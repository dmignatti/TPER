Public Class supStatDetails
  Inherits System.Collections.CollectionBase

  Private m_dtmDateBegin, m_dtmDateEnd As DateTime

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    MyBase.New()
    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    CreateDeatils()

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

  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supStatDetail
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal dtmDay As DateTime) As supStatDetail
    Get
      Dim Index As Integer = DateDiff(DateInterval.Day, m_dtmDateBegin, dtmDay)
      Return MyBase.List(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Sub CreateDeatils()

    Dim dtmDay As DateTime = m_dtmDateBegin

    Do While (dtmDay <= m_dtmDateEnd)
      Dim det As New supStatDetail(dtmDay)
      MyBase.List.Add(det)
      dtmDay = dtmDay.AddDays(1)
    Loop

  End Sub

End Class
