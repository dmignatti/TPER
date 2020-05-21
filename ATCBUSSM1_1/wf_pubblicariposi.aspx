<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_pubblicariposi.aspx.vb" Inherits="ATCBussm1.wf_pubblicariposi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Pubblica riposi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
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
						<h6>Elenco operatori mobilità con riposi<br>
							<span class="label">(Filtrati per anno, ordinati per cognome, nome)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" HeaderText="Attenzione!" Width="100%" CssClass="Error"></asp:validationsummary>
						<P><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRiposiPubblica1, "Tables[RiposiMatricolaAnno]").Rows.Count <= 0 %>'>Non ci sono riposi da pubblicare.</asp:label><br>
							<asp:label id="Label6" class="label" runat="server">Anno: </asp:label><asp:textbox style="Z-INDEX: 0" id="txtAnno" runat="server"></asp:textbox>&nbsp;<asp:button id="btnCerca" runat="server" CssClass="bottone" CausesValidation="False" Text="Cerca"></asp:button><br>
							<br>
							<asp:button id="BtnAggiorna" runat="server" CssClass="bottone" CausesValidation="False" Text="Ricarica Tutti i Riposi da Teorico AS400"></asp:button>&nbsp;<asp:button id="BtnNuoviRiposi" runat="server" CssClass="bottone" CausesValidation="False" Text="Carica Riposi Nuovi Operatori da Teorico AS400"></asp:button>&nbsp;<asp:button id="btnPubblicaTutti" runat="server" CssClass="bottone" CausesValidation="False"
								Text="Pubblica tutti"></asp:button>&nbsp;<asp:button id="btnRitiraTutti" runat="server" CssClass="bottone" CausesValidation="False" Text="Ritira tutti"></asp:button><asp:datagrid id=dgRiposiPubblica runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsRiposiPubblica1, "Tables[RiposiMatricolaAnno]").Rows.Count > 0 %>' DataMember="RiposiMatricolaAnno" DataSource="<%# DsRiposiPubblica1 %>" UseAccessibleHeader="True" DataKeyField="TTMATR" AutoGenerateColumns="False" GridLines="None">
								<Columns>
									<asp:ButtonColumn Text="Ricarica da AS400" ButtonType= "LinkButton" CommandName="RicaricaAS400"></asp:ButtonColumn>
									<asp:EditCommandColumn ButtonType="LinkButton" EditText="Pubblica/ritira" >
										<ItemStyle Wrap="False"></ItemStyle>
									</asp:EditCommandColumn>
									<asp:BoundColumn DataField="TTAAGG" SortExpression="TTAAGG" ReadOnly="True" HeaderText="Anno"></asp:BoundColumn>
									<asp:BoundColumn DataField="TTMATR" SortExpression="TTMATR" ReadOnly="True" HeaderText="Matricola"></asp:BoundColumn>
									<asp:BoundColumn DataField="Cognome" SortExpression="Cognome" ReadOnly="True" HeaderText="Cognome"></asp:BoundColumn>
									<asp:BoundColumn DataField="Nome" SortExpression="Nome" ReadOnly="True" HeaderText="Nome"></asp:BoundColumn>
									<asp:BoundColumn DataField="Pubblica" SortExpression="Pubblica" Visible="True" ReadOnly="True" HeaderText="Pubblicato"></asp:BoundColumn>
								</Columns>
							</asp:datagrid></P>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
