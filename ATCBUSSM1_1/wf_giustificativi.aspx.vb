Public Class wf_giustificativi
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
    Me.SqlSelectCommand1.CommandText = "SELECT distinct U.Cognome + ' ' + U.Nome AS Approvatore, G.ID, G.AccertatoreId, G" & _
    ".Accertatori_GiustificativoCausaleId, G.DataDa, G.DataA, G.OraDa, isnull(DBO.Get" & _
    "OrderGiustificativi(DATADA,AccertatoreId,Accertatori_GiustificativoCausale.codic" & _
    "e),'') AS ORDINE, Accertatori_GiustificativoCausale.codice as CODICE, G.OraA, DA" & _
    "TEPART(hour, G.OraDa) AS Ora_Da, DATEPART(minute, G.OraDa) AS Minuti_Da, DATEPAR" & _
    "T(hour, G.OraA) AS Ora_A, DATEPART(minute, G.OraA) AS Minuti_A, G.StatoGiustific" & _
    "ativo, G.DataRichiesta, G.DataApprovazione, G.ApprovatoDa, G.CreatedOn, G.Modifi" & _
    "edOn, G.CreatedBy, G.ModifiedBy, U1.IDUser + ' - ' + U1.Cognome + ' ' + U1.Nome " & _
    "AS CognomeNome, dbo.Accertatori_GiustificativoCausale.Nome AS Causale, G.Frazion" & _
    "ato AS Frazionato, G.DefaultApprovato, G.PreavvisoGG, G.NrMaxGG, CASE WHEN G.Sta" & _
    "toGiustificativo IS NULL THEN 'Da approvare' WHEN G.StatoGiustificativo = 0 THEN" & _
    " 'Respinta' WHEN G.StatoGiustificativo = 1 THEN 'Approvata' END AS StatoApprovaz" & _
    "ione FROM dbo.Accertatori_GiustificativoRichiesta G INNER JOIN dbo.Accertatori_G" & _
    "iustificativoCausale ON G.Accertatori_GiustificativoCausaleId = dbo.Accertatori_" & _
    "GiustificativoCausale.ID LEFT OUTER JOIN dbo.ATC_Utenti U1 ON G.AccertatoreId = " & _
    "U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U ON G.ApprovatoDa = U.ID WHERE (G.DataA >=" & _
    " DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) AND (G.AccertatoreId = @AccertatoreId" & _
    ") ORDER BY G.CreatedOn DESC"
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
  Const Modulo As String = "wf_giustificativi.aspx"
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
    btnAddRichiesta.Enabled = dgGiustificativi.EditItemIndex = -1
    ddlCausali.Enabled = dgGiustificativi.EditItemIndex = -1
    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
    daGiustificativi.Fill(DsGiustificativi1, TableRG)
    If Not IsPostBack Then

      daCausali.Fill(DsGiustificativi1, TableCG)

      ddlCausali.DataBind()

      fnc.ScriviLog(oUtente.IDUser, Modulo, "Pagina iniziale", Session("IPAddress"))

      daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
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

  End Sub

  Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRichiesta.Click
    Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).NewRow
    Dim dt As DateTime

    Dim drcausali As SqlClient.SqlDataReader
    oUtente.bStoInserendo = True
    dt = Now.Date
    dr.Item("ID") = Guid.NewGuid
    dr.Item("AccertatoreId") = oUtente.ID
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
    args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDataDa"), Calendar).SelectedDate >= Now.Date



    args.IsValid = True

  End Sub

  Public Sub cvAlleOre_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    


    'args.IsValid = ris

  End Sub

  Private Sub dgGiustificativi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.UpdateCommand
    Dim senzapreavviso As Boolean
    Dim CodiceCausale As String
    If Me.IsValid Then

      Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsGiustificativi1.Tables(TableRG).NewRow
        dr.Item("ID") = Guid.NewGuid
        dr.Item("AccertatoreId") = oUtente.ID
        dr.Item("Accertatori_GiustificativoCausaleId") = New Guid(ddlCausali.Items(ddlCausali.SelectedIndex).Value)
        dr.Item("DataRichiesta") = Now
        dr.Item("CreatedOn") = Now
        dr.Item("ModifiedOn") = Now
        dr.Item("CreatedBy") = oUtente.ID
        dr.Item("ModifiedBy") = oUtente.ID
        con.Open()
        Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG], [SenzaPreavviso] " & _
                       " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & ddlCausali.Items(ddlCausali.SelectedIndex).Value & "'", con)
        Dim drcausali As SqlClient.SqlDataReader

        drcausali = cmdcausali.ExecuteReader()
        If drcausali.HasRows Then
          drcausali.Read()
          dr.Item("Frazionato") = drcausali(3)
          dr.Item("DefaultApprovato") = drcausali(4)
          dr.Item("PreavvisoGG") = drcausali(5)
          dr.Item("NrMaxGG") = drcausali(6)
          senzapreavviso = Convert.ToBoolean(drcausali(7))
          'DM2020.04 leggo il codice causale e lo metto nella variabile
          CodiceCausale = drcausali(2)

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

        If (pCountGG(dr.Item("DataDa"), dr.Item("DataA")) > dr.Item("NrMaxGG")) Then

          DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Il numero massimo di giorni richiedibili per il giustificativo scelto Ë " & dr.Item("NrMaxGG").ToString()
          DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
          fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato inserimento giustificativo numero di giorni richiesti maggiore di " & dr.Item("NrMaxGG").ToString() & " previsti dalla causale.", Session("IPAddress"))
        Else
          If QualeCausale(ddlCausali.Items(ddlCausali.SelectedIndex).Value) = "32" Then
            'DM2020.04 ∞∞∞------∞∞∞ CONGEDO PARENTALE FRAZIONATO ∞∞∞------∞∞∞            
            Dim sTIPO As String
            Dim iOraEnt As Integer
            Dim iMinEnt As Integer
            Dim iOraUsc As Integer
            Dim iMinUsc As Integer
            Dim iTURNO As Integer
            Dim iMassimoMinuti As Integer
            Dim iMinutiChiesti As Integer
            Dim DataDA As Date
            Dim DataA As Date
            Dim sOraEnt As Integer    'scelta ora entrata
            Dim sMinEnt As Integer    'scelti min entrata
            Dim sOraUsc As Integer    'scelta ora uscita
            Dim sMinUsc As Integer    'scelti min uscita
            Dim sMESSAGGIOERRORE As String = ""
            '
            iTURNO = pInCheTurnoSono(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, sTIPO, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
            If sTIPO <> "FT" Then
              If sTIPO = "" Then
                sMESSAGGIOERRORE = "Giorno non di turno"
              Else
                sMESSAGGIOERRORE = "Solo i turni Full-Time possono richiedere un 'Congedo parentale frazionato'"
              End If
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = sMESSAGGIOERRORE
              GoTo FineControlli
            End If
            ' 
            If pCongedoGi‡Presente(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), dr.Item("ID")) Then
              sMESSAGGIOERRORE = "Congedo gi‡ richiesto per quella data"
              GoTo FineControlli
            End If

            ' il numero gg di preavviso (oggi 6) me li faccio passare dalla tabella
            Dim preavvisoGG As Integer
            preavvisoGG = dr.Item("PreavvisoGG")
            If Not DataOKperCongedo(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), preavvisoGG) Then
              sMESSAGGIOERRORE = "La richiesta puÚ essere avanzata dalle 00:00 di " & preavvisoGG.ToString & " giorni lavorativi precedenti e fino alle 24:00 di 3 giorni lavorativi precedenti. " & "<br>" & "Data non valida"
              GoTo FineControlli
            End If
            '
            Dim ORA_ENT1 As Integer   'PRIMA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim MIN_ENT1 As Integer   'PRIMA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim ORA_USC1 As Integer   'PRIMA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim MIN_USC1 As Integer   'PRIMA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim ORA_ENT2 As Integer   'SECONDA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim MIN_ENT2 As Integer   'SECONDA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim ORA_USC2 As Integer   'SECONDA PARTE DELL'ORA ENTRATA - ORA USCITA
            Dim MIN_USC2 As Integer   'SECONDA PARTE DELL'ORA ENTRATA - ORA USCITA

            ' CONTROLLO CHE NON SIA UN TIPO TURNO PART-TIME A CHIEDERE IL CPF

            If iOraEnt > iOraUsc Then
              sMESSAGGIOERRORE = "Ora entrata Ë maggiore dell'ora di uscita"
              GoTo FineControlli
            End If
            datada = FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate).ToString + " " + iOraEnt.ToString + ":" + iMinEnt.ToString
            DataA = FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataA"), Calendar).SelectedDate, DateFormat.ShortDate).ToString + " " + iOraUsc.ToString + ":" + iMinUsc.ToString
            iMassimoMinuti = DateDiff(DateInterval.Minute, datada, DataA)
            '
            '
            If iMassimoMinuti <= 431 Then
              'SE PASSO DI QUI MI TROVO IN UN TURNO FT non SPEZZATO
              iMassimoMinuti = (iMassimoMinuti \ 2)
              '---> CONTROLLO ULTERIORE: se esistono gi‡, in questo mese, altre richieste di Congedo PF, 
              '--                       se ci sono un numero dispari di richieste, faccio uscire un numero dispari 215
              '--                       altrimenti un numero pari 216
              If (pCongedoPresenteNelMese(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), dr.Item("ID")) Mod 2) = 0 Then
                iMassimoMinuti = iMassimoMinuti + 1
              End If
              ORA_ENT1 = iOraEnt
              MIN_ENT1 = iMinEnt
              ORA_USC1 = Hour(DateAdd(DateInterval.Minute, iMassimoMinuti, datada))
              MIN_USC1 = Minute(DateAdd(DateInterval.Minute, iMassimoMinuti, datada))
              ORA_ENT2 = Hour(DateAdd(DateInterval.Minute, iMassimoMinuti * -1, DataA))
              MIN_ENT2 = Minute(DateAdd(DateInterval.Minute, iMassimoMinuti * -1, DataA))
              ORA_USC2 = iOraUsc
              MIN_USC2 = iMinUsc
            Else
              'QUI MI TROVO IN UNO SPEZZATO
              'mattina 3.35 (215 min o 216 a seconda ....) - pomeriggio 2.11 (131 min)
              'SE PASSO DI QUI MI TROVO IN UN TURNO FT non SPEZZATO
              iMassimoMinuti = 215
              '---> CONTROLLO ULTERIORE: se esistono gi‡, in questo mese, altre richieste di Congedo PF, 
              '--                       se ci sono un numero dispari di richieste, faccio uscire un numero dispari 215
              '--                       altrimenti un numero pari 216
              If (pCongedoPresenteNelMese(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), dr.Item("ID")) Mod 2) = 0 Then
                iMassimoMinuti = iMassimoMinuti + 1
              End If
              ORA_ENT1 = iOraEnt
              MIN_ENT1 = iMinEnt
              ORA_USC1 = Hour(DateAdd(DateInterval.Minute, iMassimoMinuti, datada))
              MIN_USC1 = Minute(DateAdd(DateInterval.Minute, iMassimoMinuti, datada))
              ORA_ENT2 = Hour(DateAdd(DateInterval.Minute, -131, DataA))
              MIN_ENT2 = Minute(DateAdd(DateInterval.Minute, -131, DataA))
              ORA_USC2 = iOraUsc
              MIN_USC2 = iMinUsc
            End If
            '
            sOraEnt = DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).SelectedValue
            sMinEnt = DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).SelectedValue
            sOraUsc = DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).SelectedValue
            sMinUsc = DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).SelectedValue
            ' ora calcolo quanti minuti ha chiesto questo utente
            datada = FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate).ToString + " " + sOraEnt.ToString + ":" + sMinEnt.ToString
            DataA = FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataA"), Calendar).SelectedDate, DateFormat.ShortDate).ToString + " " + sOraUsc.ToString + ":" + sMinUsc.ToString
            iMinutiChiesti = DateDiff(DateInterval.Minute, datada, DataA)
            ' 
            If sOraEnt = ORA_ENT1 And sMinEnt = MIN_ENT1 Then
              'PRIMA PARTE DI TURNO
              If sOraUsc <> ORA_USC1 Or sMinUsc <> MIN_USC1 Then
                sMESSAGGIOERRORE = "Se si vuole la prima parte del turno, bisogna impostare l'orario di fine alle " & Right("00" + ORA_USC1.ToString, 2) & ":" & Right("00" + MIN_USC1.ToString, 2)
                DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).SelectedItem.Value = Right("00" + ORA_USC1.ToString, 2)
                DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).SelectedItem.Value = Right("00" + MIN_USC1.ToString, 2)
                GoTo FineControlli
              End If
            ElseIf sOraUsc = ORA_USC2 And sMinUsc = MIN_USC2 Then
              'ULTIMA PARTE DI TURNO
              If sOraEnt <> ORA_ENT2 Or sMinEnt <> MIN_ENT2 Then
                sMESSAGGIOERRORE = "Se si vuole la seconda parte del turno, bisogna impostare l'orario di inizio alle " & Right("00" + ORA_ENT2.ToString, 2) & ":" & Right("00" + MIN_ENT2.ToString, 2)
                DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).SelectedItem.Value = Right("00" + ORA_ENT2.ToString, 2)
                DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).SelectedItem.Value = Right("00" + MIN_ENT2.ToString, 2)
                GoTo FineControlli
              End If
            Else
              sMESSAGGIOERRORE = "Attenzione! E' possibile selezionare solo la prima met‡ o la seconda met‡ del turno."
              GoTo FineControlli
            End If


