Public Class wf_mancatatimbraturagestori
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCongediFrazionati = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsRichiesteCongediFrazionati1 = New ATCBussm1.dsRichiesteCongediFrazionati
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.daMancataTimbratura = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsMancataTimbratura1 = New ATCBussm1.DsMancataTimbratura
    Me.daAccertatori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsRichiesteCongediFrazionati1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsMancataTimbratura1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCongediFrazionati
    '
    Me.daCongediFrazionati.DeleteCommand = Me.SqlCommand1
    Me.daCongediFrazionati.InsertCommand = Me.SqlInsertCommand1
    Me.daCongediFrazionati.SelectCommand = Me.SqlSelectCommand1
    Me.daCongediFrazionati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediFrazionati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("DalleOre", "DalleOre"), New System.Data.Common.DataColumnMapping("AlleOre", "AlleOre"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    Me.daCongediFrazionati.UpdateCommand = Me.SqlCommand2
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "DELETE FROM dbo.RichiesteCongediFrazionati WHERE (IdRichiesta = @IdRichiesta)"
    Me.SqlCommand1.Connection = Me.con
    Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.RichiesteCongediFrazionati (IdRichiesta, IdAccertatore, Data, Dal" & _
    "leOre, AlleOre, Intero) VALUES (@IdRichiesta, @IdAccertatore, @Data, @DalleOre, " & _
    "@AlleOre, @Intero)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRichiesta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdRichiesta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 8, "DalleOre"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 8, "AlleOre"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intero", System.Data.SqlDbType.Bit, 1, "Intero"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, RC.IdRichiesta, RC.IdAccertatore," & _
    " RC.Data, RC.DalleOre, RC.AlleOre, CASE WHEN RC.StatoApprovazione IS NULL THEN '" & _
    "Da approvare' WHEN RC.StatoApprovazione = 0 THEN 'Respinta' WHEN RC.StatoApprova" & _
    "zione = 1 THEN 'Approvata' WHEN RC.StatoApprovazione = 99 THEN 'Convertito in in" & _
    "tero' END AS StatoApprovazione, RC.DataApprovazione, RC.IdApprovatore, RC.ts,RC." & _
    "Intero FROM dbo.RichiesteCongediFrazionati RC LEFT OUTER JOIN dbo.ATC_Utenti U O" & _
    "N RC.IdApprovatore = U.ID WHERE (RC.IdAccertatore = @IdAccertatore) AND (RC.Data" & _
    " >= DATEADD(d,DATEDIFF(d,0,GETDATE()),0)) ORDER BY RC.ts DESC"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "IdAccertatore"))
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "UPDATE dbo.RichiesteCongediFrazionati SET Data = @Data, DalleOre = @DalleOre, All" & _
    "eOre = @AlleOre, ts = GETDATE(), Intero = @Intero WHERE (IdRichiesta = @IdRIchie" & _
    "sta)"
    Me.SqlCommand2.Connection = Me.con
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DalleOre", System.Data.SqlDbType.BigInt, 8, "DalleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AlleOre", System.Data.SqlDbType.BigInt, 8, "AlleOre"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intero", System.Data.SqlDbType.Bit, 1, "Intero"))
    Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdRIchiesta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdRichiesta", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsRichiesteCongediFrazionati1
    '
    Me.DsRichiesteCongediFrazionati1.DataSetName = "dsRichiesteCongediFrazionati"
    Me.DsRichiesteCongediFrazionati1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=False;initial catalog=ATCBussm"
    '
    'daMancataTimbratura
    '
    Me.daMancataTimbratura.DeleteCommand = Me.SqlDeleteCommand2
    Me.daMancataTimbratura.InsertCommand = Me.SqlInsertCommand3
    Me.daMancataTimbratura.SelectCommand = Me.SqlSelectCommand3
    Me.daMancataTimbratura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_MancataTimbratura", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Entrata1", "Entrata1"), New System.Data.Common.DataColumnMapping("Uscita1", "Uscita1"), New System.Data.Common.DataColumnMapping("Entrata2", "Entrata2"), New System.Data.Common.DataColumnMapping("Uscita2", "Uscita2"), New System.Data.Common.DataColumnMapping("StatoMancataTimbratura", "StatoMancataTimbratura"), New System.Data.Common.DataColumnMapping("DataInserimento", "DataInserimento"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("ApprovatoDa", "ApprovatoDa"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    Me.daMancataTimbratura.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.Accertatori_MancataTimbratura WHERE (ID = @ID)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.Accertatori_MancataTimbratura(ID, AccertatoreId, Data, Entrata1, " & _
    "Uscita1, Entrata2, Uscita2, StatoMancataTimbratura, DataInserimento, DataApprova" & _
    "zione, ApprovatoDa, CreatedOn, ModifiedOn, CreatedBy, ModifiedBy) VALUES (@ID, @" & _
    "AccertatoreId, @Data, @Entrata1, @Uscita1, @Entrata2, @Uscita2, @StatoMancataTim" & _
    "bratura, @DataInserimento, @DataApprovazione, @ApprovatoDa, @CreatedOn, @Modifie" & _
    "dOn, @CreatedBy, @ModifiedBy); SELECT ID, AccertatoreId, Data, Entrata1, Uscita1" & _
    ", Entrata2, Uscita2, StatoMancataTimbratura, DataInserimento, DataApprovazione, " & _
    "ApprovatoDa, CreatedOn, ModifiedOn, CreatedBy, ModifiedBy FROM dbo.Accertatori_M" & _
    "ancataTimbratura WHERE (ID = @ID)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrata1", System.Data.SqlDbType.DateTime, 8, "Entrata1"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Uscita1", System.Data.SqlDbType.DateTime, 8, "Uscita1"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrata2", System.Data.SqlDbType.DateTime, 8, "Entrata2"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Uscita2", System.Data.SqlDbType.DateTime, 8, "Uscita2"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StatoMancataTimbratura", System.Data.SqlDbType.Int, 4, "StatoMancataTimbratura"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataInserimento", System.Data.SqlDbType.DateTime, 8, "DataInserimento"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataApprovazione", System.Data.SqlDbType.DateTime, 8, "DataApprovazione"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ApprovatoDa", System.Data.SqlDbType.Int, 4, "ApprovatoDa"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedOn", System.Data.SqlDbType.DateTime, 8, "CreatedOn"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, MT.ID, MT.AccertatoreId, MT.Data," & _
    " MT.Entrata1, MT.Uscita1, MT.Entrata2, MT.Uscita2, DATEPART(hour, MT.Entrata1) A" & _
    "S DalleOre1, DATEPART(hour, MT.Uscita1) AS AlleOre1, DATEPART(hour, MT.Entrata2)" & _
    " AS DalleOre2, DATEPART(hour, MT.Uscita2) AS AlleOre2, DATEPART(minute, MT.Entra" & _
    "ta1) AS DalleMin1, DATEPART(minute, MT.Uscita1) AS AlleMin1, DATEPART(minute, MT" & _
    ".Entrata2) AS DalleMin2, DATEPART(minute, MT.Uscita2) AS AlleMin2, CASE WHEN MT." & _
    "StatoMancataTimbratura IS NULL THEN 'Da approvare' WHEN MT.StatoMancataTimbratur" & _
    "a = 0 THEN 'Respinta' WHEN MT.StatoMancataTimbratura = 1 THEN 'Approvata' END AS" & _
    " StatoApprovazione, MT.DataApprovazione, MT.ApprovatoDa, MT.CreatedOn, U1.IDUser" & _
    " + ' - ' + U1.Cognome + ' ' + U1.Nome AS CognomeNome, MT.DataInserimento, MT.Sta" & _
    "toMancataTimbratura, MT.CreatedBy, MT.ModifiedOn, MT.ModifiedBy FROM dbo.Accerta" & _
    "tori_MancataTimbratura MT LEFT OUTER JOIN dbo.ATC_Utenti U1 ON MT.AccertatoreId " & _
    "= U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U ON MT.ApprovatoDa = U.ID WHERE (MT.Data" & _
    " >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) AND (MT.AccertatoreId = @IdAccerta" & _
    "tore) ORDER BY MT.CreatedOn DESC"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAccertatore", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.Accertatori_MancataTimbratura SET Data = @Data, Entrata1 = @Entrata1, " & _
    "Uscita1 = @Uscita1, Entrata2 = @Entrata2, Uscita2 = @Uscita2, DataInserimento = " & _
    "GETDATE() WHERE (ID = @ID)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrata1", System.Data.SqlDbType.DateTime, 8, "Entrata1"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Uscita1", System.Data.SqlDbType.DateTime, 8, "Uscita1"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrata2", System.Data.SqlDbType.DateTime, 8, "Entrata2"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Uscita2", System.Data.SqlDbType.DateTime, 8, "Uscita2"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsMancataTimbratura1
    '
    Me.DsMancataTimbratura1.DataSetName = "DsMancataTimbratura"
    Me.DsMancataTimbratura1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daAccertatori
    '
    Me.daAccertatori.SelectCommand = Me.SqlSelectCommand2
    Me.daAccertatori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TPER_Accertatori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("NomeCognome", "NomeCognome")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT ID, LTRIM(RTRIM(ISNULL(Cognome, ''))) + ' ' + LTRIM(RTRIM(ISNULL(Nome, '')" & _
    ")) + ' -  ' + IDUser AS NomeCognome FROM dbo.ATC_Utenti WHERE (TipoUtente = 2) A" & _
    "ND (Abilitato = 1) ORDER BY NomeCognome"
    Me.SqlSelectCommand2.Connection = Me.con
    CType(Me.DsRichiesteCongediFrazionati1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsMancataTimbratura1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCongediFrazionati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsRichiesteCongediFrazionati1 As ATCBussm1.dsRichiesteCongediFrazionati
  Protected WithEvents dgCongediFrazionati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnAddRichiesta As System.Web.UI.WebControls.Button
  Protected WithEvents lblRichieste As System.Web.UI.WebControls.Label
  Protected WithEvents cvOnModifica As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents cvTipoUtente As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents daMancataTimbratura As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsMancataTimbratura1 As ATCBussm1.DsMancataTimbratura
  Protected WithEvents daAccertatori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents ddlAccertatori As System.Web.UI.WebControls.DropDownList
  Protected WithEvents Label6 As System.Web.UI.WebControls.Label
  Protected WithEvents BtnCerca As System.Web.UI.WebControls.Button

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
  Const TableMT As String = "Accertatori_MancataTimbratura"
  Const Modulo As String = "wf_mancatatimbraturagestori.aspx"
  Dim accertatoreid As String
  Dim accertatoreNome As String

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
      Response.Redirect("wf_questionario.aspx")
    End If

    cvTipoUtente.Validate()
    btnAddRichiesta.Enabled = cvTipoUtente.IsValid And dgCongediFrazionati.EditItemIndex = -1


    If Not IsPostBack Then
      daAccertatori.Fill(DsMancataTimbratura1, "TPER_Accertatori")
      ddlAccertatori.DataBind()
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, Modulo, "Pagina iniziale", Session("IPAddress"))

      daMancataTimbratura.SelectCommand.Parameters("@IDAccertatore").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
      daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
      Session.Add("AccIndex", Convert.ToInt32(ddlAccertatori.SelectedIndex))
    Else
      'daAccertatori.Fill(DsMancataTimbratura1, "TPER_Accertatori")
      'ddlAccertatori.DataBind()
      'ddlAccertatori.SelectedIndex = Session("AccIndex")

      daMancataTimbratura.SelectCommand.Parameters("@IDAccertatore").Value = ddlAccertatori.Items(Convert.ToInt32(Session("AccIndex"))).Value
      daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
    End If

  End Sub

  Private Sub dgCongediFrazionati_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemDataBound
    Dim dtda1 As DateTime
    Dim dta1 As DateTime
    Dim dtda2 As DateTime
    Dim dta2 As DateTime

    If Not e.Item.FindControl("ddlDalleOre1") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dtda1 = dr.Item("Entrata1")
      DirectCast(e.Item.FindControl("ddlDalleOre1"), DropDownList).SelectedValue = dtda1.Hour
    End If
    If Not e.Item.FindControl("ddlDaMinuti1") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dtda1 = dr.Item("Entrata1")
      DirectCast(e.Item.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue = dtda1.Minute
    End If

    If Not e.Item.FindControl("ddlAlleOre1") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dta1 = dr.Item("Uscita1")
      DirectCast(e.Item.FindControl("ddlAlleOre1"), DropDownList).SelectedValue = dta1.Hour
    End If
    If Not e.Item.FindControl("ddlAMinuti1") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dta1 = dr.Item("Uscita1")
      DirectCast(e.Item.FindControl("ddlAMinuti1"), DropDownList).SelectedValue = dta1.Minute
    End If


    If Not e.Item.FindControl("ddlDalleOre2") Is Nothing Then

      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dtda2 = dr.Item("Entrata2")
      DirectCast(e.Item.FindControl("ddlDalleOre2"), DropDownList).SelectedValue = dtda2.Hour
    End If
    If Not e.Item.FindControl("ddlDaMinuti2") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dtda2 = dr.Item("Entrata2")
      DirectCast(e.Item.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue = dtda2.Minute
    End If

    If Not e.Item.FindControl("ddlAlleOre2") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dta2 = dr.Item("Uscita2")
      DirectCast(e.Item.FindControl("ddlAlleOre2"), DropDownList).SelectedValue = dta2.Hour
    End If
    If Not e.Item.FindControl("ddlAMinuti2") Is Nothing Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      dta2 = dr.Item("Uscita2")
      DirectCast(e.Item.FindControl("ddlAMinuti2"), DropDownList).SelectedValue = dta2.Minute
    End If

  End Sub

  Private Sub btnAddRichiesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRichiesta.Click
    Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).NewRow
    Dim dt As DateTime
    dt = Now.Date
    dr.Item("ID") = Guid.NewGuid
    dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    dr.Item("Data") = Now.Date
    dr.Item("DataInserimento") = Now
    dr.Item("CreatedOn") = Now
    dr.Item("CreatedBy") = oUtente.ID
    dr.Item("ModifiedOn") = Now

    dr.Item("ModifiedBy") = oUtente.ID
    'dr.Item("DalleOre") = New TimeSpan(7, 0, 0).Ticks
    'dr.Item("AlleOre") = New TimeSpan(7, 0, 0).Ticks

    dr.Item("Entrata1") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
    dr.Item("Uscita1") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
    dr.Item("Entrata2") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)
    dr.Item("Uscita2") = New DateTime(Year(dt), Month(dt), Day(dt), 0, 0, 0)

    DsMancataTimbratura1.Tables(TableMT).Rows.InsertAt(dr, 0)
    dgCongediFrazionati.EditItemIndex = 0

    'Page.DataBind()
    dgCongediFrazionati.DataBind()
    btnAddRichiesta.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, Modulo, "Click nuova richiesta mancata timbratura gest", Session("IPAddress"))
  End Sub

  Private Sub dgCongediFrazionati_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.CancelCommand
    dgCongediFrazionati.EditItemIndex = -1
    daMancataTimbratura.SelectCommand.Parameters("@IDAccertatore").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
    dgCongediFrazionati.DataBind()
    btnAddRichiesta.Enabled = True
    fnc.ScriviLog(oUtente.IDUser, "wf_mancatatimbratura.aspx", "Annullata modifica", Session("IPAddress"))
  End Sub

  Private Sub dgCongediFrazionati_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.EditCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      dgCongediFrazionati.EditItemIndex = e.Item.ItemIndex
      daMancataTimbratura.SelectCommand.Parameters("@IDAccertatore").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
      daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
      dgCongediFrazionati.DataBind()
      btnAddRichiesta.Enabled = False
      fnc.ScriviLog(oUtente.IDUser, "wf_mancatatimbratura.aspx", "Inizio modifica mancata timbratura", Session("IPAddress"))
    End If
  End Sub

  Public Sub cvMinData_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    args.IsValid = DirectCast(DirectCast(source, CustomValidator).Parent.FindControl("caData"), Calendar).SelectedDate <= Now.Date

  End Sub

  Public Sub cvAlleOre_OnServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
    Dim t1 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre1"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue, 0)
    Dim t2 As New TimeSpan(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre1"), DropDownList).SelectedValue, DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti1"), DropDownList).SelectedValue, 0)
    Dim t1h As Integer
    Dim t1m As Integer
    Dim t2h As Integer
    Dim t2m As Integer

    Dim t3h As Integer
    Dim t3m As Integer
    Dim t4h As Integer
    Dim t4m As Integer
    Dim ris As Boolean

    t1h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre1"), DropDownList).SelectedValue)
    t1m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue)
    t2h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre1"), DropDownList).SelectedValue)
    t2m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti1"), DropDownList).SelectedValue)

    t3h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDalleOre2"), DropDownList).SelectedValue)
    t3m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlDaMinuti2"), DropDownList).SelectedValue)
    t4h = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAlleOre2"), DropDownList).SelectedValue)
    t4m = Convert.ToInt32(DirectCast(DirectCast(source, CustomValidator).Parent.Parent.FindControl("ddlAMinuti2"), DropDownList).SelectedValue)
    Dim t3 As New TimeSpan(t3h, t3m, 0)
    Dim t4 As New TimeSpan(t4h, t4m, 0)
    ris = True
    If (t2h <> 0 Or t2m <> 0) Then
      ris = t2.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    End If


    If (t3h <> 0 Or t3m <> 0) Then
      ris = ris And t3.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
      ris = ris And t3.Subtract(t2).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    End If
    If (t4h <> 0 Or t4m <> 0) Then
      ris = ris And t4.Subtract(t1).CompareTo(New TimeSpan(0, 15, 0)) <> -1
      ris = ris And t4.Subtract(t2).CompareTo(New TimeSpan(0, 15, 0)) <> -1
      ris = ris And t4.Subtract(t3).CompareTo(New TimeSpan(0, 15, 0)) <> -1
    End If


    args.IsValid = ris

  End Sub

  Private Sub dgCongediFrazionati_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.UpdateCommand
    If Me.IsValid Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If dr Is Nothing Then
        dr = DsMancataTimbratura1.Tables(TableMT).NewRow
        dr.Item("ID") = Guid.NewGuid
        dr.Item("AccertatoreId") = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
        dr.Item("DataInserimento") = Now
        dr.Item("CreatedOn") = Now
        dr.Item("ModifiedOn") = Now
        dr.Item("CreatedBy") = oUtente.ID
        dr.Item("ModifiedBy") = oUtente.ID

        DsMancataTimbratura1.Tables(TableMT).Rows.Add(dr)
      End If
      Dim dt As DateTime
      dt = DirectCast(e.Item.FindControl("caData"), Calendar).SelectedDate
      dr.Item("Data") = DirectCast(e.Item.FindControl("caData"), Calendar).SelectedDate
      dr.Item("Entrata1") = New DateTime(Year(dt), Month(dt), Day(dt), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlDalleOre1"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlDaMinuti1"), DropDownList).SelectedValue), 0)
      dr.Item("Uscita1") = New DateTime(Year(dt), Month(dt), Day(dt), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlAlleOre1"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlAMinuti1"), DropDownList).SelectedValue), 0)
      dr.Item("Entrata2") = New DateTime(Year(dt), Month(dt), Day(dt), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlDalleOre2"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlDaMinuti2"), DropDownList).SelectedValue), 0)
      dr.Item("Uscita2") = New DateTime(Year(dt), Month(dt), Day(dt), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlAlleOre2"), DropDownList).SelectedValue), Convert.ToInt32(DirectCast(e.Item.FindControl("ddlAMinuti2"), DropDownList).SelectedValue), 0)

      daMancataTimbratura.Update(DsMancataTimbratura1, TableMT)
      DsMancataTimbratura1.Tables(TableMT).Clear()
      'daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
      dgCongediFrazionati_CancelCommand(source, e)
      fnc.ScriviLog(oUtente.IDUser, "wf_mancatatimbratura.aspx", oUtente.Nome & "-" & "Confermato inserimento/modifica mancata timbratura ", Session("IPAddress"))
    End If
  End Sub

  Private Sub dgCongediFrazionati_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.DeleteCommand
    cvOnModifica.IsValid = DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = "Da approvare" Or DirectCast(e.Item.FindControl("lblStatoApprovazione"), Label).Text = ""
    If cvOnModifica.IsValid Then
      Dim dr As DataRow = DsMancataTimbratura1.Tables(TableMT).Rows.Find(dgCongediFrazionati.DataKeys(e.Item.ItemIndex))
      If Not dr Is Nothing Then
        dr.Delete()
        daMancataTimbratura.Update(DsMancataTimbratura1, TableMT)
        fnc.ScriviLog(oUtente.IDUser, "wf_mancatatimbratura.aspx", "Eliminato mancata timbratura", Session("IPAddress"))
      End If
      dgCongediFrazionati_CancelCommand(source, e)
    End If
  End Sub

  Private Sub dgCongediFrazionati_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemCreated
    If Not e.Item.FindControl("lnkDelete") Is Nothing Then DirectCast(e.Item.FindControl("lnkDelete"), LinkButton).Attributes.Add("onClick", "return confirm('Sei sicuro di voler eliminare questa richiesta di mancata timbratura?');")
  End Sub


  Private Sub BtnCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerca.Click
    daMancataTimbratura.SelectCommand.Parameters("@IDAccertatore").Value = ddlAccertatori.Items(ddlAccertatori.SelectedIndex).Value
    daMancataTimbratura.Fill(DsMancataTimbratura1, TableMT)
    dgCongediFrazionati.DataBind()
    Session.Remove("AccIndex")
    Session.Add("AccIndex", ddlAccertatori.SelectedIndex)
  End Sub
End Class
