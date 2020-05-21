Public Class wf_confMobilita
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.daConf = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsConfMobilita1 = New ATCBussm1.DsConfMobilita
    CType(Me.DsConfMobilita1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'daConf
    '
    Me.daConf.DeleteCommand = Me.SqlDeleteCommand1
    Me.daConf.InsertCommand = Me.SqlInsertCommand1
    Me.daConf.SelectCommand = Me.SqlSelectCommand1
    Me.daConf.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Conf_Mobilita", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nr_CambiGStessoTipo", "Nr_CambiGStessoTipo"), New System.Data.Common.DataColumnMapping("Nr_CambiMStessoTipo", "Nr_CambiMStessoTipo"), New System.Data.Common.DataColumnMapping("CreateOn", "CreateOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
    Me.daConf.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Conf_Mobilita WHERE (Id = @Original_Id)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Conf_Mobilita(Nr_CambiGStessoTipo, Nr_CambiMStessoTipo, CreateOn," & _
    " ModifiedOn, CreatedBy, ModifiedBy, Id) VALUES (@Nr_CambiGStessoTipo, @Nr_CambiM" & _
    "StessoTipo, @CreateOn, @ModifiedOn, @CreatedBy, @ModifiedBy, @Id); SELECT Nr_Cam" & _
    "biGStessoTipo, Nr_CambiMStessoTipo, CreateOn, ModifiedOn, CreatedBy, ModifiedBy," & _
    " Id FROM dbo.Conf_Mobilita WHERE (Id = @Id)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nr_CambiGStessoTipo", System.Data.SqlDbType.Int, 4, "Nr_CambiGStessoTipo"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nr_CambiMStessoTipo", System.Data.SqlDbType.Int, 4, "Nr_CambiMStessoTipo"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT TOP 1 Nr_CambiGStessoTipo, Nr_CambiMStessoTipo, CreateOn, ModifiedOn, Crea" & _
    "tedBy, ModifiedBy, Id FROM dbo.Conf_Mobilita"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Conf_Mobilita SET Nr_CambiGStessoTipo = @Nr_CambiGStessoTipo, Nr_Cambi" & _
    "MStessoTipo = @Nr_CambiMStessoTipo, CreateOn = @CreateOn, ModifiedOn = @Modified" & _
    "On, CreatedBy = @CreatedBy, ModifiedBy = @ModifiedBy, Id = @Id WHERE (Id = @Orig" & _
    "inal_Id); SELECT Nr_CambiGStessoTipo, Nr_CambiMStessoTipo, CreateOn, ModifiedOn," & _
    " CreatedBy, ModifiedBy, Id FROM dbo.Conf_Mobilita WHERE (Id = @Id)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nr_CambiGStessoTipo", System.Data.SqlDbType.Int, 4, "Nr_CambiGStessoTipo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nr_CambiMStessoTipo", System.Data.SqlDbType.Int, 4, "Nr_CambiMStessoTipo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreateOn", System.Data.SqlDbType.DateTime, 8, "CreateOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime, 8, "ModifiedOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreatedBy", System.Data.SqlDbType.VarChar, 50, "CreatedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModifiedBy", System.Data.SqlDbType.VarChar, 50, "ModifiedBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsConfMobilita1
    '
    Me.DsConfMobilita1.DataSetName = "DsConfMobilita"
    Me.DsConfMobilita1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsConfMobilita1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents pnlMessage As System.Web.UI.WebControls.Panel
  Protected WithEvents btnConferma As System.Web.UI.WebControls.Button
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daConf As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsConfMobilita1 As ATCBussm1.DsConfMobilita
  Protected WithEvents ValidationSummary1 As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblNr_CambiGStessoTipo As System.Web.UI.WebControls.Label
  Protected WithEvents txtNr_CambiGStessoTipo As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblNr_CambiMStessoTipo As System.Web.UI.WebControls.Label
  Protected WithEvents txtNr_CambiMStessoTipo As System.Web.UI.WebControls.TextBox
  Protected WithEvents cvInputField As System.Web.UI.WebControls.CustomValidator

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
  Private newData As Boolean = False
  '
  Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    oUtente = Session("User")

    daConf.Fill(DsConfMobilita1, "Conf_Mobilita")

    If Not DsConfMobilita1.Tables("Conf_Mobilita").Rows.Count > 0 Then
      newData = True
      Dim dr As DataRow
      dr = DsConfMobilita1.Tables("Conf_Mobilita").NewRow
      dr.Item("Id") = Guid.NewGuid
      dr.Item("Nr_CambiGStessoTipo") = 0
      dr.Item("Nr_CambiMStessoTipo") = 0
      DsConfMobilita1.Tables("Conf_Mobilita").Rows.InsertAt(dr, 0)
    End If

    If Not IsPostBack Then
      txtNr_CambiGStessoTipo.Text = DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("Nr_CambiGStessoTipo")
      txtNr_CambiMStessoTipo.Text = DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("Nr_CambiMStessoTipo")
    End If

  End Sub

  Private Sub btnConferma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferma.Click
    pMessageVisibility(Me.IsValid)
    If Me.IsValid Then

      DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("Nr_CambiGStessoTipo") = txtNr_CambiGStessoTipo.Text
      DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("Nr_CambiMStessoTipo") = txtNr_CambiMStessoTipo.Text
      DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("ModifiedOn") = Now
      DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("ModifiedBy") = oUtente.Nome

      If newData Then
        DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("CreateOn") = Now
        DsConfMobilita1.Tables("Conf_Mobilita").Rows(0).Item("CreatedBy") = oUtente.Nome
      End If

      daConf.Update(DsConfMobilita1, "Conf_Mobilita")

    End If
  End Sub

  Private Sub pMessageVisibility(ByVal visible As Boolean)
    pnlMessage.Visible = visible
    For Each c As Control In pnlMessage.Controls
      c.Visible = visible
    Next
  End Sub

  Private Sub cvInputField_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvInputField.ServerValidate
    Dim result As Boolean = True

    If Not System.Text.RegularExpressions.Regex.Match(txtNr_CambiGStessoTipo.Text, "\d+").Success() Then result = False
    If Not System.Text.RegularExpressions.Regex.Match(txtNr_CambiMStessoTipo.Text, "\d+").Success() Then result = False

    args.IsValid = result
  End Sub
End Class
