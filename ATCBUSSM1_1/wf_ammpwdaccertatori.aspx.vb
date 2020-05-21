Public Class wf_ammpwdaccertatori
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
		Me.daAccertatori = New System.Data.SqlClient.SqlDataAdapter
		Me.dvAccertatori = New System.Data.DataView
		Me.dsUtenti1 = New ATCBussm1.dsUtenti
		CType(Me.dvAccertatori, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato, DataUlti" & _
		"moAccesso, OraUltimoAccesso, NrAccessi, TipoUtente FROM dbo.ATC_Utenti WHERE (Ti" & _
		"poUtente = 2)"
		Me.SqlSelectCommand1.Connection = Me.con
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
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Utenti SET IDUser = @IDUser, Pwd = @Pwd, IDResponsabile = @IDRespo" & _
		"nsabile, Cognome = @Cognome, Nome = @Nome, EMail = @EMail, Abilitato = @Abilitat" & _
		"o, DataUltimoAccesso = @DataUltimoAccesso, OraUltimoAccesso = @OraUltimoAccesso," & _
		" NrAccessi = @NrAccessi, TipoUtente = @TipoUtente WHERE (ID = @Original_ID) AND " & _
		"(Abilitato = @Original_Abilitato OR @Original_Abilitato IS NULL AND Abilitato IS" & _
		" NULL) AND (Cognome = @Original_Cognome OR @Original_Cognome IS NULL AND Cognome" & _
		" IS NULL) AND (DataUltimoAccesso = @Original_DataUltimoAccesso OR @Original_Data" & _
		"UltimoAccesso IS NULL AND DataUltimoAccesso IS NULL) AND (EMail = @Original_EMai" & _
		"l OR @Original_EMail IS NULL AND EMail IS NULL) AND (IDResponsabile = @Original_" & _
		"IDResponsabile OR @Original_IDResponsabile IS NULL AND IDResponsabile IS NULL) A" & _
		"ND (IDUser = @Original_IDUser OR @Original_IDUser IS NULL AND IDUser IS NULL) AN" & _
		"D (Nome = @Original_Nome OR @Original_Nome IS NULL AND Nome IS NULL) AND (NrAcce" & _
		"ssi = @Original_NrAccessi OR @Original_NrAccessi IS NULL AND NrAccessi IS NULL) " & _
		"AND (OraUltimoAccesso = @Original_OraUltimoAccesso OR @Original_OraUltimoAccesso" & _
		" IS NULL AND OraUltimoAccesso IS NULL) AND (Pwd = @Original_Pwd OR @Original_Pwd" & _
		" IS NULL AND Pwd IS NULL) AND (TipoUtente = @Original_TipoUtente OR @Original_Ti" & _
		"poUtente IS NULL AND TipoUtente IS NULL); SELECT ID, IDUser, Pwd, IDResponsabile" & _
		", Cognome, Nome, EMail, Abilitato, DataUltimoAccesso, OraUltimoAccesso, NrAccess" & _
		"i, TipoUtente FROM dbo.ATC_Utenti WHERE (ID = @ID)"
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
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Utenti WHERE (ID = @Original_ID) AND (Abilitato = @Original_A" & _
		"bilitato OR @Original_Abilitato IS NULL AND Abilitato IS NULL) AND (Cognome = @O" & _
		"riginal_Cognome OR @Original_Cognome IS NULL AND Cognome IS NULL) AND (DataUltim" & _
		"oAccesso = @Original_DataUltimoAccesso OR @Original_DataUltimoAccesso IS NULL AN" & _
		"D DataUltimoAccesso IS NULL) AND (EMail = @Original_EMail OR @Original_EMail IS " & _
		"NULL AND EMail IS NULL) AND (IDResponsabile = @Original_IDResponsabile OR @Origi" & _
		"nal_IDResponsabile IS NULL AND IDResponsabile IS NULL) AND (IDUser = @Original_I" & _
		"DUser OR @Original_IDUser IS NULL AND IDUser IS NULL) AND (Nome = @Original_Nome" & _
		" OR @Original_Nome IS NULL AND Nome IS NULL) AND (NrAccessi = @Original_NrAccess" & _
		"i OR @Original_NrAccessi IS NULL AND NrAccessi IS NULL) AND (OraUltimoAccesso = " & _
		"@Original_OraUltimoAccesso OR @Original_OraUltimoAccesso IS NULL AND OraUltimoAc" & _
		"cesso IS NULL) AND (Pwd = @Original_Pwd OR @Original_Pwd IS NULL AND Pwd IS NULL" & _
		") AND (TipoUtente = @Original_TipoUtente OR @Original_TipoUtente IS NULL AND Tip" & _
		"oUtente IS NULL)"
		Me.SqlDeleteCommand1.Connection = Me.con
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cognome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cognome", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataUltimoAccesso", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataUltimoAccesso", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IDResponsabile", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDResponsabile", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IDUser", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDUser", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NrAccessi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NrAccessi", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OraUltimoAccesso", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OraUltimoAccesso", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pwd", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pwd", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoUtente", System.Data.DataRowVersion.Original, Nothing))
		'
		'daAccertatori
		'
		Me.daAccertatori.DeleteCommand = Me.SqlDeleteCommand1
		Me.daAccertatori.InsertCommand = Me.SqlInsertCommand1
		Me.daAccertatori.SelectCommand = Me.SqlSelectCommand1
		Me.daAccertatori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
		Me.daAccertatori.UpdateCommand = Me.SqlUpdateCommand1
		'
		'dvAccertatori
		'
		Me.dvAccertatori.ApplyDefaultSort = True
		Me.dvAccertatori.Sort = "IDUser"
		Me.dvAccertatori.Table = Me.dsUtenti1.ATC_Utenti
		'
		'dsUtenti1
		'
		Me.dsUtenti1.DataSetName = "dsUtenti"
		Me.dsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
		CType(Me.dvAccertatori, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
	Protected WithEvents pnlMessage As System.Web.UI.WebControls.Panel
	Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
	Protected WithEvents lblAccertatore As System.Web.UI.WebControls.Label
	Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
	Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
	Protected WithEvents rfvPassword As System.Web.UI.WebControls.RequiredFieldValidator
	Protected WithEvents lblConfermaPassword As System.Web.UI.WebControls.Label
	Protected WithEvents txtConfermaPassword As System.Web.UI.WebControls.TextBox
	Protected WithEvents rfvConfermaPassword As System.Web.UI.WebControls.RequiredFieldValidator
	Protected WithEvents cvPassword As System.Web.UI.WebControls.CompareValidator
	Protected WithEvents btnConferma As System.Web.UI.WebControls.Button
	Protected WithEvents ddlAccertatori As System.Web.UI.WebControls.DropDownList
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents daAccertatori As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents dvAccertatori As System.Data.DataView
	Protected WithEvents dsUtenti1 As dsUtenti

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
  Dim fnc As New Funzioni

	Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    daAccertatori.Fill(dsUtenti1)
    If Not IsPostBack Then
      ddlAccertatori.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_ammpwdaccertatori.aspx", "Pagina iniziale", Session("IPAddress"))
    End If

	End Sub

	Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
		If Me.IsValid Then
			Dim dr As DataRow = dsUtenti1.Tables("ATC_Utenti").Rows.Find(ddlAccertatori.SelectedValue)
			dr("Pwd") = txtPassword.Text.Trim
			daAccertatori.Update(dsUtenti1)
      pnlMessage.Visible = True
      fnc.ScriviLog(oUtente.IDUser, "wf_ammpwdaccertatori.aspx", "Confermata la modifica della password sull'accertatore: " & ddlAccertatori.SelectedValue, Session("IPAddress"))
		End If
  End Sub

End Class
