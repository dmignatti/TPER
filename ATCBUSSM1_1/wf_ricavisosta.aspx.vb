Imports System.Data.SqlClient
Public Class wf_ricavisosta
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaRicaviSosta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsRicaviSosta = New ATCBussm1.DsRicaviSosta
    Me.DaConsuntivoSosta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.ConnDatiAs400 = New System.Data.SqlClient.SqlConnection
    CType(Me.DsRicaviSosta, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaRicaviSosta
    '
    Me.DaRicaviSosta.DeleteCommand = Me.SqlCommand1
    Me.DaRicaviSosta.InsertCommand = Me.SqlCommand2
    Me.DaRicaviSosta.SelectCommand = Me.SqlSelectCommand1
    Me.DaRicaviSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BudgetSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Budget", "Budget"), New System.Data.Common.DataColumnMapping("Consuntivo", "Consuntivo"), New System.Data.Common.DataColumnMapping("ConsuntivoFiere", "ConsuntivoFiere")})})
    Me.DaRicaviSosta.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.BudgetSosta WHERE (Id = @Id)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "INSERT INTO dbo.BudgetSosta (Id, Data, Budget,ConsuntivoFiere) VALUES (@Id, @Data" & _
    ", @Budget,@ConsuntivoFiere); "
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Budget", System.Data.SqlDbType.Float, 8, "Budget"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsuntivoFiere", System.Data.SqlDbType.Float, 8, "ConsuntivoFiere"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT BudgetSosta.Id, BudgetSosta.Data, BudgetSosta.Budget, ConsuntivoSosta.Cons" & _
    "untivo, BudgetSosta.ConsuntivoFiere FROM BudgetSosta LEFT OUTER JOIN ConsuntivoS" & _
    "osta ON BudgetSosta.Data = ConsuntivoSosta.DataC"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.BudgetSosta SET Id = @Id, Data = @Data, Budget = @Budget, ConsuntivoFi" & _
    "ere = @ConsuntivoFiere WHERE (Id = @Original_Id) AND (Budget = @Original_Budget " & _
    "OR @Original_Budget IS NULL AND Budget IS NULL) AND (Data = @Original_Data OR @O" & _
    "riginal_Data IS NULL AND Data IS NULL) AND (ConsuntivoFiere = @Original_Consunti" & _
    "voFiere OR @Original_ConsuntivoFiere IS NULL AND ConsuntivoFiere IS NULL);"
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Budget", System.Data.SqlDbType.Float, 8, "Budget"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConsuntivoFiere", System.Data.SqlDbType.Float, 8, "ConsuntivoFiere"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Budget", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Budget", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConsuntivoFiere", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsuntivoFiere", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRicaviSosta
    '
    Me.DsRicaviSosta.DataSetName = "DsRicaviSosta"
    Me.DsRicaviSosta.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DaConsuntivoSosta
    '
    Me.DaConsuntivoSosta.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaConsuntivoSosta.InsertCommand = Me.SqlInsertCommand2
    Me.DaConsuntivoSosta.SelectCommand = Me.SqlSelectCommand3
    Me.DaConsuntivoSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ConsuntivoSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdC", "IdC"), New System.Data.Common.DataColumnMapping("DataC", "DataC"), New System.Data.Common.DataColumnMapping("Consuntivo", "Consuntivo")})})
    Me.DaConsuntivoSosta.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.ConsuntivoSosta WHERE (YEAR(DataC) = @anno)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.ConsuntivoSosta(IdC, DataC, Consuntivo) VALUES (@IdC, @DataC, @Co" & _
    "nsuntivo); SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSosta WHERE (IdC = @" & _
    "IdC)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSosta"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.ConsuntivoSosta SET IdC = @IdC, DataC = @DataC, Consuntivo = @Consunti" & _
    "vo WHERE (IdC = @Original_IdC) AND (Consuntivo = @Original_Consuntivo OR @Origin" & _
    "al_Consuntivo IS NULL AND Consuntivo IS NULL) AND (DataC = @Original_DataC OR @O" & _
    "riginal_DataC IS NULL AND DataC IS NULL); SELECT IdC, DataC, Consuntivo FROM dbo" & _
    ".ConsuntivoSosta WHERE (IdC = @IdC)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdC", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdC", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Consuntivo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consuntivo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataC", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataC", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSosta"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'ConnDatiAs400
    '
    Me.ConnDatiAs400.ConnectionString = CType(configurationAppSettings.GetValue("ConnDatiAs400", GetType(System.String)), String)
    CType(Me.DsRicaviSosta, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaRicaviSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents lnkAddnew As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlRicaviSosta As System.Web.UI.WebControls.Panel
  Protected WithEvents DsRicaviSosta As ATCBussm1.DsRicaviSosta
  Protected WithEvents DgRicaviSosta As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LnkConsuntivo As System.Web.UI.WebControls.LinkButton
  Protected WithEvents DaConsuntivoSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents btnAggiorna As System.Web.UI.WebControls.Button
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected Friend WithEvents ConnDatiAs400 As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
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

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    If Not IsPostBack Then

      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      txtAnno.Text = Format(Now, "yyyy")

    End If
  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    Ricerca()

  End Sub

  Private Sub Ricerca()
    Dim a As DateTime

    If txtAnno.Text.Trim <> "" Then
      If DaRicaviSosta.SelectCommand.CommandText.IndexOf("WHERE") < 0 And DaRicaviSosta.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
        DaRicaviSosta.SelectCommand.CommandText &= " WHERE Year(Data)= " & txtAnno.Text & " "
      End If
    End If

    If DaRicaviSosta.SelectCommand.CommandText.IndexOf("Order By") < 0 Then
      DaRicaviSosta.SelectCommand.CommandText &= " ORDER BY data"
    End If

    DsRicaviSosta.Tables("RicaviSosta").Clear()
    DaRicaviSosta.Fill(DsRicaviSosta.Tables("RicaviSosta"))

    dgRicaviSosta.CurrentPageIndex = 0
    dgRicaviSosta.DataBind()
    pnlRicaviSosta.Visible = True
    DgRicaviSosta.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgRicaviSosta.EditItemIndex = e.Item.ItemIndex
    DaRicaviSosta.Fill(DsRicaviSosta.Tables("RicaviSosta"))
    Ricerca()

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As DataRow

    DaRicaviSosta.Fill(DsRicaviSosta, "RicaviSosta")
    drF = DsRicaviSosta.Tables("RicaviSosta").Rows.Find(DgRicaviSosta.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaRicaviSosta.Update(DsRicaviSosta, "RicaviSosta")
    End If

    DgRicaviSosta.EditItemIndex = -1

    Ricerca()

  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)

    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa riga?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    DgRicaviSosta.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Dim Budget As Double
    Dim Consuntivo As Double

    Me.Validate()
    If Me.IsValid Then

      DaRicaviSosta.Fill(DsRicaviSosta.Tables("RicaviSosta"))
      drF = DsRicaviSosta.Tables("RicaviSosta").Rows.Find(DgRicaviSosta.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsRicaviSosta.Tables("RicaviSosta").NewRow
        drF.Item("Id") = DgRicaviSosta.DataKeys(e.Item.ItemIndex)
        DsRicaviSosta.Tables("RicaviSosta").Rows.Add(drF)
      End If

      drF.Item("Data") = "01/" & IIf(DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim = "", Format(Now, "mm/yyyy"), DirectCast(e.Item.Cells(1).Controls(1), TextBox).Text.Trim)
      '  drF.Item("ConsuntivoFiere") = CDbl(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      drF.Item("ConsuntivoFiere") = CDbl(0)
      drF.Item("Budget") = CDbl(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      DaRicaviSosta.Update(DsRicaviSosta, "RicaviSosta")
      Ricerca()
      DgRicaviSosta.EditItemIndex = -1
      DgRicaviSosta.DataBind()

    End If

  End Sub

  Private Function MeseDopo() As String

    Dim StrSQL As String
    If txtAnno.Text.Trim <> "" Then
      StrSQL = "Select TOP 1 Data from BudgetSosta where Year(Data)=@1 order by data desc"
    Else
      StrSQL = "Select TOP 1 Data from BudgetSosta order by data desc"
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

      If Month(DtData) = 12 Then
        MeseDopo = "01/12/" & Format(Year(DtData), "0000")
      Else
        MeseDopo = "01/" & Format(Month(DtData) + 1, "00") & "/" & Format(Year(DtData), "0000")
      End If

    Else
      MeseDopo = Format(Now, "01/MM/yyyy")
    End If
    con.Close()

  End Function

  Private Sub lnkAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAddnew.Click

    Dim dr As Data.DataRow

    Ricerca()
    dr = DsRicaviSosta.Tables("RicaviSosta").NewRow
    dr.Item("Id") = Guid.NewGuid
    dr.Item("Data") = MeseDopo()
    dr.Item("Budget") = 0
    dr.Item("ConsuntivoFiere") = 0
    dr.Item("Consuntivo") = 0
    DsRicaviSosta.Tables("RicaviSosta").Rows.InsertAt(dr, 0)
    DgRicaviSosta.EditItemIndex = 0
    DgRicaviSosta.DataBind()

  End Sub


  Public Sub CVBudget_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
  End Sub

  Private Sub DgRicaviSosta_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgRicaviSosta.CancelCommand
    pDataGridCancel(source, e)
  End Sub

  Private Sub DgRicaviSosta_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgRicaviSosta.DeleteCommand
    pDataGridDelete(source, e)
  End Sub

  Private Sub DgRicaviSosta_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgRicaviSosta.EditCommand
    pDataGridEdit(source, e)
  End Sub

  Private Sub DgRicaviSosta_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgRicaviSosta.ItemCreated
    pItemCreated(sender, e)
  End Sub

  Private Sub DgRicaviSosta_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgRicaviSosta.UpdateCommand
    pDataGridUpdate(source, e)
  End Sub

  Private Sub btnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiorna.Click


    If txtAnno.Text.Trim <> "" Then

      Dim StrSQL As String
      Dim strAnno As String
      Dim DtData As DateTime
      Dim drD As DataRow()
      Dim drF As DataRow
      Dim righe As Integer

      strAnno = txtAnno.Text.Trim

      ' StrSQL = "SELECT SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) AS MESE,ABS(ROUND(SUM(TVDATI_TVSTO00F.MOQTA * TVDATI_TVTIT00F.TIVAL) / 1.2, 2)) AS Ricavo " & _
      '         "FROM TVDATI_TVSTO00F INNER JOIN TVDATI_TVTIT00F ON TVDATI_TVSTO00F.MOCOD = TVDATI_TVTIT00F.TICOD INNER JOIN " & _
      '        "TVDATI_TVTAR00F ON TVDATI_TVTIT00F.TIICT = TVDATI_TVTAR00F.TAICT AND TVDATI_TVSTO00F.MODAT <= TVDATI_TVTAR00F.TADTA AND " & _
      '       "TVDATI_TVSTO00F.MODAT >= TVDATI_TVTAR00F.TADTD WHERE (TVDATI_TVSTO00F.MOCAU = 'PA' OR " & _
      '      "TVDATI_TVSTO00F.MOCAU = 'PS' OR TVDATI_TVSTO00F.MOCAU = 'PN' OR " & _
      '     "TVDATI_TVSTO00F.MOCAU = 'SP') AND (TVDATI_TVSTO00F.MOANN IS NULL or TVDATI_TVSTO00F.MOANN<=' ') and SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 1, 4)='" & strAnno & "' " & _
      '    "GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) "
      '


      StrSQL = "select Mese, sum(Ricavo) as Ricavo from ( " & _
                "SELECT SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) AS Mese, " & _
               "ABS(ROUND((SUM(ISNULL(TVDATI_TVSTO00F.MOVUR,0)) + SUM(ISNULL(TVDATI_TVSTO00F.MOVEX,0))), 2)) AS Ricavo " & _
               "FROM TVDATI_TVSTO00F " & _
               "WHERE (TVDATI_TVSTO00F.MOCAU = 'PA' OR " & _
               "TVDATI_TVSTO00F.MOCAU = 'PS' OR TVDATI_TVSTO00F.MOCAU = 'PN' OR " & _
               "TVDATI_TVSTO00F.MOCAU = 'SP' or TVDATI_TVSTO00F.MOCAU = 'SF' or TVDATI_TVSTO00F.MOCAU = 'FS') AND (TVDATI_TVSTO00F.MOANN IS NULL or TVDATI_TVSTO00F.MOANN<=' ') and SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 1, 4)='" & strAnno & "' " & _
               "GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) " & _
               " Union all " & _
               " SELECT  SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 5, 2) AS Mese,ABS((SUM(isnull(TIMPO,0)))) AS Ricavo " & _
               " FROM         TVDATI_ETCOR00F " & _
               " WHERE TBIAB='S' and ( TFLAG IS NULL or TFLAG ='') and  SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 1, 4) ='" & strAnno & "' " & _
               " GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 5, 2)) as a " & _
               " group by Mese"



      ' StrSQL = "SELECT MID(TRIM(CSTR(TVDATI_TVSTO00F.MODAT)), 5, 2) AS MESE, ABS(SUM((TVDATI_TVSTO00F.MOQTA*TVDATI_TVTIT00F.TIVAL)/1.2)) AS Ricavo " & _
      '          "FROM (TVDATI_TVSTO00F INNER JOIN TVDATI_TVTIT00F ON TVDATI_TVSTO00F.MOCOD = TVDATI_TVTIT00F.TICOD) INNER JOIN TVDATI_TVTAR00F ON " & _
      '          "TVDATI_TVTIT00F.TIICT = TVDATI_TVTAR00F.TAICT  WHERE (TVDATI_TVSTO00F.MOCAU = 'PA' OR TVDATI_TVSTO00F.MOCAU = 'PS' OR " & _
      '          "TVDATI_TVSTO00F.MOCAU = 'PN' OR TVDATI_TVSTO00F.MOCAU = 'SP') AND (TVDATI_TVSTO00F.MOANN IS NULL) and " & _
      '          "MID(TRIM(CSTR(TVDATI_TVSTO00F.MODAT)), 1, 4)='" & strAnno & "' AND TVDATI_TVSTO00F.MODAT <= TVDATI_TVTAR00F.TADTA AND " & _
      '          "TVDATI_TVSTO00F.MODAT >= TVDATI_TVTAR00F.TADTD GROUP BY MID(TRIM(CSTR(TVDATI_TVSTO00F.MODAT)), 5, 2)"


      Dim com As New SqlCommand(StrSQL, ConnDatiAs400)
      'Dim com As New OleDb.OleDbCommand(StrSQL, ConnDatiAs400)
      'Dim dRead As OleDb.OleDbDataReader
      Dim dRead As SqlDataReader
      ConnDatiAs400.Open()

      dRead = com.ExecuteReader

      DaConsuntivoSosta.Fill(DsRicaviSosta.Tables("ConsuntivoSosta"))

      If dRead.HasRows = True Then
        con.Open()

        DaConsuntivoSosta.DeleteCommand.Parameters("@ANNO").Value = CInt(txtAnno.Text.Trim)
        righe = DaConsuntivoSosta.DeleteCommand.ExecuteNonQuery()
        DaConsuntivoSosta.Update(DsRicaviSosta, "ConsuntivoSosta")

        con.Close()

        Do While dRead.Read

          drF = DsRicaviSosta.Tables("ConsuntivoSosta").NewRow
          drF.Item("IdC") = Guid.NewGuid
          DsRicaviSosta.Tables("ConsuntivoSosta").Rows.Add(drF)

          drF.Item("DataC") = "01/" & dRead.Item("MESE") & "/" & strAnno
          drF.Item("Consuntivo") = dRead.Item("Ricavo")
          DaConsuntivoSosta.Update(DsRicaviSosta, "ConsuntivoSosta")

        Loop
      End If
      con.Close()
      Ricerca()
      ConnDatiAs400.Close()

    End If

  End Sub

End Class
