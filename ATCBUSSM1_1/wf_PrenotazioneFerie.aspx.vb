Public Class wf_PrenotazioneFerie
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daRichiesteFerie = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.comMensileAperto = New System.Data.Odbc.OdbcCommand
    Me.DsRichiesteFerie1 = New ATCBussm1.dsRichiesteFerie
    Me.conDep = New System.Data.SqlClient.SqlConnection
    Me.daRichiestaPrenotazione = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsRichiestaPrenotazione1 = New ATCBussm1.DsRichiestaPrenotazione
    Me.daIntervalliPeriodoValido = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsRichiestaPrenotazione1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daRichiesteFerie
    '
    Me.daRichiesteFerie.DeleteCommand = Me.SqlCommand2
    Me.daRichiesteFerie.InsertCommand = Me.SqlInsertCommand1
    Me.daRichiesteFerie.SelectCommand = Me.SqlSelectCommand1
    Me.daRichiesteFerie.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteFerie", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daRichiesteFerie.UpdateCommand = Me.SqlCommand1
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.RichiesteFerie WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteFerie (IdRichiesta, IdAccertatore, DalGiorno, AlGiorno) " & _
    "VALUES (@IdRichiesta, @IdAccertatore, @DalGiorno, @AlGiorno)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Nome + ' ' + U.Cognome AS Approvatore, RF.IdRichiesta, RF.IdAccertatore," & _
    " RF.DalGiorno, RF.AlGiorno, CASE WHEN RF.StatoApprovazione IS NULL THEN 'Da appr" & _
    "ovare' WHEN RF.StatoApprovazione = 0 THEN 'Respinta' WHEN RF.StatoApprovazione =" & _
    " 1 THEN 'Approvata' END AS StatoApprovazione, RF.DataApprovazione, RF.IdApprovat" & _
    "ore, RF.ts FROM dbo.RichiesteFerie RF LEFT OUTER JOIN dbo.ATC_Utenti U ON RF.IdA" & _
    "pprovatore = U.ID WHERE (RF.IdAccertatore = @IdAccertatore) AND (RF.DalGiorno > " & _
    "GETDATE()) ORDER BY RF.ts DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.RichiesteFerie SET DalGiorno = @DalGiorno, AlGiorno = @AlGiorno, ts = " & _
    "GETDATE() WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'comMensileAperto
    '
    Me.comMensileAperto.CommandText = CType(configurationAppSettings.GetValue("SelectCheckMensileAperto", GetType(System.String)), String)
    Me.comMensileAperto.Connection = Me.conAS400
    '
    'DsRichiesteFerie1
    '
    Me.DsRichiesteFerie1.DataSetName = "dsRichiesteFerie"
    Me.DsRichiesteFerie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conDep
    '
    Me.conDep.ConnectionString = CType(configurationAppSettings.GetValue("conDep.ConnectionString", GetType(System.String)), String)
    '
    'daRichiestaPrenotazione
    '
    Me.daRichiestaPrenotazione.DeleteCommand = Me.SqlDeleteCommand1
    Me.daRichiestaPrenotazione.InsertCommand = Me.SqlInsertCommand2
    Me.daRichiestaPrenotazione.SelectCommand = Me.SqlSelectCommand2
    Me.daRichiestaPrenotazione.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioneRichiesta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("Accertatori_PrenotazioneIntervalliId", "Accertatori_PrenotazioneIntervalliId"), New System.Data.Common.DataColumnMapping("StatoPrenotazione", "StatoPrenotazione"), New System.Data.Common.DataColumnMapping("DataPrenotazione", "DataPrenotazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.daRichiestaPrenotazione.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Accertatori_PrenotazioneRichiesta WHERE (ID = @Original_ID) AND (" & _
    "AccertatoreId = @Original_AccertatoreId OR @Original_AccertatoreId IS NULL AND A" & _
    "ccertatoreId IS NULL) AND (Accertatori_PrenotazioneIntervalliId = @Original_Acce" & _
    "rtatori_PrenotazioneIntervalliId OR @Original_Accertatori_PrenotazioneIntervalli" & _
    "Id IS NULL AND Accertatori_PrenotazioneIntervalliId IS NULL) AND (CreatedBy = @O" & _
    "riginal_CreatedBy OR @Original_CreatedBy IS NULL AND CreatedBy IS NULL) AND (Dat" & _
    "aApprovazione = @Original_DataApprovazione OR @Original_DataApprovazione IS NULL" & _
    " AND DataApprovazione IS NULL) AND (DataPrenotazione = @Original_DataPrenotazion" & _
    "e OR @Original_DataPrenotazione IS NULL AND DataPrenotazione IS NULL) AND (IdApp" & _
    "rovatore = @Original_IdApprovatore OR @Original_IdApprovatore IS NULL AND IdAppr" & _
    "ovatore IS NULL) AND (ModifiedBy = @Original_ModifiedBy OR @Original_ModifiedBy " & _
    "IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Origi" & _
    "nal_ModifiedOn IS NULL AND ModifiedOn IS NULL) AND (StatoPrenotazione = @Origina" & _
    "l_StatoPrenotazione OR @Original_StatoPrenotazione IS NULL AND StatoPrenotazione" & _
    " IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioneIntervalliId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataApprovazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataApprovazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdApprovatore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApprovatore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StatoPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatoPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioneRichiesta (ID, AccertatoreId, Accertatori" & _
    "_PrenotazioneIntervalliId, StatoPrenotazione, DataPrenotazione, DataApprovazione" & _
    ", IdApprovatore, ModifiedOn, CreatedBy, ModifiedBy) VALUES (@ID, @AccertatoreId," & _
    " @Accertatori_PrenotazioneIntervalliId, @StatoPrenotazione, @DataPrenotazione, @" & _
    "DataApprovazione, @IdApprovatore, @ModifiedOn, @CreatedBy, @ModifiedBy); SELECT " & _
    "ID, AccertatoreId, Accertatori_PrenotazioneIntervalliId, StatoPrenotazione, Data" & _
    "Prenotazione, DataApprovazione, IdApprovatore, ModifiedOn, CreatedBy, ModifiedBy" & _
    " FROM dbo.Accertatori_PrenotazioneRichiesta WHERE (ID = @ID)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioneIntervalliId"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoPrenotazione", System.Data.SqlDbType.Int, 4, "StatoPrenotazione"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataPrenotazione", System.Data.SqlDbType.DateTime, 8, "DataPrenotazione"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdApprovatore", System.Data.SqlDbType.Int, 4, "IdApprovatore"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT dbo.Accertatori_PrenotazioneRichiesta.ID, dbo.Accertatori_PrenotazioneRich" & _
    "iesta.AccertatoreId, dbo.Accertatori_PrenotazioneRichiesta.Accertatori_Prenotazi" & _
    "oneIntervalliId, dbo.Accertatori_PrenotazioneRichiesta.StatoPrenotazione, dbo.Ac" & _
    "certatori_PrenotazioneRichiesta.DataPrenotazione, dbo.Accertatori_PrenotazioneRi" & _
    "chiesta.DataApprovazione, dbo.Accertatori_PrenotazioneRichiesta.IdApprovatore, d" & _
    "bo.Accertatori_PrenotazioneRichiesta.ModifiedOn, dbo.Accertatori_PrenotazioneRic" & _
    "hiesta.CreatedBy, dbo.Accertatori_PrenotazioneRichiesta.ModifiedBy, dbo.Accertat" & _
    "ori_PrenotazioneIntervalli.Nome, dbo.Accertatori_PrenotazioneStato.Stato FROM db" & _
    "o.Accertatori_PrenotazioneRichiesta INNER JOIN dbo.Accertatori_PrenotazioneInter" & _
    "valli ON dbo.Accertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervall" & _
    "iId = dbo.Accertatori_PrenotazioneIntervalli.ID INNER JOIN dbo.Accertatori_Preno" & _
    "tazioneStato ON dbo.Accertatori_PrenotazioneRichiesta.StatoPrenotazione = dbo.Ac" & _
    "certatori_PrenotazioneStato.ID WHERE (dbo.Accertatori_PrenotazioneRichiesta.Acce" & _
    "rtatoreId = @AccertatoreId)"
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori_PrenotazioneRichiesta SET ID = @ID, AccertatoreId = @Accer" & _
    "tatoreId, Accertatori_PrenotazioneIntervalliId = @Accertatori_PrenotazioneInterv" & _
    "alliId, StatoPrenotazione = @StatoPrenotazione, DataPrenotazione = @DataPrenotaz" & _
    "ione, DataApprovazione = @DataApprovazione, IdApprovatore = @IdApprovatore, Modi" & _
    "fiedOn = @ModifiedOn, CreatedBy = @CreatedBy, ModifiedBy = @ModifiedBy WHERE (ID" & _
    " = @Original_ID) AND (AccertatoreId = @Original_AccertatoreId OR @Original_Accer" & _
    "tatoreId IS NULL AND AccertatoreId IS NULL) AND (Accertatori_PrenotazioneInterva" & _
    "lliId = @Original_Accertatori_PrenotazioneIntervalliId OR @Original_Accertatori_" & _
    "PrenotazioneIntervalliId IS NULL AND Accertatori_PrenotazioneIntervalliId IS NUL" & _
    "L) AND (CreatedBy = @Original_CreatedBy OR @Original_CreatedBy IS NULL AND Creat" & _
    "edBy IS NULL) AND (DataApprovazione = @Original_DataApprovazione OR @Original_Da" & _
    "taApprovazione IS NULL AND DataApprovazione IS NULL) AND (DataPrenotazione = @Or" & _
    "iginal_DataPrenotazione OR @Original_DataPrenotazione IS NULL AND DataPrenotazio" & _
    "ne IS NULL) AND (IdApprovatore = @Original_IdApprovatore OR @Original_IdApprovat" & _
    "ore IS NULL AND IdApprovatore IS NULL) AND (ModifiedBy = @Original_ModifiedBy OR" & _
    " @Original_ModifiedBy IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = @Origina" & _
    "l_ModifiedOn OR @Original_ModifiedOn IS NULL AND ModifiedOn IS NULL) AND (StatoP" & _
    "renotazione = @Original_StatoPrenotazione OR @Original_StatoPrenotazione IS NULL" & _
    " AND StatoPrenotazione IS NULL); SELECT ID, AccertatoreId, Accertatori_Prenotazi" & _
    "oneIntervalliId, StatoPrenotazione, DataPrenotazione, DataApprovazione, IdApprov" & _
    "atore, ModifiedOn, CreatedBy, ModifiedBy FROM dbo.Accertatori_PrenotazioneRichie" & _
    "sta WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioneIntervalliId"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoPrenotazione", System.Data.SqlDbType.Int, 4, "StatoPrenotazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataPrenotazione", System.Data.SqlDbType.DateTime, 8, "DataPrenotazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdApprovatore", System.Data.SqlDbType.Int, 4, "IdApprovatore"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioneIntervalliId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioneIntervalliId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataApprovazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataApprovazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdApprovatore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApprovatore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StatoPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StatoPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRichiestaPrenotazione1
    '
    Me.DsRichiestaPrenotazione1.DataSetName = "DsRichiestaPrenotazione"
    Me.DsRichiestaPrenotazione1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daIntervalliPeriodoValido
    '
    Me.daIntervalliPeriodoValido.SelectCommand = Me.SqlSelectCommand3
    Me.daIntervalliPeriodoValido.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioneIntervalliValidi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Accertatori_PrenotazioniPeriodoId", "Accertatori_PrenotazioniPeriodoId"), New System.Data.Common.DataColumnMapping("IntervalloDa", "IntervalloDa"), New System.Data.Common.DataColumnMapping("IntervalloA", "IntervalloA"), New System.Data.Common.DataColumnMapping("MaxPrenotazione", "MaxPrenotazione"), New System.Data.Common.DataColumnMapping("NumPrenotati", "NumPrenotati"), New System.Data.Common.DataColumnMapping("NumDisponibilita", "NumDisponibilita"), New System.Data.Common.DataColumnMapping("UltimaPrenotazione", "UltimaPrenotazione"), New System.Data.Common.DataColumnMapping("Pubblicato", "Pubblicato"), New System.Data.Common.DataColumnMapping("PrenotabileDa", "PrenotabileDa"), New System.Data.Common.DataColumnMapping("PrenotabileA", "PrenotabileA"), New System.Data.Common.DataColumnMapping("NumMaxIntervalli", "NumMaxIntervalli")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT Accertatori_PrenotazioneIntervalli.ID, Accertatori_PrenotazioneIntervalli." & _
    "Nome + ' Posti liberi: ' + CAST(Accertatori_PrenotazioneIntervalli.NumDisponibil" & _
    "ita AS Varchar(3)) AS Nome, Accertatori_PrenotazioneIntervalli.Accertatori_Preno" & _
    "tazioniPeriodoId, Accertatori_PrenotazioneIntervalli.IntervalloDa, Accertatori_P" & _
    "renotazioneIntervalli.IntervalloA, Accertatori_PrenotazioneIntervalli.MaxPrenota" & _
    "zione, Accertatori_PrenotazioneIntervalli.NumPrenotati, Accertatori_Prenotazione" & _
    "Intervalli.NumDisponibilita, Accertatori_PrenotazioneIntervalli.UltimaPrenotazio" & _
    "ne, Accertatori_PrenotazioniPeriodo.Pubblicato, Accertatori_PrenotazioniPeriodo." & _
    "PrenotabileDa, Accertatori_PrenotazioniPeriodo.PrenotabileA, Accertatori_Prenota" & _
    "zioniPeriodo.NumMaxIntervalli FROM Accertatori_PrenotazioneIntervalli INNER JOIN" & _
    " Accertatori_PrenotazioniPeriodo ON Accertatori_PrenotazioneIntervalli.Accertato" & _
    "ri_PrenotazioniPeriodoId = Accertatori_PrenotazioniPeriodo.ID WHERE (Accertatori" & _
    "_PrenotazioniPeriodo.Pubblicato = 1) AND (DATEADD(day, 1, Accertatori_Prenotazio" & _
    "niPeriodo.PrenotabileA) >= GETDATE()) AND (GETDATE() > CONVERT(DATETIME, CAST(YE" & _
    "AR(Accertatori_PrenotazioniPeriodo.PrenotabileDa) AS varchar(4)) + '-' + CAST(MO" & _
    "NTH(Accertatori_PrenotazioniPeriodo.PrenotabileDa) AS varchar(2)) + '-' + CAST(D" & _
    "AY(Accertatori_PrenotazioniPeriodo.PrenotabileDa) AS varchar(2)) + ' ' + CAST(Ac" & _
    "certatori_PrenotazioniPeriodo.PrenotabileDaOra AS Varchar(2)) + ':' + CAST(Accer" & _
    "tatori_PrenotazioniPeriodo.PrenotabileDaMinuti AS Varchar(2)), 102)) ORDER BY Ac" & _
    "certatori_PrenotazioneIntervalli.IntervalloDa"
    Me.SqlSelectCommand3.Connection = Me.con
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsRichiestaPrenotazione1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daRichiesteFerie As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents comMensileAperto As System.Data.Odbc.OdbcCommand
  Protected WithEvents DsRichiesteFerie1 As ATCBussm1.dsRichiesteFerie
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents conDep As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daRichiestaPrenotazione As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsRichiestaPrenotazione1 As ATCBussm1.DsRichiestaPrenotazione
  Protected WithEvents daIntervalliPeriodoValido As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents btnAddPrenotazione As System.Web.UI.WebControls.Button
  Protected WithEvents dgPrenotazioneferie As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblIntervalliEsauriti As System.Web.UI.WebControls.Label

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

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If
    LoadPagina()

    If Not IsPostBack Then
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", oUtente.IDUser & " - Pagina iniziale prenotazione", Session("IPAddress"))

    End If


  End Sub

  Public Sub cvDataDal_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)


    'If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date) Then
    '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate <= Now.Date.AddDays(60)
    '  DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere delle ferie oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")

    'Else
    '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
    '  DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")

    'End If
    ''args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
    ''DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")

  End Sub

  Private Sub LoadPagina()
    Dim comabilita As New SqlClient.SqlCommand("SELECT CASE WHEN COUNT(*) < MAX(isnull(PP.NumMaxIntervalli,0)) THEN 1 ELSE 0 END AS Abilita, isnull(MAX(isnull(PP.NumMaxIntervalli,0)),0) AS MaxPreno " & _
    "FROM  Accertatori_PrenotazioneRichiesta as PR INNER JOIN " & _
     "Accertatori_PrenotazioneIntervalli as A_PI ON PR.Accertatori_PrenotazioneIntervalliId = A_PI.ID INNER JOIN " & _
     "Accertatori_PrenotazioniPeriodo as PP ON A_PI.Accertatori_PrenotazioniPeriodoId = PP.ID " & _
"WHERE (PP.Pubblicato = 1) AND (GETDATE() >= CONVERT(DATETIME, cast(year(PP.PrenotabileDa) as varchar(4)) + '-' +  cast(month(PP.PrenotabileDa) as varchar(2)) + '-' + cast(day(PP.PrenotabileDa) as varchar(2)) +' ' + cast(PP.PrenotabileDaOra as Varchar(2)) +':' + cast(PP.PrenotabileDaMinuti as Varchar(2)), 102)) AND " & _
 "(PP.PrenotabileA >= GETDATE()) AND (PR.AccertatoreId = '" & oUtente.ID & "') AND (isnull(PR.StatoPrenotazione,0) <> 2)", con)
    fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", oUtente.IDUser & "- Sql valida intervallo - " & "SELECT CASE WHEN COUNT(*) < MAX(isnull(PP.NumMaxIntervalli,0)) THEN 1 ELSE 0 END AS Abilita, isnull(MAX(isnull(PP.NumMaxIntervalli,0)),0) AS MaxPreno " & _
    "FROM  Accertatori_PrenotazioneRichiesta as PR INNER JOIN " & _
     "Accertatori_PrenotazioneIntervalli as A_PI ON PR.Accertatori_PrenotazioneIntervalliId = A_PI.ID INNER JOIN " & _
     "Accertatori_PrenotazioniPeriodo as PP ON A_PI.Accertatori_PrenotazioniPeriodoId = PP.ID " & _
