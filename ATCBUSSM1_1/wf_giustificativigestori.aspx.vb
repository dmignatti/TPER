Public Class wf_giustificativigestori
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daAccertatori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daCausali = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.DsGiustificativi1 = New ATCBussm1.dsGiustificativi
    Me.daGiustificativi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    CType(Me.DsGiustificativi1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daAccertatori
    '
    Me.daAccertatori.SelectCommand = Me.SqlSelectCommand2
    Me.daAccertatori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TPER_Accertatori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("NomeCognome", "NomeCognome")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT ID, LTRIM(RTRIM(ISNULL(Cognome, ''))) + ' ' + LTRIM(RTRIM(ISNULL(Nome, '')" & _
    ")) + ' -  ' + IDUser AS NomeCognome FROM dbo.ATC_Utenti WHERE (TipoUtente = 2) A" & _
    "ND (Abilitato = 1) ORDER BY NomeCognome"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'daCausali
    '
    Me.daCausali.AcceptChangesDuringFill = False
    Me.daCausali.SelectCommand = Me.SqlSelectCommand4
    Me.daCausali.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_Causale", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Codice", "Codice")})})
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT ID, Nome, Codice FROM dbo.Accertatori_GiustificativoCausale WHERE (GETDATE" & _
    "() >= ValiditaDa) AND (GETDATE() <= ValiditaA) ORDER BY Nome"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'DsGiustificativi1
    '
    Me.DsGiustificativi1.DataSetName = "dsGiustificativi"
    Me.DsGiustificativi1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daGiustificativi
    '
    Me.daGiustificativi.DeleteCommand = Me.SqlCommand1
    Me.daGiustificativi.InsertCommand = Me.SqlCommand2
    Me.daGiustificativi.SelectCommand = Me.SqlSelectCommand1
    Me.daGiustificativi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_GiustificativoRichiesta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("Accertatori_GiustificativoCausaleId", "Accertatori_GiustificativoCausaleId"), New System.Data.Common.DataColumnMapping("DataDa", "DataDa"), New System.Data.Common.DataColumnMapping("DataA", "DataA"), New System.Data.Common.DataColumnMapping("OraDa", "OraDa"), New System.Data.Common.DataColumnMapping("OraA", "OraA"), New System.Data.Common.DataColumnMapping("Ora_Da", "Ora_Da"), New System.Data.Common.DataColumnMapping("Minuti_Da", "Minuti_Da"), New System.Data.Common.DataColumnMapping("Ora_A", "Ora_A"), New System.Data.Common.DataColumnMapping("Minuti_A", "Minuti_A"), New System.Data.Common.DataColumnMapping("StatoGiustificativo", "StatoGiustificativo"), New System.Data.Common.DataColumnMapping("DataRichiesta", "DataRichiesta"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("ApprovatoDa", "ApprovatoDa"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("Causale", "Causale"), New System.Data.Common.DataColumnMapping("Frazionato", "Frazionato"), New System.Data.Common.DataColumnMapping("DefaultApprovato", "DefaultApprovato"), New System.Data.Common.DataColumnMapping("PreavvisoGG", "PreavvisoGG"), New System.Data.Common.DataColumnMapping("NrMaxGG", "NrMaxGG")})})
    Me.daGiustificativi.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.Accertatori_GiustificativoRichiesta WHERE (ID = @ID)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "INSERT INTO dbo.Accertatori_GiustificativoRichiesta (ID, AccertatoreId, Accertato" & _
    "ri_GiustificativoCausaleId, DataDa, DataA, OraDa, OraA, StatoGiustificativo, Dat" & _
    "aRichiesta, DataApprovazione, ApprovatoDa, CreatedOn, ModifiedOn, CreatedBy, Mod" & _
    "ifiedBy, Frazionato, DefaultApprovato, PreavvisoGG, NrMaxGG) VALUES (@ID, @Accer" & _
    "tatoreId, @Accertatori_GiustificativoCausaleId, @DataDa, @DataA, @OraDa, @OraA, " & _
    "@StatoGiustificativo, @DataRichiesta, @DataApprovazione, @ApprovatoDa, @CreatedO" & _
    "n, @ModifiedOn, @CreatedBy, @ModifiedBy, @Frazionato, @DefaultApprovato, @Preavv" & _
    "isoGG, @NrMaxGG)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_GiustificativoCausaleId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_GiustificativoCausaleId"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataDa", System.Data.SqlDbType.DateTime, 8, "DataDa"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataA", System.Data.SqlDbType.DateTime, 8, "DataA"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraDa", System.Data.SqlDbType.DateTime, 8, "OraDa"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraA", System.Data.SqlDbType.DateTime, 8, "OraA"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoGiustificativo", System.Data.SqlDbType.Int, 4, "StatoGiustificativo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataRichiesta", System.Data.SqlDbType.DateTime, 8, "DataRichiesta"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ApprovatoDa", System.Data.SqlDbType.Bit, 1, "ApprovatoDa"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedOn", System.Data.SqlDbType.DateTime, 8, "CreatedOn"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frazionato", System.Data.SqlDbType.Bit, 1, "Frazionato"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DefaultApprovato", System.Data.SqlDbType.Bit, 1, "DefaultApprovato"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreavvisoGG", System.Data.SqlDbType.Int, 4, "PreavvisoGG"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrMaxGG", System.Data.SqlDbType.Int, 4, "NrMaxGG"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, G.ID, G.AccertatoreId, G.Accertat" & _
    "ori_GiustificativoCausaleId, G.DataDa, G.DataA, G.OraDa, G.OraA, DATEPART(hour, " & _
    "G.OraDa) AS Ora_Da, DATEPART(minute, G.OraDa) AS Minuti_Da, DATEPART(hour, G.Ora" & _
    "A) AS Ora_A, DATEPART(minute, G.OraA) AS Minuti_A, G.StatoGiustificativo, G.Data" & _
    "Richiesta, G.DataApprovazione, G.ApprovatoDa, G.CreatedOn, G.ModifiedOn, G.Creat" & _
    "edBy, G.ModifiedBy, U1.IDUser + ' - ' + U1.Cognome + ' ' + U1.Nome AS CognomeNom" & _
    "e, dbo.Accertatori_GiustificativoCausale.Nome AS Causale, G.Frazionato AS Frazio" & _
    "nato, G.DefaultApprovato, G.PreavvisoGG, G.NrMaxGG, CASE WHEN G.StatoGiustificat" & _
    "ivo IS NULL THEN 'Da approvare' WHEN G.StatoGiustificativo = 0 THEN 'Respinta' W" & _
    "HEN G.StatoGiustificativo = 1 THEN 'Approvata' END AS StatoApprovazione FROM dbo" & _
    ".Accertatori_GiustificativoRichiesta G INNER JOIN dbo.Accertatori_Giustificativo" & _
    "Causale ON G.Accertatori_GiustificativoCausaleId = dbo.Accertatori_Giustificativ" & _
    "oCausale.ID LEFT OUTER JOIN dbo.ATC_Utenti U1 ON G.AccertatoreId = U1.ID LEFT OU" & _
    "TER JOIN dbo.ATC_Utenti U ON G.ApprovatoDa = U.ID WHERE (G.DataA >= DATEADD(d, D" & _
    "ATEDIFF(d, 0, GETDATE()), 0)) AND (G.AccertatoreId = @AccertatoreId) ORDER BY G." & _
    "CreatedOn DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.Accertatori_GiustificativoRichiesta SET AccertatoreId = @AccertatoreId" & _
    ", Accertatori_GiustificativoCausaleId = @Accertatori_GiustificativoCausaleId, Da" & _
    "taDa = @DataDa, DataA = @DataA, OraDa = @OraDa, OraA = @OraA, StatoGiustificativ" & _
    "o = @StatoGiustificativo, DataRichiesta = @DataRichiesta, DataApprovazione = @Da" & _
    "taApprovazione, ApprovatoDa = @ApprovatoDa, ModifiedOn = @ModifiedOn, CreatedBy " & _
    "= @CreatedBy, ModifiedBy = @ModifiedBy, Frazionato = @Frazionato, DefaultApprova" & _
    "to = @DefaultApprovato, PreavvisoGG = @PreavvisoGG, NrMaxGG = @NrMaxGG WHERE (ID" & _
    " = @ID)"
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_GiustificativoCausaleId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_GiustificativoCausaleId"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataDa", System.Data.SqlDbType.DateTime, 8, "DataDa"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataA", System.Data.SqlDbType.DateTime, 8, "DataA"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraDa", System.Data.SqlDbType.DateTime, 8, "OraDa"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OraA", System.Data.SqlDbType.DateTime, 8, "OraA"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoGiustificativo", System.Data.SqlDbType.Int, 4, "StatoGiustificativo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataRichiesta", System.Data.SqlDbType.DateTime, 8, "DataRichiesta"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ApprovatoDa", System.Data.SqlDbType.Bit, 1, "ApprovatoDa"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frazionato", System.Data.SqlDbType.Bit, 1, "Frazionato"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DefaultApprovato", System.Data.SqlDbType.Bit, 1, "DefaultApprovato"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreavvisoGG", System.Data.SqlDbType.Int, 4, "PreavvisoGG"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrMaxGG", System.Data.SqlDbType.Int, 4, "NrMaxGG"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=False;initial catalog=ATCBussm"
    CType(Me.DsGiustificativi1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents btnAddRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents daAccertatori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents Label6 As System.Web.UI.WebControls.Label
  Protected WithEvents ddlCausali As System.Web.UI.WebControls.DropDownList
  Protected WithEvents daCausali As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsGiustificativi1 As ATCBussm1.dsGiustificativi
  Protected WithEvents dgGiustificativi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daGiustificativi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents ddlAccertatori As System.Web.UI.WebControls.DropDownList
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Dim oUtente As Utente
  Dim fnc As New Funzioni
  Const TableRG As String = "Accertatori_GiustificativoRichiesta"
  Const TableCG As String = "Accertatori_Causale"
  Const TableA As String = "TPER_Accertatori"
  Const Modulo As String = "wf_giustificativigestore.aspx"
  Dim accertatoreid As String
  Dim accertatoreNome As String

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    cvTipoUtente.Validate()
    'btnAddRichiesta.Enabled = cvTipoUtente.IsValid And dgGiustificativi.EditItemIndex = -1


    If Not IsPostBack Then
      daAccertatori.Fill(DsGiustificativi1, TableA)
      ddlAccertatori.DataBind()
      daCausali.Fill(DsGiustificativi1, TableCG)
      ddlCausali.DataBind()

      fnc.ScriviLog(oUtente.IDUser, Modulo, "Pagina iniziale", Session("IPAddress"))

      daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
      daGiustificativi.Fill(DsGiustificativi1, TableRG)
      dgGiustificativi.DataBind()
      Page.DataBind()
      Session.Add("CausaleIndex", Convert.ToInt32(ddlCausali.SelectedIndex))
    Else
      'daCausali.Fill(DsGiustificativi1, TableCG)
      'ddlCausali.DataBind()
      'ddlCausali.SelectedIndex = Session("CausaleIndex")
      'daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
      'daGiustificativi.Fill(DsGiustificativi1, TableRG)
      'dgGiustificativi.DataBind()
      'Page.DataBind()
    End If
    btnAddRichiesta.Enabled = dgGiustificativi.EditItemIndex = -1
    ddlCausali.Enabled = dgGiustificativi.EditItemIndex = -1
    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    daGiustificativi.Fill(DsGiustificativi1, TableRG)

  End Sub

  Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRichiesta.Click
    Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).NewRow
    Dim dt As DateTime

    Dim drcausali As SqlClient.SqlDataReader

    dt = Now.Date
    dr.Item("ID") = Guid.NewGuid
    dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    dr.Item("Accertatori_GiustificativoCausaleId") = New Guid(ddlCausali.Items(ddlCausali.SelectedIndex).Value)
    dr.Item("DataDa") = Now.Date
    dr.Item("DataA") = Now.Date
    dr.Item("DataRichiesta") = Now
    dr.Item("CreatedOn") = Now
    dr.Item("CreatedBy") = oUtente.ID
    dr.Item("ModifiedOn") = Now
    dr.Item("ModifiedBy") = oUtente.ID

    dr.Item("OraDa") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
    dr.Item("OraA") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
    con.Open()
    Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG] " & _
                   " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & ddlCausali.Items(ddlCausali.SelectedIndex).Value & "'", con)

    drcausali = cmdcausali.ExecuteReader()
    If drcausali.HasRows Then
      drcausali.Read()
      dr.Item("Frazionato") = drcausali(3)
      dr.Item("DefaultApprovato") = drcausali(4)
      dr.Item("PreavvisoGG") = drcausali(5)
      dr.Item("NrMaxGG") = drcausali(6)
    End If
    con.Close()
    DsGiustificativi1.Tables(TableRG).Rows.InsertAt(dr, 0)
    dgGiustificativi.EditItemIndex = 0

    'Page.DataBind()
    dgGiustificativi.DataBind()
    btnAddRichiesta.Enabled = False
    ddlCausali.Enabled = False

    fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Click nuova richiesta giustificativo", Session("IPAddress"))
  End Sub


  Public Sub cvMinData_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    'Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, System.Web.UI.WebControls.DataGridItem).ItemIndex))
    'DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(DirectCast(source, CustomValidator).Parent))
    ' args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDataDa"), Calendar).SelectedDate >= Now.Date



    args.IsValid = True

  End Sub

  Public Sub cvAlleOre_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    'Dim t1 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre1"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue, 0)
    'Dim t2 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre1"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti1"), DropDownList).SelectedValue, 0)
    'Dim t1h As Integer
    'Dim t1m As Integer
    'Dim t2h As Integer
    'Dim t2m As Integer

    'Dim t3h As Integer
    'Dim t3m As Integer
    'Dim t4h As Integer
    'Dim t4m As Integer
    'Dim ris As Boolean

    't1h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre1"), DropDownList).SelectedValue)
    't1m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue)
    't2h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre1"), DropDownList).SelectedValue)
    't2m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti1"), DropDownList).SelectedValue)

    't3h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre2"), DropDownList).SelectedValue)
    't3m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti2"), DropDownList).SelectedValue)
    't4h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre2"), DropDownList).SelectedValue)
    't4m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti2"), DropDownList).SelectedValue)
    'Dim t3 As New TimeSpan(t3h, t3m, 0)
    'Dim t4 As New TimeSpan(t4h, t4m, 0)
    'ris = True
    'If (t2h <> 0 Or t2m <> 0) Then
    '  ris = t2.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    'End If


    'If (t3h <> 0 Or t3m <> 0) Then
    '  ris = ris And t3.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    '  ris = ris And t3.Subtract(t2).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    'End If
    'If (t4h <> 0 Or t4m <> 0) Then
    '  ris = ris And t4.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    '  ris = ris And t4.Subtract(t2).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    '  ris = ris And t4.Subtract(t3).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    'End If


    'args.IsValid = ris

  End Sub

  Private Sub dgGiustificativi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.UpdateCommand

    If Me.IsValid Then

      Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsGiustificativi1.Tables(TableRG).NewRow
        dr.Item("ID") = Guid.NewGuid
        dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
        dr.Item("Accertatori_GiustificativoCausaleId") = New Guid(ddlCausali.Items(ddlCausali.SelectedIndex).Value)
        dr.Item("DataRichiesta") = Now
        dr.Item("CreatedOn") = Now
        dr.Item("ModifiedOn") = Now
        dr.Item("CreatedBy") = oUtente.ID
        dr.Item("ModifiedBy") = oUtente.ID
        con.Open()
        Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG] " & _
                       " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & ddlCausali.Items(ddlCausali.SelectedIndex).Value & "'", con)
        Dim drcausali As SqlClient.SqlDataReader

        drcausali = cmdcausali.ExecuteReader()
        If drcausali.HasRows Then
          drcausali.Read()
          dr.Item("Frazionato") = drcausali(3)
          dr.Item("DefaultApprovato") = drcausali(4)
          dr.Item("PreavvisoGG") = drcausali(5)
          dr.Item("NrMaxGG") = drcausali(6)
        End If
        con.Close()
        DsGiustificativi1.Tables(TableRG).Rows.Add(dr)
      End If
      Dim dtDa As DateTime
      dtDa = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
      Dim dtA As DateTime
      dtA = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
      dr.Item("DataDa") = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
      dr.Item("DataA") = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
      If (dr.Item("Frazionato") = True) Then
        dr.Item("OraDa") = New DateTime(Year(dtDa), Month(dtDa), Day(dtDa), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).SelectedValue), 0)
        dr.Item("OraA") = New DateTime(Year(dtA), Month(dtA), Day(dtA), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).SelectedValue), 0)
      Else

        dr.Item("OraDa") = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
        dr.Item("OraA") = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
      End If
      If (dr.Item("DefaultApprovato")) Then
        dr.Item("StatoGiustificativo") = 1
        dr.Item("DataApprovazione") = Now
        dr.Item("ApprovatoDa") = oUtente.ID

      End If
      If (dr.Item("OraDa") > dr.Item("OraA")) Then
        DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Verificare di aver inserito le date corrette"
        DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
        fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato inserimento giustificativo date errate.", Session("IPAddress"))

      Else

        daGiustificativi.Update(DsGiustificativi1, TableRG)
        DsGiustificativi1.Tables(TableRG).Clear()
        dgGiustificativi_CancelCommand(source, e)
        fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo ", Session("IPAddress"))
      End If
    End If
  


  End Sub

  Private Sub dgGiustificativi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgGiustificativi.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di giusitficativo?');")

  End Sub

  Private Sub dgGiustificativi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.DeleteCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daGiustificativi.Update(DsGiustificativi1, TableRG)
        fnc.ScriviLog(oUtente.IDUser, Modulo, "Eliminato giustificativo", Session("IPAddress"))
      End If
      dgGiustificativi_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgGiustificativi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.CancelCommand
    dgGiustificativi.EditItemIndex = -1
    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    daGiustificativi.Fill(DsGiustificativi1, TableRG)
    dgGiustificativi.DataBind()
    btnAddRichiesta.Enabled = True
    ddlCausali.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Annullata modifica", Session("IPAddress"))

  End Sub

  Private Sub dgGiustificativi_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgGiustificativi.ItemDataBound
    Dim dtda1 As DateTime
    Dim dta1 As DateTime
    Dim dtda2 As DateTime
    Dim dta2 As DateTime
    Dim frazionato As Boolean

    frazionato = True

    If Not e.Item.FindControl("ddlOraDa") Is Nothing Then

      Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
      dtda1 = dr.Item("OraDa")

      ' If ( dr.Item("Frazionato")   = ) Then
      'End If
      If Not IsDBNull(dr.Item("Frazionato")) Then
        If (dr.Item("Frazionato") = False) Then

          DirectCast(e.Item.FindControl("LblOraDa"), Label).Visible = False
          DirectCast(e.Item.FindControl("LblMinutiDa"), Label).Visible = False
          DirectCast(e.Item.FindControl("LblOraA"), Label).Visible = False
          DirectCast(e.Item.FindControl("LblMinutiA"), Label).Visible = False

          DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).Visible = False
          DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).Visible = False
          DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).Visible = False
          DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).Visible = False

        Else
          DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).SelectedValue = dtda1.Hour
          If Not e.Item.FindControl("ddlMinutiDa") Is Nothing Then
            'Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
            dtda1 = dr.Item("OraDa")
            DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).SelectedValue = dtda1.Minute
          End If

          If Not e.Item.FindControl("ddlOraA") Is Nothing Then
            'Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
            dta1 = dr.Item("OraA")
            DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).SelectedValue = dta1.Hour
          End If
          If Not e.Item.FindControl("ddlMinutiA") Is Nothing Then
            'Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
            dta1 = dr.Item("OraA")
            DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).SelectedValue = dta1.Minute
          End If
        End If

        'End If

      End If

    End If

  End Sub

  Private Sub dgGiustificativi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.EditCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      dgGiustificativi.EditItemIndex = e.Item.ItemIndex
      daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
      daGiustificativi.Fill(DsGiustificativi1, TableRG)
      dgGiustificativi.DataBind()
      btnAddRichiesta.Enabled = False
      ddlCausali.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Inizio modifica giustificativo", Session("IPAddress"))
    End If
  End Sub

  Private Sub ddlCausali_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCausali.SelectedIndexChanged
    Session.Remove("CausaleIndex")
    Session.Add("CausaleIndex", Convert.ToInt32(ddlCausali.SelectedIndex))
  End Sub

  Private Function pCountGG(ByVal dal As Date, ByVal al As Date) As Integer
    Dim i As Integer = 0
    Do While dal <= al
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
      Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value & "') AND (DataRiposo = @Data) ", con)
      riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
      con.Open()
      If Not (dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0 Or riposi.ExecuteScalar() > 0) Then i += 1
      con.Close()
      dal = dal.AddDays(1)
    Loop
    pCountGG = i

  End Function

  Private Function RitornaRiposi(ByVal dal As Date, ByVal al As Date) As String
    Dim strriposi As String = ""
    Do While dal <= al
      Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
      riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
      con.Open()
      If (riposi.ExecuteScalar() > 0) Then
        strriposi = strriposi & "<br />" & "data: " & Format(dal, "dd/MM/yyyy")

      End If
      con.Close()
      dal = dal.AddDays(1)
    Loop
    RitornaRiposi = strriposi

  End Function


  Private Function pCountFeriali(ByVal dal As Date, ByVal al As Date) As Integer
    Dim i As Integer = 0
    Do While dal <= al
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal

      con.Open()
      If Not (dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0) Then i += 1
      con.Close()
      dal = dal.AddDays(1)
    Loop
    pCountFeriali = i

  End Function

  Private Function RichiestePresenti(ByVal dal As Date, ByVal al As Date) As String
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("SELECT G.AccertatoreId, G.OraDa, G.OraA, G.DataRichiesta, C.Nome " & _
                        " FROM Accertatori_GiustificativoRichiesta AS G INNER JOIN " & _
                        " Accertatori_GiustificativoCausale AS C ON G.Accertatori_GiustificativoCausaleId = C.ID " & _
                        " WHERE ((G.StatoGiustificativo IS NULL) OR (G.StatoGiustificativo = 0) OR " & _
                        " (G.StatoGiustificativo = 1)) and  AccertatoreId  = " & ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value.ToString() & " " & _
                        " and not (G.OraA<CONVERT(DATETIME, '" & Replace(Format(dal, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) or G.OraDa>CONVERT(DATETIME, '" & Replace(Format(al, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) )", con)
    Dim drgiustificativi As SqlClient.SqlDataReader
    con.Open()
    drgiustificativi = cmdgiustificativi.ExecuteReader()
    If drgiustificativi.HasRows Then
      Do While drgiustificativi.Read
        richiesta = richiesta & "<br />" & System.Convert.ToString(drgiustificativi("Nome")) & "- Da " & drgiustificativi("OraDa") & " a " & drgiustificativi("OraA") & " richiesta in data: " & drgiustificativi("DataRichiesta")

      Loop
    End If
    con.Close()

    RichiestePresenti = richiesta

  End Function


  Private Sub ddlAccertatori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlAccertatori.SelectedIndexChanged
    'ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    btnAddRichiesta.Enabled = dgGiustificativi.EditItemIndex = -1
    ddlCausali.Enabled = dgGiustificativi.EditItemIndex = -1
    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    daGiustificativi.Fill(DsGiustificativi1, TableRG)
    dgGiustificativi.DataBind()
  End Sub
End Class
