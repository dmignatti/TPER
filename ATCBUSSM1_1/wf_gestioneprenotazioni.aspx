<HTML>
	<HEAD>
		<title>wf_gestionecongedi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					prenotazione di ferie</legend>
				<p>Le richieste sono ordinate per il campo "Intervallo" in maniera decrescente. A 
					parità di&nbsp;data le richieste sono ordinate anche per il campo "Data 
					prenotazione" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricolaF" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaF" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStatoF" Runat="server" CssClass="label">Stato approvazion</asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoF" name="ddlStatoF" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Prenotati" value="Prenotati"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblPeriodoP" Runat="server" CssClass="label">Periodo prenotazione: </asp:label></td>
						<td></td>
						<td><asp:button id="btnFiltroF" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgPrenotazione runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="Accertatori_PrenotazioneRichiesta" DataKeyField="ID" DataSource="<%# DsGestionePreno1 %>" UseAccessibleHeader="True">
					<Columns>
						<asp:BoundColumn DataField="ID" SortExpression="ID" HeaderText="ID"></asp:BoundColumn>
					</Columns>
				</asp:datagrid></fieldset>
			&nbsp;
			<br>
			&nbsp;
			<br>
		</form>
	</body>
</HTML>
