Public Class wf_viewcustodia
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateBegin As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateEnd As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
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

  Private Const mk_CELL_HEIGHT As Integer = 15
  Private Const mk_COLDESC_WIDTH As Integer = 300
  Private Const mk_COLIMPORTO_WIDTH As Integer = 60

  Private Const mk_CSS_TITLE As String = "supTarf_Title"
  Private Const mk_CSS_COLHEADER As String = "supTarf_ColHeader"
  Private Const mk_CSS_TARF5_TEXT As String = "supTarf_Peso1Day_Text"
  Private Const mk_CSS_TARF5_NUMBER As String = "supTarf_Peso1Day_Number"
  Private Const mk_CSS_TARF6_TEXT As String = "supTarf_Peso2Day_Text"
  Private Const mk_CSS_TARF6_NUMBER As String = "supTarf_Peso2Day_Number"
  Private Const mk_CSS_TARF7_TEXT As String = "supTarf_Peso3Day_Text"
  Private Const mk_CSS_TARF7_NUMBER As String = "supTarf_Peso3Day_Number"

  Private m_TarfCust As supTariffarioCustodia

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      lblDateBegin.Text = strDateBegin
      lblDateEnd.Text = strDateEnd
      lblError.Text = ""
      m_TarfCust = New supTariffarioCustodia(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      Fill()
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim i As Integer

    tbl.Rows.Clear()

    AddColHeaders()
    AddItem(m_TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Meno_di_12_ore))
    AddItem(m_TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Primo_giorno))
    AddItem(m_TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Secondo_giorno))

  End Sub

  Private Sub AddColHeaders()

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "Descrizione", mk_CSS_COLHEADER, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Importo (€)", mk_CSS_COLHEADER, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddItem(ByVal tarf As supTarfCustodia)

    Dim strStyle_1, strStyle_2 As String
    Dim row As New TableRow

    Select Case tarf.FK_CaIm
      Case supTarfCustodia.CausaleEnum.Meno_di_12_ore
        strStyle_1 = mk_CSS_TARF5_TEXT
        strStyle_2 = mk_CSS_TARF5_NUMBER
      Case supTarfCustodia.CausaleEnum.Primo_giorno
        strStyle_1 = mk_CSS_TARF6_TEXT
        strStyle_2 = mk_CSS_TARF6_NUMBER
      Case supTarfCustodia.CausaleEnum.Secondo_giorno
        strStyle_1 = mk_CSS_TARF7_TEXT
        strStyle_2 = mk_CSS_TARF7_NUMBER
    End Select
    row.Cells.Add(GetCell(1, tarf.Desc, strStyle_1, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, supFunction.FormatEuro(tarf.Importo, False), strStyle_2, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
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
