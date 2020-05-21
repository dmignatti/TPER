Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class wf_pianososta
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daEsecutori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daTipi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daCausali = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.daZone = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
    Me.daToponimi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
    Me.daLavori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsValori = New ATCBussm1.dsValori
    CType(Me.DsValori, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'daEsecutori
    '
    Me.daEsecutori.DeleteCommand = Me.SqlDeleteCommand1
    Me.daEsecutori.InsertCommand = Me.SqlInsertCommand1
    Me.daEsecutori.SelectCommand = Me.SqlSelectCommand1
    Me.daEsecutori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradaliEsecutori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdEsecutore", "IdEsecutore"), New System.Data.Common.DataColumnMapping("Esecutore", "Esecutore")})})
    Me.daEsecutori.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.LavoriStradaliEsecutori WHERE (IdEsecutore = @Original_IdEsecutor" & _
    "e) AND (Esecutore = @Original_Esecutore OR @Original_Esecutore IS NULL AND Esecu" & _
    "tore IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdEsecutore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdEsecutore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esecutore", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esecutore", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.LavoriStradaliEsecutori(IdEsecutore, Esecutore) VALUES (@IdEsecut" & _
    "ore, @Esecutore); SELECT IdEsecutore, Esecutore FROM dbo.LavoriStradaliEsecutori" & _
    " WHERE (IdEsecutore = @IdEsecutore) ORDER BY Esecutore"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdEsecutore", System.Data.SqlDbType.Int, 4, "IdEsecutore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esecutore", System.Data.SqlDbType.VarChar, 100, "Esecutore"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdEsecutore, Esecutore FROM dbo.LavoriStradaliEsecutori ORDER BY Esecutore" & _
    ""
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.LavoriStradaliEsecutori SET IdEsecutore = @IdEsecutore, Esecutore = @E" & _
    "secutore WHERE (IdEsecutore = @Original_IdEsecutore) AND (Esecutore = @Original_" & _
    "Esecutore OR @Original_Esecutore IS NULL AND Esecutore IS NULL); SELECT IdEsecut" & _
    "ore, Esecutore FROM dbo.LavoriStradaliEsecutori WHERE (IdEsecutore = @IdEsecutor" & _
    "e) ORDER BY Esecutore"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdEsecutore", System.Data.SqlDbType.Int, 4, "IdEsecutore"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esecutore", System.Data.SqlDbType.VarChar, 100, "Esecutore"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdEsecutore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdEsecutore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esecutore", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esecutore", System.Data.DataRowVersion.Original, Nothing))
    '
    'daTipi
    '
    Me.daTipi.DeleteCommand = Me.SqlDeleteCommand2
    Me.daTipi.InsertCommand = Me.SqlInsertCommand2
    Me.daTipi.SelectCommand = Me.SqlSelectCommand2
    Me.daTipi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradaliTipi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdTipo", "IdTipo"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
    Me.daTipi.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.LavoriStradaliTipi WHERE (IdTipo = @Original_IdTipo) AND (Tipo = " & _
    "@Original_Tipo OR @Original_Tipo IS NULL AND Tipo IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.LavoriStradaliTipi (IdTipo, Tipo) VALUES (@IdTipo, @Tipo); SELECT" & _
    " IdTipo, Tipo FROM dbo.LavoriStradaliTipi WHERE (IdTipo = @IdTipo) ORDER BY Tipo" & _
    ""
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 4, "IdTipo"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdTipo, Tipo FROM dbo.LavoriStradaliTipi ORDER BY Tipo"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.LavoriStradaliTipi SET IdTipo = @IdTipo, Tipo = @Tipo WHERE (IdTipo = " & _
    "@Original_IdTipo) AND (Tipo = @Original_Tipo OR @Original_Tipo IS NULL AND Tipo " & _
    "IS NULL); SELECT IdTipo, Tipo FROM dbo.LavoriStradaliTipi WHERE (IdTipo = @IdTip" & _
    "o) ORDER BY Tipo"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 4, "IdTipo"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    '
    'daCausali
    '
    Me.daCausali.DeleteCommand = Me.SqlDeleteCommand3
    Me.daCausali.InsertCommand = Me.SqlInsertCommand3
    Me.daCausali.SelectCommand = Me.SqlSelectCommand3
    Me.daCausali.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradaliCausali", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdCausale", "IdCausale"), New System.Data.Common.DataColumnMapping("Causale", "Causale")})})
    Me.daCausali.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.LavoriStradaliCausali WHERE (IdCausale = @Original_IdCausale) AND" & _
    " (Causale = @Original_Causale OR @Original_Causale IS NULL AND Causale IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCausale", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCausale", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Causale", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Causale", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.LavoriStradaliCausali(IdCausale, Causale) VALUES (@IdCausale, @Ca" & _
    "usale); SELECT IdCausale, Causale FROM dbo.LavoriStradaliCausali WHERE (IdCausal" & _
    "e = @IdCausale) ORDER BY Causale"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCausale", System.Data.SqlDbType.Int, 4, "IdCausale"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Causale", System.Data.SqlDbType.VarChar, 100, "Causale"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT IdCausale, Causale FROM dbo.LavoriStradaliCausali ORDER BY Causale"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.LavoriStradaliCausali SET IdCausale = @IdCausale, Causale = @Causale W" & _
    "HERE (IdCausale = @Original_IdCausale) AND (Causale = @Original_Causale OR @Orig" & _
    "inal_Causale IS NULL AND Causale IS NULL); SELECT IdCausale, Causale FROM dbo.La" & _
    "voriStradaliCausali WHERE (IdCausale = @IdCausale) ORDER BY Causale"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCausale", System.Data.SqlDbType.Int, 4, "IdCausale"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Causale", System.Data.SqlDbType.VarChar, 100, "Causale"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCausale", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCausale", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Causale", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Causale", System.Data.DataRowVersion.Original, Nothing))
    '
    'daZone
    '
    Me.daZone.DeleteCommand = Me.SqlDeleteCommand4
    Me.daZone.InsertCommand = Me.SqlInsertCommand4
    Me.daZone.SelectCommand = Me.SqlSelectCommand4
    Me.daZone.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradaliZone", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Zona", "Zona")})})
    Me.daZone.UpdateCommand = Me.SqlUpdateCommand4
    '
    'SqlDeleteCommand4
    '
    Me.SqlDeleteCommand4.CommandText = "DELETE FROM dbo.LavoriStradaliZone WHERE (IdZona = @Original_IdZona) AND (Zona = " & _
    "@Original_Zona OR @Original_Zona IS NULL AND Zona IS NULL)"
    Me.SqlDeleteCommand4.Connection = Me.con
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdZona", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zona", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand4
    '
    Me.SqlInsertCommand4.CommandText = "INSERT INTO dbo.LavoriStradaliZone(IdZona, Zona) VALUES (@IdZona, @Zona); SELECT " & _
    "IdZona, Zona FROM dbo.LavoriStradaliZone WHERE (IdZona = @IdZona)"
    Me.SqlInsertCommand4.Connection = Me.con
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.Int, 4, "IdZona"))
    Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.VarChar, 50, "Zona"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT IdZona, Zona FROM dbo.LavoriStradaliZone Order By Zona"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'SqlUpdateCommand4
    '
    Me.SqlUpdateCommand4.CommandText = "UPDATE dbo.LavoriStradaliZone SET IdZona = @IdZona, Zona = @Zona WHERE (IdZona = " & _
    "@Original_IdZona) AND (Zona = @Original_Zona OR @Original_Zona IS NULL AND Zona " & _
    "IS NULL); SELECT IdZona, Zona FROM dbo.LavoriStradaliZone WHERE (IdZona = @IdZon" & _
    "a)"
    Me.SqlUpdateCommand4.Connection = Me.con
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.Int, 4, "IdZona"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.VarChar, 50, "Zona"))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdZona", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zona", System.Data.DataRowVersion.Original, Nothing))
    '
    'daToponimi
    '
    Me.daToponimi.DeleteCommand = Me.SqlDeleteCommand5
    Me.daToponimi.InsertCommand = Me.SqlInsertCommand5
    Me.daToponimi.SelectCommand = Me.SqlSelectCommand5
    Me.daToponimi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "StradarioBologna", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codice", "Codice"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("cod_comune", "cod_comune"), New System.Data.Common.DataColumnMapping("cod_prov", "cod_prov")})})
    Me.daToponimi.UpdateCommand = Me.SqlUpdateCommand5
    '
    'SqlDeleteCommand5
    '
    Me.SqlDeleteCommand5.CommandText = "DELETE FROM dbo.StradarioBologna WHERE (Codice = @Original_Codice) AND (cod_comun" & _
    "e = @Original_cod_comune) AND (cod_prov = @Original_cod_prov) AND (Nome = @Origi" & _
    "nal_Nome OR @Original_Nome IS NULL AND Nome IS NULL)"
    Me.SqlDeleteCommand5.Connection = Me.con
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codice", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codice", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_comune", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_comune", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_prov", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prov", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand5
    '
    Me.SqlInsertCommand5.CommandText = "INSERT INTO dbo.StradarioBologna(Codice, Nome, cod_comune, cod_prov) VALUES (@Cod" & _
    "ice, @Nome, @cod_comune, @cod_prov); SELECT Codice, Nome, cod_comune, cod_prov F" & _
    "ROM dbo.StradarioBologna WHERE (Codice = @Codice) AND (cod_comune = @cod_comune)" & _
    " AND (cod_prov = @cod_prov) ORDER BY Nome"
    Me.SqlInsertCommand5.Connection = Me.con
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.Int, 4, "Codice"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 255, "Nome"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_comune", System.Data.SqlDbType.Int, 4, "cod_comune"))
    Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_prov", System.Data.SqlDbType.Int, 4, "cod_prov"))
    '
    'SqlSelectCommand5
    '
    Me.SqlSelectCommand5.CommandText = "SELECT Codice, Nome, cod_comune, cod_prov FROM dbo.StradarioBologna WHERE (cod_pr" & _
    "ov = 37) AND (cod_comune = 6) ORDER BY Nome"
    Me.SqlSelectCommand5.Connection = Me.con
    '
    'SqlUpdateCommand5
    '
    Me.SqlUpdateCommand5.CommandText = "UPDATE dbo.StradarioBologna SET Codice = @Codice, Nome = @Nome, cod_comune = @cod" & _
    "_comune, cod_prov = @cod_prov WHERE (Codice = @Original_Codice) AND (cod_comune " & _
    "= @Original_cod_comune) AND (cod_prov = @Original_cod_prov) AND (Nome = @Origina" & _
    "l_Nome OR @Original_Nome IS NULL AND Nome IS NULL); SELECT Codice, Nome, cod_com" & _
    "une, cod_prov FROM dbo.StradarioBologna WHERE (Codice = @Codice) AND (cod_comune" & _
    " = @cod_comune) AND (cod_prov = @cod_prov) ORDER BY Nome"
    Me.SqlUpdateCommand5.Connection = Me.con
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.Int, 4, "Codice"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 255, "Nome"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_comune", System.Data.SqlDbType.Int, 4, "cod_comune"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_prov", System.Data.SqlDbType.Int, 4, "cod_prov"))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codice", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codice", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_comune", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_comune", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_prov", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_prov", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    '
    'daLavori
    '
    Me.daLavori.DeleteCommand = Me.SqlCommand1
    Me.daLavori.InsertCommand = Me.SqlCommand2
    Me.daLavori.SelectCommand = Me.SqlSelectCommand6
    Me.daLavori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradali", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Toponimo", "Toponimo"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Causale", "Causale"), New System.Data.Common.DataColumnMapping("Esecutore", "Esecutore"), New System.Data.Common.DataColumnMapping("Zona", "Zona"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Titolo", "Titolo"), New System.Data.Common.DataColumnMapping("Testo", "Testo"), New System.Data.Common.DataColumnMapping("File", "File"), New System.Data.Common.DataColumnMapping("Ext", "Ext"), New System.Data.Common.DataColumnMapping("DataInizio", "DataInizio"), New System.Data.Common.DataColumnMapping("DataFine", "DataFine"), New System.Data.Common.DataColumnMapping("IdTipo", "IdTipo"), New System.Data.Common.DataColumnMapping("IdCausale", "IdCausale"), New System.Data.Common.DataColumnMapping("IdEsecutore", "IdEsecutore"), New System.Data.Common.DataColumnMapping("VerticaleInstallata", "VerticaleInstallata"), New System.Data.Common.DataColumnMapping("VerticaleRimossa", "VerticaleRimossa"), New System.Data.Common.DataColumnMapping("VerticaleSostituita", "VerticaleSostituita"), New System.Data.Common.DataColumnMapping("StalliInLinea", "StalliInLinea"), New System.Data.Common.DataColumnMapping("StalliAPettine", "StalliAPettine"), New System.Data.Common.DataColumnMapping("StalliMoto", "StalliMoto"), New System.Data.Common.DataColumnMapping("StalliCancInLinea", "StalliCancInLinea"), New System.Data.Common.DataColumnMapping("StalliCancAPettine", "StalliCancAPettine"), New System.Data.Common.DataColumnMapping("StalliCancMoto", "StalliCancMoto"), New System.Data.Common.DataColumnMapping("Fittoni", "Fittoni"), New System.Data.Common.DataColumnMapping("Formaggioni", "Formaggioni"), New System.Data.Common.DataColumnMapping("IdVia", "IdVia"), New System.Data.Common.DataColumnMapping("Ordinanza", "Ordinanza"), New System.Data.Common.DataColumnMapping("PaliNuovi", "PaliNuovi"), New System.Data.Common.DataColumnMapping("PaliEliminati", "PaliEliminati"), New System.Data.Common.DataColumnMapping("PaliRipristinati", "PaliRipristinati"), New System.Data.Common.DataColumnMapping("CartelliNuovi", "CartelliNuovi"), New System.Data.Common.DataColumnMapping("CartelliEliminati", "CartelliEliminati"), New System.Data.Common.DataColumnMapping("CartelliRipristinati", "CartelliRipristinati"), New System.Data.Common.DataColumnMapping("StalliONuovi", "StalliONuovi"), New System.Data.Common.DataColumnMapping("StalliOEliminati", "StalliOEliminati"), New System.Data.Common.DataColumnMapping("StalliORipristinati", "StalliORipristinati"), New System.Data.Common.DataColumnMapping("StalliRRNuovi", "StalliRRNuovi"), New System.Data.Common.DataColumnMapping("StalliRREliminati", "StalliRREliminati"), New System.Data.Common.DataColumnMapping("StalliRRRipristinati", "StalliRRRipristinati"), New System.Data.Common.DataColumnMapping("ResidentiNuovi", "ResidentiNuovi"), New System.Data.Common.DataColumnMapping("ResidentiEliminati", "ResidentiEliminati"), New System.Data.Common.DataColumnMapping("ResidentiRipristinati", "ResidentiRipristinati"), New System.Data.Common.DataColumnMapping("StalliMotoNuovi", "StalliMotoNuovi"), New System.Data.Common.DataColumnMapping("StalliMotoEliminati", "StalliMotoEliminati"), New System.Data.Common.DataColumnMapping("StalliMotoRipristinati", "StalliMotoRipristinati"), New System.Data.Common.DataColumnMapping("FittoniNuovi", "FittoniNuovi"), New System.Data.Common.DataColumnMapping("FittoniEliminati", "FittoniEliminati"), New System.Data.Common.DataColumnMapping("FittoniRipristinati", "FittoniRipristinati"), New System.Data.Common.DataColumnMapping("FormaggioniNuovi", "FormaggioniNuovi"), New System.Data.Common.DataColumnMapping("FormaggioniEliminati", "FormaggioniEliminati"), New System.Data.Common.DataColumnMapping("FormaggioniRipristinati", "FormaggioniRipristinati")})})
    Me.daLavori.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.LavoriStradali SET DataCancellazione = GETDATE() WHERE (Id = @Original" & _
    "_Id) AND (CartelliEliminati = @Original_CartelliEliminati OR @Original_CartelliE" & _
    "liminati IS NULL AND CartelliEliminati IS NULL) AND (CartelliNuovi = @Original_C" & _
    "artelliNuovi OR @Original_CartelliNuovi IS NULL AND CartelliNuovi IS NULL) AND (" & _
    "CartelliRipristinati = @Original_CartelliRipristinati OR @Original_CartelliRipri" & _
    "stinati IS NULL AND CartelliRipristinati IS NULL) AND (DataFine = @Original_Data" & _
    "Fine OR @Original_DataFine IS NULL AND DataFine IS NULL) AND (DataInizio = @Orig" & _
    "inal_DataInizio OR @Original_DataInizio IS NULL AND DataInizio IS NULL) AND (Ext" & _
    " = @Original_Ext OR @Original_Ext IS NULL AND Ext IS NULL) AND ([File] = @Origin" & _
    "al_File OR @Original_File IS NULL AND [File] IS NULL) AND (FittoniEliminati = @O" & _
    "riginal_FittoniEliminati OR @Original_FittoniEliminati IS NULL AND FittoniElimin" & _
    "ati IS NULL) AND (FittoniNuovi = @Original_FittoniNuovi OR @Original_FittoniNuov" & _
    "i IS NULL AND FittoniNuovi IS NULL) AND (FittoniRipristinati = @Original_Fittoni" & _
    "Ripristinati OR @Original_FittoniRipristinati IS NULL AND FittoniRipristinati IS" & _
    " NULL) AND (FormaggioniEliminati = @Original_FormaggioniEliminati OR @Original_F" & _
    "ormaggioniEliminati IS NULL AND FormaggioniEliminati IS NULL) AND (FormaggioniNu" & _
    "ovi = @Original_FormaggioniNuovi OR @Original_FormaggioniNuovi IS NULL AND Forma" & _
    "ggioniNuovi IS NULL) AND (FormaggioniRipristinati = @Original_FormaggioniRiprist" & _
    "inati OR @Original_FormaggioniRipristinati IS NULL AND FormaggioniRipristinati I" & _
    "S NULL) AND (IdCausale = @Original_IdCausale OR @Original_IdCausale IS NULL AND " & _
    "IdCausale IS NULL) AND (IdEsecutore = @Original_IdEsecutore OR @Original_IdEsecu" & _
    "tore IS NULL AND IdEsecutore IS NULL) AND (IdTipo = @Original_IdTipo OR @Origina" & _
    "l_IdTipo IS NULL AND IdTipo IS NULL) AND (IdVia = @Original_IdVia OR @Original_I" & _
    "dVia IS NULL AND IdVia IS NULL) AND (IdZona = @Original_IdZona OR @Original_IdZo" & _
    "na IS NULL AND IdZona IS NULL) AND (Ordinanza = @Original_Ordinanza OR @Original" & _
    "_Ordinanza IS NULL AND Ordinanza IS NULL) AND (PaliEliminati = @Original_PaliEli" & _
    "minati OR @Original_PaliEliminati IS NULL AND PaliEliminati IS NULL) AND (PaliNu" & _
    "ovi = @Original_PaliNuovi OR @Original_PaliNuovi IS NULL AND PaliNuovi IS NULL) " & _
    "AND (PaliRipristinati = @Original_PaliRipristinati OR @Original_PaliRipristinati" & _
    " IS NULL AND PaliRipristinati IS NULL) AND (ResidentiEliminati = @Original_Resid" & _
    "entiEliminati OR @Original_ResidentiEliminati IS NULL AND ResidentiEliminati IS " & _
    "NULL) AND (ResidentiNuovi = @Original_ResidentiNuovi OR @Original_ResidentiNuovi" & _
    " IS NULL AND ResidentiNuovi IS NULL) AND (ResidentiRipristinati = @Original_Resi" & _
    "dentiRipristinati OR @Original_ResidentiRipristinati IS NULL AND ResidentiRipris" & _
    "tinati IS NULL) AND (StalliMotoEliminati = @Original_StalliMotoEliminati OR @Ori" & _
    "ginal_StalliMotoEliminati IS NULL AND StalliMotoEliminati IS NULL) AND (StalliMo" & _
    "toNuovi = @Original_StalliMotoNuovi OR @Original_StalliMotoNuovi IS NULL AND Sta" & _
    "lliMotoNuovi IS NULL) AND (StalliMotoRipristinati = @Original_StalliMotoRipristi" & _
    "nati OR @Original_StalliMotoRipristinati IS NULL AND StalliMotoRipristinati IS N" & _
    "ULL) AND (StalliOEliminati = @Original_StalliOEliminati OR @Original_StalliOElim" & _
    "inati IS NULL AND StalliOEliminati IS NULL) AND (StalliONuovi = @Original_Stalli" & _
    "ONuovi OR @Original_StalliONuovi IS NULL AND StalliONuovi IS NULL) AND (StalliOR" & _
    "ipristinati = @Original_StalliORipristinati OR @Original_StalliORipristinati IS " & _
    "NULL AND StalliORipristinati IS NULL) AND (StalliRREliminati = @Original_StalliR" & _
    "REliminati OR @Original_StalliRREliminati IS NULL AND StalliRREliminati IS NULL)" & _
    " AND (StalliRRNuovi = @Original_StalliRRNuovi OR @Original_StalliRRNuovi IS NULL" & _
    " AND StalliRRNuovi IS NULL) AND (StalliRRRipristinati = @Original_StalliRRRipris" & _
    "tinati OR @Original_StalliRRRipristinati IS NULL AND StalliRRRipristinati IS NUL" & _
    "L) AND (Testo = @Original_Testo OR @Original_Testo IS NULL AND Testo IS NULL) AN" & _
    "D (Titolo = @Original_Titolo OR @Original_Titolo IS NULL AND Titolo IS NULL) AND" & _
    " (PaliExNovo = @Original_PaliExNovo OR @Original_PaliExNovo IS NULL AND PaliExNo" & _
    "vo IS NULL) AND (CartelliExNovo = @Original_CartelliExNovo OR @Original_Cartelli" & _
    "ExNovo IS NULL AND CartelliExNovo IS NULL) AND (StalliOExNovo = @Original_Stalli" & _
    "OExNovo OR @Original_StalliOExNovo IS NULL AND StalliOExNovo IS NULL) AND (Stall" & _
    "iRRExNovo = @Original_StalliRRExNovo OR @Original_StalliRRExNovo IS NULL AND Sta" & _
    "lliRRExNovo IS NULL) AND (ResidentiExNovo = @Original_ResidentiExNovo OR @Origin" & _
    "al_ResidentiExNovo IS NULL AND ResidentiExNovo IS NULL) AND (StalliMotoExNovo = " & _
    "@Original_StalliMotoExNovo OR @Original_StalliMotoExNovo IS NULL AND StalliMotoE" & _
    "xNovo IS NULL) AND (FittoniExNovo = @Original_FittoniExNovo OR @Original_Fittoni" & _
    "ExNovo IS NULL AND FittoniExNovo IS NULL) AND (FormaggioniExNovo = @Original_For" & _
    "maggioniExNovo OR @Original_FormaggioniExNovo IS NULL AND FormaggioniExNovo IS N" & _
    "ULL) AND (CarsharingNuovi = @Original_CarsharingNuovi OR @Original_CarsharingNuo" & _
    "vi IS NULL AND CarsharingNuovi IS NULL) AND (CarsharingEliminati = @Original_Car" & _
    "sharingEliminati OR @Original_CarsharingEliminati IS NULL AND CarsharingEliminat" & _
    "i IS NULL) AND (CarsharingRipristinati = @Original_CarsharingRipristinati OR @Or" & _
    "iginal_CarsharingRipristinati IS NULL AND CarsharingRipristinati IS NULL) AND (C" & _
    "arsharingExNovo = @Original_CarsharingExNovo OR @Original_CarsharingExNovo IS NU" & _
    "LL AND CarsharingExNovo IS NULL) AND (DisabiliNuovi = @Original_DisabiliNuovi OR" & _
    " @Original_DisabiliNuovi IS NULL AND DisabiliNuovi IS NULL) AND (DisabiliElimina" & _
    "ti = @Original_DisabiliEliminati OR @Original_DisabiliEliminati IS NULL AND Disa" & _
    "biliEliminati IS NULL) AND (DisabiliRipristinati = @Original_DisabiliRipristinat" & _
    "i OR @Original_DisabiliRipristinati IS NULL AND DisabiliRipristinati IS NULL) AN" & _
    "D (DisabiliExNovo = @Original_DisabiliExNovo OR @Original_DisabiliExNovo IS NULL" & _
    " AND DisabiliExNovo IS NULL) AND (GenericiNuovi = @Original_GenericiNuovi OR @Or" & _
    "iginal_GenericiNuovi IS NULL AND GenericiNuovi IS NULL) AND (GenericiEliminati =" & _
    " @Original_GenericiEliminati OR @Original_GenericiEliminati IS NULL AND Generici" & _
    "Eliminati IS NULL) AND (GenericiRipristinati = @Original_GenericiRipristinati OR" & _
    " @Original_GenericiRipristinati IS NULL AND GenericiRipristinati IS NULL) AND (G" & _
    "enericiExNovo = @Original_GenericiExNovo OR @Original_GenericiExNovo IS NULL AND" & _
    " GenericiExNovo IS NULL) AND (DiscoOrarioNuovi = @Original_DiscoOrarioNuovi OR @" & _
    "Original_DiscoOrarioNuovi IS NULL AND DiscoOrarioNuovi IS NULL) AND (DiscoOrario" & _
    "Eliminati = @Original_DiscoOrarioEliminati OR @Original_DiscoOrarioEliminati IS " & _
    "NULL AND DiscoOrarioEliminati IS NULL) AND (DiscoOrarioRipristinati = @Original_" & _
    "DiscoOrarioRipristinati OR @Original_DiscoOrarioRipristinati IS NULL AND DiscoOr" & _
    "arioRipristinati IS NULL) AND (DiscoOrarioExNovo = @Original_DiscoOrarioExNovo O" & _
    "R @Original_DiscoOrarioExNovo IS NULL AND DiscoOrarioExNovo IS NULL) AND (Carico" & _
    "ScaricoNuovi = @Original_CaricoScaricoNuovi OR @Original_CaricoScaricoNuovi IS N" & _
    "ULL AND CaricoScaricoNuovi IS NULL) AND (CaricoScaricoEliminati = @Original_Cari" & _
    "coScaricoEliminati OR @Original_CaricoScaricoEliminati IS NULL AND CaricoScarico" & _
    "Eliminati IS NULL) AND (CaricoScaricoRipristinati = @Original_CaricoScaricoRipri" & _
    "stinati OR @Original_CaricoScaricoRipristinati IS NULL AND CaricoScaricoRipristi" & _
    "nati IS NULL) AND (CaricoScaricoExNovo = @Original_CaricoScaricoExNovo OR @Origi" & _
    "nal_CaricoScaricoExNovo IS NULL AND CaricoScaricoExNovo IS NULL)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataFine", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataFine", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataInizio", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataInizio", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ext", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ext", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_File", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "File", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCausale", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCausale", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdEsecutore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdEsecutore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdVia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdZona", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinanza", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinanza", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliOEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliOEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliONuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliONuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliORipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliORipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRREliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRREliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Testo", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Testo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Titolo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Titolo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliOExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliOExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoExNovo", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "INSERT INTO dbo.LavoriStradali (IdVia, IdZona, Titolo, Ordinanza, Testo, [File], " & _
    "Ext, DataInizio, DataFine, IdTipo, IdCausale, IdEsecutore, PaliNuovi, PaliElimin" & _
    "ati, PaliRipristinati, CartelliNuovi, CartelliEliminati, CartelliRipristinati, S" & _
    "talliONuovi, StalliOEliminati, StalliORipristinati, StalliRRNuovi, StalliRRElimi" & _
    "nati, StalliRRRipristinati, ResidentiNuovi, ResidentiEliminati, ResidentiRiprist" & _
    "inati, StalliMotoNuovi, StalliMotoEliminati, StalliMotoRipristinati, FittoniNuov" & _
    "i, FittoniEliminati, FittoniRipristinati, FormaggioniNuovi, FormaggioniEliminati" & _
    ", FormaggioniRipristinati, PaliExNovo, CartelliExNovo, StalliOExNovo, StalliRREx" & _
    "Novo, ResidentiExNovo, StalliMotoExNovo, FittoniExNovo, FormaggioniExNovo, Carsh" & _
    "aringNuovi, CarsharingEliminati, CarsharingRipristinati, CarsharingExNovo, Disab" & _
    "iliNuovi, DisabiliEliminati, DisabiliRipristinati, DisabiliExNovo, GenericiNuovi" & _
    ", GenericiEliminati, GenericiRipristinati, GenericiExNovo, DiscoOrarioNuovi, Dis" & _
    "coOrarioEliminati, DiscoOrarioRipristinati, DiscoOrarioExNovo, CaricoScaricoNuov" & _
    "i, CaricoScaricoEliminati, CaricoScaricoRipristinati, CaricoScaricoExNovo) VALUE" & _
    "S (@IdVia, @IdZona, @Titolo, @Ordinanza, @Testo, @File, @Ext, @DataInizio, @Data" & _
    "Fine, @IdTipo, @IdCausale, @IdEsecutore, @PaliNuovi, @PaliEliminati, @PaliRipris" & _
    "tinati, @CartelliNuovi, @CartelliEliminati, @CartelliRipristinati, @StalliONuovi" & _
    ", @StalliOEliminati, @StalliORipristinati, @StalliRRNuovi, @StalliRREliminati, @" & _
    "StalliRRRipristinati, @ResidentiNuovi, @ResidentiEliminati, @ResidentiRipristina" & _
    "ti, @StalliMotoNuovi, @StalliMotoEliminati, @StalliMotoRipristinati, @FittoniNuo" & _
    "vi, @FittoniEliminati, @FittoniRipristinati, @FormaggioniNuovi, @FormaggioniElim" & _
    "inati, @FormaggioniRipristinati, @PaliExNovo, @CartelliExNovo, @StalliOExNovo, @" & _
    "StalliRRExNovo, @ResidentiExNovo, @StalliMotoExNovo, @FittoniExNovo, @Formaggion" & _
    "iExNovo, @CarsharingNuovi, @CarsharingEliminati, @CarsharingRipristinati, @Carsh" & _
    "aringExNovo, @DisabiliNuovi, @DisabiliEliminati, @DisabiliRipristinati, @Disabil" & _
    "iExNovo, @GenericiNuovi, @GenericiEliminati, @GenericiRipristinati, @GenericiExN" & _
    "ovo, @DiscoOrarioNuovi, @DiscoOrarioEliminati, @DiscoOrarioRipristinati, @DiscoO" & _
    "rarioExNovo, @CaricoScaricoNuovi, @CaricoScaricoEliminati, @CaricoScaricoRiprist" & _
    "inati, @CaricoScaricoExNovo)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVia", System.Data.SqlDbType.Int, 4, "IdVia"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.VarChar, 20, "IdZona"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Titolo", System.Data.SqlDbType.VarChar, 100, "Titolo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinanza", System.Data.SqlDbType.VarChar, 50, "Ordinanza"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Testo", System.Data.SqlDbType.VarChar, 1000, "Testo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@File", System.Data.SqlDbType.UniqueIdentifier, 16, "File"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ext", System.Data.SqlDbType.VarChar, 10, "Ext"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataInizio", System.Data.SqlDbType.DateTime, 8, "DataInizio"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataFine", System.Data.SqlDbType.DateTime, 8, "DataFine"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 4, "IdTipo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCausale", System.Data.SqlDbType.Int, 4, "IdCausale"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdEsecutore", System.Data.SqlDbType.Int, 4, "IdEsecutore"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliNuovi", System.Data.SqlDbType.Int, 4, "PaliNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliEliminati", System.Data.SqlDbType.Int, 4, "PaliEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliRipristinati", System.Data.SqlDbType.Int, 4, "PaliRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliNuovi", System.Data.SqlDbType.Int, 4, "CartelliNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliEliminati", System.Data.SqlDbType.Int, 4, "CartelliEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliRipristinati", System.Data.SqlDbType.Int, 4, "CartelliRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliONuovi", System.Data.SqlDbType.Int, 4, "StalliONuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliOEliminati", System.Data.SqlDbType.Int, 4, "StalliOEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliORipristinati", System.Data.SqlDbType.Int, 4, "StalliORipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRNuovi", System.Data.SqlDbType.Int, 4, "StalliRRNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRREliminati", System.Data.SqlDbType.Int, 4, "StalliRREliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRRipristinati", System.Data.SqlDbType.Int, 4, "StalliRRRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiNuovi", System.Data.SqlDbType.Int, 4, "ResidentiNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiEliminati", System.Data.SqlDbType.Int, 4, "ResidentiEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiRipristinati", System.Data.SqlDbType.Int, 4, "ResidentiRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoNuovi", System.Data.SqlDbType.Int, 4, "StalliMotoNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoEliminati", System.Data.SqlDbType.Int, 4, "StalliMotoEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoRipristinati", System.Data.SqlDbType.Int, 4, "StalliMotoRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniNuovi", System.Data.SqlDbType.Int, 4, "FittoniNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniEliminati", System.Data.SqlDbType.Int, 4, "FittoniEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniRipristinati", System.Data.SqlDbType.Int, 4, "FittoniRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniNuovi", System.Data.SqlDbType.Int, 4, "FormaggioniNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniEliminati", System.Data.SqlDbType.Int, 4, "FormaggioniEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniRipristinati", System.Data.SqlDbType.Int, 4, "FormaggioniRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliExNovo", System.Data.SqlDbType.Int, 4, "PaliExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliExNovo", System.Data.SqlDbType.Int, 4, "CartelliExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliOExNovo", System.Data.SqlDbType.Int, 4, "StalliOExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRExNovo", System.Data.SqlDbType.Int, 4, "StalliRRExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiExNovo", System.Data.SqlDbType.Int, 4, "ResidentiExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoExNovo", System.Data.SqlDbType.Int, 4, "StalliMotoExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniExNovo", System.Data.SqlDbType.Int, 4, "FittoniExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniExNovo", System.Data.SqlDbType.Int, 4, "FormaggioniExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingNuovi", System.Data.SqlDbType.Int, 4, "CarsharingNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingEliminati", System.Data.SqlDbType.Int, 4, "CarsharingEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingRipristinati", System.Data.SqlDbType.Int, 4, "CarsharingRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingExNovo", System.Data.SqlDbType.Int, 4, "CarsharingExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliNuovi", System.Data.SqlDbType.Int, 4, "DisabiliNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliEliminati", System.Data.SqlDbType.Int, 4, "DisabiliEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliRipristinati", System.Data.SqlDbType.Int, 4, "DisabiliRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliExNovo", System.Data.SqlDbType.Int, 4, "DisabiliExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiNuovi", System.Data.SqlDbType.Int, 4, "GenericiNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiEliminati", System.Data.SqlDbType.Int, 4, "GenericiEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiRipristinati", System.Data.SqlDbType.Int, 4, "GenericiRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiExNovo", System.Data.SqlDbType.Int, 4, "GenericiExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioNuovi", System.Data.SqlDbType.Int, 4, "DiscoOrarioNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioEliminati", System.Data.SqlDbType.Int, 4, "DiscoOrarioEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioRipristinati", System.Data.SqlDbType.Int, 4, "DiscoOrarioRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioExNovo", System.Data.SqlDbType.Int, 4, "DiscoOrarioExNovo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoNuovi", System.Data.SqlDbType.Int, 4, "CaricoScaricoNuovi"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoEliminati", System.Data.SqlDbType.Int, 4, "CaricoScaricoEliminati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoRipristinati", System.Data.SqlDbType.Int, 4, "CaricoScaricoRipristinati"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoExNovo", System.Data.SqlDbType.Int, 4, "CaricoScaricoExNovo"))
    '
    'SqlSelectCommand6
    '
    Me.SqlSelectCommand6.CommandText = "SELECT dbo.StradarioBologna.Nome, dbo.LavoriStradaliTipi.Tipo, dbo.LavoriStradali" & _
    "Causali.Causale, dbo.LavoriStradaliEsecutori.Esecutore, dbo.LavoriStradaliZone.Z" & _
    "ona, dbo.LavoriStradali.Id, dbo.LavoriStradali.IdZona, dbo.LavoriStradali.Titolo" & _
    ", dbo.LavoriStradali.Testo, dbo.LavoriStradali.[File], dbo.LavoriStradali.Ext, d" & _
    "bo.LavoriStradali.DataInizio, dbo.LavoriStradali.DataFine, dbo.LavoriStradali.Id" & _
    "Tipo, dbo.LavoriStradali.IdCausale, dbo.LavoriStradali.IdEsecutore, dbo.Stradari" & _
    "oBologna.Codice AS IdVia, dbo.LavoriStradali.Ordinanza, dbo.LavoriStradali.PaliN" & _
    "uovi, dbo.LavoriStradali.PaliEliminati, dbo.LavoriStradali.PaliRipristinati, dbo" & _
    ".LavoriStradali.CartelliNuovi, dbo.LavoriStradali.CartelliEliminati, dbo.LavoriS" & _
    "tradali.CartelliRipristinati, dbo.LavoriStradali.StalliONuovi, dbo.LavoriStradal" & _
    "i.StalliOEliminati, dbo.LavoriStradali.StalliORipristinati, dbo.LavoriStradali.S" & _
    "talliRRNuovi, dbo.LavoriStradali.StalliRREliminati, dbo.LavoriStradali.StalliRRR" & _
    "ipristinati, dbo.LavoriStradali.ResidentiNuovi, dbo.LavoriStradali.ResidentiElim" & _
    "inati, dbo.LavoriStradali.ResidentiRipristinati, dbo.LavoriStradali.StalliMotoNu" & _
    "ovi, dbo.LavoriStradali.StalliMotoEliminati, dbo.LavoriStradali.StalliMotoRipris" & _
    "tinati, dbo.LavoriStradali.FittoniNuovi, dbo.LavoriStradali.FittoniEliminati, db" & _
    "o.LavoriStradali.FittoniRipristinati, dbo.LavoriStradali.FormaggioniNuovi, dbo.L" & _
    "avoriStradali.FormaggioniEliminati, dbo.LavoriStradali.FormaggioniRipristinati, " & _
    "dbo.LavoriStradali.PaliExNovo, dbo.LavoriStradali.CartelliExNovo, dbo.LavoriStra" & _
    "dali.StalliOExNovo, dbo.LavoriStradali.StalliRRExNovo, dbo.LavoriStradali.Reside" & _
    "ntiExNovo, dbo.LavoriStradali.StalliMotoExNovo, dbo.LavoriStradali.FittoniExNovo" & _
    ", dbo.LavoriStradali.FormaggioniExNovo, dbo.LavoriStradali.CarsharingNuovi, dbo." & _
    "LavoriStradali.CarsharingEliminati, dbo.LavoriStradali.CarsharingRipristinati, d" & _
    "bo.LavoriStradali.CarsharingExNovo, dbo.LavoriStradali.DisabiliNuovi, dbo.Lavori" & _
    "Stradali.DisabiliEliminati, dbo.LavoriStradali.DisabiliRipristinati, dbo.LavoriS" & _
    "tradali.DisabiliExNovo, dbo.LavoriStradali.GenericiNuovi, dbo.LavoriStradali.Gen" & _
    "ericiEliminati, dbo.LavoriStradali.GenericiRipristinati, dbo.LavoriStradali.Gene" & _
    "riciExNovo, dbo.LavoriStradali.DiscoOrarioNuovi, dbo.LavoriStradali.DiscoOrarioE" & _
    "liminati, dbo.LavoriStradali.DiscoOrarioRipristinati, dbo.LavoriStradali.DiscoOr" & _
    "arioExNovo, dbo.LavoriStradali.CaricoScaricoNuovi, dbo.LavoriStradali.CaricoScar" & _
    "icoEliminati, dbo.LavoriStradali.CaricoScaricoRipristinati, dbo.LavoriStradali.C" & _
    "aricoScaricoExNovo FROM dbo.LavoriStradali LEFT OUTER JOIN dbo.LavoriStradaliZon" & _
    "e ON dbo.LavoriStradali.IdZona = dbo.LavoriStradaliZone.IdZona LEFT OUTER JOIN d" & _
    "bo.LavoriStradaliEsecutori ON dbo.LavoriStradali.IdEsecutore = dbo.LavoriStradal" & _
    "iEsecutori.IdEsecutore LEFT OUTER JOIN dbo.LavoriStradaliCausali ON dbo.LavoriSt" & _
    "radali.IdCausale = dbo.LavoriStradaliCausali.IdCausale LEFT OUTER JOIN dbo.Lavor" & _
    "iStradaliTipi ON dbo.LavoriStradali.IdTipo = dbo.LavoriStradaliTipi.IdTipo RIGHT" & _
    " OUTER JOIN dbo.StradarioBologna ON dbo.LavoriStradali.IdVia = dbo.StradarioBolo" & _
    "gna.Codice AND dbo.StradarioBologna.cod_prov = 37 AND dbo.StradarioBologna.cod_c" & _
    "omune = 6 AND dbo.LavoriStradali.DataCancellazione IS NULL"
    Me.SqlSelectCommand6.Connection = Me.con
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.LavoriStradali SET IdVia = @IdVia, IdZona = @IdZona, Titolo = @Titolo," & _
    " Ordinanza = @Ordinanza, Testo = @Testo, [File] = @Param2, Ext = @Ext, DataInizi" & _
    "o = @DataInizio, DataFine = @DataFine, IdTipo = @IdTipo, IdCausale = @IdCausale," & _
    " IdEsecutore = @IdEsecutore, PaliNuovi = @PaliNuovi, PaliEliminati = @PaliElimin" & _
    "ati, PaliRipristinati = @PaliRipristinati, CartelliNuovi = @CartelliNuovi, Carte" & _
    "lliEliminati = @CartelliEliminati, CartelliRipristinati = @CartelliRipristinati," & _
    " StalliONuovi = @StalliONuovi, StalliOEliminati = @StalliOEliminati, StalliORipr" & _
    "istinati = @StalliORipristinati, StalliRRNuovi = @StalliRRNuovi, StalliRRElimina" & _
    "ti = @StalliRREliminati, StalliRRRipristinati = @StalliRRRipristinati, Residenti" & _
    "Nuovi = @ResidentiNuovi, ResidentiEliminati = @ResidentiEliminati, ResidentiRipr" & _
    "istinati = @ResidentiRipristinati, StalliMotoNuovi = @StalliMotoNuovi, StalliMot" & _
    "oEliminati = @StalliMotoEliminati, StalliMotoRipristinati = @StalliMotoRipristin" & _
    "ati, FittoniNuovi = @FittoniNuovi, FittoniEliminati = @FittoniEliminati, Fittoni" & _
    "Ripristinati = @FittoniRipristinati, FormaggioniNuovi = @FormaggioniNuovi, Forma" & _
    "ggioniEliminati = @FormaggioniEliminati, FormaggioniRipristinati = @FormaggioniR" & _
    "ipristinati, PaliExNovo = @PaliExNovo, CartelliExNovo = @CartelliExNovo, StalliO" & _
    "ExNovo = @StalliOExNovo, StalliRRExNovo = @StalliRRExNovo, ResidentiExNovo = @Re" & _
    "sidentiExNovo, StalliMotoExNovo = @StalliMotoExNovo, FittoniExNovo = @FittoniExN" & _
    "ovo, FormaggioniExNovo = @FormaggioniExNovo, CarsharingNuovi = @CarsharingNuovi," & _
    " CarsharingEliminati = @CarsharingEliminati, CarsharingRipristinati = @Carsharin" & _
    "gRipristinati, CarsharingExNovo = @CarsharingExNovo, DisabiliNuovi = @DisabiliNu" & _
    "ovi, DisabiliEliminati = @DisabiliEliminati, DisabiliRipristinati = @DisabiliRip" & _
    "ristinati, DisabiliExNovo = @DisabiliExNovo, GenericiNuovi = @GenericiNuovi, Gen" & _
    "ericiEliminati = @GenericiEliminati, GenericiRipristinati = @GenericiRipristinat" & _
    "i, GenericiExNovo = @GenericiExNovo, DiscoOrarioNuovi = @DiscoOrarioNuovi, Disco" & _
    "OrarioEliminati = @DiscoOrarioEliminati, DiscoOrarioRipristinati = @DiscoOrarioR" & _
    "ipristinati, DiscoOrarioExNovo = @DiscoOrarioExNovo, CaricoScaricoNuovi = @Caric" & _
    "oScaricoNuovi, CaricoScaricoEliminati = @CaricoScaricoEliminati, CaricoScaricoRi" & _
    "pristinati = @CaricoScaricoRipristinati, CaricoScaricoExNovo = @CaricoScaricoExN" & _
    "ovo WHERE (Id = @Original_Id) AND (CartelliEliminati = @Original_CartelliElimina" & _
    "ti OR @Original_CartelliEliminati IS NULL AND CartelliEliminati IS NULL) AND (Ca" & _
    "rtelliNuovi = @Original_CartelliNuovi OR @Original_CartelliNuovi IS NULL AND Car" & _
    "telliNuovi IS NULL) AND (CartelliRipristinati = @Original_CartelliRipristinati O" & _
    "R @Original_CartelliRipristinati IS NULL AND CartelliRipristinati IS NULL) AND (" & _
    "DataFine = @Original_DataFine OR @Original_DataFine IS NULL AND DataFine IS NULL" & _
    ") AND (DataInizio = @Original_DataInizio OR @Original_DataInizio IS NULL AND Dat" & _
    "aInizio IS NULL) AND (Ext = @Original_Ext OR @Original_Ext IS NULL AND Ext IS NU" & _
    "LL) AND ([File] = @Original_File OR @Original_File IS NULL AND [File] IS NULL) A" & _
    "ND (FittoniEliminati = @Original_FittoniEliminati OR @Original_FittoniEliminati " & _
    "IS NULL AND FittoniEliminati IS NULL) AND (FittoniNuovi = @Original_FittoniNuovi" & _
    " OR @Original_FittoniNuovi IS NULL AND FittoniNuovi IS NULL) AND (FittoniRiprist" & _
    "inati = @Original_FittoniRipristinati OR @Original_FittoniRipristinati IS NULL A" & _
    "ND FittoniRipristinati IS NULL) AND (FormaggioniEliminati = @Original_Formaggion" & _
    "iEliminati OR @Original_FormaggioniEliminati IS NULL AND FormaggioniEliminati IS" & _
    " NULL) AND (FormaggioniNuovi = @Original_FormaggioniNuovi OR @Original_Formaggio" & _
    "niNuovi IS NULL AND FormaggioniNuovi IS NULL) AND (FormaggioniRipristinati = @Or" & _
    "iginal_FormaggioniRipristinati OR @Original_FormaggioniRipristinati IS NULL AND " & _
    "FormaggioniRipristinati IS NULL) AND (IdCausale = @Original_IdCausale OR @Origin" & _
    "al_IdCausale IS NULL AND IdCausale IS NULL) AND (IdEsecutore = @Original_IdEsecu" & _
    "tore OR @Original_IdEsecutore IS NULL AND IdEsecutore IS NULL) AND (IdTipo = @Or" & _
    "iginal_IdTipo OR @Original_IdTipo IS NULL AND IdTipo IS NULL) AND (IdVia = @Orig" & _
    "inal_IdVia OR @Original_IdVia IS NULL AND IdVia IS NULL) AND (IdZona = @Original" & _
    "_IdZona OR @Original_IdZona IS NULL AND IdZona IS NULL) AND (Ordinanza = @Origin" & _
    "al_Ordinanza OR @Original_Ordinanza IS NULL AND Ordinanza IS NULL) AND (PaliElim" & _
    "inati = @Original_PaliEliminati OR @Original_PaliEliminati IS NULL AND PaliElimi" & _
    "nati IS NULL) AND (PaliNuovi = @Original_PaliNuovi OR @Original_PaliNuovi IS NUL" & _
    "L AND PaliNuovi IS NULL) AND (PaliRipristinati = @Original_PaliRipristinati OR @" & _
    "Original_PaliRipristinati IS NULL AND PaliRipristinati IS NULL) AND (ResidentiEl" & _
    "iminati = @Original_ResidentiEliminati OR @Original_ResidentiEliminati IS NULL A" & _
    "ND ResidentiEliminati IS NULL) AND (ResidentiNuovi = @Original_ResidentiNuovi OR" & _
    " @Original_ResidentiNuovi IS NULL AND ResidentiNuovi IS NULL) AND (ResidentiRipr" & _
    "istinati = @Original_ResidentiRipristinati OR @Original_ResidentiRipristinati IS" & _
    " NULL AND ResidentiRipristinati IS NULL) AND (StalliMotoEliminati = @Original_St" & _
    "alliMotoEliminati OR @Original_StalliMotoEliminati IS NULL AND StalliMotoElimina" & _
    "ti IS NULL) AND (StalliMotoNuovi = @Original_StalliMotoNuovi OR @Original_Stalli" & _
    "MotoNuovi IS NULL AND StalliMotoNuovi IS NULL) AND (StalliMotoRipristinati = @Or" & _
    "iginal_StalliMotoRipristinati OR @Original_StalliMotoRipristinati IS NULL AND St" & _
    "alliMotoRipristinati IS NULL) AND (StalliOEliminati = @Original_StalliOEliminati" & _
    " OR @Original_StalliOEliminati IS NULL AND StalliOEliminati IS NULL) AND (Stalli" & _
    "ONuovi = @Original_StalliONuovi OR @Original_StalliONuovi IS NULL AND StalliONuo" & _
    "vi IS NULL) AND (StalliORipristinati = @Original_StalliORipristinati OR @Origina" & _
    "l_StalliORipristinati IS NULL AND StalliORipristinati IS NULL) AND (StalliRRElim" & _
    "inati = @Original_StalliRREliminati OR @Original_StalliRREliminati IS NULL AND S" & _
    "talliRREliminati IS NULL) AND (StalliRRNuovi = @Original_StalliRRNuovi OR @Origi" & _
    "nal_StalliRRNuovi IS NULL AND StalliRRNuovi IS NULL) AND (StalliRRRipristinati =" & _
    " @Original_StalliRRRipristinati OR @Original_StalliRRRipristinati IS NULL AND St" & _
    "alliRRRipristinati IS NULL) AND (Testo = @Original_Testo OR @Original_Testo IS N" & _
    "ULL AND Testo IS NULL) AND (Titolo = @Original_Titolo OR @Original_Titolo IS NUL" & _
    "L AND Titolo IS NULL) AND (PaliExNovo = @Original_PaliExNovo OR @Original_PaliEx" & _
    "Novo IS NULL AND PaliExNovo IS NULL) AND (CartelliExNovo = @Original_CartelliExN" & _
    "ovo OR @Original_CartelliExNovo IS NULL AND CartelliExNovo IS NULL) AND (StalliO" & _
    "ExNovo = @Original_StalliOExNovo OR @Original_StalliOExNovo IS NULL AND StalliOE" & _
    "xNovo IS NULL) AND (StalliRRExNovo = @Original_StalliRRExNovo OR @Original_Stall" & _
    "iRRExNovo IS NULL AND StalliRRExNovo IS NULL) AND (ResidentiExNovo = @Original_R" & _
    "esidentiExNovo OR @Original_ResidentiExNovo IS NULL AND ResidentiExNovo IS NULL)" & _
    " AND (StalliMotoExNovo = @Original_StalliMotoExNovo OR @Original_StalliMotoExNov" & _
    "o IS NULL AND StalliMotoExNovo IS NULL) AND (FittoniExNovo = @Original_FittoniEx" & _
    "Novo OR @Original_FittoniExNovo IS NULL AND FittoniExNovo IS NULL) AND (Formaggi" & _
    "oniExNovo = @Original_FormaggioniExNovo OR @Original_FormaggioniExNovo IS NULL A" & _
    "ND FormaggioniExNovo IS NULL) AND (CarsharingNuovi = @Original_CarsharingNuovi O" & _
    "R @Original_CarsharingNuovi IS NULL AND CarsharingNuovi IS NULL) AND (Carsharing" & _
    "Eliminati = @Original_CarsharingEliminati OR @Original_CarsharingEliminati IS NU" & _
    "LL AND CarsharingEliminati IS NULL) AND (CarsharingRipristinati = @Original_Cars" & _
    "haringRipristinati OR @Original_CarsharingRipristinati IS NULL AND CarsharingRip" & _
    "ristinati IS NULL) AND (CarsharingExNovo = @Original_CarsharingExNovo OR @Origin" & _
    "al_CarsharingExNovo IS NULL AND CarsharingExNovo IS NULL) AND (DisabiliNuovi = @" & _
    "Original_DisabiliNuovi OR @Original_DisabiliNuovi IS NULL AND DisabiliNuovi IS N" & _
    "ULL) AND (DisabiliEliminati = @Original_DisabiliEliminati OR @Original_DisabiliE" & _
    "liminati IS NULL AND DisabiliEliminati IS NULL) AND (DisabiliRipristinati = @Ori" & _
    "ginal_DisabiliRipristinati OR @Original_DisabiliRipristinati IS NULL AND Disabil" & _
    "iRipristinati IS NULL) AND (DisabiliExNovo = @Original_DisabiliExNovo OR @Origin" & _
    "al_DisabiliExNovo IS NULL AND DisabiliExNovo IS NULL) AND (GenericiNuovi = @Orig" & _
    "inal_GenericiNuovi OR @Original_GenericiNuovi IS NULL AND GenericiNuovi IS NULL)" & _
    " AND (GenericiEliminati = @Original_GenericiEliminati OR @Original_GenericiElimi" & _
    "nati IS NULL AND GenericiEliminati IS NULL) AND (GenericiRipristinati = @Origina" & _
    "l_GenericiRipristinati OR @Original_GenericiRipristinati IS NULL AND GenericiRip" & _
    "ristinati IS NULL) AND (GenericiExNovo = @Original_GenericiExNovo OR @Original_G" & _
    "enericiExNovo IS NULL AND GenericiExNovo IS NULL) AND (DiscoOrarioNuovi = @Origi" & _
    "nal_DiscoOrarioNuovi OR @Original_DiscoOrarioNuovi IS NULL AND DiscoOrarioNuovi " & _
    "IS NULL) AND (DiscoOrarioEliminati = @Original_DiscoOrarioEliminati OR @Original" & _
    "_DiscoOrarioEliminati IS NULL AND DiscoOrarioEliminati IS NULL) AND (DiscoOrario" & _
    "Ripristinati = @Original_DiscoOrarioRipristinati OR @Original_DiscoOrarioRiprist" & _
    "inati IS NULL AND DiscoOrarioRipristinati IS NULL) AND (DiscoOrarioExNovo = @Ori" & _
    "ginal_DiscoOrarioExNovo OR @Original_DiscoOrarioExNovo IS NULL AND DiscoOrarioEx" & _
    "Novo IS NULL) AND (CaricoScaricoNuovi = @Original_CaricoScaricoNuovi OR @Origina" & _
    "l_CaricoScaricoNuovi IS NULL AND CaricoScaricoNuovi IS NULL) AND (CaricoScaricoE" & _
    "liminati = @Original_CaricoScaricoEliminati OR @Original_CaricoScaricoEliminati " & _
    "IS NULL AND CaricoScaricoEliminati IS NULL) AND (CaricoScaricoRipristinati = @Or" & _
    "iginal_CaricoScaricoRipristinati OR @Original_CaricoScaricoRipristinati IS NULL " & _
    "AND CaricoScaricoRipristinati IS NULL) AND (CaricoScaricoExNovo = @Original_Cari" & _
    "coScaricoExNovo OR @Original_CaricoScaricoExNovo IS NULL AND CaricoScaricoExNovo" & _
    " IS NULL)"
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVia", System.Data.SqlDbType.Int, 4, "IdVia"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.VarChar, 20, "IdZona"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Titolo", System.Data.SqlDbType.VarChar, 100, "Titolo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinanza", System.Data.SqlDbType.VarChar, 50, "Ordinanza"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Testo", System.Data.SqlDbType.VarChar, 1000, "Testo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Param2", System.Data.SqlDbType.UniqueIdentifier, 16, "File"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ext", System.Data.SqlDbType.VarChar, 10, "Ext"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataInizio", System.Data.SqlDbType.DateTime, 8, "DataInizio"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataFine", System.Data.SqlDbType.DateTime, 8, "DataFine"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 4, "IdTipo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCausale", System.Data.SqlDbType.Int, 4, "IdCausale"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdEsecutore", System.Data.SqlDbType.Int, 4, "IdEsecutore"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliNuovi", System.Data.SqlDbType.Int, 4, "PaliNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliEliminati", System.Data.SqlDbType.Int, 4, "PaliEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliRipristinati", System.Data.SqlDbType.Int, 4, "PaliRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliNuovi", System.Data.SqlDbType.Int, 4, "CartelliNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliEliminati", System.Data.SqlDbType.Int, 4, "CartelliEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliRipristinati", System.Data.SqlDbType.Int, 4, "CartelliRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliONuovi", System.Data.SqlDbType.Int, 4, "StalliONuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliOEliminati", System.Data.SqlDbType.Int, 4, "StalliOEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliORipristinati", System.Data.SqlDbType.Int, 4, "StalliORipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRNuovi", System.Data.SqlDbType.Int, 4, "StalliRRNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRREliminati", System.Data.SqlDbType.Int, 4, "StalliRREliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRRipristinati", System.Data.SqlDbType.Int, 4, "StalliRRRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiNuovi", System.Data.SqlDbType.Int, 4, "ResidentiNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiEliminati", System.Data.SqlDbType.Int, 4, "ResidentiEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiRipristinati", System.Data.SqlDbType.Int, 4, "ResidentiRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoNuovi", System.Data.SqlDbType.Int, 4, "StalliMotoNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoEliminati", System.Data.SqlDbType.Int, 4, "StalliMotoEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoRipristinati", System.Data.SqlDbType.Int, 4, "StalliMotoRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniNuovi", System.Data.SqlDbType.Int, 4, "FittoniNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniEliminati", System.Data.SqlDbType.Int, 4, "FittoniEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniRipristinati", System.Data.SqlDbType.Int, 4, "FittoniRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniNuovi", System.Data.SqlDbType.Int, 4, "FormaggioniNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniEliminati", System.Data.SqlDbType.Int, 4, "FormaggioniEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniRipristinati", System.Data.SqlDbType.Int, 4, "FormaggioniRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PaliExNovo", System.Data.SqlDbType.Int, 4, "PaliExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CartelliExNovo", System.Data.SqlDbType.Int, 4, "CartelliExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliOExNovo", System.Data.SqlDbType.Int, 4, "StalliOExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliRRExNovo", System.Data.SqlDbType.Int, 4, "StalliRRExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResidentiExNovo", System.Data.SqlDbType.Int, 4, "ResidentiExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StalliMotoExNovo", System.Data.SqlDbType.Int, 4, "StalliMotoExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FittoniExNovo", System.Data.SqlDbType.Int, 4, "FittoniExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaggioniExNovo", System.Data.SqlDbType.Int, 4, "FormaggioniExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingNuovi", System.Data.SqlDbType.Int, 4, "CarsharingNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingEliminati", System.Data.SqlDbType.Int, 4, "CarsharingEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingRipristinati", System.Data.SqlDbType.Int, 4, "CarsharingRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CarsharingExNovo", System.Data.SqlDbType.Int, 4, "CarsharingExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliNuovi", System.Data.SqlDbType.Int, 4, "DisabiliNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliEliminati", System.Data.SqlDbType.Int, 4, "DisabiliEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliRipristinati", System.Data.SqlDbType.Int, 4, "DisabiliRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DisabiliExNovo", System.Data.SqlDbType.Int, 4, "DisabiliExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiNuovi", System.Data.SqlDbType.Int, 4, "GenericiNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiEliminati", System.Data.SqlDbType.Int, 4, "GenericiEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiRipristinati", System.Data.SqlDbType.Int, 4, "GenericiRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GenericiExNovo", System.Data.SqlDbType.Int, 4, "GenericiExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioNuovi", System.Data.SqlDbType.Int, 4, "DiscoOrarioNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioEliminati", System.Data.SqlDbType.Int, 4, "DiscoOrarioEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioRipristinati", System.Data.SqlDbType.Int, 4, "DiscoOrarioRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiscoOrarioExNovo", System.Data.SqlDbType.Int, 4, "DiscoOrarioExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoNuovi", System.Data.SqlDbType.Int, 4, "CaricoScaricoNuovi"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoEliminati", System.Data.SqlDbType.Int, 4, "CaricoScaricoEliminati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoRipristinati", System.Data.SqlDbType.Int, 4, "CaricoScaricoRipristinati"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CaricoScaricoExNovo", System.Data.SqlDbType.Int, 4, "CaricoScaricoExNovo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataFine", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataFine", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataInizio", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataInizio", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ext", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ext", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_File", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "File", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCausale", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCausale", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdEsecutore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdEsecutore", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdVia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdZona", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinanza", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinanza", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliOEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliOEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliONuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliONuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliORipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliORipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRREliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRREliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Testo", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Testo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Titolo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Titolo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PaliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PaliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CartelliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CartelliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliOExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliOExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliRRExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliRRExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResidentiExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResidentiExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_StalliMotoExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StalliMotoExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FittoniExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FittoniExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaggioniExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaggioniExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CarsharingExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CarsharingExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DisabiliExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DisabiliExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GenericiExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GenericiExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiscoOrarioExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiscoOrarioExNovo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoNuovi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoNuovi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoEliminati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoEliminati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoRipristinati", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoRipristinati", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CaricoScaricoExNovo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CaricoScaricoExNovo", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsValori
    '
    Me.DsValori.DataSetName = "dsValori"
    Me.DsValori.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsValori, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
  Protected WithEvents pnlSearch As System.Web.UI.WebControls.Panel
  Protected WithEvents lblVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents cboZona As System.Web.UI.WebControls.DropDownList
  Protected WithEvents cboEsecutore As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblCausale As System.Web.UI.WebControls.Label
  Protected WithEvents cboTipo As System.Web.UI.WebControls.DropDownList
  Protected WithEvents cboCausale As System.Web.UI.WebControls.DropDownList
  Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RangeValidator2 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daEsecutori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daTipi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsValori As ATCBussm1.dsValori
  Protected WithEvents daCausali As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daZone As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daToponimi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents daLavori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents dgLavoriStradali As System.Web.UI.WebControls.DataGrid
  Protected WithEvents txtDal As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtAl As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDETitle As System.Web.UI.WebControls.TextBox
  Protected WithEvents cboDETipo As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtDETesto As System.Web.UI.WebControls.TextBox
  Protected WithEvents pnlRisultati As System.Web.UI.WebControls.Panel
  Protected WithEvents pnlModifica As System.Web.UI.WebControls.Panel
  Protected WithEvents cboDEZona As System.Web.UI.WebControls.DropDownList
  Protected WithEvents cboDECausale As System.Web.UI.WebControls.DropDownList
  Protected WithEvents cboDEEsecutore As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblDEVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtDEIdVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEId As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEFile As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEExt As System.Web.UI.WebControls.TextBox
  Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents RangeValidator3 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RangeValidator4 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents txtDEOrdinanza As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEDataInizio As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEDataFine As System.Web.UI.WebControls.TextBox
  Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator5 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents RegularExpressionValidator2 As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents RegularExpressionValidator3 As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents RegularExpressionValidator4 As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblTipo As System.Web.UI.WebControls.Label
  Protected WithEvents LblNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTPaliNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTPaliEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTPaliRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents pnlConteggio As System.Web.UI.WebControls.Panel
  Protected WithEvents LblHPali As System.Web.UI.WebControls.Label
  Protected WithEvents LblHCartelli As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCartelliNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCartelliEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHStalliO As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliONuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliOEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHStalliRR As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliRRNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliRREliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHResidenti As System.Web.UI.WebControls.Label
  Protected WithEvents LblTResidentiNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTResidentiEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHMoto As System.Web.UI.WebControls.Label
  Protected WithEvents LblTMotoNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTMotoEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHFittoni As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFittoniNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFittoniEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblHForma As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFormaNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents Label4 As System.Web.UI.WebControls.Label
  Protected WithEvents Label17 As System.Web.UI.WebControls.Label
  Protected WithEvents Label18 As System.Web.UI.WebControls.Label
  Protected WithEvents Label22 As System.Web.UI.WebControls.Label
  Protected WithEvents Label26 As System.Web.UI.WebControls.Label
  Protected WithEvents Label30 As System.Web.UI.WebControls.Label
  Protected WithEvents Label34 As System.Web.UI.WebControls.Label
  Protected WithEvents Label38 As System.Web.UI.WebControls.Label
  Protected WithEvents Label42 As System.Web.UI.WebControls.Label
  Protected WithEvents Label46 As System.Web.UI.WebControls.Label
  Protected WithEvents TxtPaliNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtPaliEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtPaliRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtCartelliNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliONuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliRRNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtResidentiNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtMotoNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtFittoniNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtCartelliEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliOEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliRREliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtResidentiEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtMotoEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtFittoniEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtCartelliRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliORipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtStalliRRRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtFormaEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtResidentiRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtMotoRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtFittoniRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtFormaRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents RV1 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV2 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents R3 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV4 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV5 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV6 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV7 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV8 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV9 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV10 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV11 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV12 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV13 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV14 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV15 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV16 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV17 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV18 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV19 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV20 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV21 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV22 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV23 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RV24 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents LblTCartelliExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliOExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliRRExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTResidentiExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTMotoExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFittoniExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTPaliExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCartelliRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliORipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTStalliRRRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTResidentiRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTMotoRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFittoniRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents TxtFormaExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtPaliExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator12 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCartelliExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator11 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtStalliOExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator10 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtStalliRRExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator9 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtResidentiExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator8 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtMotoExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator7 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtFittoniExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator6 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtFormaNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator5 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents LabeX As System.Web.UI.WebControls.Label
  Protected WithEvents TxtCarNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator13 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCarEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator14 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCarRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator15 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCarExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator16 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents TxtDisabiliNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator17 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtDisabiliEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator18 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtDisabiliRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator19 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtDisabiliExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator20 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Label5 As System.Web.UI.WebControls.Label
  Protected WithEvents TxtGenNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator21 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtGenEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator22 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtGenRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator23 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtGenExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rangevalidator24 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Label6 As System.Web.UI.WebControls.Label
  Protected WithEvents Rangevalidator25 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Rangevalidator26 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Rangevalidator27 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents Rangevalidator28 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents LblTDiscEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDiscRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDiscExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFormaEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFormaRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTFormaExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblHCarsharing As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCarNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCarEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCarRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCarExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblHDisabili As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDisNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDisEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDisRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDisExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblHGenerici As System.Web.UI.WebControls.Label
  Protected WithEvents LblTGenNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTGenEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTGenRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTGenExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents LblHDiscoOrario As System.Web.UI.WebControls.Label
  Protected WithEvents LblTDiscNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents TxtDiscNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtDiscEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtDiscRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents TxtDiscExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label1c As System.Web.UI.WebControls.Label
  Protected WithEvents Label3d As System.Web.UI.WebControls.Label
  Protected WithEvents Label5g As System.Web.UI.WebControls.Label
  Protected WithEvents Label6d As System.Web.UI.WebControls.Label
  Protected WithEvents LblHCaricoS As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCaricoSNuovi As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCaricoSEliminati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCaricoSRipristinati As System.Web.UI.WebControls.Label
  Protected WithEvents LblTCaricoSExNovo As System.Web.UI.WebControls.Label
  Protected WithEvents TxtCaricoSNuovi As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rv29 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCaricoSEliminati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rv30 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCaricoSRipristinati As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rv31 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents TxtCaricoSExNovo As System.Web.UI.WebControls.TextBox
  Protected WithEvents Rv32 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents LhCaricoScarico As System.Web.UI.WebControls.Label
  Protected WithEvents lblZONA As System.Web.UI.WebControls.Label
  Protected WithEvents LblPeriodo As System.Web.UI.WebControls.Label
  Protected WithEvents LblEsecutore As System.Web.UI.WebControls.Label

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
  Private pUnspecified As String = "[Non specificato]"
  Private Where As String = ""

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' ----------------------------------------------------------------------------
    '     Righe agginte da Paolo Cavazzini
    ' ----------------------------------------------------------------------------
    'Dim intUserID As Integer = atcbSession.Get_UserID(Me.Session)
    'Dim intSectionID As Integer = atcbSession.Get_SectionID(Me.Session)
    'atcbWUser.LoadMenu(intUserID, intSectionID, tblToolbar)
    If Not IsPostBack Then
      ' ----------------------------------------------------------------------------
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      'dgLavoriStradali.Columns(4).Visible = oUtente.CheckAbil(2, 2)
      'dgLavoriStradali.Columns(5).Visible = oUtente.CheckAbil(2, 4)
      'dgLavoriStradali.Columns(6).Visible = oUtente.CheckAbil(2, 3)

      dgLavoriStradali.Columns(4).Visible = True
      dgLavoriStradali.Columns(5).Visible = True
      dgLavoriStradali.Columns(6).Visible = True

      daEsecutori.Fill(DsValori.Tables("LavoriStradaliEsecutori"))
      daTipi.Fill(DsValori.Tables("LavoriStradaliTipi"))
      daCausali.Fill(DsValori.Tables("LavoriStradaliCausali"))
      daZone.Fill(DsValori.Tables("LavoriStradaliZone"))
      cboEsecutore.DataBind()
      cboEsecutore.Items.Insert(0, pUnspecified)
      cboTipo.DataBind()
      cboTipo.Items.Insert(0, pUnspecified)
      cboCausale.DataBind()
      cboCausale.Items.Insert(0, pUnspecified)
      cboZona.DataBind()
      cboZona.Items.Insert(0, pUnspecified)
      cboDEEsecutore.DataBind()
      cboDETipo.DataBind()
      cboDECausale.DataBind()
      cboDEZona.DataBind()


      pShowConteggi()
    End If

  End Sub

  Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    pSearchItem()
  End Sub

  Private Sub btnNewFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    pNewFind()
  End Sub

  Private Sub pNewFind()
    pnlConteggio.Visible = True
    pnlModifica.Visible = False
    pnlRisultati.Visible = True
    pnlSearch.Visible = True
  End Sub

  Private Sub dgLavoriStradali_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgLavoriStradali.ItemCommand
    DsValori.Tables("LavoriStradali").Clear()
    daLavori.Fill(DsValori.Tables("LavoriStradali"))
    Select Case e.CommandName
      Case "Edit"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          DsValori.Tables("LavoriStradali").DefaultView.RowStateFilter = DataViewRowState.None
          pLoadItem(DsValori.Tables("LavoriStradali").Select("Id = " & e.Item.Cells(0).Text))
          pEnableItems(True)
        End If
      Case "Delete"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          pDeleteItem(e.Item.Cells(0).Text)
          pSearchItem()
        End If
      Case "Add"
        pShowInsertPanel()
        lblDEVia.Text = e.Item.Cells(2).Text
        txtDEIdVia.Text = e.Item.Cells(1).Text
        pClearItem()
        pEnableItems(True)
      Case "View"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          DsValori.Tables("LavoriStradali").DefaultView.RowStateFilter = DataViewRowState.None
          pLoadItem(DsValori.Tables("LavoriStradali").Select("Id = " & e.Item.Cells(0).Text))
          pEnableItems(False)
        End If
    End Select
  End Sub

  Private Sub pLoadItem(ByRef dr() As DataRow)

    pShowInsertPanel()
    lblDEVia.Text = dr(0).Item("Nome")
    txtDEId.Text = "" & dr(0).Item("Id")
    txtDEIdVia.Text = "" & dr(0).Item("IdVia")
    txtDETitle.Text = "" & dr(0).Item("Titolo")
    txtDEOrdinanza.Text = "" & dr(0).Item("Ordinanza")
    txtDETesto.Text = "" & dr(0).Item("Testo")
    txtDEDataInizio.Text = "" & dr(0).Item("DataInizio")
    txtDEDataFine.Text = "" & dr(0).Item("DataFine")
    If IsDBNull(dr(0).Item("IdCausale")) Then
      cboDECausale.SelectedItem.Text = pUnspecified
    Else
      cboDECausale.SelectedValue = "" & dr(0).Item("IdCausale")
    End If
    If IsDBNull(dr(0).Item("IdEsecutore")) Then
      cboDEEsecutore.SelectedItem.Text = pUnspecified
    Else
      cboDEEsecutore.SelectedValue = "" & dr(0).Item("IdEsecutore")
    End If
    If IsDBNull(dr(0).Item("IdTipo")) Then
      cboDETipo.SelectedItem.Text = pUnspecified
    Else
      cboDETipo.SelectedValue = "" & dr(0).Item("IdTipo")
    End If
    If IsDBNull(dr(0).Item("IdZona")) Then
      cboDEZona.SelectedItem.Text = pUnspecified
    Else
      cboDEZona.SelectedValue = "" & dr(0).Item("IdZona")
    End If

    ' vecchi campi tabella lavori stradali
    'txtDEVertInstallata.Text = "" & dr(0).Item("VerticaleInstallata")
    'txtDEVertRimossa.Text = "" & dr(0).Item("VerticaleRimossa")
    'txtDEVertSostituita.Text = "" & dr(0).Item("VerticaleSostituita")
    'txtDEStalliAPettine.Text = "" & dr(0).Item("StalliAPettine")
    'txtDEStalliInLinea.Text = "" & dr(0).Item("StalliInLinea")
    'txtDEStalliMoto.Text = "" & dr(0).Item("StalliMoto")
    'txtDEStalliCancAPettine.Text = "" & dr(0).Item("StalliCancAPettine")
    'txtDEStalliCancInLinea.Text = "" & dr(0).Item("StalliCancInLinea")
    'txtDEStalliCancMoto.Text = "" & dr(0).Item("StalliCancMoto")
    'txtDEFormaggioni.Text = "" & dr(0).Item("Formaggioni")
    'txtDEFittoni.Text = "" & dr(0).Item("Fittoni")
    ' fine vecchi campi lavori stradali

    ' nuovi campi della tabella lavori stradali
    TxtPaliNuovi.Text = "" & dr(0).Item("PaliNuovi")
    TxtPaliEliminati.Text = "" & dr(0).Item("PaliEliminati")
    TxtPaliRipristinati.Text = "" & dr(0).Item("PaliRipristinati")
    TxtPaliExNovo.Text = "" & dr(0).Item("PaliExNovo")
    TxtCartelliNuovi.Text = "" & dr(0).Item("CartelliNuovi")
    TxtCartelliEliminati.Text = "" & dr(0).Item("CartelliEliminati")
    TxtCartelliRipristinati.Text = "" & dr(0).Item("CartelliRipristinati")
    TxtCartelliExNovo.Text = "" & dr(0).Item("CartelliExNovo")
    TxtStalliONuovi.Text = "" & dr(0).Item("StalliONuovi")
    TxtStalliOEliminati.Text = "" & dr(0).Item("StalliOEliminati")
    TxtStalliORipristinati.Text = "" & dr(0).Item("StalliORipristinati")
    TxtStalliOExNovo.Text = "" & dr(0).Item("StalliOExNovo")
    TxtStalliRRNuovi.Text = "" & dr(0).Item("StalliRRNuovi")
    TxtStalliRREliminati.Text = "" & dr(0).Item("StalliRREliminati")
    TxtStalliRRRipristinati.Text = "" & dr(0).Item("StalliRRRipristinati")
    TxtStalliRRExNovo.Text = "" & dr(0).Item("StalliRRExNovo")
    TxtResidentiNuovi.Text = "" & dr(0).Item("ResidentiNuovi")
    TxtResidentiEliminati.Text = "" & dr(0).Item("ResidentiEliminati")
    TxtResidentiRipristinati.Text = "" & dr(0).Item("ResidentiRipristinati")
    TxtResidentiExNovo.Text = "" & dr(0).Item("ResidentiExNovo")
    TxtMotoNuovi.Text = "" & dr(0).Item("StalliMotoNuovi")
    TxtMotoEliminati.Text = "" & dr(0).Item("StalliMotoEliminati")
    TxtMotoRipristinati.Text = "" & dr(0).Item("StalliMotoRipristinati")
    TxtMotoExNovo.Text = "" & dr(0).Item("StalliMotoExNovo")
    TxtFittoniNuovi.Text = "" & dr(0).Item("FittoniNuovi")
    TxtFittoniEliminati.Text = "" & dr(0).Item("FittoniEliminati")
    TxtFittoniRipristinati.Text = "" & dr(0).Item("FittoniRipristinati")
    TxtFittoniExNovo.Text = "" & dr(0).Item("FittoniExNovo")
    TxtFormaNuovi.Text = "" & dr(0).Item("FormaggioniNuovi")
    TxtFormaEliminati.Text = "" & dr(0).Item("FormaggioniEliminati")
    TxtFormaRipristinati.Text = "" & dr(0).Item("FormaggioniRipristinati")
    TxtFormaExNovo.Text = "" & dr(0).Item("FormaggioniExNovo")
    TxtCarNuovi.Text = "" & dr(0).Item("CarsharingNuovi")
    TxtCarEliminati.Text = "" & dr(0).Item("CarsharingEliminati")
    TxtCarRipristinati.Text = "" & dr(0).Item("CarsharingRipristinati")
    TxtCarExNovo.Text = "" & dr(0).Item("CarsharingExNovo")
    TxtDisabiliNuovi.Text = "" & dr(0).Item("DisabiliNuovi")
    TxtDisabiliEliminati.Text = "" & dr(0).Item("DisabiliEliminati")
    TxtDisabiliRipristinati.Text = "" & dr(0).Item("DisabiliRipristinati")
    TxtDisabiliExNovo.Text = "" & dr(0).Item("DisabiliExNovo")
    TxtGenNuovi.Text = "" & dr(0).Item("GenericiNuovi")
    TxtGenEliminati.Text = "" & dr(0).Item("GenericiEliminati")
    TxtGenRipristinati.Text = "" & dr(0).Item("GenericiRipristinati")
    TxtGenExNovo.Text = "" & dr(0).Item("GenericiExNovo")
    TxtDiscNuovi.Text = "" & dr(0).Item("DiscoOrarioNuovi")
    TxtDiscEliminati.Text = "" & dr(0).Item("DiscoOrarioEliminati")
    TxtDiscRipristinati.Text = "" & dr(0).Item("DiscoOrarioRipristinati")
    TxtDiscExNovo.Text = "" & dr(0).Item("DiscoOrarioExNovo")

    TxtCaricoSNuovi.Text = "" & dr(0).Item("CaricoScaricoNuovi")
    TxtCaricoSEliminati.Text = "" & dr(0).Item("CaricoScaricoEliminati")
    TxtCaricoSRipristinati.Text = "" & dr(0).Item("CaricoScaricoRipristinati")
    TxtCaricoSExNovo.Text = "" & dr(0).Item("CaricoScaricoExNovo")

    ' fine nuovi campi della tabella lavori stradali


  End Sub

  Private Sub pDeleteItem(ByVal id As Integer)
    DsValori.Tables("LavoriStradali").Select("Id = " & id)(0).Delete()
    daLavori.Update(DsValori.Tables("LavoriStradali"))
    DsValori.Tables("LavoriStradali").Clear()
    daLavori.Fill(DsValori.Tables("LavoriStradali"))
  End Sub

  Private Sub pAddFile(ByVal Path As String, ByVal KillFile As Boolean)
    'If OrdFile.PostedFile.InputStream.Length > 0 Then
    '  If KillFile Then
    '    FileSystem.Kill(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "/files/" & txtDEFile.Text & txtDEExt.Text)
    '  End If
    '  txtDEExt.Text = OrdFile.PostedFile.FileName.Substring(OrdFile.PostedFile.FileName.LastIndexOf(".") + 1)
    '  OrdFile.PostedFile.SaveAs(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & Path)
    '  btnView.NavigateUrl = "files/" & Path
    '  btnView.Enabled = True
    '  btnDelete.Enabled = True
    '  txtDETesto.Visible = False
    'End If
  End Sub

  Public Sub pSearchItem()
    pBuildWhere()
    If Where.Length > 0 And daLavori.SelectCommand.CommandText.IndexOf("WHERE") < 0 Then
      daLavori.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If daLavori.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      daLavori.SelectCommand.CommandText &= " Order By DataInizio Desc, Nome, Zona"
    End If
    DsValori.Tables("LavoriStradali").Clear()
    daLavori.Fill(DsValori.Tables("LavoriStradali"))
    dgLavoriStradali.CurrentPageIndex = 0
    dgLavoriStradali.DataBind()
    pShowConteggi()
    pnlRisultati.Visible = True
    dgLavoriStradali.Visible = DsValori.Tables("LavoriStradali").Rows.Count > 0
    lblMessage.Visible = Not dgLavoriStradali.Visible
  End Sub

  Private Function pSaveItem() As Boolean

    'Dim dr As DataRow
    'DsValori.Tables("LavoriStradali").Rows.Add(dr)
    Dim dr() As DataRow
    DsValori.Tables("LavoriStradali").Clear()
    daLavori.Fill(DsValori.Tables("LavoriStradali"))
    If txtDEId.Text.Length > 0 Then
      'Modifica
      dr = DsValori.Tables("LavoriStradali").Select("Id = " & txtDEId.Text)
    Else
      'Inserimento
      ReDim dr(0)
      dr(0) = DsValori.Tables("LavoriStradali").NewRow()
      dr(0).Item("IdVia") = txtDEIdVia.Text
    End If
    dr(0).Item("Titolo") = txtDETitle.Text
    If txtDEOrdinanza.Text.Length > 0 Then
      dr(0).Item("Ordinanza") = txtDEOrdinanza.Text
    Else
      dr(0).Item("Ordinanza") = DBNull.Value
    End If
    If cboDEZona.SelectedItem.Text = pUnspecified Then
      dr(0).Item("IdZona") = DBNull.Value
    Else
      dr(0).Item("IdZona") = cboDEZona.SelectedValue
    End If
    If cboDETipo.SelectedItem.Text = pUnspecified Then
      dr(0).Item("IdTipo") = DBNull.Value
    Else
      dr(0).Item("IdTipo") = cboDETipo.SelectedValue
    End If
    If cboDECausale.SelectedItem.Text = pUnspecified Then
      dr(0).Item("IdCausale") = DBNull.Value
    Else
      dr(0).Item("IdCausale") = cboDECausale.SelectedValue
    End If
    If cboDEEsecutore.SelectedItem.Text = pUnspecified Then
      dr(0).Item("IdEsecutore") = DBNull.Value
    Else
      dr(0).Item("IdEsecutore") = cboDEEsecutore.SelectedValue
    End If
    dr(0).Item("Testo") = txtDETesto.Text
    If txtDEDataInizio.Text.Length > 0 Then
      dr(0).Item("DataInizio") = txtDEDataInizio.Text
    Else
      dr(0).Item("DataInizio") = DBNull.Value
    End If
    If txtDEDataFine.Text.Length > 0 Then
      dr(0).Item("DataFine") = txtDEDataFine.Text
    Else
      dr(0).Item("DataFine") = DBNull.Value
    End If

    'vecchi campi della tabella lavori stradali
    'dr(0).Item("VerticaleInstallata") = CInt("0" & txtDEVertInstallata.Text)
    'dr(0).Item("VerticaleRimossa") = CInt("0" & txtDEVertRimossa.Text)
    'dr(0).Item("VerticaleSostituita") = CInt("0" & txtDEVertSostituita.Text)
    'dr(0).Item("StalliInLinea") = CInt("0" & txtDEStalliInLinea.Text)
    'dr(0).Item("StalliAPettine") = CInt("0" & txtDEStalliAPettine.Text)
    'dr(0).Item("StalliMoto") = CInt("0" & txtDEStalliMoto.Text)
    'dr(0).Item("StalliCancInLinea") = CInt("0" & txtDEStalliCancInLinea.Text)
    'dr(0).Item("StalliCancAPettine") = CInt("0" & txtDEStalliCancAPettine.Text)
    'dr(0).Item("StalliCancMoto") = CInt("0" & txtDEStalliCancMoto.Text)
    'dr(0).Item("Formaggioni") = CInt("0" & txtDEFormaggioni.Text)
    'dr(0).Item("Fittoni") = CInt("0" & txtDEFittoni.Text)
    'fine vecchi campi della tabella lavori stradali

    ' nuovi campi della lavori stradali
    dr(0).Item("PaliNuovi") = CInt("0" & TxtPaliNuovi.Text)
    dr(0).Item("PaliEliminati") = CInt("0" & TxtPaliEliminati.Text)
    dr(0).Item("PaliRipristinati") = CInt("0" & TxtPaliRipristinati.Text)
    dr(0).Item("PaliExNovo") = CInt("0" & TxtPaliExNovo.Text)
    dr(0).Item("CartelliNuovi") = CInt("0" & TxtCartelliNuovi.Text)
    dr(0).Item("CartelliEliminati") = CInt("0" & TxtCartelliEliminati.Text)
    dr(0).Item("CartelliRipristinati") = CInt("0" & TxtCartelliRipristinati.Text)
    dr(0).Item("CartelliExNovo") = CInt("0" & TxtCartelliExNovo.Text)
    dr(0).Item("StalliONuovi") = CInt("0" & TxtStalliONuovi.Text)
    dr(0).Item("StalliOEliminati") = CInt("0" & TxtStalliOEliminati.Text)
    dr(0).Item("StalliORipristinati") = CInt("0" & TxtStalliORipristinati.Text)
    dr(0).Item("StalliOExNovo") = CInt("0" & TxtStalliOExNovo.Text)
    dr(0).Item("StalliRRNuovi") = CInt("0" & TxtStalliRRNuovi.Text)
    dr(0).Item("StalliRREliminati") = CInt("0" & TxtStalliRREliminati.Text)
    dr(0).Item("StalliRRRipristinati") = CInt("0" & TxtStalliRRRipristinati.Text)
    dr(0).Item("StalliRRExNovo") = CInt("0" & TxtStalliRRExNovo.Text)
    dr(0).Item("ResidentiNuovi") = CInt("0" & TxtResidentiNuovi.Text)
    dr(0).Item("ResidentiEliminati") = CInt("0" & TxtResidentiEliminati.Text)
    dr(0).Item("ResidentiRipristinati") = CInt("0" & TxtResidentiRipristinati.Text)
    dr(0).Item("ResidentiExNovo") = CInt("0" & TxtResidentiExNovo.Text)
    dr(0).Item("StalliMotoNuovi") = CInt("0" & TxtMotoNuovi.Text)
    dr(0).Item("StalliMotoEliminati") = CInt("0" & TxtMotoEliminati.Text)
    dr(0).Item("StalliMotoRipristinati") = CInt("0" & TxtMotoRipristinati.Text)
    dr(0).Item("StalliMotoExNovo") = CInt("0" & TxtMotoExNovo.Text)
    dr(0).Item("FittoniNuovi") = CInt("0" & TxtFittoniNuovi.Text)
    dr(0).Item("FittoniEliminati") = CInt("0" & TxtFittoniEliminati.Text)
    dr(0).Item("FittoniRipristinati") = CInt("0" & TxtFittoniRipristinati.Text)
    dr(0).Item("FittoniExNovo") = CInt("0" & TxtFittoniExNovo.Text)
    dr(0).Item("FormaggioniNuovi") = CInt("0" & TxtFormaNuovi.Text)
    dr(0).Item("FormaggioniEliminati") = CInt("0" & TxtFormaEliminati.Text)
    dr(0).Item("FormaggioniRipristinati") = CInt("0" & TxtFormaRipristinati.Text)
    dr(0).Item("FormaggioniExNovo") = CInt("0" & TxtFormaExNovo.Text)


    dr(0).Item("CarsharingNuovi") = CInt("0" & TxtCarNuovi.Text)
    dr(0).Item("CarsharingEliminati") = CInt("0" & TxtCarEliminati.Text)
    dr(0).Item("CarsharingRipristinati") = CInt("0" & TxtCarRipristinati.Text)
    dr(0).Item("CarsharingExNovo") = CInt("0" & TxtCarExNovo.Text)
    dr(0).Item("DisabiliNuovi") = CInt("0" & TxtDisabiliNuovi.Text)
    dr(0).Item("DisabiliEliminati") = CInt("0" & TxtDisabiliEliminati.Text)
    dr(0).Item("DisabiliRipristinati") = CInt("0" & TxtDisabiliRipristinati.Text)
    dr(0).Item("DisabiliExNovo") = CInt("0" & TxtDisabiliExNovo.Text)
    dr(0).Item("GenericiNuovi") = CInt("0" & TxtGenNuovi.Text)
    dr(0).Item("GenericiEliminati") = CInt("0" & TxtGenEliminati.Text)
    dr(0).Item("GenericiRipristinati") = CInt("0" & TxtGenRipristinati.Text)
    dr(0).Item("GenericiExNovo") = CInt("0" & TxtGenExNovo.Text)
    dr(0).Item("DiscoOrarioNuovi") = CInt("0" & TxtDiscNuovi.Text)
    dr(0).Item("DiscoOrarioEliminati") = CInt("0" & TxtDiscEliminati.Text)
    dr(0).Item("DiscoOrarioRipristinati") = CInt("0" & TxtDiscRipristinati.Text)
    dr(0).Item("DiscoOrarioExNovo") = CInt("0" & TxtDiscExNovo.Text)

    dr(0).Item("CaricoScaricoNuovi") = CInt("0" & TxtCaricoSNuovi.Text)
    dr(0).Item("CaricoScaricoEliminati") = CInt("0" & TxtCaricoSEliminati.Text)
    dr(0).Item("CaricoScaricoRipristinati") = CInt("0" & TxtCaricoSRipristinati.Text)
    dr(0).Item("CaricoScaricoExNovo") = CInt("0" & TxtCaricoSExNovo.Text)


    ' fine nuovi campi della tabella lavori stradali

    If txtDEId.Text.Length = 0 Then
      DsValori.Tables("LavoriStradali").Rows.Add(dr(0))
    End If
    daLavori.Update(DsValori, "LavoriStradali")
    pnlSearch.Visible = True
    pnlConteggio.Visible = True
    pnlModifica.Visible = False

  End Function

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    If Me.IsValid Then pSaveItem()
  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    pNewFind()
  End Sub

  'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
  '  FileSystem.Kill(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "/files/" & txtDEFile.Text & txtDEExt.Text)
  '  'btnView.Enabled = False
  '  'btnDelete.Enabled = False
  '  txtDETesto.Visible = True
  '  txtDEExt.Text = ""
  '  txtDEFile.Text = ""
  '  pSaveItem()
  'End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    pSearchItem()
  End Sub

  Private Sub dgLavoriStradali_PageIndexChanged(ByVal sender As System.Object, ByVal e As DataGridPageChangedEventArgs) Handles dgLavoriStradali.PageIndexChanged
    dgLavoriStradali.CurrentPageIndex = e.NewPageIndex
    pBuildWhere()
    If Where.Length > 0 And daLavori.SelectCommand.CommandText.IndexOf("WHERE") < 0 Then
      daLavori.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If daLavori.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      daLavori.SelectCommand.CommandText &= " Order By DataInizio Desc, Nome, Zona"
    End If
    DsValori.Tables("LavoriStradali").Clear()
    daLavori.Fill(DsValori.Tables("LavoriStradali"))
    dgLavoriStradali.DataBind()
  End Sub

  Private Sub pShowInsertPanel()
    pnlModifica.Visible = True
    pnlSearch.Visible = False
    pnlConteggio.Visible = False
    pnlRisultati.Visible = False
    txtDEId.Visible = False
    txtDEIdVia.Visible = False
    txtDEFile.Visible = False
    txtDEExt.Visible = False
  End Sub

  Private Sub pLoadVia(ByVal id As Integer)
    Dim com As New SqlCommand("Select * from StradarioBologna Where Cod_Prov = 37 And Cod_Comune = 6 And Codice = @1", con)
    Dim dRead As SqlDataReader
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dRead = com.ExecuteReader
    dRead.Read()
    lblDEVia.Text = dRead.Item("Nome")
    txtDEIdVia.Text = id
    con.Close()
  End Sub


  Private Sub pAddItem(ByVal id As Integer)
    pShowInsertPanel()
    pLoadVia(id)
  End Sub

  Private Sub pShowConteggi()

    con.Open()

    Dim com01 As New SqlClient.SqlCommand("Select Sum(PaliNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com02 As New SqlClient.SqlCommand("Select Sum(PaliEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com03 As New SqlClient.SqlCommand("Select Sum(PaliRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com04 As New SqlClient.SqlCommand("Select Sum(CartelliNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com05 As New SqlClient.SqlCommand("Select Sum(CartelliEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com06 As New SqlClient.SqlCommand("Select Sum(CartelliRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com07 As New SqlClient.SqlCommand("Select Sum(StalliONuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com08 As New SqlClient.SqlCommand("Select Sum(StalliOEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com09 As New SqlClient.SqlCommand("Select Sum(StalliORipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com10 As New SqlClient.SqlCommand("Select Sum(StalliRRNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com11 As New SqlClient.SqlCommand("Select Sum(StalliRREliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com12 As New SqlClient.SqlCommand("Select Sum(StalliRRRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com13 As New SqlClient.SqlCommand("Select Sum(ResidentiNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com14 As New SqlClient.SqlCommand("Select Sum(ResidentiEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com15 As New SqlClient.SqlCommand("Select Sum(ResidentiRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com16 As New SqlClient.SqlCommand("Select Sum(StalliMotoNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com17 As New SqlClient.SqlCommand("Select Sum(StalliMotoEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com18 As New SqlClient.SqlCommand("Select Sum(StalliMotoRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com19 As New SqlClient.SqlCommand("Select Sum(FittoniNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com20 As New SqlClient.SqlCommand("Select Sum(FittoniEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com21 As New SqlClient.SqlCommand("Select Sum(FittoniRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com22 As New SqlClient.SqlCommand("Select Sum(FormaggioniNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com23 As New SqlClient.SqlCommand("Select Sum(FormaggioniEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com24 As New SqlClient.SqlCommand("Select Sum(FormaggioniRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com25 As New SqlClient.SqlCommand("Select Sum(PaliExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com26 As New SqlClient.SqlCommand("Select Sum(CartelliExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com27 As New SqlClient.SqlCommand("Select Sum(StalliOExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com28 As New SqlClient.SqlCommand("Select Sum(StalliRRExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com29 As New SqlClient.SqlCommand("Select Sum(ResidentiExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com30 As New SqlClient.SqlCommand("Select Sum(StalliMotoExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com31 As New SqlClient.SqlCommand("Select Sum(FittoniExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com32 As New SqlClient.SqlCommand("Select Sum(FormaggioniExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com33 As New SqlClient.SqlCommand("Select Sum(CarsharingNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com34 As New SqlClient.SqlCommand("Select Sum(CarsharingEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com35 As New SqlClient.SqlCommand("Select Sum(CarsharingRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com36 As New SqlClient.SqlCommand("Select Sum(CarsharingExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com37 As New SqlClient.SqlCommand("Select Sum(DisabiliNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com38 As New SqlClient.SqlCommand("Select Sum(DisabiliEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com39 As New SqlClient.SqlCommand("Select Sum(DisabiliRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com40 As New SqlClient.SqlCommand("Select Sum(DisabiliExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com41 As New SqlClient.SqlCommand("Select Sum(GenericiNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com42 As New SqlClient.SqlCommand("Select Sum(GenericiEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com43 As New SqlClient.SqlCommand("Select Sum(GenericiRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com44 As New SqlClient.SqlCommand("Select Sum(GenericiExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com45 As New SqlClient.SqlCommand("Select Sum(DiscoOrarioNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com46 As New SqlClient.SqlCommand("Select Sum(DiscoOrarioEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com47 As New SqlClient.SqlCommand("Select Sum(DiscoOrarioRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com48 As New SqlClient.SqlCommand("Select Sum(DiscoOrarioExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com49 As New SqlClient.SqlCommand("Select Sum(CaricoScaricoNuovi) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com50 As New SqlClient.SqlCommand("Select Sum(CaricoScaricoEliminati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com51 As New SqlClient.SqlCommand("Select Sum(CaricoScaricoRipristinati) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)
    Dim com52 As New SqlClient.SqlCommand("Select Sum(CaricoScaricoExNovo) From LavoriStradali Right Join StradarioBologna S On LavoriStradali.IdVia = S.Codice And LavoriStradali.DataCancellazione Is Null And S.Cod_Prov = 37 And S.Cod_Comune = 6" & IIf(Where.Length > 0, " WHERE " & Where, ""), con)



    LblTPaliNuovi.Text = CInt("0" & com01.ExecuteScalar)
    LblTPaliEliminati.Text = CInt("0" & com02.ExecuteScalar)
    LblTPaliRipristinati.Text = CInt("0" & com03.ExecuteScalar)
    LblTCartelliNuovi.Text = CInt("0" & com04.ExecuteScalar)
    LblTCartelliEliminati.Text = CInt("0" & com05.ExecuteScalar)
    LblTCartelliRipristinati.Text = CInt("0" & com06.ExecuteScalar)
    LblTStalliONuovi.Text = CInt("0" & com07.ExecuteScalar)
    LblTStalliOEliminati.Text = CInt("0" & com08.ExecuteScalar)
    LblTStalliORipristinati.Text = CInt("0" & com09.ExecuteScalar)
    LblTStalliRRNuovi.Text = CInt("0" & com10.ExecuteScalar)
    LblTStalliRREliminati.Text = CInt("0" & com11.ExecuteScalar)
    LblTStalliRRRipristinati.Text = CInt("0" & com12.ExecuteScalar)
    LblTResidentiNuovi.Text = CInt("0" & com13.ExecuteScalar)
    LblTResidentiEliminati.Text = CInt("0" & com14.ExecuteScalar)
    LblTResidentiRipristinati.Text = CInt("0" & com15.ExecuteScalar)
    LblTMotoNuovi.Text = CInt("0" & com16.ExecuteScalar)
    LblTMotoEliminati.Text = CInt("0" & com17.ExecuteScalar)
    LblTMotoRipristinati.Text = CInt("0" & com18.ExecuteScalar)
    LblTFittoniNuovi.Text = CInt("0" & com19.ExecuteScalar)
    LblTFittoniEliminati.Text = CInt("0" & com20.ExecuteScalar)
    LblTFittoniRipristinati.Text = CInt("0" & com21.ExecuteScalar)
    LblTFormaNuovi.Text = CInt("0" & com22.ExecuteScalar)
    LblTFormaEliminati.Text = CInt("0" & com23.ExecuteScalar)
    LblTFormaRipristinati.Text = CInt("0" & com24.ExecuteScalar)
    LblTPaliExNovo.Text = CInt("0" & com25.ExecuteScalar)
    LblTCartelliExNovo.Text = CInt("0" & com26.ExecuteScalar)
    LblTStalliOExNovo.Text = CInt("0" & com27.ExecuteScalar)
    LblTStalliRRExNovo.Text = CInt("0" & com28.ExecuteScalar)
    LblTResidentiExNovo.Text = CInt("0" & com29.ExecuteScalar)
    LblTMotoExNovo.Text = CInt("0" & com30.ExecuteScalar)
    LblTFittoniExNovo.Text = CInt("0" & com31.ExecuteScalar)
    LblTFormaExNovo.Text = CInt("0" & com32.ExecuteScalar)
    LblTCarNuovi.Text = CInt("0" & com33.ExecuteScalar)
    LblTCarEliminati.Text = CInt("0" & com34.ExecuteScalar)
    LblTCarRipristinati.Text = CInt("0" & com35.ExecuteScalar)
    LblTCarExNovo.Text = CInt("0" & com36.ExecuteScalar)
    LblTDisNuovi.Text = CInt("0" & com37.ExecuteScalar)
    LblTDisEliminati.Text = CInt("0" & com38.ExecuteScalar)
    LblTDisRipristinati.Text = CInt("0" & com39.ExecuteScalar)
    LblTDisExNovo.Text = CInt("0" & com40.ExecuteScalar)
    LblTGenNuovi.Text = CInt("0" & com41.ExecuteScalar)
    LblTGenEliminati.Text = CInt("0" & com42.ExecuteScalar)
    LblTGenRipristinati.Text = CInt("0" & com43.ExecuteScalar)
    LblTGenExNovo.Text = CInt("0" & com44.ExecuteScalar)
    LblTDiscNuovi.Text = CInt("0" & com45.ExecuteScalar)
    LblTDiscEliminati.Text = CInt("0" & com46.ExecuteScalar)
    LblTDiscRipristinati.Text = CInt("0" & com47.ExecuteScalar)
    LblTDiscExNovo.Text = CInt("0" & com48.ExecuteScalar)

    LblTCaricoSNuovi.Text = CInt("0" & com49.ExecuteScalar)
    LblTCaricoSEliminati.Text = CInt("0" & com50.ExecuteScalar)
    LblTCaricoSRipristinati.Text = CInt("0" & com51.ExecuteScalar)
    LblTCaricoSExNovo.Text = CInt("0" & com52.ExecuteScalar)

    con.Close()

  End Sub

  Private Sub pEnableItems(ByVal b As Boolean)

    txtDEId.Enabled = b
    txtDEIdVia.Enabled = b
    txtDETitle.Enabled = b
    txtDEOrdinanza.Enabled = b
    txtDETesto.Enabled = b
    txtDEDataInizio.Enabled = b
    txtDEDataFine.Enabled = b
    cboDECausale.Enabled = b
    cboDEEsecutore.Enabled = b
    cboDETipo.Enabled = b
    cboDEZona.Enabled = b
    'Vecchi campi tabella lavori stradali
    'txtDEVertInstallata.Enabled = b
    'txtDEVertRimossa.Enabled = b
    'txtDEVertSostituita.Enabled = b
    'txtDEStalliAPettine.Enabled = b
    'txtDEStalliInLinea.Enabled = b
    'txtDEStalliMoto.Enabled = b
    'txtDEStalliCancAPettine.Enabled = b
    'txtDEStalliCancInLinea.Enabled = b
    'txtDEStalliCancMoto.Enabled = b
    'txtDEFormaggioni.Enabled = b
    'txtDEFittoni.Enabled = b
    'Fine Vecchi campi tabella lavori stradali

    TxtPaliNuovi.Enabled = b
    TxtPaliEliminati.Enabled = b
    TxtPaliRipristinati.Enabled = b
    TxtPaliExNovo.Enabled = b
    TxtCartelliNuovi.Enabled = b
    TxtCartelliEliminati.Enabled = b
    TxtCartelliRipristinati.Enabled = b
    TxtCartelliExNovo.Enabled = b
    TxtStalliONuovi.Enabled = b
    TxtStalliOEliminati.Enabled = b
    TxtStalliORipristinati.Enabled = b
    TxtStalliOExNovo.Enabled = b
    TxtStalliRRNuovi.Enabled = b
    TxtStalliRREliminati.Enabled = b
    TxtStalliRRRipristinati.Enabled = b
    TxtStalliRRExNovo.Enabled = b
    TxtResidentiNuovi.Enabled = b
    TxtResidentiEliminati.Enabled = b
    TxtResidentiRipristinati.Enabled = b
    TxtResidentiExNovo.Enabled = b
    TxtMotoNuovi.Enabled = b
    TxtMotoEliminati.Enabled = b
    TxtMotoRipristinati.Enabled = b
    TxtMotoExNovo.Enabled = b
    TxtFittoniNuovi.Enabled = b
    TxtFittoniEliminati.Enabled = b
    TxtFittoniRipristinati.Enabled = b
    TxtFittoniExNovo.Enabled = b
    TxtFormaNuovi.Enabled = b
    TxtFormaEliminati.Enabled = b
    TxtFormaExNovo.Enabled = b
    TxtCarNuovi.Enabled = b
    TxtCarEliminati.Enabled = b
    TxtCarRipristinati.Enabled = b
    TxtCarExNovo.Enabled = b
    TxtDisabiliNuovi.Enabled = b
    TxtDisabiliEliminati.Enabled = b
    TxtDisabiliRipristinati.Enabled = b
    TxtDisabiliExNovo.Enabled = b
    TxtGenNuovi.Enabled = b
    TxtGenEliminati.Enabled = b
    TxtGenRipristinati.Enabled = b
    TxtGenExNovo.Enabled = b
    TxtDiscNuovi.Enabled = b
    TxtDiscEliminati.Enabled = b
    TxtDiscRipristinati.Enabled = b
    TxtDiscExNovo.Enabled = b

    TxtCaricoSNuovi.Enabled = b
    TxtCaricoSEliminati.Enabled = b
    TxtCaricoSRipristinati.Enabled = b
    TxtCaricoSExNovo.Enabled = b

    btnSave.Visible = b

  End Sub

  Private Function ToSqlDate(ByVal dt As String) As String
    Dim pArr(3) As String
    pArr = dt.Split("/")
    ToSqlDate = pArr(2) & "-" & Right("0" & pArr(1), 2) & "-" & Right("0" & pArr(0), 2)
  End Function

  Sub dgLavoriStradali_ItemCreated(ByVal Sender As Object, ByVal e As DataGridItemEventArgs) Handles dgLavoriStradali.ItemCreated
    Select Case e.Item.ItemType
      Case ListItemType.Item, ListItemType.AlternatingItem, ListItemType.EditItem
        Dim myDeleteButton As LinkButton
        myDeleteButton = e.Item.FindControl("Linkbutton2")
        myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi eliminare questo lavoro stradale?');")
    End Select
  End Sub

  Private Sub pClearItem()
    txtDEId.Text = ""
    txtDEDataFine.Text = ""
    txtDEDataInizio.Text = ""
    txtDEExt.Text = ""
    txtDEFile.Text = ""
    txtDETesto.Text = ""
    txtDETitle.Text = ""
    txtDEOrdinanza.Text = ""
    ' Vecchi campi tabella lavori stradali
    'txtDEFittoni.Text = ""
    'txtDEFormaggioni.Text = ""
    'txtDEStalliAPettine.Text = ""
    'txtDEStalliCancAPettine.Text = ""
    'txtDEStalliCancInLinea.Text = ""
    'txtDEStalliCancMoto.Text = ""
    'txtDEStalliInLinea.Text = ""
    'txtDEStalliMoto.Text = ""
    'txtDEVertInstallata.Text = ""
    'txtDEVertRimossa.Text = ""
    'txtDEVertSostituita.Text = ""
    ' fine vecchi campi della tabella lavori stradali 
    ' nuovi campi tabella lavori stradali 
    TxtPaliNuovi.Text = ""
    TxtPaliEliminati.Text = ""
    TxtPaliRipristinati.Text = ""
    TxtPaliExNovo.Text = ""
    TxtCartelliNuovi.Text = ""
    TxtCartelliEliminati.Text = ""
    TxtCartelliRipristinati.Text = ""
    TxtCartelliExNovo.Text = ""
    TxtStalliONuovi.Text = ""
    TxtStalliOEliminati.Text = ""
    TxtStalliORipristinati.Text = ""
    TxtStalliOExNovo.Text = ""
    TxtStalliRRNuovi.Text = ""
    TxtStalliRREliminati.Text = ""
    TxtStalliRRRipristinati.Text = ""
    TxtStalliRRExNovo.Text = ""
    TxtResidentiNuovi.Text = ""
    TxtResidentiEliminati.Text = ""
    TxtResidentiRipristinati.Text = ""
    TxtResidentiExNovo.Text = ""
    TxtMotoNuovi.Text = ""
    TxtMotoEliminati.Text = ""
    TxtMotoRipristinati.Text = ""
    TxtMotoExNovo.Text = ""
    TxtFittoniNuovi.Text = ""
    TxtFittoniEliminati.Text = ""
    TxtFittoniRipristinati.Text = ""
    TxtFittoniExNovo.Text = ""
    TxtFormaNuovi.Text = ""
    TxtFormaEliminati.Text = ""
    TxtFormaRipristinati.Text = ""
    TxtFormaExNovo.Text = ""
    TxtCarNuovi.Text = ""
    TxtCarEliminati.Text = ""
    TxtCarRipristinati.Text = ""
    TxtCarExNovo.Text = ""
    TxtDisabiliNuovi.Text = ""
    TxtDisabiliEliminati.Text = ""
    TxtDisabiliRipristinati.Text = ""
    TxtDisabiliExNovo.Text = ""
    TxtGenNuovi.Text = ""
    TxtGenEliminati.Text = ""
    TxtGenRipristinati.Text = ""
    TxtGenExNovo.Text = ""
    TxtDiscNuovi.Text = ""
    TxtDiscEliminati.Text = ""
    TxtDiscRipristinati.Text = ""
    TxtDiscExNovo.Text = ""

    TxtCaricoSNuovi.Text = ""
    TxtCaricoSEliminati.Text = ""
    TxtCaricoSRipristinati.Text = ""
    TxtCaricoSExNovo.Text = ""
    ' fine nuovi campi tabella lavori stradali

    cboDECausale.SelectedIndex = 0
    cboDEEsecutore.SelectedIndex = 0
    cboDETipo.SelectedIndex = 0
    cboDEZona.SelectedIndex = 0
  End Sub

  Private Sub pBuildWhere()
    Where = ""
    If txtVia.Text.Length > 0 Then
      Where &= "Nome Like '%" & txtVia.Text.Replace("'", "''") & "%'"
    End If
    If cboZona.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.IdZona = " & cboZona.SelectedValue
    End If
    If txtDal.Text.Length > 0 Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.DataInizio >= {d'" & ToSqlDate(txtDal.Text) & "'}"
    End If
    If txtAl.Text.Length > 0 Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.DataInizio <= {d'" & ToSqlDate(txtAl.Text) & "'}"
    End If
    If cboEsecutore.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.IdEsecutore = " & cboEsecutore.SelectedValue
    End If
    If cboTipo.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.IdTipo = " & cboTipo.SelectedValue
    End If
    If cboCausale.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "LavoriStradali.IdCausale = " & cboCausale.SelectedValue
    End If
  End Sub


End Class
