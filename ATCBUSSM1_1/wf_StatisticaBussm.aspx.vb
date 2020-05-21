Imports System.Data.SqlClient
Public Class wf_StatisticaBussm
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.ConnDatiAs400 = New System.Data.SqlClient.SqlConnection
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.DaConsuntivoSosta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsConsuntivo = New ATCBussm1.DsConsuntivo
    Me.DaTSanzioniSosta = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DaConsuntivoSostaProvv = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
    Me.ConnSCAT = New System.Data.SqlClient.SqlConnection
    CType(Me.DsConsuntivo, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'ConnDatiAs400
    '
    Me.ConnDatiAs400.ConnectionString = CType(configurationAppSettings.GetValue("ConnDatiAs400", GetType(System.String)), String)
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)
    '
    'DaConsuntivoSosta
    '
    Me.DaConsuntivoSosta.DeleteCommand = Me.SqlDeleteCommand2
    Me.DaConsuntivoSosta.InsertCommand = Me.SqlInsertCommand2
    Me.DaConsuntivoSosta.SelectCommand = Me.SqlSelectCommand3
    Me.DaConsuntivoSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ConsuntivoSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdC", "IdC"), New System.Data.Common.DataColumnMapping("DataC", "DataC"), New System.Data.Common.DataColumnMapping("Consuntivo", "Consuntivo")})})
    Me.DaConsuntivoSosta.UpdateCommand = Me.SqlUpdateCommand2
    '
    'SqlDeleteCommand2
    '
    Me.SqlDeleteCommand2.CommandText = "DELETE FROM dbo.ConsuntivoSosta WHERE (YEAR(DataC) = @anno)"
    Me.SqlDeleteCommand2.Connection = Me.con
    Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand2
    '
    Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.ConsuntivoSosta(IdC, DataC, Consuntivo) VALUES (@IdC, @DataC, @Co" & _
    "nsuntivo); SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSosta WHERE (IdC = @" & _
    "IdC)"
    Me.SqlInsertCommand2.Connection = Me.con
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSosta"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'SqlUpdateCommand2
    '
    Me.SqlUpdateCommand2.CommandText = "UPDATE dbo.ConsuntivoSosta SET IdC = @IdC, DataC = @DataC, Consuntivo = @Consunti" & _
    "vo WHERE (IdC = @Original_IdC) AND (Consuntivo = @Original_Consuntivo OR @Origin" & _
    "al_Consuntivo IS NULL AND Consuntivo IS NULL) AND (DataC = @Original_DataC OR @O" & _
    "riginal_DataC IS NULL AND DataC IS NULL); SELECT IdC, DataC, Consuntivo FROM dbo" & _
    ".ConsuntivoSosta WHERE (IdC = @IdC)"
    Me.SqlUpdateCommand2.Connection = Me.con
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdC", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdC", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Consuntivo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consuntivo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataC", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataC", System.Data.DataRowVersion.Original, Nothing))
    '
    'DsConsuntivo
    '
    Me.DsConsuntivo.DataSetName = "DsConsuntivo"
    Me.DsConsuntivo.Locale = New System.Globalization.CultureInfo("en-US")
    '
    'DaTSanzioniSosta
    '
    Me.DaTSanzioniSosta.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaTSanzioniSosta.InsertCommand = Me.SqlInsertCommand1
    Me.DaTSanzioniSosta.SelectCommand = Me.SqlSelectCommand1
    Me.DaTSanzioniSosta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TSanzioniSosta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdSanzioniSosta", "IdSanzioniSosta"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Totale", "Totale")})})
    Me.DaTSanzioniSosta.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.TSanzioniSosta WHERE (YEAR(Data) = @anno)"
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.TSanzioniSosta(IdSanzioniSosta, Data, Totale) VALUES (@IdSanzioni" & _
    "Sosta, @Data, @Totale); SELECT IdSanzioniSosta, Data, Totale FROM dbo.TSanzioniS" & _
    "osta WHERE (IdSanzioniSosta = @IdSanzioniSosta)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdSanzioniSosta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdSanzioniSosta"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Totale", System.Data.SqlDbType.Float, 8, "Totale"))
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT IdSanzioniSosta, Data, Totale FROM dbo.TSanzioniSosta"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.TSanzioniSosta SET IdSanzioniSosta = @IdSanzioniSosta, Data = @Data, T" & _
    "otale = @Totale WHERE (IdSanzioniSosta = @Original_IdSanzioniSosta) AND (Data = " & _
    "@Original_Data OR @Original_Data IS NULL AND Data IS NULL) AND (Totale = @Origin" & _
    "al_Totale OR @Original_Totale IS NULL AND Totale IS NULL); SELECT IdSanzioniSost" & _
    "a, Data, Totale FROM dbo.TSanzioniSosta WHERE (IdSanzioniSosta = @IdSanzioniSost" & _
    "a)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdSanzioniSosta", System.Data.SqlDbType.UniqueIdentifier, 16, "IdSanzioniSosta"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Data", System.Data.SqlDbType.DateTime, 8, "Data"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Totale", System.Data.SqlDbType.Float, 8, "Totale"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdSanzioniSosta", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdSanzioniSosta", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Data", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Data", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Totale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Totale", System.Data.DataRowVersion.Original, Nothing))
    '
    'DaConsuntivoSostaProvv
    '
    Me.DaConsuntivoSostaProvv.ContinueUpdateOnError = True
    Me.DaConsuntivoSostaProvv.DeleteCommand = Me.SqlDeleteCommand3
    Me.DaConsuntivoSostaProvv.InsertCommand = Me.SqlInsertCommand3
    Me.DaConsuntivoSostaProvv.SelectCommand = Me.SqlSelectCommand2
    Me.DaConsuntivoSostaProvv.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ConsuntivoSostaProvv", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdC", "IdC"), New System.Data.Common.DataColumnMapping("DataC", "DataC"), New System.Data.Common.DataColumnMapping("Consuntivo", "Consuntivo")})})
    Me.DaConsuntivoSostaProvv.UpdateCommand = Me.SqlUpdateCommand3
    '
    'SqlDeleteCommand3
    '
    Me.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.ConsuntivoSostaProvv WHERE (YEAR(DataC) = @anno)"
    Me.SqlDeleteCommand3.Connection = Me.con
    Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand3
    '
    Me.SqlInsertCommand3.CommandText = "INSERT INTO dbo.ConsuntivoSostaProvv(IdC, DataC, Consuntivo) VALUES (@IdC, @DataC" & _
    ", @Consuntivo); SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSostaProvv WHER" & _
    "E (IdC = @IdC)"
    Me.SqlInsertCommand3.Connection = Me.con
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT IdC, DataC, Consuntivo FROM dbo.ConsuntivoSostaProvv"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'SqlUpdateCommand3
    '
    Me.SqlUpdateCommand3.CommandText = "UPDATE dbo.ConsuntivoSostaProvv SET IdC = @IdC, DataC = @DataC, Consuntivo = @Con" & _
    "suntivo WHERE (IdC = @Original_IdC) AND (Consuntivo = @Original_Consuntivo OR @O" & _
    "riginal_Consuntivo IS NULL AND Consuntivo IS NULL) AND (DataC = @Original_DataC " & _
    "OR @Original_DataC IS NULL AND DataC IS NULL); SELECT IdC, DataC, Consuntivo FRO" & _
    "M dbo.ConsuntivoSostaProvv WHERE (IdC = @IdC)"
    Me.SqlUpdateCommand3.Connection = Me.con
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdC", System.Data.SqlDbType.UniqueIdentifier, 16, "IdC"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataC", System.Data.SqlDbType.DateTime, 8, "DataC"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Consuntivo", System.Data.SqlDbType.Float, 8, "Consuntivo"))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdC", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdC", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Consuntivo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consuntivo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DataC", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataC", System.Data.DataRowVersion.Original, Nothing))
    '
    'ConnSCAT
    '
    Me.ConnSCAT.ConnectionString = CType(configurationAppSettings.GetValue("ConnSCAT.ConnectionString", GetType(System.String)), String)
    CType(Me.DsConsuntivo, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents LblMese As System.Web.UI.WebControls.Label
  Protected WithEvents LblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents TxtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnSend As System.Web.UI.WebControls.Button
  Protected WithEvents PnlParametri As System.Web.UI.WebControls.Panel
  Protected WithEvents PnlStatistica As System.Web.UI.WebControls.Panel
  Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
  Protected WithEvents CboMese As System.Web.UI.WebControls.DropDownList
  Protected WithEvents VSConsumiAz As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents CVA As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents LblVisualizza As System.Web.UI.WebControls.Label
  Protected WithEvents ChkAutoparchimetri As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkOrganico As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkNote As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkParcheggi As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkCarsharing As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkDepositeria As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkPianoSosta As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkRicavi As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkSanzioni As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkParcRiv As System.Web.UI.WebControls.CheckBox
  Protected Friend WithEvents ConnDatiAs400 As System.Data.SqlClient.SqlConnection
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaConsuntivoSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsConsuntivo As ATCBussm1.DsConsuntivo
  Protected WithEvents DaTSanzioniSosta As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaConsuntivoSostaProvv As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents ChkCSRicaviPerUsiInterni As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkCSConsumiAziendali As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ChkParcometri As System.Web.UI.WebControls.CheckBox
  Protected WithEvents ConnSCAT As System.Data.SqlClient.SqlConnection

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
    If Not IsPostBack Then
      ' ----------------------------------------------------------------------------
      oUtente = Session("User")
      If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
      TxtAnno.Text = Year(Now)
      CboMese.SelectedValue = IIf(Month(Now) = 1, 1, Month(Now) - 1)

    End If

  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
    Aggiorna()
    Storico()
    PnlStatistica.Visible = Me.IsValid
  End Sub

  Public Function UrlReport() As String

    Dim mese As Integer
    Dim anno As Integer
    Dim StrDataV As String
    Dim StrDatAs400 As String
    Dim StrParVisual As String = ""

    mese = CInt(CboMese.SelectedValue)
    anno = CInt(IIf(TxtAnno.Text.Trim = "", Year(Now), TxtAnno.Text))

    Dim Giorno As Integer = System.DateTime.DaysInMonth(anno, mese)
    StrDataV = Giorno.ToString & "/" & mese.ToString & "/" & anno.ToString & " 23:59:59"
    StrDatAs400 = anno.ToString & mese.ToString("00") & Giorno.ToString("00")

    If Not ChkPianoSosta.Checked Then StrParVisual &= "&PianoSosta=false"
    If Not ChkParcRiv.Checked Then StrParVisual &= "&ParcometriRiv=false"
    If Not ChkRicavi.Checked Then StrParVisual &= "&Ricavi=false"
    If Not ChkAutoparchimetri.Checked Then StrParVisual &= "&AutoParchimetri=false"
    If Not ChkOrganico.Checked Then StrParVisual &= "&Organico=false"
    If Not ChkSanzioni.Checked Then StrParVisual &= "&SanzioniSosta=false"
    If Not ChkNote.Checked Then StrParVisual &= "&Note=false"
    If Not ChkParcheggi.Checked Then StrParVisual &= "&Parcheggi=false"
    If Not ChkCarsharing.Checked Then StrParVisual &= "&Carsharing=false"
    If Not ChkDepositeria.Checked Then StrParVisual &= "&Depositeria=false"
    If Not ChkCSRicaviPerUsiInterni.Checked Then StrParVisual &= "&CSRicaviXUsiInterni=false"
    If Not ChkCSConsumiAziendali.Checked Then StrParVisual &= "&CSConsumiAziendali=false"
    If Not ChkParcometri.Checked Then StrParVisual &= "&Parcometri=false"

    UrlReport = "&rc:Parameters=false&rc:DocMap=false&ANNO=" & anno.ToString & "&DATAV=" & StrDataV & "&DATAS400=" & StrDatAs400 & StrParVisual

  End Function

  Private Sub Aggiorna()
    Try

    Catch ex As Exception

    End Try
    If TxtAnno.Text.Trim <> "" Then
      If CInt(TxtAnno.Text.Trim) = Year(Now) Or CInt(TxtAnno.Text.Trim) = (Year(Now) - 1) Then
        Dim StrSQL As String
        Dim strAnno As String
        Dim DtData As DateTime
        Dim drD As DataRow()

        Dim drF As DataRow
        Dim drP As DataRow
        Dim drS As DataRow
        Dim righe As Integer

        strAnno = TxtAnno.Text.Trim
        Try
          StrSQL = "select Mese, sum(Ricavo) as Ricavo from ( " & _
                    "SELECT SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) AS Mese, " & _
                   "ABS(ROUND((SUM(ISNULL(TVDATI_TVSTO00F.MOVUR,0)) + SUM(ISNULL(TVDATI_TVSTO00F.MOVEX,0))), 2)) AS Ricavo " & _
                   "FROM TVDATI_TVSTO00F " & _
                   "WHERE (TVDATI_TVSTO00F.MOCAU = 'PA' OR " & _
                   "TVDATI_TVSTO00F.MOCAU = 'PS' OR TVDATI_TVSTO00F.MOCAU = 'PN' OR " & _
                   "TVDATI_TVSTO00F.MOCAU = 'SP' or TVDATI_TVSTO00F.MOCAU = 'SF' or TVDATI_TVSTO00F.MOCAU = 'FS') AND (TVDATI_TVSTO00F.MOANN IS NULL or TVDATI_TVSTO00F.MOANN<=' ') and SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 1, 4)='" & strAnno & "' " & _
                   "GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVSTO00F.MODAT))), 5, 2) " & _
                   " Union all " & _
                   " SELECT  SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 5, 2) AS Mese,ABS((SUM(isnull(TIMPO,0)))) AS Ricavo " & _
                   " FROM         TVDATI_ETCOR00F " & _
                   " WHERE TBIAB='S' and ( TFLAG IS NULL or TFLAG ='') and  SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 1, 4) ='" & strAnno & "' " & _
                   " GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TDTEM))), 5, 2)) as a " & _
                   " group by Mese"


          Dim com As New SqlCommand(StrSQL, ConnDatiAs400)

          Dim dRead As SqlDataReader
          ConnDatiAs400.Open()

          dRead = com.ExecuteReader

          DaConsuntivoSosta.Fill(DsConsuntivo.Tables("ConsuntivoSosta"))

          If dRead.HasRows = True Then
            con.Open()

            DaConsuntivoSosta.DeleteCommand.Parameters("@ANNO").Value = CInt(TxtAnno.Text.Trim)
            righe = DaConsuntivoSosta.DeleteCommand.ExecuteNonQuery()
            DaConsuntivoSosta.Update(DsConsuntivo, "ConsuntivoSosta")

            con.Close()

            Do While dRead.Read

              drF = DsConsuntivo.Tables("ConsuntivoSosta").NewRow
              drF.Item("IdC") = Guid.NewGuid
              DsConsuntivo.Tables("ConsuntivoSosta").Rows.Add(drF)

              drF.Item("DataC") = "01/" & dRead.Item("MESE") & "/" & strAnno
              drF.Item("Consuntivo") = dRead.Item("Ricavo")
              DaConsuntivoSosta.Update(DsConsuntivo, "ConsuntivoSosta")

            Loop
          End If
          con.Close()

          ConnDatiAs400.Close()

          'BRN 20050109 inserita parte di visualizzazione dei ricavi provvisori

          StrSQL = "SELECT SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVMOV00F.MODAT))), 5, 2) AS Mese, " & _
                   "ABS(ROUND((SUM(ISNULL(TVDATI_TVMOV00F.MOVUR,0)) + SUM(ISNULL(TVDATI_TVMOV00F.MOVEX,0))), 2)) AS Ricavo " & _
                   "FROM TVDATI_TVMOV00F " & _
                   "WHERE (TVDATI_TVMOV00F.MOCAU = 'PA' OR " & _
                   "TVDATI_TVMOV00F.MOCAU = 'PS' OR TVDATI_TVMOV00F.MOCAU = 'PN' OR " & _
                   "TVDATI_TVMOV00F.MOCAU = 'SP' or TVDATI_TVMOV00F.MOCAU = 'SF' or TVDATI_TVMOV00F.MOCAU = 'FS') AND (TVDATI_TVMOV00F.MOANN IS NULL or TVDATI_TVMOV00F.MOANN<=' ') and SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVMOV00F.MODAT))), 1, 4)='" & strAnno & "' " & _
                   "GROUP BY SUBSTRING(RTRIM(LTRIM(STR(TVDATI_TVMOV00F.MODAT))), 5, 2) "


          Dim comP As New SqlCommand(StrSQL, ConnDatiAs400)

          Dim dReadP As SqlDataReader
          ConnDatiAs400.Open()

          dReadP = comP.ExecuteReader

          DaConsuntivoSostaProvv.Fill(DsConsuntivo.Tables("ConsuntivoSostaProvv"))

          con.Open()
          DaConsuntivoSostaProvv.DeleteCommand.Parameters("@ANNO").Value = CInt(TxtAnno.Text.Trim)
          righe = DaConsuntivoSostaProvv.DeleteCommand.ExecuteNonQuery()
          DaConsuntivoSostaProvv.Update(DsConsuntivo, "ConsuntivoSostaProvv")
          con.Close()

          If dReadP.HasRows = True Then

            Do While dReadP.Read

              drP = DsConsuntivo.Tables("ConsuntivoSostaProvv").NewRow
              drP.Item("IdC") = Guid.NewGuid
              DsConsuntivo.Tables("ConsuntivoSostaProvv").Rows.Add(drP)

              drP.Item("DataC") = "01/" & dReadP.Item("MESE") & "/" & strAnno
              drP.Item("Consuntivo") = dReadP.Item("Ricavo")
              DaConsuntivoSostaProvv.Update(DsConsuntivo, "ConsuntivoSostaProvv")

            Loop
          End If
          con.Close()

          ConnDatiAs400.Close()
          'fine brn 20050109
          'Commentata per evitare problemi di accesso al db
          'If CInt(strAnno) = Year(Now) Then
          '  StrSQL = "SELECT COUNT(V.ID_DOC) AS Numero_Sanzioni, YEAR(V.Data) AS Anno, MONTH(V.Data) AS Mese, MIN(V.Data) AS MeseData " & _
          '           "FROM EsportazioneVerbali V LEFT OUTER JOIN DettagliGruppiSanzioni D ON V.Gruppo = D.Gruppo COLLATE Latin1_General_CI_AS " & _
          '           "WHERE (YEAR(V.Data) = " & strAnno & ") GROUP BY YEAR(V.Data), MONTH(V.Data) ORDER BY YEAR(V.Data), MONTH(V.Data) "
          'Else
          '  StrSQL = "SELECT COUNT(V.ID_DOC) AS Numero_Sanzioni, YEAR(V.Data) AS Anno, MONTH(V.Data) AS Mese, MIN(V.Data) AS MeseData " & _
          '           "FROM EsportazioneVerbali" & strAnno.Trim & " V LEFT OUTER JOIN DettagliGruppiSanzioni D ON V.Gruppo = D.Gruppo COLLATE Latin1_General_CI_AS " & _
          '           "WHERE (YEAR(V.Data) = " & strAnno & ") GROUP BY YEAR(V.Data), MONTH(V.Data) ORDER BY YEAR(V.Data), MONTH(V.Data) "

          'End If

        Catch ex As Exception

        End Try
        Try

          StrSQL = "SELECT SUM(ConteggioTotale) AS Numero_Sanzioni, YEAR(Data) AS anno, MONTH(Data) AS mese, MIN(Data) AS MeseData " & _
                   "FROM Rep_DatiConteggiImportiVerbali GROUP BY YEAR(Data), MONTH(Data) HAVING(Year(Data) = " & strAnno & ") ORDER BY anno, mese "


          Dim comS As New SqlCommand(StrSQL, ConnSCAT)

          Dim dReadS As SqlDataReader
          ConnSCAT.Open()

          dReadS = comS.ExecuteReader
          DaTSanzioniSosta.Fill(DsConsuntivo.Tables("TSanzioniSosta"))

          If dReadS.HasRows = True Then

            con.Open()
            DaTSanzioniSosta.DeleteCommand.Parameters("@ANNO").Value = CInt(TxtAnno.Text.Trim)
            righe = DaTSanzioniSosta.DeleteCommand.ExecuteNonQuery()
            DaTSanzioniSosta.Update(DsConsuntivo, "TSanzioniSosta")
            con.Close()

            Do While dReadS.Read
              drS = DsConsuntivo.Tables("TSanzioniSosta").NewRow
              drS.Item("IdSanzioniSosta") = Guid.NewGuid
              DsConsuntivo.Tables("TSanzioniSosta").Rows.Add(drS)
              drS.Item("Data") = "01/" & dReadS.Item("Mese") & "/" & strAnno
              drS.Item("Totale") = dReadS.Item("Numero_Sanzioni")
              DaTSanzioniSosta.Update(DsConsuntivo, "TSanzioniSosta")
            Loop
          End If
          con.Close()
          ConnSCAT.Close()


        Catch ex As Exception

        End Try

      End If

    End If

  End Sub

  Private Sub Storico()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader

    Dim mese As Integer
    Dim anno As Integer
    Dim DataLimiteStorico As DateTime
    If CInt(CboMese.SelectedValue) < 12 Then
      mese = CInt(CboMese.SelectedValue) + 1
      anno = CInt(IIf(TxtAnno.Text.Trim = "", Year(Now), TxtAnno.Text))
    Else
      mese = CInt(CboMese.SelectedValue)
      anno = CInt(IIf(TxtAnno.Text.Trim = "", Year(Now), TxtAnno.Text)) + 1
    End If

    DataLimiteStorico = CType(configurationAppSettings.GetValue("GiorniStorico", GetType(System.String)), String) & "/" & mese.ToString & "/" & anno.ToString & " 23:59:59"

    If Now <= DataLimiteStorico Then
      AggiornaStoricoPianoSosta()
    End If

  End Sub

  Private Sub AggiornaStoricoPianoSosta()

    Dim mese As Integer
    Dim anno As Integer
    Dim StrDataV As String
    Dim StrDataStor As String
    Dim StrInsertSQL As String
    Dim strUpdateSQL As String
    Dim strSelectSQL As String
    Dim strSQL As String

    mese = CInt(CboMese.SelectedValue)
    anno = CInt(IIf(TxtAnno.Text.Trim = "", 10, TxtAnno.Text))
    Dim NRighe As Integer

    Dim Giorno As Integer = System.DateTime.DaysInMonth(anno, mese)
    StrDataV = anno.ToString & "-" & Format(mese, "00") & "-" & Giorno.ToString & " 23:59:59"
    StrDataStor = anno.ToString & "-" & Format(mese, "00") & "-" & "01"
    Try
      con.Open()
    Catch ex As Exception
      con.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
      Exit Sub
    End Try

    strSelectSQL = "SELECT COUNT(*) AS NumeroRighe FROM StoricoPianoSosta WHERE (Data = CONVERT(datetime, '" & StrDataStor & "', 121))"
    Dim comSelect As New SqlCommand(strSelectSQL, con)

    Try
      NRighe = comSelect.ExecuteScalar
    Catch ex As Exception
      con.Close()
      Throw New Exception("Errore nella selezione dei dati.")
      Exit Sub
    End Try

    If NRighe > 0 Then

      strSQL = "UPDATE StoricoPianoSosta SET StoricoPianoSosta.Ordinaria=Storico.Ordinaria, StoricoPianoSosta.RapidaRotazione=Storico.RapidaRotazione, " & _
              "StoricoPianoSosta.Residenti=Storico.Residenti, StoricoPianoSosta.Disabili=Storico.Disabili, StoricoPianoSosta.Generici=Storico.Generici, " & _
              "StoricoPianoSosta.CaricoScarico=Storico.CaricoScarico, StoricoPianoSosta.DiscoOrario=Storico.DiscoOrario, " & _
              "StoricoPianoSosta.Carsharing=Storico.Carsharing, StoricoPianoSosta.PostiMoto=Storico.PostiMoto " & _
              "from (select CONVERT(datetime, '" & StrDataStor & "', 121) as DataStor, ISNULL(idsettore,IdZona) AS IdZonaStor, " & _
              "(ISNULL(OrdinariaB,0) + ISNULL(LavOrdinari,0)) as Ordinaria, (ISNULL(RapidaRotB,0) + ISNULL(LavRapidaR,0)) as RapidaRotazione, (ISNULL(ResidentiB,0) + ISNULL(LavResidenti,0)) as Residenti, " & _
              "(ISNULL(DisabiliB,0) + ISNULL(LavDisabili,0)) as Disabili, (ISNULL(GenericiB,0) + ISNULL(LavGenerici,0)) as Generici, (ISNULL(Carico_ScaricoB,0) + ISNULL(LavCaricoScarico,0)) as CaricoScarico, " & _
              "(ISNULL(DiscoOrarioB,0)  + ISNULL(LavDiscoOrario,0)) as DiscoOrario, (ISNULL(CarsharingB,0) + ISNULL(LavCarsharing,0)) as Carsharing, (ISNULL(PostiMotoB,0) + ISNULL(LavMoto,0)) as PostiMoto " & _
              "from (SELECT MAX(Stalli.Settore) AS Settore, SUM(ISNULL(Stalli.Blu,0)) AS OrdinariaB, SUM(ISNULL(Stalli.Verde,0)) AS RapidaRotB, SUM(ISNULL(Stalli.Residenti,0)) AS ResidentiB, " & _
              "SUM(ISNULL(Stalli.RiservatoGenerico,0)) AS GenericiB, SUM(ISNULL(Stalli.CaricoScarico,0)) AS Carico_ScaricoB, SUM(ISNULL(Stalli.Handi,0)) AS DisabiliB, " & _
              "SUM(ISNULL(Stalli.discoorario,0)) AS DiscoOrarioB, SUM(ISNULL(Stalli.Carsharing,0)) AS CarsharingB, SUM(ISNULL(Stalli.Moto,0)) AS PostiMotoB, Settori.IdSettore AS IdSettore, " & _
              "LavoriStradaliZone.Tipo AS Tipo, LavoriStradaliZone.Zona AS Zona, MAX(LavoriStradaliTipiZone.TipoZona) AS TipoZona " & _
              "FROM LavoriStradaliTipiZone INNER JOIN " & _
              "LavoriStradaliZone ON LavoriStradaliTipiZone.IdTipoZona = LavoriStradaliZone.Tipo LEFT OUTER JOIN " & _
              "Stalli INNER JOIN Settori ON Stalli.ID_SZF = Settori.Id_SZF ON LavoriStradaliZone.IdZona = Settori.IdSettore " & _
              "GROUP BY Settori.IdSettore, LavoriStradaliZone.Tipo, LavoriStradaliZone.Zona " & _
              ") A FULL OUTER JOIN " & _
              "(SELECT SUM(ISNULL(LavoriStradali.StalliONuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliOEliminati, 0)) AS LavOrdinari, " & _
              "SUM(ISNULL(LavoriStradali.StalliRRNuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliRREliminati, 0)) AS LavRapidaR, " & _
              "SUM(ISNULL(LavoriStradali.ResidentiNuovi, 0)) - SUM(ISNULL(LavoriStradali.ResidentiEliminati, 0)) AS LavResidenti, " & _
              "SUM(ISNULL(LavoriStradali.StalliMotoNuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliMotoEliminati, 0)) AS LavMoto, " & _
              "SUM(ISNULL(LavoriStradali.CarsharingNuovi, 0)) - SUM(ISNULL(LavoriStradali.CarsharingEliminati, 0)) AS LavCarsharing, " & _
              "SUM(ISNULL(LavoriStradali.DisabiliNuovi, 0)) - SUM(ISNULL(LavoriStradali.DisabiliEliminati, 0)) AS LavDisabili, " & _
              "SUM(ISNULL(LavoriStradali.GenericiNuovi, 0)) - SUM(ISNULL(LavoriStradali.GenericiEliminati, 0)) AS LavGenerici, " & _
              "SUM(ISNULL(LavoriStradali.DiscoOrarioNuovi, 0)) - SUM(ISNULL(LavoriStradali.DiscoOrarioEliminati, 0)) AS LavDiscoOrario, " & _
              "SUM(ISNULL(LavoriStradali.CaricoScaricoNuovi, 0)) - SUM(ISNULL(LavoriStradali.CaricoScaricoEliminati, 0)) AS LavCaricoScarico, " & _
              "LavoriStradali.IdZona AS IdZona " & _
              "FROM LavoriStradali INNER JOIN " & _
              "LavoriStradaliToponimi ON LavoriStradali.IdVia = LavoriStradaliToponimi.IdToponimo AND " & _
              "LavoriStradali.DataCancellazione IS NULL " & _
              "WHERE LavoriStradali.DataFine<=CONVERT(datetime, '" & StrDataV & "', 121) AND LavoriStradali.DataFine>=CONVERT(datetime, '2005-07-01 23:59:59', 121) " & _
              "GROUP BY LavoriStradali.IdZona " & _
              ")B on IdSettore= IdZona where (NOT (A.IdSettore IS NULL)) or (NOT (B.IdZona IS NULL))) AS Storico inner join StoricoPianoSosta on Storico.IdZonaStor = StoricoPianoSosta.IdZona and StoricoPianoSosta.Data=CONVERT(datetime, '" & StrDataStor & "', 121)"

    Else

      strSQL = "INSERT INTO StoricoPianoSosta(Data, IdZona, Ordinaria, RapidaRotazione, Residenti, Disabili, Generici, CaricoScarico, DiscoOrario, Carsharing, PostiMoto) " & _
              "select CONVERT(datetime, '" & StrDataStor & "', 121), ISNULL(idsettore,IdZona) AS IdZonaStor,(ISNULL(OrdinariaB,0) + ISNULL(LavOrdinari,0)) as Ordinaria, (ISNULL(RapidaRotB,0) + ISNULL(LavRapidaR,0)) as RapidaRotazione, (ISNULL(ResidentiB,0) + ISNULL(LavResidenti,0)) as Residenti, " & _
              "(ISNULL(DisabiliB,0) + ISNULL(LavDisabili,0)) as Disabili, (ISNULL(GenericiB,0) + ISNULL(LavGenerici,0)) as Generici, (ISNULL(Carico_ScaricoB,0) + ISNULL(LavCaricoScarico,0)) as CaricoScarico, " & _
              "(ISNULL(DiscoOrarioB,0)  + ISNULL(LavDiscoOrario,0)) as DiscoOrario, (ISNULL(CarsharingB,0) + ISNULL(LavCarsharing,0)) as Carsharing, (ISNULL(PostiMotoB,0) + ISNULL(LavMoto,0)) as PostiMoto " & _
              "from (SELECT MAX(Stalli.Settore) AS Settore, SUM(ISNULL(Stalli.Blu,0)) AS OrdinariaB, SUM(ISNULL(Stalli.Verde,0)) AS RapidaRotB, SUM(ISNULL(Stalli.Residenti,0)) AS ResidentiB, " & _
              "SUM(ISNULL(Stalli.RiservatoGenerico,0)) AS GenericiB, SUM(ISNULL(Stalli.CaricoScarico,0)) AS Carico_ScaricoB, SUM(ISNULL(Stalli.Handi,0)) AS DisabiliB, " & _
              "SUM(ISNULL(Stalli.discoorario,0)) AS DiscoOrarioB, SUM(ISNULL(Stalli.Carsharing,0)) AS CarsharingB, SUM(ISNULL(Stalli.Moto,0)) AS PostiMotoB, Settori.IdSettore AS IdSettore, " & _
              "LavoriStradaliZone.Tipo AS Tipo, LavoriStradaliZone.Zona AS Zona, MAX(LavoriStradaliTipiZone.TipoZona) AS TipoZona " & _
              "FROM LavoriStradaliTipiZone INNER JOIN " & _
              "LavoriStradaliZone ON LavoriStradaliTipiZone.IdTipoZona = LavoriStradaliZone.Tipo LEFT OUTER JOIN " & _
              "Stalli INNER JOIN Settori ON Stalli.ID_SZF = Settori.Id_SZF ON LavoriStradaliZone.IdZona = Settori.IdSettore " & _
              "GROUP BY Settori.IdSettore, LavoriStradaliZone.Tipo, LavoriStradaliZone.Zona " & _
              ") A FULL OUTER JOIN " & _
              "(SELECT SUM(ISNULL(LavoriStradali.StalliONuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliOEliminati, 0)) AS LavOrdinari, " & _
              "SUM(ISNULL(LavoriStradali.StalliRRNuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliRREliminati, 0)) AS LavRapidaR, " & _
              "SUM(ISNULL(LavoriStradali.ResidentiNuovi, 0)) - SUM(ISNULL(LavoriStradali.ResidentiEliminati, 0)) AS LavResidenti, " & _
              "SUM(ISNULL(LavoriStradali.StalliMotoNuovi, 0)) - SUM(ISNULL(LavoriStradali.StalliMotoEliminati, 0)) AS LavMoto, " & _
              "SUM(ISNULL(LavoriStradali.CarsharingNuovi, 0)) - SUM(ISNULL(LavoriStradali.CarsharingEliminati, 0)) AS LavCarsharing, " & _
              "SUM(ISNULL(LavoriStradali.DisabiliNuovi, 0)) - SUM(ISNULL(LavoriStradali.DisabiliEliminati, 0)) AS LavDisabili, " & _
              "SUM(ISNULL(LavoriStradali.GenericiNuovi, 0)) - SUM(ISNULL(LavoriStradali.GenericiEliminati, 0)) AS LavGenerici, " & _
              "SUM(ISNULL(LavoriStradali.DiscoOrarioNuovi, 0)) - SUM(ISNULL(LavoriStradali.DiscoOrarioEliminati, 0)) AS LavDiscoOrario, " & _
              "SUM(ISNULL(LavoriStradali.CaricoScaricoNuovi, 0)) - SUM(ISNULL(LavoriStradali.CaricoScaricoEliminati, 0)) AS LavCaricoScarico, " & _
              "LavoriStradali.IdZona AS IdZona " & _
              "FROM LavoriStradali INNER JOIN " & _
              "LavoriStradaliToponimi ON LavoriStradali.IdVia = LavoriStradaliToponimi.IdToponimo AND " & _
              "LavoriStradali.DataCancellazione IS NULL " & _
              "WHERE LavoriStradali.DataFine<=CONVERT(datetime, '" & StrDataV & "', 121) AND LavoriStradali.DataFine>=CONVERT(datetime, '2005-07-01 23:59:59', 121) " & _
              "GROUP BY LavoriStradali.IdZona " & _
              ")B on IdSettore= IdZona where (NOT (A.IdSettore IS NULL)) OR (NOT (B.IdZona IS NULL))"

    End If

    Dim com As New SqlCommand(strSQL, con)

    Try
      com.ExecuteNonQuery()

      con.Close()
      ' con.Dispose()
    Catch ex As Exception
      con.Close()
      'con.Dispose()

      Throw New Exception("Impossibile aggiornare i dati.")
    End Try

  End Sub

End Class
