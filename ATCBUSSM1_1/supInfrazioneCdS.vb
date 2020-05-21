Imports System.Data.SqlClient

Public Class supInfrazioneCdS

  Private m_intPK As Integer
  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime

  Private m_strCodice As String
  Private m_strArticolo As String
  Private m_strDesc As String
  Private m_decImporto As Decimal

  ' ***************************************************************************************************
  '     CREATION METHODS
  ' ***************************************************************************************************
  Public Sub New(ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)

  End Sub

  Public Sub New(ByVal intPK As Integer, ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_intPK = intPK
    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)

  End Sub

  ' ***************************************************************************************************
  '     PROPERTIES
  ' ***************************************************************************************************
  Public ReadOnly Property PK() As Integer
    Get
      Return m_intPK
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

  Public Property Codice() As String
    Get
      Return m_strCodice
    End Get
    Set(ByVal Value As String)
      m_strCodice = Value.Trim
    End Set
  End Property

  Public Property Articolo() As String
    Get
      Return m_strArticolo
    End Get
    Set(ByVal Value As String)
      m_strArticolo = Value.Trim
    End Set
  End Property

  Public Property Desc() As String
    Get
      Return m_strDesc
    End Get
    Set(ByVal Value As String)
      m_strDesc = Value.Trim
    End Set
  End Property

  Public Property Importo() As Decimal
    Get
      Return m_decImporto
    End Get
    Set(ByVal Value As Decimal)
      m_decImporto = Value
    End Set
  End Property

  ' ***************************************************************************************************
  '     PUBLIC METHODS
  ' ***************************************************************************************************
  Public Function SqlInsert() As String

    Dim sSql As String = ""

    If (DateTime.Now < m_dtmDataFine) Then
      sSql = "INSERT INTO Angr_Infrazione " & _
                  "(Infr_Codice, " & _
                  "Infr_Articolo, " & _
                  "Infr_Desc, " & _
                  "Infr_Importo, " & _
                  "Infr_DataInizio, " & _
                  "Infr_DataFine, " & _
                  "UserInsert) " & _
             "VALUES " & _
                  "('" & m_strCodice.Replace("'", "''") & "', " & _
                  "'" & m_strArticolo.Replace("'", "''") & "', " & _
                  "'" & m_strDesc.Replace("'", "''") & "', " & _
                  supFunction.sqlMoney(m_decImporto) & ", " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121), " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataFine) & "', 121), " & _
                  "1)"
    End If

    Return sSql

  End Function

  Public Function SqlInsertSingle() As String

    If CheckCodice(True) Then
      Return SqlInsert()
    Else
      Return ""
    End If

  End Function

  Public Function SqlUpdate() As String

    Dim sSql As String = ""

    If (DateTime.Now < m_dtmDataInizio) Then
      If CheckCodice(False) Then
        sSql = "UPDATE " & _
                    "Angr_Infrazione " & _
               "SET " & _
                    "Infr_Codice = '" & m_strCodice.Replace("'", "''") & "', " & _
                    "Infr_Articolo = '" & m_strArticolo.Replace("'", "''") & "', " & _
                    "Infr_Desc = '" & m_strDesc.Replace("'", "''") & "', " & _
                    "Infr_Importo = " & supFunction.sqlMoney(m_decImporto) & ", " & _
                    "Infr_UserInsert = 1 " & _
               "WHERE " & _
                    "Infr_PK = " & m_intPK
      End If
    End If

    Return sSql

  End Function

  Public Function SqlDelete() As String

    Dim sSql As String = ""

    If (DateTime.Now < m_dtmDataInizio) Then
      sSql = "DELETE FROM Angr_Infrazione WHERE Infr_PK = " & m_intPK
    End If

    Return sSql

  End Function

  Private Function CheckCodice(ByVal blnForInsert As Boolean) As Boolean

    Dim blnRC As Boolean
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "Infr_PK " & _
             "FROM " & _
                "Angr_Infrazione " & _
             "WHERE " & _
                "Infr_Codice = '" & m_strCodice.Replace("'", "''") & "' AND " & _
                "Infr_DataInizio = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataInizio) & "', 121) AND " & _
                "Infr_DataFine = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataFine) & "', 121)"

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
        If blnForInsert Then
          blnRC = False
        Else
          dr.Read()
          blnRC = (System.Convert.ToInt32(dr("Infr_PK")) = m_intPK)
        End If
      Else
        blnRC = True
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento dei tipi di documento.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    Return blnRC

  End Function

End Class
