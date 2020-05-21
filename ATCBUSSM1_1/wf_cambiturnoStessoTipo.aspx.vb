Public Class wf_cambiturnoStessoTipo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
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
    Me.DsCambiTurnoStessoTipo = New ATCBussm1.DsCambiTurnoGiornalieriStessoTipo
    Me.daCambioTurnoStessoTipo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsListaTurniStessoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsCambiTurnoStessoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
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
    "inatario, CASE WHEN left(R.TurnoDestinatario,1) <> '9' THEN LTrim(R.TurnoDestina" & _
    "tario) ELSE 'Riposo' END AS TurnoDestinatario, R.StatoRichiesta as StatoRichiest" & _
    "a, CASE WHEN StatoRichiesta IS NULL THEN 'Da accettare' WHEN StatoRichiesta = 0 " & _
    "THEN 'Rifutato' WHEN StatoRichiesta = 1 THEN 'Accettato' END AS EtichettaStatoRi" & _
    "chiesta, R.data, R.StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts," & _
    " U.ID FROM dbo.RichiesteCambiTurnoStessoTipo R LEFT OUTER JOIN dbo.ATC_Utenti U " & _
    "ON R.IdAccertatoreRichiedente = U.ID WHERE (R.IdAccertatoreDestinatario = @IdUte" & _
    "nte) AND (R.StatoApprovazione IS NULL) AND R.data >= GetDate()  ORDER BY R.data"
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
    '
    'DsCambiTurnoStessoTipo
    '
    Me.DsCambiTurnoStessoTipo.DataSetName = "DsCambiTurnoStessoTipo"
    Me.DsCambiTurnoStessoTipo.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daCambioTurnoStessoTipo
    '
    Me.daCambioTurnoStessoTipo.InsertCommand = Me.SqlInsertCommand1
    Me.daCambioTurnoStessoTipo.SelectCommand = Me.SqlSelectCommand1
    Me.daCambioTurnoStessoTipo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("TurnoRichiedente", "TurnoRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("TurnoDestinatario", "TurnoDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCambiTurnoStessoTipo(IdRichiesta, IdAccertatoreRichieden" & _
    "te, TurnoRichiedente, IdAccertatoreDestinatario, TurnoDestinatario, StatoRichies" & _
    "ta, data, StatoApprovazione, DataApprovazione, IdApprovatore, ts) VALUES (@IdRic" & _
    "hiesta, @IdAccertatoreRichiedente, @TurnoRichiedente, @IdAccertatoreDestinatario" & _
    ", @TurnoDestinatario, @StatoRichiesta, @data, @StatoApprovazione, @DataApprovazi" & _
    "one, @IdApprovatore, @ts)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreRichiedente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoRichiedente", System.Data.SqlDbType.Int, 4, "TurnoRichiedente"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoDestinatario", System.Data.SqlDbType.VarChar, 20, "TurnoDestinatario"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoRichiesta", System.Data.SqlDbType.Int, 4, "StatoRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data", System.Data.SqlDbType.DateTime, 8, "data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoApprovazione", System.Data.SqlDbType.Int, 4, "StatoApprovazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdApprovatore", System.Data.SqlDbType.Int, 4, "IdApprovatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ts", System.Data.SqlDbType.DateTime, 8, "ts"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatar" & _
    "io, r.data, r.DataApprovazione, r.IdApprovatore, r.StatoRichiesta, CASE WHEN Sta" & _
    "toRichiesta IS NULL THEN 'Da accettare' WHEN StatoRichiesta = 0  THEN 'Rifutato'" & _
    " WHEN StatoRichiesta = 1 THEN 'Accettato' END AS EtichettaStatoRichiesta, CASE R" & _
    ".StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' ELSE 'Da Appr" & _
    "ovare' END AS StatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome " & _
    "AS CognomeNomeRichiedente, u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedent" & _
    "e < 90000 THEN LTrim(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiede" & _
    "nte, CASE WHEN LEFT(r.TurnoDestinatario, 1) <> '9' THEN LTrim(r.TurnoDestinatari" & _
    "o) ELSE 'Riposo' END AS TurnoDestinatario, u1.ID, u3.ID AS Expr1 FROM dbo.Richie" & _
    "steCambiTurnoStessoTipo r LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRi" & _
    "chiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID W" & _
    "HERE (r.StatoRichiesta = 1) AND (r.data >= DATEADD(d, DATEDIFF(d, 1, GETDATE())," & _
    " 0)) AND (r.IdAccertatoreRichiedente = @IdUtente) ORDER BY r.data DESC, r.ts"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsListaTurniStessoTipo1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsCambiTurnoStessoTipo, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents lblCambiTurno As System.Web.UI.WebControls.Label
  Protected WithEvents btnAnnulla As System.Web.UI.WebControls.Button
  Protected WithEvents btnOk As System.Web.UI.WebControls.Button
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
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCambioTurnoStessoTipo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsCambiTurnoStessoTipo As ATCBussm1.DsCambiTurnoGiornalieriStessoTipo
  Protected WithEvents ddlDataCal As System.Web.UI.WebControls.Calendar

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
    pDate48H = Date48H_LAVORATIVE()

  End Sub

#End Region

  Dim oUtente As Utente
  Dim fnc As New Funzioni
  '''
  ''' modifica per assegnare stessi controlli dei congedi
  '''
  Private pDate48H As DateTime

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

    daCambioTurnoStessoTipo.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambioTurnoStessoTipo.Fill(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")

    daCambiTurnoDaAccettare.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiTurno")

    If Not IsPostBack Then
      ddlDataCal.SelectedDate = pDate48H
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  Private Function Date48H_LAVORATIVE() As DateTime
    'DM2020.04 - ATTENZIONE, SOLO PER I "CAMBI TURNO" DEVE ESSERE RICHIESTO UN GIORNO LAVORATIVO PRECEDENTE ALLE 48 ORE
    Dim i As Integer = 0

    Dim data As DateTime = Now.Date
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    'se oggi è festa, il giorno che posso scegliere sarà un giorno in più
    Do While pFestivita(data)
      data = data.AddDays(1)
    Loop

    If FormatDateTime(data, DateFormat.ShortDate) = FormatDateTime(Now, DateFormat.ShortDate) And Hour(Now) >= 18 Then
      data = data.AddDays(1)
      Do While pFestivita(data)
        data = data.AddDays(1)
      Loop
    End If

    ' conto 2 giorni dalla data corrente (se non festiva) ... ma due gg LAVORATIVI
    ' però poi il giorno giusto è il giorno DOPO. Per cui conto 3 gg
    Do While i < 3
      data = data.AddDays(1)
      If Not pFestivita(data) Then i = i + 1
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Controllo festività: il giorno  " & data.ToString() & " Risultato: " & data.ToString, Session("IPAddress"))
    Loop
    'Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    'riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(data, "dd/MM/yyyy")
    Date48H_LAVORATIVE = data
  End Function
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
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlDataCal.SelectedDate
    con.Open()
    args.IsValid = sc.ExecuteScalar() = 0
    con.Close()
  End Sub

  Private Sub addRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click
    pShowPanel(True)
    oUtente.bStoInserendo = True
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Click nuovo cambio turno", Session("IPAddress"))
  End Sub

  Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
    pShowPanel(False)
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Annullata richiesta nuovo cambio turno", Session("IPAddress"))
  End Sub

  Private Sub pShowPanel(ByVal Flag As Boolean)
    pnlData.Visible = Flag
    btnNuovaRichiesta.Enabled = Not Flag
    For Each item As Control In pnlData.Controls
      item.Visible = Flag
    Next
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    pCaricaTurniAccertatoriGiornaliero(ddlDataCal.SelectedDate)
    Me.Validate()
    If Me.IsValid Then

      Dim dr As DataRow = DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").NewRow
      oUtente.bStoInserendo = True

      dr.Item("IdRichiesta") = Guid.NewGuid
      dr.Item("IdAccertatoreRichiedente") = oUtente.ID
      dr.Item("TurnoRichiedente") = ""
      dr.Item("Data") = ddlDataCal.SelectedDate
      dr.Item("Ts") = Now
      'dr.Item("IdAccertatoreDestinatario") = 0
      dr.Item("TurnoDestinatario") = ""
      dr.Item("StatoRichiesta") = "1"

      DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").Rows.InsertAt(dr, 0)
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
    s = s.Replace("@PTAAGG", CDate(ddlDataCal.SelectedDate).Year)
    s = s.Replace("@PTMMGG", CDate(ddlDataCal.SelectedDate).Month)
    s = s.Replace("@PTGGGG", CDate(ddlDataCal.SelectedDate).Day)
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

      DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambioTurnoStessoTipo.Fill(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")

      Page.DataBind()
    End If
  End Sub

  Public Sub cvData_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvData.ServerValidate
    'DM2020.03 - controllo che sia un giorno più avanti di 48 ore
    '         - poi se sia festivo o meno
    '         - per ultimo se capita proprio come primo giorno utile ma oggi siamo già dopo le 18

    If (ddlDataCal.SelectedDate < pDate48H) Then
      'La richiesta di cambio turno deve essere avanzata entro le 18:00 del giorno antecedente l’uscita del servizio 48 ore
      cvData.ErrorMessage = "La richiesta di cambio turno deve essere avanzata entro le 18:00 del giorno lavorativo antecedente l’uscita del servizio 48 ore" & "<br>" & "Primo giorno selezionabile: " & pDate48H.Date.ToShortDateString.ToString
      args.IsValid = False
    ElseIf pFestivita(ddlDataCal.SelectedDate, True) Then
      cvData.ErrorMessage = "Non è possibile scegliere un giorno festivo o di riposo"
      args.IsValid = False
    Else
        args.IsValid = True      
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
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlDataCal.SelectedDate
    con.Open()
    args.IsValid = sc.ExecuteScalar() = 0
    con.Close()

  End Sub
  Public Sub cvGiornalieroAbilitato_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvGiornalieroAbilitato.ServerValidate
    'Dim Config As New System.Configuration.AppSettingsReader
    'Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    'comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlDataCal.SelectedDate
    'con.Open()
    'args.IsValid = comNumExecutionTime.ExecuteScalar() = 1
    'con.Close()

  End Sub

  Private Sub cvEccezioni_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvEccezioni.ServerValidate
    Dim sc As New SqlClient.SqlCommand("dbo.prt_getchangeandexc", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@ID", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@DT", SqlDbType.DateTime).Value = ddlDataCal.SelectedDate
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

  Function AggiornoTurno(ByVal InpTS As Date, ByVal InpUtente As Integer, ByVal InpTurno As String) As Boolean
    'DM2020.03 aggiorno turno
    Dim DataTradotta As String
    DataTradotta = InpTS.Year.ToString + "-" + Right("00" + InpTS.Month.ToString, 2) + "-" + Right("00" + InpTS.Day.ToString, 2)
    DataTradotta = DataTradotta + " " + Right("00" + Hour(InpTS).ToString, 2) + ":" + Right("00" + Minute(InpTS).ToString, 2) + ":" + Right("00" + Second(InpTS).ToString, 2)

    Dim sc As New SqlClient.SqlCommand("UPDATE dbo.RichiesteCambiTurnoStessoTipo SET TurnoDestinatario = @TurnoDestinatario where CONVERT(varchar, ts, 20) = @TS and IdAccertatoreRichiedente = @IdUtente", con)


    sc.Parameters.Add("@TS", SqlDbType.VarChar).Value = DataTradotta
    sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = InpUtente
    sc.Parameters.Add("@TurnoDestinatario", SqlDbType.VarChar).Value = InpTurno

    On Error GoTo err_aggiorno_turno
    con.Open()
    sc.ExecuteNonQuery()
    AggiornoTurno = True

    con.Close()
    Exit Function
err_aggiorno_turno:

    AggiornoTurno = False
  End Function

  Function InseriscoTurno(ByVal InpIdUtente As Integer, ByVal InpTurnoAttuale As Integer, ByVal InpTurno As String) As Boolean
    'DM2020.03 inserisco turno
    Dim sc As New SqlClient.SqlCommand("INSERT INTO dbo.RichiesteCambiTurnoStessoTipo (IdRichiesta, IdAccertatoreRichiede" & _
    "nte, TurnoRichiedente,  TurnoDestinatario, data, StatoRichiesta) VALUE" & _
    "S (@IdRichiesta, @IdAccertatoreRichiedente, @TurnoRichiedente, " & _
    " @TurnoDestinatario, @data,@StatoRichiesta)", Me.con)


    sc.Parameters.Add("@IdRichiesta", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid
    sc.Parameters.Add("@IdAccertatoreRichiedente", SqlDbType.Int).Value = InpIdUtente
    sc.Parameters.Add("@TurnoRichiedente", SqlDbType.Int).Value = InpTurnoAttuale
    sc.Parameters.Add("@TurnoDestinatario", SqlDbType.VarChar).Value = InpTurno
    sc.Parameters.Add("@data", SqlDbType.DateTime).Value = ddlDataCal.SelectedDate
    sc.Parameters.Add("@StatoRichiesta", SqlDbType.Int).Value = 1
    '
    On Error GoTo err_inserisco_turno
    con.Open()
    sc.ExecuteNonQuery()
    InseriscoTurno = True

    con.Close()
    Exit Function
err_inserisco_turno:

    InseriscoTurno = False
  End Function
  Function CancelloTurno(ByVal InpTS As Date, ByVal InpUtente As Integer) As Boolean
    'DM2020.03 cancello turno
    Dim DataTradotta As String

    DataTradotta = InpTS.Year.ToString + "-" + Right("00" + InpTS.Month.ToString, 2) + "-" + Right("00" + InpTS.Day.ToString, 2)
    DataTradotta = DataTradotta + " " + Right("00" + Hour(InpTS).ToString, 2) + ":" + Right("00" + Minute(InpTS).ToString, 2) + ":" + Right("00" + Second(InpTS).ToString, 2)
    Dim sc As New SqlClient.SqlCommand("DELETE dbo.RichiesteCambiTurnoStessoTipo" & _
    " WHERE CONVERT(varchar, ts, 20) = @ts and IdAccertatoreRichiedente = @IdUtente", Me.con)
    sc.Parameters.Add("@ts", SqlDbType.VarChar).Value = DataTradotta
    sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = InpUtente
    '
    On Error GoTo err_cancello_turno

    con.Open()
    sc.ExecuteNonQuery()
    CancelloTurno = True

    con.Close()
    Exit Function
err_cancello_turno:

    CancelloTurno = False
  End Function



  Private Sub dgCambiTurnoGiornalieriStessoTipo_EditCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.EditCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnModifica.IsValid Then
      pCaricaTurniAccertatoriGiornaliero(e.Item.Cells(8).Text)
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
    cvOnDelete.IsValid = (DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da Approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnDelete.IsValid Then

      If CancelloTurno(e.Item.Cells(2).Text, oUtente.ID) Then

        daCambioTurnoStessoTipo.Update(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")
        DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").Clear()
        daCambioTurnoStessoTipo.Fill(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Eliminato cambio turno stesso tipo", Session("IPAddress"))
      End If
      dgCambiTurnoGiornalieriStessoTipo_CancelCommand1(source, e)
    End If
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.ItemCommand

    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "Premo ITEM COMMANDo", Session("IPAddress"))
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_ItemCreated1(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di cambio turno?');")
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_UpdateCommand1(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.UpdateCommand

    Dim TRic As Integer
    Dim TDes As Integer
    Dim IRic As Integer
    Dim IDes As Integer


    If Me.IsValid Then
      If oUtente.bStoInserendo Then
        InseriscoTurno(oUtente.ID, pGetTurno(oUtente.IDUser), DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue)
        oUtente.bStoInserendo = False
        'dr = DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").NewRow
        'dr.Item("IdRichiesta") = Guid.NewGuid
        'dr.Item("ts") = Now
        'dr.Item("TurnoDestinatario") = DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue
        'dr.Item("IdAccertatoreRichiedente") = oUtente.ID
        'dr.Item("TurnoRichiedente") = pGetTurno(oUtente.IDUser)
        'dr.Item("Data") = ddlData.SelectedValue
        'DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").Rows.Add(dr)
      Else
        pCaricaTurniAccertatoriGiornaliero(ddlDataCal.SelectedDate)
        'dr.Item("TurnoDestinatario") = DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue
        ''DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedItem.Value
        ''daCambioTurnoStessoTipo.UpdateCommand.Parameters("@IdRichiesta").Value = dr.Item("IdRichiesta")
        ''dr.Item("IdAccertatoreDestinatario") = pGetIDAccertatoreDestinatario(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue)
        If AggiornoTurno(e.Item.Cells(2).Text, oUtente.ID, DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue) Then
          fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoStessoTipo.aspx", "HO FATTO MODIFICA AL TURNO", Session("IPAddress"))
        End If
      End If
      DsCambiTurnoStessoTipo.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambioTurnoStessoTipo.Update(DsCambiTurnoStessoTipo)
      daCambioTurnoStessoTipo.Fill(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")
      '--> daCambioTurnoStessoTipo.Fill(DsCambiTurnoStessoTipo, "RichiesteCambiTurnoStessoTipo")
      ''''FT - Toglie l'editing mode
      dgCambiTurnoGiornalieriStessoTipo_CancelCommand1(source, e)
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturno.aspx", "Confermata la modifica al cambio turno", Session("IPAddress"))
    End If
    'End If
  End Sub


  Private Sub cvOnModifica_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles cvOnModifica.Init

  End Sub



  Private Sub btnNuovaRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click
    oUtente.bStoInserendo = True
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoGiornalieriStessoTipo.SelectedIndexChanged

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

  Private Sub ddlDataCal_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlDataCal.SelectionChanged

  End Sub
End Class
