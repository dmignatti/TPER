Public Class wf_insertinfrazione
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents txtCodice As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDateBegin As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateEnd As System.Web.UI.WebControls.Label
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents txtArticolo As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
  Protected WithEvents txtImporto As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label

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

    Dim strDateBegin, strDateEnd As String

    Try
      strDateBegin = Request.QueryString(atcbConstant.QS_DateBegin)
      strDateEnd = Request.QueryString(atcbConstant.QS_DateEnd)
      lblDateBegin.Text = strDateBegin
      lblDateEnd.Text = strDateEnd
      If (DateTime.Now < supFunction.DecodeDate(strDateBegin)) Then
        lblMessage.Text = "Importante: Non si potrà modificare i dati immessi quando il tariffario sarà in vigore."
      Else
        lblMessage.Text = "Importante: Non si potrà modificare i dati immessi, poiché il tariffario è in vigore."
      End If
      lblError.Text = ""
      btnSave.Visible = True
    Catch ex As Exception
      lblError.Text = "Errore: " & ex.Message
      btnSave.Visible = False
    End Try

    hlkBack.NavigateUrl = "wf_tariffarioinfrazioni.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Dim infr As New supInfrazioneCdS(supFunction.DecodeDate(lblDateBegin.Text), supFunction.DecodeDate(lblDateEnd.Text))
    Dim tr As New supTransaction

    If CheckUserData() Then
      Try
        infr.Codice = txtCodice.Text
        infr.Articolo = txtArticolo.Text
        infr.Desc = txtDesc.Text
        infr.Importo = supFunction.ToMoney_Euro(txtImporto.Text.Trim)
        tr.SqlCommands.Add(infr.SqlInsertSingle)
        If tr.Execute() Then
          Response.Redirect("wf_tariffarioinfrazioni.aspx?" & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID))
        Else
          lblError.Text = tr.ErrorMessage
        End If
      Catch ex As Exception
        lblError.Text = "Errore nel salvataggio dei dati"
      End Try
    End If

  End Sub

  Private Function CheckUserData() As Boolean

    Dim RC As Boolean

    RC = False
    If (txtCodice.Text.Length > 10) Then
      lblError.Text = "La lunghezza massima di 'Codice' è 10 caratteri"
    Else
      If (txtArticolo.Text.Length > 10) Then
        lblError.Text = "La lunghezza massima di 'Articolo' è 10 caratteri"
      Else
        If (txtDesc.Text.Length > 255) Then
          lblError.Text = "La lunghezza massima di 'Descrizione' è 255 caratteri"
        Else
          Try
            If supFunction.IsMoney_Euro(txtImporto.Text) Then
              RC = True
            Else
              lblError.Text = "Il campo 'Importo' non è valido." & Chr(13) & Chr(10) & _
                              "Digitare soltanto cifre ed una virgola."
            End If
          Catch ex As Exception
            lblError.Text = ex.Message
          End Try
        End If
      End If
    End If

    Return RC

  End Function

End Class
