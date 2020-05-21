Public Class wf_exitvrbd
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
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

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim strBackUrl As String
    Dim vrbd As supVehicleRBD

    strBackUrl = "wf_viewdeposito1.aspx?" & _
                  atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                  atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

    hlkBack.NavigateUrl = strBackUrl

    Try
      vrbd = Session("Vehicle")
      If Not IsPostBack() Then
        vrbd.Save()
        Response.Redirect(strBackUrl)
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

End Class
