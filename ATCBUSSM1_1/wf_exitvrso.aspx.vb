Public Class wf_exitvrso
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents txtRitrCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrLuogoNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrLuogoNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents revRitrDataNascita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents rfvRitrDataNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrLuogoResidenza As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrLuogoResidenza As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrIndirizzo As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrIndirizzo As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtNumPatente As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtRilPatente As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlTipoDocumento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtNumDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtRilDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropLuogoNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents revPropDataNascita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtPropLuogoResidenza As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropIndirizzo As System.Web.UI.WebControls.TextBox
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

  Dim m_vrso As supVehicleRSO

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    hlkBack.NavigateUrl = "wf_viewdeposito1.aspx?" & _
                          atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                          atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

    Try
      m_vrso = Session("Vehicle")
      supTblDamages.FillTable(tblDamage, m_vrso.DanniScarico)
      If Not IsPostBack() Then
        supFunction.FillDdlGDATCTipoDocumento(ddlTipoDocumento, True)
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      StoreData()
      m_vrso.Save()
      Response.Redirect("wf_viewdeposito1.aspx?" & _
                        atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                        atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode))
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub StoreData()

    m_vrso.Ritr_Cognome = txtRitrCognome.Text.Trim
    m_vrso.Ritr_Nome = txtRitrNome.Text.Trim
    m_vrso.Ritr_LuogoNascita = txtRitrLuogoNascita.Text.Trim
    m_vrso.Ritr_DataNascita = supFunction.DecodeDate(txtRitrDataNascita.Text.Trim)
    m_vrso.Ritr_LuogoResidenza = txtRitrLuogoResidenza.Text.Trim
    m_vrso.Ritr_Indirizzo = txtRitrIndirizzo.Text.Trim

    If (txtPropCognome.Text.Trim <> "") Then
      m_vrso.Prop_Cognome = txtPropCognome.Text.Trim
    End If
    If (txtPropNome.Text.Trim <> "") Then
      m_vrso.Prop_Nome = txtPropNome.Text.Trim
    End If
    If (txtPropLuogoNascita.Text.Trim <> "") Then
      m_vrso.Prop_LuogoNascita = txtPropLuogoNascita.Text.Trim
    End If
    If (txtPropDataNascita.Text.Trim <> "") Then
      m_vrso.Prop_DataNascita = supFunction.DecodeDate(txtPropDataNascita.Text.Trim)
    End If
    If (txtPropLuogoResidenza.Text.Trim <> "") Then
      m_vrso.Prop_LuogoResidenza = txtPropLuogoResidenza.Text.Trim
    End If
    If (txtPropIndirizzo.Text.Trim <> "") Then
      m_vrso.Prop_Indirizzo = txtPropIndirizzo.Text.Trim
    End If

    If ((txtNumPatente.Text.Trim <> "") And (txtRilPatente.Text.Trim <> "")) Then
      m_vrso.NumeroPatente = txtNumPatente.Text.Trim
      m_vrso.RilascioPatente = txtRilPatente.Text.Trim
    Else
      If ((ddlTipoDocumento.SelectedIndex > 0) And (txtNumDocumento.Text.Trim <> "") And (txtRilDocumento.Text.Trim <> "")) Then
        m_vrso.TipoDocumento = ddlTipoDocumento.SelectedItem.Text.Trim
        m_vrso.NumeroDocumento = txtNumDocumento.Text.Trim
        m_vrso.RilascioDocumento = txtRilDocumento.Text.Trim
      Else
        Throw New Exception("E' necessario specificare i dati della patente o di altro documento")
      End If
    End If

    m_vrso.DanniRitiro = supTblDamages.GetDamageString(tblDamage)

  End Sub

End Class
