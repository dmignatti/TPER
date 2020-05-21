Public Class wf_cambiturnoNecessario
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCambiTurnoNecessario = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoNecessario1 = New ATCBussm1.dsCambiTurnoGiornalieri
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.daAccertatoriASGiornaliero = New System.Data.Odbc.OdbcDataAdapter
    Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
    Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
    Me.daCambiTurnoDaAccettare = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoDaAccettare1 = New ATCBussm1.dsCambiTurnoDaAccettare
    Me.daEccezioni = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    CType(Me.DsCambiTurnoNecessario1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCambiTurnoNecessario
    '
    Me.daCambiTurnoNecessario.DeleteCommand = Me.SqlCommand2
    Me.daCambiTurnoNecessario.InsertCommand = Me.SqlCommand1
    Me.daCambiTurnoNecessario.SelectCommand = Me.SqlSelectCommand1
    Me.daCambiTurnoNecessario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurno", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("TurnoRichiedente", "TurnoRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("TurnoDestinatario", "TurnoDestinatario"), New System.Data.Common.DataColumnMapping("Destinatario", "Destinatario"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("MatricolaAccertatoreDestinatario", "MatricolaAccertatoreDestinatario")})})
    Me.daCambiTurnoNecessario.UpdateCommand = Me.SqlCommand3
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "DELETE FROM dbo.RichiesteCambiTurnoNecessario WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "INSERT INTO dbo.RichiesteCambiTurnoNecessario (IdRichiesta, IdAccertatoreRichiede" & _
    "nte, TurnoRichiedente, IdAccertatoreDestinatario, TurnoDestinatario, data) VALUE" & _
    "S (@IdRichiesta, @IdAccertatoreRichiedente, @TurnoRichiedente, @IdAccertatoreDes" & _
    "tinatario, @TurnoDestinatario, @data)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreRichiedente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoRichiedente", System.Data.SqlDbType.Int, 4, "TurnoRichiedente"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoDestinatario", System.Data.SqlDbType.Int, 4, "TurnoDestinatario"))
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data", System.Data.SqlDbType.DateTime, 8, "data"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatoreRichiedente, CASE WHEN R.TurnoRichiede" & _
    "nte < 90000 THEN LTrim(Str(R.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichie" & _
    "dente, R.IdAccertatoreDestinatario, CASE WHEN R.TurnoDestinatario < 90000 THEN L" & _
    "Trim(Str(R.TurnoDestinatario)) ELSE 'Riposo' END AS TurnoDestinatario, '(' + U.I" & _
    "DUser + ') ' + U.Cognome + ' ' + U.Nome AS Destinatario, R.data, CASE WHEN Stato" & _
    "Richiesta IS NULL THEN 'Da accettare' WHEN StatoRichiesta = 0 THEN 'Rifutato' WH" & _
    "EN StatoRichiesta = 1 THEN 'Accettato' END AS StatoRichiesta, CASE WHEN StatoApp" & _
    "rovazione IS NULL THEN 'Da approvare' WHEN StatoApprovazione = 0 THEN 'Respinto'" & _
    " WHEN StatoApprovazione = 1 THEN 'Approvato' END AS StatoApprovazione, U.ID, U.I" & _
    "DUser AS MatricolaAccertatoreDestinatario FROM dbo.RichiesteCambiTurnoNecessario" & _
    " R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatoreDestinatario = U.ID WHERE " & _
    " R.IdAccertatoreRichiedente = @IdUtente AND month(R.data) >= month(GETDATE()) OR" & _
    "DER  BY R.ts DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "UPDATE dbo.RichiesteCambiTurnoNecessario SET IdAccertatoreDestinatario = @IdAccer" & _
    "tatoreDestinatario, TurnoDestinatario = @TurnoDestinatario, ts = GETDATE() WHERE" & _
    " (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoDestinatario", System.Data.SqlDbType.Int, 4, "TurnoDestinatario"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsCambiTurnoNecessario1
    '
    Me.DsCambiTurnoNecessario1.DataSetName = "dsCambiTurnoNecessario"
    Me.DsCambiTurnoNecessario1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'daAccertatoriASGiornaliero
    '
    Me.daAccertatoriASGiornaliero.InsertCommand = Me.OdbcInsertCommand1
    Me.daAccertatoriASGiornaliero.SelectCommand = Me.OdbcSelectCommand3
    Me.daAccertatoriASGiornaliero.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Matricola", "Matricola"), New System.Data.Common.DataColumnMapping("Accertatore", "Accertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Turno", "Turno"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
    '
    'OdbcInsertCommand1
    '
    Me.OdbcInsertCommand1.CommandText = "INSERT INTO INNOTEST.AMPTG00F(PTMATR, PTGGGG, PTMMGG, PTAAGG, PTCTUR, PTFLSM) VAL" & _
    "UES (?, ?, ?, ?, ?, ?)"
    Me.OdbcInsertCommand1.Connection = Me.conAS400
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTMATR", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "PTMATR", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTGGGG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "PTGGGG", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTMMGG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "PTMMGG", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTAAGG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "PTAAGG", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTCTUR", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "PTCTUR", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("PTFLSM", System.Data.Odbc.OdbcType.VarChar, 1, "PTFLSM"))
    '
    'OdbcSelectCommand3
    '
    Me.OdbcSelectCommand3.CommandText = CType(configurationAppSettings.GetValue("SelectTurniAccertatoriGiornalieroN", GetType(System.String)), String)
    Me.OdbcSelectCommand3.Connection = Me.conAS400
    '
    'daCambiTurnoDaAccettare
    '
    Me.daCambiTurnoDaAccettare.SelectCommand = Me.SqlSelectCommand4
    Me.daCambiTurnoDaAccettare.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoNecessario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("EtichettaStatoRichiesta", "EtichettaStatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
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
    "esteCambiTurnoNecessario R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatoreRi" & _
    "chiedente = U.ID WHERE (R.IdAccertatoreDestinatario = @IdUtente) AND (R.StatoApp" & _
    "rovazione IS NULL) AND (R.data >= GETDATE()) ORDER BY R.data"
    Me.SqlSelectCommand4.Connection = Me.con
    Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    '
    'SqlCommand5
    '
    Me.SqlCommand5.CommandText = "UPDATE dbo.RichiesteCambiTurnoNecessario SET StatoRichiesta = @StatoRichiesta WHE" & _
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
    CType(Me.DsCambiTurnoNecessario1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgCambiTurnoGiornalieri As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblCambiTurno As System.Web.UI.WebControls.Label
  Protected WithEvents btnAnnulla As System.Web.UI.WebControls.Button
  Protected WithEvents btnOk As System.Web.UI.WebControls.Button
  Protected WithEvents pnlData As System.Web.UI.WebControls.Panel
  Protected WithEvents btnNuovaRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents daAccertatoriASGiornaliero As System.Data.Odbc.OdbcDataAdapter
  Protected WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
  Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTurnoVuoto As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTurnoOkGiornaliero As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvSoloUnCambio As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
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
  Protected WithEvents daCambiTurnoNecessario As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsCambiTurnoNecessario1 As ATCBussm1.dsCambiTurnoGiornalieri
  Protected WithEvents ddlData As System.Web.UI.WebControls.DropDownList

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

  Dim oUtente As Utente
  Dim fnc As New Funzioni
  Private pDate48H As DateTime

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    '-- DM2020.05
    oUtente.bStoAccettando = False
    oUtente.iRigaAccetto = 0

    'FT - !!! - Abilito l'interfaccia solo per gli accertatori
    'FT - !!! - Questo perché sono gli unici ad avere nell'IDUser il numero di matricola che serve per caricare i turni
    cvTipoUtente.Validate()
    btnNuovaRichiesta.Enabled = cvTipoUtente.IsValid And Not pnlData.Visible And dgCambiTurnoGiornalieri.EditItemIndex = -1
    'FT - !!!

    daCambiTurnoNecessario.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoNecessario.Fill(DsCambiTurnoNecessario1, "RichiesteCambiTurno")

    daCambiTurnoDaAccettare.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoNecessario")

    If Not IsPostBack Then
      DateNecesarie(ddlData)

      '
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  Private Sub DateNecesarie(ByRef ddl As DropDownList)
    Dim i As Integer = 0
    Dim data As DateTime = Now.Date
    Dim DtMIN As String
    'If (Now.Hour >= 17) Then
    '  data = Now.AddDays(1)
    'End If

    data = data.AddDays(1)
    DtMIN = "CONVERT(DATETIME, '" & pDate48H.Year.ToString & "-" & pDate48H.Month.ToString & "-" & pDate48H.Day.ToString & "', 102)"
    Dim sc As New SqlClient.SqlCommand("SELECT CONVERT(DATETIME,STR([TNAAVE]) + '-' +  STR(TNMMVE) + '-' +  STR(TNGGVE), 102) AS LADATA FROM [AMTNE00F]  INNER JOIN AMPTG00F   ON AMPTG00F.PTCTUR = TNCTUR AND PTMMGG = TNMMVE AND PTAAGG = TNAAVE AND PTGGGG = TNGGVE Where PTMATR = @Matricola and PTCTUR <> 0 and CONVERT(DATETIME,STR([TNAAVE]) + '-' +  STR(TNMMVE) + '-' +  STR(TNGGVE), 102)> " & DtMIN & " ORDER BY PTMATR,  TNAAVE, TNMMVE,TNGGVE", con)
    sc.Parameters.Add("@Matricola", SqlDbType.VarChar).Value = oUtente.IDUser
    Dim drx As SqlClient.SqlDataReader
    con.Open()
    drx = sc.ExecuteReader()

    While drx.Read()
      Dim d As DateTime
      d = drx.GetValue(0)
      ddl.Items.Add(New ListItem(d.ToString("D"), drx.GetValue(0)))

      'ddl.Items.Add(New ListItem(data.ToString("D"), CDate("2004-08-30")))
      i += 1
    End While
    drx.Close()
    con.Close()
  End Sub
  Public Sub cvdatadaaccettare_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    Dim dt As Date
    ''DM2020.01 - FINO ALLE 18.00
    '''If (Now.Hour >= 18) Then
    '''  dt = Now.AddDays(2).Date
    '''Else
    '''  dt = Now.AddDays(1).Date
    '''End If
    ''--> DM2020.05
    ''--> Ho tolto il controllo sopra perché di fatto pDate48 controlla già che si sia dopo le 18 e nel caso, la data
    ''     di riferimento è un giorno ulteriore.
    If oUtente.bStoAccettando Then
      'CType(source, System.Web.UI.WebControls.CustomValidator).ErrorMessage = "" 
      args.IsValid = Convert.ToDateTime(DirectCast(dgCambiTurnoDaAccettare.Items.Item(oUtente.iRigaAccetto).FindControl("lbldata"), Label).Text) > pDate48H
      oUtente.bStoAccettando = False
      '--> DirectCast(source, CustomValidator).ErrorMessage = "Le richieste di scambio consensuale di turno necessario sono consentite fino alle ore 18:00 del giorno precedente a quello interessato dalla richiesta."
    End If

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
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Click nuovo cambio turno", Session("IPAddress"))
  End Sub

  Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
    pShowPanel(False)
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Annullata richiesta nuovo cambio turno", Session("IPAddress"))
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
      Dim dr As DataRow = DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").NewRow
      dr.Item("IdRichiesta") = Guid.NewGuid
      dr.Item("IdAccertatoreRichiedente") = oUtente.ID
      dr.Item("Data") = ddlData.SelectedValue
      dr.Item("Destinatario") = DsCambiTurnoNecessario1.Tables("Accertatori").Rows(0).Item("CognomeNome")
      dr.Item("IdAccertatoreDestinatario") = DsCambiTurnoNecessario1.Tables("Accertatori").Rows(0).Item("ID")
      dr.Item("MatricolaAccertatoreDestinatario") = DsCambiTurnoNecessario1.Tables("Accertatori").Rows(0).Item("Matricola")
      DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Rows.InsertAt(dr, 0)
      dgCambiTurnoGiornalieri.EditItemIndex = 0
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Inserito cambio turno in stato modifica, da confermare ", Session("IPAddress"))
      'End If

      'Else
      'FT - !!! - Errore: non ci sono altri accertatori in turno per questa data
    End If
    pShowPanel(False)
  End Sub

  Private Sub pCaricaTurniAccertatoriGiornaliero(ByVal pData As Date)
    'pData = CDate("2004-08-30")

    Dim strblocchi As String
    strblocchi = " "
    Dim cmdblocchi As New SqlClient.SqlCommand("SELECT ATC_Utenti.IDUser FROM Accertatori_BloccoCambioGiornaliero INNER JOIN ATC_Utenti ON Accertatori_BloccoCambioGiornaliero.AccertatoreId = ATC_Utenti.ID WHERE (Accertatori_BloccoCambioGiornaliero.InizioOn <= GetDate()) AND (Accertatori_BloccoCambioGiornaliero.FineOn > getdate())", con)

    Dim drblocchi As SqlClient.SqlDataReader
    con.Open()
    drblocchi = cmdblocchi.ExecuteReader()
    If drblocchi.HasRows Then

      Do While drblocchi.Read
        strblocchi = strblocchi & " AND  A.PTMATR <> '" & drblocchi("IDUser") & "' "    
      Loop
    Else
    End If

    con.Close()

    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Filtro " & strblocchi, Session("IPAddress"))
    Dim s As String = daAccertatoriASGiornaliero.SelectCommand.CommandText
    s = s.Replace("@Anno", pData.Year)
    s = s.Replace("@Mese", pData.Month)
    s = s.Replace("@Giorno", pData.Day)
    s = s.Replace("@Matricola", oUtente.IDUser)
    s = s.Replace("ORDER BY CognomeNome", strblocchi & " ORDER BY CognomeNome")
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Commandtext " & s, Session("IPAddress"))
    daAccertatoriASGiornaliero.SelectCommand.CommandText = s
    DsCambiTurnoNecessario1.Tables("Accertatori").Clear()
    daAccertatoriASGiornaliero.Fill(DsCambiTurnoNecessario1, "Accertatori")
  End Sub

  Private Sub cvTipoUtente_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTipoUtente.ServerValidate
    args.IsValid = oUtente.TipoUtente = 2
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieri.EditCommand
    cvOnModifica.IsValid = (DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "Da accettare" Or DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnModifica.IsValid Then
      pCaricaTurniAccertatoriGiornaliero(DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Rows.Find(dgCambiTurnoGiornalieri.DataKeys(e.Item.ItemIndex)).Item("Data"))
      dgCambiTurnoGiornalieri.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnNuovaRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Stato di modifica del cambio turno", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieri.CancelCommand
    btnNuovaRichiesta.Enabled = True
    dgCambiTurnoGiornalieri.EditItemIndex = -1
    Page.DataBind()
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Annullata la modifica del cambio turno", Session("IPAddress"))
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieri.DeleteCommand
    cvOnDelete.IsValid = (DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnDelete.IsValid Then
      Dim dr As DataRow = DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Rows.Find(dgCambiTurnoGiornalieri.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daCambiTurnoNecessario.Update(DsCambiTurnoNecessario1, "RichiesteCambiTurno")
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Eliminato cambio turno", Session("IPAddress"))
      End If
      dgCambiTurnoGiornalieriStessoTipo_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgCambiTurnoGiornalieriStessoTipo_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoGiornalieri.UpdateCommand

    Dim TRic As Integer
    Dim TDes As Integer
    Dim IRic As Integer
    Dim IDes As Integer

    pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)

    TRic = pGetTurno(oUtente.IDUser)
    TDes = DsCambiTurnoNecessario1.Tables("Accertatori").Rows.Find(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue).Item("Turno")
    IRic = oUtente.ID
    IDes = pGetIDAccertatoreDestinatario(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue)

    Dim sc As New SqlClient.SqlCommand("dbo.prt_getLicenseAuthorization", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@TRIC", SqlDbType.Int).Value = TRic
    sc.Parameters.Add("@TDES", SqlDbType.Int).Value = TDes
    sc.Parameters.Add("@IRIC", SqlDbType.Int).Value = IRic
    sc.Parameters.Add("@IDES", SqlDbType.Int).Value = IDes

    Dim drx As SqlClient.SqlDataReader
    con.Open()
    drx = sc.ExecuteReader()
    drx.Read()
    Dim RicAbilitato As Boolean = drx("RicAbilitato")
    Dim DesAbilitato As Boolean = drx("DesAbilitato")
    con.Close()

    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", String.Format("Ric:{0} Des:{1}", RicAbilitato.ToString(), DesAbilitato.ToString()), Session("IPAddress"))

    If Not (RicAbilitato And DesAbilitato) Then
      cvCheckPatente.IsValid = False

    Else
     
      If Me.IsValid Then
        Dim dr As DataRow = DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Rows.Find(dgCambiTurnoGiornalieri.DataKeys(e.Item.ItemIndex))
        If dr Is Nothing Then
          dr = DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").NewRow
          dr.Item("IdRichiesta") = Guid.NewGuid
          dr.Item("IdAccertatoreRichiedente") = oUtente.ID
          dr.Item("TurnoRichiedente") = pGetTurno(oUtente.IDUser)
          dr.Item("Data") = ddlData.SelectedValue
          DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Rows.Add(dr)
        End If
        pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)
        dr.Item("TurnoDestinatario") = DsCambiTurnoNecessario1.Tables("Accertatori").Rows.Find(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue).Item("Turno")
        dr.Item("IdAccertatoreDestinatario") = pGetIDAccertatoreDestinatario(DirectCast(e.Item.FindControl("ddlDestinatarioCambioTurno"), DropDownList).SelectedValue)
        daCambiTurnoNecessario.Update(DsCambiTurnoNecessario1, "RichiesteCambiTurno")
        DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Clear()
        daCambiTurnoNecessario.Fill(DsCambiTurnoNecessario1, "RichiesteCambiTurno")
        'FT - Toglie l'editing mode
        dgCambiTurnoGiornalieriStessoTipo_CancelCommand(source, e)
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Confermata la modifica al cambio turno", Session("IPAddress"))
      End If
    End If
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
    args.IsValid = DsCambiTurnoNecessario1.Tables("Accertatori").Rows.Count > 0

  End Sub

  Private Sub cvTurnoOkGiornaliero_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTurnoOkGiornaliero.ServerValidate


    Dim conf As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Dim com As New Odbc.OdbcCommand(conf.GetValue("SelectTurnoOkGiornalieroAccertatore", GetType(String)), conAS400)
    Dim s As String = com.CommandText
    s = s.Replace("@Matricola", oUtente.IDUser)
    s = s.Replace("@Anno", CDate(ddlData.SelectedValue).Year)
    s = s.Replace("@Mese", CDate(ddlData.SelectedValue).Month)
    s = s.Replace("@Giorno", CDate(ddlData.SelectedValue).Day)
    's = s.Replace("@Blocchi", strblocchi)
    com.CommandText = s
    conAS400.Open()
    args.IsValid = com.ExecuteScalar() > 0
    conAS400.Close()
  End Sub

  Private Function pGetIDAccertatoreDestinatario(ByVal Matricola As String) As Integer
    Dim com As New SqlClient.SqlCommand("Select Id From ATC_Utenti Where IDUser = @IDUser", con)
    com.Parameters.Add("@IDUser", SqlDbType.VarChar).Value = Matricola
    con.Open()
    pGetIDAccertatoreDestinatario = com.ExecuteScalar
    con.Close()
  End Function

  Private Sub dgCambiTurnoGiornalieriStessoTipo_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCambiTurnoGiornalieri.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then DirectCast(e.Item.FindControl("btnDelete"), Button).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di cambio turno necessario?');")
  End Sub

  Private Sub cvSoloUnCambio_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvSoloUnCambio.ServerValidate
    '---------------------------
    'DM2020.02 ULTERIORE CONTROLLO
    args.IsValid = PossoCambioTNecessario(ddlData.SelectedValue)
    


  End Sub

  Private Sub dgCambiTurnoDaAccettare_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoDaAccettare.ItemCommand
    Dim dr As DataRow = DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurnoNecessario").Rows.Find(dgCambiTurnoDaAccettare.DataKeys(e.Item.ItemIndex))
    oUtente.bStoAccettando = True
    oUtente.iRigaAccetto = e.Item.ItemIndex
    Page.Validate()
    If Page.IsValid Then
      Select Case e.CommandName
        Case "Accetta"
          dr.Item("StatoRichiesta") = 1
          fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Accettato cambio turno", Session("IPAddress"))
        Case "Rifiuta"
          dr.Item("StatoRichiesta") = 0
          fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnoNecessario.aspx", "Rifiutato cambio turno", Session("IPAddress"))
      End Select
      daCambiTurnoDaAccettare.Update(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoNecessario")

      DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurno").Clear()
      daCambiTurnoDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoNecessario")

      DsCambiTurnoNecessario1.Tables("RichiesteCambiTurno").Clear()
      daCambiTurnoNecessario.Fill(DsCambiTurnoNecessario1, "RichiesteCambiTurno")

      Page.DataBind()
    End If
    oUtente.bStoAccettando = False
  End Sub

  Public Sub cvData_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvData.ServerValidate

    If ddlData.SelectedValue < pDate48H Then
      args.IsValid = False
      DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere solo date dal " & pDate48H.ToString
    ElseIf ddlData.SelectedValue > Now.Date.AddDays(60) Then
      args.IsValid = False
      DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere congedi oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")
    Else
      args.IsValid = True
    End If


    If (ddlData.SelectedValue = pDate48H) Then
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
    " FROM dbo.RichiesteCambiTurnoNecessario R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatoreDestinatario = U.ID " & _
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
    'Dim Config As New System.Configuration.AppSettingsReader
    'Dim comNumExecutionTime As New SqlClient.SqlCommand(Config.GetValue("SQLNumExecutionTime", GetType(String)), con)
    'comNumExecutionTime.Parameters.Add("@Data", SqlDbType.DateTime).Value = ddlData.SelectedValue
    'con.Open()
    'args.IsValid = comNumExecutionTime.ExecuteScalar() = 1
    'con.Close()

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
  Function PossoCambioTNecessario(ByVal InpData As DateTime) As Boolean
    'DM2020.04 - CONTROLLO IL TURNO NECESSARIO
    ' mi basta capire se questo mese, l'utente richiedente abbia già richiesto un turno necessario

    Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurnoNecessario Where (IdAccertatoreRichiedente = @IdUtente) And month(Data) = month(@Data) and year(Data) = year(@Data) And (StatoRichiesta Is Null Or StatoRichiesta = 1) and (StatoApprovazione is null or StatoApprovazione = 1)", con)
    sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = InpData
    con.Open()
    PossoCambioTNecessario = sc.ExecuteScalar() < 1
    con.Close()

  End Function


  Private Sub btnNuovaRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click

  End Sub

  Private Sub dgCambiTurnoGiornalieri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoGiornalieri.SelectedIndexChanged

  End Sub

  Private Sub dgCambiTurnoDaAccettare_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoDaAccettare.SelectedIndexChanged

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

  Private Function pTurnoNecessario(ByVal dal As Date, Optional ByVal inpMATRICOLA As String = "") As Boolean
    'DM2020.02 - controllo che la data sia una festività: se lo è ritorno TRUE
    'DM2020.04 - aggiungo che si possa cercare un qualunque UTENTE, se gli si passa la matricola
    Dim i As Integer = 0
    Dim sc As New SqlClient.SqlCommand("exec Sp_SonoSuUnTurnoNecessario @Matricola, @Data", con)
    '------- DM20202.04
    If inpMATRICOLA = "" Then inpMATRICOLA = oUtente.IDUser
    '------- 
    sc.Parameters.Add("@Matricola", SqlDbType.VarChar).Value = inpMATRICOLA
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
End Class
