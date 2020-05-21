Public Class wf_viewinfrazioni
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblDateBegin As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateEnd As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
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

  Private Const mk_CELL_HEIGHT As Integer = 15
  Private Const mk_COLPK_WIDTH As Integer = 50
  Private Const mk_COLCODICE_WIDTH As Integer = 50
  Private Const mk_COLARTICOLO_WIDTH As Integer = 50
  Private Const mk_COLDESC_WIDTH As Integer = 550
  Private Const mk_COLIMPORTO_WIDTH As Integer = 70

  Private Const mk_CSS_TITLEGRP As String = "supGDATCSession_DetailTitle0"
  Private Const mk_CSS_TITLE As String = "supGDATCSession_DetailTitle1"
  Private Const mk_CSS_TEXT As String = "supGDATCSession_DetailLeft"
  Private Const mk_CSS_NUMBER As String = "supGDATCSession_DetailRight"

  Private m_TarfInfr As supTariffarioInfr

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      lblDateBegin.Text = strDateBegin
      lblDateEnd.Text = strDateEnd
      lblError.Text = ""
      m_TarfInfr = New supTariffarioInfr(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      m_TarfInfr.Fetch()
      Fill()
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim i As Integer

    tbl.Rows.Clear()

    Dim row As New TableRow
    'row.Cells.Add(GetCell(1, "ID", mk_CSS_TITLE, mk_COLPK_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Articolo", mk_CSS_TITLE, mk_COLCODICE_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Codice", mk_CSS_TITLE, mk_COLARTICOLO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Descrizione", mk_CSS_TITLE, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Importo", mk_CSS_TITLE, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)
    For i = 0 To m_TarfInfr.Infrazioni.UBound
      AddItem(m_TarfInfr.Infrazioni(i))
    Next

  End Sub

  Private Sub AddItem(ByVal infr As supInfrazioneCdS)

    Dim row As New TableRow
    'row.Cells.Add(GetCell(1, infr.PK.ToString, mk_CSS_NUMBER, mk_COLPK_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, infr.Articolo, mk_CSS_NUMBER, mk_COLCODICE_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, infr.Codice, mk_CSS_NUMBER, mk_COLARTICOLO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, infr.Desc, mk_CSS_TEXT, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, supFunction.FormatEuro(infr.Importo, True), mk_CSS_NUMBER, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)

  End Sub

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
