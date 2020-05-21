Imports System.Data.SqlClient

Public Class wf_editviezone
  Inherits System.Web.UI.Page

  Private oUtente As Utente

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daStradario = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsStradario1 = New ATCBussm1.dsStradario
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsStradario1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daStradario
    '
    Me.daStradario.DeleteCommand = Me.SqlCommand2
    Me.daStradario.InsertCommand = Me.SqlInsertCommand1
    Me.daStradario.SelectCommand = Me.SqlSelectCommand1
    Me.daStradario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "StradarioBologna", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_prov", "cod_prov"), New System.Data.Common.DataColumnMapping("cod_comune", "cod_comune"), New System.Data.Common.DataColumnMapping("Codice", "Codice"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("SettoreZona", "SettoreZona"), New System.Data.Common.DataColumnMapping("Guid", "Guid")})})
    Me.daStradario.UpdateCommand = Me.SqlCommand1
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.StradarioBologna (cod_prov, cod_comune, Codice, Nome, SettoreZona" & _
    ", Guid) VALUES (37, 6, @Codice, @Nome, NULL, @Guid)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.Int, 4, "Codice"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 255, "Nome"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier, 4, "Guid"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Codice, Nome, SettoreZona, Guid FROM dbo.StradarioBologna WHERE (Nome LIKE" & _
    " '%' + @Nome + '%') AND (cod_prov = 37) AND (cod_comune = 6) ORDER BY Nome"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 255, "Nome"))
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.StradarioBologna SET Codice = @Codice, Nome = @Nome WHERE (Guid = @Gui" & _
    "d)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.Int, 4, "Codice"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 255, "Nome"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Guid", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsStradario1
    '
    Me.DsStradario1.DataSetName = "dsStradario"
    Me.DsStradario1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.StradarioBologna WHERE (Guid = @Guid)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Guid", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsStradario1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daStradario As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsStradario1 As ATCBussm1.dsStradario
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents txtVia As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
  Protected WithEvents lblNoVie As System.Web.UI.WebControls.Label
  Protected WithEvents btnAddVia As System.Web.UI.WebControls.Button
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgStradario As System.Web.UI.WebControls.DataGrid
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsSommario As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand

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
    oUtente = Session("User")
    daStradario.SelectCommand.Parameters("@Nome").Value = txtVia.Text
    daStradario.Fill(DsStradario1, "StradarioBologna")

    lblNoVie.Visible = DsStradario1.Tables("StradarioBologna").Rows.Count <= 0
    dgStradario.Visible = DsStradario1.Tables("StradarioBologna").Rows.Count > 0

    If Not IsPostBack Then Page.DataBind()
  End Sub

  Private Sub btnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerca.Click
    DsStradario1.Tables(dgStradario.DataMember).Clear()
    daStradario.SelectCommand.Parameters("@Nome").Value = txtVia.Text
    daStradario.Fill(DsStradario1, "StradarioBologna")
    dgStradario.CurrentPageIndex = 0
    dgStradario.DataBind()
  End Sub

  Private Sub dgStradario_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgStradario.PageIndexChanged
    dgStradario.CurrentPageIndex = e.NewPageIndex
    dgStradario.DataBind()
  End Sub

  Private Sub dgStradario_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStradario.EditCommand
    btnCerca.Enabled = False
    btnAddVia.Enabled = False
    dgStradario.EditItemIndex = e.Item.ItemIndex
    dgStradario.DataBind()
  End Sub

  Private Sub dgStradario_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStradario.CancelCommand
    dgStradario.EditItemIndex = -1
    dgStradario.DataBind()
    btnCerca.Enabled = True
    btnAddVia.Enabled = True
    lblNoVie.Visible = DsStradario1.Tables("StradarioBologna").Rows.Count <= 0
    dgStradario.Visible = DsStradario1.Tables("StradarioBologna").Rows.Count > 0
  End Sub

  Private Sub dgStradario_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStradario.UpdateCommand
    If Me.IsValid Then
      Dim dr As DataRow
      dr = DsStradario1.Tables(dgStradario.DataMember).Rows.Find(dgStradario.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsStradario1.Tables(dgStradario.DataMember).NewRow
        dr.Item("Guid") = Guid.NewGuid
        DsStradario1.Tables(dgStradario.DataMember).Rows.Add(dr)
      End If
      dr.Item("Codice") = DirectCast(e.Item.Cells(1).FindControl("txtCodice"), TextBox).Text
      dr.Item("Nome") = DirectCast(e.Item.Cells(2).FindControl("txtNome"), TextBox).Text
      daStradario.Update(DsStradario1, dgStradario.DataMember)
      DsStradario1.Tables(dgStradario.DataMember).Clear()
      daStradario.SelectCommand.Parameters("@Nome").Value = txtVia.Text
      daStradario.Fill(DsStradario1, "StradarioBologna")
      dgStradario.EditItemIndex = -1
      dgStradario.DataBind()
      dgStradario_CancelCommand(source, e)
    End If
  End Sub

  Private Sub btnAddVia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVia.Click
    Dim dr As DataRow
    lblNoVie.Visible = False
    dgStradario.Visible = True
    dr = DsStradario1.Tables(dgStradario.DataMember).NewRow
    dr.Item("Guid") = Guid.NewGuid
    DsStradario1.Tables(dgStradario.DataMember).Rows.InsertAt(dr, 0)
    btnCerca.Enabled = False
    btnAddVia.Enabled = False
    dgStradario.EditItemIndex = 0
    dgStradario.CurrentPageIndex = 0
    dgStradario.DataBind()
  End Sub

  Public Sub cvCodiceUnivoco_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    Dim com As New SqlClient.SqlCommand("Select Guid From StradarioBologna Where Cod_Prov = @Cod_Prov And Cod_Comune = @Cod_Comune And Codice = @Codice", con)
    Dim pGuid As Guid
    com.Parameters.Add("@Cod_Prov", SqlDbType.Int).Value = 37
    com.Parameters.Add("@Cod_Comune", SqlDbType.Int).Value = 6
    com.Parameters.Add("@Codice", SqlDbType.Int).Value = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl(DirectCast(source, CustomValidator).ControlToValidate), TextBox).Text
    con.Open()
    pGuid = com.ExecuteScalar
    If pGuid.ToString <> "00000000-0000-0000-0000-000000000000" Then
      args.IsValid = pGuid.Equals(dgStradario.DataKeys(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).ItemIndex))
    Else
      args.IsValid = True
    End If
    con.Close()
  End Sub

  Private Sub dgStradario_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgStradario.DeleteCommand
    Dim dr As DataRow
    dr = DsStradario1.Tables(dgStradario.DataMember).Rows.Find(dgStradario.DataKeys(e.Item.ItemIndex))
    If Not dr Is Nothing Then
      dr.Delete()
      daStradario.Update(DsStradario1, dgStradario.DataMember)
    End If
    DsStradario1.Tables(dgStradario.DataMember).Clear()
    daStradario.SelectCommand.Parameters("@Nome").Value = txtVia.Text
    daStradario.Fill(DsStradario1, "StradarioBologna")
    dgStradario.CurrentPageIndex = 0
    dgStradario.EditItemIndex = -1
    dgStradario.DataBind()
    dgStradario_CancelCommand(source, e)
  End Sub

  Private Sub dgStradario_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgStradario.ItemCreated
    If Not e.Item.FindControl("lnkElimina") Is Nothing Then DirectCast(e.Item.FindControl("lnkElimina"), LinkButton).Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi eliminare questa via?');")
  End Sub
End Class
