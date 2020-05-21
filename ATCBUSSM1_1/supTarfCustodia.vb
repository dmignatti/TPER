Imports System.Data.SqlClient

Public Class supTarfCustodia

  Public Enum CausaleEnum As Integer
    Meno_di_12_ore = 5
    Primo_giorno = 6
    Secondo_giorno = 7
  End Enum

  Private m_intPK As Integer
  Private m_intFK_CaIm As CausaleEnum
  Private m_strDesc As String
  Private m_decImporto As Decimal
  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime

  ' *********************************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************************
  Public Sub New(ByVal intFK_CaIm As CausaleEnum, ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_intPK = 0
    m_intFK_CaIm = intFK_CaIm
    m_strDesc = GetDesc()
    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)
    Fetch()

  End Sub

  ' *********************************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************************
  Public ReadOnly Property PK() As Integer
    Get
      Return m_intPK
    End Get
  End Property

  Public ReadOnly Property FK_CaIm() As CausaleEnum
    Get
      Return m_intFK_CaIm
    End Get
  End Property

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

  Public ReadOnly Property Desc() As String
    Get
      Return m_strDesc
    End Get
  End Property

  Public Property Importo() As Decimal
    Get
      Return m_decImporto
    End Get
    Set(ByVal Value As Decimal)
      m_decImporto = Value
    End Set
  End Property

  ' *********************************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************************
  Public Function SqlCommand() As String

    If (m_intPK = 0) Then
      Return SqlInsert()
    Else
      Return SqlUpdate()
    End If

  End Function

  ' *********************************************************************************************************
  '     PRIVATE METHODS
  ' *********************************************************************************************************
  Private Sub Fetch()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "Tarf_PK, " & _
                "ISNULL(Tarf_Importo, 0) Tarf_Importo " & _
             "FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm = " & CStr(m_intFK_CaIm) & " AND " & _
                "Tarf_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121) AND " & _
                "Tarf_DataFine = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataFine) & "', 121)"

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
        m_intPK = System.Convert.ToInt32(dr("Tarf_PK"))
        m_decImporto = System.Convert.ToDecimal(dr("Tarf_Importo"))
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

  Private Function SqlInsert() As String

    Dim sSql As String = ""

    If (DateTime.Now < m_dtmDataFine) Then
      sSql = "INSERT INTO Tabl_Tariffa " & _
                  "(Tarf_FK_CaIm, " & _
                  "Tarf_FK_Peso, Tarf_FK_FOra, " & _
                  "Tarf_Desc, " & _
                  "Tarf_Importo, " & _
                  "Tarf_RincaroPerTon, Tarf_LimiteInfApp, " & _
                  "Tarf_DataInizio, " & _
                  "Tarf_DataFine) " & _
             "VALUES " & _
                  "(" & CStr(m_intFK_CaIm) & ", " & _
                  "0, 0, " & _
                  "'" & m_strDesc.Replace("'", "''") & "', " & _
                  supFunction.sqlMoney(m_decImporto) & ", " & _
                  "0, 0, " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121), " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataFine) & "', 121))"
    End If

    Return sSql

  End Function

  Private Function SqlUpdate() As String

    Dim sSql As String = ""

    If (DateTime.Now < m_dtmDataInizio) Then
      sSql = "UPDATE " & _
                  "Tabl_Tariffa " & _
             "SET " & _
                  "Tarf_Importo = " & supFunction.sqlMoney(m_decImporto) & " " & _
             "WHERE " & _
                  "Tarf_PK = " & CStr(m_intPK)
    End If

    Return sSql

  End Function

  'Private Function SqlDelete() As String

  '  Dim sSql As String = ""

  '  If (DateTime.Now < m_dtmDataInizio) Then
  '    sSql = "DELETE FROM Tabl_Tariffa " & _
  '           "WHERE " & _
  '                "Tarf_FK_CaIm = " & m_intFK_CaIm & " AND " & _
  '                "Tarf_FK_Peso = " & m_intFK_Peso & " AND " & _
  '                "Tarf_FK_FOra = " & m_intFK_FOra & " AND " & _
  '                "Tarf_DataInizio = " & supFunction.sqlDate121(m_dtmDataInizio) & "', 121) AND " & _
  '                "Tarf_DataFine= " & supFunction.sqlDate121(m_dtmDataFine) & "', 121)"
  '  End If

  '  Return sSql

  'End Function

  Private Function GetDesc() As String

    Select Case m_intFK_CaIm
      Case CausaleEnum.Meno_di_12_ore
        Return "Custodia in deposito inferiore a 12 ore"
      Case CausaleEnum.Primo_giorno
        Return "Custodia in deposito durante il primo giorno"
      Case CausaleEnum.Secondo_giorno
        Return "Custodia giornaliera in deposito oltre il primo giorno"
    End Select

  End Function

End Class
