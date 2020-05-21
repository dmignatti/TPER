Public Class wf_deletevehicle
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
  Protected WithEvents lblPlate As System.Web.UI.WebControls.Label
  Protected WithEvents txtNotes As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnExecute As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents lblError As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Dim m_intUserID As Integer
  Dim m_intVehicleID As Integer
  Dim m_strVehiclePlate As String
  Dim m_strVehicleState As String

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      m_intUserID = atcbSession.Get_UserID(Me.Session)
      m_intVehicleID = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleID))
      m_strVehiclePlate = Request.QueryString(atcbConstant.QS_VehiclePlate)
      m_strVehicleState = Request.QueryString(atcbConstant.QS_VehicleState)
      lblPlate.Text = m_strVehiclePlate
      hlkBack.NavigateUrl = "wf_viewdeposito.aspx?" & _
                            atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                            atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)
      If (m_strVehicleState = "DEL") Then
        lblTitle.Text = "Reintegro veicoli cancellati"
        btnExecute.Text = "Reintegra"
        btnExecute.Attributes.Add("onclick", "return(confirm('Sei sicuro di voler reintegrare il veicolo?'));")
      Else
        lblTitle.Text = "Cancellazione veicoli"
        btnExecute.Text = "Cancella"
        btnExecute.Attributes.Add("onclick", "return(confirm('Sei sicuro di voler cancellare il veicolo?'));")
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click

    Dim RC As Boolean = False

    If (m_strVehicleState = "DEL") Then
      RC = atcbWUser.RecoverDeletedVehicle(m_intUserID, m_intVehicleID, m_strVehiclePlate, txtNotes.Text.Trim)
    Else
      RC = atcbWUser.DeleteVehicle(m_intUserID, m_intVehicleID, m_strVehiclePlate, txtNotes.Text.Trim)
    End If
    If RC Then
      Response.Redirect("wf_viewdeposito.aspx?" & _
                        atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                        atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode))
    Else
      lblError.Text = "Errore nel salvataggio dei dati"
    End If

  End Sub

End Class