FineControlli:
            If sMESSAGGIOERRORE <> "" Then
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = sMESSAGGIOERRORE
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & " - CONGEDO PF -  " & sMESSAGGIOERRORE, Session("IPAddress"))
            Else
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = True
              '...........
              ' CONFERMATO E INSERITO GIUSTIFICATIVO 
              daGiustificativi.Update(DsGiustificativi1, TableRG)
              DsGiustificativi1.Tables(TableRG).Clear()
              dgGiustificativi_CancelCommand(source, e)
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo ", Session("IPAddress"))
            End If
            '------------- fine 32 - congedo parentale frazionato
          ElseIf QualeCausale(ddlCausali.Items(ddlCausali.SelectedIndex).Value) = "04" Then
            'DM2020.05 ∞∞∞------∞∞∞ 04 DONAZIONE SANGUE ∞∞∞------∞∞∞       
            Dim sMESSAGGIOERRORE As String = ""
            If pDonazioneGi‡Presente(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), dr.Item("ID")) Then
              sMESSAGGIOERRORE = "Donazione sangue gi‡ richiesta per quella data"
              GoTo FineControlliDonazione
            End If
            Dim preavvisoGG As Integer
            preavvisoGG = dr.Item("PreavvisoGG")
            If Not DataOKperDonazione(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), preavvisoGG) Then
              sMESSAGGIOERRORE = "La richiesta puÚ essere avanzata fino alle 18:00 del giorno precedente le 48 ore di servizio."
              GoTo FineControlliDonazione
            End If
            If pFestivita(FormatDateTime(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, DateFormat.ShortDate), True) Then
              sMESSAGGIOERRORE = "Non Ë possibile scegliere un giorno festivo o di riposo"
              GoTo FineControlliDonazione
            End If
            '

