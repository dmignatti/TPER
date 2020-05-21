Imports System.Data.SqlClient

Public Class wf_permessi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents cboModuli As System.Web.UI.WebControls.DropDownList
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents lstGruppiModulo As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnDel As System.Web.UI.WebControls.Button
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents lstGruppi As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button

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

    ' ----------------------------------------------------------------------------
    '     Righe agginte da Paolo Cavazzini
    ' ----------------------------------------------------------------------------
    'Dim intUserID As Integer = atcbSession.Get_UserID(Me.Session)
    'Dim intSectionID As Integer = atcbSession.Get_SectionID(Me.Session)
    'atcbWUser.LoadMenu(intUserID, intSectionID, tblToolbar)
    ' ----------------------------------------------------------------------------
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select * From ATC_ModuliPortale Where Abilitato <> 0 Order By Descrizione", con)
    Dim dr As SqlDataReader
    If Not Me.IsPostBack Then
      con.Open()
      dr = com.ExecuteReader
      cboModuli.Items.Clear()
      Do While dr.Read
        cboModuli.Items.Add(dr.Item("Descrizione"))
        cboModuli.Items.FindByText(dr.Item("Descrizione")).Value = dr.Item("Id")
      Loop
      dr.Close()
      con.Close()
      con.Dispose()
      LoadListaGruppi()
      LoadListaGruppiModulo()
      btnAdd.Visible = oUtente.CheckAbil(13, 2)
      btnDel.Visible = oUtente.CheckAbil(14, 3)
    End If

  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Insert Into ATC_RelModuloGruppo(IdModulo, IdGruppo) Values(@1, @2)", con)
    Dim i As Integer
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = cboModuli.SelectedValue
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstGruppi.Items.Count - 1
      If lstGruppi.Items(i).Selected Then
        com.Parameters("@2").Value = lstGruppi.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    con.Close()
    con.Dispose()

    LoadListaGruppi()
    LoadListaGruppiModulo()
  End Sub

  Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Delete From ATC_RelModuloGruppo Where IdModulo = @1 And IdGruppo = @2", con)
    Dim i As Integer
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = cboModuli.SelectedValue
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstGruppiModulo.Items.Count - 1
      If lstGruppiModulo.Items(i).Selected Then
        com.Parameters("@2").Value = lstGruppiModulo.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    con.Close()
    con.Dispose()

    LoadListaGruppi()
    LoadListaGruppiModulo()
  End Sub

  Private Sub cboModuli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModuli.SelectedIndexChanged
    'Put user code to initialize the page here
    LoadListaGruppi()
    LoadListaGruppiModulo()
  End Sub

  Private Sub LoadListaGruppi()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader

    con.Open()
    com = New SqlCommand("Select * From ATC_Gruppi G Where G.Amministrazione = 0 And Not Exists(Select * From ATC_RelModuloGruppo MG Where MG.IdGruppo = G.ID And IdModulo = @1) Order By Descrizione", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = cboModuli.SelectedValue
    dr = com.ExecuteReader
    lstGruppi.Items.Clear()
    Do While dr.Read
      lstGruppi.Items.Add(dr.Item("Descrizione"))
      lstGruppi.Items.FindByText(dr.Item("Descrizione")).Value = dr.Item("Id")
    Loop
    dr.Close()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub LoadListaGruppiModulo()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader

    con.Open()
    com = New SqlCommand("Select MG.IdGruppo, G.Descrizione From ATC_RelModuloGruppo MG Left Join ATC_Gruppi G On MG.IdGruppo = G.Id Where IdModulo = @1 And G.Amministrazione = 0 Order By Descrizione", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = cboModuli.SelectedValue
    dr = com.ExecuteReader
    lstGruppiModulo.Items.Clear()
    Do While dr.Read
      lstGruppiModulo.Items.Add(dr.Item("Descrizione"))
      lstGruppiModulo.Items.FindByText(dr.Item("Descrizione")).Value = dr.Item("IdGruppo")
    Loop

    dr.Close()
    con.Close()
  End Sub

End Class
