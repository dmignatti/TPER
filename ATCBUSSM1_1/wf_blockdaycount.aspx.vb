Public Class wf_blockdaycount
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents lblPlate As System.Web.UI.WebControls.Label
  Protected WithEvents lblType As System.Web.UI.WebControls.Label
  Protected WithEvents lblMark As System.Web.UI.WebControls.Label
  Protected WithEvents lblModel As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateIn As System.Web.UI.WebControls.Label
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents lblNVerbale As System.Web.UI.WebControls.Label
  Protected WithEvents lblState As System.Web.UI.WebControls.Label
  Protected WithEvents txtDateBlock As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtTimeBlock As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents rfvDateBlock As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvTimeBlock As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBlock As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents revTimeBlock As System.Web.UI.WebControls.RegularExpressionValidator

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

    Dim intPK As Integer

    hlkBack.NavigateUrl = getBackLink()

    Try
      intPK = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleID))
      Dim vehicle As New supVehicle(intPK)
      vehicle.Fetch()
      lblPlate.Text = vehicle.Plate
      lblType.Text = vehicle.Type
      lblMark.Text = vehicle.Mark
      lblModel.Text = vehicle.Model
      lblDateIn.Text = supFunction.FormatDate(vehicle.DateIn, supFunction.supDateFormatEnum.dfeDateHourMin)
      lblNVerbale.Text = vehicle.NVerbale
      lblState.Text = vehicle.State
      btnSave.Visible = True
      lblError.Text = ""
    Catch ex As Exception
      lblPlate.Text = ""
      lblType.Text = ""
      lblMark.Text = ""
      lblModel.Text = ""
      lblDateIn.Text = ""
      lblNVerbale.Text = ""
      lblState.Text = ""
      btnSave.Visible = False
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Function getBackLink() As String

    Return "wf_viewdeposito1.aspx?" & _
           atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
           atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

  End Function

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      Dim intPK As Integer = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleID))
      Dim dtmDateBlock As DateTime = supFunction.DecodeDate(txtDateBlock.Text, txtTimeBlock.Text)
      If atcbWUser.BlockDayCount(intPK, dtmDateBlock) Then
        Response.Redirect(getBackLink())
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

End Class
