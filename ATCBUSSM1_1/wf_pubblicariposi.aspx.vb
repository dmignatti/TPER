Public Class wf_pubblicariposi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.daRiposiPubblica = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
    Me.DsRiposiPubblica1 = New ATCBussm1.DsRiposiPubblica
    CType(Me.DsRiposiPubblica1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=False;initial catalog=ATCBussm"
    '
    'daRiposiPubblica
    '
    Me.daRiposiPubblica.SelectCommand = Me.SqlCommand6
    Me.daRiposiPubblica.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RiposiMatricolaAnno", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TTMATR", "TTMATR"), New System.Data.Common.DataColumnMapping("TTAAGG", "TTAAGG"), New System.Data.Common.DataColumnMapping("Pubblica", "Pubblica"), New System.Data.Common.DataColumnMapping("Cognome", "Cognome"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("NomePulsante", "NomePulsante")})})
    '
    'SqlCommand6
    '
    Me.SqlCommand6.CommandText = "SELECT R1.TTMATR, R1.TTAAGG, ISNULL(dbo.RiposiPubblicati.Pubblica, 0) AS Pubblica" & _
    ", R1.Cognome, R1.Nome, CASE WHEN ISNULL(dbo.RiposiPubblicati.Pubblica, 0) = 0 TH" & _
    "EN 'Pubblica' ELSE 'Ritira' END AS NomePulsante FROM dbo.RiposiMatricolaAnno R1 " & _
    "LEFT OUTER JOIN dbo.RiposiPubblicati ON R1.TTMATR = dbo.RiposiPubblicati.Matrico" & _
    "la AND R1.TTAAGG = dbo.RiposiPubblicati.Anno WHERE (R1.TTAAGG = @Anno) ORDER BY " & _
    "R1.Cognome, R1.Nome"
    Me.SqlCommand6.Connection = Me.con
    Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.VarChar, 50, "TTAAGG"))
    '
    'DsRiposiPubblica1
    '
    Me.DsRiposiPubblica1.DataSetName = "DsRiposiPubblica"
    Me.DsRiposiPubblica1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRiposiPubblica1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents Label6 As System.Web.UI.WebControls.Label
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents daRiposiPubblica As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsRiposiPubblica1 As ATCBussm1.DsRiposiPubblica
  Protected WithEvents dgRiposiPubblica As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
  Protected WithEvents btnPubblicaTutti As System.Web.UI.WebControls.Button
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnRitiraTutti As System.Web.UI.WebControls.Button
  Protected WithEvents BtnAggiorna As System.Web.UI.WebControls.Button
  Protected WithEvents BtnNuoviRiposi As System.Web.UI.WebControls.Button

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
  Const TableRG As String = "RiposiMatricolaAnno"

  Const Modulo As String = "wf_pubblicariposi.aspx"
  Dim accertatoreid As String
  Dim accertatoreNome As String

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    'cvTipoUtente.Validate()
    'btnAddRichiesta.Enabled = cvTipoUtente.IsValid And dgGiustificativi.EditItemIndex = -1


    If Not IsPostBack Then
      txtAnno.Text = Now.Year.ToString()


      fnc.ScriviLog(oUtente.IDUser, Modulo, "Pagina iniziale", Session("IPAddress"))

      daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
      daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
      dgRiposiPubblica.DataBind()
      Page.DataBind()
      'Session.Add("CausaleIndex", Convert.ToInt32(ddlCausali.SelectedIndex))
    Else
      'daCausali.Fill(DsGiustificativi1, TableCG)
      'ddlCausali.DataBind()
      'ddlCausali.SelectedIndex = Session("CausaleIndex")
      'daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = oUtente.ID
      'daGiustificativi.Fill(DsGiustificativi1, TableRG)
      'dgGiustificativi.DataBind()
      'Page.DataBind()
    End If


    'daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    'daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)

  End Sub

  'Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).NewRow
  '  Dim dt As DateTime

  '  Dim drcausali As SqlClient.SqlDataReader

  '  dt = Now.Date
  '  dr.Item("ID") = Guid.NewGuid
  '  dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
  '  dr.Item("Accertatori_GiustificativoCausaleId") = New Guid(ddlCausali.Items(ddlCausali.SelectedIndex).Value)
  '  dr.Item("DataDa") = Now.Date
  '  dr.Item("DataA") = Now.Date
  '  dr.Item("DataRichiesta") = Now
  '  dr.Item("CreatedOn") = Now
  '  dr.Item("CreatedBy") = oUtente.ID
  '  dr.Item("ModifiedOn") = Now
  '  dr.Item("ModifiedBy") = oUtente.ID

  '  dr.Item("OraDa") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
  '  dr.Item("OraA") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
  '  con.Open()
  '  Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG] " & _
  '                 " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & ddlCausali.Items(ddlCausali.SelectedIndex).Value & "'", con)

  '  drcausali = cmdcausali.ExecuteReader()
  '  If drcausali.HasRows Then
  '    drcausali.Read()
  '    dr.Item("Frazionato") = drcausali(3)
  '    dr.Item("DefaultApprovato") = drcausali(4)
  '    dr.Item("PreavvisoGG") = drcausali(5)
  '    dr.Item("NrMaxGG") = drcausali(6)
  '  End If
  '  con.Close()
  '  DsGiustificativi1.Tables(TableRG).Rows.InsertAt(dr, 0)
  '  dgGiustificativi.EditItemIndex = 0

  '  'Page.DataBind()
  '  dgGiustificativi.DataBind()
  '  btnAddRichiesta.Enabled = False
  '  ddlCausali.Enabled = False

  '  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Click nuova richiesta giustificativo", Session("IPAddress"))
  'End Sub


  Public Sub cvMinData_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    'Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(DirectCast(DirectCast(source, CustomValidator).Parent.Parent, System.Web.UI.WebControls.DataGridItem).ItemIndex))
    'DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(DirectCast(source, CustomValidator).Parent))
    ' args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDataDa"), Calendar).SelectedDate >= Now.Date



    args.IsValid = True

  End Sub
  'Private Sub dgGiustificativi_UpdateCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)

  '  If Me.IsValid Then

  '    Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
  '    If dr Is Nothing Then
  '      dr = DsGiustificativi1.Tables(TableRG).NewRow
  '      dr.Item("ID") = Guid.NewGuid
  '      dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
  '      dr.Item("Accertatori_GiustificativoCausaleId") = New Guid(ddlCausali.Items(ddlCausali.SelectedIndex).Value)
  '      dr.Item("DataRichiesta") = Now
  '      dr.Item("CreatedOn") = Now
  '      dr.Item("ModifiedOn") = Now
  '      dr.Item("CreatedBy") = oUtente.ID
  '      dr.Item("ModifiedBy") = oUtente.ID
  '      con.Open()
  '      Dim cmdcausali As New SqlClient.SqlCommand("SELECT  [ID],[Nome],[Codice],[Frazionato],[DefaultApprovato],[PreavvisoGG],[NrMaxGG] " & _
  '                     " FROM [dbo].[Accertatori_GiustificativoCausale] where ID = '" & ddlCausali.Items(ddlCausali.SelectedIndex).Value & "'", con)
  '      Dim drcausali As SqlClient.SqlDataReader

  '      drcausali = cmdcausali.ExecuteReader()
  '      If drcausali.HasRows Then
  '        drcausali.Read()
  '        dr.Item("Frazionato") = drcausali(3)
  '        dr.Item("DefaultApprovato") = drcausali(4)
  '        dr.Item("PreavvisoGG") = drcausali(5)
  '        dr.Item("NrMaxGG") = drcausali(6)
  '      End If
  '      con.Close()
  '      DsGiustificativi1.Tables(TableRG).Rows.Add(dr)
  '    End If
  '    Dim dtDa As DateTime
  '    dtDa = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
  '    Dim dtA As DateTime
  '    dtA = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
  '    dr.Item("DataDa") = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
  '    dr.Item("DataA") = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
  '    If (dr.Item("Frazionato") = True) Then
  '      dr.Item("OraDa") = New DateTime(Year(dtDa), Month(dtDa), Day(dtDa), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlOraDa"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlMinutiDa"), DropDownList).SelectedValue), 0)
  '      dr.Item("OraA") = New DateTime(Year(dtA), Month(dtA), Day(dtA), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlOraA"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlMinutiA"), DropDownList).SelectedValue), 0)
  '    Else

  '      dr.Item("OraDa") = DirectCast(e.Item.FindControl("caDataDa"), Calendar).SelectedDate
  '      dr.Item("OraA") = DirectCast(e.Item.FindControl("caDataA"), Calendar).SelectedDate
  '    End If
  '    If (dr.Item("DefaultApprovato")) Then
  '      dr.Item("StatoGiustificativo") = 1
  '      dr.Item("DataApprovazione") = Now
  '      dr.Item("ApprovatoDa") = oUtente.ID

  '    End If
  '    If (dr.Item("OraDa") > dr.Item("OraA")) Then
  '      DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).ErrorMessage = "Verificare di aver inserito le date corrette"
  '      DirectCast(e.Item.FindControl("cvMinData"), CustomValidator).IsValid = False
  '      fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Bloccato inserimento giustificativo date errate.", Session("IPAddress"))

  '    Else

  '      daGiustificativi.Update(DsGiustificativi1, TableRG)
  '      DsGiustificativi1.Tables(TableRG).Clear()
  '      dgGiustificativi_CancelCommand(source, e)
  '      fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Nome & "-" & "Confermato inserimento/modifica giustificativo ", Session("IPAddress"))
  '    End If
  '  End If



  'End Sub

  'Private Sub dgGiustificativi_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
  '  If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di giusitficativo?');")

  'End Sub

  'Private Sub dgGiustificativi_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  If cvOnModifica.IsValid Then
  '    Dim dr As DataRow = DsGiustificativi1.Tables(TableRG).Rows.Find(dgGiustificativi.DataKeys(e.Item.ItemIndex))
  '    If Not dr Is Nothing Then
  '      dr.Delete()
  '      daGiustificativi.Update(DsGiustificativi1, TableRG)
  '      fnc.ScriviLog(oUtente.IDUser, Modulo, "Eliminato giustificativo", Session("IPAddress"))
  '    End If
  '    dgGiustificativi_CancelCommand(source, e)
  '  End If
  'End Sub

  'Private Sub dgGiustificativi_CancelCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  dgGiustificativi.EditItemIndex = -1
  '  daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
  '  daGiustificativi.Fill(DsGiustificativi1, TableRG)
  '  dgGiustificativi.DataBind()
  '  btnAddRichiesta.Enabled = True
  '  ddlCausali.Enabled = True
  '  fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Annullata modifica", Session("IPAddress"))

  'End Sub


  'Private Sub dgGiustificativi_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)


  '  cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""



  '  If cvOnModifica.IsValid Then
  '    dgGiustificativi.EditItemIndex = e.Item.ItemIndex
  '    daGiustificativi.SelectCommand.Parameters("@AccertatoreId").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
  '    daGiustificativi.Fill(DsGiustificativi1, TableRG)
  '    dgGiustificativi.DataBind()
  '    btnAddRichiesta.Enabled = False
  '    ddlCausali.Enabled = False
  '    fnc.ScriviLog(oUtente.IDUser, Modulo, oUtente.Cognome & "-Inizio modifica giustificativo", Session("IPAddress"))
  '  End If
  'End Sub




  Private Function RitornaRiposi(ByVal dal As Date, ByVal al As Date) As String
    'Dim strriposi As String = ""
    'Do While dal <= al
    '  Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    '  riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(dal, "dd/MM/yyyy")
    '  con.Open()
    '  If (riposi.ExecuteScalar() > 0) Then
    '    strriposi = strriposi & "<br />" & "data: " & Format(dal, "dd/MM/yyyy")

    '  End If
    '  con.Close()
    '  dal = dal.AddDays(1)
    'Loop
    'RitornaRiposi = strriposi

  End Function


  Private Sub dgRiposiPubblica_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgRiposiPubblica.EditCommand
    dgRiposiPubblica.EditItemIndex = -1

    Dim matricola As String
    Dim anno As String
    Dim pubblica As Boolean
    matricola = e.Item.Cells(3).Text

    anno = e.Item.Cells(2).Text
    pubblica = Convert.ToBoolean(e.Item.Cells(6).Text)
    If (pubblica) Then
      Dim DeleteRiposi As New SqlClient.SqlCommand("DELETE FROM RiposiPubblicati WHERE  (Matricola = '" & matricola & "') AND (Anno = '" & anno & "') ", con)
      con.Open()
      DeleteRiposi.ExecuteNonQuery()
      con.Close()

    Else
      Dim InsertRiposi As New SqlClient.SqlCommand("INSERT INTO RiposiPubblicati(Matricola, Anno, Pubblica) VALUES('" & matricola & "','" & anno & "' ,1 )   ", con)
      con.Open()
      InsertRiposi.ExecuteNonQuery()
      con.Close()
    End If

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()


  End Sub

  Private Sub btnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerca.Click

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()

  End Sub

  Private Sub btnPubblicaTutti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPubblicaTutti.Click
    Dim InsertRiposi As New SqlClient.SqlCommand("INSERT INTO  dbo.RiposiPubblicati ( Matricola, Anno, Pubblica) SELECT  R1.TTMATR, R1.TTAAGG,1 AS Pubblica " & _
    " FROM  dbo.RiposiMatricolaAnno R1 LEFT OUTER JOIN dbo.RiposiPubblicati ON R1.TTMATR = dbo.RiposiPubblicati.Matricola AND R1.TTAAGG = dbo.RiposiPubblicati.Anno " & _
    "WHERE  (R1.TTAAGG = '" & txtAnno.Text & "') and ISNULL(dbo.RiposiPubblicati.Pubblica, 0)=0 ", con)
    con.Open()
    InsertRiposi.ExecuteNonQuery()
    con.Close()

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()

  
  End Sub

  Private Sub btnRitiraTutti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRitiraTutti.Click
    Dim DeleteRiposi As New SqlClient.SqlCommand("DELETE FROM RiposiPubblicati WHERE (Anno = '" & txtAnno.Text & "') ", con)
    con.Open()
    DeleteRiposi.ExecuteNonQuery()
    con.Close()

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()

  End Sub

  Private Sub BtnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAggiorna.Click
    Dim DeleteRiposi As New SqlClient.SqlCommand("DELETE FROM RiposiTeoricoBck WHERE (TTAAGG = '" & txtAnno.Text & "') ", con)
    con.Open()
    DeleteRiposi.ExecuteNonQuery()
    con.Close()
    Dim InsertRiposi As New SqlClient.SqlCommand("INSERT INTO  dbo.RiposiTeoricoBck ( TTMATR, TTGGGG, TTMMGG, TTAAGG, TTCTUR, DataRiposo) SELECT  R1.TTMATR, R1.TTGGGG, R1.TTMMGG, R1.TTAAGG, R1.TTCTUR, R1.DataRiposo " & _
    " FROM  dbo.RiposiTeorico R1 WHERE  (R1.TTAAGG = '" & txtAnno.Text & "') ", con)
    con.Open()
    InsertRiposi.ExecuteNonQuery()
    con.Close()

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()
  End Sub

  Private Sub BtnNuoviRiposi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuoviRiposi.Click
    Dim InsertRiposi As New SqlClient.SqlCommand("INSERT INTO  dbo.RiposiTeoricoBck ( TTMATR, TTGGGG, TTMMGG, TTAAGG, TTCTUR, DataRiposo) SELECT  R1.TTMATR, R1.TTGGGG, R1.TTMMGG, R1.TTAAGG, R1.TTCTUR, R1.DataRiposo " & _
    " FROM  dbo.RiposiTeorico  R1 left outer join RiposiTeoricoBck RB  on R1.TTAAGG =RB.TTAAGG and R1.TTMATR=RB.TTMATR  WHERE  (R1.TTAAGG = '" & txtAnno.Text & "' and RB.TTAAGG is null) ", con)
    con.Open()
    InsertRiposi.ExecuteNonQuery()
    con.Close()

    daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
    daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
    dgRiposiPubblica.DataBind()
    Page.DataBind()
  End Sub

  Private Sub dgRiposiPubblica_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgRiposiPubblica.ItemCommand

    Dim matricola As String
    Dim anno As String

    matricola = e.Item.Cells(3).Text
    anno = e.Item.Cells(2).Text
    If e.CommandName = "RicaricaAS400" Then

      Dim DeleteRiposi As New SqlClient.SqlCommand("DELETE FROM RiposiTeoricoBck WHERE (TTAAGG = '" & anno & "' and TTMATR ='" & matricola & "') ", con)
      con.Open()
      DeleteRiposi.ExecuteNonQuery()
      con.Close()
      Dim InsertRiposi As New SqlClient.SqlCommand("INSERT INTO  dbo.RiposiTeoricoBck ( TTMATR, TTGGGG, TTMMGG, TTAAGG, TTCTUR, DataRiposo) SELECT  R1.TTMATR, R1.TTGGGG, R1.TTMMGG, R1.TTAAGG, R1.TTCTUR, R1.DataRiposo " & _
      " FROM  dbo.RiposiTeorico R1 WHERE  (R1.TTAAGG = '" & anno & "' and R1.TTMATR = '" & matricola & "') ", con)
      con.Open()
      InsertRiposi.ExecuteNonQuery()
      con.Close()

      daRiposiPubblica.SelectCommand.Parameters("@Anno").Value = txtAnno.Text
      daRiposiPubblica.Fill(DsRiposiPubblica1, TableRG)
      dgRiposiPubblica.DataBind()
      Page.DataBind()
    End If


  End Sub
End Class
