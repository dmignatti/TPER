Public Class wf_cercabikepark
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaBikePark = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    Me.dvBikePark = New System.Data.DataView
    Me.DaTipiNotaBP = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvBikePark, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'DaBikePark
    '
    Me.DaBikePark.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaBikePark.InsertCommand = Me.SqlInsertCommand1
    Me.DaBikePark.SelectCommand = Me.SqlSelectCommand1
    Me.DaBikePark.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BikeParkLista", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("DATA", "DATA"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("DATA_NASCITA", "DATA_NASCITA"), New System.Data.Common.DataColumnMapping("RES_VIA", "RES_VIA"), New System.Data.Common.DataColumnMapping("RES_N_CIV", "RES_N_CIV"), New System.Data.Common.DataColumnMapping("RES_CAP", "RES_CAP"), New System.Data.Common.DataColumnMapping("RES_ID_CIT", "RES_ID_CIT"), New System.Data.Common.DataColumnMapping("RES_CIT", "RES_CIT"), New System.Data.Common.DataColumnMapping("RES_PROV", "RES_PROV"), New System.Data.Common.DataColumnMapping("TEL", "TEL"), New System.Data.Common.DataColumnMapping("CEL", "CEL"), New System.Data.Common.DataColumnMapping("DOM_RES", "DOM_RES"), New System.Data.Common.DataColumnMapping("DOM_VIA", "DOM_VIA"), New System.Data.Common.DataColumnMapping("DOM_N_CIV", "DOM_N_CIV"), New System.Data.Common.DataColumnMapping("DOM_CAP", "DOM_CAP"), New System.Data.Common.DataColumnMapping("DOM_ID_CIT", "DOM_ID_CIT"), New System.Data.Common.DataColumnMapping("DOM_CIT", "DOM_CIT"), New System.Data.Common.DataColumnMapping("DOM_PROV", "DOM_PROV"), New System.Data.Common.DataColumnMapping("DOCUMENTO_TIPO", "DOCUMENTO_TIPO"), New System.Data.Common.DataColumnMapping("DOCUMENTO_NUM", "DOCUMENTO_NUM"), New System.Data.Common.DataColumnMapping("TESSERA", "TESSERA"), New System.Data.Common.DataColumnMapping("CODICEFISCALE", "CODICEFISCALE"), New System.Data.Common.DataColumnMapping("REGIONE", "REGIONE"), New System.Data.Common.DataColumnMapping("DATAINSERIMENTO", "DATAINSERIMENTO"), New System.Data.Common.DataColumnMapping("IdUtente", "IdUtente"), New System.Data.Common.DataColumnMapping("Cauzione", "Cauzione")})})
    Me.DaBikePark.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.BikePark WHERE (ID = @Original_ID) AND (CEL = @Original_CEL OR @O" & _
    "riginal_CEL IS NULL AND CEL IS NULL) AND (CODICEFISCALE = @Original_CODICEFISCAL" & _
    "E OR @Original_CODICEFISCALE IS NULL AND CODICEFISCALE IS NULL) AND (COGNOME = @" & _
    "Original_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) AND (Cauzione" & _
    " = @Original_Cauzione OR @Original_Cauzione IS NULL AND Cauzione IS NULL) AND (D" & _
    "ATA = @Original_DATA OR @Original_DATA IS NULL AND DATA IS NULL) AND (DATAINSERI" & _
    "MENTO = @Original_DATAINSERIMENTO OR @Original_DATAINSERIMENTO IS NULL AND DATAI" & _
    "NSERIMENTO IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA OR @Original_DATA" & _
    "_NASCITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM = @Original_DOCUME" & _
    "NTO_NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS NULL) AND (DOCUM" & _
    "ENTO_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIPO IS NULL AND DOC" & _
    "UMENTO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Original_DOM_CAP IS NU" & _
    "LL AND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Original_DOM_CIT IS" & _
    " NULL AND DOM_CIT IS NULL) AND (DOM_ID_CIT = @Original_DOM_ID_CIT OR @Original_D" & _
    "OM_ID_CIT IS NULL AND DOM_ID_CIT IS NULL) AND (DOM_N_CIV = @Original_DOM_N_CIV O" & _
    "R @Original_DOM_N_CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = @Original_D" & _
    "OM_PROV OR @Original_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_RES = @Orig" & _
    "inal_DOM_RES) AND (DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA IS NULL AND " & _
    "DOM_VIA IS NULL) AND (IdUtente = @Original_IdUtente OR @Original_IdUtente IS NUL" & _
    "L AND IdUtente IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRIC" & _
    "OLA IS NULL AND MATRICOLA IS NULL) AND (NOME = @Original_NOME OR @Original_NOME " & _
    "IS NULL AND NOME IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = @Orig" & _
    "inal_RES_CAP OR @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CIT = @O" & _
    "riginal_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL) AND (RES_ID_CI" & _
    "T = @Original_RES_ID_CIT OR @Original_RES_ID_CIT IS NULL AND RES_ID_CIT IS NULL)" & _
    " AND (RES_N_CIV = @Original_RES_N_CIV OR @Original_RES_N_CIV IS NULL AND RES_N_C" & _
    "IV IS NULL) AND (RES_PROV = @Original_RES_PROV OR @Original_RES_PROV IS NULL AND" & _
    " RES_PROV IS NULL) AND (RES_VIA = @Original_RES_VIA OR @Original_RES_VIA IS NULL" & _
    " AND RES_VIA IS NULL) AND (TEL = @Original_TEL OR @Original_TEL IS NULL AND TEL " & _
    "IS NULL) AND (TESSERA = @Original_TESSERA OR @Original_TESSERA IS NULL AND TESSE" & _
    "RA IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODICEFISCALE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAINSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TESSERA", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TESSERA", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.BikePark(ID, DATA, MATRICOLA, COGNOME, NOME, DATA_NASCITA, RES_VI" & _
    "A, RES_N_CIV, RES_CAP, RES_ID_CIT, RES_CIT, RES_PROV, TEL, CEL, DOM_RES, DOM_VIA" & _
    ", DOM_N_CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_N" & _
    "UM, TESSERA, CODICEFISCALE, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione) VALUES" & _
    " (@ID, @DATA, @MATRICOLA, @COGNOME, @NOME, @DATA_NASCITA, @RES_VIA, @RES_N_CIV, " & _
    "@RES_CAP, @RES_ID_CIT, @RES_CIT, @RES_PROV, @TEL, @CEL, @DOM_RES, @DOM_VIA, @DOM" & _
    "_N_CIV, @DOM_CAP, @DOM_ID_CIT, @DOM_CIT, @DOM_PROV, @DOCUMENTO_TIPO, @DOCUMENTO_" & _
    "NUM, @TESSERA, @CODICEFISCALE, @REGIONE, @DATAINSERIMENTO, @IdUtente, @Cauzione)" & _
    "; SELECT ID, DATA, MATRICOLA, COGNOME, NOME, DATA_NASCITA, RES_VIA, RES_N_CIV, R" & _
    "ES_CAP, RES_ID_CIT, RES_CIT, RES_PROV, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DO" & _
    "M_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, TESSERA, CO" & _
    "DICEFISCALE, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione FROM dbo.BikePark C WH" & _
    "ERE (ID = @ID)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
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
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TESSERA", System.Data.SqlDbType.VarChar, 10, "TESSERA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, "CODICEFISCALE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATAINSERIMENTO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT C.ID, C.DATA, C.MATRICOLA, C.COGNOME, C.NOME, C.DATA_NASCITA, C.RES_VIA, C" & _
    ".RES_N_CIV, C.RES_CAP, C.RES_ID_CIT, C.RES_CIT, C.RES_PROV, C.TEL, C.CEL, C.DOM_" & _
    "RES, C.DOM_VIA, C.DOM_N_CIV, C.DOM_CAP, C.DOM_ID_CIT, C.DOM_CIT, C.DOM_PROV, C.D" & _
    "OCUMENTO_TIPO, C.DOCUMENTO_NUM, C.TESSERA, C.CODICEFISCALE, C.REGIONE, C.DATAINS" & _
    "ERIMENTO, C.IdUtente, C.Cauzione, CASE WHEN N.NumeroNote IS NULL THEN 0 ELSE N.N" & _
    "umeroNote END AS NumeroNote, CASE WHEN A.NumeroAllegati IS NULL THEN 0 ELSE A.Nu" & _
    "meroAllegati END AS NumeroAllegati FROM dbo.BikePark C LEFT OUTER JOIN (SELECT I" & _
    "DAnagrafica, COUNT(*) AS NumeroNote FROM BikePark_Note WHERE (RTRIM(LTRIM(STR(Bi" & _
    "kePark_Note.IdTipoNota))) LIKE @IdTipoNota AND BikePark_Note.Data >= CONVERT(DAT" & _
    "ETIME, @DataNoteDa, 102) AND BikePark_Note.Data < CONVERT(DATETIME, @DataNoteA, " & _
    "102)) GROUP BY IDAnagrafica) N ON C.ID = N.IDAnagrafica LEFT OUTER JOIN (SELECT " & _
    "IDAnagrafica, COUNT(*) AS NumeroAllegati FROM BikePark_Allegati GROUP BY IDAnagr" & _
    "afica) A ON C.ID = A.IDAnagrafica"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Proposed, Nothing))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataNoteDa", System.Data.SqlDbType.DateTime))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataNoteA", System.Data.SqlDbType.DateTime))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.BikePark SET ID = @ID, DATA = @DATA, MATRICOLA = @MATRICOLA, COGNOME =" & _
    " @COGNOME, NOME = @NOME, DATA_NASCITA = @DATA_NASCITA, RES_VIA = @RES_VIA, RES_N" & _
    "_CIV = @RES_N_CIV, RES_CAP = @RES_CAP, RES_ID_CIT = @RES_ID_CIT, RES_CIT = @RES_" & _
    "CIT, RES_PROV = @RES_PROV, TEL = @TEL, CEL = @CEL, DOM_RES = @DOM_RES, DOM_VIA =" & _
    " @DOM_VIA, DOM_N_CIV = @DOM_N_CIV, DOM_CAP = @DOM_CAP, DOM_ID_CIT = @DOM_ID_CIT," & _
    " DOM_CIT = @DOM_CIT, DOM_PROV = @DOM_PROV, DOCUMENTO_TIPO = @DOCUMENTO_TIPO, DOC" & _
    "UMENTO_NUM = @DOCUMENTO_NUM, TESSERA = @TESSERA, CODICEFISCALE = @CODICEFISCALE," & _
    " REGIONE = @REGIONE, DATAINSERIMENTO = @DATAINSERIMENTO, IdUtente = @IdUtente, C" & _
    "auzione = @Cauzione WHERE (ID = @Original_ID) AND (CEL = @Original_CEL OR @Origi" & _
    "nal_CEL IS NULL AND CEL IS NULL) AND (CODICEFISCALE = @Original_CODICEFISCALE OR" & _
    " @Original_CODICEFISCALE IS NULL AND CODICEFISCALE IS NULL) AND (COGNOME = @Orig" & _
    "inal_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) AND (Cauzione = @" & _
    "Original_Cauzione OR @Original_Cauzione IS NULL AND Cauzione IS NULL) AND (DATA " & _
    "= @Original_DATA OR @Original_DATA IS NULL AND DATA IS NULL) AND (DATAINSERIMENT" & _
    "O = @Original_DATAINSERIMENTO OR @Original_DATAINSERIMENTO IS NULL AND DATAINSER" & _
    "IMENTO IS NULL) AND (DATA_NASCITA = @Original_DATA_NASCITA OR @Original_DATA_NAS" & _
    "CITA IS NULL AND DATA_NASCITA IS NULL) AND (DOCUMENTO_NUM = @Original_DOCUMENTO_" & _
    "NUM OR @Original_DOCUMENTO_NUM IS NULL AND DOCUMENTO_NUM IS NULL) AND (DOCUMENTO" & _
    "_TIPO = @Original_DOCUMENTO_TIPO OR @Original_DOCUMENTO_TIPO IS NULL AND DOCUMEN" & _
    "TO_TIPO IS NULL) AND (DOM_CAP = @Original_DOM_CAP OR @Original_DOM_CAP IS NULL A" & _
    "ND DOM_CAP IS NULL) AND (DOM_CIT = @Original_DOM_CIT OR @Original_DOM_CIT IS NUL" & _
    "L AND DOM_CIT IS NULL) AND (DOM_ID_CIT = @Original_DOM_ID_CIT OR @Original_DOM_I" & _
    "D_CIT IS NULL AND DOM_ID_CIT IS NULL) AND (DOM_N_CIV = @Original_DOM_N_CIV OR @O" & _
    "riginal_DOM_N_CIV IS NULL AND DOM_N_CIV IS NULL) AND (DOM_PROV = @Original_DOM_P" & _
    "ROV OR @Original_DOM_PROV IS NULL AND DOM_PROV IS NULL) AND (DOM_RES = @Original" & _
    "_DOM_RES) AND (DOM_VIA = @Original_DOM_VIA OR @Original_DOM_VIA IS NULL AND DOM_" & _
    "VIA IS NULL) AND (IdUtente = @Original_IdUtente OR @Original_IdUtente IS NULL AN" & _
    "D IdUtente IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRICOLA " & _
    "IS NULL AND MATRICOLA IS NULL) AND (NOME = @Original_NOME OR @Original_NOME IS N" & _
    "ULL AND NOME IS NULL) AND (REGIONE = @Original_REGIONE) AND (RES_CAP = @Original" & _
    "_RES_CAP OR @Original_RES_CAP IS NULL AND RES_CAP IS NULL) AND (RES_CIT = @Origi" & _
    "nal_RES_CIT OR @Original_RES_CIT IS NULL AND RES_CIT IS NULL) AND (RES_ID_CIT = " & _
    "@Original_RES_ID_CIT OR @Original_RES_ID_CIT IS NULL AND RES_ID_CIT IS NULL) AND" & _
    " (RES_N_CIV = @Original_RES_N_CIV OR @Original_RES_N_CIV IS NULL AND RES_N_CIV I" & _
    "S NULL) AND (RES_PROV = @Original_RES_PROV OR @Original_RES_PROV IS NULL AND RES" & _
    "_PROV IS NULL) AND (RES_VIA = @Original_RES_VIA OR @Original_RES_VIA IS NULL AND" & _
    " RES_VIA IS NULL) AND (TEL = @Original_TEL OR @Original_TEL IS NULL AND TEL IS N" & _
    "ULL) AND (TESSERA = @Original_TESSERA OR @Original_TESSERA IS NULL AND TESSERA I" & _
    "S NULL); SELECT ID, DATA, MATRICOLA, COGNOME, NOME, DATA_NASCITA, RES_VIA, RES_N" & _
    "_CIV, RES_CAP, RES_ID_CIT, RES_CIT, RES_PROV, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_" & _
    "CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, TESS" & _
    "ERA, CODICEFISCALE, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione FROM dbo.BikePa" & _
    "rk C WHERE (ID = @ID)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, "DOM_ID_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TESSERA", System.Data.SqlDbType.VarChar, 10, "TESSERA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, "CODICEFISCALE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATAINSERIMENTO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODICEFISCALE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cauzione", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cauzione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAINSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAINSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_NASCITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_NUM", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOCUMENTO_TIPO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_RES", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_RES", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DOM_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DOM_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdUtente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdUtente", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_REGIONE", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REGIONE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_CIT", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_ID_CIT", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_N_CIV", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_N_CIV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_PROV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_PROV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RES_VIA", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RES_VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TEL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TESSERA", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TESSERA", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'dvBikePark
    '
    Me.dvBikePark.ApplyDefaultSort = True
    Me.dvBikePark.Sort = "Cognome, Nome, Data_Nascita"
    Me.dvBikePark.Table = Me.DsBiglietterie1.BikeParkLista
    '
    'DaTipiNotaBP
    '
    Me.DaTipiNotaBP.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaTipiNotaBP.InsertCommand = Me.SqlInsertCommand2
    Me.DaTipiNotaBP.SelectCommand = Me.SqlSelectCommand2
    Me.DaTipiNotaBP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BikePark_TipoNota", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
    Me.DaTipiNotaBP.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.BikePark_TipoNota WHERE (IdTipoNota = @Original_IdTipoNota) AND (" & _
    "Tipo = @Original_Tipo OR @Original_Tipo IS NULL AND Tipo IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.BikePark_TipoNota(IdTipoNota, Tipo) VALUES (@IdTipoNota, @Tipo); " & _
    "SELECT IdTipoNota, Tipo FROM dbo.BikePark_TipoNota WHERE (IdTipoNota = @IdTipoNo" & _
    "ta)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 255, "Tipo"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdTipoNota, Tipo FROM dbo.BikePark_TipoNota"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.BikePark_TipoNota SET IdTipoNota = @IdTipoNota, Tipo = @Tipo WHERE (Id" & _
    "TipoNota = @Original_IdTipoNota) AND (Tipo = @Original_Tipo OR @Original_Tipo IS" & _
    " NULL AND Tipo IS NULL); SELECT IdTipoNota, Tipo FROM dbo.BikePark_TipoNota WHER" & _
    "E (IdTipoNota = @IdTipoNota)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 255, "Tipo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvBikePark, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblCerca As System.Web.UI.WebControls.Label
  Protected WithEvents txtFiltro As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlSearchType As System.Web.UI.WebControls.DropDownList
  Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
  Protected WithEvents lnkRicercaAvanzata As System.Web.UI.WebControls.LinkButton
  Protected WithEvents lnkAnnullaRicerca As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlRicercaSemplice As System.Web.UI.WebControls.Panel
  Protected WithEvents lblMatricola As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricola As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataDa As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataDa As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataA As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataA As System.Web.UI.WebControls.TextBox
  Protected WithEvents cvDataA1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataA As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataDa As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataNascita As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents cvDataNascita As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents lblCauzione As System.Web.UI.WebControls.Label
  Protected WithEvents TxtCauzione As System.Web.UI.WebControls.TextBox
  Protected WithEvents RECauzione As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblNote As System.Web.UI.WebControls.Label
  Protected WithEvents chkNote As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ddlTipoNota As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblDataDaNote As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataDaNote As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataANote As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataANote As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDataANote1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataANote As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataDaNote As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents lblAllegati As System.Web.UI.WebControls.Label
  Protected WithEvents chkAllegati As System.Web.UI.WebControls.CheckBox
  Protected WithEvents lnkRicercaSemplice As System.Web.UI.WebControls.LinkButton
  Protected WithEvents btnRicercaAvanzata As System.Web.UI.WebControls.Button
  Protected WithEvents pnlRicercaAvanzata As System.Web.UI.WebControls.Panel
  Protected WithEvents lblCount As System.Web.UI.WebControls.Label
  Protected WithEvents btnAdd2 As System.Web.UI.WebControls.Button
  Protected WithEvents lblNoUtenti As System.Web.UI.WebControls.Label
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaBikePark As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents dvBikePark As System.Data.DataView
  Protected WithEvents DaTipiNotaBP As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgBikePark As System.Web.UI.WebControls.DataGrid
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblTessera As System.Web.UI.WebControls.Label
  Protected WithEvents txtTessera As System.Web.UI.WebControls.TextBox

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
      DaBikePark.SelectCommand.Parameters("@IdTipoNota").Value = "%"
      DaBikePark.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      DaBikePark.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"

    ElseIf chkNote.Checked Then

      DaBikePark.SelectCommand.Parameters("@IdTipoNota").Value = ddlTipoNota.SelectedValue
      If txtDataDaNote.Text.Trim <= "" Then
        DaBikePark.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      Else
        DaBikePark.SelectCommand.Parameters("@DataNoteDa").Value = Format(CDate(txtDataDaNote.Text), "yyyy-MM-dd 00:00:00")
      End If
      If txtDataANote.Text.Trim <= "" Then
        DaBikePark.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"
      Else
        DaBikePark.SelectCommand.Parameters("@DataNoteA").Value = Format(CDate(txtDataANote.Text).AddDays(1), "yyyy-MM-dd 00:00:00")
      End If
    Else
      DaBikePark.SelectCommand.Parameters("@IdTipoNota").Value = "%"
      DaBikePark.SelectCommand.Parameters("@DataNoteDa").Value = "1980-01-01 00:00:00"
      DaBikePark.SelectCommand.Parameters("@DataNoteA").Value = "2099-12-31 00:00:00"
    End If

    DaBikePark.Fill(DsBiglietterie1)
    DaTipiNotaBP.Fill(DsBiglietterie1)
    If pnlRicercaSemplice.Visible Then
      dvBikePark.RowFilter = pCreateFilter()
    Else
      dvBikePark.RowFilter = pCreateAdvancedFilter()
    End If
    If Not IsPostBack Then Page.DataBind()
    ddlTipoNota.Visible = chkNote.Checked
    lblDataDaNote.Visible = chkNote.Checked
    txtDataDaNote.Visible = chkNote.Checked
    lblDataANote.Visible = chkNote.Checked
    txtDataANote.Visible = chkNote.Checked
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Response.Redirect("wf_bikepark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
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
          where &= "(Cauzione = " & s & " Or Tessera = '" & s & "')"
        ElseIf IsDate(s) Then
          where &= "(Data_Nascita = '" & CDate(s).Date & "' OR (DataInserimento >'" & CDate(s).Date & "' AND DataInserimento <'" & CDate(s).Date.AddDays(1) & "'))"
        Else
          where &= "(Nome Like '%" & s & "%' Or Cognome Like '%" & s & "%' Or Tessera = '" & s & "')"
        End If
      Next
      pCreateFilter = where
    Else
      pCreateFilter = DefaultFilter
    End If
  End Function

  Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
    Response.Redirect("wf_bikepark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub btnRicercaAvanzata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicercaAvanzata.Click
    dgBikePark.CurrentPageIndex = 0
    dgBikePark.DataBind()
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
    If txtTessera.Text.Trim.Length > 0 Then
      s &= IIf(s.Length > 0, " AND ", "") & "Tessera = '" & txtTessera.Text.Trim & "'"
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
    dgBikePark.CurrentPageIndex = 0
    dgBikePark.DataBind()
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
    dvBikePark.RowFilter = pCreateFilter()
    dgBikePark.CurrentPageIndex = 0
    dgBikePark.DataBind()
    lblNoUtenti.DataBind()
    lblCount.DataBind()
    Page.DataBind()

  End Sub

  Private Sub dgBikePark_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBikePark.ItemCommand
    Select Case e.CommandName
      Case "Note"
        Response.Redirect("wf_bikeparknote.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IDAnagrafica=" & Server.UrlEncode(dgBikePark.DataKeys(e.Item.ItemIndex)))
      Case "NuovaNota"
        Response.Redirect("wf_bikeparknota.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")) & "&IDAnagrafica=" & Server.UrlEncode(dgBikePark.DataKeys(e.Item.ItemIndex)))
      Case "Allegati"
        Response.Redirect("wf_bikepark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(dgBikePark.DataKeys(e.Item.ItemIndex)))
    End Select
  End Sub

  Private Sub dgBikePark_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBikePark.DeleteCommand

    Dim id As Integer = dgBikePark.DataKeys(e.Item.ItemIndex)
    'Eliminare tutti gli allegati
    Dim comDelAtt As New SqlClient.SqlCommand("Delete From BikePark_Allegati Where IdAnagrafica = @IdAnagrafica", con)
    comDelAtt.Parameters.Add("@IdAnagrafica", SqlDbType.Int).Value = id
    'Eliminare tutte le note
    Dim comDelNote As New SqlClient.SqlCommand("Delete From BikePark_Note Where IdAnagrafica = @IdAnagrafica", con)
    comDelNote.Parameters.Add("@IdAnagrafica", SqlDbType.Int).Value = id
    'eliminare l'anagrafica
    con.Open()
    comDelAtt.ExecuteNonQuery()
    comDelNote.ExecuteNonQuery()
    con.Close()
    DsBiglietterie1.Tables("BikeParkLista").Rows.Find(id).Delete()
    DaBikePark.Update(DsBiglietterie1)
    dgBikePark.DataBind()

  End Sub

  Private Sub dgBikePark_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgBikePark.ItemCreated

    If Not e.Item.FindControl("btnDelete") Is Nothing Then
      DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "javascript: return confirm('Attenzione! Verranno eliminate anche eventuali note ed allegati.\nProcedere?');")
    End If

  End Sub

  Private Sub dgBikePark_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBikePark.SelectedIndexChanged
    Response.Redirect("wf_bikepark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(dgBikePark.DataKeys(dgBikePark.SelectedIndex)))
  End Sub

  Private Sub dgBikePark_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgBikePark.PageIndexChanged
    dgBikePark.CurrentPageIndex = e.NewPageIndex
    dgBikePark.DataBind()
  End Sub

End Class
