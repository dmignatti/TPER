Public Class wf_cambiturnomensile
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCambiTurnoMensile = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoMensile1 = New ATCBussm1.dsCambiTurnoMensile
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.comCheckMensileAperto = New System.Data.Odbc.OdbcCommand
    Me.comCheckTurnoMensile = New System.Data.Odbc.OdbcCommand
    Me.comCheckCambiTurno = New System.Data.SqlClient.SqlCommand
    Me.daAccertatoriAS = New System.Data.Odbc.OdbcDataAdapter
    Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
    Me.comTurnoMensile = New System.Data.Odbc.OdbcCommand
    Me.comIdAccertatoreDestinatario = New System.Data.SqlClient.SqlCommand
    Me.daCambiTurnoMensileDaAccettare = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand12 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoDaAccettare1 = New ATCBussm1.dsCambiTurnoDaAccettare
    CType(Me.DsCambiTurnoMensile1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCambiTurnoMensile
    '
    Me.daCambiTurnoMensile.DeleteCommand = Me.SqlCommand7
    Me.daCambiTurnoMensile.InsertCommand = Me.SqlCommand8
    Me.daCambiTurnoMensile.SelectCommand = Me.SqlCommand9
    Me.daCambiTurnoMensile.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoMensile", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("Destinatario", "Destinatario"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("MatricolaAccertatoreDestinatario", "MatricolaAccertatoreDestinatario")})})
    Me.daCambiTurnoMensile.UpdateCommand = Me.SqlCommand10
    '
    'SqlCommand7
    '
    Me.SqlCommand7.CommandText = "DELETE FROM dbo.RichiesteCambiTurnoMensile WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand7.Connection = Me.con
    Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlCommand8
    '
    Me.SqlCommand8.CommandText = "INSERT INTO dbo.RichiesteCambiTurnoMensile (IdRichiesta, IdAccertatoreRichiedente" & _
    ", IdAccertatoreDestinatario, data, TurnoRichiedente, TurnoDestinatario) VALUES (" & _
    "@IdRichiesta, @IdAccertatoreRichiedente, @IdAccertatoreDestinatario, @data, @Tur" & _
    "noRichiedente, @TurnoDestinatario)"
    Me.SqlCommand8.Connection = Me.con
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreRichiedente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@data", System.Data.SqlDbType.DateTime, 8, "data"))
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoRichiedente", System.Data.SqlDbType.Int, 4, "TurnoRichiedente"))
    Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoDestinatario", System.Data.SqlDbType.Int, 4, "TurnoDestinatario"))
    '
    'SqlCommand9
    '
    Me.SqlCommand9.CommandText = "SELECT R.IdRichiesta, R.IdAccertatoreRichiedente, R.TurnoRichiedente, R.IdAccerta" & _
    "toreDestinatario, R.TurnoDestinatario, '(' + U.IDUser + ') ' + U.Cognome + ' ' +" & _
    " U.Nome AS Destinatario, U.IDUser AS MatricolaAccertatoreDestinatario, R.data, C" & _
    "ASE WHEN StatoRichiesta IS NULL THEN 'Da accettare' WHEN StatoRichiesta = 0 THEN" & _
    " 'Rifutato' WHEN StatoRichiesta = 1 THEN 'Accettato' END AS StatoRichiesta, CASE" & _
    " WHEN StatoApprovazione IS NULL THEN 'Da approvare' WHEN StatoApprovazione = 0 T" & _
    "HEN 'Respinto' WHEN StatoApprovazione = 1 THEN 'Approvato' END AS StatoApprovazi" & _
    "one, U.ID, R.ts FROM dbo.RichiesteCambiTurnoMensile R LEFT OUTER JOIN dbo.ATC_Ut" & _
    "enti U ON R.IdAccertatoreDestinatario = U.ID WHERE (R.IdAccertatoreRichiedente =" & _
    " @IdUtente) AND (R.data >= GETDATE()) OR (R.data >= GETDATE()) AND (R.IdAccertat" & _
    "oreDestinatario = @IdUtente) AND (R.StatoRichiesta IS NOT NULL) ORDER BY R.ts DE" & _
    "SC"
    Me.SqlCommand9.Connection = Me.con
    Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    '
    'SqlCommand10
    '
    Me.SqlCommand10.CommandText = "UPDATE dbo.RichiesteCambiTurnoMensile SET IdAccertatoreDestinatario = @IdAccertat" & _
    "oreDestinatario, TurnoDestinatario = @TurnoDestinatario, ts = GETDATE() WHERE (I" & _
    "dRichiesta = @IdRichiesta)"
    Me.SqlCommand10.Connection = Me.con
    Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatoreDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TurnoDestinatario", System.Data.SqlDbType.Int, 4, "TurnoDestinatario"))
    Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsCambiTurnoMensile1
    '
    Me.DsCambiTurnoMensile1.DataSetName = "dsCambiTurnoMensile"
    Me.DsCambiTurnoMensile1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'comCheckMensileAperto
    '
    Me.comCheckMensileAperto.CommandText = CType(configurationAppSettings.GetValue("SelectCheckMensileAperto", GetType(System.String)), String)
    Me.comCheckMensileAperto.Connection = Me.conAS400
    '
    'comCheckTurnoMensile
    '
    Me.comCheckTurnoMensile.CommandText = CType(configurationAppSettings.GetValue("SelectTurnoOkMensileAccertatore", GetType(System.String)), String)
    Me.comCheckTurnoMensile.Connection = Me.conAS400
    '
    'comCheckCambiTurno
    '
    Me.comCheckCambiTurno.CommandText = "SELECT dbo.PossoCambioMensile(@IdUtente,  @IdUserDestinatario, @Data)"
    Me.comCheckCambiTurno.Connection = Me.con
    Me.comCheckCambiTurno.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreRichiedente"))
    Me.comCheckCambiTurno.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUserDestinatario", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    Me.comCheckCambiTurno.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "data"))
    '
    'daAccertatoriAS
    '
    Me.daAccertatoriAS.SelectCommand = Me.OdbcSelectCommand2
    '
    'OdbcSelectCommand2
    '
    Me.OdbcSelectCommand2.CommandText = CType(configurationAppSettings.GetValue("SelectTurniAccertatoriMensile", GetType(System.String)), String)
    Me.OdbcSelectCommand2.Connection = Me.conAS400
    '
    'comTurnoMensile
    '
    Me.comTurnoMensile.CommandText = CType(configurationAppSettings.GetValue("SelectTurnoMensileAccertatore", GetType(System.String)), String)
    Me.comTurnoMensile.Connection = Me.conAS400
    '
    'comIdAccertatoreDestinatario
    '
    Me.comIdAccertatoreDestinatario.CommandText = "SELECT Id FROM ATC_Utenti WHERE IDUser = @IDUser"
    Me.comIdAccertatoreDestinatario.Connection = Me.con
    Me.comIdAccertatoreDestinatario.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDUser", System.Data.SqlDbType.VarChar, 30, "IDUser"))
    '
    'daCambiTurnoMensileDaAccettare
    '
    Me.daCambiTurnoMensileDaAccettare.SelectCommand = Me.SqlCommand11
    Me.daCambiTurnoMensileDaAccettare.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoMensile", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("IDUser", "IDUser"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("EtichettaStatoRichiesta", "EtichettaStatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("ID", "ID")})})
    Me.daCambiTurnoMensileDaAccettare.UpdateCommand = Me.SqlCommand12
    '
    'SqlCommand11
    '
    Me.SqlCommand11.CommandText = "SELECT R.IdRichiesta, R.IdAccertatoreRichiedente, '(' + U.IDUser + ') ' + U.Cogno" & _
    "me + ' ' + U.Nome AS IDuser, R.TurnoRichiedente, R.IdAccertatoreDestinatario, R." & _
    "TurnoDestinatario, R.StatoRichiesta, CASE StatoRichiesta WHEN NULL THEN 'Da appr" & _
    "ovare' WHEN 0 THEN 'Rifutato' WHEN 1 THEN 'Accettato' END AS EtichettaStatoRichi" & _
    "esta, R.data, R.StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts, U." & _
    "ID FROM dbo.RichiesteCambiTurnoMensile R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.I" & _
    "dAccertatoreRichiedente = U.ID WHERE (R.IdAccertatoreDestinatario = @IdUtente) A" & _
    "ND (R.StatoApprovazione IS NULL) AND R.data >= GetDate() ORDER BY R.data"
    Me.SqlCommand11.Connection = Me.con
    Me.SqlCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdUtente", System.Data.SqlDbType.Int, 4, "IdAccertatoreDestinatario"))
    '
    'SqlCommand12
    '
    Me.SqlCommand12.CommandText = "UPDATE dbo.RichiesteCambiTurnoMensile SET StatoRichiesta = @StatoRichiesta WHERE " & _
    "(IdRichiesta = @IdRichiesta)"
    Me.SqlCommand12.Connection = Me.con
    Me.SqlCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoRichiesta", System.Data.SqlDbType.Int, 4, "StatoRichiesta"))
    Me.SqlCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsCambiTurnoDaAccettare1
    '
    Me.DsCambiTurnoDaAccettare1.DataSetName = "dsCambiTurnoDaAccettare"
    Me.DsCambiTurnoDaAccettare1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsCambiTurnoMensile1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsCambiTurnoDaAccettare1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCambiTurnoMensile As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsCambiTurnoMensile1 As ATCBussm1.dsCambiTurnoMensile
  Protected WithEvents btnNuovaRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents lblCambiTurno As System.Web.UI.WebControls.Label
  Protected WithEvents dgCambiTurnoMensile As System.Web.UI.WebControls.DataGrid
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents comCheckMensileAperto As System.Data.Odbc.OdbcCommand
  Protected WithEvents comCheckTurnoMensile As System.Data.Odbc.OdbcCommand
  Protected WithEvents cvMensileAperto As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvCheckTurnoMensile As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvCheckCambiTurno As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents comCheckCambiTurno As System.Data.SqlClient.SqlCommand
  Protected WithEvents daAccertatoriAS As System.Data.Odbc.OdbcDataAdapter
  Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
  Protected WithEvents comTurnoMensile As System.Data.Odbc.OdbcCommand
  Protected WithEvents cvOnDelete As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents comIdAccertatoreDestinatario As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgCambiTurnoMensileDaAccettare As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblCambiTurnoMensileDaAccettare As System.Web.UI.WebControls.Label
  Protected WithEvents daCambiTurnoMensileDaAccettare As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand12 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsCambiTurnoDaAccettare1 As ATCBussm1.dsCambiTurnoDaAccettare
  Protected WithEvents cvEccezioni As System.Web.UI.WebControls.CustomValidator

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
    btnNuovaRichiesta.Enabled = cvTipoUtente.IsValid And dgCambiTurnoMensile.EditItemIndex = -1
    'FT - !!!

    daCambiTurnoMensile.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoMensile.Fill(DsCambiTurnoMensile1, "RichiesteCambiTurnoMensile")

    daCambiTurnoMensileDaAccettare.SelectCommand.Parameters("@IdUtente").Value = oUtente.ID
    daCambiTurnoMensileDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiturnoMensile")

    If Not IsPostBack Then
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Pagina iniziale", Session("IPAddress"))
    End If

  End Sub

  Private Sub cvTipoUtente_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTipoUtente.ServerValidate
    args.IsValid = oUtente.TipoUtente = 2
  End Sub

  Private Sub btnNuovaRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaRichiesta.Click
    pCaricaTurniAccertatori(Now.Date.AddDays(-Now.Day + 1).AddMonths(1))
    If Me.IsValid Then
      Dim dr As DataRow = DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").NewRow
      dr.Item("IdRichiesta") = Guid.NewGuid
      dr.Item("IdAccertatoreRichiedente") = oUtente.ID
      dr.Item("Data") = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)
      dr.Item("MatricolaAccertatoreDestinatario") = DsCambiTurnoMensile1.Tables("Accertatori").Rows(0).Item("Matricola")
      DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Rows.InsertAt(dr, 0)
      dgCambiTurnoMensile.EditItemIndex = 0
      Page.DataBind()
      btnNuovaRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Click nuovo cambio turno", Session("IPAddress"))
    End If
  End Sub

  Private Sub cvMensileAperto_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvMensileAperto.ServerValidate
    Dim MeseMensileAperto As String
    conAS400.Open()
    MeseMensileAperto = "" & comCheckMensileAperto.ExecuteScalar
    args.IsValid = MeseMensileAperto.Length > 0
    conAS400.Close()
  End Sub

  Private Sub cvCheckTurnoMensile_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvCheckTurnoMensile.ServerValidate
    Dim s As String = comCheckTurnoMensile.CommandText
    s = s.Replace("@Matricola", oUtente.IDUser)
    s = s.Replace("@Anno", Now.Date.AddDays(-Now.Day + 1).AddMonths(1).Year)
    's = s.Replace("@Anno", 2004)
    s = s.Replace("@Mese", Now.Date.AddDays(-Now.Day + 1).AddMonths(1).Month)
    's = s.Replace("@Mese", 8)
    comCheckTurnoMensile.CommandText = s
    conAS400.Open()
    args.IsValid = comCheckTurnoMensile.ExecuteScalar() > 0
    conAS400.Close()
  End Sub

  Private Sub cvCheckCambiTurno_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvCheckCambiTurno.ServerValidate
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "cvCheckCambiTurn - SERVERVALIDATE", Session("IPAddress"))
    con.Open()
    ''comCheckCambiTurno.Parameters("@IdUtente").Value = oUtente.ID
    ''comCheckCambiTurno.Parameters("@Data").Value = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)
    '''comCheckCambiTurno.Parameters("@Data").Value = "2004-08-01"
    ''args.IsValid = comCheckCambiTurno.ExecuteScalar() <= 0
    '---- DM2020.02 - CONTROLLO CAMBIO MENSILE
    If dgCambiTurnoMensile.EditItemIndex <> 0 Then
      'If IsNothing(pGetIDAccertatoreDestinatario(DirectCast(dgCambiTurnoMensile.FindControl("ddlAccertatoreDestinatario"), DropDownList).SelectedValue)) Then
      args.IsValid = True
    Else
      comCheckCambiTurno.Parameters("@IdUtente").Value = oUtente.ID
      comCheckCambiTurno.Parameters("@IdUserDestinatario").Value = pGetIDAccertatoreDestinatario(DirectCast(dgCambiTurnoMensile.FindControl("ddlAccertatoreDestinatario"), DropDownList).SelectedValue)
      '    
      comCheckCambiTurno.Parameters("@Data").Value = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)
      'comCheckCambiTurno.Parameters("@Data").Value = "2004-08-01"
      args.IsValid = comCheckCambiTurno.ExecuteScalar() = "0"
    End If
    con.Close()
  End Sub

  Private Sub pCaricaTurniAccertatori(ByVal pDate As Date)
    DsCambiTurnoMensile1.Tables("Accertatori").Clear()
    Dim s As String = daAccertatoriAS.SelectCommand.CommandText
    s = s.Replace("@Anno", pDate.Year)
    's = s.Replace("@Anno", 2004)
    s = s.Replace("@Mese", pDate.Month)
    's = s.Replace("@Mese", 8)
    s = s.Replace("@Matricola", oUtente.IDUser)
    daAccertatoriAS.SelectCommand.CommandText = s
    daAccertatoriAS.Fill(DsCambiTurnoMensile1, "Accertatori")
  End Sub

  Private Sub dgCambiTurnoMensile_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensile.CancelCommand
    dgCambiTurnoMensile.EditItemIndex = -1
    Page.DataBind()
    btnNuovaRichiesta.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Annullata modifica cambio turno mensile", Session("IPAddress"))
  End Sub

  Private Sub dgCambiTurnoMensile_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensile.EditCommand
    cvOnModifica.IsValid = (DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "Da accettare" Or DirectCast(e.Item.FindControl("lblStatoRichiesta"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnModifica.IsValid Then
      pCaricaTurniAccertatori(DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Rows.Find(dgCambiTurnoMensile.DataKeys(e.Item.ItemIndex)).Item("Data"))
      dgCambiTurnoMensile.EditItemIndex = e.Item.ItemIndex
      Page.DataBind()
      btnNuovaRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Stato di modifica del cambio turno mensile", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCambiTurnoMensile_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensile.DeleteCommand
    cvOnDelete.IsValid = (DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "") And DirectCast(e.Item.FindControl("lblIdAccertatoreRichiedente"), Label).Text = oUtente.ID
    If cvOnDelete.IsValid Then
      Dim dr As DataRow = DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Rows.Find(dgCambiTurnoMensile.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daCambiTurnoMensile.Update(DsCambiTurnoMensile1, "RichiesteCambiTurnoMensile")
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Eliminato cambio turno mensile", Session("IPAddress"))
      End If
      dgCambiTurnoMensile_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgCambiTurnoMensile_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCambiTurnoMensile.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di scambio turno mensile?');")
  End Sub

  Private Sub dgCambiTurnoMensile_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensile.UpdateCommand
    'FT - ??? - Ho tolto causesvalidation del link ok e l'isvalid perché altrimenti scatta la verifica che non ci sia già una richiesta per la data. 
    '           Quando si arriva a questo punto è comunque tutto valido, però sarebbe bello trovare un'altra strada più standard...
    'If Me.IsValid Then



    'DM2020.02 - inserisco il controllo se davvero posso o meno farlo il cambio mensile
    Dim Risposta As String
    Risposta = PossoCambioMensile(pGetIDAccertatoreDestinatario(DirectCast(e.Item.FindControl("ddlAccertatoreDestinatario"), DropDownList).SelectedValue))
    If Risposta = "0" Then
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Posso fare il cambio mensile!", Session("IPAddress"))    

      Dim dr As DataRow = DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Rows.Find(dgCambiTurnoMensile.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").NewRow
        dr.Item("IdRichiesta") = Guid.NewGuid
        dr.Item("IdAccertatoreRichiedente") = oUtente.ID
        dr.Item("TurnoRichiedente") = pGetTurno(oUtente.IDUser)
        dr.Item("Data") = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)
        DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Rows.Add(dr)
      End If
      pCaricaTurniAccertatori(dr.Item("Data"))
      'pCaricaTurniAccertatori("2004-08-30")
      dr.Item("TurnoDestinatario") = DsCambiTurnoMensile1.Tables("Accertatori").Rows.Find(DirectCast(e.Item.FindControl("ddlAccertatoreDestinatario"), DropDownList).SelectedValue).Item("Turno")
      dr.Item("IdAccertatoreDestinatario") = pGetIDAccertatoreDestinatario(DirectCast(e.Item.FindControl("ddlAccertatoreDestinatario"), DropDownList).SelectedValue)
      daCambiTurnoMensile.Update(DsCambiTurnoMensile1, "RichiesteCambiTurnoMensile")
      DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Clear()
      daCambiTurnoMensile.Fill(DsCambiTurnoMensile1, "RichiesteCambiTurnoMensile")
      'FT - Toglie l'editing mode
      dgCambiTurnoMensile_CancelCommand(source, e)
      'End If
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Confermata modifica del cambio turno mensile", Session("IPAddress"))
    Else
      'FT - Toglie l'editing mode
      cvOnModifica.ErrorMessage = Risposta
      cvOnModifica.IsValid = False
      dgCambiTurnoMensile_CancelCommand(source, e)
      fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", Risposta, Session("IPAddress"))
      'End If
    End If
    
  End Sub

  Private Function pGetTurno(ByVal Matricola As String) As Integer
    Dim s As String = comTurnoMensile.CommandText
    s = s.Replace("@SQMATR", Matricola)
    s = s.Replace("@SQAAAS", Now.Date.AddDays(-Now.Day + 1).AddMonths(1).Year)
    's = s.Replace("@SQAAAS", 2004)
    s = s.Replace("@SQMMAS", Now.Date.AddDays(-Now.Day + 1).AddMonths(1).Month)
    's = s.Replace("@SQMMAS", 8)
    comTurnoMensile.CommandText = s
    Try
      conAS400.Open()
      pGetTurno = comTurnoMensile.ExecuteScalar()
      conAS400.Close()
    Catch ex As Exception
      Throw ex
    End Try
  End Function

  Private Function pGetIDAccertatoreDestinatario(ByVal Matricola As String) As Integer
    comIdAccertatoreDestinatario.Parameters("@IdUser").Value = Matricola
    con.Open()
    pGetIDAccertatoreDestinatario = comIdAccertatoreDestinatario.ExecuteScalar
    con.Close()
  End Function

  Private Sub dgCambiTurnoMensileDaAccettare_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensileDaAccettare.ItemCommand
    Dim dr As DataRow = DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurnoMensile").Rows.Find(dgCambiTurnoMensileDaAccettare.DataKeys(e.Item.ItemIndex))
    Select Case e.CommandName
      Case "Accetta"
        dr.Item("StatoRichiesta") = 1
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Accettato cambio turno mensile", Session("IPAddress"))
      Case "Rifiuta"
        dr.Item("StatoRichiesta") = 0
        fnc.ScriviLog(oUtente.IDUser, "wf_cambiturnomensile.aspx", "Rifiutato cambio turno mensile", Session("IPAddress"))
    End Select
    daCambiTurnoMensileDaAccettare.Update(DsCambiTurnoDaAccettare1, "RichiesteCambiTurnoMensile")

    DsCambiTurnoDaAccettare1.Tables("RichiesteCambiTurnoMensile").Clear()
    daCambiTurnoMensileDaAccettare.Fill(DsCambiTurnoDaAccettare1, "RichiesteCambiturnoMensile")

    DsCambiTurnoMensile1.Tables("RichiesteCambiTurnoMensile").Clear()
    daCambiTurnoMensile.Fill(DsCambiTurnoMensile1, "RichiesteCambiTurnoMensile")

    Page.DataBind()

  End Sub

  Private Sub cvEccezioni_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvEccezioni.ServerValidate
    Dim sc As New SqlClient.SqlCommand("dbo.prt_getchangeandexc", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@ID", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@DT", SqlDbType.DateTime).Value = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)
    sc.Parameters.Add("@TP", SqlDbType.Char).Value = "M"

    Dim dr As SqlClient.SqlDataReader
    con.Open()
    dr = sc.ExecuteReader()
    dr.Read()
    Dim numcambi As Int32 = dr("NUMCAMBI")
    Dim numecce As Int32 = dr("NUMECCE")

    args.IsValid = numcambi < numecce
    con.Close()
  End Sub

  Function PossoCambioMensile(ByVal InpIdUserSostituente As Integer) As String
    'DM2020.02 - CONTROLLO CHE IO POSSA FARE UN CAMBIO MENSILE
    Dim sc As New SqlClient.SqlCommand("SP_PossoCambioMensile", con)
    sc.CommandType() = CommandType.StoredProcedure
    sc.Parameters.Add("@IdUser", SqlDbType.Int).Value = oUtente.ID
    sc.Parameters.Add("@IdUserDestinatario", SqlDbType.Int).Value = InpIdUserSostituente
    sc.Parameters.Add("@DataCambio", SqlDbType.DateTime).Value = Now.Date.AddDays(-Now.Day + 1).AddMonths(1)    

    Dim dr As SqlClient.SqlDataReader
    con.Open()
    dr = sc.ExecuteReader()
    dr.Read()

    If dr.FieldCount > 0 Then
      PossoCambioMensile = dr("Risultato")
    Else
      PossoCambioMensile = "0"
    End If
    con.Close()


  End Function

  Private Sub dgCambiTurnoMensileDaAccettare_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoMensileDaAccettare.SelectedIndexChanged

  End Sub

  Private Sub dgCambiTurnoMensile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoMensile.SelectedIndexChanged

  End Sub
End Class

