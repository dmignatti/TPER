Public Class supGDATCSessionLogs
  Inherits System.Collections.CollectionBase

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal intSessionPK As Integer)
    MyBase.new()
  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supGDATCSessionLog
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return MyBase.Count - 1
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Function Add(ByVal strUserID As String, _
                ByVal strUserName As String, ByVal strComputerName As String, _
                ByVal dtmTime As DateTime, ByVal strAction As String, _
                ByVal strDBTable As String, ByVal strDBRecord As String, _
                ByVal strPayment As String, ByVal strMoney As String) As supGDATCSessionLog

    Dim log As New supGDATCSessionLog(strUserID, strUserName, strComputerName, dtmTime, strAction, strDBTable, strDBRecord, strPayment, strMoney)
    MyBase.List.Add(log)
    Return log

  End Function

End Class
