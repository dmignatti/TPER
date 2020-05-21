Imports System.Data.SqlClient

Public Class supRpt1

  Protected m_intFK_User As Integer
  Protected m_dtmDateBegin As DateTime
  Protected m_dtmDateEnd As DateTime
  Protected m_Users As supRpt1Users

  Protected m_decTotRimzBanc As Decimal
  Protected m_decTotRimzCash As Decimal
  Protected m_decTotInfrBanc As Decimal
  Protected m_decTotInfrCash As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_intFK_User = 0
    m_dtmDateBegin = New DateTime(dtmDateBegin.Year, dtmDateBegin.Month, dtmDateBegin.Day, 0, 0, 0)
    m_dtmDateEnd = New DateTime(dtmDateEnd.Year, dtmDateEnd.Month, dtmDateEnd.Day, 23, 59, 59)
    m_Users = New supRpt1Users
    m_decTotRimzBanc = -1
    m_decTotRimzCash = -1
    m_decTotInfrBanc = -1
    m_decTotInfrCash = -1

  End Sub

  Public Sub New(ByVal intFK_User As Integer, ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_intFK_User = intFK_User
    m_dtmDateBegin = New DateTime(dtmDateBegin.Year, dtmDateBegin.Month, dtmDateBegin.Day, 0, 0, 0)
    m_dtmDateEnd = New DateTime(dtmDateEnd.Year, dtmDateEnd.Month, dtmDateEnd.Day, 23, 59, 59)
    m_Users = New supRpt1Users
    m_decTotRimzBanc = -1
    m_decTotRimzCash = -1
    m_decTotInfrBanc = -1
    m_decTotInfrCash = -1

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property FK_User() As Integer
    Get
      Return m_intFK_User
    End Get
  End Property

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

  Public ReadOnly Property Users() As supRpt1Users
    Get
      Return m_Users
    End Get
  End Property

  Public ReadOnly Property TotRimzBanc() As Decimal
    Get
      If (m_decTotRimzBanc = -1) Then
        getTotal()
      End If
      Return m_decTotRimzBanc
    End Get
  End Property

  Public ReadOnly Property TotRimzCash() As Decimal
    Get
      If (m_decTotRimzCash = -1) Then
        getTotal()
      End If
      Return m_decTotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotInfrBanc() As Decimal
    Get
      If (m_decTotInfrBanc = -1) Then
        getTotal()
      End If
      Return m_decTotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotInfrCash() As Decimal
    Get
      If (m_decTotInfrCash = -1) Then
        getTotal()
      End If
      Return m_decTotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotInfr() As Decimal
    Get
      Return TotInfrBanc + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotRimz() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotBanc() As Decimal
    Get
      Return TotRimzBanc + TotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotCash() As Decimal
    Get
      Return TotRimzCash + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash + TotInfrBanc + TotInfrCash
    End Get
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Sub Fetch()

    Dim strSql As String

    strSql = "SELECT " & _
                  "LSes_PK AS XProg, " & _
                  "LSes_FK_Sess AS XSessionID, " & _
                  "LSes_FK_User AS XFK_User, " & _
                  "LSes_FK_MoPa AS XMoPa, " & _
                  "dbo.GetDay(LSes_DataOra) AS XDate, " & _
                  "dbo.GetHour(LSes_DataOra) AS XTime, " & _
                  "LSes_Azione AS XDesc, " & _
                  "LSes_Importo AS XTotal, " & _
                  "(CASE " & _
                        "WHEN (LSes_Tabella = 'Angr_VerbaleCdS') THEN 1 " & _
                        "WHEN (LSes_Tabella = 'Angr_VeicoloRTR') THEN 2 " & _
                        "ELSE 3 " & _
                  "END) AS XFlag " & _
             "FROM " & _
                  "Log_Sessione " & _
             "WHERE " & _
                "LSes_Importo <> 0 AND " & _
                "LSes_DataOra >= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateBegin) & "', 121) AND " & _
                "LSes_DataOra < CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateEnd) & "', 121)"

    If (m_intFK_User > 0) Then
      strSql = strSql & " AND LSes_FK_User = " & CStr(m_intFK_User)
    End If

    strSql = "SELECT " & _
                  "B.User_LoginName AS XUserCode, " & _
                  "(B.User_LastName + ' ' + B.User_FirstName) AS XUserName, " & _
                  "A.XProg, A.XSessionID, A.XDate, A.XTime, A.XDesc, A.XTotal, A.XFlag, A.XMoPa " & _
             "FROM " & _
                  "(" & strSql & ") A " & _
                  "INNER JOIN Angr_User B ON A.XFK_User = B.User_PK " & _
             "ORDER BY " & _
                  "XUserName, XDate, XSessionID, XTime, XProg"

    m_Users.Clear()
    Fill(strSql)

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Sub Fill(ByVal strSql As String)

    Dim intTempSessionID As Integer = 0
    Dim intTempUserCode As String = ""
    Dim dtmTempDate As New DateTime(9999, 12, 31)
    Dim tmpUser As supRpt1User
    Dim tmpDay As supRpt1Day
    Dim tmpSession As supRpt1Session

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader()

    If dr.HasRows Then
      Do While dr.Read
        If (intTempUserCode <> dr("XUserCode")) Then
          tmpUser = m_Users.Add(dr("XUserCode"), dr("XUserName"))
          intTempUserCode = dr("XUserCode")
          dtmTempDate = New DateTime(9999, 12, 31)
          intTempSessionID = 0
        End If
        If (dtmTempDate <> dr("XDate")) Then
          tmpDay = tmpUser.Days.Add(dr("XDate"))
          dtmTempDate = dr("XDate")
          intTempSessionID = 0
        End If
        If (intTempSessionID <> dr("XSessionID")) Then
          tmpSession = tmpDay.Sessions.Add(dr("XSessionID"), tmpDay.DayValue)
          intTempSessionID = dr("XSessionID")
        End If
        tmpSession.Details.Add(dr("XTime"), dr("XDesc"), dr("XFlag"), dr("XMoPa"), dr("XTotal"))
      Loop
    End If

    dr.Close()
    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()

  End Sub

  Protected Sub getTotal()

    Dim i As Integer

    m_decTotRimzBanc = 0
    m_decTotRimzCash = 0
    m_decTotInfrBanc = 0
    m_decTotInfrCash = 0

    For i = 0 To m_Users.UBound
      m_decTotRimzBanc = m_decTotRimzBanc + m_Users(i).TotRimzBanc
      m_decTotRimzCash = m_decTotRimzCash + m_Users(i).TotRimzCash
      m_decTotInfrBanc = m_decTotInfrBanc + m_Users(i).TotInfrBanc
      m_decTotInfrCash = m_decTotInfrCash + m_Users(i).TotInfrCash
    Next

  End Sub

End Class
