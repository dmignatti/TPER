Imports System.Web
Imports System.Web.SessionState
Imports System.Web.Security
Imports System.Security.Principal
Imports System.Data.SqlClient

Public Class Global
  Inherits System.Web.HttpApplication

#Region " Component Designer Generated Code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Component Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Required by the Component Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Component Designer
  'It can be modified using the Component Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    components = New System.ComponentModel.Container
  End Sub

#End Region

  Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the application is started
  End Sub

  Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the session is started
  End Sub

	Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
		' Fires at the beginning of each request
	End Sub

	Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
		Dim authTicket As FormsAuthenticationTicket
		'Dim cookie As HttpCookie = Context.Request.Cookies(FormsAuthentication.FormsCookieName)
		'If Not cookie Is Nothing Then
		'  Try
		'    authTicket = FormsAuthentication.Decrypt(cookie.Value)
		'  Catch ex As System.Security.Cryptography.CryptographicException
		'    Response.Clear()
		'    Response.Write("Ticket di autenticazione non presente o non valido.")
		'    Response.End()
		'  End Try
		'Else
		If Not Context.Request.QueryString(FormsAuthentication.FormsCookieName) Is Nothing Then
			Try
				authTicket = FormsAuthentication.Decrypt(Context.Request.QueryString(FormsAuthentication.FormsCookieName))
			Catch ex As System.Security.Cryptography.CryptographicException
				Response.Clear()
				Response.Write("Ticket di autenticazione non presente o non valido.")
				Response.End()
			End Try
		End If
		'End If
		If Not authTicket Is Nothing Then
			Dim id As New FormsIdentity(authTicket)
			Dim gp As New GenericPrincipal(id, Nothing)
			Context.User = gp
		End If
	End Sub

	Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when an error occurs
	End Sub

	Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the session ends
	End Sub

	Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the application ends
	End Sub

End Class
