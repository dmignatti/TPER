Imports System.Data.SqlClient

Public Class wf_StoricoSettoreSosta
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("ConnectionString", GetType(System.String)), String)

  End Sub
  Protected WithEvents VSDatiSintesi As System.Web.UI.WebControls.ValidationSummary
  Protected WithEvents lblAnno As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnASPianoSosta As System.Web.UI.WebControls.Button
  Protected WithEvents rfvAnno As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvAnno As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents PnlRicerca As System.Web.UI.WebControls.Panel
  Protected WithEvents LblMese As System.Web.UI.WebControls.Label
  Protected WithEvents CboMese As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblAggPianoSostaOk As System.Web.UI.WebControls.Label
  Protected WithEvents LblMeseCS As System.Web.UI.WebControls.Label
  Protected WithEvents CboMeseCS As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblAnnoCS As System.Web.UI.WebControls.Label
  Protected WithEvents txtAnnoCS As System.Web.UI.WebControls.TextBox
  Protected WithEvents btnASCSRicaviAz As System.Web.UI.WebControls.Button
  Protected WithEvents rfvAnnoCS As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents cvAnnoCS As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents lblAggCSRicaviOk As System.Web.UI.WebControls.Label
  Protected WithEvents con As System.Data.SqlClient.SqlConnection

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
    If Not IsPostBack Then

      txtAnno.Text = Now.Year
      lblAggPianoSostaOk.Visible = False

      ' txtAnnoCS.Text = Now.Year

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
    anno = CInt(IIf(txtAnno.Text.Trim = "", 10, txtAnno.Text))
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
      con.Dispose()
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
      con.Dispose()
      lblAggPianoSostaOk.Visible = True
    Catch ex As Exception
      con.Dispose()
      lblAggPianoSostaOk.Visible = False
      Throw New Exception("Impossibile aggiornare i dati.")
    End Try

  End Sub

  Private Sub btnASPianoSosta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnASPianoSosta.Click

    AggiornaStoricoPianoSosta()

  End Sub

  Private Sub CboMese_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMese.SelectedIndexChanged
    lblAggPianoSostaOk.Visible = False
  End Sub


End Class
