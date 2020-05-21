Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class wf_CSConsumiAz
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaConsumi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.DaCS_Centri = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DaCS_Gruppi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DaCS_Consumi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsConsumi = New ATCBussm1.DsConsumi
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    CType(Me.DsConsumi, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaConsumi
    '
    Me.DaConsumi.SelectCommand = Me.SqlSelectCommand4
    Me.DaConsumi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Consumi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdCentroCCS", "IdCentroCCS"), New System.Data.Common.DataColumnMapping("IdGruppoCCS", "IdGruppoCCS"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Valore", "Valore"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione"), New System.Data.Common.DataColumnMapping("CentroCS", "CentroCS"), New System.Data.Common.DataColumnMapping("GruppoCS", "GruppoCS"), New System.Data.Common.DataColumnMapping("OrdineC", "OrdineC"), New System.Data.Common.DataColumnMapping("OrdineG", "OrdineG")})})
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT dbo.CS_Consumi.Id, dbo.CS_Consumi.IdCentroCCS, dbo.CS_Consumi.IdGruppoCCS," & _
    " dbo.CS_Consumi.Data, dbo.CS_Consumi.Valore, dbo.CS_Consumi.DataCreazione, dbo.C" & _
    "S_Centri.CentroCS, dbo.CS_Gruppi.GruppoCS, dbo.CS_Centri.OrdineC, dbo.CS_Gruppi." & _
    "OrdineG FROM dbo.CS_Centri RIGHT OUTER JOIN dbo.CS_Consumi LEFT OUTER JOIN dbo.C" & _
    "S_Gruppi ON dbo.CS_Consumi.IdGruppoCCS = dbo.CS_Gruppi.IdGruppoCS ON dbo.CS_Cent" & _
    "ri.IdCentroCS = dbo.CS_Consumi.IdCentroCCS"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'DaCS_Centri
    '
    Me.DaCS_Centri.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaCS_Centri.InsertCommand = Me.SqlInsertCommand1
    Me.DaCS_Centri.SelectCommand = Me.SqlSelectCommand1
    Me.DaCS_Centri.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CS_Centri", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdCentroCS", "IdCentroCS"), New System.Data.Common.DataColumnMapping("CentroCS", "CentroCS"), New System.Data.Common.DataColumnMapping("OrdineC", "OrdineC")})})
    Me.DaCS_Centri.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.CS_Centri WHERE (IdCentroCS = @IdCentroCS)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCS", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.CS_Centri(IdCentroCS, CentroCS, OrdineC) VALUES (@IdCentroCS, @Ce" & _
    "ntroCS, @OrdineC); SELECT IdCentroCS, CentroCS, OrdineC FROM dbo.CS_Centri WHERE" & _
    " (IdCentroCS = @IdCentroCS) ORDER BY OrdineC"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdCentroCS"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CentroCS", System.Data.SqlDbType.VarChar, 200, "CentroCS"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineC", System.Data.SqlDbType.Int, 4, "OrdineC"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdCentroCS, CentroCS, OrdineC FROM dbo.CS_Centri ORDER BY OrdineC"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.CS_Centri SET IdCentroCS = @IdCentroCS, CentroCS = @CentroCS, OrdineC " & _
    "= @OrdineC WHERE (IdCentroCS = @Original_IdCentroCS) AND (CentroCS = @Original_C" & _
    "entroCS OR @Original_CentroCS IS NULL AND CentroCS IS NULL) AND (OrdineC = @Orig" & _
    "inal_OrdineC OR @Original_OrdineC IS NULL AND OrdineC IS NULL); SELECT IdCentroC" & _
    "S, CentroCS, OrdineC FROM dbo.CS_Centri WHERE (IdCentroCS = @IdCentroCS) ORDER B" & _
    "Y OrdineC"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdCentroCS"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CentroCS", System.Data.SqlDbType.VarChar, 200, "CentroCS"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineC", System.Data.SqlDbType.Int, 4, "OrdineC"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CentroCS", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CentroCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrdineC", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrdineC", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaCS_Gruppi
    '
    Me.DaCS_Gruppi.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaCS_Gruppi.InsertCommand = Me.SqlInsertCommand2
    Me.DaCS_Gruppi.SelectCommand = Me.SqlSelectCommand2
    Me.DaCS_Gruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CS_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdGruppoCS", "IdGruppoCS"), New System.Data.Common.DataColumnMapping("GruppoCS", "GruppoCS"), New System.Data.Common.DataColumnMapping("OrdineG", "OrdineG")})})
    Me.DaCS_Gruppi.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.CS_Gruppi WHERE (IdGruppoCS = @IdGruppoCS)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdGruppoCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdGruppoCS", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.CS_Gruppi(IdGruppoCS, GruppoCS, OrdineG) VALUES (@IdGruppoCS, @Gr" & _
    "uppoCS, @OrdineG); SELECT IdGruppoCS, GruppoCS, OrdineG FROM dbo.CS_Gruppi WHERE" & _
    " (IdGruppoCS = @IdGruppoCS) ORDER BY OrdineG"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdGruppoCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdGruppoCS"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GruppoCS", System.Data.SqlDbType.VarChar, 100, "GruppoCS"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineG", System.Data.SqlDbType.Int, 4, "OrdineG"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdGruppoCS, GruppoCS, OrdineG FROM dbo.CS_Gruppi ORDER BY OrdineG"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.CS_Gruppi SET IdGruppoCS = @IdGruppoCS, GruppoCS = @GruppoCS, OrdineG " & _
    "= @OrdineG WHERE (IdGruppoCS = @Original_IdGruppoCS) AND (GruppoCS = @Original_G" & _
    "ruppoCS OR @Original_GruppoCS IS NULL AND GruppoCS IS NULL) AND (OrdineG = @Orig" & _
    "inal_OrdineG OR @Original_OrdineG IS NULL AND OrdineG IS NULL); SELECT IdGruppoC" & _
    "S, GruppoCS, OrdineG FROM dbo.CS_Gruppi WHERE (IdGruppoCS = @IdGruppoCS) ORDER B" & _
    "Y OrdineG"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdGruppoCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdGruppoCS"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GruppoCS", System.Data.SqlDbType.VarChar, 100, "GruppoCS"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrdineG", System.Data.SqlDbType.Int, 4, "OrdineG"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdGruppoCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdGruppoCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GruppoCS", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GruppoCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrdineG", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrdineG", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaCS_Consumi
    '
    Me.DaCS_Consumi.DeleteCommand = Me.SqlDeleteCommand3
    Me.DaCS_Consumi.InsertCommand = Me.SqlInsertCommand3
    Me.DaCS_Consumi.SelectCommand = Me.SqlSelectCommand3
    Me.DaCS_Consumi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CS_Consumi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdCentroCCS", "IdCentroCCS"), New System.Data.Common.DataColumnMapping("IdGruppoCCS", "IdGruppoCCS"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Valore", "Valore"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione")})})
    Me.DaCS_Consumi.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.CS_Consumi WHERE (Id = @Id)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.CS_Consumi(Id, IdCentroCCS, IdGruppoCCS, Data, Valore, DataCreazi" & _
    "one) VALUES (@Id, @IdCentroCCS, @IdGruppoCCS, @Data, @Valore, @DataCreazione); S" & _
    "ELECT Id, IdCentroCCS, IdGruppoCCS, Data, Valore, DataCreazione FROM dbo.CS_Cons" & _
    "umi WHERE (Id = @Id)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdCentroCCS"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdGruppoCCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdGruppoCCS"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Valore", System.Data.SqlDbType.Float, 8, "Valore"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT Id, IdCentroCCS, IdGruppoCCS, Data, Valore, DataCreazione FROM dbo.CS_Cons" & _
    "umi"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.CS_Consumi SET Id = @Id, IdCentroCCS = @IdCentroCCS, IdGruppoCCS = @Id" & _
    "GruppoCCS, Data = @Data, Valore = @Valore, DataCreazione = @DataCreazione WHERE " & _
    "(Id = @Original_Id) AND (Data = @Original_Data OR @Original_Data IS NULL AND Dat" & _
    "a IS NULL) AND (DataCreazione = @Original_DataCreazione OR @Original_DataCreazio" & _
    "ne IS NULL AND DataCreazione IS NULL) AND (IdCentroCCS = @Original_IdCentroCCS O" & _
    "R @Original_IdCentroCCS IS NULL AND IdCentroCCS IS NULL) AND (IdGruppoCCS = @Ori" & _
    "ginal_IdGruppoCCS OR @Original_IdGruppoCCS IS NULL AND IdGruppoCCS IS NULL) AND " & _
    "(Valore = @Original_Valore OR @Original_Valore IS NULL AND Valore IS NULL); SELE" & _
    "CT Id, IdCentroCCS, IdGruppoCCS, Data, Valore, DataCreazione FROM dbo.CS_Consumi" & _
    " WHERE (Id = @Id)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdCentroCCS"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdGruppoCCS", System.Data.SqlDbType.UniqueIdentifier, 16, "IdGruppoCCS"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Valore", System.Data.SqlDbType.Float, 8, "Valore"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdGruppoCCS", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdGruppoCCS", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Valore", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Valore", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsConsumi
    '
    Me.DsConsumi.DataSetName = "DsConsumi"
    Me.DsConsumi.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=SRVZAMBONIN;packet size=4096;user id=usrBussm;data source=zion;per" & _
    "sist security info=False;initial catalog=atcbussm"
    CType(Me.DsConsumi, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents pnlConsumi As System.Web.UI.WebControls.Panel
  Protected WithEvents DaConsumi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dgConsumiCS As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents LblCentroC As System.Web.UI.WebControls.Label
  Protected WithEvents cboCentro As System.Web.UI.WebControls.DropDownList
  Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
  Protected WithEvents DaCS_Centri As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DaCS_Gruppi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DaCS_Consumi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsConsumi As ATCBussm1.DsConsumi
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents LblGruppoA As System.Web.UI.WebControls.Label
  Protected WithEvents CboGruppoA As System.Web.UI.WebControls.DropDownList
  Protected WithEvents LblGruppo As System.Web.UI.WebControls.Label
  Protected WithEvents cboGruppo As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents txtMeseAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents DgCentri As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LnkCentro As System.Web.UI.WebControls.LinkButton
  Protected WithEvents LnkDelGruppo As System.Web.UI.WebControls.LinkButton
  Protected WithEvents LnkGruppo As System.Web.UI.WebControls.LinkButton
  Protected WithEvents LnkAggCentro As System.Web.UI.WebControls.LinkButton
  Protected WithEvents DgGruppi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LnkAggGruppo As System.Web.UI.WebControls.LinkButton
  Protected WithEvents PnlGruppi As System.Web.UI.WebControls.Panel
  Protected WithEvents PnlCentri As System.Web.UI.WebControls.Panel
  Protected WithEvents VSConsumiAz As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection

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
    'Put user code to initialize the page here
    If Not IsPostBack Then
      ' ----------------------------------------------------------------------------
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      DaCS_Centri.Fill(DsConsumi, "CS_Centri")
      DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
      cboCentro.DataBind()
      cboCentro.Items.Insert(0, pUnspecified)
      cboGruppo.DataBind()
      cboGruppo.Items.Insert(0, pUnspecified)
      txtMeseAnno.Text = Format(Now, "MM/yyyy")
    End If

  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    Ricerca()

  End Sub

  Private Sub pBuildWhere()

    Where = ""
    If txtMeseAnno.Text.Trim <> "" Then
      Where &= " Month(CS_Consumi.Data)=" & Month(txtMeseAnno.Text.Trim) & " and "
      Where &= " Year(CS_Consumi.Data)=" & Year(txtMeseAnno.Text.Trim)
    End If
    If cboGruppo.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "CS_Consumi.IdGruppoCCS = '" & cboGruppo.SelectedValue & "' "
    End If
    If cboCentro.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "CS_Consumi.IdCentroCCS = '" & cboCentro.SelectedValue & "' "
    End If
    If Where.Length > 0 Then Where = " WHERE " & Where
    Where &= " ORDER BY CS_Consumi.Data , CS_Gruppi.OrdineG, CS_Centri.OrdineC "

  End Sub

  Private Sub Ricerca()

    pBuildWhere()
    If Where.Length > 0 And DaConsumi.SelectCommand.CommandText.IndexOf("WHERE") < 0 Then
      DaConsumi.SelectCommand.CommandText &= Where
    End If

    DsConsumi.Tables("Consumi").Clear()
    DaConsumi.Fill(DsConsumi, "Consumi")

    dgConsumiCS.CurrentPageIndex = 0
    dgConsumiCS.DataBind()
    pnlConsumi.Visible = True
    PnlGruppi.Visible = False
    PnlCentri.Visible = False

  End Sub

  ' ------------------- GRIGLIA CONSUMI ---------------------- 

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgConsumiCS.EditItemIndex = e.Item.ItemIndex
    Ricerca()
    DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
    DirectCast(dgConsumiCS.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).DataBind()
    DaCS_Centri.Fill(DsConsumi, "CS_Centri")
    DirectCast(dgConsumiCS.Items(e.Item.ItemIndex).Cells(3).Controls(1), DropDownList).DataBind()

    If e.Item.Cells(5).Text <> "&nbsp;" Then
      DirectCast(dgConsumiCS.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).SelectedValue = e.Item.Cells(5).Text
    End If

    If e.Item.Cells(4).Text <> "&nbsp;" Then
      DirectCast(dgConsumiCS.Items(e.Item.ItemIndex).Cells(3).Controls(1), DropDownList).SelectedValue = e.Item.Cells(4).Text
    End If

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaCS_Consumi.Fill(DsConsumi, "CS_Consumi")
    drF = DsConsumi.Tables("CS_Consumi").Rows.Find(dgConsumiCS.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaCS_Consumi.Update(DsConsumi, "CS_Consumi")
    End If

    dgConsumiCS.EditItemIndex = -1

    Ricerca()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa riga di consumo aziendale?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgConsumiCS.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim StrData As String
    Dim DValore As Double
    Dim g As Guid

    Me.Validate()
    If Me.IsValid Then

      StrData = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      DValore = CDbl(IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text))

      DaCS_Consumi.Fill(DsConsumi, "CS_Consumi")
      drF = DsConsumi.Tables("CS_Consumi").Rows.Find(dgConsumiCS.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsConsumi.Tables("CS_Consumi").NewRow
        drF.Item("Id") = dgConsumiCS.DataKeys(e.Item.ItemIndex)
        DsConsumi.Tables("CS_Consumi").Rows.Add(drF)
      End If

      drF.Item("Data") = StrData
      g = New Guid(DirectCast(e.Item.Cells(3).Controls(1), DropDownList).SelectedValue)
      drF.Item("IdCentroCCS") = g
      g = New Guid(DirectCast(e.Item.Cells(2).Controls(1), DropDownList).SelectedValue)
      drF.Item("IdGruppoCCS") = g
      drF.Item("Valore") = DValore

      DaCS_Consumi.Update(DsConsumi, "CS_Consumi")

      dgConsumiCS.EditItemIndex = -1
      Ricerca()
    End If

  End Sub

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow
    Ricerca()
    dr = DsConsumi.Tables("Consumi").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = IIf(txtMeseAnno.Text.Trim = "", Format(Now, "dd/MM/yyyy"), "01/" & txtMeseAnno.Text.Trim)
    dr.Item("DataCreazione") = Now
    DsConsumi.Tables("Consumi").Rows.InsertAt(dr, 0)
    dgConsumiCS.EditItemIndex = 0

    dgConsumiCS.DataBind()


    DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
    DirectCast(dgConsumiCS.Items(dgConsumiCS.EditItemIndex).Cells(2).Controls(1), DropDownList).DataBind()
    DaCS_Centri.Fill(DsConsumi, "CS_Centri")
    DirectCast(dgConsumiCS.Items(dgConsumiCS.EditItemIndex).Cells(3).Controls(1), DropDownList).DataBind()


  End Sub

  ' ------------------- FINE GRIGLIA CONSUMI --------------------- 

  ' ------------------- GRIGLIA CENTRI CONSUMO ------------------- 

  Private Sub RicercaCentri()

    DsConsumi.Tables("CS_Centri").Clear()
    DaCS_Centri.Fill(DsConsumi, "CS_Centri")

    DgCentri.CurrentPageIndex = 0
    DgCentri.DataBind()


  End Sub

  Public Sub pDGDeleteCentro(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaCS_Centri.Fill(DsConsumi, "CS_Centri")
    drF = DsConsumi.Tables("CS_Centri").Rows.Find(DgCentri.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaCS_Centri.Update(DsConsumi, "CS_Centri")
    End If
    DgCentri.EditItemIndex = -1
    RicercaCentri()

  End Sub

  Public Sub pItemCreatedCentro(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelCentro")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo centro?');")
    End If

  End Sub

  Public Sub pDGEditCentro(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgCentri.EditItemIndex = e.Item.ItemIndex
    RicercaCentri()

  End Sub

  Public Sub pDGUpdateCentro(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim StrCentro As String
    Dim IOrdineC As Integer
    Me.Validate()
    If Me.IsValid Then

      StrCentro = DirectCast(e.Item.Cells(1).Controls(0), TextBox).Text.Trim
      IOrdineC = CInt(IIf(DirectCast(e.Item.Cells(2).Controls(0), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(0), TextBox).Text))

      DaCS_Centri.Fill(DsConsumi, "CS_Centri")
      drF = DsConsumi.Tables("CS_Centri").Rows.Find(DgCentri.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsConsumi.Tables("CS_Centri").NewRow
        drF.Item("IdCentroCS") = DgCentri.DataKeys(e.Item.ItemIndex)
        DsConsumi.Tables("CS_Centri").Rows.Add(drF)
      End If

      drF.Item("CentroCS") = StrCentro
      drF.Item("OrdineC") = IOrdineC

      DaCS_Centri.Update(DsConsumi, "CS_Centri")

      DgCentri.EditItemIndex = -1
      RicercaCentri()

    End If

  End Sub

  Public Sub pDGCancelCentro(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgCentri.EditItemIndex = -1
    RicercaCentri()

  End Sub

  Private Sub LnkCentro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkCentro.Click

    RicercaCentri()
    PnlGruppi.Visible = False
    PnlCentri.Visible = True
    pnlConsumi.Visible = False

  End Sub

  Private Sub LnkAggCentro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkAggCentro.Click

    Dim dr As Data.DataRow
    DaCS_Centri.Fill(DsConsumi, "CS_Centri")
    dr = DsConsumi.Tables("CS_Centri").NewRow
    dr.Item("IdCentroCS") = Guid.NewGuid
    DsConsumi.Tables("CS_Centri").Rows.InsertAt(dr, 0)

    DgCentri.EditItemIndex = 0
    DgCentri.DataBind()


  End Sub

  ' ------------------- FINE GRIGLIA CENTRI CONSUMO ------------------- 

  ' ------------------- GRIGLIA GRUPPI CONSUMO ------------------- 

  Private Sub RicercaGruppi()

    DsConsumi.Tables("CS_Gruppi").Clear()
    DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")

    DgGruppi.CurrentPageIndex = 0
    DgGruppi.DataBind()

  End Sub


  Public Sub pDGDeleteGruppo(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
    Dim drF As DataRow

    DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
    drF = DsConsumi.Tables("CS_Gruppi").Rows.Find(DgGruppi.DataKeys(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaCS_Gruppi.Update(DsConsumi, "CS_Gruppi")
    End If
    DgGruppi.EditItemIndex = -1
    RicercaGruppi()

  End Sub

  Public Sub pItemCreatedGruppo(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelGruppo")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo gruppo?');")
    End If

  End Sub

  Public Sub pDGEditGruppo(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgGruppi.EditItemIndex = e.Item.ItemIndex
    RicercaGruppi()

  End Sub

  Public Sub pDGUpdateGruppo(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow
    Dim StrGruppo As String
    Dim IOrdineG As Integer
    Me.Validate()
    If Me.IsValid Then

      StrGruppo = DirectCast(e.Item.Cells(1).Controls(0), TextBox).Text.Trim
      IOrdineG = CInt(IIf(DirectCast(e.Item.Cells(2).Controls(0), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(0), TextBox).Text))

      DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
      drF = DsConsumi.Tables("CS_Gruppi").Rows.Find(DgGruppi.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsConsumi.Tables("CS_Gruppi").NewRow
        drF.Item("IdGruppoCS") = DgGruppi.DataKeys(e.Item.ItemIndex)
        DsConsumi.Tables("CS_Gruppi").Rows.Add(drF)
      End If

      drF.Item("GruppoCS") = StrGruppo
      drF.Item("OrdineG") = IOrdineG

      DaCS_Gruppi.Update(DsConsumi, "CS_Gruppi")

      DgGruppi.EditItemIndex = -1
      RicercaGruppi()
    End If

  End Sub

  Public Sub pDGCancelGruppo(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgGruppi.EditItemIndex = -1
    RicercaGruppi()

  End Sub

  Private Sub LnkGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkGruppo.Click

    RicercaGruppi()
    PnlGruppi.Visible = True
    PnlCentri.Visible = False
    pnlConsumi.Visible = False

  End Sub

  Private Sub LnkAggGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkAggGruppo.Click


    Dim dr As Data.DataRow
    DaCS_Gruppi.Fill(DsConsumi, "CS_Gruppi")
    dr = DsConsumi.Tables("CS_Gruppi").NewRow
    dr.Item("IdGruppoCS") = Guid.NewGuid
    DsConsumi.Tables("CS_Gruppi").Rows.InsertAt(dr, 0)
    DgGruppi.EditItemIndex = 0
    DgGruppi.DataBind()


  End Sub

  ' ------------------- FINE GRIGLIA GRUPPI CONSUMO ------------------- 
  Private Sub dgConsumiCS_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgConsumiCS.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub dgConsumiCS_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgConsumiCS.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub dgConsumiCS_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgConsumiCS.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub dgConsumiCS_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgConsumiCS.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub dgConsumiCS_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgConsumiCS.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub

  Private Sub DgCentri_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgCentri.CancelCommand
    pDGCancelCentro(source, e)
  End Sub

  Private Sub DgCentri_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgCentri.DeleteCommand
    pDGDeleteCentro(source, e)
  End Sub

  Private Sub DgCentri_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgCentri.EditCommand
    pDGEditCentro(source, e)
  End Sub

  Private Sub DgCentri_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgCentri.ItemCreated
    pItemCreatedCentro(sender, e)
  End Sub

  Private Sub DgCentri_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgCentri.UpdateCommand
    pDGUpdateCentro(source, e)
  End Sub

  Private Sub DgGruppi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgGruppi.CancelCommand
    pDGCancelGruppo(source, e)
  End Sub

  Private Sub DgGruppi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgGruppi.DeleteCommand
    pDGDeleteGruppo(source, e)
  End Sub

  Private Sub DgGruppi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgGruppi.EditCommand
    pDGEditGruppo(source, e)
  End Sub

  Private Sub DgGruppi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgGruppi.ItemCreated
    pItemCreatedGruppo(sender, e)
  End Sub

  Private Sub DgGruppi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgGruppi.UpdateCommand
    pDGUpdateGruppo(source, e)
  End Sub
End Class
