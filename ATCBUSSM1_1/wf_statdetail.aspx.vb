Public Class wf_statdetail
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tblResume As System.Web.UI.WebControls.Table
  Protected WithEvents tblDetail As System.Web.UI.WebControls.Table
  Protected WithEvents ddlUser As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtDateEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateEnd As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateEnd As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
  Protected WithEvents lblError As System.Web.UI.WebControls.Label

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
  Private Const mk_CSSCLASS_WORKDAY As String = "supStat_Detail_WORKDAY"
  Private Const mk_CSSCLASS_HOLIDAY As String = "supStat_Detail_HOLIDAY"
  Private Const mk_CSSCLASS_STRWDAY As String = "supStat_Detail_STRWDAY"
  Private Const mk_CSSCLASS_STRHDAY As String = "supStat_Detail_STRHDAY"

  Private Const mk_WIDTH_YEAR As Integer = 40
  Private Const mk_WIDTH_MONTH As Integer = 40
  Private Const mk_WIDTH_WEEKDAY As Integer = 40
  Private Const mk_WIDTH_DATE As Integer = 70
  Private Const mk_WIDTH_STRFLAG As Integer = 60
  Private Const mk_WIDTH_NUMBER As Integer = 50

  Dim m_dtmDateBegin, m_dtmDateEnd As DateTime

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      If IsPostBack Then
        m_dtmDateBegin = supFunction.DecodeDate(txtDateBegin.Text)
        m_dtmDateEnd = supFunction.DecodeDate(txtDateEnd.Text)
      Else
        SetDefault()
      End If
    Catch ex As Exception
      SetDefault()
    End Try

    Try
      Fill()
    Catch ex As Exception
      lblError.Text = "Errore in lettura dati."
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub SetDefault()

    m_dtmDateBegin = New DateTime(DateTime.Now.Year, 1, 1)
    m_dtmDateEnd = DateTime.Today
    txtDateBegin.Text = supFunction.FormatDate(m_dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard)
    txtDateEnd.Text = supFunction.FormatDate(m_dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)

  End Sub

  Private Sub Fill()

    Dim statdata As New supStatData(m_dtmDateBegin, m_dtmDateEnd)
    statdata.Fetch()
    Fill_Resume(statdata)
    Fill_Detail(statdata)

  End Sub

  Private Sub Fill_Detail(ByRef statdata As supStatData)

    Dim i As Integer

    FormatTable(tblDetail)
    AddHeaderGroup(tblDetail)
    AddHeader(tblDetail)
    For i = 0 To statdata.Details.UBound
      AddRow(tblDetail, statdata.Details(i))
    Next

  End Sub

  Private Sub Fill_Resume(ByRef statdata As supStatData)

    FormatTable(tblResume)

    Dim row_0 As New TableRow
    row_0.Cells.Add(GetCell(5, "", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Center, False))
    row_0.Cells.Add(GetCell(2, "Tot.interv.", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row_0.Cells.Add(GetCell(2, "Feriali", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row_0.Cells.Add(GetCell(2, "Festivi", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row_0.Cells.Add(GetCell(2, "Seabo", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    tblResume.Rows.Add(row_0)

    Dim row_1 As New TableRow
    row_1.Cells.Add(GetCell(5, "Numero giornate", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row_1.Cells.Add(GetCell(2, statdata.DayCount, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_1.Cells.Add(GetCell(2, statdata.DayCount - statdata.HolidayCount, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_1.Cells.Add(GetCell(2, statdata.HolidayCount, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_1.Cells.Add(GetCell(2, statdata.StreetWashingCount, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    tblResume.Rows.Add(row_1)

    AddHeaderGroup(tblResume)

    Dim row_2 As New TableRow
    row_2.Cells.Add(GetCell(5, "", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row_2.Cells.Add(GetCell(2, "Totale", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_2.Cells.Add(GetCell(2, "Media g.", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_2.Cells.Add(GetCell(2, "Totale", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_2.Cells.Add(GetCell(2, "Media g.", mk_CSSCLASS_TITLE, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    tblResume.Rows.Add(row_2)

    Dim row_3 As New TableRow
    row_3.Cells.Add(GetCell(5, "Totale", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row_3.Cells.Add(GetCell(2, statdata.TotalIn, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_3.Cells.Add(GetCell(2, statdata.AverageIn, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_3.Cells.Add(GetCell(2, statdata.TotalOut, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_3.Cells.Add(GetCell(2, statdata.AverageOut, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    tblResume.Rows.Add(row_3)

    Dim row_4 As New TableRow
    row_4.Cells.Add(GetCell(5, "Seabo", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row_4.Cells.Add(GetCell(2, statdata.Total_StreetWashing, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_4.Cells.Add(GetCell(2, statdata.AverageStreetWashing, mk_CSSCLASS_WORKDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row_4.Cells.Add(GetCell(2, "*****", mk_CSSCLASS_STRWDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row_4.Cells.Add(GetCell(2, "*****", mk_CSSCLASS_STRWDAY, 2 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    tblResume.Rows.Add(row_4)

  End Sub

  Private Sub FormatTable(ByRef tbl As Table)

    tbl.Rows.Clear()
    tbl.CssClass = "supStat_DetailTable"
    tbl.CellPadding = 0
    tbl.CellSpacing = 0
    tbl.Width = Unit.Pixel(mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG + 8 * mk_WIDTH_NUMBER)

  End Sub

  Private Sub AddHeaderGroup(ByRef tbl As Table)

    Dim row As New TableRow
    row.Cells.Add(GetCell(5, "", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR + mk_WIDTH_MONTH + mk_WIDTH_WEEKDAY + mk_WIDTH_DATE + mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(4, "In Ingresso", mk_CSSCLASS_TITLE, 4 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(4, "In Uscita", mk_CSSCLASS_TITLE, 4 * mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddHeader(ByRef tbl As Table)

    Dim row As New TableRow
    row.Cells.Add(GetCell(0, "Anno", mk_CSSCLASS_TITLE, mk_WIDTH_YEAR, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "Mese", mk_CSSCLASS_TITLE, mk_WIDTH_MONTH, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "Giorno", mk_CSSCLASS_TITLE, mk_WIDTH_WEEKDAY, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "Data", mk_CSSCLASS_TITLE, mk_WIDTH_DATE, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "Pul.Strade", mk_CSSCLASS_TITLE, mk_WIDTH_STRFLAG, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "Totale", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "0-7", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "7-20", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "20-24", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "Totale", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Left, False))
    row.Cells.Add(GetCell(0, "0-7", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "7-20", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, "20-24", mk_CSSCLASS_TITLE, mk_WIDTH_NUMBER, HorizontalAlign.Center, False))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddRow(ByRef tbl As Table, ByVal det As supStatDetail)

    Dim strCssClass As String
    Dim row As New TableRow

    If det.IsHoliday Then
      If det.StreetWashing Then
        strCssClass = mk_CSSCLASS_STRHDAY
      Else
        strCssClass = mk_CSSCLASS_HOLIDAY
      End If
    Else
      If det.StreetWashing Then
        strCssClass = mk_CSSCLASS_STRWDAY
      Else
        strCssClass = mk_CSSCLASS_WORKDAY
      End If
    End If

    row.Cells.Add(GetCell(0, CStr(det.Day.Year), strCssClass, mk_WIDTH_YEAR, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, supFunction.MonthName(det.Day.Month, supFunction.supMonthNameEnum.mneShortName), strCssClass, mk_WIDTH_MONTH, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, supFunction.WeekdayName(det.Day, supFunction.supWeekdayNameEnum.wneShortName), strCssClass, mk_WIDTH_WEEKDAY, HorizontalAlign.Center, False))
    row.Cells.Add(GetCell(0, supFunction.FormatDate(det.Day, supFunction.supDateFormatEnum.dfeShortDate), strCssClass, mk_WIDTH_DATE, HorizontalAlign.Center, False))
    If det.StreetWashing Then
      row.Cells.Add(GetCell(0, "SEABO", strCssClass, mk_WIDTH_STRFLAG, HorizontalAlign.Center, False))
    Else
      row.Cells.Add(GetCell(0, "", strCssClass, mk_WIDTH_STRFLAG, HorizontalAlign.Center, False))
    End If

    row.Cells.Add(GetCell(0, det.TotalIn, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, True))
    row.Cells.Add(GetCell(0, det.NumberIn_ZeroSeven, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row.Cells.Add(GetCell(0, det.NumberIn_SevenTwenty, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row.Cells.Add(GetCell(0, det.NumberIn_TwentyZero, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row.Cells.Add(GetCell(0, det.TotalOut, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, True))
    row.Cells.Add(GetCell(0, det.NumberOut_ZeroSeven, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row.Cells.Add(GetCell(0, det.NumberOut_SevenTwenty, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))
    row.Cells.Add(GetCell(0, det.NumberOut_TwentyZero, strCssClass, mk_WIDTH_NUMBER, HorizontalAlign.Right, False))

    tbl.Rows.Add(row)

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intAlignment As HorizontalAlign, ByVal blnBold As Boolean) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    If (strText = "0") Then
      cell.Text = ""
    Else
      cell.Text = strText
    End If
    cell.CssClass = strCssClass
    cell.HorizontalAlign = intAlignment
    cell.Width = Unit.Pixel(intWidth)
    cell.Font.Bold = blnBold
    Return cell

  End Function

End Class
