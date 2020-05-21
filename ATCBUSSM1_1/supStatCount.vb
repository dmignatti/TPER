Public Class supStatCount

  Private m_intCount As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New()
    m_intCount = 0
  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Value() As Integer
    Get
      Return m_intCount
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub Add(ByVal intNumberToAdd As Integer)
    m_intCount = m_intCount + intNumberToAdd
  End Sub

  Public Sub Subtract(ByVal intNumberToSubtract As Integer)
    m_intCount = m_intCount - intNumberToSubtract
  End Sub

  Public Sub Clear()
    m_intCount = 0
  End Sub

End Class
