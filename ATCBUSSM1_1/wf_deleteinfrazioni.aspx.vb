Public Class wf_deleteinfrazioni
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

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      Dim TarfInfr As New supTariffarioInfr(supFunction.DecodeDate(strDateBegin), supFunction.DecodeDate(strDateEnd))
      If TarfInfr.Delete() Then
        Response.Redirect("wf_tariffarioinfrazioni.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID))
      Else
        lblError.Text = "Errore di cancellazione"
      End If
    Catch ex As Exception
      lblError.Text = "Errore decodifica parametri"
    End Try
    GC.Collect(GC.MaxGeneration)

  End Sub

End Class
