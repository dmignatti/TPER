Imports System.Data.SqlClient

Public Class supTariffarioInfr

  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime
  Private m_Infrs As supInfrazioniCdS

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New(ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)
    m_Infrs = New supInfrazioniCdS(m_dtmDataInizio, m_dtmDataFine)

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Public ReadOnly Property CanInsert() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataFine)
    End Get
  End Property

  Public ReadOnly Property CanUpdate() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataInizio)
    End Get
  End Property

  Public ReadOnly Property CanDelete() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataInizio)
    End Get
  End Property

  Public Property DataInizio() As DateTime
    Get
      Return m_dtmDataInizio
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataInizio = Value
    End Set
  End Property

  Public Property DataFine() As DateTime
    Get
      Return m_dtmDataFine
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataFine = Value
    End Set
  End Property

  Public ReadOnly Property Infrazioni() As supInfrazioniCdS
    Get
      Return m_Infrs
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Sub Fetch()
    Fill_Infrazioni(m_Infrs, m_dtmDataInizio, m_dtmDataFine)
  End Sub

  Public Function Save() As Boolean

    Dim i As Integer
    Dim sSql As String
    Dim tr As New supTransaction

    If (m_dtmDataInizio > DateTime.Today) Then
      If CheckCodici() Then
        ' Elimino tutte le tariffe non ancora in vigore.
        tr.SqlCommands.Add(SqlDeleteOthers())
        ' Aggiorno la data di fine della tariffa in corso di validità.
        tr.SqlCommands.Add(SqlUpdateCurrentRate(m_dtmDataInizio.AddSeconds(-1)))
        ' Inserisco le nuove tariffe.
        tr.SqlCommands.Add(sSql)
        For i = 0 To m_Infrs.UBound
          tr.SqlCommands.Add(m_Infrs(i).SqlInsert)
        Next
        Return tr.Execute
      Else
        Return False
      End If
    Else
      Return False
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

  ' ****************************************************************************************
  '     PUBLIC SHARED METHODS
  ' ****************************************************************************************
  Public Shared Sub GetCurrentInterval(ByRef dtmCurrDataInizio As DateTime, ByRef dtmCurrDataFine As DateTime)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT DISTINCT " & _
                "Infr_DataInizio, Infr_DataFine " & _
             "FROM " & _
                "Angr_Infrazione " & _
             "WHERE " & _
                "Infr_DataInizio <= GETDATE() AND " & _
                "GETDATE() <= Infr_DataFine"

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
        dtmCurrDataInizio = System.Convert.ToDateTime(dr("Infr_DataInizio"))
        dtmCurrDataFine = System.Convert.ToDateTime(dr("Infr_DataFine"))
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  ' ****************************************************************************************
  '     PRIVATE METHODS
  ' ****************************************************************************************
  Private Function Get_CurrentDataInizio() As DateTime

    Dim dtmRC As DateTime
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT DISTINCT " & _
                "Infr_DataInizio " & _
             "FROM " & _
                "Angr_Infrazione " & _
             "WHERE " & _
                "Infr_DataInizio < GETDATE() AND " & _
                "GETDATE() < Infr_DataFine"

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
        dtmRC = System.Convert.ToDateTime(dr("Infr_DataInizio"))
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    Return dtmRC

  End Function

  Private Sub GetPreviousInterval(ByRef dtmPrevDataInizio As DateTime, ByRef dtmPrevDataFine As DateTime, ByVal blnForInsert As Boolean)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    If blnForInsert Then
      strSql = "SELECT TOP 1 " & _
                  "Infr_DataInizio, Infr_DataFine " & _
               "FROM " & _
                  "Angr_Infrazione " & _
               "ORDER BY " & _
                  "Infr_DataInizio DESC, Infr_DataFine DESC"
    Else
      strSql = "SELECT TOP 1 " & _
                  "Infr_DataInizio, Infr_DataFine " & _
               "FROM " & _
                  "Angr_Infrazione " & _
               "WHERE " & _
                  "Infr_DataInizio < CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121) AND " & _
                  "Infr_DataFine < CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataFine) & "', 121) " & _
               "ORDER BY " & _
                  "Infr_DataInizio DESC, Infr_DataFine DESC"
    End If

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
        dtmPrevDataInizio = System.Convert.ToDateTime(dr("Infr_DataInizio"))
        dtmPrevDataFine = System.Convert.ToDateTime(dr("Infr_DataFine"))
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  Private Sub Fill_Infrazioni(ByRef infrs As supInfrazioniCdS, ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    Dim intPK As Integer
    Dim decImporto As Decimal
    Dim strCodice, strArticolo, strDesc As String
    Dim strSql, strSqlWhere As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    infrs.Clear()

    strSql = "SELECT " & _
                "Infr_PK, " & _
                "ISNULL(Infr_Codice, '') Infr_Codice, " & _
                "ISNULL(Infr_Articolo, '') Infr_Articolo, " & _
                "ISNULL(Infr_Desc, '') Infr_Desc, " & _
                "ISNULL(Infr_Importo, 0) Infr_Importo " & _
             "FROM " & _
                "Angr_Infrazione " & _
             "WHERE " & _
                "Infr_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(dtmDataInizio) & "', 121) AND " & _
                "Infr_DataFine = CONVERT(datetime, '" & supFunction.sqlDate121(dtmDataFine) & "', 121) " & _
             "ORDER BY " & _
                "Infr_Articolo, Infr_Codice"

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
        Do While dr.Read()
          intPK = System.Convert.ToInt32(dr("Infr_PK"))
          strCodice = System.Convert.ToString(dr("Infr_Codice"))
          strArticolo = System.Convert.ToString(dr("Infr_Articolo"))
          strDesc = System.Convert.ToString(dr("Infr_Desc"))
          decImporto = System.Convert.ToDecimal(dr("Infr_Importo"))
          infrs.Add(intPK, strCodice, strArticolo, strDesc, decImporto)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  Private Function CheckCodici() As Boolean

    Dim RC As Boolean
    Dim i, j As Integer

    RC = True
    For i = 0 To m_Infrs.UBound
      For j = 0 To m_Infrs.UBound
        If ((i <> j) And (m_Infrs(i).Codice = m_Infrs(j).Codice)) Then
          RC = False
          Exit For
        End If
      Next
    Next

    Return RC

  End Function

  Private Function SqlUpdateCurrentRate(ByVal dtmNewDataFine As DateTime) As String

    Dim strSql As String
    Dim dtmCurrDataInizio As DateTime = Get_CurrentDataInizio()

    strSql = "UPDATE " & _
                "Angr_Infrazione " & _
             "SET " & _
                "Infr_DataFine = CONVERT(datetime, '" & supFunction.sqlDate121(dtmNewDataFine) & "', 121) " & _
             "WHERE " & _
                "Infr_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(dtmCurrDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteThisRate() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Angr_Infrazione " & _
             "WHERE " & _
                "Infr_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteOthers() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Angr_Infrazione " & _
           "WHERE " & _
                "Infr_DataInizio > GETDATE()"
    Return strSql

  End Function

End Class
