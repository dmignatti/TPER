Imports System.Web.UI.WebControls

Public Class wf_rptincassi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tblMain As System.Web.UI.WebControls.Table
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents lblUserFilter As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateFilter As System.Web.UI.WebControls.Label
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim intGDATCUser As Integer
    Dim dtmDateBegin As DateTime
    Dim dtmDateEnd As DateTime
    Dim rpt As supRpt1

    hlkBack.NavigateUrl = "wf_incassi.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)

    Try
      intGDATCUser = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_GDATCUser))
      dtmDateBegin = supFunction.DecodeDate(System.Convert.ToString(Request.QueryString(atcbConstant.QS_DateBegin)))
      dtmDateEnd = supFunction.DecodeDate(System.Convert.ToString(Request.QueryString(atcbConstant.QS_DateEnd)))
      Try
        If (intGDATCUser = 0) Then
          rpt = New supRpt1(dtmDateBegin, dtmDateEnd)
          lblUserFilter.Text = "Tutti gli operatori"
        Else
          rpt = New supRpt1(intGDATCUser, dtmDateBegin, dtmDateEnd)
          lblUserFilter.Text = ""
        End If
        lblDateFilter.Text = "dal " & supFunction.FormatDate(dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard) & _
                             " al " & supFunction.FormatDate(dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)
        rpt.Fetch()
        FillTable(rpt)
      Catch ex As Exception
        lblError.Text = "Errore nel reperimento dati."
      End Try
    Catch ex As Exception
      lblError.Text = "I parametri non sono corretti."
    End Try

  End Sub

  Private Sub FillTable(ByRef rpt As supRpt1)

    Dim i As Integer

    Try
      tblMain.Rows.Clear()
      AddGrandTotal(rpt)
      For i = 0 To rpt.Users.UBound
        AddUser(rpt.Users(i))
      Next
    Catch ex As Exception
      lblError.Text = "Errore nella creazione del report."
    End Try

  End Sub

  Private Sub AddGrandTotal(ByRef rpt As supRpt1)

    Dim row As New TableRow

    row.Cells.Add(GetCell(44, "Totale Generale", "supReportHeader0", 0, 50, HorizontalAlign.Center))
    tblMain.Rows.Add(row)
    SetTblTotal(rpt, True)

  End Sub

  Private Sub AddUser(ByRef usr As supRpt1User)

    Dim i As Integer
    Dim row As New TableRow

    For i = 1 To 44
      row.Cells.Add(GetCell(0, ".", "supReportHeader3", 10, 10, HorizontalAlign.Center))
    Next
    tblMain.Rows.Add(row)

    row = New TableRow
    row.Cells.Add(GetCell(44, usr.Name & " (" & usr.Code & ")", "supReportHeader1", 0, 50, HorizontalAlign.Center))
    tblMain.Rows.Add(row)

    SetTblTotal(usr, True)

    'row = New TableRow
    'row.Cells.Add(GetCell(45, "", "supReportVoid1", 0, 20, HorizontalAlign.NotSet))
    'tblMain.Rows.Add(row)

    For i = 0 To usr.Days.UBound
      AddDay(usr.Days(i))
    Next

  End Sub

  Private Sub AddDay(ByRef day As supRpt1Day)

    Dim i As Integer
    Dim row As New TableRow

    For i = 1 To 44
      row.Cells.Add(GetCell(0, ".", "supReportHeader3", 10, 10, HorizontalAlign.Center))
    Next
    tblMain.Rows.Add(row)

    row = New TableRow
    row.Cells.Add(GetCell(44, supFunction.FormatDate(day.DayValue, supFunction.supDateFormatEnum.dfeLongDate), "supReportHeader2", 0, 30, HorizontalAlign.Left))
    tblMain.Rows.Add(row)

    SetTblTotal(day, False)
    For i = 0 To day.Sessions.UBound
      AddSession(day.Sessions(i))
    Next

  End Sub

  Private Sub AddSession(ByRef sess As supRpt1Session)

    Dim i As Integer
    Dim row As New TableRow
    Dim strComment As String

    For i = 1 To 44
      row.Cells.Add(GetCell(0, ".", "supReportHeader3", 10, 10, HorizontalAlign.Center))
    Next
    tblMain.Rows.Add(row)

    row = New TableRow
    row.Cells.Add(GetCell(44, "Sessione #" & sess.ID, "supReportHeader2", 0, 30, HorizontalAlign.Left))
    tblMain.Rows.Add(row)

    SetTblTotal(sess, False)

    strComment = sess.GetComment()
    If Not (strComment.Equals("")) Then
      Dim rowComment = New TableRow
      rowComment.Cells.Add(GetCell(44, strComment, "supReportHeader3", 0, 15, HorizontalAlign.Left))
      tblMain.Rows.Add(rowComment)
    End If

    For i = 0 To sess.Details.UBound
      AddDetail(sess.Details(i))
    Next

  End Sub

  Private Sub AddDetail(ByRef det As supRpt1Detail)

    Dim row As New TableRow

    'row.Cells.Add(GetCell(0, "", "supReportVoid2", 0, 15, HorizontalAlign.NotSet))
    row.Cells.Add(GetCell(6, det.Time, "supReportDetail", 0, 15, HorizontalAlign.Center))
    row.Cells.Add(GetCell(25, det.Desc, "supReportDetail", 0, 15, HorizontalAlign.Left))
    row.Cells.Add(GetCell(6, det.PaymentDesc, "supReportDetail", 0, 15, HorizontalAlign.Left))
    row.Cells.Add(GetCell(7, supFunction.FormatEuro(det.Money, False), "supReportDetail", 0, 15, HorizontalAlign.Right))
    tblMain.Rows.Add(row)

  End Sub


  Private Sub SetTblTotal(ByRef obj As Object, ByVal blnFlag As Boolean)

    Dim row0 As New TableRow
    Dim row1 As New TableRow
    Dim row2 As New TableRow
    Dim row3 As New TableRow
    Dim row4 As New TableRow

    Dim strCssClass As String = IIf(blnFlag, "supReportVoid1", "supReportVoid2")

    'row0.Cells.Add(GetCell(0, "", strCssClass, 0, 15, HorizontalAlign.NotSet))
    row0.Cells.Add(GetCell(6, "", "supReportHeader3", 0, 15, HorizontalAlign.Center))
    row0.Cells.Add(GetCell(10, "Servizi", "supReportHeader3", 0, 15, HorizontalAlign.Center))
    row0.Cells.Add(GetCell(10, "Sanzioni", "supReportHeader3", 0, 15, HorizontalAlign.Center))
    row0.Cells.Add(GetCell(11, "Totale", "supReportHeader3", 0, 15, HorizontalAlign.Center))
    row0.Cells.Add(GetCell(7, ".", "supReportHeader3", 0, 15, HorizontalAlign.NotSet))
    tblMain.Rows.Add(row0)

    'row1.Cells.Add(GetCell(0, "", strCssClass, 0, 15, HorizontalAlign.NotSet))
    row1.Cells.Add(GetCell(6, "Bancomat", "supReportHeader3", 0, 15, HorizontalAlign.Left))
    row1.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotRimzBanc, False), "supReportDetail", 0, 15, HorizontalAlign.Right))
    row1.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotInfrBanc, False), "supReportDetail", 0, 15, HorizontalAlign.Right))
    row1.Cells.Add(GetCell(11, supFunction.FormatEuro(obj.TotBanc, False), "supReportSubTotal", 0, 15, HorizontalAlign.Right))
    row1.Cells.Add(GetCell(7, ".", "supReportHeader3", 0, 15, HorizontalAlign.NotSet))
    tblMain.Rows.Add(row1)

    'row2.Cells.Add(GetCell(0, "", strCssClass, 0, 15, HorizontalAlign.NotSet))
    row2.Cells.Add(GetCell(6, "Contanti", "supReportHeader3", 0, 15, HorizontalAlign.Left))
    row2.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotRimzCash, False), "supReportDetail", 0, 15, HorizontalAlign.Right))
    row2.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotInfrCash, False), "supReportDetail", 0, 15, HorizontalAlign.Right))
    row2.Cells.Add(GetCell(11, supFunction.FormatEuro(obj.TotCash, False), "supReportSubTotal", 0, 15, HorizontalAlign.Right))
    row2.Cells.Add(GetCell(7, ".", "supReportHeader3", 0, 15, HorizontalAlign.NotSet))
    tblMain.Rows.Add(row2)

    'row3.Cells.Add(GetCell(0, "", strCssClass, 0, 15, HorizontalAlign.NotSet))
    row3.Cells.Add(GetCell(6, "Totale", "supReportHeader3", 0, 15, HorizontalAlign.Left))
    row3.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotRimz, False), "supReportSubTotal", 0, 15, HorizontalAlign.Right))
    row3.Cells.Add(GetCell(10, supFunction.FormatEuro(obj.TotInfr, False), "supReportSubTotal", 0, 15, HorizontalAlign.Right))
    row3.Cells.Add(GetCell(11, supFunction.FormatEuro(obj.Total, False), "supReportTotal", 0, 15, HorizontalAlign.Right))
    row3.Cells.Add(GetCell(7, ".", "supReportHeader3", 0, 15, HorizontalAlign.NotSet))
    tblMain.Rows.Add(row3)

    row4.Cells.Add(GetCell(44, "", "supReportHeader3", 0, 15, HorizontalAlign.NotSet))
    tblMain.Rows.Add(row4)

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intHeight As Integer, ByVal intAlignment As HorizontalAlign) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    If (intWidth > 0) Then
      cell.Width = Unit.Pixel(intWidth)
    End If
    If (intHeight > 0) Then
      cell.Height = Unit.Pixel(intHeight)
    End If
    cell.HorizontalAlign = intAlignment
    Return cell

  End Function

End Class
