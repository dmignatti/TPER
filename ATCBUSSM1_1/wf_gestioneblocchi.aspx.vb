Public Class wf_gestioneblocchi
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
    Me.DaBloccoCambioGiornaliero = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
    Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
    Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
    Me.DsBlocco1 = New ATCBussm1.DSBlocco
    Me.DaAccertatori = New System.Data.SqlClient.SqlDataAdapter
    Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
    CType(Me.DsAmministrazioneCongedi1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DsBlocco1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.SqlSelectCommand1.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, CASE WHEN R" & _
    ".StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Appro" & _
    "vato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazi" & _
    "one, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Co" & _
    "gnome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, " & _
    "U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FR" & _
    "OM dbo.RichiesteCongedi R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = " & _
    "U.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGi" & _
    "orno >= GETDATE()) ORDER BY R.DalGiorno DESC, R.ts"
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
    "io, r.data, r.DataApprovazione, r.IdApprovatore, CASE R.StatoApprovazione WHEN 0" & _
    " THEN 'Rifiutato' WHEN 1 THEN 'Approvato' WHEN NULL THEN 'Da Approvare' END AS S" & _
    "tatoApprovazione, u1.IDUser + ' - ' + u1.Cognome + ' ' + u1.Nome AS CognomeNomeR" & _
    "ichiedente, u2.IDUser + ' - ' + u2.Cognome + ' ' + u2.Nome AS CognomeNomeDestina" & _
    "tario, u3.IDUser AS Approvatore, CASE WHEN r.TurnoRichiedente < 90000 THEN LTrim" & _
    "(Str(r.TurnoRichiedente)) ELSE 'Riposo' END AS TurnoRichiedente, CASE WHEN r.Tur" & _
    "noDestinatario < 90000 THEN LTrim(Str(r.TurnoDestinatario)) ELSE 'Riposo' END AS" & _
    " TurnoDestinatario FROM dbo.RichiesteCambiTurno r LEFT OUTER JOIN dbo.ATC_Utenti" & _
    " u1 ON r.IdAccertatoreRichiedente = u1.ID LEFT OUTER JOIN dbo.ATC_Utenti u2 ON r" & _
    ".IdAccertatoreDestinatario = u2.ID LEFT OUTER JOIN dbo.ATC_Utenti u3 ON r.IdAppr" & _
    "ovatore = u3.ID WHERE (r.StatoRichiesta = 1) AND (r.data >= DATEADD(d, DATEDIFF(" & _
    "d, 0, GETDATE()), 0)) ORDER BY r.data DESC, r.ts"
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
    Me.SqlSelectCommand3.CommandText = "SELECT R.ts, R.IdRichiesta, R.IdAccertatore, R.DalGiorno, R.AlGiorno, CASE WHEN R" & _
    ".StatoApprovazione = 0 THEN 'Rifiutato' WHEN R.StatoApprovazione = 1 THEN 'Appro" & _
    "vato' WHEN R.StatoApprovazione IS NULL THEN 'Da Approvare' END AS StatoApprovazi" & _
    "one, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1, U.IDUser + ' - ' + U.Co" & _
    "gnome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitato, U.DataUltimoAccesso, " & _
    "U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2.IDUser AS Approvatore FR" & _
    "OM dbo.RichiesteFerie R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U." & _
    "ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.DalGior" & _
    "no >= GETDATE()) ORDER BY R.DalGiorno DESC, R.ts"
    Me.SqlSelectCommand3.Connection = Me.con
    '
    'daCongediFrazionati
    '
    Me.daCongediFrazionati.SelectCommand = Me.SqlSelectCommand4
    Me.daCongediFrazionati.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RichiesteCongediFrazionati", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ts", "ts"), New System.Data.Common.DataColumnMapping("IdRichiesta", "IdRichiesta"), New System.Data.Common.DataColumnMapping("IdAccertatore", "IdAccertatore"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("IdApprovatore", "IdApprovatore"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("EMail", "EMail"), New System.Data.Common.DataColumnMapping("Abilitato", "Abilitato"), New System.Data.Common.DataColumnMapping("DataUltimoAccesso", "DataUltimoAccesso"), New System.Data.Common.DataColumnMapping("OraUltimoAccesso", "OraUltimoAccesso"), New System.Data.Common.DataColumnMapping("NrAccessi", "NrAccessi"), New System.Data.Common.DataColumnMapping("TipoUtente", "TipoUtente"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore")})})
    '
    'SqlSelectCommand4
    '
    Me.SqlSelectCommand4.CommandText = "SELECT Isnull(R.StatoApprovazione,0) as stato, R.ts, R.IdRichiesta, R.IdAccertato" & _
    "re, R.Data, R.DalleOre, R.AlleOre, CASE WHEN R.StatoApprovazione = 0 THEN 'Rifiu" & _
    "tato' WHEN R.StatoApprovazione = 1 THEN 'Approvato' WHEN R.StatoApprovazione IS " & _
    "NULL THEN 'Da Approvare' WHEN R.StatoApprovazione = 99 THEN 'Convertito in inter" & _
    "o' END AS StatoApprovazione, R.DataApprovazione, R.IdApprovatore, R.ts AS Expr1," & _
    " U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, U.EMail, U.Abilitat" & _
    "o, U.DataUltimoAccesso, U.OraUltimoAccesso, U.NrAccessi, U.TipoUtente, U.ID, U2." & _
    "IDUser AS Approvatore, isnull(Intero,0) as Intero  FROM dbo.RichiesteCongediFraz" & _
    "ionati R LEFT OUTER JOIN dbo.ATC_Utenti U ON R.IdAccertatore = U.ID LEFT OUTER J" & _
    "OIN dbo.ATC_Utenti U2 ON R.IdApprovatore = U2.ID WHERE (R.Data >= DATEADD(d, DAT" & _
    "EDIFF(d, 5, GETDATE()), 0)) ORDER BY R.Data DESC, R.DalleOre DESC, R.ts"
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
    'SqlConnection1
    '
    Me.SqlConnection1.ConnectionString = "workstation id=""VM-XPDEV"";packet size=4096;user id=utentebussm;data source=INSVSQ" & _
    "L03TST;persist security info=False;initial catalog=ATCBussm"
    '
    'DaGiustificativo
    '
    Me.DaGiustificativo.SelectCommand = Me.SqlSelectCommand6
    Me.DaGiustificativo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_GiustificativoRichiesta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Approvatore", "Approvatore"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("StatoApprovazione", "StatoApprovazione"), New System.Data.Common.DataColumnMapping("Accertatori_GiustificativoCausaleId", "Accertatori_GiustificativoCausaleId"), New System.Data.Common.DataColumnMapping("DataDa", "DataDa"), New System.Data.Common.DataColumnMapping("DataA", "DataA"), New System.Data.Common.DataColumnMapping("OraDa", "OraDa"), New System.Data.Common.DataColumnMapping("OraA", "OraA"), New System.Data.Common.DataColumnMapping("StatoGiustificativo", "StatoGiustificativo"), New System.Data.Common.DataColumnMapping("DataRichiesta", "DataRichiesta"), New System.Data.Common.DataColumnMapping("DataApprovazione", "DataApprovazione"), New System.Data.Common.DataColumnMapping("ApprovatoDa", "ApprovatoDa"), New System.Data.Common.DataColumnMapping("CreatedOn", "CreatedOn"), New System.Data.Common.DataColumnMapping("ModifiedOn", "ModifiedOn"), New System.Data.Common.DataColumnMapping("CreatedBy", "CreatedBy"), New System.Data.Common.DataColumnMapping("ModifiedBy", "ModifiedBy"), New System.Data.Common.DataColumnMapping("Frazionato", "Frazionato"), New System.Data.Common.DataColumnMapping("DefaultApprovato", "DefaultApprovato"), New System.Data.Common.DataColumnMapping("PreavvisoGG", "PreavvisoGG"), New System.Data.Common.DataColumnMapping("NrMaxGG", "NrMaxGG"), New System.Data.Common.DataColumnMapping("Causale", "Causale")})})
    '
    'SqlSelectCommand6
    '
    Me.SqlSelectCommand6.CommandText = "SELECT U.Cognome + ' ' + U.Nome AS Approvatore, U1.IDUser + ' - ' + U1.Cognome + " & _
    "' ' + U1.Nome AS CognomeNome, RG.ID, RG.AccertatoreId, CASE WHEN RG.StatoGiustif" & _
    "icativo IS NULL THEN 'Da approvare' WHEN RG.StatoGiustificativo = 0 THEN 'Respin" & _
    "ta' WHEN RG.StatoGiustificativo = 1 THEN 'Approvata' END AS StatoApprovazione, R" & _
    "G.Accertatori_GiustificativoCausaleId, RG.DataDa, RG.DataA, RG.OraDa, RG.OraA, R" & _
    "G.StatoGiustificativo, RG.DataRichiesta, RG.DataApprovazione, RG.ApprovatoDa, RG" & _
    ".CreatedOn, RG.ModifiedOn, RG.CreatedBy, RG.ModifiedBy, RG.Frazionato, RG.Defaul" & _
    "tApprovato, RG.PreavvisoGG, RG.NrMaxGG, GC.Nome AS Causale FROM dbo.Accertatori_" & _
    "GiustificativoRichiesta RG INNER JOIN dbo.Accertatori_GiustificativoCausale GC O" & _
    "N RG.Accertatori_GiustificativoCausaleId = GC.ID LEFT OUTER JOIN dbo.ATC_Utenti " & _
    "U1 ON RG.AccertatoreId = U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U ON RG.ApprovatoD" & _
    "a = U.ID WHERE (RG.OraDa >= DATEADD(d, DATEDIFF(d, 5, GETDATE()), 0)) ORDER BY R" & _
    "G.OraDa DESC, RG.DataRichiesta DESC"
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
    'DaBloccoCambioGiornaliero
    '
    Me.DaBloccoCambioGiornaliero.DeleteCommand = Me.SqlDeleteCommand1
    Me.DaBloccoCambioGiornaliero.InsertCommand = Me.SqlInsertCommand1
    Me.DaBloccoCambioGiornaliero.SelectCommand = Me.SqlSelectCommand7
    Me.DaBloccoCambioGiornaliero.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accertatori_BloccoCambioGiornaliero", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Matricola", "Matricola"), New System.Data.Common.DataColumnMapping("AccertatoreId", "AccertatoreId"), New System.Data.Common.DataColumnMapping("AggiornamentoOn", "AggiornamentoOn"), New System.Data.Common.DataColumnMapping("InizioOn", "InizioOn"), New System.Data.Common.DataColumnMapping("FineOn", "FineOn"), New System.Data.Common.DataColumnMapping("Motivo", "Motivo"), New System.Data.Common.DataColumnMapping("IdInizioBy", "IdInizioBy"), New System.Data.Common.DataColumnMapping("IdFineBy", "IdFineBy")})})
    Me.DaBloccoCambioGiornaliero.UpdateCommand = Me.SqlUpdateCommand1
    '
    'SqlDeleteCommand1
    '
    Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.Accertatori_BloccoCambioGiornaliero WHERE (ID = @Original_ID) AND" & _
    " (AccertatoreId = @Original_AccertatoreId OR @Original_AccertatoreId IS NULL AND" & _
    " AccertatoreId IS NULL) AND (AggiornamentoOn = @Original_AggiornamentoOn OR @Ori" & _
    "ginal_AggiornamentoOn IS NULL AND AggiornamentoOn IS NULL) AND (FineOn = @Origin" & _
    "al_FineOn OR @Original_FineOn IS NULL AND FineOn IS NULL) AND (IdFineBy = @Origi" & _
    "nal_IdFineBy OR @Original_IdFineBy IS NULL AND IdFineBy IS NULL) AND (IdInizioBy" & _
    " = @Original_IdInizioBy OR @Original_IdInizioBy IS NULL AND IdInizioBy IS NULL) " & _
    "AND (InizioOn = @Original_InizioOn OR @Original_InizioOn IS NULL AND InizioOn IS" & _
    " NULL) AND (Motivo = @Original_Motivo OR @Original_Motivo IS NULL AND Motivo IS " & _
    "NULL) AND (Stato = @Original_Stato OR @Original_Stato IS NULL AND Stato IS NULL)" & _
    ""
    Me.SqlDeleteCommand1.Connection = Me.con
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AggiornamentoOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AggiornamentoOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FineOn", System.Data.SqlDbType.Variant, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FineOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdFineBy", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdFineBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdInizioBy", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdInizioBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_InizioOn", System.Data.SqlDbType.Variant, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InizioOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Motivo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Motivo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Stato", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stato", System.Data.DataRowVersion.Original, Nothing))
    '
    'SqlInsertCommand1
    '
    Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.Accertatori_BloccoCambioGiornaliero (ID, AccertatoreId, InizioOn," & _
    " Motivo, IdInizioBy, Stato, FineOn, IdFineBy) VALUES (@ID, @AccertatoreId, @Iniz" & _
    "ioOn, @Motivo, @IdInizioBy, @Stato, @FineOn, @IdFineBy); SELECT ID, AccertatoreI" & _
    "d, InizioOn, Motivo, IdInizioBy, Stato, FineOn, IdFineBy FROM dbo.Accertatori_Bl" & _
    "occoCambioGiornaliero WHERE (ID = @ID)"
    Me.SqlInsertCommand1.Connection = Me.con
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@InizioOn", System.Data.SqlDbType.DateTime, 8, "InizioOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Motivo", System.Data.SqlDbType.NVarChar, 50, "Motivo"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdInizioBy", System.Data.SqlDbType.Int, 4, "IdInizioBy"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Stato", System.Data.SqlDbType.NVarChar, 50, "Stato"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FineOn", System.Data.SqlDbType.DateTime, 8, "FineOn"))
    Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdFineBy", System.Data.SqlDbType.Int, 4, "IdFineBy"))
    '
    'SqlSelectCommand7
    '
    Me.SqlSelectCommand7.CommandText = "SELECT B.ID, B.AccertatoreId, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS Cogn" & _
    "omeNome, B.AggiornamentoOn, B.InizioOn, B.FineOn, B.Motivo, B.IdInizioBy, B.IdFi" & _
    "neBy, B.Stato, U1.IDUser AS InseritoDa, U2.IDUser AS TerminatoDa FROM dbo.Accert" & _
    "atori_BloccoCambioGiornaliero B LEFT OUTER JOIN dbo.ATC_Utenti U ON B.Accertator" & _
    "eId = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U1 ON B.IdInizioBy = U1.ID LEFT OUTER " & _
    "JOIN dbo.ATC_Utenti U2 ON B.IdFineBy = U2.ID"
    Me.SqlSelectCommand7.Connection = Me.con
    '
    'SqlUpdateCommand1
    '
    Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.Accertatori_BloccoCambioGiornaliero SET AccertatoreId = @AccertatoreId" & _
    ", AggiornamentoOn = @AggiornamentoOn, InizioOn = @InizioOn, FineOn = @FineOn, Mo" & _
    "tivo = @Motivo, IdInizioBy = @IdInizioBy, Stato = @Stato WHERE (AccertatoreId = " & _
    "@Original_AccertatoreId OR @Original_AccertatoreId IS NULL AND AccertatoreId IS " & _
    "NULL) AND (AggiornamentoOn = @Original_AggiornamentoOn OR @Original_Aggiornament" & _
    "oOn IS NULL AND AggiornamentoOn IS NULL) AND (IdInizioBy = @Original_IdInizioBy " & _
    "OR @Original_IdInizioBy IS NULL AND IdInizioBy IS NULL) AND (InizioOn = @Origina" & _
    "l_InizioOn OR @Original_InizioOn IS NULL AND InizioOn IS NULL) AND (IdFineBy = @" & _
    "Original_IdFineBy OR @Original_IdFineBy IS NULL AND IdFineBy IS NULL) AND (FineO" & _
    "n = @Original_FineOn OR @Original_FineOn IS NULL AND FineOn IS NULL) AND (Motivo" & _
    " = @Original_Motivo OR @Original_Motivo IS NULL AND Motivo IS NULL) AND (Stato =" & _
    " @Original_Stato OR @Original_Stato IS NULL AND Stato IS NULL); SELECT ID, Accer" & _
    "tatoreId, AggiornamentoOn, InizioOn, FineOn, Motivo, IdInizioBy, IdFineBy, Stato" & _
    " FROM dbo.Accertatori_BloccoCambioGiornaliero WHERE (ID = @ID)"
    Me.SqlUpdateCommand1.Connection = Me.con
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccertatoreId", System.Data.SqlDbType.Int, 4, "AccertatoreId"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AggiornamentoOn", System.Data.SqlDbType.DateTime, 8, "AggiornamentoOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@InizioOn", System.Data.SqlDbType.DateTime, 8, "InizioOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FineOn", System.Data.SqlDbType.DateTime, 8, "FineOn"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Motivo", System.Data.SqlDbType.NVarChar, 50, "Motivo"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdInizioBy", System.Data.SqlDbType.Int, 4, "IdInizioBy"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Stato", System.Data.SqlDbType.NVarChar, 50, "Stato"))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccertatoreId", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccertatoreId", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AggiornamentoOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AggiornamentoOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdInizioBy", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdInizioBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_InizioOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InizioOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdFineBy", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdFineBy", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FineOn", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FineOn", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Motivo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Motivo", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Stato", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stato", System.Data.DataRowVersion.Original, Nothing))
    Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"))
    '
    'DsBlocco1
    '
    Me.DsBlocco1.DataSetName = "DSBlocco"
    Me.DsBlocco1.Locale = New System.Globalization.CultureInfo("it-IT")
    '
    'DaAccertatori
    '
    Me.DaAccertatori.SelectCommand = Me.SqlCommand3
    Me.DaAccertatori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATC_Utenti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("CognomeNome", "CognomeNome")})})
    '
    'SqlCommand3
    '
    Me.SqlCommand3.CommandText = "SELECT ID, IDUser + ' - ' + Cognome + ' ' + Nome AS CognomeNome FROM dbo.ATC_Uten" & _
    "ti WHERE (TipoUtente = 2) AND (Abilitato = 1) ORDER BY IDUser + ' - ' + Cognome " & _
    "+ ' ' + Nome"
    Me.SqlCommand3.Connection = Me.con
    CType(Me.DsAmministrazioneCongedi1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DsBlocco1, System.ComponentModel.ISupportInitialize).EndInit()

  End Sub
  Protected WithEvents con As System.Data.SqlClient.SqlConnection
  Protected WithEvents daCongedi As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents DsAmministrazioneCongedi1 As ATCBussm1.dsAmministrazioneCongedi
  Protected WithEvents daCambiTurno As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCambiTurnoMensili As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daFerie As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCongediFrazionati As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
  Protected WithEvents lblMatricola As System.Web.UI.WebControls.Label
  Protected WithEvents txtMatricola As System.Web.UI.WebControls.TextBox
  Protected WithEvents lblStato As System.Web.UI.WebControls.Label
  Protected WithEvents lblDalGiorno As System.Web.UI.WebControls.Label
  Protected WithEvents btnFiltro As System.Web.UI.WebControls.Button
  Protected WithEvents ddlStato As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents daMancataTimbratura As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
  Protected WithEvents DaGiustificativo As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
  Protected WithEvents daCausali As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DaBloccoCambioGiornaliero As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
  Protected WithEvents DsBlocco1 As ATCBussm1.DSBlocco
  Protected WithEvents dgBlocchiGiornalieri As System.Web.UI.WebControls.DataGrid
  Protected WithEvents DataInizio As System.Web.UI.WebControls.Calendar
  Protected WithEvents BtnNuovo As System.Web.UI.WebControls.Button
  Protected WithEvents DaAccertatori As System.Data.SqlClient.SqlDataAdapter
  Protected WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand

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


    If Not IsPostBack Then
      AllineaStatoAFine()
      DataInizio.SelectedDate = New Date(2018, 1, 1)

      'DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
      Ricerca()
      Page.DataBind()

      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneblocchi.aspx", "Pagina iniziale", Session("IPAddress"))
    Else
      Ricerca()
      'dgBlocchiGiornalieri.DataBind()
    End If
  End Sub

  Private Sub AllineaStatoAFine()
    Dim sc As New SqlClient.SqlCommand("Update Accertatori_BloccoCambioGiornaliero Set AggiornamentoOn = GetDate(), Stato = 'Terminato' Where FineOn<= GetDate() ", con)
    con.Open()

    sc.ExecuteNonQuery()
    con.Close()
  End Sub

  Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
    Ricerca()

    dgBlocchiGiornalieri.DataBind()
  End Sub

  Private Sub Ricerca()
    Dim filtro_stato As String
    Dim filtro_matricola As String
    Dim filtro_data As String
    filtro_stato = ""
    filtro_matricola = ""
    filtro_data = ""
    Dim data0 = New DateTime(1, 1, 1)


    If Not (DataInizio.SelectedDate = data0) Then
      filtro_data = " (InizioOn>= '" & Format(DataInizio.SelectedDate, "yyyy-MM-dd") & "') "
    Else
      filtro_data = " (InizioOn >= '2018-01-01') "
    End If
    If (ddlStato.Value = "Annullati") Then
      filtro_stato = " and B.Stato= 'Annullato'"
    ElseIf (ddlStato.Value = "Terminati") Then
      filtro_stato = " and B.Stato= 'Terminato' "
    ElseIf (ddlStato.Value = "Attivi") Then
      filtro_stato = " and (B.Stato ='Attivo') "
    End If
    If (Not Trim(txtMatricola.Text) = "") Then
      filtro_matricola = " and (U.IDUser like '%" & Trim(txtMatricola.Text) & "%') "
    End If
    DaBloccoCambioGiornaliero.SelectCommand.CommandText = "SELECT B.ID, AccertatoreId, U.IDUser + ' - ' + U.Cognome + ' ' + U.Nome AS CognomeNome, AggiornamentoOn, InizioOn,  FineOn, Motivo, IdInizioBy, IdFineBy, Stato, U1.IDUser AS InseritoDa, U2.IDUser AS TerminatoDa FROM dbo.Accertatori_BloccoCambioGiornaliero as B  LEFT OUTER JOIN dbo.ATC_Utenti U ON B.AccertatoreId = U.ID LEFT OUTER JOIN dbo.ATC_Utenti U1 ON B.IdInizioBy = U1.ID LEFT OUTER JOIN dbo.ATC_Utenti U2 ON B.IdFineBy = U2.ID  WHERE " & filtro_data & filtro_stato & filtro_matricola & "   ORDER BY InizioOn "

    DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
    ' dgBlocchiGiornalieri.DataBind()


  End Sub

  Private Sub BtnNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuovo.Click
    DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
    DaAccertatori.Fill(DsBlocco1, "ATC_Utenti")
    ' pCaricaTurniAccertatoriGiornaliero(ddlData.SelectedValue)
    Me.Validate()
    If Me.IsValid Then
      'Dim richiesteG As String
      'richiesteG = ""
      'richiesteG = RichiestePresenti(ddlData.SelectedValue, oUtente.ID)
      'If Not (richiesteG = "") Then

      '  cvSoloUnCambio.ErrorMessage = richiesteG
      '  cvSoloUnCambio.IsValid = False

      'Else
      Dim dr As DataRow = DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").NewRow
      dr.Item("ID") = Guid.NewGuid

      dr.Item("IdInizioBy") = oUtente.ID
      dr.Item("IdFineBy") = oUtente.ID
      dr.Item("InizioOn") = Now()
      dr.Item("FineOn") = Now().AddMonths(1)

      dr.Item("AccertatoreId") = DsBlocco1.Tables("ATC_Utenti").Rows(0).Item("ID")

      DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Rows.InsertAt(dr, 0)
      dgBlocchiGiornalieri.EditItemIndex = 0
      BtnNuovo.Enabled = False
      Page.DataBind()
      fnc.ScriviLog(oUtente.IDUser, "wf_gestioneblocchi.aspx", "Inserito blocco ", Session("IPAddress"))
      '   End If

    Else

    End If

  End Sub

  Private Sub dgBlocchiGiornalieri_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBlocchiGiornalieri.ItemCommand
    If e.CommandName = "Termina" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_BloccoCambioGiornaliero Set IdFineBy = @IdFineBy, AggiornamentoOn = GetDate(), FineOn= GetDate(), Stato = 'Terminato' Where ID = @Id", con)
      con.Open()
      sc.Parameters.Add("@IdFineBy", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgBlocchiGiornalieri.DataKeys(e.Item.ItemIndex)

      sc.ExecuteNonQuery()
      con.Close()
      DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Clear()
      DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
      dgBlocchiGiornalieri.DataBind()
    ElseIf e.CommandName = "Annulla" Then
      Dim sc As New SqlClient.SqlCommand("Update Accertatori_BloccoCambioGiornaliero Set IdFineBy = @IdFineBy, AggiornamentoOn = GetDate(), FineOn= GetDate(), Stato = 'Annullato' Where ID = @Id", con)
      con.Open()
      sc.Parameters.Add("@IdFineBy", SqlDbType.Int).Value = oUtente.ID
      sc.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dgBlocchiGiornalieri.DataKeys(e.Item.ItemIndex)
      sc.ExecuteNonQuery()
      con.Close()
      DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Clear()
      DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
      dgBlocchiGiornalieri.DataBind()
    End If
  End Sub

  Private Sub dgBlocchiGiornalieri_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBlocchiGiornalieri.UpdateCommand

    Dim dr As DataRow = DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Rows.Find(dgBlocchiGiornalieri.DataKeys(e.Item.ItemIndex))
    DaAccertatori.Fill(DsBlocco1, "ATC_Utenti")
    If dr Is Nothing Then
      dr = DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").NewRow
      dr.Item("ID") = Guid.NewGuid
      dr.Item("IdInizioBy") = oUtente.ID
      dr.Item("IdFineBy") = oUtente.ID
      dr.Item("InizioOn") = Now()
      dr.Item("FineOn") = Now().AddMonths(1)
      dr.Item("AccertatoreId") = DsBlocco1.Tables("ATC_Utenti").Rows(0).Item("ID")
      DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Rows.Add(dr)
    Else
      dr.Item("AggiornamentoOn") = Now()
    End If


    dr.Item("AccertatoreId") = (DirectCast(e.Item.FindControl("ddlOperatore"), DropDownList).SelectedValue)
    dr.Item("InizioOn") = IIf(DirectCast(e.Item.FindControl("caInizioOn"), Calendar).SelectedDate() < Now, Now, DirectCast(e.Item.FindControl("caInizioOn"), Calendar).SelectedDate())
    dr.Item("FineOn") = DirectCast(e.Item.FindControl("caFineOn"), Calendar).SelectedDate().AddDays(1).AddSeconds(-1)
    dr.Item("Motivo") = DirectCast(e.Item.FindControl("txtMotivo"), TextBox).Text
    dr.Item("Stato") = "Attivo"
    DaBloccoCambioGiornaliero.Update(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
    DsBlocco1.Tables("Accertatori_BloccoCambioGiornaliero").Clear()
    DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")

    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneblocchi.aspx", "Confermato il blocco", Session("IPAddress"))
    BtnNuovo.Enabled = True

    dgBlocchiGiornalieri.EditItemIndex = -1
    Page.DataBind()

  End Sub

  Private Sub dgBlocchiGiornalieri_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBlocchiGiornalieri.CancelCommand
    BtnNuovo.Enabled = True

    dgBlocchiGiornalieri.EditItemIndex = -1

    Page.DataBind()
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneblocchi.aspx", "Annullata la modifica del blocco cambio turno", Session("IPAddress"))
  End Sub

  Private Sub dgBlocchiGiornalieri_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgBlocchiGiornalieri.EditCommand
    DaBloccoCambioGiornaliero.Fill(DsBlocco1, "Accertatori_BloccoCambioGiornaliero")
    dgBlocchiGiornalieri.DataBind()
    DaAccertatori.Fill(DsBlocco1, "ATC_Utenti")
    dgBlocchiGiornalieri.EditItemIndex = e.Item.ItemIndex
    Page.DataBind()
    BtnNuovo.Enabled = False
    fnc.ScriviLog(oUtente.IDUser, "wf_gestioneblocchi.aspx", "Stato di modifica del blocco", Session("IPAddress"))
  End Sub
End Class
