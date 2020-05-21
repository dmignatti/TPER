Public Class wf_basesosta
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
		Me.con = New System.Data.SqlClient.SqlConnection
		Me.DaPianoSosta = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
		Me.DaLavoriStradaliZone = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
		Me.DsPianoSosta = New ATCBussm1.DsPianoSosta
		Me.DaPianoSostaZona = New System.Data.SqlClient.SqlDataAdapter
		Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
		CType(Me.DsPianoSosta, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'con
		'
		Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
		'
		'DaPianoSosta
		'
		Me.DaPianoSosta.DeleteCommand = Me.SqlDeleteCommand1
		Me.DaPianoSosta.InsertCommand = Me.SqlInsertCommand1
		Me.DaPianoSosta.SelectCommand = Me.SqlSelectCommand1
		Me.DaPianoSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PianoSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Ordinaria", "Ordinaria"), New System.Data.Common.DataColumnMapping("RapidaRot", "RapidaRot"), New System.Data.Common.DataColumnMapping("Residenti", "Residenti"), New System.Data.Common.DataColumnMapping("Disabili", "Disabili"), New System.Data.Common.DataColumnMapping("Generici", "Generici"), New System.Data.Common.DataColumnMapping("Carico_scarico", "Carico_scarico"), New System.Data.Common.DataColumnMapping("PostiMoto", "PostiMoto")})})
		Me.DaPianoSosta.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.PianoSosta WHERE (Id = @Id)"
		Me.SqlDeleteCommand1.Connection = Me.con
		Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.PianoSosta(Id, IdZona, Ordinaria, RapidaRot, Residenti, Disabili," & _
		" Generici, Carico_scarico, PostiMoto) VALUES (@Id, @IdZona, @Ordinaria, @RapidaR" & _
		"ot, @Residenti, @Disabili, @Generici, @Carico_scarico, @PostiMoto); SELECT Id, I" & _
		"dZona, Ordinaria, RapidaRot, Residenti, Disabili, Generici, Carico_scarico, Post" & _
		"iMoto FROM dbo.PianoSosta WHERE (Id = @Id)"
		Me.SqlInsertCommand1.Connection = Me.con
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.Int, 4, "IdZona"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Int, 4, "Ordinaria"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RapidaRot", System.Data.SqlDbType.Int, 4, "RapidaRot"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Residenti", System.Data.SqlDbType.Int, 4, "Residenti"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Disabili", System.Data.SqlDbType.Int, 4, "Disabili"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Generici", System.Data.SqlDbType.Int, 4, "Generici"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Carico_scarico", System.Data.SqlDbType.Int, 4, "Carico_scarico"))
		Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PostiMoto", System.Data.SqlDbType.Int, 4, "PostiMoto"))
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT Id, IdZona, Ordinaria, RapidaRot, Residenti, Disabili, Generici, Carico_sc" & _
		"arico, PostiMoto FROM dbo.PianoSosta"
		Me.SqlSelectCommand1.Connection = Me.con
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.PianoSosta SET Id = @Id, IdZona = @IdZona, Ordinaria = @Ordinaria, Rap" & _
		"idaRot = @RapidaRot, Residenti = @Residenti, Disabili = @Disabili, Generici = @G" & _
		"enerici, Carico_scarico = @Carico_scarico, PostiMoto = @PostiMoto WHERE (Id = @O" & _
		"riginal_Id) AND (Carico_scarico = @Original_Carico_scarico OR @Original_Carico_s" & _
		"carico IS NULL AND Carico_scarico IS NULL) AND (Disabili = @Original_Disabili OR" & _
		" @Original_Disabili IS NULL AND Disabili IS NULL) AND (Generici = @Original_Gene" & _
		"rici OR @Original_Generici IS NULL AND Generici IS NULL) AND (IdZona = @Original" & _
		"_IdZona OR @Original_IdZona IS NULL AND IdZona IS NULL) AND (Ordinaria = @Origin" & _
		"al_Ordinaria OR @Original_Ordinaria IS NULL AND Ordinaria IS NULL) AND (PostiMot" & _
		"o = @Original_PostiMoto OR @Original_PostiMoto IS NULL AND PostiMoto IS NULL) AN" & _
		"D (RapidaRot = @Original_RapidaRot OR @Original_RapidaRot IS NULL AND RapidaRot " & _
		"IS NULL) AND (Residenti = @Original_Residenti OR @Original_Residenti IS NULL AND" & _
		" Residenti IS NULL); SELECT Id, IdZona, Ordinaria, RapidaRot, Residenti, Disabil" & _
		"i, Generici, Carico_scarico, PostiMoto FROM dbo.PianoSosta WHERE (Id = @Id)"
		Me.SqlUpdateCommand1.Connection = Me.con
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16, "Id"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.Int, 4, "IdZona"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Int, 4, "Ordinaria"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RapidaRot", System.Data.SqlDbType.Int, 4, "RapidaRot"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Residenti", System.Data.SqlDbType.Int, 4, "Residenti"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Disabili", System.Data.SqlDbType.Int, 4, "Disabili"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Generici", System.Data.SqlDbType.Int, 4, "Generici"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Carico_scarico", System.Data.SqlDbType.Int, 4, "Carico_scarico"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PostiMoto", System.Data.SqlDbType.Int, 4, "PostiMoto"))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Carico_scarico", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Carico_scarico", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Disabili", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Disabili", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Generici", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Generici", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdZona", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinaria", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PostiMoto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostiMoto", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RapidaRot", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RapidaRot", System.Data.DataRowVersion.Original, Nothing))
		Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Residenti", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Residenti", System.Data.DataRowVersion.Original, Nothing))
		'
		'DaLavoriStradaliZone
		'
		Me.DaLavoriStradaliZone.SelectCommand = Me.SqlSelectCommand2
		Me.DaLavoriStradaliZone.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LavoriStradaliZone", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Zona", "Zona"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = "SELECT IdZona, Zona, Tipo FROM dbo.LavoriStradaliZone ORDER BY Tipo"
		Me.SqlSelectCommand2.Connection = Me.con
		'
		'DsPianoSosta
		'
		Me.DsPianoSosta.DataSetName = "DsPianoSosta"
		Me.DsPianoSosta.Locale = New System.Globalization.CultureInfo("it-IT")
		'
		'DaPianoSostaZona
		'
		Me.DaPianoSostaZona.SelectCommand = Me.SqlSelectCommand3
		Me.DaPianoSostaZona.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PianoSostaZona", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdZona", "IdZona"), New System.Data.Common.DataColumnMapping("Ordinaria", "Ordinaria"), New System.Data.Common.DataColumnMapping("RapidaRot", "RapidaRot"), New System.Data.Common.DataColumnMapping("Residenti", "Residenti"), New System.Data.Common.DataColumnMapping("Disabili", "Disabili"), New System.Data.Common.DataColumnMapping("Generici", "Generici"), New System.Data.Common.DataColumnMapping("Carico_scarico", "Carico_scarico"), New System.Data.Common.DataColumnMapping("PostiMoto", "PostiMoto"), New System.Data.Common.DataColumnMapping("Zona", "Zona"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
		'
		'SqlSelectCommand3
		'
		Me.SqlSelectCommand3.CommandText = "SELECT dbo.PianoSosta.Id, dbo.PianoSosta.IdZona, dbo.PianoSosta.Ordinaria, dbo.Pi" & _
		"anoSosta.RapidaRot, dbo.PianoSosta.Residenti, dbo.PianoSosta.Disabili, dbo.Piano" & _
		"Sosta.Generici, dbo.PianoSosta.Carico_scarico, dbo.PianoSosta.PostiMoto, dbo.Lav" & _
		"oriStradaliZone.Zona, dbo.LavoriStradaliZone.Tipo FROM dbo.PianoSosta INNER JOIN" & _
		" dbo.LavoriStradaliZone ON dbo.PianoSosta.IdZona = dbo.LavoriStradaliZone.IdZona" & _
		" ORDER BY dbo.LavoriStradaliZone.Tipo"
		Me.SqlSelectCommand3.Connection = Me.con
		CType(Me.DsPianoSosta, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaPianoSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaLavoriStradaliZone As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsPianoSosta As ATCBussm1.DsPianoSosta
  Protected WithEvents dgPianoSosta As System.Web.UI.WebControls.DataGrid
	Protected WithEvents pnlRicaviSosta As System.Web.UI.WebControls.Panel
  Protected WithEvents DaPianoSostaZona As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents pnlPianoSosta As System.Web.UI.WebControls.Panel
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
	Protected WithEvents btnAddNew As System.Web.UI.WebControls.Button

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
    'Put user code to initialize the page here

    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")

    If Not IsPostBack Then
      Ricerca()
    End If

  End Sub

  Private Sub Ricerca()

    DsPianoSosta.Tables("PianoSostaZona").Clear()
    DaPianoSostaZona.Fill(DsPianoSosta.Tables("PianoSostaZona"))

    dgPianoSosta.CurrentPageIndex = 0
    dgPianoSosta.DataBind()
    pnlPianoSosta.Visible = True
    dgPianoSosta.Visible = True

  End Sub

  Public Sub pDataGridEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgPianoSosta.EditItemIndex = e.Item.ItemIndex
    DaLavoriStradaliZone.Fill(DsPianoSosta.Tables("LavoriStradaliZone"))
    Ricerca()

    DaLavoriStradaliZone.Fill(DsPianoSosta.Tables("LavoriStradaliZone"))
    DirectCast(dgPianoSosta.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).DataBind()

    If e.Item.Cells(1).Text <> "&nbsp;" Then
      DirectCast(dgPianoSosta.Items(e.Item.ItemIndex).Cells(2).Controls(1), DropDownList).SelectedValue = e.Item.Cells(1).Text
    End If

  End Sub

  Public Sub pDataGridDelete(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
    Dim drF As DataRow
    DaPianoSosta.Fill(DsPianoSosta, "PianoSosta")
    drF = DsPianoSosta.Tables("PianoSosta").Rows.Find(dgPianoSosta.DataKeys.Item(e.Item.ItemIndex))
    If Not drF Is Nothing Then
      drF.Delete()
      DaPianoSosta.Update(DsPianoSosta, "PianoSosta")
    End If
    dgPianoSosta.EditItemIndex = -1
    Ricerca()
  End Sub

  Public Sub pItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
    Dim myDeleteButton As LinkButton

    myDeleteButton = e.Item.FindControl("LnkDelete")
    If Not myDeleteButton Is Nothing Then
      myDeleteButton.Attributes.Add("onclick", "return confirm('Sei sicuro di voler eliminare questa riga?');")
    End If

  End Sub

  Public Sub pDataGridCancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    dgPianoSosta.EditItemIndex = -1
    Ricerca()

  End Sub

  Public Sub pDataGridUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

    Dim drF As Data.DataRow
    Dim DataI As DateTime
    Dim Budget As Double
    Dim Consuntivo As Double

    Me.Validate()
    If Me.IsValid Then

      DaPianoSosta.Fill(DsPianoSosta.Tables("PianoSosta"))
      drF = DsPianoSosta.Tables("PianoSosta").Rows.Find(dgPianoSosta.DataKeys(e.Item.ItemIndex))

      If drF Is Nothing Then
        drF = DsPianoSosta.Tables("PianoSosta").NewRow
        drF.Item("Id") = dgPianoSosta.DataKeys(e.Item.ItemIndex)
        DsPianoSosta.Tables("PianoSosta").Rows.Add(drF)
      End If

      drF.Item("IdZona") = CInt(DirectCast(e.Item.Cells(2).Controls(1), DropDownList).SelectedValue)
      drF.Item("Ordinaria") = CDbl(IIf(DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(3).Controls(1), TextBox).Text.Trim))
      drF.Item("RapidaRot") = CDbl(IIf(DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(4).Controls(1), TextBox).Text.Trim))
      drF.Item("Residenti") = CDbl(IIf(DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(5).Controls(1), TextBox).Text.Trim))
      drF.Item("Disabili") = CDbl(IIf(DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(6).Controls(1), TextBox).Text.Trim))
      drF.Item("Generici") = CDbl(IIf(DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(7).Controls(1), TextBox).Text.Trim))
      drF.Item("Carico_Scarico") = CDbl(IIf(DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(8).Controls(1), TextBox).Text.Trim))
      drF.Item("PostiMoto") = CDbl(IIf(DirectCast(e.Item.Cells(9).Controls(1), TextBox).Text.Trim = "", 0, DirectCast(e.Item.Cells(9).Controls(1), TextBox).Text.Trim))

      DaPianoSosta.Update(DsPianoSosta, "PianoSosta")
      Ricerca()
      dgPianoSosta.EditItemIndex = -1
      dgPianoSosta.DataBind()

    End If

  End Sub

	'------------------------------------------
	Public Sub CVNumerico_OnServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
		args.IsValid = IsNumeric(DirectCast(DirectCast(source, CustomValidator).Parent.Controls(1), TextBox).Text)
	End Sub

	Private Sub dgPianoSosta_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPianoSosta.DeleteCommand
		pDataGridDelete(source, e)
	End Sub

	Private Sub dgPianoSosta_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgPianoSosta.ItemCreated
		pItemCreated(sender, e)
	End Sub

	Private Sub dgPianoSosta_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPianoSosta.EditCommand
		pDataGridEdit(source, e)
	End Sub

	Private Sub dgPianoSosta_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPianoSosta.UpdateCommand
		pDataGridUpdate(source, e)
	End Sub

	Private Sub dgPianoSosta_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgPianoSosta.CancelCommand
		pDataGridCancel(source, e)
	End Sub

	Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
		Dim dr As Data.DataRow
		DaPianoSostaZona.Fill(DsPianoSosta, "PianoSostaZona")
		dr = DsPianoSosta.Tables("PianoSostaZona").NewRow
		dr.Item("Id") = Guid.NewGuid
		DsPianoSosta.Tables("PianoSostaZona").Rows.InsertAt(dr, 0)
		dgPianoSosta.EditItemIndex = 0
		dgPianoSosta.DataBind()

		DaLavoriStradaliZone.Fill(DsPianoSosta.Tables("LavoriStradaliZone"))
		DirectCast(dgPianoSosta.Items(dgPianoSosta.EditItemIndex).Cells(2).Controls(1), DropDownList).DataBind()
	End Sub
End Class
