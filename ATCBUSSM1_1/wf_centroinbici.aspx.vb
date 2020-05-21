Imports System.Data.SqlClient
Public Class wf_centroinbici
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daTipoDocumento = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    Me.daParentela = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daCentroinbici = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daAllegati = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.dvAllegati = New System.Data.DataView
    Me.comInsAtt = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
    Me.daNote = New System.Data.SqlClient.SqlDataAdapter
    Me.dvNote = New System.Data.DataView
    Me.conBigl = New System.Data.SqlClient.SqlConnection
    Me.daComuni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daOrigineAbbonamento = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
    Me.daTipoAbbonamento = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
    Me.daDurataAbbonamento = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvAllegati, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvNote, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daTipoDocumento
    '
    Me.daTipoDocumento.DeleteCommand = Me.SqlDeleteCommand1
    Me.daTipoDocumento.InsertCommand = Me.SqlInsertCommand1
    Me.daTipoDocumento.SelectCommand = Me.SqlSelectCommand1
    Me.daTipoDocumento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_TipoDocumento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daTipoDocumento.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.CentroInBici_TipoDocumento WHERE (Id = @Original_Id) AND (Descriz" & _
    "ione = @Original_Descrizione OR @Original_Descrizione IS NULL AND Descrizione IS" & _
    " NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.CentroInBici_TipoDocumento(Descrizione) VALUES (@Descrizione); SE" & _
    "LECT Id, Descrizione FROM dbo.CentroInBici_TipoDocumento WHERE (Id = @@IDENTITY)" & _
    ""
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Descrizione FROM dbo.CentroInBici_TipoDocumento"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.CentroInBici_TipoDocumento SET Descrizione = @Descrizione WHERE (Id = " & _
    "@Original_Id) AND (Descrizione = @Original_Descrizione OR @Original_Descrizione " & _
    "IS NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo.CentroInBici_T" & _
    "ipoDocumento WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daParentela
    '
    Me.daParentela.InsertCommand = Me.SqlInsertCommand2
    Me.daParentela.SelectCommand = Me.SqlSelectCommand2
    Me.daParentela.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_Parentela", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.CentroInBici_Parentela(Descrizione) VALUES (@Descrizione); SELECT" & _
    " Id, Descrizione FROM dbo.CentroInBici_Parentela WHERE (Id = @@IDENTITY)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id, Descrizione FROM dbo.CentroInBici_Parentela"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'daCentroinbici
    '
    Me.daCentroinbici.DeleteCommand = Me.SqlDeleteCommand2
    Me.daCentroinbici.InsertCommand = Me.SqlInsertCommand3
    Me.daCentroinbici.SelectCommand = Me.SqlSelectCommand3
    Me.daCentroinbici.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("DATA", "DATA"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("MINORENNE", "MINORENNE"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("DATA_NASCITA", "DATA_NASCITA"), New System.Data.Common.DataColumnMapping("PARENTELA", "PARENTELA"), New System.Data.Common.DataColumnMapping("COGNOME_PARENTE", "COGNOME_PARENTE"), New System.Data.Common.DataColumnMapping("NOME_PARENTE", "NOME_PARENTE"), New System.Data.Common.DataColumnMapping("RES_VIA", "RES_VIA"), New System.Data.Common.DataColumnMapping("RES_N_CIV", "RES_N_CIV"), New System.Data.Common.DataColumnMapping("RES_CAP", "RES_CAP"), New System.Data.Common.DataColumnMapping("RES_CIT", "RES_CIT"), New System.Data.Common.DataColumnMapping("RES_PROV", "RES_PROV"), New System.Data.Common.DataColumnMapping("RES_VIA_P", "RES_VIA_P"), New System.Data.Common.DataColumnMapping("RES_N_CIV_P", "RES_N_CIV_P"), New System.Data.Common.DataColumnMapping("RES_CAP_P", "RES_CAP_P"), New System.Data.Common.DataColumnMapping("RES_CIT_P", "RES_CIT_P"), New System.Data.Common.DataColumnMapping("RES_PROV_P", "RES_PROV_P"), New System.Data.Common.DataColumnMapping("TEL", "TEL"), New System.Data.Common.DataColumnMapping("CEL", "CEL"), New System.Data.Common.DataColumnMapping("DOM_RES", "DOM_RES"), New System.Data.Common.DataColumnMapping("DOM_VIA", "DOM_VIA"), New System.Data.Common.DataColumnMapping("DOM_N_CIV", "DOM_N_CIV"), New System.Data.Common.DataColumnMapping("DOM_CAP", "DOM_CAP"), New System.Data.Common.DataColumnMapping("DOM_CIT", "DOM_CIT"), New System.Data.Common.DataColumnMapping("DOM_PROV", "DOM_PROV"), New System.Data.Common.DataColumnMapping("DOCUMENTO_TIPO", "DOCUMENTO_TIPO"), New System.Data.Common.DataColumnMapping("DOCUMENTO_NUM", "DOCUMENTO_NUM"), New System.Data.Common.DataColumnMapping("CHIAVE", "CHIAVE"), New System.Data.Common.DataColumnMapping("REGIONE", "REGIONE"), New System.Data.Common.DataColumnMapping("IdUtente", "IdUtente"), New System.Data.Common.DataColumnMapping("Cauzione", "Cauzione"), New System.Data.Common.DataColumnMapping("Studente", "Studente"), New System.Data.Common.DataColumnMapping("Comune", "Comune"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_NUM", "ABBONAMENTO_NUM"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_ORIGINE", "ABBONAMENTO_ORIGINE"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_TIPO", "ABBONAMENTO_TIPO"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_DURATA", "ABBONAMENTO_DURATA"), New System.Data.Common.DataColumnMapping("Pendolare", "Pendolare"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_ALTRO", "ABBONAMENTO_ALTRO"), New System.Data.Common.DataColumnMapping("ABBONAMENTO_TRATTA", "ABBONAMENTO_TRATTA")})})
    Me.daCentroinbici.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.CentroInBici WHERE (ID = @Original_ID) AND (ABBONAMENTO_ALTRO = @" & _
    "Original_ABBONAMENTO_ALTRO OR @Original_ABBONAMENTO_ALTRO IS NULL AND ABBONAMENT" & _
    "O_ALTRO IS NULL) AND (ABBONAMENTO_DURATA = @Original_ABBONAMENTO_DURATA OR @Orig" & _
    "inal_ABBONAMENTO_DURATA IS NULL AND ABBONAMENTO_DURATA IS NULL) AND (ABBONAMENTO" & _
    "_NUM = @Original_ABBONAMENTO_NUM OR @Original_ABBONAMENTO_NUM IS NULL AND ABBONA" & _
    "MENTO_NUM IS NULL) AND (ABBONAMENTO_ORIGINE = @Original_ABBONAMENTO_ORIGINE OR @" & _
    "Original_ABBONAMENTO_ORIGINE IS NULL AND ABBONAMENTO_ORIGINE IS NULL) AND (ABBON" & _
    "AMENTO_TIPO = @Original_ABBONAMENTO_TIPO OR @Original_ABBONAMENTO_TIPO IS NULL A" & _
    "ND ABBONAMENTO_TIPO IS NULL) AND (ABBONAMENTO_TRATTA = @Original_ABBONAMENTO_TRA" & _
    "TTA OR @Original_ABBONAMENTO_TRATTA IS NULL AND ABBONAMENTO_TRATTA IS NULL) AND " & _
    "(CEL = @Original_CEL OR @Original_CEL IS NULL AND CEL IS NULL) AND (CHIAVE = @Or" & _
    "iginal_CHIAVE OR @Original_CHIAVE IS NULL AND CHIAVE IS NULL) AND (COGNOME = @Or" & _
    "iginal_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) AND (COGNOME_PA" & _
    "RENTE = @Original_COGNOME_PARENTE OR @Original_COGNOME_PARENTE IS NULL AND COGNO" & _
    "ME_PARENTE IS NULL) AND (Cauzione = @Original_Cauzione OR @Original_Cauzione IS " & _
    "NULL AND Cauzione IS NULL) AND (Comune = @Original_Comune OR @Original_Comune IS" & _
    " NULL AND Comune IS NULL) AND (DATA = @Original_DATA OR @Original_DATA IS NULL A" & _
    "ND DATA IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA OR @Original_DATA_NA" & _
    "SCITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM = @Original_DOCUMENTO" & _
    "_NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS NULL) AND (DOCUMENT" & _
    "O_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIPO IS NULL AND DOCUME" & _
    "NTO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Original_DOM_CAP IS NULL " & _
    "AND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Original_DOM_CIT IS NU" & _
    "LL AND DOM_CIT IS NULL) AND (DOM_N_CIV = @Original_DOM_N_CIV OR @Original_DOM_N_" & _
    "CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = @Original_DOM_PROV OR @Origin" & _
    "al_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_RES = @Original_DOM_RES) AND " & _
    "(DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA IS NULL AND DOM_VIA IS NULL) A" & _
    "ND (IdUtente = @Original_IdUtente OR @Original_IdUtente IS NULL AND IdUtente IS " & _
    "NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRICOLA IS NULL AND MA" & _
    "TRICOLA IS NULL) AND (MINORENNE = @Original_MINORENNE) AND (NOME = @Original_NOM" & _
    "E OR @Original_NOME IS NULL AND NOME IS NULL) AND (NOME_PARENTE = @Original_NOME" & _
    "_PARENTE OR @Original_NOME_PARENTE IS NULL AND NOME_PARENTE IS NULL) AND (PARENT" & _
    "ELA = @Original_PARENTELA OR @Original_PARENTELA IS NULL AND PARENTELA IS NULL) " & _
    "AND (Pendolare = @Original_Pendolare OR @Original_Pendolare IS NULL AND Pendolar" & _
    "e IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = @Original_RES_CAP OR" & _
    " @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CAP_P = @Original_RES_C" & _
    "AP_P OR @Original_RES_CAP_P IS NULL AND RES_CAP_P IS NULL) AND (RES_CIT = @Origi" & _
    "nal_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL) AND (RES_CIT_P = @" & _
    "Original_RES_CIT_P OR @Original_RES_CIT_P IS NULL AND RES_CIT_P IS NULL) AND (RE" & _
    "S_N_CIV = @Original_RES_N_CIV OR @Original_RES_N_CIV IS NULL AND RES_N_CIV IS NU" & _
    "LL) AND (RES_N_CIV_P = @Original_RES_N_CIV_P OR @Original_RES_N_CIV_P IS NULL AN" & _
    "D RES_N_CIV_P IS NULL) AND (RES_PROV = @Original_RES_PROV OR @Original_RES_PROV " & _
    "IS NULL AND RES_PROV IS NULL) AND (RES_PROV_P = @Original_RES_PROV_P OR @Origina" & _
    "l_RES_PROV_P IS NULL AND RES_PROV_P IS NULL) AND (RES_VIA = @Original_RES_VIA OR" & _
    " @Original_RES_VIA IS NULL AND RES_VIA IS NULL) AND (RES_VIA_P = @Original_RES_V" & _
    "IA_P OR @Original_RES_VIA_P IS NULL AND RES_VIA_P IS NULL) AND (Studente = @Orig" & _
    "inal_Studente OR @Original_Studente IS NULL AND Studente IS NULL) AND (TEL = @Or" & _
    "iginal_TEL OR @Original_TEL IS NULL AND TEL IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_ALTRO", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_ALTRO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_DURATA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_DURATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_ORIGINE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_ORIGINE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_TRATTA", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_TRATTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CHIAVE", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CHIAVE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comune", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comune", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MINORENNE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MINORENNE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTELA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTELA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pendolare", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pendolare", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP_P", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT_P", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV_P", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA_P", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Studente", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Studente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.CentroInBici(ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_" & _
    "NASCITA, PARENTELA, COGNOME_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, " & _
    "RES_CIT, RES_PROV, RES_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_CIT_P, RES_PROV_P, TEL" & _
    ", CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, " & _
    "DOCUMENTO_NUM, CHIAVE, REGIONE, IdUtente, Cauzione, Studente, Comune, ABBONAMENT" & _
    "O_NUM, ABBONAMENTO_ORIGINE, ABBONAMENTO_TIPO, ABBONAMENTO_DURATA, Pendolare, ABB" & _
    "ONAMENTO_ALTRO, ABBONAMENTO_TRATTA) VALUES (@ID, @DATA, @MATRICOLA, @MINORENNE, " & _
    "@COGNOME, @NOME, @DATA_NASCITA, @PARENTELA, @COGNOME_PARENTE, @NOME_PARENTE, @RE" & _
    "S_VIA, @RES_N_CIV, @RES_CAP, @RES_CIT, @RES_PROV, @RES_VIA_P, @RES_N_CIV_P, @RES" & _
    "_CAP_P, @RES_CIT_P, @RES_PROV_P, @TEL, @CEL, @DOM_RES, @DOM_VIA, @DOM_N_CIV, @DO" & _
    "M_CAP, @DOM_CIT, @DOM_PROV, @DOCUMENTO_TIPO, @DOCUMENTO_NUM, @CHIAVE, @REGIONE, " & _
    "@IdUtente, @Cauzione, @Studente, @Comune, @ABBONAMENTO_NUM, @ABBONAMENTO_ORIGINE" & _
    ", @ABBONAMENTO_TIPO, @ABBONAMENTO_DURATA, @Pendolare, @ABBONAMENTO_ALTRO, @ABBON" & _
    "AMENTO_TRATTA); SELECT ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_NASCI" & _
    "TA, PARENTELA, COGNOME_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, RES_C" & _
    "IT, RES_PROV, RES_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_CIT_P, RES_PROV_P, TEL, CEL" & _
    ", DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUM" & _
    "ENTO_NUM, CHIAVE, REGIONE, IdUtente, Cauzione, Studente, Comune, ABBONAMENTO_NUM" & _
    ", ABBONAMENTO_ORIGINE, ABBONAMENTO_TIPO, ABBONAMENTO_DURATA, Pendolare, ABBONAME" & _
    "NTO_ALTRO, ABBONAMENTO_TRATTA FROM dbo.CentroInBici WHERE (ID = @ID)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MINORENNE", System.Data.SqlDbType.Bit, 1, "MINORENNE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTELA", System.Data.SqlDbType.Int, 4, "PARENTELA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "COGNOME_PARENTE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "NOME_PARENTE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA_P", System.Data.SqlDbType.VarChar, 100, "RES_VIA_P"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV_P"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP_P", System.Data.SqlDbType.VarChar, 5, "RES_CAP_P"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT_P", System.Data.SqlDbType.VarChar, 50, "RES_CIT_P"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV_P", System.Data.SqlDbType.VarChar, 2, "RES_PROV_P"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CHIAVE", System.Data.SqlDbType.VarChar, 10, "CHIAVE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Studente", System.Data.SqlDbType.Bit, 1, "Studente"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comune", System.Data.SqlDbType.Bit, 1, "Comune"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "ABBONAMENTO_NUM"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_ORIGINE", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_ORIGINE"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_TIPO", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_TIPO"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_DURATA", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_DURATA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pendolare", System.Data.SqlDbType.Bit, 1, "Pendolare"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_ALTRO", System.Data.SqlDbType.VarChar, 500, "ABBONAMENTO_ALTRO"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_TRATTA", System.Data.SqlDbType.VarChar, 500, "ABBONAMENTO_TRATTA"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_NASCITA, PARENTELA, CO" & _
    "GNOME_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, RES_CIT, RES_PROV, RES" & _
    "_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_CIT_P, RES_PROV_P, TEL, CEL, DOM_RES, DOM_VI" & _
    "A, DOM_N_CIV, DOM_CAP, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CHIAVE," & _
    " REGIONE, IdUtente, Cauzione, Studente, Comune, ABBONAMENTO_NUM, ABBONAMENTO_ORI" & _
    "GINE, ABBONAMENTO_TIPO, ABBONAMENTO_DURATA, Pendolare, ABBONAMENTO_ALTRO, ABBONA" & _
    "MENTO_TRATTA FROM dbo.CentroInBici WHERE (ID = @id)"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.CentroInBici SET ID = @ID, DATA = @DATA, MATRICOLA = @MATRICOLA, MINOR" & _
    "ENNE = @MINORENNE, COGNOME = @COGNOME, NOME = @NOME, DATA_NASCITA = @DATA_NASCIT" & _
    "A, PARENTELA = @PARENTELA, COGNOME_PARENTE = @COGNOME_PARENTE, NOME_PARENTE = @N" & _
    "OME_PARENTE, RES_VIA = @RES_VIA, RES_N_CIV = @RES_N_CIV, RES_CAP = @RES_CAP, RES" & _
    "_CIT = @RES_CIT, RES_PROV = @RES_PROV, RES_VIA_P = @RES_VIA_P, RES_N_CIV_P = @RE" & _
    "S_N_CIV_P, RES_CAP_P = @RES_CAP_P, RES_CIT_P = @RES_CIT_P, RES_PROV_P = @RES_PRO" & _
    "V_P, TEL = @TEL, CEL = @CEL, DOM_RES = @DOM_RES, DOM_VIA = @DOM_VIA, DOM_N_CIV =" & _
    " @DOM_N_CIV, DOM_CAP = @DOM_CAP, DOM_CIT = @DOM_CIT, DOM_PROV = @DOM_PROV, DOCUM" & _
    "ENTO_TIPO = @DOCUMENTO_TIPO, DOCUMENTO_NUM = @DOCUMENTO_NUM, CHIAVE = @CHIAVE, R" & _
    "EGIONE = @REGIONE, IdUtente = @IdUtente, Cauzione = @Cauzione, Studente = @Stude" & _
    "nte, Comune = @Comune, ABBONAMENTO_NUM = @ABBONAMENTO_NUM, ABBONAMENTO_ORIGINE =" & _
    " @ABBONAMENTO_ORIGINE, ABBONAMENTO_TIPO = @ABBONAMENTO_TIPO, ABBONAMENTO_DURATA " & _
    "= @ABBONAMENTO_DURATA, Pendolare = @Pendolare, ABBONAMENTO_ALTRO = @ABBONAMENTO_" & _
    "ALTRO, ABBONAMENTO_TRATTA = @ABBONAMENTO_TRATTA WHERE (ID = @Original_ID) AND (A" & _
    "BBONAMENTO_ALTRO = @Original_ABBONAMENTO_ALTRO OR @Original_ABBONAMENTO_ALTRO IS" & _
    " NULL AND ABBONAMENTO_ALTRO IS NULL) AND (ABBONAMENTO_DURATA = @Original_ABBONAM" & _
    "ENTO_DURATA OR @Original_ABBONAMENTO_DURATA IS NULL AND ABBONAMENTO_DURATA IS NU" & _
    "LL) AND (ABBONAMENTO_NUM = @Original_ABBONAMENTO_NUM OR @Original_ABBONAMENTO_NU" & _
    "M IS NULL AND ABBONAMENTO_NUM IS NULL) AND (ABBONAMENTO_ORIGINE = @Original_ABBO" & _
    "NAMENTO_ORIGINE OR @Original_ABBONAMENTO_ORIGINE IS NULL AND ABBONAMENTO_ORIGINE" & _
    " IS NULL) AND (ABBONAMENTO_TIPO = @Original_ABBONAMENTO_TIPO OR @Original_ABBONA" & _
    "MENTO_TIPO IS NULL AND ABBONAMENTO_TIPO IS NULL) AND (ABBONAMENTO_TRATTA = @Orig" & _
    "inal_ABBONAMENTO_TRATTA OR @Original_ABBONAMENTO_TRATTA IS NULL AND ABBONAMENTO_" & _
    "TRATTA IS NULL) AND (CEL = @Original_CEL OR @Original_CEL IS NULL AND CEL IS NUL" & _
    "L) AND (CHIAVE = @Original_CHIAVE OR @Original_CHIAVE IS NULL AND CHIAVE IS NULL" & _
    ") AND (COGNOME = @Original_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS N" & _
    "ULL) AND (COGNOME_PARENTE = @Original_COGNOME_PARENTE OR @Original_COGNOME_PAREN" & _
    "TE IS NULL AND COGNOME_PARENTE IS NULL) AND (Cauzione = @Original_Cauzione OR @O" & _
    "riginal_Cauzione IS NULL AND Cauzione IS NULL) AND (Comune = @Original_Comune OR" & _
    " @Original_Comune IS NULL AND Comune IS NULL) AND (DATA = @Original_DATA OR @Ori" & _
    "ginal_DATA IS NULL AND DATA IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA " & _
    "OR @Original_DATA_NASCITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM =" & _
    " @Original_DOCUMENTO_NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS" & _
    " NULL) AND (DOCUMENTO_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIP" & _
    "O IS NULL AND DOCUMENTO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Origi" & _
    "nal_DOM_CAP IS NULL AND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Or" & _
    "iginal_DOM_CIT IS NULL AND DOM_CIT IS NULL) AND (DOM_N_CIV = @Original_DOM_N_CIV" & _
    " OR @Original_DOM_N_CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = @Original" & _
    "_DOM_PROV OR @Original_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_RES = @Or" & _
    "iginal_DOM_RES) AND (DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA IS NULL AN" & _
    "D DOM_VIA IS NULL) AND (IdUtente = @Original_IdUtente OR @Original_IdUtente IS N" & _
    "ULL AND IdUtente IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATR" & _
    "ICOLA IS NULL AND MATRICOLA IS NULL) AND (MINORENNE = @Original_MINORENNE) AND (" & _
    "NOME = @Original_NOME OR @Original_NOME IS NULL AND NOME IS NULL) AND (NOME_PARE" & _
    "NTE = @Original_NOME_PARENTE OR @Original_NOME_PARENTE IS NULL AND NOME_PARENTE " & _
    "IS NULL) AND (PARENTELA = @Original_PARENTELA OR @Original_PARENTELA IS NULL AND" & _
    " PARENTELA IS NULL) AND (Pendolare = @Original_Pendolare OR @Original_Pendolare " & _
    "IS NULL AND Pendolare IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = " & _
    "@Original_RES_CAP OR @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CAP" & _
    "_P = @Original_RES_CAP_P OR @Original_RES_CAP_P IS NULL AND RES_CAP_P IS NULL) A" & _
    "ND (RES_CIT = @Original_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL" & _
    ") AND (RES_CIT_P = @Original_RES_CIT_P OR @Original_RES_CIT_P IS NULL AND RES_CI" & _
    "T_P IS NULL) AND (RES_N_CIV = @Original_RES_N_CIV OR @Original_RES_N_CIV IS NULL" & _
    " AND RES_N_CIV IS NULL) AND (RES_N_CIV_P = @Original_RES_N_CIV_P OR @Original_RE" & _
    "S_N_CIV_P IS NULL AND RES_N_CIV_P IS NULL) AND (RES_PROV = @Original_RES_PROV OR" & _
    " @Original_RES_PROV IS NULL AND RES_PROV IS NULL) AND (RES_PROV_P = @Original_RE" & _
    "S_PROV_P OR @Original_RES_PROV_P IS NULL AND RES_PROV_P IS NULL) AND (RES_VIA = " & _
    "@Original_RES_VIA OR @Original_RES_VIA IS NULL AND RES_VIA IS NULL) AND (RES_VIA" & _
    "_P = @Original_RES_VIA_P OR @Original_RES_VIA_P IS NULL AND RES_VIA_P IS NULL) A" & _
    "ND (Studente = @Original_Studente OR @Original_Studente IS NULL AND Studente IS " & _
    "NULL) AND (TEL = @Original_TEL OR @Original_TEL IS NULL AND TEL IS NULL); SELECT" & _
    " ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_NASCITA, PARENTELA, COGNOME" & _
    "_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, RES_CIT, RES_PROV, RES_VIA_" & _
    "P, RES_N_CIV_P, RES_CAP_P, RES_CIT_P, RES_PROV_P, TEL, CEL, DOM_RES, DOM_VIA, DO" & _
    "M_N_CIV, DOM_CAP, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CHIAVE, REGI" & _
    "ONE, IdUtente, Cauzione, Studente, Comune, ABBONAMENTO_NUM, ABBONAMENTO_ORIGINE," & _
    " ABBONAMENTO_TIPO, ABBONAMENTO_DURATA, Pendolare, ABBONAMENTO_ALTRO, ABBONAMENTO" & _
    "_TRATTA FROM dbo.CentroInBici WHERE (ID = @ID)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MINORENNE", System.Data.SqlDbType.Bit, 1, "MINORENNE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTELA", System.Data.SqlDbType.Int, 4, "PARENTELA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "COGNOME_PARENTE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "NOME_PARENTE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA_P", System.Data.SqlDbType.VarChar, 100, "RES_VIA_P"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV_P"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP_P", System.Data.SqlDbType.VarChar, 5, "RES_CAP_P"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT_P", System.Data.SqlDbType.VarChar, 50, "RES_CIT_P"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV_P", System.Data.SqlDbType.VarChar, 2, "RES_PROV_P"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CHIAVE", System.Data.SqlDbType.VarChar, 10, "CHIAVE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Studente", System.Data.SqlDbType.Bit, 1, "Studente"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comune", System.Data.SqlDbType.Bit, 1, "Comune"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "ABBONAMENTO_NUM"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_ORIGINE", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_ORIGINE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_TIPO", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_TIPO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_DURATA", System.Data.SqlDbType.Int, 4, "ABBONAMENTO_DURATA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Pendolare", System.Data.SqlDbType.Bit, 1, "Pendolare"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_ALTRO", System.Data.SqlDbType.VarChar, 500, "ABBONAMENTO_ALTRO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABBONAMENTO_TRATTA", System.Data.SqlDbType.VarChar, 500, "ABBONAMENTO_TRATTA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_ALTRO", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_ALTRO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_DURATA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_DURATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_ORIGINE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_ORIGINE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABBONAMENTO_TRATTA", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABBONAMENTO_TRATTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CHIAVE", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CHIAVE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comune", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comune", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MINORENNE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MINORENNE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTELA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTELA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Pendolare", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pendolare", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP_P", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT_P", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV_P", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA_P", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Studente", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Studente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    '
    'daAllegati
    '
    Me.daAllegati.DeleteCommand = Me.SqlDeleteCommand3
    Me.daAllegati.InsertCommand = Me.SqlInsertCommand4
    Me.daAllegati.SelectCommand = Me.SqlSelectCommand4
    Me.daAllegati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_Allegati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("Extension", "Extension")})})
    Me.daAllegati.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.CentroInBici_Allegati WHERE (Id = @Original_Id) AND (Description " & _
    "= @Original_Description OR @Original_Description IS NULL AND Description IS NULL" & _
    ") AND (Extension = @Original_Extension OR @Original_Extension IS NULL AND Extens" & _
    "ion IS NULL) AND (FileName = @Original_FileName OR @Original_FileName IS NULL AN" & _
    "D FileName IS NULL) AND (IdAnagrafica = @Original_IdAnagrafica OR @Original_IdAn" & _
    "agrafica IS NULL AND IdAnagrafica IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extension", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand4
    '
    Me.SqlInsertCommand4.CommandText = "INSERT INTO dbo.CentroInBici_Allegati(Id, IdAnagrafica, Description, FileName, Ex" & _
    "tension) VALUES (@Id, @IdAnagrafica, @Description, @FileName, @Extension); SELEC" & _
    "T Id, IdAnagrafica, Description, FileName, Extension FROM dbo.CentroInBici_Alleg" & _
    "ati WHERE (Id = @Id)"
    Me.SqlInsertCommand4.Connection = Me.con
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.VarChar, 255, "FileName"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.VarChar, 10, "Extension"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT Id, IdAnagrafica, Description, FileName, Extension FROM dbo.CentroInBici_A" & _
    "llegati WHERE (IdAnagrafica = @Id)"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.CentroInBici_Allegati SET Description = @Description WHERE (Id = @Orig" & _
    "inal_Id) AND (Description = @Original_Description OR @Original_Description IS NU" & _
    "LL AND Description IS NULL) AND (Extension = @Original_Extension OR @Original_Ex" & _
    "tension IS NULL AND Extension IS NULL) AND (FileName = @Original_FileName OR @Or" & _
    "iginal_FileName IS NULL AND FileName IS NULL) AND (IdAnagrafica = @Original_IdAn" & _
    "agrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL); SELECT Id," & _
    " IdAnagrafica, Description, FileName, Extension FROM dbo.CentroInBici_Allegati W" & _
    "HERE (Id = @Id)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extension", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    '
    'dvAllegati
    '
    Me.dvAllegati.Table = Me.DsBiglietterie1.CentroInBici_Allegati
    '
    'comInsAtt
    '
    Me.comInsAtt.CommandText = "INSERT INTO dbo.CentroInBici_Allegati (Id, IdAnagrafica, Description, FileName, E" & _
    "xtension) VALUES (@ID, @IdAnagrafica, @Description, @FileName, @Extension)"
    Me.comInsAtt.Connection = Me.con
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.VarChar, 255, "FileName"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.VarChar, 10, "Extension"))
    '
    'SqlSelectCommand5
    '
    Me.SqlSelectCommand5.CommandText = "SELECT N.Id, N.IdAnagrafica, N.IdTipoNota, T.Tipo, N.Data, N.Nota FROM dbo.Centro" & _
    "InBici_Note N INNER JOIN dbo.CentroInBici_TipoNota T ON N.IdTipoNota = T.IdTipoN" & _
    "ota WHERE (N.IdAnagrafica = @IdAnagrafica)"
    Me.SqlSelectCommand5.Connection = Me.con
    Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    '
    'SqlInsertCommand5
    '
    Me.SqlInsertCommand5.CommandText = "INSERT INTO dbo.CentroInBici_Note(Id, IdAnagrafica, IdTipoNota, Data, Nota) VALUE" & _
    "S (@Id, @IdAnagrafica, @IdTipoNota, @Data, @Nota); SELECT Id, IdAnagrafica, IdTi" & _
    "poNota, Data, Nota FROM dbo.CentroInBici_Note WHERE (Id = @Id)"
    Me.SqlInsertCommand5.Connection = Me.con
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, "IdTipoNota"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    '
    'SqlUpdateCommand4
    '
    Me.SqlUpdateCommand4.CommandText = "UPDATE dbo.CentroInBici_Note SET Id = @Id, IdAnagrafica = @IdAnagrafica, IdTipoNo" & _
    "ta = @IdTipoNota, Data = @Data, Nota = @Nota WHERE (Id = @Original_Id) AND (Data" & _
    " = @Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica " & _
    "= @Original_IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS N" & _
    "ULL) AND (IdTipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND " & _
    "IdTipoNota IS NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Not" & _
    "a IS NULL); SELECT Id, IdAnagrafica, IdTipoNota, Data, Nota FROM dbo.CentroInBic" & _
    "i_Note WHERE (Id = @Id)"
    Me.SqlUpdateCommand4.Connection = Me.con
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, "IdTipoNota"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlDeleteCommand4
    '
    Me.SqlDeleteCommand4.CommandText = "DELETE FROM dbo.CentroInBici_Note WHERE (Id = @Original_Id) AND (Data = @Original" & _
    "_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica = @Original_" & _
    "IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL) AND (Id" & _
    "TipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND IdTipoNota I" & _
    "S NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL)"
    Me.SqlDeleteCommand4.Connection = Me.con
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'daNote
    '
    Me.daNote.DeleteCommand = Me.SqlDeleteCommand4
    Me.daNote.InsertCommand = Me.SqlInsertCommand5
    Me.daNote.SelectCommand = Me.SqlSelectCommand5
    Me.daNote.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_Note", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Nota", "Nota")})})
    Me.daNote.UpdateCommand = Me.SqlUpdateCommand4
    '
    'dvNote
    '
    Me.dvNote.Table = Me.DsBiglietterie1.CentroInBici_Note
    '
    'conBigl
    '
    Me.conBigl.ConnectionString = CType(configurationAppSettings.GetValue("conBigl.ConnectionString", GetType(System.String)), String)
    '
    'daComuni
    '
    Me.daComuni.InsertCommand = Me.SqlCommand1
    Me.daComuni.SelectCommand = Me.SqlCommand2
    Me.daComuni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COMUNIPROV", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CMISTA", "CMISTA"), New System.Data.Common.DataColumnMapping("CMCOMU", "CMCOMU"), New System.Data.Common.DataColumnMapping("CMPROV", "CMPROV"), New System.Data.Common.DataColumnMapping("CMCAPO", "CMCAPO"), New System.Data.Common.DataColumnMapping("CMBELF", "CMBELF"), New System.Data.Common.DataColumnMapping("NAZIONE", "NAZIONE"), New System.Data.Common.DataColumnMapping("CMORD", "CMORD"), New System.Data.Common.DataColumnMapping("UpdateDate", "UpdateDate"), New System.Data.Common.DataColumnMapping("DeleteDate", "DeleteDate")})})
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "INSERT INTO dbo.COMUNIPROV(CMISTA, CMCOMU, CMPROV, CMCAPO, CMBELF, NAZIONE, CMORD" & _
    ", UpdateDate, DeleteDate) VALUES (@CMISTA, @CMCOMU, @CMPROV, @CMCAPO, @CMBELF, @" & _
    "NAZIONE, @CMORD, @UpdateDate, @DeleteDate); SELECT CMISTA, CMCOMU, CMPROV, CMCAP" & _
    "O, CMBELF, NAZIONE, CMORD, UpdateDate, DeleteDate FROM dbo.COMUNIPROV"
    Me.SqlCommand1.Connection = Me.conBigl
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMISTA", System.Data.SqlDbType.VarChar, 6, "CMISTA"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMCOMU", System.Data.SqlDbType.VarChar, 65, "CMCOMU"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMPROV", System.Data.SqlDbType.VarChar, 2, "CMPROV"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMCAPO", System.Data.SqlDbType.VarChar, 5, "CMCAPO"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMBELF", System.Data.SqlDbType.VarChar, 4, "CMBELF"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NAZIONE", System.Data.SqlDbType.VarChar, 4, "NAZIONE"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CMORD", System.Data.SqlDbType.SmallInt, 2, "CMORD"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UpdateDate", System.Data.SqlDbType.DateTime, 8, "UpdateDate"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeleteDate", System.Data.SqlDbType.DateTime, 8, "DeleteDate"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "SELECT CMISTA, CMCOMU, CMPROV, CMCAPO, CMBELF, NAZIONE, CMORD, UpdateDate, Delete" & _
    "Date FROM dbo.COMUNIPROV ORDER BY CMCOMU"
    Me.SqlCommand2.Connection = Me.conBigl
    '
    'daOrigineAbbonamento
    '
    Me.daOrigineAbbonamento.DeleteCommand = Me.SqlDeleteCommand5
    Me.daOrigineAbbonamento.InsertCommand = Me.SqlInsertCommand6
    Me.daOrigineAbbonamento.SelectCommand = Me.SqlSelectCommand6
    Me.daOrigineAbbonamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_OrigineAbbonamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daOrigineAbbonamento.UpdateCommand = Me.SqlUpdateCommand5
    '
    'SqlDeleteCommand5
    '
    Me.SqlDeleteCommand5.CommandText = "DELETE FROM dbo.CentroInBici_OrigineAbbonamento WHERE (Id = @Original_Id) AND (De" & _
    "scrizione = @Original_Descrizione OR @Original_Descrizione IS NULL AND Descrizio" & _
    "ne IS NULL)"
    Me.SqlDeleteCommand5.Connection = Me.con
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand6
    '
    Me.SqlInsertCommand6.CommandText = "INSERT INTO dbo.CentroInBici_OrigineAbbonamento(Id, Descrizione) VALUES (@Id, @De" & _
    "scrizione); SELECT Id, Descrizione FROM dbo.CentroInBici_OrigineAbbonamento WHER" & _
    "E (Id = @Id)"
    Me.SqlInsertCommand6.Connection = Me.con
    Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand6
    '
    Me.SqlSelectCommand6.CommandText = "SELECT Id, Descrizione FROM dbo.CentroInBici_OrigineAbbonamento"
    Me.SqlSelectCommand6.Connection = Me.con
    '
    'SqlUpdateCommand5
    '
    Me.SqlUpdateCommand5.CommandText = "UPDATE dbo.CentroInBici_OrigineAbbonamento SET Id = @Id, Descrizione = @Descrizio" & _
    "ne WHERE (Id = @Original_Id) AND (Descrizione = @Original_Descrizione OR @Origin" & _
    "al_Descrizione IS NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo" & _
    ".CentroInBici_OrigineAbbonamento WHERE (Id = @Id)"
    Me.SqlUpdateCommand5.Connection = Me.con
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'daTipoAbbonamento
    '
    Me.daTipoAbbonamento.DeleteCommand = Me.SqlDeleteCommand6
    Me.daTipoAbbonamento.InsertCommand = Me.SqlInsertCommand7
    Me.daTipoAbbonamento.SelectCommand = Me.SqlSelectCommand7
    Me.daTipoAbbonamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_TipoAbbonamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daTipoAbbonamento.UpdateCommand = Me.SqlUpdateCommand6
    '
    'SqlDeleteCommand6
    '
    Me.SqlDeleteCommand6.CommandText = "DELETE FROM dbo.CentroInBici_TipoAbbonamento WHERE (Id = @Original_Id) AND (Descr" & _
    "izione = @Original_Descrizione OR @Original_Descrizione IS NULL AND Descrizione " & _
    "IS NULL)"
    Me.SqlDeleteCommand6.Connection = Me.con
    Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand7
    '
    Me.SqlInsertCommand7.CommandText = "INSERT INTO dbo.CentroInBici_TipoAbbonamento(Id, Descrizione) VALUES (@Id, @Descr" & _
    "izione); SELECT Id, Descrizione FROM dbo.CentroInBici_TipoAbbonamento WHERE (Id " & _
    "= @Id)"
    Me.SqlInsertCommand7.Connection = Me.con
    Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand7
    '
    Me.SqlSelectCommand7.CommandText = "SELECT Id, Descrizione FROM dbo.CentroInBici_TipoAbbonamento"
    Me.SqlSelectCommand7.Connection = Me.con
    '
    'SqlUpdateCommand6
    '
    Me.SqlUpdateCommand6.CommandText = "UPDATE dbo.CentroInBici_TipoAbbonamento SET Id = @Id, Descrizione = @Descrizione " & _
    "WHERE (Id = @Original_Id) AND (Descrizione = @Original_Descrizione OR @Original_" & _
    "Descrizione IS NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo.Ce" & _
    "ntroInBici_TipoAbbonamento WHERE (Id = @Id)"
    Me.SqlUpdateCommand6.Connection = Me.con
    Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'daDurataAbbonamento
    '
    Me.daDurataAbbonamento.DeleteCommand = Me.SqlDeleteCommand7
    Me.daDurataAbbonamento.InsertCommand = Me.SqlInsertCommand8
    Me.daDurataAbbonamento.SelectCommand = Me.SqlSelectCommand8
    Me.daDurataAbbonamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_DurataAbbonamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daDurataAbbonamento.UpdateCommand = Me.SqlUpdateCommand7
    '
    'SqlDeleteCommand7
    '
    Me.SqlDeleteCommand7.CommandText = "DELETE FROM dbo.CentroInBici_DurataAbbonamento WHERE (Id = @Original_Id) AND (Des" & _
    "crizione = @Original_Descrizione OR @Original_Descrizione IS NULL AND Descrizion" & _
    "e IS NULL)"
    Me.SqlDeleteCommand7.Connection = Me.con
    Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand8
    '
    Me.SqlInsertCommand8.CommandText = "INSERT INTO dbo.CentroInBici_DurataAbbonamento(Id, Descrizione) VALUES (@Id, @Des" & _
    "crizione); SELECT Id, Descrizione FROM dbo.CentroInBici_DurataAbbonamento WHERE " & _
    "(Id = @Id)"
    Me.SqlInsertCommand8.Connection = Me.con
    Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    '
    'SqlSelectCommand8
    '
    Me.SqlSelectCommand8.CommandText = "SELECT Id, Descrizione FROM dbo.CentroInBici_DurataAbbonamento"
    Me.SqlSelectCommand8.Connection = Me.con
    '
    'SqlUpdateCommand7
    '
    Me.SqlUpdateCommand7.CommandText = "UPDATE dbo.CentroInBici_DurataAbbonamento SET Id = @Id, Descrizione = @Descrizion" & _
    "e WHERE (Id = @Original_Id) AND (Descrizione = @Original_Descrizione OR @Origina" & _
    "l_Descrizione IS NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo." & _
    "CentroInBici_DurataAbbonamento WHERE (Id = @Id)"
    Me.SqlUpdateCommand7.Connection = Me.con
    Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvAllegati, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvNote, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents lblNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataNascita As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblResidenzaVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtCellulare As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCellulare As System.Web.UI.WebControls.Label
  Protected WithEvents txtFisso As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblFisso As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDomicilioProvincia As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDomicilioProvincia As System.Web.UI.WebControls.Label
  Protected WithEvents lblDomicilioComune As System.Web.UI.WebControls.Label
  Protected WithEvents txtDomicilioCAP As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDomicilioCAP As System.Web.UI.WebControls.Label
  Protected WithEvents txtDomicilioCivico As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDomicilioCivico As System.Web.UI.WebControls.Label
  Protected WithEvents txtDomicilioVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDomicilioVia As System.Web.UI.WebControls.Label
  Protected WithEvents lblParenteParentela As System.Web.UI.WebControls.Label
  Protected WithEvents ddlParenteParentela As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblParenteNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtParenteNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblParenteCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtParenteCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtParenteProvincia As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblParenteProvincia As System.Web.UI.WebControls.Label
  Protected WithEvents lblParenteComune As System.Web.UI.WebControls.Label
  Protected WithEvents txtParenteCAP As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblParenteCAP As System.Web.UI.WebControls.Label
  Protected WithEvents txtParenteCivico As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblParenteCivico As System.Web.UI.WebControls.Label
  Protected WithEvents txtParenteVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblParenteVia As System.Web.UI.WebControls.Label
  Protected WithEvents lblChiave As System.Web.UI.WebControls.Label
  Protected WithEvents txtChiave As System.Web.UI.WebControls.TextBox
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvChiave As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvDataNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvDataNascita As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents btnSalva As System.Web.UI.WebControls.Button
  Protected WithEvents lnkBack As System.Web.UI.WebControls.LinkButton
  Protected WithEvents btnSalva2 As System.Web.UI.WebControls.Button
  Protected WithEvents lnkBack2 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents lblTipoDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents lblNumeroDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents txtNumeroDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlTipoDocumento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents rfvVia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvCivico As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvCAP As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvComune As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvProvincia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvMinorenne As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvDomicilio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents rfvTipoDocumento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvNumeroDocumento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvDomicilioVia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvDomicilioCivico As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvDomicilioCAP As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParentela As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteVia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteCivico As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteCAP As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteComune As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvParenteProvincia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblResidenzaCivico As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaCivico As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblResidenzaCap As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaCAP As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblResidenzaComune As System.Web.UI.WebControls.Label
  Protected WithEvents lblResidenzaProvincia As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaProvincia As System.Web.UI.WebControls.TextBox
  Protected WithEvents daTipoDocumento As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents daParentela As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvChiaveGiaAssegnata As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents txtID As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents daCentroinbici As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents lblFileDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents fileDocumento As System.Web.UI.HtmlControls.HtmlInputFile
  Protected WithEvents daAllegati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dgAllegati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents dvAllegati As System.Data.DataView
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents btnSalva3 As System.Web.UI.WebControls.Button
  Protected WithEvents lnkBack3 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents comInsAtt As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgNote As System.Web.UI.WebControls.DataGrid
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daNote As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dvNote As System.Data.DataView
  Protected WithEvents revChiave As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents conBigl As System.Data.SqlClient.SqlConnection
  Protected WithEvents daComuni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lkStampa As System.Web.UI.HtmlControls.HtmlAnchor
  Protected WithEvents txtCauzione As System.Web.UI.WebControls.TextBox
  Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents LblCauzioen As System.Web.UI.WebControls.Label
  Protected WithEvents LblOperatore As System.Web.UI.WebControls.Label
  Protected WithEvents TxtIdUtente As System.Web.UI.WebControls.TextBox
  Protected WithEvents lkStampa2 As System.Web.UI.HtmlControls.HtmlAnchor
  Protected WithEvents txtResidenzaComune As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtDomicilioComune As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtParenteComune As System.Web.UI.WebControls.TextBox
  Protected WithEvents ChkStudente As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkComune As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkPendolare As System.Web.UI.WebControls.CheckBox
  Protected WithEvents daOrigineAbbonamento As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daTipoAbbonamento As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daDurataAbbonamento As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents LblOrigine As System.Web.UI.WebControls.Label
  Protected WithEvents LblTipoAbb As System.Web.UI.WebControls.Label
  Protected WithEvents ddlTipoAbbonamento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents LblNumAbbonamento As System.Web.UI.WebControls.Label
  Protected WithEvents txtNumeroAbbonamento As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlOrigineAbbonamento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents LblDurata As System.Web.UI.WebControls.Label
  Protected WithEvents Requiredfieldvalidator5 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents ddldurata As System.Web.UI.WebControls.DropDownList
  Protected WithEvents RfvNAbbonamento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RfvddlTipoDocumento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtTratta As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblTratta As System.Web.UI.WebControls.Label
  Protected WithEvents RfvTratta As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents TxtAltro As System.Web.UI.WebControls.TextBox
  Protected WithEvents RfvddlOrigineAbbonamento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RfvddlTipoAbbonamento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents Rfvddldurata As System.Web.UI.WebControls.RequiredFieldValidator


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
    If CStr("" & Request("Id")).Length > 0 Then txtID.Value = Request("Id")
    If Not IsPostBack Then
      daTipoDocumento.Fill(DsBiglietterie1)
      daParentela.Fill(DsBiglietterie1)
      daOrigineAbbonamento.Fill(DsBiglietterie1)
      daTipoAbbonamento.Fill(DsBiglietterie1)
      daDurataAbbonamento.Fill(DsBiglietterie1)
      daTipoAbbonamento.Fill(DsBiglietterie1)
      'daComuni.Fill(DsBiglietterie1)
    End If
    If txtID.Value.Length <= 0 Then
      lkStampa.Visible = False
      lkStampa2.Visible = False
      If Not IsPostBack Then
        Dim dr As DataRow = DsBiglietterie1.Tables("centroinbici").NewRow
        dr("ID") = -1
        dr("Minorenne") = 0
        dr("DOM_RES") = 0
        dr("Regione") = 0
        dr("Res_CAP") = "40100"
        dr("Res_Cit") = "BOLOGNA"
        dr("Res_Prov") = "BO"
        dr("Res_CAP_P") = "40100"
        dr("Res_Cit_P") = "BOLOGNA"
        dr("Res_Prov_P") = "BO"
        dr("Dom_CAP") = "40100"
        dr("Dom_Cit") = "BOLOGNA"
        dr("Dom_Prov") = "BO"
        dr("Cauzione") = 10
        dr("Studente") = 0
        dr("Comune") = 0
        dr("Pendolare") = 0
        dr("IdUtente") = DirectCast(Session("User"), Utente).ID
        DsBiglietterie1.Tables("centroinbici").Rows.Add(dr)
      End If
    Else
      lkStampa.Visible = True
      lkStampa2.Visible = True
      daAllegati.SelectCommand.Parameters("@ID").Value = txtID.Value
      daAllegati.Fill(DsBiglietterie1)
      daCentroinbici.SelectCommand.Parameters("@ID").Value = txtID.Value
      daCentroinbici.Fill(DsBiglietterie1)
    End If
    If Not IsPostBack Then
      Page.DataBind()
      If txtID.Value.Length > 0 Then
        If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("Parentela") Is DBNull.Value Then
          If DsBiglietterie1.Tables("centroinbici").Rows(0)("Parentela") <> 0 Then ddlParenteParentela.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("Parentela")
        End If
        If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("Documento_Tipo") Is DBNull.Value Then
          If DsBiglietterie1.Tables("centroinbici").Rows(0)("Documento_Tipo") <> 0 Then ddlTipoDocumento.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("Documento_Tipo")
        End If

        If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_ORIGINE") Is DBNull.Value Then
          If DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_ORIGINE") <> 0 Then ddlOrigineAbbonamento.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_ORIGINE")
        End If
        If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_TIPO") Is DBNull.Value Then
          If DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_TIPO") <> 0 Then ddlTipoAbbonamento.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_TIPO")
        End If
        If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_DURATA") Is DBNull.Value Then
          If DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_DURATA") <> 0 Then ddldurata.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("ABBONAMENTO_DURATA")
        End If
        'If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT") Is DBNull.Value Then
        '  If DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT") <> 0 Then ddlResidenzaComune.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT")
        'End If
        'If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("DOM_ID_CIT") Is DBNull.Value Then
        '  If DsBiglietterie1.Tables("centroinbici").Rows(0)("DOM_ID_CIT") <> 0 Then ddlDomicilioComune.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("DOM_ID_CIT")
        'End If
        'If Not DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT_P") Is DBNull.Value Then
        '  If DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT_P") <> 0 Then ddlParenteComune.SelectedValue = DsBiglietterie1.Tables("centroinbici").Rows(0)("RES_ID_CIT_P")
        'End If
      Else
        ' ddlResidenzaComune.SelectedValue = "037006"

      End If
      'ddlDomicilioComune.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      'ddlParenteComune.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      'ddlResidenzaComune.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      ddlParenteParentela.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      ddlTipoDocumento.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      ddlOrigineAbbonamento.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      ddlTipoAbbonamento.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
      ddldurata.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
    End If
    'RitornaOperatore()
  End Sub

  'Private Sub RitornaOperatore()
  '  Dim cnn As SqlConnection
  '  Dim cmd As SqlCommand
  '  Dim dr As SqlDataReader
  '  Dim strSql As String
  '  Dim Operatore As String
  '  strSql = "SELECT isnull(Cognome,'') as Cognome, Isnull(Nome,'') as Nome FROM ATC_Utenti WHERE(ID = " & CInt(TxtIdUtente.Text.Trim) & ")"
  '  cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
  '  Try
  '    cnn.Open()
  '  Catch ex As Exception
  '    cnn.Dispose()
  '    Throw New Exception("Impossibile stabilire una connessione ai dati.")
  '    Exit Sub
  '  End Try

  '  Try
  '    cmd = New SqlCommand(strSql, cnn)
  '    cmd.CommandType = CommandType.Text
  '    cmd.CommandTimeout = 15
  '  Catch ex As Exception
  '    cnn.Close()
  '    cnn.Dispose()
  '    Throw New Exception("Errore di creazione comando SQL")
  '  End Try
  '  Try
  '    dr = cmd.ExecuteReader()
  '    If dr.HasRows Then
  '      dr.Read()
  '      Operatore = dr("Cognome") & " " & dr("Nome")
  '    End If
  '    dr.Close()
  '  Catch ex As Exception
  '    Throw New Exception("Errore di lettura dati")
  '  Finally
  '    dr.Close()
  '  End Try
  '  LblOperatore.Text = "Operatore emittente: " & Operatore

  'End Sub


  Private Sub cvMinorenne_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvMinorenne.ServerValidate
    If IsDate(txtDataNascita.Text) Then
      args.IsValid = Now.Date.AddYears(-18) >= txtDataNascita.Text
    Else
      args.IsValid = True
    End If
    'FT - !!! - Attivo o disattivo i campi condizionati
    rfvParentela.Enabled = Not args.IsValid
    If rfvParentela.Enabled Then rfvParentela.Validate()
    rfvParenteNome.Enabled = Not args.IsValid
    If rfvParenteNome.Enabled Then rfvParenteNome.Validate()
    rfvParenteCognome.Enabled = Not args.IsValid
    If rfvParenteCognome.Enabled Then rfvParenteCognome.Validate()
    rfvParenteVia.Enabled = Not args.IsValid
    If rfvParenteVia.Enabled Then rfvParenteVia.Validate()
    rfvParenteCivico.Enabled = Not args.IsValid
    If rfvParenteCivico.Enabled Then rfvParenteCivico.Validate()
    rfvParenteCAP.Enabled = Not args.IsValid
    If rfvParenteCAP.Enabled Then rfvParenteCAP.Validate()
    rfvParenteComune.Enabled = Not args.IsValid
    If rfvParenteComune.Enabled Then rfvParenteComune.Validate()
    rfvParenteProvincia.Enabled = Not args.IsValid
    If rfvParenteProvincia.Enabled Then rfvParenteProvincia.Validate()
    args.IsValid = Me.IsValid

  End Sub

  Private Sub btnSalva2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva2.Click
    If Me.IsValid Then
      pSave()
    End If
  End Sub

  Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
    If Me.IsValid Then
      pSave()
    End If
  End Sub

  Private Sub cvDomicilio_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvDomicilio.ServerValidate

    If ChkPendolare.Checked Then
      args.IsValid = True
      RfvNAbbonamento.Enabled = True
      RfvNAbbonamento.Validate()
      RfvddlOrigineAbbonamento.Enabled = True
      RfvddlOrigineAbbonamento.Validate()
      RfvddlTipoAbbonamento.Enabled = True
      RfvddlTipoAbbonamento.Validate()
      Rfvddldurata.Enabled = True
      Rfvddldurata.Validate()
      RfvTratta.Enabled = True
      RfvTratta.Validate()
      args.IsValid = Me.IsValid
    Else


      If ChkStudente.Checked Or ChkComune.Checked Then
        args.IsValid = True
      Else
        args.IsValid = txtResidenzaProvincia.Text.ToUpper.Trim = "BO"
        rfvDomicilioVia.Enabled = Not args.IsValid
        If rfvDomicilioVia.Enabled Then rfvDomicilioVia.Validate()
        rfvDomicilioCivico.Enabled = Not args.IsValid
        If rfvDomicilioCivico.Enabled Then rfvDomicilioCivico.Validate()
        rfvDomicilioCAP.Enabled = Not args.IsValid
        If rfvDomicilioCAP.Enabled Then rfvDomicilioCAP.Validate()
        args.IsValid = Me.IsValid
      End If
    End If
  End Sub

  Private Sub cvChiaveGiaAssegnata_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvChiaveGiaAssegnata.ServerValidate
    'Bruna controllo sull'esistenza della chiave da ripensare
    'Dim com As SqlClient.SqlCommand
    'If txtID.Value.Length > 0 Then
    '  com = New SqlClient.SqlCommand("Select Count(*) From CentroInBici Where Chiave = @Chiave And Id <> @Id	", con)
    '  com.Parameters.Add("@Id", SqlDbType.Int).Value = txtID.Value
    'Else
    '  com = New SqlClient.SqlCommand("Select Count(*) From CentroInBici Where Chiave = @Chiave", con)
    'End If
    'com.Parameters.Add("@Chiave", SqlDbType.VarChar).Value = txtChiave.Text.Trim
    'con.Open()
    'args.IsValid = com.ExecuteScalar <= 0
    'con.Close()

    args.IsValid = True

  End Sub

  Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack.Click
    Response.Redirect("wf_cercacentroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
  End Sub

  Private Sub lnkBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack2.Click
    Response.Redirect("wf_cercacentroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
  End Sub

  Private Sub btnSalva3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva3.Click
    'FT - !!! - Salvataggio allegato
    Dim f As HttpPostedFile = fileDocumento.PostedFile()
    If f.FileName.Length > 0 Then
      'Salva estensione
      comInsAtt.Parameters("@ID").Value = Guid.NewGuid
      comInsAtt.Parameters("@IdAnagrafica").Value = txtID.Value
      comInsAtt.Parameters("@Description").Value = DBNull.Value
      comInsAtt.Parameters("@FileName").Value = f.FileName.Substring(f.FileName.LastIndexOf("\") + 1, f.FileName.LastIndexOf(".") - f.FileName.LastIndexOf("\") - 1)
      comInsAtt.Parameters("@Extension").Value = f.FileName.Substring(f.FileName.LastIndexOf(".") + 1)
      con.Open()
      comInsAtt.ExecuteNonQuery()
      con.Close()
      'Salva file
      f.SaveAs(Server.MapPath("Attachments") & "\" & DirectCast(comInsAtt.Parameters("@ID").Value, Guid).ToString & "." & comInsAtt.Parameters("@Extension").Value)
      DsBiglietterie1.Tables("Centroinbici_Allegati").Clear()
      daAllegati.SelectCommand.Parameters("@ID").Value = txtID.Value
      daAllegati.Fill(DsBiglietterie1)
      dgAllegati.DataBind()
    End If
  End Sub

  Private Sub lnkBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack3.Click
    Response.Redirect("wf_cercacentroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
  End Sub

  Private Sub dgAllegati_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAllegati.EditCommand
    dgAllegati.EditItemIndex = e.Item.ItemIndex
    dgAllegati.DataBind()
  End Sub

  Private Sub dgAllegati_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAllegati.CancelCommand
    dgAllegati.EditItemIndex = -1
    dgAllegati.DataBind()

  End Sub

  Private Sub dgAllegati_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgAllegati.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then
      DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi eliminare questo allegato?');")
    End If
  End Sub

  Private Sub dgAllegati_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAllegati.DeleteCommand
    DsBiglietterie1.Tables("CentroInBici_Allegati").Rows.Find(dgAllegati.DataKeys(e.Item.ItemIndex)).Delete()
    daAllegati.Update(DsBiglietterie1)
    DsBiglietterie1.Tables("Centroinbici_Allegati").Clear()
    daAllegati.SelectCommand.Parameters("@ID").Value = txtID.Value
    daAllegati.Fill(DsBiglietterie1)
    dgAllegati_CancelCommand(source, e)
  End Sub

  Private Sub dgAllegati_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAllegati.UpdateCommand
    Dim dr As DataRow = DsBiglietterie1.Tables("Centroinbici_Allegati").Rows.Find(dgAllegati.DataKeys(e.Item.ItemIndex))
    dr("Description") = DirectCast(e.Item.FindControl("txtDescription"), TextBox).Text
    daAllegati.Update(DsBiglietterie1)
    dgAllegati_CancelCommand(source, e)
  End Sub

  Private Sub pSave()
    Dim dr As DataRow
    If txtID.Value.Length <= 0 Then
      dr = DsBiglietterie1.Tables("CentroInBici").NewRow
      Dim comSelID As New SqlClient.SqlCommand("Select Max(id) + 1 From CentroInBici", con)
      con.Open()
      txtID.Value = comSelID.ExecuteScalar
      con.Close()
      dr("ID") = txtID.Value
      dr("Minorenne") = 0
      dr("DOM_RES") = 0
      dr("Regione") = 0
      DsBiglietterie1.Tables("CentroInBici").Rows.Add(dr)
    Else
      dr = DsBiglietterie1.Tables("CentroInBici").Rows.Find(txtID.Value)
    End If
    dr("Cognome") = IIf(txtCognome.Text.Trim.Length > 0, txtCognome.Text.Trim.ToUpper, DBNull.Value)
    dr("Nome") = IIf(txtNome.Text.Trim.Length > 0, txtNome.Text.ToUpper, DBNull.Value)
    dr("Matricola") = DirectCast(Session("User"), Utente).IDUser
    dr("Data_Nascita") = IIf(txtDataNascita.Text.Trim.Length > 0, txtDataNascita.Text.Trim.ToUpper, DBNull.Value)
    dr("Minorenne") = Now.Date.AddYears(-18) < txtDataNascita.Text
    dr("Parentela") = IIf(ddlParenteParentela.SelectedValue.Length > 0, ddlParenteParentela.SelectedValue, DBNull.Value)
    dr("Cognome_Parente") = IIf(txtParenteCognome.Text.Trim.Length > 0, txtParenteCognome.Text.Trim, DBNull.Value)
    dr("Nome_Parente") = IIf(txtParenteNome.Text.Trim.Length > 0, txtParenteNome.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Via") = IIf(txtResidenzaVia.Text.Trim.Length > 0, txtResidenzaVia.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_N_Civ") = IIf(txtResidenzaCivico.Text.Trim.Length > 0, txtResidenzaCivico.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Cap") = IIf(txtResidenzaCAP.Text.Trim.Length > 0, txtResidenzaCAP.Text.Trim.ToUpper, DBNull.Value)
    'dr("Res_ID_Cit") = IIf(ddlResidenzaComune.SelectedValue <> "", ddlResidenzaComune.SelectedValue, DBNull.Value)
    'If ddlResidenzaComune.SelectedValue <> "" Then
    '  dr("Res_Cit") = ddlResidenzaComune.SelectedItem.Text
    'End If
    dr("Res_Cit") = IIf(txtResidenzaComune.Text.Trim.Length > 0, txtResidenzaComune.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Prov") = IIf(txtResidenzaProvincia.Text.Trim.Length > 0, txtResidenzaProvincia.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Via_P") = IIf(txtParenteVia.Text.Trim.Length > 0, txtParenteVia.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_N_Civ_P") = IIf(txtParenteCivico.Text.Trim.Length > 0, txtParenteCivico.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Cap_P") = IIf(txtParenteCAP.Text.Trim.Length > 0, txtParenteCAP.Text.Trim.ToUpper, DBNull.Value)
    'dr("Res_ID_Cit_P") = IIf(ddlParenteComune.SelectedValue <> "", ddlParenteComune.SelectedValue, DBNull.Value)
    'If ddlParenteComune.SelectedValue <> "" Then
    '  dr("Res_Cit_P") = ddlParenteComune.SelectedItem.Text
    'End If
    dr("Res_Cit_P") = IIf(TxtParenteComune.Text.Trim.Length > 0, TxtParenteComune.Text.Trim.ToUpper, DBNull.Value)

    dr("Res_Prov_P") = IIf(txtParenteProvincia.Text.Trim.Length > 0, txtParenteProvincia.Text.Trim.ToUpper, DBNull.Value)
    dr("Tel") = IIf(txtFisso.Text.Trim.Length > 0, txtFisso.Text.Trim.ToUpper, DBNull.Value)
    dr("Cel") = IIf(txtCellulare.Text.Trim.Length > 0, txtCellulare.Text.Trim.ToUpper, DBNull.Value)
    dr("Dom_Via") = IIf(txtDomicilioVia.Text.Trim.Length > 0, txtDomicilioVia.Text.Trim.ToUpper, DBNull.Value)
    dr("Dom_N_Civ") = IIf(txtDomicilioCivico.Text.Trim.Length > 0, txtDomicilioCivico.Text.Trim.ToUpper, DBNull.Value)
    dr("Dom_Cap") = IIf(txtDomicilioCAP.Text.Trim.Length > 0, txtDomicilioCAP.Text.Trim.ToUpper, DBNull.Value)
    'dr("Dom_ID_Cit") = IIf(ddlDomicilioComune.SelectedValue <> "", ddlDomicilioComune.SelectedValue, DBNull.Value)
    'If ddlDomicilioComune.SelectedValue <> "" Then
    '  dr("Dom_Cit") = ddlDomicilioComune.SelectedItem.Text
    'End If
    dr("Dom_Cit") = IIf(TxtDomicilioComune.Text.Trim.Length > 0, TxtDomicilioComune.Text.Trim.ToUpper, DBNull.Value)
    dr("Dom_Prov") = IIf(txtDomicilioProvincia.Text.Trim.Length > 0, txtDomicilioProvincia.Text.Trim.ToUpper, DBNull.Value)
    dr("Documento_Tipo") = IIf(ddlTipoDocumento.SelectedValue.Length > 0, ddlTipoDocumento.SelectedValue, DBNull.Value)
    dr("Documento_Num") = IIf(txtNumeroDocumento.Text.Trim.Length > 0, txtNumeroDocumento.Text.Trim.ToUpper, DBNull.Value)
    dr("Chiave") = IIf(txtChiave.Text.Trim.Length > 0, txtChiave.Text.Trim.ToUpper, DBNull.Value)
    dr("Cauzione") = IIf(txtCauzione.Text.Trim.Length > 0, CDbl(txtCauzione.Text.Trim), DBNull.Value)
    dr("Studente") = ChkStudente.Checked
    dr("Comune") = ChkComune.Checked
    dr("Pendolare") = ChkPendolare.Checked

    dr("ABBONAMENTO_NUM") = IIf(txtNumeroAbbonamento.Text.Trim.Length > 0 And ChkPendolare.Checked, txtNumeroAbbonamento.Text.Trim, DBNull.Value)
    dr("ABBONAMENTO_ORIGINE") = IIf(ddlOrigineAbbonamento.SelectedValue.Length > 0 And ChkPendolare.Checked, ddlOrigineAbbonamento.SelectedValue, DBNull.Value)
    dr("ABBONAMENTO_ALTRO") = IIf(TxtAltro.Text.Trim.Length > 0 And ChkPendolare.Checked, TxtAltro.Text.Trim, DBNull.Value)
    dr("ABBONAMENTO_TIPO") = IIf(ddlTipoAbbonamento.SelectedValue.Length > 0 And ChkPendolare.Checked, ddlTipoAbbonamento.SelectedValue, DBNull.Value)
    dr("ABBONAMENTO_DURATA") = IIf(ddldurata.SelectedValue.Length > 0 And ChkPendolare.Checked, ddldurata.SelectedValue, DBNull.Value)
    dr("ABBONAMENTO_TRATTA") = IIf(txtTratta.Text.Trim.Length > 0 And ChkPendolare.Checked, txtTratta.Text.Trim, DBNull.Value)

    dr("IdUtente") = IIf(TxtIdUtente.Text.Trim.Length > 0, TxtIdUtente.Text.Trim, DirectCast(Session("User"), Utente).ID)
    daCentroinbici.Update(DsBiglietterie1)
    lkStampa.Visible = True
    lkStampa2.Visible = True
  End Sub

  Private Sub dgAllegati_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgAllegati.PageIndexChanged
    dgAllegati.CurrentPageIndex = e.NewPageIndex
    dgAllegati.EditItemIndex = -1
    dgAllegati.DataBind()
  End Sub

  Private Sub lKStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub daCentroinbici_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles daCentroinbici.RowUpdated

  End Sub


  Private Sub ChkStudente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkStudente.CheckedChanged
    If ChkStudente.Checked Then
      ChkComune.Checked = Not ChkStudente.Checked
      ChkPendolare.Checked = Not ChkStudente.Checked
    End If
    If ChkComune.Checked Then
      txtCauzione.Text = 0
    Else
      If ChkStudente.Checked Then

        txtCauzione.Text = 5
      Else
        txtCauzione.Text = 10
      End If
    End If

    RfvNAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlOrigineAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlTipoAbbonamento.Enabled = ChkPendolare.Checked
    Rfvddldurata.Enabled = ChkPendolare.Checked
    RfvTratta.Enabled = ChkPendolare.Checked
  End Sub

  Private Sub ChkComune_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkComune.CheckedChanged
    If ChkComune.Checked Then
      ChkStudente.Checked = Not ChkComune.Checked
      ChkPendolare.Checked = Not ChkComune.Checked
    End If
    If ChkComune.Checked Then
      txtCauzione.Text = 0
    Else
      If ChkStudente.Checked Then

        txtCauzione.Text = 5
      Else
        txtCauzione.Text = 10
      End If
    End If

    RfvNAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlOrigineAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlTipoAbbonamento.Enabled = ChkPendolare.Checked
    Rfvddldurata.Enabled = ChkPendolare.Checked
    RfvTratta.Enabled = ChkPendolare.Checked

  End Sub

  Private Sub ChkPendolare_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkPendolare.CheckedChanged

    If ChkPendolare.Checked Then
      ChkComune.Checked = Not ChkPendolare.Checked
      ChkStudente.Checked = Not ChkPendolare.Checked
    End If
    If ChkComune.Checked Then
      txtCauzione.Text = 0
    Else
      If ChkStudente.Checked Then
        txtCauzione.Text = 5
      Else
        txtCauzione.Text = 10
      End If
    End If


    RfvNAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlOrigineAbbonamento.Enabled = ChkPendolare.Checked
    RfvddlTipoAbbonamento.Enabled = ChkPendolare.Checked
    Rfvddldurata.Enabled = ChkPendolare.Checked
    RfvTratta.Enabled = ChkPendolare.Checked


  End Sub
End Class
