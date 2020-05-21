Public Class wf_GiorniSpecialiPS
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaPSostaGiorni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsPSostaGSpeciali = New ATCBussm1.DsPSostaGSpeciali
    Me.DaPSostaEventoGG = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DaPSostaProvvGG = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DaPSostaGSpeciali = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsPSostaGSpeciali, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaPSostaGiorni
    '
    Me.DaPSostaGiorni.ContinueUpdateOnError = True
    Me.DaPSostaGiorni.SelectCommand = Me.SqlSelectCommand1
    Me.DaPSostaGiorni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PSostaGiorni", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("IdTipoEvento", "IdTipoEvento"), New System.Data.Common.DataColumnMapping("IdTipoProvv", "IdTipoProvv"), New System.Data.Common.DataColumnMapping("IdEvento", "IdEvento"), New System.Data.Common.DataColumnMapping("DescrEvento", "DescrEvento"), New System.Data.Common.DataColumnMapping("IdProvv", "IdProvv"), New System.Data.Common.DataColumnMapping("DescrProvv", "DescrProvv")})})
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT dbo.PSostaGSpeciali.Id, dbo.PSostaGSpeciali.Data, dbo.PSostaGSpeciali.IdTi" & _
    "poEvento, dbo.PSostaGSpeciali.IdTipoProvv, dbo.PSostaEventoGG.Id AS IdEvento, db" & _
    "o.PSostaEventoGG.Descrizione AS DescrEvento, dbo.PSostaProvvGG.Id AS IdProvv, db" & _
    "o.PSostaProvvGG.Descrizione AS DescrProvv FROM dbo.PSostaGSpeciali INNER JOIN db" & _
    "o.PSostaEventoGG ON dbo.PSostaGSpeciali.IdTipoEvento = dbo.PSostaEventoGG.Id INN" & _
    "ER JOIN dbo.PSostaProvvGG ON dbo.PSostaGSpeciali.IdTipoProvv = dbo.PSostaProvvGG" & _
    ".Id"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'DsPSostaGSpeciali
    '
    Me.DsPSostaGSpeciali.DataSetName = "DsPSostaGSpeciali"
    Me.DsPSostaGSpeciali.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DaPSostaEventoGG
    '
    Me.DaPSostaEventoGG.ContinueUpdateOnError = True
    Me.DaPSostaEventoGG.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaPSostaEventoGG.InsertCommand = Me.SqlInsertCommand2
    Me.DaPSostaEventoGG.SelectCommand = Me.SqlSelectCommand2
    Me.DaPSostaEventoGG.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PSostaEventoGG", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.DaPSostaEventoGG.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.PSostaEventoGG WHERE (Id = @Original_Id) AND (Descrizione = @Orig" & _
    "inal_Descrizione OR @Original_Descrizione IS NULL AND Descrizione IS NULL)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.PSostaEventoGG(Id, Descrizione) VALUES (@Id, @Descrizione); SELEC" & _
    "T Id, Descrizione FROM dbo.PSostaEventoGG WHERE (Id = @Id)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 200, "Descrizione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id, Descrizione FROM dbo.PSostaEventoGG"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.PSostaEventoGG SET Id = @Id, Descrizione = @Descrizione WHERE (Id = @O" & _
    "riginal_Id) AND (Descrizione = @Original_Descrizione OR @Original_Descrizione IS" & _
    " NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo.PSostaEventoGG W" & _
    "HERE (Id = @Id)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 200, "Descrizione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaPSostaProvvGG
    '
    Me.DaPSostaProvvGG.ContinueUpdateOnError = True
    Me.DaPSostaProvvGG.DeleteCommand = Me.SqlDeleteCommand3
    Me.DaPSostaProvvGG.InsertCommand = Me.SqlInsertCommand3
    Me.DaPSostaProvvGG.SelectCommand = Me.SqlSelectCommand3
    Me.DaPSostaProvvGG.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PSostaProvvGG", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.DaPSostaProvvGG.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.PSostaProvvGG WHERE (Id = @Original_Id) AND (Descrizione = @Origi" & _
    "nal_Descrizione OR @Original_Descrizione IS NULL AND Descrizione IS NULL)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.PSostaProvvGG(Id, Descrizione) VALUES (@Id, @Descrizione); SELECT" & _
    " Id, Descrizione FROM dbo.PSostaProvvGG WHERE (Id = @Id)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 100, "Descrizione"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT Id, Descrizione FROM dbo.PSostaProvvGG"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.PSostaProvvGG SET Id = @Id, Descrizione = @Descrizione WHERE (Id = @Or" & _
    "iginal_Id) AND (Descrizione = @Original_Descrizione OR @Original_Descrizione IS " & _
    "NULL AND Descrizione IS NULL); SELECT Id, Descrizione FROM dbo.PSostaProvvGG WHE" & _
    "RE (Id = @Id)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 100, "Descrizione"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaPSostaGSpeciali
    '
    Me.DaPSostaGSpeciali.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaPSostaGSpeciali.InsertCommand = Me.SqlInsertCommand1
    Me.DaPSostaGSpeciali.SelectCommand = Me.SqlSelectCommand4
    Me.DaPSostaGSpeciali.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PSostaGSpeciali", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("IdTipoEvento", "IdTipoEvento"), New System.Data.Common.DataColumnMapping("IdTipoProvv", "IdTipoProvv")})})
    Me.DaPSostaGSpeciali.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.PSostaGSpeciali WHERE (Id = @Original_Id) AND (Data = @Original_D" & _
    "ata OR @Original_Data IS NULL AND Data IS NULL) AND (IdTipoEvento = @Original_Id" & _
    "TipoEvento OR @Original_IdTipoEvento IS NULL AND IdTipoEvento IS NULL) AND (IdTi" & _
    "poProvv = @Original_IdTipoProvv OR @Original_IdTipoProvv IS NULL AND IdTipoProvv" & _
    " IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoEvento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoEvento", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoProvv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoProvv", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.PSostaGSpeciali(Id, Data, IdTipoEvento, IdTipoProvv) VALUES (@Id," & _
    " @Data, @IdTipoEvento, @IdTipoProvv); SELECT Id, Data, IdTipoEvento, IdTipoProvv" & _
    " FROM dbo.PSostaGSpeciali WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoEvento", System.Data.SqlDbType.Int, 4, "IdTipoEvento"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoProvv", System.Data.SqlDbType.Int, 4, "IdTipoProvv"))
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT Id, Data, IdTipoEvento, IdTipoProvv FROM dbo.PSostaGSpeciali"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.PSostaGSpeciali SET Id = @Id, Data = @Data, IdTipoEvento = @IdTipoEven" & _
    "to, IdTipoProvv = @IdTipoProvv WHERE (Id = @Original_Id) AND (Data = @Original_D" & _
    "ata OR @Original_Data IS NULL AND Data IS NULL) AND (IdTipoEvento = @Original_Id" & _
    "TipoEvento OR @Original_IdTipoEvento IS NULL AND IdTipoEvento IS NULL) AND (IdTi" & _
    "poProvv = @Original_IdTipoProvv OR @Original_IdTipoProvv IS NULL AND IdTipoProvv" & _
    " IS NULL); SELECT Id, Data, IdTipoEvento, IdTipoProvv FROM dbo.PSostaGSpeciali W" & _
    "HERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoEvento", System.Data.SqlDbType.Int, 4, "IdTipoEvento"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdTipoProvv", System.Data.SqlDbType.Int, 4, "IdTipoProvv"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoEvento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoEvento", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdTipoProvv", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdTipoProvv", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsPSostaGSpeciali, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DsPSostaGSpeciali As ATCBussm1.DsPSostaGSpeciali
  Protected WithEvents dgGiorniSpeciali As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlGiorniSpeciali As System.Web.UI.WebControls.Panel
  Protected WithEvents DaPSostaEventoGG As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaPSostaProvvGG As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents CboEventoG As System.Web.UI.WebControls.DropDownList
  Protected WithEvents LblEventi As System.Web.UI.WebControls.Label
  Protected WithEvents LblProvv As System.Web.UI.WebControls.Label
  Protected WithEvents CboProvvG As System.Web.UI.WebControls.DropDownList
  Protected WithEvents DaPSostaGiorni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DaPSostaGSpeciali As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator

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
      DaPSostaEventoGG.Fill(DsPSostaGSpeciali, "PSostaEventoGG")
      DaPSostaProvvGG.Fill(DsPSostaGSpeciali, "PSostaProvvGG")
      CboEventoG.DataBind()
      CboProvvG.DataBind()
      txtAnno.Text = Format(Now, "yyyy")

    End If

  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    Ricerca()

  End Sub

  Private Sub Ricerca()
    Dim strWhere As String

    strWhere = ""
    If txtAnno.Text.Trim <> "" Then
      strWhere &= " Year(Data)= " & txtAnno.Text & " "
    End If

    If CboEventoG.SelectedValue <> 0 Then

      If strWhere <= "" Then
        strWhere &= " IdTipoEvento = " & CboEventoG.SelectedValue
      Else
        strWhere &= " and IdTipoEvento = " & CboEventoG.SelectedValue
      End If

    End If

    If CboProvvG.SelectedValue <> 0 Then

      If strWhere <= "" Then
        strWhere &= " IdTipoProvv = " & CboProvvG.SelectedValue
      Else
        strWhere &= " and IdTipoProvv = " & CboProvvG.SelectedValue
      End If

    End If

    If DaPSostaGiorni.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaPSostaGiorni.SelectCommand.CommandText.IndexOf("Order By") < 0 And Len(strWhere) > 0 Then
      DaPSostaGiorni.SelectCommand.CommandText &= " WHERE " & strWhere
    End If

    If DaPSostaGiorni.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaPSostaGiorni.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsPSostaGSpeciali.Tables("PSostaGiorni").Clear()
    DaPSostaGiorni.Fill(DsPSostaGSpeciali.Tables("PSostaGiorni"))

    dgGiorniSpeciali.CurrentPageIndex = 0
    dgGiorniSpeciali.DataBind()

    pnlGiorniSpeciali.Visible = True
    dgGiorniSpeciali.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgGiorniSpeciali.EditItemIndex = e.Item.ItemIndex
    DaPSostaGiorni.Fill(DsPSostaGSpeciali.Tables("PSostaGiorni"))
    Ricerca()
    DaPSostaEventoGG.Fill(DsPSostaGSpeciali, "PSostaEventoGG")
    DirectCast(dgGiorniSpeciali.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).DataBind()
    DaPSostaProvvGG.Fill(DsPSostaGSpeciali, "PSostaProvvGG")
    DirectCast(dgGiorniSpeciali.Items(e.Item.ItemIndex).Cells(3).Controls(1), DropDownList).DataBind()

    If e.Item.Cells(4).Text <> "&nbsp;" Then
      DirectCast(dgGiorniSpeciali.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).SelectedValue = e.Item.Cells(4).Text
    End If

    If e.Item.Cells(5).Text <> "&nbsp;" Then
      DirectCast(dgGiorniSpeciali.Items(e.Item.ItemIndex).Cells(3).Controls(1), DropDownList).SelectedValue = e.Item.Cells(5).Text
    End If

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow
    DaPSostaGSpeciali.Fill(DsPSostaGSpeciali, "PSostaGSpeciali")
    drF = DsPSostaGSpeciali.Tables("PSostaGSpeciali").Rows.Find(dgGiorniSpeciali.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaPSostaGSpeciali.Update(DsPSostaGSpeciali, "PSostaGSpeciali")
    End If
    dgGiorniSpeciali.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa data?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgGiorniSpeciali.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Me.Validate()
    If Me.IsValid Then

      DaPSostaGSpeciali.Fill(DsPSostaGSpeciali.Tables("PSostaGSpeciali"))
      drF = DsPSostaGSpeciali.Tables("PSostaGSpeciali").Rows.Find(dgGiorniSpeciali.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsPSostaGSpeciali.Tables("PSostaGSpeciali").NewRow
        drF.Item("Id") = dgGiorniSpeciali.DataKeys(e.Item.ItemIndex)
        DsPSostaGSpeciali.Tables("PSostaGSpeciali").Rows.Add(drF)
      End If

      drF.Item("Data") = DirectCast(e.Item.Cells(1).Controls(1), Calendar).SelectedDate
      drF.Item("IdTipoEvento") = DirectCast(e.Item.Cells(2).Controls(1), DropDownList).SelectedValue
      drF.Item("IdTipoProvv") = DirectCast(e.Item.Cells(3).Controls(1), DropDownList).SelectedValue

      DaPSostaGSpeciali.Update(DsPSostaGSpeciali, "PSostaGSpeciali")
      Ricerca()
      dgGiorniSpeciali.EditItemIndex = -1
      dgGiorniSpeciali.DataBind()

    End If

  End Sub

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow
    Ricerca()
    'DaPSostaGSpeciali.Fill(DsPSostaGSpeciali, "PSostaGSpeciali")
    dr = DsPSostaGSpeciali.Tables("PSostaGiorni").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = Now
    dr.Item("IdEvento") = 0
    dr.Item("IdProvv") = 0

    DsPSostaGSpeciali.Tables("PSostaGiorni").Rows.InsertAt(dr, 0)
    dgGiorniSpeciali.EditItemIndex = 0
    dgGiorniSpeciali.DataBind()
    DaPSostaEventoGG.Fill(DsPSostaGSpeciali, "PSostaEventoGG")
    DirectCast(dgGiorniSpeciali.Items(0).Cells(2).Controls(1), DropDownList).DataBind()
    DaPSostaProvvGG.Fill(DsPSostaGSpeciali, "PSostaProvvGG")
    DirectCast(dgGiorniSpeciali.Items(0).Cells(3).Controls(1), DropDownList).DataBind()

  End Sub

  Private Sub dgGiorniSpeciali_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiorniSpeciali.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub dgGiorniSpeciali_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiorniSpeciali.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub dgGiorniSpeciali_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiorniSpeciali.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub dgGiorniSpeciali_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgGiorniSpeciali.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub dgGiorniSpeciali_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiorniSpeciali.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub
End Class
