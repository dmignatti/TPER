Imports System.Data.SqlClient

Public Class frmOrdinanza
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents txtOrdinanza As System.Web.UI.WebControls.TextBox

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
    'Put user code to initialize the page here
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select Testo, [File], Ext From Ordinanze Where [Id] = @1", con)
    Dim dr As SqlDataReader
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = Request.QueryString.Item("Id")
    dr = com.ExecuteReader
    dr.Read()
    If Len("" & dr.Item("Ext")) > 0 Then
      Dim g As Guid
      g = dr.Item("File")
      Response.Redirect("files/" & g.ToString & dr.Item("Ext"))
    Else
      txtOrdinanza.Text = "" & dr.Item("Testo")
    End If
    con.Close()
    con.Dispose()
  End Sub

End Class
