Public Class wf_exitvrvi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tblDamage As System.Web.UI.WebControls.Table
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Dim m_vrvi As supVehicleRVI

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    hlkBack.NavigateUrl = "wf_viewdeposito1.aspx?" & _
                          atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                          atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

    Try
      m_vrvi = Session("Vehicle")
      supTblDamages.FillTable(tblDamage, m_vrvi.DanniScarico)
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      StoreData()
      m_vrvi.Save()
      Response.Redirect("wf_viewdeposito1.aspx?" & _
                        atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                        atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode))
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub StoreData()
    m_vrvi.DanniRitiro = supTblDamages.GetDamageString(tblDamage)
  End Sub

End Class
