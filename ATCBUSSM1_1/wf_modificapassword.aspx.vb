Public Class wf_modificapassword
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.daUtenti = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.DsUtenti1 = New ATCBussm1.dsUtenti
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'daUtenti
		'
		Me.daUtenti.SelectCommand = Me.SqlSelectCommand1
		Me.daUtenti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
		Me.daUtenti.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato, DataUlti" & _
		"moAccesso, OraUltimoAccesso, NrAccessi, TipoUtente FROM dbo.ATC_Utenti WHERE (ID" & _
		" = @Id)"
		Me.SqlSelectCommand1.Connection = Me.con
		Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "ID"))
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Utenti SET Pwd = @Pwd WHERE (ID = @Original_ID); SELECT ID, IDUser" & _
		", Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato, DataUltimoAccesso, OraUl" & _
		"timoAccesso, NrAccessi, TipoUtente FROM dbo.ATC_Utenti WHERE (ID = @ID)"
		Me.SqlUpdateCommand1.Connection = Me.con
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pwd", System.Data.SqlDbType.VarChar, 10, "Pwd"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
		'
		'DsUtenti1
		'
		Me.DsUtenti1.DataSetName = "dsUtenti"
		Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
  Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtConfermaPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
  Protected WithEvents lblConfermaPassword As System.Web.UI.WebControls.Label
  Protected WithEvents rfvPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvConfermaPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvPassword As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents txtOldPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblOldPassword As System.Web.UI.WebControls.Label
  Protected WithEvents cvOldPassword As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daUtenti As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
  Protected WithEvents btnConferma As System.Web.UI.WebControls.Button
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents rfvOldPassword As System.Web.UI.WebControls.RequiredFieldValidator
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
  Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")

    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    daUtenti.SelectCommand.Parameters("@Id").Value = oUtente.ID
    daUtenti.Fill(DsUtenti1, "ATC_Utenti")

    If Not IsPostBack Then
      fnc.ScriviLog(oUtente.IDUser, "wf_modificapassword.aspx", "Pagina iniziale", Session("IPAddress"))
    End If

  End Sub

  Private Sub cvOldPassword_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvOldPassword.ServerValidate
    args.IsValid = txtOldPassword.Text.CompareTo(DsUtenti1.Tables("ATC_Utenti").Rows(0).Item("pwd")) = 0
  End Sub

  Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
    pMessageVisibility(Me.IsValid)
    If Me.IsValid Then
      DsUtenti1.Tables("ATC_Utenti").Rows(0).Item("pwd") = txtPassword.Text
      daUtenti.Update(DsUtenti1, "ATC_Utenti")
      fnc.ScriviLog(oUtente.IDUser, "wf_modificapassword.aspx", "Confermata la modifica della password", Session("IPAddress"))
    End If
  End Sub

  Private Sub pMessageVisibility(ByVal visible As Boolean)
    pnlMessage.Visible = visible
    For Each c As Control In pnlMessage.Controls
      c.Visible = visible
    Next
  End Sub

End Class
