Public Class wf_Parcheggi
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaParcheggi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsParcheggi = New ATCBussm1.DsParcheggi
    CType(Me.DsParcheggi, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaParcheggi
    '
    Me.DaParcheggi.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaParcheggi.InsertCommand = Me.SqlInsertCommand1
    Me.DaParcheggi.SelectCommand = Me.SqlSelectCommand1
    Me.DaParcheggi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Parcheggi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Posti", "Posti"), New System.Data.Common.DataColumnMapping("PercOccup", "PercOccup"), New System.Data.Common.DataColumnMapping("ConnPNV", "ConnPNV"), New System.Data.Common.DataColumnMapping("Autom", "Autom"), New System.Data.Common.DataColumnMapping("Note", "Note")})})
    Me.DaParcheggi.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Parcheggi WHERE (Id = @Original_Id) AND (Autom = @Original_Autom " & _
    "OR @Original_Autom IS NULL AND Autom IS NULL) AND (ConnPNV = @Original_ConnPNV O" & _
    "R @Original_ConnPNV IS NULL AND ConnPNV IS NULL) AND (Nome = @Original_Nome OR @" & _
    "Original_Nome IS NULL AND Nome IS NULL) AND (PercOccup = @Original_PercOccup OR " & _
    "@Original_PercOccup IS NULL AND PercOccup IS NULL) AND (Posti = @Original_Posti " & _
    "OR @Original_Posti IS NULL AND Posti IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Autom", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Autom", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConnPNV", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConnPNV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PercOccup", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercOccup", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Posti", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Posti", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Parcheggi(Id, Nome, Posti, PercOccup, ConnPNV, Autom, Note) VALUE" & _
    "S (@Id, @Nome, @Posti, @PercOccup, @ConnPNV, @Autom, @Note); SELECT Id, Nome, Po" & _
    "sti, PercOccup, ConnPNV, Autom, Note FROM dbo.Parcheggi WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 50, "Nome"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Posti", System.Data.SqlDbType.Int, 4, "Posti"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PercOccup", System.Data.SqlDbType.Float, 8, "PercOccup"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConnPNV", System.Data.SqlDbType.Bit, 1, "ConnPNV"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Autom", System.Data.SqlDbType.Bit, 1, "Autom"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 1073741823, "Note"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Nome, Posti, PercOccup, ConnPNV, Autom, Note FROM dbo.Parcheggi"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Parcheggi SET Id = @Id, Nome = @Nome, Posti = @Posti, PercOccup = @Per" & _
    "cOccup, ConnPNV = @ConnPNV, Autom = @Autom, Note = @Note WHERE (Id = @Original_I" & _
    "d) AND (Autom = @Original_Autom OR @Original_Autom IS NULL AND Autom IS NULL) AN" & _
    "D (ConnPNV = @Original_ConnPNV OR @Original_ConnPNV IS NULL AND ConnPNV IS NULL)" & _
    " AND (Nome = @Original_Nome OR @Original_Nome IS NULL AND Nome IS NULL) AND (Per" & _
    "cOccup = @Original_PercOccup OR @Original_PercOccup IS NULL AND PercOccup IS NUL" & _
    "L) AND (Posti = @Original_Posti OR @Original_Posti IS NULL AND Posti IS NULL); S" & _
    "ELECT Id, Nome, Posti, PercOccup, ConnPNV, Autom, Note FROM dbo.Parcheggi WHERE " & _
    "(Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 50, "Nome"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Posti", System.Data.SqlDbType.Int, 4, "Posti"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PercOccup", System.Data.SqlDbType.Float, 8, "PercOccup"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConnPNV", System.Data.SqlDbType.Bit, 1, "ConnPNV"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Autom", System.Data.SqlDbType.Bit, 1, "Autom"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 1073741823, "Note"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Autom", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Autom", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConnPNV", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConnPNV", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nome", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nome", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PercOccup", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PercOccup", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Posti", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Posti", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsParcheggi
    '
    Me.DsParcheggi.DataSetName = "DsParcheggi"
    Me.DsParcheggi.Locale = New System.Globalization.CultureInfo("en-US")
    CType(Me.DsParcheggi, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaParcheggi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsParcheggi As ATCBussm1.DsParcheggi
  Protected WithEvents dgParcheggi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlParcheggi As System.Web.UI.WebControls.Panel
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents VSParcheggio As System.Web.UI.WebControls.ValidationSummary

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

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    If Not IsPostBack Then
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      Ricerca()
    End If

  End Sub

  Private Sub Ricerca()

    DsParcheggi.Tables("Parcheggi").Clear()
    DaParcheggi.Fill(DsParcheggi.Tables("Parcheggi"))

    dgParcheggi.CurrentPageIndex = 0
    dgParcheggi.DataBind()
    pnlParcheggi.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgParcheggi.EditItemIndex = e.Item.ItemIndex
    DaParcheggi.Fill(DsParcheggi.Tables("Parcheggi"))
    Ricerca()

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaParcheggi.Fill(DsParcheggi, "Parcheggi")
    drF = DsParcheggi.Tables("Parcheggi").Rows.Find(dgParcheggi.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaParcheggi.Update(DsParcheggi, "Parcheggi")
    End If

    dgParcheggi.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo parcheggio?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgParcheggi.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Me.Validate()
    If Me.IsValid Then
      DaParcheggi.Fill(DsParcheggi.Tables("Parcheggi"))
      drF = DsParcheggi.Tables("Parcheggi").Rows.Find(dgParcheggi.DataKeys(e.Item.ItemIndex))
      If drF Is Nothing Then
        drF = DsParcheggi.Tables("Parcheggi").NewRow
        drF.Item("Id") = dgParcheggi.DataKeys(e.Item.ItemIndex)
        DsParcheggi.Tables("Parcheggi").Rows.Add(drF)
      End If

      drF.Item("Nome") = IIf(DirectCast(e.Item.Cells(1).Controls(0), TextBox).Text.Trim = "", "", DirectCast(e.Item.Cells(1).Controls(0), TextBox).Text.Trim)
      drF.Item("Posti") = CInt(IIf(DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim))
      drF.Item("PercOccup") = CDbl(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      drF.Item("ConnPNV") = CBool(DirectCast(e.Item.Cells(4).Controls(1), DropDownList).SelectedValue)
      drF.Item("Autom") = CBool(DirectCast(e.Item.Cells(5).Controls(1), DropDownList).SelectedValue)
      drF.Item("Note") = IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", "", DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim)

      DaParcheggi.Update(DsParcheggi, "Parcheggi")

      Ricerca()
      dgParcheggi.EditItemIndex = -1
      dgParcheggi.DataBind()
    End If

  End Sub

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow
    Ricerca()
    'DaParcheggi.Fill(DsParcheggi, "Parcheggi")
    dr = DsParcheggi.Tables("Parcheggi").NewRow
    dr.Item("Id") = Guid.NewGuid
    DsParcheggi.Tables("Parcheggi").Rows.InsertAt(dr, 0)

    dgParcheggi.EditItemIndex = 0
    dgParcheggi.DataBind()

  End Sub

  Public Sub CVPosti_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)

    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)

  End Sub

  Public Sub CVPercOcc_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)

    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)

  End Sub

  Private Sub dgParcheggi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParcheggi.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub dgParcheggi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParcheggi.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub dgParcheggi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParcheggi.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub dgParcheggi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgParcheggi.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub dgParcheggi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParcheggi.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub
End Class
