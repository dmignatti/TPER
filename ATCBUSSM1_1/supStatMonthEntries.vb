Public Class supStatMonthEntries
  Inherits System.Collections.CollectionBase

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New()

    MyBase.New()
    CreateItems()

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supStatMonthEntry
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal intYear As Integer, ByVal intMonth As Integer) As supStatMonthEntry
    Get

      Dim index As Integer
      index = DateDiff(DateInterval.Month, supStatData.DayZero, New DateTime(intYear, intMonth, 1))
      Return MyBase.List(index)

    End Get
  End Property

  'Public ReadOnly Property Find(ByVal intYear As Integer, ByVal intMonth As Integer) As supStatMonthEntry
  '  Get
  '    Dim statm As supStatMonthEntry
  '    Dim selstatm As supStatMonthEntry = Nothing
  '    For Each statm In MyBase.List
  '      If ((statm.Year = intYear) And (statm.Month = intMonth)) Then
  '        selstatm = statm
  '        Exit For
  '      End If
  '    Next
  '    Return selstatm
  '  End Get
  'End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub CreateItems()

    Dim i, j As Integer
    Dim intYearBegin As Integer = supStatData.DayZero.Year
    Dim intYearEnd As Integer = DateTime.Now.Year
    Dim intMonthBegin, intMonthEnd As Integer

    For i = intYearBegin To intYearEnd
      intMonthBegin = IIf(i = intYearBegin, supStatData.DayZero.Month, 1)
      intMonthEnd = IIf(i = intYearEnd, DateTime.Now.Month, 12)
      For j = intMonthBegin To intMonthEnd
        MyBase.List.Add(New supStatMonthEntry(i, j))
      Next
    Next

  End Sub

End Class
