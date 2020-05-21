Public Class wfTitoliSosta
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaDivisioneZona = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DaTitoliSosta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsTitoliSosta = New ATCBussm1.DsTitoliSosta
    Me.DaTitoliSostaD = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsTitoliSosta, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaDivisioneZona
    '
    Me.DaDivisioneZona.SelectCommand = Me.SqlSelectCommand1
    Me.DaDivisioneZona.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DivisioneZona", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Descrizione FROM dbo.DivisioneZona"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'DaTitoliSosta
    '
    Me.DaTitoliSosta.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaTitoliSosta.InsertCommand = Me.SqlInsertCommand1
    Me.DaTitoliSosta.SelectCommand = Me.SqlSelectCommand2
    Me.DaTitoliSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TitoliSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("CodiceTit", "CodiceTit"), New System.Data.Common.DataColumnMapping("Divisione", "Divisione")})})
    Me.DaTitoliSosta.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.TitoliSosta WHERE (Id = @Original_Id) AND (CodiceTit = @Original_" & _
    "CodiceTit OR @Original_CodiceTit IS NULL AND CodiceTit IS NULL) AND (Divisione =" & _
    " @Original_Divisione OR @Original_Divisione IS NULL AND Divisione IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceTit", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceTit", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Divisione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Divisione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.TitoliSosta(Id, CodiceTit, Divisione) VALUES (@Id, @CodiceTit, @D" & _
    "ivisione); SELECT Id, CodiceTit, Divisione FROM dbo.TitoliSosta WHERE (Id = @Id)" & _
    " ORDER BY CodiceTit"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceTit", System.Data.SqlDbType.VarChar, 50, "CodiceTit"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Divisione", System.Data.SqlDbType.Int, 4, "Divisione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id, CodiceTit, Divisione FROM dbo.TitoliSosta ORDER BY CodiceTit"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.TitoliSosta SET Id = @Id, CodiceTit = @CodiceTit, Divisione = @Divisio" & _
    "ne WHERE (Id = @Original_Id) AND (CodiceTit = @Original_CodiceTit OR @Original_C" & _
    "odiceTit IS NULL AND CodiceTit IS NULL) AND (Divisione = @Original_Divisione OR " & _
    "@Original_Divisione IS NULL AND Divisione IS NULL); SELECT Id, CodiceTit, Divisi" & _
    "one FROM dbo.TitoliSosta WHERE (Id = @Id) ORDER BY CodiceTit"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodiceTit", System.Data.SqlDbType.VarChar, 50, "CodiceTit"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Divisione", System.Data.SqlDbType.Int, 4, "Divisione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodiceTit", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodiceTit", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Divisione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Divisione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsTitoliSosta
    '
    Me.DsTitoliSosta.DataSetName = "DsTitoliSosta"
    Me.DsTitoliSosta.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'DaTitoliSostaD
    '
    Me.DaTitoliSostaD.ContinueUpdateOnError = True
    Me.DaTitoliSostaD.SelectCommand = Me.SqlSelectCommand3
    Me.DaTitoliSostaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TitoliSostaD", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("CodiceTit", "CodiceTit"), New System.Data.Common.DataColumnMapping("Divisione", "Divisione"), New System.Data.Common.DataColumnMapping("DescrizioneDiv", "DescrizioneDiv")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT dbo.TitoliSosta.Id, dbo.TitoliSosta.CodiceTit, dbo.TitoliSosta.Divisione, " & _
    "dbo.DivisioneZona.Descrizione AS DescrizioneDiv FROM dbo.TitoliSosta INNER JOIN " & _
    "dbo.DivisioneZona ON dbo.TitoliSosta.Divisione = dbo.DivisioneZona.Id ORDER BY d" & _
    "bo.TitoliSosta.CodiceTit"
    Me.SqlSelectCommand3.Connection = Me.con
    CType(Me.DsTitoliSosta, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents VSTitoliSosta As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaDivisioneZona As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaTitoliSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsTitoliSosta As ATCBussm1.DsTitoliSosta
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents dgTitoloSosta As System.Web.UI.WebControls.DataGrid
  Protected WithEvents pnlTitoloSosta As System.Web.UI.WebControls.Panel
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaTitoliSostaD As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand

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
      dgTitoloSosta.CurrentPageIndex = 0
    End If

  End Sub

  Private Sub Ricerca()


    DsTitoliSosta.Tables("TitoliSostaD").Clear()
    DaTitoliSostaD.Fill(DsTitoliSosta.Tables("TitoliSostaD"))
    DsTitoliSosta.Tables("TitoliSosta").Clear()
    DaTitoliSosta.Fill(DsTitoliSosta.Tables("TitoliSosta"))
    DsTitoliSosta.Tables("DivisioneZona").Clear()
    DaDivisioneZona.Fill(DsTitoliSosta.Tables("DivisioneZona"))


    dgTitoloSosta.DataBind()
    pnlTitoloSosta.Visible = True
    dgTitoloSosta.Visible = True

  End Sub

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow

    Ricerca()
    dgTitoloSosta.CurrentPageIndex = 0

    dr = DsTitoliSosta.Tables("TitoliSostaD").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("CodiceTit") = ""
    dr.Item("Divisione") = 1
    DsTitoliSosta.Tables("TitoliSostaD").Rows.InsertAt(dr, 0)
    dgTitoloSosta.EditItemIndex = 0

    dgTitoloSosta.DataBind()
    DaTitoliSosta.Fill(DsTitoliSosta, "TitoliSosta")

  End Sub

  Private Sub dgTitoloSosta_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgTitoloSosta.ItemCreated

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo mese?');")
    End If

  End Sub

  Private Sub dgTitoloSosta_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTitoloSosta.DeleteCommand
    Dim drF As DataRow

    DaTitoliSosta.Fill(DsTitoliSosta, "TitoliSosta")
    drF = DsTitoliSosta.Tables("TitoliSosta").Rows.Find(dgTitoloSosta.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaTitoliSosta.Update(DsTitoliSosta, "TitoliSosta")
    End If

    dgTitoloSosta.CurrentPageIndex = 0
    dgTitoloSosta.EditItemIndex = -1

    Ricerca()
  End Sub

  Private Sub dgTitoloSosta_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTitoloSosta.EditCommand
    'dgTitoloSosta.EditItemIndex = -1

    dgTitoloSosta.EditItemIndex = e.Item.ItemIndex
    DaTitoliSostaD.Fill(DsTitoliSosta.Tables("TitoliSostaD"))
    Ricerca()

    DirectCast(dgTitoloSosta.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).DataBind()
    If e.Item.Cells(1).Text <> "&nbsp;" Then
      DirectCast(dgTitoloSosta.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).SelectedValue = e.Item.Cells(3).Text
    End If


  End Sub

  Private Sub dgTitoloSosta_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTitoloSosta.CancelCommand

    dgTitoloSosta.EditItemIndex = -1
    Ricerca()

  End Sub

  Private Sub dgTitoloSosta_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgTitoloSosta.UpdateCommand

    Dim drF As Data.DataRow
    Me.Validate()
    If Me.IsValid Then


      DaTitoliSosta.Fill(DsTitoliSosta.Tables("TitoliSosta"))
      drF = DsTitoliSosta.Tables("TitoliSosta").Rows.Find(dgTitoloSosta.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsTitoliSosta.Tables("TitoliSosta").NewRow
        drF.Item("Id") = dgTitoloSosta.DataKeys(e.Item.ItemIndex)
        DsTitoliSosta.Tables("TitoliSosta").Rows.Add(drF)
      End If

      drF.Item("CodiceTit") = DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim
      drF.Item("Divisione") = DirectCast(e.Item.Cells(2).Controls(1), DropDownList).SelectedValue

      DaTitoliSosta.Update(DsTitoliSosta, "TitoliSosta")
      Ricerca()
      dgTitoloSosta.EditItemIndex = -1
      dgTitoloSosta.DataBind()

    End If

  End Sub

  Private Sub dgTitoloSosta_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgTitoloSosta.PageIndexChanged

    dgTitoloSosta.CurrentPageIndex = e.NewPageIndex
    Ricerca()
  End Sub
End Class
