Public Class supVehicles
  Inherits System.Collections.CollectionBase

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New()
    MyBase.New()
  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supVehicle
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Function Add(ByVal intPK As Integer, ByVal strPlate As String, ByVal dtmDateIn As DateTime, ByVal dtmDateOut As DateTime, ByVal strType As String, ByVal strMark As String, ByVal strModel As String, ByVal strNVerbale As String, ByVal strState As String) As supVehicle

    Dim vehicle As New supVehicle(intPK, dtmDateIn, dtmDateOut, strPlate, strType, strMark, strModel, strNVerbale, strState)
    MyBase.List.Add(vehicle)
    Return vehicle

  End Function

End Class
