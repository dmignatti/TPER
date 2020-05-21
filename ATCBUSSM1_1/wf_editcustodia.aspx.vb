Public Class wf_editcustodia
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblDateEnd As System.Web.UI.WebControls.Label

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
  Private Const mk_CSS_TEXTBOX As String = "supTarf_TextBox"

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      If Not IsPostBack Then
        txtDateBegin.Text = strDateBegin
      End If
      lblDateEnd.Text = strDateEnd
      lblError.Text = ""
      btnSave.Visible = True
      Dim TarfCust As New supTariffarioCustodia(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      Fill(TarfCust)
    Catch ex As Exception
      lblError.Text = ex.Message
      btnSave.Visible = False
    End Try

    hlkBack.NavigateUrl = "wf_tariffariocustodia.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      Dim TarfCust As New supTariffarioCustodia(supFunction.DecodeDate(txtDateBegin.Text), supFunction.DecodeDate(lblDateEnd.Text))
      StoreData(TarfCust)
      If TarfCust.Save() Then
        Response.Redirect("wf_tariffariocustodia.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID))
      Else
        lblError.Text = "Errori nel salvataggio dei dati."
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill(ByVal TarfCust As supTariffarioCustodia)

    Dim i As Integer

    tbl.Rows.Clear()

    AddColHeaders()
    AddItem("5", TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Meno_di_12_ore))
    AddItem("6", TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Primo_giorno))
    AddItem("7", TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Secondo_giorno))

  End Sub

  Private Sub AddColHeaders()

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "Descrizione", mk_CSS_COLHEADER, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Importo (€)", mk_CSS_COLHEADER, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddItem(ByVal strIndex As String, ByVal tarf As supTarfCustodia)

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
    row.Cells.Add(GetCell(1, "", strStyle_2, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtCustodia_" & strIndex, supFunction.FormatEuro(tarf.Importo, False), mk_CSS_TEXTBOX))
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

  Private Function GetTextBox(ByVal strID As String, ByVal strText As String, ByVal strCssClass As String) As TextBox

    Dim txt As New TextBox
    txt.ID = strID
    txt.Text = strText
    txt.CssClass = strCssClass
    txt.Attributes.Add("Runat", "server")
    Return txt

  End Function

  Private Sub StoreData(ByRef TarfCust As supTariffarioCustodia)

    Dim txtImp_5, txtImp_6, txtImp_7 As TextBox

    Try
      txtImp_5 = tbl.FindControl("txtCustodia_5")
      txtImp_6 = tbl.FindControl("txtCustodia_6")
      txtImp_7 = tbl.FindControl("txtCustodia_7")
      TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Meno_di_12_ore).Importo = supFunction.ToMoney_Euro(txtImp_5.Text)
      TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Primo_giorno).Importo = supFunction.ToMoney_Euro(txtImp_6.Text)
      TarfCust.Tariffa(supTarfCustodia.CausaleEnum.Secondo_giorno).Importo = supFunction.ToMoney_Euro(txtImp_7.Text)
    Catch ex As Exception
      Throw New Exception("Errore in lettura dati utente")
    End Try

  End Sub

End Class
