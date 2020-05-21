Public Class wf_congedifrazionati
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCongediFrazionati = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsRichiesteCongediFrazionati1 = New ATCBussm1.dsRichiesteCongediFrazionati
    CType(Me.DsRichiesteCongediFrazionati1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCongediFrazionati
    '
    Me.daCongediFrazionati.DeleteCommand = Me.SqlCommand1
    Me.daCongediFrazionati.InsertCommand = Me.SqlInsertCommand1
    Me.daCongediFrazionati.SelectCommand = Me.SqlSelectCommand1
    Me.daCongediFrazionati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediFrazionati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("DalleOre", "DalleOre"), New System.Data.Common.DataColumnMapping("AlleOre", "AlleOre"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daCongediFrazionati.UpdateCommand = Me.SqlCommand2
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.RichiesteCongediFrazionati WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCongediFrazionati (IdRichiesta, IdAccertatore, Data, Dal" & _
    "leOre, AlleOre, Intero) VALUES (@IdRichiesta, @IdAccertatore, @Data, @DalleOre, " & _
    "@AlleOre, @Intero)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 8, "DalleOre"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 8, "AlleOre"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intero", System.Data.SqlDbType.Bit, 1, "Intero"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, RC.IdRichiesta, RC.IdAccertatore," & _
    " RC.Data, RC.DalleOre, RC.AlleOre, CASE WHEN RC.StatoApprovazione IS NULL THEN '" & _
    "Da approvare' WHEN RC.StatoApprovazione = 0 THEN 'Respinta' WHEN RC.StatoApprova" & _
    "zione = 1 THEN 'Approvata' WHEN RC.StatoApprovazione = 99 THEN 'Convertito in in" & _
    "tero' END AS StatoApprovazione, RC.DataApprovazione, RC.IdApprovatore, RC.ts, RC" & _
    ".Intero FROM dbo.RichiesteCongediFrazionati RC LEFT OUTER JOIN dbo.ATC_Utenti U " & _
    "ON RC.IdApprovatore = U.ID WHERE (RC.IdAccertatore = @IdAccertatore) AND (RC.Dat" & _
    "a >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) ORDER BY RC.Data DESC, RC.DalleOr" & _
    "e DESC, RC.ts"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "UPDATE dbo.RichiesteCongediFrazionati SET Data = @Data, DalleOre = @DalleOre, All" & _
    "eOre = @AlleOre, ts = DATEADD(second, 2, GETDATE()), Intero = @Intero WHERE (IdR" & _
    "ichiesta = @IdRIchiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 8, "DalleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 8, "AlleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intero", System.Data.SqlDbType.Bit, 1, "Intero"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRIchiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRichiesteCongediFrazionati1
    '
    Me.DsRichiesteCongediFrazionati1.DataSetName = "dsRichiesteCongediFrazionati"
    Me.DsRichiesteCongediFrazionati1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRichiesteCongediFrazionati1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCongediFrazionati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsRichiesteCongediFrazionati1 As ATCBussm1.dsRichiesteCongediFrazionati
  Protected WithEvents dgCongediFrazionati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnAddRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Dim oUtente As Utente
  Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    cvTipoUtente.Validate()
    btnAddRichiesta.Enabled = cvTipoUtente.IsValid And dgCongediFrazionati.EditItemIndex = -1
    daCongediFrazionati.SelectCommand.Parameters("@IDAccertatore").Value = oUtente.ID
    daCongediFrazionati.Fill(DsRichiesteCongediFrazionati1, "RichiesteCongediFrazionati")
    If Not IsPostBack Then
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCongediFrazionati_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemDataBound
    If Not e.Item.FindControl("lblDalleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    If Not e.Item.FindControl("lblAlleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    If Not e.Item.FindControl("ddlDalleOre") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("DalleOre"))
      DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlDaMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("DalleOre"))
      DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue = t.Minutes
    End If
    If Not e.Item.FindControl("ddlAlleOre") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("AlleOre"))
      DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlAMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("AlleOre"))
      DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue = t.Minutes
    End If
  End Sub

  Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRichiesta.Click
    Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").NewRow
    dr.Item("IdRichiesta") = Guid.NewGuid
    dr.Item("IdAccertatore") = oUtente.ID
    dr.Item("Data") = Now.Date
    dr.Item("Intero") = False
    dr.Item("DalleOre") = New TimeSpan(7, 0, 0).Ticks
    dr.Item("AlleOre") = New TimeSpan(7, 0, 0).Ticks
    DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.InsertAt(dr, 0)
    dgCongediFrazionati.EditItemIndex = 0
    Page.DataBind()
    btnAddRichiesta.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Click nuova richiesta congedo frazionato", Session("IPAddress"))
  End Sub

  Private Sub dgCongediFrazionati_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.CancelCommand
    dgCongediFrazionati.EditItemIndex = -1
    Page.DataBind()
    btnAddRichiesta.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Annullata modifica", Session("IPAddress"))
  End Sub

  Private Sub dgCongediFrazionati_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.EditCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      dgCongediFrazionati.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnAddRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Inizio modifica congedo", Session("IPAddress"))
    End If
  End Sub

  Public Sub cvMinData_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate > Now.AddDays(1).Date) Then
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate > Now.AddDays(1).Date
    Else
      If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate <= Now.Date) Then
        args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate > Now.Date
      ElseIf (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate = Now.AddDays(1).Date) Then
        'DM2020.01 - FINO ALLE 18.00
        If (Now.Hour >= 18) Then
          args.IsValid = False
        Else
          args.IsValid = True
        End If
      End If
    End If

  End Sub

  Public Sub cvAlleOre_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    Dim t1 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti"), DropDownList).SelectedValue, 0)
    Dim t2 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti"), DropDownList).SelectedValue, 0)
    args.IsValid = t2.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
  End Sub

  Private Sub dgCongediFrazionati_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.UpdateCommand
    If Me.IsValid Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatore") = oUtente.ID
        DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Add(dr)
      End If
      dr.Item("Intero") = DirectCast(e.Item.FindControl("chkIntero"), CheckBox).Checked
      dr.Item("Data") = DirectCast(e.Item.FindControl("caData"), Calendar).SelectedDate
      Dim selectedData As DateTime
      selectedData = DirectCast(e.Item.FindControl("caData"), Calendar).SelectedDate
      Dim dataDa As DateTime
      Dim dataA As DateTime
      Dim oraDa As Integer
      Dim oraA As Integer
      Dim minDa As Integer
      Dim minA As Integer
      oraDa = DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue
      minDa = DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue
      oraA = DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue
      minA = DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue
      dataDa = New DateTime(selectedData.Year, selectedData.Month, selectedData.Day, oraDa, minDa, 0)
      dataA = New DateTime(selectedData.Year, selectedData.Month, selectedData.Day, oraA, minA, 0)
      dr.Item("DalleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue, 0).Ticks
      dr.Item("AlleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue, 0).Ticks
      Dim richiesteG As String
      richiesteG = ""
      richiesteG = RichiestePresenti(dataDa, dataA)
      If Not (richiesteG = "") Then

        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).ErrorMessage = "Sono già presenti dei giustificativi: <br/>" & richiesteG
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).IsValid = False

      Else

        daCongediFrazionati.Update(DsRichiesteCongediFrazionati1, "RichiesteCongediFrazionati")
        DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Clear()
        daCongediFrazionati.Fill(DsRichiesteCongediFrazionati1, "RichiesteCongediFrazionati")
        dgCongediFrazionati_CancelCommand(source, e)
        fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Confermato inserimento/modifica congedo", Session("IPAddress"))

      End If

    End If
  End Sub

  Private Sub dgCongediFrazionati_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.DeleteCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsRichiesteCongediFrazionati1.Tables("RichiesteCongediFrazionati").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daCongediFrazionati.Update(DsRichiesteCongediFrazionati1, "RichiesteCongediFrazionati")
        fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Eliminato congedo", Session("IPAddress"))
      End If
      dgCongediFrazionati_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgCongediFrazionati_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di congedo frazionato?');")
  End Sub

  Private Function RichiestePresenti(ByVal dal As Date, ByVal al As Date) As String
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("SELECT G.AccertatoreId, G.OraDa, G.OraA, G.DataRichiesta, C.Nome " & _
                        " FROM Accertatori_GiustificativoRichiesta AS G INNER JOIN " & _
                        " Accertatori_GiustificativoCausale AS C ON G.Accertatori_GiustificativoCausaleId = C.ID " & _
                        " WHERE ((G.StatoGiustificativo IS NULL) OR (G.StatoGiustificativo = 0) OR " & _
                        " (G.StatoGiustificativo = 1)) and  AccertatoreId  = " & oUtente.ID.ToString() & " " & _
                        " and not (G.OraA<=CONVERT(DATETIME, '" & Replace(Format(dal, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) or G.OraDa>=CONVERT(DATETIME, '" & Replace(Format(al, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) )", con)
    Dim drgiustificativi As SqlClient.SqlDataReader
    con.Open()
    drgiustificativi = cmdgiustificativi.ExecuteReader()
    If drgiustificativi.HasRows Then
      Do While drgiustificativi.Read
        richiesta = richiesta & "<br />" & System.Convert.ToString(drgiustificativi("Nome")) & "- Da " & drgiustificativi("OraDa") & " a " & drgiustificativi("OraA") & " richiesta in data: " & drgiustificativi("DataRichiesta")

      Loop
    End If
    con.Close()

    RichiestePresenti = richiesta

  End Function



  Private Sub dgCongediFrazionati_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCongediFrazionati.SelectedIndexChanged

  End Sub
End Class
