Public Class wf_gestionecausaligiustificativi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCausaliGiustificativi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsGiustificativi1 = New ATCBussm1.dsGiustificativi
    CType(Me.DsGiustificativi1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCausaliGiustificativi
    '
    Me.daCausaliGiustificativi.DeleteCommand = Me.SqlDeleteCommand2
    Me.daCausaliGiustificativi.InsertCommand = Me.SqlInsertCommand3
    Me.daCausaliGiustificativi.SelectCommand = Me.SqlSelectCommand3
    Me.daCausaliGiustificativi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_GiustificativoCausale", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Codice", "Codice"), New System.Data.Common.DataColumnMapping("ValiditaDa", "ValiditaDa"), New System.Data.Common.DataColumnMapping("ValiditaA", "ValiditaA"), New System.Data.Common.DataColumnMapping("Frazionato", "Frazionato"), New System.Data.Common.DataColumnMapping("DefaultApprovato", "DefaultApprovato"), New System.Data.Common.DataColumnMapping("PreavvisoGG", "PreavvisoGG"), New System.Data.Common.DataColumnMapping("NrMaxGG", "NrMaxGG"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.daCausaliGiustificativi.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.Accertatori_GiustificativoCausale WHERE (ID = @ID)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.Accertatori_GiustificativoCausale (ID, Nome, Codice, ValiditaDa, " & _
    "ValiditaA, Frazionato, DefaultApprovato, SenzaPreavviso, PreavvisoGG, NrMaxGG, C" & _
    "reatedBy, ModifiedBy) VALUES (@ID, @Nome, @Codice, @ValiditaDa, @ValiditaA, @Fra" & _
    "zionato, @DefaultApprovato, @SenzaPreavviso, @PreavvisoGG, @NrMaxGG, @CreatedBy," & _
    " @ModifiedBy)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.NVarChar, 10, "Codice"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValiditaDa", System.Data.SqlDbType.DateTime, 8, "ValiditaDa"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValiditaA", System.Data.SqlDbType.DateTime, 8, "ValiditaA"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frazionato", System.Data.SqlDbType.Bit, 1, "Frazionato"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DefaultApprovato", System.Data.SqlDbType.Bit, 1, "DefaultApprovato"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SenzaPreavviso", System.Data.SqlDbType.Bit, 1, "SenzaPreavviso"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreavvisoGG", System.Data.SqlDbType.Int, 4, "PreavvisoGG"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrMaxGG", System.Data.SqlDbType.Int, 4, "NrMaxGG"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID, Nome, Codice, ValiditaDa, ValiditaA, Frazionato, DefaultApprovato, Sen" & _
    "zaPreavviso, PreavvisoGG, NrMaxGG, CreatedOn, ModifiedOn, CreatedBy, ModifiedBy " & _
    "FROM dbo.Accertatori_GiustificativoCausale ORDER BY Nome"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.Accertatori_GiustificativoCausale SET ID = @ID, Nome = @Nome, Codice =" & _
    " @Codice, ValiditaDa = @ValiditaDa, ValiditaA = @ValiditaA, Frazionato = @Frazio" & _
    "nato, DefaultApprovato = @DefaultApprovato, SenzaPreavviso = @SenzaPreavviso, Pr" & _
    "eavvisoGG = @PreavvisoGG, NrMaxGG = @NrMaxGG, ModifiedOn = @ModifiedOn, Modified" & _
    "By = @ModifiedBy WHERE (ID = @ID)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nome", System.Data.SqlDbType.NVarChar, 250, "Nome"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codice", System.Data.SqlDbType.NVarChar, 10, "Codice"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValiditaDa", System.Data.SqlDbType.DateTime, 8, "ValiditaDa"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValiditaA", System.Data.SqlDbType.DateTime, 8, "ValiditaA"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frazionato", System.Data.SqlDbType.Bit, 1, "Frazionato"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DefaultApprovato", System.Data.SqlDbType.Bit, 1, "DefaultApprovato"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SenzaPreavviso", System.Data.SqlDbType.Bit, 1, "SenzaPreavviso"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PreavvisoGG", System.Data.SqlDbType.Int, 4, "PreavvisoGG"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NrMaxGG", System.Data.SqlDbType.Int, 4, "NrMaxGG"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'DsGiustificativi1
    '
    Me.DsGiustificativi1.DataSetName = "dsGiustificativi"
    Me.DsGiustificativi1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsGiustificativi1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents dgCausaliGiustificativi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents daCausaliGiustificativi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsGiustificativi1 As ATCBussm1.dsGiustificativi
  Protected WithEvents btnAddCausale As System.Web.UI.WebControls.Button

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
  Const tabella As String = "Accertatori_GiustificativoCausale"
  Const modulo As String = "wf_gestionecausaligiustificativi.aspx"

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    daCausaliGiustificativi.Fill(DsGiustificativi1, tabella)

    If Not IsPostBack Then
      daCausaliGiustificativi.Fill(DsGiustificativi1, tabella)
      'dgCausaliGiustificativi.DataBind()
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-Pagina iniziale", Session("IPAddress"))

    End If
  End Sub

  Public Sub cvDataDal_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)

    'If (DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date) Then
    '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate <= Now.Date.AddDays(60)
    '  DirectCast(source, CustomValidator).ErrorMessage = "Non è possibile chiedere delle ferie oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")

    'Else
    '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= Now.Date
    '  DirectCast(source, CustomValidator).ErrorMessage = "E' possibile chiedere delle ferie solo a partire da " & Format(Now, "Y")

    'End If

  End Sub

  'Private Sub dgFerie_EditCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
  '  'If cvOnModifica.IsValid Then
  '  fnc.ScriviLog(oUtente.IDUser, "wf_gestioneperiodipreno.aspx", "Inizio modifica periodo prenotazione", Session("IPAddress"))
  '  Response.Redirect("wf_gestioneintervallipreno.aspx?ID=" & Convert.ToString(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex)))

  '  ' End If
  'End Sub

  'Private Sub dgCausaliGiustificativi_UpdateCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
  '  'Me.Validate()
  '  'If Me.IsValid Then
  '  Dim dr As DataRow = DsGiustificativi1.Tables(tabella).Rows.Find(dgCausaliGiustificativi.DataKeys(e.Item.ItemIndex))
  '  'Response.Write(dgPeriodoPrenotazione.DataKeys(e.Item.ItemIndex))

  '  If dr Is Nothing Then
  '    dr = DsGiustificativi1.Tables(tabella).NewRow
  '    dr.Item("ID") = Guid.NewGuid()
  '    dr.Item("CreatedOn") = Now
  '    DsGiustificativi1.Tables(tabella).Rows.Add(dr)
  '  End If
  '  dr.Item("ModifiedOn") = Now
  '  dr.Item("CreatedBy") = oUtente.IDUser
  '  dr.Item("ModifiedBy") = oUtente.IDUser

  '  dr.Item("PreavvisoGG") = Convert.ToInt32(DirectCast(e.Item.FindControl("PreavvisoGG"), TextBox).Text)
  '  dr.Item("NrMaxGG ") = Convert.ToInt32(DirectCast(e.Item.FindControl("NrMaxGG"), TextBox).Text)

  '  dr.Item("Nome") = DirectCast(e.Item.FindControl("Nome"), TextBox).Text
  '  dr.Item("Codice") = DirectCast(e.Item.FindControl("Codice"), TextBox).Text
  '  dr.Item("ValiditaDa") = DirectCast(e.Item.FindControl("caValiditaDa"), Calendar).SelectedDate
  '  dr.Item("ValiditaA") = DirectCast(e.Item.FindControl("caValiditaA"), Calendar).SelectedDate

  '  dr.Item("Frazionato") = IIf(DirectCast(e.Item.FindControl("Frazionato"), CheckBox).Checked = True, 1, 0)
  '  dr.Item("DefaultApprovato") = IIf(DirectCast(e.Item.FindControl("DefaultApprovato"), CheckBox).Checked = True, 1, 0)

  '  daCausaliGiustificativi.Update(DsGiustificativi1, tabella)
  '  DsGiustificativi1.Tables(tabella).Clear()
  '  daCausaliGiustificativi.Fill(DsGiustificativi1, tabella)

  '  'dgPeriodoPrenotazione_CancelCommand(source, e)
  '  dgCausaliGiustificativi.EditItemIndex = -1
  '  Page.DataBind()
  '  btnAddPeriodo.Enabled = True
  '  fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-Confermato inserimento/modifica della causale giustificativo", Session("IPAddress"))
  '  ' End If

  'End Sub
 

  Private Sub dgCausaliGiustificativi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCausaliGiustificativi.CancelCommand

    dgCausaliGiustificativi.EditItemIndex = -1
    Page.DataBind()
    btnAddCausale.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-Annullata modifica sulle causali giustificativi", Session("IPAddress"))

  End Sub

  Private Sub dgCausaliGiustificativi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCausaliGiustificativi.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa causale?');")

  End Sub

  Private Sub dgCausaliGiustificativi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCausaliGiustificativi.EditCommand

    dgCausaliGiustificativi.EditItemIndex = e.Item.ItemIndex
    Page.DataBind()
    btnAddCausale.Enabled = False

    fnc.ScriviLog(oUtente.IDUser, modulo, "Inizio modifica causale giustificativo", Session("IPAddress"))

  End Sub

  Private Sub dgCausaliGiustificativi_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCausaliGiustificativi.UpdateCommand
    'Me.Validate()
    'If Me.IsValid Then

    Dim dr As DataRow = DsGiustificativi1.Tables(tabella).Rows.Find(dgCausaliGiustificativi.DataKeys(e.Item.ItemIndex))


    fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-dentro update", Session("IPAddress"))

    'UPDATE dbo.Accertatori_GiustificativoCausale SET ID = @ID, Nome = @Nome, Codice = @Codice, 
    '   ValiditaDa = @ValiditaDa, ValiditaA = @ValiditaA, Frazionato = @Frazionato, 
    '   DefaultApprovato = @DefaultApprovato, PreavvisoGG = @PreavvisoGG, NrMaxGG = @NrMaxGG, 
    '   ModifiedOn = @ModifiedOn, ModifiedBy = @ModifiedBy WHERE (ID = @ID)


    If dr Is Nothing Then
      dr = DsGiustificativi1.Tables(tabella).NewRow
      dr.Item("ID") = Guid.NewGuid()
      dr.Item("CreatedBy") = oUtente.IDUser
      ' dr.Item("CreatedOn") = Now
      DsGiustificativi1.Tables(tabella).Rows.Add(dr)
    End If
    dr.Item("CreatedOn") = Now
    dr.Item("ModifiedOn") = Now
    'dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser

    Dim preavvGG As Int32
    If (DirectCast(e.Item.FindControl("PreavvisoGG"), TextBox).Text.Trim() = "") Then
      preavvGG = 0
    Else
      preavvGG = Convert.ToInt32(DirectCast(e.Item.FindControl("PreavvisoGG"), TextBox).Text)
    End If


    dr.Item("PreavvisoGG") = preavvGG
    dr.Item("NrMaxGG") = Convert.ToInt32(IIf(DirectCast(e.Item.FindControl("NrMaxGG"), TextBox).Text = "", 99, DirectCast(e.Item.FindControl("NrMaxGG"), TextBox).Text))

    dr.Item("Nome") = DirectCast(e.Item.FindControl("Nome"), TextBox).Text
    dr.Item("Codice") = DirectCast(e.Item.FindControl("Codice"), TextBox).Text
    dr.Item("ValiditaDa") = DirectCast(e.Item.FindControl("caValiditaDa"), Calendar).SelectedDate
    dr.Item("ValiditaA") = DirectCast(e.Item.FindControl("caValiditaA"), Calendar).SelectedDate
    dr.Item("SenzaPreavviso") = IIf(DirectCast(e.Item.FindControl("SenzaPreavviso"), CheckBox).Checked = True, 1, 0)
    dr.Item("Frazionato") = IIf(DirectCast(e.Item.FindControl("Frazionato"), CheckBox).Checked = True, 1, 0)
    dr.Item("DefaultApprovato") = IIf(DirectCast(e.Item.FindControl("DefaultApprovato"), CheckBox).Checked = True, 1, 0)

    daCausaliGiustificativi.Update(DsGiustificativi1, tabella)
    DsGiustificativi1.Tables(tabella).Clear()
    daCausaliGiustificativi.Fill(DsGiustificativi1, tabella)

    ' dgCausaliGiustificativi_CancelCommand(source, e)
    dgCausaliGiustificativi.EditItemIndex = -1
    Page.DataBind()
    btnAddCausale.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-Confermato inserimento/modifica della causale giustificativo", Session("IPAddress"))
    ' End If

  End Sub

  Private Sub dgCausaliGiustificativi_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCausaliGiustificativi.DeleteCommand
    Dim dr As DataRow = DsGiustificativi1.Tables(tabella).Rows.Find(dgCausaliGiustificativi.DataKeys(e.Item.ItemIndex))
    If Not dr Is Nothing Then
      dr.Delete()
      daCausaliGiustificativi.Update(DsGiustificativi1, tabella)
      fnc.ScriviLog(oUtente.IDUser, modulo, "Eliminata la causale giustificativo", Session("IPAddress"))
    End If
    dgCausaliGiustificativi_CancelCommand(source, e)
  End Sub


  Private Sub btnAddCausale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCausale.Click

    Dim dr As DataRow = DsGiustificativi1.Tables(tabella).NewRow
    Dim MeseMensileAperto As String
    dr.Item("ID") = Guid.NewGuid()
    'dr.Item("CreatedOn") = Now
    'dr.Item("ModifiedOn") = Now
    dr.Item("CreatedBy") = oUtente.IDUser
    dr.Item("ModifiedBy") = oUtente.IDUser
    dr.Item("Nome") = ""
    dr.Item("Codice") = ""
    dr.Item("PreavvisoGG") = 0
    dr.Item("NrMaxGG") = 1
    dr.Item("ValiditaDa") = Now
    dr.Item("ValiditaA") = Now.AddDays(7)
    dr.Item("SenzaPreavviso") = 0
    dr.Item("Frazionato") = 0
    dr.Item("DefaultApprovato") = 0

    DsGiustificativi1.Tables(tabella).Rows.InsertAt(dr, 0)

    dgCausaliGiustificativi.EditItemIndex = 0
    Page.DataBind()
    btnAddCausale.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, modulo, oUtente.Cognome & "-Click nuova causale giustificativo", Session("IPAddress"))

  End Sub

  Private Sub daCausaliGiustificativi_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles daCausaliGiustificativi.RowUpdated

  End Sub
End Class
