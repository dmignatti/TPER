Imports System.Data.SqlClient
Public Class wf_stalli
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaStalli = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DaStradarioBologna = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DaSettori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsStalli = New ATCBussm1.DsStalli
    Me.DaStalliNotest = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsStalli, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaStalli
    '
    Me.DaStalli.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaStalli.InsertCommand = Me.SqlInsertCommand1
    Me.DaStalli.SelectCommand = Me.SqlSelectCommand1
    Me.DaStalli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Stalli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CivKey", "CivKey"), New System.Data.Common.DataColumnMapping("Via", "Via"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("Blu", "Blu"), New System.Data.Common.DataColumnMapping("Verde", "Verde"), New System.Data.Common.DataColumnMapping("Handi", "Handi"), New System.Data.Common.DataColumnMapping("Residenti", "Residenti"), New System.Data.Common.DataColumnMapping("RiservatoGenerico", "RiservatoGenerico"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("CaricoScarico", "CaricoScarico"), New System.Data.Common.DataColumnMapping("Moto", "Moto"), New System.Data.Common.DataColumnMapping("discoorario", "discoorario"), New System.Data.Common.DataColumnMapping("sospesi", "sospesi"), New System.Data.Common.DataColumnMapping("Settore", "Settore"), New System.Data.Common.DataColumnMapping("libera", "libera"), New System.Data.Common.DataColumnMapping("ID_SZF", "ID_SZF")})})
    Me.DaStalli.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Stalli WHERE (id = @Original_id)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Stalli (CivKey, Via, Note, Blu, Verde, Handi, Residenti, Riservat" & _
    "oGenerico, CaricoScarico, Moto, discoorario, sospesi, Settore, libera, ID_SZF, C" & _
    "arsharing) VALUES (@CivKey, @Via, @Note, @Blu, @Verde, @Handi, @Residenti, @Rise" & _
    "rvatoGenerico, @CaricoScarico, @Moto, @discoorario, @sospesi, @Settore, @libera," & _
    " @ID_SZF, @Carsharing); SELECT CivKey, Via, Note, Blu, Verde, Handi, Residenti, " & _
    "RiservatoGenerico, id, CaricoScarico, Moto, discoorario, sospesi, Settore, liber" & _
    "a, ID_SZF, Carsharing FROM dbo.Stalli WHERE (id = @@IDENTITY) ORDER BY CivKey"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CivKey", System.Data.SqlDbType.Int, 4, "CivKey"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Via", System.Data.SqlDbType.NVarChar, 100, "Via"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 100, "Note"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Blu", System.Data.SqlDbType.Int, 4, "Blu"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Verde", System.Data.SqlDbType.Int, 4, "Verde"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Handi", System.Data.SqlDbType.Int, 4, "Handi"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Residenti", System.Data.SqlDbType.Int, 4, "Residenti"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RiservatoGenerico", System.Data.SqlDbType.Int, 4, "RiservatoGenerico"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScarico", System.Data.SqlDbType.Int, 4, "CaricoScarico"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Moto", System.Data.SqlDbType.Int, 4, "Moto"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discoorario", System.Data.SqlDbType.Int, 4, "discoorario"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sospesi", System.Data.SqlDbType.Int, 4, "sospesi"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Settore", System.Data.SqlDbType.NVarChar, 50, "Settore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@libera", System.Data.SqlDbType.Int, 4, "libera"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_SZF", System.Data.SqlDbType.Int, 4, "ID_SZF"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Carsharing", System.Data.SqlDbType.Int, 4, "Carsharing"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT dbo.Stalli.CivKey, dbo.Stalli.Via, dbo.Stalli.Note, dbo.Stalli.Blu, dbo.St" & _
    "alli.Verde, dbo.Stalli.Handi, dbo.Stalli.Residenti, dbo.Stalli.RiservatoGenerico" & _
    ", dbo.Stalli.id, dbo.Stalli.CaricoScarico, dbo.Stalli.Moto, dbo.Stalli.discoorar" & _
    "io, dbo.Stalli.sospesi, dbo.Stalli.Settore, dbo.Stalli.libera, dbo.Stalli.ID_SZF" & _
    ", dbo.StradarioBologna.Nome, dbo.Settori.Desc_Settore, dbo.Settori.Desc_Dettagli" & _
    "o_Settore, dbo.Stalli.Carsharing FROM dbo.Stalli LEFT OUTER JOIN dbo.Settori ON " & _
    "dbo.Stalli.ID_SZF = dbo.Settori.Id_SZF LEFT OUTER JOIN dbo.StradarioBologna ON d" & _
    "bo.Stalli.CivKey = dbo.StradarioBologna.Codice"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Stalli SET CivKey = @CivKey, Via = @Via, Note = @Note, Blu = @Blu, Ver" & _
    "de = @Verde, Handi = @Handi, Residenti = @Residenti, RiservatoGenerico = @Riserv" & _
    "atoGenerico, CaricoScarico = @CaricoScarico, Moto = @Moto, discoorario = @discoo" & _
    "rario, sospesi = @sospesi, Settore = @Settore, libera = @libera, ID_SZF = @ID_SZ" & _
    "F, Carsharing = @Carsharing WHERE (id = @Original_id) AND (Blu = @Original_Blu O" & _
    "R @Original_Blu IS NULL AND Blu IS NULL) AND (CaricoScarico = @Original_CaricoSc" & _
    "arico OR @Original_CaricoScarico IS NULL AND CaricoScarico IS NULL) AND (CivKey " & _
    "= @Original_CivKey OR @Original_CivKey IS NULL AND CivKey IS NULL) AND (Handi = " & _
    "@Original_Handi OR @Original_Handi IS NULL AND Handi IS NULL) AND (ID_SZF = @Ori" & _
    "ginal_ID_SZF OR @Original_ID_SZF IS NULL AND ID_SZF IS NULL) AND (Moto = @Origin" & _
    "al_Moto OR @Original_Moto IS NULL AND Moto IS NULL) AND (Note = @Original_Note O" & _
    "R @Original_Note IS NULL AND Note IS NULL) AND (Residenti = @Original_Residenti " & _
    "OR @Original_Residenti IS NULL AND Residenti IS NULL) AND (RiservatoGenerico = @" & _
    "Original_RiservatoGenerico OR @Original_RiservatoGenerico IS NULL AND RiservatoG" & _
    "enerico IS NULL) AND (Settore = @Original_Settore OR @Original_Settore IS NULL A" & _
    "ND Settore IS NULL) AND (Verde = @Original_Verde OR @Original_Verde IS NULL AND " & _
    "Verde IS NULL) AND (Via = @Original_Via OR @Original_Via IS NULL AND Via IS NULL" & _
    ") AND (discoorario = @Original_discoorario OR @Original_discoorario IS NULL AND " & _
    "discoorario IS NULL) AND (libera = @Original_libera OR @Original_libera IS NULL " & _
    "AND libera IS NULL) AND (sospesi = @Original_sospesi OR @Original_sospesi IS NUL" & _
    "L AND sospesi IS NULL) AND (Carsharing = @Original_Carsharing OR @Original_Carsh" & _
    "aring IS NULL AND Carsharing IS NULL); SELECT CivKey, Via, Note, Blu, Verde, Han" & _
    "di, Residenti, RiservatoGenerico, id, CaricoScarico, Moto, discoorario, sospesi," & _
    " Settore, libera, ID_SZF, Carsharing FROM dbo.Stalli WHERE (id = @id) ORDER BY C" & _
    "ivKey"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CivKey", System.Data.SqlDbType.Int, 4, "CivKey"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Via", System.Data.SqlDbType.NVarChar, 100, "Via"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 100, "Note"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Blu", System.Data.SqlDbType.Int, 4, "Blu"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Verde", System.Data.SqlDbType.Int, 4, "Verde"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Handi", System.Data.SqlDbType.Int, 4, "Handi"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Residenti", System.Data.SqlDbType.Int, 4, "Residenti"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RiservatoGenerico", System.Data.SqlDbType.Int, 4, "RiservatoGenerico"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScarico", System.Data.SqlDbType.Int, 4, "CaricoScarico"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Moto", System.Data.SqlDbType.Int, 4, "Moto"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discoorario", System.Data.SqlDbType.Int, 4, "discoorario"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sospesi", System.Data.SqlDbType.Int, 4, "sospesi"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Settore", System.Data.SqlDbType.NVarChar, 50, "Settore"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@libera", System.Data.SqlDbType.Int, 4, "libera"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_SZF", System.Data.SqlDbType.Int, 4, "ID_SZF"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Carsharing", System.Data.SqlDbType.Int, 4, "Carsharing"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Blu", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Blu", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScarico", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScarico", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CivKey", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CivKey", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Handi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Handi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_SZF", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_SZF", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Moto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moto", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Note", System.Data.SqlDbType.NVarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Residenti", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Residenti", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RiservatoGenerico", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RiservatoGenerico", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Settore", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Settore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Verde", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Verde", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Via", System.Data.SqlDbType.NVarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Via", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discoorario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discoorario", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_libera", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "libera", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sospesi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sospesi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Carsharing", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Carsharing", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"))
    '
    'DaStradarioBologna
    '
    Me.DaStradarioBologna.SelectCommand = Me.SqlSelectCommand3
    Me.DaStradarioBologna.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "StradarioBologna", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_prov", "cod_prov"), New System.Data.Common.DataColumnMapping("cod_comune", "cod_comune"), New System.Data.Common.DataColumnMapping("Codice", "Codice"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("SettoreZona", "SettoreZona"), New System.Data.Common.DataColumnMapping("Guid", "Guid")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT cod_prov, cod_comune, Codice, Nome, SettoreZona, Guid FROM dbo.StradarioBo" & _
    "logna"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'DaSettori
    '
    Me.DaSettori.SelectCommand = Me.SqlSelectCommand2
    Me.DaSettori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Settori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_SZF", "Id_SZF"), New System.Data.Common.DataColumnMapping("Id_ZonaSettoreUnico", "Id_ZonaSettoreUnico"), New System.Data.Common.DataColumnMapping("Desc_Settore", "Desc_Settore"), New System.Data.Common.DataColumnMapping("Desc_Dettaglio_Settore", "Desc_Dettaglio_Settore")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id_SZF, Id_ZonaSettoreUnico, Desc_Settore, Desc_Dettaglio_Settore FROM dbo" & _
    ".Settori"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'DsStalli
    '
    Me.DsStalli.DataSetName = "DsStalli"
    Me.DsStalli.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'DaStalliNotest
    '
    Me.DaStalliNotest.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaStalliNotest.InsertCommand = Me.SqlInsertCommand2
    Me.DaStalliNotest.SelectCommand = Me.SqlSelectCommand4
    Me.DaStalliNotest.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "StalliNoteSt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nota", "Nota"), New System.Data.Common.DataColumnMapping("Data", "Data")})})
    Me.DaStalliNotest.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.StalliNoteSt WHERE (Id = @Original_Id) AND (Data = @Original_Data" & _
    " OR @Original_Data IS NULL AND Data IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.StalliNoteSt(Id, Nota, Data) VALUES (@Id, @Nota, @Data); SELECT I" & _
    "d, Nota, Data FROM dbo.StalliNoteSt WHERE (Id = @Id)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT Id, Nota, Data FROM dbo.StalliNoteSt ORDER BY Data"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.StalliNoteSt SET Id = @Id, Nota = @Nota, Data = @Data WHERE (Id = @Ori" & _
    "ginal_Id) AND (Data = @Original_Data OR @Original_Data IS NULL AND Data IS NULL)" & _
    "; SELECT Id, Nota, Data FROM dbo.StalliNoteSt WHERE (Id = @Id)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsStalli, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaStalli As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dgStalli As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlStalli As System.Web.UI.WebControls.Panel
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaStradarioBologna As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents VSStalli As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents DaSettori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsStalli As ATCBussm1.DsStalli
  Protected WithEvents lblVia As System.Web.UI.WebControls.Label
  Protected WithEvents lblPeriodo As System.Web.UI.WebControls.Label
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents pnlSearch As System.Web.UI.WebControls.Panel
  Protected WithEvents cboSettori As System.Web.UI.WebControls.DropDownList
  Protected WithEvents LnkStampa As System.Web.UI.WebControls.LinkButton
  Protected WithEvents DaStalliNotest As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgNoteSt As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LnkAggiuntaNote As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlNote As System.Web.UI.WebControls.Panel

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private oUtente As Utente
  Private Where As String = ""
  Private pUnspecified As String = "[Non specificato]"

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    If Not IsPostBack Then

      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      DsStalli.Tables("Stalli").Clear()
      DaStalli.Fill(DsStalli.Tables("Stalli"))
      DaSettori.Fill(DsStalli.Tables("Settori"))
      cboSettori.DataBind()
      cboSettori.Items.Insert(0, pUnspecified)
      Ricerca()
      dgStalli.CurrentPageIndex = 0
      dgStalli.DataBind()
      pnlStalli.Visible = True
      pnlNote.Visible = False

    End If
  End Sub
  Private Sub Ricerca()

    pBuildWhere()
    If Where.Length > 0 And DaStalli.SelectCommand.CommandText.IndexOf("WHERE") < 0 Then
      DaStalli.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If DaStalli.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaStalli.SelectCommand.CommandText &= " Order By  Stalli.CivKey"
    End If
    DsStalli.Tables("Stalli").Clear()
    DaStalli.Fill(DsStalli.Tables("Stalli"))
    dgStalli.DataBind()
    pnlStalli.Visible = True
    pnlNote.Visible = False

  End Sub
  Private Sub pBuildWhere()
    Where = ""
    If txtVia.Text.Length > 0 Then
      Where &= "StradarioBologna.Nome Like '%" & txtVia.Text.Replace("'", "''") & "%'"
    End If
    If cboSettori.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "Stalli.ID_SZF = " & cboSettori.SelectedValue
    End If
  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgStalli.EditItemIndex = e.Item.ItemIndex
    DaStalli.Fill(DsStalli.Tables("Stalli"))
    Ricerca()
    DaStradarioBologna.Fill(DsStalli.Tables("StradarioBologna"))
    DirectCast(dgStalli.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).DataBind()

    DaSettori.Fill(DsStalli.Tables("Settori"))
    DirectCast(dgStalli.Items(e.Item.ItemIndex).Cells(4).Controls(1), DropDownList).DataBind()

    If e.Item.Cells(1).Text <> "&nbsp;" Then
      DirectCast(dgStalli.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).SelectedValue = e.Item.Cells(1).Text
    End If
    If e.Item.Cells(3).Text <> "&nbsp;" Then
      DirectCast(dgStalli.Items(e.Item.ItemIndex).Cells(4).Controls(1), DropDownList).SelectedValue = e.Item.Cells(3).Text
    End If


  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaStalli.Fill(DsStalli, "Stalli")
    drF = DsStalli.Tables("Stalli").Rows.Find(dgStalli.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaStalli.Update(DsStalli, "Stalli")
    End If
    dgStalli.CurrentPageIndex = 0
    dgStalli.EditItemIndex = -1

    Ricerca()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa via?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgStalli.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Dim Budget As Double
    Dim Consuntivo As Double

    Me.Validate()
    If Me.IsValid Then

      DaStalli.Fill(DsStalli.Tables("Stalli"))
      drF = DsStalli.Tables("Stalli").Rows.Find(dgStalli.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsStalli.Tables("Stalli").NewRow
        'drF.Item("Id") = dgStalli.DataKeys(e.Item.ItemIndex)
        DsStalli.Tables("Stalli").Rows.Add(drF)
      End If

      drF.Item("CivKey") = DirectCast(e.Item.Cells(2).Controls(1), DropDownList).SelectedValue
      drF.Item("ID_SZF") = DirectCast(e.Item.Cells(4).Controls(1), DropDownList).SelectedValue
      drF.Item("Note") = DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim
      drF.Item("Blu") = IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim)
      drF.Item("Verde") = IIf(DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim)
      drF.Item("Handi") = IIf(DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim)
      drF.Item("Residenti") = IIf(DirectCast(e.Item.Cells(9).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(9).Controls(1), TextBox).Text.Trim)
      drF.Item("RiservatoGenerico") = IIf(DirectCast(e.Item.Cells(10).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(10).Controls(1), TextBox).Text.Trim)
      drF.Item("CaricoScarico") = IIf(DirectCast(e.Item.Cells(11).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(11).Controls(1), TextBox).Text.Trim)
      drF.Item("Moto") = IIf(DirectCast(e.Item.Cells(12).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(12).Controls(1), TextBox).Text.Trim)
      drF.Item("discoorario") = IIf(DirectCast(e.Item.Cells(13).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(13).Controls(1), TextBox).Text.Trim)
      drF.Item("sospesi") = IIf(DirectCast(e.Item.Cells(14).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(14).Controls(1), TextBox).Text.Trim)
      drF.Item("libera") = IIf(DirectCast(e.Item.Cells(15).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(15).Controls(1), TextBox).Text.Trim)
      drF.Item("Carsharing") = IIf(DirectCast(e.Item.Cells(16).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(16).Controls(1), TextBox).Text.Trim)

      DaStalli.Update(DsStalli, "Stalli")
      Ricerca()
      dgStalli.EditItemIndex = -1
      dgStalli.DataBind()

    End If

  End Sub

  Public Sub CVNumerico_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow

    Ricerca()
    dgStalli.CurrentPageIndex = 0
    dr = DsStalli.Tables("Stalli").NewRow

    DsStalli.Tables("Stalli").Rows.InsertAt(dr, 0)
    dgStalli.EditItemIndex = 0
    dgStalli.DataBind()
    DaStradarioBologna.Fill(DsStalli.Tables("StradarioBologna"))
    DirectCast(dgStalli.Items(0).Cells(2).Controls(1), DropDownList).DataBind()
    DaSettori.Fill(DsStalli.Tables("Settori"))
    DirectCast(dgStalli.Items(0).Cells(4).Controls(1), DropDownList).DataBind()


  End Sub

  Private Sub dgStalli_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgStalli.PageIndexChanged

    dgStalli.CurrentPageIndex = e.NewPageIndex
    Ricerca()

  End Sub

  Private Sub dgStalli_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStalli.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub dgStalli_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStalli.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub dgStalli_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStalli.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub dgStalli_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgStalli.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub dgStalli_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStalli.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub


  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    Ricerca()
  End Sub

  '------------------------Inizio note di stampa-----------------------------

  Private Sub LnkStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkStampa.Click

    RicercaNote()
    pnlStalli.Visible = False
    pnlNote.Visible = True

  End Sub

  Private Sub RicercaNote()

    DsStalli.Tables("StalliNoteSt").Clear()
    DaStalliNotest.Fill(DsStalli.Tables("StalliNoteSt"))
    dgNoteSt.DataBind()

  End Sub

  Public Sub pItemCreatedNote(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDeleteNote")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa nota?');")
    End If

  End Sub

  Private Function MeseDopo() As String
    Dim StrSQL As String
    StrSQL = "Select TOP 1 Data from StalliNoteSt order by data desc"

    Dim com As New SqlCommand(StrSQL, con)
    Dim dRead As SqlDataReader
    Dim DtData As DateTime
    con.Open()

    dRead = com.ExecuteReader
    dRead.Read()
    If dRead.HasRows = True Then
      DtData = IIf(IsDBNull(dRead.Item("Data")), Now, dRead.Item("Data"))
      MeseDopo = "01/" & Format(Month(DtData) + 1, "00") & "/" & Format(Year(DtData), "0000")
    Else
      MeseDopo = Format(Now, "01/MM/yyyy")
    End If
    con.Close()
  End Function

  Private Sub LnkAggiuntaNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkAggiuntaNote.Click
    Dim dr As Data.DataRow

    RicercaNote()
    dr = DsStalli.Tables("StalliNoteSt").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopo()
    DsStalli.Tables("StalliNoteSt").Rows.InsertAt(dr, 0)
    dgNoteSt.EditItemIndex = 0

    dgNoteSt.DataBind()

  End Sub

  Private Sub dgNoteSt_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSt.EditCommand

    dgNoteSt.EditItemIndex = e.Item.ItemIndex
    DaStalliNotest.Fill(DsStalli.Tables("StalliNoteSt"))
    RicercaNote()

  End Sub

  Private Sub dgNoteSt_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSt.CancelCommand

    dgNoteSt.EditItemIndex = -1
    RicercaNote()

  End Sub

  Private Sub dgNoteSt_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSt.DeleteCommand

    Dim drF As DataRow

    DaStalliNotest.Fill(DsStalli, "StalliNoteSt")
    drF = DsStalli.Tables("StalliNoteSt").Rows.Find(dgNoteSt.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaStalliNotest.Update(DsStalli, "StalliNoteSt")
    End If

    dgNoteSt.EditItemIndex = -1

    RicercaNote()

  End Sub

  Private Sub dgNoteSt_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSt.UpdateCommand

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Me.Validate()
    If Me.IsValid Then

      DaStalliNotest.Fill(DsStalli.Tables("StalliNoteSt"))
      drF = DsStalli.Tables("StalliNoteSt").Rows.Find(dgNoteSt.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsStalli.Tables("StalliNoteSt").NewRow
        drF.Item("Id") = dgNoteSt.DataKeys(e.Item.ItemIndex)
        DsStalli.Tables("StalliNoteSt").Rows.Add(drF)
      End If

      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      drF.Item("Nota") = DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim
      DaStalliNotest.Update(DsStalli, "StalliNoteSt")
      RicercaNote()
      dgNoteSt.EditItemIndex = -1
      dgNoteSt.DataBind()

    End If

  End Sub

  '------------------------Fine note di stampa---------------------------

End Class
