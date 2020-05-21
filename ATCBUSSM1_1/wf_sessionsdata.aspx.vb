Public Class wf_sessionsdata
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tblTotal As System.Web.UI.WebControls.Table
  Protected WithEvents tblDetail As System.Web.UI.WebControls.Table
  Protected WithEvents chkFilter As System.Web.UI.WebControls.CheckBox
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtDateEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateEnd As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateEnd As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents Button1 As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Private Const m_kintCellHeight As Integer = 15

  Private Const mk_ITEM_TITLE As String = "supGDATCSession_ItemTitle"
  Private Const mk_ITEM_BODY As String = "supGDATCSession_ItemTable"

  Private Const mk_DET_TITLEGRP As String = "supGDATCSession_DetailTitle0"
  Private Const mk_DET_TITLE As String = "supGDATCSession_DetailTitle1"
  Private Const mk_DET_TITLETOT As String = "supGDATCSession_DetailTitle2"
  Private Const mk_DET_TEXT As String = "supGDATCSession_DetailLeft"
  Private Const mk_DET_DATE As String = "supGDATCSession_DetailCenter"
  Private Const mk_DET_NUMBER As String = "supGDATCSession_DetailRight"
  Private Const mk_DET_TOTAL As String = "supGDATCSession_DetailTotal"
  Private Const mk_DET_SUBTOTAL As String = "supGDATCSession_DetailSubTotal"
  Private Const mk_DET_LINK As String = "supGDATCSession_DetailLink"
  Private Const mk_DET_COL0_WIDTH As Integer = 50
  Private Const mk_DET_COL1_WIDTH As Integer = 150
  Private Const mk_DET_COL2_WIDTH As Integer = 140
  Private Const mk_DET_COL3_WIDTH As Integer = 80
  Private Const mk_ITEM_WIDTH As Integer = 750

  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      If IsPostBack Then
        m_dtmDateBegin = supFunction.DecodeDate(txtDateBegin.Text)
        m_dtmDateEnd = supFunction.DecodeDate(txtDateEnd.Text)
      Else
        SetDefault()
      End If
      lblError.Text = ""
    Catch ex As Exception
      SetDefault()
      lblError.Text = ex.Message
    End Try

    txtDateBegin.Text = supFunction.FormatDate(m_dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard)
    txtDateEnd.Text = supFunction.FormatDate(m_dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)

    Fill()

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub SetDefault()

    m_dtmDateBegin = DateTime.Today
    m_dtmDateEnd = DateTime.Today
    chkFilter.Checked = False

  End Sub

  Private Sub Fill()

    Dim sf As New supGDATCSessionFilter(m_dtmDateBegin, m_dtmDateEnd)
    Try
      sf.Fetch()
      Fill_Total(sf)
      Fill_Details(sf)
    Catch ex As Exception
    End Try

  End Sub

  Private Sub Fill_Total(ByRef sf As supGDATCSessionFilter)

    tblTotal.Rows.Clear()
    FormatTable(tblTotal)

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, "", mk_ITEM_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    tblTotal.Rows.Add(row)

    AddSubItem_Totals(tblTotal, sf.Total_BancRimz, sf.Total_BancInfr, sf.Total_CashRimz, sf.Total_CashInfr)

  End Sub

  Private Sub Fill_Details(ByRef sf As supGDATCSessionFilter)

    Dim i As Integer

    tblDetail.Rows.Clear()
    For i = 0 To sf.Days.UBound
      If chkFilter.Checked Then
        If (sf.Days(i).Total > 0) Then
          AddItem_Day(sf.Days(i))
        End If
      Else
        AddItem_Day(sf.Days(i))
      End If
    Next

  End Sub

  Private Sub FormatTable(ByRef tbl As Table)

    tbl.CellPadding = 0
    tbl.CellSpacing = 0
    tbl.Width = Unit.Pixel(mk_DET_COL1_WIDTH + 2 * mk_DET_COL2_WIDTH + 4 * mk_DET_COL3_WIDTH)

  End Sub

  Private Sub AddItem_Day(ByRef day As supGDATCSessionDay)

    If (day.Recordset.Count > 0) Then

      Dim row As New TableRow
      Dim cell As New TableCell
      Dim tbl As New Table
      FormatTable(tbl)

      tbl.Rows.Add(GetRowMono(9, " ", mk_ITEM_TITLE, m_kintCellHeight))
      tbl.Rows.Add(GetRowMono(9, "Sessioni di " & supFunction.WeekdayName(day.Day, supFunction.supWeekdayNameEnum.wneStandard) & " " & supFunction.FormatDate(day.Day, supFunction.supDateFormatEnum.dfeStandard), mk_ITEM_TITLE, m_kintCellHeight))
      'tbl.Rows.Add(GetRowMono(11, "Dettaglio", "supGDATCSession_ItemTitle", m_kintCellHeight))
      AddSubItem_Totals(tbl, day.Total_BancRimz, day.Total_BancInfr, day.Total_CashRimz, day.Total_CashInfr)
      AddSubItem_Recordset(tbl, day.Recordset)
      cell.Controls.Add(tbl)

      row.Cells.Add(cell)
      tblDetail.Rows.Add(row)

    End If

  End Sub

  Private Sub AddSubItem_Totals(ByRef tbl As Table, ByVal decBancRimz As Decimal, ByVal decBancInfr As Decimal, ByVal decCashRimz As Decimal, ByVal decCashInfr As Decimal)

    Dim row0 As New TableRow
    row0.Cells.Add(GetCell(1, "", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(1, "Pagamento", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(1, "Rim.Cus.", mk_DET_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(1, "Infr.CdS", mk_DET_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(2, "Totale", mk_DET_TITLE, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(3, "", mk_DET_TITLE, mk_DET_COL0_WIDTH + 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row0)

    Dim row1 As New TableRow
    row1.Cells.Add(GetCell(1, "", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Bancomat", mk_DET_TITLETOT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, supFunction.FormatEuro(decBancRimz, True), mk_DET_NUMBER, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, supFunction.FormatEuro(decBancInfr, True), mk_DET_NUMBER, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(2, supFunction.FormatEuro(decBancRimz + decBancInfr, True), mk_DET_SUBTOTAL, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(3, "", mk_DET_TITLE, mk_DET_COL0_WIDTH + 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row1)

    Dim row2 As New TableRow
    row2.Cells.Add(GetCell(1, "", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row2.Cells.Add(GetCell(1, "Contanti", mk_DET_TITLETOT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row2.Cells.Add(GetCell(1, supFunction.FormatEuro(decCashRimz, True), mk_DET_NUMBER, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row2.Cells.Add(GetCell(1, supFunction.FormatEuro(decCashInfr, True), mk_DET_NUMBER, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row2.Cells.Add(GetCell(2, supFunction.FormatEuro(decCashRimz + decCashInfr, True), mk_DET_SUBTOTAL, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row2.Cells.Add(GetCell(3, "", mk_DET_TITLE, mk_DET_COL0_WIDTH + 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row2)

    Dim row3 As New TableRow
    row3.Cells.Add(GetCell(1, "", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row3.Cells.Add(GetCell(1, "Totale", mk_DET_TITLETOT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row3.Cells.Add(GetCell(1, supFunction.FormatEuro(decBancRimz + decCashRimz, True), mk_DET_SUBTOTAL, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row3.Cells.Add(GetCell(1, supFunction.FormatEuro(decBancInfr + decCashInfr, True), mk_DET_SUBTOTAL, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row3.Cells.Add(GetCell(2, supFunction.FormatEuro(decBancRimz + decCashRimz + decBancInfr + decCashInfr, True), mk_DET_TOTAL, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row3.Cells.Add(GetCell(3, "", mk_DET_TITLE, mk_DET_COL0_WIDTH + 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row3)

  End Sub

  Private Sub AddSubItem_Recordset(ByRef tbl As Table, ByVal rs As supGDATCSessionRecordset)

    Dim row0 As New TableRow
    row0.Cells.Add(GetCell(4, "", mk_DET_TITLEGRP, mk_DET_COL0_WIDTH + mk_DET_COL1_WIDTH + 2 * mk_DET_COL2_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(2, "Bancomat", mk_DET_TITLEGRP, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(2, "Contanti", mk_DET_TITLEGRP, 2 * mk_DET_COL3_WIDTH, m_kintCellHeight))
    row0.Cells.Add(GetCell(1, "", mk_DET_TITLEGRP, mk_DET_COL0_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row0)

    Dim row1 As New TableRow
    row1.Cells.Add(GetCell(1, "ID", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Utente", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Data/ora inizio", mk_DET_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Data/ora fine", mk_DET_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Rim.Cus.", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Infr.CdS", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Rim.Cus. ", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "Infr.CdS", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row1.Cells.Add(GetCell(1, "", mk_DET_TITLE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    tbl.Rows.Add(row1)

    Dim i As Integer
    For i = 0 To rs.UBound
      If chkFilter.Checked Then
        If rs(i).Total > 0 Then
          AddSubItem_Record(tbl, rs(i))
        End If
      Else
        AddSubItem_Record(tbl, rs(i))
      End If
    Next

  End Sub

  Private Sub AddSubItem_Record(ByRef tbl As Table, ByRef rcd As supGDATCSessionRecord)

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, rcd.PK.ToString, mk_DET_TEXT, mk_DET_COL0_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, rcd.UserName & " - " & rcd.UserID, mk_DET_TEXT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, supFunction.FormatDate(rcd.DateOpen, supFunction.supDateFormatEnum.dfeDateTime), mk_DET_DATE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, supFunction.FormatDate(rcd.DateClose, supFunction.supDateFormatEnum.dfeDateTime), mk_DET_DATE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    If (rcd.BancRimz > 0) Then
      row.Cells.Add(GetCell(1, supFunction.FormatEuro(rcd.BancRimz, True), mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    Else
      row.Cells.Add(GetCell(1, ".", mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    End If
    If (rcd.BancInfr > 0) Then
      row.Cells.Add(GetCell(1, supFunction.FormatEuro(rcd.BancInfr, True), mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    Else
      row.Cells.Add(GetCell(1, ".", mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    End If
    If (rcd.CashRimz > 0) Then
      row.Cells.Add(GetCell(1, supFunction.FormatEuro(rcd.CashRimz, True), mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    Else
      row.Cells.Add(GetCell(1, ".", mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    End If
    If (rcd.CashInfr > 0) Then
      row.Cells.Add(GetCell(1, supFunction.FormatEuro(rcd.CashInfr, True), mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    Else
      row.Cells.Add(GetCell(1, ".", mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    End If

    row.Cells.Add(GetCell(1, "", mk_DET_DATE, mk_DET_COL0_WIDTH, m_kintCellHeight))
    Dim hlk As New HyperLink
    hlk.Text = "Log"
    hlk.CssClass = mk_DET_LINK
    hlk.NavigateUrl = "wf_sessiondetail.aspx?" & _
                      atcbConstant.QS_SessionPK & "=" & rcd.PK.ToString & "&" & _
                      atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) '& "&" & _
    'atcbConstant.QS_DayBegin & "=" & CStr(m_dtmDateBegin.Day) & "&" & _
    'atcbConstant.QS_MonthBegin & "=" & CStr(m_dtmDateBegin.Month) & "&" & _
    'atcbConstant.QS_YearBegin & "=" & CStr(m_dtmDateBegin.Year) & "&" & _
    'atcbConstant.QS_DayEnd & "=" & CStr(m_dtmDateEnd.Day) & "&" & _
    'atcbConstant.QS_MonthEnd & "=" & CStr(m_dtmDateEnd.Month) & "&" & _
    'atcbConstant.QS_YearEnd & "=" & CStr(m_dtmDateEnd.Year)


    row.Cells(row.Cells.Count - 1).Controls.Add(hlk)

    'row.Cells.Add(GetCell(1, rcd.State, "supGDATCSession_DetailLeft", 100, m_kintCellHeight))
    'row.Cells.Add(GetCell(1, rcd.Notes, "supGDATCSession_DetailLeft", 100, m_kintCellHeight))
    tbl.Rows.Add(row)

  End Sub

  Private Function GetRowMono(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intHeight As Integer) As TableRow

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.Height = Unit.Pixel(intHeight)

    Dim row As New TableRow
    row.Cells.Add(cell)
    Return row

  End Function

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As String, ByVal intHeight As Integer) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.Width = Unit.Pixel(intWidth)
    cell.Height = Unit.Pixel(intHeight)
    Return cell

  End Function

End Class
