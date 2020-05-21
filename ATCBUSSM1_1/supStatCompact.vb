Public Class supStatCompact

  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_Rows As supStatCompactRows

  Private m_intWorkingDayCount As Integer
  Private m_intHolidayCount As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    CalculateDayGaps()

    m_Rows = New supStatCompactRows(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, m_intHolidayCount)

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property DayCount() As Integer
    Get
      Return DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd)
    End Get
  End Property

  Public ReadOnly Property WorkingDayCount() As Integer
    Get
      Return m_intWorkingDayCount
    End Get
  End Property

  Public ReadOnly Property HolidayCount() As Integer
    Get
      Return m_intWorkingDayCount
    End Get
  End Property

  Public ReadOnly Property Rows() As supStatCompactRows
    Get
      Return m_Rows
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub Fill()

    Dim SData As New supStatData(m_dtmDateBegin, m_dtmDateEnd)
    SData.Fetch()

    m_Rows(0).AllDays.CountIn.Add(SData.TotalIn)
    m_Rows(0).AllDays.CountOut.Add(SData.TotalOut)
    m_Rows(1).AllDays.CountIn.Add(SData.TotalIn_SevenTwenty)
    m_Rows(1).AllDays.CountOut.Add(SData.TotalOut_SevenTwenty)
    m_Rows(2).AllDays.CountIn.Add(SData.TotalIn_TwentyZero)
    m_Rows(2).AllDays.CountOut.Add(SData.TotalOut_TwentyZero)
    m_Rows(3).AllDays.CountIn.Add(SData.TotalIn_ZeroSeven)
    m_Rows(3).AllDays.CountOut.Add(SData.TotalOut_ZeroSeven)

    Dim i As Integer

    For i = 0 To SData.Details.UBound
      If SData.Details(i).IsHoliday Then
        m_Rows(0).Holidays.CountIn.Add(SData.Details(i).TotalIn)
        m_Rows(0).Holidays.CountOut.Add(SData.Details(i).TotalOut)
        m_Rows(1).Holidays.CountIn.Add(SData.Details(i).NumberIn_SevenTwenty)
        m_Rows(1).Holidays.CountOut.Add(SData.Details(i).NumberOut_SevenTwenty)
        m_Rows(2).Holidays.CountIn.Add(SData.Details(i).NumberIn_TwentyZero)
        m_Rows(2).Holidays.CountOut.Add(SData.Details(i).NumberOut_TwentyZero)
        m_Rows(3).Holidays.CountIn.Add(SData.Details(i).NumberIn_ZeroSeven)
        m_Rows(3).Holidays.CountOut.Add(SData.Details(i).NumberOut_ZeroSeven)
      Else
        m_Rows(0).WorkingDays.CountIn.Add(SData.Details(i).TotalIn)
        m_Rows(0).WorkingDays.CountOut.Add(SData.Details(i).TotalOut)
        m_Rows(1).WorkingDays.CountIn.Add(SData.Details(i).NumberIn_SevenTwenty)
        m_Rows(1).WorkingDays.CountOut.Add(SData.Details(i).NumberOut_SevenTwenty)
        m_Rows(2).WorkingDays.CountIn.Add(SData.Details(i).NumberIn_TwentyZero)
        m_Rows(2).WorkingDays.CountOut.Add(SData.Details(i).NumberOut_TwentyZero)
        m_Rows(3).WorkingDays.CountIn.Add(SData.Details(i).NumberIn_ZeroSeven)
        m_Rows(3).WorkingDays.CountOut.Add(SData.Details(i).NumberOut_ZeroSeven)
      End If
    Next

  End Sub

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Sub CalculateDayGaps()

    Dim intTotalDayCount As Integer = DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd) + 1
    Dim dtmSunday As DateTime = Get_FirstSunday()
    Dim holds As New supHolidays(m_dtmDateBegin, m_dtmDateEnd)

    ' Aggiunge le domeniche alle ferie tabellate.
    m_intHolidayCount = holds.Count
    Do While (dtmSunday < m_dtmDateEnd)
      If (holds(dtmSunday) Is Nothing) Then
        m_intHolidayCount = m_intHolidayCount + 1
      End If
      dtmSunday = dtmSunday.AddDays(7)
    Loop

    m_intWorkingDayCount = intTotalDayCount - m_intHolidayCount

  End Sub

  Private Function Get_FirstSunday() As DateTime

    Select Case m_dtmDateBegin.DayOfWeek
      Case DayOfWeek.Monday
        Return m_dtmDateBegin.AddDays(6)
      Case DayOfWeek.Tuesday
        Return m_dtmDateBegin.AddDays(5)
      Case DayOfWeek.Wednesday
        Return m_dtmDateBegin.AddDays(4)
      Case DayOfWeek.Thursday
        Return m_dtmDateBegin.AddDays(3)
      Case DayOfWeek.Friday
        Return m_dtmDateBegin.AddDays(2)
      Case DayOfWeek.Saturday
        Return m_dtmDateBegin.AddDays(1)
      Case DayOfWeek.Sunday
        Return m_dtmDateBegin
    End Select

  End Function

End Class
