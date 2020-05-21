Public Class wf_statyears
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tblDetail As System.Web.UI.WebControls.Table

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Const mk_CSSCLASS_TOTAL_TITLE As String = "supStat_DetailTitle"
  Private Const mk_CSSCLASS_TITLE As String = "supStat_DetailTitle"
  Private Const mk_CSSCLASS_NUMBER As String = "supStat_Detail_WORKDAY"
  Private Const mk_CSSCLASS_DELTA As String = "supStat_Detail_WORKDAY"
  Private Const mk_CSSCLASS_DELTANEG As String = "supStat_Detail_HOLIDAY"
  Private Const mk_CSSCLASS_CAPTION As String = "supStat_Detail_STRWDAY"

  'Private Const mk_WIDTH_YEAR As Integer = 150
  'Private Const mk_WIDTH_MONTH As Integer = 50
  'Private Const mk_WIDTH_WEEKDAY As Integer = 50
  'Private Const mk_WIDTH_DATE As Integer = 90
  Private Const mk_WIDTH_DESC As Integer = 100
  Private Const mk_WIDTH_NUMBER As Integer = 100

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      Fill()
    Catch ex As Exception
      lblError.Text = "Errore in lettura dati."
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim statyears As New supStatYears

    tblDetail.Width = Unit.Pixel(2 * (mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER))
    'FormatTable(tblDetail)
    AddRows(statyears)

  End Sub

  Private Sub FormatTable(ByRef tbl As Table)

    tbl.Rows.Clear()
    tbl.CssClass = "supStat_DetailTable"
    tbl.CellPadding = 0
    tbl.CellSpacing = 0
    tbl.Width = Unit.Pixel(mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER)

  End Sub

  Private Sub AddHeader(ByRef tbl As Table, ByVal strTitle As String, ByVal strTitleCssClass As String)

    Dim row As New TableRow
    row.Cells.Add(GetCell(3, strTitle, strTitleCssClass, mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, True))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddRows(ByVal statyears As supStatYears)

    Dim i As Integer
    Dim strTitle As String
    Dim cdet As supStatYearDetail

    Dim row0 As New TableRow
    row0.Cells.Add(GetCell(2, "", "", 2 * (mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER), HorizontalAlign.Left, False))
    row0.Cells(row0.Cells.Count - 1).Controls.Add(GetTable(statyears.Totals, "Totale", mk_CSSCLASS_TOTAL_TITLE, False))
    tblDetail.Rows.Add(row0)

    For i = 0 To (statyears.Details.UBound - 1)
      strTitle = "Anno " & statyears.Details(i).Year & " (" & _
                  supFunction.FormatDate(statyears.Details(i).DateBegin, supFunction.supDateFormatEnum.dfeStandard) & " - " & _
                  supFunction.FormatDate(statyears.Details(i).DateEnd, supFunction.supDateFormatEnum.dfeStandard) & ")"
      Dim row As New TableRow
      row.Cells.Add(GetCell(2, "", "", 2 * (mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER), HorizontalAlign.Left, False))
      row.Cells(row.Cells.Count - 1).Controls.Add(GetTable(statyears.Details(i), strTitle, mk_CSSCLASS_TITLE, (i = statyears.Details.UBound - 1)))
      tblDetail.Rows.Add(row)
    Next

    Dim rown As New TableRow
    strTitle = "Anno " & statyears.Details(statyears.Details.UBound).Year & " (" & _
                supFunction.FormatDate(statyears.Details(statyears.Details.UBound).DateBegin, supFunction.supDateFormatEnum.dfeStandard) & " - " & _
                supFunction.FormatDate(statyears.Details(statyears.Details.UBound).DateEnd, supFunction.supDateFormatEnum.dfeStandard) & ")"
    rown.Cells.Add(GetCell(0, "", "", 2 * (mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER), HorizontalAlign.Left, False))
    rown.Cells(rown.Cells.Count - 1).Controls.Add(GetTable(statyears.Details(statyears.Details.UBound), strTitle, mk_CSSCLASS_TITLE, True))

    cdet = statyears.Details(statyears.Details.UBound).GetComparison
    strTitle = "Anno " & cdet.Year & " (" & _
                supFunction.FormatDate(cdet.DateBegin, supFunction.supDateFormatEnum.dfeStandard) & " - " & _
                supFunction.FormatDate(cdet.DateEnd, supFunction.supDateFormatEnum.dfeStandard) & ")"
    rown.Cells.Add(GetCell(0, "", "", 2 * (mk_WIDTH_DESC + 2 * mk_WIDTH_NUMBER), HorizontalAlign.Left, False))
    rown.Cells(rown.Cells.Count - 1).Controls.Add(GetTable(cdet, strTitle, mk_CSSCLASS_TITLE, False))
    tblDetail.Rows.Add(rown)

  End Sub

  Private Function GetTable(ByVal det As supStatYearDetail, ByVal strTitle As String, ByVal strTitleCssClass As String, ByVal blnWriteDelta As Boolean) As Table

    Dim tbl As New Table
    Dim strCssClass As String

    FormatTable(tbl)
    AddHeader(tbl, strTitle, strTitleCssClass)

    Dim row0 As New TableRow
    row0.Cells.Add(GetCell(0, supFunction.FormatInteger(det.DayCount) & " gg.", mk_CSSCLASS_NUMBER, mk_WIDTH_DESC, HorizontalAlign.Center, True))
    row0.Cells.Add(GetCell(0, "In ingresso", mk_CSSCLASS_CAPTION, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row0.Cells.Add(GetCell(0, "In uscita", mk_CSSCLASS_CAPTION, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    tbl.Rows.Add(row0)

    Dim row1 As New TableRow
    row1.Cells.Add(GetCell(0, "Totale", mk_CSSCLASS_CAPTION, mk_WIDTH_DESC, HorizontalAlign.Left, False))
    row1.Cells.Add(GetCell(0, supFunction.FormatInteger(det.TotalIn), mk_CSSCLASS_NUMBER, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row1.Cells.Add(GetCell(0, supFunction.FormatInteger(det.TotalOut), mk_CSSCLASS_NUMBER, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    tbl.Rows.Add(row1)

    Dim row2 As New TableRow
    row2.Cells.Add(GetCell(0, "Media/g.", mk_CSSCLASS_CAPTION, mk_WIDTH_DESC, HorizontalAlign.Left, False))
    row2.Cells.Add(GetCell(0, supFunction.FormatDecimal(det.AverageIn), mk_CSSCLASS_NUMBER, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row2.Cells.Add(GetCell(0, supFunction.FormatDecimal(det.AverageOut), mk_CSSCLASS_NUMBER, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    tbl.Rows.Add(row2)

    If blnWriteDelta Then
      Dim intPrevYear As Integer = det.Year - 1
      Dim strDeltaIn, strDeltaOut As String
      Dim strCssClass_DeltaIn, strCssClass_DeltaOut As String
      Dim row3 As New TableRow
      strDeltaIn = det.DeltaIn
      strDeltaOut = det.DeltaOut
      strCssClass_DeltaIn = IIf(Left(strDeltaIn, 1) = "+", mk_CSSCLASS_DELTA, mk_CSSCLASS_DELTANEG)
      strCssClass_DeltaOut = IIf(Left(strDeltaOut, 1) = "+", mk_CSSCLASS_DELTA, mk_CSSCLASS_DELTANEG)
      row3.Cells.Add(GetCell(0, "Diff.con il " & CStr(intPrevYear), mk_CSSCLASS_CAPTION, mk_WIDTH_DESC, HorizontalAlign.Left, False))
      row3.Cells.Add(GetCell(0, strDeltaIn, strCssClass_DeltaIn, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
      row3.Cells.Add(GetCell(0, strDeltaOut, strCssClass_DeltaOut, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
      tbl.Rows.Add(row3)
    End If

    Return tbl

  End Function

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intAlignment As HorizontalAlign, ByVal blnBold As Boolean) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    'If (strText = "0") Then
    '  cell.Text = ""
    'Else
    '  cell.Text = strText
    'End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.HorizontalAlign = intAlignment
    cell.VerticalAlign = VerticalAlign.Top
    cell.Width = Unit.Pixel(intWidth)
    cell.Font.Bold = blnBold
    Return cell

  End Function

End Class
