Public Class wf_TbTurni
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
    Me.DsUtenti1 = New ATCBussm1.dsUtenti
    Me.SqlSelectTurni = New System.Data.SqlClient.SqlCommand
    Me.daTurni = New System.Data.SqlClient.SqlDataAdapter
    Me.DsTURNI1 = New ATCBussm1.dsTURNI
    Me.daTBCambiTurno = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.dvTurni = New System.Data.DataView
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsTURNI1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.daGruppiDelModulo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GruppiDelModulo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
    Me.daGruppiDelModulo.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_Gruppi WHERE (ID = @Delete2_Original_ID) AND (Abilitato = @Or" & _
    "iginal_Abilitato OR @Original_Abilitato IS NULL AND Abilitato IS NULL) AND (Ammi" & _
    "nistrazione = @Original_Amministrazione OR @Original_Amministrazione IS NULL AND" & _
    " Amministrazione IS NULL) AND (Descrizione = @Original_Descrizione) AND (EMail =" & _
    " @Original_EMail OR @Original_EMail IS NULL AND EMail IS NULL)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Delete2_Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.ATC_Gruppi(Descrizione, Abilitato, EMail, Amministrazione) VALUES" & _
    " (@Descrizione, @Abilitato, @EMail, @Amministrazione)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT r.IDGruppo AS ID, g.Descrizione FROM dbo.ATC_RelModuloGruppo r INNER JOIN " & _
    "dbo.ATC_Gruppi g ON r.IDGruppo = g.ID WHERE (r.IDModulo = @Id) ORDER BY g.Descri" & _
    "zione"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "IDModulo"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_Gruppi SET Descrizione = @Descrizione, Abilitato = @Abilitato, EMa" & _
    "il = @EMail, Amministrazione = @Amministrazione WHERE (ID = @Update2_Original_ID" & _
    ") AND (Abilitato = @Original_Abilitato OR @Original_Abilitato IS NULL AND Abilit" & _
    "ato IS NULL) AND (Amministrazione = @Original_Amministrazione OR @Original_Ammin" & _
    "istrazione IS NULL AND Amministrazione IS NULL) AND (Descrizione = @Original_Des" & _
    "crizione) AND (EMail = @Original_EMail OR @Original_EMail IS NULL AND EMail IS N" & _
    "ULL)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EMail", System.Data.SqlDbType.VarChar, 50, "EMail"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amministrazione", System.Data.SqlDbType.Bit, 1, "Amministrazione"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Update2_Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amministrazione", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amministrazione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EMail", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMail", System.Data.DataRowVersion.Original, Nothing))
    '
    'daGruppi
    '
    Me.daGruppi.SelectCommand = Me.SqlSelectCommand3
    Me.daGruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Amministrazione", "Amministrazione")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT ID, Descrizione FROM dbo.ATC_Gruppi g1 WHERE (NOT EXISTS (SELECT * FROM at" & _
    "c_relmodulogruppo g2 WHERE g1.id = g2.idgruppo AND g2.idmodulo = @id))"
    Me.SqlSelectCommand3.Connection = Me.con
    Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "IDUtente"))
    '
    'dvGruppi
    '
    Me.dvGruppi.Sort = "Descrizione"
    Me.dvGruppi.Table = Me.DsUtenti1.ATC_Gruppi
    '
    'DsUtenti1
    '
    Me.DsUtenti1.DataSetName = "dsUtenti"
    Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'SqlSelectTurni
    '
    Me.SqlSelectTurni.CommandText = "select AMTIP00F.TITIPL AS TITIPL, AMTIP00F.TIDTIP AS TIDTIP  ,isnull(AMTIP00F.TIGRUA, '') AS " & _
    "TIGRUA FROM AMTIP00F  left outer join TB_CAMBI_TURNO TR   ON TR.TITIPL = AMTIP00" & _
    "F.TITIPL WHERE TR.TIDTIP IS NULL ORDER BY AMTIP00F.TITIPL"
    Me.SqlSelectTurni.Connection = Me.con
    '
    'daTurni
    '
    Me.daTurni.SelectCommand = Me.SqlSelectTurni
    Me.daTurni.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AMTIP00F", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TITIPL", "TITIPL"), New System.Data.Common.DataColumnMapping("TIDTIP", "TIDTIP"), New System.Data.Common.DataColumnMapping("TISASS", "TISASS"), New System.Data.Common.DataColumnMapping("TISROT", "TISROT"), New System.Data.Common.DataColumnMapping("TIFLSM", "TIFLSM"), New System.Data.Common.DataColumnMapping("TISNOT", "TISNOT"), New System.Data.Common.DataColumnMapping("TIFGRI", "TIFGRI"), New System.Data.Common.DataColumnMapping("TISRSQ", "TISRSQ"), New System.Data.Common.DataColumnMapping("TIGRUA", "TIGRUA")})})
    '
    'DsTURNI1
    '
    Me.DsTURNI1.DataSetName = "dsTURNI"
    Me.DsTURNI1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daTBCambiTurno
    '
    Me.daTBCambiTurno.DeleteCommand = Me.SqlDeleteCommand2
    Me.daTBCambiTurno.InsertCommand = Me.SqlInsertCommand2
    Me.daTBCambiTurno.SelectCommand = Me.SqlSelectCommand2
    Me.daTBCambiTurno.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TB_CAMBI_TURNO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TITIPL", "TITIPL"), New System.Data.Common.DataColumnMapping("TIDTIP", "TIDTIP"), New System.Data.Common.DataColumnMapping("TIGRUA", "TIGRUA")})})
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM [ATCBussm].[dbo].[TB_CAMBI_TURNO]WHERE TITIPL = @TITIPL"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TITIPL", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.TB_CAMBI_TURNO(TITIPL, TIDTIP, TIGRUA) VALUES (@TITIPL, @TIDTIP, " & _
    "@TIGRUA)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TITIPL", System.Data.SqlDbType.VarChar, 5, "TITIPL"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIDTIP", System.Data.SqlDbType.VarChar, 30, "TIDTIP"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIGRUA", System.Data.SqlDbType.VarChar, 5, "TIGRUA"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT TITIPL, TIDTIP, TIGRUA FROM TB_CAMBI_TURNO order by TITIPL"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'dvTurni
    '
    Me.dvTurni.Sort = "TITIPL"
    Me.dvTurni.Table = Me.DsTURNI1.AMTIP00F
    CType(Me.dvGruppi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsTURNI1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dvTurni, System.ComponentModel.ISupportInitialize).EndInit()

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
  Protected WithEvents SqlSelectTurni As System.Data.SqlClient.SqlCommand
  Protected WithEvents daTurni As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsTURNI1 As ATCBussm1.dsTURNI
  Protected WithEvents daTBCambiTurno As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dvTurni As System.Data.DataView

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
    '''''    If CStr("" & Request("Id")).Length > 0 Then txtId.Value = Request("Id")
    pFillGrid()
    If Not IsPostBack Then
      dgGruppi.DataBind()
      dgGruppiDelModulo.DataBind()
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
        where &= "(TIDTIP Like '%" & el & "%') or (TITIPL Like '%" & el & "%') or (TIGRUA Like '%" & el & "%')"
      Next
      ''dvGruppi.RowFilter = where
      dvTurni.RowFilter = where
    Else
      ''dvGruppi.RowFilter = ""
      dvTurni.RowFilter = ""
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
    ''Dim com As New SqlClient.SqlCommand("Insert Into ATC_RelModuloGruppo(IdModulo, IdGruppo) Values(@IdModulo, @IdGruppo)", con)
    Dim com As New SqlClient.SqlCommand("Insert Into TB_CAMBI_TURNO(TITIPL,TIDTIP,TIGRUA) Values(@TITIPL, @TIDTIP, @TIGRUA)", con)
    com.Parameters.Add("@TITIPL", SqlDbType.VarChar)
    com.Parameters.Add("@TIDTIP", SqlDbType.VarChar)
    com.Parameters.Add("@TIGRUA", SqlDbType.VarChar)
    con.Open()
    For i As Integer = 0 To dgGruppi.Items.Count - 1
      If DirectCast(dgGruppi.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@TITIPL").Value = dgGruppi.DataKeys(i)
        com.Parameters("@TIDTIP").Value = dgGruppi.Items(i).Cells(2).Text
        com.Parameters("@TIGRUA").Value = dgGruppi.Items(i).Cells(3).Text
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
    '''Dim com As New SqlClient.SqlCommand("Delete From ATC_RelModuloGruppo Where IdGruppo = @ID And IdModulo = @IdModulo", con)
    Dim com As New SqlClient.SqlCommand("Delete From TB_CAMBI_TURNO Where TITIPL = @TITIPL", con)

    com.Parameters.Add("@TITIPL", SqlDbType.VarChar)
    Dim LowerBound As Integer = dgGruppiDelModulo.CurrentPageIndex * dgGruppiDelModulo.PageSize
    Dim UpperBound As Integer = IIf(dgGruppiDelModulo.CurrentPageIndex = dgGruppiDelModulo.PageCount - 1, dgGruppiDelModulo.Items.Count - 1, dgGruppiDelModulo.CurrentPageIndex * dgGruppiDelModulo.PageSize + dgGruppiDelModulo.PageSize - 1)
    con.Open()
    For i As Integer = 0 To dgGruppiDelModulo.Items.Count - 1
      If DirectCast(dgGruppiDelModulo.Items(i).FindControl("chkSelected"), CheckBox).Checked Then
        com.Parameters("@TITIPL").Value = dgGruppiDelModulo.DataKeys(i)
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
    ''''DsUtenti1.Tables("ATC_Gruppi").Clear()    
    '''DsUtenti1.Tables("GruppiDiAppartenenza").Clear()
    DsTURNI1.Tables("AMTIP00F").Clear()
    DsTURNI1.Tables("TB_CAMBI_TURNO").Clear()
    pFillGrid()
    dgGruppi.DataBind()
    dgGruppiDelModulo.DataBind()
    btnAdd.DataBind()
    btnRemove.DataBind()
    lblNoProdotti.DataBind()
    lblNoCarichi.DataBind()
  End Sub

  Private Sub pFillGrid()
    ''If txtId.Value.Length > 0 Then
    ''  daGruppiDelModulo.SelectCommand.Parameters("@id").Value = txtId.Value
    ''  daGruppiDelModulo.Fill(DsUtenti1)
    ''  daGruppi.SelectCommand.Parameters("@id").Value = txtId.Value
    ''Else
    ''  daGruppi.SelectCommand.Parameters("@id").Value = 0
    ''End If
    daTurni.Fill(DsTURNI1)
    daTBCambiTurno.Fill(DsTURNI1)
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


  Private Sub dgGruppi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGruppi.SelectedIndexChanged

  End Sub

  Private Sub dgGruppiDelModulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGruppiDelModulo.SelectedIndexChanged

  End Sub
End Class
