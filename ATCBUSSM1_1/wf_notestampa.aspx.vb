Imports System.Data.SqlClient
Public Class wf_notestampa
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaNoteSezione = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsNoteSezione = New ATCBussm1.DsNoteSezione
    Me.DaSezioneReport = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsNoteSezione, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaNoteSezione
    '
    Me.DaNoteSezione.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaNoteSezione.InsertCommand = Me.SqlInsertCommand1
    Me.DaNoteSezione.SelectCommand = Me.SqlSelectCommand1
    Me.DaNoteSezione.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NoteSezione", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nota", "Nota"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("IdSezione", "IdSezione")})})
    Me.DaNoteSezione.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.NoteSezione WHERE (Id = @Original_Id) AND (Data = @Original_Data " & _
    "OR @Original_Data IS NULL AND Data IS NULL) AND (IdSezione = @Original_IdSezione" & _
    " OR @Original_IdSezione IS NULL AND IdSezione IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdSezione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdSezione", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.NoteSezione(Id, Nota, Data, IdSezione) VALUES (@Id, @Nota, @Data," & _
    " @IdSezione); SELECT Id, Nota, Data, IdSezione FROM dbo.NoteSezione WHERE (Id = " & _
    "@Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdSezione", System.Data.SqlDbType.Int, 4, "IdSezione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT dbo.NoteSezione.Id, dbo.NoteSezione.Nota, dbo.NoteSezione.Data, dbo.NoteSe" & _
    "zione.IdSezione, dbo.SezioniReport.Descrizione FROM dbo.NoteSezione INNER JOIN d" & _
    "bo.SezioniReport ON dbo.NoteSezione.IdSezione = dbo.SezioniReport.IdSezione"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.NoteSezione SET Id = @Id, Nota = @Nota, Data = @Data, IdSezione = @IdS" & _
    "ezione WHERE (Id = @Original_Id) AND (Data = @Original_Data OR @Original_Data IS" & _
    " NULL AND Data IS NULL) AND (IdSezione = @Original_IdSezione OR @Original_IdSezi" & _
    "one IS NULL AND IdSezione IS NULL); SELECT Id, Nota, Data, IdSezione FROM dbo.No" & _
    "teSezione WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdSezione", System.Data.SqlDbType.Int, 4, "IdSezione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdSezione", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdSezione", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsNoteSezione
    '
    Me.DsNoteSezione.DataSetName = "DsNoteSezione"
    Me.DsNoteSezione.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DaSezioneReport
    '
    Me.DaSezioneReport.SelectCommand = Me.SqlSelectCommand2
    Me.DaSezioneReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SezioniReport", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdSezione", "IdSezione"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdSezione, Descrizione FROM dbo.SezioniReport"
    Me.SqlSelectCommand2.Connection = Me.con
    CType(Me.DsNoteSezione, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaNoteSezione As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsNoteSezione As ATCBussm1.DsNoteSezione
  Protected WithEvents Validationsummary1 As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents LnkAggiuntaNote As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlNote As System.Web.UI.WebControls.Panel
  Protected WithEvents dgNoteSezione As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DaSezioneReport As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents lblSezione As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents cboSezioneSt As System.Web.UI.WebControls.DropDownList
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents pnlSearch As System.Web.UI.WebControls.Panel
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
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
  Private Where As String = ""
  Private pUnspecified As String = "[Non specificato]"

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here

    If Not IsPostBack Then

      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      DsNoteSezione.Tables("NoteSezione").Clear()
      DaNoteSezione.Fill(DsNoteSezione.Tables("NoteSezione"))
      DaSezioneReport.Fill(DsNoteSezione.Tables("SezioniReport"))
      cboSezioneSt.DataBind()
      'cboSezioneSt.Items.Insert(0, pUnspecified)
      dgNoteSezione.CurrentPageIndex = 0
      dgNoteSezione.DataBind()
      txtAnno.Text = Year(Now)
      Ricerca()
      pnlNote.Visible = True

    End If

  End Sub

  Private Sub Ricerca()

    pBuildWhere()
    If Where.Length > 0 And DaNoteSezione.SelectCommand.CommandText.IndexOf("WHERE") < 0 Then
      DaNoteSezione.SelectCommand.CommandText &= " WHERE " & Where
    End If
    If DaNoteSezione.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaNoteSezione.SelectCommand.CommandText &= " Order By  Data, Descrizione "
    End If
    DsNoteSezione.Tables("NoteSezione").Clear()
    DaNoteSezione.Fill(DsNoteSezione.Tables("NoteSezione"))
    dgNoteSezione.DataBind()
    pnlNote.Visible = True

  End Sub

  Private Sub pBuildWhere()

    Where = ""

    If txtAnno.Text.Length > 0 Then
      Where &= "YEAR(dbo.NoteSezione.Data) = " & txtAnno.Text & " "
    End If
    If cboSezioneSt.SelectedItem.Text <> pUnspecified Then
      If Where.Length > 0 Then Where &= " AND "
      Where &= "dbo.SezioniReport.IdSezione = " & cboSezioneSt.SelectedValue
    End If

  End Sub

  Private Sub LnkAggiuntaNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkAggiuntaNote.Click
    Dim dr As Data.DataRow

    Ricerca()
    dgNoteSezione.CurrentPageIndex = 0
    dr = DsNoteSezione.Tables("NoteSezione").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopo()
    DsNoteSezione.Tables("NoteSezione").Rows.InsertAt(dr, 0)
    dgNoteSezione.EditItemIndex = 0

    dgNoteSezione.DataBind()
    DaSezioneReport.Fill(DsNoteSezione.Tables("SezioniReport"))
    DirectCast(dgNoteSezione.Items(0).Cells(1).Controls(1), DropDownList).DataBind()

  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    Ricerca()

  End Sub

  Private Sub dgNoteSezione_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgNoteSezione.ItemCreated

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDeleteNote")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa nota?');")
    End If

  End Sub

  Private Function MeseDopo() As String

    Dim StrSQL As String

    If cboSezioneSt.SelectedItem.Text <> pUnspecified Then
      StrSQL = "Select TOP 1 Data FROM NoteSezione WHERE (IdSezione = " & cboSezioneSt.SelectedValue & ") order by data desc"
    Else
      StrSQL = "Select TOP 1 Data FROM NoteSezione order by data desc"
    End If

    Dim com As New SqlCommand(StrSQL, con)
    Dim dRead As SqlDataReader
    Dim DtData As DateTime
    con.Open()

    dRead = com.ExecuteReader
    dRead.Read()
    If dRead.HasRows = True Then
      DtData = IIf(IsDBNull(dRead.Item("Data")), Now, dRead.Item("Data"))
      If Month(DtData) < 12 Then
        MeseDopo = "01/" & Format(Month(DtData) + 1, "00") & "/" & Format(Year(DtData), "0000")
      Else
        MeseDopo = "01/" & Format(Month(DtData), "00") & "/" & Format(Year(DtData), "0000")
      End If
    Else
        MeseDopo = Format(Now, "01/MM/yyyy")
      End If
      con.Close()

  End Function

  Private Sub dgNoteSezione_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSezione.EditCommand

    dgNoteSezione.EditItemIndex = e.Item.ItemIndex
    DaNoteSezione.Fill(DsNoteSezione.Tables("NoteSezione"))
    Ricerca()
    DaSezioneReport.Fill(DsNoteSezione.Tables("SezioniReport"))
    DirectCast(dgNoteSezione.Items(e.Item.ItemIndex).Cells(1).Controls(1), DropDownList).DataBind()
    DirectCast(dgNoteSezione.Items(e.Item.ItemIndex).Cells(1).Controls(1), DropDownList).SelectedValue = cboSezioneSt.SelectedValue

  End Sub

  Private Sub dgNoteSezione_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSezione.CancelCommand

    dgNoteSezione.EditItemIndex = -1
    Ricerca()

  End Sub

  Private Sub dgNoteSezione_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSezione.DeleteCommand

    Dim drF As DataRow

    DaNoteSezione.Fill(DsNoteSezione, "NoteSezione")
    drF = DsNoteSezione.Tables("NoteSezione").Rows.Find(dgNoteSezione.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaNoteSezione.Update(DsNoteSezione, "NoteSezione")
    End If

    dgNoteSezione.CurrentPageIndex = 0
    dgNoteSezione.EditItemIndex = -1

    Ricerca()

  End Sub

  Private Sub dgNoteSezione_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgNoteSezione.UpdateCommand

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Me.Validate()
    If Me.IsValid Then

      DaNoteSezione.Fill(DsNoteSezione.Tables("NoteSezione"))
      drF = DsNoteSezione.Tables("NoteSezione").Rows.Find(dgNoteSezione.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsNoteSezione.Tables("NoteSezione").NewRow
        drF.Item("Id") = dgNoteSezione.DataKeys(e.Item.ItemIndex)
        DsNoteSezione.Tables("NoteSezione").Rows.Add(drF)
      End If

      drF.Item("IdSezione") = DirectCast(dgNoteSezione.Items(0).Cells(1).Controls(1), DropDownList).SelectedValue
      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim)
      drF.Item("Nota") = DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim
      DaNoteSezione.Update(DsNoteSezione, "NoteSezione")
      Ricerca()
      dgNoteSezione.EditItemIndex = -1
      dgNoteSezione.DataBind()

    End If

  End Sub

  Private Sub dgNoteSezione_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgNoteSezione.PageIndexChanged

    dgNoteSezione.CurrentPageIndex = e.NewPageIndex
    Ricerca()

  End Sub

End Class
