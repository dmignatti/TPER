Public Class wf_congediGarantiti
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCongediGarantiti = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsRichieste1 = New ATCBussm1.dsRichieste
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.OleConAS400 = New System.Data.OleDb.OleDbConnection
    CType(Me.DsRichieste1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCongediGarantiti
    '
    Me.daCongediGarantiti.DeleteCommand = Me.SqlCommand1
    Me.daCongediGarantiti.InsertCommand = Me.SqlInsertCommand1
    Me.daCongediGarantiti.SelectCommand = Me.SqlSelectCommand1
    Me.daCongediGarantiti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongedi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("DalleOre", "DalleOre"), New System.Data.Common.DataColumnMapping("AlleOre", "AlleOre"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta")})})
    Me.daCongediGarantiti.UpdateCommand = Me.SqlCommand2
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.RichiesteCongediGarantiti WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCongediGarantiti (IdRichiesta, IdAccertatore, DalGiorno," & _
    " AlGiorno) VALUES (@IdRichiesta, @IdAccertatore, @DalGiorno, @AlGiorno)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdRichiesta, IdAccertatore, DalGiorno, AlGiorno, dbo.GetOrderList(DalGiorn" & _
    "o, IdAccertatore) AS Ordine, CASE WHEN StatoApprovazione IS NULL THEN 'Da approv" & _
    "are' WHEN StatoApprovazione = 0 THEN 'Respinta' WHEN StatoApprovazione = 1 THEN " & _
    "'Approvata' END AS StatoRichiesta, ts FROM dbo.RichiesteCongediGarantiti WHERE (" & _
    "IdAccertatore = @IdAccertatore) AND (DalGiorno > GETDATE()) ORDER BY DalGiorno D" & _
    "ESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "UPDATE dbo.RichiesteCongediGarantiti SET DalGiorno = @DalGiorno, AlGiorno = @AlGi" & _
    "orno, ts = DATEADD(second, 2, GETDATE()) WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRichieste1
    '
    Me.DsRichieste1.DataSetName = "dsRichieste"
    Me.DsRichieste1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'OleConAS400
    '
    Me.OleConAS400.ConnectionString = "Maximum Decimal Precision=31;Cursor Sensitivity=3;Library List=;Sort Language ID=" & _
    ";Protection Level=None;Block Fetch=True;Force Translate=65535;Persist Security I" & _
    "nfo=True;Trace=0;Add Statements To SQL Package=True;Unusable SQL Package Action=" & _
    "1;Convert Date Time To Char=TRUE;Query Optimize Goal=0;Query Options File Librar" & _
    "y=;SQL Package Library Name=;Extended Properties=;Minimum Divide Scale=0;Block S" & _
    "ize=0;SQL Package Name=;Initial Catalog=ATC01;Sort Table=;Hex Parser Option=0;Ca" & _
    "talog Library List=;Sort Sequence=0;Maximum Decimal Scale=31;User ID=SCASOST;Pas" & _
    "sword=BUSSMVAR;Data Compression=True;Use SQL Packages=False;Transport Product=Cl" & _
    "ient Access;Provider=""IBMDA400"";SSL=DEFAULT;Data Source=ATC01;Naming Convention=" & _
    "0"
    CType(Me.DsRichieste1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DsRichieste1 As ATCBussm1.dsRichieste
  Protected WithEvents dgCongedi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnAddCongedo As System.Web.UI.WebControls.Button
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvOnModificaCongedo As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvOnEliminaCongedo As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents lblCongedi As System.Web.UI.WebControls.Label
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents daCongediGarantiti As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents OleConAS400 As System.Data.OleDb.OleDbConnection

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object


  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
    pDate48H = Date48H()
  End Sub

#End Region

  Private oUtente As Utente
  Private pDate48H As DateTime
  Dim fnc As New Funzioni
  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    'Filtro del dataset dei congedi a seconda dell'utente loggato.
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If


    cvTipoUtente.Validate()
    btnAddCongedo.Enabled = cvTipoUtente.IsValid And dgCongedi.EditItemIndex = -1

    daCongediGarantiti.SelectCommand.Parameters("@IdAccertatore").Value = oUtente.ID
    daCongediGarantiti.Fill(DsRichieste1)

    If Not IsPostBack Then

      fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Pagina iniziale", Session("IPAddress"))
      Page.DataBind()
    End If
  End Sub

  Private Sub btnAddCongedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCongedo.Click
    pAggiungiCongedo()

    fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Click nuova richiesta congedo", Session("IPAddress"))
  End Sub

  Private Sub dgCongedi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.CancelCommand
    dgCongedi.EditItemIndex = -1
    Page.DataBind()
    dgCongedi.Visible = DsRichieste1.Tables("RichiesteCongedi").Rows.Count > 0
    lblCongedi.Visible = DsRichieste1.Tables("RichiesteCongedi").Rows.Count <= 0
    btnAddCongedo.Enabled = True

    fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Annullata modifica", Session("IPAddress"))
  End Sub

  Private Sub dgCongedi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.UpdateCommand
    Me.Validate()
    If Me.IsValid Then
      Dim dr As Data.DataRow
      dr = DsRichieste1.Tables("RichiesteCongedi").Rows.Find(dgCongedi.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsRichieste1.Tables("RichiesteCongedi").NewRow
        dr.Item("IdRichiesta") = dgCongedi.DataKeys(e.Item.ItemIndex)
        DsRichieste1.Tables("RichiesteCongedi").Rows.Add(dr)
      End If
      dr.Item("IdAccertatore") = oUtente.ID
      dr.Item("DalGiorno") = DirectCast(e.Item.FindControl("caDalGiorno"), Calendar).SelectedDate
      dr.Item("AlGiorno") = DirectCast(e.Item.FindControl("caAlGiorno"), Calendar).SelectedDate
      Dim richiesteG As String
      richiesteG = ""
      richiesteG = RichiestePresenti(dr.Item("DalGiorno"), dgCongedi.DataKeys(e.Item.ItemIndex))
      If Not (richiesteG = "") Then
        '2) controllo che non ci sia già un'altra richiesta nel mese

        DirectCast(e.Item.FindControl("cvDal"), CustomValidator).ErrorMessage = richiesteG
        DirectCast(e.Item.FindControl("cvDal"), CustomValidator).IsValid = False

      Else
        daCongediGarantiti.Update(DsRichieste1, "RichiesteCongedi")
        DsRichieste1.Tables("RichiesteCongedi").Clear()
        daCongediGarantiti.Fill(DsRichieste1, "RichiesteCongedi")
        'FT - Toglie l'editing mode
        dgCongedi_CancelCommand(source, e)

        fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Confermato inserimento/modifica congedo", Session("IPAddress"))
      End If
    End If
  End Sub
  Private Function RichiestePresenti(ByVal dal As Date, ByVal InpIdRichiesta As Guid) As String
    'DM2020.03 - controllo che questo mese non ci sia già una richeista congedi garantiti
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("select * from [RichiesteCongediGarantiti] " & _
            " where month(Dalgiorno) = " & Month(dal) & _
            " and Idrichiesta <>  '" & InpIdRichiesta.ToString & "' " & _
            "    and IdAccertatore  = " & oUtente.ID.ToString() & _
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

  Public Sub cvDal_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate > Now.Date.AddDays(60)) Then
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate <= Now.Date.AddDays(60)
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere congedi oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")
    Else
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate > pDate48H

    End If
    'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate > pDate48H
  End Sub

  Public Sub cvAl_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caAlGiorno"), Calendar).SelectedDate >= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate
  End Sub

  Public Sub cvMaxGiorni_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    'args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caAlGiorno"), Calendar).SelectedDate.AddDays(-(pCountFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) + 4)) <= DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate

    Dim dal As Date = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate
    Dim al As Date = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caAlGiorno"), Calendar).SelectedDate
    'args.IsValid = al.Subtract(dal).TotalDays - pCountFestivita(dal, al) < 1
    args.IsValid = al.Subtract(dal).TotalDays < 1
  End Sub

  Public Sub cvPresente_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    'DM2020.03 - CONTROLLI PER VALIDARE L'INSERIMENTO
    Dim result As Boolean = True
    Dim dal As Date = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate
    Dim Ritorno As String
    Dim outResiduoFerie As String
    '--- DM2020.03 - 
    ' ---- Faccio i controlli che potrebbero impedire un INSERIMENTO
    ' 1) se è un giorno festivo, niente da fare
    If Not pVestizioneDefinitiva(dal) Then
      DirectCast(source, CustomValidator).ErrorMessage = "Vestizione definitiva non ancora creata per il mese di " & MonthName(Month(dal)).ToString
      result = False
    ElseIf CalcolaResiduoFerieSosta(dal, oUtente.IDUser, outResiduoFerie) Then
      DirectCast(source, CustomValidator).ErrorMessage = "Residuo ferie non positivo."
      result = False
    ElseIf pFestivita(dal) = True Then
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile scegliere un giorno festivo o di riposo"
      result = False
    ElseIf pTurnoNecessario(dal) = True Then
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile scegliere un giorno in cui ci sia un Turno Necessario"
      result = False
    End If
    'QUI AGGIUNGEREMEO SE RESIDUO FERIE HA UN VALORE

    args.IsValid = result
  End Sub
  'Public Sub cvDataOk_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= pDate48H
  'End Sub

  'Public Sub cvAlleOre_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
  '  If DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(1).Controls(1), Calendar).SelectedDate() = DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(2).Controls(1), Calendar).SelectedDate() Then
  '    Dim t1 As New TimeSpan(DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(3).Controls(5), DropDownList).SelectedValue, DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(3).Controls(7), DropDownList).SelectedValue, 0)
  '    Dim t2 As New TimeSpan(DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(4).Controls(5), DropDownList).SelectedValue, DirectCast(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, DataGridItem).Cells(4).Controls(7), DropDownList).SelectedValue, 0)
  '    args.IsValid = t1.CompareTo(t2) = -1 Or t1.CompareTo(t2) = 0
  '  Else
  '    args.IsValid = True
  '  End If
  'End Sub

  Private Sub dgCongedi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.DeleteCommand
    cvOnEliminaCongedo.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare"
    If cvOnEliminaCongedo.IsValid Then
      Dim dr As DataRow
      dr = DsRichieste1.Tables("RichiesteCongedi").Rows.Find(dgCongedi.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then dr.Delete()
      daCongediGarantiti.Update(DsRichieste1, "RichiesteCongedi")
      'FT - Toglie l'editing mode
      dgCongedi_CancelCommand(source, e)
      Dim fnc As New Funzioni
      fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Eliminato congedo", Session("IPAddress"))
    End If
  End Sub

  Private Sub pAggiungiCongedo()
    Dim dr As Data.DataRow = DsRichieste1.Tables("RichiesteCongedi").NewRow
    dr.Item("IdRichiesta") = Guid.NewGuid
    'FT - !!! - Gestire le festività e le domeniche

    dr.Item("DalGiorno") = pDate48H.AddDays(1)
    dr.Item("AlGiorno") = pDate48H.AddDays(1)
    'FT
    DsRichieste1.Tables("RichiesteCongedi").Rows.InsertAt(dr, 0)
    dgCongedi.EditItemIndex = 0
    Page.DataBind()
    btnAddCongedo.Enabled = False
  End Sub

  Private Sub dgCongedi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.EditCommand
    cvOnModificaCongedo.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare"
    If cvOnModificaCongedo.IsValid Then
      dgCongedi.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnAddCongedo.Enabled = False

      fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Inizio modifica congedo", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCongedi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongedi.ItemCreated
    Dim myDeleteButton As LinkButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questo richiesta di congedo?');")
  End Sub

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



  Private Sub cvTipoUtente_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTipoUtente.ServerValidate
    args.IsValid = oUtente.TipoUtente = 2
  End Sub



  Private Function pCountFestivita(ByVal dal As Date, ByVal al As Date) As Integer
    Dim i As Integer = 0
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
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
  Public Sub cvMeseDataDalAl_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    args.IsValid = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)

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
  Private Function pVestizioneDefinitiva(ByVal dal As Date) As Boolean
    'DM2020.03 - controllo che il mese e l'anno della richiesta ci sia già la vestizione definitiva
    Dim i As Integer = 0
    Dim AA As Integer
    Dim MM As Integer
    Dim sc As New SqlClient.SqlCommand("select * from dbo.AMPTG00F TURNIMATRICOLA where TURNIMATRICOLA.PTAAGG = @aa and TURNIMATRICOLA.PTMMGG = @mm ", con)
    AA = Year(dal)
    MM = Month(dal)
    sc.Parameters.Add("@aa", SqlDbType.Int).Value = AA
    sc.Parameters.Add("@mm", SqlDbType.Int).Value = MM
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

  '------ DA PAOLA per LANCIARE PROGRAMMA AS400 --------
  Friend Function CalcolaResiduoFerieSosta(ByVal DataServizio As String, ByRef Matricola As String, ByRef ResiduoFerie As String) As Boolean

    CalcolaResiduoFerieSosta = False

    OleConAS400.Open()

    If OleConAS400 Is Nothing Then

      Exit Function

    End If

    Dim OleDbCmd As OleDb.OleDbCommand
    Dim OleDbDa As OleDb.OleDbDataAdapter
    Dim OleDbDs As System.Data.DataSet = Nothing

    Try

      OleDbCmd = New OleDb.OleDbCommand

      With OleDbCmd

        .Connection = OleConAS400
        .CommandType = CommandType.StoredProcedure
        .CommandTimeout = 1000
        .CommandText = "VESTIAMT.AMBTC73P"

        Dim OleDbPar1 As System.Data.OleDb.OleDbParameter
        OleDbPar1 = .CreateParameter()
        OleDbPar1.ParameterName = "MATR"
        OleDbPar1.DbType = DbType.String
        OleDbPar1.Size = 5
        OleDbPar1.Value = StrDup(5 - Len(LTrim(RTrim(Convert.ToString(Matricola)))), "0") & LTrim(RTrim(Convert.ToString(Matricola)))
        OleDbPar1.Direction = ParameterDirection.InputOutput
        .Parameters.Add(OleDbPar1)

        Dim OleDbPar2 As System.Data.OleDb.OleDbParameter
        OleDbPar2 = .CreateParameter()
        OleDbPar2.ParameterName = "DTGG"
        OleDbPar2.DbType = DbType.String
        OleDbPar2.Size = 8
        OleDbPar2.Value = Year(DataServizio) & _
                        StrDup(2 - Len(LTrim(RTrim(Convert.ToString(Month(DataServizio))))), "0") & _
                        LTrim(RTrim(Month(DataServizio))) & _
                        StrDup(2 - Len(LTrim(RTrim(Convert.ToString(Day(DataServizio))))), "0") & _
                        LTrim(RTrim(Day(DataServizio)))
        OleDbPar2.Direction = ParameterDirection.InputOutput
        .Parameters.Add(OleDbPar2)

        Dim OleDbPar3 As System.Data.OleDb.OleDbParameter
        OleDbPar3 = .CreateParameter()
        OleDbPar3.ParameterName = "RESF"
        OleDbPar3.DbType = DbType.String
        OleDbPar3.Size = 8
        OleDbPar3.Value = "00000000"
        OleDbPar3.Direction = ParameterDirection.Output
        .Parameters.Add(OleDbPar3)


        .ExecuteNonQuery()

        ResiduoFerie = OleDbPar3.Value.ToString()

        If ResiduoFerie > 0 Then
          CalcolaResiduoFerieSosta = False
        Else
          CalcolaResiduoFerieSosta = True
        End If
        OleConAS400.Close()
        OleDbCmd = Nothing
        OleDbDs = Nothing
        OleDbDa = Nothing

      End With


    Catch ex As Exception

      fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Calcola Data Next", Err.Description)

      OleConAS400.Close()
      OleDbCmd = Nothing
      OleDbDa = Nothing
      OleDbDs = Nothing

    End Try



  End Function

  Friend Function HoResiduoFerieSosta(ByVal DataServizio As String, ByRef Matricola As String, ByRef ResiduoFerie As String) As Boolean

    HoResiduoFerieSosta = False

    OleConAS400.Open()

    If OleConAS400 Is Nothing Then

      Exit Function

    End If

    Dim OleDbCmd As OleDb.OleDbCommand
    Dim OleDbDa As OleDb.OleDbDataAdapter
    Dim OleDbDs As System.Data.DataSet = Nothing

    Try

      OleDbCmd = New OleDb.OleDbCommand

      OleDbCmd = New OleDb.OleDbCommand

      With OleDbCmd

        .Connection = OleConAS400
        .CommandType = CommandType.Text
        .CommandTimeout = 100
        .CommandText = "{{CALL pgm(VESTIAMT.AMBTC73P) parm('" & StrDup(5 - Len(LTrim(RTrim(Convert.ToString(Matricola)))), "0") & LTrim(RTrim(Convert.ToString(Matricola))) & "' " & _
          "'" & Year(DataServizio) & _
                        StrDup(2 - Len(LTrim(RTrim(Convert.ToString(Month(DataServizio))))), "0") & _
                        LTrim(RTrim(Month(DataServizio))) & _
                        StrDup(2 - Len(LTrim(RTrim(Convert.ToString(Day(DataServizio))))), "0") & _
                        LTrim(RTrim(Day(DataServizio))) & "'" & _
            "'0000000')}}"

        .ExecuteNonQuery()



        OleDbCmd = Nothing
        OleDbDs = Nothing
        OleDbDa = Nothing

      End With


    Catch ex As Exception

      fnc.ScriviLog(oUtente.IDUser, "wf_congediGarantiti.aspx", "Calcola Data Next", Err.Description)

      OleConAS400.Close()
      OleDbCmd = Nothing
      OleDbDa = Nothing
      OleDbDs = Nothing

    End Try



  End Function




  Private Sub dgCongedi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCongedi.SelectedIndexChanged

  End Sub
End Class
