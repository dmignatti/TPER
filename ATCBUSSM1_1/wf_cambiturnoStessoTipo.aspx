<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_cambiturnoStessoTipo.aspx.vb" Inherits="ATCBussm1.wf_cambiturnoStessoTipo"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_cambiturnoStessoTipo</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			&nbsp;
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission>
			<table id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6><FONT color="darkblue">Cambi turno&nbsp;</FONT> <span class="label">(Sono visibili 
								solamente i cambi turno ancora da effettuare)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="error" Width="100%" HeaderText="Attenzione!"></asp:validationsummary><asp:label id=lblCambiTurno runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsCambiTurnoStessoTipo, "Tables[RichiesteCambiTurnoStessoTipo]").Rows.Count <= 0 %>'>Non ci sono cambi turno.</asp:label><asp:button id="btnNuovaRichiesta" runat="server" CssClass="bottone" Text="Nuovo cambio turno"></asp:button>
						<asp:panel id="pnlData" runat="server" Visible="False">
							<HR SIZE="1" noShade>
							<H6 style="COLOR: blue">Quando?</H6>
							<HR SIZE="1" noShade>
							<asp:Calendar id="ddlDataCal" runat="server" Width="112px" CssClass="grid" Height="114px"></asp:Calendar>
							<asp:CustomValidator id="cvData" runat="server" ErrorMessage="La richiesta di cambio turno deve essere avanzata entro le 18:00 del giorno antecedente l�uscita del servizio 48 ore"
								Display="None" OnServerValidate="cvData_ServerValidate"></asp:CustomValidator>
							<asp:Button id="btnOk" runat="server" CssClass="bottone" Text="Ok"></asp:Button>
							<asp:Button id="btnAnnulla" runat="server" CssClass="bottone" Text="Annulla" CausesValidation="False"></asp:Button>
							<asp:CustomValidator id="cvTurnoVuoto" runat="server" ErrorMessage="Non ci sono turni per questa data."
								Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvEccezioni" runat="server" ErrorMessage="Superato numero cambi giornalieri nel mese"
								Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvTurnoOkGiornaliero" runat="server" ErrorMessage="Non hai un turno associato in questa data."
								Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvSoloUnCambio" runat="server" ErrorMessage="E' possibile richiedere solamente due cambi turno al giorno."
								Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvGiornalieroAbilitato" runat="server" ErrorMessage="Giornaliero non rilasciato per questa data."
								Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvbloccoCambio" runat="server" ErrorMessage="Funzionalit� inibita." Display="None"></asp:CustomValidator>
							<asp:CustomValidator id="cvCheckPatente" runat="server" ErrorMessage="Turno richiede possesso patente"
								Display="None"></asp:CustomValidator>
							<HR SIZE="1" noShade>
						</asp:panel><asp:datagrid id=dgCambiTurnoGiornalieriStessoTipo runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsCambiTurnoStessoTipo, "Tables[RichiesteCambiTurnoStessoTipo]").Rows.Count > 0 %>' GridLines="None" AutoGenerateColumns="False" DataKeyField="IdRichiesta" DataMember="RichiesteCambiTurnoStessoTipo" DataSource="<%# DsCambiTurnoStessoTipo %>" UseAccessibleHeader="True">
							<Columns>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="BtnUpdate" runat="server" CssClass="bottone" Text="Modifica" CausesValidation="false"
											CommandName="Edit"></asp:Button>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Button id="Button5" runat="server" CssClass="bottone" Text="Ok" CommandName="Update"></asp:Button>&nbsp;
										<asp:Button id="Button4" runat="server" CssClass="bottone" Text="Annulla" CausesValidation="false"
											CommandName="Cancel"></asp:Button>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="bottone" Text="Elimina" CausesValidation="false"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False" HeaderText="IdAccertatoreRichiedente">
									<ItemTemplate>
										<asp:Label id=lblIdAccertatoreRichiedente runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IdAccertatoreRichiedente") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" ReadOnly="True" HeaderText="Cambia il turno"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdAccertatoreDestinatario" SortExpression="IdAccertatoreDestinatario"
									ReadOnly="True" HeaderText="IdAccertatoreDestinatario"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Con">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TurnoDestinatario") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id=ddlDestinatarioCambioTurno runat="server" DataSource="<%#DsListaTurniStessoTipo1 %>" DataMember="dbo_SP_ListaCambiGiornalieriStessoTipo" DataValueField="TITIPL" DataTextField="DESCR">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="TurnoDestinatario" SortExpression="TurnoDestinatario"
									ReadOnly="True" HeaderText="TurnoDestinatario"></asp:BoundColumn>
								<asp:BoundColumn DataField="data" SortExpression="data" ReadOnly="True" HeaderText="In Data" DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False" HeaderText="Stato della Richiesta">
									<ItemTemplate>
										<asp:Label id="lblStatoRichiesta" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EtichettaStatoRichiesta") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn Visible="False" HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoApprovazione") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid></td>
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
						<h6>Riepilogo cambi turno da accettare<br>
							<span class="label">(Sono visibili solamente i cambi turno da accettare non scaduti 
								e non ancora approvati dagli amministratori)</span></h6>
						<hr SIZE="1" noShade>
						<asp:label id=lblCambiTurnoDaAccettare runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsCambiTurnoDaAccettare1, "Tables[RichiesteCambiTurno]").Rows.Count <= 0 %>'>Non ci sono cambi turno da accettare.</asp:label><asp:datagrid id=dgCambiTurnoDaAccettare runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsCambiTurnoDaAccettare1, "Tables[RichiesteCambiTurno]").Rows.Count > 0 %>' GridLines="None" AutoGenerateColumns="False" DataKeyField="IdRichiesta" DataMember="RichiesteCambiTurno" DataSource="<%# DsCambiTurnoDaAccettare1 %>" UseAccessibleHeader="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="IdAccertatoreRichiedente" SortExpression="IdAccertatoreRichiedente"
									HeaderText="IdAccertatoreRichiedente"></asp:BoundColumn>
								<asp:BoundColumn DataField="IDUser" SortExpression="IDUser" ReadOnly="True" HeaderText="Richiedente"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Nel giorno">
									<ItemTemplate>
										<asp:Label ID="lbldata" Runat ="server" Text='<%# DataBinder.Eval(Container, "DataItem.data", "{0:d}") %>'>
										</asp:Label>
										<asp:CustomValidator id="cvdatadaaccettare" runat="server" ErrorMessage="Le richieste di scambio consensuale di turno sono consentite fino alle ore 18:00 del giorno precedente a quello interessato dalla richiesta."
											Display="None" OnServerValidate="cvdatadaaccettare_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvblocco" runat="server" ErrorMessage="Funzionalit� inibita." Display="None"
											OnServerValidate="cvblocco_OnServerValidate"></asp:CustomValidator>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" HeaderText="Cambia il turno"></asp:BoundColumn>
								<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" HeaderText="Con il turno"></asp:BoundColumn>
								<asp:BoundColumn DataField="EtichettaStatoRichiesta" SortExpression="EtichettaStatoRichiesta" HeaderText="Stato Richiesta"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="Button1" runat="server" Text="Accetta" CssClass="bottone" CausesValidation="false"
											CommandName="Accetta"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="Button2" runat="server" Text="Rifiuta" CssClass="bottone" CausesValidation="false"
											CommandName="Rifiuta"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid></td>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<asp:customvalidator id="cvTipoUtente" runat="server" ErrorMessage="Solamente gli accertatori possono richiedere congedi e cambi turno."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvOnModifica" runat="server" ErrorMessage="Non � possibile modificare questa richiesta perch� non sei tu il richiedente."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvOnDelete" runat="server" ErrorMessage="Non � possibile eliminare questa richiesta perch� non sei tu il richiedente oppure perch� � stata approvata o respinta."
				Display="None"></asp:customvalidator></form>
	</body>
</HTML>
