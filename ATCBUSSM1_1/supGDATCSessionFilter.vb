Imports System.Data.SqlClient

Public Class supGDATCSessionFilter

  Private m_dtmDateBegin, m_dtmDateEnd As DateTime
  Private m_Days As supGDATCSessionDays

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    m_Days = New supGDATCSessionDays(dtmDateBegin, dtmDateEnd)

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Public ReadOnly Property DateBegin() As DateTime
    Get
      Return m_dtmDateBegin
    End Get
  End Property

  Public ReadOnly Property DateEnd() As DateTime
    Get
      Return m_dtmDateEnd
    End Get
  End Property

  Public ReadOnly Property Days() As supGDATCSessionDays
    Get
      Return m_Days
    End Get
  End Property

  Public ReadOnly Property Total_BancRimz() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim day As supGDATCSessionDay
      For Each day In m_Days
        decTotal = decTotal + day.Total_BancRimz
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_BancInfr() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim day As supGDATCSessionDay
      For Each day In m_Days
        decTotal = decTotal + day.Total_BancInfr
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_CashRimz() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim day As supGDATCSessionDay
      For Each day In m_Days
        decTotal = decTotal + day.Total_CashRimz
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_CashInfr() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim day As supGDATCSessionDay
      For Each day In m_Days
        decTotal = decTotal + day.Total_CashInfr
      Next
      Return decTotal
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Sub Fetch()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim intPK, intFK_User As Integer
    Dim strUserID, strUserName, strComputerName, strState, strNotes As String
    Dim dtmDateOpen, dtmDateClose As DateTime
    Dim decBancRimz, decBancInfr, decCashRimz, decCashInfr As Decimal

    strSql = "SELECT " & _
                "Sess_PK, Sess_FK_User, " & _
                "ISNULL(Sess_UserLogin, '') Sess_UserLogin, " & _
                "ISNULL(Sess_UserName, '') Sess_UserName, " & _
                "ISNULL(Sess_ClientID, '') Sess_ClientID, " & _
                "Sess_DateOpen, Sess_DateClose, " & _
                "Sess_BancRimz, Sess_BancInfr, " & _
                "Sess_CashRimz, Sess_CashInfr, " & _
                "ISNULL(Sess_State, '') Sess_State, " & _
                "ISNULL(Sess_Notes, '') Sess_Notes " & _
             "FROM " & _
                "Tabl_Sessione " & _
             "WHERE " & _
                "Sess_DateOpen >= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateBegin) & "', 112) AND " & _
                "Sess_DateOpen < CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateEnd.AddDays(1)) & "', 112) " & _
             "ORDER BY " & _
                "Sess_DateOpen, Sess_DateClose, Sess_UserName"

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
          intPK = System.Convert.ToInt32(dr("Sess_PK"))
          intFK_User = System.Convert.ToInt32(dr("Sess_FK_User"))
          strUserID = System.Convert.ToString(dr("Sess_UserLogin"))
          strUserName = System.Convert.ToString(dr("Sess_UserName"))
          strComputerName = System.Convert.ToString(dr("Sess_ClientID"))
          dtmDateOpen = System.Convert.ToDateTime(dr("Sess_DateOpen"))
          dtmDateClose = System.Convert.ToDateTime(dr("Sess_DateClose"))
          decBancRimz = System.Convert.ToDecimal(dr("Sess_BancRimz"))
          decBancInfr = System.Convert.ToDecimal(dr("Sess_BancInfr"))
          decCashRimz = System.Convert.ToDecimal(dr("Sess_CashRimz"))
          decCashInfr = System.Convert.ToDecimal(dr("Sess_CashInfr"))
          strState = System.Convert.ToString(dr("Sess_State"))
          strNotes = System.Convert.ToString(dr("Sess_Notes"))
          Dim Index As Integer = DateDiff(DateInterval.Day, m_dtmDateBegin, dtmDateOpen)
          Dim day As supGDATCSessionDay = m_Days(Index)
          If Not (day Is Nothing) Then
            day.Recordset.Add(intPK, intFK_User, strUserID, strUserName, strComputerName, dtmDateOpen, dtmDateClose, decBancRimz, decBancInfr, decCashRimz, decCashInfr, strState, strNotes)
          End If
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
