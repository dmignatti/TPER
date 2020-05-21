Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class wf_ordinanze
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daOrdinanze = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsOrdinanze = New ATCBussm1.dsOrdinanze
    Me.daOrdinanzeTipi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsOrdinanze, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'daOrdinanze
    '
    Me.daOrdinanze.DeleteCommand = Me.SqlCommand1
    Me.daOrdinanze.InsertCommand = Me.SqlCommand2
    Me.daOrdinanze.SelectCommand = Me.SqlSelectCommand2
    Me.daOrdinanze.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ordinanze", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codice", "Codice"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Idvia", "Idvia"), New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Titolo", "Titolo"), New System.Data.Common.DataColumnMapping("Testo", "Testo"), New System.Data.Common.DataColumnMapping("File", "File"), New System.Data.Common.DataColumnMapping("Ext", "Ext"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("dal", "dal"), New System.Data.Common.DataColumnMapping("al", "al"), New System.Data.Common.DataColumnMapping("IdParent", "IdParent"), New System.Data.Common.DataColumnMapping("DataCancellazione", "DataCancellazione"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione")})})
    Me.daOrdinanze.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.Ordinanze SET DataCancellazione = GETDATE() WHERE (Id = @Id)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "INSERT INTO dbo.Ordinanze (Idvia, Titolo, Testo, [File], Ext, Tipo, dal, al, Ordi" & _
    "nanza, IdParent) VALUES (@IdVia, @Titolo, @Testo, @File, @Ext, @Tipo, @dal, @al," & _
    " @Ordinanza, @IdParent)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVia", System.Data.SqlDbType.Int, 4, "Idvia"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Titolo", System.Data.SqlDbType.VarChar, 100, "Titolo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Testo", System.Data.SqlDbType.VarChar, 1000, "Testo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@File", System.Data.SqlDbType.UniqueIdentifier, 16, "File"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ext", System.Data.SqlDbType.VarChar, 10, "Ext"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.SmallInt, 2, "Tipo"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dal", System.Data.SqlDbType.DateTime, 8, "dal"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@al", System.Data.SqlDbType.DateTime, 8, "al"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinanza", System.Data.SqlDbType.VarChar, 50, "Ordinanza"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdParent", System.Data.SqlDbType.Int, 4, "IdParent"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdVia, Codice, Nome, Id, Titolo, Testo, [File], Ext, Tipo, dal, al, IdPare" & _
    "nt, Ordinanza, TipoOrdinanza FROM (SELECT O1.IdVia, L.Codice, L.Nome, O1.[Id], O" & _
    "1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.IdParent, O1.O" & _
    "rdinanza, OT.Tipo AS TipoOrdinanza FROM ordinanze o1 RIGHT JOIN StradarioBologna" & _
    " L ON o1.IdVia = L.Codice AND L.Cod_Prov = 37 AND L.Cod_Comune = 6 LEFT JOIN Ord" & _
    "inanzeTipi OT ON o1.Tipo = OT.[Id] WHERE GetDate() BETWEEN o1.Dal AND o1.Al AND " & _
    "o1.tipo = 2 AND o1.datacancellazione IS NULL UNION SELECT O1.IdVia, L.Codice, L." & _
    "Nome, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O" & _
    "1.IdParent, O1.Ordinanza, OT.Tipo AS TipoOrdinanza FROM ordinanze o1 LEFT JOIN S" & _
    "tradarioBologna L ON o1.IdVia = L.Codice AND L.Cod_Prov = 37 AND L.Cod_Comune = " & _
    "6 LEFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id] WHERE GetDate() BETWEEN o1.Dal" & _
    " AND o1.Al AND o1.datacancellazione IS NULL AND o1.tipo = 1 AND NOT o1.[id] IN (" & _
    "SELECT IdParent FROM ordinanze o3 WHERE datacancellazione IS NULL AND GetDate() " & _
    "BETWEEN o3.Dal AND o3.Al AND o3.tipo = 2) UNION SELECT O1.IdVia, L.Codice, L.Nom" & _
    "e, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.I" & _
    "dParent, O1.Ordinanza, OT.Tipo AS TipoOrdinanza FROM ordinanze o1 LEFT JOIN Stra" & _
    "darioBologna L ON o1.IdVia = L.Codice AND L.Cod_Prov = 37 AND L.Cod_Comune = 6 L" & _
    "EFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id] WHERE GetDate() BETWEEN o1.Dal AN" & _
    "D o1.Al AND o1.datacancellazione IS NULL AND o1.Tipo = 3 AND idparent IN (SELECT" & _
    " [id] FROM ordinanze o2 WHERE datacancellazione IS NULL AND GetDate() BETWEEN o2" & _
    ".Dal AND o2.Al AND o2.tipo IN (1, 2)) UNION SELECT NULL, L.Codice, L.Nome, NULL," & _
    " NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL FROM StradarioBologn" & _
    "a L WHERE L.Cod_Prov = 37 AND L.Cod_Comune = 6 AND NOT L.Codice IN (SELECT IdVia" & _
    " FROM Ordinanze O WHERE DataCancellazione IS NULL AND GetDate() BETWEEN o.Dal AN" & _
    "D o.Al)) O4"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.Ordinanze SET Idvia = @IdVia, Ordinanza = @Ordinanza, Titolo = @Titolo" & _
    ", Testo = @Testo, [File] = @File, Ext = @Ext, Tipo = @Tipo, dal = @dal, al = @al" & _
    ", IdParent = @IdParent WHERE (Id = @Id) AND (Idvia = @Original_IdVia OR @Origina" & _
    "l_IdVia IS NULL AND Idvia IS NULL) AND (Ordinanza = @Original_Ordinanza OR @Orig" & _
    "inal_Ordinanza IS NULL AND Ordinanza IS NULL) AND (Titolo = @Original_Titolo OR " & _
    "@Original_Titolo IS NULL AND Titolo IS NULL) AND (Testo = @Original_Testo OR @Or" & _
    "iginal_Testo IS NULL AND Testo IS NULL) AND ([File] = @Original_File OR @Origina" & _
    "l_File IS NULL AND [File] IS NULL) AND (Ext = @Original_Ext OR @Original_Ext IS " & _
    "NULL AND Ext IS NULL) AND (Tipo = @Original_Tipo OR @Original_Tipo IS NULL AND T" & _
    "ipo IS NULL) AND (dal = @Original_dal OR @Original_dal IS NULL AND dal IS NULL) " & _
    "AND (al = @Original_al OR @Original_al IS NULL AND al IS NULL) AND (IdParent = @" & _
    "Original_IdParent OR @Original_IdParent IS NULL AND IdParent IS NULL)"
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVia", System.Data.SqlDbType.Int, 4, "Idvia"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinanza", System.Data.SqlDbType.VarChar, 50, "Ordinanza"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Titolo", System.Data.SqlDbType.VarChar, 100, "Titolo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Testo", System.Data.SqlDbType.VarChar, 1000, "Testo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@File", System.Data.SqlDbType.UniqueIdentifier, 16, "File"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ext", System.Data.SqlDbType.VarChar, 10, "Ext"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.SmallInt, 2, "Tipo"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dal", System.Data.SqlDbType.DateTime, 8, "dal"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@al", System.Data.SqlDbType.DateTime, 8, "al"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdParent", System.Data.SqlDbType.Int, 4, "IdParent"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Idvia", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinanza", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinanza", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Titolo", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Titolo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Testo", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Testo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_File", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "File", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ext", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ext", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_dal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dal", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_al", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "al", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdParent", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdParent", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsOrdinanze
    '
    Me.DsOrdinanze.DataSetName = "dsOrdinanze"
    Me.DsOrdinanze.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daOrdinanzeTipi
    '
    Me.daOrdinanzeTipi.DeleteCommand = Me.SqlDeleteCommand1
    Me.daOrdinanzeTipi.InsertCommand = Me.SqlInsertCommand1
    Me.daOrdinanzeTipi.SelectCommand = Me.SqlSelectCommand1
    Me.daOrdinanzeTipi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OrdinanzeTipi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
    Me.daOrdinanzeTipi.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.OrdinanzeTipi WHERE (Id = @Original_Id) AND (Tipo = @Ori" & _
    "ginal_Tipo OR @Original_Tipo IS NULL AND Tipo IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO ATCBussm.dbo.OrdinanzeTipi(Tipo) VALUES (@Tipo); SELECT Id, Tipo FROM" & _
    " ATCBussm.dbo.OrdinanzeTipi WHERE (Id = @@IDENTITY) ORDER BY Tipo"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 30, "Tipo"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Tipo FROM ATCBussm.dbo.OrdinanzeTipi ORDER BY Tipo"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE ATCBussm.dbo.OrdinanzeTipi SET Tipo = @Tipo WHERE (Id = @Original_Id) AND " & _
    "(Tipo = @Original_Tipo OR @Original_Tipo IS NULL AND Tipo IS NULL); SELECT Id, T" & _
    "ipo FROM ATCBussm.dbo.OrdinanzeTipi WHERE (Id = @Id) ORDER BY Tipo"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 30, "Tipo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    CType(Me.DsOrdinanze, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents btnView As System.Web.UI.WebControls.HyperLink
  Protected WithEvents btnDelete As System.Web.UI.WebControls.ImageButton
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
  Protected WithEvents pnlEditOrd As System.Web.UI.WebControls.Panel
  Protected WithEvents OrdFile As System.Web.UI.HtmlControls.HtmlInputFile
  Protected WithEvents pnlSearch As System.Web.UI.WebControls.Panel
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents chkStorico As System.Web.UI.WebControls.CheckBox
  Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
  Protected WithEvents pnlRisultati As System.Web.UI.WebControls.Panel
  Protected WithEvents dgOrdinanze As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents txtOrdinanza As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDETitle As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEAl As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDETesto As System.Web.UI.WebControls.TextBox
  Protected WithEvents cboDETipo As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtDEDal As System.Web.UI.WebControls.TextBox
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daOrdinanze As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsOrdinanze As ATCBussm1.dsOrdinanze
  Protected WithEvents txtdeId As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtdeIdVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEFile As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDEExt As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDEVia As System.Web.UI.WebControls.Label
  Protected WithEvents txtDEOrdinanza As System.Web.UI.WebControls.TextBox
  Protected WithEvents daOrdinanzeTipi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator3 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator4 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RequiredFieldValidator5 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents RangeValidator2 As System.Web.UI.WebControls.RangeValidator
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand

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
  Private pSelectStorico As String = "" & _
    "Select L.Codice, O1.IdVia, L.Nome, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.IdParent, O1.Ordinanza, " & _
    "OT.Tipo AS TipoOrdinanza FROM ordinanze o1 RIGHT JOIN StradarioBologna L ON o1.IdVia = L.Codice And L.Cod_Prov = 37 And L.Cod_Comune = 6 And o1.DataCancellazione Is Null LEFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id]"
  Private pSelectStandard As String = "" & _
    "SELECT IdVia, Codice, Nome, Id, Titolo, Testo, [File], Ext, Tipo, dal, al, IdParent, Ordinanza, TipoOrdinanza " & _
    "FROM (SELECT     O1.IdVia, L.Codice, L.Nome, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.IdParent, O1.Ordinanza, " & _
    "OT.Tipo AS TipoOrdinanza FROM ordinanze o1 RIGHT JOIN StradarioBologna L ON o1.IdVia = L.Codice And L.Cod_Prov = 37 And L.Cod_Comune = 6 LEFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id] " & _
    "WHERE GetDate() BETWEEN o1.Dal AND o1.Al AND o1.tipo = 2 AND o1.datacancellazione IS NULL UNION SELECT O1.IdVia, L.Codice, L.Nome, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.IdParent, O1.Ordinanza, " & _
    "OT.Tipo AS TipoOrdinanza FROM ordinanze o1 LEFT JOIN StradarioBologna L ON o1.IdVia = L.Codice And L.Cod_Prov = 37 And L.Cod_Comune = 6 LEFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id] " & _
    "WHERE GetDate() BETWEEN o1.Dal AND o1.Al AND o1.datacancellazione IS NULL AND o1.tipo = 1 AND NOT o1.[id] IN (SELECT IdParent " & _
    "FROM ordinanze WHERE datacancellazione IS NULL AND GetDate() BETWEEN Dal AND Al AND tipo = 2) And o1.DataCreazione = " & _
    "(Select Max(DataCreazione) From Ordinanze o4 Where GetDate() BETWEEN o4.Dal AND o4.Al AND o4.datacancellazione IS NULL AND o4.tipo = 1 And NOT o4.[id] IN " & _
    "(SELECT IdParent FROM ordinanze WHERE datacancellazione IS NULL AND GetDate() BETWEEN Dal AND Al AND tipo = 2) And O4.IdVia = o1.IdVia) UNION " & _
    "SELECT O1.IdVia, L.Codice, L.Nome, O1.[Id], O1.Titolo, O1.Testo, O1.[File], O1.Ext, O1.Tipo, O1.dal, O1.al, O1.IdParent, O1.Ordinanza, " & _
    "OT.Tipo AS TipoOrdinanza FROM ordinanze o1 LEFT JOIN StradarioBologna L ON o1.IdVia = L.Codice And L.Cod_Prov = 37 And L.Cod_Comune = 6 LEFT JOIN OrdinanzeTipi OT ON o1.Tipo = OT.[Id] " & _
    "WHERE GetDate() BETWEEN o1.Dal AND o1.Al AND o1.datacancellazione IS NULL AND o1.Tipo = 3 AND idparent IN (SELECT [id] FROM ordinanze o2 " & _
    "WHERE datacancellazione IS NULL AND GetDate() BETWEEN o2.Dal AND o2.Al AND o2.tipo IN (1, 2)) UNION SELECT NULL, L.Codice, L.Nome, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL " & _
    "FROM StradarioBologna L WHERE L.Cod_Prov = 37 And L.Cod_Comune = 6 And NOT L.Codice IN (SELECT IdVia FROM Ordinanze O WHERE DataCancellazione IS NULL AND GetDate() BETWEEN o.Dal AND o.Al)) O4"
  Private pSelectParent As String = "" & _
    "Select [Id] From Ordinanze Where IdVia = @1 And Tipo = 1 And DataCancellazione Is Null And GetDate() Between Dal And Al"
  Private Where As String = ""

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' ----------------------------------------------------------------------------
    '     Righe aggiunte da Paolo Cavazzini
    ' ----------------------------------------------------------------------------
    'Dim intUserID As Integer = atcbSession.Get_UserID(Me.Session)
    'Dim intSectionID As Integer = atcbSession.Get_SectionID(Me.Session)
    'atcbWUser.LoadMenu(intUserID, intSectionID, tblToolbar)
    If Not IsPostBack Then
      ' ----------------------------------------------------------------------------
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      dgOrdinanze.Columns(3).Visible = True
      dgOrdinanze.Columns(4).Visible = True
      dgOrdinanze.Columns(5).Visible = True

      daOrdinanzeTipi.Fill(DsOrdinanze.Tables("OrdinanzeTipi"))
      cboDETipo.DataBind()
      'cboDETipo.Items.Insert(0, pUnspecified)
      btnDelete.Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi eliminare questa ordinanza?');")
    End If
    
  End Sub

  Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
    pSearchItem()
  End Sub

  'Private Sub btnVoceMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoceMenu.Click
  '  Dim arg As String = sender.CommandName
  '  Response.Redirect(arg)
  'End Sub

  Private Sub btnNewFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    pNewSearch()
  End Sub

  Private Sub pNewSearch()
    pnlEditOrd.Visible = False
    pnlRisultati.Visible = True
    pnlSearch.Visible = True
  End Sub

  Private Sub dgOrdinanze_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgOrdinanze.ItemCommand
    pBuildWhere()
    If chkStorico.Checked Then
      daOrdinanze.SelectCommand.CommandText = pSelectStorico
    Else
      daOrdinanze.SelectCommand.CommandText = pSelectStandard
    End If
    If Where.Length > 0 Then
      daOrdinanze.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If daOrdinanze.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      daOrdinanze.SelectCommand.CommandText &= " Order By Al Desc, Dal Desc, Nome"
    End If
    DsOrdinanze.Tables("Ordinanze").Clear()
    daOrdinanze.Fill(DsOrdinanze.Tables("Ordinanze"))
    Select Case e.CommandName
      Case "Edit"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          DsOrdinanze.Tables("Ordinanze").DefaultView.RowStateFilter = DataViewRowState.None
          pLoadItem(DsOrdinanze.Tables("Ordinanze").Select("Id = " & e.Item.Cells(0).Text))
          pEnableItems(True)
          pCheckParent(CInt(e.Item.Cells(1).Text), CInt(e.Item.Cells(0).Text))
        End If
      Case "Delete"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          pDeleteItem(e.Item.Cells(0).Text)
          pSearchItem()
        End If
      Case "Add"
        pShowInsertPanel()
        lblDEVia.Text = e.Item.Cells(2).Text
        txtdeIdVia.Text = e.Item.Cells(1).Text
        pClearItem()
        pEnableItems(True)
        pCheckParent(CInt(e.Item.Cells(1).Text))
      Case "View"
        If e.Item.Cells(0).Text.Replace("&nbsp;", "").Length > 0 Then
          DsOrdinanze.Tables("Ordinanze").DefaultView.RowStateFilter = DataViewRowState.None
          pLoadItem(DsOrdinanze.Tables("Ordinanze").Select("Id = " & e.Item.Cells(0).Text))
          pEnableItems(False)
        End If
    End Select
  End Sub

  Private Sub pLoadItem(ByRef dr() As DataRow)
    Dim g As Guid

    pShowInsertPanel()
    lblDEVia.Text = "" & dr(0).Item("Nome")
    txtdeId.Text = "" & dr(0).Item("ID")
    txtdeIdVia.Text = "" & dr(0).Item("Codice")
    If Not dr(0).Item("File") Is DBNull.Value Then
      g = dr(0).Item("File")
      txtDEFile.Text = "" & g.ToString
    Else
      txtDEFile.Text = ""
    End If
    txtDEExt.Text = "" & dr(0).Item("Ext")
    txtDETitle.Text = "" & dr(0).Item("Titolo")
    If IsDBNull(dr(0).Item("Tipo")) Then
      cboDETipo.SelectedItem.Text = pUnspecified
    Else
      cboDETipo.SelectedValue = dr(0).Item("Tipo")
    End If
    txtDEOrdinanza.Text = "" & dr(0).Item("Ordinanza")
    txtDETesto.Text = "" & dr(0).Item("Testo")
    txtDEDal.Text = "" & dr(0).Item("dal")
    txtDEAl.Text = "" & dr(0).Item("al")

    btnView.Enabled = "" & dr(0).Item("Ext") <> ""
    btnDelete.Enabled = btnView.Enabled
    txtDEFile.Visible = Not btnView.Enabled
    'txtDETesto.Visible = 
    If btnView.Enabled Then btnView.NavigateUrl = "frmOrdinanza.aspx?id=" & dr(0).Item("Id")

    pnlEditOrd.Visible = True
  End Sub

  Private Sub pDeleteItem(ByVal id As Integer)
    DsOrdinanze.Tables("Ordinanze").Select("Id = " & id)(0).Delete()
    daOrdinanze.Update(DsOrdinanze.Tables("Ordinanze"))
    DsOrdinanze.Tables("Ordinanze").Clear()
    daOrdinanze.Fill(DsOrdinanze.Tables("Ordinanze"))
  End Sub

  Private Function pSaveItem(Optional ByVal ReturnToSearch As Boolean = True) As Boolean
    Dim dr() As DataRow
    Dim g As Guid

    If chkStorico.Checked Then
      daOrdinanze.SelectCommand.CommandText = pSelectStorico
    Else
      daOrdinanze.SelectCommand.CommandText = pSelectStandard
    End If
    DsOrdinanze.Tables("Ordinanze").Clear()
    daOrdinanze.Fill(DsOrdinanze.Tables("Ordinanze"))
    If txtdeId.Text.Length > 0 Then
      'Modifica
      dr = DsOrdinanze.Tables("Ordinanze").Select("Id = " & txtdeId.Text)
    Else
      'Inserimento
      ReDim dr(0)
      dr(0) = DsOrdinanze.Tables("Ordinanze").NewRow()
    End If
    dr(0).Item("IdVia") = txtdeIdVia.Text
    dr(0).Item("Titolo") = txtDETitle.Text
    If txtDEOrdinanza.Text.Length > 0 Then
      dr(0).Item("Ordinanza") = txtDEOrdinanza.Text
    Else
      dr(0).Item("Ordinanza") = DBNull.Value
    End If
    If cboDETipo.SelectedItem.Text = pUnspecified Then
      dr(0).Item("Tipo") = DBNull.Value
    Else
      dr(0).Item("Tipo") = cboDETipo.SelectedValue
    End If

    dr(0).Item("Testo") = txtDETesto.Text
    If txtDEDal.Text.Length > 0 Then
      dr(0).Item("Dal") = txtDEDal.Text
    Else
      dr(0).Item("Dal") = DBNull.Value
    End If
    If txtDEAl.Text.Length > 0 Then
      dr(0).Item("Al") = txtDEAl.Text
    Else
      dr(0).Item("Al") = DBNull.Value
    End If
    If txtdeId.Text.Length = 0 Then
      DsOrdinanze.Tables("Ordinanze").Rows.Add(dr(0))
    End If
    If cboDETipo.SelectedValue <> 1 Then
      Dim com As New SqlCommand(pSelectParent, con)
      com.Parameters.Add("@1", SqlDbType.Int).Value = txtdeIdVia.Text
      Dim dread As SqlDataReader
      con.Open()
      dread = com.ExecuteReader
      If dread.HasRows Then
        dread.Read()
        dr(0).Item("IdParent") = dread.Item("Id")
      End If
      con.Close()
    End If
    If OrdFile.PostedFile.InputStream.Length > 0 Then
      Dim Ext As String
      Ext = OrdFile.PostedFile.FileName.Substring(OrdFile.PostedFile.FileName.LastIndexOf("."))
      If txtDEExt.Text.Length > 0 Then
        'Se c'è già un file collegato lo sovrascrivo
        g = New Guid(txtDEFile.Text)
        pAddFile(txtDEFile.Text & Ext, True)
      Else
        'Altrimenti ne creo uno nuovo
        g = g.NewGuid
        pAddFile(g.ToString & Ext, False)
      End If
      dr(0).Item("File") = g
      dr(0).Item("Ext") = Ext
    Else
      If txtDEExt.Text.Length > 0 Then
        g = New Guid(txtDEFile.Text)
        dr(0).Item("File") = g
        dr(0).Item("Ext") = txtDEExt.Text
      Else
        dr(0).Item("File") = DBNull.Value
        dr(0).Item("Ext") = DBNull.Value
      End If
    End If
    daOrdinanze.Update(DsOrdinanze.Tables("Ordinanze"))
    If ReturnToSearch Then
      pnlSearch.Visible = True
      pnlRisultati.Visible = False
      pnlEditOrd.Visible = False
    End If
  End Function

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    If Me.IsValid Then pSaveItem()
    'pSearchItem()
  End Sub

  Public Sub pSearchItem()
    pBuildWhere()
    If chkStorico.Checked Then
      daOrdinanze.SelectCommand.CommandText = pSelectStorico
    Else
      daOrdinanze.SelectCommand.CommandText = pSelectStandard
    End If
    If Where.Length > 0 Then
      daOrdinanze.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If daOrdinanze.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      daOrdinanze.SelectCommand.CommandText &= " Order By Al Desc, Dal Desc, Nome"
    End If
    DsOrdinanze.Tables("Ordinanze").Clear()
    daOrdinanze.Fill(DsOrdinanze.Tables("Ordinanze"))
    dgOrdinanze.CurrentPageIndex = 0
    dgOrdinanze.DataBind()
    pnlRisultati.Visible = True
    dgOrdinanze.Visible = DsOrdinanze.Tables("Ordinanze").Rows.Count > 0
    lblMessage.Visible = Not dgOrdinanze.Visible
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    pClearItem()
    pnlEditOrd.Visible = True
    txtdeId.Visible = False
    txtdeIdVia.Visible = False
    txtDEFile.Visible = False
    txtDEExt.Visible = False
    txtDETesto.Visible = True

  End Sub

  Private Sub pClearItem()
    txtDEAl.Text = ""
    txtDEDal.Text = ""
    txtDEExt.Text = ""
    txtDEFile.Text = ""
    txtdeId.Text = ""
    txtDEOrdinanza.Text = ""
    txtDETesto.Text = ""
    txtDETitle.Text = ""
    cboDETipo.SelectedIndex = 0
    btnDelete.Enabled = False
    btnView.Enabled = False
  End Sub

  Private Sub pAddFile(ByVal Path As String, ByVal KillFile As Boolean)
    If OrdFile.PostedFile.InputStream.Length > 0 Then
      If KillFile And File.Exists(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & Path) Then
        FileSystem.Kill(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & Path)
      End If
      txtDEExt.Text = OrdFile.PostedFile.FileName.Substring(OrdFile.PostedFile.FileName.LastIndexOf(".") + 1)
      OrdFile.PostedFile.SaveAs(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & Path)
      btnView.NavigateUrl = "files/" & Path
      btnView.Enabled = True
      btnDelete.Enabled = True
      txtDEFile.Visible = False
    End If
  End Sub

  Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDelete.Click
    If File.Exists(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & txtDEFile.Text & txtDEExt.Text) Then
      FileSystem.Kill(Server.MapPath("/" & ConfigurationSettings.AppSettings.Item("ApplicationName")) & "\files\" & txtDEFile.Text & txtDEExt.Text)
    End If
    btnView.Enabled = False
    btnDelete.Enabled = False
    txtDEFile.Visible = True
    txtDEExt.Text = ""
    txtDEFile.Text = ""
    pSaveItem(False)
  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    pNewSearch()
  End Sub

  Private Sub dgOrdinanze_PageIndexChanged(ByVal sender As System.Object, ByVal e As DataGridPageChangedEventArgs) Handles dgOrdinanze.PageIndexChanged
    dgOrdinanze.CurrentPageIndex = e.NewPageIndex
    If chkStorico.Checked Then
      daOrdinanze.SelectCommand.CommandText = pSelectStorico
    Else
      daOrdinanze.SelectCommand.CommandText = pSelectStandard
    End If
    pBuildWhere()
    If Where.Length > 0 Then
      daOrdinanze.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If daOrdinanze.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      daOrdinanze.SelectCommand.CommandText &= " Order By Al Desc, Dal Desc, Nome"
    End If
    DsOrdinanze.Tables("Ordinanze").Clear()
    daOrdinanze.Fill(DsOrdinanze.Tables("Ordinanze"))
    dgOrdinanze.DataBind()
  End Sub

  Private Sub pShowInsertPanel()
    pnlEditOrd.Visible = True
    pnlSearch.Visible = False
    pnlRisultati.Visible = False
    txtdeId.Visible = False
    txtdeIdVia.Visible = False
    txtDEFile.Visible = False
    txtDEExt.Visible = False
    txtDETesto.Visible = True
  End Sub

  Private Sub pEnableItems(ByVal b As Boolean)
    txtdeId.Enabled = b
    txtdeIdVia.Enabled = b
    txtDETitle.Enabled = b
    txtDEOrdinanza.Enabled = b
    txtDETesto.Enabled = b
    txtDEDal.Enabled = b
    txtDEAl.Enabled = b
    btnDelete.Enabled = b
    OrdFile.Visible = b
    cboDETipo.Enabled = b
    btnSave.Visible = b
  End Sub

  Private Sub dgOrdinanze_ItemCreated(ByVal Sender As Object, ByVal e As DataGridItemEventArgs) Handles dgOrdinanze.ItemCreated
    Select Case e.Item.ItemType
      Case ListItemType.Item, ListItemType.AlternatingItem, ListItemType.EditItem
        Dim myDeleteButton As LinkButton
        myDeleteButton = e.Item.FindControl("Linkbutton2")
        myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi eliminare questa ordinanza?');")
    End Select
  End Sub

  Private Sub pCheckParent(ByVal id As Integer, Optional ByVal idOrdinanza As Integer = -1)
    Dim com As New SqlCommand(pSelectParent, con)
    Dim dr As SqlDataReader
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dr = com.ExecuteReader
    dr.Read()
    If (idOrdinanza <= 0 And Not dr.HasRows) Then
      cboDETipo.SelectedValue = 1
      cboDETipo.Enabled = False
    ElseIf (idOrdinanza > 0 And dr.Item("Id") = idOrdinanza) Then
      cboDETipo.SelectedValue = 1
      cboDETipo.Enabled = False
    End If

    'If (idOrdinanza > 0 And dr.Item("Id") = idOrdinanza) Or (idOrdinanza <= 0 And Not dr.HasRows) Then
    '  cboDETipo.SelectedValue = 1
    '  cboDETipo.Enabled = False
    'End If
    con.Close()
  End Sub

  Private Sub pBuildWhere()
    Where = ""
    If txtVia.Text.Length > 0 Then
      Where &= "Nome Like '%" & txtVia.Text.Replace("'", "''") & "%'"
    End If
    If txtOrdinanza.Text.Length > 0 Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "Ordinanza = '" & txtOrdinanza.Text.Replace("'", "''") & "'"
    End If
  End Sub

End Class