FineControlliDonazione:
            If sMESSAGGIOERRORE <> "" Then
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = sMESSAGGIOERRORE
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & " - DONAZIONE SANGUE - " & sMESSAGGIOERRORE, Session("IPAddress"))
            Else
              '...........
              ' CONFERMATO E INSERITO GIUSTIFICATIVO 
              daGiustificativi.Update(DsGiustificativi1, TableRG)
              DsGiustificativi1.Tables(TableRG).Clear()
              dgGiustificativi_CancelCommand(source, e)
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo 04", Session("IPAddress"))
            End If
            '------------- fine 04 - Donazione Sangue
          ElseIf Not (senzapreavviso) Then
            Dim preavvisogg As Int32
            Dim dopo18 As Boolean
            '''DM2020.01 - FINO ALLE 18.00
            ''If (Now.Hour >= 18) Then
            ''  dopo18 = True
            ''Else
            ''  dopo18 = False
            ''End If
            '  preavvisogg = dr.Item("PreavvisoGG") + 1
            'Else
            preavvisogg = dr.Item("PreavvisoGG")
            'End If

            If (pCountFeriali(Now.Date, dr.Item("DataDa")) < preavvisogg) Then
              Dim messaggio As String
              messaggio = "Termini scaduti per la richiesta del giustificativo."

              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = messaggio
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato ins/mod giustificativo il numero di giorni di preavviso " & dr.Item("PreavvisoGG").ToString() & " non Ë rispettato.", Session("IPAddress"))

            Else
              Dim riposi As String = ""
              riposi = RitornaRiposi(dr.Item("DataDa"), dr.Item("DataA"))
              If Not (riposi = "") Then
                DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Non si puÚ richiedere giustificativo se si Ë in riposo: " & riposi
                DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
                fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Blocco ins/mod.Non si puÚ richiedere giustificativo se si Ë in riposo.Riposo:" & riposi & " Da " & dr.Item("OraDa").ToString() & " A " & dr.Item("OraA").ToString(), Session("IPAddress"))

              Else
                Dim richiesta As String = ""
                richiesta = RichiestePresenti(dr.Item("DataDa"), dr.Item("DataA"))
                If Not (richiesta = "") Then
                  DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Sono gi‡ presenti dei giustificativi: <br/>" & richiesta
                  DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
                  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato ins/mod giustificativo ci sono gi‡ dei giustificativi presenti. Da " & dr.Item("OraDa").ToString() & " A " & dr.Item("OraA").ToString(), Session("IPAddress"))

                Else

                  daGiustificativi.Update(DsGiustificativi1, TableRG)
                  DsGiustificativi1.Tables(TableRG).Clear()
                  dgGiustificativi_CancelCommand(source, e)
                  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo ", Session("IPAddress"))
                End If
              End If
            End If
          Else
            'senza preavviso
            Dim datanow As Date
            Dim datada As Date
            datanow = Now.Date
            datada = Convert.ToDateTime(dr.Item("DataDa")).Date
            If (datanow > datada) Then
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Il giustificativo deve essere inserito entro le 23:59:59 della data di partenza."
              DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
              fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato ins/mod giustificativo deve essere inserito entro le 23:59:59 della data di partenza.", Session("IPAddress"))

            Else

              Dim riposi As String = ""
              riposi = RitornaRiposi(dr.Item("DataDa"), dr.Item("DataA"))
              If Not (riposi = "") Then
                DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Non si pu‡ richiede giustificativo se si Ë in riposo: " & riposi
                DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
                fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Blocco ins/mod.Non si pu‡ richiede giustificativo se si Ë in riposo.Riposo:" & riposi & " Da " & dr.Item("OraDa").ToString() & " A " & dr.Item("OraA").ToString(), Session("IPAddress"))

              Else
                Dim richiesta As String = ""
                richiesta = RichiestePresenti(dr.Item("DataDa"), dr.Item("DataA"))
                If Not (richiesta = "") Then
                  DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Sono gi‡ presenti dei giustificativi: <br/>" & richiesta
                  DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
                  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato ins/mod giustificativo ci sono gi‡ dei giustificativi presenti. Da " & dr.Item("OraDa").ToString() & " A " & dr.Item("OraA").ToString(), Session("IPAddress"))

                Else

                  daGiustificativi.Update(DsGiustificativi1, TableRG)
                  DsGiustificativi1.Tables(TableRG).Clear()
                  dgGiustificativi_CancelCommand(source, e)
                  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo ", Session("IPAddress"))

                End If



              End If

            End If
          End If
          End If
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
    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
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
    If e.Item.Cells(6).Text.ToLower = "false" Then
      e.Item.Cells(11).Text = ""
      e.Item.Cells(13).Text = ""
    
    End If

  End Sub

  Private Sub dgGiustificativi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.EditCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      oUtente.bStoInserendo = False
      dgGiustificativi.EditItemIndex = e.Item.ItemIndex
      daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
      daGiustificativi.Fill(DsGiustificativi1, TableRG)
      dgGiustificativi.DataBind()
      'DM2020.04 
      ' --- se entro in modifica devo mettere nella lista la stessa CAUSALE che sto modificando
      Dim s As String
      Dim i As Integer
      s = dgGiustificativi.Items(dgGiustificativi.EditItemIndex).Cells(4).Text
      For i = 0 To ddlCausali.Items.Count - 1
        If ddlCausali.Items(i).Text = s Then
          ddlCausali.SelectedIndex = i
          Exit For
        End If
      Next
      ' --- 
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
      Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
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
    'DM2020.01 - FINO ALLE 18.00
    If (Now.Hour >= 18) Then
      dal = dal.AddDays(1)
    End If
    dal = dal.AddDays(1)
    If dal > al Then
      i = -1
    Else

      Do While dal < al
        Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
        sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal

        con.Open()
        If Not (dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0) Then i += 1
        con.Close()
        dal = dal.AddDays(1)
      Loop
    End If
    pCountFeriali = i

  End Function

  Private Function RichiestePresenti(ByVal dal As Date, ByVal al As Date) As String
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("SELECT G.AccertatoreId, G.OraDa, G.OraA, G.DataRichiesta, C.Nome " & _
                        " FROM Accertatori_GiustificativoRichiesta AS G INNER JOIN " & _
                        " Accertatori_GiustificativoCausale AS C ON G.Accertatori_GiustificativoCausaleId = C.ID " & _
                        " WHERE ((G.StatoGiustificativo IS NULL) OR (G.StatoGiustificativo = 0) OR " & _
                        " (G.StatoGiustificativo = 1)) and  AccertatoreId  = " & oUtente.ID.ToString() & " " & _
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

  Private Sub daCausali_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles daCausali.RowUpdated

  End Sub

  Private Sub dgGiustificativi_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGiustificativi.PreRender
    Dim sTIPO As String
    Dim iOraEnt As Integer
    Dim iMinEnt As Integer
    Dim iOraUsc As Integer
    Dim iMinUsc As Integer
    Dim iTURNO As Integer
    '
    Dim pOraEnt As String
    Dim pMinEnt As String
    Dim pOraUsc As String
    Dim pMinUsc As String
    ColoraGerarchie()
    If dgGiustificativi.EditItemIndex <> -1 Then

      If DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlOraDa"), DropDownList) Is Nothing Then Exit Sub
      If dgGiustificativi.Items.Item(dgGiustificativi.EditItemIndex).Cells(6).Text.ToLower = "false" Then
        dgGiustificativi.Items.Item(dgGiustificativi.EditItemIndex).Cells(11).Text = ""
        dgGiustificativi.Items.Item(dgGiustificativi.EditItemIndex).Cells(13).Text = ""
        Exit Sub
      End If

      iTURNO = pInCheTurnoSono(DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("caDataDa"), Calendar).SelectedDate, sTIPO, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
      ''If iTURNO <> "0" Then
      'Beep()
      'Else
      If Not oUtente.bStoInserendo Then
        pOraEnt = DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlOraDa"), DropDownList).SelectedValue
        pMinEnt = DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlMinutiDa"), DropDownList).SelectedValue
        pOraUsc = DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlOraA"), DropDownList).SelectedValue
        pMinUsc = DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlMinutiA"), DropDownList).SelectedValue
        CaricaListeGiorni(dgGiustificativi.EditItemIndex, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
        If pOraEnt >= iOraEnt Then
          On Error Resume Next
          DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlOraDa"), DropDownList).SelectedValue = Right("00" + pOraEnt, 2)
          DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlMinutiDa"), DropDownList).SelectedValue = Right("00" + pMinEnt, 2)
          DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlOraA"), DropDownList).SelectedValue = Right("00" + pOraUsc, 2)
          DirectCast(dgGiustificativi.Items(dgGiustificativi.EditItemIndex).FindControl("ddlMinutiA"), DropDownList).SelectedValue = Right("00" + pMinUsc, 2)
          On Error GoTo 0
        End If
      Else
        CaricaListeGiorni(dgGiustificativi.EditItemIndex, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
      End If
      'End If          
    End If

  End Sub

  Private Function pInCheTurnoSono(ByVal dal As Date, ByRef inpGruppoTurni As String, ByRef OraEnt1 As Integer, ByRef MinEnt1 As Integer, ByRef OraUsc1 As Integer, ByRef MinUsc1 As Integer) As Integer
    'DM2020.02 - controllo in che turno sono 
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("exec Sp_InCheTurnoSono @Matricola, @Data", con)
    sc.Parameters.Add("@Matricola", SqlDbType.VarChar).Value = oUtente.IDUser
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
    con.Open()
    Dim drTurno As SqlClient.SqlDataReader
    Dim OraMin1 As String
    Dim OraMin2 As String
    Dim OraMin3 As String
    Dim OraMin4 As String
    drTurno = sc.ExecuteReader()
    If drTurno.HasRows Then
      While drTurno.Read
        'DM2020.04 migliorato e preso anche la data DA e data A 
        'conteggio dei campi parte da 0
        pInCheTurnoSono = drTurno.GetValue(8)                 'TUCTUR
        inpGruppoTurni = drTurno.GetString(7).ToString.Trim   'TUGRUA
        '
        OraMin1 = drTurno.GetValue(16) '16 - GOENT1
        OraMin2 = drTurno.GetValue(17)  '17 - GOUSC1
        '
        OraMin3 = drTurno.GetValue(18) '18 - GOENT2
        OraMin4 = drTurno.GetValue(19)  '18 - GOUSC2


        OraEnt1 = Left(OraMin1, 2)
        MinEnt1 = Right(OraMin1, 2)
        'DM2020.04 - potrebbe esserci un orario tipo le 2630 (cioË le 2 e 30 di notte)
        '           in questo caso controllo e tolgo 24 dall'ora
        If OraMin3 = "9999" Then
          If Left(OraMin2, 2) >= 24 Then
            OraUsc1 = Left(OraMin2, 2) - 24
          Else
            OraUsc1 = Left(OraMin2, 2)
          End If
          MinUsc1 = Right(OraMin2, 2)
        Else
          If Left(OraMin4, 2) >= 24 Then
            OraUsc1 = Left(OraMin4, 2) - 24
          Else
            OraUsc1 = Left(OraMin4, 2)
          End If
          MinUsc1 = Right(OraMin4, 2)
        End If
      End While


    Else
      pInCheTurnoSono = 0
    End If
    drTurno.Close()
    con.Close()
  End Function

  Private Sub CaricaListeGiorni(ByVal InpIndex As Integer, ByVal DaOra As Integer, ByVal DaMinuto As Integer, ByVal AOra As Integer, ByVal AMinuto As Integer)
    'DM2020.04
    Dim I As Integer
    Dim bDrastico As Boolean
    ' QUESTO FLAG LO METTO A LIVELLO DI PROGRAMMAZIONE. Ora questa SUB la posso usare dovunque.
    '       se poi vorrÚ essere drastico, la metto a TRUE. Altrimenti riempio l'intera lista di ore da 0 a 23
    bDrastico = False

    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).Items.Clear()
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).Items.Clear()
    '-- PuÚ accadere che l'ora A sia pi˘ piccola di ora DA. Quando c'Ë un turno di notte.
    '-- in questo caso faccio due for... una fino alla ORA DA... fino alle 23 e l'altra dalle 00 all'ora A
    If bDrastico Then
      If AOra > DaOra Then
        For I = DaOra To AOra
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
      Else
        For I = 0 To AOra
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
        For I = DaOra To 23
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
      End If
    Else
      For I = 0 To 23
        DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
      Next I
    End If
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiDa"), DropDownList).Items.Clear()
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiA"), DropDownList).Items.Clear()
    For I = 0 To 59
      DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiDa"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
      DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiA"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
    Next I
    '
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraDa"), DropDownList).SelectedValue = Right("00" + DaOra.ToString, 2)
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiDa"), DropDownList).SelectedValue = Right("00" + DaMinuto.ToString, 2)
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlOraA"), DropDownList).SelectedValue = Right("00" + AOra.ToString, 2)
    DirectCast(dgGiustificativi.Items(InpIndex).FindControl("ddlMinutiA"), DropDownList).SelectedValue = Right("00" + AMinuto.ToString, 2)
  End Sub
  Private Function QualeCausale(ByVal InpID As String) As String

    Dim drcausali As SqlClient.SqlDataReader

    con.Open()
    Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG] " & _
                   " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & InpID.ToString & "'", con)

    drcausali = cmdcausali.ExecuteReader()
    If drcausali.HasRows Then
      drcausali.Read()
      'DM2020.04 leggo il codice causale e lo metto nella variabile
      QualeCausale = drcausali(2)
    End If
    con.Close()
  End Function
  Private Function pFestivita(ByVal dal As Date, Optional ByVal AncheRiposo As Boolean = False) As Boolean
    'DM2020.02 - controllo che la data sia una festivit‡: se lo Ë ritorno TRUE
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = FormatDateTime(dal, DateFormat.ShortDate)
    con.Open()
    If sc.ExecuteScalar() > 0 Or dal.DayOfWeek = DayOfWeek.Sunday Then
      pFestivita = True
    Else
      pFestivita = False
    End If
    con.Close()

    If Not pFestivita And AncheRiposo Then

      Dim scRiposi As New SqlClient.SqlCommand("SELECT COUNT(*) FROM [Riposi] where TTGGGG = DAY(@data) and TTMMGG = MONTH(@data) and TTAAGG = YEAR (@data) and TTMATR = '" & oUtente.IDUser & "'", con)
      scRiposi.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
      con.Open()
      If scRiposi.ExecuteScalar() > 0 Then
        pFestivita = True
      Else
        pFestivita = False
      End If

      con.Close()
    End If
  End Function
  Function DataLavorativa(ByVal inpData As Date, ByVal inpGG As Integer) As Date
    'DM2020.04 - DATA LAVORATIVA: aggiungendo un numero di GG lavorativi ad una data "data", quale DATA esce?
    Dim i As Integer = 0
    Dim dataTrovata As Date
    dataTrovata = inpData
    Do While i < inpGG
      dataTrovata = dataTrovata.AddDays(1)
      If Not pFestivita(dataTrovata) Then i = i + 1
    Loop
    DataLavorativa = FormatDateTime(dataTrovata, DateFormat.ShortDate)
  End Function
  Function DataOKperCongedo(ByVal inpData As Date, ByVal inpPreavviso As Integer) As Boolean
    'DM2020.04 - controlliamo quello che hanno voluto che siano i controlli per il CONGEDO PARENTALE FRAZIONATO
    Dim dDATA_MIN As Date
    Dim dDATA_MAX As Date
    Dim iDiff As Integer
    Dim iDiff2 As Integer
    'Controllo che quel giorno non abbia gi‡ preso uno stesso congedo, altrimenti NIENTE

    dDATA_MIN = DataLavorativa(FormatDateTime(Now.Date, DateFormat.ShortDate), 3)
    dDATA_MAX = DataLavorativa(FormatDateTime(Now.Date, DateFormat.ShortDate), inpPreavviso)

    iDiff = DateDiff(DateInterval.Day, inpData, dDATA_MIN)
    iDiff2 = DateDiff(DateInterval.Day, inpData, dDATA_MAX)
    If iDiff <= 0 And iDiff2 >= 0 Then
      DataOKperCongedo = True
    Else
      DataOKperCongedo = False
    End If
  End Function
  Private Function pCongedoGi‡Presente(ByVal inpData As Date, ByVal IdRichiesta As Guid) As Boolean
    'DM2020.04 - controllo che in quella data io non abbia gi‡ preso un congedo
    ' 32 - CONGEDO PARENTALE FRAZIONATO
    Dim i As Integer = 0

    Dim scCongedi As New SqlClient.SqlCommand("SELECT COUNT(*) from Accertatori_GiustificativoRichiesta RIC " & _
      " inner join [Accertatori_GiustificativoCausale] CAU on CAU.ID = RIC.Accertatori_GiustificativoCausaleId " & _
      " where(CAU.Codice = 32) and DataDa = @Data and AccertatoreId = @Accertatore and RIC.ID<>'" & IdRichiesta.ToString & "'", con)

    scCongedi.Parameters.Add("@Data", SqlDbType.DateTime).Value = inpData
    scCongedi.Parameters.Add("@Accertatore", SqlDbType.Int).Value = oUtente.ID

    con.Open()
    If scCongedi.ExecuteScalar() > 0 Then
      pCongedoGi‡Presente = True
    Else
      pCongedoGi‡Presente = False
    End If

    con.Close()

  End Function

  Private Function pCongedoPresenteNelMese(ByVal inpData As Date, ByVal IdRichiesta As Guid) As Integer
    'DM2020.04 - controllo che in quella data io non abbia gi‡ preso un congedo
    ' 32 - CONGEDO PARENTALE FRAZIONATO
    Dim i As Integer = 0

    Dim scCongedi As New SqlClient.SqlCommand("SELECT COUNT(*) as CONTA from Accertatori_GiustificativoRichiesta RIC " & _
      " inner join [Accertatori_GiustificativoCausale] CAU on CAU.ID = RIC.Accertatori_GiustificativoCausaleId " & _
      " where(CAU.Codice = 32) and month(DataDa) = month(@Data) and DataDa <> @Data " & _
      " and (statoGiustificativo is null or statogiustificativo = 1) " & _
      " and AccertatoreId = @Accertatore and RIC.ID<>'" & IdRichiesta.ToString & "'", con)


    scCongedi.Parameters.Add("@Data", SqlDbType.DateTime).Value = inpData
    scCongedi.Parameters.Add("@Accertatore", SqlDbType.Int).Value = oUtente.ID

    con.Open()

    pCongedoPresenteNelMese = scCongedi.ExecuteScalar()

    con.Close()

  End Function

  Function DataOKperDonazione(ByVal inpData As Date, ByVal inpPreavviso As Integer) As Boolean
    'DM2020.04 - controlliamo quello che hanno voluto che siano i controlli per il DONAZIONE SANGUE
    Dim dDATA_MIN As Date
    Dim iDiff As Integer

    '
    dDATA_MIN = Date48H(inpPreavviso)
    iDiff = DateDiff(DateInterval.Day, inpData, dDATA_MIN)

    ' la data Date48() mi mostra il giorno in cui finisce il GIORNALIERO, ancora giorno NON selezionabile. 
    ' Per cui bisogna controllare che ci sia un numero negativo
    If iDiff < 0 Then
      DataOKperDonazione = True
    Else
      DataOKperDonazione = False
    End If
  End Function
  Private Function pDonazioneGi‡Presente(ByVal inpData As Date, ByVal IdRichiesta As Guid) As Boolean
    'DM2020.04 - controllo che in quella data non ci siano gi‡ delle donazioni richieste
    ' 04 - DONAZIONE SANGUE
    Dim i As Integer = 0

    Dim scCongedi As New SqlClient.SqlCommand("SELECT COUNT(*) from Accertatori_GiustificativoRichiesta RIC " & _
      " inner join [Accertatori_GiustificativoCausale] CAU on CAU.ID = RIC.Accertatori_GiustificativoCausaleId " & _
      " where(CAU.Codice = '04')  and AccertatoreId = @Accertatore and DataDa = @Data and RIC.ID<>'" & IdRichiesta.ToString & "'", con)

    scCongedi.Parameters.Add("@Data", SqlDbType.DateTime).Value = inpData
    scCongedi.Parameters.Add("@Accertatore", SqlDbType.Int).Value = oUtente.ID

    con.Open()
    If scCongedi.ExecuteScalar() > 0 Then
      pDonazioneGi‡Presente = True
    Else
      pDonazioneGi‡Presente = False
    End If

    con.Close()

  End Function
  Private Function Date48H(Optional ByVal nGG As Integer = 2) As DateTime
    Dim i As Integer = 0

    Dim data As DateTime = Now.Date
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    'DM2020.01 - FINO ALLE 18.00
    'DM2020.01 -> precedente --> If (Now.Hour >= 17) Then
    If (Now.Hour >= 18) Then
      data = Now.AddDays(1)
    End If

    Do While i < nGG
      data = data.AddDays(1)
      If Not pFestivita(data) Then i = i + 1
      fnc.ScriviLog(oUtente.IDUser, "wf_giustificativi.aspx", "Controllo festivit‡: " & data.ToString() & " i= " & i.ToString, Session("IPAddress"))
    Loop
    'Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    'riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(data, "dd/MM/yyyy")
    Date48H = data
  End Function

  Private Sub dgGiustificativi_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGiustificativi.DataBinding

  End Sub

  Private Sub dgGiustificativi_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.ItemCommand

  End Sub

  Private Sub dgGiustificativi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGiustificativi.Load

  End Sub
  Sub ColoraGerarchie()
    Dim i As Integer
    Dim sToolTip As String
    Const cORDINE = 17
    Const cCODICE = 18
    Const cDATADA = 19
    sToolTip = "Col colore ROSSO Ë indicato che si Ë in graduatoria al di fuori del limite massimo"
    If dgGiustificativi.EditItemIndex = -1 Then
      For i = 0 To dgGiustificativi.Items.Count - 1

        ' colonna 17: ordine
        ' colonna 18: codice
        ' colonna 19: datada
        If dgGiustificativi.Items(i).Cells(cCODICE).Text = "04" Then
          Dim laDATA As Date
          Dim ilCOLORE As Drawing.Color
          ilCOLORE = Color.Black
          laDATA = dgGiustificativi.Items(i).Cells(cDATADA).Text
          'Else
          'laDATA = FormatDateTime(DirectCast(dgGiustificativi.Items(i).FindControl("LblDataDa"), Label).Text(), DateFormat.ShortDate)
          'End If
          If laDATA.DayOfWeek = DayOfWeek.Saturday Then
            ' se Ë sabato: massimo 1 al gg
            If dgGiustificativi.Items(i).Cells(cORDINE).Text > 1 Then
              ilCOLORE = Color.Red
            End If
          ElseIf pFestivita(laDATA.AddDays(1)) And pFestivita(laDATA.AddDays(-1)) Then
            ' se Ë un gg in mezzo a due giorni di festa: massimo 1 al gg
            If dgGiustificativi.Items(i).Cells(cORDINE).Text > 1 Then
              ilCOLORE = Color.Red
            End If
          Else
            ' altrimenti massimo 2 al gg
            If dgGiustificativi.Items(i).Cells(cORDINE).Text > 2 Then
              ilCOLORE = Color.Red
            End If
          End If
          '
          dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = ilCOLORE
          dgGiustificativi.Items(i).Cells(cORDINE).ToolTip = sToolTip
        ElseIf dgGiustificativi.Items(i).Cells(cCODICE).Text = "32" And IIf(IsNumeric(dgGiustificativi.Items(i).Cells(cORDINE).Text), dgGiustificativi.Items(i).Cells(cORDINE).Text, 0) > 2 Then
          'MASSIMO 2 PER GIORNO SE SI TRATTA DI CONGEDO PARENTALE FRAZIONATO (32)
          dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = Color.Red
          dgGiustificativi.Items(i).Cells(cORDINE).ToolTip = sToolTip
        Else
          dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = Color.Black
        End If
      Next i
    End If
  End Sub

  Private Sub dgGiustificativi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGiustificativi.SelectedIndexChanged

  End Sub
End Class


