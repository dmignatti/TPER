Public Class wf_spostamentoRiposo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daRichiesteSpostamentoRiposo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.comMensileAperto = New System.Data.Odbc.OdbcCommand
    Me.DsRichiesteFerie1 = New ATCBussm1.dsRichiesteFerie
    Me.conDep = New System.Data.SqlClient.SqlConnection
    Me.DsRichiesteSpostamentoRiposo1 = New ATCBussm1.DsRichiesteSpostamentoRiposo
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsRichiesteSpostamentoRiposo1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daRichiesteSpostamentoRiposo
    '
    Me.daRichiesteSpostamentoRiposo.DeleteCommand = Me.SqlCommand2
    Me.daRichiesteSpostamentoRiposo.InsertCommand = Me.SqlInsertCommand1
    Me.daRichiesteSpostamentoRiposo.SelectCommand = Me.SqlSelectCommand1
    Me.daRichiesteSpostamentoRiposo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteSpostamentoRiposo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daRichiesteSpostamentoRiposo.UpdateCommand = Me.SqlCommand1
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.RichiesteSpostamentoRiposo WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteSpostamentoRiposo (IdRichiesta, IdAccertatore, DalGiorno" & _
    ", AlGiorno, DalleOre, AlleOre, TipoSpostamento) VALUES (@IdRichiesta, @IdAccerta" & _
    "tore, @DalGiorno, @AlGiorno, @DalleOre, @AlleOre, @TipoSpostamento)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 12, "DalleOre"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 12, "AlleORe"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoSpostamento", System.Data.SqlDbType.VarChar, 1, "TipoSpostamento"))

    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Nome + ' ' + U.Cognome AS Approvatore, RF.IdRichiesta, RF.IdAccertatore," & _
    " RF.TipoSpostamento, convert(date, RF.DalGiorno) as DalGiorno,  RF.AlGiorno, RF." & _
    "DalleOre, RF.AlleOre, CASE WHEN RF.StatoApprovazione IS NULL THEN 'Da approvare'" & _
    " WHEN RF.StatoApprovazione = 0 THEN 'Respinta' WHEN RF.StatoApprovazione = 1 THE" & _
    "N 'Approvata' END AS StatoApprovazione, RF.DataApprovazione, RF.IdApprovatore, R" & _
    "F.ts FROM dbo.RichiesteSpostamentoRiposo RF LEFT OUTER JOIN dbo.ATC_Utenti U ON " & _
    "RF.IdApprovatore = U.ID WHERE (RF.IdAccertatore = @IdAccertatore) AND (RF.DalGio" & _
    "rno > GETDATE()) ORDER BY RF.ts DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.RichiesteSpostamentoRiposo SET TipoSpostamento=@TipoSpostamento, DalGi" & _
    "orno = @DalGiorno, AlGiorno = @AlGiorno, DalleOre = @DalleOre, AlleOre = @AlleOr" & _
    "e, ts = DATEADD(second, 2, GETDATE()) WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoSpostamento", System.Data.SqlDbType.VarChar, 1, "TipoSpostamento"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 12, "DalleOre"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 12, "AlleOre"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'comMensileAperto
    '
    Me.comMensileAperto.CommandText = CType(configurationAppSettings.GetValue("SelectCheckMensileAperto", GetType(System.String)), String)
    Me.comMensileAperto.Connection = Me.conAS400
    '
    'DsRichiesteFerie1
    '
    Me.DsRichiesteFerie1.DataSetName = "dsRichiesteFerie"
    Me.DsRichiesteFerie1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conDep
    '
    Me.conDep.ConnectionString = CType(configurationAppSettings.GetValue("conDep.ConnectionString", GetType(System.String)), String)
    '
    'DsRichiesteSpostamentoRiposo1
    '
    Me.DsRichiesteSpostamentoRiposo1.DataSetName = "DsRichiesteSpostamentoRiposo"
    Me.DsRichiesteSpostamentoRiposo1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsRichiesteSpostamentoRiposo1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents comMensileAperto As System.Data.Odbc.OdbcCommand
  Protected WithEvents DsRichiesteFerie1 As ATCBussm1.dsRichiesteFerie
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents conDep As System.Data.SqlClient.SqlConnection
  Protected WithEvents daRichiesteSpostamentoRiposo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsRichiesteSpostamentoRiposo1 As ATCBussm1.DsRichiesteSpostamentoRiposo
  Protected WithEvents dgSpostamentoRiposo As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents pnlData As System.Web.UI.WebControls.Panel
  Protected WithEvents ddlDataCal As System.Web.UI.WebControls.Calendar
  Protected WithEvents cvData As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents btnOk As System.Web.UI.WebControls.Button
  Protected WithEvents btnAnnulla As System.Web.UI.WebControls.Button
  Protected WithEvents cvTurnoVuoto As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvEccezioni As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTurnoOkGiornaliero As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvSoloUnCambio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvGiornalieroAbilitato As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvbloccoCambio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvCheckPatente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents DdlData As System.Web.UI.WebControls.DropDownList

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
    '''
    ''' modifica per assegnare stessi controlli dei congedi
    '''
    pDate48H = Date48H()
    'DM2020.04 - caricalista - solo la prima volta


  End Sub

#End Region

  '''
  ''' modifica per assegnare stessi controlli dei congedi
  '''
  Private pDate48H As DateTime

  Dim oUtente As Utente
  Dim fnc As New Funzioni


  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")

    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    daRichiesteSpostamentoRiposo.SelectCommand.Parameters("@IDAccertatore").Value = oUtente.ID
    daRichiesteSpostamentoRiposo.Fill(DsRichiesteSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
    If Not IsPostBack Then
      CaricaLista()
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Pagina iniziale", Session("IPAddress"))

    End If
  End Sub

  Public Sub cvDataDal_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    ' commentati i vincoli del mensile aperto e dei due mesi di preavviso
    ''' modifica per assegnare stessi controlli dei congedi
    '''
    If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate > pDate48H) Then
      'If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date) Then
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate <= Now.Date.AddDays(60)
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere spostamenti oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")
    Else
      'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate > pDate48H

      DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere spostamenti solo a partire dal " & Format(pDate48H.AddDays(1), "dd/MM/yyyy")

    End If
    'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date


  End Sub

  Private Sub dgSpostamentoRiposo_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler fare questa richiesta?');")
  End Sub

  Public Sub cvMinDataAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    Dim DAL As Date
    Dim AL As Date
    AL = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate
    DAL = DdlData.SelectedValue
    If DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate <= pDate48H Then
      DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere spostamenti solo a partire dal " & Format(pDate48H.AddDays(1), "dd/MM/yyyy")
      args.IsValid = False
    Else
      args.IsValid = Not pFestivita(AL)
      If args.IsValid Then
        DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile spostare un giorno feriale in un sabato o festivo"
        args.IsValid = Not (DAL.DayOfWeek < DayOfWeek.Saturday And AL.DayOfWeek >= DayOfWeek.Saturday)
      End If
    End If
  End Sub

  Public Sub cvMeseDataDalAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    'args.IsValid = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)
    args.IsValid = True
  End Sub

  Private Function pCountFestivita(ByVal dal As Date, ByVal al As Date) As Integer
    Dim i As Integer = 0
    Do While dal <= al
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
      Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
      riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
      con.Open()
      If dal.DayOfWeek = DayOfWeek.Sunday Or sc.ExecuteScalar() > 0 Or riposi.ExecuteScalar() > 0 Then i += 1
      con.Close()
      dal = dal.AddDays(1)
    Loop
    pCountFestivita = i

  End Function


  Private Sub dgSpostamentoRiposo_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgSpostamentoRiposo.DeleteCommand

    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daRichiesteSpostamentoRiposo.Update(DsRichiesteSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
        fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Eliminata richiesta", Session("IPAddress"))
      End If
      dgSpostamentoRiposo_CancelCommand(source, e)
    End If


  End Sub

  Private Sub dgSpostamentoRiposo_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgSpostamentoRiposo.EditCommand

    If e.CommandName = "Edit" Then
      'DM2020.04 se sto modificando, lo scrivo e mi porto dietro la riga che modifico
      oUtente.bStoInserendo = False
      oUtente.iRigaModifico = e.Item.ItemIndex
      DdlData.SelectedValue = FormatDateTime(e.Item.Cells(3).Text, DateFormat.ShortDate)
      pShowPanel(True)
    Else
      'DM2020.04 - se sto inserendo lo scrivo e non mi interesso della riga in cui sono
      oUtente.bStoInserendo = True
      oUtente.iRigaModifico = 0
      dgSpostamentoRiposo.EditItemIndex = e.Item.ItemIndex
    End If
    Page.DataBind()

    btnAdd.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Inizio modifica richiesta spostamento", Session("IPAddress"))


  End Sub

  Private Sub dgSpostamentoRiposo_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgSpostamentoRiposo.CancelCommand


    dgSpostamentoRiposo.EditItemIndex = -1
    Page.DataBind()
    btnAdd.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Annullata modifica della richiesta spostamento", Session("IPAddress"))


  End Sub

  Private Sub dgSpostamentoRiposo_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgSpostamentoRiposo.UpdateCommand


    Me.Validate()
    If Me.IsValid Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatore") = oUtente.ID

        DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Add(dr)
      End If
      'DM2020.04
      dr.Item("DalGiorno") = FormatDateTime(DdlData.SelectedValue, DateFormat.ShortDate)
      dr.Item("AlGiorno") = DirectCast(e.Item.FindControl("caAlGiorno"), Calendar).SelectedDate

      'DM2020.04 - update anche sul TIPOSPOSTAMENTO
      If DirectCast(e.Item.FindControl("RTipoF"), RadioButton).Checked Then
        dr.Item("TipoSpostamento") = "F"
      ElseIf DirectCast(e.Item.FindControl("RTipoS"), RadioButton).Checked Then
        dr.Item("TipoSpostamento") = "S"
      Else
        dr.Item("TipoSpostamento") = ""
      End If
      'DM2020.05 - inserisco anche DALLEORE e ALLEORE      
      If DirectCast(e.Item.FindControl("RTipoF"), RadioButton).Checked Or DirectCast(e.Item.FindControl("RTipoS"), RadioButton).Checked Then
        dr.Item("DalleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue, 0).Ticks
        dr.Item("AlleOre") = New TimeSpan(DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue, DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue, 0).Ticks
      Else
        dr.Item("DalleOre") = New TimeSpan(0).Ticks
        dr.Item("AlleOre") = New TimeSpan(0).Ticks       
      End If


      daRichiesteSpostamentoRiposo.Update(DsRichiesteSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
      DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Clear()
      daRichiesteSpostamentoRiposo.Fill(DsRichiesteSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
      dgSpostamentoRiposo_CancelCommand(source, e)
      fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Confermato inserimento/modifica della richiesta ", Session("IPAddress"))



    End If


  End Sub
  Private Sub pShowPanel(ByVal Flag As Boolean)
    pnlData.Visible = Flag
    btnAdd.Enabled = Not Flag
    For Each item As Control In pnlData.Controls
      item.Visible = Flag
    Next
  End Sub
  Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    oUtente.bStoInserendo = True
    oUtente.iRigaModifico = 0
    pShowPanel(True)
  End Sub



  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    Me.Validate()
    If Me.IsValid Then
      Dim MeseMensileAperto As String
      Dim dr As DataRow
      If oUtente.bStoInserendo Then
        'DM2020.04 - se sto inserendo davvero, creo una nuova GUID
        dr = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid

      Else
        dr = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(oUtente.iRigaModifico))

      End If
      dr.Item("IdAccertatore") = oUtente.ID
      dr.Item("DalGiorno") = FormatDateTime(DdlData.SelectedValue, DateFormat.ShortDate)
      dr.Item("AlGiorno") = pDate48H.AddDays(1).Date

      'DM2020.04 - rifaccio il controllo se io stia o meno facendo un inserimento, per capire se fare ADD o UPDATE
      If oUtente.bStoInserendo Then
        DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.InsertAt(dr, 0)
      Else
        '-- DM2020.04 - non faccio UPDATE finché non vado nella riga e decido lì se farlo o meno
        '--> daRichiesteSpostamentoRiposo.Update(DsRichiesteSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
        '-- 
      End If
      dgSpostamentoRiposo.EditItemIndex = oUtente.iRigaModifico

      Page.DataBind()

      '----------------------------------------------------
      '
      If oUtente.iRigaModifico >= 0 Then
        If dgSpostamentoRiposo.Items(oUtente.iRigaModifico).FindControl("LblTIPO") Is Nothing Then
          If dr.Item("TipoSpostamento").ToString = "S" Then
            DirectCast(dgSpostamentoRiposo.Items(oUtente.iRigaModifico).FindControl("RTipoS"), RadioButton).Checked = True
          ElseIf dr.Item("TipoSpostamento").ToString = "F" Then
            DirectCast(dgSpostamentoRiposo.Items(oUtente.iRigaModifico).FindControl("RTipoF"), RadioButton).Checked = True
          Else
            DirectCast(dgSpostamentoRiposo.Items(oUtente.iRigaModifico).FindControl("RTipoD"), RadioButton).Checked = True
          End If
        End If
      End If

      '----------------------------------------------------
      btnAdd.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Click nuova richiesta spostamento", Session("IPAddress"))
      pShowPanel(False)
    End If
  End Sub

  Private Sub btnAnnulla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
    pShowPanel(False)
    ' --- annullo i dati che mi ero segnato come notifica di modifica
    oUtente.bStoInserendo = False
    oUtente.iRigaModifico = 0
    '
    fnc.ScriviLog(oUtente.IDUser, "wf_spostamentoRiposo.aspx", "Annullata richiesta nuovo spostamento", Session("IPAddress"))
  End Sub
#Region " Funzioni interne VAR "
  '''
  ''' modifica per assegnare stessi controlli dei congedi
  '''
  Private Function Date48H() As DateTime
    Dim i As Integer = 0

    Dim data As DateTime = Now.Date
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    'DM2020.01 - FINO ALLE 18.00
    'DM2020.01 -> precedente --> If (Now.Hour >= 17) Then
    If (Now.Hour >= 18) Then
      data = Now.AddDays(1)
    End If

    Do While i < 2
      data = data.AddDays(1)
      If Not pFestivita(data) Then i = i + 1
      fnc.ScriviLog(oUtente.IDUser, "wf_SpostamentoRiposo.aspx", "Controllo festività: " & data.ToString() & " i= " & i.ToString, Session("IPAddress"))
    Loop
    'Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    'riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(data, "dd/MM/yyyy")
    Date48H = data
  End Function
  Sub CaricaLista()
    'DM2020.04 - carichiao la lista di tutti i possibili giorni di riposo
    Dim i As Integer
    Dim cmdriposo As New SqlClient.SqlCommand("SELECT convert(date,  cast([PTAAGG] as varchar)  " & _
          " + '-' + cast([PTMMGG] as varchar) + '-' +  cast([PTGGGG] as varchar), 102)  as data,  " & _
          " [PTMATR],[PTGGGG],[PTMMGG],[PTAAGG],[PTCTUR],[PTFLSM] " & _
          " FROM [AMPTG00F]  " & _
          " where PTMATR = '" & oUtente.IDUser & "' " & _
          " and convert(datetime,  cast([PTAAGG] as varchar) + '-' + cast([PTMMGG] as varchar) + '-' +  cast([PTGGGG] as varchar), 102)>GETDATE()+1 " & _
          " and PTCTUR >= 90000 ", con)
    ''' " and PTGGGG > " & Day(Now.AddDays(2).ToString) & " and PTMMGG >= " & Month(Now).ToString & " and PTAAGG >= " & Year(Now).ToString & _
    Dim DrRiposi As SqlClient.SqlDataReader
    con.Open()
    DrRiposi = cmdriposo.ExecuteReader()
    i = 0
    If DrRiposi.HasRows Then
      Do While DrRiposi.Read
        If FormatDateTime(System.Convert.ToString(DrRiposi("data")), DateFormat.ShortDate) > FormatDateTime(pDate48H, DateFormat.ShortDate) Then
          DdlData.Items.Add(FormatDateTime(System.Convert.ToString(DrRiposi("data")), DateFormat.ShortDate))
          i = i + 1
        End If
      Loop
    End If
    con.Close()

    DdlData.DataBind()
  End Sub



  Private Sub dgSpostamentoRiposo_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgSpostamentoRiposo.ItemDataBound
    'DM2020.04 - Quando mostro la tabella scrivo al posto del LBLTIPO il vero TipoSpostamento

    If Not e.Item.FindControl("LblTIPO") Is Nothing Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      DirectCast(e.Item.FindControl("LblTIPO"), Label).Text = dr.Item("TipoSpostamento").ToString

      If dr.Item("TipoSpostamento").ToString.Trim <> "" Then
        DirectCast(e.Item.FindControl("LblALGIORNO"), Label).Visible = False
        DirectCast(e.Item.FindControl("LblDalleOre"), Label).Visible = True
        DirectCast(e.Item.FindControl("LblAlleOre"), Label).Visible = True
      Else
        DirectCast(e.Item.FindControl("LblALGIORNO"), Label).Visible = True
        DirectCast(e.Item.FindControl("LblDalleOre"), Label).Visible = False
        DirectCast(e.Item.FindControl("LblAlleOre"), Label).Visible = False
      End If
    End If

    If Not e.Item.FindControl("lblDalleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    If Not e.Item.FindControl("lblAlleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    If Not e.Item.FindControl("ddlDalleOre") Is Nothing Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(IIf(IsDBNull(dr.Item("DalleOre")), 0, dr.Item("DalleOre")))
      DirectCast(e.Item.FindControl("ddlDalleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlDaMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(IIf(IsDBNull(dr.Item("DalleOre")), 0, dr.Item("DalleOre")))
      DirectCast(e.Item.FindControl("ddlDaMinuti"), DropDownList).SelectedValue = t.Minutes
    End If
    If Not e.Item.FindControl("ddlAlleOre") Is Nothing Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(IIf(IsDBNull(dr.Item("AlleOre")), 0, dr.Item("AlleOre")))
      DirectCast(e.Item.FindControl("ddlAlleOre"), DropDownList).SelectedValue = t.Hours
    End If
    If Not e.Item.FindControl("ddlAMinuti") Is Nothing Then
      Dim dr As DataRow = DsRichiesteSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Rows.Find(dgSpostamentoRiposo.DataKeys(e.Item.ItemIndex))
      Dim t As New TimeSpan(IIf(IsDBNull(dr.Item("AlleOre")), 0, dr.Item("AlleOre")))
      DirectCast(e.Item.FindControl("ddlAMinuti"), DropDownList).SelectedValue = t.Minutes
    End If

  End Sub

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
#End Region

  Private Sub dgSpostamentoRiposo_ItemCreated1(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgSpostamentoRiposo.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta?');")
  End Sub

  Private Sub dgSpostamentoRiposo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgSpostamentoRiposo.SelectedIndexChanged

  End Sub
End Class
