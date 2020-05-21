Public Class wf_statisticavie
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
  Protected WithEvents btnSend As System.Web.UI.WebControls.Button
  Protected WithEvents LblNVie As System.Web.UI.WebControls.Label
  Protected WithEvents TxtNVie As System.Web.UI.WebControls.TextBox
  Protected WithEvents LblSintesi As System.Web.UI.WebControls.Label
  Protected WithEvents ChkSintesi As System.Web.UI.WebControls.CheckBox
  Protected WithEvents LblDa As System.Web.UI.WebControls.Label
  Protected WithEvents CalDa As System.Web.UI.WebControls.Calendar
  Protected WithEvents LblA As System.Web.UI.WebControls.Label
  Protected WithEvents CalA As System.Web.UI.WebControls.Calendar
  Protected WithEvents PnlParametri As System.Web.UI.WebControls.Panel
  Protected WithEvents PnlStatistica As System.Web.UI.WebControls.Panel
  Protected WithEvents VSConsumiAz As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvVie As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvvVie As System.Web.UI.WebControls.CompareValidator

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
      TxtNVie.Text = "10"

    End If

  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    PnlStatistica.Visible = Me.IsValid
  End Sub

  Public Function UrlReport() As String
    ' If Me.IsValid Then
    UrlReport = "&rc:Toolbar=true&rc:Parameters=false&amp;rc:DocMap=false&NVia=" & Trim(TxtNVie.Text) & "&DATADA=" & String.Concat(CalDa.SelectedDate.Day, "/", CalDa.SelectedDate.Month, "/", CalDa.SelectedDate.Year) & "&DATAA=" & String.Concat(CalA.SelectedDate.Day, "/", CalA.SelectedDate.Month, "/", CalA.SelectedDate.Year) & "&Sintetico=" & ChkSintesi.Checked
    ' Else
    ' UrlReport = "about:blank"
    ' End If
  End Function

End Class
