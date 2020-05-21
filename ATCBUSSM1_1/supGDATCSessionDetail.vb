Imports System.Data.SqlClient

Public Class supGDATCSessionDetail

  Private m_intSessionPK As String
  Private m_Logs As supGDATCSessionLogs

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal intSessionPK As Integer)

    m_intSessionPK = intSessionPK
    m_Logs = New supGDATCSessionLogs(intSessionPK)
    Fetch()

  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Public ReadOnly Property SessionPK() As Integer
    Get
      Return m_intSessionPK
    End Get
  End Property

  Public ReadOnly Property Logs() As supGDATCSessionLogs
    Get
      Return m_Logs
    End Get
  End Property

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Private Sub Fetch()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim strUserID, strUserName, strComputerName, strAction, strDBTable, strDBRecord, strPayment, strMoney As String
    Dim dtmTime As DateTime

    m_Logs.Clear()

    strSql = "SELECT " & _
                "LSes_UserLogin, " & _
                "ISNULL(LSes_UserName, '') LSes_UserName, " & _
                "ISNULL(LSes_ClientID, '') LSes_ClientID, " & _
                "LSes_DataOra, " & _
                "ISNULL(LSes_Azione, '') LSes_Azione, " & _
                "ISNULL(LSes_Tabella, '') LSes_Tabella, " & _
                "ISNULL(LSes_Mode, '') LSes_Mode, " & _
                "ISNULL(LSes_RecordID, 0) LSes_RecordID, " & _
                "ISNULL(MoPa_Desc, '') MoPa_Desc, " & _
                "ISNULL(LSes_Importo, 0) LSes_Importo " & _
             "FROM " & _
                "Log_Sessione LEFT OUTER JOIN Angr_ModalitaPagamento " & _
                "ON LSes_FK_MoPa = MoPa_PK " & _
             "WHERE " & _
                "LSes_FK_Sess = " & m_intSessionPK & " " & _
             "ORDER BY " & _
                "LSes_DataOra ASC"

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
        Do While dr.Read
          strUserID = System.Convert.ToString(dr("LSes_UserLogin"))
          strUserName = System.Convert.ToString(dr("LSes_UserName"))
          strComputerName = System.Convert.ToString(dr("LSes_ClientID"))
          dtmTime = System.Convert.ToDateTime(dr("LSes_DataOra"))
          strAction = System.Convert.ToString(dr("LSes_Azione"))
          strDBTable = System.Convert.ToString(dr("LSes_Tabella"))
          strDBRecord = System.Convert.ToString(dr("LSes_Mode")) & " " & System.Convert.ToInt32(dr("LSes_RecordID"))
          strPayment = System.Convert.ToString(dr("MoPa_Desc"))
          strMoney = System.Convert.ToString(dr("LSes_Importo"))
          m_Logs.Add(strUserID, strUserName, strComputerName, dtmTime, strAction, strDBTable, strDBRecord, strPayment, strMoney)
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

End Class
