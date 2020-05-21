Imports System.Data.SqlClient

Public Class wf_gruppi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents lstGruppi As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents btnModify As System.Web.UI.WebControls.Button
  Protected WithEvents btnRemove As System.Web.UI.WebControls.Button
  Protected WithEvents txtId As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents txtDescription As System.Web.UI.WebControls.TextBox
  Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents lstUtentiGruppo As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnRemoveUser As System.Web.UI.WebControls.Button
  Protected WithEvents Label4 As System.Web.UI.WebControls.Label
  Protected WithEvents lstUtenti As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnAddUser As System.Web.UI.WebControls.Button
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents Button1 As System.Web.UI.WebControls.Button
  Protected WithEvents pnlGroup As System.Web.UI.WebControls.Panel

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
    If Not Me.IsPostBack Then
      pLoadGroups()
      btnAdd.Visible = oUtente.CheckAbil(12, 2)
      btnModify.Visible = oUtente.CheckAbil(12, 4)
      btnRemove.Visible = oUtente.CheckAbil(12, 3)
    End If

  End Sub

  Private Sub pLoadGroups()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select * From ATC_Gruppi Where Amministrazione = 0 Order By Descrizione", con)
    Dim dr As SqlDataReader
    con.Open()
    dr = com.ExecuteReader
    lstGruppi.DataSource = dr
    lstGruppi.DataTextField = "Descrizione"
    lstGruppi.DataValueField = "ID"
    lstGruppi.DataBind()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
    If lstGruppi.SelectedValue <> "" Then
      pClearPanel()
      pLoadGroup(lstGruppi.SelectedValue)
      pShowPanel()
    End If
  End Sub

  Private Sub pClearPanel()
    txtId.Text = ""
    txtDescription.Text = ""
    lstUtenti.Items.Clear()
    lstUtentiGruppo.Items.Clear()
  End Sub

  Private Sub pShowPanel()
    pnlGroup.Visible = True
    txtId.Visible = False
  End Sub

  Private Sub pLoadGroup(ByVal id As Integer)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select * From ATC_Gruppi Where Id = @1", con)
    Dim dr As SqlDataReader
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dr = com.ExecuteReader
    dr.Read()
    txtId.Text = dr.Item("ID")
    txtDescription.Text = dr.Item("Descrizione")
    dr.Close()
    con.Close()
    con.Dispose()

    pLoadUtenti(id)
    pLoadUtentiGruppo(id)

  End Sub

  Private Sub pLoadUtentiGruppo(ByVal id As Integer)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    con.Open()
    com = New SqlCommand("Select U.ID As Id, U.IDUser As Descrizione From ATC_Utenti U Left Join ATC_RelUtenteGruppo UG On U.ID = UG.IDUtente Left Join ATC_Gruppi G On UG.IdGruppo = G.ID Where UG.IDGruppo = @1", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dr = com.ExecuteReader
    lstUtentiGruppo.DataSource = dr
    lstUtentiGruppo.DataTextField = "Descrizione"
    lstUtentiGruppo.DataValueField = "ID"
    lstUtentiGruppo.DataBind()
    dr.Close()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub pLoadUtenti(Optional ByVal id As Integer = -1)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    con.Open()
    If id = -1 Then
      com = New SqlCommand("Select ID, IDUser From ATC_Utenti", con)
    Else
      com = New SqlCommand("Select ID, IDUser From ATC_Utenti U Where Not Exists(Select * From ATC_RelUtenteGruppo UG Where UG.IDUtente = U.ID And UG.IDGruppo = @1)", con)
      com.Parameters.Add("@1", SqlDbType.Int).Value = id
    End If
    dr = com.ExecuteReader
    lstUtenti.DataSource = dr
    lstUtenti.DataTextField = "IDUser"
    lstUtenti.DataValueField = "ID"
    lstUtenti.DataBind()
    dr.Close()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    pClearPanel()
    pLoadUtenti()
    pShowPanel()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Delete From ATC_Gruppi Where Id = @1", con)

    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = lstGruppi.SelectedValue
    com.ExecuteNonQuery()
    com = New SqlCommand("Delete From ATC_RelUtenteGruppo Where IdGruppo = @1", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = lstGruppi.SelectedValue
    com.ExecuteNonQuery()
    con.Close()
    con.Dispose()
    pLoadGroups()
  End Sub

  Private Sub btnRemoveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveUser.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Delete From ATC_RelUtenteGruppo Where IdUtente = @2 AND IdGruppo = @1", con)
    Dim i As Integer

    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = CInt(txtId.Text)
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstUtentiGruppo.Items.Count - 1
      If lstUtentiGruppo.Items(i).Selected Then
        com.Parameters("@2").Value = lstUtentiGruppo.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    pLoadUtenti(CInt(txtId.Text))
    pLoadUtentiGruppo(CInt(txtId.Text))
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("", con)
    Dim i As Integer
    Dim dr As SqlDataReader
    Dim Id As Integer

    If txtId.Text.Length = 0 Then
      pSaveGroup()
      If lblError.Visible Then Exit Sub
      com.CommandText = "Select Id From ATC_Gruppi Where Descrizione = @1"
      com.Parameters.Add("@1", SqlDbType.VarChar).Value = txtDescription.Text
      dr = com.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        Id = dr.Item("Id")
        txtId.Text = Id
        dr.Close()
      Else
        dr.Close()
        Exit Sub
      End If
    Else
      Id = txtId.Text
    End If
    con.Open()
    com.CommandText = "Insert Into ATC_RelUtenteGruppo(IdUtente, IDGruppo) Values(@2, @1)"
    com.Parameters.Add("@1", SqlDbType.Int).Value = Id
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstUtenti.Items.Count - 1
      If lstUtenti.Items(i).Selected Then
        com.Parameters("@2").Value = lstUtenti.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    pLoadUtenti(Id)
    pLoadUtentiGruppo(Id)
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    pSaveGroup()
    pnlGroup.Visible = False
    pLoadGroups()
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    pnlGroup.Visible = False
    pLoadGroups()
  End Sub

  Private Sub pSaveGroup()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("", con)

    lblError.Visible = False
    con.Open()
    If txtId.Text.Length > 0 Then
      com.CommandText = "Update ATC_Gruppi Set Descrizione = @2 Where Id = @1"
      com.Parameters.Add("@1", SqlDbType.Int).Value = CInt(txtId.Text)
    Else
      com.CommandText = "Select Count(*) From ATC_Gruppi Where Descrizione = @1"
      com.Parameters.Add("@1", SqlDbType.VarChar).Value = txtDescription.Text
      If com.ExecuteScalar > 0 Then
        lblError.Text = "ERRORE: impossibile salvare perché è già presente un gruppo con la stessa descrizione."
        lblError.Visible = True
        Exit Sub
      End If
      com.CommandText = "Insert Into ATC_Gruppi(Descrizione, Amministrazione) Values(@2, 0)"
    End If
    com.Parameters.Add("@2", SqlDbType.VarChar).Value = txtDescription.Text
    com.ExecuteNonQuery()
    con.Close()
    con.Dispose()
  End Sub

End Class
