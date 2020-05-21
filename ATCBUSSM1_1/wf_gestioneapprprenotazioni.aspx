<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestioneapprprenotazioni.aspx.vb" Inherits="ATCBussm1.wf_gestioneapprprenotazioni"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gestioneapprprenotazioni</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					prenotazione di ferie</legend>
				<p>Le richieste sono ordinate per il campo "Periodo", poi per il campo 
					"Intervallo". A parità di&nbsp;intervallo le richieste sono ordinate anche per 
					il campo "Data prenotazione" in maniera crescente.
					<asp:DataGrid id="DgApprovaprenotazioni" CssClass="grid" runat="server" Width ="100%" DataSource="<%# DsApprovaPreno1 %>" DataKeyField="ID" DataMember="Accertatori_PrenotazioneRichiesta" AutoGenerateColumns="False" UseAccessibleHeader="True">
						<Columns>
							<asp:BoundColumn DataField="ID" SortExpression="ID" HeaderText="ID" visible="false"></asp:BoundColumn>
							<asp:BoundColumn DataField="Periodo" SortExpression="Periodo" HeaderText="Periodo" visible="true"></asp:BoundColumn>
							<asp:BoundColumn DataField="DataPrenotazione" SortExpression="DataPrenotazione" HeaderText="Data prenotazione"></asp:BoundColumn>
							<asp:TemplateColumn HeaderText="Accertatore">
								<ItemTemplate>
									<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.matricola") & " " & DataBinder.Eval(Container, "DataItem.CognomeNome") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:BoundColumn DataField="Nome" SortExpression="Nome" HeaderText="Intervallo"></asp:BoundColumn>
							<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato"></asp:BoundColumn>
							<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data Approvazione"></asp:BoundColumn>
							<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
							<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
							<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
							<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
							<asp:ButtonColumn Text="Elimina" CommandName="Elimina"></asp:ButtonColumn>
						</Columns>
					</asp:DataGrid></p>
			</fieldset>
		</form>
	</body>
</HTML>
