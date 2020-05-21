Public Class supStatCompactRow

  'Public Const DayZone_WholeDay As Integer = 0
  'Public Const DayZone_SevenTwenty As Integer = 1
  'Public Const DayZone_TwentyZero As Integer = 2
  'Public Const DayZone_ZeroSeven As Integer = 3

  'Public Enum DayZoneEnum As Integer
  '  WholeDay = 0
  '  SevenTwenty = 1
  '  TwentyZero = 2
  '  ZeroSeven = 3
  'End Enum

  Private m_intHourGap As Integer
  Private m_intWorkingDayCount As Integer
  Private m_intHolidayCount As Integer
  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_cellAllDays As supStatCompactCell
  Private m_cellWorkingDays As supStatCompactCell
  Private m_cellHolidays As supStatCompactCell

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime, ByVal intWorkingDayCount As Integer, ByVal intHolidayCount As Integer, ByVal intHourGap As Integer)

    m_intHourGap = intHourGap
    m_intWorkingDayCount = intWorkingDayCount
    m_intHolidayCount = intHolidayCount
    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd

    m_cellAllDays = New supStatCompactCell(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount + m_intHolidayCount, intHourGap)
    m_cellWorkingDays = New supStatCompactCell(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, intHourGap)
    m_cellHolidays = New supStatCompactCell(m_dtmDateBegin, m_dtmDateEnd, m_intHolidayCount, intHourGap)

  End Sub

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

  Public ReadOnly Property AllDays() As supStatCompactCell
    Get
      Return m_cellAllDays
    End Get
  End Property

  Public ReadOnly Property WorkingDays() As supStatCompactCell
    Get
      Return m_cellWorkingDays
    End Get
  End Property

  Public ReadOnly Property Holidays() As supStatCompactCell
    Get
      Return m_cellHolidays
    End Get
  End Property

End Class
