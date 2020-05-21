Public Class wf_stampaautoparchimetri
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents txtanno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSend As System.Web.UI.WebControls.Button
  Protected WithEvents PnlAutoparchimetri As System.Web.UI.WebControls.Panel

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
  Private oUtente As Utente

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here

    If Not IsPostBack Then
      ' ----------------------------------------------------------------------------
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      txtanno.Text = Year(Now)

    End If
  End Sub

  Public Function UrlReport() As String

    UrlReport = "&rc:Parameters=false&rc:DocMap=false&ANNO=" & txtanno.Text.ToString

  End Function

  Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click

    PnlAutoparchimetri.Visible = True

  End Sub

End Class
