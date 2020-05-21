Imports System.Web.Security

Public Class wc_checkpermission
  Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

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

    Dim intUserID, intModuleID As Integer

    Try
      intUserID = atcbSession.Get_UserID(Me.Session)
      intModuleID = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_ModuleID))
      If Not atcbWUser.CheckModule(intUserID, intModuleID) Then
        Logout()
      End If
    Catch ex As Exception
      Logout()
    End Try

  End Sub

  Private Sub Logout()
    Session.Abandon()
    'FT - 20041129
		FormsAuthentication.SignOut()
		Response.Redirect("wf_newmain.aspx")
    'Me.Parent.Page.Response.Redirect("frmLogin.aspx")
    'FT
  End Sub

End Class
