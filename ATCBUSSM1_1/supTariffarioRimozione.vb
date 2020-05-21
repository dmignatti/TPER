Imports System.Data.SqlClient

Public Class supTariffarioRimozione

  Private m_Tarf_111 As supTariffa
  Private m_Tarf_112 As supTariffa
  Private m_Tarf_121 As supTariffa
  Private m_Tarf_122 As supTariffa
  Private m_Tarf_131 As supTariffa
  Private m_Tarf_132 As supTariffa

  Private m_Tarf_211 As supTariffa
  Private m_Tarf_212 As supTariffa
  Private m_Tarf_221 As supTariffa
  Private m_Tarf_222 As supTariffa
  Private m_Tarf_231 As supTariffa
  Private m_Tarf_232 As supTariffa

  Private m_Tarf_311 As supTariffa
  Private m_Tarf_312 As supTariffa
  Private m_Tarf_321 As supTariffa
  Private m_Tarf_322 As supTariffa
  Private m_Tarf_331 As supTariffa
  Private m_Tarf_332 As supTariffa

  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime

  ' *********************************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************************
  Public Sub New(ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)

    m_Tarf_111 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_112 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_121 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_122 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_131 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_132 = New supTariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)

    m_Tarf_211 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_212 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_221 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_222 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_231 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_232 = New supTariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)

    m_Tarf_311 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_312 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_321 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_322 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_331 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali, m_dtmDataInizio, m_dtmDataFine)
    m_Tarf_332 = New supTariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi, m_dtmDataInizio, m_dtmDataFine)

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

  Public ReadOnly Property Tariffa(ByVal CauImp As supTariffa.CausaleEnum, ByVal CatPes As supTariffa.CategoriaPesoEnum, ByVal FasOra As supTariffa.FasciaOrariaEnum) As supTariffa
    Get
      Select Case CauImp
        Case supTariffa.CausaleEnum.DirittoChiamata
          Select Case CatPes
            Case supTariffa.CategoriaPesoEnum.FinoA15
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_111
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_112
              End Select
            Case supTariffa.CategoriaPesoEnum.FinoA35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_121
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_122
              End Select
            Case supTariffa.CategoriaPesoEnum.Oltre35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_131
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_132
              End Select
          End Select
        Case supTariffa.CausaleEnum.Rimozione
          Select Case CatPes
            Case supTariffa.CategoriaPesoEnum.FinoA15
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_211
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_212
              End Select
            Case supTariffa.CategoriaPesoEnum.FinoA35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_221
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_222
              End Select
            Case supTariffa.CategoriaPesoEnum.Oltre35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_231
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_232
              End Select
          End Select
        Case supTariffa.CausaleEnum.Trasporto
          Select Case CatPes
            Case supTariffa.CategoriaPesoEnum.FinoA15
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_311
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_312
              End Select
            Case supTariffa.CategoriaPesoEnum.FinoA35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_321
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_322
              End Select
            Case supTariffa.CategoriaPesoEnum.Oltre35
              Select Case FasOra
                Case supTariffa.FasciaOrariaEnum.DiurnaFeriali
                  Return m_Tarf_331
                Case supTariffa.FasciaOrariaEnum.NotturnaEFestivi
                  Return m_Tarf_332
              End Select
          End Select
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
      ' Inserisco/Aggiorno le tariffe del "Diritto di chiamata".
      tr.SqlCommands.Add(m_Tarf_111.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_112.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_121.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_122.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_131.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_132.SqlCommand())
      ' Inserisco/Aggiorno le tariffe delle "Operazioni connesse alla rimozione".
      tr.SqlCommands.Add(m_Tarf_211.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_212.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_221.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_222.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_231.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_232.SqlCommand())
      ' Inserisco/Aggiorno le tariffe del "Trasporto"
      tr.SqlCommands.Add(m_Tarf_311.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_312.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_321.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_322.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_331.SqlCommand())
      tr.SqlCommands.Add(m_Tarf_332.SqlCommand())
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
                "Tarf_FK_CaIm = 1 AND " & _
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
      Throw New Exception("Errore di accesso ai dati.")
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
                "Tarf_FK_CaIm IN (1, 2, 3) AND " & _
                "Tarf_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(dtmCurrDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteThisRate() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm IN (1, 2, 3) AND " & _
                "Tarf_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121)"
    Return strSql

  End Function

  Private Function SqlDeleteOthers() As String

    Dim strSql As String

    strSql = "DELETE FROM " & _
                "Tabl_Tariffa " & _
            "WHERE " & _
                "Tarf_FK_CaIm IN (1, 2, 3) AND " & _
                "Tarf_DataInizio > GETDATE() AND " & _
                "Tarf_DataInizio <> CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121)"
    Return strSql

  End Function

End Class
