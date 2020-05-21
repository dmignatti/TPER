Public Class wf_dativeicoloexit
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblTarga As System.Web.UI.WebControls.Label
  Protected WithEvents lblTipo As System.Web.UI.WebControls.Label
  Protected WithEvents lblMarca As System.Web.UI.WebControls.Label
  Protected WithEvents txtPesoPC As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataIngresso As System.Web.UI.WebControls.Label
  Protected WithEvents ddlExitType As System.Web.UI.WebControls.DropDownList
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents btnGo As System.Web.UI.WebControls.Button
  Protected WithEvents txtDataUscita As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtOraUscita As System.Web.UI.WebControls.TextBox
  Protected WithEvents tblDenuncia As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents txtNumeroDenuncia As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlCorpoDenuncia As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtOraDenuncia As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvNumeroDenuncia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvCorpoDenuncia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvDataDenuncia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvOraDenuncia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtStazioneDenuncia As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvStazioneDenuncia As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents txtDataDenuncia As System.Web.UI.WebControls.TextBox
  Protected WithEvents revDataDenuncia As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents revOraDenuncia As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents ddlUser As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtNoteUscita As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlPagamento As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtPK As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvUser As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvPagamento As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvPK As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents tblQuietanza As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents tblDatiUscita As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents rfvDataUscita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvOraUscita As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents rfvExitType As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDataUscita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents revOraUscita As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents tblDatiVeicolo As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents rfvPesoPC As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revPesoPC As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblModello As System.Web.UI.WebControls.Label
  Protected WithEvents tblOperatore As System.Web.UI.HtmlControls.HtmlTable
  Protected WithEvents tblPagamento As System.Web.UI.HtmlControls.HtmlTable

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private m_intVehicleID As Integer
  Private m_strVehicleState As String
  Private m_vd As supVehicleDPT

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    hlkBack.NavigateUrl = "wf_viewdeposito1.aspx?" & _
                          atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                          atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)

    m_intVehicleID = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleID))
    m_strVehicleState = Request.QueryString(atcbConstant.QS_VehicleState)

    Try
      m_vd = New supVehicleDPT(m_intVehicleID, m_strVehicleState)
      If IsPostBack Then

      Else
        lblDataIngresso.Text = supFunction.FormatDate(m_vd.DataIngresso, supFunction.supDateFormatEnum.dfeDateTime)
        lblTarga.Text = m_vd.Targa
        lblTipo.Text = m_vd.Tipo
        lblMarca.Text = m_vd.Marca
        lblModello.Text = m_vd.Modello
        txtPesoPC.Text = supFunction.GUIFormatPesoPC(m_vd.PesoPC)
        FillDdlExitType(m_vd.Stato)
        SetTableVisible(ddlExitType.SelectedValue)
        FillDdlCorpoDenuncia()
        supFunction.FillDdlGDATCUser(ddlUser, False, True)
        supFunction.FillDdlGDATCPagamento(ddlPagamento, True)
      End If
    Catch ex As Exception
      lblError.Text = ex.Message
      tblDatiVeicolo.Visible = False
      tblDatiUscita.Visible = False
      tblDenuncia.Visible = False
      tblQuietanza.Visible = False
      tblOperatore.Visible = False
      tblPagamento.Visible = False
      btnGo.Visible = False
    End Try

  End Sub

  Private Sub FillDdlExitType(ByVal strStato As String)

    Dim li As ListItem

    ddlExitType.Items.Clear()

    If (strStato = "DPT") Then
      li = New ListItem("Ritiro regolare dietro pagamento", "RTR")
      ddlExitType.Items.Add(li)
      li = New ListItem("Ritiro regolare dietro pagamento postdatato", "RTP")
      ddlExitType.Items.Add(li)
      li = New ListItem("Ritiro di veicolo appartenente ad invalido", "HND")
      ddlExitType.Items.Add(li)
      li = New ListItem("Ritiro di veicolo appartenente ad istituzioni", "RVI")
      ddlExitType.Items.Add(li)
      li = New ListItem("Ritiro di veicolo risultato rubato", "RBT")
      ddlExitType.Items.Add(li)
      li = New ListItem("Veicolo sottratto da deposito", "RBD")
      ddlExitType.Items.Add(li)
    ElseIf (strStato = "DSV") Then
      li = New ListItem("Ritiro di veicolo senza onere", "RSO")
      ddlExitType.Items.Add(li)
      li = New ListItem("Ritiro di veicolo risultato rubato", "RBT")
      ddlExitType.Items.Add(li)
      li = New ListItem("Veicolo sottratto da deposito", "RBD")
      ddlExitType.Items.Add(li)
    Else
      Throw New Exception("Il veicolo non può uscire da deposito. Stato incompleto o inesistente.")
    End If

  End Sub

  Private Sub FillDdlCorpoDenuncia()

    ddlCorpoDenuncia.Items.Clear()
    ddlCorpoDenuncia.Items.Add("Carabinieri")
    ddlCorpoDenuncia.Items.Add("Polizia")
    ddlCorpoDenuncia.SelectedIndex = 0

  End Sub

  Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

    Dim strStato As String
    Dim strUrl As String
    Dim strQueryString As String

    Try
      strStato = ddlExitType.SelectedValue
      StoreData(strStato)
      strQueryString = atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                       atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode)
      Select Case strStato
        Case "HND"
          strUrl = "wf_exitvhnd.aspx"
        Case "RBD"
          strUrl = "wf_exitvrbd.aspx"
        Case "RBT"
          strUrl = "wf_exitvrbt.aspx"
        Case "RSO"
          strUrl = "wf_exitvrso.aspx"
        Case "RTR", "RTP"
          strUrl = "wf_exitvrtr.aspx"
        Case "RVI"
          strUrl = "wf_exitvrvi.aspx"
      End Select
      Response.Redirect(strUrl & "?" & strQueryString)
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub ddlExitType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlExitType.SelectedIndexChanged

    If (ddlExitType.SelectedIndex >= 0) Then
      SetTableVisible(ddlExitType.SelectedValue)
    End If

  End Sub

  Private Sub SetTableVisible(ByVal strNewState As String)

    tblDatiVeicolo.Visible = True
    tblDatiUscita.Visible = True
    Select Case strNewState
      Case "HND", "RSO", "RVI"
        tblQuietanza.Visible = True
        tblOperatore.Visible = True
        tblPagamento.Visible = False
        tblDenuncia.Visible = False
      Case "RBD"
        tblQuietanza.Visible = False
        tblOperatore.Visible = False
        tblPagamento.Visible = False
        tblDenuncia.Visible = True
      Case "RBT"
        tblQuietanza.Visible = False
        tblOperatore.Visible = False
        tblPagamento.Visible = False
        tblDenuncia.Visible = False
      Case "RTP"
        tblQuietanza.Visible = True
        tblOperatore.Visible = True
        tblPagamento.Visible = True
        tblDenuncia.Visible = True
      Case "RTR"
        tblQuietanza.Visible = True
        tblOperatore.Visible = True
        tblPagamento.Visible = True
        tblDenuncia.Visible = False
    End Select

  End Sub

  Private Sub StoreData(ByVal strNewState As String)

    Dim objVehicle As Object

    Select Case strNewState
      Case "HND"
        objVehicle = New supVehicleHND(m_vd.FK_Rimz, m_vd.Stato)
      Case "RBD"
        objVehicle = New supVehicleRBD(m_vd.FK_Rimz, m_vd.Stato)
      Case "RBT"
        objVehicle = New supVehicleRBT(m_vd.FK_Rimz, m_vd.Stato)
      Case "RSO"
        objVehicle = New supVehicleRSO(m_vd.FK_Rimz, m_vd.Stato)
      Case "RTR", "RTP"
        objVehicle = New supVehicleRTR(m_vd.FK_Rimz, m_vd.Stato)
        If (ddlPagamento.SelectedIndex = 0) Then
          Throw New Exception("E' necessario specificare il tipo di pagamento")
        Else
          objVehicle.ModalitaPagamento = ddlPagamento.SelectedItem.Text
        End If
      Case "RVI"
          objVehicle = New supVehicleRVI(m_vd.FK_Rimz, m_vd.Stato)
    End Select

    If ((strNewState <> "RBD") And (strNewState <> "RBT")) Then
      objVehicle.PK = System.Convert.ToInt32(txtPK.Text.Trim)
      If (ddlUser.SelectedIndex = 0) Then
        Throw New Exception("E' necessario specificare l'operatore di depositeria")
      Else
        objVehicle.FK_User = System.Convert.ToInt32(ddlUser.SelectedValue)
        objVehicle.UserNominativo = Mid(ddlUser.SelectedItem.Text, 1, InStr(1, ddlUser.SelectedItem.Text, "(") - 1).Trim
        objVehicle.UserMatricola = Mid(StrReverse(ddlUser.SelectedItem.Text), 2, InStr(1, StrReverse(ddlUser.SelectedItem.Text), "(") - 2).Trim
      End If
    End If

    If ((strNewState = "RBD") Or (strNewState = "RTP")) Then
      objVehicle.CorpoDenuncia = ddlCorpoDenuncia.SelectedItem.Text.Trim
      objVehicle.NumeroDenuncia = txtNumeroDenuncia.Text.Trim
      objVehicle.DataDenuncia = supFunction.DecodeDate(txtDataDenuncia.Text.Trim, txtOraDenuncia.Text.Trim)
      objVehicle.StazioneDenuncia = txtStazioneDenuncia.Text.Trim
    End If

    objVehicle.PesoPC = DecodePesoPC()
    objVehicle.DataUscita = supFunction.DecodeDate(txtDataUscita.Text.Trim, txtOraUscita.Text.Trim)
    objVehicle.NoteUscita = txtNoteUscita.Text.Trim

    Session.Add("Vehicle", objVehicle)

  End Sub

  Private Function DecodePesoPC() As Double

    Dim dblPesoPC As Double = System.Convert.ToDouble(Mid(txtPesoPC.Text.Trim, 1, 2))
    dblPesoPC = dblPesoPC + System.Convert.ToDouble(Mid(txtPesoPC.Text.Trim, 4, 2)) / 100
    Return dblPesoPC

  End Function

End Class
