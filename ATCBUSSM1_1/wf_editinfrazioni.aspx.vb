Public Class wf_editinfrazioni
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents txtOldRate As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtNewRate As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnGo As System.Web.UI.WebControls.Button
  Protected WithEvents hidRows As System.Web.UI.HtmlControls.HtmlInputHidden
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
  Private Const mk_COLPK_WIDTH As Integer = 30
  Private Const mk_COLCODICE_WIDTH As Integer = 50
  Private Const mk_COLARTICOLO_WIDTH As Integer = 50
  Private Const mk_COLDESC_WIDTH As Integer = 550
  Private Const mk_COLIMPORTO_WIDTH As Integer = 70

  Private Const mk_CSS_TITLEGRP As String = "supGDATCSession_DetailTitle0"
  Private Const mk_CSS_TITLE As String = "supGDATCSession_DetailTitle1"
  Private Const mk_CSS_TEXT As String = "supGDATCSession_DetailLeft"
  Private Const mk_CSS_NUMBER As String = "supGDATCSession_DetailRight"
  Private Const mk_CSS_TEXTBOX As String = "supUpdInfr_TextBox"

  Private m_intDBMode As atcbConstant.DBModeEnum

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strDateBegin, strDateEnd As String
    Dim dtmDateBegin, dtmDateEnd As DateTime

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      m_intDBMode = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_DBMode))
      If Not IsPostBack Then
        txtDateBegin.Text = strDateBegin
      End If
      lblDateEnd.Text = strDateEnd
      lblError.Text = ""
      btnSave.Attributes.Add("onclick", "return(confirm(BeforeDelete()));")
      btnSave.Visible = True
      ' ***********************************
      If (m_intDBMode = atcbConstant.DBModeEnum.dbmForInsert) Then
        supTariffarioInfr.GetCurrentInterval(dtmDateBegin, dtmDateEnd)
        If Not IsPostBack Then
          lblError.Text = "Sono state importate le tariffe del tariffario in vigore."
        End If
      Else
        dtmDateBegin = supFunction.DecodeDate(strDateBegin)
        dtmDateEnd = supFunction.DecodeDate(strDateEnd)
      End If
      Dim TarfInfr = New supTariffarioInfr(dtmDateBegin, dtmDateEnd)
      TarfInfr.Fetch()
      Fill(TarfInfr)
    Catch ex As Exception
      lblError.Text = ex.Message
      btnSave.Visible = False
    End Try

    hlkBack.NavigateUrl = "wf_tariffarioinfrazioni.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

    Dim i As Integer
    Dim txt As TextBox

    Try
      If supFunction.IsMoney_Euro(txtOldRate.Text.Trim) Then
        If supFunction.IsMoney_Euro(txtNewRate.Text.Trim) Then
          For i = 1 To (tbl.Rows.Count - 1)
            Try
              txt = tbl.FindControl("txtImporto_" & i.ToString)
              If (txt.Text = txtOldRate.Text) Then
                txt.Text = txtNewRate.Text
              End If
            Catch ex As Exception
              lblError.Text = "E'stato impossibile sostituire alcuni importi."
            End Try
          Next
        End If
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      Dim TarfInfr As New supTariffarioInfr(supFunction.DecodeDate(txtDateBegin.Text), supFunction.DecodeDate(lblDateEnd.Text))
      StoreData(TarfInfr)
      If TarfInfr.Save() Then
        Response.Redirect("wf_tariffarioinfrazioni.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID))
      Else
        lblError.Text = "Errori nel salvataggio dei dati."
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

  'Private Function EnableCalendar(ByVal blnValue As Boolean)

  '  txtDayBegin.Enabled = blnValue
  '  txtMonthBegin.Enabled = blnValue
  '  txtYearBegin.Enabled = blnValue

  'End Function

  Private Sub Fill(ByVal TarfInfr As supTariffarioInfr)

    Dim i, Index As Integer

    tbl.Rows.Clear()

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "Canc.", mk_CSS_TITLE, mk_COLPK_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Articolo", mk_CSS_TITLE, mk_COLCODICE_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Codice", mk_CSS_TITLE, mk_COLARTICOLO_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Descrizione", mk_CSS_TITLE, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells.Add(GetCell(1, "Importo", mk_CSS_TITLE, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    tbl.Rows.Add(row)
    For i = 0 To TarfInfr.Infrazioni.UBound
      Index = i + 1
      AddItem(TarfInfr.Infrazioni(i), Index)
    Next
    hidRows.Value = tbl.Rows.Count - 1

  End Sub

  Private Sub AddItem(ByVal infr As supInfrazioneCdS, ByVal Index As Integer)

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, "", mk_CSS_NUMBER, mk_COLPK_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetCheckBox("chkSel_" & Index.ToString, False, mk_CSS_TEXTBOX, Index))

    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLCODICE_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtArticolo_" & Index.ToString, infr.Articolo, mk_CSS_TEXTBOX))

    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLARTICOLO_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtCodice_" & Index.ToString, infr.Codice, mk_CSS_TEXTBOX))

    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLDESC_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtDesc_" & Index.ToString, infr.Desc, mk_CSS_TEXTBOX))

    row.Cells.Add(GetCell(1, "", mk_CSS_NUMBER, mk_COLIMPORTO_WIDTH, mk_CELL_HEIGHT))
    row.Cells(row.Cells.Count - 1).Controls.Add(GetTextBox("txtImporto_" & Index.ToString, supFunction.FormatEuro(infr.Importo, False), mk_CSS_TEXTBOX))

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

  Private Function GetCheckBox(ByVal strID As String, ByVal blnChecked As Boolean, ByVal strCssClass As String, ByVal Index As Integer) As CheckBox

    Dim chk As New CheckBox
    chk.ID = strID
    chk.Checked = blnChecked
    chk.CssClass = strCssClass
    chk.Attributes.Add("Runat", "server")
    chk.Attributes.Add("onclick", "javascript: chkSel_Click(" & Index.ToString & ")")
    Return chk

  End Function

  Private Sub StoreData(ByRef TarfInfr As supTariffarioInfr)

    Dim i As Integer
    Dim chkSel As CheckBox
    Dim txtArticolo, txtCodice, txtDesc, txtImporto As TextBox

    TarfInfr.Infrazioni.Clear()
    For i = 1 To (tbl.Rows.Count - 1)
      Try
        chkSel = tbl.FindControl("chkSel_" & i.ToString)
        txtArticolo = tbl.FindControl("txtArticolo_" & i.ToString)
        txtCodice = tbl.FindControl("txtCodice_" & i.ToString)
        txtDesc = tbl.FindControl("txtDesc_" & i.ToString)
        txtImporto = tbl.FindControl("txtImporto_" & i.ToString)
        Try
          If Not chkSel.Checked Then
            TarfInfr.Infrazioni.Add(0, txtCodice.Text.Trim, txtArticolo.Text.Trim, txtDesc.Text.Trim, supFunction.ToMoney_Euro(txtImporto.Text.Trim))
          End If
        Catch ex As Exception
          Throw New Exception(ex.Message)
        End Try
      Catch ex As Exception
        Throw New Exception("Errore in lettura dati utente (riga " & i.ToString & ")")
      End Try
    Next

  End Sub

End Class
