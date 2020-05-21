Public Class wf_confTurnoPatente
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.daTipTurni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsTipoTurni1 = New ATCBussm1.DsTipoTurni
    CType(Me.DsTipoTurni1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'daTipTurni
    '
    Me.daTipTurni.DeleteCommand = Me.SqlDeleteCommand1
    Me.daTipTurni.InsertCommand = Me.SqlInsertCommand1
    Me.daTipTurni.SelectCommand = Me.SqlSelectCommand1
    Me.daTipTurni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipTurno_Abilitazione", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Cod_Tipologia", "Cod_Tipologia"), New System.Data.Common.DataColumnMapping("Flag_Patente", "Flag_Patente"), New System.Data.Common.DataColumnMapping("CreateOn", "CreateOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.daTipTurni.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM TipTurno_Abilitazione WHERE (Id = @Original_Id) AND (Cod_Tipologia = " & _
    "@Original_Cod_Tipologia OR @Original_Cod_Tipologia IS NULL AND Cod_Tipologia IS " & _
    "NULL) AND (CreateOn = @Original_CreateOn OR @Original_CreateOn IS NULL AND Creat" & _
    "eOn IS NULL) AND (CreatedBy = @Original_CreatedBy OR @Original_CreatedBy IS NULL" & _
    " AND CreatedBy IS NULL) AND (Flag_Patente = @Original_Flag_Patente OR @Original_" & _
    "Flag_Patente IS NULL AND Flag_Patente IS NULL) AND (ModifiedBy = @Original_Modif" & _
    "iedBy OR @Original_ModifiedBy IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = " & _
    "@Original_ModifiedOn OR @Original_ModifiedOn IS NULL AND ModifiedOn IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Tipologia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Tipologia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreateOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreateOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Flag_Patente", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flag_Patente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO TipTurno_Abilitazione(Id, Cod_Tipologia, Flag_Patente, CreateOn, Modi" & _
    "fiedOn, CreatedBy, ModifiedBy) VALUES (@Id, @Cod_Tipologia, @Flag_Patente, @Crea" & _
    "teOn, @ModifiedOn, @CreatedBy, @ModifiedBy); SELECT Id, Cod_Tipologia, Flag_Pate" & _
    "nte, CreateOn, ModifiedOn, CreatedBy, ModifiedBy FROM TipTurno_Abilitazione WHER" & _
    "E (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Tipologia", System.Data.SqlDbType.VarChar, 50, "Cod_Tipologia"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag_Patente", System.Data.SqlDbType.Bit, 1, "Flag_Patente"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Cod_Tipologia, Flag_Patente, CreateOn, ModifiedOn, CreatedBy, Modified" & _
    "By FROM dbo.TipTurno_Abilitazione WHERE (Cod_Tipologia = @Cod_Tipologia)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Tipologia", System.Data.SqlDbType.VarChar, 50, "Cod_Tipologia"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE TipTurno_Abilitazione SET Id = @Id, Cod_Tipologia = @Cod_Tipologia, Flag_P" & _
    "atente = @Flag_Patente, CreateOn = @CreateOn, ModifiedOn = @ModifiedOn, CreatedB" & _
    "y = @CreatedBy, ModifiedBy = @ModifiedBy WHERE (Id = @Original_Id) AND (Cod_Tipo" & _
    "logia = @Original_Cod_Tipologia OR @Original_Cod_Tipologia IS NULL AND Cod_Tipol" & _
    "ogia IS NULL) AND (CreateOn = @Original_CreateOn OR @Original_CreateOn IS NULL A" & _
    "ND CreateOn IS NULL) AND (CreatedBy = @Original_CreatedBy OR @Original_CreatedBy" & _
    " IS NULL AND CreatedBy IS NULL) AND (Flag_Patente = @Original_Flag_Patente OR @O" & _
    "riginal_Flag_Patente IS NULL AND Flag_Patente IS NULL) AND (ModifiedBy = @Origin" & _
    "al_ModifiedBy OR @Original_ModifiedBy IS NULL AND ModifiedBy IS NULL) AND (Modif" & _
    "iedOn = @Original_ModifiedOn OR @Original_ModifiedOn IS NULL AND ModifiedOn IS N" & _
    "ULL); SELECT Id, Cod_Tipologia, Flag_Patente, CreateOn, ModifiedOn, CreatedBy, M" & _
    "odifiedBy FROM TipTurno_Abilitazione WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Tipologia", System.Data.SqlDbType.VarChar, 50, "Cod_Tipologia"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag_Patente", System.Data.SqlDbType.Bit, 1, "Flag_Patente"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Tipologia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Tipologia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreateOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreateOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Flag_Patente", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flag_Patente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsTipoTurni1
    '
    Me.DsTipoTurni1.DataSetName = "DsTipoTurni"
    Me.DsTipoTurni1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsTipoTurni1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents LinkButton2 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents daTipTurni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DsTipoTurni1 As ATCBussm1.DsTipoTurni
  Protected WithEvents lblCodTipo As System.Web.UI.WebControls.Label
  Protected WithEvents txtCodTipo As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblFlagPatente As System.Web.UI.WebControls.Label
  Protected WithEvents chkFlagPatente As System.Web.UI.WebControls.CheckBox
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents pnlMessage As System.Web.UI.WebControls.Panel

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
    oUtente = Session("User")
    daTipTurni.SelectCommand.Parameters("@Cod_Tipologia").Value() = Request("Cod")
    daTipTurni.Fill(DsTipoTurni1, "TipTurno_Abilitazione")

    If Not DsTipoTurni1.Tables("TipTurno_Abilitazione").Rows.Count > 0 Then
      'txtCodTipo.Text = Request("Cod")
      Dim dr As DataRow
      dr = DsTipoTurni1.Tables("TipTurno_Abilitazione").NewRow
      dr.Item("Id") = Guid.NewGuid
      dr.Item("Cod_Tipologia") = Request("Cod")
      dr.Item("Flag_Patente") = 0
      dr.Item("CreatedBy") = oUtente.Nome
      dr.Item("CreateOn") = Now
      DsTipoTurni1.Tables("TipTurno_Abilitazione").Rows.InsertAt(dr, 0)
    End If
    If Not IsPostBack Then Page.DataBind()
  End Sub

  Private Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
    Response.Redirect("wf_confTurniPatente.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    pMessageVisibility(Me.IsValid)

    DsTipoTurni1.Tables("TipTurno_Abilitazione").Rows(0).Item("Flag_Patente") = IIf(chkFlagPatente.Checked, 1, 0)
    DsTipoTurni1.Tables("TipTurno_Abilitazione").Rows(0).Item("ModifiedOn") = Now
    DsTipoTurni1.Tables("TipTurno_Abilitazione").Rows(0).Item("ModifiedBy") = oUtente.Nome

    daTipTurni.Update(DsTipoTurni1, "TipTurno_Abilitazione")
  End Sub
  Private Sub pMessageVisibility(ByVal visible As Boolean)
    pnlMessage.Visible = visible
    For Each c As Control In pnlMessage.Controls
      c.Visible = visible
    Next
  End Sub

End Class
