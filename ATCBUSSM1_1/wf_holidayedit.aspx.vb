Public Class wf_holidayedit
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblState As System.Web.UI.WebControls.Label
  Protected WithEvents hidRows As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents btnImport As System.Web.UI.WebControls.Button
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents lblEaster As System.Web.UI.WebControls.Label
  Protected WithEvents txtYear As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Protected Const m_kiTableWidth As Integer = 300
  Protected Const m_kiColWidth_0 As Integer = 30
  Protected Const m_kiColWidth_1 As Integer = 80
  Protected Const m_kiColWidth_2 As Integer = 40
  Protected Const m_kiColWidth_3 As Integer = 150

  Protected m_strParamYear As String
  Protected m_strParamModuleID As String
  Protected m_intYear As Integer
  Protected m_HoldConf As supDBHolidayConf

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      m_strParamYear = Chr(39) & atcbConstant.QS_SelectedYear & Chr(39)
      m_strParamModuleID = Chr(39) & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & Chr(39)
    Catch ex As Exception
    End Try

    Try
      m_intYear = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_SelectedYear))
      Dim dtmTrial As New DateTime(m_intYear, 1, 1)
    Catch ex As Exception
      m_intYear = DateTime.Now.Year
    End Try
    txtYear.Text = CStr(m_intYear)

    btnSave.Attributes.Add("onclick", "return(confirm(BeforeDelete()));")
    m_HoldConf = New supDBHolidayConf(m_intYear)
    If IsPostBack Then
      SetTable(System.Convert.ToInt32(hidRows.Value))
    Else
      Refresh(m_HoldConf)
      WriteEaster()
    End If

  End Sub

  Private Sub SetTable(ByVal intRows As Integer)

    Dim i As Integer

    tbl.Controls.Clear()
    tbl.Rows.Clear()
    tbl.Width = Unit.Pixel(m_kiTableWidth)
    tbl.CellSpacing = 0
    tbl.CellPadding = 1

    AddTitle()
    For i = 1 To intRows
      AddRow(i)
    Next

    hidRows.Value = tbl.Rows.Count - 1

  End Sub

  Private Sub AddTitle()

    Dim row As New TableRow

    Dim cell_0 As New System.Web.UI.WebControls.TableCell
    cell_0.Text = "Canc."
    cell_0.CssClass = "supHolidayConf_ColTitle"
    cell_0.Width = Unit.Pixel(m_kiColWidth_0)
    row.Cells.Add(cell_0)

    Dim cell_1 As New System.Web.UI.WebControls.TableCell
    cell_1.Text = "Mese"
    cell_1.CssClass = "supHolidayConf_ColTitle"
    cell_1.Width = Unit.Pixel(m_kiColWidth_1)
    row.Cells.Add(cell_1)

    Dim cell_2 As New System.Web.UI.WebControls.TableCell
    cell_2.Text = "Giorno"
    cell_2.CssClass = "supHolidayConf_ColTitle"
    cell_2.Width = Unit.Pixel(m_kiColWidth_2)
    row.Cells.Add(cell_2)

    Dim cell_3 As New System.Web.UI.WebControls.TableCell
    cell_3.Text = "Descrizione"
    cell_3.CssClass = "supHolidayConf_ColTitle"
    cell_3.Width = Unit.Pixel(m_kiColWidth_3)
    row.Cells.Add(cell_3)

    tbl.Rows.Add(row)

  End Sub

  Private Sub AddRow(ByVal Index As Integer)

    Dim chkSel As New System.Web.UI.WebControls.CheckBox
    chkSel.ID = "chkSel_" & Index.ToString
    chkSel.Attributes.Add("runat", "server")
    chkSel.Attributes.Add("onclick", "javascript: chkSel_Click(" & Index & ")")
    chkSel.CssClass = "supHolidayConf_InputCtl"
    Dim cell_0 As New System.Web.UI.WebControls.TableCell
    cell_0.Width = Unit.Pixel(m_kiColWidth_0 - tbl.CellPadding)
    cell_0.Controls.Add(chkSel)

    Dim ddlMonth As New System.Web.UI.WebControls.DropDownList
    ddlMonth.ID = "ddlMonth_" & Index.ToString
    ddlMonth.Attributes.Add("runat", "server")
    supFunction.Fill_DllMonth(ddlMonth)
    ddlMonth.CssClass = "supHolidayConf_InputCtl"
    Dim cell_1 As New System.Web.UI.WebControls.TableCell
    cell_1.Width = Unit.Pixel(m_kiColWidth_1 - tbl.CellPadding)
    cell_1.Controls.Add(ddlMonth)

    Dim txtDay As New System.Web.UI.WebControls.TextBox
    txtDay.ID = "txtDay_" & Index.ToString
    txtDay.Attributes.Add("runat", "server")
    txtDay.CssClass = "supHolidayConf_InputCtl"
    Dim cell_2 As New System.Web.UI.WebControls.TableCell
    cell_2.Width = Unit.Pixel(m_kiColWidth_2 - tbl.CellPadding)
    cell_2.Controls.Add(txtDay)

    Dim txtDesc As New System.Web.UI.WebControls.TextBox
    txtDesc.ID = "txtDesc_" & Index.ToString
    txtDesc.Attributes.Add("runat", "server")
    txtDesc.CssClass = "supHolidayConf_InputCtl"
    Dim cell_3 As New System.Web.UI.WebControls.TableCell
    cell_3.Width = Unit.Pixel(m_kiColWidth_3 - tbl.CellPadding)
    cell_3.Controls.Add(txtDesc)

    Dim row As New TableRow
    row.Cells.Add(cell_0)
    row.Cells.Add(cell_1)
    row.Cells.Add(cell_2)
    row.Cells.Add(cell_3)

    tbl.Rows.Add(row)

  End Sub

  Private Function getCtlData(ByRef hc As supDBHolidayConf) As Boolean

    Dim bExit As Boolean
    Dim i As Integer
    Dim dtmDay As DateTime
    Dim chkSel As System.Web.UI.WebControls.CheckBox
    Dim ddlMonth As System.Web.UI.WebControls.DropDownList
    Dim txtDay As System.Web.UI.WebControls.TextBox
    Dim txtDesc As System.Web.UI.WebControls.TextBox

    If (hc Is Nothing) Then
      Return False
    Else
      hc.Holidays.Clear()
      bExit = False
      For i = 1 To tbl.Rows.Count - 1
        chkSel = tbl.FindControl("chkSel_" & i)
        ddlMonth = tbl.FindControl("ddlMonth_" & i)
        txtDay = tbl.FindControl("txtDay_" & i)
        txtDesc = tbl.FindControl("txtDesc_" & i)
        If Not chkSel.Checked Then
          Try
            dtmDay = New DateTime(m_intYear, supFunction.MonthNumber(ddlMonth.SelectedItem.Text), txtDay.Text)
            hc.Holidays.Add(dtmDay, txtDesc.Text)
          Catch ex As Exception
            lblState.Text = "Errore in lettura dati utente."
            bExit = True
          End Try
        End If
        If bExit Then Exit For
      Next
      Return (Not bExit)
    End If

  End Function

  Private Sub putCtlData(ByRef hc As supDBHolidayConf)

    Dim i, Index As Integer
    Dim ddlMonth As System.Web.UI.WebControls.DropDownList
    Dim txtDay As System.Web.UI.WebControls.TextBox
    Dim txtDesc As System.Web.UI.WebControls.TextBox

    If Not (hc Is Nothing) Then
      For i = 0 To hc.Holidays.UBound
        Index = i + 1
        ddlMonth = tbl.FindControl("ddlMonth_" & Index)
        txtDay = tbl.FindControl("txtDay_" & Index)
        txtDesc = tbl.FindControl("txtDesc_" & Index)
        ddlMonth.SelectedIndex = hc.Holidays(i).Day.Month - 1
        txtDay.Text = hc.Holidays(i).Day.Day
        txtDesc.Text = hc.Holidays(i).Desc
      Next
    End If

  End Sub

  Private Sub WriteEaster()
    lblEaster.Text = "Pasqua calc: Dom. " & supFunction.FormatDate(m_HoldConf.Easter, supFunction.supDateFormatEnum.dfeLongDate)
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    Dim intNewRows As Integer

    AddRow(tbl.Rows.Count)
    hidRows.Value = tbl.Rows.Count - 1

    intNewRows = tbl.Rows.Count - 1 - m_HoldConf.FetchCount

    If (intNewRows = 0) Then
      lblState.Text = ""
    ElseIf (intNewRows = 1) Then
      lblState.Text = "Aggiunta nuova riga"
    Else
      lblState.Text = "Aggiunte " & intNewRows.ToString & " nuove righe"
    End If

  End Sub

  Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

    Dim hc = New supDBHolidayConf(m_intYear - 1)
    Refresh(hc)
    WriteEaster()
    lblState.Text = "Festività importate da " & System.Convert.ToString(m_intYear - 1)

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    If getCtlData(m_HoldConf) Then
      If m_HoldConf.Save() Then
        lblState.Text = "I dati sono stati salvati"
        Refresh(m_HoldConf)
        WriteEaster()
      Else
        lblState.Text = "Errore nel salvataggio dei dati"
      End If
    End If

  End Sub

  Private Sub Refresh(ByRef hc As supDBHolidayConf)

    If Not (hc Is Nothing) Then
      hc.Fetch()
      SetTable(hc.Holidays.Count)
      putCtlData(hc)
    End If

  End Sub

End Class
