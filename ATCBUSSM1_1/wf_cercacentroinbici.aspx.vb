Public Class wf_cercacentroinbici
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCentroInBici = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    Me.dvCentroInBici = New System.Data.DataView
    Me.daTipoNota = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvCentroInBici, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCentroInBici
    '
    Me.daCentroInBici.DeleteCommand = Me.SqlDeleteCommand1
    Me.daCentroInBici.InsertCommand = Me.SqlInsertCommand1
    Me.daCentroInBici.SelectCommand = Me.SqlSelectCommand1
    Me.daCentroInBici.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("DATA", "DATA"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("MINORENNE", "MINORENNE"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("DATA_NASCITA", "DATA_NASCITA"), New System.Data.Common.DataColumnMapping("PARENTELA", "PARENTELA"), New System.Data.Common.DataColumnMapping("COGNOME_PARENTE", "COGNOME_PARENTE"), New System.Data.Common.DataColumnMapping("NOME_PARENTE", "NOME_PARENTE"), New System.Data.Common.DataColumnMapping("RES_VIA", "RES_VIA"), New System.Data.Common.DataColumnMapping("RES_N_CIV", "RES_N_CIV"), New System.Data.Common.DataColumnMapping("RES_CAP", "RES_CAP"), New System.Data.Common.DataColumnMapping("RES_ID_CIT", "RES_ID_CIT"), New System.Data.Common.DataColumnMapping("RES_CIT", "RES_CIT"), New System.Data.Common.DataColumnMapping("RES_PROV", "RES_PROV"), New System.Data.Common.DataColumnMapping("RES_VIA_P", "RES_VIA_P"), New System.Data.Common.DataColumnMapping("RES_N_CIV_P", "RES_N_CIV_P"), New System.Data.Common.DataColumnMapping("RES_CAP_P", "RES_CAP_P"), New System.Data.Common.DataColumnMapping("RES_ID_CIT_P", "RES_ID_CIT_P"), New System.Data.Common.DataColumnMapping("RES_CIT_P", "RES_CIT_P"), New System.Data.Common.DataColumnMapping("RES_PROV_P", "RES_PROV_P"), New System.Data.Common.DataColumnMapping("TEL", "TEL"), New System.Data.Common.DataColumnMapping("CEL", "CEL"), New System.Data.Common.DataColumnMapping("DOM_RES", "DOM_RES"), New System.Data.Common.DataColumnMapping("DOM_VIA", "DOM_VIA"), New System.Data.Common.DataColumnMapping("DOM_N_CIV", "DOM_N_CIV"), New System.Data.Common.DataColumnMapping("DOM_CAP", "DOM_CAP"), New System.Data.Common.DataColumnMapping("DOM_ID_CIT", "DOM_ID_CIT"), New System.Data.Common.DataColumnMapping("DOM_CIT", "DOM_CIT"), New System.Data.Common.DataColumnMapping("DOM_PROV", "DOM_PROV"), New System.Data.Common.DataColumnMapping("DOCUMENTO_TIPO", "DOCUMENTO_TIPO"), New System.Data.Common.DataColumnMapping("DOCUMENTO_NUM", "DOCUMENTO_NUM"), New System.Data.Common.DataColumnMapping("CHIAVE", "CHIAVE"), New System.Data.Common.DataColumnMapping("REGIONE", "REGIONE"), New System.Data.Common.DataColumnMapping("DATAINSERIMENTO", "DATAINSERIMENTO"), New System.Data.Common.DataColumnMapping("IdUtente", "IdUtente"), New System.Data.Common.DataColumnMapping("Cauzione", "Cauzione")})})
    Me.daCentroInBici.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.CentroInBici WHERE (ID = @Original_ID) AND (CEL = @Original_CEL O" & _
    "R @Original_CEL IS NULL AND CEL IS NULL) AND (CHIAVE = @Original_CHIAVE OR @Orig" & _
    "inal_CHIAVE IS NULL AND CHIAVE IS NULL) AND (COGNOME = @Original_COGNOME OR @Ori" & _
    "ginal_COGNOME IS NULL AND COGNOME IS NULL) AND (COGNOME_PARENTE = @Original_COGN" & _
    "OME_PARENTE OR @Original_COGNOME_PARENTE IS NULL AND COGNOME_PARENTE IS NULL) AN" & _
    "D (Cauzione = @Original_Cauzione OR @Original_Cauzione IS NULL AND Cauzione IS N" & _
    "ULL) AND (DATA = @Original_DATA OR @Original_DATA IS NULL AND DATA IS NULL) AND " & _
    "(DATAINSERIMENTO = @Original_DATAINSERIMENTO OR @Original_DATAINSERIMENTO IS NUL" & _
    "L AND DATAINSERIMENTO IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA OR @Or" & _
    "iginal_DATA_NASCITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM = @Orig" & _
    "inal_DOCUMENTO_NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS NULL)" & _
    " AND (DOCUMENTO_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIPO IS N" & _
    "ULL AND DOCUMENTO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Original_DO" & _
    "M_CAP IS NULL AND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Original" & _
    "_DOM_CIT IS NULL AND DOM_CIT IS NULL) AND (DOM_ID_CIT = @Original_DOM_ID_CIT OR " & _
    "@Original_DOM_ID_CIT IS NULL AND DOM_ID_CIT IS NULL) AND (DOM_N_CIV = @Original_" & _
    "DOM_N_CIV OR @Original_DOM_N_CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = " & _
    "@Original_DOM_PROV OR @Original_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_" & _
    "RES = @Original_DOM_RES) AND (DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA I" & _
    "S NULL AND DOM_VIA IS NULL) AND (IdUtente = @Original_IdUtente OR @Original_IdUt" & _
    "ente IS NULL AND IdUtente IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Orig" & _
    "inal_MATRICOLA IS NULL AND MATRICOLA IS NULL) AND (MINORENNE = @Original_MINOREN" & _
    "NE) AND (NOME = @Original_NOME OR @Original_NOME IS NULL AND NOME IS NULL) AND (" & _
    "NOME_PARENTE = @Original_NOME_PARENTE OR @Original_NOME_PARENTE IS NULL AND NOME" & _
    "_PARENTE IS NULL) AND (PARENTELA = @Original_PARENTELA OR @Original_PARENTELA IS" & _
    " NULL AND PARENTELA IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = @O" & _
    "riginal_RES_CAP OR @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CAP_P" & _
    " = @Original_RES_CAP_P OR @Original_RES_CAP_P IS NULL AND RES_CAP_P IS NULL) AND" & _
    " (RES_CIT = @Original_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL) " & _
    "AND (RES_CIT_P = @Original_RES_CIT_P OR @Original_RES_CIT_P IS NULL AND RES_CIT_" & _
    "P IS NULL) AND (RES_ID_CIT = @Original_RES_ID_CIT OR @Original_RES_ID_CIT IS NUL" & _
    "L AND RES_ID_CIT IS NULL) AND (RES_ID_CIT_P = @Original_RES_ID_CIT_P OR @Origina" & _
    "l_RES_ID_CIT_P IS NULL AND RES_ID_CIT_P IS NULL) AND (RES_N_CIV = @Original_RES_" & _
    "N_CIV OR @Original_RES_N_CIV IS NULL AND RES_N_CIV IS NULL) AND (RES_N_CIV_P = @" & _
    "Original_RES_N_CIV_P OR @Original_RES_N_CIV_P IS NULL AND RES_N_CIV_P IS NULL) A" & _
    "ND (RES_PROV = @Original_RES_PROV OR @Original_RES_PROV IS NULL AND RES_PROV IS " & _
    "NULL) AND (RES_PROV_P = @Original_RES_PROV_P OR @Original_RES_PROV_P IS NULL AND" & _
    " RES_PROV_P IS NULL) AND (RES_VIA = @Original_RES_VIA OR @Original_RES_VIA IS NU" & _
    "LL AND RES_VIA IS NULL) AND (RES_VIA_P = @Original_RES_VIA_P OR @Original_RES_VI" & _
    "A_P IS NULL AND RES_VIA_P IS NULL) AND (TEL = @Original_TEL OR @Original_TEL IS " & _
    "NULL AND TEL IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CHIAVE", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CHIAVE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAINSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MINORENNE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MINORENNE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTELA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTELA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP_P", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT_P", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT_P", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV_P", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA_P", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.CentroInBici(ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_" & _
    "NASCITA, PARENTELA, COGNOME_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, " & _
    "RES_ID_CIT, RES_CIT, RES_PROV, RES_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_ID_CIT_P, " & _
    "RES_CIT_P, RES_PROV_P, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_ID_CI" & _
    "T, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CHIAVE, REGIONE, DATAINSERI" & _
    "MENTO, IdUtente, Cauzione) VALUES (@ID, @DATA, @MATRICOLA, @MINORENNE, @COGNOME," & _
    " @NOME, @DATA_NASCITA, @PARENTELA, @COGNOME_PARENTE, @NOME_PARENTE, @RES_VIA, @R" & _
    "ES_N_CIV, @RES_CAP, @RES_ID_CIT, @RES_CIT, @RES_PROV, @RES_VIA_P, @RES_N_CIV_P, " & _
    "@RES_CAP_P, @RES_ID_CIT_P, @RES_CIT_P, @RES_PROV_P, @TEL, @CEL, @DOM_RES, @DOM_V" & _
    "IA, @DOM_N_CIV, @DOM_CAP, @DOM_ID_CIT, @DOM_CIT, @DOM_PROV, @DOCUMENTO_TIPO, @DO" & _
    "CUMENTO_NUM, @CHIAVE, @REGIONE, @DATAINSERIMENTO, @IdUtente, @Cauzione); SELECT " & _
    "ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_NASCITA, PARENTELA, COGNOME_" & _
    "PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, RES_ID_CIT, RES_CIT, RES_PRO" & _
    "V, RES_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_ID_CIT_P, RES_CIT_P, RES_PROV_P, TEL, " & _
    "CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUME" & _
    "NTO_TIPO, DOCUMENTO_NUM, CHIAVE, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione FR" & _
    "OM dbo.CentroInBici WHERE (ID = @ID)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MINORENNE", System.Data.SqlDbType.Bit, 1, "MINORENNE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTELA", System.Data.SqlDbType.Int, 4, "PARENTELA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "COGNOME_PARENTE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "NOME_PARENTE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA_P", System.Data.SqlDbType.VarChar, 100, "RES_VIA_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP_P", System.Data.SqlDbType.VarChar, 5, "RES_CAP_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT_P", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT_P", System.Data.SqlDbType.VarChar, 50, "RES_CIT_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV_P", System.Data.SqlDbType.VarChar, 2, "RES_PROV_P"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, "DOM_ID_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CHIAVE", System.Data.SqlDbType.VarChar, 10, "CHIAVE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATAINSERIMENTO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT     C.ID, C.DATA, C.MATRICOLA, C.MINORENNE, C.COGNOME, C.NOME, C.DATA_NASC" & _
    "ITA, C.PARENTELA, C.COGNOME_PARENTE, C.NOME_PARENTE, C.RES_VIA, C.RES_N_CIV, C.R" & _
    "ES_CAP, C.RES_ID_CIT, C.RES_CIT, C.RES_PROV, C.RES_VIA_P, C.RES_N_CIV_P, C.RES_C" & _
    "AP_P, C.RES_ID_CIT_P, C.RES_CIT_P, C.RES_PROV_P, C.TEL, C.CEL, C.DOM_RES, C.DOM_" & _
    "VIA, C.DOM_N_CIV, C.DOM_CAP, C.DOM_ID_CIT, C.DOM_CIT, C.DOM_PROV, C.DOCUMENTO_TI" & _
    "PO, C.DOCUMENTO_NUM, C.CHIAVE, C.REGIONE, C.DATAINSERIMENTO, C.IdUtente, C.Cauzi" & _
    "one, CASE WHEN N.NumeroNote IS NULL THEN 0 ELSE N.NumeroNote END AS NumeroNote, " & _
    "CASE WHEN A.NumeroAllegati IS NULL THEN 0 ELSE A.NumeroAllegati END AS NumeroAll" & _
    "egati, C.Studente AS Studente, C.Comune, C.Pendolare FROM dbo.CentroInBici C LEF" & _
    "T OUTER JOIN (SELECT IDAnagrafica, COUNT(*) AS NumeroNote FROM CentroInBici_Note" & _
    " WHERE (RTRIM(LTRIM(STR(CentroInBici_Note.IdTipoNota))) LIKE @IdTipoNota AND Cen" & _
    "troInBici_Note.Data >= CONVERT(DATETIME, @DataNoteDa, 102) AND Data < CONVERT(DA" & _
    "TETIME, @DataNoteA, 102)) GROUP BY IDAnagrafica) N ON C.ID = N.IDAnagrafica LEFT" & _
    " OUTER JOIN (SELECT     IDAnagrafica, COUNT(*) AS NumeroAllegati FROM CentroInBi" & _
    "ci_Allegati GROUP BY IDAnagrafica) A ON C.ID = A.IDAnagrafica"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataNoteDa", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, ""))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataNoteA", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, ""))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.VarChar))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.CentroInBici SET ID = @ID, DATA = @DATA, MATRICOLA = @MATRICOLA, MINOR" & _
    "ENNE = @MINORENNE, COGNOME = @COGNOME, NOME = @NOME, DATA_NASCITA = @DATA_NASCIT" & _
    "A, PARENTELA = @PARENTELA, COGNOME_PARENTE = @COGNOME_PARENTE, NOME_PARENTE = @N" & _
    "OME_PARENTE, RES_VIA = @RES_VIA, RES_N_CIV = @RES_N_CIV, RES_CAP = @RES_CAP, RES" & _
    "_ID_CIT = @RES_ID_CIT, RES_CIT = @RES_CIT, RES_PROV = @RES_PROV, RES_VIA_P = @RE" & _
    "S_VIA_P, RES_N_CIV_P = @RES_N_CIV_P, RES_CAP_P = @RES_CAP_P, RES_ID_CIT_P = @RES" & _
    "_ID_CIT_P, RES_CIT_P = @RES_CIT_P, RES_PROV_P = @RES_PROV_P, TEL = @TEL, CEL = @" & _
    "CEL, DOM_RES = @DOM_RES, DOM_VIA = @DOM_VIA, DOM_N_CIV = @DOM_N_CIV, DOM_CAP = @" & _
    "DOM_CAP, DOM_ID_CIT = @DOM_ID_CIT, DOM_CIT = @DOM_CIT, DOM_PROV = @DOM_PROV, DOC" & _
    "UMENTO_TIPO = @DOCUMENTO_TIPO, DOCUMENTO_NUM = @DOCUMENTO_NUM, CHIAVE = @CHIAVE," & _
    " REGIONE = @REGIONE, DATAINSERIMENTO = @DATAINSERIMENTO, IdUtente = @IdUtente, C" & _
    "auzione = @Cauzione WHERE (ID = @Original_ID) AND (CEL = @Original_CEL OR @Origi" & _
    "nal_CEL IS NULL AND CEL IS NULL) AND (CHIAVE = @Original_CHIAVE OR @Original_CHI" & _
    "AVE IS NULL AND CHIAVE IS NULL) AND (COGNOME = @Original_COGNOME OR @Original_CO" & _
    "GNOME IS NULL AND COGNOME IS NULL) AND (COGNOME_PARENTE = @Original_COGNOME_PARE" & _
    "NTE OR @Original_COGNOME_PARENTE IS NULL AND COGNOME_PARENTE IS NULL) AND (Cauzi" & _
    "one = @Original_Cauzione OR @Original_Cauzione IS NULL AND Cauzione IS NULL) AND" & _
    " (DATA = @Original_DATA OR @Original_DATA IS NULL AND DATA IS NULL) AND (DATAINS" & _
    "ERIMENTO = @Original_DATAINSERIMENTO OR @Original_DATAINSERIMENTO IS NULL AND DA" & _
    "TAINSERIMENTO IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA OR @Original_D" & _
    "ATA_NASCITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM = @Original_DOC" & _
    "UMENTO_NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS NULL) AND (DO" & _
    "CUMENTO_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIPO IS NULL AND " & _
    "DOCUMENTO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Original_DOM_CAP IS" & _
    " NULL AND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Original_DOM_CIT" & _
    " IS NULL AND DOM_CIT IS NULL) AND (DOM_ID_CIT = @Original_DOM_ID_CIT OR @Origina" & _
    "l_DOM_ID_CIT IS NULL AND DOM_ID_CIT IS NULL) AND (DOM_N_CIV = @Original_DOM_N_CI" & _
    "V OR @Original_DOM_N_CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = @Origina" & _
    "l_DOM_PROV OR @Original_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_RES = @O" & _
    "riginal_DOM_RES) AND (DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA IS NULL A" & _
    "ND DOM_VIA IS NULL) AND (IdUtente = @Original_IdUtente OR @Original_IdUtente IS " & _
    "NULL AND IdUtente IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MAT" & _
    "RICOLA IS NULL AND MATRICOLA IS NULL) AND (MINORENNE = @Original_MINORENNE) AND " & _
    "(NOME = @Original_NOME OR @Original_NOME IS NULL AND NOME IS NULL) AND (NOME_PAR" & _
    "ENTE = @Original_NOME_PARENTE OR @Original_NOME_PARENTE IS NULL AND NOME_PARENTE" & _
    " IS NULL) AND (PARENTELA = @Original_PARENTELA OR @Original_PARENTELA IS NULL AN" & _
    "D PARENTELA IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = @Original_" & _
    "RES_CAP OR @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CAP_P = @Orig" & _
    "inal_RES_CAP_P OR @Original_RES_CAP_P IS NULL AND RES_CAP_P IS NULL) AND (RES_CI" & _
    "T = @Original_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL) AND (RES" & _
    "_CIT_P = @Original_RES_CIT_P OR @Original_RES_CIT_P IS NULL AND RES_CIT_P IS NUL" & _
    "L) AND (RES_ID_CIT = @Original_RES_ID_CIT OR @Original_RES_ID_CIT IS NULL AND RE" & _
    "S_ID_CIT IS NULL) AND (RES_ID_CIT_P = @Original_RES_ID_CIT_P OR @Original_RES_ID" & _
    "_CIT_P IS NULL AND RES_ID_CIT_P IS NULL) AND (RES_N_CIV = @Original_RES_N_CIV OR" & _
    " @Original_RES_N_CIV IS NULL AND RES_N_CIV IS NULL) AND (RES_N_CIV_P = @Original" & _
    "_RES_N_CIV_P OR @Original_RES_N_CIV_P IS NULL AND RES_N_CIV_P IS NULL) AND (RES_" & _
    "PROV = @Original_RES_PROV OR @Original_RES_PROV IS NULL AND RES_PROV IS NULL) AN" & _
    "D (RES_PROV_P = @Original_RES_PROV_P OR @Original_RES_PROV_P IS NULL AND RES_PRO" & _
    "V_P IS NULL) AND (RES_VIA = @Original_RES_VIA OR @Original_RES_VIA IS NULL AND R" & _
    "ES_VIA IS NULL) AND (RES_VIA_P = @Original_RES_VIA_P OR @Original_RES_VIA_P IS N" & _
    "ULL AND RES_VIA_P IS NULL) AND (TEL = @Original_TEL OR @Original_TEL IS NULL AND" & _
    " TEL IS NULL); SELECT ID, DATA, MATRICOLA, MINORENNE, COGNOME, NOME, DATA_NASCIT" & _
    "A, PARENTELA, COGNOME_PARENTE, NOME_PARENTE, RES_VIA, RES_N_CIV, RES_CAP, RES_ID" & _
    "_CIT, RES_CIT, RES_PROV, RES_VIA_P, RES_N_CIV_P, RES_CAP_P, RES_ID_CIT_P, RES_CI" & _
    "T_P, RES_PROV_P, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_ID_CIT, DOM" & _
    "_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CHIAVE, REGIONE, DATAINSERIMENTO," & _
    " IdUtente, Cauzione FROM dbo.CentroInBici WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MINORENNE", System.Data.SqlDbType.Bit, 1, "MINORENNE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTELA", System.Data.SqlDbType.Int, 4, "PARENTELA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "COGNOME_PARENTE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, "NOME_PARENTE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA_P", System.Data.SqlDbType.VarChar, 100, "RES_VIA_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP_P", System.Data.SqlDbType.VarChar, 5, "RES_CAP_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT_P", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT_P", System.Data.SqlDbType.VarChar, 50, "RES_CIT_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV_P", System.Data.SqlDbType.VarChar, 2, "RES_PROV_P"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, "DOM_ID_CIT"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CHIAVE", System.Data.SqlDbType.VarChar, 10, "CHIAVE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATAINSERIMENTO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CHIAVE", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CHIAVE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAINSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MINORENNE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MINORENNE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME_PARENTE", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME_PARENTE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTELA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTELA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP_P", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT_P", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT_P", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV_P", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV_P", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA_P", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA_P", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'dvCentroInBici
    '
    Me.dvCentroInBici.ApplyDefaultSort = True
    Me.dvCentroInBici.Sort = "Cognome, Nome, Data_Nascita"
    Me.dvCentroInBici.Table = Me.DsBiglietterie1.CentroInBici
    '
    'daTipoNota
    '
    Me.daTipoNota.InsertCommand = Me.SqlInsertCommand2
    Me.daTipoNota.SelectCommand = Me.SqlSelectCommand2
    Me.daTipoNota.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroInBici_TipoNota", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.CentroInBici_TipoNota(IdTipoNota, Tipo) VALUES (@IdTipoNota, @Tip" & _
    "o); SELECT IdTipoNota, Tipo FROM dbo.CentroInBici_TipoNota"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 255, "Tipo"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdTipoNota, Tipo FROM dbo.CentroInBici_TipoNota"
    Me.SqlSelectCommand2.Connection = Me.con
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvCentroInBici, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCentroInBici As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents dvCentroInBici As System.Data.DataView
  Protected WithEvents dgCentroInBici As System.Web.UI.WebControls.DataGrid
	Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
	Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblNoUtenti As System.Web.UI.WebControls.Label
	Protected WithEvents lblCount As System.Web.UI.WebControls.Label
	Protected WithEvents btnAdd2 As System.Web.UI.WebControls.Button
	Protected WithEvents lblMatricola As System.Web.UI.WebControls.Label
	Protected WithEvents txtMatricola As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblDataDa As System.Web.UI.WebControls.Label
	Protected WithEvents txtDataDa As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblDataA As System.Web.UI.WebControls.Label
	Protected WithEvents txtDataA As System.Web.UI.WebControls.TextBox
	Protected WithEvents btnRicercaAvanzata As System.Web.UI.WebControls.Button
	Protected WithEvents lnkRicercaSemplice As System.Web.UI.WebControls.LinkButton
	Protected WithEvents pnlRicercaAvanzata As System.Web.UI.WebControls.Panel
	Protected WithEvents pnlRicercaSemplice As System.Web.UI.WebControls.Panel
	Protected WithEvents lnkRicercaAvanzata As System.Web.UI.WebControls.LinkButton
	Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
	Protected WithEvents ddlSearchType As System.Web.UI.WebControls.DropDownList
	Protected WithEvents txtFiltro As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblCerca As System.Web.UI.WebControls.Label
	Protected WithEvents cvDataA As System.Web.UI.WebControls.CompareValidator
	Protected WithEvents cvDataDa As System.Web.UI.WebControls.CompareValidator
	Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
	Protected WithEvents lblNome As System.Web.UI.WebControls.Label
	Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
	Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblDataNascita As System.Web.UI.WebControls.Label
	Protected WithEvents txtDataNascita As System.Web.UI.WebControls.TextBox
	Protected WithEvents cvDataNascita As System.Web.UI.WebControls.CompareValidator
	Protected WithEvents lblNote As System.Web.UI.WebControls.Label
	Protected WithEvents chkNote As System.Web.UI.WebControls.CheckBox
	Protected WithEvents lblAllegati As System.Web.UI.WebControls.Label
	Protected WithEvents chkAllegati As System.Web.UI.WebControls.CheckBox
	Protected WithEvents lblChiave As System.Web.UI.WebControls.Label
	Protected WithEvents txtChiave As System.Web.UI.WebControls.TextBox
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daTipoNota As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents ddlTipoNota As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lnkAnnullaRicerca As System.Web.UI.WebControls.LinkButton
  Protected WithEvents lblCauzione As System.Web.UI.WebControls.Label
  Protected WithEvents TxtCauzione As System.Web.UI.WebControls.TextBox
  Protected WithEvents RECauzione As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblDataDaNote As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataDaNote As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataANote As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataANote As System.Web.UI.WebControls.TextBox
  Protected WithEvents cvDataANote As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataDaNote As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataA1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents txtDataANote1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents DDlTipoUtente As System.Web.UI.WebControls.DropDownList

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

	Dim DefaultFilter As String = ""

	Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    If Not IsPostBack Then
      daCentroInBici.SelectCommand.Parameters("@IdTipoNota").Value = "%"
      daCentroInBici.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      daCentroInBici.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"

    ElseIf chkNote.Checked Then

      daCentroInBici.SelectCommand.Parameters("@IdTipoNota").Value = ddlTipoNota.SelectedValue
      If txtDataDaNote.Text.Trim <= "" Then
        daCentroInBici.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      Else
        daCentroInBici.SelectCommand.Parameters("@DataNoteDa").Value = Format(CDate(txtDataDaNote.Text), "yyyy-MM-dd 00:00:00")
      End If
      If txtDataANote.Text.Trim <= "" Then
        daCentroInBici.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"
      Else
        daCentroInBici.SelectCommand.Parameters("@DataNoteA").Value = Format(CDate(txtDataANote.Text).AddDays(1), "yyyy-MM-dd 00:00:00")
      End If
    Else
      daCentroInBici.SelectCommand.Parameters("@IdTipoNota").Value = "%"
      daCentroInBici.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      daCentroInBici.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"
    End If

    daCentroInBici.Fill(DsBiglietterie1)
    daTipoNota.Fill(DsBiglietterie1)
    If pnlRicercaSemplice.Visible Then
      dvCentroInBici.RowFilter = pCreateFilter()
    Else
      dvCentroInBici.RowFilter = pCreateAdvancedFilter()
    End If
    If Not IsPostBack Then Page.DataBind()
    ddlTipoNota.Visible = chkNote.Checked
    lblDataDaNote.Visible = chkNote.Checked
    txtDataDaNote.Visible = chkNote.Checked
    lblDataANote.Visible = chkNote.Checked
    txtDataANote.Visible = chkNote.Checked
	End Sub

	Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		Response.Redirect("wf_centroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
	End Sub

	Private Sub dgCentroInBici_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCentroInBici.SelectedIndexChanged
		Response.Redirect("wf_centroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(dgCentroInBici.DataKeys(dgCentroInBici.SelectedIndex)))
	End Sub

	Private Sub dgCentroInBici_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgCentroInBici.PageIndexChanged
		dgCentroInBici.CurrentPageIndex = e.NewPageIndex
		dgCentroInBici.DataBind()
	End Sub

  'Private Sub btnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerca.Click
  '  dgCentroInBici.CurrentPageIndex = 0
  '  dgCentroInBici.DataBind()
  '  lblNoUtenti.DataBind()
  '  lblCount.DataBind()
  'End Sub

  Private Function pCreateFilter() As String
    If txtFiltro.Text.Trim.Length > 0 Then
      Dim where As String = ""
      Dim s As String = txtFiltro.Text.Trim
      Do While s.IndexOf("  ") >= 0
        s = s.Replace("  ", " ")
      Loop
      Dim pArr As String()
      pArr = s.Split(" ")
      For Each s In pArr
        s = s.Replace("'", "''")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        If where.Length > 0 Then
          If ddlSearchType.SelectedValue <> 1 Then
            where &= " Or "
          Else
            where &= " And "
          End If
        End If
        If IsNumeric(s) Then
          where &= "(Cauzione = " & s & " Or Chiave = '" & s & "')"
        ElseIf IsDate(s) Then
          where &= "(Data_Nascita = '" & CDate(s).Date & "' OR (DataInserimento >'" & CDate(s).Date & "' AND DataInserimento <'" & CDate(s).Date.AddDays(1) & "'))"
        Else
          where &= "(Nome Like '%" & s & "%' Or Cognome Like '%" & s & "%' Or Chiave = '" & s & "')"
        End If
      Next
      pCreateFilter = where
    Else
      pCreateFilter = DefaultFilter
    End If
  End Function

  Private Sub dgCentroInBici_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCentroInBici.ItemCommand
    Select Case e.CommandName
      Case "Note"
        Response.Redirect("wf_centroinbicinote.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IDAnagrafica=" & Server.UrlEncode(dgCentroInBici.DataKeys(e.Item.ItemIndex)))
      Case "NuovaNota"
        Response.Redirect("wf_centroinbicinota.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IDAnagrafica=" & Server.UrlEncode(dgCentroInBici.DataKeys(e.Item.ItemIndex)))
      Case "Allegati"
        Response.Redirect("wf_centroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(dgCentroInBici.DataKeys(e.Item.ItemIndex)))
    End Select
  End Sub

  Private Sub dgCentroInBici_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCentroInBici.DeleteCommand
    Dim id As Integer = dgCentroInBici.DataKeys(e.Item.ItemIndex)
    'Eliminare tutti gli allegati
    Dim comDelAtt As New SqlClient.SqlCommand("Delete From Centroinbici_Allegati Where IdAnagrafica = @IdAnagrafica", con)
    comDelAtt.Parameters.Add("@IdAnagrafica", SqlDbType.Int).Value = id
    'Eliminare tutte le note
    Dim comDelNote As New SqlClient.SqlCommand("Delete From Centroinbici_Note Where IdAnagrafica = @IdAnagrafica", con)
    comDelNote.Parameters.Add("@IdAnagrafica", SqlDbType.Int).Value = id
    'eliminare l'anagrafica
    con.Open()
    comDelAtt.ExecuteNonQuery()
    comDelNote.ExecuteNonQuery()
    con.Close()
    DsBiglietterie1.Tables("CentroInBici").Rows.Find(id).Delete()
    daCentroInBici.Update(DsBiglietterie1)
    dgCentroInBici.DataBind()
  End Sub

  Private Sub dgCentroInBici_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCentroInBici.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then
      DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "javascript: return confirm('Attenzione! Verranno eliminate anche eventuali note ed allegati.\nProcedere?');")
    End If
  End Sub

  Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
    Response.Redirect("wf_centroinbici.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub btnRicercaAvanzata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicercaAvanzata.Click
    dgCentroInBici.CurrentPageIndex = 0
    dgCentroInBici.DataBind()
    lblNoUtenti.DataBind()
    lblCount.DataBind()
  End Sub

  Private Function pCreateAdvancedFilter() As String
    Dim s As String = ""
    If txtMatricola.Text.Trim.Length > 0 Then
      s = "Matricola = '" & txtMatricola.Text.Trim.Replace("'", "''") & "'"
    End If
    If txtDataDa.Text.Trim.Length > 0 Then
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DataInserimento >='" & CDate(txtDataDa.Text.Trim) & "' And DataInserimento < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "'"
      Else
        s &= IIf(s.Length > 0, " AND ", "") & "DataInserimento >= '" & CDate(txtDataDa.Text.Trim) & "' And DataInserimento <= getdate()"
      End If
    Else
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DataInserimento < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "' "
      End If
    End If

    If txtNome.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Nome like '" & txtNome.Text.Trim & "%'"
    End If
    If txtCognome.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Cognome like '" & txtCognome.Text.Trim & "%'"
    End If
    If txtDataNascita.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Data_Nascita = '" & CDate(txtDataNascita.Text.Trim) & "'"
    End If
    If txtChiave.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "CHIAVE = '" & txtChiave.Text.Trim & "'"
    End If
    If TxtCauzione.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Cauzione = " & TxtCauzione.Text.Trim & " "
    End If
    If chkNote.Checked Then
      s &= IIf(s.Length > 0, " AND ", "") & "NumeroNote > 0"
    End If
    If chkAllegati.Checked Then
      s &= IIf(s.Length > 0, " AND ", "") & "NumeroAllegati > 0"
    End If

    If DDlTipoUtente.SelectedIndex = 1 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Studente = 1 and Comune=0 and Pendolare=0 "
    End If
    If DDlTipoUtente.SelectedIndex = 2 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Studente = 0  and Comune=0 and Pendolare=0 "
    End If
    If DDlTipoUtente.SelectedIndex = 3 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Studente = 0  and Comune=1 and Pendolare=0 "
    End If
    If DDlTipoUtente.SelectedIndex = 4 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Studente = 0  and Comune=0 and Pendolare=1 "
    End If
    pCreateAdvancedFilter = s
  End Function

  Private Sub lnkRicercaAvanzata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkRicercaAvanzata.Click
    pnlRicercaSemplice.Visible = False
    pnlRicercaAvanzata.Visible = True
    For Each c As Control In pnlRicercaAvanzata.Controls
      c.Visible = True
    Next
    ddlTipoNota.Visible = False
    lblDataDaNote.Visible = False
    txtDataDaNote.Visible = False
    lblDataANote.Visible = False
    txtDataANote.Visible = False
  End Sub

  Private Sub lnkRicercaSemplice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkRicercaSemplice.Click
    pnlRicercaSemplice.Visible = True
    pnlRicercaAvanzata.Visible = False
    For Each c As Control In pnlRicercaSemplice.Controls
      c.Visible = True
    Next
  End Sub

  Private Sub btnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerca.Click
    dgCentroInBici.CurrentPageIndex = 0
    dgCentroInBici.DataBind()
    lblNoUtenti.DataBind()
    lblCount.DataBind()
  End Sub

  Private Sub chkNote_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNote.CheckedChanged
    ddlTipoNota.Visible = chkNote.Checked
    lblDataDaNote.Visible = chkNote.Checked
    txtDataDaNote.Visible = chkNote.Checked
    lblDataANote.Visible = chkNote.Checked
    txtDataANote.Visible = chkNote.Checked
  End Sub

  Private Sub lnkAnnullaRicerca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkAnnullaRicerca.Click

    pnlRicercaSemplice.Visible = True
    pnlRicercaAvanzata.Visible = False
    For Each c As Control In pnlRicercaSemplice.Controls
      If TypeOf c Is TextBox Then
        CType(c, TextBox).Text = ""
      End If
      c.Visible = True
    Next
    dvCentroInBici.RowFilter = pCreateFilter()
    dgCentroInBici.CurrentPageIndex = 0
    dgCentroInBici.DataBind()
    lblNoUtenti.DataBind()
    lblCount.DataBind()
    Page.DataBind()

  End Sub


End Class
