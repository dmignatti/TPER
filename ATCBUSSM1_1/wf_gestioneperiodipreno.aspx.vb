Public Class wf_gestioneperiodipreno
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
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsPrenotazione1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.Accertatori_PrenotazioniPeriodo (ID, Nome, Pubblicato, Prenotabil" & _
    "eDa, PrenotabileDaOra, PrenotabileDaMinuti, PrenotabileA, PeriodoDa, PeriodoA, N" & _
    "umMaxIntervalli, ModifiedOn, CreatedBy, ModifiedBy) VALUES (@ID, @Nome, @Pubblic" & _
    "ato, @PrenotabileDa, @PrenotabileDaOra, @PrenotabileDaMinuti, @PrenotabileA, @Pe" & _
    "riodoDa, @PeriodoA, @NumMaxIntervalli, @ModifiedOn, @CreatedBy, @ModifiedBy); SE" & _
    "LECT ID, Nome, Pubblicato, PrenotabileDa, PrenotabileDaOra, PrenotabileDaMinuti," & _
    " PrenotabileA, PeriodoDa, PeriodoA, NumMaxIntervalli, ModifiedOn, CreatedBy, Mod" & _
    "ifiedBy FROM dbo.Accertatori_PrenotazioniPeriodo WHERE (ID = @ID)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaOra", System.Data.SqlDbType.Int, 4, "PrenotabileDaOra"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaMinuti", System.Data.SqlDbType.Int, 4, "PrenotabileDaMinuti"))
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
    Me.SqlSelectCommand2.CommandText = "SELECT ID, Nome, Pubblicato, PrenotabileDa, PrenotabileA, PeriodoDa, PeriodoA, Nu" & _
    "mMaxIntervalli, ModifiedOn, CreatedBy, ModifiedBy, PrenotabileDaOra, Prenotabile" & _
    "DaMinuti FROM Accertatori_PrenotazioniPeriodo order by PeriodoDa desc"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori_PrenotazioniPeriodo SET ID = @ID, Nome = @Nome, Pubblicato" & _
    " = @Pubblicato, PrenotabileDa = @PrenotabileDa, PrenotabileDaOra = @PrenotabileD" & _
    "aOra, PrenotabileDaMinuti = @PrenotabileDaMinuti, PrenotabileA = @PrenotabileA, " & _
    "PeriodoDa = @PeriodoDa, PeriodoA = @PeriodoA, NumMaxIntervalli = @NumMaxInterval" & _
    "li, ModifiedOn = @ModifiedOn, CreatedBy = @CreatedBy, ModifiedBy = @ModifiedBy W" & _
    "HERE (ID = @Original_ID) AND (CreatedBy = @Original_CreatedBy OR @Original_Creat" & _
    "edBy IS NULL AND CreatedBy IS NULL) AND (ModifiedBy = @Original_ModifiedBy OR @O" & _
    "riginal_ModifiedBy IS NULL AND ModifiedBy IS NULL) AND (ModifiedOn = @Original_M" & _
    "odifiedOn OR @Original_ModifiedOn IS NULL AND ModifiedOn IS NULL) AND (Nome = @O" & _
    "riginal_Nome OR @Original_Nome IS NULL AND Nome IS NULL) AND (PeriodoA = @Origin" & _
    "al_PeriodoA OR @Original_PeriodoA IS NULL AND PeriodoA IS NULL) AND (PeriodoDa =" & _
    " @Original_PeriodoDa OR @Original_PeriodoDa IS NULL AND PeriodoDa IS NULL) AND (" & _
    "PeriodoDaOra = @Original_PeriodoDaOra OR @Original_PeriodoDaOra IS NULL AND Peri" & _
    "odoDaOra IS NULL) AND (PeriodoDaMinuti = @Original_PeriodoDaMinuti OR @Original_" & _
    "PeriodoDaMinuti IS NULL AND PeriodoDaMinuti IS NULL) AND (PrenotabileA = @Origin" & _
    "al_PrenotabileA OR @Original_PrenotabileA IS NULL AND PrenotabileA IS NULL) AND " & _
    "(PrenotabileDa = @Original_PrenotabileDa OR @Original_PrenotabileDa IS NULL AND " & _
    "PrenotabileDa IS NULL) AND (Pubblicato = @Original_Pubblicato OR @Original_Pubbl" & _
    "icato IS NULL AND Pubblicato IS NULL); SELECT ID, Nome, Pubblicato, PrenotabileD" & _
    "a, PrenotabileDaOra, PrenotabileDaMinuti, PrenotabileA, PeriodoDa, PeriodoA, Num" & _
    "MaxIntervalli, ModifiedOn, CreatedBy, ModifiedBy FROM dbo.Accertatori_Prenotazio" & _
    "niPeriodo WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pubblicato", System.Data.SqlDbType.Bit, 1, "Pubblicato"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDa", System.Data.SqlDbType.DateTime, 8, "PrenotabileDa"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaOra", System.Data.SqlDbType.Int, 4, "PrenotabileDaOra"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileDaMinuti", System.Data.SqlDbType.Int, 4, "PrenotabileDaMinuti"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrenotabileA", System.Data.SqlDbType.DateTime, 8, "PrenotabileA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoDa", System.Data.SqlDbType.DateTime, 8, "PeriodoDa"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PeriodoA", System.Data.SqlDbType.DateTime, 8, "PeriodoA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMaxIntervalli", System.Data.SqlDbType.Int, 4, "NumMaxIntervalli"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreatedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreatedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModifiedOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ModifiedOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.NVarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PeriodoDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDaOra", System.Data.SqlDbType.Variant, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PeriodoDaMinuti", System.Data.SqlDbType.Variant, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrenotabileDa", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrenotabileDa", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pubblicato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pubblicato", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsPrenotazione1
    '
    Me.DsPrenotazione1.DataSetName = "DSPrenotazione"
    Me.DsPrenotazione1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=True;initial catalog=ATCBussm;password=pwdbussm"
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsPrenotazione1, System.ComponentModel.ISupportInitialize).EndInit()

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
  Protected WithEvents DaPrenotazioniPeriodo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dgPeriodoPrenotazione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsPrenotazione1 As ATCBussm1.DSPrenotazione
  Protected WithEvents btnAddPeriodo As System.Web.UI.WebControls.Button
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents cvPrenotabileA As System.Web.UI.WebControls.CustomValidator

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


    DaPrenotazioniPeriodo.Fill(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")
    If Not IsPostBack Then
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Pagina iniziale", Session("IPAddress"))

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

  End Sub

  'Private Sub dgFerie_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  'If cvOnModifica.IsValid Then
  '  fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Inizio modifica periodo prenotazione", Session("IPAddress"))
  '  Response.Redirect("wf_gestioneintervallipreno.aspx?ID=" & Convert.ToString(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex)))

  '  ' End If
  'End Sub

  Private Sub dgPeriodoPrenotazione_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPeriodoPrenotazione.UpdateCommand
    '''Max 20190314
    'If DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate = DirectCast(e.Item.FindControl("caPrenotabileA"), Calendar).SelectedDate Then
    '  DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate = DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate.AddDays(-1)
    'End If

    'Me.Validate()
    'If Me.IsValid Then
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
    'Response.Write(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))

    If dr Is Nothing Then
      dr = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").NewRow
      dr.Item("ID") = Guid.NewGuid()

      DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Add(dr)
    End If
    dr.Item("ModifiedOn") = Now
    dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("NumMaxIntervalli") = Convert.ToInt32(DirectCast(e.Item.FindControl("NumMaxIntervalli"), TextBox).Text)
    'dr.Item("NumMaxIntervalli") = Convert.ToInt32(DirectCast(e.Item.FindControl("NumMaxIntervalli"), TextBox).Text)

    'Response.Write("-" & dr.Item("NumMaxIntervalli"))
    'NumMaxIntervalli

    dr.Item("Nome") = DirectCast(e.Item.FindControl("Nome"), TextBox).Text
    dr.Item("PrenotabileDa") = DirectCast(e.Item.FindControl("caPrenotabileDa"), Calendar).SelectedDate
    dr.Item("PrenotabileDaOra") = IIf(IsNumeric(DirectCast(e.Item.FindControl("PrenotabileDaOra"), TextBox).Text), Convert.ToInt32(DirectCast(e.Item.FindControl("PrenotabileDaOra"), TextBox).Text), 0)
    dr.Item("PrenotabileDaMinuti") = IIf(IsNumeric(DirectCast(e.Item.FindControl("PrenotabileDaMinuti"), TextBox).Text), Convert.ToInt32(DirectCast(e.Item.FindControl("PrenotabileDaMinuti"), TextBox).Text), 0)
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

    DaPrenotazioniPeriodo.Update(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")
    DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Clear()
    DaPrenotazioniPeriodo.Fill(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")

    'dgPeriodoPrenotazione_CancelCommand(source, e)
    dgPeriodoPrenotazione.EditItemIndex = -1
    Page.DataBind()
    btnAddPeriodo.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Confermato inserimento/modifica del periodo di prenotazione ferie", Session("IPAddress"))
    ' End If

  End Sub
  Private Sub dgPeriodoPrenotazione_CancelCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    dgPeriodoPrenotazione.EditItemIndex = -1
    Page.DataBind()
    btnAddPeriodo.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Annullata modifica della richiesta ferie", Session("IPAddress"))

  End Sub

  'Private Sub dgPeriodoPrenotazione_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  'If cvOnModifica.IsValid Then
  '  Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
  '  If Not dr Is Nothing Then
  '    dr.Delete()
  '    DaPrenotazioniPeriodo.Update(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")
  '    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Eliminato il periodo prenotazione", Session("IPAddress"))
  '  End If
  '  dgPeriodoPrenotazione_CancelCommand(source, e)
  '  'End If

  'End Sub

  Private Sub dgPeriodoPrenotazione_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questo periodo di prenotazione?');")
  End Sub

  'Public Sub cvMinDataAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate.AddDays(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)
  'End Sub

  'Public Sub cvMeseDataDalAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)

  'End Sub

  'Private Function pCountFestivita(ByVal dal As Date, ByVal al As Date) As Integer
  '  Dim i As Integer = 0
  '  Do While dal <= al
  '    Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
  '    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
  '    Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
  '    riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
  '    con.Open()
  '    If dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0 Or riposi.ExecuteScalar() > 0 Then i += 1
  '    con.Close()
  '    dal = dal.AddDays(1)
  '  Loop
  '  pCountFestivita = i

  'End Function

  Private Sub btnAddPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPeriodo.Click
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").NewRow
    Dim MeseMensileAperto As String
    dr.Item("ID") = Guid.NewGuid()
    dr.Item("ModifiedOn") = Now
    dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("NumMaxIntervalli") = 2
    dr.Item("PrenotabileDa") = Now
    dr.Item("PrenotabileDaOra") = 0
    dr.Item("PrenotabileDaMinuti") = 0
    'dr.Item("PrenotabileA") = Now
    dr.Item("PrenotabileA") = Now.AddDays(1)
    dr.Item("PeriodoDa") = Now
    dr.Item("PeriodoA") = Now
    dr.Item("Pubblicato") = 0
    If (Month(Now) < 6) Then
      dr.Item("Nome") = "Periodo prenotazione ferie estive " & Year(Now)
    Else
      dr.Item("Nome") = "Periodo prenotazione ferie invernali " & Year(Now)
    End If


    DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.InsertAt(dr, 0)
    dgPeriodoPrenotazione.EditItemIndex = 0
    Page.DataBind()
    btnAddPeriodo.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Click nuovo periodo di prenotazione", Session("IPAddress"))
  End Sub


  Private Sub dgPeriodoPrenotazione_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPeriodoPrenotazione.EditCommand
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Inizio modifica periodo prenotazione", Session("IPAddress"))
    Session.Remove("IDPeriodoPreno")
    Response.Redirect("wf_gestioneintervallipreno.aspx?ID=" & Convert.ToString(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex)))

  End Sub


  Private Sub dgPeriodoPrenotazione_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPeriodoPrenotazione.DeleteCommand
    Dim dr As DataRow = DsPrenotazione1.Tables("Accertatori_PrenotazioniPeriodo").Rows.Find(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))
    If Not dr Is Nothing Then
      dr.Delete()
      DaPrenotazioniPeriodo.Update(DsPrenotazione1, "Accertatori_PrenotazioniPeriodo")
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Eliminato il periodo prenotazione", Session("IPAddress"))
    End If
    dgPeriodoPrenotazione_CancelCommand(source, e)
  End Sub

End Class
