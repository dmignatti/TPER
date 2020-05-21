Public Class Preview
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection

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
    Dim com As New SqlClient.SqlCommand("Select Cast(Id As Varchar(50)) + '.' + Extension from Centroinbici_Allegati Where ID = @Id", con)
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Dim Height As Integer = configurationAppSettings.GetValue("Thumbnail.Height", GetType(System.Int32))
    Dim Width As Integer = configurationAppSettings.GetValue("Thumbnail.Width", GetType(System.Int32))

    com.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = New Guid(Server.UrlDecode(Request.Params.Item("Id")))

    Dim ext As String
    Dim ct As Drawing.Imaging.ImageFormat

    Dim b As Drawing.Bitmap
    Try
      con.Open()
      ext = "" & com.ExecuteScalar
      con.Close()
      con.Dispose()
    Catch ex As Exception

    End Try

    If ext.Substring(ext.LastIndexOf(".") + 1).Length > 0 Then
      Try
        b = New Drawing.Bitmap(Server.MapPath("Attachments") & "\" & ext)
      Catch ex As Exception
        'FT - !!! - Immagine inesistente
        Exit Sub
      End Try

      Select Case ext.Substring(ext.LastIndexOf(".") + 1).ToLower
        Case "jpeg", "jpg", "jpe"
          ct = Drawing.Imaging.ImageFormat.Jpeg
          Response.ContentType = "image/jpeg"
        Case "gif"
          ct = Drawing.Imaging.ImageFormat.Gif
          Response.ContentType = "image/gif"
      End Select

      If Request.Params.Item("Prev") = 1 Then
        If b.Height > b.Width Then
          b.GetThumbnailImage(Height * b.Width \ b.Height, Height, Nothing, Nothing).Save(Response.OutputStream, ct)
        Else
          b.GetThumbnailImage(Width, Width * b.Height \ b.Width, Nothing, Nothing).Save(Response.OutputStream, ct)
        End If
      Else
        b.Save(Response.OutputStream, ct)
      End If
    Else
      'Immagine vuota
    End If
    
  End Sub

End Class
