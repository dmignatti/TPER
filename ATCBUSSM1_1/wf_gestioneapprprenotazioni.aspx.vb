Public Class wf_gestioneapprprenotazioni
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
    Me.DsApprovaPreno1 = New ATCBussm1.DSApprovaPreno
    CType(Me.DsApprovaPreno1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.SqlSelectCommand5.CommandText = "SELECT Accertatori_PrenotazioneRichiesta.ID, Accertatori_PrenotazioneRichiesta.Ac" & _
    "certatoreId, Accertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervall" & _
    "iId, Accertatori_PrenotazioneRichiesta.StatoPrenotazione, Accertatori_Prenotazio" & _
    "neRichiesta.DataPrenotazione, Accertatori_PrenotazioneRichiesta.DataApprovazione" & _
    ", Accertatori_PrenotazioneRichiesta.IdApprovatore, Accertatori_PrenotazioneRichi" & _
    "esta.CreateOn, Accertatori_PrenotazioneRichiesta.ModifiedOn, Accertatori_Prenota" & _
    "zioneRichiesta.CreatedBy, Accertatori_PrenotazioneRichiesta.ModifiedBy, ATC_Uten" & _
    "ti_1.IDUser AS matricola, ATC_Utenti_1.Cognome + ' ' + ATC_Utenti_1.Nome AS Cogn" & _
    "omeNome, Accertatori_PrenotazioneIntervalli.Nome, ISNULL(ATC_Utenti.IDUser, '') " & _
    "AS Approvatore, Accertatori_PrenotazioneStato.Stato AS StatoApprovazione, Accert" & _
    "atori_PrenotazioniPeriodo.Nome AS Periodo FROM Accertatori_PrenotazioneIntervall" & _
    "i INNER JOIN Accertatori_PrenotazioneRichiesta ON Accertatori_PrenotazioneInterv" & _
    "alli.ID = Accertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliId" & _
    " INNER JOIN Accertatori_PrenotazioneStato ON Accertatori_PrenotazioneRichiesta.S" & _
    "tatoPrenotazione = Accertatori_PrenotazioneStato.ID INNER JOIN Accertatori_Preno" & _
    "tazioniPeriodo ON Accertatori_PrenotazioneIntervalli.Accertatori_PrenotazioniPer" & _
    "iodoId = Accertatori_PrenotazioniPeriodo.ID LEFT OUTER JOIN ATC_Utenti ATC_Utent" & _
    "i_1 ON Accertatori_PrenotazioneRichiesta.AccertatoreId = ATC_Utenti_1.ID LEFT OU" & _
    "TER JOIN ATC_Utenti ON Accertatori_PrenotazioneRichiesta.IdApprovatore = ATC_Ute" & _
    "nti.ID ORDER BY Accertatori_PrenotazioniPeriodo.PeriodoDa DESC, Accertatori_Pren" & _
    "otazioneIntervalli.IntervalloDa, Accertatori_PrenotazioneRichiesta.DataPrenotazi" & _
    "one"
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
    'DsApprovaPreno1
    '
    Me.DsApprovaPreno1.DataSetName = "DSApprovaPreno"
    Me.DsApprovaPreno1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsApprovaPreno1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaPrenotazioneRichiesta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsApprovaPreno1 As ATCBussm1.DSApprovaPreno
  Protected WithEvents DgApprovaprenotazioni As System.Web.UI.WebControls.DataGrid

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

      DaPrenotazioneRichiesta.Fill(DsApprovaPreno1, "Accertatori_PrenotazioneRichiesta")

      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneprenotazione.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub


  Private Sub DgApprovaprenotazioni_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgApprovaprenotazioni.ItemCommand
    Dim idintervallo As String
    Dim comintervallo As New SqlClient.SqlCommand("select Accertatori_PrenotazioneIntervalliId as id from Accertatori_PrenotazioneRichiesta where (Accertatori_PrenotazioneRichiesta.ID = @ID)", con)

    con.Open()
    comintervallo.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)
    idintervallo = Convert.ToString(comintervallo.ExecuteScalar())
    con.Close()
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_PrenotazioneRichiesta Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoPrenotazione = @StatoApprovazione Where ID = @ID", con)
      Dim insertferie As New SqlClient.SqlCommand("INSERT INTO RichiesteFerie (IdAccertatore, DalGiorno, AlGiorno, DataApprovazione, IdApprovatore, ts, StatoApprovazione) " & _
                   "SELECT  Accertatori_PrenotazioneRichiesta.AccertatoreId, Accertatori_PrenotazioneIntervalli.IntervalloDa, Accertatori_PrenotazioneIntervalli.IntervalloA,  " & _
                      " Accertatori_PrenotazioneRichiesta.DataApprovazione, Accertatori_PrenotazioneRichiesta.IdApprovatore, Accertatori_PrenotazioneRichiesta.DataPrenotazione, " & _
                      " 1 AS Stato FROM  Accertatori_PrenotazioneRichiesta INNER JOIN " & _
                      " Accertatori_PrenotazioneIntervalli ON Accertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliId = Accertatori_PrenotazioneIntervalli.ID " & _
                      " WHERE (Accertatori_PrenotazioneRichiesta.ID = @ID)", con)

     

      con.Open()
       sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)

      insertferie.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)

      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 3
          sc.ExecuteNonQuery()
          insertferie.ExecuteNonQuery()
          con.Close()
          fnc.ScriviLog(oUtente.IDUser, "wf_gestioneapprprenotazioni.aspx", oUtente.IDUser & " - Approva Idrichiesta: " & DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex).ToString(), Session("IPAddress"))


        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 2
          sc.ExecuteNonQuery()

          con.Close()
          ricalcoladispo(idintervallo)
          fnc.ScriviLog(oUtente.IDUser, "wf_gestioneapprprenotazioni.aspx", oUtente.IDUser & " - Rifiuta Idrichiesta: " & DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex).ToString(), Session("IPAddress"))

      End Select
      'sc.ExecuteNonQuery()

      DsApprovaPreno1.Tables("Accertatori_PrenotazioneRichiesta").Clear()
      DaPrenotazioneRichiesta.Fill(DsApprovaPreno1, "Accertatori_PrenotazioneRichiesta")
      DgApprovaprenotazioni.DataBind()

    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_PrenotazioneRichiesta Set IdApprovatore = NULL, DataApprovazione = NULL, StatoPrenotazione = 1 Where ID = @ID and not StatoPrenotazione=3", con)
      con.Open()
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()

      DsApprovaPreno1.Tables("Accertatori_PrenotazioneRichiesta").Clear()
      DaPrenotazioneRichiesta.Fill(DsApprovaPreno1, "Accertatori_PrenotazioneRichiesta")
      DgApprovaprenotazioni.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneapprprenotazioni.aspx", oUtente.IDUser & " - Annulla Idrichiesta: " & DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex).ToString(), Session("IPAddress"))

    ElseIf e.CommandName = "Elimina" Then
      Dim sc As New SqlClient.SqlCommand("delete Accertatori_PrenotazioneRichiesta  Where ID = @ID ", con)
      Dim idrich As Guid

      idrich = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)
      con.Open()
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DgApprovaprenotazioni.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      ricalcoladispo(idintervallo)
      DsApprovaPreno1.Tables("Accertatori_PrenotazioneRichiesta").Clear()
      DaPrenotazioneRichiesta.Fill(DsApprovaPreno1, "Accertatori_PrenotazioneRichiesta")
      DgApprovaprenotazioni.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneapprprenotazioni.aspx", oUtente.IDUser & " - Elimina Idrichiesta: " & idrich.ToString(), Session("IPAddress"))

    End If
  End Sub


  Private Sub ricalcoladispo(ByVal g As String)

    Dim comnumpreno As New SqlClient.SqlCommand("select count(*) as n from dbo.Accertatori_PrenotazioneRichiesta where Accertatori_PrenotazioneIntervalliId='" & g & "' and (Accertatori_PrenotazioneRichiesta.StatoPrenotazione <> 2)", con)

    con.Open()

    Dim prenotati As Int32
    prenotati = Convert.ToInt32(comnumpreno.ExecuteScalar())
    con.Close()


    Dim comup As New SqlClient.SqlCommand("update accertatori_prenotazioneIntervalli set numdisponibilita = MaxPrenotazione - " & prenotati & ", numprenotati=" & prenotati & " where id ='" & g & "'", con)
    con.Open()

    comup.ExecuteNonQuery()
    con.Close()

  End Sub

End Class
