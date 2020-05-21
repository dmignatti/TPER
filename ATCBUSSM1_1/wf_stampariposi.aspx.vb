Imports System.Net
Imports System.IO
Imports System.Web.Services.Protocols

Public Class wf_stampariposi
  Inherits System.Web.UI.Page


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
  Private oUtente As Utente
  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here


    Dim reportUri As String
    Try
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
       Dim iduser As String
      If Not (oUtente.TipoUtente = 2) Then
        iduser = "10000"
        Dim idmatr As String
        idmatr = Request.QueryString("IDMatr")
        If (IsNumeric(idmatr)) Then
          iduser = idmatr
        End If

      Else

        iduser = oUtente.IDUser
      End If
      Dim anno As String
      anno = Session("annoriposi")
      reportUri = "http://appsql/ReportServer?%2fAtcReport%2fRptRiposi&ID=" & iduser & "&ANNO=" & anno & "&rs%3aCommand=Render&rs%3AFormat=PDF"
      Dim client = New WebClient
      Dim cred As New NetworkCredential("admininnovatech", "pwdtech", "atcbologna")
      client.Credentials = cred
      'client.Credentials = new CredentialCache ssrsCredentials
      Dim Data As Byte()
      Data = client.DownloadData(reportUri)

      Response.ContentType = "application/pdf"

      Response.AddHeader("content-length", Data.Length.ToString())
      Response.AddHeader("Cache-Control", "private, max-age=1")
      Response.BinaryWrite(Data)

    Catch ex As Exception
      Dim msg As String
      msg = "SSRS Communication Failedurl: " & reportUri & " - ex:" & ex.Message

      Throw New InvalidOperationException(msg, ex)
    Catch ex As SoapException
      Dim msg As String
      msg = "SSRS Communication Failedurl: " & reportUri & " - ex:" & ex.InnerException.Message

      Throw New InvalidOperationException(msg, ex)
    End Try

  End Sub

End Class
