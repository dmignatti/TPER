Imports System.Data.SqlClient
Public Class wf_autoparchimetri
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daUtenti = New System.Data.SqlClient.SqlDataAdapter
    Me.dvUtenti = New System.Data.DataView
    Me.DsBiglietterie1 = New ATCBussm1.dsBiglietterie
    CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT REPLACE(STR(A.NUMERATORE, 8), ' ', '0') + REPLACE(SPACE(8 - LEN(CASE WHEN " & _
    "V.MATAUTO IS NULL THEN '' ELSE V.MATAUTO END)), ' ', '0') + CASE WHEN V.MATAUTO " & _
    "IS NULL THEN '' ELSE V.MatAuto END AS ID, A.NUMERATORE, A.DATA_INSERIMENTO, A.MA" & _
    "TRICOLA, A.COGNOME, A.NOME, A.VIA, A.NUMEROVIA, A.CITTA, A.CAP, A.TELEFONO, A.MA" & _
    "IL, A.DSI, V.MATAUTO, T.DSI AS TIPO, V.DATAVENDITA, V.DATARESO, A.ATTIVA FROM db" & _
    "o.AutoParchimetri_Anagrafiche A LEFT OUTER JOIN dbo.AutoParchimetri_Venduti V ON" & _
    " A.NUMERATORE = V.NUMERATORE LEFT OUTER JOIN dbo.AutoParchimetri_Tipi T ON V.DSI" & _
    " = T.ID_DSI"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.AutoParchimetri_Anagrafiche(DATA_INSERIMENTO, MATRICOLA, COGNOME," & _
    " NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO, MAIL, DSI) VALUES (@DATA_INSERIMENT" & _
    "O, @MATRICOLA, @COGNOME, @NOME, @VIA, @NUMEROVIA, @CITTA, @CAP, @TELEFONO, @MAIL" & _
    ", @DSI); SELECT NUMERATORE, DATA_INSERIMENTO, MATRICOLA, COGNOME, NOME, VIA, NUM" & _
    "EROVIA, CITTA, CAP, TELEFONO, MAIL, DSI FROM dbo.AutoParchimetri_Anagrafiche WHE" & _
    "RE (NUMERATORE = @@IDENTITY)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATA_INSERIMENTO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VIA", System.Data.SqlDbType.VarChar, 255, "VIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMEROVIA", System.Data.SqlDbType.VarChar, 50, "NUMEROVIA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CITTA", System.Data.SqlDbType.VarChar, 50, "CITTA"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CAP", System.Data.SqlDbType.VarChar, 5, "CAP"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TELEFONO", System.Data.SqlDbType.VarChar, 50, "TELEFONO"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MAIL", System.Data.SqlDbType.VarChar, 50, "MAIL"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.AutoParchimetri_Anagrafiche SET DATA_INSERIMENTO = @DATA_INSERIMENTO, " & _
    "MATRICOLA = @MATRICOLA, COGNOME = @COGNOME, NOME = @NOME, VIA = @VIA, NUMEROVIA " & _
    "= @NUMEROVIA, CITTA = @CITTA, CAP = @CAP, TELEFONO = @TELEFONO, MAIL = @MAIL, DS" & _
    "I = @DSI WHERE (NUMERATORE = @Original_NUMERATORE) AND (CAP = @Original_CAP OR @" & _
    "Original_CAP IS NULL AND CAP IS NULL) AND (CITTA = @Original_CITTA OR @Original_" & _
    "CITTA IS NULL AND CITTA IS NULL) AND (COGNOME = @Original_COGNOME OR @Original_C" & _
    "OGNOME IS NULL AND COGNOME IS NULL) AND (DATA_INSERIMENTO = @Original_DATA_INSER" & _
    "IMENTO OR @Original_DATA_INSERIMENTO IS NULL AND DATA_INSERIMENTO IS NULL) AND (" & _
    "DSI = @Original_DSI OR @Original_DSI IS NULL AND DSI IS NULL) AND (MAIL = @Origi" & _
    "nal_MAIL OR @Original_MAIL IS NULL AND MAIL IS NULL) AND (MATRICOLA = @Original_" & _
    "MATRICOLA OR @Original_MATRICOLA IS NULL AND MATRICOLA IS NULL) AND (NOME = @Ori" & _
    "ginal_NOME OR @Original_NOME IS NULL AND NOME IS NULL) AND (NUMEROVIA = @Origina" & _
    "l_NUMEROVIA OR @Original_NUMEROVIA IS NULL AND NUMEROVIA IS NULL) AND (TELEFONO " & _
    "= @Original_TELEFONO OR @Original_TELEFONO IS NULL AND TELEFONO IS NULL) AND (VI" & _
    "A = @Original_VIA OR @Original_VIA IS NULL AND VIA IS NULL); SELECT NUMERATORE, " & _
    "DATA_INSERIMENTO, MATRICOLA, COGNOME, NOME, VIA, NUMEROVIA, CITTA, CAP, TELEFONO" & _
    ", MAIL, DSI FROM dbo.AutoParchimetri_Anagrafiche WHERE (NUMERATORE = @NUMERATORE" & _
    ")"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, "DATA_INSERIMENTO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MATRICOLA", System.Data.SqlDbType.VarChar, 30, "MATRICOLA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COGNOME", System.Data.SqlDbType.VarChar, 100, "COGNOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 100, "NOME"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VIA", System.Data.SqlDbType.VarChar, 255, "VIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMEROVIA", System.Data.SqlDbType.VarChar, 50, "NUMEROVIA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CITTA", System.Data.SqlDbType.VarChar, 50, "CITTA"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CAP", System.Data.SqlDbType.VarChar, 5, "CAP"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TELEFONO", System.Data.SqlDbType.VarChar, 50, "TELEFONO"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MAIL", System.Data.SqlDbType.VarChar, 50, "MAIL"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DSI", System.Data.SqlDbType.Int, 4, "DSI"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CITTA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CITTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_INSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MAIL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAIL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMEROVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMEROVIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TELEFONO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VIA", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMERATORE", System.Data.SqlDbType.Int, 4, "NUMERATORE"))
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.AutoParchimetri_Venduti WHERE Numeratore = @Original_Numeratore; " & _
    "DELETE FROM dbo.AutoParchimetri_Anagrafiche WHERE (NUMERATORE = @Original_NUMERA" & _
    "TORE) AND (CAP = @Original_CAP OR @Original_CAP IS NULL AND CAP IS NULL) AND (CI" & _
    "TTA = @Original_CITTA OR @Original_CITTA IS NULL AND CITTA IS NULL) AND (COGNOME" & _
    " = @Original_COGNOME OR @Original_COGNOME IS NULL AND COGNOME IS NULL) AND (DATA" & _
    "_INSERIMENTO = @Original_DATA_INSERIMENTO OR @Original_DATA_INSERIMENTO IS NULL " & _
    "AND DATA_INSERIMENTO IS NULL) AND (DSI = @Original_DSI OR @Original_DSI IS NULL " & _
    "AND DSI IS NULL) AND (MAIL = @Original_MAIL OR @Original_MAIL IS NULL AND MAIL I" & _
    "S NULL) AND (MATRICOLA = @Original_MATRICOLA OR @Original_MATRICOLA IS NULL AND " & _
    "MATRICOLA IS NULL) AND (NOME = @Original_NOME OR @Original_NOME IS NULL AND NOME" & _
    " IS NULL) AND (NUMEROVIA = @Original_NUMEROVIA OR @Original_NUMEROVIA IS NULL AN" & _
    "D NUMEROVIA IS NULL) AND (TELEFONO = @Original_TELEFONO OR @Original_TELEFONO IS" & _
    " NULL AND TELEFONO IS NULL) AND (VIA = @Original_VIA OR @Original_VIA IS NULL AN" & _
    "D VIA IS NULL); SELECT REPLACE(STR(A.NUMERATORE, 8), ' ', '0') + REPLACE(SPACE(8" & _
    " - LEN(V.MATAUTO)), ' ', '0') + V.MATAUTO AS ID, A.NUMERATORE, A.DATA_INSERIMENT" & _
    "O, A.MATRICOLA, A.COGNOME, A.NOME, A.VIA, A.NUMEROVIA, A.CITTA, A.CAP, A.TELEFON" & _
    "O, A.MAIL, A.DSI, V.MATAUTO, T .DSI AS TIPO FROM dbo.AutoParchimetri_Anagrafiche" & _
    " A INNER JOIN dbo.AutoParchimetri_Venduti V ON A.NUMERATORE = V.NUMERATORE INNER" & _
    " JOIN dbo.AutoParchimetri_Tipi T ON V.DSI = T .ID_DSI"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMERATORE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERATORE", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CAP", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAP", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CITTA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CITTA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COGNOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COGNOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DATA_INSERIMENTO", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATA_INSERIMENTO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DSI", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSI", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MAIL", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAIL", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MATRICOLA", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MATRICOLA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOME", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NUMEROVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMEROVIA", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TELEFONO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONO", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VIA", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VIA", System.Data.DataRowVersion.Original, Nothing))
    '
    'daUtenti
    '
    Me.daUtenti.DeleteCommand = Me.SqlDeleteCommand1
    Me.daUtenti.InsertCommand = Me.SqlInsertCommand1
    Me.daUtenti.SelectCommand = Me.SqlSelectCommand1
    Me.daUtenti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AutoParchimetri_Anagrafiche", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMERATORE", "NUMERATORE"), New System.Data.Common.DataColumnMapping("DATA_INSERIMENTO", "DATA_INSERIMENTO"), New System.Data.Common.DataColumnMapping("MATRICOLA", "MATRICOLA"), New System.Data.Common.DataColumnMapping("COGNOME", "COGNOME"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("VIA", "VIA"), New System.Data.Common.DataColumnMapping("NUMEROVIA", "NUMEROVIA"), New System.Data.Common.DataColumnMapping("CITTA", "CITTA"), New System.Data.Common.DataColumnMapping("CAP", "CAP"), New System.Data.Common.DataColumnMapping("TELEFONO", "TELEFONO"), New System.Data.Common.DataColumnMapping("MAIL", "MAIL"), New System.Data.Common.DataColumnMapping("DSI", "DSI")})})
    Me.daUtenti.UpdateCommand = Me.SqlUpdateCommand1
    '
    'dvUtenti
    '
    Me.dvUtenti.ApplyDefaultSort = True
    Me.dvUtenti.Sort = "Cognome, Nome"
    Me.dvUtenti.Table = Me.DsBiglietterie1.AutoParchimetri_Anagrafiche
    '
    'DsBiglietterie1
    '
    Me.DsBiglietterie1.DataSetName = "dsBiglietterie"
    Me.DsBiglietterie1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.dvUtenti, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsBiglietterie1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents lblNoAutoparchimetri As System.Web.UI.WebControls.Label
  Protected WithEvents btnAddAuto As System.Web.UI.WebControls.Button
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daUtenti As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents dvUtenti As System.Data.DataView
  Protected WithEvents DsBiglietterie1 As ATCBussm1.dsBiglietterie
  Protected WithEvents lblCerca As System.Web.UI.WebControls.Label
  Protected WithEvents txtCerca As System.Web.UI.WebControls.TextBox
  Protected WithEvents ddlModifier As System.Web.UI.WebControls.DropDownList
  Protected WithEvents btnCerca As System.Web.UI.WebControls.Button
  Protected WithEvents txtFake As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblCount As System.Web.UI.WebControls.Label
  Protected WithEvents btnAdd2 As System.Web.UI.WebControls.Button
  Protected WithEvents LblNAcquistiStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblNVenditeStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblNResiStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblNRimanenzeStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblNAcquistiDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblNVenditeDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblNResiDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblNRimanenzeDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblAcquistiDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblVenditeDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblResiDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblRimanenzeDSI As System.Web.UI.WebControls.Label
  Protected WithEvents LblAcquistiStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblVenditeStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblResiStd As System.Web.UI.WebControls.Label
  Protected WithEvents LblRimanenzeStd As System.Web.UI.WebControls.Label
  Protected WithEvents lnkAnnullaRicerca As System.Web.UI.WebControls.LinkButton
  Protected WithEvents vsErrori As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lnkRicercaAvanzata As System.Web.UI.WebControls.LinkButton
  Protected WithEvents pnlRicercaSemplice As System.Web.UI.WebControls.Panel
  Protected WithEvents lblDataDa As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataDa As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDataA As System.Web.UI.WebControls.Label
  Protected WithEvents txtDataA As System.Web.UI.WebControls.TextBox
  Protected WithEvents cvDataA As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents cvDataDa As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents lnkRicercaSemplice As System.Web.UI.WebControls.LinkButton
  Protected WithEvents btnRicercaAvanzata As System.Web.UI.WebControls.Button
  Protected WithEvents pnlRicercaAvanzata As System.Web.UI.WebControls.Panel
  Protected WithEvents lblInfVendite As System.Web.UI.WebControls.Label
  Protected WithEvents cvDataA1 As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents ChkSoloAttivi As System.Web.UI.WebControls.CheckBox
  Protected WithEvents Chk As System.Web.UI.WebControls.CheckBox
  Protected WithEvents adgUtenti As System.Web.UI.WebControls.DataGrid

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
    daUtenti.Fill(DsBiglietterie1)
    If Not IsPostBack Then
      Page.DataBind()

    End If
    If pnlRicercaSemplice.Visible Then
      dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
    Else
      dvUtenti.RowFilter = pCreateAdvancedFilter()
    End If
    adgUtenti.DataBind()

    SituazioneMagazzino()
  End Sub

  Private Function pCreateAdvancedFilter() As String
    Dim s As String = ""
    Dim r As String = ""
    Dim FiltroVendite As String = ""
    Dim FiltroReso As String = ""

    If txtDataDa.Text.Trim.Length > 0 Then
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA >='" & CDate(txtDataDa.Text.Trim) & "' And DATAVENDITA < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "'"
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO >='" & CDate(txtDataDa.Text.Trim) & "' And DATARESO < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "'"

      Else
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA >= '" & CDate(txtDataDa.Text.Trim) & "' And DATAVENDITA < '" & CDate(Format(Now, "dd/MM/yyyy")).AddDays(1) & "'"
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO >= '" & CDate(txtDataDa.Text.Trim) & "' And DATARESO <  '" & CDate(Format(Now, "dd/MM/yyyy")).AddDays(1) & "'"

      End If
    Else
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "' "
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO < '" & CDate(txtDataA.Text.Trim).AddDays(1) & "' "

      End If
    End If
    If (ChkSoloAttivi.Checked) Then
      If (s.Trim = "") Then
        s = "ATTIVA=1"
      Else
        s = "(" & s & ") AND ATTIVA=1"
      End If
    End If
    pCreateAdvancedFilter = s
    FiltroVendite = s
    FiltroReso = r
    VenditeXData()


  End Function

  Private Sub SituazioneMagazzino()
    Dim SqlAcq As String
    Dim SqlVenditeDSI As String
    Dim SqlVenditeST As String
    Dim SqlResiDSI As String
    Dim SqlResiST As String

    Dim IAcquistiDSI As Integer
    Dim IAcquistiSt As Integer
    Dim IVenditeDSI As Integer
    Dim IVenditeST As Integer
    Dim IResiDSI As Integer
    Dim IResiSt As Integer
    Dim ScortaDSI As Integer
    Dim ScortaST As Integer

    SqlAcq = "SELECT SUM(isnull(AcquistiATC,0)) AS TotAcquistiATC, SUM(isnull(AcquistiDSI,0)) AS TotAcquistiDSI FROM Autoparchimetri"
    SqlVenditeDSI = "SELECT COUNT( *) as TotVenditaDSI FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 1)"
    SqlVenditeST = "SELECT COUNT( *) as TotVenditaSt FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 2)"
    SqlResiDSI = "SELECT COUNT( *) as TotResiDSI FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 1) AND (NOT(DATARESO IS NULL))"
    SqlResiST = "SELECT COUNT( *) as TotResiSt FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 2) AND (NOT(DATARESO IS NULL))"

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
      Exit Sub
    End Try

    Try
      cmd = New SqlCommand(SqlAcq, cnn)
      cmd.CommandType = CommandType.Text
      cmd.CommandTimeout = 15
    Catch ex As Exception
      cnn.Close()
      cnn.Dispose()
      Throw New Exception("Errore di creazione comando SQL")
    End Try
    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        IAcquistiDSI = dr("TotAcquistiDSI")
        IAcquistiSt = dr("TotAcquistiATC")
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di lettura dati")
    Finally
      dr.Close()
    End Try

    Try
      cmd.CommandText = SqlVenditeDSI
      IVenditeDSI = cmd.ExecuteScalar
      cmd.CommandText = SqlVenditeST
      IVenditeST = cmd.ExecuteScalar
      cmd.CommandText = SqlResiDSI
      IResiDSI = cmd.ExecuteScalar
      cmd.CommandText = SqlResiST
      IResiSt = cmd.ExecuteScalar
    Catch ex As Exception
      Throw New Exception("Errore di lettura dati")
    End Try

    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()
    ScortaDSI = IAcquistiDSI - IVenditeDSI
    ScortaST = IAcquistiSt - IVenditeST
    LblAcquistiDSI.Text = "Acquisti DSI: "
    LblNAcquistiDSI.Text = IAcquistiDSI.ToString.Trim
    LblVenditeDSI.Text = "Vendite DSI: "
    LblNVenditeDSI.Text = IVenditeDSI.ToString.Trim
    LblResiDSI.Text = "Resi DSI: "
    LblNResiDSI.Text = IResiDSI.ToString.Trim
    LblRimanenzeDSI.Text = "Rimanenza DSI: "
    LblNRimanenzeDSI.Text = ScortaDSI.ToString.Trim
    LblAcquistiStd.Text = "Acquisti standard: "
    LblNAcquistiStd.Text = IAcquistiSt.ToString.Trim
    LblVenditeStd.Text = "Vendite standard: "
    LblNVenditeStd.Text = IVenditeST.ToString.Trim
    LblResiStd.Text = "Resi standard: "
    LblNResiStd.Text = IResiSt.ToString.Trim
    LblRimanenzeStd.Text = "Rimanenza standard: "
    LblNRimanenzeStd.Text = ScortaST.ToString.Trim

  End Sub


  Private Sub ReBind(Optional ByVal BackTo0 As Boolean = False, Optional ByVal CancelEdit As Boolean = False)
    If BackTo0 Then adgUtenti.CurrentPageIndex = 0
    If CancelEdit Then adgUtenti.EditItemIndex = -1
    adgUtenti.DataBind()
    lblNoAutoparchimetri.DataBind()
    lblCount.DataBind()
  End Sub

  Private Function pCreateFilter(ByVal Filter As String, ByVal Modifier As Integer, Optional ByVal DefaultFilter As String = "") As String
    If Filter.Trim.Length > 0 Then
      Dim where As String = ""
      Dim s As String = Filter.Trim
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
          If Modifier <> 1 Then
            where &= " Or "
          Else
            where &= " And "
          End If
        End If
        where &= "(Cognome Like '%" & s & "%' Or Nome Like '%" & s & "%' Or Via Like '%" & s & "%' Or Citta Like '%" & s & "%' Or Tipo Like '%" & s & "%' Or Matauto Like '%" & s & "%')"
      Next
      If (ChkSoloAttivi.Checked) Then
        pCreateFilter = "(" & where & ") AND ATTIVA=1"
      Else
        pCreateFilter = where
      End If


    Else
      If (ChkSoloAttivi.Checked) Then
        If (DefaultFilter.Trim = "") Then
          pCreateFilter = "ATTIVA=1"
        Else
          pCreateFilter = "(" & DefaultFilter & ") AND ATTIVA=1"
        End If
      Else
        pCreateFilter = DefaultFilter

      End If

    End If
    lblInfVendite.Text = ""
  End Function

  Private Sub VenditeXData()
    Dim SqlVenditeDSI As String
    Dim SqlVenditeST As String
    Dim SqlResiDSI As String
    Dim SqlResiST As String

    Dim IVenditeDSI As Integer
    Dim IVenditeST As Integer
    Dim IResiDSI As Integer
    Dim IResiSt As Integer
    Dim s As String = ""
    Dim r As String = ""

    If txtDataDa.Text.Trim.Length > 0 Then
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA >= CONVERT(DATETIME, '" & Format(CDate(txtDataDa.Text.Trim), "yyyy/MM/dd") & " 00:00:00', 102) And DATAVENDITA <  CONVERT(DATETIME, '" & Format(CDate(txtDataA.Text.Trim).AddDays(1), "yyyy/MM/dd") & " 00:00:00', 102)"
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO >= CONVERT(DATETIME, '" & Format(CDate(txtDataDa.Text.Trim), "yyyy/MM/dd") & " 00:00:00', 102) And DATARESO <  CONVERT(DATETIME, '" & Format(CDate(txtDataA.Text.Trim).AddDays(1), "yyyy/MM/dd") & " 00:00:00', 102)"
      Else
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA >=  CONVERT(DATETIME, '" & Format(CDate(txtDataDa.Text.Trim), "yyyy/MM/dd") & " 00:00:00', 102) And DATAVENDITA <= getdate()"
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO >=  CONVERT(DATETIME, '" & Format(CDate(txtDataDa.Text.Trim), "yyyy/MM/dd") & " 00:00:00', 102) And DATARESO <= getdate()"
      End If
    Else
      If txtDataA.Text.Trim.Length > 0 Then
        s &= IIf(s.Length > 0, " AND ", "") & "DATAVENDITA <  CONVERT(DATETIME, '" & Format(CDate(txtDataA.Text.Trim).AddDays(1), "yyyy/MM/dd") & " 00:00:00', 102) "
        r &= IIf(r.Length > 0, " AND ", "") & "DATARESO <  CONVERT(DATETIME, '" & Format(CDate(txtDataA.Text.Trim).AddDays(1), "yyyy/MM/dd") & " 00:00:00', 102) "
      End If
    End If

    SqlVenditeDSI = "SELECT COUNT( *) as TotVenditaDSI FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 1)" & IIf(s.Trim > "", " and " & s, "")
    SqlVenditeST = "SELECT COUNT( *) as TotVenditaSt FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 2) " & IIf(s.Trim > "", " and " & s, "")
    SqlResiDSI = "SELECT COUNT( *) as TotResiDSI FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 1) AND (NOT(DATARESO IS NULL)) " & IIf(r.Trim > "", " and " & r, "")
    SqlResiST = "SELECT COUNT( *) as TotResiSt FROM AutoParchimetri_Venduti WHERE (NOT (DATAVENDITA IS NULL)) AND (DSI = 2) AND (NOT(DATARESO IS NULL)) " & IIf(r.Trim > "", " and " & r, "")

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
      Exit Sub
    End Try

    Try
      cmd = New SqlCommand(SqlVenditeDSI, cnn)
      cmd.CommandType = CommandType.Text
      cmd.CommandTimeout = 15
    Catch ex As Exception
      cnn.Close()
      cnn.Dispose()
      Throw New Exception("Errore di creazione comando SQL")
    End Try

    Try
      cmd.CommandText = SqlVenditeDSI
      IVenditeDSI = cmd.ExecuteScalar
      cmd.CommandText = SqlVenditeST
      IVenditeST = cmd.ExecuteScalar
      cmd.CommandText = SqlResiDSI
      IResiDSI = cmd.ExecuteScalar
      cmd.CommandText = SqlResiST
      IResiSt = cmd.ExecuteScalar
    Catch ex As Exception
      Throw New Exception("Errore di lettura dati")
    End Try

    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()
    lblInfVendite.Text = "Vendite DSI: " & IVenditeDSI.ToString.Trim & " - Resi DSI: " & IResiDSI.ToString.Trim & " - Vendite standard: " & IVenditeST.ToString.Trim & " - Resi standard: " & IResiSt.ToString.Trim

  End Sub

  Private Sub btnCerca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerca.Click
    ReBind(True)
  End Sub


  Private Sub AttivaANA(ByVal id As Int32)
    Dim oConn As SqlConnection
    oConn = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    oConn.Open()

    Dim strSQL As String
    Dim myCommand As New SqlCommand

    myCommand.Connection = oConn

    strSQL = "UPDATE AutoParchimetri_Anagrafiche SET ATTIVA=1 WHERE (NUMERATORE=" & id & ")"
    Try
      myCommand.CommandText = strSQL
      myCommand.ExecuteNonQuery()

    Catch e As Exception

    Finally
      oConn.Close()
      oConn.Dispose()
    End Try

    oConn = Nothing
  End Sub

  Private Sub DisattivaANA(ByVal id As Int32)
    Dim oConn As SqlConnection
    oConn = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    oConn.Open()

    Dim strSQL As String
    Dim myCommand As New SqlCommand

    myCommand.Connection = oConn

    strSQL = "UPDATE AutoParchimetri_Anagrafiche SET ATTIVA=0 WHERE (NUMERATORE=" & id & ")"
    Try
      myCommand.CommandText = strSQL
      myCommand.ExecuteNonQuery()

    Catch e As Exception

    Finally
      oConn.Close()
      oConn.Dispose()
    End Try

    oConn = Nothing
  End Sub

  Private Sub btnAddAuto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddAuto.Click
    Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  Private Sub lnkAnnullaRicerca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkAnnullaRicerca.Click

    txtCerca.Text = ""
    ddlModifier.SelectedValue = 0
    dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
    Page.DataBind()

  End Sub

  Private Sub lnkRicercaAvanzata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkRicercaAvanzata.Click
    pnlRicercaSemplice.Visible = False
    pnlRicercaAvanzata.Visible = True
    For Each c As Control In pnlRicercaAvanzata.Controls
      c.Visible = True
    Next
  End Sub

  Private Sub lnkRicercaSemplice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkRicercaSemplice.Click
    pnlRicercaSemplice.Visible = True
    pnlRicercaAvanzata.Visible = False
    For Each c As Control In pnlRicercaSemplice.Controls
      c.Visible = True
    Next
  End Sub

  Private Sub btnRicercaAvanzata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRicercaAvanzata.Click
    ReBind(True)
  End Sub

  Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
    Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")))
  End Sub

  'Private Sub dgUtenti_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles adgUtenti.DeleteCommand
  '  Dim dr As DataRow = DsBiglietterie1.Tables("Autoparchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))
  '  dr.Delete()
  '  daUtenti.Update(DsBiglietterie1)
  '  DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Clear()
  '  daUtenti.Fill(DsBiglietterie1)
  '  ReBind(True)
  '  SituazioneMagazzino()
  'End Sub

  'Private Sub dgUtenti_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles adgUtenti.ItemCommand
  '  Select Case e.CommandName
  '    Case "Navigate"
  '      Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
  '    Case "Attiva"
  '      'Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
  '      AttivaANA(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore"))

  '      daUtenti.Fill(DsBiglietterie1)

  '      If pnlRicercaSemplice.Visible Then
  '        dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
  '      Else
  '        dvUtenti.RowFilter = pCreateAdvancedFilter()
  '      End If


  '      adgUtenti.DataBind()
  '      Page.DataBind()


  '    Case "Disattiva"
  '      'Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
  '      DisattivaANA(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore"))

  '      daUtenti.Fill(DsBiglietterie1)

  '      If pnlRicercaSemplice.Visible Then
  '        dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
  '      Else
  '        dvUtenti.RowFilter = pCreateAdvancedFilter()
  '      End If


  '      adgUtenti.DataBind()
  '      Page.DataBind()
  '      adgUtenti.DataBind()
  '      Page.DataBind()

  '  End Select
  'End Sub

  'Private Sub dgUtenti_ItemCreated(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
  '  If Not e.Item.FindControl("btnDelete") Is Nothing Then
  '    DirectCast(e.Item.FindControl("btnDelete"), ImageButton).Attributes.Add("onClick", "javascript: return confirm('Attenzione! Verranno eliminati anche gli autoparchimetri legati a questo utente.\nProcedere?');")
  '  End If
  'End Sub
  'Private Sub dgUtenti_PageIndexChanged(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs)
  '  adgUtenti.CurrentPageIndex = e.NewPageIndex
  '  ReBind()
  'End Sub


  Private Sub adgUtenti_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles adgUtenti.PageIndexChanged
    adgUtenti.CurrentPageIndex = e.NewPageIndex
    ReBind()
  End Sub

  Private Sub adgUtenti_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles adgUtenti.DeleteCommand
    Dim dr As DataRow = DsBiglietterie1.Tables("Autoparchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))
    dr.Delete()
    daUtenti.Update(DsBiglietterie1)
    DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Clear()
    daUtenti.Fill(DsBiglietterie1)
    ReBind(True)
    SituazioneMagazzino()
  End Sub

  Private Sub adgUtenti_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles adgUtenti.ItemCreated
    If Not e.Item.FindControl("btnDelete") Is Nothing Then
      DirectCast(e.Item.FindControl("btnDelete"), ImageButton).Attributes.Add("onClick", "javascript: return confirm('Attenzione! Verranno eliminati anche gli autoparchimetri legati a questo utente.\nProcedere?');")
    End If
  End Sub

  Sub adgUtenti_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles adgUtenti.ItemCommand
    Select Case e.CommandName
      Case "Navigate"
        Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
      Case "Attiva"
        'Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
        AttivaANA(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore"))

        daUtenti.Fill(DsBiglietterie1)

        If pnlRicercaSemplice.Visible Then
          dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
        Else
          dvUtenti.RowFilter = pCreateAdvancedFilter()
        End If


        adgUtenti.DataBind()
        Page.DataBind()


      Case "Disattiva"
        'Response.Redirect("wf_autoparchimetro.aspx?ModuleID=" & Server.UrlEncode(Request("ModuleID")) & "&ID=" & Server.UrlEncode(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore")))
        DisattivaANA(DsBiglietterie1.Tables("AutoParchimetri_Anagrafiche").Rows.Find(adgUtenti.DataKeys(e.Item.ItemIndex))("Numeratore"))

        daUtenti.Fill(DsBiglietterie1)

        If pnlRicercaSemplice.Visible Then
          dvUtenti.RowFilter = pCreateFilter(txtCerca.Text, ddlModifier.SelectedValue)
        Else
          dvUtenti.RowFilter = pCreateAdvancedFilter()
        End If


        adgUtenti.DataBind()
        Page.DataBind()
        adgUtenti.DataBind()
        Page.DataBind()

    End Select
  End Sub


 

End Class
