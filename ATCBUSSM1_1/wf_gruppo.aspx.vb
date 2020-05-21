Public Class wf_gruppo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DsUtenti1 = New ATCBussm1.dsUtenti
    Me.daGruppo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daUtenti = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.dvUtenti = New System.Data.DataView
    Me.daUtentiDelGruppo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'DsUtenti1
    '
    Me.DsUtenti1.DataSetName = "dsUtenti"
    Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daGruppo
    '
    Me.daGruppo.DeleteCommand = Me.SqlDeleteCommand1
    Me.daGruppo.InsertCommand = Me.SqlInsertCommand1
    Me.daGruppo.SelectCommand = Me.SqlSelectCommand1
    Me.daGruppo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Amministrazione", "Amministrazione")})})
    Me.daGruppo.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Gruppi WHERE (ID = @Original_ID) AND (Abilitato = @Original_A" & _
    "bilitato OR @Original_Abilitato IS NULL AND Abilitato IS NULL) AND (Amministrazi" & _
    "one = @Original_Amministrazione OR @Original_Amministrazione IS NULL AND Amminis" & _
    "trazione IS NULL) AND (Descrizione = @Original_Descrizione) AND (EMail = @Origin" & _
    "al_EMail OR @Original_EMail IS NULL AND EMail IS NULL)"
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
    Me.SqlSelectCommand1.CommandText = "SELECT ID, Descrizione, Abilitato, EMail, Amministrazione FROM dbo.ATC_Gruppi WHE" & _
    "RE (ID = @Id)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "ID"))
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
    'daUtenti
    '
    Me.daUtenti.SelectCommand = Me.SqlSelectCommand2
    Me.daUtenti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT distinct ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato," & _
    " DataUltimoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente FROM dbo.ATC_Utenti " & _
    "a WHERE (NOT EXISTS (SELECT * FROM atc_relutentegruppo b WHERE b.idutente = a.id" & _
    " AND idgruppo = @Id))"
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    '
    'dvUtenti
    '
    Me.dvUtenti.Sort = "Cognome, Nome, IdUSer"
    Me.dvUtenti.Table = Me.DsUtenti1.ATC_Utenti
    '
    'daUtentiDelGruppo
    '
    Me.daUtentiDelGruppo.SelectCommand = Me.SqlSelectCommand3
    Me.daUtentiDelGruppo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "UtentiDelGruppo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT r.ID, u.IDUser, u.Pwd, u.IDResponsabile, u.Cognome, u.Nome, u.EMail, u.Abi" & _
    "litato, u.DataUltimoAccesso, u.OraUltimoAccesso, u.NrAccessi, u.TipoUtente FROM " & _
    "dbo.ATC_Utenti u INNER JOIN dbo.ATC_RelUtenteGruppo r ON u.ID = r.IDUtente WHERE" & _
    " (r.IDGruppo = @Id and u.Abilitato=1 ) ORDER BY u.Cognome, u.Nome, u.IDUser"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "IDGruppo"))
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
  Protected WithEvents daGruppo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblDescrizione As System.Web.UI.WebControls.Label
  Protected WithEvents txtDescrizione As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblAbilitato As System.Web.UI.WebControls.Label
  Protected WithEvents chkAbilitato As System.Web.UI.WebControls.CheckBox
  Protected WithEvents lnkBack As System.Web.UI.WebControls.LinkButton
  Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
  Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNoProdotti As System.Web.UI.WebControls.Label
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents btnRemove As System.Web.UI.WebControls.Button
  Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNoCarichi As System.Web.UI.WebControls.Label
  Protected WithEvents LinkButton1 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents lblSearch As System.Web.UI.WebControls.Label
  Protected WithEvents daUtenti As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dvUtenti As System.Data.DataView
  Protected WithEvents daUtentiDelGruppo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvDescrizione As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtId As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents dgUtenti As System.Web.UI.WebControls.DataGrid
  Protected WithEvents dgUtentiDelGruppo As System.Web.UI.WebControls.DataGrid
  Protected WithEvents cvGruppo As System.Web.UI.WebControls.CustomValidator

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
    If CStr("" & Request("Id")).Length > 0 Then txtId.Value = Request("Id")
		pFillGrid()
		If txtId.Value.Length <= 0 Then
			If Not IsPostBack Then
				Dim dr As DataRow = DsUtenti1.Tables("ATC_Gruppi").NewRow
				dr("Id") = -1
				dr("Abilitato") = 1
				DsUtenti1.Tables("ATC_Gruppi").Rows.Add(dr)
			End If
		Else
			daGruppo.SelectCommand.Parameters("@Id").Value = txtId.Value
			daGruppo.Fill(DsUtenti1)
		End If
		If Not IsPostBack Then
			Page.DataBind()
		End If
		txtSearch.Attributes.Add("onKeyPress", "javascript: return !(window.event && window.event.keyCode == 13);")
  End Sub

  Private Sub pFillGrid()
    If txtId.Value.Length > 0 Then
      daUtentiDelGruppo.SelectCommand.Parameters("@id").Value = txtId.Value
      daUtentiDelGruppo.Fill(DsUtenti1)
      daUtenti.SelectCommand.Parameters("@id").Value = txtId.Value
    Else
      daUtenti.SelectCommand.Parameters("@id").Value = 0
    End If
    daUtenti.Fill(DsUtenti1)
  End Sub

  Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack.Click
		Response.Redirect("wf_gruppiNew.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
		Response.Redirect("wf_gruppiNew.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub dgUtenti_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgUtenti.PageIndexChanged
    pFilterUsersGrid()
    dgUtenti.CurrentPageIndex = e.NewPageIndex
    dgUtenti.DataBind()
    dgUtentiDelGruppo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub pFilterUsersGrid()
    Dim s As String = txtSearch.Text.Trim
    If s.Length > 0 Then
      Do While s.IndexOf("  ") > 0
        s = s.Replace("  ", " ")
      Loop
      Dim pArr As String() = s.Split(" ")
      Dim where As String = ""
			For Each el As String In pArr
				If where.Length > 0 Then where &= " And "
				where &= "(Cognome Like '%" & el & "%' Or IdUser Like '%" & el & "%' Or Nome Like '%" & el & "%')"
			Next
			dvUtenti.RowFilter = where
		Else
      dvUtenti.RowFilter = ""
    End If
  End Sub

  Private Sub dgUtentiDelGruppo_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgUtentiDelGruppo.PageIndexChanged
    pFilterUsersGrid()
    dgUtentiDelGruppo.CurrentPageIndex = e.NewPageIndex
    dgUtentiDelGruppo.DataBind()
    dgUtenti.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    pFilterUsersGrid()
    dgUtenti.CurrentPageIndex = 0
    dgUtenti.DataBind()
    dgUtentiDelGruppo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Dim com As New SqlClient.SqlCommand("Insert Into ATC_RelUtenteGruppo Values(@IdUtente, @IdGruppo)", con)
    com.Parameters.Add("@IdUtente", SqlDbType.Int)
    com.Parameters.Add("@IdGruppo", SqlDbType.Int)
    con.Open()
    For i As Integer = 0 To dgUtenti.Items.Count - 1
      If DirectCast(dgUtenti.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@IdGruppo").Value = txtId.Value
        com.Parameters("@IdUtente").Value = dgUtenti.DataKeys(i)
        com.ExecuteNonQuery()
      End If
    Next
    pFilterUsersGrid()
    dgUtenti.CurrentPageIndex = 0
    dgUtentiDelGruppo.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Dim com As New SqlClient.SqlCommand("Delete From ATC_RelUtenteGruppo Where Id = @Id", con)
    com.Parameters.Add("@Id", SqlDbType.Int)
    Dim LowerBound As Integer = dgUtentiDelGruppo.CurrentPageIndex * dgUtentiDelGruppo.PageSize
    Dim UpperBound As Integer = IIf(dgUtentiDelGruppo.CurrentPageIndex = dgUtentiDelGruppo.PageCount - 1, dgUtentiDelGruppo.Items.Count - 1, dgUtentiDelGruppo.CurrentPageIndex * dgUtentiDelGruppo.PageSize + dgUtentiDelGruppo.PageSize - 1)
    con.Open()
    For i As Integer = 0 To dgUtentiDelGruppo.Items.Count - 1
      If DirectCast(dgUtentiDelGruppo.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@Id").Value = dgUtentiDelGruppo.DataKeys(i)
        com.ExecuteNonQuery()
      End If
    Next
    pFilterUsersGrid()
    dgUtenti.CurrentPageIndex = 0
    dgUtentiDelGruppo.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub pRefreshGrid()
    DsUtenti1.Tables("ATC_Utenti").Clear()
    DsUtenti1.Tables("UtentiDelGruppo").Clear()
    pFillGrid()
    dgUtenti.DataBind()
    dgUtentiDelGruppo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

	Private Sub cvGruppo_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvGruppo.ServerValidate
		If txtId.Value.Length > 0 Then
			Dim com As New SqlClient.SqlCommand("Select Count(*) From ATC_Gruppi Where Descrizione = @Descrizione And Id <> @Id", con)
			com.Parameters.Add("@Descrizione", SqlDbType.VarChar).Value = txtDescrizione.Text
			com.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Value
			con.Open()
			args.IsValid = com.ExecuteScalar <= 0
			con.Close()
		Else
			args.IsValid = True
		End If
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If Me.IsValid Then
			Dim dr As DataRow
			If txtId.Value.Length <= 0 Then
				dr = DsUtenti1.Tables("ATC_Gruppi").NewRow
				'Dim com As New SqlClient.SqlCommand("select Max(ID) + 1 From ATC_Gruppi", con)
				'con.Open()
				'dr("Id") = com.ExecuteScalar
				'con.Close()
				dr("Id") = -1
				DsUtenti1.Tables("ATC_Gruppi").Rows.Add(dr)
				'txtId.Value = dr("Id")
			Else
				dr = DsUtenti1.Tables("ATC_Gruppi").Rows.Find(txtId.Value)
			End If
			dr("Descrizione") = txtDescrizione.Text
			dr("Abilitato") = IIf(chkAbilitato.Checked, 1, 0)
			daGruppo.Update(DsUtenti1)
			txtId.Value = dr("Id")
			Page.DataBind()
		End If
	End Sub
End Class
