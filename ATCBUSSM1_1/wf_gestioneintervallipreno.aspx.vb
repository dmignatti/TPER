Public Class wf_gestioneintervallipreno
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
    Me.DaPrenotazioniPeriodo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsPrenotazione1 = New ATCBussm1.DSPrenotazione
    Me.DaPrenotazioneIntervalli = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.DaPrenotazionePeriodoM = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsPrenotazioneM1 = New ATCBussm1.DsPrenotazioneM
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsPrenotazione1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsPrenotazioneM1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'DaPrenotazioniPeriodo
    '
    Me.DaPrenotazioniPeriodo.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaPrenotazioniPeriodo.InsertCommand = Me.SqlInsertCommand2
    Me.DaPrenotazioniPeriodo.SelectCommand = Me.SqlSelectCommand2
    Me.DaPrenotazioniPeriodo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioniPeriodo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Pubblicato", "Pubblicato"), New System.Data.Common.DataColumnMapping("PrenotabileDa", "PrenotabileDa"), New System.Data.Common.DataColumnMapping("PrenotabileA", "PrenotabileA"), New System.Data.Common.DataColumnMapping("PeriodoDa", "PeriodoDa"), New System.Data.Common.DataColumnMapping("PeriodoA", "PeriodoA"), New System.Data.Common.DataColumnMapping("NumMaxIntervalli", "NumMaxIntervalli"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.DaPrenotazioniPeriodo.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Accertatori_PrenotazioniPeriodo WHERE (ID = @Original_ID) AND (Cr" & _
    "eatedBy = @Original_CreatedBy OR @Original_CreatedBy IS NULL AND CreatedBy IS NU" & _
    "LL) AND (ModifiedBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND M" & _
    "odifiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Original_ModifiedO" & _
    "n IS NULL AND ModifiedOn IS NULL) AND (Nome = @Original_Nome OR @Original_Nome I" & _
    "S NULL AND Nome IS NULL) AND (PeriodoA = @Original_PeriodoA OR @Original_Periodo" & _
    "A IS NULL AND PeriodoA IS NULL) AND (PeriodoDa = @Original_PeriodoDa OR @Origina" & _
    "l_PeriodoDa IS NULL AND PeriodoDa IS NULL) AND (PrenotabileA = @Original_Prenota" & _
    "bileA OR @Original_PrenotabileA IS NULL AND PrenotabileA IS NULL) AND (Prenotabi" & _
    "leDa = @Original_PrenotabileDa OR @Original_PrenotabileDa IS NULL AND Prenotabil" & _
    "eDa IS NULL) AND (Pubblicato = @Original_Pubblicato OR @Original_Pubblicato IS N" & _
    "ULL AND Pubblicato IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pubblicato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pubblicato", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioniPeriodo(ID, Nome, Pubblicato, Prenotabile" & _
    "Da, PrenotabileA, PeriodoDa, PeriodoA, NumMaxIntervalli, ModifiedOn, CreatedBy, " & _
    "ModifiedBy) VALUES (@ID, @Nome, @Pubblicato, @PrenotabileDa, @PrenotabileA, @Per" & _
    "iodoDa, @PeriodoA, @NumMaxIntervalli, @ModifiedOn, @CreatedBy, @ModifiedBy); SEL" & _
    "ECT ID, Nome, Pubblicato, PrenotabileDa, PrenotabileA, PeriodoDa, PeriodoA, NumM" & _
    "axIntervalli, ModifiedOn, CreatedBy, ModifiedBy FROM dbo.Accertatori_Prenotazion" & _
    "iPeriodo WHERE (ID = @ID)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileA", System.Data.SqlDbType.DateTime, 8, "PrenotabileA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoDa", System.Data.SqlDbType.DateTime, 8, "PeriodoDa"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoA", System.Data.SqlDbType.DateTime, 8, "PeriodoA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMaxIntervalli", System.Data.SqlDbType.Int, 4, "NumMaxIntervalli"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT ID, Nome, Pubblicato, PrenotabileDa,PrenotabileDaOra,PrenotabileDaMinuti, " & _
    "PrenotabileA, PeriodoDa, PeriodoA, NumMaxIntervalli, ModifiedOn, CreatedBy, Modi" & _
    "fiedBy FROM dbo.Accertatori_PrenotazioniPeriodo"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori_PrenotazioniPeriodo SET Nome = @Nome, Pubblicato = @Pubbli" & _
    "cato, PrenotabileDa = @PrenotabileDa, PrenotabileDaOra = @PrenotabileDaOra, Pren" & _
    "otabileDaMinuti = @PrenotabileDaMinuti, PrenotabileA = @PrenotabileA, PeriodoDa " & _
    "= @PeriodoDa, PeriodoA = @PeriodoA, ModifiedOn = @ModifiedOn, ModifiedBy = @Modi" & _
    "fiedBy, NumMaxIntervalli = @NumMaxIntervalli, ID = @ID WHERE (ID = @Original_ID)" & _
    " AND (ModifiedBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND Modi" & _
    "fiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Original_ModifiedOn I" & _
    "S NULL AND ModifiedOn IS NULL) AND (Nome = @Original_Nome OR @Original_Nome IS N" & _
    "ULL AND Nome IS NULL) AND (PeriodoA = @Original_PeriodoA OR @Original_PeriodoA I" & _
    "S NULL AND PeriodoA IS NULL) AND (PeriodoDa = @Original_PeriodoDa OR @Original_P" & _
    "eriodoDa IS NULL AND PeriodoDa IS NULL) AND (PrenotabileA = @Original_Prenotabil" & _
    "eA OR @Original_PrenotabileA IS NULL AND PrenotabileA IS NULL) AND (PrenotabileD" & _
    "a = @Original_PrenotabileDa OR @Original_PrenotabileDa IS NULL AND PrenotabileDa" & _
    " IS NULL) AND (PeriodoDaOra = @Original_PeriodoDaOra OR @Original_PeriodoDaOra I" & _
    "S NULL AND PeriodoDaOra IS NULL) AND (PeriodoDaMinuti = @Original_PeriodoDaMinut" & _
    "i OR @Original_PeriodoDaMinuti IS NULL AND PeriodoDaMinuti IS NULL) AND (Pubblic" & _
    "ato = @Original_Pubblicato OR @Original_Pubblicato IS NULL AND Pubblicato IS NUL" & _
    "L); SELECT Nome, Pubblicato, PrenotabileDa, PrenotabileDaOra, PrenotabileDaMinut" & _
    "i, PrenotabileA, PeriodoDa, PeriodoA, ModifiedOn, ModifiedBy, NumMaxIntervalli, " & _
    "ID FROM dbo.Accertatori_PrenotazioniPeriodo WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaOra", System.Data.SqlDbType.Int, 4, "PrenotabileDaOra"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaMinuti", System.Data.SqlDbType.Int, 4, "PrenotabileDaMinuti"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileA", System.Data.SqlDbType.DateTime, 8, "PrenotabileA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoDa", System.Data.SqlDbType.DateTime, 8, "PeriodoDa"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoA", System.Data.SqlDbType.DateTime, 8, "PeriodoA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMaxIntervalli", System.Data.SqlDbType.Int, 4, "NumMaxIntervalli"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDaOra", System.Data.SqlDbType.Variant, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDaMinuti", System.Data.SqlDbType.Variant, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pubblicato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pubblicato", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsPrenotazione1
    '
    Me.DsPrenotazione1.DataSetName = "DSPrenotazione"
    Me.DsPrenotazione1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DaPrenotazioneIntervalli
    '
    Me.DaPrenotazioneIntervalli.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaPrenotazioneIntervalli.InsertCommand = Me.SqlInsertCommand3
    Me.DaPrenotazioneIntervalli.SelectCommand = Me.SqlSelectCommand3
    Me.DaPrenotazioneIntervalli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioneIntervalli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Accertatori_PrenotazioniPeriodoId", "Accertatori_PrenotazioniPeriodoId"), New System.Data.Common.DataColumnMapping("IntervalloDa", "IntervalloDa"), New System.Data.Common.DataColumnMapping("IntervalloA", "IntervalloA"), New System.Data.Common.DataColumnMapping("MaxPrenotazione", "MaxPrenotazione"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("NumPrenotati", "NumPrenotati"), New System.Data.Common.DataColumnMapping("NumDisponibilita", "NumDisponibilita"), New System.Data.Common.DataColumnMapping("UltimaPrenotazione", "UltimaPrenotazione")})})
    Me.DaPrenotazioneIntervalli.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.Accertatori_PrenotazioneIntervalli WHERE (ID = @Original_ID) AND " & _
    "(Accertatori_PrenotazioniPeriodoId = @Original_Accertatori_PrenotazioniPeriodoId" & _
    " OR @Original_Accertatori_PrenotazioniPeriodoId IS NULL AND Accertatori_Prenotaz" & _
    "ioniPeriodoId IS NULL) AND (CreatedBy = @Original_CreatedBy OR @Original_Created" & _
    "By IS NULL AND CreatedBy IS NULL) AND (IntervalloA = @Original_IntervalloA OR @O" & _
    "riginal_IntervalloA IS NULL AND IntervalloA IS NULL) AND (IntervalloDa = @Origin" & _
    "al_IntervalloDa OR @Original_IntervalloDa IS NULL AND IntervalloDa IS NULL) AND " & _
    "(MaxPrenotazione = @Original_MaxPrenotazione OR @Original_MaxPrenotazione IS NUL" & _
    "L AND MaxPrenotazione IS NULL) AND (ModifiedBy = @Original_ModifiedBy OR @Origin" & _
    "al_ModifiedBy IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = @Original_Modifi" & _
    "edOn OR @Original_ModifiedOn IS NULL AND ModifiedOn IS NULL) AND (Nome = @Origin" & _
    "al_Nome OR @Original_Nome IS NULL AND Nome IS NULL) AND (NumDisponibilita = @Ori" & _
    "ginal_NumDisponibilita OR @Original_NumDisponibilita IS NULL AND NumDisponibilit" & _
    "a IS NULL) AND (NumPrenotati = @Original_NumPrenotati OR @Original_NumPrenotati " & _
    "IS NULL AND NumPrenotati IS NULL) AND (UltimaPrenotazione = @Original_UltimaPren" & _
    "otazione OR @Original_UltimaPrenotazione IS NULL AND UltimaPrenotazione IS NULL)" & _
    ""
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioniPeriodoId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioniPeriodoId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IntervalloA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IntervalloA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IntervalloDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IntervalloDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MaxPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDisponibilita", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDisponibilita", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumPrenotati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumPrenotati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UltimaPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UltimaPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioneIntervalli(ID, Nome, Accertatori_Prenotaz" & _
    "ioniPeriodoId, IntervalloDa, IntervalloA, MaxPrenotazione, ModifiedOn, CreatedBy" & _
    ", ModifiedBy, NumPrenotati, NumDisponibilita, UltimaPrenotazione) VALUES (@ID, @" & _
    "Nome, @Accertatori_PrenotazioniPeriodoId, @IntervalloDa, @IntervalloA, @MaxPreno" & _
    "tazione, @ModifiedOn, @CreatedBy, @ModifiedBy, @NumPrenotati, @NumDisponibilita," & _
    " @UltimaPrenotazione); SELECT ID, Nome, Accertatori_PrenotazioniPeriodoId, Inter" & _
    "valloDa, IntervalloA, MaxPrenotazione, ModifiedOn, CreatedBy, ModifiedBy, NumPre" & _
    "notati, NumDisponibilita, UltimaPrenotazione FROM dbo.Accertatori_PrenotazioneIn" & _
    "tervalli WHERE (ID = @ID)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioniPeriodoId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioniPeriodoId"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IntervalloDa", System.Data.SqlDbType.DateTime, 8, "IntervalloDa"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IntervalloA", System.Data.SqlDbType.DateTime, 8, "IntervalloA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MaxPrenotazione", System.Data.SqlDbType.Int, 4, "MaxPrenotazione"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumPrenotati", System.Data.SqlDbType.Int, 4, "NumPrenotati"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDisponibilita", System.Data.SqlDbType.Int, 4, "NumDisponibilita"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UltimaPrenotazione", System.Data.SqlDbType.DateTime, 8, "UltimaPrenotazione"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID, Nome, Accertatori_PrenotazioniPeriodoId, IntervalloDa, IntervalloA, Ma" & _
    "xPrenotazione, ModifiedOn, CreatedBy, ModifiedBy, NumPrenotati, NumDisponibilita" & _
    ", UltimaPrenotazione FROM dbo.Accertatori_PrenotazioneIntervalli WHERE (Accertat" & _
    "ori_PrenotazioniPeriodoId = @ID) ORDER BY IntervalloDa"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioniPeriodoId"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.Accertatori_PrenotazioneIntervalli SET ID = @ID, Nome = @Nome, Accerta" & _
    "tori_PrenotazioniPeriodoId = @Accertatori_PrenotazioniPeriodoId, IntervalloDa = " & _
    "@IntervalloDa, IntervalloA = @IntervalloA, MaxPrenotazione = @MaxPrenotazione, M" & _
    "odifiedOn = @ModifiedOn, CreatedBy = @CreatedBy, ModifiedBy = @ModifiedBy, NumPr" & _
    "enotati = @NumPrenotati, NumDisponibilita = @NumDisponibilita, UltimaPrenotazion" & _
    "e = @UltimaPrenotazione WHERE (ID = @Original_ID) AND (Accertatori_PrenotazioniP" & _
    "eriodoId = @Original_Accertatori_PrenotazioniPeriodoId OR @Original_Accertatori_" & _
    "PrenotazioniPeriodoId IS NULL AND Accertatori_PrenotazioniPeriodoId IS NULL) AND" & _
    " (CreatedBy = @Original_CreatedBy OR @Original_CreatedBy IS NULL AND CreatedBy I" & _
    "S NULL) AND (IntervalloA = @Original_IntervalloA OR @Original_IntervalloA IS NUL" & _
    "L AND IntervalloA IS NULL) AND (IntervalloDa = @Original_IntervalloDa OR @Origin" & _
    "al_IntervalloDa IS NULL AND IntervalloDa IS NULL) AND (MaxPrenotazione = @Origin" & _
    "al_MaxPrenotazione OR @Original_MaxPrenotazione IS NULL AND MaxPrenotazione IS N" & _
    "ULL) AND (ModifiedBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND " & _
    "ModifiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Original_Modified" & _
    "On IS NULL AND ModifiedOn IS NULL) AND (Nome = @Original_Nome OR @Original_Nome " & _
    "IS NULL AND Nome IS NULL) AND (NumDisponibilita = @Original_NumDisponibilita OR " & _
    "@Original_NumDisponibilita IS NULL AND NumDisponibilita IS NULL) AND (NumPrenota" & _
    "ti = @Original_NumPrenotati OR @Original_NumPrenotati IS NULL AND NumPrenotati I" & _
    "S NULL) AND (UltimaPrenotazione = @Original_UltimaPrenotazione OR @Original_Ulti" & _
    "maPrenotazione IS NULL AND UltimaPrenotazione IS NULL); SELECT ID, Nome, Accerta" & _
    "tori_PrenotazioniPeriodoId, IntervalloDa, IntervalloA, MaxPrenotazione, Modified" & _
    "On, CreatedBy, ModifiedBy, NumPrenotati, NumDisponibilita, UltimaPrenotazione FR" & _
    "OM dbo.Accertatori_PrenotazioneIntervalli WHERE (ID = @ID)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accertatori_PrenotazioniPeriodoId", System.Data.SqlDbType.UniqueIdentifier, 16, "Accertatori_PrenotazioniPeriodoId"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IntervalloDa", System.Data.SqlDbType.DateTime, 8, "IntervalloDa"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IntervalloA", System.Data.SqlDbType.DateTime, 8, "IntervalloA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MaxPrenotazione", System.Data.SqlDbType.Int, 4, "MaxPrenotazione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumPrenotati", System.Data.SqlDbType.Int, 4, "NumPrenotati"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDisponibilita", System.Data.SqlDbType.Int, 4, "NumDisponibilita"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UltimaPrenotazione", System.Data.SqlDbType.DateTime, 8, "UltimaPrenotazione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accertatori_PrenotazioniPeriodoId", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accertatori_PrenotazioniPeriodoId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IntervalloA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IntervalloA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IntervalloDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IntervalloDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MaxPrenotazione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaxPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDisponibilita", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDisponibilita", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumPrenotati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumPrenotati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UltimaPrenotazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UltimaPrenotazione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=True;initial catalog=ATCBussm;password=pwdbussm"
    '
    'DaPrenotazionePeriodoM
    '
    Me.DaPrenotazionePeriodoM.DeleteCommand = Me.SqlDeleteCommand3
    Me.DaPrenotazionePeriodoM.InsertCommand = Me.SqlInsertCommand4
    Me.DaPrenotazionePeriodoM.SelectCommand = Me.SqlSelectCommand4
    Me.DaPrenotazionePeriodoM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_PrenotazioniPeriodo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Pubblicato", "Pubblicato"), New System.Data.Common.DataColumnMapping("PrenotabileDa", "PrenotabileDa"), New System.Data.Common.DataColumnMapping("PrenotabileA", "PrenotabileA"), New System.Data.Common.DataColumnMapping("PeriodoDa", "PeriodoDa"), New System.Data.Common.DataColumnMapping("PrenotabileDaOra", "PrenotabileDaOra"), New System.Data.Common.DataColumnMapping("PrenotabileDaMinuti", "PrenotabileDaMinuti"), New System.Data.Common.DataColumnMapping("PeriodoA", "PeriodoA"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("NumMaxIntervalli", "NumMaxIntervalli"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
    Me.DaPrenotazionePeriodoM.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.Accertatori_PrenotazioniPeriodo WHERE (ID = @Original_ID) AND (Mo" & _
    "difiedBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND ModifiedBy I" & _
    "S NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Original_ModifiedOn IS NULL A" & _
    "ND ModifiedOn IS NULL) AND (Nome = @Original_Nome OR @Original_Nome IS NULL AND " & _
    "Nome IS NULL) AND (PeriodoA = @Original_PeriodoA OR @Original_PeriodoA IS NULL A" & _
    "ND PeriodoA IS NULL) AND (PeriodoDa = @Original_PeriodoDa OR @Original_PeriodoDa" & _
    " IS NULL AND PeriodoDa IS NULL) AND (PrenotabileA = @Original_PrenotabileA OR @O" & _
    "riginal_PrenotabileA IS NULL AND PrenotabileA IS NULL) AND (PrenotabileDa = @Ori" & _
    "ginal_PrenotabileDa OR @Original_PrenotabileDa IS NULL AND PrenotabileDa IS NULL" & _
    ") AND (Pubblicato = @Original_Pubblicato OR @Original_Pubblicato IS NULL AND Pub" & _
    "blicato IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pubblicato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pubblicato", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand4
    '
    Me.SqlInsertCommand4.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioniPeriodo (Nome, Pubblicato, PrenotabileDa," & _
    " PrenotabileA, PeriodoDa, PrenotabileDaOra, PrenotabileDaMinuti, PeriodoA, Modif" & _
    "iedOn, ModifiedBy, NumMaxIntervalli, ID) VALUES (@Nome, @Pubblicato, @Prenotabil" & _
    "eDa, @PrenotabileA, @PeriodoDa, @PrenotabileDaOra, @PrenotabileDaMinuti, @Period" & _
    "oA, @ModifiedOn, @ModifiedBy, @NumMaxIntervalli, @ID); SELECT Nome, Pubblicato, " & _
    "PrenotabileDa, PrenotabileA, PeriodoDa, PrenotabileDaOra, PrenotabileDaMinuti, P" & _
    "eriodoA, ModifiedOn, ModifiedBy, NumMaxIntervalli, ID FROM dbo.Accertatori_Preno" & _
    "tazioniPeriodo WHERE (ID = @ID)"
    Me.SqlInsertCommand4.Connection = Me.con
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileA", System.Data.SqlDbType.DateTime, 8, "PrenotabileA"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoDa", System.Data.SqlDbType.DateTime, 8, "PeriodoDa"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaOra", System.Data.SqlDbType.Int, 4, "PrenotabileDaOra"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaMinuti", System.Data.SqlDbType.Int, 4, "PrenotabileDaMinuti"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoA", System.Data.SqlDbType.DateTime, 8, "PeriodoA"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMaxIntervalli", System.Data.SqlDbType.Int, 4, "NumMaxIntervalli"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT Nome, Pubblicato, PrenotabileDa, PrenotabileA, PeriodoDa, PrenotabileDaOra" & _
    ", PrenotabileDaMinuti, PeriodoA, ModifiedOn, ModifiedBy, NumMaxIntervalli, ID FR" & _
    "OM Accertatori_PrenotazioniPeriodo WHERE (ID = @ID)"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.Accertatori_PrenotazioniPeriodo SET Nome = @Nome, Pubblicato = @Pubbli" & _
    "cato, PrenotabileDa = @PrenotabileDa, PrenotabileDaOra = @PrenotabileDaOra, Pren" & _
    "otabileDaMinuti = @PrenotabileDaMinuti, PrenotabileA = @PrenotabileA, PeriodoDa " & _
    "= @PeriodoDa, PeriodoA = @PeriodoA, ModifiedOn = @ModifiedOn, ModifiedBy = @Modi" & _
    "fiedBy, NumMaxIntervalli = @NumMaxIntervalli, ID = @ID WHERE (ID = @Original_ID)" & _
    " AND (ModifiedBy = @Original_ModifiedBy OR @Original_ModifiedBy IS NULL AND Modi" & _
    "fiedBy IS NULL) AND (ModifiedOn = @Original_ModifiedOn OR @Original_ModifiedOn I" & _
    "S NULL AND ModifiedOn IS NULL) AND (Nome = @Original_Nome OR @Original_Nome IS N" & _
    "ULL AND Nome IS NULL) AND (PeriodoA = @Original_PeriodoA OR @Original_PeriodoA I" & _
    "S NULL AND PeriodoA IS NULL) AND (PeriodoDa = @Original_PeriodoDa OR @Original_P" & _
    "eriodoDa IS NULL AND PeriodoDa IS NULL) AND (PrenotabileA = @Original_Prenotabil" & _
    "eA OR @Original_PrenotabileA IS NULL AND PrenotabileA IS NULL) AND (PrenotabileD" & _
    "a = @Original_PrenotabileDa OR @Original_PrenotabileDa IS NULL AND PrenotabileDa" & _
    " IS NULL) AND (Pubblicato = @Original_Pubblicato OR @Original_Pubblicato IS NULL" & _
    " AND Pubblicato IS NULL); SELECT Nome, Pubblicato, PrenotabileDa, PrenotabileA, " & _
    "PrenotabileDaOra, PrenotabileDaMinuti, PeriodoDa, PeriodoA, ModifiedOn, Modified" & _
    "By, NumMaxIntervalli, ID FROM dbo.Accertatori_PrenotazioniPeriodo WHERE (ID = @I" & _
    "D)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaOra", System.Data.SqlDbType.Int, 4, "PrenotabileDaOra"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaMinuti", System.Data.SqlDbType.Int, 4, "PrenotabileDaMinuti"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileA", System.Data.SqlDbType.DateTime, 8, "PrenotabileA"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoDa", System.Data.SqlDbType.DateTime, 8, "PeriodoDa"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoA", System.Data.SqlDbType.DateTime, 8, "PeriodoA"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMaxIntervalli", System.Data.SqlDbType.Int, 4, "NumMaxIntervalli"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pubblicato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pubblicato", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsPrenotazioneM1
    '
    Me.DsPrenotazioneM1.DataSetName = "DsPrenotazioneM"
    Me.DsPrenotazioneM1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsPrenotazione1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsPrenotazioneM1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daRichiesteFerie As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents comMensileAperto As System.Data.Odbc.OdbcCommand
  Protected WithEvents DsRichiesteFerie1 As ATCBussm1.dsRichiesteFerie
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents conDep As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaPrenotazioniPeriodo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsPrenotazione1 As ATCBussm1.DSPrenotazione
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaPrenotazioneIntervalli As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DaPrenotazionePeriodoM As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgIntervalloPrenotazione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsPrenotazioneM1 As ATCBussm1.DsPrenotazioneM
  Protected WithEvents DlPeriodoPrenotazione As System.Web.UI.WebControls.DataList
  Protected WithEvents lblIntervalli As System.Web.UI.WebControls.Label
  Protected WithEvents btnAddIntervallo As System.Web.UI.WebControls.Button
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand

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
    Dim gid = New Guid
    If Not (Trim(Request.QueryString("ID")) = "") Then
      Session.Add("IDPeriodoPreno", Trim(Request.QueryString("ID")))

    End If
    gid = New Guid(Convert.ToString(Session("IDPeriodoPreno")))
    DaPrenotazionePeriodoM.SelectCommand.Parameters("@ID").Value = gid
    DaPrenotazionePeriodoM.Fill(DsPrenotazioneM1, "Accertatori_PrenotazioniPeriodo")
    DaPrenotazioneIntervalli.SelectCommand.Parameters("@ID").Value = gid
    DaPrenotazioneIntervalli.Fill(DsPrenotazione1, "Accertatori_PrenotazioneIntervalli")
    If Not IsPostBack Then


      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Pagina iniziale", Session("IPAddress"))

    End If


  End Sub

  'Public Sub cvDataDal_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)

  '  'If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date) Then
  '  '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate <= Now.Date.AddDays(60)
  '  '  DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere delle ferie oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")

  '  'Else
  '  '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
  '  '  DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")

  '  'End If

  'End Sub

  'Private Sub dgFerie_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  'If cvOnModifica.IsValid Then
  '  fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Inizio modifica periodo prenotazione", Session("IPAddress"))
  '  Response.Redirect("wf_dettaglioperiodoprenotazione.aspx?ID=" & Convert.ToString(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex)))

  '  ' End If
  'End Sub

  'Private Sub dgPeriodoPrenotazione_UpdateCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'Me.Validate()
  '  'If Me.IsValid Then
  '  Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
  '  'Response.Write(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))

  '  If dr Is Nothing Then
  '    dr = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").NewRow
  '    dr.Item("ID") = Guid.NewGuid()

  '    DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Add(dr)
  '  End If
  '  dr.Item("ModifiedOn") = Now
  '  dr.Item("CreatedBy") = oUtente.IDUser
  '  dr.Item("ModifiedBy") = oUtente.IDUser
  '  dr.Item("NumMaxIntervalli") = 2
  '  'Response.Write("-" & dr.Item("NumMaxIntervalli"))

  '  dr.Item("Nome") = DirectCast(e.Item.FindControl("Nome"), TextBox).Text
  '  dr.Item("PrenotabileDa") = DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate
  '  dr.Item("PrenotabileA") = DirectCast(e.Item.FindControl("caPrenotabileA"), Calendar).SelectedDate
  '  dr.Item("PeriodoDa") = DirectCast(e.Item.FindControl("caPeriodoDa"), Calendar).SelectedDate
  '  dr.Item("PeriodoA") = DirectCast(e.Item.FindControl("caPeriodoA"), Calendar).SelectedDate

  '  dr.Item("Pubblicato") = IIf(DirectCast(e.Item.FindControl("Pubblicato"), CheckBox).Checked = True, 1, 0)


  '  DaPrenotazioniPeriodo.Update(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")
  '  DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Clear()
  '  DaPrenotazioniPeriodo.Fill(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")

  '  'dgPeriodoPrenotazione_CancelCommand(source, e)
  '  dgPeriodoPrenotazione.EditItemIndex = -1
  '  Page.DataBind()
  '  btnAddPeriodo.Enabled = True
  '  fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Confermato inserimento/modifica del periodo di prenotazione ferie", Session("IPAddress"))
  '  ' End If

  'End Sub
  'Private Sub dgPeriodoPrenotazione_CancelCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  dgPeriodoPrenotazione.EditItemIndex = -1
  '  Page.DataBind()
  '  btnAddPeriodo.Enabled = True
  '  fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Annullata modifica della richiesta ferie", Session("IPAddress"))

  'End Sub

  'Private Sub dgPeriodoPrenotazione_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  'If cvOnModifica.IsValid Then
  '  Dim dr As DataRow = DsRichiesteFerie1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
  '  If Not dr Is Nothing Then
  '    dr.Delete()
  '    daRichiesteFerie.Update(DsRichiesteFerie1, "Accertatori_PrenotazioniPeriodo")
  '    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Eliminato il periodo prenotazione", Session("IPAddress"))
  '  End If
  '  dgPeriodoPrenotazione_CancelCommand(source, e)
  '  'End If

  'End Sub

  'Private Sub dgPeriodoPrenotazione_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
  '  If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questo periodo di prenotazione?');")
  'End Sub

  ''Public Sub cvMinDataAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  ''  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate.AddDays(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)
  ''End Sub

  ''Public Sub cvMeseDataDalAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  ''  args.IsValid = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)

  ''End Sub

  Private Sub DlPeriodoPrenotazione_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DlPeriodoPrenotazione.EditCommand

    DlPeriodoPrenotazione.EditItemIndex = e.Item.ItemIndex
    Page.DataBind()
    '    btnAddIntervallo.Enabled = False
    '    fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Inizio modifica richiesta ferie", Session("IPAddress"))



  End Sub



  Private Sub btnAddIntervallo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntervallo.Click
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").NewRow
    Dim MeseMensileAperto As String
    Dim idperido As New Guid(Convert.ToString(Session("IDPeriodoPreno")))
    Dim comi As New SqlClient.SqlCommand("SELECT TOP(1) CASE WHEN NOT (Accertatori_PrenotazioneIntervalli.IntervalloA IS NULL) THEN Accertatori_PrenotazioneIntervalli.IntervalloA ELSE DATEADD(day, - 1, PeriodoDa)  END AS DA " & _
                                " FROM Accertatori_PrenotazioneIntervalli RIGHT OUTER JOIN " & _
                                "Accertatori_PrenotazioniPeriodo ON Accertatori_PrenotazioneIntervalli.Accertatori_PrenotazioniPeriodoId = Accertatori_PrenotazioniPeriodo.ID " & _
                                " where Accertatori_PrenotazioniPeriodo.id='" & idperido.ToString() & "' " & _
                                "ORDER BY Accertatori_PrenotazioneIntervalli.IntervalloDa DESC", con)
    Dim IntervalloDa As DateTime

    con.Open()

    IntervalloDa = Convert.ToDateTime(comi.ExecuteScalar())
    con.Close()

    dr.Item("ID") = Guid.NewGuid()
    dr.Item("Accertatori_PrenotazioniPeriodoId") = idperido
    dr.Item("ModifiedOn") = Now
    dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("IntervalloDa") = IntervalloDa.AddDays(1)
    dr.Item("IntervalloA") = IntervalloDa.AddDays(7)
    dr.Item("MaxPrenotazione") = 5
    dr.Item("NumPrenotati") = 0
    dr.Item("NumDisponibilita") = 5
    dr.Item("Nome") = ""



    DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").Rows.InsertAt(dr, 0)
    dgIntervalloPrenotazione.EditItemIndex = 0
    Page.DataBind()
    btnAddIntervallo.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Click nuovo periodo di prenotazione", Session("IPAddress"))



  End Sub

  Private Sub DlPeriodoPrenotazione_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DlPeriodoPrenotazione.UpdateCommand
    '''Max 20190314
    'If DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate = DirectCast(e.Item.FindControl("caPrenotabileA"), Calendar).SelectedDate Then
    '  DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate = DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate.AddDays(-1)
    'End If

    'Me.Validate()
    'If Me.IsValid Then
    'Me.Validate()
    'If Me.IsValid Then
    Dim dr As DataRow = DsPrenotazioneM1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(DlPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
    'Response.Write(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))

    If dr Is Nothing Then
      dr = DsPrenotazioneM1.Tables("Accertatori_PrenotazioniPeriodo").NewRow
      dr.Item("ID") = Guid.NewGuid()

      DsPrenotazioneM1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Add(dr)
    End If
    dr.Item("ModifiedOn") = Now
    'dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("NumMaxIntervalli") = Convert.ToInt32(DirectCast(e.Item.FindControl("NumMaxIntervalli"), TextBox).Text)
    'dr.Item("NumMaxIntervalli") = Convert.ToInt32(DirectCast(e.Item.FindControl("NumMaxIntervalli"), TextBox).Text)

    'Response.Write("-" & dr.Item("NumMaxIntervalli"))
    'NumMaxIntervalli
    dr.Item("Nome") = DirectCast(e.Item.FindControl("Nome"), TextBox).Text
    dr.Item("PrenotabileDa") = DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate
    dr.Item("PrenotabileDaOra") = DirectCast(e.Item.FindControl("txtDAOra"), TextBox).Text
    dr.Item("PrenotabileDaMinuti") = DirectCast(e.Item.FindControl("txtDAMinuti"), TextBox).Text
    dr.Item("PrenotabileA") = DirectCast(e.Item.FindControl("caPrenotabileA"), Calendar).SelectedDate
    dr.Item("PeriodoDa") = DirectCast(e.Item.FindControl("caPeriodoDa"), Calendar).SelectedDate
    dr.Item("PeriodoA") = DirectCast(e.Item.FindControl("caPeriodoA"), Calendar).SelectedDate

    '''Max 20190314
    'dr.Item("Pubblicato") = IIf(DirectCast(e.Item.FindControl("Pubblicato"), CheckBox).Checked = True, 1, 0)
    If DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate = DirectCast(e.Item.FindControl("caPrenotabileA"), Calendar).SelectedDate Then
      Dim cvl As CustomValidator
      cvl = New CustomValidator
      cvl.ErrorMessage = "Con date uguali nel periodo selezionato inibita la pubblicazione."
      cvl.IsValid = False
      Me.Page.Validators.Add(cvl)

      dr.Item("Pubblicato") = 0
    Else
      dr.Item("Pubblicato") = IIf(DirectCast(e.Item.FindControl("Pubblicato"), CheckBox).Checked = True, 1, 0)
    End If

    DaPrenotazionePeriodoM.Update(DsPrenotazioneM1, "Accertatori_PrenotazioniPeriodo")
    DsPrenotazioneM1.Tables("Accertatori_PrenotazioniPeriodo").Clear()
    DaPrenotazionePeriodoM.Fill(DsPrenotazioneM1, "Accertatori_PrenotazioniPeriodo")

    'dgPeriodoPrenotazione_CancelCommand(source, e)
    DlPeriodoPrenotazione.EditItemIndex = -1
    Dim gid = New Guid(Convert.ToString(Session("IDPeriodoPreno")))
    DaPrenotazionePeriodoM.SelectCommand.Parameters("@ID").Value = gid
    DaPrenotazionePeriodoM.Fill(DsPrenotazioneM1, "Accertatori_PrenotazioniPeriodo")
    DaPrenotazioneIntervalli.SelectCommand.Parameters("@ID").Value = gid
    DaPrenotazioneIntervalli.Fill(DsPrenotazione1, "Accertatori_PrenotazioneIntervalli")
    Page.DataBind()

    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Confermato inserimento/modifica del periodo di prenotazione ferie", Session("IPAddress"))
    ' End If

    'End If
  End Sub

  Private Sub DlPeriodoPrenotazione_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DlPeriodoPrenotazione.CancelCommand
    DlPeriodoPrenotazione.EditItemIndex = -1
    Page.DataBind()
    btnAddIntervallo.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneintervallipreno.aspx", "Annullata modifica periodo preno", Session("IPAddress"))

  End Sub

  Private Sub dgIntervalloPrenotazione_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgIntervalloPrenotazione.CancelCommand
    dgIntervalloPrenotazione.EditItemIndex = -1
    Page.DataBind()
    btnAddIntervallo.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneintervallipreno.aspx", "Annullata modifica intervallo preno", Session("IPAddress"))

  End Sub


  Private Sub dgIntervalloPrenotazione_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgIntervalloPrenotazione.UpdateCommand

    'Me.Validate()
    'If Me.IsValid Then
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").Rows.Find(dgIntervalloPrenotazione.DataKeys(e.Item.ItemIndex))
    Dim idperido As New Guid(Convert.ToString(Session("IDPeriodoPreno")))
    'Response.Write(dr Is Nothing)

    If dr Is Nothing Then
      dr = DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").NewRow
      dr.Item("ID") = Guid.NewGuid()
      dr.Item("Accertatori_PrenotazioniPeriodoId") = idperido
      dr.Item("CreatedBy") = oUtente.IDUser
      dr.Item("NumPrenotati") = 0

      DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").Rows.Add(dr)
    End If

    dr.Item("ModifiedOn") = Now
    'dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("Nome") = "Da " & Format(DirectCast(e.Item.FindControl("caIntervalloDa"), Calendar).SelectedDate, "dd/MM/yy") & " A " & Format(DirectCast(e.Item.FindControl("caIntervalloA"), Calendar).SelectedDate, "dd/MM/yy")
    dr.Item("IntervalloDa") = DirectCast(e.Item.FindControl("caIntervalloDa"), Calendar).SelectedDate
    dr.Item("IntervalloA") = DirectCast(e.Item.FindControl("caIntervalloA"), Calendar).SelectedDate


    dr.Item("MaxPrenotazione") = Convert.ToInt32(DirectCast(e.Item.FindControl("MaxPrenotazione"), TextBox).Text)

    dr.Item("NumDisponibilita") = dr.Item("MaxPrenotazione") - dr.Item("NumPrenotati")
    DaPrenotazioneIntervalli.Update(DsPrenotazione1, "Accertatori_PrenotazioneIntervalli")
    DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").Clear()
    DaPrenotazioneIntervalli.Fill(DsPrenotazione1, "Accertatori_PrenotazioneIntervalli")

    'dgPeriodoPrenotazione_CancelCommand(source, e)
    dgIntervalloPrenotazione.EditItemIndex = -1
    btnAddIntervallo.Enabled = True
    Page.DataBind()

    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneintervallipreno.aspx", "Confermato inserimento/modifica intervallo di prenotazione ferie", Session("IPAddress"))
    ' End If

    'End If


  End Sub

  Private Sub dgIntervalloPrenotazione_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgIntervalloPrenotazione.DeleteCommand
    'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    'If cvOnModifica.IsValid Then
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioneIntervalli").Rows.Find(dgIntervalloPrenotazione.DataKeys(e.Item.ItemIndex))
    If Not dr Is Nothing Then
      dr.Delete()
      DaPrenotazioneIntervalli.Update(DsPrenotazione1, "Accertatori_PrenotazioneIntervalli")
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneintervallipreno.aspx", "Eliminato intervallo di prenotazione", Session("IPAddress"))
    End If
    dgIntervalloPrenotazione_CancelCommand(source, e)
    'End If
  End Sub


  Private Sub dgIntervalloPrenotazione_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgIntervalloPrenotazione.EditCommand
    dgIntervalloPrenotazione.EditItemIndex = e.Item.ItemIndex
    Page.DataBind()


  End Sub

End Class
