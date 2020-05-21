Public Class wf_statmonths
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

  Private Const mk_CSSCLASS_TITLE As String = "supStat_DetailTitle"
  Private Const mk_CSSCLASS_NUMBER As String = "supStat_Detail_WORKDAY"

  Private Const mk_COLWIDTH As Integer = 80

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      Fill()
    Catch ex As Exception
      lblError.Text = "Errore in lettura dati."
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim statmonth As New supStatMonth
    statmonth.Refresh()

    FormatTable(tblDetail)
    AddHeader()
    AddRows(statmonth)

  End Sub

  Private Sub FormatTable(ByRef tbl As Table)

    tbl.Rows.Clear()
    tbl.CssClass = "supStat_DetailTable"
    tbl.CellPadding = 0
    tbl.CellSpacing = 0
    tbl.Width = Unit.Pixel(5 * mk_COLWIDTH)

  End Sub

  Private Sub AddHeader()

    Dim row As New TableRow
    row.Cells.Add(GetCell(0, "Anno", mk_CSSCLASS_TITLE, mk_COLWIDTH, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "Mese", mk_CSSCLASS_TITLE, mk_COLWIDTH, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "Totale", mk_CSSCLASS_TITLE, mk_COLWIDTH, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "Media giorno", mk_CSSCLASS_TITLE, mk_COLWIDTH, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "Pulizia strade", mk_CSSCLASS_TITLE, mk_COLWIDTH, HorizontalAlign.Center, False))
    tblDetail.Rows.Add(row)

  End Sub

  Private Sub AddRows(ByRef statmonth As supStatMonth)

    Dim blnBold As Boolean
    Dim i As Integer
    Dim intYear As Integer = 0
    Dim row As TableRow

    For i = 0 To statmonth.Items.UBound
      row = New TableRow
      If (intYear = statmonth.Items(i).Year) Then
        blnBold = False
      Else
        blnBold = True
        intYear = statmonth.Items(i).Year
      End If
      row.Cells.Add(GetCell(0, CStr(statmonth.Items(i).Year), mk_CSSCLASS_NUMBER, mk_COLWIDTH, HorizontalAlign.Center, blnBold))
      row.Cells.Add(GetCell(0, supFunction.MonthName(statmonth.Items(i).Month, supFunction.supMonthNameEnum.mneStandard), mk_CSSCLASS_NUMBER, mk_COLWIDTH, HorizontalAlign.Left, blnBold))
      row.Cells.Add(GetCell(0, supFunction.FormatInteger(statmonth.Items(i).TotalCount), mk_CSSCLASS_NUMBER, mk_COLWIDTH, HorizontalAlign.Right, blnBold))
      row.Cells.Add(GetCell(0, supFunction.FormatDecimal(statmonth.Items(i).DayAverage), mk_CSSCLASS_NUMBER, mk_COLWIDTH, HorizontalAlign.Right, blnBold))
      row.Cells.Add(GetCell(0, supFunction.FormatInteger(statmonth.Items(i).SeaboCount), mk_CSSCLASS_NUMBER, mk_COLWIDTH, HorizontalAlign.Right, blnBold))
      tblDetail.Rows.Add(row)
    Next

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intAlignment As HorizontalAlign, ByVal blnBold As Boolean) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.HorizontalAlign = intAlignment
    cell.VerticalAlign = VerticalAlign.Top
    cell.Width = Unit.Pixel(intWidth)
    cell.Font.Bold = blnBold
    Return cell

  End Function

End Class
