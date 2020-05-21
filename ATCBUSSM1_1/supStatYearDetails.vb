Public Class supStatYearDetails
  Inherits System.Collections.CollectionBase

  Private m_intMaxYear As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New()

    MyBase.New()
    m_intMaxYear = 0

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supStatYearDetail
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

  Public ReadOnly Property GetItem(ByVal intYear As Integer) As supStatYearDetail
    Get
      Dim det As supStatYearDetail
      Dim seldet As supStatYearDetail = Nothing
      For Each det In MyBase.List
        If (det.Year = intYear) Then
          seldet = det
        End If
      Next
      Return seldet
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Function Add(ByVal intYear As Integer) As supStatYearDetail

    Dim dtmDateBegin, dtmDateEnd As DateTime
    Dim det As supStatYearDetail

    If (intYear > m_intMaxYear) Then
      m_intMaxYear = intYear
    End If

    If (intYear = supStatData.DayZero.Year) Then
      dtmDateBegin = supStatData.DayZero
      dtmDateEnd = New DateTime(supStatData.DayZero.Year, 12, 31, 23, 59, 39)
    ElseIf (intYear = DateTime.Today.Year) Then
      dtmDateBegin = New DateTime(DateTime.Today.Year, 1, 1, 0, 0, 0)
      dtmDateEnd = New DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59)
    Else
      dtmDateBegin = New DateTime(intYear, 1, 1, 0, 0, 0)
      dtmDateEnd = New DateTime(intYear, 12, 31, 23, 59, 59)
    End If

    det = New supStatYearDetail(dtmDateBegin, dtmDateEnd)
    If (MyBase.List.Count = 0) Then
      MyBase.List.Add(det)
    ElseIf (MyBase.List.Count = 1) Then
      If (MyBase.List(0).Year < intYear) Then
        MyBase.List.Add(det)
      ElseIf (MyBase.List(0).Year = intYear) Then
        ' non aggiunge niente.
      Else
        MyBase.List.Insert(0, det)
      End If
    ElseIf (m_intMaxYear = intYear) Then
      MyBase.List.Add(det)
    Else
      Dim intAddAtIndex As Integer = GetAddAtIndex(intYear)
      If (intAddAtIndex > -1) Then
        MyBase.List.Insert(1, det)
      Else
        ' non aggiunge niente.
      End If
    End If

    Return det

  End Function

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Function GetAddAtIndex(ByVal intYear As Integer) As Integer

    Dim i As Integer
    Dim intAddAt As Integer = -1

    If (intYear < MyBase.List(0).Year) Then
      intAddAt = 0
    Else
      For i = 1 To (MyBase.Count - 1)
        If (intYear < MyBase.List(i).Year) Then
          intAddAt = i
          Exit For
        End If
      Next
    End If

    Return intAddAt

  End Function

End Class
