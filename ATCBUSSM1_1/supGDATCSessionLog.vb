Public Class supGDATCSessionLog

  Private m_strUserID As String
  Private m_strUserName As String
  Private m_strComputerName As String
  Private m_dtmTime As DateTime
  Private m_strAction As String
  Private m_strDBTable As String
  Private m_strDBRecord As String
  Private m_strPayment As String
  Private m_strMoney As String

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal strUserID As String, _
                ByVal strUserName As String, ByVal strComputerName As String, _
                ByVal dtmTime As DateTime, ByVal strAction As String, _
                ByVal strDBTable As String, ByVal strDBRecord As String, _
                ByVal strPayment As String, ByVal strMoney As String)

    m_strUserID = strUserID
    m_strUserName = strUserName
    m_strComputerName = strComputerName
    m_dtmTime = dtmTime
    m_strAction = strAction
    m_strDBTable = strDBTable
    m_strDBRecord = strDBRecord
    m_strPayment = strPayment
    m_strMoney = strMoney

  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Public ReadOnly Property UserID() As String
    Get
      Return m_strUserID
    End Get
  End Property

  Public ReadOnly Property UserName() As String
    Get
      Return m_strUserName
    End Get
  End Property

  Public ReadOnly Property ComputerName() As String
    Get
      Return m_strComputerName
    End Get
  End Property

  Public ReadOnly Property Time() As DateTime
    Get
      Return m_dtmTime
    End Get
  End Property

  Public ReadOnly Property Action() As String
    Get
      Return m_strAction
    End Get
  End Property

  Public ReadOnly Property DBTable() As String
    Get
      Return m_strDBTable
    End Get
  End Property

  Public ReadOnly Property DBRecord() As String
    Get
      Return m_strDBRecord
    End Get
  End Property

  Public ReadOnly Property Payment() As String
    Get
      Return m_strPayment
    End Get
  End Property

  Public ReadOnly Property Money() As String
    Get
      Return m_strMoney
    End Get
  End Property

End Class
