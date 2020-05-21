Imports System.Data.SqlClient

Public Class wf_marchemodelli
  Inherits System.Web.UI.Page

  Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm

  Protected WithEvents ddlShow As System.Web.UI.WebControls.DropDownList
  Protected WithEvents grd As System.Web.UI.WebControls.DataGrid
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtDateEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateEnd As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateEnd As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents lblError As System.Web.UI.WebControls.Label

  Private details As New DataSet

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

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

    Dim dtmDateBegin, dtmDateEnd As DateTime

    Try
      If IsPostBack Then
        dtmDateBegin = supFunction.DecodeDate(txtDateBegin.Text)
        dtmDateEnd = supFunction.DecodeDate(txtDateEnd.Text)
      Else
        dtmDateBegin = DateTime.Today.AddDays(-7)
        dtmDateEnd = DateTime.Today
        ' Valorizza i controlli.
        txtDateBegin.Text = supFunction.FormatDate(dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard)
        txtDateEnd.Text = supFunction.FormatDate(dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)
        Fill_ddlShow()
      End If
      Fill_grd(dtmDateBegin, dtmDateEnd)
    Catch ex As Exception
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Sub saltapagina(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs)
    grd.CurrentPageIndex = e.NewPageIndex
    grd.DataBind()
  End Sub

  Sub PagerButtonClick(ByVal sender As Object, ByVal e As EventArgs)
    'used by external paging UI
    Dim arg As String = sender.CommandArgument

    Select Case arg
      Case "Successiva"
        If (grd.CurrentPageIndex < (grd.PageCount - 1)) Then
          grd.CurrentPageIndex += 1
        End If
      Case "Precedente"
        If (grd.CurrentPageIndex > 0) Then
          grd.CurrentPageIndex -= 1
        End If
    End Select
    grd.DataBind()
    Page.DataBind()
  End Sub

  Private Sub Fill_ddlShow()

    ddlShow.Items.Clear()
    ddlShow.Items.Add("Nuove marche")
    ddlShow.Items.Add("Nuovi modelli")
    ddlShow.SelectedIndex = 1

  End Sub

  Private Sub Fill_grd(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    Dim strTableName As String
    Dim sSql, sSqlBase As String

    Select Case ddlShow.SelectedIndex
      Case 0
        strTableName = "Angr_MarcaMezzo"
      Case 1
        strTableName = "Angr_ModelloMezzo"
    End Select

    sSqlBase = "SELECT * FROM Log_Sessione " & _
               "WHERE " & _
                    "LSes_Tabella = '" & strTableName & "' AND " & _
                    "LSes_DataOra >= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBegin) & "', 121) AND " & _
                    "LSes_DataOra <= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateEnd) & "', 121)"

    Select Case ddlShow.SelectedIndex
      Case 0
        sSql = "SELECT " & _
                    "LSes_DataOra, LSes_FK_Sess, LSes_UserName, MaMe_Desc " & _
               "FROM " & _
                    "(" & sSqlBase & ") A " & _
                    "INNER JOIN Angr_MarcaMezzo B ON A.LSes_RecordID = B.MaMe_PK " & _
               "ORDER BY " & _
                    "LSes_UserName, LSes_FK_Sess, MaMe_Desc"
      Case 1
        sSql = "SELECT " & _
                    "LSes_DataOra, LSes_FK_Sess, LSes_UserName, MaMe_Desc, MoMe_Desc " & _
               "FROM " & _
                    "(" & sSqlBase & ") A " & _
                    "INNER JOIN Angr_ModelloMezzo B ON A.LSes_RecordID = B.MoMe_PK " & _
                    "INNER JOIN Angr_MarcaMezzo C ON B.MoMe_FK_MaMe = C.MaMe_PK " & _
               "ORDER BY " & _
                    "LSes_UserName, LSes_FK_Sess, MaMe_Desc, MoMe_Desc"
    End Select
    ' (dbo.FormatDate(LSes_DataOra))

    Dim oConnSQL As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionStringDepositerie"))
    oConnSQL.Open()
    Dim MyCommand As SqlDataAdapter
    MyCommand = New SqlDataAdapter(sSql, oConnSQL)
    details = New DataSet
    MyCommand.Fill(details)

    grd.AutoGenerateColumns = False
    grd.Columns.Clear()

    AddColumn("ID Sessione", "LSes_FK_Sess", HorizontalAlign.Right)
    AddColumn("Data", "LSes_DataOra", HorizontalAlign.Center)
    AddColumn("Utente", "LSes_UserName", HorizontalAlign.Left)
    AddColumn("Marca", "MaMe_Desc", HorizontalAlign.Left)
    If (ddlShow.SelectedIndex = 1) Then
      AddColumn("Modello", "MoMe_Desc", HorizontalAlign.Left)
    End If

    grd.DataSource = details.Tables(0)
    grd.DataBind()

    Page.DataBind()

  End Sub

  Private Sub AddColumn(ByVal strHeaderText As String, ByVal strDataField As String, ByVal intAlign As HorizontalAlign)

    Dim col As New BoundColumn
    col.HeaderText = strHeaderText
    col.HeaderStyle.HorizontalAlign = HorizontalAlign.Left
    col.ItemStyle.HorizontalAlign = intAlign
    col.DataField = strDataField
    grd.Columns.Add(col)

  End Sub

End Class
