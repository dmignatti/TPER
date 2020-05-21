Imports System.Web.Security

Public Class wf_newmain
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

  Protected WithEvents tvw As Microsoft.Web.UI.WebControls.TreeView
  Protected WithEvents lblUserName As System.Web.UI.WebControls.Label
  Protected WithEvents lblLastAccess As System.Web.UI.WebControls.Label
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents lnkLogout As System.Web.UI.WebControls.LinkButton

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

    Try
      If Not IsPostBack Then
        Dim User As Utente = Session("User")
        'ConfigTvw()
        atcbWUser.LoadMenu(User.ID, tvw)
        atcbWUser.FetchGeneral(User.ID, lblUserName.Text, lblLastAccess.Text)
        Dim fnc As New Funzioni
        fnc.ScriviLog(User.IDUser, "wf_newmain.aspx", "Login utente: " & User.Cognome, Session("IPAddress"))
      End If
    Catch ex As Exception
      Response.Redirect("frmLogin.aspx?ReturnURL=" & Server.UrlEncode("wf_newmain.aspx"))
    End Try

  End Sub

  Private Sub ConfigTvw()

    tvw.BorderColor = System.Drawing.Color.Black
    tvw.BorderStyle = BorderStyle.Solid
    tvw.BorderWidth = Unit.Pixel(1)

  End Sub

  Private Sub lnkLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkLogout.Click
    FormsAuthentication.SignOut()
    Response.Redirect("wf_newmain.aspx")
  End Sub
End Class
