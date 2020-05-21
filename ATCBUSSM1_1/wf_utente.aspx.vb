Public Class wf_utente
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daUtente = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsUtenti1 = New ATCBussm1.dsUtenti
    Me.daTipiUtente = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daGruppi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.dvGruppi = New System.Data.DataView
    Me.daGruppiDiAppartenenza = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daUtente
    '
    Me.daUtente.DeleteCommand = Me.SqlDeleteCommand1
    Me.daUtente.InsertCommand = Me.SqlInsertCommand1
    Me.daUtente.SelectCommand = Me.SqlSelectCommand1
    Me.daUtente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("Pwd", "Pwd"), New System.Data.Common.DataColumnMapping("IDResponsabile", "IDResponsabile"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente")})})
    Me.daUtente.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Utenti WHERE (ID = @Original_ID) AND (Abilitato = @Original_A" & _
    "bilitato) AND (Cognome = @Original_Cognome) AND (DataUltimoAccesso = @Original_D" & _
    "ataUltimoAccesso) AND (EMail = @Original_EMail) AND (IDResponsabile = @Original_" & _
    "IDResponsabile) AND (IDUser = @Original_IDUser) AND (Nome = @Original_Nome) AND " & _
    "(NrAccessi = @Original_NrAccessi) AND (OraUltimoAccesso = @Original_OraUltimoAcc" & _
    "esso) AND (Pwd = @Original_Pwd) AND (TipoUtente = @Original_TipoUtente) AND (Fla" & _
    "g_Patente = @Original_Flag_Patente)"
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
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Flag_Patente", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Flag_Patente", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.ATC_Utenti (IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Ab" & _
    "ilitato, DataUltimoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente, Flag_Patent" & _
    "e) VALUES (@IDUser, @Pwd, @IDResponsabile, @Cognome, @Nome, @EMail, @Abilitato, " & _
    "@DataUltimoAccesso, @OraUltimoAccesso, @NrAccessi, @TipoUtente, @Flag_Patente); " & _
    "SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato, DataUlt" & _
    "imoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente, Flag_Patente FROM dbo.ATC_U" & _
    "tenti WHERE (ID = @@IDENTITY)"
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
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag_Patente", System.Data.SqlDbType.Bit, 1, "Flag_Patente"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome, EMail, Abilitato, DataUlti" & _
    "moAccesso, OraUltimoAccesso, NrAccessi, TipoUtente, Flag_Patente FROM dbo.ATC_Ut" & _
    "enti WHERE (ID = @id)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Utenti SET IDUser = @IDUser, Pwd = @Pwd, IDResponsabile = @IDRespo" & _
    "nsabile, Cognome = @Cognome, Nome = @Nome, EMail = @EMail, Abilitato = @Abilitat" & _
    "o, DataUltimoAccesso = @DataUltimoAccesso, OraUltimoAccesso = @OraUltimoAccesso," & _
    " NrAccessi = @NrAccessi, TipoUtente = @TipoUtente, Flag_Patente = @Flag_Patente " & _
    "WHERE (ID = @Original_ID); SELECT ID, IDUser, Pwd, IDResponsabile, Cognome, Nome" & _
    ", EMail, Abilitato, DataUltimoAccesso, OraUltimoAccesso, NrAccessi, TipoUtente, " & _
    "Flag_Patente FROM dbo.ATC_Utenti WHERE (ID = @ID)"
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
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Flag_Patente", System.Data.SqlDbType.Bit, 1, "Flag_Patente"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    '
    'DsUtenti1
    '
    Me.DsUtenti1.DataSetName = "dsUtenti"
    Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daTipiUtente
    '
    Me.daTipiUtente.DeleteCommand = Me.SqlDeleteCommand2
    Me.daTipiUtente.InsertCommand = Me.SqlInsertCommand2
    Me.daTipiUtente.SelectCommand = Me.SqlSelectCommand2
    Me.daTipiUtente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_TipoUtente", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daTipiUtente.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.ATC_TipoUtente WHERE (ID = @Original_ID) AND (Descrizione = @Orig" & _
    "inal_Descrizione)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.ATC_TipoUtente(Descrizione) VALUES (@Descrizione); SELECT ID, Des" & _
    "crizione FROM dbo.ATC_TipoUtente WHERE (ID = @@IDENTITY) ORDER BY Descrizione"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT ID, Descrizione FROM dbo.ATC_TipoUtente ORDER BY Descrizione"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.ATC_TipoUtente SET Descrizione = @Descrizione WHERE (ID = @Original_ID" & _
    ") AND (Descrizione = @Original_Descrizione); SELECT ID, Descrizione FROM dbo.ATC" & _
    "_TipoUtente WHERE (ID = @ID) ORDER BY Descrizione"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    '
    'daGruppi
    '
    Me.daGruppi.SelectCommand = Me.SqlSelectCommand3
    Me.daGruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Amministrazione", "Amministrazione")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID, Descrizione, Abilitato, EMail, Amministrazione FROM dbo.ATC_Gruppi g1 " & _
    "WHERE (NOT EXISTS (SELECT * FROM atc_relutentegruppo g2 WHERE g1.id = g2.idgrupp" & _
    "o AND g2.idutente = @id))"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "IDUtente"))
    '
    'dvGruppi
    '
    Me.dvGruppi.Table = Me.DsUtenti1.ATC_Gruppi
    '
    'daGruppiDiAppartenenza
    '
    Me.daGruppiDiAppartenenza.DeleteCommand = Me.SqlDeleteCommand3
    Me.daGruppiDiAppartenenza.InsertCommand = Me.SqlInsertCommand3
    Me.daGruppiDiAppartenenza.SelectCommand = Me.SqlSelectCommand4
    Me.daGruppiDiAppartenenza.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GruppiDiAppartenenza", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Amministrazione", "Amministrazione")})})
    Me.daGruppiDiAppartenenza.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.ATC_Gruppi WHERE (ID = @Delete2_Original_ID) AND (Abilitato = @Or" & _
    "iginal_Abilitato OR @Original_Abilitato IS NULL AND Abilitato IS NULL) AND (Ammi" & _
    "nistrazione = @Original_Amministrazione OR @Original_Amministrazione IS NULL AND" & _
    " Amministrazione IS NULL) AND (Descrizione = @Original_Descrizione) AND (EMail =" & _
    " @Original_EMail OR @Original_EMail IS NULL AND EMail IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Delete2_Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.ATC_Gruppi(Descrizione, Abilitato, EMail, Amministrazione) VALUES" & _
    " (@Descrizione, @Abilitato, @EMail, @Amministrazione)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT r.ID, g.Descrizione, g.Abilitato, g.EMail, g.Amministrazione FROM dbo.ATC_" & _
    "RelUtenteGruppo r INNER JOIN dbo.ATC_Gruppi g ON r.IDGruppo = g.ID WHERE (r.IDUt" & _
    "ente = @id)"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "IDUtente"))
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.ATC_Gruppi SET Descrizione = @Descrizione, Abilitato = @Abilitato, EMa" & _
    "il = @EMail, Amministrazione = @Amministrazione WHERE (ID = @Update2_Original_ID" & _
    ") AND (Abilitato = @Original_Abilitato OR @Original_Abilitato IS NULL AND Abilit" & _
    "ato IS NULL) AND (Amministrazione = @Original_Amministrazione OR @Original_Ammin" & _
    "istrazione IS NULL AND Amministrazione IS NULL) AND (Descrizione = @Original_Des" & _
    "crizione) AND (EMail = @Original_EMail OR @Original_EMail IS NULL AND EMail IS N" & _
    "ULL)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Update2_Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblIdUser As System.Web.UI.WebControls.Label
  Protected WithEvents txtIdUser As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
  Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblTipoUtente As System.Web.UI.WebControls.Label
  Protected WithEvents ddlTipoUtente As System.Web.UI.WebControls.DropDownList
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daUtente As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
  Protected WithEvents daTipiUtente As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvIdUSer As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtId As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents lblNoCarichi As System.Web.UI.WebControls.Label
  Protected WithEvents btnRemove As System.Web.UI.WebControls.Button
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents lblNoProdotti As System.Web.UI.WebControls.Label
  Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
  Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents daGruppi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dvGruppi As System.Data.DataView
  Protected WithEvents daGruppiDiAppartenenza As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents dgGruppi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents dgGruppoDiAppartenenza As System.Web.UI.WebControls.DataGrid
  Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
  Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblAbilitato As System.Web.UI.WebControls.Label
  Protected WithEvents chkAbilitato As System.Web.UI.WebControls.CheckBox
  Protected WithEvents revEmail As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents LinkButton1 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents LinkButton2 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents cvIdUser As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents lblPatente As System.Web.UI.WebControls.Label
  Protected WithEvents chkPatente As System.Web.UI.WebControls.CheckBox

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
        Dim dr As DataRow = DsUtenti1.Tables("ATC_Utenti").NewRow
        dr("Id") = -1
        dr("TipoUtente") = 1
        dr("Abilitato") = 1
        'MB 20190704 aggiunta riga seguente
        dr("Flag_Patente") = 0
        DsUtenti1.Tables("ATC_Utenti").Rows.Add(dr)
      End If
    Else
      daUtente.SelectCommand.Parameters("@Id").Value = txtId.Value
      daUtente.Fill(DsUtenti1)
    End If
    daTipiUtente.Fill(DsUtenti1)
    If Not IsPostBack Then
      Page.DataBind()
    End If
    txtSearch.Attributes.Add("onKeyPress", "javascript: return !(window.event && window.event.keyCode == 13);")
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Dim com As New SqlClient.SqlCommand("Insert Into ATC_RelUtenteGruppo Values(@IdUtente, @IdGruppo)", con)
    com.Parameters.Add("@IdUtente", SqlDbType.Int)
    com.Parameters.Add("@IdGruppo", SqlDbType.Int)
    con.Open()
    For i As Integer = 0 To dgGruppi.Items.Count - 1
      If DirectCast(dgGruppi.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@IdUtente").Value = txtId.Value
        com.Parameters("@IdGruppo").Value = dgGruppi.DataKeys(i)
        com.ExecuteNonQuery()
      End If
    Next
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppoDiAppartenenza.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub pFilterGroupsGrid()
    Dim s As String = txtSearch.Text.Trim
    If s.Length > 0 Then
      Do While s.IndexOf("  ") > 0
        s = s.Replace("  ", " ")
      Loop
      Dim pArr As String() = s.Split(" ")
      Dim where As String = ""
      For Each el As String In pArr
        If where.Length > 0 Then where &= " And "
        where &= "(Descrizione Like '%" & el & "%')"
      Next
      dvGruppi.RowFilter = where
    Else
      dvGruppi.RowFilter = ""
    End If
  End Sub

  Private Sub pRefreshGrid()
    DsUtenti1.Tables("ATC_Gruppi").Clear()
    DsUtenti1.Tables("GruppiDiAppartenenza").Clear()
    pFillGrid()
    dgGruppi.DataBind()
    dgGruppoDiAppartenenza.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub pFillGrid()
    If txtId.Value.Length > 0 Then
      daGruppiDiAppartenenza.SelectCommand.Parameters("@id").Value = txtId.Value
      daGruppiDiAppartenenza.Fill(DsUtenti1)
      daGruppi.SelectCommand.Parameters("@id").Value = txtId.Value
    Else
      daGruppi.SelectCommand.Parameters("@id").Value = 0
    End If
    daGruppi.Fill(DsUtenti1)
  End Sub

  Private Sub dgGruppi_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgGruppi.PageIndexChanged
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = e.NewPageIndex
    dgGruppi.DataBind()
    dgGruppoDiAppartenenza.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppi.DataBind()
    dgGruppoDiAppartenenza.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Dim com As New SqlClient.SqlCommand("Delete From ATC_RelUtenteGruppo Where Id = @Id", con)
    com.Parameters.Add("@Id", SqlDbType.Int)
    Dim LowerBound As Integer = dgGruppoDiAppartenenza.CurrentPageIndex * dgGruppoDiAppartenenza.PageSize
    Dim UpperBound As Integer = IIf(dgGruppoDiAppartenenza.CurrentPageIndex = dgGruppoDiAppartenenza.PageCount - 1, dgGruppoDiAppartenenza.Items.Count - 1, dgGruppoDiAppartenenza.CurrentPageIndex * dgGruppoDiAppartenenza.PageSize + dgGruppoDiAppartenenza.PageSize - 1)
    con.Open()
    For i As Integer = 0 To dgGruppoDiAppartenenza.Items.Count - 1
      If DirectCast(dgGruppoDiAppartenenza.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@Id").Value = dgGruppoDiAppartenenza.DataKeys(i)
        com.ExecuteNonQuery()
      End If
    Next
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppoDiAppartenenza.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    If Me.IsValid Then
      Dim dr As DataRow
      If txtId.Value.Length <= 0 Then
        dr = DsUtenti1.Tables("ATC_Utenti").NewRow
        'Dim com As New SqlClient.SqlCommand("select Max(ID) + 1 From ATC_Utenti", con)
        'con.Open()
        'dr("Id") = com.ExecuteScalar
        'con.Close()
        dr("Id") = -1
        DsUtenti1.Tables("ATC_Utenti").Rows.Add(dr)
        dr("IdResponsabile") = 0
        dr("NrAccessi") = 0
      Else
        dr = DsUtenti1.Tables("ATC_Utenti").Rows.Find(txtId.Value)
      End If
      dr("IdUser") = txtIdUser.Text
      dr("PWD") = txtPassword.Text
      dr("Cognome") = IIf(txtCognome.Text.Length > 0, txtCognome.Text, DBNull.Value)
      dr("Nome") = IIf(txtNome.Text.Length > 0, txtNome.Text, DBNull.Value)
      dr("Email") = IIf(txtEmail.Text.Length > 0, txtEmail.Text, DBNull.Value)
      dr("Abilitato") = IIf(chkAbilitato.Checked, 1, 0)
      dr("TipoUtente") = ddlTipoUtente.SelectedValue
      dr("Flag_Patente") = IIf(chkPatente.Checked, 1, 0)
      daUtente.Update(DsUtenti1)
      txtId.Value = dr("Id")
      dgGruppi.DataBind()
      dgGruppoDiAppartenenza.DataBind()
    End If
  End Sub

  Private Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
    Response.Redirect("wf_utentiNew.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub dgGruppoDiAppartenenza_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgGruppoDiAppartenenza.PageIndexChanged
    pFilterGroupsGrid()
    dgGruppoDiAppartenenza.CurrentPageIndex = e.NewPageIndex
    dgGruppoDiAppartenenza.DataBind()
    dgGruppi.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub cvIdUser_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvIdUser.ServerValidate
    If txtId.Value.Length > 0 Then
      Dim com As New SqlClient.SqlCommand("Select Count(*) From ATC_Utenti Where IdUSer = @IdUSer And Id <> @Id", con)
      com.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = txtIdUser.Text
      com.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Value
      con.Open()
      args.IsValid = com.ExecuteScalar <= 0
      con.Close()
    Else
      args.IsValid = True
    End If
  End Sub

  Private Sub LinkButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
    Response.Redirect("wf_UtentiNew.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub
End Class