"WHERE (PP.Pubblicato = 1) AND (GETDATE() >= CONVERT(DATETIME, cast(year(PP.PrenotabileDa) as varchar(4)) + '-' +  cast(month(PP.PrenotabileDa) as varchar(2)) + '-' + cast(day(PP.PrenotabileDa) as varchar(2)) +' ' + cast(PP.PrenotabileDaOra as Varchar(2)) +':' + cast(PP.PrenotabileDaMinuti as Varchar(2)), 102)) AND " & _
 "(PP.PrenotabileA >= GETDATE()) AND (PR.AccertatoreId = '" & oUtente.ID & "') AND (isnull(PR.StatoPrenotazione,0) <> 2)", Session("IPAddress"))
    '(GETDATE() >= CONVERT(DATETIME, cast(year(PP.PrenotabileDa) as varchar(4)) + '-' +  cast(month(PP.PrenotabileDa) as varchar(2)) + '-' + cast(day(PP.PrenotabileDa) as varchar(2)) +' ' + cast(PP.PrenotabileDaOra as Varchar(2)) +':' + cast(PP.PrenotabileDaMinuti as Varchar(2)), 102))
    ' (GETDATE() >= PP.PrenotabileDa)

    'Response.End()
    Dim dr As SqlClient.SqlDataReader
    Dim abilita As Int32
    Dim MaxPreno As Int32
    con.Open()

    dr = comabilita.ExecuteReader()
    If dr.HasRows Then
      Do While dr.Read
        abilita = System.Convert.ToInt32(dr("Abilita"))
        MaxPreno = System.Convert.ToInt32(dr("MaxPreno"))

      Loop
    End If
    con.Close()
    'daRichiesteFerie.SelectCommand.Parameters("@IDAccertatore").Value = oUtente.ID
    'daRichiesteFerie.Fill(DsRichiesteFerie1, "RichiesteFerie")
    daRichiestaPrenotazione.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
    daRichiestaPrenotazione.Fill(DsRichiestaPrenotazione1, "Accertatori_PrenotazioneRichiesta")

    daIntervalliPeriodoValido.Fill(DsRichiestaPrenotazione1, "Accertatori_PrenotazioneIntervalliValidi")

    If (abilita = 0 And MaxPreno > 0) Then
      lblIntervalliEsauriti.Text = "Hai raggiunto il massimo degli intevalli prenotabili. Il max è uguale a " & MaxPreno.ToString() & "."
      btnAddPrenotazione.Enabled = False
    Else
      btnAddPrenotazione.Enabled = DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneIntervalliValidi").Rows.Count > 0
    End If

  End Sub

  Private Sub dgFerie_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      dgPrenotazioneferie.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnAddPrenotazione.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", oUtente.IDUser & " - Inizio modifica richiesta ferie", Session("IPAddress"))
    End If
  End Sub


  Public Sub validaintervallo_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    '   args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate.AddDays(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)

    Dim ddl As DropDownList
    ddl = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlintervalloferie"), DropDownList)

    Dim com As New SqlClient.SqlCommand("select numdisponibilita from accertatori_prenotazioneIntervalli where id ='" & Convert.ToString(ddl.SelectedValue) & "'", con)
    Dim comdata As New SqlClient.SqlCommand("select top 1 dataprenotazione from Accertatori_PrenotazioneRichiesta where Accertatori_PrenotazioneIntervalliId ='" & Convert.ToString(ddl.SelectedValue) & "' ORDER BY DataPrenotazione DESC", con)

    Dim comusato As New SqlClient.SqlCommand("SELECT COUNT(*) AS n FROM Accertatori_PrenotazioneRichiesta " & _
                " WHERE (Accertatori_PrenotazioneIntervalliId = '" & Convert.ToString(ddl.SelectedValue) & "') AND (AccertatoreId = " & oUtente.ID & ") and (Accertatori_PrenotazioneRichiesta.StatoPrenotazione <> 2)", con)

    Dim dispo As Integer
    Dim n_usato As Integer
    con.Open()
    Dim dataprenotazione As DateTime
    dataprenotazione = Convert.ToDateTime(comdata.ExecuteScalar())
    con.Close()
    con.Open()
    dispo = Convert.ToInt32(com.ExecuteScalar())
    n_usato = Convert.ToInt32(comusato.ExecuteScalar())
    con.Close()
    If dispo > 0 Then
      args.IsValid = True
      If n_usato = 0 Then
        args.IsValid = True
      Else
        args.IsValid = False

        DirectCast(source, CustomValidator).ErrorMessage = "E' già stata inserita una prenotazione per questo intervallo."

        vsErrori.DataBind()
      End If
    Else

      args.IsValid = False

      DirectCast(source, CustomValidator).ErrorMessage = "Intervallo esaurito. Data ultima prenotazione: " & dataprenotazione
      'DirectCast(source, CustomValidator).DataBind()
      'vsErrori.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", oUtente.IDUser & " - Ha ricevuto il messaggio di intervallo esaurito. Data ultima prenotazione: " & dataprenotazione, Session("IPAddress"))

    End If



  End Sub

  Public Sub cvMinDataAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    '   args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate.AddDays(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)
  End Sub

  Public Sub cvMeseDataDalAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    '  args.IsValid = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)

  End Sub

  Private Function pCountFestivita(ByVal dal As Date, ByVal al As Date) As Integer
    'Dim i As Integer = 0
    'Do While dal <= al
    '  Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
    '  sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
    '  Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    '  riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
    '  con.Open()
    '  If dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0 Or riposi.ExecuteScalar() > 0 Then i += 1
    '  con.Close()
    '  dal = dal.AddDays(1)
    'Loop
    'pCountFestivita = i

  End Function

  Private Sub btnAddPrenotazione_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddPrenotazione.Click

    Dim dr As DataRow = DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").NewRow
    Dim MeseMensileAperto As String
    dr.Item("ID") = Guid.NewGuid
    dr.Item("AccertatoreId") = oUtente.ID

    dr.Item("ModifiedOn") = Now
    dr.Item("DataPrenotazione") = Now
    dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").Rows.InsertAt(dr, 0)
    dgPrenotazioneferie.EditItemIndex = 0
    'Response.End()

    Page.DataBind()

    daIntervalliPeriodoValido.Fill(DsRichiestaPrenotazione1, "Accertatori_PrenotazioneIntervalliValidi")
    btnAddPrenotazione.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", oUtente.IDUser & " - Click nuova richiesta ferie", Session("IPAddress"))



  End Sub

  Private Sub dgPrenotazioneferie_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPrenotazioneferie.CancelCommand

    dgPrenotazioneferie.EditItemIndex = -1
    Page.DataBind()
    btnAddPrenotazione.Enabled = True
    'fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", oUtente.IDUser & " - Annullata modifica della richiesta prenotazione ferie", Session("IPAddress"))


  End Sub

  Private Sub dgPrenotazioneferie_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPrenotazioneferie.UpdateCommand
    Me.Validate()
    If Me.IsValid Then



      '  Dim com As New SqlClient.SqlCommand("select numdisponibilita from accertatori_prenotazioneIntervalli where id ='" & Convert.ToString(DirectCast(e.Item.FindControl("ddlintervalloferie"), DropDownList).SelectedItem.Value) & "'", con)
      Dim comnumpreno As New SqlClient.SqlCommand("select count(*) as n from dbo.Accertatori_PrenotazioneRichiesta where Accertatori_PrenotazioneIntervalliId='" & Convert.ToString(DirectCast(e.Item.FindControl("ddlintervalloferie"), DropDownList).SelectedItem.Value) & "' and (Accertatori_PrenotazioneRichiesta.StatoPrenotazione <> 2)", con)
      Dim gid As New Guid(Convert.ToString(DirectCast(e.Item.FindControl("ddlintervalloferie"), DropDownList).SelectedItem.Value))

      Dim dr As DataRow = DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").Rows.Find(dgPrenotazioneferie.DataKeys(e.Item.ItemIndex))
      Dim insertferie As New SqlClient.SqlCommand("INSERT INTO RichiesteFerie (IdAccertatore, DalGiorno, AlGiorno, DataApprovazione, IdApprovatore, ts, StatoApprovazione) " & _
                     "SELECT  Accertatori_PrenotazioneRichiesta.AccertatoreId, Accertatori_PrenotazioneIntervalli.IntervalloDa, Accertatori_PrenotazioneIntervalli.IntervalloA,  " & _
                        " Accertatori_PrenotazioneRichiesta.DataApprovazione, Accertatori_PrenotazioneRichiesta.IdApprovatore, Accertatori_PrenotazioneRichiesta.DataPrenotazione, " & _
                        " 1 AS Stato FROM  Accertatori_PrenotazioneRichiesta INNER JOIN " & _
                        " Accertatori_PrenotazioneIntervalli ON Accertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliId = Accertatori_PrenotazioneIntervalli.ID " & _
                        " WHERE (Accertatori_PrenotazioneRichiesta.ID = @ID)", con)

      Dim idrichiesta As Guid
      If dr Is Nothing Then
        dr = DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").NewRow
        dr.Item("ID") = Guid.NewGuid
        dr.Item("AccertatoreId") = oUtente.ID
        dr.Item("ModifiedOn") = Now
        dr.Item("DataPrenotazione") = Now
        dr.Item("CreatedBy") = oUtente.IDUser
        dr.Item("ModifiedBy") = oUtente.IDUser
        DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").Rows.Add(dr)
      End If

      idrichiesta = dr.Item("ID")
      dr.Item("Accertatori_PrenotazioneIntervalliId") = gid
      dr.Item("StatoPrenotazione") = 3
      'Accertatori_PrenotazioneRichiesta.DataApprovazione, Accertatori_PrenotazioneRichiesta.IdApprovatore,
      dr.Item("DataApprovazione") = Now
      dr.Item("IdApprovatore") = oUtente.ID
      daRichiestaPrenotazione.Update(DsRichiestaPrenotazione1, "Accertatori_PrenotazioneRichiesta")
      con.Open()

      Dim prenotati As Int32
      prenotati = Convert.ToInt32(comnumpreno.ExecuteScalar())

      con.Close()


      Dim comup As New SqlClient.SqlCommand("update accertatori_prenotazioneIntervalli set numdisponibilita = MaxPrenotazione - " & prenotati & ", numprenotati=" & prenotati & ",UltimaPrenotazione=getdate() where id ='" & Convert.ToString(DirectCast(e.Item.FindControl("ddlintervalloferie"), DropDownList).SelectedItem.Value) & "'", con)
      con.Open()

      comup.ExecuteNonQuery()
      con.Close()

      con.Open()

      insertferie.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = idrichiesta
      insertferie.ExecuteNonQuery()

      con.Close()

      Page.DataBind()
      DsRichiestaPrenotazione1.Tables("Accertatori_PrenotazioneRichiesta").Clear()
      daRichiestaPrenotazione.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID

      daRichiestaPrenotazione.Fill(DsRichiestaPrenotazione1, "Accertatori_PrenotazioneRichiesta")
      'FT - !!!
      dgPrenotazioneferie_CancelCommand(source, e)

      fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", oUtente.IDUser & " - Confermato inserimento/modifica della richiesta prenotazione ferie. Idrichiesta: " & idrichiesta.ToString(), Session("IPAddress"))
      'End If
      LoadPagina()
    End If


  End Sub

  Private Sub dgPrenotazioneferie_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPrenotazioneferie.EditCommand
    'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    'If cvOnModifica.IsValid Then
    dgPrenotazioneferie.EditItemIndex = e.Item.ItemIndex
    Page.DataBind()


    btnAddPrenotazione.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_prenotazioneferie.aspx", "Inizio modifica richiesta prenotazione ferie", Session("IPAddress"))
    'End If
  End Sub


End Class
