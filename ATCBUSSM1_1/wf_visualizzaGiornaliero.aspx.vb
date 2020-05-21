Public Class wf_visualizzaGiornaliero
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daTurni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsVestizione1 = New ATCBussm1.dsVestizione
    Me.dvTurni = New System.Data.DataView
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.DaAcc = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
    Me.daAccertatori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsVestizione1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daTurni
    '
    Me.daTurni.DeleteCommand = Me.SqlDeleteCommand2
    Me.daTurni.InsertCommand = Me.SqlInsertCommand2
    Me.daTurni.SelectCommand = Me.SqlSelectCommand2
    Me.daTurni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Turni", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Turno", "Turno"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("CodiceTipologia", "CodiceTipologia"), New System.Data.Common.DataColumnMapping("TipologiaTurno", "TipologiaTurno"), New System.Data.Common.DataColumnMapping("Percorso", "Percorso"), New System.Data.Common.DataColumnMapping("DescrizionePercorso", "DescrizionePercorso"), New System.Data.Common.DataColumnMapping("OrdineAssegnamento", "OrdineAssegnamento"), New System.Data.Common.DataColumnMapping("Nota", "Nota")})})
    Me.daTurni.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.Turni WHERE (Data = @Original_Data) AND (Turno = @Original_Turno)" & _
    " AND (CodiceTipologia = @Original_CodiceTipologia OR @Original_CodiceTipologia I" & _
    "S NULL AND CodiceTipologia IS NULL) AND (DescrizionePercorso = @Original_Descriz" & _
    "ionePercorso OR @Original_DescrizionePercorso IS NULL AND DescrizionePercorso IS" & _
    " NULL) AND (Nota = @Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL) AN" & _
    "D (OrdineAssegnamento = @Original_OrdineAssegnamento OR @Original_OrdineAssegnam" & _
    "ento IS NULL AND OrdineAssegnamento IS NULL) AND (Percorso = @Original_Percorso " & _
    "OR @Original_Percorso IS NULL AND Percorso IS NULL) AND (TipologiaTurno = @Origi" & _
    "nal_TipologiaTurno OR @Original_TipologiaTurno IS NULL AND TipologiaTurno IS NUL" & _
    "L)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceTipologia", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceTipologia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescrizionePercorso", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescrizionePercorso", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.NVarChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrdineAssegnamento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrdineAssegnamento", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Percorso", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Percorso", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipologiaTurno", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipologiaTurno", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.Turni(Turno, Data, CodiceTipologia, TipologiaTurno, Percorso, Des" & _
    "crizionePercorso, OrdineAssegnamento, Nota) VALUES (@Turno, @Data, @CodiceTipolo" & _
    "gia, @TipologiaTurno, @Percorso, @DescrizionePercorso, @OrdineAssegnamento, @Not" & _
    "a); SELECT Turno, Data, CodiceTipologia, TipologiaTurno, Percorso, DescrizionePe" & _
    "rcorso, OrdineAssegnamento, Nota FROM dbo.Turni WHERE (Data = @Data) AND (Turno " & _
    "= @Turno) ORDER BY CodiceTipologia, OrdineAssegnamento"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceTipologia", System.Data.SqlDbType.NVarChar, 5, "CodiceTipologia"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipologiaTurno", System.Data.SqlDbType.NVarChar, 30, "TipologiaTurno"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Percorso", System.Data.SqlDbType.NVarChar, 5, "Percorso"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescrizionePercorso", System.Data.SqlDbType.NVarChar, 30, "DescrizionePercorso"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineAssegnamento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrdineAssegnamento", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 120, "Nota"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Turno, Data, CodiceTipologia, TipologiaTurno, Percorso, DescrizionePercors" & _
    "o, OrdineAssegnamento, Nota FROM dbo.Turni WHERE (Data = @Data) ORDER BY CodiceT" & _
    "ipologia, OrdineAssegnamento"
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.Turni SET Turno = @Turno, Data = @Data, CodiceTipologia = @CodiceTipol" & _
    "ogia, TipologiaTurno = @TipologiaTurno, Percorso = @Percorso, DescrizionePercors" & _
    "o = @DescrizionePercorso, OrdineAssegnamento = @OrdineAssegnamento, Nota = @Nota" & _
    " WHERE (Data = @Original_Data) AND (Turno = @Original_Turno) AND (CodiceTipologi" & _
    "a = @Original_CodiceTipologia OR @Original_CodiceTipologia IS NULL AND CodiceTip" & _
    "ologia IS NULL) AND (DescrizionePercorso = @Original_DescrizionePercorso OR @Ori" & _
    "ginal_DescrizionePercorso IS NULL AND DescrizionePercorso IS NULL) AND (Nota = @" & _
    "Original_Nota OR @Original_Nota IS NULL AND Nota IS NULL) AND (OrdineAssegnament" & _
    "o = @Original_OrdineAssegnamento OR @Original_OrdineAssegnamento IS NULL AND Ord" & _
    "ineAssegnamento IS NULL) AND (Percorso = @Original_Percorso OR @Original_Percors" & _
    "o IS NULL AND Percorso IS NULL) AND (TipologiaTurno = @Original_TipologiaTurno O" & _
    "R @Original_TipologiaTurno IS NULL AND TipologiaTurno IS NULL); SELECT Turno, Da" & _
    "ta, CodiceTipologia, TipologiaTurno, Percorso, DescrizionePercorso, OrdineAssegn" & _
    "amento, Nota FROM dbo.Turni WHERE (Data = @Data) AND (Turno = @Turno) ORDER BY C" & _
    "odiceTipologia, OrdineAssegnamento"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceTipologia", System.Data.SqlDbType.NVarChar, 5, "CodiceTipologia"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipologiaTurno", System.Data.SqlDbType.NVarChar, 30, "TipologiaTurno"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Percorso", System.Data.SqlDbType.NVarChar, 5, "Percorso"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescrizionePercorso", System.Data.SqlDbType.NVarChar, 30, "DescrizionePercorso"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineAssegnamento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrdineAssegnamento", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 120, "Nota"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceTipologia", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceTipologia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescrizionePercorso", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescrizionePercorso", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nota", System.Data.SqlDbType.NVarChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nota", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrdineAssegnamento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrdineAssegnamento", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Percorso", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Percorso", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipologiaTurno", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipologiaTurno", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsVestizione1
    '
    Me.DsVestizione1.DataSetName = "dsVestizione"
    Me.DsVestizione1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'dvTurni
    '
    Me.dvTurni.Sort = "turno"
    Me.dvTurni.Table = Me.DsVestizione1.Turni
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'DaAcc
    '
    Me.DaAcc.DeleteCommand = Me.SqlCommand1
    Me.DaAcc.InsertCommand = Me.SqlCommand2
    Me.DaAcc.SelectCommand = Me.SqlCommand3
    Me.DaAcc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccertatoriTurno", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Matricola", "Matricola"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Turno", "Turno"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("CodiceGruppo", "CodiceGruppo"), New System.Data.Common.DataColumnMapping("Gruppo", "Gruppo"), New System.Data.Common.DataColumnMapping("TipologiaTurno", "TipologiaTurno")})})
    Me.DaAcc.UpdateCommand = Me.SqlCommand4
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.Accertatori WHERE (Data = @Original_Data) AND (Matricola = @Origi" & _
    "nal_Matricola) AND (CodiceGruppo = @Original_CodiceGruppo OR @Original_CodiceGru" & _
    "ppo IS NULL AND CodiceGruppo IS NULL) AND (CognomeNome = @Original_CognomeNome O" & _
    "R @Original_CognomeNome IS NULL AND CognomeNome IS NULL) AND (Gruppo = @Original" & _
    "_Gruppo OR @Original_Gruppo IS NULL AND Gruppo IS NULL) AND (Turno = @Original_T" & _
    "urno OR @Original_Turno IS NULL AND Turno IS NULL)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceGruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CognomeNome", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CognomeNome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gruppo", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "INSERT INTO dbo.Accertatori (Matricola, Data, Turno, CognomeNome, CodiceGruppo, G" & _
    "ruppo) VALUES (@Matricola, @Data, @Turno, @CognomeNome, @CodiceGruppo, @Gruppo);" & _
    " SELECT Matricola, Data, Turno, CognomeNome, CodiceGruppo, Gruppo FROM dbo.Accer" & _
    "tatori WHERE (Data = @Data) AND (Matricola = @Matricola) ORDER BY Gruppo, Turno," & _
    " CognomeNome"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CognomeNome", System.Data.SqlDbType.NVarChar, 25, "CognomeNome"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, "CodiceGruppo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gruppo", System.Data.SqlDbType.NVarChar, 30, "Gruppo"))
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = CType(configurationAppSettings.GetValue("SqlCommand3.CommandText", GetType(System.String)), String)
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    '
    'SqlCommand4
    '
    Me.SqlCommand4.CommandText = "UPDATE dbo.Accertatori SET Matricola = @Matricola, Data = @Data, Turno = @Turno, " & _
    "CognomeNome = @CognomeNome, CodiceGruppo = @CodiceGruppo, Gruppo = @Gruppo WHERE" & _
    " (Data = @Original_Data) AND (Matricola = @Original_Matricola) AND (CodiceGruppo" & _
    " = @Original_CodiceGruppo OR @Original_CodiceGruppo IS NULL AND CodiceGruppo IS " & _
    "NULL) AND (CognomeNome = @Original_CognomeNome OR @Original_CognomeNome IS NULL " & _
    "AND CognomeNome IS NULL) AND (Gruppo = @Original_Gruppo OR @Original_Gruppo IS N" & _
    "ULL AND Gruppo IS NULL) AND (Turno = @Original_Turno OR @Original_Turno IS NULL " & _
    "AND Turno IS NULL); SELECT Matricola, Data, Turno, CognomeNome, CodiceGruppo, Gr" & _
    "uppo FROM dbo.Accertatori WHERE (Data = @Data) AND (Matricola = @Matricola) ORDE" & _
    "R BY Gruppo, Turno, CognomeNome"
    Me.SqlCommand4.Connection = Me.con
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CognomeNome", System.Data.SqlDbType.NVarChar, 25, "CognomeNome"))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, "CodiceGruppo"))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gruppo", System.Data.SqlDbType.NVarChar, 30, "Gruppo"))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceGruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CognomeNome", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CognomeNome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gruppo", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    '
    'daAccertatori
    '
    Me.daAccertatori.DeleteCommand = Me.SqlDeleteCommand1
    Me.daAccertatori.InsertCommand = Me.SqlInsertCommand1
    Me.daAccertatori.SelectCommand = Me.SqlSelectCommand1
    Me.daAccertatori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Matricola", "Matricola"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Turno", "Turno"), New System.Data.Common.DataColumnMapping("FlagAssenza", "FlagAssenza"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("CodiceGiustificativo", "CodiceGiustificativo"), New System.Data.Common.DataColumnMapping("OraInizioGiustificativo", "OraInizioGiustificativo"), New System.Data.Common.DataColumnMapping("OraFineGiustificativo", "OraFineGiustificativo"), New System.Data.Common.DataColumnMapping("TipoAssenza", "TipoAssenza"), New System.Data.Common.DataColumnMapping("CodiceGruppo", "CodiceGruppo"), New System.Data.Common.DataColumnMapping("Gruppo", "Gruppo")})})
    Me.daAccertatori.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Accertatori WHERE (Data = @Original_Data) AND (Matricola = @Origi" & _
    "nal_Matricola) AND (CodiceGruppo = @Original_CodiceGruppo OR @Original_CodiceGru" & _
    "ppo IS NULL AND CodiceGruppo IS NULL) AND (CognomeNome = @Original_CognomeNome O" & _
    "R @Original_CognomeNome IS NULL AND CognomeNome IS NULL) AND (Gruppo = @Original" & _
    "_Gruppo OR @Original_Gruppo IS NULL AND Gruppo IS NULL) AND (Turno = @Original_T" & _
    "urno OR @Original_Turno IS NULL AND Turno IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceGruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CognomeNome", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CognomeNome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gruppo", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Accertatori (Matricola, Data, Turno, CognomeNome, CodiceGruppo, G" & _
    "ruppo) VALUES (@Matricola, @Data, @Turno, @CognomeNome, @CodiceGruppo, @Gruppo);" & _
    " SELECT Matricola, Data, Turno, CognomeNome, CodiceGruppo, Gruppo FROM dbo.Accer" & _
    "tatori WHERE (Data = @Data) AND (Matricola = @Matricola) ORDER BY Gruppo, Turno," & _
    " CognomeNome"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CognomeNome", System.Data.SqlDbType.NVarChar, 25, "CognomeNome"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, "CodiceGruppo"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gruppo", System.Data.SqlDbType.NVarChar, 30, "Gruppo"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Matricola, Data, Turno, CognomeNome, CodiceGruppo, Gruppo FROM dbo.Accerta" & _
    "tori WHERE (Data = @Data) ORDER BY Gruppo, Turno, CognomeNome"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori SET Matricola = @Matricola, Data = @Data, Turno = @Turno, " & _
    "CognomeNome = @CognomeNome, CodiceGruppo = @CodiceGruppo, Gruppo = @Gruppo WHERE" & _
    " (Data = @Original_Data) AND (Matricola = @Original_Matricola) AND (CodiceGruppo" & _
    " = @Original_CodiceGruppo OR @Original_CodiceGruppo IS NULL AND CodiceGruppo IS " & _
    "NULL) AND (CognomeNome = @Original_CognomeNome OR @Original_CognomeNome IS NULL " & _
    "AND CognomeNome IS NULL) AND (Gruppo = @Original_Gruppo OR @Original_Gruppo IS N" & _
    "ULL AND Gruppo IS NULL) AND (Turno = @Original_Turno OR @Original_Turno IS NULL " & _
    "AND Turno IS NULL); SELECT Matricola, Data, Turno, CognomeNome, CodiceGruppo, Gr" & _
    "uppo FROM dbo.Accertatori WHERE (Data = @Data) AND (Matricola = @Matricola) ORDE" & _
    "R BY Gruppo, Turno, CognomeNome"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CognomeNome", System.Data.SqlDbType.NVarChar, 25, "CognomeNome"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, "CodiceGruppo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gruppo", System.Data.SqlDbType.NVarChar, 30, "Gruppo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Matricola", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Matricola", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceGruppo", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceGruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CognomeNome", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CognomeNome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Gruppo", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gruppo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Turno", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Turno", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsVestizione1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents dgVestizione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daTurni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsVestizione1 As ATCBussm1.dsVestizione
  Protected WithEvents caDataGiornaliero As System.Web.UI.WebControls.Calendar
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgTurni As System.Web.UI.WebControls.DataGrid
  Protected WithEvents Table1 As System.Web.UI.WebControls.Table
  Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
  Protected WithEvents dvTurni As System.Data.DataView
  Protected WithEvents btnSyncAS400 As System.Web.UI.WebControls.Button
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents DaAcc As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daAccertatori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()

    caDataGiornaliero.SelectedDate = Now.Date
    caDataGiornaliero.VisibleDate = Now.Date

  End Sub

#End Region

  Private oUtente As Utente

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here

    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")


    If Not IsPostBack Then
      '   caDataGiornaliero.SelectedDate = Now()
      If Giornaliero_Abilitato() Then

        dgVestizione.Visible = False
        pSyncAS400(caDataGiornaliero.SelectedDate, False)
        DsVestizione1.Tables("AccertatoriTurno").Clear()
        DaAcc.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
        DaAcc.Fill(DsVestizione1, "AccertatoriTurno")
  

        dgVestizione.DataBind()
        dgVestizione.Visible = True
      Else
        dgVestizione.Visible = False
      End If
    Else
      If (Giornaliero_Abilitato()) Then
        DaAcc.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
        DaAcc.Fill(DsVestizione1, "AccertatoriTurno")
        dgVestizione.Visible = True
      Else
        dgVestizione.Visible = False
      End If

    End If



  End Sub

  Private Sub caDataGiornaliero_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caDataGiornaliero.SelectionChanged

    If (Giornaliero_Abilitato()) Then


    pSyncAS400(caDataGiornaliero.SelectedDate, False)
    DsVestizione1.Clear()
    DaAcc.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    DaAcc.Fill(DsVestizione1, "AccertatoriTurno")
    'daTurni.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    'daTurni.Fill(DsVestizione1, "Turni")
      dgVestizione.Visible = True
      dgVestizione.DataBind()

    Else
      dgVestizione.Visible = False
    End If

  End Sub


  Private Sub pSyncAS400(ByVal SelectedDate As DateTime, ByVal ForceResync As Boolean)
    Dim comCheckAccertatori As New SqlClient.SqlCommand("Select Count(*) From Accertatori Where Data = @Data", con)
    Dim comCheckTurni As New SqlClient.SqlCommand("Select Count(*) From Turni Where Data = @Data", con)
    Dim comCheckGiustificativi As New SqlClient.SqlCommand("Select Count(*) From Giustificativi Where Data = @Data", con)

    Dim b As Boolean
    Dim Config As New System.Configuration.AppSettingsReader
    Dim comOreExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLOreExecutionTime", GetType(String)), con)
    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    Dim comDeleteExecutionTime As New SqlClient.SqlCommand(Config.GetValue("DeleteExecutionTime", GetType(String)), con)
    Dim comInsertExecutionTime As New SqlClient.SqlCommand(Config.GetValue("InsertExecutionTime", GetType(String)), con)
    Dim senzaSelectedDate As Boolean
    Dim minutirefresh As Integer
    Dim fnc As New Funzioni


    Try
      senzaSelectedDate = True

      fnc.ScriviLog(oUtente.IDUser, "wf_visualizzaGiornaliero.aspx", "Lancio del pSyncAS400", Session("IPAddress"))

      minutirefresh = Config.GetValue("MinutiRefresh", GetType(Integer))
      comCheckAccertatori.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      comOreExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      b = comCheckAccertatori.ExecuteScalar > 0

      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)
      If (senzaSelectedDate) Then
        ForceResync = False
      Else
        ForceResync = comOreExecutionTime.ExecuteScalar > minutirefresh
      End If

      con.Close()
      fnc.ScriviLog(oUtente.IDUser, "wf_visualizzaGiornaliero.aspx", "pSyncAS400 - Senza rec. executiontime: " & senzaSelectedDate.ToString() & " ForceResync: " & ForceResync.ToString(), Session("IPAddress"))

      If Not b Or ForceResync Then

        comDeleteExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
        con.Open()
        comDeleteExecutionTime.ExecuteNonQuery()
        con.Close()
        fnc.ScriviLog(oUtente.IDUser, "wf_visualizzaGiornaliero.aspx", "pSyncAS400 - Dopo delete executiontime", Session("IPAddress"))

        comInsertExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
        con.Open()
        comInsertExecutionTime.ExecuteNonQuery()
        con.Close()
        fnc.ScriviLog(oUtente.IDUser, "wf_visualizzaGiornaliero.aspx", "pSyncAS400 - Dopo insert executiontime", Session("IPAddress"))

        'Dim daAS400 As New OleDb.OleDbDataAdapter("SELECT M.AMMATR AS MATRICOLA, @SelectedDate AS DATA, T.PTCTUR AS TURNO, iif(g.gscgst is null, 0, 1) AS FLAGASSENZA, A.ANCGNO AS COGNOMENOME, G.GSCGST AS CODICEGIUSTIFICATIVO, G.GSHHIN AS ORAINIZIOGIUSTIFICATIVO, G.GSHHFN AS ORAFINEGIUSTIFICATIVO, G.TADESC AS TIPOASSENZA, iif(V.PGGRUA is null, M.amgrua, V.pggrua) AS CODICEGRUPPO, iif(V.DEGRUA is null, D.tadesc ,V.degrua) AS gruppo FROM ((((VESTI110_AMAMT00F AS M LEFT JOIN VESTI110_AMTAB00F AS D ON (Trim(M.AMGRUA) = Trim(D.TACODE) And D.TACODT = 'GRU')) LEFT JOIN AMPE_APANA00F AS A ON M.AMMATR = A.ANMATR) LEFT JOIN (SELECT G.GSMATR, G.GSCGST, D.TADESC, G.GSHHIN, G.GSHHFN, G.GSFL22 FROM VESTI110_AMGST00F AS G LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(G.GSCGST) = TRIM(D.TACODE) AND D.TACODT = 'GIU') WHERE (@StringDate BETWEEN CStr(G.GSAAIN) + Right('0' + CStr(G.GSMMIN), 2) + Right('0' + CStr(G.GSGGIN), 2) AND CStr(G.GSAAFN) + Right('0' + CStr(G.GSMMFN), 2) + Right('0' + CStr(G.GSGGFN), 2))) AS G ON M.AMMATR = G.GSMATR) LEFT JOIN [SELECT PTMATR, PTCTUR, PTFLSM FROM VESTI110_AMPTG00F WHERE (PTGGGG = @Day) AND (PTMMGG = @Month) AND (PTAAGG = @Year) AND (PTMATR <> 0)]. AS T ON T.PTMATR = M.AMMATR) LEFT JOIN [SELECT P.PGPERC, D.TADESC AS DEPERC, P.PGGRUA, D2.TADESC AS DEGRUA, P.PGTIPL, T.TIDTIP, P.PGCTUR, P.PGNOTA, T.TISASS FROM (((VESTI110_AMPEG00F AS P LEFT OUTER JOIN VESTI110_AMTIP00F AS T ON P.PGTIPL = T.TITIPL) LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(P.PGPERC) = TRIM(D.TACODE) AND D.TACODT = 'PER')) LEFT OUTER JOIN VESTI110_AMTAB00F AS D2 ON (TRIM(P.PGGRUA) = TRIM(D2.TACODE) AND D2.TACODT = 'GRU')) WHERE (@Year = P.PGAAGG) AND (@Month = P.PGMMGG) AND (@Day = P.PGGGGG)]. AS V ON V.PGCTUR = T.PTCTUR WHERE (M.AMAAGG = @Year AND (M.AMMMGG = @Month));", conAS400)
        Dim daAS400 As New Odbc.OdbcDataAdapter(Config.GetValue("SelectAccertatori", GetType(String)), conAS400)
        'Query ok
        'SELECT M.AMMATR AS MATRICOLA, @SelectedDate AS DATA, T.PTCTUR AS TURNO, A.ANCGNO AS COGNOMENOME, iif(V.PGGRUA is null, M.amgrua, V.pggrua) AS CODICEGRUPPO, iif(V.DEGRUA is null, D.tadesc ,V.degrua) AS gruppo FROM ((((VESTI110_AMAMT00F AS M LEFT JOIN VESTI110_AMTAB00F AS D ON (Trim(M.AMGRUA) = Trim(D.TACODE) And D.TACODT = 'GRU')) LEFT JOIN AMPE_APANA00F AS A ON M.AMMATR = A.ANMATR) LEFT JOIN (SELECT PTMATR, PTCTUR, PTFLSM FROM VESTI110_AMPTG00F WHERE (PTGGGG = @Day) AND (PTMMGG = @Month) AND (PTAAGG = @Year) AND (PTMATR <> 0)) AS T ON T.PTMATR = M.AMMATR) LEFT JOIN (SELECT P.PGPERC, D.TADESC AS DEPERC, P.PGGRUA, D2.TADESC AS DEGRUA, P.PGTIPL, T.TIDTIP, P.PGCTUR, P.PGNOTA, T.TISASS FROM (((VESTI110_AMPEG00F AS P LEFT OUTER JOIN VESTI110_AMTIP00F AS T ON P.PGTIPL = T.TITIPL) LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(P.PGPERC) = TRIM(D.TACODE) AND D.TACODT = 'PER')) LEFT OUTER JOIN VESTI110_AMTAB00F AS D2 ON (TRIM(P.PGGRUA) = TRIM(D2.TACODE) AND D2.TACODT = 'GRU')) WHERE (@Year = P.PGAAGG) AND (@Month = P.PGMMGG) AND (@Day = P.PGGGGG)) AS V ON V.PGCTUR = T.PTCTUR) WHERE (M.AMAAGG = @Year AND (M.AMMMGG = @Month));
        Dim s As String = daAS400.SelectCommand.CommandText
        If ForceResync Or senzaSelectedDate Then
          Dim comDeleteAccertatori As New SqlClient.SqlCommand("Delete From Accertatori Where Data = @Data", con)
          comDeleteAccertatori.Parameters.Add("@Data", SqlDbType.DateTime).Value = caDataGiornaliero.SelectedDate
          con.Open()
          comDeleteAccertatori.ExecuteNonQuery()
          con.Close()
        End If
        s = s.Replace("@Day", caDataGiornaliero.SelectedDate.Day)
        s = s.Replace("@Month", caDataGiornaliero.SelectedDate.Month)
        s = s.Replace("@Year", caDataGiornaliero.SelectedDate.Year)
        s = s.Replace("@SelectedDate", "'" & caDataGiornaliero.SelectedDate.Year & "-" & Right("0" & caDataGiornaliero.SelectedDate.Month, 2) & "-" & Right("0" & caDataGiornaliero.SelectedDate.Day, 2) & "'")
        daAS400.SelectCommand.CommandText = s
        'daAS400.SelectCommand.Parameters.Add("@SelectedDate", OleDb.OleDbType.Date).Value = caData.SelectedDate
        daAS400.AcceptChangesDuringFill = False
        DsVestizione1.Tables("AccertatoriTurno").Clear()
        daAS400.Fill(DsVestizione1, "AccertatoriTurno")
        DaAcc.Update(DsVestizione1, "AccertatoriTurno")
        daAS400.Dispose()

      End If

      comCheckTurni.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      b = comCheckTurni.ExecuteScalar > 0
      con.Close()


    Catch ex As Exception
      Response.Write("ATTENZIONE: si sono verificati dei problemi durante il recupero dei dati da AS400!<br>")
      Response.Write("Descrizione dell'errore: " & ex.Source & " - " & ex.Message & "<br>")
      fnc.ScriviLog(oUtente.IDUser, "wf_visualizzaGiornaliero.aspx", "Descrizione dell'errore: " & ex.Source & " - " & ex.Message, Session("IPAddress"))
      'fnc.ScriviLog(oUtente.IDUser, "wf_ammpwdaccertatori.aspx", "Pagina iniziale", Session("IPAddress"))
    End Try
  End Sub

  'Private Sub btnSyncAS400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncAS400.Click
  '  pSyncAS400(caDataGiornaliero.SelectedDate, True)
  '  DsVestizione1.Clear()
  '  daAccertatori.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
  '  daAccertatori.Fill(DsVestizione1, "Accertatori")
  '  daTurni.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
  '  daTurni.Fill(DsVestizione1, "Turni")
  '  Page.DataBind()
  'End Sub

  Public Function Giornaliero_Abilitato() As Boolean

    Dim Config As New System.Configuration.AppSettingsReader

    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)

    Dim senzaSelectedDate As Boolean

    Dim fnc As New Funzioni
    Dim SelectedDate As DateTime
    Try
      senzaSelectedDate = True
      SelectedDate = caDataGiornaliero.SelectedDate

      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)
      con.Close()

    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Errore checked abilitato: " & ex.Message, Session("IPAddress"))
      If (con.State = ConnectionState.Open) Then
        con.Close()
      End If
    End Try

    Giornaliero_Abilitato = Not senzaSelectedDate
  End Function

End Class
