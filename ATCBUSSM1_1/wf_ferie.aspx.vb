Public Class wf_ferie
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daRichiesteFerie = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.comMensileAperto = New System.Data.Odbc.OdbcCommand
    Me.DsRichiesteFerie1 = New ATCBussm1.dsRichiesteFerie
    Me.conDep = New System.Data.SqlClient.SqlConnection
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daRichiesteFerie
    '
    Me.daRichiesteFerie.DeleteCommand = Me.SqlCommand2
    Me.daRichiesteFerie.InsertCommand = Me.SqlInsertCommand1
    Me.daRichiesteFerie.SelectCommand = Me.SqlSelectCommand1
    Me.daRichiesteFerie.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteFerie", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daRichiesteFerie.UpdateCommand = Me.SqlCommand1
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.RichiesteFerie WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteFerie (IdRichiesta, IdAccertatore, DalGiorno, AlGiorno) " & _
    "VALUES (@IdRichiesta, @IdAccertatore, @DalGiorno, @AlGiorno)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Nome + ' ' + U.Cognome AS Approvatore, RF.IdRichiesta, RF.IdAccertatore," & _
    " RF.DalGiorno, RF.AlGiorno, CASE WHEN RF.StatoApprovazione IS NULL THEN 'Da appr" & _
    "ovare' WHEN RF.StatoApprovazione = 0 THEN 'Respinta' WHEN RF.StatoApprovazione =" & _
    " 1 THEN 'Approvata' END AS StatoApprovazione, RF.DataApprovazione, RF.IdApprovat" & _
    "ore, RF.ts FROM dbo.RichiesteFerie RF LEFT OUTER JOIN dbo.ATC_Utenti U ON RF.IdA" & _
    "pprovatore = U.ID WHERE (RF.IdAccertatore = @IdAccertatore) AND (RF.DalGiorno > " & _
    "GETDATE()) ORDER BY RF.ts DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "UPDATE dbo.RichiesteFerie SET DalGiorno = @DalGiorno, AlGiorno = @AlGiorno, ts = " & _
    "DATEADD(second, 2, GETDATE()) WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
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
    CType(Me.DsRichiesteFerie1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
	Protected WithEvents con As System.Data.SqlClient.SqlConnection
	Protected WithEvents daRichiesteFerie As System.Data.SqlClient.SqlDataAdapter
	Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
	Protected WithEvents comMensileAperto As System.Data.Odbc.OdbcCommand
	Protected WithEvents DsRichiesteFerie1 As ATCBussm1.dsRichiesteFerie
	Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
	Protected WithEvents btnAddFerie As System.Web.UI.WebControls.Button
	Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
	Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
	Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
	Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
	Protected WithEvents conDep As System.Data.SqlClient.SqlConnection
  Protected WithEvents dgFerie As System.Web.UI.WebControls.DataGrid

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

    daRichiesteFerie.SelectCommand.Parameters("@IDAccertatore").Value = oUtente.ID
    daRichiesteFerie.Fill(DsRichiesteFerie1, "RichiesteFerie")
    If Not IsPostBack Then
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Pagina iniziale", Session("IPAddress"))

    End If
  End Sub

  Public Sub cvDataDal_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    ' commentati i vincoli del mensile aperto e dei due mesi di preavviso

    'Dim MeseMensileAperto As String
    'conAS400.Open()
    'MeseMensileAperto = "" & comMensileAperto.ExecuteScalar
    'conAS400.Close()
    'If MeseMensileAperto.Length > 0 Then
    '	Dim d As Date = Date.Parse(MeseMensileAperto)
    '	If Now.Date < d Then
    '		args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= d.Date
    '		DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(d, "Y")
    '	Else
    '		args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
    '		DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")
    '	End If
    'Else
    '	args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.AddDays(-Now.Day + 1).AddMonths(2).Date
    '	DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now.AddDays(-Now.Day + 1).AddMonths(2), "Y")
    '  End If

    '''
    ''' modifica per assegnare stessi controlli dei congedi
    '''
    If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate > pDate48H) Then
      'If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date) Then
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate <= Now.Date.AddDays(60)
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere delle ferie oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")
    Else
      'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate > pDate48H
      'DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")
      DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire dal " & Format(pDate48H.AddDays(1), "dd/MM/yyyy")

    End If
    'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
    'DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")

  End Sub

  Private Sub btnAddFerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFerie.Click
    Dim dr As DataRow = DsRichiesteFerie1.Tables("RichiesteFerie").NewRow
    Dim MeseMensileAperto As String
    dr.Item("IdRichiesta") = Guid.NewGuid
    dr.Item("IdAccertatore") = oUtente.ID
    'conAS400.Open()
    'MeseMensileAperto = "" & comMensileAperto.ExecuteScalar
    'conAS400.Close()
    'If MeseMensileAperto.Length > 0 Then
    '  Dim d As Date = Date.Parse(MeseMensileAperto)
    '  If Now.Date < d Then
    '    dr.Item("DalGiorno") = d
    '    dr.Item("AlGiorno") = d.AddDays(4)
    '  Else
    '    dr.Item("DalGiorno") = Now
    '    dr.Item("AlGiorno") = Now.AddDays(4)
    '  End If
    'Else
    '  dr.Item("DalGiorno") = Now.AddDays(-Now.Day + 1).AddMonths(2)
    '  dr.Item("AlGiorno") = Now.AddDays(-Now.Day + 1).AddMonths(2).AddDays(4)
    'End If

    '''
    ''' modifica per assegnare stessi controlli dei congedi
    '''
    'dr.Item("DalGiorno") = Now.AddDays(1)
    'dr.Item("AlGiorno") = Now.AddDays(5)
    dr.Item("DalGiorno") = pDate48H.AddDays(1)
    dr.Item("AlGiorno") = pDate48H.AddDays(6)

    DsRichiesteFerie1.Tables("RichiesteFerie").Rows.InsertAt(dr, 0)
    dgFerie.EditItemIndex = 0
    Page.DataBind()
    btnAddFerie.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Click nuova richiesta ferie", Session("IPAddress"))
  End Sub

  Private Sub dgFerie_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      dgFerie.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnAddFerie.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Inizio modifica richiesta ferie", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgFerie_CancelCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    dgFerie.EditItemIndex = -1
    Page.DataBind()
    btnAddFerie.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Annullata modifica della richiesta ferie", Session("IPAddress"))

  End Sub

  Private Sub dgFerie_UpdateCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    Me.Validate()
    If Me.IsValid Then
      Dim dr As DataRow = DsRichiesteFerie1.Tables("RichiesteFerie").Rows.Find(dgFerie.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsRichiesteFerie1.Tables("RichiesteFerie").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatore") = oUtente.ID
        DsRichiesteFerie1.Tables("RichiesteFerie").Rows.Add(dr)
      End If
      dr.Item("DalGiorno") = DirectCast(e.Item.FindControl("caDalGiorno"), Calendar).SelectedDate
      dr.Item("AlGiorno") = DirectCast(e.Item.FindControl("caAlGiorno"), Calendar).SelectedDate

      'FT - !!! Per vedere anche l'orario di inserimento (campo TS) della riga appena inserita devo svuotare la tabella e riempirla nuovamente
      Dim richiesteG As String
      richiesteG = ""
      richiesteG = RichiestePresenti(dr.Item("DalGiorno"), dr.Item("AlGiorno"))
      If Not (richiesteG = "") Then

        DirectCast(e.Item.FindControl("cvMinDataAl"), CustomValidator).ErrorMessage = "Sono già presenti dei giustificativi: <br/>" & richiesteG
        DirectCast(e.Item.FindControl("cvMinDataAl"), CustomValidator).IsValid = False

      Else
        daRichiesteFerie.Update(DsRichiesteFerie1, "RichiesteFerie")
        DsRichiesteFerie1.Tables("RichiesteFerie").Clear()
        daRichiesteFerie.Fill(DsRichiesteFerie1, "RichiesteFerie")
        'FT - !!!
        dgFerie_CancelCommand(source, e)
        fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Confermato inserimento/modifica della richiesta ferie", Session("IPAddress"))

      End If

    End If

  End Sub

  Private Sub dgFerie_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsRichiesteFerie1.Tables("RichiesteFerie").Rows.Find(dgFerie.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daRichiesteFerie.Update(DsRichiesteFerie1, "RichiesteFerie")
        fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Eliminata richiesta ferie", Session("IPAddress"))
      End If
      dgFerie_CancelCommand(source, e)
    End If

  End Sub

  Private Sub dgFerie_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler 4re questa richiesta di ferie?');")
  End Sub

  Public Sub cvMinDataAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate.AddDays(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)
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
  Private Function RichiestePresenti(ByVal dal As Date, ByVal al As Date) As String
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("SELECT G.AccertatoreId, G.OraDa, G.OraA, G.DataRichiesta, C.Nome " & _
                        " FROM Accertatori_GiustificativoRichiesta AS G INNER JOIN " & _
                        " Accertatori_GiustificativoCausale AS C ON G.Accertatori_GiustificativoCausaleId = C.ID " & _
                        " WHERE ((G.StatoGiustificativo IS NULL) OR (G.StatoGiustificativo = 0) OR " & _
                        " (G.StatoGiustificativo = 1)) and  AccertatoreId  = " & oUtente.ID.ToString() & " " & _
                        " and not (G.OraA<CONVERT(DATETIME, '" & Replace(Format(dal, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) or G.OraDa>CONVERT(DATETIME, '" & Replace(Format(al, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) )", con)
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
  '''
  ''' modifica per assegnare stessi controlli dei congedi
  '''
  Private Function Date48H() As DateTime
    Dim i As Integer = 0

    Dim data As DateTime = Now.Date
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    'DM2020.01 - FINO ALLE 18.00
    If (Now.Hour >= 18) Then
      data = Now.AddDays(1)
    End If

    Do While i < 2
      data = data.AddDays(1)
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      ' Modifica del 2018/11/06 per problema dopo ore 17 in caso di festività
      'sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = data
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = data.Date

      con.Open()
      If (data.DayOfWeek <> DayOfWeek.Sunday And sc.ExecuteScalar() <= 0) Then i += 1
      fnc.ScriviLog(oUtente.IDUser, "wf_ferie.aspx", "Controllo festività: " & sc.CommandText & "  " & data.ToString() & " Risultato: " & (data.DayOfWeek <> DayOfWeek.Sunday And sc.ExecuteScalar() <= 0), Session("IPAddress"))
      con.Close()
    Loop
    'Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    'riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(data, "dd/MM/yyyy")
    Date48H = data
  End Function


End Class
