Public Class supHoliday

  Private m_dtmDay As DateTime

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime)
    m_dtmDay = dtmDay
  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Public ReadOnly Property Day() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

End Class
