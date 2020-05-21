Imports System.Data.SqlClient
Public Class wf_CSDatiSintesi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaCarSharing = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsCarSharing = New ATCBussm1.DsCarSharing
    Me.DaCS = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsCarSharing, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaCarSharing
    '
    Me.DaCarSharing.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaCarSharing.InsertCommand = Me.SqlInsertCommand1
    Me.DaCarSharing.SelectCommand = Me.SqlSelectCommand1
    Me.DaCarSharing.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CarSharing", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Incassi", "Incassi"), New System.Data.Common.DataColumnMapping("KmMese", "KmMese"), New System.Data.Common.DataColumnMapping("TempoUt", "TempoUt"), New System.Data.Common.DataColumnMapping("N_Corse", "N_Corse"), New System.Data.Common.DataColumnMapping("N_Auto", "N_Auto"), New System.Data.Common.DataColumnMapping("N_Parcheggi", "N_Parcheggi"), New System.Data.Common.DataColumnMapping("N_Utenti", "N_Utenti"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione")})})
    Me.DaCarSharing.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.CarSharing WHERE (Id = @Id)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.CarSharing(Id, Data, Incassi, KmMese, TempoUt, N_Corse, N_Auto, N" & _
    "_Parcheggi, N_Utenti, DataCreazione) VALUES (@Id, @Data, @Incassi, @KmMese, @Tem" & _
    "poUt, @N_Corse, @N_Auto, @N_Parcheggi, @N_Utenti, @DataCreazione); SELECT Id, Da" & _
    "ta, Incassi, KmMese, TempoUt, N_Corse, N_Auto, N_Parcheggi, N_Utenti, DataCreazi" & _
    "one FROM dbo.CarSharing WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Incassi", System.Data.SqlDbType.Float, 8, "Incassi"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KmMese", System.Data.SqlDbType.Int, 4, "KmMese"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TempoUt", System.Data.SqlDbType.Int, 4, "TempoUt"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Corse", System.Data.SqlDbType.Int, 4, "N_Corse"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Auto", System.Data.SqlDbType.Int, 4, "N_Auto"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Parcheggi", System.Data.SqlDbType.Int, 4, "N_Parcheggi"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Utenti", System.Data.SqlDbType.Int, 4, "N_Utenti"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Data, Incassi, KmMese, TempoUt, N_Corse, N_Auto, N_Parcheggi, N_Utenti" & _
    ", DataCreazione FROM dbo.CarSharing"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.CarSharing SET Id = @Id, Data = @Data, Incassi = @Incassi, KmMese = @K" & _
    "mMese, TempoUt = @TempoUt, N_Corse = @N_Corse, N_Auto = @N_Auto, N_Parcheggi = @" & _
    "N_Parcheggi, N_Utenti = @N_Utenti, DataCreazione = @DataCreazione WHERE (Id = @O" & _
    "riginal_Id) AND (Data = @Original_Data OR @Original_Data IS NULL AND Data IS NUL" & _
    "L) AND (DataCreazione = @Original_DataCreazione OR @Original_DataCreazione IS NU" & _
    "LL AND DataCreazione IS NULL) AND (Incassi = @Original_Incassi OR @Original_Inca" & _
    "ssi IS NULL AND Incassi IS NULL) AND (KmMese = @Original_KmMese OR @Original_KmM" & _
    "ese IS NULL AND KmMese IS NULL) AND (N_Auto = @Original_N_Auto OR @Original_N_Au" & _
    "to IS NULL AND N_Auto IS NULL) AND (N_Corse = @Original_N_Corse OR @Original_N_C" & _
    "orse IS NULL AND N_Corse IS NULL) AND (N_Parcheggi = @Original_N_Parcheggi OR @O" & _
    "riginal_N_Parcheggi IS NULL AND N_Parcheggi IS NULL) AND (N_Utenti = @Original_N" & _
    "_Utenti OR @Original_N_Utenti IS NULL AND N_Utenti IS NULL) AND (TempoUt = @Orig" & _
    "inal_TempoUt OR @Original_TempoUt IS NULL AND TempoUt IS NULL); SELECT Id, Data," & _
    " Incassi, KmMese, TempoUt, N_Corse, N_Auto, N_Parcheggi, N_Utenti, DataCreazione" & _
    " FROM dbo.CarSharing WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Incassi", System.Data.SqlDbType.Float, 8, "Incassi"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KmMese", System.Data.SqlDbType.Int, 4, "KmMese"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TempoUt", System.Data.SqlDbType.Int, 4, "TempoUt"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Corse", System.Data.SqlDbType.Int, 4, "N_Corse"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Auto", System.Data.SqlDbType.Int, 4, "N_Auto"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Parcheggi", System.Data.SqlDbType.Int, 4, "N_Parcheggi"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N_Utenti", System.Data.SqlDbType.Int, 4, "N_Utenti"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Incassi", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incassi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KmMese", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KmMese", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N_Auto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N_Auto", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N_Corse", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N_Corse", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N_Parcheggi", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N_Parcheggi", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N_Utenti", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N_Utenti", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TempoUt", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TempoUt", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsCarSharing
    '
    Me.DsCarSharing.DataSetName = "DsCarSharing"
    Me.DsCarSharing.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'DaCS
    '
    Me.DaCS.SelectCommand = Me.SqlSelectCommand2
    Me.DaCS.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Incassi", "Incassi"), New System.Data.Common.DataColumnMapping("KmMese", "KmMese"), New System.Data.Common.DataColumnMapping("TempoUt", "TempoUt"), New System.Data.Common.DataColumnMapping("N_Corse", "N_Corse"), New System.Data.Common.DataColumnMapping("N_Auto", "N_Auto"), New System.Data.Common.DataColumnMapping("N_Parcheggi", "N_Parcheggi"), New System.Data.Common.DataColumnMapping("N_Utenti", "N_Utenti")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT dbo.CarSharing.Id, dbo.CarSharing.Data AS Data, dbo.CarSharing.Incassi AS " & _
    "Incassi, dbo.CarSharing.DataCreazione AS DataCreazione, CS.km AS KmMese, CS.temp" & _
    "outilizzo AS TempoUt, CS.N_Corse AS N_Corse, CS.n_autodisponibili AS N_AutoCosta" & _
    ", CS.n_parcheggi AS N_ParcheggiCosta, CS.n_utenti AS N_Utenti_tessere, dbo.CarSh" & _
    "aring.N_Utenti AS N_Utenti, dbo.CarSharing.N_Parcheggi AS N_Parcheggi, dbo.CarSh" & _
    "aring.N_Auto AS N_Auto FROM dbo.CarSharing LEFT OUTER JOIN (SELECT cast((str(mes" & _
    "e) + '/' + '01/' + str(anno)) AS datetime) AS Data, mese, anno, km, tempoutilizz" & _
    "o, N_Corse, n_autodisponibili, n_parcheggi, n_utenti FROM carma_riepilogomensile" & _
    ") CS ON dbo.CarSharing.Data = CS.Data"
    Me.SqlSelectCommand2.Connection = Me.con
    CType(Me.DsCarSharing, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaCarSharing As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsCarSharing As ATCBussm1.DsCarSharing
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents dgCarSharing As System.Web.UI.WebControls.DataGrid
  Protected WithEvents pnlCarSharing As System.Web.UI.WebControls.Panel
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents DaCS As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand

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
    End If
  End Sub

  Private Sub Ricerca()

    If txtAnno.Text.Trim <> "" Then
      If DaCarSharing.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaCarSharing.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaCarSharing.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaCarSharing.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaCarSharing.SelectCommand.CommandText &= " ORDER BY data"
    End If

    If txtAnno.Text.Trim <> "" Then
      If DaCS.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaCS.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaCS.SelectCommand.CommandText &= " WHERE Year(Carsharing.Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaCS.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaCS.SelectCommand.CommandText &= " ORDER BY Carsharing.data"
    End If

    DsCarSharing.Tables("CarSharing").Clear()
    DaCarSharing.Fill(DsCarSharing.Tables("CarSharing"))

    DsCarSharing.Tables("CS").Clear()
    DaCS.Fill(DsCarSharing.Tables("CS"))

    dgCarSharing.CurrentPageIndex = 0
    dgCarSharing.DataBind()
    pnlCarSharing.Visible = True
    dgCarSharing.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgCarSharing.EditItemIndex = e.Item.ItemIndex
    DaCarSharing.Fill(DsCarSharing.Tables("CarSharing"))
    Ricerca()

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaCarSharing.Fill(DsCarSharing, "CarSharing")
    drF = DsCarSharing.Tables("CarSharing").Rows.Find(dgCarSharing.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaCarSharing.Update(DsCarSharing, "CarSharing")
    End If

    dgCarSharing.EditItemIndex = -1

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

    dgCarSharing.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Me.Validate()
    If Me.IsValid Then

      DaCarSharing.Fill(DsCarSharing.Tables("CarSharing"))
      drF = DsCarSharing.Tables("CarSharing").Rows.Find(dgCarSharing.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsCarSharing.Tables("CarSharing").NewRow
        drF.Item("Id") = dgCarSharing.DataKeys(e.Item.ItemIndex)
        DsCarSharing.Tables("CarSharing").Rows.Add(drF)
      End If

      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      drF.Item("Incassi") = CDbl(IIf(DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim))
      'drF.Item("KmMese") = CInt(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      'drF.Item("TempoUt") = CInt(IIf(DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim))
      'drF.Item("N_Corse") = CInt(IIf(DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim))
      drF.Item("N_Auto") = CInt(IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim))
      drF.Item("N_Parcheggi") = CInt(IIf(DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim))
      drF.Item("N_Utenti") = CInt(IIf(DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim))

      DaCarSharing.Update(DsCarSharing, "CarSharing")
      Ricerca()
      dgCarSharing.EditItemIndex = -1
      dgCarSharing.DataBind()

    End If

  End Sub

  Private Function MeseDopo() As String
    Dim StrSQL As String
    If txtAnno.Text.Trim <> "" Then
      StrSQL = "Select TOP 1 Data from CarSharing where Year(Data)=@1 order by data desc"
    Else
      StrSQL = "Select TOP 1 Data from CarSharing order by data desc"
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
      If Month(DtData) < 12 Then
        MeseDopo = "01/" & Format(Month(DtData) + 1, "00") & "/" & Format(Year(DtData), "0000")
      Else
        MeseDopo = "01/01/" & Format(Year(DtData) + 1, "0000")
      End If
    Else
      MeseDopo = Format(Now, "01/MM/" & txtAnno.Text)
    End If
    con.Close()
  End Function

  Private Function MeseDopoCS() As DateTime
    Dim StrSQL As String
    If txtAnno.Text.Trim <> "" Then
      StrSQL = "Select TOP 1 Data from CarSharing where Year(Data)=@1 order by data desc"
    Else
      StrSQL = "Select TOP 1 Data from CarSharing order by data desc"
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
      If Month(DtData) < 12 Then
        MeseDopoCS = DtData.AddMonths(1)
      Else
        MeseDopoCS = DtData
      End If
    Else
      MeseDopoCS = Now
    End If
    con.Close()
  End Function

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow
    Dim DataCS As DateTime

    Ricerca()
    dr = DsCarSharing.Tables("CS").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopoCS()
    dr.Item("DataCreazione") = Now
    DsCarSharing.Tables("Cs").Rows.InsertAt(dr, 0)
    dgCarSharing.EditItemIndex = 0

    dgCarSharing.DataBind()

  End Sub

  Public Sub CVIncassi_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVN_Auto_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVN_Parcheggi_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVN_Utenti_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Private Sub dgCarSharing_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCarSharing.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub dgCarSharing_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCarSharing.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub dgCarSharing_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCarSharing.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub dgCarSharing_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCarSharing.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub dgCarSharing_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCarSharing.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub
End Class
