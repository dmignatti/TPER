Public Class wf_permessiNew
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.daModuli = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.DsUtenti1 = New ATCBussm1.dsUtenti
		Me.dvModuli = New System.Data.DataView
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dvModuli, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
		'
		'daModuli
		'
		Me.daModuli.DeleteCommand = Me.SqlDeleteCommand1
		Me.daModuli.InsertCommand = Me.SqlInsertCommand1
		Me.daModuli.SelectCommand = Me.SqlSelectCommand1
		Me.daModuli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_ModuliPortale", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("FK_Sect", "FK_Sect"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("CosaLancio", "CosaLancio"), New System.Data.Common.DataColumnMapping("QSMode", "QSMode")})})
		Me.daModuli.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.ATC_ModuliPortale WHERE (ID = @Original_ID) AND (Abilitato = @Ori" & _
		"ginal_Abilitato) AND (CosaLancio = @Original_CosaLancio) AND (Descrizione = @Ori" & _
		"ginal_Descrizione) AND (FK_Sect = @Original_FK_Sect OR @Original_FK_Sect IS NULL" & _
		" AND FK_Sect IS NULL) AND (QSMode = @Original_QSMode)"
		Me.SqlDeleteCommand1.Connection = Me.con
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CosaLancio", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CosaLancio", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FK_Sect", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FK_Sect", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QSMode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QSMode", System.Data.DataRowVersion.Original, Nothing))
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.ATC_ModuliPortale(FK_Sect, Descrizione, Abilitato, CosaLancio, QS" & _
		"Mode) VALUES (@FK_Sect, @Descrizione, @Abilitato, @CosaLancio, @QSMode); SELECT " & _
		"ID, FK_Sect, Descrizione, Abilitato, CosaLancio, QSMode FROM dbo.ATC_ModuliPorta" & _
		"le WHERE (ID = @@IDENTITY)"
		Me.SqlInsertCommand1.Connection = Me.con
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FK_Sect", System.Data.SqlDbType.Int, 4, "FK_Sect"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CosaLancio", System.Data.SqlDbType.VarChar, 255, "CosaLancio"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QSMode", System.Data.SqlDbType.Int, 4, "QSMode"))
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT M.ID, S.Sect_Desc, M.Descrizione, M.Abilitato FROM dbo.ATC_ModuliPortale M" & _
		" INNER JOIN dbo.Tabl_Section S ON M.FK_Sect = S.Sect_PK"
		Me.SqlSelectCommand1.Connection = Me.con
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.ATC_ModuliPortale SET FK_Sect = @FK_Sect, Descrizione = @Descrizione, " & _
		"Abilitato = @Abilitato, CosaLancio = @CosaLancio, QSMode = @QSMode WHERE (ID = @" & _
		"Original_ID) AND (Abilitato = @Original_Abilitato) AND (CosaLancio = @Original_C" & _
		"osaLancio) AND (Descrizione = @Original_Descrizione) AND (FK_Sect = @Original_FK" & _
		"_Sect OR @Original_FK_Sect IS NULL AND FK_Sect IS NULL) AND (QSMode = @Original_" & _
		"QSMode); SELECT ID, FK_Sect, Descrizione, Abilitato, CosaLancio, QSMode FROM dbo" & _
		".ATC_ModuliPortale WHERE (ID = @ID)"
		Me.SqlUpdateCommand1.Connection = Me.con
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FK_Sect", System.Data.SqlDbType.Int, 4, "FK_Sect"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descrizione", System.Data.SqlDbType.VarChar, 50, "Descrizione"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abilitato", System.Data.SqlDbType.Bit, 1, "Abilitato"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CosaLancio", System.Data.SqlDbType.VarChar, 255, "CosaLancio"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QSMode", System.Data.SqlDbType.Int, 4, "QSMode"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abilitato", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abilitato", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CosaLancio", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CosaLancio", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descrizione", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FK_Sect", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FK_Sect", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QSMode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QSMode", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
		'
		'DsUtenti1
		'
		Me.DsUtenti1.DataSetName = "dsUtenti"
		Me.DsUtenti1.Locale = New System.Globalization.CultureInfo("it-IT")
		'
		'dvModuli
		'
		Me.dvModuli.Sort = "Sect_Desc, Descrizione"
		Me.dvModuli.Table = Me.DsUtenti1.ATC_ModuliPortale
		CType(Me.DsUtenti1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dvModuli, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daModuli As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsUtenti1 As ATCBussm1.dsUtenti
  Protected WithEvents dvModuli As System.Data.DataView
  Protected WithEvents dgModuli As System.Web.UI.WebControls.DataGrid
	Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
	Protected WithEvents lblCerca As System.Web.UI.WebControls.Label
	Protected WithEvents txtFiltro As System.Web.UI.WebControls.TextBox
	Protected WithEvents ddlSearchType As System.Web.UI.WebControls.DropDownList
	Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
	Protected WithEvents lblCount As System.Web.UI.WebControls.Label
	Protected WithEvents lblNoModuli As System.Web.UI.WebControls.Label

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

	Dim DefaultFilter As String = ""

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
		daModuli.Fill(DsUtenti1)
		dvModuli.RowFilter = pCreateFilter()
    If Not IsPostBack Then Page.DataBind()
  End Sub

  Private Sub dgModuli_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgModuli.SelectedIndexChanged
    Response.Redirect("wf_modulo.aspx?ID=" & Server.UrlEncode(dgModuli.DataKeys(dgModuli.SelectedIndex)))
  End Sub

  Private Sub dgModuli_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgModuli.PageIndexChanged
    dgModuli.CurrentPageIndex = e.NewPageIndex
    dgModuli.DataBind()
	End Sub

	Private Function pCreateFilter() As String
		If txtFiltro.Text.Trim.Length > 0 Then
			Dim where As String = ""
			Dim s As String = txtFiltro.Text.Trim
			Do While s.IndexOf("  ") >= 0
				s = s.Replace("  ", " ")
			Loop
			Dim pArr As String()
			pArr = s.Split(" ")
			For Each s In pArr
				s = s.Replace("'", "''")
				s = s.Replace("%", "[%]")
				s = s.Replace("_", "[_]")
				If where.Length > 0 Then
					If ddlSearchType.SelectedValue <> 1 Then
						where &= " Or "
					Else
						where &= " And "
					End If
				End If
				where &= "(Descrizione Like '%" & s & "%' or Sect_Desc Like '%" & s & "%')"
			Next
			pCreateFilter = where
		Else
			pCreateFilter = DefaultFilter
		End If
	End Function

	Private Sub btnCerca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerca.Click
		dgModuli.CurrentPageIndex = 0
		dgModuli.DataBind()
		lblNoModuli.DataBind()
		lblCount.DataBind()
	End Sub
End Class
