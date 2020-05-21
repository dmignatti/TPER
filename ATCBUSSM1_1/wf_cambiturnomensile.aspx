<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_cambiturnomensile.aspx.vb" Inherits="ATCBussm1.wf_cambiturnomensile"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_cambiturnomensile</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>
							Scambi turno mensile <span class="label">(Sono visibili solamente gli scambi turno 
								ancora da effettuare)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblCambiTurno runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsCambiTurnoMensile1, "Tables[RichiesteCambiTurnoMensile]").Rows.Count <= 0 %>'>Non ci sono richieste di scambio turno.</asp:label><asp:button id="btnNuovaRichiesta" runat="server" CssClass="bottone" Text="Nuovo scambio turno"></asp:button><asp:customvalidator id="cvEccezioni" ErrorMessage="Superato numero scambi mensili nell'anno" Display="None"
							Runat="server"></asp:customvalidator><asp:customvalidator id="cvMensileAperto" runat="server" ErrorMessage="Per ora non è possibile richiedere scambi turno mensili perché il mensile provvisorio è chiuso."
							Display="None"></asp:customvalidator><asp:customvalidator id="cvCheckTurnoMensile" runat="server" ErrorMessage="Non si ha un turno associato in questo mese."
							Display="None"></asp:customvalidator><asp:customvalidator id="cvCheckCambiTurno" runat="server" ErrorMessage="Non è possibile richiedere più di uno scambio turno mensile al mese."
							Display="None"></asp:customvalidator><asp:datagrid id=dgCambiTurnoMensile runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsCambiTurnoMensile1, "Tables[RichiesteCambiTurnoMensile]").Rows.Count  > 0 %>' GridLines="None" AutoGenerateColumns="False" DataKeyField="IdRichiesta" DataMember="RichiesteCambiTurnoMensile" DataSource="<%# DsCambiTurnoMensile1 %>" UseAccessibleHeader="True">
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="LinkButton1" runat="server" Text="Modifica" CausesValidation="false" CommandName="Edit"></asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="LinkButton3" runat="server" Text="Ok" CausesValidation="False" CommandName="Update">Ok</asp:LinkButton>&nbsp;
										<asp:LinkButton id="LinkButton2" runat="server" Text="Annulla" CausesValidation="false" CommandName="Cancel"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" Text="Elimina" CausesValidation="false" CommandName="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False" HeaderText="IdAccertatoreRichiedente">
									<ItemTemplate>
										<asp:Label id="lblIdAccertatoreRichiedente" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IdAccertatoreRichiedente") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" ReadOnly="True" HeaderText="Scambia il turno"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdAccertatoreDestinatario" SortExpression="IdAccertatoreDestinatario"
									ReadOnly="True" HeaderText="IdAccertatoreDestinatario"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Con">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Destinatario") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id=ddlAccertatoreDestinatario runat="server" DataMember="Accertatori" DataSource="<%# DsCambiTurnoMensile1 %>" DataValueField="Matricola" DataTextField="Accertatore">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" ReadOnly="True"
									HeaderText="Con il turno"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="MatricolaAccertatoreDestinatario" SortExpression="MatricolaAccertatoreDestinatario"
									ReadOnly="True" HeaderText="MatricolaAccertatoreDestinatario"></asp:BoundColumn>
								<asp:BoundColumn DataField="data" SortExpression="data" ReadOnly="True" HeaderText="Per il mese di"
									DataFormatString="{0:Y}"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Stato della Richiesta">
									<ItemTemplate>
										<asp:Label id="lblStatoRichiesta" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoRichiesta") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoApprovazione") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<br>
			<table id="Table02" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Riepilogo scambi turno a mensile&nbsp;da accettare<br>
							<span class="label">(Sono visibili solamente gli scambi turno da accettare non 
								scaduti e non ancora approvati dagli amministratori)</span></h6>
						<hr SIZE="1" noShade>
						<asp:label id=lblCambiTurnoMensileDaAccettare runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsCambiTurnoDaAccettare1, "Tables[RichiesteCambiTurnoMensile]").Rows.Count <= 0 %>'>Non ci sono scambi turno da accettare.</asp:label><asp:datagrid id=dgCambiTurnoMensileDaAccettare runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsCambiTurnoDaAccettare1, "Tables[RichiesteCambiTurnoMensile]").Rows.Count > 0 %>' GridLines="None" AutoGenerateColumns="False" DataKeyField="IdRichiesta" DataMember="RichiesteCambiTurnoMensile" DataSource="<%# DsCambiTurnoDaAccettare1 %>" UseAccessibleHeader="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="IdAccertatoreRichiedente" SortExpression="IdAccertatoreRichiedente"
									HeaderText="IdAccertatoreRichiedente"></asp:BoundColumn>
								<asp:BoundColumn DataField="IDUser" SortExpression="IDUser" ReadOnly="True" HeaderText="Richiedente"></asp:BoundColumn>
								<asp:BoundColumn DataField="data" SortExpression="data" ReadOnly="True" HeaderText="Nel mese di"
									DataFormatString="{0:Y}"></asp:BoundColumn>
								<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" HeaderText="Scambia il turno"></asp:BoundColumn>
								<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" HeaderText="Con il turno"></asp:BoundColumn>
								<asp:BoundColumn DataField="EtichettaStatoRichiesta" SortExpression="EtichettaStatoRichiesta" HeaderText="Stato Richiesta"></asp:BoundColumn>
								<asp:ButtonColumn Text="Accetta" CommandName="Accetta"></asp:ButtonColumn>
								<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<asp:customvalidator id="cvOnModifica" runat="server" ErrorMessage="Non è possibile modificare questa richiesta perché non sei tu il richiedente oppure perché è stata accettata o rifiutata."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvOnDelete" runat="server" ErrorMessage="Non è possibile eliminare questa richiesta perché non sei tu il richiedente oppure perché è stata approvata o respinta."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvTipoUtente" runat="server" ErrorMessage="Solamente gli accertatori possono richiedere congedi e scambi turno."
				Display="None"></asp:customvalidator></form>
	</body>
</HTML>
