Public Class wf_viewstallixvia
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaSettori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsSettori = New ATCBussm1.DsSettori
    CType(Me.DsSettori, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaSettori
    '
    Me.DaSettori.SelectCommand = Me.SqlSelectCommand2
    Me.DaSettori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Settori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_SZF", "Id_SZF"), New System.Data.Common.DataColumnMapping("Id_ZonaSettoreUnico", "Id_ZonaSettoreUnico"), New System.Data.Common.DataColumnMapping("Desc_Settore", "Desc_Settore"), New System.Data.Common.DataColumnMapping("Desc_Dettaglio_Settore", "Desc_Dettaglio_Settore")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id_SZF, Id_ZonaSettoreUnico, Desc_Settore, Desc_Dettaglio_Settore, IdSetto" & _
    "re FROM dbo.Settori"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'DsSettori
    '
    Me.DsSettori.DataSetName = "DsSettori"
    Me.DsSettori.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsSettori, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents VSStalli As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblVia As System.Web.UI.WebControls.Label
  Protected WithEvents lblPeriodo As System.Web.UI.WebControls.Label
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents cboSettori As System.Web.UI.WebControls.DropDownList
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents pnlSearch As System.Web.UI.WebControls.Panel
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaSettori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsSettori As ATCBussm1.DsSettori
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents TxtAl As System.Web.UI.WebControls.TextBox
  Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
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
  Private Where As String = ""
  Private pUnspecified As String = "[Non specificato]"

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    If Not IsPostBack Then

      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      DaSettori.Fill(DsSettori.Tables("Settori"))
      cboSettori.DataBind()
      cboSettori.Items.Insert(0, pUnspecified)
      TxtAl.Text = Format(Now, "dd/MM/yyyy")


    End If
  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    PnlStatistica.Visible = Me.IsValid
  End Sub

  Public Function UrlReport() As String
  
    Dim StrDataV As String
    Dim StrNomeVia As String
    Dim StrParVisual As String = ""
    Dim Settore As String

    StrDataV = TxtAl.Text & " 23:59:59"
    If txtVia.Text.Trim = "" Then
      StrNomeVia = "%"
    Else
      StrNomeVia = Replace(txtVia.Text, "'", "") & "%"
    End If
    If cboSettori.SelectedItem.Text <> pUnspecified Then
      Settore = cboSettori.SelectedValue
    Else
      Settore = "%"
    End If

    StrParVisual = "&DATAV=" & StrDataV & "&SETTORE=" & Settore & "&NOMEVIA=" & StrNomeVia

    UrlReport = "&rc:Parameters=false&rc:DocMap=false" & StrParVisual

  End Function



End Class
