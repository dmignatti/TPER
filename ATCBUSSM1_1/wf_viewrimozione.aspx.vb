Public Class wf_viewrimozione
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

  Private m_TarfRimz As supTariffarioRimozione

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      lblDateBegin.Text = strDateBegin
      lblDateEnd.Text = strDateEnd
      lblError.Text = ""
      m_TarfRimz = New supTariffarioRimozione(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      Fill()
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim i As Integer

    tbl.Rows.Clear()

    AddTitle("Diritto di chiamata")
    AddColHeaders()
    AddItem("Fino a 15 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Da 15 a 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Oltre 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.DirittoChiamata, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))

    AddTitle("")
    AddTitle("Operazioni connesse alla rimozione")
    AddColHeaders()
    AddItem("Fino a 15 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Da 15 a 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Oltre 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Rimozione, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))

    AddTitle("")
    AddTitle("Trasporto (costo al kilometro)")
    AddColHeaders()
    AddItem("Fino a 15 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA15, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Da 15 a 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.FinoA35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))
    AddItem("Oltre 35 q.li", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.DiurnaFeriali))
    AddItem("", m_TarfRimz.Tariffa(supTariffa.CausaleEnum.Trasporto, supTariffa.CategoriaPesoEnum.Oltre35, supTariffa.FasciaOrariaEnum.NotturnaEFestivi))

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

  Private Sub AddItem(ByVal strChapter As String, ByVal tarf As supTariffa)

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
    row.Cells.Add(GetCell(1, supFunction.FormatEuro(tarf.Importo, False), strStyle_2, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    If (tarf.RincaroPerTon > 0) Then
      row.Cells.Add(GetCell(1, CStr(tarf.RincaroPerTon) & "%", strStyle_2, mk_COLRINCARO_WIDTH, mk_CELL_HEIGHT))
    Else
      row.Cells.Add(GetCell(1, "", strStyle_2, mk_COLRINCARO_WIDTH, mk_CELL_HEIGHT))
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

End Class
