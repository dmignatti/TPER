Public Class wf_congedi_Cntrl
  'DM2020.02 - MODIFICA INTEGRATIVO 
  Inherits System.Web.UI.Page
  Const CMaxPrenotabile = 3

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCongedi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsRichieste1 = New ATCBussm1.dsRichieste
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.daMostraFerieCongedi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.DsMostraFerieCongedi1 = New ATCBussm1.DsMostraFerieCongedi
    CType(Me.DsRichieste1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsMostraFerieCongedi1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCongedi
    '
    Me.daCongedi.DeleteCommand = Me.SqlCommand1
    Me.daCongedi.InsertCommand = Me.SqlInsertCommand1
    Me.daCongedi.SelectCommand = Me.SqlSelectCommand1
    Me.daCongedi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongedi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("DalleOre", "DalleOre"), New System.Data.Common.DataColumnMapping("AlleOre", "AlleOre"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta")})})
    Me.daCongedi.UpdateCommand = Me.SqlCommand2
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.RichiesteCongedi WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCongedi (IdRichiesta, IdAccertatore, DalGiorno, AlGiorno" & _
    ") VALUES (@IdRichiesta, @IdAccertatore, @DalGiorno, @AlGiorno)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalGiorno", System.Data.SqlDbType.DateTime, 8, "DalGiorno"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlGiorno", System.Data.SqlDbType.DateTime, 8, "AlGiorno"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdRichiesta, IdAccertatore, DalGiorno, AlGiorno, dbo.GetOrderListCongedi(D" & _
    "alGiorno, IdAccertatore) AS Ordine, CASE WHEN StatoApprovazione IS NULL THEN 'Da" & _
    " approvare' WHEN StatoApprovazione = 0 THEN 'Respinta' WHEN StatoApprovazione = " & _
    "1 THEN 'Approvata' END AS StatoRichiesta, ts FROM dbo.RichiesteCongedi WHERE (Id" & _
    "Accertatore = @IdAccertatore) AND (DalGiorno > GETDATE()) ORDER BY DalGiorno DES" & _
    "C"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "UPDATE dbo.RichiesteCongedi SET DalGiorno = @DalGiorno, AlGiorno = @AlGiorno, ts " & _
    "= DATEADD(second, 2, GETDATE()) WHERE (IdRichiesta = @IdRichiesta)"
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
    'daMostraFerieCongedi
    '
    Me.daMostraFerieCongedi.SelectCommand = Me.SqlSelectCommand2
    Me.daMostraFerieCongedi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_PrenotazioniFerieCongedi_TBL", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GIORNO", "GIORNO"), New System.Data.Common.DataColumnMapping("ListaUser", "ListaUser"), New System.Data.Common.DataColumnMapping("num", "num"), New System.Data.Common.DataColumnMapping("PosizioneSuccessiva", "PosizioneSuccessiva"), New System.Data.Common.DataColumnMapping("PosUser", "PosUser")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("CHIAVE", "CHIAVE"), New System.Data.Common.DataColumnMapping("GIORNO", "GIORNO"), New System.Data.Common.DataColumnMapping("NUM", "NUM"), New System.Data.Common.DataColumnMapping("IDACCERTATORE", "IDACCERTATORE"), New System.Data.Common.DataColumnMapping("IDUSER", "IDUSER"), New System.Data.Common.DataColumnMapping("LISTAUSER", "LISTAUSER"), New System.Data.Common.DataColumnMapping("DATAEORA", "DATAEORA"), New System.Data.Common.DataColumnMapping("PosizioneSuccessiva", "PosizioneSuccessiva"), New System.Data.Common.DataColumnMapping("PosUser", "PosUser")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "[SP_PrenotazioniFerieCongedi_TBL]"
    Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
    Me.SqlSelectCommand2.Connection = Me.con
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataDA", System.Data.SqlDbType.NVarChar, 10))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataA", System.Data.SqlDbType.NVarChar, 10))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoRic", System.Data.SqlDbType.VarChar, 1))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.VarChar, 30))
    Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FerieCongedi", System.Data.SqlDbType.Char))
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;integrated security=SSPI;data source=I" & _
    "NSVSQL03;persist security info=False;initial catalog=ATCBussm"
    '
    'DsMostraFerieCongedi1
    '
    Me.DsMostraFerieCongedi1.DataSetName = "DsMostraFerieCongedi"
    Me.DsMostraFerieCongedi1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRichieste1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsMostraFerieCongedi1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCongedi As System.Data.SqlClient.SqlDataAdapter
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
  Protected WithEvents lblDAL As System.Web.UI.WebControls.Label
  Protected WithEvents lblAL As System.Web.UI.WebControls.Label
  Protected WithEvents DgMostraFerieCongedi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents daMostraFerieCongedi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsMostraFerieCongedi1 As ATCBussm1.DsMostraFerieCongedi
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand

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

    daCongedi.SelectCommand.Parameters("@IdAccertatore").Value = oUtente.ID
    daCongedi.Fill(DsRichieste1)

    If Not IsPostBack Then

      fnc.ScriviLog(oUtente.IDUser, "wf_congedi_Cntrl.aspx", "Pagina iniziale", Session("IPAddress"))
      Page.DataBind()
    End If
  End Sub

  Private Sub btnAddCongedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCongedo.Click
    pAggiungiCongedo()

    fnc.ScriviLog(oUtente.IDUser, "wf_congedi_Cntrl.aspx", "Click nuova richiesta congedo", Session("IPAddress"))
  End Sub

  Private Sub dgCongedi_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.CancelCommand
    dgCongedi.EditItemIndex = -1

    DgMostraFerieCongedi.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     
    lblDAL.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     
    lblAL.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     


    Page.DataBind()
    dgCongedi.Visible = DsRichieste1.Tables("RichiesteCongedi").Rows.Count > 0
    lblCongedi.Visible = DsRichieste1.Tables("RichiesteCongedi").Rows.Count <= 0
    btnAddCongedo.Enabled = True

    fnc.ScriviLog(oUtente.IDUser, "wf_congedi.aspx", "Annullata modifica", Session("IPAddress"))
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
      richiesteG = RichiestePresenti(dr.Item("DalGiorno"), dr.Item("AlGiorno"))
      If Not (richiesteG = "") Then

        DirectCast(e.Item.FindControl("cvDal"), CustomValidator).ErrorMessage = "Sono gi‡ presenti dei giustificativi: <br/>" & richiesteG
        DirectCast(e.Item.FindControl("cvDal"), CustomValidator).IsValid = False

      Else
        If SonoARiposo(oUtente.IDUser, dr.Item("DalGiorno")) = True Then
          'DM2020.02 - MODIFICO per controllare che il giorno scelto IO STESSO non sia gi‡ a RIPOSO. Nel caso, mando messaggio e non faccio nulla
          DirectCast(e.Item.FindControl("cvDal"), CustomValidator).ErrorMessage = "Quel giorno non Ë selezionabile poichË di riposo"
          DirectCast(e.Item.FindControl("cvDal"), CustomValidator).IsValid = False

        Else
          daCongedi.Update(DsRichieste1, "RichiesteCongedi")
          DsRichieste1.Tables("RichiesteCongedi").Clear()
          daCongedi.Fill(DsRichieste1, "RichiesteCongedi")
          'FT - Toglie l'editing mode
          dgCongedi_CancelCommand(source, e)

          fnc.ScriviLog(oUtente.IDUser, "wf_congedi.aspx", "Confermato inserimento/modifica congedo", Session("IPAddress"))
        End If
      End If
    End If
  End Sub
  Private Function RichiestePresenti(ByVal dal As Date, ByVal al As Date) As String
    Dim richiesta As String = ""

    Dim cmdgiustificativi As New SqlClient.SqlCommand("SELECT G.AccertatoreId, G.OraDa, G.OraA, G.DataRichiesta, C.Nome " & _
                        " FROM Accertatori_GiustificativoRichiesta AS G INNER JOIN " & _
                        " Accertatori_GiustificativoCausale AS C ON G.Accertatori_GiustificativoCausaleId = C.ID " & _
                        " WHERE ((G.StatoGiustificativo IS NULL) OR (G.StatoGiustificativo = 0) OR " & _
                        " (G.StatoGiustificativo = 1)) and  AccertatoreId  = " & oUtente.ID.ToString() & " " & _
                        " and not (convert(varchar(10), G.OraA, 102)<CONVERT(DATETIME, '" & Replace(Format(dal, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) or convert(varchar(10), G.OraA, 102)>CONVERT(DATETIME, '" & Replace(Format(al, "yyyy-MM-dd HH:mm:ss"), ".", ":") & "', 102) )", con)
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

  Public Sub cvDal_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
    If (DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate > pDate48H) Then
      args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caDalGiorno"), Calendar).SelectedDate <= Now.Date.AddDays(60)
      DirectCast(source, CustomValidator).ErrorMessage = "Non Ë possibile chiedere congedi oltre la data " & Format(Now.Date.AddDays(60), "dd/MM/yyyy")
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
    Dim result As Boolean = True

    Dim dal As Date = DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate
    Dim cmdPresenza As New SqlClient.SqlCommand("SELECT IsNUll(dbo.GetOrderListFerieCongedi('" & Format(dal, "yyyy-MM-dd") & "', " & oUtente.ID.ToString() & "),0)", con)
    con.Open()
    If (cmdPresenza.ExecuteNonQuery) <> -1 Then
      result = False
    End If
    con.Close()

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
      daCongedi.Update(DsRichieste1, "RichiesteCongedi")
      'FT - Toglie l'editing mode
      dgCongedi_CancelCommand(source, e)
      Dim fnc As New Funzioni
      fnc.ScriviLog(oUtente.IDUser, "wf_congedi.aspx", "Eliminato congedo", Session("IPAddress"))
    End If
  End Sub

  Private Sub pAggiungiCongedo()
    Dim dr As Data.DataRow = DsRichieste1.Tables("RichiesteCongedi").NewRow
    dr.Item("IdRichiesta") = Guid.NewGuid
    'FT - !!! - Gestire le festivit‡ e le domeniche

    dr.Item("DalGiorno") = pDate48H.AddDays(1)
    dr.Item("AlGiorno") = pDate48H.AddDays(1)
    'FT
    DsRichieste1.Tables("RichiesteCongedi").Rows.InsertAt(dr, 0)
    dgCongedi.EditItemIndex = 0

    DgMostraFerieCongedi.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     
    lblDAL.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     
    lblAL.Visible = (dgCongedi.EditItemIndex = 0) 'DM2020.02     

    Page.DataBind()
    btnAddCongedo.Enabled = False
  End Sub

  Private Sub dgCongedi_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.EditCommand
    cvOnModificaCongedo.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare"
    If cvOnModificaCongedo.IsValid Then
      dgCongedi.EditItemIndex = e.Item.ItemIndex

      DgMostraFerieCongedi.Visible = True 'DM2020.02     
      lblDAL.Visible = True 'DM2020.02     
      lblAL.Visible = True 'DM2020.02     

      Page.DataBind()
      btnAddCongedo.Enabled = False

      dgCongedi.ToolTip = e.Item.ItemIndex.ToString
      '--> AggiornaDataGrid(DirectCast(dgCongedi.Items(e.Item.ItemIndex).FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(dgCongedi.Items(e.Item.ItemIndex).FindControl("caAlGiorno"), Calendar).SelectedDate)

      fnc.ScriviLog(oUtente.IDUser, "wf_congedi.aspx", "Inizio modifica congedo", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCongedi_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongedi.ItemCreated
    Dim myDeleteButton As LinkButton = e.Item.FindControl("lnkDelete")
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
      Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
      ' Modifica del 2018/11/06 per problema dopo ore 17 in caso di festivit‡
      'sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = data
      sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = data.Date

      con.Open()
      If (data.DayOfWeek <> DayOfWeek.Sunday And sc.ExecuteScalar() <= 0) Then i += 1
      fnc.ScriviLog(oUtente.IDUser, "wf_congedi.aspx", "Controllo festivit‡: " & sc.CommandText & "  " & data.ToString() & " Risultato: " & (data.DayOfWeek <> DayOfWeek.Sunday And sc.ExecuteScalar() <= 0), Session("IPAddress"))
      con.Close()
    Loop
    'Dim riposi As New SqlClient.SqlCommand("Select Count(*) From Riposi WHERE (TTMATR = '" & oUtente.IDUser & "') AND (DataRiposo = @Data) ", con)
    'riposi.Parameters.Add("@Data", SqlDbType.VarChar, 50).Value = Format(data, "dd/MM/yyyy")
    Date48H = data
  End Function

  'Private Sub cvData_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  'Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurno Where (IdAccertatoreRichiedente = @IdUtente Or IdAccertatoreDestinatario = @IdUtente) And Data = @Data And IdRichiesta <> @IdRichiesta", con)
  '  Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurno Where (IdAccertatoreRichiedente = @IdUtente Or IdAccertatoreDestinatario = @IdUtente) And Data = @Data And (StatoRichiesta Is Null Or StatoRichiesta = 1)", con)
  '  sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
  '  sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate
  '  'sc.Parameters.Add("@IdRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurno.DataKeys.Item(dgCambiTurno.EditItemIndex)
  '  con.Open()
  '  args.IsValid = sc.ExecuteScalar() <= 0
  '  con.Close()
  'End Sub

  'Private Sub cvDataOk_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate >= pDate48H
  'End Sub

  'Private Sub cvDati_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  args.IsValid = DsRichieste1.Tables("Accertatori").Rows.Count > 0
  'End Sub

  Private Sub cvTipoUtente_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvTipoUtente.ServerValidate
    args.IsValid = oUtente.TipoUtente = 2
  End Sub

  'Private Sub cvDataMensile_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurnoMensile Where (IdAccertatoreRichiedente = @IdUtente Or IdAccertatoreDestinatario = @IdUtente) And Data = @Data And (StatoRichiesta Is Null Or StatoRichiesta = 1)", con)
  '  sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
  '  sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), Calendar).SelectedDate
  '  con.Open()
  '  args.IsValid = sc.ExecuteScalar() <= 0
  '  con.Close()
  'End Sub

  'Private Sub cvMensili_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
  '  Dim conf As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
  '  Dim sc As New Odbc.OdbcCommand(conf.GetValue("SelectMensiliProvvisoriAperti", GetType(String)), conAS400)
  '  conAS400.Open()
  '  args.IsValid = sc.ExecuteScalar() > 0
  '  conAS400.Close()
  'End Sub

  'Private Function pCheckCambiTurnoMese(ByVal pData As Date) As Boolean
  '  Dim sc As New SqlClient.SqlCommand("Select Count(*) From RichiesteCambiTurnoMensile Where (IdAccertatoreRichiedente = @IdUtente Or IdAccertatoreDestinatario = @IdUtente) And Data = @Data And (StatoRichiesta Is Null Or StatoRichiesta = 1)", con)
  '  sc.Parameters.Add("@IdUtente", SqlDbType.Int).Value = oUtente.ID
  '  sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = pData
  '  con.Open()
  '  pCheckCambiTurnoMese = sc.ExecuteScalar() <= 0
  '  con.Close()
  'End Function

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
    If args.IsValid = True Then
      args.IsValid = Not HoGi‡ChiestoCongedo(oUtente.IDUser, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caAlGiorno"), Calendar).SelectedDate) = Month(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate)
    End If
  End Sub
  Public Sub cvDataDalFestiva_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    args.IsValid = Not pFestivita(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("caDalGiorno"), Calendar).SelectedDate,True)

  End Sub
  '
  Private Function pFestivita(ByVal dal As Date, Optional ByVal AncheRiposo As Boolean = False) As Boolean
    'DM2020.02 - controllo che la data sia una festivit‡: se lo Ë ritorno TRUE
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

  Private Sub daCongedi_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles daCongedi.RowUpdated

  End Sub

  Private Sub DgMostraFerieCongedi_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgMostraFerieCongedi.PreRender
    'DM2020.02
    For i As Integer = 0 To DgMostraFerieCongedi.Items.Count - 1
      If DgMostraFerieCongedi.Items(i).Cells(3).Text > CMaxPrenotabile Then
        DgMostraFerieCongedi.Items(i).Cells(3).BackColor = Color.Red
      ElseIf DgMostraFerieCongedi.Items(i).Cells(3).Text = CMaxPrenotabile Then
        DgMostraFerieCongedi.Items(i).Cells(3).BackColor = Color.Green
      End If
    Next i
  End Sub

  Private Sub AggiornaDataGrid(ByVal InpDataDa As Date, ByVal InpDataA As Date)
    'DM2020.02
    Dim sData As String
    sData = CStr(InpDataDa)
    If sData = "" Then sData = Now
    sData = Right(sData, 4) + "-" + Mid(sData, 4, 2) + "-" + Left(sData, 2)
    daMostraFerieCongedi.SelectCommand.Parameters(1).Value() = sData
    '    
    sData = CStr(InpDataA)
    If sData = "" Then sData = Now
    sData = Right(sData, 4) + "-" + Mid(sData, 4, 2) + "-" + Left(sData, 2)
    daMostraFerieCongedi.SelectCommand.Parameters(2).Value() = sData
    '
    lblDAL.Text = InpDataDa
    lblAL.Text = InpDataA
    DgMostraFerieCongedi.ToolTip = daMostraFerieCongedi.SelectCommand.Parameters(1).Value + " - " + daMostraFerieCongedi.SelectCommand.Parameters(2).Value
    '
    DgMostraFerieCongedi.Columns(1).Visible() = oUtente.TipoUtente = 1
    daMostraFerieCongedi.SelectCommand.Parameters(3).Value() = "R"
    daMostraFerieCongedi.SelectCommand.Parameters(4).Value() = oUtente.IDUser
    daMostraFerieCongedi.SelectCommand.Parameters(5).Value() = "C"  'Passo alla stored la "C" di Congedi
    daMostraFerieCongedi.Fill(DsMostraFerieCongedi1)
    DgMostraFerieCongedi.DataBind()
  End Sub

  Private Sub dgCongedi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCongedi.SelectedIndexChanged

  End Sub

  Private Sub dgCongedi_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCongedi.PreRender
    'DM2020.02
    On Error Resume Next
    If dgCongedi.EditItemIndex.ToString > -1 Then
      'DgMostraFerieCongedi.ToolTip = dgFerie.EditItemIndex.ToString

      '      For i As Integer = 0 To dgCongedi.Items.Count - 1
      If Not IsNothing(dgCongedi.Items(dgCongedi.EditItemIndex).FindControl("caDalGiorno").ID) Then
        '--> DgMostraFerieCongedi.ToolTip = DirectCast(dgFerie.Items(i).FindControl("caDalGiorno"), Calendar).SelectedDate & "-" & DirectCast(dgFerie.Items(i).FindControl("caAlGiorno"), Calendar).SelectedDate
        AggiornaDataGrid(DirectCast(dgCongedi.Items(dgCongedi.EditItemIndex).FindControl("caDalGiorno"), Calendar).SelectedDate, DirectCast(dgCongedi.Items(dgCongedi.EditItemIndex).FindControl("caAlGiorno"), Calendar).SelectedDate)
      End If
      '     Next i
    End If
  End Sub

  Function SonoARiposo(ByVal InpMatricola As String, ByVal InpData As DateTime) As Boolean

    Dim risposta As Boolean
    Dim tr As New supTransaction
    Dim sdata As String
    sdata = InpData
    Dim cmdRiposo As New SqlClient.SqlCommand("SELECT * FROM [Riposi] where TTMATR = '" & InpMatricola.ToString & "' and DataRiposo = '" & sdata & "'", con)
    Dim drRiposo As SqlClient.SqlDataReader
    con.Open()
    drRiposo = cmdRiposo.ExecuteReader()
    risposta = drRiposo.HasRows
    con.Close()

    SonoARiposo = risposta

  End Function
  Function HoGi‡ChiestoCongedo(ByVal InpMatricola As String, ByVal InpData As DateTime) As Boolean
    'DM2020.03
    Dim risposta As Boolean
    Dim tr As New supTransaction
    Dim sdata As String
    sdata = InpData
    Dim cmdHoGi‡Chiesto As New SqlClient.SqlCommand("SELECT * FROM RichiesteCongedi inner join ATC_Utenti UTE on UTE.ID = IdAccertatore where UTE.IDUser = '" & InpMatricola.ToString & "' and DalGiorno = '" & sdata & "'", con)
    Dim drHoGi‡Chiesto As SqlClient.SqlDataReader
    con.Open()
    drHoGi‡Chiesto = cmdHoGi‡Chiesto.ExecuteReader()
    risposta = drHoGi‡Chiesto.HasRows
    con.Close()

    HoGi‡ChiestoCongedo = risposta

  End Function

  Private Sub cvOnModificaCongedo_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvOnModificaCongedo.ServerValidate

  End Sub
End Class
