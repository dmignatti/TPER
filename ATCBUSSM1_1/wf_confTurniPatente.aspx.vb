Public Class wf_confTurniPatente
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.daConf = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DsTipoTurni1 = New ATCBussm1.DsTipoTurni
    Me.dvTipoTurni = New System.Data.DataView
    CType(Me.DsTipoTurni1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvTipoTurni, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'daConf
    '
    Me.daConf.SelectCommand = Me.SqlSelectCommand1
    Me.daConf.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoTurni", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodiceTipologia", "CodiceTipologia"), New System.Data.Common.DataColumnMapping("TipologiaTurno", "TipologiaTurno"), New System.Data.Common.DataColumnMapping("Flag_Patente", "Flag_Patente")})})
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    DISTINCT Turni.CodiceTipologia, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Turni.TipologiaTurno, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    ISN" & _
    "ULL(TipTurno_Abilitazione.Flag_Patente, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    0) AS Flag_Patente" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "FROM" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Turn" & _
    "i LEFT OUTER" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "JOIN" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    TipTurno_Abilitazione ON" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "        Turni.CodiceTipologia " & _
    "collate database_default = TipTurno_Abilitazione.Cod_Tipologia collate database_" & _
    "default" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'DsTipoTurni1
    '
    Me.DsTipoTurni1.DataSetName = "DsTipoTurni"
    Me.DsTipoTurni1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'dvTipoTurni
    '
    Me.dvTipoTurni.Sort = "CodiceTipologia"
    Me.dvTipoTurni.Table = Me.DsTipoTurni1.TipoTurni
    CType(Me.DsTipoTurni1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvTipoTurni, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents pnlMessage As System.Web.UI.WebControls.Panel
  Protected WithEvents daConf As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents dgTipoTurni As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsTipoTurni1 As ATCBussm1.DsTipoTurni
  Protected WithEvents dvTipoTurni As System.Data.DataView

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
    daConf.Fill(DsTipoTurni1)
    'dvUtenti.RowFilter = pCreateFilter()
    If Not IsPostBack Then Page.DataBind()

    End Sub

  Private Sub dgTipoTurni_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgTipoTurni.PageIndexChanged
    dgTipoTurni.CurrentPageIndex = e.NewPageIndex
    dgTipoTurni.DataBind()
  End Sub

  Private Sub dgTipoTurni_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTipoTurni.SelectedIndexChanged
    Response.Redirect("wf_confTurnoPatente.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&Cod=" & Server.UrlEncode(dgTipoTurni.DataKeys(dgTipoTurni.SelectedIndex)))
  End Sub
End Class
