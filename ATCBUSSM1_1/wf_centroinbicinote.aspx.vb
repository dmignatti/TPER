Public Class wf_centroinbicinote
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
		Me.dvNote = New System.Data.DataView
		Me.daNote = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
		Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
		CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dvNote, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'DsBiglietterie1
		'
		Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
		Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
		'
		'dvNote
		'
		Me.dvNote.ApplyDefaultSort = True
		Me.dvNote.Sort = "Data Desc"
		Me.dvNote.Table = Me.DsBiglietterie1.CentroInBici_Note
		'
		'daNote
		'
		Me.daNote.DeleteCommand = Me.SqlDeleteCommand4
		Me.daNote.InsertCommand = Me.SqlInsertCommand5
		Me.daNote.SelectCommand = Me.SqlSelectCommand5
		Me.daNote.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_Note", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Nota", "Nota")})})
		Me.daNote.UpdateCommand = Me.SqlUpdateCommand4
		'
		'SqlDeleteCommand4
		'
		Me.SqlDeleteCommand4.CommandText = "DELETE FROM dbo.CentroInBici_Note WHERE (Id = @Original_Id) AND (Data = @Original" & _
		"_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica = @Original_" & _
		"IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL) AND (Id" & _
		"TipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND IdTipoNota I" & _
		"S NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL)"
		Me.SqlDeleteCommand4.Connection = Me.con
		Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'SqlInsertCommand5
		'
		Me.SqlInsertCommand5.CommandText = "INSERT INTO dbo.CentroInBici_Note(Id, IdAnagrafica, IdTipoNota, Data, Nota) VALUE" & _
		"S (@Id, @IdAnagrafica, @IdTipoNota, @Data, @Nota); SELECT Id, IdAnagrafica, IdTi" & _
		"poNota, Data, Nota FROM dbo.CentroInBici_Note WHERE (Id = @Id)"
		Me.SqlInsertCommand5.Connection = Me.con
		Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
		Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
		Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, "IdTipoNota"))
		Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
		Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
		'
		'SqlSelectCommand5
		'
		Me.SqlSelectCommand5.CommandText = "SELECT N.Id, N.IdAnagrafica, N.IdTipoNota, T.Tipo, N.Data, N.Nota FROM dbo.Centro" & _
		"InBici_Note N INNER JOIN dbo.CentroInBici_TipoNota T ON N.IdTipoNota = T.IdTipoN" & _
		"ota WHERE (N.IdAnagrafica = @IdAnagrafica)"
		Me.SqlSelectCommand5.Connection = Me.con
		Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
		'
		'SqlUpdateCommand4
		'
		Me.SqlUpdateCommand4.CommandText = "UPDATE dbo.CentroInBici_Note SET Id = @Id, IdAnagrafica = @IdAnagrafica, IdTipoNo" & _
		"ta = @IdTipoNota, Data = @Data, Nota = @Nota WHERE (Id = @Original_Id) AND (Data" & _
		" = @Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica " & _
		"= @Original_IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS N" & _
		"ULL) AND (IdTipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND " & _
		"IdTipoNota IS NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Not" & _
		"a IS NULL); SELECT Id, IdAnagrafica, IdTipoNota, Data, Nota FROM dbo.CentroInBic" & _
		"i_Note WHERE (Id = @Id)"
		Me.SqlUpdateCommand4.Connection = Me.con
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, "IdTipoNota"))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
		CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dvNote, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
	Protected WithEvents dvNote As System.Data.DataView
	Protected WithEvents daNote As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
	Protected WithEvents dgNote As System.Web.UI.WebControls.DataGrid
	Protected WithEvents lblNoNote As System.Web.UI.WebControls.Label
	Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
	Protected WithEvents LinkButton1 As System.Web.UI.WebControls.LinkButton

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
		daNote.SelectCommand.Parameters("@IDAnagrafica").Value = Request("IDAnagrafica")
		daNote.Fill(DsBiglietterie1)
		If Not IsPostBack Then Page.DataBind()
	End Sub

	Private Sub dgNote_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgNote.PageIndexChanged
		dgNote.CurrentPageIndex = e.NewPageIndex
		dgNote.EditItemIndex = -1
		dgNote.DataBind()
	End Sub

	Private Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
		Response.Redirect("wf_cercacentroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
	End Sub

	Private Sub dgNote_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgNote.SelectedIndexChanged
		Response.Redirect("wf_centroinbicinota.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IdAnagrafica=" & Server.UrlEncode(Request("IDAnagrafica")) & "&ID=" & Server.UrlEncode(DirectCast(dgNote.DataKeys(dgNote.SelectedIndex), Guid).ToString))
	End Sub

	Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		Response.Redirect("wf_centroinbicinota.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IdAnagrafica=" & Server.UrlEncode(Request("IDAnagrafica")))
	End Sub

	Private Sub dgNote_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgNote.ItemCreated
		If Not e.Item.FindControl("btnDelete") Is Nothing Then
			DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "javascript: return confirm('Sei sicuro di voler eliminare questa nota?');")
		End If
	End Sub

	Private Sub dgNote_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNote.DeleteCommand
		DsBiglietterie1.Tables("Centroinbici_Note").Rows.Find(dgNote.DataKeys(e.Item.ItemIndex)).Delete()
		daNote.Update(DsBiglietterie1)
		Page.DataBind()
	End Sub
End Class
