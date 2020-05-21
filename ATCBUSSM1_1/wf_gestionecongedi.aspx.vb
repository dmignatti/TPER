Public Class wf_gestionecongedi
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    Me.con = New System.Data.SqlClient.SqlConnection
    Me.daCongedi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsAmministrazioneCongedi1 = New ATCBussm1.dsAmministrazioneCongedi
    Me.daCambiTurno = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
    Me.daCambiTurnoMensili = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
    Me.daFerie = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
    Me.daCongediFrazionati = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
    Me.daMancataTimbratura = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
    Me.DaGiustificativo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
    Me.daCausali = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
    Me.DsMostraFerieCongedi1 = New ATCBussm1.DsMostraFerieCongedi
    Me.daMostraFerieCongedi = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    Me.daCambioTurnoStessoTipo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
    Me.DsCambiTurnoGiornalieriStessoTipo1 = New ATCBussm1.DsCambiTurnoGiornalieriStessoTipo
    Me.daCongediGarantiti = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
    Me.DaSpostamentoRiposo = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
    Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
    Me.DsSpostamentoRiposo1 = New ATCBussm1.DsSpostamentoRiposo
    Me.DsAccertatoriASGiornaliero1 = New ATCBussm1.dsAccertatoriASGiornaliero
    CType(Me.DsAmministrazioneCongedi1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsMostraFerieCongedi1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsCambiTurnoGiornalieriStessoTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsSpostamentoRiposo1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsAccertatoriASGiornaliero1, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'con
    '
    Me.con.ConnectionString = CType(configurationAppSettings.GetValue("con.ConnectionString", GetType(System.String)), String)
    '
    'daCongedi
    '
    Me.daCongedi.SelectCommand = Me.SqlSelectCommand1
    Me.daCongedi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongedi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlSelectCommand1
    '
    Me.SqlSelectCommand1.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrde" & _
    "rListCongedi(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoApprovazi" & _
    "one = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.St" & _
    "atoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataAppr" & _
    "ovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U" & _
    ".Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAcce" & _
    "sso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.Richiest" & _
    "eCongedi R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER" & _
    " JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGiorno >= GETDATE" & _
    "()) ORDER BY R.DalGiorno DESC, R.ts, Ordine"
    Me.SqlSelectCommand1.Connection = Me.con
    '
    'DsAmministrazioneCongedi1
    '
    Me.DsAmministrazioneCongedi1.DataSetName = "dsAmministrazioneCongedi"
    Me.DsAmministrazioneCongedi1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daCambiTurno
    '
    Me.daCambiTurno.SelectCommand = Me.SqlSelectCommand2
    Me.daCambiTurno.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurno", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("CognomeNomeRichiedente", "CognomeNomeRichiedente"), New System.Data.Common.DataColumnMapping("CognomeNomeDestinatario", "CognomeNomeDestinatario"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlSelectCommand2
    '
    Me.SqlSelectCommand2.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatar" & _
    "io, r.data, r.Necessari, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprov" & _
    "azione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' ELSE 'Da Approvare' END A" & _
    "S StatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNo" & _
    "meRichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDest" & _
    "inatario, u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LT" & _
    "rim(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN r." & _
    "TurnoDestinatario < 90000 THEN LTrim(Str(r.TurnoDestinatario)) ELSE 'Riposo' END" & _
    " AS TurnoDestinatario FROM (select *, ' ' as Necessari from dbo.RichiesteCambiTu" & _
    "rno  union all select *, 'X' as Necessari from dbo.RichiesteCambiTurnoNecessario" & _
    ") r  LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEF" & _
    "T OUTER JOIN dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID LEFT OUTER" & _
    " JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) " & _
    "AND (r.data >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) ORDER BY r.data DESC, r" & _
    ".ts"
    Me.SqlSelectCommand2.Connection = Me.con
    '
    'daCambiTurnoMensili
    '
    Me.daCambiTurnoMensili.SelectCommand = Me.SqlCommand1
    Me.daCambiTurnoMensili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoMensile", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("CognomeNomeRichiedente", "CognomeNomeRichiedente"), New System.Data.Common.DataColumnMapping("CognomeNomeDestinatario", "CognomeNomeDestinatario"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlCommand1
    '
    Me.SqlCommand1.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatar" & _
    "io, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0" & _
    " THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da Approvare' END AS S" & _
    "tatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeR" & _
    "ichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestina" & _
    "tario, u3.IDUser AS Approvatore, r.TurnoRichiedente AS TurnoRichiedente, r.Turno" & _
    "Destinatario AS TurnoDestinatario FROM dbo.RichiesteCambiTurnoMensile r LEFT OUT" & _
    "ER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN " & _
    "dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID LEFT OUTER JOIN dbo.ATC" & _
    "_Utenti u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND r.data >=" & _
    " GETDATE() ORDER BY r.data DESC, r.ts"
    Me.SqlCommand1.Connection = Me.con
    '
    'daFerie
    '
    Me.daFerie.SelectCommand = Me.SqlSelectCommand3
    Me.daFerie.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteFerie", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlSelectCommand3
    '
    Me.SqlSelectCommand3.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrde" & _
    "rListFerieCongediMAX(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoA" & _
    "pprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' W" & _
    "HEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R." & _
    "DataApprovazione, R.IdApprovatore, R.ts AS TS, U.IDUser + ' - ' + U.Cognome + ' " & _
    "' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltim" & _
    "oAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.Ric" & _
    "hiesteFerie R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OU" & _
    "TER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGiorno >= GETD" & _
    "ATE()) ORDER BY R.DalGiorno DESC, R.ts"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'daCongediFrazionati
    '
    Me.daCongediFrazionati.SelectCommand = Me.SqlSelectCommand4
    Me.daCongediFrazionati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediFrazionati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT ISNULL(R.StatoApprovazione, 0) AS stato, R.ts, R.IdRichiesta, R.IdAccertat" & _
    "ore, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifi" & _
    "utato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS" & _
    " NULL THEN 'Da Approvare' WHEN R.StatoApprovazione = 99 THEN 'Convertito in inte" & _
    "ro' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, Garantiti , U" & _
    ".IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato," & _
    " U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.ID" & _
    "User AS Approvatore, ISNULL(R.Intero, 0) AS Intero FROM (select *, ' ' as Garant" & _
    "iti from dbo.RichiesteCongediFrazionati  union all select *, 'X' as Garantiti fr" & _
    "om  dbo.RichiesteCongediGarantitiFra) R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.Id" & _
    "Accertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID " & _
    "WHERE (R.Data >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) ORDER BY R.Data DESC," & _
    " R.ts DESC"
    Me.SqlSelectCommand4.Connection = Me.con
    '
    'daMancataTimbratura
    '
    Me.daMancataTimbratura.SelectCommand = Me.SqlSelectCommand5
    Me.daMancataTimbratura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_MancataTimbratura", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Entrata1", "Entrata1"), New System.Data.Common.DataColumnMapping("Uscita1", "Uscita1"), New System.Data.Common.DataColumnMapping("Entrata2", "Entrata2"), New System.Data.Common.DataColumnMapping("Uscita2", "Uscita2"), New System.Data.Common.DataColumnMapping("StatoMancataTimbratura", "StatoMancataTimbratura"), New System.Data.Common.DataColumnMapping("DataInserimento", "DataInserimento"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("ApprovatoDa", "ApprovatoDa"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy")})})
    '
    'SqlSelectCommand5
    '
    Me.SqlSelectCommand5.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, MT.ID, MT.AccertatoreId, MT.Data," & _
    " MT.Entrata1, MT.Uscita1, MT.Entrata2, MT.Uscita2, DATEPART(hour, MT.Entrata1) A" & _
    "S DalleOre1, DATEPART(hour, MT.Uscita1) AS AlleOre1, DATEPART(hour, MT.Entrata2)" & _
    " AS DalleOre2, DATEPART(hour, MT.Uscita2) AS AlleOre2, DATEPART(minute, MT.Entra" & _
    "ta1) AS DalleMin1, DATEPART(minute, MT.Uscita1) AS AlleMin1, DATEPART(minute, MT" & _
    ".Entrata2) AS DalleMin2, DATEPART(minute, MT.Uscita2) AS AlleMin2, CASE WHEN MT." & _
    "StatoMancataTimbratura IS NULL THEN 'Da approvare' WHEN MT.StatoMancataTimbratur" & _
    "a = 0 THEN 'Respinta' WHEN MT.StatoMancataTimbratura = 1 THEN 'Approvata' END AS" & _
    " StatoApprovazione, MT.DataApprovazione, MT.ApprovatoDa, MT.CreatedOn, U1.IDUser" & _
    " + ' - ' + U1.Cognome + ' ' + U1.Nome AS CognomeNome, MT.StatoMancataTimbratura," & _
    " MT.DataInserimento, MT.ModifiedOn, MT.CreatedBy, MT.ModifiedBy FROM dbo.Accerta" & _
    "tori_MancataTimbratura MT LEFT OUTER JOIN dbo.ATC_Utenti U1 ON MT.AccertatoreId " & _
    "= U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U ON MT.ApprovatoDa = U.ID WHERE (MT.Data" & _
    " >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) ORDER BY MT.Data DESC, MT.Entrata1" & _
    " DESC, MT.DataInserimento DESC"
    Me.SqlSelectCommand5.Connection = Me.con
    '
    '
    'DaGiustificativo
    '
    Me.DaGiustificativo.SelectCommand = Me.SqlSelectCommand6
    Me.DaGiustificativo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_GiustificativoRichiesta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("Accertatori_GiustificativoCausaleId", "Accertatori_GiustificativoCausaleId"), New System.Data.Common.DataColumnMapping("DataDa", "DataDa"), New System.Data.Common.DataColumnMapping("DataA", "DataA"), New System.Data.Common.DataColumnMapping("OraDa", "OraDa"), New System.Data.Common.DataColumnMapping("OraA", "OraA"), New System.Data.Common.DataColumnMapping("StatoGiustificativo", "StatoGiustificativo"), New System.Data.Common.DataColumnMapping("DataRichiesta", "DataRichiesta"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("ApprovatoDa", "ApprovatoDa"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("Frazionato", "Frazionato"), New System.Data.Common.DataColumnMapping("DefaultApprovato", "DefaultApprovato"), New System.Data.Common.DataColumnMapping("PreavvisoGG", "PreavvisoGG"), New System.Data.Common.DataColumnMapping("NrMaxGG", "NrMaxGG"), New System.Data.Common.DataColumnMapping("Causale", "Causale")})})
    '
    'SqlSelectCommand6
    '
    Me.SqlSelectCommand6.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, U1.IDUser + ' - ' + U1.Cognome + " & _
    "' ' + U1.Nome AS CognomeNome, RG.ID, RG.AccertatoreId, isnull(DBO.GetOrderGiusti" & _
    "ficativi(DATADA,AccertatoreId,GC.codice),'') AS ORDINE, GC.Codice as CODICE, CAS" & _
    "E WHEN RG.StatoGiustificativo IS NULL THEN 'Da approvare' WHEN RG.StatoGiustific" & _
    "ativo = 0 THEN 'Respinta' WHEN RG.StatoGiustificativo = 1 THEN 'Approvata' END A" & _
    "S StatoApprovazione, RG.Accertatori_GiustificativoCausaleId, RG.DataDa, RG.DataA" & _
    ", RG.OraDa, RG.OraA, RG.StatoGiustificativo, RG.DataRichiesta, RG.DataApprovazio" & _
    "ne, RG.ApprovatoDa, RG.CreatedOn, RG.ModifiedOn, RG.CreatedBy, RG.ModifiedBy, RG" & _
    ".Frazionato, RG.DefaultApprovato, RG.PreavvisoGG, RG.NrMaxGG, GC.Nome AS Causale" & _
    " FROM dbo.Accertatori_GiustificativoRichiesta RG INNER JOIN dbo.Accertatori_Gius" & _
    "tificativoCausale GC ON RG.Accertatori_GiustificativoCausaleId = GC.ID LEFT OUTE" & _
    "R JOIN dbo.ATC_Utenti U1 ON RG.AccertatoreId = U1.ID LEFT OUTER JOIN dbo.ATC_Ute" & _
    "nti U ON RG.ApprovatoDa = U.ID WHERE (RG.OraDa >= DATEADD(d, DATEDIFF(d, 5, GETD" & _
    "ATE()), 0)) ORDER BY DataDa DESC, GC.Codice asc, RG.DataRichiesta ASC"
    Me.SqlSelectCommand6.Connection = Me.con
    '
    'daCausali
    '
    Me.daCausali.AcceptChangesDuringFill = False
    Me.daCausali.SelectCommand = Me.SqlCommand2
    Me.daCausali.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_Causale", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Nome", "Nome"), New System.Data.Common.DataColumnMapping("Codice", "Codice")})})
    '
    'SqlCommand2
    '
    Me.SqlCommand2.CommandText = "SELECT ID, Nome, Codice FROM dbo.Accertatori_GiustificativoCausale WHERE (GETDATE" & _
    "() >= ValiditaDa) AND (GETDATE() <= ValiditaA)"
    Me.SqlCommand2.Connection = Me.con
    '
    'DsMostraFerieCongedi1
    '
    Me.DsMostraFerieCongedi1.DataSetName = "DsMostraFerieCongedi"
    Me.DsMostraFerieCongedi1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daMostraFerieCongedi
    '
    Me.daMostraFerieCongedi.SelectCommand = Me.SqlCommand3
    Me.daMostraFerieCongedi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_PrenotazioniFerieCongedi_TBL", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GIORNO", "GIORNO"), New System.Data.Common.DataColumnMapping("ListaUser", "ListaUser"), New System.Data.Common.DataColumnMapping("num", "num"), New System.Data.Common.DataColumnMapping("PosizioneSuccessiva", "PosizioneSuccessiva"), New System.Data.Common.DataColumnMapping("PosUser", "PosUser")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("CHIAVE", "CHIAVE"), New System.Data.Common.DataColumnMapping("GIORNO", "GIORNO"), New System.Data.Common.DataColumnMapping("NUM", "NUM"), New System.Data.Common.DataColumnMapping("IDACCERTATORE", "IDACCERTATORE"), New System.Data.Common.DataColumnMapping("IDUSER", "IDUSER"), New System.Data.Common.DataColumnMapping("LISTAUSER", "LISTAUSER"), New System.Data.Common.DataColumnMapping("DATAEORA", "DATAEORA"), New System.Data.Common.DataColumnMapping("PosizioneSuccessiva", "PosizioneSuccessiva"), New System.Data.Common.DataColumnMapping("PosUser", "PosUser")})})
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "[SP_PrenotazioniFerieCongedi_TBL]"
    Me.SqlCommand3.CommandType = System.Data.CommandType.StoredProcedure
    Me.SqlCommand3.Connection = Me.con
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataDA", System.Data.SqlDbType.DateTime, 10))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DataA", System.Data.SqlDbType.DateTime, 10))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoRic", System.Data.SqlDbType.Char, 1, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "R"))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.Char, 30))
    Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FerieCongedi", System.Data.SqlDbType.Char))
    '
    'daCambioTurnoStessoTipo
    '
    Me.daCambioTurnoStessoTipo.SelectCommand = Me.SqlSelectCommand7
    Me.daCambioTurnoStessoTipo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCambiTurnoStessoTipo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatoreRichiedente", "IdAccertatoreRichiedente"), New System.Data.Common.DataColumnMapping("TurnoRichiedente", "TurnoRichiedente"), New System.Data.Common.DataColumnMapping("IdAccertatoreDestinatario", "IdAccertatoreDestinatario"), New System.Data.Common.DataColumnMapping("TurnoDestinatario", "TurnoDestinatario"), New System.Data.Common.DataColumnMapping("StatoRichiesta", "StatoRichiesta"), New System.Data.Common.DataColumnMapping("data", "data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    '
    'SqlSelectCommand7
    '
    Me.SqlSelectCommand7.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatar" & _
    "io, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0" & _
    " THEN 'Rifiutato' WHEN 1 THEN 'Approvato' ELSE 'Da Approvare' END AS StatoApprov" & _
    "azione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente" & _
    ",  u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LTrim(Str" & _
    "(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN left(r.Tu" & _
    "rnoDestinatario,1) <> '9' THEN LTrim(r.TurnoDestinatario) ELSE 'Riposo' END AS T" & _
    "urnoDestinatario FROM dbo.RichiesteCambiTurnoStessoTipo r LEFT OUTER JOIN dbo.AT" & _
    "C_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti" & _
    " u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND (r.data >= DATEA" & _
    "DD(d, DATEDIFF(d, 0, GETDATE()), 0)) ORDER BY r.data DESC, r.ts"
    Me.SqlSelectCommand7.Connection = Me.con
    '
    'DsCambiTurnoGiornalieriStessoTipo1
    '
    Me.DsCambiTurnoGiornalieriStessoTipo1.DataSetName = "DsCambiTurnoGiornalieriStessoTipo"
    Me.DsCambiTurnoGiornalieriStessoTipo1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'daCongediGarantiti
    '
    Me.daCongediGarantiti.SelectCommand = Me.SqlSelectCommand8
    Me.daCongediGarantiti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediGarantiti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    '
    'SqlSelectCommand8
    '
    Me.SqlSelectCommand8.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrde" & _
    "rListCongedi(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoApprovazi" & _
    "one = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.St" & _
    "atoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataAppr" & _
    "ovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U" & _
    ".Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAcce" & _
    "sso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.Richiest" & _
    "eCongediGarantiti R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID L" & _
    "EFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGiorno >" & _
    "= GETDATE()) ORDER BY R.DalGiorno DESC, R.ts, Ordine"
    Me.SqlSelectCommand8.Connection = Me.con
    '
    'DaSpostamentoRiposo
    '
    Me.DaSpostamentoRiposo.SelectCommand = Me.SqlSelectCommand9
    Me.DaSpostamentoRiposo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteSpostamentoRiposo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("DalGiorno", "DalGiorno"), New System.Data.Common.DataColumnMapping("AlGiorno", "AlGiorno"), New System.Data.Common.DataColumnMapping("TipoSpostamento", "TipoSpostamento"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("ts", "ts")})})
    '
    'SqlSelectCommand9
    '
    Me.SqlSelectCommand9.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.TipoSpostamento, R.Al" & _
    "Giorno, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato" & _
    "' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL" & _
    " THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovato" & _
    "re, R.ts AS TS, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EM" & _
    "ail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUt" & _
    "ente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteSpostamentoRiposo R LEFT " & _
    "OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Ut" & _
    "enti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGiorno >= GETDATE()) ORDER BY R.D" & _
    "alGiorno DESC, R.ts"
    Me.SqlSelectCommand9.Connection = Me.con
    '
    'DsSpostamentoRiposo1
    '
    Me.DsSpostamentoRiposo1.DataSetName = "DsSpostamentoRiposo"
    Me.DsSpostamentoRiposo1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DsAccertatoriASGiornaliero1
    '
    Me.DsAccertatoriASGiornaliero1.DataSetName = "dsAccertatoriASGiornaliero"
    Me.DsAccertatoriASGiornaliero1.Locale = New System.Globalization.CultureInfo("it-IT")
    CType(Me.DsAmministrazioneCongedi1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsMostraFerieCongedi1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsCambiTurnoGiornalieriStessoTipo1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsSpostamentoRiposo1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsAccertatoriASGiornaliero1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCongedi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsAmministrazioneCongedi1 As ATCBussm1.dsAmministrazioneCongedi
  Protected WithEvents dgCongedi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents dgCambiTurno As System.Web.UI.WebControls.DataGrid
  Protected WithEvents daCambiTurno As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgCambiTurnoMensili As System.Web.UI.WebControls.DataGrid
  Protected WithEvents daCambiTurnoMensili As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daFerie As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCongediFrazionati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents dgFerie As System.Web.UI.WebControls.DataGrid
  Protected WithEvents lblMatricola As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricola As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStato As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiorno As System.Web.UI.WebControls.Label
  Protected WithEvents btnFiltro As System.Web.UI.WebControls.Button
  Protected WithEvents DalGiorno As System.Web.UI.WebControls.Calendar
  Protected WithEvents ddlStato As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents lblMatricolaC As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaC As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStatoC As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoC As System.Web.UI.WebControls.Label
  Protected WithEvents DalGiornoC As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroC As System.Web.UI.WebControls.Button
  Protected WithEvents lblMatricolaF As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaF As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStatoF As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoF As System.Web.UI.WebControls.Label
  Protected WithEvents DalGiornoF As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroF As System.Web.UI.WebControls.Button
  Protected WithEvents lblMatricolaCTG As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaCTG As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStatoCTG As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoCTG As System.Web.UI.WebControls.Label
  Protected WithEvents DalGiornoCTG As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroCTG As System.Web.UI.WebControls.Button
  Protected WithEvents lblMatricolaCTM As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaCTM As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStatoCTM As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoCTM As System.Web.UI.WebControls.Label
  Protected WithEvents DalGiornoCTM As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroCTM As System.Web.UI.WebControls.Button
  Protected WithEvents ddlStatoC As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents ddlStatoF As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents ddlStatoCTG As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents ddlStatoCTM As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents daMancataTimbratura As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
  Protected WithEvents Label2 As System.Web.UI.WebControls.Label
  Protected WithEvents Label3 As System.Web.UI.WebControls.Label
  Protected WithEvents dgMancataTimbratura As System.Web.UI.WebControls.DataGrid
  Protected WithEvents txtMatricolaMT As System.Web.UI.WebControls.TextBox
  Protected WithEvents DalGiornoMT As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroMT As System.Web.UI.WebControls.Button
  Protected WithEvents ddlStatoMT As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents Label8 As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricolaRG As System.Web.UI.WebControls.TextBox
  Protected WithEvents Label9 As System.Web.UI.WebControls.Label
  Protected WithEvents Label10 As System.Web.UI.WebControls.Label
  Protected WithEvents DalGiornoRG As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroRG As System.Web.UI.WebControls.Button
  Protected WithEvents dgGiustificativi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents ddlStatoRG As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents DaGiustificativo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCausali As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents Label11 As System.Web.UI.WebControls.Label
  Protected WithEvents ddlCausali As System.Web.UI.WebControls.DropDownList
  Protected WithEvents lblDAL As System.Web.UI.WebControls.Label
  Protected WithEvents lblAL As System.Web.UI.WebControls.Label
  Protected WithEvents DgMostraFerieCongedi As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DsMostraFerieCongedi1 As ATCBussm1.DsMostraFerieCongedi
  Protected WithEvents daMostraFerieCongedi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblUTENTE As System.Web.UI.WebControls.Label
  Protected WithEvents Label13 As System.Web.UI.WebControls.Label
  Protected WithEvents Label14 As System.Web.UI.WebControls.Label
  Protected WithEvents daCambioTurnoStessoTipo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsCambiTurnoGiornalieriStessoTipo1 As ATCBussm1.DsCambiTurnoGiornalieriStessoTipo
  Protected WithEvents BtnFiltroStessoT As System.Web.UI.WebControls.Button
  Protected WithEvents txtMatricolaStessoT As System.Web.UI.WebControls.TextBox
  Protected WithEvents DalGiornoStessoT As System.Web.UI.WebControls.Calendar
  Protected WithEvents dgCambiTurnoStessoT As System.Web.UI.WebControls.DataGrid
  Protected WithEvents ddlStatoStessoT As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents dgCongediFrazionati As System.Web.UI.WebControls.DataGrid
  Protected WithEvents Label16 As System.Web.UI.WebControls.Label
  Protected WithEvents Label17 As System.Web.UI.WebControls.Label
  Protected WithEvents dgCongediGarantiti As System.Web.UI.WebControls.DataGrid
  Protected WithEvents daCongediGarantiti As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
  Protected WithEvents BtnFiltroCGA As System.Web.UI.WebControls.Button
  Protected WithEvents ddlStatoCGA As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents DalGiornoCGA As System.Web.UI.WebControls.Calendar
  Protected WithEvents TxtMatricolaCGA As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblDalGiornoStessoT As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoGCA As System.Web.UI.WebControls.Label

  Protected WithEvents DaSpostamentoRiposo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
  Protected WithEvents DsSpostamentoRiposo1 As ATCBussm1.DsSpostamentoRiposo
  Protected WithEvents TxtMatricolaSPR As System.Web.UI.WebControls.TextBox
  Protected WithEvents DalGiornoSPR As System.Web.UI.WebControls.Calendar
  Protected WithEvents btnFiltroSPR As System.Web.UI.WebControls.Button
  Protected WithEvents DgSpostamentoRiposo As System.Web.UI.WebControls.DataGrid
  Protected WithEvents LblMatricolaSPR As System.Web.UI.WebControls.Label
  Protected WithEvents LblStatoSPR As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoSPR As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoMT As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiornoRG As System.Web.UI.WebControls.Label
  Protected WithEvents LblTipoSPR As System.Web.UI.WebControls.Label
  Protected WithEvents DdlTipoSPR As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents DdlStatoSPR As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents DsAccertatoriASGiornaliero1 As ATCBussm1.dsAccertatoriASGiornaliero

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
    Dim fnc As New Funzioni

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
    oUtente = Session("User")
    If Session("User") Is Nothing Then Response.Redirect("frmLogin.aspx")
    'DM2020.02 - rendo invisibili lbl e grid

    lblDAL.Visible = False 'DM2020.02     
    lblAL.Visible = False 'DM2020.02  
    lblUTENTE.Visible = False
    DgMostraFerieCongedi.Visible = False

    If Not IsPostBack Then
      DalGiorno.SelectedDate = Now()
      DalGiornoC.SelectedDate = Now()
      DalGiornoF.SelectedDate = Now()
      DalGiornoCTM.SelectedDate = Now()
      DalGiornoCTG.SelectedDate = Now()
      DalGiornoMT.SelectedDate = Now()
      DalGiornoRG.SelectedDate = Now()
      DalGiornoStessoT.SelectedDate = Now()     'DM2020.03
      DalGiornoCGA.SelectedDate = Now()     'DM2020.03
      DalGiornoSPR.SelectedDate = Now()     'DM2020.04
      daCausali.Fill(DsAmministrazioneCongedi1, "Accertatori_Causale")
      ddlCausali.DataBind()


      daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
      daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
      daFerie.Fill(DsAmministrazioneCongedi1, "Richiesteferie")
      daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
      daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
      daCambioTurnoStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo") 'DM2020.03
      daMancataTimbratura.Fill(DsAmministrazioneCongedi1, "Accertatori_MancataTimbratura")
      DaGiustificativo.Fill(DsAmministrazioneCongedi1, "Accertatori_GiustificativoRichiesta")
      daCongediGarantiti.Fill(DsAmministrazioneCongedi1, "RichiesteCongediGarantiti")
      DaSpostamentoRiposo.Fill(DsSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
      Page.DataBind()
      Dim n As Integer
      n = ddlCausali.Items.Count

      ddlCausali.Items.Add(" Tutte")
      ddlCausali.Items(n).Value = Guid.Empty.ToString
      ddlCausali.SelectedIndex = n

      fnc.ScriviLog(oUtente.IDUser, "wf_gestionecongedi.aspx", "Pagina iniziale", Session("IPAddress"))
    End If
  End Sub

  Public Sub lblOre_OnDataBinding(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim t As New TimeSpan("0" & DirectCast(sender, Label).Text)
    DirectCast(sender, Label).Text = t.ToString
  End Sub

  Private Sub dgCongedi_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongedi.ItemCommand

    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCongedi Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongedi.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
      daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
      dgCongedi.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCongedi Set IdApprovatore =NULL, DataApprovazione =NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongedi.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
      daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
      dgCongedi.DataBind()
    End If

  End Sub

  Private Sub dgCambiTurno_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurno.ItemCommand

    'DM2020.03 - controllo se son dentro ad un Congedo Frazionato Garantito o no
    Dim sTabella As String
    If e.Item.Cells(12).Text = "X" Then   'riconosco se sono GARANTITO perché qui metto una "X"
      sTabella = "RichiesteCambiTurnoNecessario"
    Else
      sTabella = "RichiesteCambiTurno"
    End If


    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update " & sTabella & " Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurno.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCambiTurno").Clear()
      daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
      dgCambiTurno.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update " & sTabella & " Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurno.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCambiTurno").Clear()
      daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
      dgCambiTurno.DataBind()
    End If
  End Sub

  Private Sub dgCambiTurnoMensili_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoMensili.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoMensile Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoMensili.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCambiTurnoMensile").Clear()
      daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
      dgCambiTurnoMensili.DataBind()
      DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
      daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
      dgCongedi.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoMensile Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoMensili.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCambiTurnoMensile").Clear()
      daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
      dgCambiTurnoMensili.DataBind()
    End If
  End Sub

  

  Private Sub dgFerie_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgFerie.ItemCommand
    Dim UtenteScelto As String
    Dim ArrUtente() As String

    'DM2020.02 - aggiungo VISUALIZZA (Select)
    If e.CommandName = "Select" Then

      DgMostraFerieCongedi.Visible = True 'DM2020.02 
      lblUTENTE.Text = e.Item.Cells(2).Text
      ArrUtente = Split(e.Item.Cells(2).Text, "-")
      UtenteScelto = ArrUtente(0)
      AggiornaDataGrid(e.Item.Cells(3).Text, e.Item.Cells(4).Text, UtenteScelto)

      lblDAL.Visible = True 'DM2020.02     
      lblAL.Visible = True 'DM2020.02    
      lblUTENTE.Visible = True

      '--> Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_ferie_congedi.aspx", "Visualizzazione richiesta ferie e congedi", Session("IPAddress"))
    End If


    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteFerie Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgFerie.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteFerie").Clear()
      daFerie.Fill(DsAmministrazioneCongedi1, "RichiesteFerie")
      dgFerie.DataBind()

    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteFerie Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgFerie.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteFerie").Clear()
      daFerie.Fill(DsAmministrazioneCongedi1, "RichiesteFerie")
      dgFerie.DataBind()
    End If
  End Sub


  Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiorno.SelectedDate = data0) Then
      filtro_data = " (R.Data >= '" & Format(DalGiorno.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (R.Data >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) "
    End If
    If (ddlStato.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStato.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStato.Value = "Convertito in intero") Then
      filtro_stato = " and R.StatoApprovazione=99 "
    ElseIf (ddlStato.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricola.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricola.Text) & "%') "
    End If    
    daCongediFrazionati.SelectCommand.CommandText = "SELECT Isnull(R.StatoApprovazione,0) as stato, Garantiti, R.ts, R.IdRichiesta, R.IdAccertatore, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' WHEN R.StatoApprovazione = 99 THEN 'Convertito in intero' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore, isnull(Intero,0) as Intero  FROM (select *, ' ' as Garantiti from dbo.RichiesteCongediFrazionati  union all select *, 'X' as Garantiti from  dbo.RichiesteCongediGarantitiFra) R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & "   ORDER BY R.Data DESC, R.DalleOre DESC, R.ts"
    'Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
    'Response.Write("Matricola:" & Trim(txtMatricola.Text))
    'Response.End()
    daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
    dgCongediFrazionati.DataBind()

  End Sub

  Private Sub btnFiltroCTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroCTM.Click
    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoCTM.SelectedDate = data0) Then
      filtro_data = " (R.Data >= '" & Format(DalGiornoCTM.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " ( r.data >= GETDATE() ) "
    End If
    If (ddlStatoCTM.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoCTM.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoCTM.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricolaCTM.Text) = "") Then
      filtro_matricola = " and (u1.IDUser like '%" & Trim(txtMatricolaCTM.Text) & "%') "
    End If

    daCambiTurnoMensili.SelectCommand.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatario, r.data, r.DataApprovazione, r.IdApprovatore, " & _
      "CASE R.StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da approvare' END AS StatoApprovazione, " & _
      " u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestinatario, " & _
      " u3.IDUser AS Approvatore, r.TurnoRichiedente AS TurnoRichiedente, r.TurnoDestinatario AS TurnoDestinatario " & _
      " FROM dbo.RichiesteCambiTurnoMensile r " & _
      " LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID " & _
      " LEFT OUTER JOIN dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID " & _
      " LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID " & _
      " WHERE (r.StatoRichiesta = 1) AND " & filtro_data & filtro_stato & filtro_matricola & " ORDER BY r.data DESC, r.ts "

    daCambiTurnoMensili.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurnoMensile")
    dgCambiTurnoMensili.DataBind()

    'daCongediFrazionati.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongediFrazionati R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY R.Data DESC, R.DalleOre DESC, R.ts"
    ''Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
    ''Response.Write("Matricola:" & Trim(txtMatricola.Text))
    ''Response.End()
    'daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
    'dgCongediFrazionati.DataBind()
  End Sub

  Private Sub btnFiltroCTG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroCTG.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoCTG.SelectedDate = data0) Then
      filtro_data = " (R.Data >= '" & Format(DalGiornoCTG.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (r.data >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) "
    End If
    If (ddlStatoCTG.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoCTG.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoCTG.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricolaCTG.Text) = "") Then
      filtro_matricola = " and (u1.IDUser like '%" & Trim(txtMatricolaCTG.Text) & "%') "
    End If

    daCambiTurno.SelectCommand.CommandText = "SELECT r.ts, r.IdRichiesta, r.Necessari, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatario, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da approvare' END AS StatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestinatario, u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LTrim(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN r.TurnoDestinatario < 90000 THEN LTrim(Str(r.TurnoDestinatario)) ELSE 'Riposo' END AS TurnoDestinatario FROM (select *, ' ' as Necessari from dbo.RichiesteCambiTurno  union all select *, 'X' as Necessari from dbo.RichiesteCambiTurnoNecessario) r LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti u2 ON r.IdAccertatoreDestinatario = u2.ID LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY r.data DESC, r.ts"

    daCambiTurno.Fill(DsAmministrazioneCongedi1, "RichiesteCambiTurno")
    dgCambiTurno.CssClass = "grid"
    dgCambiTurno.DataBind()


  End Sub

  Private Sub btnFiltroF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroF.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoF.SelectedDate = data0) Then
      filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoF.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (R.DalGiorno >= GETDATE()) "
    End If
    If (ddlStatoF.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoF.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoF.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricolaF.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricolaF.Text) & "%') "
    End If
    daFerie.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrderListFerieCongediMAX(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS TS, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteFerie R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"

    'Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
    'Response.Write("Matricola:" & Trim(txtMatricola.Text))
    'Response.End()
    daFerie.Fill(DsAmministrazioneCongedi1, "Richiesteferie")
    dgFerie.DataBind()



  End Sub

  Private Sub btnFiltroC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroC.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoC.SelectedDate = data0) Then
      filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoC.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (R.DalGiorno >= GETDATE()) "
    End If
    If (ddlStatoC.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoC.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoC.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricolaC.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricolaC.Text) & "%') "
    End If
    'MB 2019/05/20
    'daCongedi.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongedi R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"
    daCongedi.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrderListCongedi(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongedi R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"
    'Response.Write(daCongediFrazionati.SelectCommand.CommandText & "    ")
    'Response.Write("Matricola:" & Trim(txtMatricola.Text))
    'Response.End()
    daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
    dgCongedi.DataBind()


  End Sub

  Private Sub dgMancataTimbratura_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgMancataTimbratura.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_MancataTimbratura Set ApprovatoDa = @IdApprovatore, DataApprovazione = GetDate(), StatoMancataTimbratura = @StatoApprovazione Where ID = @ID", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgMancataTimbratura.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("Accertatori_MancataTimbratura").Clear()
      daMancataTimbratura.Fill(DsAmministrazioneCongedi1, "Accertatori_MancataTimbratura")
      dgMancataTimbratura.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_MancataTimbratura Set ApprovatoDa =NULL, DataApprovazione =NULL, StatoMancataTimbratura = NULL Where ID = @ID", con)
      con.Open()
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgMancataTimbratura.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("Accertatori_MancataTimbratura").Clear()
      daMancataTimbratura.Fill(DsAmministrazioneCongedi1, "Accertatori_MancataTimbratura")
      dgMancataTimbratura.DataBind()
    End If
  End Sub

  Private Sub btnFiltroMT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltroMT.Click
    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    If Not (DalGiornoMT.SelectedDate = data0) Then
      filtro_data = " (MT.Data >= '" & Format(DalGiornoMT.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (MT.Data >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) "
    End If
    If (ddlStatoMT.Value = "Rifiutati") Then
      filtro_stato = " and MT.StatoMancataTimbratura=0 "
    ElseIf (ddlStatoMT.Value = "Approvati") Then
      filtro_stato = " and MT.StatoMancataTimbratura=1 "

    ElseIf (ddlStatoMT.Value = "Da approvare") Then
      filtro_stato = " and (MT.StatoMancataTimbratura is null) "
    End If
    If (Not Trim(txtMatricolaMT.Text) = "") Then
      filtro_matricola = " and (U1.IDUser like '%" & Trim(txtMatricolaMT.Text) & "%') "
    End If
    daMancataTimbratura.SelectCommand.CommandText = "SELECT DataInserimento,U.Cognome + ' ' + U.Nome AS Approvatore, MT.ID, MT.AccertatoreId, MT.Data, MT.Entrata1, MT.Uscita1, MT.Entrata2, MT.Uscita2, DATEPART(hour, MT.Entrata1) AS DalleOre1, DATEPART(hour, MT.Uscita1) AS AlleOre1, DATEPART(hour, MT.Entrata2) AS DalleOre2, DATEPART(hour, MT.Uscita2) AS AlleOre2, DATEPART(minute, MT.Entrata1) AS DalleMin1, DATEPART(minute, MT.Uscita1) AS AlleMin1, DATEPART(minute, MT.Entrata2) AS DalleMin2, DATEPART(minute, MT.Uscita2) AS AlleMin2, CASE WHEN MT.StatoMancataTimbratura IS NULL THEN 'Da approvare' WHEN MT.StatoMancataTimbratura = 0 THEN 'Respinta' WHEN MT.StatoMancataTimbratura = 1 THEN 'Approvata' END AS StatoApprovazione, MT.DataApprovazione, MT.ApprovatoDa, MT.CreatedOn, U1.IDUser + ' - ' + U1.Cognome + ' ' + U1.Nome AS CognomeNome FROM dbo.Accertatori_MancataTimbratura MT LEFT OUTER JOIN dbo.ATC_Utenti U1 ON MT.AccertatoreId = U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U ON MT.ApprovatoDa = U.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & "  order by MT.DATA DESC, MT.Entrata1 desc, MT.DataInserimento desc"

    daMancataTimbratura.Fill(DsAmministrazioneCongedi1, "Accertatori_MancataTimbratura")
    dgMancataTimbratura.DataBind()


  End Sub


  Private Sub dgGiustificativi_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgGiustificativi.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_GiustificativoRichiesta Set ApprovatoDa = @IdApprovatore, DataApprovazione = GetDate(), StatoGiustificativo = @StatoGiustificativo Where ID = @ID", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgGiustificativi.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoGiustificativo", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoGiustificativo", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("Accertatori_GiustificativoRichiesta").Clear()
      DaGiustificativo.Fill(DsAmministrazioneCongedi1, "Accertatori_GiustificativoRichiesta")
      dgGiustificativi.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_GiustificativoRichiesta Set ApprovatoDa =NULL, DataApprovazione =NULL, StatoGiustificativo = NULL Where ID = @ID", con)
      con.Open()
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgGiustificativi.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("Accertatori_GiustificativoRichiesta").Clear()
      DaGiustificativo.Fill(DsAmministrazioneCongedi1, "Accertatori_GiustificativoRichiesta")
      dgGiustificativi.DataBind()
    End If
  End Sub

  Private Sub btnFiltroRG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltroRG.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    Dim filtro_causale As String

    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    filtro_causale = ""
    Dim data0 = New DateTime(1, 1, 1)
    'RG.Accertatori_GiustificativoCausaleId

    If Not (ddlCausali.Items(ddlCausali.SelectedIndex).Value = Guid.Empty.ToString()) Then
      filtro_causale = " and cast(RG.Accertatori_GiustificativoCausaleId as varchar(36)) ='" & ddlCausali.Items(ddlCausali.SelectedIndex).Value.ToString() & "' "
    End If
    If Not (DalGiornoRG.SelectedDate = data0) Then
      filtro_data = " (RG.OraDa >= '" & Format(DalGiornoRG.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (RG.OraDa >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) "
    End If
    If (ddlStatoRG.Value = "Rifiutati") Then
      filtro_stato = " and RG.StatoGiustificativo=0 "
    ElseIf (ddlStatoRG.Value = "Approvati") Then
      filtro_stato = " and RG.StatoGiustificativo=1 "

    ElseIf (ddlStatoRG.Value = "Da approvare") Then
      filtro_stato = " and (RG.StatoGiustificativo is null) "
    End If
    If (Not Trim(txtMatricolaRG.Text) = "") Then
      filtro_matricola = " and (U1.IDUser like '%" & Trim(txtMatricolaRG.Text) & "%') "
    End If
    DaGiustificativo.SelectCommand.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, isnull(DBO.GetOrderGiustificativi(DATADA,AccertatoreId,GC.codice),'')  AS ORDINE, GC.codice as CODICE, U1.IDUser + ' - ' + U1.Cognome + ' ' + U1.Nome AS CognomeNome, RG.ID, RG.AccertatoreId, CASE WHEN RG.StatoGiustificativo IS NULL  THEN 'Da approvare' WHEN RG.StatoGiustificativo = 0 THEN 'Respinta' WHEN RG.StatoGiustificativo = 1 THEN 'Approvata' END AS StatoApprovazione, RG.Accertatori_GiustificativoCausaleId, RG.DataDa, RG.DataA, RG.OraDa, RG.OraA, RG.StatoGiustificativo, RG.DataRichiesta, RG.DataApprovazione, RG.ApprovatoDa, RG.CreatedOn, RG.ModifiedOn, RG.CreatedBy, RG.ModifiedBy, RG.Frazionato, RG.DefaultApprovato, RG.PreavvisoGG, RG.NrMaxGG, GC.Nome AS Causale FROM Accertatori_GiustificativoRichiesta AS RG INNER JOIN Accertatori_GiustificativoCausale AS GC ON RG.Accertatori_GiustificativoCausaleId = GC.ID LEFT OUTER JOIN ATC_Utenti AS U1 ON RG.AccertatoreId = U1.ID LEFT OUTER JOIN ATC_Utenti AS U ON RG.ApprovatoDa = U.ID WHERE " & filtro_data & filtro_stato & filtro_matricola & filtro_causale & "  ORDER BY DataDa DESC, GC.Codice asc, RG.DataRichiesta ASC"

    DaGiustificativo.Fill(DsAmministrazioneCongedi1, "Accertatori_GiustificativoRichiesta")
    dgGiustificativi.DataBind()

  End Sub
  Private Sub AggiornaDataGrid(ByVal InpDataDa As Date, ByVal InpDataA As Date, ByVal InpUtente As String)
    Dim sData As String
    sData = CStr(InpDataDa)
    If sData = "" Then sData = Now
    sData = Right(sData, 4) + "-" + Mid(sData, 4, 2) + "-" + Left(sData, 2)
    daMostraFerieCongedi.SelectCommand.Parameters(1).Value() = sData
    '    
    sData = CStr(InpDataA)
    If sData = "" Then sData = Now
    sData = Right(sData, 4) + "-" + Mid(sData, 4, 2) + "-" + Left(sData, 2)
    daMostraFerieCongedi.SelectCommand.Parameters(2).Value() = sData
    '
    lblDAL.Text = InpDataDa
    lblAL.Text = InpDataA

    DgMostraFerieCongedi.ToolTip = daMostraFerieCongedi.SelectCommand.Parameters(1).Value + " - " + daMostraFerieCongedi.SelectCommand.Parameters(2).Value
    '
    DgMostraFerieCongedi.Columns(1).Visible() = oUtente.TipoUtente = 1
    '
    daMostraFerieCongedi.SelectCommand.Parameters(3).Value() = "R"
    daMostraFerieCongedi.SelectCommand.Parameters(4).Value() = InpUtente
    daMostraFerieCongedi.SelectCommand.Parameters(5).Value() = "F"  'Passo alla stored "F" ossia che sono dentro le FERIE
    daMostraFerieCongedi.Fill(DsMostraFerieCongedi1)
    DgMostraFerieCongedi.DataBind()
  End Sub
  Private Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataBinding

  End Sub

  Private Sub dgFerie_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFerie.Load

  End Sub
  Private Sub CaricaDG(ByVal Campi() As String)
    Dim Cont As Int16
    With dgFerie
      'IMPOSTO IL CARICAMENTO MANUALE DELLE COLONNE DEL DATAGRID
      .AutoGenerateColumns = False
      'CARICO LE COLONNE SPECIFICHE A ECONDA DELL'UTENTE


      .DataBind()
    End With
  End Sub

  Private Sub BtnFiltroStessoT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltroStessoT.Click
    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiornoStessoT.SelectedDate)
    'Response.End()
    If Not (DalGiornoStessoT.SelectedDate = data0) Then
      filtro_data = " (R.Data >= '" & Format(DalGiornoStessoT.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (r.data >= DATEADD(d, DATEDIFF(d, 0, GETDATE()), 0)) "
    End If
    If (ddlStatoStessoT.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoStessoT.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoStessoT.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(txtMatricolaStessoT.Text) = "") Then
      filtro_matricola = " and (u1.IDUser like '%" & Trim(txtMatricolaStessoT.Text) & "%') "
    End If

    daCambioTurnoStessoTipo.SelectCommand.CommandText = "SELECT r.ts, r.IdRichiesta, r.IdAccertatoreRichiedente, r.IdAccertatoreDestinatario, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0 THEN 'Rifiutato' WHEN 1 THEN 'Approvato' ELSE 'Da approvare' END AS StatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeRichiedente,  u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LTrim(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN left(r.TurnoDestinatario,1) <> '9' THEN LTrim(r.TurnoDestinatario) ELSE 'Riposo' END AS TurnoDestinatario FROM dbo.RichiesteCambiTurnoStessoTipo r LEFT OUTER JOIN dbo.ATC_Utenti u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdApprovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND " & filtro_data & filtro_stato & filtro_matricola & "  ORDER BY r.data DESC, r.ts"

    daCambioTurnoStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")
    dgCambiTurnoStessoT.DataBind()
  End Sub


  Private Sub dgCambiTurnoStessoT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCambiTurnoStessoT.SelectedIndexChanged

  End Sub

  Private Sub dgCambiTurnoStessoT_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCambiTurnoStessoT.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoStessoTipo Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoStessoT.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambioTurnoStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")
      dgCambiTurnoStessoT.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCambiTurnoStessoTipo Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCambiTurnoStessoT.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsCambiTurnoGiornalieriStessoTipo1.Tables("RichiesteCambiTurnoStessoTipo").Clear()
      daCambioTurnoStessoTipo.Fill(DsCambiTurnoGiornalieriStessoTipo1, "RichiesteCambiTurnoStessoTipo")
      dgCambiTurnoStessoT.DataBind()
    End If
  End Sub

  Private Sub dgCongediFrazionati_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCongediFrazionati.SelectedIndexChanged

  End Sub

  Private Sub BtnFiltroCGA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFiltroCGA.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoCGA.SelectedDate = data0) Then
      filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoCGA.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (R.DalGiorno >= GETDATE()) "
    End If
    If (ddlStatoCGA.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (ddlStatoCGA.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (ddlStatoCGA.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(TxtMatricolaCGA.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(TxtMatricolaCGA.Text) & "%') "
    End If
    'MB 2019/05/20

    daCongediGarantiti.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, dbo.GetOrderListCongedi(R.DalGiorno, R.IdAccertatore) AS Ordine, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteCongediGarantiti R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"

    daCongediGarantiti.Fill(DsAmministrazioneCongedi1, "RichiesteCongediGarantiti")
    dgCongediGarantiti.DataBind()

  End Sub

  Private Sub dgCongediGarantiti_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediGarantiti.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCongediGarantiti Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediGarantiti.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCongediGarantiti").Clear()
      daCongediGarantiti.Fill(DsAmministrazioneCongedi1, "RichiesteCongediGarantiti")
      dgCongediGarantiti.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteCongediGarantiti Set IdApprovatore =NULL, DataApprovazione =NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediGarantiti.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCongediGarantiti").Clear()
      daCongediGarantiti.Fill(DsAmministrazioneCongedi1, "RichiesteCongediGarantiti")
      dgCongediGarantiti.DataBind()
    End If
  End Sub



  Private Sub DalGiornoCGA_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DalGiornoCGA.SelectionChanged

  End Sub

  Private Sub dgCongediFrazionati_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCongediFrazionati.ItemCommand
    'DM2020.03 - controllo se son dentro ad un Congedo Frazionato Garantito o no
    Dim sTabella As String
    If e.Item.Cells(13).Text = "X" Then   'riconosco se sono GARANTITO perché qui metto una "X"
      sTabella = "RichiesteCongediGarantitiFra"
    Else
      sTabella = "RichiesteCongediFrazionati"
    End If

    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Or e.CommandName = "Converti" Then
      Dim stato As Integer
      stato = 0

      Dim sc As New SqlClient.SqlCommand("Update " & sTabella & " Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()

      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IdRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediFrazionati.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
        Case "Converti"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 99
          stato = 99
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      If (stato = 99) Then
        Dim conv As New SqlClient.SqlCommand("INSERT INTO RichiesteCongedi(IdRichiesta, IdAccertatore, DalGiorno, StatoApprovazione, DataApprovazione, IdApprovatore, ts, AlGiorno) SELECT NEWID() AS Expr1, IdAccertatore, Data, 1 as stato, DataApprovazione, IdApprovatore, ts, Data AS DataA FROM " & sTabella & " WHERE IdRichiesta =  @IdRichiesta", con)
        con.Open()

        conv.Parameters.Add("@IdRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediFrazionati.DataKeys(e.Item.ItemIndex)
        conv.ExecuteNonQuery()
        con.Close()
        DsAmministrazioneCongedi1.Tables("RichiesteCongedi").Clear()
        daCongedi.Fill(DsAmministrazioneCongedi1, "RichiesteCongedi")
        dgCongedi.DataBind()

      End If
      DsAmministrazioneCongedi1.Tables("RichiesteCongediFrazionati").Clear()
      daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
      dgCongediFrazionati.DataBind()

    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update " & sTabella & " Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = dgCongediFrazionati.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsAmministrazioneCongedi1.Tables("RichiesteCongediFrazionati").Clear()
      daCongediFrazionati.Fill(DsAmministrazioneCongedi1, "RichiesteCongediFrazionati")
      dgCongediFrazionati.DataBind()
    End If
  End Sub

  Private Sub dgCongediFrazionati_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCongediFrazionati.ItemDataBound
    If Not e.Item.FindControl("lblDalleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblDalleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    If Not e.Item.FindControl("lblAlleOre") Is Nothing Then
      Dim t As New TimeSpan("0" & DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text)
      DirectCast(e.Item.FindControl("lblAlleOre"), Label).Text = t.ToString.Substring(0, 5)
    End If
    'If Not e.Item.FindControl("LblGarantiti") Is Nothing Then
    '  If CType(CType(e.Item.FindControl("LblGarantiti"), System.Web.UI.Control), System.Web.UI.WebControls.Label).Text = "1" Then

    '  End If
    'End If
  End Sub

 
  Private Sub DaSpostamentoRiposo_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles DaSpostamentoRiposo.RowUpdated

  End Sub

  Private Sub btnFiltroSPR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltroSPR.Click

    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    Dim filtro_tipo As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    filtro_tipo = "" 'DM2020.04
    Dim data0 = New DateTime(1, 1, 1)

    'Response.Write(DalGiorno.SelectedDate)
    'Response.End()
    If Not (DalGiornoSPR.SelectedDate = data0) Then
      filtro_data = " (R.DalGiorno >= '" & Format(DalGiornoSPR.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (R.DalGiorno >= GETDATE()) "
    End If
    'DM2020.04-gestisco anche il tipo
    If (DdlTipoSPR.Value = "Data") Then
      filtro_tipo = " and R.TipoSpostamento=' ' "
    ElseIf (DdlTipoSPR.Value = "Straordinario") Then
      filtro_tipo = " and R.TipoSpostamento='S' "
    ElseIf (DdlTipoSPR.Value = "Ferie") Then
      filtro_tipo = " and R.TipoSpostamento='F' "
    Else
      filtro_tipo = " "
    End If
    '
    If (DdlStatoSPR.Value = "Rifiutati") Then
      filtro_stato = " and R.StatoApprovazione=0 "
    ElseIf (DdlStatoSPR.Value = "Approvati") Then
      filtro_stato = " and R.StatoApprovazione=1 "
    ElseIf (DdlStatoSPR.Value = "Da approvare") Then
      filtro_stato = " and (R.StatoApprovazione is null) "
    End If
    If (Not Trim(TxtMatricolaSPR.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(TxtMatricolaSPR.Text) & "%') "
    End If
    'MB 2019/05/20
    'SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.TipoSpostamento, R.AlGiorno,  CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS TS, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteSpostamentoRiposo R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & " ORDER BY R.DalGiorno DESC, R.ts"
    DaSpostamentoRiposo.SelectCommand.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.TipoSpostamento, R.AlGiorno,  CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS TS, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FROM dbo.RichiesteSpostamentoRiposo R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE " & filtro_data & filtro_matricola & filtro_stato & filtro_tipo & " ORDER BY R.DalGiorno DESC, R.ts"

    DaSpostamentoRiposo.Fill(DsSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
    DgSpostamentoRiposo.DataBind()
  End Sub

  Private Sub DgSpostamentoRiposo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgSpostamentoRiposo.SelectedIndexChanged

  End Sub

  Private Sub DgSpostamentoRiposo_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DgSpostamentoRiposo.ItemCommand
    If e.CommandName = "Approva" Or e.CommandName = "Rifiuta" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteSpostamentoRiposo Set IdApprovatore = @IdApprovatore, DataApprovazione = GetDate(), StatoApprovazione = @StatoApprovazione Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IdApprovatore", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = DgSpostamentoRiposo.DataKeys(e.Item.ItemIndex)
      Select Case e.CommandName
        Case "Approva"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 1
        Case "Rifiuta"
          sc.Parameters.Add("@StatoApprovazione", SqlDbType.Int).Value = 0
      End Select
      sc.ExecuteNonQuery()
      con.Close()
      DsSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Clear()
      DaSpostamentoRiposo.Fill(DsSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
      DgSpostamentoRiposo.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update RichiesteSpostamentoRiposo Set IdApprovatore = NULL, DataApprovazione = NULL, StatoApprovazione = NULL Where IDRichiesta = @IdRichiesta", con)
      con.Open()
      sc.Parameters.Add("@IDRichiesta", SqlDbType.UniqueIdentifier).Value = DgSpostamentoRiposo.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsSpostamentoRiposo1.Tables("RichiesteSpostamentoRiposo").Clear()
      DaSpostamentoRiposo.Fill(DsSpostamentoRiposo1, "RichiesteSpostamentoRiposo")
      DgSpostamentoRiposo.DataBind()
    End If

  End Sub

  Private Sub DgSpostamentoRiposo_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DgSpostamentoRiposo.ItemDataBound
    'DM2020.04 - Quando mostro la tabella scrivo al posto del LBLTIPO il vero TipoSpostamento
    If e.Item.Cells(1).Text.Trim <> "" And e.Item.Cells(1).Text.Trim <> "Tipo" Then
      If e.Item.Cells(11).Text <> "&nbsp;" Then      
        'DM2020.05 - se sono sul tipo F:ferie o S:Straordinari, non mostro la DATA A ma metto l'indicazione di ORADA ORAA
        Dim t1 As New TimeSpan("0" & e.Item.Cells(11).Text)
        Dim t2 As New TimeSpan("0" & e.Item.Cells(12).Text)
        e.Item.Cells(3).Text = t1.ToString.Substring(0, 5) & " - " & t2.ToString.Substring(0, 5)
      End If
    End If
  End Sub
  Sub ColoraGerarchie()
    Dim i As Integer
    Dim cORDINE As Integer = 5
    Dim cCODICE As Integer = 12
    Dim cDATADA As Integer = 3
    If dgGiustificativi.EditItemIndex = -1 Then
      For i = 0 To dgGiustificativi.Items.Count - 1

        ' colonna 17: ordine
        ' colonna 18: codice
        ' colonna 19: datada
        If dgGiustificativi.Items(i).Cells(cCODICE).Text = "04" Then
          Dim laDATA As Date
          Dim ilCOLORE As Drawing.Color
          ilCOLORE = Color.Black
          laDATA = dgGiustificativi.Items(i).Cells(cDATADA).Text
          'Else
          'laDATA = FormatDateTime(DirectCast(dgGiustificativi.Items(i).FindControl("LblDataDa"), Label).Text(), DateFormat.ShortDate)
          'End If
          If laDATA.DayOfWeek = DayOfWeek.Saturday Then
            ' se è sabato: massimo 1 al gg
            If dgGiustificativi.Items(i).Cells(cORDINE).Text > 1 Then
              ilCOLORE = Color.Red
            End If
          ElseIf pFestivita(laDATA.AddDays(1)) And pFestivita(laDATA.AddDays(-1)) Then
            If IsNumeric(dgGiustificativi.Items(i).Cells(cORDINE).Text) Then
              ' se è un gg in mezzo a due giorni di festa: massimo 1 al gg
              If dgGiustificativi.Items(i).Cells(cORDINE).Text > 1 Then
                ilCOLORE = Color.Red
              End If
            End If
          Else
            ' altrimenti massimo 2 al gg
            If IsNumeric(dgGiustificativi.Items(i).Cells(cORDINE).Text) Then
              If dgGiustificativi.Items(i).Cells(cORDINE).Text > 2 Then
                ilCOLORE = Color.Red
              End If
            End If
          End If
          'MASSIMO 2 PER GIORNO SE SI TRATTA DI CONGEDO PARENTALE FRAZIONATO (32)
          dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = ilCOLORE
        ElseIf dgGiustificativi.Items(i).Cells(cCODICE).Text = "32" Then
            If IsNumeric(dgGiustificativi.Items(i).Cells(cORDINE).Text) Then
              If dgGiustificativi.Items(i).Cells(cORDINE).Text > 2 Then
                'MASSIMO 2 PER GIORNO SE SI TRATTA DI CONGEDO PARENTALE FRAZIONATO (32)
                dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = Color.Red
              Else
                dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = Color.Black
              End If
            Else
              dgGiustificativi.Items(i).Cells(cORDINE).ForeColor = Color.Black
            End If
        End If
      Next i
    End If
  End Sub

  Private Sub dgGiustificativi_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGiustificativi.PreRender
    ColoraGerarchie()
  End Sub
  Private Function pFestivita(ByVal dal As Date, Optional ByVal AncheRiposo As Boolean = False) As Boolean
    'DM2020.02 - controllo che la data sia una festività: se lo è ritorno TRUE
    Dim i As Integer = 0

    Dim sc As New SqlClient.SqlCommand("Select Count(*) From Conf_Festivita Where Fest_Data = @Data", con)
    sc.Parameters.Add("@Data", SqlDbType.DateTime).Value = FormatDateTime(dal, DateFormat.ShortDate)
    con.Open()
    If sc.ExecuteScalar() > 0 Or dal.DayOfWeek = DayOfWeek.Sunday Then
      pFestivita = True
    Else
      pFestivita = False
    End If
    con.Close()

    If Not pFestivita And AncheRiposo Then

      Dim scRiposi As New SqlClient.SqlCommand("SELECT COUNT(*) FROM [Riposi] where TTGGGG = DAY(@data) and TTMMGG = MONTH(@data) and TTAAGG = YEAR (@data) and TTMATR = '" & oUtente.IDUser & "'", con)
      scRiposi.Parameters.Add("@Data", SqlDbType.DateTime).Value = dal
      con.Open()
      If scRiposi.ExecuteScalar() > 0 Then
        pFestivita = True
      Else
        pFestivita = False
      End If

      con.Close()
    End If
  End Function

  Private Sub dgGiustificativi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGiustificativi.SelectedIndexChanged

  End Sub

  Private Sub dgGiustificativi_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgGiustificativi.ItemDataBound
    If e.Item.Cells(13).Text.ToLower = "false" Then
      e.Item.Cells(3).Text = FormatDateTime(e.Item.Cells(3).Text, DateFormat.ShortDate)
      e.Item.Cells(4).Text = FormatDateTime(e.Item.Cells(4).Text, DateFormat.ShortDate)
    End If

  End Sub
End Class
