Public Class wf_congediGarantitiFra
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
    Me.DsRichiesteCongediGarantitiFra1 = New ATCBussm1.DsRichiesteCongediGarantitiFra
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    CType(Me.DsRichiesteCongediGarantitiFra1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.daCongediFrazionati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediGarantitiFra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("DalleOre", "DalleOre"), New System.Data.Common.DataColumnMapping("AlleOre", "AlleOre"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daCongediFrazionati.UpdateCommand = Me.SqlCommand2
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.RichiesteCongediGarantitiFra WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCongediGarantitiFra (IdRichiesta, IdAccertatore, Data, D" & _
    "alleOre, AlleOre, Intero) VALUES (@IdRichiesta, @IdAccertatore, @Data, @DalleOre" & _
    ", @AlleOre, @Intero)"
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
    ".Intero FROM dbo.RichiesteCongediGarantitiFra RC LEFT OUTER JOIN dbo.ATC_Utenti " & _
    "U ON RC.IdApprovatore = U.ID WHERE (RC.IdAccertatore = @IdAccertatore) AND (mont" & _
    "h(RC.Data) >=month(GETDATE())) ORDER BY RC.Data DESC, RC.DalleOre DESC, RC.ts"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "UPDATE dbo.RichiesteCongediGarantitiFra SET Data = @Data, DalleOre = @DalleOre, A" & _
    "lleOre = @AlleOre, ts = DATEADD(second, 2, GETDATE()), Intero = @Intero WHERE (I" & _
    "dRichiesta = @IdRIchiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 8, "DalleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 8, "AlleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intero", System.Data.SqlDbType.Bit, 1, "Intero"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRIchiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRichiesteCongediGarantitiFra1
    '
    Me.DsRichiesteCongediGarantitiFra1.DataSetName = "DsRichiesteCongediGarantitiFra"
    Me.DsRichiesteCongediGarantitiFra1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    CType(Me.DsRichiesteCongediGarantitiFra1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgCongediFrazionati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnAddRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents daCongediFrazionati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsRichiesteCongediGarantitiFra1 As ATCBussm1.DsRichiesteCongediGarantitiFra
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection

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
    daCongediFrazionati.Fill(DsRichiesteCongediGarantitiFra1, "RichiesteCongediGarantitiFra")
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
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("DalleOre"))
      DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlDaMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("DalleOre"))
      DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue = t.Minutes
    End If
    If Not e.Item.FindControl("ddlAlleOre") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("AlleOre"))
      DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlAMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(dr.Item("AlleOre"))
      DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue = t.Minutes
    End If
  End Sub

  Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRichiesta.Click
    Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").NewRow
    oUtente.bStoInserendo = True
    dr.Item("IdRichiesta") = Guid.NewGuid
    dr.Item("IdAccertatore") = oUtente.ID
    dr.Item("Data") = Now.Date
    dr.Item("Intero") = False
    dr.Item("DalleOre") = New TimeSpan(0, 0, 0).Ticks
    dr.Item("AlleOre") = New TimeSpan(0, 0, 0).Ticks
    DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.InsertAt(dr, 0)
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
      oUtente.bStoInserendo = False
      dgCongediFrazionati.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnAddRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Inizio modifica congedo", Session("IPAddress"))    
    End If
  End Sub

  Public Sub cvMinData_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    'Il Congedo garantito frazionato posso chiederlo entro le 18 di un giorno LAVORATIVO precedente
    '   quindi finché non sono in un giorno feriale, non CONTO un giorno succesivo
    Dim PrimaDataValida As Date
    Dim UltimaDataValida As Date 'La data ultima per richiedere, alle 18 della quale giornata, non si può chiedere se non il gg dopo
    PrimaDataValida = Now
    Do While pFestivita(PrimaDataValida)
      PrimaDataValida = PrimaDataValida.AddDays(1)
    Loop
    If FormatDateTime(PrimaDataValida, DateFormat.ShortDate) = FormatDateTime(Now, DateFormat.ShortDate) And Hour(Now) >= 18 Then
      PrimaDataValida = PrimaDataValida.AddDays(1)
      Do While pFestivita(PrimaDataValida)
        PrimaDataValida = PrimaDataValida.AddDays(1)
      Loop
    End If
    UltimaDataValida = PrimaDataValida
    'DA "DOMANI" è VALIDA
    PrimaDataValida = DataLavorativa(PrimaDataValida, 1)

    If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate >= PrimaDataValida.Date) Then
      'DM2020.03 Se la data scelta è corretta dal punto di vista del periodo, faccio gli altri controlli
      ' 1) se è un giorno festivo, niente da fare
      Dim dal As Date
      dal = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate
      '
      If Not pVestizioneDefinitiva(dal) Then
        DirectCast(source, CustomValidator).ErrorMessage = "Vestizione definitiva non ancora creata per il mese di " & MonthName(Month(dal)).ToString
        args.IsValid = False
      ElseIf pFestivita(dal, True) = True Then
        DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile scegliere un giorno festivo o di riposo"
        args.IsValid = False
      ElseIf pTurnoAccertamentoEsteso(dal) = True Then
        DirectCast(source, CustomValidator).ErrorMessage = "Si è su un turno di Accertamento Esteso. Data non selezionabile."
        args.IsValid = False
        ' DM2020.03 - TOLTO IL CONTROLLO TURNO NECESSARIO
        'ElseIf pTurnoNecessario(dal) = True Then
        '  DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile scegliere un giorno in cui ci sia un Turno Necessario"
        ''  args.IsValid = False

      Else
        args.IsValid = True
      End If
    Else
      If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate < UltimaDataValida.Date) Then
        DirectCast(source, CustomValidator).ErrorMessage = "La prima data selezionabile è " & FormatDateTime(PrimaDataValida, DateFormat.ShortDate)
        args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate > PrimaDataValida.Date
      ElseIf (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate = UltimaDataValida.Date) Then
        DirectCast(source, CustomValidator).ErrorMessage = "Puoi fare la richiesta entro le 18.00 del giorno lavorativo precedente alla data scelta."
        args.IsValid = False
      End If
    End If

  End Sub

  Public Sub cvAlleOre_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    Dim t1 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti"), DropDownList).SelectedValue, 0)
    Dim t2 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti"), DropDownList).SelectedValue, 0)
    args.IsValid = t2.Subtract(t1).TotalMinutes >= 15
  End Sub

  Private Sub dgCongediFrazionati_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.UpdateCommand
    If Me.IsValid Then
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatore") = oUtente.ID
        DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Add(dr)
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

      'DM2020.03 
      Dim sTIPO As String
      Dim iOraEnt As Integer
      Dim iMinEnt As Integer
      Dim iOraUsc As Integer
      Dim iMinUsc As Integer
      Dim iTURNO As Integer
      Dim iMassimoMinuti As Double
      iTURNO = pInCheTurnoSono(dataDa, sTIPO, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
      Dim DTENTRATA As DateTime
      Dim DTUSCITA As DateTime
      Dim DTRICHIESTA As DateTime
      DTENTRATA = FormatDateTime(dataDa, DateFormat.ShortDate) + " " + iOraEnt.ToString + ":" + iMinEnt.ToString
      DTUSCITA = FormatDateTime(dataDa, DateFormat.ShortDate) + " " + iOraUsc.ToString + ":" + iMinUsc.ToString
      DTRICHIESTA = FormatDateTime(dataDa, DateFormat.ShortDate) + " " + oraDa.ToString + ":" + minDa.ToString
      ' ---------------- CONTROLLO INFRA TURNI ---------------------
      If DateDiff(DateInterval.Minute, DTENTRATA, DTUSCITA) > 431 Then
        If DateDiff(DateInterval.Minute, DTENTRATA, DTRICHIESTA) <= 85 Then
          'SE SONO QUI è PERCHE' LA DIFFERENZA TRA DATA ENTR E DATA USCITA è PIU' DI 7 ore e 11 min. 
          'per cui c'è in mezzo mezz'ora da togliere 
          iMassimoMinuti = (DateDiff(DateInterval.Minute, DTENTRATA, DTUSCITA) - 30) / 2
        Else
          iMassimoMinuti = (DateDiff(DateInterval.Minute, DTENTRATA, DTUSCITA)) / 2 + 15
        End If
      Else
        iMassimoMinuti = DateDiff(DateInterval.Minute, DTENTRATA, DTUSCITA) / 2

      End If

      If iMassimoMinuti = 0 Then
        If sTIPO = "FT" Then
          iMassimoMinuti = 215
        Else
          iMassimoMinuti = 166
        End If
      End If
      If IsNothing(sTIPO) Then
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).ErrorMessage = "Non risultano turni per quella data."
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).IsValid = False
        Exit Sub
      End If
      If DateDiff(DateInterval.Minute, dataDa, dataA) > iMassimoMinuti Then
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).ErrorMessage = "Richiesta oraria non valida: massimo metà turno"
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).IsValid = False
        Exit Sub
      End If
      dr.Item("DalleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue, 0).Ticks
      dr.Item("AlleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue, 0).Ticks


      Dim richiesteG As String
      richiesteG = ""
      richiesteG = RichiestePresenti(dataDa, dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If Not (richiesteG = "") Then
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).ErrorMessage = richiesteG
        DirectCast(e.Item.FindControl("cvAlleOre"), CustomValidator).IsValid = False
      Else

        daCongediFrazionati.Update(DsRichiesteCongediGarantitiFra1, "RichiesteCongediGarantitiFra")
        DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Clear()
        daCongediFrazionati.Fill(DsRichiesteCongediGarantitiFra1, "RichiesteCongediGarantitiFra")
        dgCongediFrazionati_CancelCommand(source, e)
        fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Confermato inserimento/modifica congedo", Session("IPAddress"))

      End If

    End If
  End Sub

  Private Sub dgCongediFrazionati_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.DeleteCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsRichiesteCongediGarantitiFra1.Tables("RichiesteCongediGarantitiFra").Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daCongediFrazionati.Update(DsRichiesteCongediGarantitiFra1, "RichiesteCongediGarantitiFra")
        fnc.ScriviLog(oUtente.IDUser, "wf_congedifrazionati.aspx", "Eliminato congedo", Session("IPAddress"))
      End If
      dgCongediFrazionati_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgCongediFrazionati_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di congedo frazionato?');")
  End Sub

  Private Function RichiestePresenti(ByVal dal As Date, ByVal inpIdRichiesta As Guid) As String
    'DM2020.03 - controllo che questo mese non ci sia già una richeista congedi garantiti
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("select * from [RichiesteCongediGarantitiFra] " & _
            " where month(data) = " & Month(dal) & _
            "    and IdAccertatore  = " & oUtente.ID.ToString() & _
            " and IdRichiesta <> '" & inpIdRichiesta.ToString & "' " & _
            " and (StatoApprovazione <> 0 or StatoApprovazione is null) ", con)
    Dim drgiustificativi As SqlClient.SqlDataReader
    con.Open()
    drgiustificativi = cmdgiustificativi.ExecuteReader()
    If drgiustificativi.HasRows Then
      richiesta = "Non è possibile richiedere due congedi garantiti nello stesso mese."
    End If
    con.Close()

    RichiestePresenti = richiesta
  End Function
  Function DataLavorativa(ByVal inpData As Date, ByVal inpGG As Integer) As Date
    'DM2020.04 - DATA LAVORATIVA: aggiungendo un numero di GG lavorativi ad una data "data", quale DATA esce?
    Dim i As Integer = 0
    Dim dataTrovata As Date
    dataTrovata = inpData
    Do While i < inpGG
      dataTrovata = dataTrovata.AddDays(1)
      If Not pFestivita(dataTrovata) Then i = i + 1
    Loop
    DataLavorativa = FormatDateTime(dataTrovata, DateFormat.ShortDate)
  End Function
  Private Function pFestivita(ByVal dal As Date, Optional ByVal AncheRiposo As Boolean = False) As Boolean
    'DM2020.02 - controllo che la data sia una festività: se lo è ritorno TRUE
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = FormatDateTime(dal, DateFormat.ShortDate)
    con.Open()
    If sc.ExecuteScalar() > 0 Or dal.DayOfWeek = DayOfWeek.Sunday Then
      pFestivita = True
    Else
      pFestivita = False
    End If
    con.Close()

    If Not pFestivita And AncheRiposo Then

      Dim scRiposi As New SqlClient.SqlCommand("SELECT COUNT(*) FROM [Riposi] where TTGGGG = DAY(@data) and TTMMGG = MONTH(@data) and TTAAGG = YEAR (@data) and TTMATR = '" & oUtente.IDUser & "'", con)
      scRiposi.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
      con.Open()
      If scRiposi.ExecuteScalar() > 0 Then
        pFestivita = True
      Else
        pFestivita = False
      End If

      con.Close()
    End If

  End Function
  Private Function pVestizioneDefinitiva(ByVal dal As Date) As Boolean
    'DM2020.03 - controllo che il mese e l'anno della richiesta ci sia già la vestizione definitiva
    Dim i As Integer = 0
    Dim AA As Integer
    Dim MM As Integer
    Dim sc As New SqlClient.SqlCommand("select * from dbo.AMPTG00F TURNIMATRICOLA where TURNIMATRICOLA.PTAAGG = @aa and TURNIMATRICOLA.PTMMGG = @mm ", con)
    AA = Year(dal)
    MM = Month(dal)
    sc.Parameters.Add("@aa", SqlDbType.Int).Value = AA.ToString
    sc.Parameters.Add("@mm", SqlDbType.Int).Value = MM.ToString
    con.Open()
    Dim drVestizione As SqlClient.SqlDataReader
    drVestizione = sc.ExecuteReader()
    If drVestizione.HasRows Then
      pVestizioneDefinitiva = True
    Else
      pVestizioneDefinitiva = False
    End If
    con.Close()
  End Function

  Private Function pTurnoNecessario(ByVal dal As Date) As Boolean
    'DM2020.02 - controllo che la data sia una festività: se lo è ritorno TRUE
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("exec Sp_SonoSuUnTurnoNecessario @Matricola, @Data", con)
    sc.Parameters.Add("@Matricola", SqlDbType.VarChar).Value = oUtente.IDUser
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
    con.Open()
    Dim drTurnoNecessario As SqlClient.SqlDataReader
    drTurnoNecessario = sc.ExecuteReader()
    If drTurnoNecessario.HasRows Then
      pTurnoNecessario = True
    Else
      pTurnoNecessario = False
    End If
    con.Close()
  End Function

  Private Function pTurnoAccertamentoEsteso(ByVal dal As Date) As Boolean
    'DM2020.03 - tabella TB_TURNI_ACCERTAMENTO_ESTESO: se ho un turno di quelli qui presenti, non posso fare congedi garantiti frazionati
    Dim i As Integer = 0
    Dim iTurno As Integer
    Dim iGRUPPOTURNO As String
    iTurno = pInCheTurnoSono(dal, iGRUPPOTURNO, 0, 0, 0, 0)

    Dim sc As New SqlClient.SqlCommand("SELECT TOP 1000 [TURNI],[GRUPPI],[TIPO] FROM TB_TURNI_ACCERTAMENTO_ESTESO where turni = @TURNO", con)
    sc.Parameters.Add("@TURNO", SqlDbType.Int).Value = iTurno
    con.Open()
    Dim drTurnoAccert As SqlClient.SqlDataReader
    drTurnoAccert = sc.ExecuteReader()
    If drTurnoAccert.HasRows Then
      pTurnoAccertamentoEsteso = True
    Else
      pTurnoAccertamentoEsteso = False
    End If
    drTurnoAccert.Close()
    con.Close()
  End Function
  Private Function pGetTurno(ByVal Matricola As String, ByVal dal As Date) As Integer
    Dim conf As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Dim com As New Odbc.OdbcCommand(conf.GetValue("SelectTurnoGiornalieroAccertatore", GetType(String)), conAS400)
    Dim s As String = com.CommandText
    s = s.Replace("@PTMATR", Matricola)
    s = s.Replace("@PTAAGG", CDate(dal).Year)
    s = s.Replace("@PTMMGG", CDate(dal).Month)
    s = s.Replace("@PTGGGG", CDate(dal).Day)
    com.CommandText = s
    Try
      conAS400.Open()
      pGetTurno = com.ExecuteScalar()
      conAS400.Close()

    Catch ex As Exception
      Throw ex
    End Try
  End Function

  Private Function pInCheTurnoSono(ByVal dal As Date, ByRef inpGruppoTurni As String, ByRef OraEnt1 As Integer, ByRef MinEnt1 As Integer, ByRef OraUsc1 As Integer, ByRef MinUsc1 As Integer) As Integer
    'DM2020.02 - controllo in che turno sono 
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("exec Sp_InCheTurnoSono @Matricola, @Data", con)
    sc.Parameters.Add("@Matricola", SqlDbType.VarChar).Value = oUtente.IDUser
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
    con.Open()
    Dim drTurno As SqlClient.SqlDataReader
    Dim OraMin1 As String
    Dim OraMin2 As String
    Dim OraMin3 As String
    Dim OraMin4 As String
    drTurno = sc.ExecuteReader()
    If drTurno.HasRows Then
      While drTurno.Read
        'DM2020.04 migliorato e preso anche la data DA e data A 
        'conteggio dei campi parte da 0
        pInCheTurnoSono = drTurno.GetValue(8)                 'TUCTUR
        inpGruppoTurni = drTurno.GetString(7).ToString.Trim   'TUGRUA
        '
        OraMin1 = drTurno.GetValue(16) '16 - GOENT1
        OraMin2 = drTurno.GetValue(17)  '17 - GOUSC1
        '
        OraMin3 = drTurno.GetValue(18) '18 - GOENT2
        OraMin4 = drTurno.GetValue(19)  '18 - GOUSC2


        OraEnt1 = Left(OraMin1, 2)
        MinEnt1 = Right(OraMin1, 2)
        'DM2020.04 - potrebbe esserci un orario tipo le 2630 (cioè le 2 e 30 di notte)
        '           in questo caso controllo e tolgo 24 dall'ora
        If OraMin3 = "9999" Then
          If Left(OraMin2, 2) >= 24 Then
            OraUsc1 = Left(OraMin2, 2) - 24
          Else
            OraUsc1 = Left(OraMin2, 2)
          End If
          MinUsc1 = Right(OraMin2, 2)
        Else
          If Left(OraMin4, 2) >= 24 Then
            OraUsc1 = Left(OraMin4, 2) - 24
          Else
            OraUsc1 = Left(OraMin4, 2)
          End If
          MinUsc1 = Right(OraMin4, 2)
        End If
      End While


    Else
      pInCheTurnoSono = 0
    End If
    drTurno.Close()
    con.Close()
  End Function

  Private Sub dgCongediFrazionati_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCongediFrazionati.Load


  End Sub

  Private Sub dgCongediFrazionati_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCongediFrazionati.SelectedIndexChanged

  End Sub

  Private Sub dgCongediFrazionati_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCongediFrazionati.PreRender
    Dim sTIPO As String
    Dim iOraEnt As Integer
    Dim iMinEnt As Integer
    Dim iOraUsc As Integer
    Dim iMinUsc As Integer
    Dim iTURNO As Integer
    Dim iMassimoMinuti As Integer
    Dim pOraEnt As String
    Dim pMinEnt As String
    Dim pOraUsc As String
    Dim pMinUsc As String
    If dgCongediFrazionati.EditItemIndex <> -1 Then
      iTURNO = pInCheTurnoSono(DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("caData"), Calendar).SelectedDate, sTIPO, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
      ''If iTURNO <> "0" Then
      'Beep()
      'Else
      If Not oUtente.bStoInserendo Then
        pOraEnt = DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlDalleOre"), DropDownList).SelectedValue
        pMinEnt = DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlDaMinuti"), DropDownList).SelectedValue
        pOraUsc = DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlAlleOre"), DropDownList).SelectedValue
        pMinUsc = DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlAMinuti"), DropDownList).SelectedValue
        CaricaListeGiorni(dgCongediFrazionati.EditItemIndex, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
        If pOraEnt >= iOraEnt Then
          On Error Resume Next
          DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlDalleOre"), DropDownList).SelectedValue = Right("00" + pOraEnt, 2)
          DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlDaMinuti"), DropDownList).SelectedValue = Right("00" + pMinEnt, 2)
          DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlAlleOre"), DropDownList).SelectedValue = Right("00" + pOraUsc, 2)
          DirectCast(dgCongediFrazionati.Items(dgCongediFrazionati.EditItemIndex).FindControl("ddlAMinuti"), DropDownList).SelectedValue = Right("00" + pMinUsc, 2)
          On Error GoTo 0
        End If
      Else
        CaricaListeGiorni(dgCongediFrazionati.EditItemIndex, iOraEnt, iMinEnt, iOraUsc, iMinUsc)
      End If

      'End If
    End If
  End Sub

  Private Sub CaricaListeGiorni(ByVal InpIndex As Integer, ByVal DaOra As Integer, ByVal DaMinuto As Integer, ByVal AOra As Integer, ByVal AMinuto As Integer)
    'DM2020.04
    Dim I As Integer
    Dim bDrastico As Boolean
    ' QUESTO FLAG LO METTO A LIVELLO DI PROGRAMMAZIONE. Ora questa SUB la posso usare dovunque.
    '       se poi vorrò essere drastico, la metto a TRUE. Altrimenti riempio l'intera lista di ore da 0 a 23
    bDrastico = True

    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).Items.Clear()
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).Items.Clear()
    '-- Può accadere che l'ora A sia più piccola di ora DA. Quando c'è un turno di notte.
    '-- in questo caso faccio due for... una fino alla ORA DA... fino alle 23 e l'altra dalle 00 all'ora A
    If bDrastico Then
      If AOra > DaOra Then
        For I = DaOra To AOra
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
      Else
        For I = 0 To AOra
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
        For I = DaOra To 23
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
          DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        Next I
      End If
    Else
      For I = 0 To 23
        DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
        DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
      Next I
    End If
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDaMinuti"), DropDownList).Items.Clear()
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAMinuti"), DropDownList).Items.Clear()
    For I = 0 To 59
      DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDaMinuti"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
      DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAMinuti"), DropDownList).Items.Add(Right("00" + I.ToString, 2))
    Next I
    '
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDalleOre"), DropDownList).SelectedValue = Right("00" + DaOra.ToString, 2)
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAlleOre"), DropDownList).SelectedValue = Right("00" + AOra.ToString, 2)
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlDaMinuti"), DropDownList).SelectedValue = Right("00" + DaMinuto.ToString, 2)
    DirectCast(dgCongediFrazionati.Items(InpIndex).FindControl("ddlAMinuti"), DropDownList).SelectedValue = Right("00" + AMinuto.ToString, 2)
  End Sub
End Class
