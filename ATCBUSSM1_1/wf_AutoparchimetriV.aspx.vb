Imports System.Data.SqlClient
Public Class wf_AutoparchimetriV
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaAutoPV = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsAutoPV = New ATCBussm1.DsAutoPV
    Me.dvAutoparchimetri = New System.Data.DataView
    Me.DaAutoPNew = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsAutoPV, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvAutoparchimetri, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaAutoPV
    '
    Me.DaAutoPV.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaAutoPV.InsertCommand = Me.SqlInsertCommand1
    Me.DaAutoPV.SelectCommand = Me.SqlSelectCommand1
    Me.DaAutoPV.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Autoparchimetri", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("AcquistiATC", "AcquistiATC"), New System.Data.Common.DataColumnMapping("VenditeSTD", "VenditeSTD"), New System.Data.Common.DataColumnMapping("VenditeDSI", "VenditeDSI"), New System.Data.Common.DataColumnMapping("ResiSTD", "ResiSTD"), New System.Data.Common.DataColumnMapping("ResiDSI", "ResiDSI"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione")})})
    Me.DaAutoPV.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Autoparchimetri WHERE (Id = @Id)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Autoparchimetri (Id, Data, AcquistiATC, AcquistiDSI, VenditeSTD, " & _
    "VenditeDSI, ResiSTD, ResiDSI, DataCreazione) VALUES (@Id, @Data, @AcquistiATC, @" & _
    "AcquistiDSI, @VenditeSTD, @VenditeDSI, @ResiSTD, @ResiDSI, @DataCreazione); SELE" & _
    "CT Id, Data, AcquistiATC, AcquistiDSI, VenditeSTD, VenditeDSI, ResiSTD, ResiDSI," & _
    " DataCreazione FROM dbo.Autoparchimetri WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AcquistiATC", System.Data.SqlDbType.Int, 4, "AcquistiATC"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AcquistiDSI", System.Data.SqlDbType.Int, 4, "AcquistiDSI"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VenditeSTD", System.Data.SqlDbType.Int, 4, "VenditeSTD"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VenditeDSI", System.Data.SqlDbType.Int, 4, "VenditeDSI"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResiSTD", System.Data.SqlDbType.Int, 4, "ResiSTD"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResiDSI", System.Data.SqlDbType.Int, 4, "ResiDSI"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT Id, Data, AcquistiATC, AcquistiDSI, VenditeSTD, VenditeDSI, ResiSTD, ResiD" & _
    "SI, DataCreazione FROM dbo.Autoparchimetri"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Autoparchimetri SET Id = @Id, Data = @Data, AcquistiATC = @AcquistiATC" & _
    ", AcquistiDSI = @AcquistiDSI, VenditeSTD = @VenditeSTD, VenditeDSI = @VenditeDSI" & _
    ", ResiSTD = @ResiSTD, ResiDSI = @ResiDSI, DataCreazione = @DataCreazione WHERE (" & _
    "Id = @Original_Id) AND (AcquistiATC = @Original_AcquistiATC OR @Original_Acquist" & _
    "iATC IS NULL AND AcquistiATC IS NULL) AND (AcquistiDSI = @Original_AcquistiDSI O" & _
    "R @Original_AcquistiDSI IS NULL AND AcquistiDSI IS NULL) AND (Data = @Original_D" & _
    "ata OR @Original_Data IS NULL AND Data IS NULL) AND (DataCreazione = @Original_D" & _
    "ataCreazione OR @Original_DataCreazione IS NULL AND DataCreazione IS NULL) AND (" & _
    "ResiDSI = @Original_ResiDSI OR @Original_ResiDSI IS NULL AND ResiDSI IS NULL) AN" & _
    "D (ResiSTD = @Original_ResiSTD OR @Original_ResiSTD IS NULL AND ResiSTD IS NULL)" & _
    " AND (VenditeDSI = @Original_VenditeDSI OR @Original_VenditeDSI IS NULL AND Vend" & _
    "iteDSI IS NULL) AND (VenditeSTD = @Original_VenditeSTD OR @Original_VenditeSTD I" & _
    "S NULL AND VenditeSTD IS NULL); SELECT Id, Data, AcquistiATC, AcquistiDSI, Vendi" & _
    "teSTD, VenditeDSI, ResiSTD, ResiDSI, DataCreazione FROM dbo.Autoparchimetri WHER" & _
    "E (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AcquistiATC", System.Data.SqlDbType.Int, 4, "AcquistiATC"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AcquistiDSI", System.Data.SqlDbType.Int, 4, "AcquistiDSI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VenditeSTD", System.Data.SqlDbType.Int, 4, "VenditeSTD"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VenditeDSI", System.Data.SqlDbType.Int, 4, "VenditeDSI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResiSTD", System.Data.SqlDbType.Int, 4, "ResiSTD"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ResiDSI", System.Data.SqlDbType.Int, 4, "ResiDSI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 8, "DataCreazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AcquistiATC", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcquistiATC", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AcquistiDSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AcquistiDSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResiDSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResiDSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ResiSTD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ResiSTD", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VenditeDSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VenditeDSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VenditeSTD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VenditeSTD", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsAutoPV
    '
    Me.DsAutoPV.DataSetName = "DsAutoPV"
    Me.DsAutoPV.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'dvAutoparchimetri
    '
    Me.dvAutoparchimetri.Table = Me.DsAutoPV.AutoParchimetriNew
    '
    'DaAutoPNew
    '
    Me.DaAutoPNew.SelectCommand = Me.SqlSelectCommand2
    Me.DaAutoPNew.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AutoParchimetriNew", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("AcquistiATC", "AcquistiATC"), New System.Data.Common.DataColumnMapping("AcquistiDSI", "AcquistiDSI"), New System.Data.Common.DataColumnMapping("VenditeSTD", "VenditeSTD"), New System.Data.Common.DataColumnMapping("VenditeDSI", "VenditeDSI"), New System.Data.Common.DataColumnMapping("ResiSTD", "ResiSTD"), New System.Data.Common.DataColumnMapping("ResiDSI", "ResiDSI")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT A.id, A.Data, ISNULL(A.AcquistiATC, 0) AS AcquistiATC, ISNULL(A.AcquistiDS" & _
    "I, 0) AS AcquistiDSI, ISNULL(B.TotVenditeSTD, 0) AS VenditeSTD, ISNULL(B.TotVend" & _
    "iteDSI, 0) AS VenditeDSI, ISNULL(B.TotResiSTD, 0) AS ResiSTD, ISNULL(B.TotResiDS" & _
    "I, 0) AS ResiDSI, A.DataCreazione FROM (SELECT id, Data, isnull(AcquistiATC, 0) " & _
    "AS AcquistiATC, isnull(AcquistiDSI, 0) AS AcquistiDSI, DataCreazione FROM Autopa" & _
    "rchimetri) A LEFT OUTER JOIN (SELECT MAX(dateadd(day, - day(datavendita) + 1, da" & _
    "tavendita)) AS dataVendite, YEAR(AutoParchimetri_Venduti.DATAVENDITA) AS AnnoVen" & _
    "dite, month(AutoParchimetri_Venduti.DATAVENDITA) AS MeseVendite, TotVenditeDSI =" & _
    " SUM(CASE WHEN AutoParchimetri_Venduti.DSI = 1 THEN 1 ELSE 0 END), TotVenditeSTD" & _
    " = SUM(CASE WHEN AutoParchimetri_Venduti.DSI = 1 THEN 0 ELSE 1 END), TotResiDSI " & _
    "= SUM(CASE WHEN AutoParchimetri_Venduti.DSI = 1 AND NOT (DATARESO IS NULL) THEN " & _
    "1 ELSE 0 END), TotResiSTD = SUM(CASE WHEN AutoParchimetri_Venduti.DSI = 2 AND NO" & _
    "T (DATARESO IS NULL) THEN 1 ELSE 0 END) FROM AutoParchimetri_Venduti WHERE (NOT " & _
    "(AutoParchimetri_Venduti.DATAVENDITA IS NULL)) GROUP BY YEAR(AutoParchimetri_Ven" & _
    "duti.DATAVENDITA), MONTH(AutoParchimetri_Venduti.DATAVENDITA)) B ON YEAR(A.Data)" & _
    " = B.AnnoVendite AND MONTH(A.Data) = B.MeseVendite"
    Me.SqlSelectCommand2.Connection = Me.con
    CType(Me.DsAutoPV, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvAutoparchimetri, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
	Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
	Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
	Protected WithEvents btnFind As System.Web.UI.WebControls.Button
	Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents DaAutoPV As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents DsAutoPV As ATCBussm1.DsAutoPV
	Protected WithEvents dgAutoPV As System.Web.UI.WebControls.DataGrid
	Protected WithEvents pnlAutoPV As System.Web.UI.WebControls.Panel
	Protected WithEvents VSAutoparchimetri As System.Web.UI.WebControls.ValidationSummary
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
	Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
	Protected WithEvents dvAutoparchimetri As System.Data.DataView
	Protected WithEvents lblNoAutoparchimetri As System.Web.UI.WebControls.Label
	Protected WithEvents lblCount As System.Web.UI.WebControls.Label
	Protected WithEvents btnAddMonth As System.Web.UI.WebControls.Button
  Protected WithEvents DaAutoPNew As System.Data.SqlClient.SqlDataAdapter
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
      RicercaN()
		End If
	End Sub

  Private Sub RicercaN()

    If txtAnno.Text.Trim <> "" Then
      If DaAutoPNew.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaAutoPNew.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaAutoPNew.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaAutoPNew.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsAutoPV.Tables("AutoParchimetriNew").Clear()
    DaAutoPNew.Fill(DsAutoPV.Tables("AutoParchimetriNew"))

    dgAutoPV.CurrentPageIndex = 0
    dgAutoPV.DataBind()
    lblCount.DataBind()
    lblNoAutoparchimetri.DataBind()
    pnlAutoPV.Visible = True
    'dgAutoPV.Visible = True

  End Sub

  'Private Sub RicercaADDN()

  '  If txtAnno.Text.Trim <> "" Then
  '    If DaAutoPNew.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaAutoPV.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
  '      DaAutoPNew.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
  '    End If
  '  End If

  '  If DaAutoPNew.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
  '    DaAutoPNew.SelectCommand.CommandText &= " ORDER BY DataCreazione desc"
  '  End If

  '  DsAutoPV.Tables("AutoParchimetriNew").Clear()
  '  DaAutoPNew.Fill(DsAutoPV.Tables("AutoParchimetriNew"))

  '  dgAutoPV.CurrentPageIndex = 0
  '  dgAutoPV.DataBind()
  '  lblCount.DataBind()
  '  lblNoAutoparchimetri.DataBind()
  '  pnlAutoPV.Visible = True

  'End Sub

  Private Sub Ricerca()

    If txtAnno.Text.Trim <> "" Then
      If DaAutoPV.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaAutoPV.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaAutoPV.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaAutoPV.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaAutoPV.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsAutoPV.Tables("Autoparchimetri").Clear()
    DaAutoPV.Fill(DsAutoPV.Tables("Autoparchimetri"))

    dgAutoPV.CurrentPageIndex = 0
    dgAutoPV.DataBind()
    lblCount.DataBind()
    lblNoAutoparchimetri.DataBind()
    pnlAutoPV.Visible = True
    'dgAutoPV.Visible = True

  End Sub

  'Private Sub RicercaADD()

  '  If txtAnno.Text.Trim <> "" Then
  '    If DaAutoPV.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaAutoPV.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
  '      DaAutoPV.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
  '    End If
  '  End If

  '  If DaAutoPV.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
  '    DaAutoPV.SelectCommand.CommandText &= " ORDER BY DataCreazione desc"
  '  End If

  '  DsAutoPV.Tables("Autoparchimetri").Clear()
  '  DaAutoPV.Fill(DsAutoPV.Tables("Autoparchimetri"))

  '  dgAutoPV.CurrentPageIndex = 0
  '  dgAutoPV.DataBind()
  '  lblCount.DataBind()
  '  lblNoAutoparchimetri.DataBind()
  '  pnlAutoPV.Visible = True

  'End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgAutoPV.EditItemIndex = e.Item.ItemIndex
    DaAutoPV.Fill(DsAutoPV.Tables("Autoparchimetri"))
    RicercaN()

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaAutoPV.Fill(DsAutoPV, "Autoparchimetri")
    drF = DsAutoPV.Tables("Autoparchimetri").Rows.Find(dgAutoPV.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaAutoPV.Update(DsAutoPV, "Autoparchimetri")
    End If

    dgAutoPV.EditItemIndex = -1

    RicercaN()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo mese?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgAutoPV.EditItemIndex = -1
    RicercaN()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow

    Me.Validate()
    If Me.IsValid Then
      DaAutoPV.Fill(DsAutoPV.Tables("Autoparchimetri"))

      drF = DsAutoPV.Tables("Autoparchimetri").Rows.Find(dgAutoPV.DataKeys(e.Item.ItemIndex))
      If drF Is Nothing Then
        drF = DsAutoPV.Tables("Autoparchimetri").NewRow
        drF.Item("Id") = dgAutoPV.DataKeys(e.Item.ItemIndex)
        DsAutoPV.Tables("Autoparchimetri").Rows.Add(drF)
      End If

      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      drF.Item("AcquistiATC") = CInt(IIf(DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(2).Controls(1), TextBox).Text.Trim))
      drF.Item("AcquistiDSI") = CInt(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      'drF.Item("VenditeSTD") = CInt(IIf(DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim))
      'drF.Item("VenditeDSI") = CInt(IIf(DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim))
      'drF.Item("ResiSTD") = CInt(IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim))
      'drF.Item("ResiDSI") = CInt(IIf(DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim))

      DaAutoPV.Update(DsAutoPV, "Autoparchimetri")

      RicercaN()
      dgAutoPV.EditItemIndex = -1
      dgAutoPV.DataBind()
      lblCount.DataBind()
      lblNoAutoparchimetri.DataBind()
    End If

  End Sub

  Private Function MeseDopo() As String

    Dim StrSQL As String
    If txtAnno.Text.Trim <> "" Then
      StrSQL = "Select TOP 1 Data from Autoparchimetri where Year(Data)=@1 order by data desc"
    Else
      StrSQL = "Select TOP 1 Data from Autoparchimetri order by data desc"
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
        MeseDopo = "01/" & Format(Month(DtData), "00") & "/" & Format(Year(DtData), "0000")
      End If

    Else
      MeseDopo = Format(Now, "01/MM/" & txtAnno.Text)
    End If
    con.Close()

  End Function



  Public Sub CVAcqATC_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Public Sub CVAcqDSI_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  'Public Sub CVVendSTD_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
  '  args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  'End Sub

  'Public Sub CVVendDSI_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
  '  args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  'End Sub

  'Public Sub CVResiSTD_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
  '  args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  'End Sub

  'Public Sub CVResiDSI_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
  '  args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  'End Sub

  Private Sub btnAddMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMonth.Click
    Dim dr As Data.DataRow
    RicercaN()

    dr = DsAutoPV.Tables("AutoParchimetriNew").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopo()
    dr.Item("DataCreazione") = Now

    DsAutoPV.Tables("AutoParchimetriNew").Rows.InsertAt(dr, 0)
    dgAutoPV.EditItemIndex = 0

    DirectCast(dgAutoPV.DataSource, DataView).Sort = "DataCreazione desc"
    dgAutoPV.DataBind()
    Page.DataBind()

  End Sub
End Class
