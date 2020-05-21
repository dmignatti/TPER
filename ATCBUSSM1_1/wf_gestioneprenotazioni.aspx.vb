Public Class wf_gestioneprenotazioni
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaPrenotazioneRichiesta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsPrenotazioneRichieste1 = New ATCBussm1.DsPrenotazioneRichieste
    Me.DsGestionePreno1 = New ATCBussm1.DsGestionePreno
    CType(Me.DsPrenotazioneRichieste1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsGestionePreno1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'DaPrenotazioneRichiesta
    '
    Me.DaPrenotazioneRichiesta.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaPrenotazioneRichiesta.InsertCommand = Me.SqlInsertCommand1
    Me.DaPrenotazioneRichiesta.SelectCommand = Me.SqlSelectCommand5
    Me.DaPrenotazioneRichiesta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioneRichiesta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("Accertatori_PrenotazioneIntervalliId", "Accertatori_PrenotazioneIntervalliId"), New System.Data.Common.DataColumnMapping("StatoPrenotazione", "StatoPrenotazione"), New System.Data.Common.DataColumnMapping("DataPrenotazione", "DataPrenotazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("CreateOn", "CreateOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.DaPrenotazioneRichiesta.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Accertatori_PrenotazioneRichiesta WHERE (ID = @Original_ID) AND (" & _
    "AccertatoreId = @Original_AccertatoreId OR @Original_AccertatoreId IS NULL AND A" & _
    "ccertatoreId IS NULL) AND (Accertatori_PrenotazioneIntervalliId = @Original_Acce" & _
    "rtatori_PrenotazioneIntervalliId OR @Original_Accertatori_PrenotazioneIntervalli" & _
    "Id IS NULL AND Accertatori_PrenotazioneIntervalliId IS NULL) AND (CreateOn = @Or" & _
    "iginal_CreateOn OR @Original_CreateOn IS NULL AND CreateOn IS NULL) AND (Created" & _
    "By = @Original_CreatedBy OR @Original_CreatedBy IS NULL AND CreatedBy IS NULL) A" & _
    "ND (DataApprovazione = @Original_DataApprovazione OR @Original_DataApprovazione " & _
    "IS NULL AND DataApprovazione IS NULL) AND (DataPrenotazione = @Original_DataPren" & _
    "otazione OR @Original_DataPrenotazione IS NULL AND DataPrenotazione IS NULL) AND" & _
    " (IdApprovatore = @Original_IdApprovatore OR @Original_IdApprovatore IS NULL AND" & _
    " IdApprovatore IS NULL) AND (ModifiedBy = @Original_ModifiedBy OR @Original_Modi" & _
    "fiedBy IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR" & _
    " @Original_ModifiedOn IS NULL AND ModifiedOn IS NULL) AND (StatoPrenotazione = @" & _
    "Original_StatoPrenotazione OR @Original_StatoPrenotazione IS NULL AND StatoPreno" & _
    "tazione IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioneIntervalliId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreateOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreateOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataApprovazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataApprovazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdApprovatore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApprovatore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StatoPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatoPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioneRichiesta(ID, AccertatoreId, Accertatori_" & _
    "PrenotazioneIntervalliId, StatoPrenotazione, DataPrenotazione, DataApprovazione," & _
    " IdApprovatore, CreateOn, ModifiedOn, CreatedBy, ModifiedBy) VALUES (@ID, @Accer" & _
    "tatoreId, @Accertatori_PrenotazioneIntervalliId, @StatoPrenotazione, @DataPrenot" & _
    "azione, @DataApprovazione, @IdApprovatore, @CreateOn, @ModifiedOn, @CreatedBy, @" & _
    "ModifiedBy); SELECT ID, AccertatoreId, Accertatori_PrenotazioneIntervalliId, Sta" & _
    "toPrenotazione, DataPrenotazione, DataApprovazione, IdApprovatore, CreateOn, Mod" & _
    "ifiedOn, CreatedBy, ModifiedBy FROM dbo.Accertatori_PrenotazioneRichiesta WHERE " & _
    "(ID = @ID)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioneIntervalliId"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoPrenotazione", System.Data.SqlDbType.Int, 4, "StatoPrenotazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataPrenotazione", System.Data.SqlDbType.DateTime, 8, "DataPrenotazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdApprovatore", System.Data.SqlDbType.Int, 4, "IdApprovatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand5
    '
    Me.SqlSelectCommand5.CommandText = "SELECT dbo.Accertatori_PrenotazioneRichiesta.ID, dbo.Accertatori_PrenotazioneRich" & _
    "iesta.AccertatoreId, dbo.Accertatori_PrenotazioneRichiesta.Accertatori_Prenotazi" & _
    "oneIntervalliId, dbo.Accertatori_PrenotazioneRichiesta.StatoPrenotazione, dbo.Ac" & _
    "certatori_PrenotazioneRichiesta.DataPrenotazione, dbo.Accertatori_PrenotazioneRi" & _
    "chiesta.DataApprovazione, dbo.Accertatori_PrenotazioneRichiesta.IdApprovatore, d" & _
    "bo.Accertatori_PrenotazioneRichiesta.CreateOn, dbo.Accertatori_PrenotazioneRichi" & _
    "esta.ModifiedOn, dbo.Accertatori_PrenotazioneRichiesta.CreatedBy, dbo.Accertator" & _
    "i_PrenotazioneRichiesta.ModifiedBy, ATC_Utenti_1.IDUser AS matricola, ATC_Utenti" & _
    "_1.Cognome + ' ' + ATC_Utenti_1.Nome AS CognomeNome, dbo.Accertatori_Prenotazion" & _
    "eIntervalli.Nome, ISNULL(dbo.ATC_Utenti.IDUser, '') AS Approvatore FROM dbo.Acce" & _
    "rtatori_PrenotazioneIntervalli INNER JOIN dbo.Accertatori_PrenotazioneRichiesta " & _
    "ON dbo.Accertatori_PrenotazioneIntervalli.ID = dbo.Accertatori_PrenotazioneRichi" & _
    "esta.Accertatori_PrenotazioneIntervalliId LEFT OUTER JOIN dbo.ATC_Utenti ATC_Ute" & _
    "nti_1 ON dbo.Accertatori_PrenotazioneRichiesta.AccertatoreId = ATC_Utenti_1.ID L" & _
    "EFT OUTER JOIN dbo.ATC_Utenti ON dbo.Accertatori_PrenotazioneRichiesta.IdApprova" & _
    "tore = dbo.ATC_Utenti.ID"
    Me.SqlSelectCommand5.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori_PrenotazioneRichiesta SET ID = @ID, AccertatoreId = @Accer" & _
    "tatoreId, Accertatori_PrenotazioneIntervalliId = @Accertatori_PrenotazioneInterv" & _
    "alliId, StatoPrenotazione = @StatoPrenotazione, DataPrenotazione = @DataPrenotaz" & _
    "ione, DataApprovazione = @DataApprovazione, IdApprovatore = @IdApprovatore, Crea" & _
    "teOn = @CreateOn, ModifiedOn = @ModifiedOn, CreatedBy = @CreatedBy, ModifiedBy =" & _
    " @ModifiedBy WHERE (ID = @Original_ID) AND (AccertatoreId = @Original_Accertator" & _
    "eId OR @Original_AccertatoreId IS NULL AND AccertatoreId IS NULL) AND (Accertato" & _
    "ri_PrenotazioneIntervalliId = @Original_Accertatori_PrenotazioneIntervalliId OR " & _
    "@Original_Accertatori_PrenotazioneIntervalliId IS NULL AND Accertatori_Prenotazi" & _
    "oneIntervalliId IS NULL) AND (CreateOn = @Original_CreateOn OR @Original_CreateO" & _
    "n IS NULL AND CreateOn IS NULL) AND (CreatedBy = @Original_CreatedBy OR @Origina" & _
    "l_CreatedBy IS NULL AND CreatedBy IS NULL) AND (DataApprovazione = @Original_Dat" & _
    "aApprovazione OR @Original_DataApprovazione IS NULL AND DataApprovazione IS NULL" & _
    ") AND (DataPrenotazione = @Original_DataPrenotazione OR @Original_DataPrenotazio" & _
    "ne IS NULL AND DataPrenotazione IS NULL) AND (IdApprovatore = @Original_IdApprov" & _
    "atore OR @Original_IdApprovatore IS NULL AND IdApprovatore IS NULL) AND (Modifie" & _
    "dBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND ModifiedBy IS NUL" & _
    "L) AND (ModifiedOn = @Original_ModifiedOn OR @Original_ModifiedOn IS NULL AND Mo" & _
    "difiedOn IS NULL) AND (StatoPrenotazione = @Original_StatoPrenotazione OR @Origi" & _
    "nal_StatoPrenotazione IS NULL AND StatoPrenotazione IS NULL); SELECT ID, Accerta" & _
    "toreId, Accertatori_PrenotazioneIntervalliId, StatoPrenotazione, DataPrenotazion" & _
    "e, DataApprovazione, IdApprovatore, CreateOn, ModifiedOn, CreatedBy, ModifiedBy " & _
    "FROM dbo.Accertatori_PrenotazioneRichiesta WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioneIntervalliId"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoPrenotazione", System.Data.SqlDbType.Int, 4, "StatoPrenotazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataPrenotazione", System.Data.SqlDbType.DateTime, 8, "DataPrenotazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdApprovatore", System.Data.SqlDbType.Int, 4, "IdApprovatore"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioneIntervalliId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreateOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreateOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataApprovazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataApprovazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdApprovatore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApprovatore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StatoPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatoPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsPrenotazioneRichieste1
    '
    Me.DsPrenotazioneRichieste1.DataSetName = "DsPrenotazioneRichieste"
    Me.DsPrenotazioneRichieste1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DsGestionePreno1
    '
    Me.DsGestionePreno1.DataSetName = "DsGestionePreno"
    Me.DsGestionePreno1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsPrenotazioneRichieste1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsGestionePreno1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents lblMatricolaF As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaF As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStatoF As System.Web.UI.WebControls.Label
  Protected WithEvents btnFiltroF As System.Web.UI.WebControls.Button
  Protected WithEvents ddlStatoF As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents DaPrenotazioneRichiesta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblPeriodoP As System.Web.UI.WebControls.Label
  Protected WithEvents dgPrenotazione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsPrenotazioneRichieste1 As ATCBussm1.DsPrenotazioneRichieste
  Protected WithEvents DsGestionePreno1 As ATCBussm1.DsGestionePreno

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


    If Not IsPostBack Then

      DaPrenotazioneRichiesta.Fill(DsGestionePreno1, "Accertatori_PrenotazioneRichiesta")

      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneprenotazione.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  'Public Sub lblOre_OnDataBinding(ByVal sender As Object, ByVal e As System.EventArgs)
  '  Dim t As New TimeSpan("0" & DirectCast(sender, Label).Text)
  '  DirectCast(sender, Label).Text = t.ToString
  'End Sub

  'Private Sub dgCongedi_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)

  '  If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCongedi Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongedi.DataKeys(e.Item.ItemIndex)
  '    Select Case e.CommandName
  '      Case "Approva"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
  '      Case "Rifiuta"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
  '    End Select
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
  '    daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
  '    dgCongedi.DataBind()
  '  ElseIf e.CommandName = "Annulla" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCongedi Set IdApprovatore =NULL, DataApprovazione =NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongedi.DataKeys(e.Item.ItemIndex)
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
  '    daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
  '    dgCongedi.DataBind()
  '  End If

  'End Sub

  'Private Sub dgCambiTurno_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurno Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurno.DataKeys(e.Item.ItemIndex)
  '    Select Case e.CommandName
  '      Case "Approva"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
  '      Case "Rifiuta"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
  '    End Select
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCambiTurno").Clear()
  '    daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
  '    dgCambiTurno.DataBind()
  '  ElseIf e.CommandName = "Annulla" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurno Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurno.DataKeys(e.Item.ItemIndex)
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCambiTurno").Clear()
  '    daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
  '    dgCambiTurno.DataBind()
  '  End If
  'End Sub

  'Private Sub dgCambiTurnoMensili_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoMensile Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoMensili.DataKeys(e.Item.ItemIndex)
  '    Select Case e.CommandName
  '      Case "Approva"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
  '      Case "Rifiuta"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
  '    End Select
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCambiTurnoMensile").Clear()
  '    daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
  '    dgCambiTurnoMensili.DataBind()
  '  ElseIf e.CommandName = "Annulla" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoMensile Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoMensili.DataKeys(e.Item.ItemIndex)
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCambiTurnoMensile").Clear()
  '    daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
  '    dgCambiTurnoMensili.DataBind()
  '  End If
  'End Sub

  'Private Sub dgCongediFrazionati_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCongediFrazionati Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediFrazionati.DataKeys(e.Item.ItemIndex)
  '    Select Case e.CommandName
  '      Case "Approva"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
  '      Case "Rifiuta"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
  '    End Select
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCongediFrazionati").Clear()
  '    daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
  '    dgCongediFrazionati.DataBind()

  '  ElseIf e.CommandName = "Annulla" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteCongediFrazionati Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediFrazionati.DataKeys(e.Item.ItemIndex)
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteCongediFrazionati").Clear()
  '    daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
  '    dgCongediFrazionati.DataBind()
  '  End If
  'End Sub

  'Private Sub dgFerie_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteFerie Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgFerie.DataKeys(e.Item.ItemIndex)
  '    Select Case e.CommandName
  '      Case "Approva"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
  '      Case "Rifiuta"
  '        sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
  '    End Select
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteFerie").Clear()
  '    daFerie.Fill(DsAmministrazioneCongedi1, "RichiesteFerie")
  '    dgFerie.DataBind()

  '  ElseIf e.CommandName = "Annulla" Then
  '    Dim sc As New SqlClient.SqlCommand("Update RichiesteFerie Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
  '    con.Open()
  '    sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgFerie.DataKeys(e.Item.ItemIndex)
  '    sc.ExecuteNonQuery()
  '    con.Close()
  '    DsAmministrazioneCongedi1.Tables("RichiesteFerie").Clear()
  '    daFerie.Fill(DsAmministrazioneCongedi1, "RichiesteFerie")
  '    dgFerie.DataBind()
  '  End If
  'End Sub

  'Private Sub dgCongediFrazionati_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
  '  If Not e.Item.FindControl("lblDalleOre") Is Nothing Then
  '    Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text)
  '    DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text = t.ToString.Substring(0, 5)
  '  End If
  '  If Not e.Item.FindControl("lblAlleOre") Is Nothing Then
  '    Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text)
  '    DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text = t.ToString.Substring(0, 5)
  '  End If
  'End Sub

  'Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  'Dim filtro_stato As String
  '  'Dim filtro_matricola As String
  '  'Dim filtro_data As String
  '  'filtro_stato = ""
  '  'filtro_matricola = ""
  '  'filtro_data = ""
  '  'Dim data0 = New DateTime(1, 1, 1)

  '  ''Response.Write(DalGiorno.SelectedDate)
  '  ''Response.End()
  '  'If Not (DalGiorno.SelectedDate = data0) Then
  '  '  filtro_data = " (R.Data >= '" & Format(DalGiorno.SelectedDate, "yyyy-MM-dd") & "') "
  '  'Else
  '  '  filtro_data = " (R.Data >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) "
  '  'End If
  '  'If (ddlStato.Value = "Rifiutati") Then
  '  '  filtro_stato = " and R.StatoApprovazione=0 "
  '  'ElseIf (ddlStato.Value = "Approvati") Then
  '  '  filtro_stato = " and R.StatoApprovazione=1 "
  '  'ElseIf (ddlStato.Value = "Da approvare") Then
  '  '  filtro_stato = " and (R.StatoApprovazione is null) "
  '  'End If
  '  'If (Not Trim(txtMatricola.Text) = "") Then
  '  '  filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricola.Text) & "%') "
  '  'End If
  '  'daCongediFrazionati.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongediFrazionati R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY R.Data DESC, R.DalleOre DESC, R.ts"
  '  ''Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
  '  ''Response.Write("Matricola:" & Trim(txtMatricola.Text))
  '  ''Response.End()
  '  'daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
  '  'dgCongediFrazionati.DataBind()

  'End Sub

  'Private Sub btnFiltroCTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim filtro_stato As String
  '  Dim filtro_matricola As String
  '  Dim filtro_data As String
  '  filtro_stato = ""
  '  filtro_matricola = ""
  '  filtro_data = ""
  '  Dim data0 = New DateTime(1, 1, 1)

  '  'Response.Write(DalGiorno.SelectedDate)
  '  'Response.End()
  '  If Not (DalGiornoCTM.SelectedDate = data0) Then
  '    filtro_data = " (R.Data >= '" & Format(DalGiornoCTM.SelectedDate, "yyyy-MM-dd") & "') "
  '  Else
  '    filtro_data = " ( r.data >= GETDATE() ) "
  '  End If
  '  If (ddlStatoCTM.Value = "Rifiutati") Then
  '    filtro_stato = " and R.StatoApprovazione=0 "
  '  ElseIf (ddlStatoCTM.Value = "Approvati") Then
  '    filtro_stato = " and R.StatoApprovazione=1 "
  '  ElseIf (ddlStatoCTM.Value = "Da approvare") Then
  '    filtro_stato = " and (R.StatoApprovazione is null) "
  '  End If
  '  If (Not Trim(txtMatricolaCTM.Text) = "") Then
  '    filtro_matricola = " and (u1.IDUser like '%" & Trim(txtMatricolaCTM.Text) & "%') "
  '  End If

  '  daCambiTurnoMensili.SelectCommand.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatario, r.data, r.DataApprovazione, r.IdApprovatore, " & _
  '    "CASE R.StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da Approvare' END AS StatoApprovazione, " & _
  '    " u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestinatario, " & _
  '    " u3.IDUser AS Approvatore, r.TurnoRichiedente AS TurnoRichiedente, r.TurnoDestinatario AS TurnoDestinatario " & _
  '    " FROM dbo.RichiesteCambiTurnoMensile r " & _
  '    " LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID " & _
  '    " LEFT OUTER JOIN dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID " & _
  '    " LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID " & _
  '    " WHERE (r.StatoRichiesta = 1) AND " & filtro_data & filtro_stato & filtro_matricola & " ORDER BY r.data DESC, r.ts "

  '  daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
  '  dgCambiTurnoMensili.DataBind()

  '  'daCongediFrazionati.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongediFrazionati R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY R.Data DESC, R.DalleOre DESC, R.ts"
  '  ''Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
  '  ''Response.Write("Matricola:" & Trim(txtMatricola.Text))
  '  ''Response.End()
  '  'daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
  '  'dgCongediFrazionati.DataBind()
  'End Sub

  'Private Sub btnFiltroCTG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  '  Dim filtro_stato As String
  '  Dim filtro_matricola As String
  '  Dim filtro_data As String
  '  filtro_stato = ""
  '  filtro_matricola = ""
  '  filtro_data = ""
  '  Dim data0 = New DateTime(1, 1, 1)

  '  'Response.Write(DalGiorno.SelectedDate)
  '  'Response.End()
  '  If Not (DalGiornoCTG.SelectedDate = data0) Then
  '    filtro_data = " (R.Data >= '" & Format(DalGiornoCTG.SelectedDate, "yyyy-MM-dd") & "') "
  '  Else
  '    filtro_data = " (r.data >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) "
  '  End If
  '  If (ddlStatoCTG.Value = "Rifiutati") Then
  '    filtro_stato = " and R.StatoApprovazione=0 "
  '  ElseIf (ddlStatoCTG.Value = "Approvati") Then
  '    filtro_stato = " and R.StatoApprovazione=1 "
  '  ElseIf (ddlStatoCTG.Value = "Da approvare") Then
  '    filtro_stato = " and (R.StatoApprovazione is null) "
  '  End If
  '  If (Not Trim(txtMatricolaCTG.Text) = "") Then
  '    filtro_matricola = " and (u1.IDUser like '%" & Trim(txtMatricolaCTG.Text) & "%') "
  '  End If

  '  daCambiTurno.SelectCommand.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatario, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da Approvare' END AS StatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestinatario, u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LTrim(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN r.TurnoDestinatario < 90000 THEN LTrim(Str(r.TurnoDestinatario)) ELSE 'Riposo' END AS TurnoDestinatario FROM dbo.RichiesteCambiTurno r LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY r.data DESC, r.ts"

  '  daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
  '  dgCambiTurno.DataBind()


  'End Sub

  'Private Sub btnFiltroF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  '  Dim filtro_stato As String
  '  Dim filtro_matricola As String
  '  Dim filtro_data As String
  '  filtro_stato = ""
  '  filtro_matricola = ""
  '  filtro_data = ""
  '  Dim data0 = New DateTime(1, 1, 1)

  '  'Response.Write(DalGiorno.SelectedDate)
  '  'Response.End()
  '  If Not (DalGiornoF.SelectedDate = data0) Then
  '    filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoF.SelectedDate, "yyyy-MM-dd") & "') "
  '  Else
  '    filtro_data = " (R.DalGiorno >= GETDATE()) "
  '  End If
  '  If (ddlStatoF.Value = "Rifiutati") Then
  '    filtro_stato = " and R.StatoApprovazione=0 "
  '  ElseIf (ddlStatoF.Value = "Approvati") Then
  '    filtro_stato = " and R.StatoApprovazione=1 "
  '  ElseIf (ddlStatoF.Value = "Da approvare") Then
  '    filtro_stato = " and (R.StatoApprovazione is null) "
  '  End If
  '  If (Not Trim(txtMatricolaF.Text) = "") Then
  '    filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricolaF.Text) & "%') "
  '  End If
  '  daFerie.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteFerie R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"
  '  'Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
  '  'Response.Write("Matricola:" & Trim(txtMatricola.Text))
  '  'Response.End()
  '  daFerie.Fill(DsAmministrazioneCongedi1, "Richiesteferie")
  '  dgFerie.DataBind()



  'End Sub

  'Private Sub btnFiltroC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  '  Dim filtro_stato As String
  '  Dim filtro_matricola As String
  '  Dim filtro_data As String
  '  filtro_stato = ""
  '  filtro_matricola = ""
  '  filtro_data = ""
  '  Dim data0 = New DateTime(1, 1, 1)

  '  'Response.Write(DalGiorno.SelectedDate)
  '  'Response.End()
  '  If Not (DalGiornoC.SelectedDate = data0) Then
  '    filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoC.SelectedDate, "yyyy-MM-dd") & "') "
  '  Else
  '    filtro_data = " (R.DalGiorno >= GETDATE()) "
  '  End If
  '  If (ddlStatoC.Value = "Rifiutati") Then
  '    filtro_stato = " and R.StatoApprovazione=0 "
  '  ElseIf (ddlStatoC.Value = "Approvati") Then
  '    filtro_stato = " and R.StatoApprovazione=1 "
  '  ElseIf (ddlStatoC.Value = "Da approvare") Then
  '    filtro_stato = " and (R.StatoApprovazione is null) "
  '  End If
  '  If (Not Trim(txtMatricolaC.Text) = "") Then
  '    filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricolaC.Text) & "%') "
  '  End If
  '  daCongedi.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongedi R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"
  '  'Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
  '  'Response.Write("Matricola:" & Trim(txtMatricola.Text))
  '  'Response.End()
  '  daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
  '  dgCongedi.DataBind()


  'End Sub


End Class
