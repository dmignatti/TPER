Public Class supStatCompactRows
  Inherits System.Collections.CollectionBase

  Private m_intWorkingDayCount As Integer
  Private m_intHolidayCount As Integer
  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime, ByVal intWorkingDayCount As Integer, ByVal intHolidayCount As Integer)

    MyBase.New()

    m_intWorkingDayCount = intWorkingDayCount
    m_intHolidayCount = intHolidayCount
    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd

    Dim rowWholeDay As New supStatCompactRow(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, m_intHolidayCount, 24)
    Dim rowSevenTwenty As New supStatCompactRow(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, m_intHolidayCount, 13)
    Dim rowTwentyZero As New supStatCompactRow(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, m_intHolidayCount, 4)
    Dim rowZeroSeven As New supStatCompactRow(m_dtmDateBegin, m_dtmDateEnd, m_intWorkingDayCount, m_intHolidayCount, 7)

    MyBase.List.Add(rowWholeDay)
    MyBase.List.Add(rowSevenTwenty)
    MyBase.List.Add(rowTwentyZero)
    MyBase.List.Add(rowZeroSeven)

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

  Default Public ReadOnly Property Item(ByVal Index As Integer) As supStatCompactRow
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

End Class
