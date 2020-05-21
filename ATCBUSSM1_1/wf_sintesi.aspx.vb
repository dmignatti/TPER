Public Class wf_sintesi
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents VSConsumiAz As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents LblMese As System.Web.UI.WebControls.Label
  Protected WithEvents LblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents TxtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents btnSend As System.Web.UI.WebControls.Button
  Protected WithEvents PnlParametri As System.Web.UI.WebControls.Panel
  Protected WithEvents PnlStatistica As System.Web.UI.WebControls.Panel

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

    End If

  End Sub



  Public Function UrlReport() As String

    Dim anno As Integer

    anno = CInt(IIf(TxtAnno.Text.Trim = "", 10, TxtAnno.Text))

  

    UrlReport = "&rc:Parameters=false&rc:DocMap=false&ANNO=" & anno.ToString

  End Function

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    PnlStatistica.Visible = Me.IsValid
  End Sub
End Class
