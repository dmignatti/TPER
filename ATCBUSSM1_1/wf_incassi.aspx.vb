Public Class wf_incassi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents txtMonthEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtYearEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlUser As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtDateEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDateEnd As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents rfvDateEnd As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
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

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strUrl As String

    Try
      If IsPostBack Then
        strUrl = "wf_rptincassi.aspx?" & _
                 atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                 atcbConstant.QS_DateBegin & "=" & txtDateBegin.Text.Trim & "&" & _
                 atcbConstant.QS_DateEnd & "=" & txtDateEnd.Text.Trim & "&" & _
                 atcbConstant.QS_GDATCUser & "=" & ddlUser.SelectedValue
        Response.Redirect(strUrl)
      Else
        supFunction.FillDdlGDATCUser(ddlUser, True, False)
        txtDateBegin.Text = supFunction.FormatDate(DateTime.Today, supFunction.supDateFormatEnum.dfeStandard)
        txtDateEnd.Text = supFunction.FormatDate(DateTime.Today, supFunction.supDateFormatEnum.dfeStandard)
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

End Class
