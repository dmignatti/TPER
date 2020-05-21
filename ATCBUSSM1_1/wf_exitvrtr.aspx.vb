Public Class wf_exitvrtr
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tblDamage As System.Web.UI.WebControls.Table
  Protected WithEvents txtRitrCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtRitrNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents revRitrDataNascita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtPropCognome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropNome As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropLuogoNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents revPropDataNascita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtPropLuogoResidenza As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtPropIndirizzo As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtNumPatente As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtRilPatente As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlTipoDocumento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtNumDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtRilDocumento As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblChiamataDesc As System.Web.UI.WebControls.Label
  Protected WithEvents lblChiamataImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblChiamataImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblOpCoRimzDesc As System.Web.UI.WebControls.Label
  Protected WithEvents lblOpCoRimzImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblOpCoRimzImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblTrasportoDesc As System.Web.UI.WebControls.Label
  Protected WithEvents lblTrasportoImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblTrasportoImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblBolloImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustMGImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustMGImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustPGImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustPGImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustSGImpUnit As System.Web.UI.WebControls.Label
  Protected WithEvents lblCustSGImporto As System.Web.UI.WebControls.Label
  Protected WithEvents supExitTableCell As System.Web.UI.WebControls.Label
  Protected WithEvents lblTotRimozione As System.Web.UI.WebControls.Label
  Protected WithEvents lblBolloImporto As System.Web.UI.WebControls.Label
  Protected WithEvents lblTotRimozioneBollo As System.Web.UI.WebControls.Label
  Protected WithEvents tblSanzioni As System.Web.UI.WebControls.Table
  Protected WithEvents lblTotSanzioni As System.Web.UI.WebControls.Label
  Protected WithEvents chkSanzioni As System.Web.UI.WebControls.CheckBox
  Protected WithEvents lblTotCustodia As System.Web.UI.WebControls.Label
  Protected WithEvents lblTotRimozioneCustodia As System.Web.UI.WebControls.Label
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents rfvRitrCognome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvRitrNome As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrLuogoNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrLuogoNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrDataNascita As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrDataNascita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrLuogoResidenza As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrLuogoResidenza As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtRitrIndirizzo As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvRitrIndirizzo As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents tblQCdSData As System.Web.UI.WebControls.Table
  Protected WithEvents tblQuietanzeCdS As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents ddlPagamento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents rfvPagamento As System.Web.UI.WebControls.RequiredFieldValidator

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Dim m_vrtr As supVehicleRTR

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    hlkBack.NavigateUrl = "wf_viewdeposito1.aspx?" & _
                          atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                          atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

    Try
      m_vrtr = Session("Vehicle")
      m_vrtr.FetchRates()
      supTblDamages.FillTable(tblDamage, m_vrtr.DanniScarico)
      Dim tblVerbali As New supTblVerbaliCdS(m_vrtr.FK_Rimz)
      tblVerbali.FillTable(tblSanzioni)
      lblTotSanzioni.Text = supFunction.FormatEuro(tblVerbali.Total, False)
      If IsPostBack() Then
        tblQuietanzeCdS.Visible = chkSanzioni.Checked
        If tblQuietanzeCdS.Visible Then
          If (m_vrtr.QuietanzeCdS Is Nothing) Then
            supFunction.FillDdlGDATCPagamento(ddlPagamento, False)
            Dim qs As New supQuietanzeCdS(m_vrtr.FK_Rimz, m_vrtr.FK_User, m_vrtr.UserMatricola, m_vrtr.UserNominativo, m_vrtr.Targa, m_vrtr.DataUscita)
            m_vrtr.QuietanzeCdS = qs
          End If
          m_vrtr.QuietanzeCdS.SetTable(tblQCdSData)
        End If
      Else
        chkSanzioni.Checked = False
        tblQuietanzeCdS.Visible = False
        supFunction.FillDdlGDATCTipoDocumento(ddlTipoDocumento, True)
        lblChiamataDesc.Text = m_vrtr.TarfChiamata
        lblChiamataImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitChiamata, False)
        lblChiamataImporto.Text = supFunction.FormatEuro(m_vrtr.ImpChiamata, False)
        lblOpCoRimzDesc.Text = m_vrtr.TarfRimozione
        lblOpCoRimzImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitRimozione, False)
        lblOpCoRimzImporto.Text = supFunction.FormatEuro(m_vrtr.ImpRimozione, False)
        lblTrasportoDesc.Text = m_vrtr.TarfTrasporto
        lblTrasportoImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitTrasporto, False)
        lblTrasportoImporto.Text = supFunction.FormatEuro(m_vrtr.ImpTrasporto, False)
        lblTotRimozione.Text = supFunction.FormatEuro(m_vrtr.TotRimozione, False)
        lblBolloImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitBollo, False)
        lblBolloImporto.Text = supFunction.FormatEuro(m_vrtr.ImpBollo, False)
        lblTotRimozioneBollo.Text = supFunction.FormatEuro(m_vrtr.TotRimozioneBollo, False)
        lblCustMGImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitCustodia12Ore, False)
        lblCustMGImporto.Text = supFunction.FormatEuro(m_vrtr.ImpCustodia12Ore, False)
        lblCustPGImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitCustodiaPG, False)
        lblCustPGImporto.Text = supFunction.FormatEuro(m_vrtr.ImpCustodiaPG, False)
        lblCustSGImpUnit.Text = supFunction.FormatEuro(m_vrtr.ImpUnitCustodiaSG, False)
        lblCustSGImporto.Text = supFunction.FormatEuro(m_vrtr.ImpCustodiaSG, False)
        lblTotCustodia.Text = supFunction.FormatEuro(m_vrtr.TotCustodia, False)
        lblTotRimozioneCustodia.Text = supFunction.FormatEuro(m_vrtr.Totale, False)
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Try
      StoreData()
      m_vrtr.Save(chkSanzioni.Checked)
      Response.Redirect("wf_viewdeposito1.aspx?" & _
                        atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                        atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode))
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub StoreData()

    m_vrtr.Ritr_Cognome = txtRitrCognome.Text.Trim
    m_vrtr.Ritr_Nome = txtRitrNome.Text.Trim
    m_vrtr.Ritr_LuogoNascita = txtRitrLuogoNascita.Text.Trim
    m_vrtr.Ritr_DataNascita = supFunction.DecodeDate(txtRitrDataNascita.Text.Trim)
    m_vrtr.Ritr_LuogoResidenza = txtRitrLuogoResidenza.Text.Trim
    m_vrtr.Ritr_Indirizzo = txtRitrIndirizzo.Text.Trim

    If (txtPropCognome.Text.Trim <> "") Then
      m_vrtr.Prop_Cognome = txtPropCognome.Text.Trim
    End If
    If (txtPropNome.Text.Trim <> "") Then
      m_vrtr.Prop_Nome = txtPropNome.Text.Trim
    End If
    If (txtPropLuogoNascita.Text.Trim <> "") Then
      m_vrtr.Prop_LuogoNascita = txtPropLuogoNascita.Text.Trim
    End If
    If (txtPropDataNascita.Text.Trim <> "") Then
      m_vrtr.Prop_DataNascita = supFunction.DecodeDate(txtPropDataNascita.Text.Trim)
    End If
    If (txtPropLuogoResidenza.Text.Trim <> "") Then
      m_vrtr.Prop_LuogoResidenza = txtPropLuogoResidenza.Text.Trim
    End If
    If (txtPropIndirizzo.Text.Trim <> "") Then
      m_vrtr.Prop_Indirizzo = txtPropIndirizzo.Text.Trim
    End If

    If ((txtNumPatente.Text.Trim <> "") And (txtRilPatente.Text.Trim <> "")) Then
      m_vrtr.NumeroPatente = txtNumPatente.Text.Trim
      m_vrtr.RilascioPatente = txtRilPatente.Text.Trim
    Else
      If ((ddlTipoDocumento.SelectedIndex > 0) And (txtNumDocumento.Text.Trim <> "") And (txtRilDocumento.Text.Trim <> "")) Then
        m_vrtr.TipoDocumento = ddlTipoDocumento.SelectedItem.Text.Trim
        m_vrtr.NumeroDocumento = txtNumDocumento.Text.Trim
        m_vrtr.RilascioDocumento = txtRilDocumento.Text.Trim
      Else
        Throw New Exception("E' necessario specificare i dati della patente o di altro documento")
      End If
    End If

    m_vrtr.DanniRitiro = supTblDamages.GetDamageString(tblDamage)

    If tblQuietanzeCdS.Visible Then
      If Not (m_vrtr.QuietanzeCdS Is Nothing) Then
        m_vrtr.QuietanzeCdS.GetGUIData(tblQCdSData, ddlPagamento.SelectedItem.Value, ddlPagamento.SelectedItem.Text, m_vrtr.Ritr_Cognome & " " & m_vrtr.Ritr_Nome)
      End If
    End If

  End Sub

End Class
