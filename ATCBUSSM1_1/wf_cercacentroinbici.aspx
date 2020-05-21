<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_cercacentroinbici.aspx.vb" Inherits="ATCBussm1.wf_cercacentroinbici"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_cercacentroinbici</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission>
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Ricerca</h6>
						<hr noShade SIZE="1">
						<asp:textbox id="txtFake" runat="server" CssClass="Hidden"></asp:textbox><asp:validationsummary id="vsErrori" runat="server" HeaderText="Attenzione!" Width="100%" cssclass="error"></asp:validationsummary>
						<asp:panel id="pnlRicercaSemplice" runat="server">
							<asp:Label id="lblCerca" runat="server" AssociatedControlID="txtFiltro">Cerca:</asp:Label>
							<asp:TextBox id="txtFiltro" runat="server"></asp:TextBox>
							<asp:DropDownList id="ddlSearchType" runat="server">
								<asp:ListItem Value="0" Selected="True">Almeno una parola</asp:ListItem>
								<asp:ListItem Value="1">Tutte le parole</asp:ListItem>
							</asp:DropDownList>
							<asp:Button id="btnCerca" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
							<asp:LinkButton id="lnkRicercaAvanzata" runat="server">Ricerca avanzata &raquo; &nbsp; &nbsp; &nbsp;</asp:LinkButton>
							<asp:LinkButton id="lnkAnnullaRicerca" runat="server">Annulla ricerca &raquo;</asp:LinkButton>
						</asp:panel>
						<asp:panel id="pnlRicercaAvanzata" runat="server" Visible="False">
							<asp:Label id="lblMatricola" runat="server" Width="100px" AssociatedControlID="txtMatricola">Matricola agente:</asp:Label>
							<asp:TextBox id="txtMatricola" runat="server"></asp:TextBox>
							<asp:Label id="lblDataDa" runat="server" Width="100px" AssociatedControlID="txtDataDa">Data vendita da:</asp:Label>
							<asp:TextBox id="txtDataDa" runat="server" Width="90px"></asp:TextBox>
							<asp:Label id="lblDataA" runat="server" Width="100px" AssociatedControlID="txtDataA">Data vendita a:</asp:Label>
							<asp:TextBox id="txtDataA" runat="server" Width="90px"></asp:TextBox>
							<asp:CompareValidator id="cvDataA1" runat="server" ErrorMessage='Il campo "Data vendita a" deve contenere una data valida'
								ControlToValidate="txtDataA" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataA" runat="server" ErrorMessage='Il campo "Data vendita a" deve contenere una data maggiore o uguale a quella del campo "Vendita data da"'
								ControlToValidate="txtDataA" Type="Date" Operator="GreaterThanEqual" Display="None" ControlToCompare="txtDataDa"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataDa" runat="server" ErrorMessage='Il campo "Data vendita da" deve contenere una data valida'
								ControlToValidate="txtDataDa" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<BR>
							<asp:Label id="lblCognome" runat="server" Width="100px" AssociatedControlID="txtCognome">Cognome:</asp:Label>
							<asp:TextBox id="txtCognome" runat="server"></asp:TextBox>
							<asp:Label id="lblNome" runat="server" Width="100px" AssociatedControlID="txtNome">Nome:</asp:Label>
							<asp:TextBox id="txtNome" runat="server"></asp:TextBox>
							<asp:Label id="lblDataNascita" runat="server" Width="100px" AssociatedControlID="txtDataNascita">Data di nascita:</asp:Label>
							<asp:TextBox id="txtDataNascita" runat="server" Width="90px"></asp:TextBox>
							<asp:CompareValidator id="cvDataNascita" runat="server" ErrorMessage='Il campo "Data di nascita" deve contenere una data valida.'
								ControlToValidate="txtDataNascita" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<BR>
							<asp:Label id="lblChiave" runat="server" Width="100px" AssociatedControlID="txtChiave">Chiave:</asp:Label>
							<asp:TextBox id="txtChiave" runat="server"></asp:TextBox>
							<asp:Label id="lblCauzione" runat="server" Width="100px" AssociatedControlID="txtCauzione">Cauzione:</asp:Label>
							<asp:TextBox id="TxtCauzione" runat="server"></asp:TextBox>
							<asp:RegularExpressionValidator id="RECauzione" runat="server" ErrorMessage="Il campo Cauzione deve essere di tipo numerico"
								ControlToValidate="TxtCauzione" Display="None" ValidationExpression="^[0-9]+[0-9]*$"></asp:RegularExpressionValidator>
							<asp:Label id="lblNote" runat="server" Width="110px" AssociatedControlID="chkNote">Utenti con le note:</asp:Label>
							<asp:CheckBox id="chkNote" runat="server" Width="30px" AutoPostBack="True"></asp:CheckBox>
							<asp:dropdownlist id=ddlTipoNota runat="server" Width="100%" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_TipoNota" DataTextField="Tipo" DataValueField="IdTipoNota">
							</asp:dropdownlist>
							<asp:Label id="lblDataDaNote" runat="server" Width="100px" AssociatedControlID="txtDataDaNote">Data nota da:</asp:Label>
							<asp:TextBox id="txtDataDaNote" runat="server"></asp:TextBox>
							<asp:Label id="lblDataANote" runat="server" Width="100px" AssociatedControlID="txtDataANote">Data nota a:</asp:Label>
							<asp:TextBox id="txtDataANote" runat="server"></asp:TextBox>
							<asp:CompareValidator id="txtDataANote1" runat="server" ErrorMessage='Il campo "Data note a" deve contenere una data valida'
								ControlToValidate="txtDataANote" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataANote" runat="server" ErrorMessage='Il campo "Data Note a" deve contenere una data maggiore o uguale a quella del campo "Data note da"'
								ControlToValidate="txtDataANote" Type="Date" Operator="GreaterThanEqual" Display="None" ControlToCompare="txtDataDa"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataDaNote" runat="server" ErrorMessage='Il campo "Data note da" deve contenere una data valida'
								ControlToValidate="txtDataDaNote" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<asp:Label id="lblAllegati" runat="server" Width="110px" AssociatedControlID="chkAllegati">Utenti con allegati:</asp:Label>
							<asp:CheckBox id="chkAllegati" runat="server" Width="30px"></asp:CheckBox>
							<BR>
							<asp:Label id="Label1" runat="server" Width="100px" AssociatedControlID="chkNote">Tipo utente:</asp:Label>
							<asp:DropDownList id="DDlTipoUtente" runat="server">
								<asp:ListItem Value=" "></asp:ListItem>
								<asp:ListItem Value="Studente/personale universitario">Studente/personale universitario</asp:ListItem>
								<asp:ListItem Value="Cittadino">Cittadino</asp:ListItem>
								<asp:ListItem Value="Dipendente comune di Bologna">Dipendente comune di Bologna</asp:ListItem>
								<asp:ListItem Value="Pendolare">Pendolare</asp:ListItem>
							</asp:DropDownList>
							<HR width="100%" SIZE="1">
							<asp:LinkButton id="lnkRicercaSemplice" runat="server">&laquo; Torna alla ricerca semplice</asp:LinkButton>
							<asp:Button id="btnRicercaAvanzata" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
						</asp:panel></td>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
			<br>
			<table class="Back" id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Risultati
							<asp:label id=lblCount runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvCentroInBici.Count &amp; ")" %>'>
							</asp:label>-
							<asp:button id="btnAdd2" runat="server" CssClass="bottone" Text="Nuova vendita chiave »"></asp:button></h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgCentroInBici runat="server" CssClass="grid" Width="100%" Visible="<%# dvCentroInBici.Count > 0 %>" DataSource="<%# dvCentroInBici %>" PagerStyle-Visible="<%# dvCentroInBici.Count > dgCentroInBici.PageSize %>" AllowPaging="True" AutoGenerateColumns="False" DataKeyField="ID" GridLines="None" UseAccessibleHeader="True">
							<Columns>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<HeaderTemplate>
										<IMG style="MARGIN: 0px" alt="" src="images/note.gif">
									</HeaderTemplate>
									<ItemTemplate>
										<asp:ImageButton id="btnNote" runat="server" Visible='<%# DataBinder.Eval(Container, "DataItem.NumeroNote") > 0 %>' ImageUrl="images/note.gif" CommandName="Note">
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<HeaderTemplate>
										<IMG style="MARGIN: 0px" alt="" src="images/attachmentw.gif">
									</HeaderTemplate>
									<ItemTemplate>
										<asp:ImageButton id="ImageButton1" runat="server" Visible='<%# DataBinder.Eval(Container, "DataItem.NumeroAllegati") > 0 %>' ImageUrl="images/attachment.gif" CommandName="Allegati">
										</asp:ImageButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Cognome">
									<ItemTemplate>
										<asp:LinkButton id="lnkCognome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.COGNOME") %>' CommandName="Select">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="NOME" SortExpression="NOME" ReadOnly="True" HeaderText="Nome"></asp:BoundColumn>
								<asp:BoundColumn DataField="DATA_NASCITA" SortExpression="DATA_NASCITA" ReadOnly="True" HeaderText="Data di nascita"
									DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:BoundColumn DataField="CHIAVE" SortExpression="CHIAVE" ReadOnly="True" HeaderText="Chiave"></asp:BoundColumn>
								<asp:BoundColumn DataField="CAUZIONE" SortExpression="CAUZIONE" ReadOnly="True" HeaderText="Cauzione"></asp:BoundColumn>
								<asp:BoundColumn DataField="MATRICOLA" SortExpression="MATRICOLA" HeaderText="Matricola"></asp:BoundColumn>
								<asp:BoundColumn DataField="DATAINSERIMENTO" SortExpression="DATAINSERIMENTO" HeaderText="Data vendita"
									DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnAddNote" runat="server" CssClass="bottone" Text="Agg. nota &raquo;" CausesValidation="false"
											CommandName="NuovaNota"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="bottone" Text="Elimina" CausesValidation="false"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:label id=lblNoUtenti runat="server" CssClass="label" Visible="<%# dvCentroInBici.Count <= 0 %>">Nessun utente soddisfa i criteri di ricerca selezionati.</asp:label>
						<hr noShade SIZE="1">
						<asp:button id="btnAdd" runat="server" CssClass="bottone" Text="Nuova vendita chiave »"></asp:button></td>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
