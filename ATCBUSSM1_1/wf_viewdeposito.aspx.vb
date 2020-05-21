Public Class wf_viewdeposito
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents ddlState As System.Web.UI.WebControls.DropDownList
  Protected WithEvents ddlType As System.Web.UI.WebControls.DropDownList
  Protected WithEvents ddlMark As System.Web.UI.WebControls.DropDownList
  Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtPlate As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
  Protected WithEvents lblCount As System.Web.UI.WebControls.Label
  Protected WithEvents lblTitle As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Private Const mk_COL0_WIDTH As Integer = 40
  Private Const mk_COL1_WIDTH As Integer = 120
  Private Const mk_COL2_WIDTH As Integer = 80
  Private Const mk_COL3_WIDTH As Integer = 120
  Private Const mk_COL4_WIDTH As Integer = 120
  Private Const mk_COL5_WIDTH As Integer = 120
  Private Const mk_COL6_WIDTH As Integer = 90
  Private Const mk_COL7_WIDTH As Integer = 80

  Private Const mk_ROWHEIGHT As Integer = 15

  Private m_intModule As Integer
  Private m_intMode As Integer

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    m_intModule = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_ModuleID))
    m_intMode = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_Mode))

    Try
      If Not IsPostBack Then
        ddlState.Items.Add("Veicoli in deposito")
        ddlState.Items(0).Value = 0
        Select Case m_intMode
          Case 1
            ddlState.Items.Add("Veicoli demoliti")
          Case 2
            ddlState.Items.Add("Veicoli cancellati")
          Case 3
            ddlState.Items.Add("Veicoli shadowed")
        End Select
        ddlState.Items(1).Value = 1
        ddlState.SelectedIndex = 0
        supFunction.Fill_ddlVehicleType(ddlType)
        Fill()
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub Fill()

    Dim intState As supVehicleSearch.VehicleStateEnum
    Dim intFK_TiMe, intFK_MaMe, intFK_MoMe As Integer

    tbl.Rows.Clear()

    If (ddlState.SelectedIndex = 0) Then
      lblTitle.Text = "Veicoli in deposito"
      intState = supVehicleSearch.VehicleStateEnum.vsePresent
    Else
      Select Case m_intMode
        Case 1
          lblTitle.Text = "Veicoli demoliti"
          intState = supVehicleSearch.VehicleStateEnum.vseDemolished
        Case 2
          lblTitle.Text = "Veicoli cancellati"
          intState = supVehicleSearch.VehicleStateEnum.vseDeleted
        Case 3
          lblTitle.Text = "Veicoli shadowed"
          intState = supVehicleSearch.VehicleStateEnum.vseShadowed
      End Select
    End If
    If (ddlType.SelectedIndex > 0) Then
      intFK_TiMe = System.Convert.ToInt32(ddlType.SelectedValue)
    Else
      intFK_TiMe = 0
    End If
    If (ddlMark.SelectedIndex > 0) Then
      intFK_MaMe = System.Convert.ToInt32(ddlMark.SelectedValue)
    Else
      intFK_MaMe = 0
    End If
    If (ddlModel.SelectedIndex > 0) Then
      intFK_MoMe = System.Convert.ToInt32(ddlModel.SelectedValue)
    Else
      intFK_MoMe = 0
    End If

    Dim vs As New supVehicleSearch
    vs.State = intState
    vs.Plate = txtPlate.Text.Trim
    vs.FK_TiMe = intFK_TiMe
    vs.FK_MaMe = intFK_MaMe
    vs.FK_MoMe = intFK_MoMe
    vs.Refresh()
    lblCount.Text = supFunction.FormatInteger(vs.Vehicles.Count) & " veicoli selezionati"
    AddHeader()
    AddRows(vs)

  End Sub

  Private Sub AddHeader()

    Dim row As New TableRow
    row.Cells.Add(GetCell(0, "Stato", "Deposito_HeaderCell", mk_COL0_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "Data ingresso", "Deposito_HeaderCell", mk_COL1_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "Targa", "Deposito_HeaderCell", mk_COL2_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "Tipo", "Deposito_HeaderCell", mk_COL3_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "Marca", "Deposito_HeaderCell", mk_COL4_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "Modello", "Deposito_HeaderCell", mk_COL5_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "# Verbale rim.", "Deposito_HeaderCell", mk_COL6_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    row.Cells.Add(GetCell(0, "", "Deposito_HeaderCell", mk_COL7_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddRows(ByVal vs As supVehicleSearch)

    Dim i As Integer
    Dim row As TableRow

    For i = 0 To vs.Vehicles.UBound
      row = New TableRow
      row.Cells.Add(GetCell(0, vs.Vehicles(i).State, "Deposito_DataCell", mk_COL0_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, supFunction.FormatDate(vs.Vehicles(i).DateIn, supFunction.supDateFormatEnum.dfeDateTime), "Deposito_DataCell", mk_COL1_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, vs.Vehicles(i).Plate, "Deposito_DataCell", mk_COL2_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, vs.Vehicles(i).Type, "Deposito_DataCell", mk_COL3_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, vs.Vehicles(i).Mark, "Deposito_DataCell", mk_COL4_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, vs.Vehicles(i).Model, "Deposito_DataCell", mk_COL5_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells.Add(GetCell(0, vs.Vehicles(i).NVerbale, "Deposito_DataCell", mk_COL6_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Right))
      row.Cells.Add(GetCell(0, "", "Deposito_DataCell", mk_COL7_WIDTH, mk_ROWHEIGHT, HorizontalAlign.Center))
      row.Cells(row.Cells.Count - 1).Controls.Add(GetHyperLink(vs.Vehicles(i)))
      tbl.Rows.Add(row)
    Next

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As String, ByVal intHeight As Integer, ByVal intAlign As HorizontalAlign) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.Width = Unit.Pixel(intWidth)
    cell.Height = Unit.Pixel(intHeight)
    cell.HorizontalAlign = intAlign
    Return cell

  End Function

  Private Function GetHyperLink(ByVal vehicle As supVehicle) As HyperLink

    Dim strRefState As String
    Dim strLinkText As String
    Dim strNavigateUrl As String

    Select Case m_intMode
      Case 1
        strNavigateUrl = "wf_demolition.aspx?"
        strRefState = "DML"
        strLinkText = "Demolisci"
      Case 2
        strNavigateUrl = "wf_deletevehicle.aspx?"
        strRefState = "DEL"
        strLinkText = "Cancella"
      Case 3
        strNavigateUrl = "wf_shadowvehicle.aspx?"
        strRefState = "SHA"
        strLinkText = "Shadow"
    End Select
    strNavigateUrl = strNavigateUrl & _
                     atcbConstant.QS_ModuleID & "=" & m_intModule & "&" & _
                     atcbConstant.QS_Mode & "=" & m_intMode & "&" & _
                     atcbConstant.QS_VehicleID & "=" & CStr(vehicle.PK) & "&" & _
                     atcbConstant.QS_VehiclePlate & "=" & CStr(vehicle.Plate) & "&" & _
                     atcbConstant.QS_VehicleState & "=" & CStr(vehicle.State)

    Dim hlk As New HyperLink
    hlk.ID = "hlkDem_" & CStr(vehicle.PK)
    hlk.CssClass = ""
    hlk.NavigateUrl = strNavigateUrl
    hlk.Width = Unit.Percentage(100)
    If (vehicle.State = strRefState) Then
      hlk.Text = "Reintegra"
    Else
      hlk.Text = strLinkText
    End If

    Return hlk

  End Function

  Private Sub ddlType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlType.SelectedIndexChanged

    Try
      If (ddlType.SelectedIndex > 0) Then
        Dim intFK_TiMe As Integer = System.Convert.ToInt32(ddlType.SelectedValue)
        supFunction.Fill_ddlVehicleMark(ddlMark, intFK_TiMe)
      Else
        ddlMark.Items.Clear()
      End If
      ddlModel.Items.Clear()
      Fill()
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub ddlMark_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlMark.SelectedIndexChanged

    Try
      If (ddlType.SelectedIndex > 0) Then
        If (ddlMark.SelectedIndex > 0) Then
          Dim intFK_TiMe As Integer = System.Convert.ToInt32(ddlType.SelectedValue)
          Dim intFK_MaMe As Integer = System.Convert.ToInt32(ddlMark.SelectedValue)
          supFunction.Fill_ddlVehicleModel(ddlModel, intFK_TiMe, intFK_MaMe)
          Fill()
        Else
          ddlModel.Items.Clear()
        End If
      Else
        ddlMark.Items.Clear()
        ddlModel.Items.Clear()
      End If
      Fill()
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    Fill()
  End Sub

  Private Sub ddlState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlState.SelectedIndexChanged
    Fill()
  End Sub

  Private Sub ddlModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlModel.SelectedIndexChanged
    Fill()
  End Sub
End Class
