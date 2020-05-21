Imports System.Data.SqlClient

Public Class wf_OrganicoAcc
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaOrganicoAcc = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsOrganicoAcc = New ATCBussm1.DsOrganicoAcc
    Me.DaOrganicoNoteSt = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsOrganicoAcc, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaOrganicoAcc
    '
    Me.DaOrganicoAcc.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaOrganicoAcc.InsertCommand = Me.SqlInsertCommand1
    Me.DaOrganicoAcc.SelectCommand = Me.SqlSelectCommand1
    Me.DaOrganicoAcc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OrganicoAcc", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("PartTEff", "PartTEff"), New System.Data.Common.DataColumnMapping("EquivEff", "EquivEff"), New System.Data.Common.DataColumnMapping("FullTAsp", "FullTAsp"), New System.Data.Common.DataColumnMapping("PartTAsp", "PartTAsp"), New System.Data.Common.DataColumnMapping("EquivAsp", "EquivAsp"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione"), New System.Data.Common.DataColumnMapping("FullTEff", "FullTEff")})})
    Me.DaOrganicoAcc.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.OrganicoAcc WHERE (Id = @Id)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.OrganicoAcc(Id, Data, PartTEff, EquivEff, FullTAsp, PartTAsp, Equ" & _
    "ivAsp, DataCreazione, FullTEff) VALUES (@Id, @Data, @PartTEff, @EquivEff, @FullT" & _
    "Asp, @PartTAsp, @EquivAsp, @DataCreazione, @FullTEff); SELECT Id, Data, PartTEff" & _
    ", EquivEff, FullTAsp, PartTAsp, EquivAsp, DataCreazione, FullTEff FROM dbo.Organ" & _
    "icoAcc WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PartTEff", System.Data.SqlDbType.Float, 8, "PartTEff"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EquivEff", System.Data.SqlDbType.Float, 8, "EquivEff"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FullTAsp", System.Data.SqlDbType.Float, 8, "FullTAsp"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PartTAsp", System.Data.SqlDbType.Float, 8, "PartTAsp"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EquivAsp", System.Data.SqlDbType.Float, 8, "EquivAsp"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FullTEff", System.Data.SqlDbType.Float, 8, "FullTEff"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Data, PartTEff, EquivEff, FullTAsp, PartTAsp, EquivAsp, DataCreazione," & _
    " FullTEff FROM dbo.OrganicoAcc"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.OrganicoAcc SET Id = @Id, Data = @Data, PartTEff = @PartTEff, EquivEff" & _
    " = @EquivEff, FullTAsp = @FullTAsp, PartTAsp = @PartTAsp, EquivAsp = @EquivAsp, " & _
    "DataCreazione = @DataCreazione, FullTEff = @FullTEff WHERE (Id = @Original_Id) A" & _
    "ND (Data = @Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (DataC" & _
    "reazione = @Original_DataCreazione OR @Original_DataCreazione IS NULL AND DataCr" & _
    "eazione IS NULL) AND (EquivAsp = @Original_EquivAsp OR @Original_EquivAsp IS NUL" & _
    "L AND EquivAsp IS NULL) AND (EquivEff = @Original_EquivEff OR @Original_EquivEff" & _
    " IS NULL AND EquivEff IS NULL) AND (FullTAsp = @Original_FullTAsp OR @Original_F" & _
    "ullTAsp IS NULL AND FullTAsp IS NULL) AND (FullTEff = @Original_FullTEff OR @Ori" & _
    "ginal_FullTEff IS NULL AND FullTEff IS NULL) AND (PartTAsp = @Original_PartTAsp " & _
    "OR @Original_PartTAsp IS NULL AND PartTAsp IS NULL) AND (PartTEff = @Original_Pa" & _
    "rtTEff OR @Original_PartTEff IS NULL AND PartTEff IS NULL); SELECT Id, Data, Par" & _
    "tTEff, EquivEff, FullTAsp, PartTAsp, EquivAsp, DataCreazione, FullTEff FROM dbo." & _
    "OrganicoAcc WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PartTEff", System.Data.SqlDbType.Float, 8, "PartTEff"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EquivEff", System.Data.SqlDbType.Float, 8, "EquivEff"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FullTAsp", System.Data.SqlDbType.Float, 8, "FullTAsp"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PartTAsp", System.Data.SqlDbType.Float, 8, "PartTAsp"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EquivAsp", System.Data.SqlDbType.Float, 8, "EquivAsp"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FullTEff", System.Data.SqlDbType.Float, 8, "FullTEff"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EquivAsp", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EquivAsp", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EquivEff", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EquivEff", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FullTAsp", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FullTAsp", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FullTEff", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FullTEff", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PartTAsp", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartTAsp", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PartTEff", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PartTEff", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsOrganicoAcc
    '
    Me.DsOrganicoAcc.DataSetName = "DsOrganicoAcc"
    Me.DsOrganicoAcc.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'DaOrganicoNoteSt
    '
    Me.DaOrganicoNoteSt.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaOrganicoNoteSt.InsertCommand = Me.SqlInsertCommand2
    Me.DaOrganicoNoteSt.SelectCommand = Me.SqlSelectCommand2
    Me.DaOrganicoNoteSt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OrganicoNoteSt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Nota", "Nota"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione")})})
    Me.DaOrganicoNoteSt.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.OrganicoNoteSt WHERE (Id = @Id)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.OrganicoNoteSt(Id, Data, Nota, DataCreazione) VALUES (@Id, @Data," & _
    " @Nota, @DataCreazione); SELECT Id, Data, Nota, DataCreazione FROM dbo.OrganicoN" & _
    "oteSt WHERE (Id = @Id)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT Id, Data, Nota, DataCreazione FROM dbo.OrganicoNoteSt"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.OrganicoNoteSt SET Id = @Id, Data = @Data, Nota = @Nota, DataCreazione" & _
    " = @DataCreazione WHERE (Id = @Original_Id) AND (Data = @Original_Data OR @Origi" & _
    "nal_Data IS NULL AND Data IS NULL) AND (DataCreazione = @Original_DataCreazione " & _
    "OR @Original_DataCreazione IS NULL AND DataCreazione IS NULL); SELECT Id, Data, " & _
    "Nota, DataCreazione FROM dbo.OrganicoNoteSt WHERE (Id = @Id)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nota", System.Data.SqlDbType.NVarChar, 1073741823, "Nota"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing))
    CType(Me.DsOrganicoAcc, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaOrganicoAcc As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsOrganicoAcc As ATCBussm1.DsOrganicoAcc
  Protected WithEvents DgOrganicoAcc As System.Web.UI.WebControls.DataGrid
  Protected WithEvents PnlOrganico As System.Web.UI.WebControls.Panel
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents DgNote As System.Web.UI.WebControls.DataGrid
  Protected WithEvents PnlNoteStampa As System.Web.UI.WebControls.Panel
  Protected WithEvents DaOrganicoNoteSt As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents LnkAggNota As System.Web.UI.WebControls.LinkButton
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents VSOrganicoAcc As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
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
      txtAnno.Text = Format(Now, "yyyy")

    End If

  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    If Me.IsValid Then
      Ricerca()
      RicercaNote()
    End If
  End Sub

  Private Sub Ricerca()

    If txtAnno.Text.Trim <> "" Then
      If DaOrganicoAcc.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaOrganicoAcc.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaOrganicoAcc.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaOrganicoAcc.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaOrganicoAcc.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsOrganicoAcc.Tables("OrganicoAcc").Clear()
    DaOrganicoAcc.Fill(DsOrganicoAcc.Tables("OrganicoAcc"))

    DgOrganicoAcc.CurrentPageIndex = 0
    DgOrganicoAcc.DataBind()
    PnlOrganico.Visible = True
    DgOrganicoAcc.Visible = True
    DgNote.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgOrganicoAcc.EditItemIndex = e.Item.ItemIndex
    DaOrganicoAcc.Fill(DsOrganicoAcc.Tables("OrganicoAcc"))
    Ricerca()

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaOrganicoAcc.Fill(DsOrganicoAcc, "OrganicoAcc")
    drF = DsOrganicoAcc.Tables("OrganicoAcc").Rows.Find(DgOrganicoAcc.DataKeys(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaOrganicoAcc.Update(DsOrganicoAcc, "OrganicoAcc")
    End If
    DgOrganicoAcc.EditItemIndex = -1
    Ricerca()
  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo mese?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgOrganicoAcc.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Me.Validate()
    If Me.IsValid Then
      DaOrganicoAcc.Fill(DsOrganicoAcc.Tables("OrganicoAcc"))
      drF = DsOrganicoAcc.Tables("OrganicoAcc").Rows.Find(DgOrganicoAcc.DataKeys(e.Item.ItemIndex))
      If drF Is Nothing Then
        drF = DsOrganicoAcc.Tables("OrganicoAcc").NewRow
        drF.Item("Id") = DgOrganicoAcc.DataKeys(e.Item.ItemIndex)
        DsOrganicoAcc.Tables("OrganicoAcc").Rows.Add(drF)
      End If

      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      drF.Item("FullTEff") = CDbl(IIf(DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim))
      drF.Item("PartTEff") = CDbl(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      drF.Item("EquivEff") = CDbl(IIf(DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim))
      drF.Item("FullTAsp") = CDbl(IIf(DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim))
      drF.Item("PartTAsp") = CDbl(IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim))
      drF.Item("EquivAsp") = CDbl(IIf(DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim))

      DaOrganicoAcc.Update(DsOrganicoAcc, "OrganicoAcc")

      Ricerca()
      DgOrganicoAcc.EditItemIndex = -1
      DgOrganicoAcc.DataBind()
    End If
  End Sub

  Private Function MeseDopo() As String
    Dim StrSQL As String
    If txtAnno.Text.Trim <> "" Then
      StrSQL = "Select TOP 1 Data from OrganicoAcc where Year(Data)=@1 order by data desc"
    Else
      StrSQL = "Select TOP 1 Data from OrganicoAcc order by data desc"
    End If
    Dim com As New SqlCommand(StrSQL, con)
    Dim dRead As SqlDataReader
    Dim DtData As DateTime
    con.Open()
    If txtAnno.Text.Trim <> "" Then
      com.Parameters.Add("@1", SqlDbType.Int).Value = CInt(txtAnno.Text)
    End If
    dRead = com.ExecuteReader
    dRead.Read()
    If dRead.HasRows = True Then
      DtData = IIf(IsDBNull(dRead.Item("Data")), Now, dRead.Item("Data"))
      MeseDopo = "01/" & Format(Month(DtData) + 1, "00") & "/" & Format(Year(DtData), "0000")
    Else
      MeseDopo = Format(Now, "01/MM/" & txtAnno.Text)
    End If
    con.Close()
  End Function

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As DataRow
    Ricerca()
    'DaOrganicoAcc.Fill(DsOrganicoAcc, "OrganicoAcc")
    dr = DsOrganicoAcc.Tables("OrganicoAcc").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopo()
    dr.Item("DataCreazione") = Now
    DsOrganicoAcc.Tables("OrganicoAcc").Rows.InsertAt(dr, 0)
    DgOrganicoAcc.EditItemIndex = 0
    DgOrganicoAcc.DataBind()

  End Sub

  Public Sub CVFTE_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVPTE_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVEQE_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVFTA_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVPTA_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVEQA_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub



  '-------------------------- GRIGLIA NOTE STAMPA -------------------------------------------------------

  Private Sub RicercaNote()

    If txtAnno.Text.Trim <> "" Then
      If DaOrganicoNoteSt.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaOrganicoNoteSt.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaOrganicoNoteSt.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaOrganicoNoteSt.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaOrganicoNoteSt.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsOrganicoAcc.Tables("OrganicoNoteSt").Clear()
    DaOrganicoNoteSt.Fill(DsOrganicoAcc.Tables("OrganicoNoteSt"))

    DgNote.CurrentPageIndex = 0
    DgNote.DataBind()
    PnlNoteStampa.Visible = True

  End Sub

  Public Sub pDGDeleteNote(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
    Dim drF As DataRow

    DaOrganicoNoteSt.Fill(DsOrganicoAcc, "OrganicoNoteSt")
    drF = DsOrganicoAcc.Tables("OrganicoNoteSt").Rows.Find(DgNote.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaOrganicoNoteSt.Update(DsOrganicoAcc, "OrganicoNoteSt")
    End If
    DgNote.EditItemIndex = -1
    RicercaNote()

  End Sub

  Public Sub pItemCreatedNote(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelNota")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo gruppo?');")
    End If

  End Sub

  Public Sub pDGEditNote(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgNote.EditItemIndex = e.Item.ItemIndex
    RicercaNote()

  End Sub

  Public Sub pDGUpdateNote(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow
    Dim StrNota As String
    Dim StrData As String
    Me.Validate()
    If Me.IsValid Then

      StrData = "01/01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      StrNota = DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim
      DaOrganicoNoteSt.Fill(DsOrganicoAcc.Tables("OrganicoNoteSt"))
      drF = DsOrganicoAcc.Tables("OrganicoNoteSt").Rows.Find(DgNote.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsOrganicoAcc.Tables("OrganicoNoteSt").NewRow
        drF.Item("Id") = DgNote.DataKeys(e.Item.ItemIndex)
        DsOrganicoAcc.Tables("OrganicoNoteSt").Rows.Add(drF)
      End If

      drF.Item("Data") = StrData
      drF.Item("Nota") = StrNota

      DaOrganicoNoteSt.Update(DsOrganicoAcc, "OrganicoNoteSt")

      DgNote.EditItemIndex = -1
      RicercaNote()

    End If

  End Sub

  Public Sub pDGCancelnote(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgNote.EditItemIndex = -1
    RicercaNote()

  End Sub

  Private Sub LnkAggNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnkAggNota.Click

    Dim dr As DataRow
    'Dim dt As New Date(Year, Month, Day)
    'DaOrganicoNoteSt.Fill(DsOrganicoAcc, "OrganicoNoteSt")
    RicercaNote()
    dr = DsOrganicoAcc.Tables("OrganicoNoteSt").NewRow
    dr.Item("Id") = Guid.NewGuid
    If txtAnno.Text.Trim <> "" Then
      dr.Item("Data") = "01/01/" & txtAnno.Text.Trim
    End If
    dr.Item("DataCreazione") = Now
    DsOrganicoAcc.Tables("OrganicoNoteSt").Rows.InsertAt(dr, 0)

    DgNote.EditItemIndex = 0
    DgNote.DataBind()

  End Sub

  '-------------------------- FINE GRIGLIA NOTE STAMPA -----------------------------------------------------

  Private Sub DgOrganicoAcc_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgOrganicoAcc.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub DgOrganicoAcc_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgOrganicoAcc.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub DgOrganicoAcc_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgOrganicoAcc.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub DgOrganicoAcc_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgOrganicoAcc.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub DgOrganicoAcc_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgOrganicoAcc.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub

  Private Sub DgNote_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgNote.CancelCommand
    pDGCancelnote(source, e)
  End Sub

  Private Sub DgNote_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgNote.DeleteCommand
    pDGDeleteNote(source, e)
  End Sub

  Private Sub DgNote_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgNote.EditCommand
    pDGEditNote(source, e)
  End Sub

  Private Sub DgNote_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgNote.ItemCreated
    pItemCreatedNote(sender, e)
  End Sub

  Private Sub DgNote_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgNote.UpdateCommand
    pDGUpdateNote(source, e)
  End Sub
End Class
