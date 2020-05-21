Public Class supSqlCommand

  Private m_strText As String

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New(ByVal strCommandText As String)

    If (strCommandText Is Nothing) Then
      m_strText = ""
    Else
      m_strText = strCommandText
    End If

  End Sub

  ' *********************************************************************************************
  '     PRPERTIES
  ' *********************************************************************************************
  Public ReadOnly Property Text() As String
    Get
      Return m_strText
    End Get
  End Property

End Class
