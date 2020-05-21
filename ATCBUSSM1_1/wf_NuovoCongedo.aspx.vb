Public Class wf_NuovoCongedo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)

  End Sub
  Protected WithEvents lblAccertatore As System.Web.UI.WebControls.Label
  Protected WithEvents txtDalGiorno As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblAlGiorno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAlGiorno As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDalleOre As System.Web.UI.WebControls.Label
  Protected WithEvents txtDalleOre As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblAlleOre As System.Web.UI.WebControls.Label
  Protected WithEvents txtAlleOre As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSalva As System.Web.UI.WebControls.Button
  Protected WithEvents Table1 As System.Web.UI.WebControls.Table
  Protected WithEvents lblNote As System.Web.UI.WebControls.Label
  Protected WithEvents cvPermessoOrario As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents vsErrors As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents cvPermessoOrario2 As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvDalGiorno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvAlGiorno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDalAlGiorno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvPermessoOrario3 As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents btnAnnulla As System.Web.UI.WebControls.Button
  Protected WithEvents cvMinimoFerie As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents cvMassimoFerie As System.Web.UI.WebControls.CustomValidator
  Protected WithEvents lblFerie As System.Web.UI.WebControls.Label
  Protected WithEvents lblAnticipoFerie As System.Web.UI.WebControls.Label
  Protected WithEvents lblNomeAccertatore As System.Web.UI.WebControls.Label
  Protected WithEvents lblLabelFerie As System.Web.UI.WebControls.Label
  Protected WithEvents lblLabelAnticipoFerie As System.Web.UI.WebControls.Label
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents dgRisultati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblDa As System.Web.UI.WebControls.Label
  Protected WithEvents txtDa As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblA As System.Web.UI.WebControls.Label
  Protected WithEvents txtA As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSearch As System.Web.UI.WebControls.Button

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    Dim m_intUserID As Integer
    Dim dr As SqlClient.SqlDataReader
    Try
      'FT - ??? - Non so se fare il controllo a questo punto che l'utente sia un accertatore oppure se abilitare questo modulo solo per gli accertatori
      m_intUserID = atcbSession.Get_UserID(Me.Session)
      btnAnnulla.Attributes.Add("onclick", "return confirm('Sei sicuro che vuoi annullare questa richiesta?');")
      'Caricare il numero di ferie disponibili
      Dim com As New SqlClient.SqlCommand("Select FerieDisponibili, FerieAnticipateDisponibili, AnnoFerieAnticipate From Accertatori where idAccertatore = @IdAccertatore", con)
      com.Parameters.Add("@IdAccertatore", SqlDbType.Int).Value = m_intUserID
      con.open()
      dr = com.ExecuteReader()
      Do While dr.Read
        lblFerie.Text = dr.Item("FerieDisponibili")
        If dr.Item("AnnoFerieAnticipate") = Now.Year Then
          lblAnticipoFerie.Text = dr.Item("FerieAnticipateDisponibili")
        Else
          Dim com2 As New SqlClient.SqlCommand("Update Accertatori Set FerieAnticipateDisponibili = (Select GiorniAnticipabili From ImpostazioniModalitaRichiestaCongedi) Where IdAccertatore = @IdAccertatore", con)
          com2.Parameters.Add("@IdAccertatore", SqlDbType.Int).Value = m_intUserID
          con.Open()
          com2.ExecuteNonQuery()
          con.Close()
          'FT - ??? - Caricare da database
          lblAnticipoFerie.Text = 10
        End If
      Loop
      con.Close()
      'Caricare il numero di ferieanticipabili
    Catch ex As Exception
      Response.Clear()
      Response.Write("Errore durante il caricamento della pagina:<br>" & ex.Source & ": " & ex.Message)
      Response.End()
    End Try
  End Sub

  Private Sub cvPermessoOrario_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvPermessoOrario.ServerValidate
    args.IsValid = (txtDalGiorno.Text = txtAlGiorno.Text) And (txtDalleOre.Text.Length > 0 Or txtAlleOre.Text.Length > 0)
  End Sub

  Private Sub cvPermessoOrario2_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvPermessoOrario2.ServerValidate
    args.IsValid = txtAlleOre.Text.Length > 0 And txtDalleOre.Text.Length > 0
  End Sub

  Private Sub cvMinimoFerie_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvMinimoFerie.ServerValidate
    If IsDate(txtAlGiorno.Text) And IsDate(txtDalGiorno.Text) Then
      args.IsValid = CDate(txtAlGiorno.Text).Subtract(txtDalGiorno.Text).Days >= 5
    Else
      args.IsValid = False
    End If
  End Sub

  Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
    If Me.IsValid Then

    End If
  End Sub

  Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
    Response.Redirect("wf_congedi.aspx")
  End Sub

  Private Sub cvMassimoFerie_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvMassimoFerie.ServerValidate

  End Sub
End Class
