Public Class atcbModule

  Private m_intID As Integer
  Private m_strDesc As String
  Private m_blnEnabled As Boolean
  Private m_strPageToLoad As String

  ' *********************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************
  Public Sub New(ByVal intID As Integer, ByVal strDesc As String, ByVal blnEnabled As Boolean, ByVal strPageToLoad As String)

    m_intID = intID
    m_strDesc = strDesc
    m_blnEnabled = blnEnabled
    m_strPageToLoad = strPageToLoad

  End Sub

  ' *********************************************************************************
  '     PROPERTIES
  ' *********************************************************************************
  Public ReadOnly Property ID() As Integer
    Get
      Return m_intID
    End Get
  End Property

  Public ReadOnly Property Desc() As String
    Get
      Return m_strDesc
    End Get
  End Property

  Public ReadOnly Property Enabled() As Boolean
    Get
      Return m_blnEnabled
    End Get
  End Property

  Public ReadOnly Property PageToLoad() As String
    Get
      Return m_strPageToLoad
    End Get
  End Property

  Public ReadOnly Property NavigateUrl() As String
    Get
      Return m_strPageToLoad & "?" & atcbConstant.QS_ModuleID & "=" & CStr(m_intID)
    End Get
  End Property

End Class
