Public Class supGDATCSessionRecord

  Private m_intPK As Integer
  Private m_intFK_User As Integer
  Private m_strUserID As String
  Private m_strUserName As String
  Private m_strComputerName As String
  Private m_dtmDateOpen As DateTime
  Private m_dtmDateClose As DateTime
  Private m_decBancRimz As Decimal
  Private m_decBancInfr As Decimal
  Private m_decCashRimz As Decimal
  Private m_decCashInfr As Decimal
  Private m_strState As String
  Private m_strNotes As String

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal intPK As Integer, ByVal intFK_User As Integer, ByVal strUserID As String, _
                ByVal strUserName As String, ByVal strComputerName As String, _
                ByVal dtmDateOpen As DateTime, ByVal dtmDateClose As DateTime, _
                ByVal decBancRimz As Decimal, ByVal decBancInfr As Decimal, _
                ByVal decCashRimz As Decimal, ByVal decCashInfr As Decimal, _
                ByVal strState As String, ByVal strNotes As String)

    m_intPK = intPK
    m_intFK_User = intFK_User
    m_strUserID = strUserID
    m_strUserName = strUserName
    m_strComputerName = strComputerName
    m_dtmDateOpen = dtmDateOpen
    m_dtmDateClose = dtmDateClose
    m_decBancRimz = decBancRimz
    m_decBancInfr = decBancInfr
    m_decCashRimz = decCashRimz
    m_decCashInfr = decCashInfr
    m_strState = strState
    m_strNotes = strNotes

  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Public ReadOnly Property PK() As Integer
    Get
      Return m_intPK
    End Get
  End Property

  Public ReadOnly Property FK_User() As Integer
    Get
      Return m_intFK_User
    End Get
  End Property

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

  Public ReadOnly Property DateOpen() As DateTime
    Get
      Return m_dtmDateOpen
    End Get
  End Property

  Public ReadOnly Property DateClose() As DateTime
    Get
      Return m_dtmDateClose
    End Get
  End Property

  Public ReadOnly Property BancRimz() As Decimal
    Get
      Return m_decBancRimz
    End Get
  End Property

  Public ReadOnly Property BancInfr() As Decimal
    Get
      Return m_decBancInfr
    End Get
  End Property

  Public ReadOnly Property CashRimz() As Decimal
    Get
      Return m_decCashRimz
    End Get
  End Property

  Public ReadOnly Property CashInfr() As Decimal
    Get
      Return m_decCashInfr
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return BancRimz + BancInfr + CashRimz + CashInfr
    End Get
  End Property

  Public ReadOnly Property State() As String
    Get
      Return m_strState
    End Get
  End Property

  Public ReadOnly Property Notes() As String
    Get
      Return m_strNotes
    End Get
  End Property

End Class
