Public Class wf_TB_TURNI_AE
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daGruppiDelModulo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daGruppi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.dvGruppi = New System.Data.DataView
    Me.DsTURNIAE2 = New ATCBussm1.DsTURNIAE
    Me.DsUtenti1 = New ATCBussm1.dsUtenti
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsTURNIAE2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daGruppiDelModulo
    '
    Me.daGruppiDelModulo.DeleteCommand = Me.SqlDeleteCommand1
    Me.daGruppiDelModulo.InsertCommand = Me.SqlInsertCommand1
    Me.daGruppiDelModulo.SelectCommand = Me.SqlSelectCommand1
    Me.daGruppiDelModulo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GruppiDelModulo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TURNI", "TURNI"), New System.Data.Common.DataColumnMapping("GRUPPI", "GRUPPI"), New System.Data.Common.DataColumnMapping("TIPO", "TIPO")})})
    Me.daGruppiDelModulo.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM FROM TB_TURNI_ACCERTAMENTO_ESTESO WHERE TURNI = @TURNI"
    Me.SqlDeleteCommand1.Connection = Me.con
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO TB_TURNI_ACCERTAMENTO_ESTESO(TURNI, GRUPPI, TIPO) VALUES (@TURNI, @GR" & _
    "UPPI, @TIPO)"
    Me.SqlInsertCommand1.Connection = Me.con
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT TURNI   ,GRUPPI      ,TIPO  FROM TB_TURNI_ACCERTAMENTO_ESTESO"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE TB_TURNI_ACCERTAMENTO_ESTESO SET GRUPPI = @GRUPPI ,TIPO = @TIPO WHERE TURN" & _
    "I = @TURNI"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TURNI", System.Data.SqlDbType.VarChar, 5, "TURNI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TURNI", System.Data.SqlDbType.VarChar, 5, "TURNI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GRUPPI", System.Data.SqlDbType.VarChar, 30, "GRUPPI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIPO", System.Data.SqlDbType.VarChar, 100, "TIPO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TURNI", System.Data.SqlDbType.VarChar, 5, "TURNI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GRUPPI", System.Data.SqlDbType.VarChar, 30, "GRUPPI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIPO", System.Data.SqlDbType.VarChar, 100, "TIPO"))
    '
    'daGruppi
    '
    Me.daGruppi.SelectCommand = Me.SqlSelectCommand3
    Me.daGruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TUCTUR", "TUCTUR"), New System.Data.Common.DataColumnMapping("TUGRUA", "TUGRUA"), New System.Data.Common.DataColumnMapping("TUTIPL", "TUTIPL")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "select AMTUR.TUCTUR AS TUCTUR,  AMTUR.TUCTUR AS TUCTUR_ORDER, AMTUR.TUGRUA AS TUG" & _
    "RUA, AMTUR.TUTIPL AS TUTIPL  FROM dbo.AMTUR00F AMTUR left outer join dbo.TB_TURN" & _
    "I_ACCERTAMENTO_ESTESO ACC  on ACC.TURNI = AMTUR.TUCTUR and ACC.TIPO = AMTUR.TUTI" & _
    "PL    WHERE CAST(YEAR(getdate()) AS VARCHAR(4)) + RIGHT('00' + CAST(MONTH(getdat" & _
    "e()) AS VARCHAR(2)) ,2)+ RIGHT('00' + CAST(DAY(getdate()) AS VARCHAR(2)),2)  BET" & _
    "WEEN CAST(TUAAIN AS VARCHAR(4)) + RIGHT('00' + CAST(TUMMIN AS VARCHAR(2)) ,2)+ R" & _
    "IGHT('00' + CAST(TUGGIN AS VARCHAR(2)),2)  AND CAST(TUAAFN AS VARCHAR(4)) + RIGH" & _
    "T('00' + CAST(TUMMFN AS VARCHAR(2)) ,2)+ RIGHT('00' + CAST(TUGGFN AS VARCHAR(2))" & _
    ",2)  and ACC.TURNI is null ORDER BY TUCTUR"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'dvGruppi
    '
    Me.dvGruppi.Sort = "TUCTUR_ORDER"
    Me.dvGruppi.Table = Me.DsTURNIAE2.ATC_Gruppi
    '
    'DsTURNIAE2
    '
    Me.DsTURNIAE2.DataSetName = "DsTURNIAE"
    Me.DsTURNIAE2.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DsUtenti1
    '
    Me.DsUtenti1.DataSetName = "dsUtenti"
    Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsTURNIAE2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daGruppiDelModulo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents txtSearch As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
  Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
  Protected WithEvents dgGruppi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblNoProdotti As System.Web.UI.WebControls.Label
  Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents btnRemove As System.Web.UI.WebControls.Button
  Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
  Protected WithEvents dgGruppiDelModulo As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblNoCarichi As System.Web.UI.WebControls.Label
  Protected WithEvents daGruppi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dvGruppi As System.Data.DataView
  Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
  Protected WithEvents DsTURNIAE2 As ATCBussm1.DsTURNIAE

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

    pFillGrid()
    If Not IsPostBack Then
      Page.DataBind()
    End If
  End Sub

  Private Sub dgGruppi_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgGruppi.PageIndexChanged
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = e.NewPageIndex
    dgGruppi.DataBind()
    dgGruppiDelModulo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub pFilterGroupsGrid()
    Dim s As String = txtSearch.Text.Trim
    If s.Length > 0 Then
      Do While s.IndexOf("  ") > 0
        s = s.Replace("  ", " ")
      Loop
      Dim pArr As String() = s.Split(" ")
      Dim where As String = ""
      For Each el As String In pArr
        If where.Length > 0 Then where &= " And "
        where &= "(TUTIPL Like '%" & el & "%') or (TUCTUR  Like '%" & el & "%') or (TUGRUA Like '%" & el & "%')"
      Next
      dvGruppi.RowFilter = where
    Else
      dvGruppi.RowFilter = ""
    End If
  End Sub

  Private Sub dgGruppiDelModulo_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgGruppiDelModulo.PageIndexChanged
    pFilterGroupsGrid()
    dgGruppiDelModulo.CurrentPageIndex = e.NewPageIndex
    dgGruppiDelModulo.DataBind()
    dgGruppi.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Dim com As New SqlClient.SqlCommand("INSERT INTO TB_TURNI_ACCERTAMENTO_ESTESO(TURNI, GRUPPI, TIPO) VALUES " & _
                                            "(@TURNI, @GRUPPI, @TIPO)", con)
    com.Parameters.Add("@TURNI", SqlDbType.VarChar)
    com.Parameters.Add("@GRUPPI", SqlDbType.VarChar)
    com.Parameters.Add("@TIPO", SqlDbType.VarChar)
    con.Open()
    For i As Integer = 0 To dgGruppi.Items.Count - 1
      If DirectCast(dgGruppi.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@TURNI").Value = dgGruppi.DataKeys(i)
        com.Parameters("@GRUPPI").Value = dgGruppi.Items(i).Cells(2).Text
        com.Parameters("@TIPO").Value = dgGruppi.Items(i).Cells(3).Text
        com.ExecuteNonQuery()
      End If
    Next
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppiDelModulo.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Dim com As New SqlClient.SqlCommand("DELETE FROM TB_TURNI_ACCERTAMENTO_ESTESO WHERE TURNI = @TURNI", con)
    com.Parameters.Add("@TURNI", SqlDbType.VarChar)

    Dim LowerBound As Integer = dgGruppiDelModulo.CurrentPageIndex * dgGruppiDelModulo.PageSize
    Dim UpperBound As Integer = IIf(dgGruppiDelModulo.CurrentPageIndex = dgGruppiDelModulo.PageCount - 1, dgGruppiDelModulo.Items.Count - 1, dgGruppiDelModulo.CurrentPageIndex * dgGruppiDelModulo.PageSize + dgGruppiDelModulo.PageSize - 1)
    con.Open()
    For i As Integer = 0 To dgGruppiDelModulo.Items.Count - 1
      If DirectCast(dgGruppiDelModulo.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@TURNI").Value = dgGruppiDelModulo.DataKeys(i).trim
        com.ExecuteNonQuery()
      End If
    Next
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppiDelModulo.CurrentPageIndex = 0
    con.Close()
    pRefreshGrid()
  End Sub

  Private Sub pRefreshGrid()
    DsTURNIAE2.Tables("ATC_Gruppi").Clear()
    DsTURNIAE2.Tables("GruppiDelModulo").Clear()
    pFillGrid()
    dgGruppi.DataBind()
    dgGruppiDelModulo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub pFillGrid()
    
    daGruppi.Fill(DsTURNIAE2)
    daGruppiDelModulo.Fill(DsTURNIAE2)
  End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    pFilterGroupsGrid()
    dgGruppi.CurrentPageIndex = 0
    dgGruppi.DataBind()
    dgGruppiDelModulo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub lnkBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Response.Redirect("wf_permessiNew.aspx")
  End Sub

  Private Sub dgGruppi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGruppi.SelectedIndexChanged

  End Sub
End Class
