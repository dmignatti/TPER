Public Class supGDATCSessionRecordset
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
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supGDATCSessionRecord
    Get
      Return MyBase.List.Item(Index)
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
  Public Function Add(ByVal intPK As Integer, ByVal intFK_User As Integer, ByVal strUserID As String, _
                ByVal strUserName As String, ByVal strComputerName As String, _
                ByVal dtmDateOpen As DateTime, ByVal dtmDateClose As DateTime, _
                ByVal decBancRimz As Decimal, ByVal decBancInfr As Decimal, _
                ByVal decCashRimz As Decimal, ByVal decCashInfr As Decimal, _
                ByVal strState As String, ByVal strNotes As String) As supGDATCSessionRecord

    Dim sess As New supGDATCSessionRecord(intPK, intFK_User, strUserID, strUserName, strComputerName, dtmDateOpen, dtmDateClose, decBancRimz, decBancInfr, decCashRimz, decCashInfr, strState, strNotes)
    MyBase.List.Add(sess)
    Return sess

  End Function

End Class
