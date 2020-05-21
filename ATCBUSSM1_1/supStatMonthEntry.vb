Public Class supStatMonthEntry

  Private m_intYear As Integer
  Private m_intMonth As Integer
  Private m_intNormalCount As Integer
  Private m_intSeaboCount As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal intYear As Integer, ByVal intMonth As Integer)

    m_intYear = intYear
    m_intMonth = intMonth
    m_intNormalCount = 0
    m_intSeaboCount = 0

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Year() As Integer
    Get
      Return m_intYear
    End Get
  End Property

  Public ReadOnly Property Month() As Integer
    Get
      Return m_intMonth
    End Get
  End Property

  Public ReadOnly Property TotalCount() As Integer
    Get
      Return m_intNormalCount + m_intSeaboCount
    End Get
  End Property

  Public Property NormalCount() As Integer
    Get
      Return m_intNormalCount
    End Get
    Set(ByVal Value As Integer)
      m_intNormalCount = Value
    End Set
  End Property

  Public Property SeaboCount() As Integer
    Get
      Return m_intSeaboCount
    End Get
    Set(ByVal Value As Integer)
      m_intSeaboCount = Value
    End Set
  End Property

  Public ReadOnly Property DayAverage() As Decimal
    Get
      Return supFunction.Round(System.Convert.ToDecimal(Me.TotalCount) / DateTime.DaysInMonth(m_intYear, m_intMonth), 2)
    End Get
  End Property

End Class
