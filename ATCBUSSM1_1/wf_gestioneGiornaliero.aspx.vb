Public Class wf_gestioneGiornaliero
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daAccertatori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daTurni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsVestizione1 = New ATCBussm1.dsVestizione
    Me.dvTurni = New System.Data.DataView
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    CType(Me.DsVestizione1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
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
    CType(Me.DsVestizione1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents dgVestizione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daAccertatori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents daTurni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsVestizione1 As ATCBussm1.dsVestizione
  Protected WithEvents caDataGiornaliero As System.Web.UI.WebControls.Calendar
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgTurni As System.Web.UI.WebControls.DataGrid
  Protected WithEvents Table1 As System.Web.UI.WebControls.Table
  Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
  Protected WithEvents dvTurni As System.Data.DataView
  Protected WithEvents btnSyncAS400 As System.Web.UI.WebControls.Button
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents BTNAbilita As System.Web.UI.WebControls.Button
  Protected WithEvents BTNDisabilita As System.Web.UI.WebControls.Button

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

    daAccertatori.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daAccertatori.Fill(DsVestizione1, "Accertatori")
    daTurni.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daTurni.Fill(DsVestizione1, "Turni")
    If Not IsPostBack Then
      btnSyncAS400.Attributes.Add("onclick", "return confirm('Aggiornando i dati verranno persi gli eventuali spostamenti fatti tramite questo modulo. Continuare ugualmente?');")
      pSyncAS400(caDataGiornaliero.SelectedDate, False)

      Page.DataBind()
    End If
    Dim bdis As Boolean
    bdis = Disabilitato()
    BTNAbilita.Visible = bdis
    BTNDisabilita.Visible = Not bdis

  End Sub

  Private Sub caDataGiornaliero_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caDataGiornaliero.SelectionChanged



    pSyncAS400(caDataGiornaliero.SelectedDate, False)
    DsVestizione1.Clear()
    daAccertatori.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daAccertatori.Fill(DsVestizione1, "Accertatori")
    daTurni.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daTurni.Fill(DsVestizione1, "Turni")
    Dim bdis As Boolean
    bdis = Disabilitato()
    BTNAbilita.Visible = bdis
    BTNDisabilita.Visible = Not bdis

    Page.DataBind()


  End Sub

  Private Sub dgVestizione_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgVestizione.EditCommand
    dgVestizione.EditItemIndex = e.Item.ItemIndex
    dgVestizione.DataBind()
    DirectCast(dgVestizione.Items(e.Item.ItemIndex).FindControl("ddlTurno"), DropDownList).Items.Insert(0, New ListItem("0", 0))
    DirectCast(dgVestizione.Items(e.Item.ItemIndex).FindControl("ddlTurno"), DropDownList).SelectedValue = DsVestizione1.Tables("Accertatori").Rows.Find(dgVestizione.DataKeys(e.Item.ItemIndex)).Item("Turno")
  End Sub

  Private Sub dgVestizione_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgVestizione.CancelCommand
    dgVestizione.EditItemIndex = -1
    dgVestizione.DataBind()
  End Sub

  Private Sub dgVestizione_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgVestizione.UpdateCommand
    Me.Validate()
    If Me.IsValid Then
      Dim dr As Data.DataRow
      dr = DsVestizione1.Tables("Accertatori").Rows.Find(dgVestizione.DataKeys(e.Item.ItemIndex))
      dr.Item("Turno") = DirectCast(e.Item.Cells(3).Controls(1), DropDownList).SelectedValue
      daAccertatori.Update(DsVestizione1, "Accertatori")
      DsVestizione1.Tables("Accertatori").Clear()
      daAccertatori.Fill(DsVestizione1, "Accertatori")
      'FT - Toglie l'editing mode
      dgVestizione_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgTurni_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTurni.EditCommand
    dgTurni.EditItemIndex = e.Item.ItemIndex
    dgTurni.DataBind()
  End Sub

  Private Sub dgTurni_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTurni.CancelCommand
    dgTurni.EditItemIndex = -1
    dgTurni.DataBind()
  End Sub

  Private Sub dgTurni_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTurni.UpdateCommand
    Me.Validate()
    If Me.IsValid Then
      Dim dr As Data.DataRow
      dr = DsVestizione1.Tables("Turni").Rows.Find(dgTurni.DataKeys(e.Item.ItemIndex))
      dr.Item("Nota") = DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text
      daTurni.Update(DsVestizione1, "Turni")
      DsVestizione1.Tables("Turni").Clear()
      daTurni.Fill(DsVestizione1, "Turni")
      'FT - Toglie l'editing mode
      dgTurni_CancelCommand(source, e)
    End If
  End Sub

  Private Sub pSyncAS400(ByVal SelectedDate As DateTime, ByVal ForceResync As Boolean)
    Dim comCheckAccertatori As New SqlClient.SqlCommand("Select Count(*) From Accertatori Where Data = @Data", con)
    Dim comCheckTurni As New SqlClient.SqlCommand("Select Count(*) From Turni Where Data = @Data", con)
    Dim comCheckGiustificativi As New SqlClient.SqlCommand("Select Count(*) From Giustificativi Where Data = @Data", con)
    Dim b As Boolean
    Dim Config As New System.Configuration.AppSettingsReader

    Try
      comCheckAccertatori.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      b = comCheckAccertatori.ExecuteScalar > 0
      con.Close()
      If Not b Or ForceResync Then
        'Dim daAS400 As New OleDb.OleDbDataAdapter("SELECT M.AMMATR AS MATRICOLA, @SelectedDate AS DATA, T.PTCTUR AS TURNO, iif(g.gscgst is null, 0, 1) AS FLAGASSENZA, A.ANCGNO AS COGNOMENOME, G.GSCGST AS CODICEGIUSTIFICATIVO, G.GSHHIN AS ORAINIZIOGIUSTIFICATIVO, G.GSHHFN AS ORAFINEGIUSTIFICATIVO, G.TADESC AS TIPOASSENZA, iif(V.PGGRUA is null, M.amgrua, V.pggrua) AS CODICEGRUPPO, iif(V.DEGRUA is null, D.tadesc ,V.degrua) AS gruppo FROM ((((VESTI110_AMAMT00F AS M LEFT JOIN VESTI110_AMTAB00F AS D ON (Trim(M.AMGRUA) = Trim(D.TACODE) And D.TACODT = 'GRU')) LEFT JOIN AMPE_APANA00F AS A ON M.AMMATR = A.ANMATR) LEFT JOIN (SELECT G.GSMATR, G.GSCGST, D.TADESC, G.GSHHIN, G.GSHHFN, G.GSFL22 FROM VESTI110_AMGST00F AS G LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(G.GSCGST) = TRIM(D.TACODE) AND D.TACODT = 'GIU') WHERE (@StringDate BETWEEN CStr(G.GSAAIN) + Right('0' + CStr(G.GSMMIN), 2) + Right('0' + CStr(G.GSGGIN), 2) AND CStr(G.GSAAFN) + Right('0' + CStr(G.GSMMFN), 2) + Right('0' + CStr(G.GSGGFN), 2))) AS G ON M.AMMATR = G.GSMATR) LEFT JOIN [SELECT PTMATR, PTCTUR, PTFLSM FROM VESTI110_AMPTG00F WHERE (PTGGGG = @Day) AND (PTMMGG = @Month) AND (PTAAGG = @Year) AND (PTMATR <> 0)]. AS T ON T.PTMATR = M.AMMATR) LEFT JOIN [SELECT P.PGPERC, D.TADESC AS DEPERC, P.PGGRUA, D2.TADESC AS DEGRUA, P.PGTIPL, T.TIDTIP, P.PGCTUR, P.PGNOTA, T.TISASS FROM (((VESTI110_AMPEG00F AS P LEFT OUTER JOIN VESTI110_AMTIP00F AS T ON P.PGTIPL = T.TITIPL) LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(P.PGPERC) = TRIM(D.TACODE) AND D.TACODT = 'PER')) LEFT OUTER JOIN VESTI110_AMTAB00F AS D2 ON (TRIM(P.PGGRUA) = TRIM(D2.TACODE) AND D2.TACODT = 'GRU')) WHERE (@Year = P.PGAAGG) AND (@Month = P.PGMMGG) AND (@Day = P.PGGGGG)]. AS V ON V.PGCTUR = T.PTCTUR WHERE (M.AMAAGG = @Year AND (M.AMMMGG = @Month));", conAS400)
        Dim daAS400 As New Odbc.OdbcDataAdapter(Config.GetValue("SelectAccertatori", GetType(String)), conAS400)
        'Query ok
        'SELECT M.AMMATR AS MATRICOLA, @SelectedDate AS DATA, T.PTCTUR AS TURNO, A.ANCGNO AS COGNOMENOME, iif(V.PGGRUA is null, M.amgrua, V.pggrua) AS CODICEGRUPPO, iif(V.DEGRUA is null, D.tadesc ,V.degrua) AS gruppo FROM ((((VESTI110_AMAMT00F AS M LEFT JOIN VESTI110_AMTAB00F AS D ON (Trim(M.AMGRUA) = Trim(D.TACODE) And D.TACODT = 'GRU')) LEFT JOIN AMPE_APANA00F AS A ON M.AMMATR = A.ANMATR) LEFT JOIN (SELECT PTMATR, PTCTUR, PTFLSM FROM VESTI110_AMPTG00F WHERE (PTGGGG = @Day) AND (PTMMGG = @Month) AND (PTAAGG = @Year) AND (PTMATR <> 0)) AS T ON T.PTMATR = M.AMMATR) LEFT JOIN (SELECT P.PGPERC, D.TADESC AS DEPERC, P.PGGRUA, D2.TADESC AS DEGRUA, P.PGTIPL, T.TIDTIP, P.PGCTUR, P.PGNOTA, T.TISASS FROM (((VESTI110_AMPEG00F AS P LEFT OUTER JOIN VESTI110_AMTIP00F AS T ON P.PGTIPL = T.TITIPL) LEFT OUTER JOIN VESTI110_AMTAB00F AS D ON (TRIM(P.PGPERC) = TRIM(D.TACODE) AND D.TACODT = 'PER')) LEFT OUTER JOIN VESTI110_AMTAB00F AS D2 ON (TRIM(P.PGGRUA) = TRIM(D2.TACODE) AND D2.TACODT = 'GRU')) WHERE (@Year = P.PGAAGG) AND (@Month = P.PGMMGG) AND (@Day = P.PGGGGG)) AS V ON V.PGCTUR = T.PTCTUR) WHERE (M.AMAAGG = @Year AND (M.AMMMGG = @Month));
        Dim s As String = daAS400.SelectCommand.CommandText
        If ForceResync Then
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
        DsVestizione1.Tables("Accertatori").Clear()
        daAS400.Fill(DsVestizione1, "Accertatori")
        daAccertatori.Update(DsVestizione1, "Accertatori")
        daAS400.Dispose()
      End If

      comCheckTurni.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      b = comCheckTurni.ExecuteScalar > 0
      con.Close()
      If Not b Or ForceResync Then
        Dim daAS400 As New Odbc.OdbcDataAdapter(Config.GetValue("SelectTurni", GetType(String)), conAS400)
        Dim s As String = daAS400.SelectCommand.CommandText
        If ForceResync Then
          Dim comDeleteTurni As New SqlClient.SqlCommand("Delete From Turni Where Data = @Data", con)
          comDeleteTurni.Parameters.Add("@Data", SqlDbType.DateTime).Value = caDataGiornaliero.SelectedDate
          con.Open()
          comDeleteTurni.ExecuteNonQuery()
          con.Close()
        End If
        s = s.Replace("@Day", caDataGiornaliero.SelectedDate.Day)
        s = s.Replace("@Month", caDataGiornaliero.SelectedDate.Month)
        s = s.Replace("@Year", caDataGiornaliero.SelectedDate.Year)
        s = s.Replace("@StringDate", caDataGiornaliero.SelectedDate.Year & "-" & Right("0" & caDataGiornaliero.SelectedDate.Month, 2) & "-" & Right("0" & caDataGiornaliero.SelectedDate.Day, 2))
        s = s.Replace("@SelectedDate", "'" & caDataGiornaliero.SelectedDate.Year & "-" & Right("0" & caDataGiornaliero.SelectedDate.Month, 2) & "-" & Right("0" & caDataGiornaliero.SelectedDate.Day, 2) & "'")
        daAS400.SelectCommand.CommandText = s
        'daAS400.SelectCommand.Parameters.Add("@SelectedDate", OleDb.OleDbType.Date).Value = caData.SelectedDate
        daAS400.AcceptChangesDuringFill = False
        DsVestizione1.Tables("Turni").Clear()
        daAS400.Fill(DsVestizione1, "Turni")
        daTurni.Update(DsVestizione1, "Turni")
        daAS400.Dispose()
      End If

    Catch ex As Exception
      Response.Write("ATTENZIONE: si sono verificati dei problemi durante il recupero dei dati da AS400!<br>")
      Response.Write("Descrizione dell'errore: " & ex.Source & " - " & ex.Message & "<br>")
    End Try
  End Sub

  Private Sub btnSyncAS400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncAS400.Click
    pSyncAS400(caDataGiornaliero.SelectedDate, True)
    DsVestizione1.Clear()
    daAccertatori.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daAccertatori.Fill(DsVestizione1, "Accertatori")
    daTurni.SelectCommand.Parameters("@Data").Value = caDataGiornaliero.SelectedDate
    daTurni.Fill(DsVestizione1, "Turni")
    Page.DataBind()
  End Sub

  Private Sub VerificaCheckAbilita()

    Dim Config As New System.Configuration.AppSettingsReader

    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)

    Dim senzaSelectedDate As Boolean

    Dim fnc As New Funzioni
    Dim SelectedDate As DateTime

    Try
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "CheckAbilita della data: " & caDataGiornaliero.SelectedDate, Session("IPAddress"))

      SelectedDate = caDataGiornaliero.SelectedDate

      senzaSelectedDate = True
      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()

      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)
      con.Close()
      If senzaSelectedDate Then

        BTNAbilita.Visible = True
        BTNDisabilita.Visible = False

      Else
        BTNAbilita.Visible = False
        BTNDisabilita.Visible = True
      End If
      'AbitaG.Checked = Not senzaSelectedDate
    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Errore VerificaCheckAbilita: " & ex.Message, Session("IPAddress"))
      If (con.State = ConnectionState.Open) Then
        con.Close()
      End If
    End Try

  End Sub

  Private Sub BTNAbilita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAbilita.Click
    Dim b As Boolean
    Dim Config As New System.Configuration.AppSettingsReader

    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    Dim comDeleteExecutionTime As New SqlClient.SqlCommand(Config.GetValue("DeleteExecutionTime", GetType(String)), con)
    Dim comInsertExecutionTime As New SqlClient.SqlCommand(Config.GetValue("InsertExecutionTime", GetType(String)), con)

    Dim senzaSelectedDate As Boolean

    Dim fnc As New Funzioni
    Dim SelectedDate As DateTime
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Cliccato btn abilita giornaliero.", Session("IPAddress"))
    Try
      SelectedDate = caDataGiornaliero.SelectedDate
      senzaSelectedDate = True
      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)

      comDeleteExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      comDeleteExecutionTime.ExecuteNonQuery()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Abilitato giornaliero eliminata riga selecteddate", Session("IPAddress"))
      comInsertExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      comInsertExecutionTime.ExecuteNonQuery()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Abilitato giornaliero inserita riga selecteddate", Session("IPAddress"))

      con.Close()
      BTNAbilita.Visible = False
      BTNDisabilita.Visible = True

    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Errore btn abilitato: " & ex.Message, Session("IPAddress"))
      If (con.State = ConnectionState.Open) Then
        con.Close()
      End If
    End Try

  End Sub

  Private Sub BTNDisabilita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDisabilita.Click
    Dim b As Boolean
    Dim Config As New System.Configuration.AppSettingsReader

    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    Dim comDeleteExecutionTime As New SqlClient.SqlCommand(Config.GetValue("DeleteExecutionTime", GetType(String)), con)
    Dim comInsertExecutionTime As New SqlClient.SqlCommand(Config.GetValue("InsertExecutionTime", GetType(String)), con)

    Dim senzaSelectedDate As Boolean

    Dim fnc As New Funzioni
    Dim SelectedDate As DateTime
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Cliccato btn disabilita giornaliero.", Session("IPAddress"))
    Try
      SelectedDate = caDataGiornaliero.SelectedDate
      senzaSelectedDate = True
      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()
      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)

      comDeleteExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      comDeleteExecutionTime.ExecuteNonQuery()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Disabilitato giornaliero eliminata riga selecteddate", Session("IPAddress"))


      con.Close()
      BTNAbilita.Visible = True
      BTNDisabilita.Visible = False
    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Errore checked abilitato: " & ex.Message, Session("IPAddress"))
      If (con.State = ConnectionState.Open) Then
        con.Close()
      End If
    End Try
  End Sub


  Public Function Disabilitato() As Boolean

    Dim Config As New System.Configuration.AppSettingsReader
    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    Dim senzaSelectedDate As Boolean

    Dim fnc As New Funzioni
    Dim SelectedDate As DateTime

    Try
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "CheckAbilita della data: " & caDataGiornaliero.SelectedDate, Session("IPAddress"))

      SelectedDate = caDataGiornaliero.SelectedDate
      senzaSelectedDate = True
      comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = SelectedDate
      con.Open()

      senzaSelectedDate = Not (comNumExecutionTime.ExecuteScalar > 0)
      con.Close()

      'AbitaG.Checked = Not senzaSelectedDate
    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneGiornaliero.aspx", "Errore VerificaCheckAbilita: " & ex.Message, Session("IPAddress"))
      If (con.State = ConnectionState.Open) Then
        con.Close()
      End If
    End Try
    Disabilitato = senzaSelectedDate
  End Function

End Class
