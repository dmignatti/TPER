Imports System.Data.SqlClient

Public Class supStatData

  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_Dets As supStatDetails

  Private m_intTotalIn_SevenTwenty As Integer
  Private m_intTotalIn_TwentyZero As Integer
  Private m_intTotalIn_ZeroSeven As Integer
  Private m_intTotalOut_SevenTwenty As Integer
  Private m_intTotalOut_TwentyZero As Integer
  Private m_intTotalOut_ZeroSeven As Integer
  Private m_intTotal_StreetWashing As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateEnd As DateTime)

    m_dtmDateBegin = DayZero
    m_dtmDateEnd = dtmDateEnd
    m_Dets = New supStatDetails(m_dtmDateBegin, m_dtmDateEnd)

    m_intTotalIn_SevenTwenty = 0
    m_intTotalIn_TwentyZero = 0
    m_intTotalIn_ZeroSeven = 0
    m_intTotalOut_SevenTwenty = 0
    m_intTotalOut_TwentyZero = 0
    m_intTotalOut_ZeroSeven = 0
    m_intTotal_StreetWashing = 0

  End Sub

  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    m_Dets = New supStatDetails(m_dtmDateBegin, m_dtmDateEnd)

    m_intTotalIn_SevenTwenty = 0
    m_intTotalIn_TwentyZero = 0
    m_intTotalIn_ZeroSeven = 0
    m_intTotalOut_SevenTwenty = 0
    m_intTotalOut_TwentyZero = 0
    m_intTotalOut_ZeroSeven = 0
    m_intTotal_StreetWashing = 0

  End Sub

  ' ***********************************************************************************************
  '     SHARED PROPERTIES
  ' ***********************************************************************************************
  Public Shared ReadOnly Property DayZero() As DateTime
    Get
      Return New DateTime(2001, 10, 15)
    End Get
  End Property

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
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

  Public ReadOnly Property DayCount() As Integer
    Get
      Return DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd) + 1
    End Get
  End Property

  Public ReadOnly Property HolidayCount() As Integer
    Get
      Return pGet_HolidayCount()
    End Get
  End Property

  Public ReadOnly Property StreetWashingCount() As Integer
    Get
      Return Get_StreetWashingDayCount()
    End Get
  End Property

  Public ReadOnly Property TotalIn_SevenTwenty() As Integer
    Get
      Return m_intTotalIn_SevenTwenty
    End Get
  End Property

  Public ReadOnly Property TotalIn_TwentyZero() As Integer
    Get
      Return m_intTotalIn_TwentyZero
    End Get
  End Property

  Public ReadOnly Property TotalIn_ZeroSeven() As Integer
    Get
      Return m_intTotalIn_ZeroSeven
    End Get
  End Property

  Public ReadOnly Property TotalOut_SevenTwenty() As Integer
    Get
      Return m_intTotalOut_SevenTwenty
    End Get
  End Property

  Public ReadOnly Property TotalOut_TwentyZero() As Integer
    Get
      Return m_intTotalOut_TwentyZero
    End Get
  End Property

  Public ReadOnly Property TotalOut_ZeroSeven() As Integer
    Get
      Return m_intTotalOut_ZeroSeven
    End Get
  End Property

  Public ReadOnly Property TotalIn() As Integer
    Get
      Return m_intTotalIn_SevenTwenty + m_intTotalIn_TwentyZero + m_intTotalIn_ZeroSeven
    End Get
  End Property

  Public ReadOnly Property TotalOut() As Integer
    Get
      Return m_intTotalOut_SevenTwenty + m_intTotalOut_TwentyZero + m_intTotalOut_ZeroSeven
    End Get
  End Property

  Public ReadOnly Property Total_StreetWashing() As Integer
    Get
      Return m_intTotal_StreetWashing
    End Get
  End Property

  Public ReadOnly Property AverageIn() As Decimal
    Get

      Dim decTotal As Decimal = System.Convert.ToDecimal(TotalIn)
      Dim decDenominator As Decimal = DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd) + 1
      If (decDenominator = 0) Then
        Return supFunction.Round(0, 2)
      Else
        Return supFunction.Round(decTotal / decDenominator, 2)
      End If

    End Get
  End Property

  Public ReadOnly Property AverageOut() As Decimal
    Get

      Dim decTotal As Decimal = System.Convert.ToDecimal(TotalOut)
      Dim decDenominator As Decimal = DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd) + 1
      If (decDenominator = 0) Then
        Return supFunction.Round(0, 2)
      Else
        Return supFunction.Round(decTotal / decDenominator, 2)
      End If

    End Get
  End Property

  Public ReadOnly Property AverageStreetWashing() As Decimal
    Get

      Dim decTotal As Decimal = System.Convert.ToDecimal(m_intTotal_StreetWashing)
      Dim decDenominator As Decimal = Get_StreetWashingDayCount()
      If (decDenominator = 0) Then
        Return supFunction.Round(0, 2)
      Else
        Return supFunction.Round(decTotal / decDenominator, 2)
      End If

    End Get
  End Property

  Public ReadOnly Property Details() As supStatDetails
    Get
      Return m_Dets
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub Fetch()

    Fetch_In()
    Fetch_Out()

  End Sub

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Sub Fetch_In()

    Dim dtmDay As DateTime
    Dim blnIsHoliday, blnStreetWashing As Boolean
    Dim intDayZone, intNumber As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "(10000*Year(Rimz_DataIngresso)+100*Month(Rimz_DataIngresso)+Day(Rimz_DataIngresso)) Data, " & _
                "(CASE " & _
                "WHEN ((DATEPART(hour,Rimz_DataIngresso)>=7) AND (DATEPART(hour,Rimz_DataIngresso)<20)) THEN 1 " & _
                "WHEN ((DATEPART(hour,Rimz_DataIngresso)>=20) AND (DATEPART(hour,Rimz_DataIngresso)<24)) THEN 2 " & _
                "WHEN ((DATEPART(hour,Rimz_DataIngresso)>=0) AND (DATEPART(hour,Rimz_DataIngresso)<7)) THEN 3 " & _
                "END) FasciaOraria " & _
             "FROM " & _
                "(" & Get_SqlBaseIn() & ") X"

    strSql = "SELECT " & _
                "A.*, " & _
                "(CASE WHEN (CaSe_Data IS NULL) THEN 0 ELSE 1 END) StreetWashing, " & _
                "(CASE WHEN (Fest_Data IS NULL) THEN 0 ELSE 1 END) IsHoliday " & _
             "FROM " & _
                "(SELECT " & _
                    "FasciaOraria, " & _
                    "CONVERT(datetime, CAST(Data AS varchar(8)), 112) Data, " & _
                    "COUNT(*) SubTotal " & _
                "FROM " & _
                    "(" & strSql & ") Y " & _
                "GROUP BY " & _
                    "FasciaOraria, Data) A " & _
                "LEFT OUTER JOIN (" & Get_SqlHolidays() & ") B ON A.Data = B.Fest_Data " & _
                "LEFT OUTER JOIN (" & Get_SqlStreetWashing() & ") C ON A.Data = C.CaSe_Data " & _
           "ORDER BY " & _
                "Data, FasciaOraria"

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
          intDayZone = System.Convert.ToInt32(dr("FasciaOraria"))
          intNumber = System.Convert.ToInt32(dr("SubTotal"))
          dtmDay = System.Convert.ToDateTime(dr("Data"))
          blnIsHoliday = System.Convert.ToBoolean(dr("IsHoliday"))
          blnStreetWashing = System.Convert.ToBoolean(dr("StreetWashing"))
          Select Case intDayZone
            Case 1
              m_Dets(dtmDay).NumberIn_SevenTwenty = intNumber
              m_intTotalIn_SevenTwenty = m_intTotalIn_SevenTwenty + intNumber
            Case 2
              m_Dets(dtmDay).NumberIn_TwentyZero = intNumber
              m_intTotalIn_TwentyZero = m_intTotalIn_TwentyZero + intNumber
            Case 3
              m_Dets(dtmDay).NumberIn_ZeroSeven = intNumber
              m_intTotalIn_ZeroSeven = m_intTotalIn_ZeroSeven + intNumber
              If blnStreetWashing Then
                m_intTotal_StreetWashing = m_intTotal_StreetWashing + intNumber
              End If
          End Select
          m_Dets(dtmDay).IsHoliday = blnIsHoliday
          m_Dets(dtmDay).StreetWashing = blnStreetWashing
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

  Private Sub Fetch_Out()

    Dim dtmDay As DateTime
    Dim intDayZone, intNumber As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "(10000 * Year(Rimz_DataUscita) + 100 * Month(Rimz_DataUscita) + Day(Rimz_DataUscita)) Data, " & _
                "(CASE " & _
                "WHEN ((DATEPART(hour, Rimz_DataUscita) >= 7) AND (DATEPART(hour, Rimz_DataUscita) < 20)) THEN 1 " & _
                "WHEN ((DATEPART(hour, Rimz_DataUscita) >= 20) AND (DATEPART(hour, Rimz_DataUscita) < 24)) THEN 2 " & _
                "WHEN ((DATEPART(hour, Rimz_DataUscita) >= 0) AND (DATEPART(hour, Rimz_DataUscita) < 7)) THEN 3 " & _
                "END) FasciaOraria " & _
           "FROM " & _
                "(" & Get_SqlBaseOut() & ") X"

    strSql = "SELECT " & _
                "FasciaOraria, " & _
                "CONVERT(datetime, CAST(Data AS varchar(8)), 112) Data, " & _
                "COUNT(*) SubTotal " & _
           "FROM " & _
                "(" & strSql & ") A " & _
           "GROUP BY " & _
                "FasciaOraria, Data " & _
           "ORDER BY " & _
                "Data, FasciaOraria"

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
          intDayZone = System.Convert.ToInt32(dr("FasciaOraria"))
          intNumber = System.Convert.ToInt32(dr("SubTotal"))
          dtmDay = System.Convert.ToDateTime(dr("Data"))
          Select Case intDayZone
            Case 1
              m_Dets(dtmDay).NumberOut_SevenTwenty = intNumber
              m_intTotalOut_SevenTwenty = m_intTotalOut_SevenTwenty + intNumber
            Case 2
              m_Dets(dtmDay).NumberOut_TwentyZero = intNumber
              m_intTotalOut_TwentyZero = m_intTotalOut_TwentyZero + intNumber
            Case 3
              m_Dets(dtmDay).NumberOut_ZeroSeven = intNumber
              m_intTotalOut_ZeroSeven = m_intTotalOut_ZeroSeven + intNumber
          End Select
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

  Private Function Get_SqlBaseIn() As String

    Dim dtmDateBegin As New DateTime(m_dtmDateBegin.Year, m_dtmDateBegin.Month, m_dtmDateBegin.Day, 0, 0, 0)
    Dim dtmDateEnd As New DateTime(m_dtmDateEnd.Year, m_dtmDateEnd.Month, m_dtmDateEnd.Day, 23, 59, 59)

    Dim sSql As String

    sSql = "SELECT " & _
                "* " & _
           "FROM " & _
                "Tabl_Rimozione " & _
           "WHERE " & _
                "Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBegin) & "', 121) AND " & _
                "Rimz_DataIngresso <= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateEnd) & "', 121)"
    Return sSql

  End Function

  Private Function Get_SqlBaseOut() As String

    Dim dtmDateBegin As New DateTime(m_dtmDateBegin.Year, m_dtmDateBegin.Month, m_dtmDateBegin.Day, 0, 0, 0)
    Dim dtmDateEnd As New DateTime(m_dtmDateEnd.Year, m_dtmDateEnd.Month, m_dtmDateEnd.Day, 23, 59, 59)

    Dim sSql As String

    sSql = "SELECT " & _
                "* " & _
           "FROM " & _
                "Tabl_Rimozione " & _
           "WHERE " & _
                "Rimz_DataUscita >= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBegin) & "', 121) AND " & _
                "Rimz_DataUscita <= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateEnd) & "', 121) AND " & _
                "Rimz_Stato <> 'DML' AND " & _
                "Rimz_Stato <> 'RBT'"
    Return sSql

  End Function

  Private Function Get_SqlHolidays() As String

    Dim sSql As String

    sSql = "SELECT " & _
                "* " & _
           "FROM " & _
                "Conf_Festivita " & _
           "WHERE " & _
                "Fest_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateBegin) & "', 112) AND " & _
                "Fest_Data <= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateEnd) & "', 112)"
    Return sSql

  End Function

  Private Function Get_SqlStreetWashing() As String

    Dim sSql As String

    sSql = "SELECT " & _
                "* " & _
           "FROM " & _
                "Conf_CalendarioSeabo " & _
           "WHERE " & _
                "CaSe_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateBegin) & "', 112) AND " & _
                "CaSe_Data <= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateEnd) & "', 112)"
    Return sSql

  End Function

  Private Function Get_StreetWashingDayCount() As Integer

    Dim intCount As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    intCount = 0

    strSql = "SELECT " & _
                "ISNULL(COUNT(*), 0) Total " & _
             "FROM " & _
                "Conf_CalendarioSeabo " & _
             "WHERE " & _
                "CaSe_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateBegin) & "', 112) AND " & _
                "CaSe_Data <= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateEnd) & "', 112)"

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
        intCount = System.Convert.ToInt32(dr("Total"))
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    Return intCount

  End Function

  Private Function pGet_HolidayCount() As Integer

    Dim i, intHolidayCount As Integer
    Dim dtmSunday As DateTime
    Dim holds As New supHolidays(m_dtmDateBegin, m_dtmDateEnd)

    ' Calcola la prima domenica successiva al primo giorno.
    dtmSunday = m_dtmDateBegin.AddDays(-1 * m_dtmDateBegin.DayOfWeek)
    If (dtmSunday < m_dtmDateBegin) Then
      dtmSunday = dtmSunday.AddDays(7)
    End If

    ' Calcola il numero di domeniche.
    intHolidayCount = 0
    Do While (dtmSunday <= m_dtmDateEnd)
      intHolidayCount = intHolidayCount + 1
      dtmSunday = dtmSunday.AddDays(7)
    Loop

    ' Aggiunge le festività che non cadono di domenica.
    For i = 0 To holds.UBound
      If (holds(i).Day.DayOfWeek <> DayOfWeek.Sunday) Then
        intHolidayCount = intHolidayCount + 1
      End If
    Next

    Return intHolidayCount

  End Function

End Class
