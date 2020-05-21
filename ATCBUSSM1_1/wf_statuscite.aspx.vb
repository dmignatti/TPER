Public Class wf_statuscite
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents txtDateInBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDateInBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents ddlState As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtDateOutEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDateInEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDateInEnd As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtDateOutBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDateOutBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents revDateOutEnd As System.Web.UI.WebControls.RegularExpressionValidator

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

    Dim strUrl As String

    If IsPostBack Then
      strUrl = "wf_rptuscite.aspx?" & _
               atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
               atcbConstant.QS_VehicleState & "=" & ddlState.SelectedValue
      If (txtDateInBegin.Text.Trim = "") Then
        strUrl = strUrl & "&" & atcbConstant.QS_DateInBegin & "=" & supFunction.FormatDate(supVehicleSearch.getDefaultDateBegin, supFunction.supDateFormatEnum.dfeStandard)
      Else
        strUrl = strUrl & "&" & atcbConstant.QS_DateInBegin & "=" & txtDateInBegin.Text
      End If
      If (txtDateInEnd.Text.Trim = "") Then
        strUrl = strUrl & "&" & atcbConstant.QS_DateInEnd & "=" & supFunction.FormatDate(supVehicleSearch.getDefaultDateEnd, supFunction.supDateFormatEnum.dfeStandard)
      Else
        strUrl = strUrl & "&" & atcbConstant.QS_DateInEnd & "=" & txtDateInEnd.Text
      End If
      If (txtDateOutBegin.Text.Trim = "") Then
        strUrl = strUrl & "&" & atcbConstant.QS_DateOutBegin & "=" & supFunction.FormatDate(supVehicleSearch.getDefaultDateBegin, supFunction.supDateFormatEnum.dfeStandard)
      Else
        strUrl = strUrl & "&" & atcbConstant.QS_DateOutBegin & "=" & txtDateOutBegin.Text
      End If
      If (txtDateOutEnd.Text.Trim = "") Then
        strUrl = strUrl & "&" & atcbConstant.QS_DateOutEnd & "=" & supFunction.FormatDate(supVehicleSearch.getDefaultDateEnd, supFunction.supDateFormatEnum.dfeStandard)
      Else
        strUrl = strUrl & "&" & atcbConstant.QS_DateOutEnd & "=" & txtDateOutEnd.Text
      End If
      Response.Redirect(strUrl)
    Else
      txtDateOutBegin.Text = supFunction.FormatDate(DateTime.Today.AddDays(-7), supFunction.supDateFormatEnum.dfeStandard)
      txtDateOutEnd.Text = supFunction.FormatDate(DateTime.Today, supFunction.supDateFormatEnum.dfeStandard)
      FillDdlState()
    End If

  End Sub

  Private Sub FillDdlState()

    ddlState.Items.Clear()

    AddItem("Veicoli ritirati dietro pagamento", supVehicleSearch.VehicleStateEnum.vseRTR)
    AddItem("Veicoli ritirati dietro pagamento postdatato", supVehicleSearch.VehicleStateEnum.vseRTP)
    AddItem("Veicoli ritirati senza onere", supVehicleSearch.VehicleStateEnum.vseRSO)
    AddItem("Veicoli ritirati senza onere perché appartenenti ad invalidi", supVehicleSearch.VehicleStateEnum.vseHND)
    AddItem("Veicoli ritirati senza onere perché appartenenti ad istituzioni", supVehicleSearch.VehicleStateEnum.vseRVI)
    AddItem("Veicoli prelevati perché risultati rubati", supVehicleSearch.VehicleStateEnum.vseRBT)
    AddItem("Veicoli usciti irregolarmente da deposito", supVehicleSearch.VehicleStateEnum.vseRBD)
    AddItem("Veicoli demoliti", supVehicleSearch.VehicleStateEnum.vseDemolished)

  End Sub

  Private Sub AddItem(ByVal strText As String, ByVal intState As supVehicleSearch.VehicleStateEnum)

    Dim li As New ListItem
    li.Text = strText
    li.Value = intState
    ddlState.Items.Add(li)

  End Sub

End Class
