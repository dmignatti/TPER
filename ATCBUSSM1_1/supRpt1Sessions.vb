Public Class supRpt1Sessions
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
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supRpt1Session
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
  Public Function Add(ByVal intID As Integer, ByVal dtmDay As DateTime) As supRpt1Session

    MyBase.List.Add(New supRpt1Session(intID, dtmDay))
    Return MyBase.List(MyBase.List.Count - 1)

  End Function

End Class
