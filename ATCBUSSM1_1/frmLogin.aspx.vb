Imports System.Data.SqlClient
Imports System.Web.Security

Public Class frmLogin
  Inherits System.Web.UI.Page

	Protected WithEvents lblUser As System.Web.UI.WebControls.Label
  Protected WithEvents Userid As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
  Protected WithEvents Password As System.Web.UI.WebControls.TextBox
  Protected WithEvents cmdConferma As System.Web.UI.WebControls.Button
  Protected WithEvents vsErrors As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents cvLogin As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents UseridValidator As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lnkInnovatech As System.Web.UI.WebControls.HyperLink
  Protected WithEvents messaggio As System.Web.UI.WebControls.Label

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If Not IsPostBack Then
      atcbSession.Close(Me.Session)
    End If

    'Response.Clear()
    'Response.Write("Utente: " & System.Security.Principal.WindowsIdentity.GetCurrent.Name)
    'Response.End()

    'Messaggio.Visible = False
    Session.Clear()
    'Session.Timeout = 50
  End Sub

  Private Sub cmdConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConferma.Click

    'Dim User As Utente
    'Dim strMessaggio As String
    'Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))

    'User = New Utente(oConn)
    'If User.Login(Trim(UCase(Userid.Text)), Trim(UCase(Password.Text)), strMessaggio) Then
    '  Session.Add("User", User)
    '  Response.Redirect("frmPrincipale.aspx")
    'Else
    '  Session.Add("UserLogged", 0)
    '  Messaggio.Text = strMessaggio
    '  Messaggio.Visible = True
    '  Userid.Text = ""
    'End If

    If Me.IsValid Then
      Dim ticket As New FormsAuthenticationTicket _
          (Userid.Text.Trim, False, 5000)
      'If Me.Session.IsCookieless Then
      'Response.Redirect(FormsAuthentication.GetRedirectUrl(Userid.Text.Trim, False) & "?" & Server.UrlEncode(FormsAuthentication.FormsCookieName) & "=" & Server.UrlEncode(FormsAuthentication.Encrypt(ticket)))

      Dim IP As String = Request.ServerVariables("REMOTE_HOST")
      Session.Add("IPAddress", Trim(IP))
      Response.Redirect("wf_newmain.aspx?" & Server.UrlEncode(FormsAuthentication.FormsCookieName) & "=" & Server.UrlEncode(FormsAuthentication.Encrypt(ticket)))
      'Else
      'Dim authCookie As New HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket))
      'Response.AppendCookie(authCookie)
      'Response.Redirect(FormsAuthentication.GetRedirectUrl(Userid.Text.Trim, False))
      'End If
    End If

    'Dim intUserID As Integer

    'Try
    '  atcbWUser.Login(Userid.Text.Trim, Password.Text, intUserID)
    '  If (intUserID > 0) Then
    '    ' ----------------------------- Codice vecchio --------------------------------
    '    Dim User As Utente
    '    Dim strMessaggio As String
    '    Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    '    User = New Utente(oConn)
    '    If User.Login(Trim(UCase(Userid.Text)), Trim(UCase(Password.Text)), strMessaggio) Then
    '      Session.Add("User", User)
    '    End If
    '    ' --------------------------- Fine codice vecchio -----------------------------
    '    If atcbSession.Open(Me.Session, intUserID) Then
    '      Response.Redirect("wf_newmain.aspx")
    '    Else
    '      Throw New Exception("Errore in apertura di sessione")
    '    End If
    '  End If
    'Catch ex As Exception
    '  Messaggio.Text = ex.Message
    '  Messaggio.Visible = True
    'End Try

  End Sub

  Private Function IsAuthenticated(ByVal UserName As String, ByVal password As String) As Boolean
    Dim intUserID As Integer
    Try
      atcbWUser.Login(UserName, password, intUserID)
      If (intUserID > 0) Then
        ' ----------------------------- Codice vecchio --------------------------------
        Dim User As Utente
        Dim strMessaggio As String
        Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
        User = New Utente(oConn)
        If User.Login(Trim(UCase(UserName)), Trim(UCase(password)), strMessaggio) Then
          Session.Add("User", User)
          IsAuthenticated = True
        End If
        ' --------------------------- Fine codice vecchio -----------------------------
				If Not atcbSession.Open(Me.Session, intUserID) Then
					IsAuthenticated = False
					Throw New Exception("Errore in apertura di sessione")
				End If
			End If
    Catch ex As Exception
      messaggio.Text = ex.Message
      messaggio.Visible = True
      IsAuthenticated = False
    End Try
  End Function

  Private Sub cvLogin_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvLogin.ServerValidate
    args.IsValid = IsAuthenticated(Userid.Text, Password.Text)
  End Sub
End Class
