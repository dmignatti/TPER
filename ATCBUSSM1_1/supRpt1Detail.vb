Public Class supRpt1Detail

  Public Enum PaymentEnum As Integer
    Bancomat = 1
    Cash = 2
  End Enum

  Public Enum FlagEnum As Integer
    Multa = 1
    Servizi = 2
    Altro = 3
  End Enum

  Protected m_strTime As String
  Protected m_strDesc As String
  Protected m_intFlag As FlagEnum
  Protected m_intPayment As PaymentEnum
  Protected m_decMoney As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal strTime As String, ByVal strDesc As String, ByVal intFlag As FlagEnum, ByVal intPayment As PaymentEnum, ByVal decMoney As Decimal)

    m_strTime = strTime
    m_strDesc = strDesc
    m_intFlag = intFlag
    m_intPayment = intPayment
    m_decMoney = decMoney

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property Time() As String
    Get
      Return m_strTime
    End Get
  End Property

  Public ReadOnly Property Desc() As String
    Get
      Return m_strDesc
    End Get
  End Property

  Public ReadOnly Property Flag() As FlagEnum
    Get
      Return m_intFlag
    End Get
  End Property

  Public ReadOnly Property Payment() As PaymentEnum
    Get
      Return m_intPayment
    End Get
  End Property

  Public ReadOnly Property PaymentDesc() As String
    Get
      Return IIf(m_intPayment = PaymentEnum.Bancomat, "Bancomat", "Contanti")
    End Get
  End Property

  Public ReadOnly Property Money() As Decimal
    Get
      Return m_decMoney
    End Get
  End Property

End Class
