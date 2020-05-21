Public Class wf_editrimozione
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
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
  Private Const mk_COLPESO_WIDTH As Integer = 90
  Private Const mk_COLDESC_WIDTH As Integer = 300
  Private Const mk_COLIMPORTO_WIDTH As Integer = 60
  Private Const mk_COLRINCARO_WIDTH As Integer = 80

  Private Const mk_CSS_TITLE As String = "supTarf_Title"
  Private Const mk_CSS_COLHEADER As String = "supTarf_ColHeader"
  Private Const mk_CSS_PESO1DAY_TEXT As String = "supTarf_Peso1Day_Text"
  Private Const mk_CSS_PESO1DAY_NUMBER As String = "supTarf_Peso1Day_Number"
  Private Const mk_CSS_PESO1NIGHT_TEXT As String = "supTarf_Peso1Night_Text"
  Private Const mk_CSS_PESO1NIGHT_NUMBER As String = "supTarf_Peso1Night_Number"
  Private Const mk_CSS_PESO2DAY_TEXT As String = "supTarf_Peso2Day_Text"
  Private Const mk_CSS_PESO2DAY_NUMBER As String = "supTarf_Peso2Day_Number"
  Private Const mk_CSS_PESO2NIGHT_TEXT As String = "supTarf_Peso2Night_Text"
  Private Const mk_CSS_PESO2NIGHT_NUMBER As String = "supTarf_Peso2Night_Number"
  Private Const mk_CSS_PESO3DAY_TEXT As String = "supTarf_Peso3Day_Text"
  Private Const mk_CSS_PESO3DAY_NUMBER As String = "supTarf_Peso3Day_Number"
  Private Const mk_CSS_PESO3NIGHT_TEXT As String = "supTarf_Peso3Night_Text"
  Private Const mk_CSS_PESO3NIGHT_NUMBER As String = "supTarf_Peso3Night_Number"
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
      Dim TarfRimz As New supTariffarioRimozione(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      Fill(TarfRimz)
    Catch ex As Exception
      lblError.Text = ex.Message
      btnSave.Visible = False
    End Try

    hlkBack.NavigateUrl = "wf_tariffariorimozione.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      Dim TarfRimz As New supTariffarioRimozione(supFunction.DecodeDate(txtDateBegin.Text), supFunction.DecodeDate(lblDateEnd.Text))
      StoreData(TarfRimz)
      If TarfRimz.Save() Then
        Response.Redirect("wf_tariffariorimozione.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID))
      Else
        lblError.Text = "Errori nel salvataggio dei dati."
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill(ByVal TarfRimz As supTariffarioRimozione)

    Dim i As Integer

    tbl.Rows.Clear()

    AddTitle("Diritto di chiamata")
    AddColHeaders()
    AddItem("Fino a 15 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "111")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "112")
    AddItem("Da 15 a 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "121")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "122")
    AddItem("Oltre 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "131")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "132")

    AddTitle("")
    AddTitle("Operazioni connesse alla rimozione")
    AddColHeaders()
    AddItem("Fino a 15 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "211")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "212")
    AddItem("Da 15 a 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "221")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "222")
    AddItem("Oltre 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "231")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "232")

    AddTitle("")
    AddTitle("Trasporto (costo al kilometro)")
    AddColHeaders()
    AddItem("Fino a 15 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "311")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "312")
    AddItem("Da 15 a 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "321")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "322")
    AddItem("Oltre 35 q.li", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali), "331")
    AddItem("", TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi), "332")

  End Sub

  Private Sub AddTitle(ByVal strTitle As String)

    Dim row As New TableRow
    row.Cells.Add(GetCell(4, strTitle, mk_CSS_TITLE, mk_COLPESO_WIDTH + mk_COLDESC_WIDTH + mk_COLIMPORTO_WIDTH + mk_COLRINCARO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddColHeaders()

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "Categoria Peso", mk_CSS_COLHEADER, mk_COLPESO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Descrizione", mk_CSS_COLHEADER, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Importo (€)", mk_CSS_COLHEADER, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Rincaro per ton.", mk_CSS_COLHEADER, mk_COLRINCARO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddItem(ByVal strChapter As String, ByVal tarf As supTariffa, ByVal strIndex As String)

    Dim strStyle_1, strStyle_2 As String
    Dim row As New TableRow

    Select Case tarf.FK_Peso
      Case supTariffa.CategoriaPesoEnum.FinoA15
        If (tarf.FK_FOra = supTariffa.FasciaOrariaEnum.DiurnaFeriali) Then
          strStyle_1 = mk_CSS_PESO1DAY_TEXT
          strStyle_2 = mk_CSS_PESO1DAY_NUMBER
        Else
          strStyle_1 = mk_CSS_PESO1NIGHT_TEXT
          strStyle_2 = mk_CSS_PESO1NIGHT_NUMBER
        End If
      Case supTariffa.CategoriaPesoEnum.FinoA35
        If (tarf.FK_FOra = supTariffa.FasciaOrariaEnum.DiurnaFeriali) Then
          strStyle_1 = mk_CSS_PESO2DAY_TEXT
          strStyle_2 = mk_CSS_PESO2DAY_NUMBER
        Else
          strStyle_1 = mk_CSS_PESO2NIGHT_TEXT
          strStyle_2 = mk_CSS_PESO2NIGHT_NUMBER
        End If
      Case supTariffa.CategoriaPesoEnum.Oltre35
        If (tarf.FK_FOra = supTariffa.FasciaOrariaEnum.DiurnaFeriali) Then
          strStyle_1 = mk_CSS_PESO3DAY_TEXT
          strStyle_2 = mk_CSS_PESO3DAY_NUMBER
        Else
          strStyle_1 = mk_CSS_PESO3NIGHT_TEXT
          strStyle_2 = mk_CSS_PESO3NIGHT_NUMBER
        End If
    End Select

    row.Cells.Add(GetCell(1, strChapter, strStyle_1, mk_COLPESO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, tarf.Desc, strStyle_1, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "", strStyle_2, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtImporto_" & strIndex, supFunction.FormatEuro(tarf.Importo, False), mk_CSS_TEXTBOX))
    row.Cells.Add(GetCell(1, "", strStyle_2, mk_COLRINCARO_WIDTH, mk_CELL_HEIGHT))
    If (tarf.FK_Peso = supTariffa.CategoriaPesoEnum.Oltre35) Then
      row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtRincaro_" & strIndex, "10", mk_CSS_TEXTBOX))
    End If
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

  Private Sub StoreData(ByRef TarfRimz As supTariffarioRimozione)

    Dim txtImp_111, txtImp_112, txtImp_121, txtImp_122, txtImp_131, txtImp_132 As TextBox
    Dim txtImp_211, txtImp_212, txtImp_221, txtImp_222, txtImp_231, txtImp_232 As TextBox
    Dim txtImp_311, txtImp_312, txtImp_321, txtImp_322, txtImp_331, txtImp_332 As TextBox
    Dim txtRin_131, txtRin_132, txtRin_231, txtRin_232, txtRin_331, txtRin_332 As TextBox

    Try
      txtImp_111 = tbl.FindControl("txtImporto_111")
      txtImp_112 = tbl.FindControl("txtImporto_112")
      txtImp_121 = tbl.FindControl("txtImporto_121")
      txtImp_122 = tbl.FindControl("txtImporto_122")
      txtImp_131 = tbl.FindControl("txtImporto_131")
      txtImp_132 = tbl.FindControl("txtImporto_132")
      txtImp_211 = tbl.FindControl("txtImporto_211")
      txtImp_212 = tbl.FindControl("txtImporto_212")
      txtImp_221 = tbl.FindControl("txtImporto_221")
      txtImp_222 = tbl.FindControl("txtImporto_222")
      txtImp_231 = tbl.FindControl("txtImporto_231")
      txtImp_232 = tbl.FindControl("txtImporto_232")
      txtImp_311 = tbl.FindControl("txtImporto_311")
      txtImp_312 = tbl.FindControl("txtImporto_312")
      txtImp_321 = tbl.FindControl("txtImporto_321")
      txtImp_322 = tbl.FindControl("txtImporto_322")
      txtImp_331 = tbl.FindControl("txtImporto_331")
      txtImp_332 = tbl.FindControl("txtImporto_332")

      txtRin_131 = tbl.FindControl("txtRincaro_131")
      txtRin_132 = tbl.FindControl("txtRincaro_132")
      txtRin_231 = tbl.FindControl("txtRincaro_231")
      txtRin_232 = tbl.FindControl("txtRincaro_232")
      txtRin_331 = tbl.FindControl("txtRincaro_331")
      txtRin_332 = tbl.FindControl("txtRincaro_332")

      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_111.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_112.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_121.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_122.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_131.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_132.Text)

      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_211.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_212.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_221.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_222.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_231.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_232.Text)

      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_311.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_312.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_321.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_322.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).Importo = supFunction.ToMoney_Euro(txtImp_331.Text)
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).Importo = supFunction.ToMoney_Euro(txtImp_332.Text)

      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_131.Text))
      TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_132.Text))
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_231.Text))
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_232.Text))
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_331.Text))
      TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi).RincaroPerTon = CDbl(System.Convert.ToInt32(txtRin_332.Text))

    Catch ex As Exception
      Throw New Exception("Errore in lettura dati utente")
    End Try

  End Sub

End Class
