Public Class wf_bikepark
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
    Me.DaBikePark = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DaAllegatiBP = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DaNoteBP = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    Me.DvNoteBP = New System.Data.DataView
    Me.DvAllegatiBP = New System.Data.DataView
    Me.comInsAtt = New System.Data.SqlClient.SqlCommand
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DvNoteBP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DvAllegatiBP, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'DaBikePark
    '
    Me.DaBikePark.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaBikePark.InsertCommand = Me.SqlInsertCommand2
    Me.DaBikePark.SelectCommand = Me.SqlSelectCommand2
    Me.DaBikePark.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BikePark", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("DATA", "DATA"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("DATA_NASCITA", "DATA_NASCITA"), New System.Data.Common.DataColumnMapping("RES_VIA", "RES_VIA"), New System.Data.Common.DataColumnMapping("RES_N_CIV", "RES_N_CIV"), New System.Data.Common.DataColumnMapping("RES_CAP", "RES_CAP"), New System.Data.Common.DataColumnMapping("RES_ID_CIT", "RES_ID_CIT"), New System.Data.Common.DataColumnMapping("RES_CIT", "RES_CIT"), New System.Data.Common.DataColumnMapping("RES_PROV", "RES_PROV"), New System.Data.Common.DataColumnMapping("TEL", "TEL"), New System.Data.Common.DataColumnMapping("CEL", "CEL"), New System.Data.Common.DataColumnMapping("DOM_RES", "DOM_RES"), New System.Data.Common.DataColumnMapping("DOM_VIA", "DOM_VIA"), New System.Data.Common.DataColumnMapping("DOM_N_CIV", "DOM_N_CIV"), New System.Data.Common.DataColumnMapping("DOM_CAP", "DOM_CAP"), New System.Data.Common.DataColumnMapping("DOM_ID_CIT", "DOM_ID_CIT"), New System.Data.Common.DataColumnMapping("DOM_CIT", "DOM_CIT"), New System.Data.Common.DataColumnMapping("DOM_PROV", "DOM_PROV"), New System.Data.Common.DataColumnMapping("DOCUMENTO_TIPO", "DOCUMENTO_TIPO"), New System.Data.Common.DataColumnMapping("DOCUMENTO_NUM", "DOCUMENTO_NUM"), New System.Data.Common.DataColumnMapping("CODICEFISCALE", "CODICEFISCALE"), New System.Data.Common.DataColumnMapping("TESSERA", "TESSERA"), New System.Data.Common.DataColumnMapping("REGIONE", "REGIONE"), New System.Data.Common.DataColumnMapping("DATAINSERIMENTO", "DATAINSERIMENTO"), New System.Data.Common.DataColumnMapping("IdUtente", "IdUtente"), New System.Data.Common.DataColumnMapping("Cauzione", "Cauzione")})})
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
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.BikePark (ID, DATA, MATRICOLA, COGNOME, NOME, DATA_NASCITA, RES_V" & _
    "IA, RES_N_CIV, RES_CAP, RES_ID_CIT, RES_CIT, RES_PROV, TEL, CEL, DOM_RES, DOM_VI" & _
    "A, DOM_N_CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_" & _
    "NUM, CODICEFISCALE, TESSERA, REGIONE, IdUtente, Cauzione) VALUES (@ID, @DATA, @M" & _
    "ATRICOLA, @COGNOME, @NOME, @DATA_NASCITA, @RES_VIA, @RES_N_CIV, @RES_CAP, @RES_I" & _
    "D_CIT, @RES_CIT, @RES_PROV, @TEL, @CEL, @DOM_RES, @DOM_VIA, @DOM_N_CIV, @DOM_CAP" & _
    ", @DOM_ID_CIT, @DOM_CIT, @DOM_PROV, @DOCUMENTO_TIPO, @DOCUMENTO_NUM, @CODICEFISC" & _
    "ALE, @TESSERA, @REGIONE, @IdUtente, @Cauzione); SELECT ID, DATA, MATRICOLA, COGN" & _
    "OME, NOME, DATA_NASCITA, RES_VIA, RES_N_CIV, RES_CAP, RES_ID_CIT, RES_CIT, RES_P" & _
    "ROV, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PR" & _
    "OV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CODICEFISCALE, TESSERA, REGIONE, DATAINSERIME" & _
    "NTO, IdUtente, Cauzione FROM dbo.BikePark WHERE (ID = @ID)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA", System.Data.SqlDbType.DateTime, 8, "DATA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_NASCITA", System.Data.SqlDbType.DateTime, 8, "DATA_NASCITA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_VIA", System.Data.SqlDbType.VarChar, 100, "RES_VIA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_N_CIV", System.Data.SqlDbType.VarChar, 10, "RES_N_CIV"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CAP", System.Data.SqlDbType.VarChar, 5, "RES_CAP"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_ID_CIT", System.Data.SqlDbType.VarChar, 6, "RES_ID_CIT"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_CIT", System.Data.SqlDbType.VarChar, 50, "RES_CIT"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RES_PROV", System.Data.SqlDbType.VarChar, 2, "RES_PROV"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TEL", System.Data.SqlDbType.VarChar, 50, "TEL"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CEL", System.Data.SqlDbType.VarChar, 50, "CEL"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_RES", System.Data.SqlDbType.Bit, 1, "DOM_RES"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_VIA", System.Data.SqlDbType.VarChar, 100, "DOM_VIA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_N_CIV", System.Data.SqlDbType.VarChar, 10, "DOM_N_CIV"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CAP", System.Data.SqlDbType.VarChar, 5, "DOM_CAP"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_ID_CIT", System.Data.SqlDbType.VarChar, 6, "DOM_ID_CIT"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_CIT", System.Data.SqlDbType.VarChar, 50, "DOM_CIT"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOM_PROV", System.Data.SqlDbType.VarChar, 2, "DOM_PROV"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_TIPO", System.Data.SqlDbType.Int, 4, "DOCUMENTO_TIPO"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DOCUMENTO_NUM", System.Data.SqlDbType.VarChar, 50, "DOCUMENTO_NUM"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, "CODICEFISCALE"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TESSERA", System.Data.SqlDbType.VarChar, 10, "TESSERA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@REGIONE", System.Data.SqlDbType.Bit, 1, "REGIONE"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdUtente"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cauzione", System.Data.SqlDbType.Float, 8, "Cauzione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT ID, DATA, MATRICOLA, COGNOME, NOME, DATA_NASCITA, RES_VIA, RES_N_CIV, RES_" & _
    "CAP, RES_ID_CIT, RES_CIT, RES_PROV, TEL, CEL, DOM_RES, DOM_VIA, DOM_N_CIV, DOM_C" & _
    "AP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CODICEFISCALE," & _
    " TESSERA, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione FROM dbo.BikePark WHERE (" & _
    "ID = @ID)"
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.BikePark SET ID = @ID, DATA = @DATA, MATRICOLA = @MATRICOLA, COGNOME =" & _
    " @COGNOME, NOME = @NOME, DATA_NASCITA = @DATA_NASCITA, RES_VIA = @RES_VIA, RES_N" & _
    "_CIV = @RES_N_CIV, RES_CAP = @RES_CAP, RES_ID_CIT = @RES_ID_CIT, RES_CIT = @RES_" & _
    "CIT, RES_PROV = @RES_PROV, TEL = @TEL, CEL = @CEL, DOM_RES = @DOM_RES, DOM_VIA =" & _
    " @DOM_VIA, DOM_N_CIV = @DOM_N_CIV, DOM_CAP = @DOM_CAP, DOM_ID_CIT = @DOM_ID_CIT," & _
    " DOM_CIT = @DOM_CIT, DOM_PROV = @DOM_PROV, DOCUMENTO_TIPO = @DOCUMENTO_TIPO, DOC" & _
    "UMENTO_NUM = @DOCUMENTO_NUM, CODICEFISCALE = @CODICEFISCALE, TESSERA = @TESSERA," & _
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
    "CIV, DOM_CAP, DOM_ID_CIT, DOM_CIT, DOM_PROV, DOCUMENTO_TIPO, DOCUMENTO_NUM, CODI" & _
    "CEFISCALE, TESSERA, REGIONE, DATAINSERIMENTO, IdUtente, Cauzione FROM dbo.BikePa" & _
    "rk WHERE (ID = @ID)"
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
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CODICEFISCALE", System.Data.SqlDbType.VarChar, 16, "CODICEFISCALE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TESSERA", System.Data.SqlDbType.VarChar, 10, "TESSERA"))
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
    'DaAllegatiBP
    '
    Me.DaAllegatiBP.DeleteCommand = Me.SqlDeleteCommand3
    Me.DaAllegatiBP.InsertCommand = Me.SqlInsertCommand3
    Me.DaAllegatiBP.SelectCommand = Me.SqlSelectCommand3
    Me.DaAllegatiBP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BikePark_Allegati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("FileName", "FileName"), New System.Data.Common.DataColumnMapping("Extension", "Extension")})})
    Me.DaAllegatiBP.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.BikePark_Allegati WHERE (Id = @Original_Id) AND (Description = @O" & _
    "riginal_Description OR @Original_Description IS NULL AND Description IS NULL) AN" & _
    "D (Extension = @Original_Extension OR @Original_Extension IS NULL AND Extension " & _
    "IS NULL) AND (FileName = @Original_FileName OR @Original_FileName IS NULL AND Fi" & _
    "leName IS NULL) AND (IdAnagrafica = @Original_IdAnagrafica OR @Original_IdAnagra" & _
    "fica IS NULL AND IdAnagrafica IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extension", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.BikePark_Allegati(Id, IdAnagrafica, Description, FileName, Extens" & _
    "ion) VALUES (@Id, @IdAnagrafica, @Description, @FileName, @Extension); SELECT Id" & _
    ", IdAnagrafica, Description, FileName, Extension FROM dbo.BikePark_Allegati WHER" & _
    "E (Id = @Id)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.VarChar, 255, "FileName"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.VarChar, 10, "Extension"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT Id, IdAnagrafica, Description, FileName, Extension FROM dbo.BikePark_Alleg" & _
    "ati WHERE (IdAnagrafica = @Id)"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.BikePark_Allegati SET Id = @Id, IdAnagrafica = @IdAnagrafica, Descript" & _
    "ion = @Description, FileName = @FileName, Extension = @Extension WHERE (Id = @Or" & _
    "iginal_Id) AND (Description = @Original_Description OR @Original_Description IS " & _
    "NULL AND Description IS NULL) AND (Extension = @Original_Extension OR @Original_" & _
    "Extension IS NULL AND Extension IS NULL) AND (FileName = @Original_FileName OR @" & _
    "Original_FileName IS NULL AND FileName IS NULL) AND (IdAnagrafica = @Original_Id" & _
    "Anagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL); SELECT I" & _
    "d, IdAnagrafica, Description, FileName, Extension FROM dbo.BikePark_Allegati WHE" & _
    "RE (Id = @Id)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.VarChar, 255, "FileName"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.VarChar, 10, "Extension"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extension", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FileName", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FileName", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaNoteBP
    '
    Me.DaNoteBP.DeleteCommand = Me.SqlDeleteCommand4
    Me.DaNoteBP.InsertCommand = Me.SqlInsertCommand4
    Me.DaNoteBP.SelectCommand = Me.SqlSelectCommand4
    Me.DaNoteBP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BikePark_Note", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAnagrafica", "IdAnagrafica"), New System.Data.Common.DataColumnMapping("IdTipoNota", "IdTipoNota"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Nota", "Nota")})})
    Me.DaNoteBP.UpdateCommand = Me.SqlUpdateCommand4
    '
    'SqlDeleteCommand4
    '
    Me.SqlDeleteCommand4.CommandText = "DELETE FROM dbo.BikePark_Note WHERE (Id = @Original_Id) AND (Data = @Original_Dat" & _
    "a OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica = @Original_IdAn" & _
    "agrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL) AND (IdTipo" & _
    "Nota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND IdTipoNota IS NU" & _
    "LL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL)"
    Me.SqlDeleteCommand4.Connection = Me.con
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand4
    '
    Me.SqlInsertCommand4.CommandText = "INSERT INTO dbo.BikePark_Note(Id, IdAnagrafica, IdTipoNota, Data, Nota) VALUES (@" & _
    "Id, @IdAnagrafica, @IdTipoNota, @Data, @Nota); SELECT Id, IdAnagrafica, IdTipoNo" & _
    "ta, Data, Nota FROM dbo.BikePark_Note WHERE (Id = @Id)"
    Me.SqlInsertCommand4.Connection = Me.con
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT N.Id, N.IdAnagrafica, N.IdTipoNota, T.Tipo, N.Data, N.Nota FROM dbo.BikePa" & _
    "rk_Note N INNER JOIN dbo.BikePark_TipoNota T ON N.IdTipoNota = T.IdTipoNota WHER" & _
    "E (N.IdAnagrafica = @IdAnagrafica)"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    '
    'SqlUpdateCommand4
    '
    Me.SqlUpdateCommand4.CommandText = "UPDATE dbo.BikePark_Note SET Id = @Id, IdAnagrafica = @IdAnagrafica, IdTipoNota =" & _
    " @IdTipoNota, Data = @Data, Nota = @Nota WHERE (Id = @Original_Id) AND (Data = @" & _
    "Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (IdAnagrafica = @O" & _
    "riginal_IdAnagrafica OR @Original_IdAnagrafica IS NULL AND IdAnagrafica IS NULL)" & _
    " AND (IdTipoNota = @Original_IdTipoNota OR @Original_IdTipoNota IS NULL AND IdTi" & _
    "poNota IS NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS" & _
    " NULL); SELECT Id, IdAnagrafica, IdTipoNota, Data, Nota FROM dbo.BikePark_Note W" & _
    "HERE (Id = @Id)"
    Me.SqlUpdateCommand4.Connection = Me.con
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoNota", System.Data.SqlDbType.Int, 4, "IdTipoNota"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.VarChar, 1000, "Nota"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAnagrafica", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAnagrafica", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoNota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoNota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DvNoteBP
    '
    Me.DvNoteBP.Table = Me.DsBiglietterie1.BikePark_Note
    '
    'DvAllegatiBP
    '
    Me.DvAllegatiBP.Table = Me.DsBiglietterie1.BikePark_Allegati
    '
    'comInsAtt
    '
    Me.comInsAtt.CommandText = "INSERT INTO dbo.BikePark_Allegati (Id, IdAnagrafica, Description, FileName, Exten" & _
    "sion) VALUES (@ID, @IdAnagrafica, @Description, @FileName, @Extension)"
    Me.comInsAtt.Connection = Me.con
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAnagrafica", System.Data.SqlDbType.Int, 4, "IdAnagrafica"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50, "Description"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", System.Data.SqlDbType.VarChar, 255, "FileName"))
    Me.comInsAtt.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.VarChar, 10, "Extension"))
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DvNoteBP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DvAllegatiBP, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents TxtIdUtente As System.Web.UI.WebControls.TextBox
  Protected WithEvents LblCauzioen As System.Web.UI.WebControls.Label
  Protected WithEvents txtCauzione As System.Web.UI.WebControls.TextBox
  Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblDataNascita As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDataNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvDataNascita As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents lblResidenzaVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvVia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblResidenzaCivico As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaCivico As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvCivico As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblResidenzaCap As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaCAP As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvCAP As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblResidenzaComune As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaComune As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvComune As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblResidenzaProvincia As System.Web.UI.WebControls.Label
  Protected WithEvents txtResidenzaProvincia As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvProvincia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblFisso As System.Web.UI.WebControls.Label
  Protected WithEvents txtFisso As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCellulare As System.Web.UI.WebControls.Label
  Protected WithEvents txtCellulare As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblTipoDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents ddlTipoDocumento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents rfvTipoDocumento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblNumeroDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents txtNumeroDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvNumeroDocumento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lnkBack As System.Web.UI.WebControls.LinkButton
  Protected WithEvents btnSalva As System.Web.UI.WebControls.Button
  Protected WithEvents dgAllegati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblFileDocumento As System.Web.UI.WebControls.Label
  Protected WithEvents btnSalva3 As System.Web.UI.WebControls.Button
  Protected WithEvents lnkBack3 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents txtID As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents lkStampa As System.Web.UI.HtmlControls.HtmlAnchor
  Protected WithEvents fileDocumento As System.Web.UI.HtmlControls.HtmlInputFile
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daTipoDocumento As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaBikePark As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaAllegatiBP As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DaNoteBP As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents DvNoteBP As System.Data.DataView
  Protected WithEvents DvAllegatiBP As System.Data.DataView
  Protected WithEvents comInsAtt As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblTessera As System.Web.UI.WebControls.Label
  Protected WithEvents txtTessera As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvTessera As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvChiaveGiaAssegnata As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents lblCodiceFiscale As System.Web.UI.WebControls.Label
  Protected WithEvents txtCodiceFiscale As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvCodiceFiscale As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents CVProvinciaBO As System.Web.UI.WebControls.CustomValidator

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
    End If
    If txtID.Value.Length <= 0 Then
      lkStampa.Visible = False

      If Not IsPostBack Then
        Dim dr As DataRow = DsBiglietterie1.Tables("BikePark").NewRow
        dr("ID") = -1

        dr("DOM_RES") = 0
        dr("Regione") = 0
        dr("Res_CAP") = "40100"
        dr("Res_Cit") = "BOLOGNA"
        dr("Res_Prov") = "BO"
        dr("Dom_CAP") = "40100"
        dr("Dom_Cit") = "BOLOGNA"
        dr("Dom_Prov") = "BO"
        dr("Cauzione") = 50
        dr("IdUtente") = DirectCast(Session("User"), Utente).ID
        DsBiglietterie1.Tables("BikePark").Rows.Add(dr)
      End If
    Else
      lkStampa.Visible = True

      DaAllegatiBP.SelectCommand.Parameters("@ID").Value = txtID.Value
      DaAllegatiBP.Fill(DsBiglietterie1)
      DaBikePark.SelectCommand.Parameters("@ID").Value = txtID.Value
      DaBikePark.Fill(DsBiglietterie1)
    End If
    If Not IsPostBack Then
      Page.DataBind()
      If txtID.Value.Length > 0 Then

        If Not DsBiglietterie1.Tables("BikePark").Rows(0)("Documento_Tipo") Is DBNull.Value Then
          If DsBiglietterie1.Tables("BikePark").Rows(0)("Documento_Tipo") <> 0 Then ddlTipoDocumento.SelectedValue = DsBiglietterie1.Tables("BikePark").Rows(0)("Documento_Tipo")
        End If

      Else


      End If

      ddlTipoDocumento.Items.Insert(0, New ListItem("[Nessuna selezione]", ""))
    End If
    'RitornaOperatore()
  End Sub

  Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
    If Me.IsValid Then
      pSave()
    End If
  End Sub

  'Private Sub cvDomicilio_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = txtResidenzaProvincia.Text.ToUpper.Trim = "BO"
  '  rfvDomicilioVia.Enabled = Not args.IsValid
  '  If rfvDomicilioVia.Enabled Then rfvDomicilioVia.Validate()
  '  rfvDomicilioCivico.Enabled = Not args.IsValid
  '  If rfvDomicilioCivico.Enabled Then rfvDomicilioCivico.Validate()
  '  rfvDomicilioCAP.Enabled = Not args.IsValid
  '  If rfvDomicilioCAP.Enabled Then rfvDomicilioCAP.Validate()
  '  args.IsValid = Me.IsValid
  'End Sub

  Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack.Click
    Response.Redirect("wf_cercaBikePark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
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
      DsBiglietterie1.Tables("BikePark_Allegati").Clear()
      DaAllegatiBP.SelectCommand.Parameters("@ID").Value = txtID.Value
      DaAllegatiBP.Fill(DsBiglietterie1)
      dgAllegati.DataBind()
    End If
  End Sub

  Private Sub lnkBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack3.Click
    Response.Redirect("wf_cercaBikePark.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleId")))
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
    DsBiglietterie1.Tables("BikePark_Allegati").Rows.Find(dgAllegati.DataKeys(e.Item.ItemIndex)).Delete()
    DaAllegatiBP.Update(DsBiglietterie1)
    DsBiglietterie1.Tables("BikePark_Allegati").Clear()
    DaAllegatiBP.SelectCommand.Parameters("@ID").Value = txtID.Value
    DaAllegatiBP.Fill(DsBiglietterie1)
    dgAllegati_CancelCommand(source, e)
  End Sub

  Private Sub dgAllegati_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAllegati.UpdateCommand
    Dim dr As DataRow = DsBiglietterie1.Tables("BikePark_Allegati").Rows.Find(dgAllegati.DataKeys(e.Item.ItemIndex))
    dr("Description") = DirectCast(e.Item.FindControl("txtDescription"), TextBox).Text
    DaAllegatiBP.Update(DsBiglietterie1)
    dgAllegati_CancelCommand(source, e)
  End Sub

  Private Sub pSave()
    Dim dr As DataRow
    If txtID.Value.Length <= 0 Then
      dr = DsBiglietterie1.Tables("BikePark").NewRow
      Dim comSelID As New SqlClient.SqlCommand("Select ISNULL(Max(id),0) + 1 From BikePark", con)
      con.Open()
      txtID.Value = comSelID.ExecuteScalar
      con.Close()
      dr("ID") = txtID.Value

      dr("DOM_RES") = 0
      dr("Regione") = 0
      DsBiglietterie1.Tables("BikePark").Rows.Add(dr)
    Else
      dr = DsBiglietterie1.Tables("BikePark").Rows.Find(txtID.Value)
    End If
    dr("Cognome") = IIf(txtCognome.Text.Trim.Length > 0, txtCognome.Text.Trim.ToUpper, DBNull.Value)
    dr("Nome") = IIf(txtNome.Text.Trim.Length > 0, txtNome.Text.ToUpper, DBNull.Value)
    dr("Matricola") = DirectCast(Session("User"), Utente).IDUser
    dr("Data_Nascita") = IIf(txtDataNascita.Text.Trim.Length > 0, txtDataNascita.Text.Trim.ToUpper, DBNull.Value)

    dr("Res_Via") = IIf(txtResidenzaVia.Text.Trim.Length > 0, txtResidenzaVia.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_N_Civ") = IIf(txtResidenzaCivico.Text.Trim.Length > 0, txtResidenzaCivico.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Cap") = IIf(txtResidenzaCAP.Text.Trim.Length > 0, txtResidenzaCAP.Text.Trim.ToUpper, DBNull.Value)

    dr("Res_Cit") = IIf(txtResidenzaComune.Text.Trim.Length > 0, txtResidenzaComune.Text.Trim.ToUpper, DBNull.Value)
    dr("Res_Prov") = IIf(txtResidenzaProvincia.Text.Trim.Length > 0, txtResidenzaProvincia.Text.Trim.ToUpper, DBNull.Value)

    dr("Cel") = IIf(txtCellulare.Text.Trim.Length > 0, txtCellulare.Text.Trim.ToUpper, DBNull.Value)
    'dr("Dom_Via") = IIf(txtDomicilioVia.Text.Trim.Length > 0, txtDomicilioVia.Text.Trim.ToUpper, DBNull.Value)
    'dr("Dom_N_Civ") = IIf(txtDomicilioCivico.Text.Trim.Length > 0, txtDomicilioCivico.Text.Trim.ToUpper, DBNull.Value)
    'dr("Dom_Cap") = IIf(txtDomicilioCAP.Text.Trim.Length > 0, txtDomicilioCAP.Text.Trim.ToUpper, DBNull.Value)

    'dr("Dom_Cit") = IIf(TxtDomicilioComune.Text.Trim.Length > 0, TxtDomicilioComune.Text.Trim.ToUpper, DBNull.Value)
    'dr("Dom_Prov") = IIf(txtDomicilioProvincia.Text.Trim.Length > 0, txtDomicilioProvincia.Text.Trim.ToUpper, DBNull.Value)
    dr("Documento_Tipo") = IIf(ddlTipoDocumento.SelectedValue.Length > 0, ddlTipoDocumento.SelectedValue, DBNull.Value)
    dr("Documento_Num") = IIf(txtNumeroDocumento.Text.Trim.Length > 0, txtNumeroDocumento.Text.Trim.ToUpper, DBNull.Value)
    dr("CODICEFISCALE") = IIf(txtCodiceFiscale.Text.Trim.Length > 0, txtCodiceFiscale.Text.Trim.ToUpper, DBNull.Value)

    dr("Tessera") = IIf(txtTessera.Text.Trim.Length > 0, txtTessera.Text.Trim.ToUpper, DBNull.Value)
    dr("Cauzione") = IIf(txtCauzione.Text.Trim.Length > 0, CDbl(txtCauzione.Text.Trim), DBNull.Value)
    dr("IdUtente") = IIf(TxtIdUtente.Text.Trim.Length > 0, TxtIdUtente.Text.Trim, DirectCast(Session("User"), Utente).ID)
    DaBikePark.Update(DsBiglietterie1)
    lkStampa.Visible = True

  End Sub

  Private Sub dgAllegati_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgAllegati.PageIndexChanged
    dgAllegati.CurrentPageIndex = e.NewPageIndex
    dgAllegati.EditItemIndex = -1
    dgAllegati.DataBind()
  End Sub

  Private Sub CVProvinciaBO_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CVProvinciaBO.ServerValidate
    args.IsValid = txtResidenzaProvincia.Text.Trim.ToUpper = "BO"
  End Sub
End Class
