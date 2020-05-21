Imports System.Data.SqlClient

Public Class wf_utenti
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daAccAS400Old = New System.Data.OleDb.OleDbDataAdapter
    Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
    Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
    Me.DsOrganico1 = New ATCBussm1.dsOrganico
    Me.daAccSql = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.conAS400 = New System.Data.Odbc.OdbcConnection
    Me.daAccAS400 = New System.Data.Odbc.OdbcDataAdapter
    Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
    Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
    CType(Me.DsOrganico1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daAccAS400Old
    '
    Me.daAccAS400Old.InsertCommand = Me.OleDbInsertCommand1
    Me.daAccAS400Old.SelectCommand = Me.OleDbSelectCommand1
    Me.daAccAS400Old.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AMPE_APANA00F", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANMATR", "ANMATR"), New System.Data.Common.DataColumnMapping("ANCOGN", "ANCOGN"), New System.Data.Common.DataColumnMapping("ANNOME", "ANNOME")})})
    '
    'OleDbInsertCommand1
    '
    Me.OleDbInsertCommand1.CommandText = "INSERT INTO AMPE_APANA00F(ANMATR, ANCOGN, ANNOME) VALUES (?, ?, ?)"
    Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ANMATR", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ANMATR", System.Data.DataRowVersion.Current, Nothing))
    Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ANCOGN", System.Data.OleDb.OleDbType.VarWChar, 32, "ANCOGN"))
    Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ANNOME", System.Data.OleDb.OleDbType.VarWChar, 18, "ANNOME"))
    '
    'OleDbSelectCommand1
    '
    Me.OleDbSelectCommand1.CommandText = "SELECT ANMATR, ANCOGN, ANNOME FROM AMPE_APANA00F TmpAccertatori WHERE (? < CStr(A" & _
    "NAACN) + RIGHT('0' + CStr(ANMMCN), 2) + RIGHT('0' + CStr(ANGGCN), 2))"
    Me.OleDbSelectCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Param1", System.Data.OleDb.OleDbType.Variant))
    '
    'DsOrganico1
    '
    Me.DsOrganico1.DataSetName = "dsOrganico"
    Me.DsOrganico1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daAccSql
    '
    Me.daAccSql.InsertCommand = Me.SqlInsertCommand1
    Me.daAccSql.SelectCommand = Me.SqlSelectCommand1
    Me.daAccSql.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TmpAccertatori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANMATR", "ANMATR"), New System.Data.Common.DataColumnMapping("ANCOGN", "ANCOGN"), New System.Data.Common.DataColumnMapping("ANNOME", "ANNOME")})})
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.TmpAccertatori(ANMATR, ANCOGN, ANNOME) VALUES (@ANMATR, @ANCOGN, " & _
    "@ANNOME); SELECT ANMATR, ANCOGN, ANNOME FROM dbo.TmpAccertatori WHERE (ANMATR = " & _
    "@ANMATR)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANMATR", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ANMATR", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANCOGN", System.Data.SqlDbType.NVarChar, 32, "ANCOGN"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANNOME", System.Data.SqlDbType.NVarChar, 18, "ANNOME"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT ANMATR, ANCOGN, ANNOME FROM dbo.TmpAccertatori"
    Me.SqlSelectCommand1.Connection = Me.con
    Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("Parameter1", System.Data.SqlDbType.VarChar))
    '
    'conAS400
    '
    Me.conAS400.ConnectionString = CType(configurationAppSettings.GetValue("conAS400.ConnectionString", GetType(System.String)), String)
    '
    'daAccAS400
    '
    Me.daAccAS400.InsertCommand = Me.OdbcInsertCommand1
    Me.daAccAS400.SelectCommand = Me.OdbcSelectCommand1
    Me.daAccAS400.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "APANA00F", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANMATR", "ANMATR"), New System.Data.Common.DataColumnMapping("ANCGNO", "ANCGNO"), New System.Data.Common.DataColumnMapping("ANCOGN", "ANCOGN"), New System.Data.Common.DataColumnMapping("ANNOME", "ANNOME"), New System.Data.Common.DataColumnMapping("ANGGNA", "ANGGNA"), New System.Data.Common.DataColumnMapping("ANMMNA", "ANMMNA"), New System.Data.Common.DataColumnMapping("ANAANA", "ANAANA"), New System.Data.Common.DataColumnMapping("ANCONA", "ANCONA"), New System.Data.Common.DataColumnMapping("ANPRNA", "ANPRNA"), New System.Data.Common.DataColumnMapping("ANSESS", "ANSESS"), New System.Data.Common.DataColumnMapping("ANCOFI", "ANCOFI"), New System.Data.Common.DataColumnMapping("ANSTCI", "ANSTCI"), New System.Data.Common.DataColumnMapping("ANINDI", "ANINDI"), New System.Data.Common.DataColumnMapping("ANCDAP", "ANCDAP"), New System.Data.Common.DataColumnMapping("ANLOCA", "ANLOCA"), New System.Data.Common.DataColumnMapping("ANCORE", "ANCORE"), New System.Data.Common.DataColumnMapping("ANPRRE", "ANPRRE"), New System.Data.Common.DataColumnMapping("ANINDO", "ANINDO"), New System.Data.Common.DataColumnMapping("ANCDAD", "ANCDAD"), New System.Data.Common.DataColumnMapping("ANLODO", "ANLODO"), New System.Data.Common.DataColumnMapping("ANCODO", "ANCODO"), New System.Data.Common.DataColumnMapping("ANPRDO", "ANPRDO"), New System.Data.Common.DataColumnMapping("ANTELP", "ANTELP"), New System.Data.Common.DataColumnMapping("ANTELE", "ANTELE"), New System.Data.Common.DataColumnMapping("ANESLV", "ANESLV"), New System.Data.Common.DataColumnMapping("ANDULV", "ANDULV"), New System.Data.Common.DataColumnMapping("ANGRLV", "ANGRLV"), New System.Data.Common.DataColumnMapping("ANARLV", "ANARLV"), New System.Data.Common.DataColumnMapping("ANMTLV", "ANMTLV"), New System.Data.Common.DataColumnMapping("ANTICN", "ANTICN"), New System.Data.Common.DataColumnMapping("ANGGCN", "ANGGCN"), New System.Data.Common.DataColumnMapping("ANMMCN", "ANMMCN"), New System.Data.Common.DataColumnMapping("ANAACN", "ANAACN"), New System.Data.Common.DataColumnMapping("ANCDCO", "ANCDCO"), New System.Data.Common.DataColumnMapping("ANPERI", "ANPERI"), New System.Data.Common.DataColumnMapping("ANTICA", "ANTICA"), New System.Data.Common.DataColumnMapping("ANGGAS", "ANGGAS"), New System.Data.Common.DataColumnMapping("ANMMAS", "ANMMAS"), New System.Data.Common.DataColumnMapping("ANAAAS", "ANAAAS"), New System.Data.Common.DataColumnMapping("ANGGFP", "ANGGFP"), New System.Data.Common.DataColumnMapping("ANMMFP", "ANMMFP"), New System.Data.Common.DataColumnMapping("ANAAFP", "ANAAFP"), New System.Data.Common.DataColumnMapping("ANNMFP", "ANNMFP"), New System.Data.Common.DataColumnMapping("ANLING", "ANLING"), New System.Data.Common.DataColumnMapping("ANTSTU", "ANTSTU"), New System.Data.Common.DataColumnMapping("ANINPS", "ANINPS"), New System.Data.Common.DataColumnMapping("ANFLAG", "ANFLAG"), New System.Data.Common.DataColumnMapping("ANGGRG", "ANGGRG"), New System.Data.Common.DataColumnMapping("ANMMRG", "ANMMRG"), New System.Data.Common.DataColumnMapping("ANAARG", "ANAARG")})})
    '
    'OdbcInsertCommand1
    '
    Me.OdbcInsertCommand1.CommandText = "INSERT INTO INNOTEST.APANA00F(ANMATR, ANCGNO, ANCOGN, ANNOME, ANGGNA, ANMMNA, ANA" & _
    "ANA, ANCONA, ANPRNA, ANSESS, ANCOFI, ANSTCI, ANINDI, ANCDAP, ANLOCA, ANCORE, ANP" & _
    "RRE, ANINDO, ANCDAD, ANLODO, ANCODO, ANPRDO, ANTELP, ANTELE, ANESLV, ANDULV, ANG" & _
    "RLV, ANARLV, ANMTLV, ANTICN, ANGGCN, ANMMCN, ANAACN, ANCDCO, ANPERI, ANTICA, ANG" & _
    "GAS, ANMMAS, ANAAAS, ANGGFP, ANMMFP, ANAAFP, ANNMFP, ANLING, ANTSTU, ANINPS, ANF" & _
    "LAG, ANGGRG, ANMMRG, ANAARG) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
    ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, " & _
    "?, ?, ?, ?, ?, ?, ?, ?, ?)"
    Me.OdbcInsertCommand1.Connection = Me.conAS400
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMATR", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANMATR", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCGNO", System.Data.Odbc.OdbcType.VarChar, 25, "ANCGNO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCOGN", System.Data.Odbc.OdbcType.VarChar, 19, "ANCOGN"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANNOME", System.Data.Odbc.OdbcType.VarChar, 18, "ANNOME"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGGNA", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANGGNA", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMMNA", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANMMNA", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANAANA", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANAANA", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCONA", System.Data.Odbc.OdbcType.VarChar, 30, "ANCONA"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANPRNA", System.Data.Odbc.OdbcType.VarChar, 2, "ANPRNA"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANSESS", System.Data.Odbc.OdbcType.VarChar, 1, "ANSESS"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCOFI", System.Data.Odbc.OdbcType.VarChar, 16, "ANCOFI"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANSTCI", System.Data.Odbc.OdbcType.VarChar, 1, "ANSTCI"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANINDI", System.Data.Odbc.OdbcType.VarChar, 30, "ANINDI"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCDAP", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ANCDAP", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANLOCA", System.Data.Odbc.OdbcType.VarChar, 20, "ANLOCA"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCORE", System.Data.Odbc.OdbcType.VarChar, 27, "ANCORE"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANPRRE", System.Data.Odbc.OdbcType.VarChar, 2, "ANPRRE"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANINDO", System.Data.Odbc.OdbcType.VarChar, 30, "ANINDO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCDAD", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ANCDAD", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANLODO", System.Data.Odbc.OdbcType.VarChar, 10, "ANLODO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCODO", System.Data.Odbc.OdbcType.VarChar, 27, "ANCODO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANPRDO", System.Data.Odbc.OdbcType.VarChar, 2, "ANPRDO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANTELP", System.Data.Odbc.OdbcType.VarChar, 1, "ANTELP"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANTELE", System.Data.Odbc.OdbcType.VarChar, 1, "ANTELE"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANESLV", System.Data.Odbc.OdbcType.VarChar, 2, "ANESLV"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANDULV", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(1, Byte), CType(0, Byte), "ANDULV", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGRLV", System.Data.Odbc.OdbcType.VarChar, 2, "ANGRLV"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANARLV", System.Data.Odbc.OdbcType.VarChar, 2, "ANARLV"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMTLV", System.Data.Odbc.OdbcType.VarChar, 1, "ANMTLV"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANTICN", System.Data.Odbc.OdbcType.VarChar, 2, "ANTICN"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGGCN", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANGGCN", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMMCN", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANMMCN", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANAACN", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANAACN", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANCDCO", System.Data.Odbc.OdbcType.VarChar, 2, "ANCDCO"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANPERI", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ANPERI", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANTICA", System.Data.Odbc.OdbcType.VarChar, 2, "ANTICA"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGGAS", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANGGAS", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMMAS", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANMMAS", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANAAAS", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANAAAS", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGGFP", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANGGFP", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMMFP", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANMMFP", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANAAFP", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANAAFP", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANNMFP", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(1, Byte), CType(0, Byte), "ANNMFP", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANLING", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(1, Byte), CType(0, Byte), "ANLING", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANTSTU", System.Data.Odbc.OdbcType.VarChar, 2, "ANTSTU"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANINPS", System.Data.Odbc.OdbcType.VarChar, 10, "ANINPS"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANFLAG", System.Data.Odbc.OdbcType.VarChar, 1, "ANFLAG"))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANGGRG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANGGRG", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANMMRG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "ANMMRG", System.Data.DataRowVersion.Current, Nothing))
    Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("ANAARG", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(4, Byte), CType(0, Byte), "ANAARG", System.Data.DataRowVersion.Current, Nothing))
    '
    'OdbcSelectCommand1
    '
    Me.OdbcSelectCommand1.CommandText = CType(configurationAppSettings.GetValue("SelectOrganico", GetType(System.String)), String)
    Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Parameter1", System.Data.Odbc.OdbcType.VarChar))
    Me.OdbcSelectCommand1.Connection = Me.conAS400
    CType(Me.DsOrganico1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents Label9 As System.Web.UI.WebControls.Label
  Protected WithEvents lstUtenti As System.Web.UI.WebControls.ListBox
  Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
  Protected WithEvents BtnModify As System.Web.UI.WebControls.Button
  Protected WithEvents btnRemove As System.Web.UI.WebControls.Button
  Protected WithEvents txtId As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label4 As System.Web.UI.WebControls.Label
  Protected WithEvents txtUserId As System.Web.UI.WebControls.TextBox
  Protected WithEvents Requiredfieldvalidator4 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents Label5 As System.Web.UI.WebControls.Label
  Protected WithEvents txtPwd As System.Web.UI.WebControls.TextBox
  Protected WithEvents Requiredfieldvalidator5 As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents txtSurname As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label6 As System.Web.UI.WebControls.Label
  Protected WithEvents chkEnabled As System.Web.UI.WebControls.CheckBox
  Protected WithEvents Label7 As System.Web.UI.WebControls.Label
  Protected WithEvents lstGruppiUtente As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnRemoveGroup As System.Web.UI.WebControls.Button
  Protected WithEvents Label8 As System.Web.UI.WebControls.Label
  Protected WithEvents lstGruppi As System.Web.UI.WebControls.ListBox
  Protected WithEvents btnAddGroup As System.Web.UI.WebControls.Button
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
  Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
  Protected WithEvents pnlUtente As System.Web.UI.WebControls.Panel
  Protected WithEvents btnSyncAS400 As System.Web.UI.WebControls.Button
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
  Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
  Protected WithEvents DsOrganico1 As ATCBussm1.dsOrganico
  Protected WithEvents daAccSql As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents conAS400 As System.Data.Odbc.OdbcConnection
  Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
  Protected WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
  Protected WithEvents daAccAS400Old As System.Data.OleDb.OleDbDataAdapter
  Protected WithEvents daAccAS400 As System.Data.Odbc.OdbcDataAdapter

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private oUtente As Utente

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' ----------------------------------------------------------------------------
    '     Righe agginte da Paolo Cavazzini
    ' ----------------------------------------------------------------------------
    'Dim intUserID As Integer = atcbSession.Get_UserID(Me.Session)
    'Dim intSectionID As Integer = atcbSession.Get_SectionID(Me.Session)
    'atcbWUser.LoadMenu(intUserID, intSectionID, tblToolbar)
    ' ----------------------------------------------------------------------------
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    If Not Me.IsPostBack Then
      pLoadUsers()
      BtnAdd.Visible = oUtente.CheckAbil(12, 2)
      BtnModify.Visible = oUtente.CheckAbil(12, 4)
      btnRemove.Visible = oUtente.CheckAbil(12, 3)
    End If

  End Sub

  Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
    If lstUtenti.SelectedValue <> "" Then
      pClearPanel()
      pLoadUser(lstUtenti.SelectedValue)
      pShowPanel()
    End If
  End Sub

  Private Sub pShowPanel()
    pnlUtente.Visible = True
    txtId.Visible = False
  End Sub

  Private Sub pLoadUser(ByVal id As Integer)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select * From ATC_Utenti Where Id = @1", con)
    Dim dr As SqlDataReader
    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dr = com.ExecuteReader
    dr.Read()
    txtId.Text = dr.Item("ID")
    txtUserId.Text = dr.Item("IDUser")
    txtName.Text = dr.Item("Nome")
    txtSurname.Text = dr.Item("Cognome")
    txtPwd.Text = dr.Item("Pwd")
    txtEmail.Text = dr.Item("Email")
    chkEnabled.Checked = CBool(dr.Item("Abilitato"))
    dr.Close()
    con.Close()
    con.Dispose()

    pLoadGruppi(id)
    pLoadGruppiUtente(id)

  End Sub

  Private Sub pClearPanel()
    txtId.Text = ""
    txtUserId.Text = ""
    txtName.Text = ""
    txtSurname.Text = ""
    txtPwd.Text = ""
    txtEmail.Text = ""
    chkEnabled.Checked = False
    lstGruppi.Items.Clear()
    lstGruppiUtente.Items.Clear()
  End Sub

  Private Sub btnRemoveGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveGroup.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Delete From ATC_RelUtenteGruppo Where IdUtente = @1 AND IdGruppo = @2", con)
    Dim i As Integer

    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = CInt(txtId.Text)
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstGruppiUtente.Items.Count - 1
      If lstGruppiUtente.Items(i).Selected Then
        com.Parameters("@2").Value = lstGruppiUtente.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    pLoadGruppi(CInt(txtId.Text))
    pLoadGruppiUtente(CInt(txtId.Text))
    con.Close()
    con.Dispose()
  End Sub

  Private Sub pLoadGruppiUtente(ByVal id As Integer)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    con.Open()
    com = New SqlCommand("Select G.ID As Id, G.Descrizione As Descrizione From ATC_RelUtenteGruppo UG Left Join ATC_Gruppi G On UG.IdGruppo = G.ID Where UG.IDUtente = @1", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = id
    dr = com.ExecuteReader
    lstGruppiUtente.DataSource = dr
    lstGruppiUtente.DataTextField = "Descrizione"
    lstGruppiUtente.DataValueField = "ID"
    lstGruppiUtente.DataBind()
    dr.Close()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub pLoadGruppi(Optional ByVal id As Integer = -1)
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    con.Open()
    If id = -1 Then
      com = New SqlCommand("Select ID, Descrizione From ATC_Gruppi", con)
    Else
      com = New SqlCommand("Select ID, Descrizione From ATC_Gruppi G Where Not Exists(Select * From ATC_RelUtenteGruppo UG Where UG.IDUtente = @1 And UG.IDGruppo = G.ID)", con)
      com.Parameters.Add("@1", SqlDbType.Int).Value = id
    End If
    dr = com.ExecuteReader
    lstGruppi.DataSource = dr
    lstGruppi.DataTextField = "Descrizione"
    lstGruppi.DataValueField = "ID"
    lstGruppi.DataBind()
    dr.Close()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGroup.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("", con)
    Dim i As Integer
    Dim dr As SqlDataReader
    Dim Id As Integer

    con.Open()
    If txtId.Text.Length = 0 Then
      pSaveUser()
      If lblError.Visible Then Exit Sub
      com.CommandText = "Select Id From ATC_Utenti Where IDUser = @1"
      com.Parameters.Add("@1", SqlDbType.VarChar).Value = txtUserId.Text
      dr = com.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        Id = dr.Item("Id")
        txtId.Text = Id
        dr.Close()
      Else
        dr.Close()
        Exit Sub
      End If
    Else
      Id = CInt(txtId.Text)
    End If
    com.Parameters.Clear()
    com.CommandText = "Insert Into ATC_RelUtenteGruppo(IdUtente, IDGruppo) Values(@1, @2)"
    com.Parameters.Add("@1", SqlDbType.Int).Value = Id
    com.Parameters.Add("@2", SqlDbType.Int)
    For i = 0 To lstGruppi.Items.Count - 1
      If lstGruppi.Items(i).Selected Then
        com.Parameters("@2").Value = lstGruppi.Items(i).Value
        com.ExecuteNonQuery()
      End If
    Next
    pLoadGruppi(Id)
    pLoadGruppiUtente(Id)
    con.Close()
    con.Dispose()

  End Sub

  Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
    pClearPanel()
    pLoadGruppi()
    pShowPanel()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Delete From ATC_Utenti Where Id = @1", con)


    con.Open()
    com.Parameters.Add("@1", SqlDbType.Int).Value = lstUtenti.SelectedValue
    com.ExecuteNonQuery()
    com = New SqlCommand("Delete From ATC_RelUtenteGruppo Where IdUtente = @1", con)
    com.Parameters.Add("@1", SqlDbType.Int).Value = lstUtenti.SelectedValue
    com.ExecuteNonQuery()
    con.Close()
    con.Dispose()

    pLoadUsers()
  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
    pSaveUser()
    pnlUtente.Visible = False
    pLoadUsers()
  End Sub

  Private Sub pLoadUsers()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("Select * From ATC_Utenti Where TipoUtente <> 1 Order By IdUser", con)
    Dim dr As SqlDataReader
    con.Open()
    dr = com.ExecuteReader
    lstUtenti.DataSource = dr
    lstUtenti.DataTextField = "IdUser"
    lstUtenti.DataValueField = "ID"
    lstUtenti.DataBind()
    con.Close()
    con.Dispose()
  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    pnlUtente.Visible = False
    pLoadUsers()
  End Sub

  Private Sub pSaveUser()
    Dim con As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim com As SqlCommand = New SqlCommand("", con)

    lblError.Visible = False
    con.Open()
    If txtId.Text.Length > 0 Then
      com.CommandText = "Update ATC_Utenti Set IDUser = @2, Pwd = @3, Cognome = @4, Nome = @5, Email = @6, Abilitato = @7 Where Id = @1"
      com.Parameters.Add("@1", SqlDbType.Int).Value = CInt(txtId.Text)
    Else
      com.CommandText = "Select Count(*) from ATC_Utenti Where IDUser = @1"
      com.Parameters.Add("@1", SqlDbType.VarChar).Value = txtUserId.Text
      If com.ExecuteScalar > 0 Then
        lblError.Text = "ERRORE: impossibile salvare perché è già presente un utente con lo stesso User ID."
        lblError.Visible = True
        Exit Sub
      End If
      com.CommandText = "Insert Into ATC_Utenti(IDUser, Pwd, Cognome, Nome, Email, Abilitato) Values(@2, @3, @4, @5, @6, @7)"
    End If
    com.Parameters.Add("@2", SqlDbType.VarChar).Value = txtUserId.Text
    com.Parameters.Add("@3", SqlDbType.VarChar).Value = txtPwd.Text
    com.Parameters.Add("@4", SqlDbType.VarChar).Value = txtSurname.Text
    com.Parameters.Add("@5", SqlDbType.VarChar).Value = txtName.Text
    com.Parameters.Add("@6", SqlDbType.VarChar).Value = txtEmail.Text
    If chkEnabled.Checked Then
      com.Parameters.Add("@7", SqlDbType.Bit).Value = 1
    Else
      com.Parameters.Add("@7", SqlDbType.Bit).Value = 0
    End If
    com.ExecuteNonQuery()
    con.Close()
    con.Dispose()

  End Sub

  Private Sub btnSyncAS400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncAS400.Click
    Dim com As New SqlCommand("Delete From TmpAccertatori", con)
    Dim comDelete As New SqlCommand("DELETE FROM ATC_Utenti WHERE TipoUtente = 2 And Not EXISTS(SELECT * FROM TmpAccertatori T WHERE LTrim(Str(T.ANMATR, 30)) = IDUser)", con)
    Dim comInsert As New SqlCommand("Insert Into ATC_Utenti(IDUser, pwd, Cognome, Nome, Abilitato, TipoUtente) Select ANMATR, ANMATR As pwd, ANCOGN, ANNOME, 1, 2 From TmpAccertatori T Where Not Exists (Select * From ATC_Utenti U Where LTrim(Str(T.ANMATR, 30)) = U.IDUser)", con)
    Dim comInsertRole As New SqlCommand("Insert Into ATC_RelUtenteGruppo(IdUtente, IdGruppo) Select Id, 12 From ATC_Utenti U Where TipoUtente = 2 And Not Exists(Select * From ATC_RelUtenteGruppo R Where R.IdUtente = U.Id And R.IdGruppo = 12)", con)
    con.Open()
    com.ExecuteNonQuery()
    con.Close()
    daAccAS400.SelectCommand.Parameters(0).Value = Today.Year & Right("0" & Today.Month, 2) & Right("0" & Today.Day, 2)
    daAccAS400.AcceptChangesDuringFill = False
    daAccAS400.Fill(DsOrganico1, "TmpAccertatori")
    daAccSql.Update(DsOrganico1, "TmpAccertatori")
    con.Open()
    comDelete.ExecuteNonQuery()
    comInsert.ExecuteNonQuery()
    comInsertRole.ExecuteNonQuery()
    con.Close()
    pLoadUsers()
  End Sub
End Class
