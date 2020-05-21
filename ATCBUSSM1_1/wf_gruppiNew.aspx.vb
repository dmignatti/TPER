Public Class wf_gruppiNew
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.daGruppi = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.DsUtenti1 = New ATCBussm1.dsUtenti
		Me.dvGruppi = New System.Data.DataView
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'daGruppi
		'
		Me.daGruppi.DeleteCommand = Me.SqlDeleteCommand1
		Me.daGruppi.InsertCommand = Me.SqlInsertCommand1
		Me.daGruppi.SelectCommand = Me.SqlSelectCommand1
		Me.daGruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Amministrazione", "Amministrazione")})})
		Me.daGruppi.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Gruppi WHERE (ID = @Original_ID) AND (Abilitato = @Original_A" & _
		"bilitato OR @Original_Abilitato IS NULL AND Abilitato IS NULL) AND (Amministrazi" & _
		"one = @Original_Amministrazione OR @Original_Amministrazione IS NULL AND Amminis" & _
		"trazione IS NULL) AND (Descrizione = @Original_Descrizione OR @Original_Descrizi" & _
		"one IS NULL AND Descrizione IS NULL) AND (EMail = @Original_EMail OR @Original_E" & _
		"Mail IS NULL AND EMail IS NULL)"
		Me.SqlDeleteCommand1.Connection = Me.con
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.ATC_Gruppi(Descrizione, Abilitato, EMail, Amministrazione) VALUES" & _
		" (@Descrizione, @Abilitato, @EMail, @Amministrazione); SELECT ID, Descrizione, A" & _
		"bilitato, EMail, Amministrazione FROM dbo.ATC_Gruppi WHERE (ID = @@IDENTITY)"
		Me.SqlInsertCommand1.Connection = Me.con
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT ID, Descrizione, Abilitato, EMail, Amministrazione FROM dbo.ATC_Gruppi"
		Me.SqlSelectCommand1.Connection = Me.con
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Gruppi SET Descrizione = @Descrizione, Abilitato = @Abilitato, EMa" & _
		"il = @EMail, Amministrazione = @Amministrazione WHERE (ID = @Original_ID) AND (A" & _
		"bilitato = @Original_Abilitato OR @Original_Abilitato IS NULL AND Abilitato IS N" & _
		"ULL) AND (Amministrazione = @Original_Amministrazione OR @Original_Amministrazio" & _
		"ne IS NULL AND Amministrazione IS NULL) AND (Descrizione = @Original_Descrizione" & _
		") AND (EMail = @Original_EMail OR @Original_EMail IS NULL AND EMail IS NULL); SE" & _
		"LECT ID, Descrizione, Abilitato, EMail, Amministrazione FROM dbo.ATC_Gruppi WHER" & _
		"E (ID = @ID)"
		Me.SqlUpdateCommand1.Connection = Me.con
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
		'
		'DsUtenti1
		'
		Me.DsUtenti1.DataSetName = "dsUtenti"
		Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
		'
		'dvGruppi
		'
		Me.dvGruppi.Sort = "Descrizione"
		Me.dvGruppi.Table = Me.DsUtenti1.ATC_Gruppi
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents daGruppi As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
	Protected WithEvents dgGruppi As System.Web.UI.WebControls.DataGrid
	Protected WithEvents dvGruppi As System.Data.DataView
	Protected WithEvents btnAddGroup As System.Web.UI.WebControls.Button
	Protected WithEvents lblNoGruppi As System.Web.UI.WebControls.Label
	Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblCerca As System.Web.UI.WebControls.Label
	Protected WithEvents txtFiltro As System.Web.UI.WebControls.TextBox
	Protected WithEvents ddlSearchType As System.Web.UI.WebControls.DropDownList
	Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
	Protected WithEvents lblCount As System.Web.UI.WebControls.Label

	'NOTE: The following placeholder declaration is required by the Web Form Designer.
	'Do not delete or move it.
	Private designerPlaceholderDeclaration As System.Object

	Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
		'CODEGEN: This method call is required by the Web Form Designer
		'Do not modify it using the code editor.
		InitializeComponent()
	End Sub

#End Region

	Dim DefaultFilter As String = ""

	Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'Put user code to initialize the page here
		daGruppi.Fill(DsUtenti1)
		dvGruppi.RowFilter = pCreateFilter()
		If Not IsPostBack Then Page.DataBind()
	End Sub

	Private Sub dgGruppi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGruppi.SelectedIndexChanged
		Response.Redirect("wf_gruppo.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&Id=" & Server.UrlEncode(dgGruppi.DataKeys(dgGruppi.SelectedIndex)))
	End Sub

	Private Sub btnAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGroup.Click
		Response.Redirect("wf_gruppo.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
	End Sub

	Private Sub dgGruppi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGruppi.DeleteCommand
		Dim idGruppo As Integer = DsUtenti1.Tables("ATC_gruppi").Rows.Find(dgGruppi.DataKeys(e.Item.ItemIndex)).Item("ID")
		Dim sqlDelPermessi As New SqlClient.SqlCommand("Delete From ATC_RelModuloGruppo Where IDGruppo = @IDGruppo", con)
		sqlDelPermessi.Parameters.Add("@IDGruppo", SqlDbType.Int).Value = idGruppo
		Dim sqlDelUtenti As New SqlClient.SqlCommand("Delete From ATC_RelUtenteGruppo Where IDGruppo = @IDGruppo", con)
		sqlDelUtenti.Parameters.Add("@IDGruppo", SqlDbType.Int).Value = idGruppo
		con.Open()
		sqlDelPermessi.ExecuteNonQuery()
		sqlDelUtenti.ExecuteNonQuery()
		con.Close()
		'Eliminare il gruppo
		DsUtenti1.Tables("ATC_gruppi").Rows.Find(dgGruppi.DataKeys(e.Item.ItemIndex)).Delete()
		daGruppi.Update(DsUtenti1)
		dgGruppi.DataBind()
	End Sub

	Private Sub dgGruppi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgGruppi.ItemCreated
		If Not e.Item.FindControl("btnDelete") Is Nothing Then
			DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "javascript: return confirm('Sei sicuro di voler eliminare questo gruppo?');")
		End If
	End Sub

	Private Function pCreateFilter() As String
		If txtFiltro.Text.Trim.Length > 0 Then
			Dim where As String = ""
			Dim s As String = txtFiltro.Text.Trim
			Do While s.IndexOf("  ") >= 0
				s = s.Replace("  ", " ")
			Loop
			Dim pArr As String()
			pArr = s.Split(" ")
			For Each s In pArr
				s = s.Replace("'", "''")
				s = s.Replace("%", "[%]")
				s = s.Replace("_", "[_]")
				If where.Length > 0 Then
					If ddlSearchType.SelectedValue <> 1 Then
						where &= " Or "
					Else
						where &= " And "
					End If
				End If
				where &= "(Descrizione Like '%" & s & "%')"
			Next
			pCreateFilter = where
		Else
			pCreateFilter = DefaultFilter
		End If
	End Function

	Private Sub btnCerca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerca.Click
		dgGruppi.CurrentPageIndex = 0
		dgGruppi.DataBind()
		lblNoGruppi.DataBind()
		lblCount.DataBind()
	End Sub
End Class
