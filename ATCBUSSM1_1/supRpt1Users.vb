Public Class supRpt1Users
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
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supRpt1User
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
  Public Function Add(ByVal strCode As String, ByVal strName As String) As supRpt1User

    MyBase.List.Add(New supRpt1User(strCode, strName))
    Return MyBase.List(MyBase.List.Count - 1)

  End Function


End Class
