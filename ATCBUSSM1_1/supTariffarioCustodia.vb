Imports System.Data.SqlClient

Public Class supTariffarioCustodia

  Private m_Tarf_5 As supTarfCustodia
  Private m_Tarf_6 As supTarfCustodia
  Private m_Tarf_7 As supTarfCustodia

  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime

  ' *********************************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************************
  Public Sub New(ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)

    m_Tarf_5 = New supTarfCustodia(supTarfCustodia.CausaleEnum.Meno_di_12_ore, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_6 = New supTarfCustodia(supTarfCustodia.CausaleEnum.Primo_giorno, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_7 = New supTarfCustodia(supTarfCustodia.CausaleEnum.Secondo_giorno, m_dtmDataInizio, m_dtmDataFine)

  End Sub

  ' *********************************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************************
  Public ReadOnly Property DataInizio() As DateTime
    Get
      Return m_dtmDataInizio
    End Get
  End Property

  Public ReadOnly Property DataFine() As DateTime
    Get
      Return m_dtmDataFine
    End Get
  End Property

  Public ReadOnly Property Tariffa(ByVal CauImp As supTarfCustodia.CausaleEnum) As supTarfCustodia
    Get
      Select Case CauImp
        Case supTarfCustodia.CausaleEnum.Meno_di_12_ore
          Return m_Tarf_5
        Case supTarfCustodia.CausaleEnum.Primo_giorno
          Return m_Tarf_6
        Case supTarfCustodia.CausaleEnum.Secondo_giorno
          Return m_Tarf_7
      End Select
    End Get
  End Property

  ' *********************************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************************
  Public Function Save() As Boolean

    If (m_dtmDataInizio > DateTime.Today) Then
      Dim tr As New supTransaction
      ' Se l'utente ha cambiato la data di inizio validità, per l'applicazione è una nuova tariffa,
      ' quindi elimino tutte le altre non ancora in vigore.
      tr.SqlCommands.Add(SqlDeleteOthers())
      ' Aggiorno la data di fine della tariffa in corso di validità.
      tr.SqlCommands.Add(SqlUpdateCurrentRate(m_dtmDataInizio.AddSeconds(-1)))
      ' Inserisco/Aggiorno la tariffa della "Custodia 12 ore".
      tr.SqlCommands.Add(m_Tarf_5.SqlCommand())
      ' Inserisco/Aggiorno la tariffa della "Custodia primo giorno".
      tr.SqlCommands.Add(m_Tarf_6.SqlCommand())
      ' Inserisco/Aggiorno la tariffa della "Custodia secondo giorno".
      tr.SqlCommands.Add(m_Tarf_7.SqlCommand())
      ' Eseguo la ransazione.
      Return tr.Execute()
    Else
      Throw New Exception("Il tariffario non può entrare in vigore prima di domani.")
    End If

  End Function

  Public Function Delete() As Boolean

    If (DateTime.Now < m_dtmDataInizio) Then
      Dim tr As New supTransaction
      ' Riporto la data di fine della tariffa in corso di validità al valore infinito.
      Dim dtmInfinity As New DateTime(9999, 12, 31, 23, 59, 59)
      tr.SqlCommands.Add(SqlUpdateCurrentRate(dtmInfinity))
      ' Cancello il tariffario (l'unico ancora non applicato).
      tr.SqlCommands.Add(SqlDeleteThisRate())
      Return tr.Execute()
    Else
      Throw New Exception("Il tariffario non può essere cancellato, poiché già in vigore.")
    End If

  End Function

  ' *********************************************************************************************************
  '     PRIVATE METHODS
  ' *********************************************************************************************************
  Private Function Get_CurrentDataInizio() As DateTime

    Dim dtmRC As DateTime
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT DISTINCT " & _
                "Tarf_DataInizio " & _
             "FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm = 5 AND " & _
                "Tarf_DataInizio < GETDATE() AND " & _
                "GETDATE() < Tarf_DataFine"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
    End Try

    cmd = New SqlCommand(strSql, cnn)
    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        dtmRC = System.Convert.ToDateTime(dr("Tarf_DataInizio"))
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento dei tipi di documento.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    Return dtmRC

  End Function

  Private Function SqlUpdateCurrentRate(ByVal dtmNewDataFine As DateTime) As String

    Dim strSql As String
    Dim dtmCurrDataInizio As DateTime = Get_CurrentDataInizio()

    strSql = "UPDATE " & _
                "Tabl_Tariffa " & _
             "SET " & _
                "Tarf_DataFine = CONVERT(datetime, '" & supFunction.sqlDate121(dtmNewDataFine) & "', 121) " & _
             "WHERE " & _
                "Tarf_FK_CaIm IN (5, 6, 7) AND " & _
                "Tarf_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(dtmCurrDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteThisRate() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Tabl_Tariffa " & _
           "WHERE " & _
                "Tarf_FK_CaIm IN (5, 6, 7) AND " & _
                "Tarf_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteOthers() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Tabl_Tariffa " & _
           "WHERE " & _
                "Tarf_FK_CaIm IN (5, 6, 7) AND " & _
                "Tarf_DataInizio > GETDATE() AND " & _
                "Tarf_DataInizio <> CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121)"
    Return strSql

  End Function

End Class
