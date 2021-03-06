Public Class wf_giorniriposoassistenti
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.DaRiposo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsRiposiTutti1 = New ATCBussm1.DsRiposiTutti
    CType(Me.DsRiposiTutti1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'DaRiposo
    '
    Me.DaRiposo.InsertCommand = Me.SqlInsertCommand1
    Me.DaRiposo.SelectCommand = Me.SqlSelectCommand1
    Me.DaRiposo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Riposi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TTMATR", "TTMATR"), New System.Data.Common.DataColumnMapping("TTGGGG", "TTGGGG"), New System.Data.Common.DataColumnMapping("TTMMGG", "TTMMGG"), New System.Data.Common.DataColumnMapping("TTAAGG", "TTAAGG"), New System.Data.Common.DataColumnMapping("TTCTUR", "TTCTUR"), New System.Data.Common.DataColumnMapping("DataRiposo", "DataRiposo")})})
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Riposi(TTMATR, TTGGGG, TTMMGG, TTAAGG, TTCTUR, DataRiposo) VALUES" & _
    " (@TTMATR, @TTGGGG, @TTMMGG, @TTAAGG, @TTCTUR, @DataRiposo); SELECT TTMATR, TTGG" & _
    "GG, TTMMGG, TTAAGG, TTCTUR, DataRiposo FROM dbo.Riposi"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TTMATR", System.Data.SqlDbType.VarChar, 50, "TTMATR"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TTGGGG", System.Data.SqlDbType.VarChar, 50, "TTGGGG"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TTMMGG", System.Data.SqlDbType.VarChar, 50, "TTMMGG"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TTAAGG", System.Data.SqlDbType.VarChar, 50, "TTAAGG"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TTCTUR", System.Data.SqlDbType.VarChar, 50, "TTCTUR"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataRiposo", System.Data.SqlDbType.VarChar, 50, "DataRiposo"))
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT ID, TTMATR, TTGGGG, TTMMGG, TTAAGG, TTCTUR, DataRiposo FROM dbo.Riposi WHE" & _
    "RE (TTAAGG = @anno) AND ('0' = @mese) AND (TTMATR = @Matr) OR (TTAAGG = @anno) A" & _
    "ND (TTMATR = @Matr) AND (TTMMGG = @mese) OR (TTAAGG = @anno) AND ('0' = @mese) A" & _
    "ND ('tutti' = @Matr) OR (TTAAGG = @anno) AND (TTMMGG = @mese) AND ('tutti' = @Ma" & _
    "tr) ORDER BY TTMATR, CAST(TTAAGG AS int), CAST(TTMMGG AS int), CAST(TTGGGG AS in" & _
    "t)"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TTAAGG", System.Data.DataRowVersion.Current, "2015"))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mese", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TTMMGG", System.Data.DataRowVersion.Current, "0"))
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Matr", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TTMATR", System.Data.DataRowVersion.Current, "tutti"))
    '
    'DsRiposiTutti1
    '
    Me.DsRiposiTutti1.DataSetName = "DsRiposiTutti"
    Me.DsRiposiTutti1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsRiposiTutti1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnFind As System.Web.UI.WebControls.Button
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents pnlGiorniSpeciali As System.Web.UI.WebControls.Panel
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaRiposo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents dgRiposi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LblMese As System.Web.UI.WebControls.Label
  Protected WithEvents CboMese As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lbllegend As System.Web.UI.WebControls.Label
  Protected WithEvents Txtmatricola As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblmatricola As System.Web.UI.WebControls.Label
  Protected WithEvents txtID As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents lkStampa As System.Web.UI.HtmlControls.HtmlAnchor
  Protected WithEvents DsRiposiTutti1 As ATCBussm1.DsRiposiTutti

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region
  Private oUtente As Utente

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here



    If Not IsPostBack Then
      txtAnno.Text = Now.Year.ToString()
      Session.Add("annoriposi", Now.Year.ToString())
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      Dim s As String = DaRiposo.SelectCommand.CommandText
      Dim iduser As String
      'If (oUtente.IDUser.ToLower() = "admin") Then
      '  iduser = "11412"
      'Else
      '  iduser = oUtente.IDUser
      'End If

      If (Txtmatricola.Text.Trim() = "") Then
        iduser = "'tutti'"
      Else
        Session.Add("Matricola", Txtmatricola.Text.Trim())
        iduser = "'" & Txtmatricola.Text.Trim() & "'"
      End If

      Dim mese As String
      mese = CboMese.SelectedValue
      s = s.Replace("@anno", txtAnno.Text)
      s = s.Replace("@Matr", iduser)
      s = s.Replace("@mese", mese)
      DaRiposo.SelectCommand.CommandText = s
      'daAS400.SelectCommand.Parameters.Add("@SelectedDate", OleDb.OleDbType.Date).Value = caData.SelectedDate
      DaRiposo.AcceptChangesDuringFill = False

      DsRiposiTutti1.Tables("Riposi").Clear()
      DaRiposo.Fill(DsRiposiTutti1, "Riposi")

      dgRiposi.DataBind()
      lbllegend.Text = "Giorni Riposo. Numero totale estratto: " & DsRiposiTutti1.Tables("Riposi").Rows.Count.ToString()

    End If

  End Sub

  Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    Ricerca()

  End Sub

  Private Sub Ricerca()
    oUtente = Session("User")
    Dim iduser As String
    'If (oUtente.IDUser.ToLower() = "admin") Then
    '  iduser = "11412"
    'Else
    '  iduser = oUtente.IDUser
    'End If
    Session.Remove("annoriposi")
    Session.Add("annoriposi", txtAnno.Text)
    If (Txtmatricola.Text.Trim() = "") Then
      iduser = "'tutti'"
    Else
      iduser = "'" & Txtmatricola.Text.Trim() & "'"
    End If

    Dim s As String = DaRiposo.SelectCommand.CommandText
    Dim mese As String
    mese = CboMese.SelectedValue
    s = s.Replace("@anno", txtAnno.Text)
    s = s.Replace("@Matr", iduser)
    s = s.Replace("@mese", mese)
    DaRiposo.SelectCommand.CommandText = s
    'daAS400.SelectCommand.Parameters.Add("@SelectedDate", OleDb.OleDbType.Date).Value = caData.SelectedDate
    DaRiposo.AcceptChangesDuringFill = False
    DsRiposiTutti1.Tables("Riposi").Clear()
    DaRiposo.Fill(DsRiposiTutti1, "Riposi")

    dgRiposi.DataBind()
    lbllegend.Text = "Giorni Riposo. Numero totale estratto: " & DsRiposiTutti1.Tables("Riposi").Rows.Count.ToString()


  End Sub


  Private Sub DaRiposo_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles DaRiposo.RowUpdated

  End Sub
End Class
