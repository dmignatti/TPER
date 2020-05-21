Imports System.Data.SqlClient
Public Class wf_questionario
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents btnConferma As System.Web.UI.WebControls.Button
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents pnlMessage As System.Web.UI.WebControls.Panel
  Protected WithEvents lblDomanda1 As System.Web.UI.WebControls.Label
  Protected WithEvents RB1aAbbastanza As System.Web.UI.WebControls.RadioButton
  Protected WithEvents RBL1a As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda1b As System.Web.UI.WebControls.Label
  Protected WithEvents RBL1b As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda1c As System.Web.UI.WebControls.Label
  Protected WithEvents RBL1c As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda1a As System.Web.UI.WebControls.Label
  Protected WithEvents lblCommenti As System.Web.UI.WebControls.Label
  Protected WithEvents txtCommenti As System.Web.UI.WebControls.TextBox
  Protected WithEvents RV1a As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RV1b As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RV1c As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblDomanda2 As System.Web.UI.WebControls.Label
  Protected WithEvents lblDomanda2a As System.Web.UI.WebControls.Label
  Protected WithEvents RV2a As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RBL2a As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda2b As System.Web.UI.WebControls.Label
  Protected WithEvents RV2b As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RBL2b As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda2c As System.Web.UI.WebControls.Label
  Protected WithEvents RV2c As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RBL2c As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents lblDomanda3 As System.Web.UI.WebControls.Label
  Protected WithEvents RV3 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RBL3 As System.Web.UI.WebControls.RadioButtonList
  Protected WithEvents VSummary As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents Table01 As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents domande As System.Web.UI.WebControls.Panel
  Protected WithEvents LBL1 As System.Web.UI.WebControls.Label
  Protected WithEvents Domandeq As System.Web.UI.WebControls.Panel
  Protected WithEvents titolo1 As System.Web.UI.WebControls.Label
  Protected WithEvents titolo2 As System.Web.UI.WebControls.Label

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
  Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
 
    If Not IsPostBack Then
      If fnc.Questionario_Compilato(oUtente.IDUser, Session("IPAddress"), oUtente.TipoUtente) Then
        pnlMessage.Visible = True
        domande.Visible = False
      Else
        pnlMessage.Visible = False
        domande.Visible = True
      End If
      fnc.ScriviLog(oUtente.IDUser, "wf_questionario.aspx", "Pagina iniziale", Session("IPAddress"))
    End If

  End Sub

  Private Function QuestionarioCompilato() As Boolean
    Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim cmd As New SqlCommand
    Dim res As Boolean
    res = False

    Try
      oConn.Open()
      cmd.Connection = oConn
      cmd.CommandText = "SELECT count(*) as n " & _
      " FROM Accertatori_Questionario where Matricola = '" & oUtente.IDUser & "'"
      Dim n As Integer
      n = Convert.ToInt32(cmd.ExecuteScalar)
      If n > 0 Then
        res = True
      End If
      cmd.Dispose()
      oConn.Close()
      oConn.Dispose()

    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_questionario.aspx", "Errore nel controllo compilazione: " & ex.Message, Session("IPAddress"))
    End Try
    QuestionarioCompilato = res

  End Function

  Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click

    If Me.IsValid Then
      InviaQuestionario()
    End If

  End Sub

  Private Sub InviaQuestionario()
    Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim cmd As New SqlCommand
    Dim Matricola, Risposta1a, Risposta1b, Risposta1c, Risposta2a, Risposta2b, Risposta2c, Risposta3 As String
    Try

      Matricola = oUtente.IDUser
      Risposta1a = RBL1a.SelectedValue
      Risposta1b = RBL1b.SelectedValue
      Risposta1c = RBL1c.SelectedValue
      Risposta2a = RBL2a.SelectedValue
      Risposta2b = RBL2b.SelectedValue
      Risposta2c = RBL2c.SelectedValue
      Risposta3 = RBL3.SelectedValue
      'Commenti = txtCommenti.Text.Replace("'", "''")

      oConn.Open()
      cmd.Connection = oConn
      cmd.CommandText = "INSERT INTO Accertatori_Questionario(Matricola, Risposta1a, Risposta1b, Risposta1c, Risposta2a, Risposta2b, Risposta2c, Risposta3) " & _
      " VALUES('" & Matricola & "','" & Risposta1a & "' ,'" & Risposta1b & "' ,'" & Risposta1c & "' ,'" & Risposta2a & "' ,'" & Risposta2b & "' ,'" & Risposta2c & "' ,'" & Risposta3 & "'  )"
      cmd.ExecuteNonQuery()
      cmd.Dispose()
      oConn.Close()
      oConn.Dispose()
      Response.Redirect("wf_questionario.aspx")
      fnc.ScriviLog(oUtente.IDUser, "wf_questionario.aspx", "Terminata la compilazione del questionario con successo", Session("IPAddress"))

    Catch ex As Exception
      fnc.ScriviLog(oUtente.IDUser, "wf_questionario.aspx", "Errore: " & ex.Message, Session("IPAddress"))
    End Try

  End Sub
End Class
