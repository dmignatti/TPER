Public Class wf_utentiNew
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.daUtenti = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.DsUtenti1 = New ATCBussm1.dsUtenti
		Me.dvUtenti = New System.Data.DataView
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'daUtenti
		'
		Me.daUtenti.DeleteCommand = Me.SqlDeleteCommand1
		Me.daUtenti.InsertCommand = Me.SqlInsertCommand1
		Me.daUtenti.SelectCommand = Me.SqlSelectCommand1
		Me.daUtenti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
		Me.daUtenti.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Utenti WHERE (ID = @Original_ID)"
		Me.SqlDeleteCommand1.Connection = Me.con
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.ATC_Utenti(IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abi" & _
		"litato, DataUltimoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente) VALUES (@IDU" & _
		"ser, @Pwd, @IDResponsabile, @Cognome, @Nome, @EMail, @Abilitato, @DataUltimoAcce" & _
		"sso, @OraUltimoAccesso, @NrAccessi, @TipoUtente); SELECT ID, IDUser, Pwd, IDResp" & _
		"onsabile, Cognome, Nome, EMail, Abilitato, DataUltimoAccesso, OraUltimoAccesso, " & _
		"NrAccessi, TipoUtente FROM dbo.ATC_Utenti WHERE (ID = @@IDENTITY)"
		Me.SqlInsertCommand1.Connection = Me.con
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDUser", System.Data.SqlDbType.VarChar, 30, "IDUser"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pwd", System.Data.SqlDbType.VarChar, 10, "Pwd"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDResponsabile", System.Data.SqlDbType.Int, 4, "IDResponsabile"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cognome", System.Data.SqlDbType.VarChar, 50, "Cognome"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 50, "Nome"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataUltimoAccesso", System.Data.SqlDbType.VarChar, 20, "DataUltimoAccesso"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraUltimoAccesso", System.Data.SqlDbType.VarChar, 20, "OraUltimoAccesso"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrAccessi", System.Data.SqlDbType.Int, 4, "NrAccessi"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoUtente", System.Data.SqlDbType.Int, 4, "TipoUtente"))
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT dbo.ATC_Utenti.ID, dbo.ATC_Utenti.IDUser, dbo.ATC_Utenti.Pwd, dbo.ATC_Uten" & _
		"ti.IDResponsabile, dbo.ATC_Utenti.Cognome, dbo.ATC_Utenti.Nome, dbo.ATC_Utenti.E" & _
		"Mail, dbo.ATC_Utenti.Abilitato, dbo.ATC_Utenti.DataUltimoAccesso, dbo.ATC_Utenti" & _
		".OraUltimoAccesso, dbo.ATC_Utenti.NrAccessi, dbo.ATC_Utenti.TipoUtente, dbo.ATC_" & _
		"TipoUtente.Descrizione AS DescrizioneTipoUtente FROM dbo.ATC_Utenti INNER JOIN d" & _
		"bo.ATC_TipoUtente ON dbo.ATC_Utenti.TipoUtente = dbo.ATC_TipoUtente.ID"
		Me.SqlSelectCommand1.Connection = Me.con
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Utenti SET IDUser = @IDUser, Pwd = @Pwd, IDResponsabile = @IDRespo" & _
		"nsabile, Cognome = @Cognome, Nome = @Nome, EMail = @EMail, Abilitato = @Abilitat" & _
		"o, DataUltimoAccesso = @DataUltimoAccesso, OraUltimoAccesso = @OraUltimoAccesso," & _
		" NrAccessi = @NrAccessi, TipoUtente = @TipoUtente WHERE (ID = @Original_ID) AND " & _
		"(Abilitato = @Original_Abilitato) AND (Cognome = @Original_Cognome) AND (DataUlt" & _
		"imoAccesso = @Original_DataUltimoAccesso) AND (EMail = @Original_EMail) AND (IDR" & _
		"esponsabile = @Original_IDResponsabile) AND (IDUser = @Original_IDUser) AND (Nom" & _
		"e = @Original_Nome) AND (NrAccessi = @Original_NrAccessi) AND (OraUltimoAccesso " & _
		"= @Original_OraUltimoAccesso) AND (Pwd = @Original_Pwd) AND (TipoUtente = @Origi" & _
		"nal_TipoUtente); SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, A" & _
		"bilitato, DataUltimoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente FROM dbo.AT" & _
		"C_Utenti WHERE (ID = @ID)"
		Me.SqlUpdateCommand1.Connection = Me.con
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDUser", System.Data.SqlDbType.VarChar, 30, "IDUser"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pwd", System.Data.SqlDbType.VarChar, 10, "Pwd"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDResponsabile", System.Data.SqlDbType.Int, 4, "IDResponsabile"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cognome", System.Data.SqlDbType.VarChar, 50, "Cognome"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 50, "Nome"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataUltimoAccesso", System.Data.SqlDbType.VarChar, 20, "DataUltimoAccesso"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraUltimoAccesso", System.Data.SqlDbType.VarChar, 20, "OraUltimoAccesso"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrAccessi", System.Data.SqlDbType.Int, 4, "NrAccessi"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoUtente", System.Data.SqlDbType.Int, 4, "TipoUtente"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cognome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cognome", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataUltimoAccesso", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataUltimoAccesso", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IDResponsabile", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDResponsabile", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IDUser", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDUser", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NrAccessi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NrAccessi", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OraUltimoAccesso", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OraUltimoAccesso", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pwd", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pwd", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoUtente", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
		'
		'DsUtenti1
		'
		Me.DsUtenti1.DataSetName = "dsUtenti"
		Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
		'
		'dvUtenti
		'
		Me.dvUtenti.Sort = "IdUser"
		Me.dvUtenti.Table = Me.DsUtenti1.ATC_Utenti
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents daUtenti As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
	Protected WithEvents dgUtenti As System.Web.UI.WebControls.DataGrid
	Protected WithEvents dvUtenti As System.Data.DataView
	Protected WithEvents lblNoUtenti As System.Web.UI.WebControls.Label
	Protected WithEvents btnAddUser As System.Web.UI.WebControls.Button
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
		daUtenti.Fill(DsUtenti1)
		dvUtenti.RowFilter = pCreateFilter()
		If Not IsPostBack Then Page.DataBind()
	End Sub

	Private Sub dgUtenti_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgUtenti.SelectedIndexChanged
		Response.Redirect("wf_utente.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&Id=" & Server.UrlEncode(dgUtenti.DataKeys(dgUtenti.SelectedIndex)))
	End Sub

	Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
		Response.Redirect("wf_utente.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
	End Sub

	Private Sub dgUtenti_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgUtenti.PageIndexChanged
		dgUtenti.CurrentPageIndex = e.NewPageIndex
		dgUtenti.DataBind()
	End Sub

	Private Sub dgUtenti_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgUtenti.ItemCreated
		If Not e.Item.FindControl("btnDelete") Is Nothing Then
			DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "javascript: return confirm('Sei sicuro di voler eliminare questo utente?');")
		End If
	End Sub

	Private Sub dgUtenti_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgUtenti.DeleteCommand
		Dim idUtente As Integer = dgUtenti.DataKeys(e.Item.ItemIndex)
		Dim sqlDelUtenti As New SqlClient.SqlCommand("Delete From ATC_RelUtenteGruppo Where IDUtente = @IDUtente", con)
		sqlDelUtenti.Parameters.Add("@IDUtente", SqlDbType.Int).Value = idUtente
		con.Open()
		sqlDelUtenti.ExecuteNonQuery()
		con.Close()
		DsUtenti1.Tables("ATC_Utenti").Rows.Find(idUtente).Delete()
		Try
			daUtenti.Update(DsUtenti1)
		Catch ex As Exception
		End Try
		dgUtenti.DataBind()
	End Sub

	Private Sub btnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerca.Click
		dgUtenti.CurrentPageIndex = 0
		dgUtenti.DataBind()
		lblNoUtenti.DataBind()
		lblCount.DataBind()
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
				where &= "(Nome Like '%" & s & "%' Or Cognome Like '%" & s & "%' Or IDUser Like '%" & s & "%' Or Email Like '%" & s & "%' Or DescrizioneTipoUtente Like '%" & s & "%')"
			Next
			pCreateFilter = where
		Else
			pCreateFilter = DefaultFilter
		End If
	End Function
End Class
