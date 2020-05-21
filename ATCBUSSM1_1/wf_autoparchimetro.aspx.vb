Imports System.Data.SqlClient
Public Class wf_autoparchimetro
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
    Me.daAutoparchimetri = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    Me.dvAutoparchimetri = New System.Data.DataView
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.daTipi = New System.Data.SqlClient.SqlDataAdapter
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvAutoparchimetri, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.daUtente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AutoParchimetri_Anagrafica", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMERATORE", "NUMERATORE"), New System.Data.Common.DataColumnMapping("DATA_INSERIMENTO", "DATA_INSERIMENTO"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("VIA", "VIA"), New System.Data.Common.DataColumnMapping("NUMEROVIA", "NUMEROVIA"), New System.Data.Common.DataColumnMapping("CITTA", "CITTA"), New System.Data.Common.DataColumnMapping("CAP", "CAP"), New System.Data.Common.DataColumnMapping("TELEFONO", "TELEFONO"), New System.Data.Common.DataColumnMapping("MAIL", "MAIL"), New System.Data.Common.DataColumnMapping("DSI", "DSI")})})
    Me.daUtente.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.AutoParchimetri_Anagrafiche WHERE (NUMERATORE = @Original_NUMERAT" & _
    "ORE) AND (CAP = @Original_CAP OR @Original_CAP IS NULL AND CAP IS NULL) AND (CIT" & _
    "TA = @Original_CITTA OR @Original_CITTA IS NULL AND CITTA IS NULL) AND (COGNOME " & _
    "= @Original_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) AND (DATA_" & _
    "INSERIMENTO = @Original_DATA_INSERIMENTO OR @Original_DATA_INSERIMENTO IS NULL A" & _
    "ND DATA_INSERIMENTO IS NULL) AND (DSI = @Original_DSI OR @Original_DSI IS NULL A" & _
    "ND DSI IS NULL) AND (MAIL = @Original_MAIL OR @Original_MAIL IS NULL AND MAIL IS" & _
    " NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRICOLA IS NULL AND M" & _
    "ATRICOLA IS NULL) AND (NOME = @Original_NOME OR @Original_NOME IS NULL AND NOME " & _
    "IS NULL) AND (NUMEROVIA = @Original_NUMEROVIA OR @Original_NUMEROVIA IS NULL AND" & _
    " NUMEROVIA IS NULL) AND (TELEFONO = @Original_TELEFONO OR @Original_TELEFONO IS " & _
    "NULL AND TELEFONO IS NULL) AND (VIA = @Original_VIA OR @Original_VIA IS NULL AND" & _
    " VIA IS NULL) AND (ATTIVA = @Original_ATTIVA OR @Original_ATTIVA IS NULL AND ATT" & _
    "IVA IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CITTA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CITTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_INSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MAIL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAIL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMEROVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMEROVIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TELEFONO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VIA", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ATTIVA", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ATTIVA", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.AutoParchimetri_Anagrafiche (NUMERATORE, DATA_INSERIMENTO, MATRIC" & _
    "OLA, COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL, DSI, ATTIVA) VAL" & _
    "UES (@NUMERATORE, @DATA_INSERIMENTO, @MATRICOLA, @COGNOME, @NOME, @VIA, @NUMEROV" & _
    "IA, @CITTA, @CAP, @TELEFONO, @MAIL, @DSI, @ATTIVA); SELECT NUMERATORE, DATA_INSE" & _
    "RIMENTO, MATRICOLA, COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL, D" & _
    "SI, ATTIVA FROM dbo.AutoParchimetri_Anagrafiche WHERE (NUMERATORE = @NUMERATORE)" & _
    ""
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMERATORE", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATA_INSERIMENTO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VIA", System.Data.SqlDbType.VarChar, 255, "VIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMEROVIA", System.Data.SqlDbType.VarChar, 50, "NUMEROVIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CITTA", System.Data.SqlDbType.VarChar, 50, "CITTA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CAP", System.Data.SqlDbType.VarChar, 5, "CAP"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TELEFONO", System.Data.SqlDbType.VarChar, 50, "TELEFONO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MAIL", System.Data.SqlDbType.VarChar, 50, "MAIL"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ATTIVA", System.Data.SqlDbType.Bit, 1, "ATTIVA"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT NUMERATORE, DATA_INSERIMENTO, MATRICOLA, COGNOME, NOME, VIA, NUMEROVIA, CI" & _
    "TTA, CAP, TELEFONO, MAIL, DSI, ATTIVA FROM dbo.AutoParchimetri_Anagrafiche WHERE" & _
    " (NUMERATORE = @Numeratore)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numeratore", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.AutoParchimetri_Anagrafiche SET NUMERATORE = @NUMERATORE, DATA_INSERIM" & _
    "ENTO = @DATA_INSERIMENTO, MATRICOLA = @MATRICOLA, COGNOME = @COGNOME, NOME = @NO" & _
    "ME, VIA = @VIA, NUMEROVIA = @NUMEROVIA, CITTA = @CITTA, CAP = @CAP, TELEFONO = @" & _
    "TELEFONO, MAIL = @MAIL, DSI = @DSI, ATTIVA = @ATTIVA WHERE (NUMERATORE = @Origin" & _
    "al_NUMERATORE) AND (CAP = @Original_CAP OR @Original_CAP IS NULL AND CAP IS NULL" & _
    ") AND (CITTA = @Original_CITTA OR @Original_CITTA IS NULL AND CITTA IS NULL) AND" & _
    " (COGNOME = @Original_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) " & _
    "AND (DATA_INSERIMENTO = @Original_DATA_INSERIMENTO OR @Original_DATA_INSERIMENTO" & _
    " IS NULL AND DATA_INSERIMENTO IS NULL) AND (DSI = @Original_DSI OR @Original_DSI" & _
    " IS NULL AND DSI IS NULL) AND (MAIL = @Original_MAIL OR @Original_MAIL IS NULL A" & _
    "ND MAIL IS NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRICOLA IS " & _
    "NULL AND MATRICOLA IS NULL) AND (NOME = @Original_NOME OR @Original_NOME IS NULL" & _
    " AND NOME IS NULL) AND (NUMEROVIA = @Original_NUMEROVIA OR @Original_NUMEROVIA I" & _
    "S NULL AND NUMEROVIA IS NULL) AND (TELEFONO = @Original_TELEFONO OR @Original_TE" & _
    "LEFONO IS NULL AND TELEFONO IS NULL) AND (VIA = @Original_VIA OR @Original_VIA I" & _
    "S NULL AND VIA IS NULL) AND (ATTIVA = @Original_ATTIVA OR @Original_ATTIVA IS NU" & _
    "LL AND ATTIVA IS NULL); SELECT NUMERATORE, DATA_INSERIMENTO, MATRICOLA, COGNOME," & _
    " NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL, DSI, ATTIVA FROM dbo.AutoParc" & _
    "himetri_Anagrafiche WHERE (NUMERATORE = @NUMERATORE)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMERATORE", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATA_INSERIMENTO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VIA", System.Data.SqlDbType.VarChar, 255, "VIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMEROVIA", System.Data.SqlDbType.VarChar, 50, "NUMEROVIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CITTA", System.Data.SqlDbType.VarChar, 50, "CITTA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CAP", System.Data.SqlDbType.VarChar, 5, "CAP"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TELEFONO", System.Data.SqlDbType.VarChar, 50, "TELEFONO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MAIL", System.Data.SqlDbType.VarChar, 50, "MAIL"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ATTIVA", System.Data.SqlDbType.Bit, 1, "ATTIVA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CITTA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CITTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_INSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MAIL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAIL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMEROVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMEROVIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TELEFONO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VIA", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ATTIVA", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ATTIVA", System.Data.DataRowVersion.Original, Nothing))
    '
    'daAutoparchimetri
    '
    Me.daAutoparchimetri.DeleteCommand = Me.SqlDeleteCommand2
    Me.daAutoparchimetri.InsertCommand = Me.SqlInsertCommand2
    Me.daAutoparchimetri.SelectCommand = Me.SqlSelectCommand2
    Me.daAutoparchimetri.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AutoParchimetri_Venduti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AUTO", "ID_AUTO"), New System.Data.Common.DataColumnMapping("NUMERATORE", "NUMERATORE"), New System.Data.Common.DataColumnMapping("MATAUTO", "MATAUTO"), New System.Data.Common.DataColumnMapping("DSI", "DSI"), New System.Data.Common.DataColumnMapping("DATAVENDITA", "DATAVENDITA"), New System.Data.Common.DataColumnMapping("DATARESO", "DATARESO")})})
    Me.daAutoparchimetri.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.AutoParchimetri_Venduti WHERE (ID_AUTO = @Original_ID_AUTO) AND (" & _
    "DATARESO = @Original_DATARESO OR @Original_DATARESO IS NULL AND DATARESO IS NULL" & _
    ") AND (DATAVENDITA = @Original_DATAVENDITA OR @Original_DATAVENDITA IS NULL AND " & _
    "DATAVENDITA IS NULL) AND (DSI = @Original_DSI OR @Original_DSI IS NULL AND DSI I" & _
    "S NULL) AND (MATAUTO = @Original_MATAUTO OR @Original_MATAUTO IS NULL AND MATAUT" & _
    "O IS NULL) AND (NUMERATORE = @Original_NUMERATORE OR @Original_NUMERATORE IS NUL" & _
    "L AND NUMERATORE IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AUTO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AUTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATARESO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATARESO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAVENDITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAVENDITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATAUTO", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATAUTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.AutoParchimetri_Venduti(ID_AUTO, NUMERATORE, MATAUTO, DSI, DATAVE" & _
    "NDITA, DATARESO) VALUES (@ID_AUTO, @NUMERATORE, @MATAUTO, @DSI, @DATAVENDITA, @D" & _
    "ATARESO); SELECT ID_AUTO, NUMERATORE, MATAUTO, DSI, DATAVENDITA, DATARESO FROM d" & _
    "bo.AutoParchimetri_Venduti V WHERE (ID_AUTO = @ID_AUTO)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_AUTO", System.Data.SqlDbType.Int, 4, "ID_AUTO"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMERATORE", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATAUTO", System.Data.SqlDbType.VarChar, 8, "MATAUTO"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAVENDITA", System.Data.SqlDbType.DateTime, 8, "DATAVENDITA"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATARESO", System.Data.SqlDbType.DateTime, 8, "DATARESO"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT V.ID_AUTO, V.NUMERATORE, V.MATAUTO, V.DATAVENDITA, V.DATARESO, V.DSI, T.DS" & _
    "I AS Tipo FROM dbo.AutoParchimetri_Venduti V INNER JOIN dbo.AutoParchimetri_Tipi" & _
    " T ON V.DSI = T.ID_DSI WHERE (V.NUMERATORE = @Numeratore)"
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numeratore", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.AutoParchimetri_Venduti SET ID_AUTO = @ID_AUTO, NUMERATORE = @NUMERATO" & _
    "RE, MATAUTO = @MATAUTO, DSI = @DSI, DATAVENDITA = @DATAVENDITA, DATARESO = @DATA" & _
    "RESO WHERE (ID_AUTO = @Original_ID_AUTO) AND (DATARESO = @Original_DATARESO OR @" & _
    "Original_DATARESO IS NULL AND DATARESO IS NULL) AND (DATAVENDITA = @Original_DAT" & _
    "AVENDITA OR @Original_DATAVENDITA IS NULL AND DATAVENDITA IS NULL) AND (DSI = @O" & _
    "riginal_DSI OR @Original_DSI IS NULL AND DSI IS NULL) AND (MATAUTO = @Original_M" & _
    "ATAUTO OR @Original_MATAUTO IS NULL AND MATAUTO IS NULL) AND (NUMERATORE = @Orig" & _
    "inal_NUMERATORE OR @Original_NUMERATORE IS NULL AND NUMERATORE IS NULL); SELECT " & _
    "ID_AUTO, NUMERATORE, MATAUTO, DSI, DATAVENDITA, DATARESO FROM dbo.AutoParchimetr" & _
    "i_Venduti V WHERE (ID_AUTO = @ID_AUTO)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_AUTO", System.Data.SqlDbType.Int, 4, "ID_AUTO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMERATORE", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATAUTO", System.Data.SqlDbType.VarChar, 8, "MATAUTO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATAVENDITA", System.Data.SqlDbType.DateTime, 8, "DATAVENDITA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATARESO", System.Data.SqlDbType.DateTime, 8, "DATARESO"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_AUTO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_AUTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATARESO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATARESO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATAVENDITA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAVENDITA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATAUTO", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATAUTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'dvAutoparchimetri
    '
    Me.dvAutoparchimetri.ApplyDefaultSort = True
    Me.dvAutoparchimetri.Sort = "DATAVENDITA Desc"
    Me.dvAutoparchimetri.Table = Me.DsBiglietterie1.AutoParchimetri_Venduti
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID_DSI, DSI FROM dbo.AutoParchimetri_Tipi"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.AutoParchimetri_Tipi(DSI) VALUES (@DSI); SELECT ID_DSI, DSI FROM " & _
    "dbo.AutoParchimetri_Tipi WHERE (ID_DSI = @@IDENTITY)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.VarChar, 10, "DSI"))
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.AutoParchimetri_Tipi SET DSI = @DSI WHERE (ID_DSI = @Original_ID_DSI) " & _
    "AND (DSI = @Original_DSI OR @Original_DSI IS NULL AND DSI IS NULL); SELECT ID_DS" & _
    "I, DSI FROM dbo.AutoParchimetri_Tipi WHERE (ID_DSI = @ID_DSI)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.VarChar, 10, "DSI"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_DSI", System.Data.SqlDbType.Int, 4, "ID_DSI"))
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.AutoParchimetri_Tipi WHERE (ID_DSI = @Original_ID_DSI) AND (DSI =" & _
    " @Original_DSI OR @Original_DSI IS NULL AND DSI IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    '
    'daTipi
    '
    Me.daTipi.DeleteCommand = Me.SqlDeleteCommand3
    Me.daTipi.InsertCommand = Me.SqlInsertCommand3
    Me.daTipi.SelectCommand = Me.SqlSelectCommand3
    Me.daTipi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AutoParchimetri_Tipi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_DSI", "ID_DSI"), New System.Data.Common.DataColumnMapping("DSI", "DSI")})})
    Me.daTipi.UpdateCommand = Me.SqlUpdateCommand3
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvAutoparchimetri, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents btnSalva As System.Web.UI.WebControls.Button
  Protected WithEvents lblCognome As System.Web.UI.WebControls.Label
  Protected WithEvents txtCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNome As System.Web.UI.WebControls.Label
  Protected WithEvents txtNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCivico As System.Web.UI.WebControls.Label
  Protected WithEvents txtCivico As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCitta As System.Web.UI.WebControls.Label
  Protected WithEvents lblCAP As System.Web.UI.WebControls.Label
  Protected WithEvents txtCAP As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblTelefono As System.Web.UI.WebControls.Label
  Protected WithEvents txtTelefono As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblEmail As System.Web.UI.WebControls.Label
  Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnNuovo As System.Web.UI.WebControls.Button
  Protected WithEvents dgAutoparchimetri As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lnkBack As System.Web.UI.WebControls.LinkButton
  Protected WithEvents lnkBack2 As System.Web.UI.WebControls.LinkButton
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daUtente As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents daAutoparchimetri As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents dvAutoparchimetri As System.Data.DataView
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daTipi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents lblNoAutoparchimetri As System.Web.UI.WebControls.Label
  Protected WithEvents txtNumeratore As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents rfvCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revEmail As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents RfvCitta As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtCitta As System.Web.UI.WebControls.TextBox
  Protected WithEvents RfvVia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RfvN As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RfvCAP As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblAltreAna As System.Web.UI.WebControls.Label
  Protected WithEvents DGAltreAna As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblAttiva As System.Web.UI.WebControls.Label
  Protected WithEvents chkAttiva As System.Web.UI.WebControls.CheckBox

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
    If txtNumeratore.Value.Length <= 0 Then txtNumeratore.Value = "" & Request("ID")
    daTipi.Fill(DsBiglietterie1)
    If txtNumeratore.Value.Length > 0 Then
      daUtente.SelectCommand.Parameters("@Numeratore").Value = txtNumeratore.Value
      daAutoparchimetri.SelectCommand.Parameters("@Numeratore").Value = txtNumeratore.Value
      daUtente.Fill(DsBiglietterie1)
      daAutoparchimetri.Fill(DsBiglietterie1)
    ElseIf Not IsPostBack Then
      Dim dr As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").NewRow
      dr("Numeratore") = -1
      dr("Citta") = "BOLOGNA"
      dr("CAP") = "40100"
      dr("ATTIVA") = True
      DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").Rows.Add(dr)



    End If

    If Not IsPostBack Then
      Page.DataBind()
    End If
  End Sub

  Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack.Click
    Response.Redirect("wf_autoparchimetri.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub lnkBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkBack2.Click
    Response.Redirect("wf_autoparchimetri.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub btnSalva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalva.Click
    Dim dr As DataRow
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim con1 As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim strsql As String
    Dim strsqlesatto As String
    Dim strsqlcount As String
    Dim strsqlcountEsatto As String
    strsql = "SELECT NUMERATORE, COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL " & _
          "FROM AutoParchimetri_Anagrafiche " & _
          "WHERE (COGNOME = '" & txtCognome.Text.Replace("'", "''").Trim.ToUpper & "') AND (NOME = '" & txtNome.Text.Replace("'", "''").Trim.ToUpper & "') AND (CITTA = '" & txtCitta.Text.Replace("'", "''").Trim.ToUpper & "') AND (CAP = '" & txtCAP.Text.Replace("'", "''").Trim.ToUpper & "')"
    strsqlesatto = "SELECT NUMERATORE, COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL " & _
          "FROM AutoParchimetri_Anagrafiche " & _
          "WHERE (COGNOME = '" & txtCognome.Text.Replace("'", "''").Trim.ToUpper & "') AND (NOME = '" & txtNome.Text.Replace("'", "''").Trim.ToUpper & "') AND (VIA = '" & txtVia.Text.Replace("'", "''").Trim.ToUpper & "')  AND (CITTA = '" & txtCitta.Text.Replace("'", "''").Trim.ToUpper & "') AND (CAP = '" & txtCAP.Text.Replace("'", "''").Trim.ToUpper & "') AND (NUMEROVIA = '" & txtCivico.Text.Replace("'", "''").Trim.ToUpper & "')"


    strsqlcount = "SELECT count(*) as N " & _
      "FROM AutoParchimetri_Anagrafiche " & _
      "WHERE (COGNOME = '" & txtCognome.Text.Replace("'", "''").Trim.ToUpper & "') AND (NOME = '" & txtNome.Text.Replace("'", "''").Trim.ToUpper & "') AND (CITTA = '" & txtCitta.Text.Replace("'", "''").Trim.ToUpper & "') AND (CAP = '" & txtCAP.Text.Replace("'", "''").Trim.ToUpper & "')"
    strsqlcountEsatto = "SELECT count(*) as N " & _
       "FROM AutoParchimetri_Anagrafiche " & _
       "WHERE (COGNOME = '" & txtCognome.Text.Replace("'", "''").Trim.ToUpper & "') AND (NOME = '" & txtNome.Text.Replace("'", "''").Trim.ToUpper & "') AND (VIA = '" & txtVia.Text.Replace("'", "''").Trim.ToUpper & "') AND (CITTA = '" & txtCitta.Text.Replace("'", "''").Trim.ToUpper & "') AND (CAP = '" & txtCAP.Text.Replace("'", "''").Trim.ToUpper & "') AND (NUMEROVIA = '" & txtCivico.Text.Replace("'", "''").Trim.ToUpper & "')"

    Dim MyCommand As SqlDataAdapter
    Dim details = New DataSet
    Dim com As New SqlCommand(strsqlcount, con1)
    Dim com1 As New SqlCommand(strsqlcountEsatto, con1)
    If Me.IsValid Then

      Dim n As Int32
      Dim nesatto As Int32
      con1.Open()
      n = Convert.ToInt32(com.ExecuteScalar())
      nesatto = Convert.ToInt32(com1.ExecuteScalar())
      con1.Close()
      con1.Dispose()
      If nesatto > 0 And txtNumeratore.Value.Length <= 0 And (Not lblAltreAna.Visible) Then
        con.Open()

        MyCommand = New SqlDataAdapter(strsqlesatto, con)
        MyCommand.Fill(details)
        DGAltreAna.AutoGenerateColumns = False

        DGAltreAna.DataSource = details.Tables(0)
        DGAltreAna.DataBind()
        DGAltreAna.Visible = True
        lblAltreAna.Text = "Attenzione ci sono altre anagrafiche con lo stesso nome, cognome, via, numero civico, città e CAP. Cliccare sulla riga della anagrafica interessata."
        lblAltreAna.Visible = True
        Dim dr1 As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").NewRow
        'COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL
        dr1("Cognome") = txtCognome.Text.ToUpper.Trim
        dr1("Nome") = txtNome.Text.ToUpper.Trim
        dr1("Via") = txtVia.Text.ToUpper.Trim
        dr1("Numerovia") = txtCivico.Text.ToUpper.Trim
        dr1("Telefono") = txtTelefono.Text.ToUpper.Trim
        dr1("Mail") = txtEmail.Text.ToUpper.Trim
        dr1("Numeratore") = -1
        dr1("Citta") = txtCitta.Text.ToUpper.Trim
        dr1("CAP") = txtCAP.Text.ToUpper.Trim
        dr1("ATTIVA") = chkAttiva.Checked
        DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").Rows.Add(dr1)
        btnSalva.Attributes.Add("onclick", "javascript: return confirm('Sei sicuro di voler salvare e non scegliere una anagrafica esistente?');")

      ElseIf n > 0 And txtNumeratore.Value.Length <= 0 And (Not lblAltreAna.Visible) Then
        con.Open()

        MyCommand = New SqlDataAdapter(strsql, con)
        MyCommand.Fill(details)
        DGAltreAna.AutoGenerateColumns = False

        DGAltreAna.DataSource = details.Tables(0)
        DGAltreAna.DataBind()
        DGAltreAna.Visible = True
        lblAltreAna.Visible = True
        Dim dr1 As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").NewRow
        'COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL
        dr1("Cognome") = txtCognome.Text.ToUpper.Trim
        dr1("Nome") = txtNome.Text.ToUpper.Trim
        dr1("Via") = txtVia.Text.ToUpper.Trim
        dr1("Numerovia") = txtCivico.Text.ToUpper.Trim
        dr1("Telefono") = txtTelefono.Text.ToUpper.Trim
        dr1("Mail") = txtEmail.Text.ToUpper.Trim
        dr1("Numeratore") = -1
        dr1("Citta") = txtCitta.Text.ToUpper.Trim
        dr1("CAP") = txtCAP.Text.ToUpper.Trim
        dr1("ATTIVA") = chkAttiva.Checked
        DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").Rows.Add(dr1)

        btnSalva.Attributes.Add("onclick", "javascript: return confirm('Sei sicuro di voler salvare e non scegliere una anagrafica esistente?');")

        'Page.DataBind()
      Else
        lblAltreAna.Visible = False
        If txtNumeratore.Value.Length <= 0 Then
          dr = DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").NewRow
          Dim comNewID As New SqlClient.SqlCommand("Select Max(Numeratore) + 1 From AutoParchimetri_Anagrafiche", con)
          con.Open()
          dr("Numeratore") = comNewID.ExecuteScalar
          txtNumeratore.Value = dr("Numeratore")
          con.Close()

          DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").Rows.Add(dr)
        Else
          dr = DsBiglietterie1.Tables("AutoParchimetri_Anagrafica").Rows.Find(txtNumeratore.Value)
        End If
        dr("Matricola") = DirectCast(Session("User"), Utente).IDUser
        dr("DATA_INSERIMENTO") = Now
        dr("Cognome") = IIf(txtCognome.Text.Trim.Length > 0, txtCognome.Text.Trim.ToUpper, DBNull.Value)
        dr("Nome") = IIf(txtNome.Text.Trim.Length > 0, txtNome.Text.Trim.ToUpper, DBNull.Value)
        dr("Via") = IIf(txtVia.Text.Trim.Length > 0, txtVia.Text.Trim.ToUpper, DBNull.Value)
        dr("NumeroVia") = IIf(txtCivico.Text.Trim.Length > 0, txtCivico.Text.Trim.ToUpper, DBNull.Value)
        dr("Citta") = IIf(txtCitta.Text.Trim.Length > 0, txtCitta.Text.Trim.ToUpper, DBNull.Value)
        dr("CAP") = IIf(txtCAP.Text.Trim.Length > 0, txtCAP.Text.Trim.ToUpper, DBNull.Value)
        dr("Telefono") = IIf(txtTelefono.Text.Trim.Length > 0, txtTelefono.Text.Trim.ToUpper, DBNull.Value)
        dr("Mail") = IIf(txtEmail.Text.Trim.Length > 0, txtEmail.Text.Trim.ToUpper, DBNull.Value)
        dr("ATTIVA") = chkAttiva.Checked
        dr("DSI") = DBNull.Value
        daUtente.Update(DsBiglietterie1)
      End If



    End If
    Page.DataBind()
  End Sub

  Private Sub dgAutoparchimetri_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAutoparchimetri.EditCommand
    dgAutoparchimetri.EditItemIndex = e.Item.ItemIndex
    ReBind()
  End Sub

  Private Sub dgAutoparchimetri_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAutoparchimetri.CancelCommand
    ReBind(, True)
  End Sub

  Private Sub dgAutoparchimetri_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAutoparchimetri.DeleteCommand
    Dim dr As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Venduti").Rows.Find(dgAutoparchimetri.DataKeys(e.Item.ItemIndex))
    If Not dr Is Nothing Then
      dr.Delete()
      daAutoparchimetri.Update(DsBiglietterie1)
    End If
    dgAutoparchimetri_CancelCommand(source, e)

  End Sub

  Private Sub btnNuovo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuovo.Click
    Dim dr As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Venduti").NewRow

    dr("ID_AUTO") = -1
    dr("DSI") = 1
    dr("DATAVENDITA") = Now
    DsBiglietterie1.Tables("AutoParchimetri_Venduti").Rows.InsertAt(dr, 0)
    dgAutoparchimetri.EditItemIndex = 0
    ReBind()
  End Sub

  Private Sub ReBind(Optional ByVal BackTo0 As Boolean = False, Optional ByVal CancelEdit As Boolean = False)
    If BackTo0 Then dgAutoparchimetri.CurrentPageIndex = 0
    If CancelEdit Then dgAutoparchimetri.EditItemIndex = -1
    dgAutoparchimetri.DataBind()
    lblNoAutoparchimetri.DataBind()
    btnNuovo.DataBind()
    btnSalva.DataBind()
  End Sub

  Private Sub dgAutoparchimetri_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAutoparchimetri.UpdateCommand
    If Me.IsValid Then
      Dim dr As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Venduti").Rows.Find(dgAutoparchimetri.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        'Nuovo
        dr = DsBiglietterie1.Tables("AutoParchimetri_Venduti").NewRow
        Dim comNewID As New SqlClient.SqlCommand("Select Max(ID_Auto) + 1 From Autoparchimetri_Venduti", con)
        con.Open()
        dr("ID_Auto") = comNewID.ExecuteScalar
        dr("DATAVENDITA") = Now
        con.Close()

        DsBiglietterie1.Tables("AutoParchimetri_Venduti").Rows.Add(dr)
      End If
      dr("Numeratore") = txtNumeratore.Value
      dr("MATAUTO") = DirectCast(e.Item.FindControl("txtMatauto"), TextBox).Text
      dr("DSI") = DirectCast(e.Item.FindControl("ddlDSI"), DropDownList).SelectedValue
      dr("Tipo") = DsBiglietterie1.Tables("AutoParchimetri_Tipi").Rows.Find(dr("DSI"))("DSI")
      daAutoparchimetri.Update(DsBiglietterie1)
      ReBind(, True)
    End If
  End Sub

  Private Sub dgAutoparchimetri_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgAutoparchimetri.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then
      DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onclick", "javascript: return confirm('Sei sicuro di voler eliminare questa vendita?');")
    End If
    If Not e.Item.FindControl("btnReso") Is Nothing Then
      DirectCast(e.Item.FindControl("btnReso"), Button).Attributes.Add("onclick", "javascript: return confirm('Confermi la operazione di reso?');")
    End If
  End Sub

  Private Sub dgAutoparchimetri_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgAutoparchimetri.ItemCommand
    Select Case e.CommandName
      Case "Reso"
        Dim dr As DataRow = DsBiglietterie1.Tables("AutoParchimetri_Venduti").Rows.Find(dgAutoparchimetri.DataKeys(e.Item.ItemIndex))
        dr("DataReso") = Now
        daAutoparchimetri.Update(DsBiglietterie1)
        ReBind(, True)
    End Select
  End Sub
  Public Sub CVEsisteMatricolaAuto_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)

    Dim comNewID As New SqlClient.SqlCommand("select count(*) FROM  AutoParchimetri_Venduti WHERE (NUMERATORE = " & txtNumeratore.Value.Trim & ") AND (REPLACE(SPACE(8 - LEN(MATAUTO)) + MATAUTO, ' ', '0') = REPLACE(SPACE(8 - LEN('" & DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text & "')) + '" & DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text & "', ' ', '0') )", con)
    con.Open()

    args.IsValid = comNewID.ExecuteScalar() <= 0
    con.Close()



  End Sub

  Private Sub DGAltreAna_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGAltreAna.ItemCommand
    Select Case e.CommandName
      Case "Navigate"
        Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DGAltreAna.DataKeys(e.Item.ItemIndex)))
    End Select
  End Sub

End Class
