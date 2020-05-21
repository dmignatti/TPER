Public Class supSeaboDay

  Private m_dtmDay As DateTime
  Private m_blnChecked As Boolean
  Private m_blnNewChecked As Boolean

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime)

    m_dtmDay = dtmDay
    m_blnChecked = False
    m_blnNewChecked = False

  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Public ReadOnly Property Day() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

  Public Property Checked() As Boolean
    Get
      Return m_blnChecked
    End Get
    Set(ByVal Value As Boolean)
      m_blnChecked = Value
    End Set
  End Property

  Public Property NewChecked() As Boolean
    Get
      Return m_blnNewChecked
    End Get
    Set(ByVal Value As Boolean)
      m_blnNewChecked = Value
    End Set
  End Property

  Public ReadOnly Property SqlCommand() As String
    Get
      If (m_blnNewChecked Xor m_blnChecked) Then
        If m_blnNewChecked Then
          Return "INSERT INTO Conf_CalendarioSeabo (CaSe_Data) VALUES (CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDay) & "', 112))"
        Else
          Return "DELETE FROM Conf_CalendarioSeabo WHERE CaSe_Data = CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDay) & "', 112)"
        End If
      Else
        Return ""
      End If
    End Get
  End Property

End Class
