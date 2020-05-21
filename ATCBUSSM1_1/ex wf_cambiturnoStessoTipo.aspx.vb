Public Class wf_cambiturnoStessoTipo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCambiTurnoGiornalieriStessoTipo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.daAccertatoriASGiornaliero = New System.Data.Odbc.OdbcDataAdapter
    Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
    Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
    Me.daCambiTurnoDaAccettare = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoDaAccettare1 = New ATCBussm1.dsCambiTurnoDaAccettare
    Me.daEccezioni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.daListaTurniStessoTipo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsListaTurniStessoTipo1 = New ATCBussm1.dsListaTurniStessoTipo
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsListaTurniStessoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCambiTurnoGiornalieriStessoTipo
    '
    Me.daCambiTurnoGiornalieriStessoTipo.DeleteCommand = Me.SqlCommand2
    Me.daCambiTurnoGiornalieriStessoTipo.InsertCommand = Me.SqlCommand1
    Me.daCambiTurnoGiornalieriStessoTipo.SelectCommand = Me.SqlSelectCommand1
    Me.daCambiTurnoGiornalieriStessoTipo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DsRichiesteCambiTurnoStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("TurnoRichiedente", "TurnoRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("TurnoDestinatario", "TurnoDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daCambiTurnoGiornalieriStessoTipo.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.RichiesteCambiTurnoStessoTipo WHERE (IdRichiesta = @IdRichiesta)"
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "INSERT INTO dbo.RichiesteCambiTurnoStessoTipo (IdRichiesta, IdAccertatoreRichiede" & _
    "nte, TurnoRichiedente, IdAccertatoreDestinatario, TurnoDestinatario, data) VALUE" & _
    "S (@IdRichiesta, @IdAccertatoreRichiedente, @TurnoRichiedente, @IdAccertatoreDes" & _
    "tinatario, @TurnoDestinatario, @data)"
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdRichiesta, IdAccertatoreRichiedente, TurnoRichiedente, IdAccertatoreDest" & _
    "inatario, TurnoDestinatario, StatoRichiesta, data, StatoApprovazione, DataApprov" & _
    "azione, IdApprovatore, ts FROM dbo.RichiesteCambiTurnoStessoTipo WHERE (IdAccert" & _
    "atoreRichiedente = @IdUtente)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.RichiesteCambiTurnoStessoTipo SET IdAccertatoreDestinatario = @IdAccer" & _
    "tatoreDestinatario, TurnoDestinatario = @TurnoDestinatario, ts = GETDATE() WHERE" & _
    " (IdRichiesta = @IdRichiesta)"
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'daAccertatoriASGiornaliero
    '
    Me.daAccertatoriASGiornaliero.SelectCommand = Me.OdbcSelectCommand1
    Me.daAccertatoriASGiornaliero.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_ListaCambiGiornalieriStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DESCR", "DESCR"), New System.Data.Common.DataColumnMapping("titipl", "titipl"), New System.Data.Common.DataColumnMapping("tigrua", "tigrua"), New System.Data.Common.DataColumnMapping("tisass", "tisass"), New System.Data.Common.DataColumnMapping("tisrsq", "tisrsq")})})
    '
    'OdbcSelectCommand1
    '
    Me.OdbcSelectCommand1.Connection = Me.conAS400
    '
    'daCambiTurnoDaAccettare
    '
    Me.daCambiTurnoDaAccettare.SelectCommand = Me.SqlSelectCommand4
    Me.daCambiTurnoDaAccettare.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("EtichettaStatoRichiesta", "EtichettaStatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
    Me.daCambiTurnoDaAccettare.UpdateCommand = Me.SqlCommand5
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT R.IdRichiesta, R.IdAccertatoreRichiedente, '(' + U.IDUser + ') ' + U.Cogno" & _
    "me + ' ' + U.Nome AS IDuser, CASE WHEN R.TurnoRichiedente < 90000 THEN LTrim(Str" & _
    "(R.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, R.IdAccertatoreDest" & _
    "inatario, CASE WHEN R.TurnoDestinatario < 90000 THEN LTrim(Str(R.TurnoDestinatar" & _
    "io)) ELSE 'Riposo' END AS TurnoDestinatario, R.StatoRichiesta, CASE WHEN StatoRi" & _
    "chiesta IS NULL THEN 'Da accettare' WHEN StatoRichiesta = 0 THEN 'Rifutato' WHEN" & _
    " StatoRichiesta = 1 THEN 'Accettato' END AS EtichettaStatoRichiesta, R.data, R.S" & _
    "tatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts, U.ID FROM dbo.Richi" & _
    "esteCambiTurno R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatoreRichiedente " & _
    "= U.ID WHERE (R.IdAccertatoreDestinatario = @IdUtente) AND (R.StatoApprovazione " & _
    "IS NULL) AND R.data >= GetDate() ORDER BY R.data"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    '
    'SqlCommand5
    '
    Me.SqlCommand5.CommandText = "UPDATE dbo.RichiesteCambiTurnoStessoTipo SET StatoRichiesta = @StatoRichiesta WHE" & _
    "RE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand5.Connection = Me.con
    Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoRichiesta", System.Data.SqlDbType.Int, 4, "StatoRichiesta"))
    Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsCambiTurnoDaAccettare1
    '
    Me.DsCambiTurnoDaAccettare1.DataSetName = "dsCambiTurnoDaAccettare"
    Me.DsCambiTurnoDaAccettare1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daEccezioni
    '
    Me.daEccezioni.SelectCommand = Me.SqlSelectCommand2
    Me.daEccezioni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_prt_getchangeandexc", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMCAMBI", "NUMCAMBI"), New System.Data.Common.DataColumnMapping("NUMECCE", "NUMECCE")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "dbo.[prt_getchangeandexc]"
    Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DT", System.Data.SqlDbType.NVarChar, 10))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TP", System.Data.SqlDbType.VarChar, 1))
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=UtenteBussm;data source=INSVSQ" & _
    "L03;persist security info=False;initial catalog=ATCBussm"
    '
    'daListaTurniStessoTipo
    '
    Me.daListaTurniStessoTipo.SelectCommand = Me.SqlSelectCommand3
    Me.daListaTurniStessoTipo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "dbo_SP_ListaCambiGiornalieriStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DESCR", "DESCR"), New System.Data.Common.DataColumnMapping("titipl", "titipl"), New System.Data.Common.DataColumnMapping("tigrua", "tigrua"), New System.Data.Common.DataColumnMapping("tisass", "tisass"), New System.Data.Common.DataColumnMapping("tisrsq", "tisrsq")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "dbo.[SP_ListaCambiGiornalieriStessoTipo]"
    Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idutente", System.Data.SqlDbType.VarChar, 10))
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data", System.Data.SqlDbType.NVarChar, 10))
    '
    'DsListaTurniStessoTipo1
    '
    Me.DsListaTurniStessoTipo1.DataSetName = "dsListaTurniStessoTipo"
    Me.DsListaTurniStessoTipo1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsListaTurniStessoTipo1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents lblCambiTurno As System.Web.UI.WebControls.Label
  Protected WithEvents btnAnnulla As System.Web.UI.WebControls.Button
  Protected WithEvents btnOk As System.Web.UI.WebControls.Button
  Protected WithEvents ddlData As System.Web.UI.WebControls.DropDownList
  Protected WithEvents pnlData As System.Web.UI.WebControls.Panel
  Protected WithEvents btnNuovaRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents daAccertatoriASGiornaliero As System.Data.Odbc.OdbcDataAdapter
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTurnoVuoto As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTurnoOkGiornaliero As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvSoloUnCambio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents daCambiTurnoDaAccettare As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsCambiTurnoDaAccettare1 As ATCBussm1.dsCambiTurnoDaAccettare
  Protected WithEvents dgCambiTurnoDaAccettare As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblCambiTurnoDaAccettare As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnDelete As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvData As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvbloccoCambio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvGiornalieroAbilitato As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents daEccezioni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents cvEccezioni As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvCheckPatente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
  Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
  Protected WithEvents daListaTurniStessoTipo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsListaTurniStessoTipo1 As ATCBussm1.dsListaTurniStessoTipo
  Protected WithEvents dgCambiTurnoGiornalieriStessoTipo As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsCambiTurnoGiornalieriStessoTipo1 As ATCBussm1.DsCambiTurnoGiornalieriStessoTipo
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCambiTurnoGiornalieriStessoTipo As System.Data.SqlClient.SqlDataAdapter
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

  Dim oUtente As Utente
  Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If


    'FT - !!! - Abilito l'interfaccia solo per gli accertatori
    'FT - !!! - Questo perché sono gli unici ad avere nell'IDUser il numero di matricola che serve per caricare i turni
    cvTipoUtente.Validate()
    btnNuovaRichiesta.Enabled = cvTipoUtente.IsValid And Not pnlData.Visible And dgCambiTurnoGiornalieriStessoTipo.EditItemIndex = -1
    'FT - !!!

    daCambiTurnoGiornalieriStessoTipo.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoGiornalieriStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")

    daCambiTurnoDaAccettare.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoStessoTipo")

    If Not IsPostBack Then
      Date48H(ddlData)
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  Private Sub Date48H(ByRef ddl As DropDownList)
    Dim i As Integer = 0
    Dim data As DateTime = Now.Date

    'If (Now.Hour >= 17) Then
    '  data = Now.AddDays(1)
    'End If
    Do While i < 2
      data = data.AddDays(1)
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = data
      con.Open()
      If data.DayOfWeek <> DayOfWeek.Sunday And sc.ExecuteScalar() <= 0 Then
        ddl.Items.Add(New ListItem(data.ToString("D"), data))
        'ddl.Items.Add(New ListItem(data.ToString("D"), CDate("2004-08-30")))
        i += 1
      End If
      con.Close()

    Loop
  End Sub
  Public Sub cvdatadaaccettare_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    Dim dt As Date
    'DM2020.01 - FINO ALLE 18.00
    If (Now.Hour >= 18) Then
      dt = Now.AddDays(2).Date
    Else
      dt = Now.AddDays(1).Date
    End If
    args.IsValid = Convert.ToDateTime(DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("lbldata"), Label).Text) >= dt
  End Sub
  Public Sub cvblocco_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    Dim sc As New SqlClient.SqlCommand("SELECT COUNT(*) AS n FROM Accertatori_BloccoCambioGiornaliero WHERE (AccertatoreId = @IdUtente) AND (InizioOn <= @Data) AND (FineOn > getdate())", con)
    sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlData.SelectedValue
    con.Open()
    args.IsValid = sc.ExecuteScalar() = 0
    con.Close()
  End Sub

  Private Sub addRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click
    pShowPanel(True)
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Click nuovo cambio turno", Session("IPAddress"))
  End Sub

  Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
    pShowPanel(False)
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Annullata richiesta nuovo cambio turno", Session("IPAddress"))
  End Sub

  Private Sub pShowPanel(ByVal Flag As Boolean)
    pnlData.Visible = Flag
    btnNuovaRichiesta.Enabled = Not Flag
    For Each item As Control In pnlData.Controls
      item.Visible = Flag
    Next
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)
    Me.Validate()
    If Me.IsValid Then
      ' Dim richiesteG As String
      ' richiesteG = ""
      ' richiesteG = RichiestePresenti(ddlData.SelectedValue, oUtente.ID)
      ' If Not (richiesteG = "") Then

      'cvSoloUnCambio.ErrorMessage = richiesteG
      'cvSoloUnCambio.IsValid = False

      'Else
      Dim dr As DataRow = DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").NewRow
      dr.Item("IdRichiesta") = Guid.NewGuid
      dr.Item("IdAccertatoreRichiedente") = oUtente.ID
      dr.Item("TurnoRichiedente") = ""
      dr.Item("Data") = ddlData.SelectedValue
      dr.Item("IdAccertatoreDestinatario") = 0
      dr.Item("TurnoDestinatario") = ""
      dr.Item("ts") = Now

      DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.InsertAt(dr, 0)
      dgCambiTurnoGiornalieriStessoTipo.EditItemIndex = 0
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Inserito cambio turno in stato modifica, da confermare ", Session("IPAddress"))
      'End If

      'Else
      'FT - !!! - Errore: non ci sono altri accertatori in turno per questa data
    End If
    pShowPanel(False)
  End Sub

  Private Sub pCaricaTurniAccertatoriGiornaliero(ByVal pData As Date)
    'pData = CDate("2004-08-30")

    ''Dim strblocchi As String
    ''strblocchi = " "
    ''Dim cmdblocchi As New SqlClient.SqlCommand("SELECT ATC_Utenti.IDUser FROM Accertatori_BloccoCambioGiornaliero INNER JOIN ATC_Utenti ON Accertatori_BloccoCambioGiornaliero.AccertatoreId = ATC_Utenti.ID WHERE (Accertatori_BloccoCambioGiornaliero.InizioOn <= GetDate()) AND (Accertatori_BloccoCambioGiornaliero.FineOn > getdate())", con)

    ''Dim drblocchi As SqlClient.SqlDataReader
    ''con.Open()
    ''drblocchi = cmdblocchi.ExecuteReader()
    ''If drblocchi.HasRows Then

    ''  Do While drblocchi.Read
    ''    strblocchi = strblocchi & " AND  A.PTMATR <> '" & drblocchi("IDUser") & "' "
    ''  Loop
    ''Else
    ''End If
    ''con.Close()
    ''fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Filtro " & strblocchi, Session("IPAddress"))

    Dim s As String = daListaTurniStessoTipo.SelectCommand.CommandText
    daListaTurniStessoTipo.SelectCommand.Parameters("@IdUtente").Value = oUtente.IDUser
    Dim DD As String = FormatDateTime(pData.Date, DateFormat.ShortDate).ToString
    daListaTurniStessoTipo.SelectCommand.Parameters("@Data").Value = Right(DD, 4) + "-" + Mid(DD, 4, 2) + "-" + Left(DD, 2)
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", daListaTurniStessoTipo.SelectCommand.CommandText & s, Session("IPAddress"))

    daListaTurniStessoTipo.Fill(DsListaTurniStessoTipo1, "dbo_SP_ListaCambiGiornalieriStessoTipo")

  End Sub

  Private Sub cvTipoUtente_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTipoUtente.ServerValidate
    args.IsValid = oUtente.TipoUtente = 2
  End Sub







  Private Function pGetTurno(ByVal Matricola As String) As Integer
    Dim conf As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Dim com As New Odbc.OdbcCommand(conf.GetValue("SelectTurnoGiornalieroAccertatore", GetType(String)), conAS400)
    Dim s As String = com.CommandText
    s = s.Replace("@PTMATR", Matricola)
    s = s.Replace("@PTAAGG", CDate(ddlData.SelectedValue).Year)
    s = s.Replace("@PTMMGG", CDate(ddlData.SelectedValue).Month)
    s = s.Replace("@PTGGGG", CDate(ddlData.SelectedValue).Day)
    com.CommandText = s
    Try
      conAS400.Open()
      pGetTurno = com.ExecuteScalar()
      conAS400.Close()

    Catch ex As Exception
      Throw ex
    End Try
  End Function

  Private Sub cvTurnoVuoto_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTurnoVuoto.ServerValidate
    args.IsValid = DsListaTurniStessoTipo1.dbo_SP_ListaCambiGiornalieriStessoTipo.Rows.Count > 0

  End Sub

  Private Sub cvTurnoOkGiornaliero_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTurnoOkGiornaliero.ServerValidate


    ''Dim conf As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    ''Dim com As New Odbc.OdbcCommand(conf.GetValue("SelectTurnoOkGiornalieroAccertatore", GetType(String)), conAS400)
    ''Dim s As String = com.CommandText
    ''s = s.Replace("@Matricola", oUtente.IDUser)
    ''s = s.Replace("@Anno", CDate(ddlData.SelectedValue).Year)
    ''s = s.Replace("@Mese", CDate(ddlData.SelectedValue).Month)
    ''s = s.Replace("@Giorno", CDate(ddlData.SelectedValue).Day)
    '''s = s.Replace("@Blocchi", strblocchi)
    ''com.CommandText = s
    ''conAS400.Open()
    ''args.IsValid = com.ExecuteScalar() > 0
    ''conAS400.Close()
  End Sub

  Private Function pGetIDAccertatoreDestinatario(ByVal Matricola As String) As Integer
    Dim com As New SqlClient.SqlCommand("Select Id From ATC_Utenti Where IDUser = @IDUser", con)
    com.Parameters.Add("@IDUser", SqlDbType.VarChar).Value = Matricola
    con.Open()
    pGetIDAccertatoreDestinatario = com.ExecuteScalar
    con.Close()
  End Function


  Private Sub cvSoloUnCambio_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvSoloUnCambio.ServerValidate
    ''Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurnoStessoTipo Where (IdAccertatoreRichiedente = @IdUtente Or IdAccertatoreDestinatario = @IdUtente) And Data = @Data And (StatoRichiesta Is Null Or StatoRichiesta = 1)", con)
    ''sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
    ''sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlData.SelectedValue
    ''con.Open()
    ''args.IsValid = sc.ExecuteScalar() <= 1
    ''con.Close()
  End Sub

  Private Sub dgCambiTurnoDaAccettare_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoDaAccettare.ItemCommand
    Dim dr As DataRow = DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Find(dgCambiTurnoDaAccettare.DataKeys(e.Item.ItemIndex))
    Page.Validate()
    If Page.IsValid Then


      Select Case e.CommandName
        Case "Accetta"
          dr.Item("StatoRichiesta") = 1
          fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Accettato cambio turno", Session("IPAddress"))
        Case "Rifiuta"
          dr.Item("StatoRichiesta") = 0
          fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Rifiutato cambio turno", Session("IPAddress"))
      End Select
      daCambiTurnoDaAccettare.Update(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoStessoTipo")

      DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambiTurnoDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoStessoTipo")

      DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambiTurnoGiornalieriStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")

      Page.DataBind()
    End If
  End Sub

  Public Sub cvData_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvData.ServerValidate
    If (ddlData.SelectedValue = Now.AddDays(1).Date) Then
      'DM2020.01 - FINO ALLE 18.00
      If (Now.Hour >= 18) Then
        args.IsValid = False
      Else
        args.IsValid = True
      End If

    End If


  End Sub

  Private Function RichiestePresenti(ByVal gg As Date, ByVal matricola As String) As String
    Dim richiesta As String = ""
    Dim cmdcambio As New SqlClient.SqlCommand("SELECT  isnull(U.IDUser,'') AS MatricolaDestinatario, isnull(U1.IDUser,'') AS MatricolaRichiedente " & _
    " FROM dbo.RichiesteCambiTurnoStessoTipo R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatoreDestinatario = U.ID " & _
    " left outer join dbo.ATC_Utenti U1 ON R.IdAccertatoreRichiedente = U1.ID  " & _
    " WHERE ((R.IdAccertatoreRichiedente = " & matricola & ") or (R.IdAccertatoreDestinatario = " & matricola & "))AND (R.data = DATEADD(d, DATEDIFF(d, 0, '" & Format(gg, "yyyy-MM-dd") & "'), 0))  AND (R.StatoRichiesta IS  NULL) ORDER BY R.ts DESC ", con)

    Dim drcambi As SqlClient.SqlDataReader
    con.Open()
    drcambi = cmdcambio.ExecuteReader()
    If drcambi.HasRows Then
      Do While drcambi.Read


        richiesta = richiesta & "<br />Attenzione è già presente un cambio per la matricola " & oUtente.IDUser & ". Prima di procedere accettare il cambio in sospeso"

      Loop
    End If
    con.Close()

    RichiestePresenti = richiesta

  End Function


  Private Sub cvbloccoCambio_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvbloccoCambio.ServerValidate
    Dim sc As New SqlClient.SqlCommand("SELECT COUNT(*) AS n FROM Accertatori_BloccoCambioGiornaliero WHERE (AccertatoreId = @IdUtente) AND (InizioOn <= @Data) AND (FineOn >getdate())", con)
    sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlData.SelectedValue
    con.Open()
    args.IsValid = sc.ExecuteScalar() = 0
    con.Close()

  End Sub
  Public Sub cvGiornalieroAbilitato_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvGiornalieroAbilitato.ServerValidate
    Dim Config As New System.Configuration.AppSettingsReader
    Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlData.SelectedValue
    con.Open()
    args.IsValid = comNumExecutionTime.ExecuteScalar() = 1
    con.Close()

  End Sub

  Private Sub cvEccezioni_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvEccezioni.ServerValidate
    Dim sc As New SqlClient.SqlCommand("dbo.prt_getchangeandexc", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@ID", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@DT", SqlDbType.DateTime).Value = ddlData.SelectedValue
    sc.Parameters.Add("@TP", SqlDbType.Char).Value = "G"

    Dim dr As SqlClient.SqlDataReader
    con.Open()
    dr = sc.ExecuteReader()
    dr.Read()
    Dim numcambi As Int32 = dr("NUMCAMBI")
    Dim numecce As Int32 = dr("NUMECCE")

    args.IsValid = numcambi < numecce
    con.Close()
  End Sub
  Function PossoCambioGiornaliero(ByVal InpIdUserSostituente As Integer, ByVal InpData As DateTime) As String
    'DM2020.02 - CONTROLLO CHE IO POSSA FARE UN CAMBIO GIORNALIERO
    Dim sc As New SqlClient.SqlCommand("SP_PossoCambioGiornaliero", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@IdUser", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@IdUserDestinatario", SqlDbType.Int).Value = InpIdUserSostituente
    sc.Parameters.Add("@DataCambio", SqlDbType.DateTime).Value = InpData

    Dim dr As SqlClient.SqlDataReader
    con.Open()
    dr = sc.ExecuteReader()
    dr.Read()

    If dr.FieldCount > 0 Then
      PossoCambioGiornaliero = dr("Risultato")
    Else
      PossoCambioGiornaliero = "0"
    End If
    con.Close()


  End Function


  Private Sub btnNuovaRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click

  End Sub



  Private Sub dgCambiTurnoGiornalieriStessoTipo_EditCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.EditCommand
    cvOnModifica.IsValid = (DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "Da accettare" Or DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnModifica.IsValid Then
      pCaricaTurniAccertatoriGiornaliero(DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Find(dgCambiTurnoGiornalieriStessoTipo.DataKeys(e.Item.ItemIndex)).Item("Data"))
      dgCambiTurnoGiornalieriStessoTipo.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnNuovaRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Stato di modifica del cambio turno", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_CancelCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.CancelCommand
    btnNuovaRichiesta.Enabled = True
    dgCambiTurnoGiornalieriStessoTipo.EditItemIndex = -1
    Page.DataBind()
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Annullata la modifica del cambio turno", Session("IPAddress"))
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_DeleteCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.DeleteCommand
    cvOnDelete.IsValid = (DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnDelete.IsValid Then
      Dim dr As DataRow = DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Find(dgCambiTurnoGiornalieriStessoTipo.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daCambiTurnoGiornalieriStessoTipo.Update(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Eliminato cambio turno", Session("IPAddress"))
      End If
      dgCambiTurnoGiornalieriStessoTipo_CancelCommand1(source, e)
    End If
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.ItemCommand

  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_ItemCreated1(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.ItemCreated
    '' If Not e.Item.FindControl("btnDelete") Is Nothing Then DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di cambio turno?');")
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_UpdateCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.UpdateCommand

    Dim TRic As Integer
    Dim TTurno As String
    Dim IRic As Integer
    Dim IDes As String

    'pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)

    TTurno = DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue.Trim
    'IDes = DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Find(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue).Item("DESCR")

    If Me.IsValid Then
      Dim dr As DataRow = DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Find(dgCambiTurnoGiornalieriStessoTipo.DataKeys(e.Item.ItemIndex))
      
      If dr Is Nothing Then
        dr = DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").NewRow
        dr.Item("ts") = Now
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatoreRichiedente") = oUtente.ID
        dr.Item("TurnoRichiedente") = TTurno
        dr.Item("Data") = ddlData.SelectedValue
        DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Rows.Add(dr)
      End If
      'pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)


      daCambiTurnoGiornalieriStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")
      Page.DataBind()


      dgCambiTurnoGiornalieriStessoTipo_CancelCommand1(source, e)
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Confermata la modifica al cambio turno", Session("IPAddress"))
    End If

  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.SelectedIndexChanged

  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.Init

  End Sub
End Class
