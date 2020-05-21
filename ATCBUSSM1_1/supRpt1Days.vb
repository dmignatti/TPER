Public Class supRpt1Days
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
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supRpt1Day
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
  Public Function Add(ByVal dtmDay As DateTime) As supRpt1Day

    MyBase.List.Add(New supRpt1Day(dtmDay))
    Return MyBase.List(MyBase.List.Count - 1)

  End Function

End Class
