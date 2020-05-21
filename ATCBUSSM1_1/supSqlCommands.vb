Public Class supSqlCommands
  Inherits System.Collections.CollectionBase

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New()
    MyBase.New()
  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supSqlCommand
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.Count - 1)
    End Get
  End Property

  ' *********************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************
  Public Function Add(ByVal sCommandText As String) As supSqlCommand

    Dim cmd As New supSqlCommand(sCommandText)
    MyBase.List.Add(cmd)
    Return MyBase.List(Me.UBound)

  End Function

End Class
