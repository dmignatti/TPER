Public Class wf_centroinbicinota
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daNota = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daTipoNota = New System.Data.SqlClient.SqlDataAdapter
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, IdAnagrafica, IdTipoNota, Data, Nota FROM dbo.CentroInBici_Note WHERE " & _
    "(Id = @Id)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.CentroInBici_Note(Id, IdAnagrafica, IdTipoNota, Data, Nota) VALUE" & _
    "S (@Id, @IdAnagrafica, @IdTipoNota, @Data, @Nota); SELECT Id, IdAnagrafica, IdTi" & _
    "poNota, Data, Nota FROM dbo.CentroInBici_Note WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.CentroInBici_Note SET Id = @Id, IdAnagrafica = @IdAnagrafica, IdTipoNo" & _
    "ta = @IdTipoNota, Data = @Data, Nota = @Nota WHERE (Id = @Original_Id) AND (Data" & _
    " = @Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica " & _
    "= @Original_IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS N" & _
    "ULL) AND (IdTipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND " & _
    "IdTipoNota IS NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Not" & _
    "a IS NULL); SELECT Id, IdAnagrafica, IdTipoNota, Data, Nota FROM dbo.CentroInBic" & _
    "i_Note WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.CentroInBici_Note WHERE (Id = @Original_Id) AND (Data = @Original" & _
    "_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica = @Original_" & _
    "IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL) AND (Id" & _
    "TipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND IdTipoNota I" & _
    "S NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'daNota
    '
    Me.daNota.DeleteCommand = Me.SqlDeleteCommand1
    Me.daNota.InsertCommand = Me.SqlInsertCommand1
    Me.daNota.SelectCommand = Me.SqlSelectCommand1
    Me.daNota.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_Note", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Nota", "Nota")})})
    Me.daNota.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdTipoNota, Tipo FROM dbo.CentroInBici_TipoNota"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.CentroInBici_TipoNota(IdTipoNota, Tipo) VALUES (@IdTipoNota, @Tip" & _
    "o); SELECT IdTipoNota, Tipo FROM dbo.CentroInBici_TipoNota"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 255, "Tipo"))
    '
    'daTipoNota
    '
    Me.daTipoNota.InsertCommand = Me.SqlInsertCommand2
    Me.daTipoNota.SelectCommand = Me.SqlSelectCommand2
    Me.daTipoNota.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_TipoNota", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
	Protected WithEvents lblTipoNota As System.Web.UI.WebControls.Label
	Protected WithEvents ddlTipoNota As System.Web.UI.WebControls.DropDownList
	Protected WithEvents lblNota As System.Web.UI.WebControls.Label
	Protected WithEvents txtNota As System.Web.UI.WebControls.TextBox
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents daNota As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents lnkBack As System.Web.UI.WebControls.LinkButton
	Protected WithEvents btnSalva As System.Web.UI.WebControls.Button
	Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
	Protected WithEvents daTipoNota As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
	Protected WithEvents txtID As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents LblData As System.Web.UI.WebControls.Label
  Protected WithEvents txtData As System.Web.UI.WebControls.TextBox
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents cvData As System.Web.UI.WebControls.CompareValidator

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
		If txtID.Value.Length <= 0 Then txtID.Value = Request("ID")
		daTipoNota.Fill(DsBiglietterie1)
		If txtID.Value.Length <= 0 Then
			If Not IsPostBack Then
				Dim dr As DataRow = DsBiglietterie1.Tables("CentroInBici_Note").NewRow
        dr("Id") = -1
        dr("Data") = Now
        dr("IdTipoNota") = 16
				dr("IdAnagrafica") = Request("IdAnagrafica")
				DsBiglietterie1.Tables("CentroInBici_Note").Rows.Add(dr)
			End If
		Else
			daNota.SelectCommand.Parameters("@ID").Value = New Guid(txtID.Value)
			daNota.Fill(DsBiglietterie1)
		End If
		If Not IsPostBack Then
			Page.DataBind()
		End If
	End Sub

	Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click

    Dim dr As DataRow
    If Me.IsValid Then
      If txtID.Value.Length <= 0 Then
        dr = DsBiglietterie1.Tables("CentroInBici_Note").NewRow
        dr("Id") = Guid.NewGuid
        txtID.Value = DirectCast(dr("ID"), Guid).ToString
        dr("IdAnagrafica") = Request("IdAnagrafica")
        DsBiglietterie1.Tables("CentroInBici_Note").Rows.Add(dr)
      Else
        dr = DsBiglietterie1.Tables("CentroInBici_Note").Rows.Find(txtID.Value)
      End If
      dr("Data") = CDate(txtData.Text.Trim)
      dr("Nota") = txtNota.Text
      dr("IdTipoNota") = ddlTipoNota.SelectedValue
      daNota.Update(DsBiglietterie1)
    End If

	End Sub

	Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack.Click
		Response.Redirect("wf_centroinbicinote.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&IdAnagrafica=" & Request("IdAnagrafica"))
	End Sub
End Class
