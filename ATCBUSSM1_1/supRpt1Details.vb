Public Class supRpt1Details
  Inherits System.Collections.CollectionBase

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New()
    MyBase.New()
  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supRpt1Detail
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return MyBase.Count - 1
    End Get
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Function Add(ByVal strTime As String, ByVal strDesc As String, ByVal intFlag As supRpt1Detail.FlagEnum, ByVal intPayment As supRpt1Detail.PaymentEnum, ByVal decMoney As Decimal) As supRpt1Detail

    MyBase.List.Add(New supRpt1Detail(strTime, strDesc, intFlag, intPayment, decMoney))
    Return MyBase.List(MyBase.List.Count - 1)

  End Function

End Class
