Public Class supStatDetail

  Private m_dtmDay As DateTime

  Private m_intNumberIn_SevenTwenty As Integer
  Private m_intNumberIn_TwentyZero As Integer
  Private m_intNumberIn_ZeroSeven As Integer
  Private m_intNumberOut_SevenTwenty As Integer
  Private m_intNumberOut_TwentyZero As Integer
  Private m_intNumberOut_ZeroSeven As Integer

  Private m_blnIsHoliday As Boolean
  Private m_blnStreetWashing As Boolean

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime)
    m_dtmDay = dtmDay
  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Day() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

  Public Property NumberIn_SevenTwenty() As Integer
    Get
      Return m_intNumberIn_SevenTwenty
    End Get
    Set(ByVal Value As Integer)
      m_intNumberIn_SevenTwenty = Value
    End Set
  End Property

  Public Property NumberIn_TwentyZero() As Integer
    Get
      Return m_intNumberIn_TwentyZero
    End Get
    Set(ByVal Value As Integer)
      m_intNumberIn_TwentyZero = Value
    End Set
  End Property

  Public Property NumberIn_ZeroSeven() As Integer
    Get
      Return m_intNumberIn_ZeroSeven
    End Get
    Set(ByVal Value As Integer)
      m_intNumberIn_ZeroSeven = Value
    End Set
  End Property

  Public Property NumberOut_SevenTwenty() As Integer
    Get
      Return m_intNumberOut_SevenTwenty
    End Get
    Set(ByVal Value As Integer)
      m_intNumberOut_SevenTwenty = Value
    End Set
  End Property

  Public Property NumberOut_TwentyZero() As Integer
    Get
      Return m_intNumberOut_TwentyZero
    End Get
    Set(ByVal Value As Integer)
      m_intNumberOut_TwentyZero = Value
    End Set
  End Property

  Public Property NumberOut_ZeroSeven() As Integer
    Get
      Return m_intNumberOut_ZeroSeven
    End Get
    Set(ByVal Value As Integer)
      m_intNumberOut_ZeroSeven = Value
    End Set
  End Property

  Public Property IsHoliday() As Boolean
    Get
      If m_blnIsHoliday Then
        Return True
      Else
        Return (m_dtmDay.DayOfWeek = DayOfWeek.Sunday)
      End If
    End Get
    Set(ByVal Value As Boolean)
      m_blnIsHoliday = Value
    End Set
  End Property

  Public Property StreetWashing() As Boolean
    Get
      Return m_blnStreetWashing
    End Get
    Set(ByVal Value As Boolean)
      m_blnStreetWashing = Value
    End Set
  End Property

  Public ReadOnly Property TotalIn() As Integer
    Get
      Return (m_intNumberIn_SevenTwenty + m_intNumberIn_TwentyZero + m_intNumberIn_ZeroSeven)
    End Get
  End Property

  Public ReadOnly Property TotalOut() As Integer
    Get
      Return (m_intNumberOut_SevenTwenty + m_intNumberOut_TwentyZero + m_intNumberOut_ZeroSeven)
    End Get
  End Property

End Class
