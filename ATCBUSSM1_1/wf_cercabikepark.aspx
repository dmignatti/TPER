<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_cercabikepark.aspx.vb" Inherits="ATCBussm1.wf_cercabikepark" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_cercabikepark</title>
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
						<asp:textbox id="txtFake" runat="server" CssClass="Hidden"></asp:textbox><asp:validationsummary id="vsErrori" runat="server" cssclass="error" Width="100%" HeaderText="Attenzione!"></asp:validationsummary><asp:panel id="pnlRicercaSemplice" runat="server">
							<asp:Label id="lblCerca" runat="server" AssociatedControlID="txtFiltro">Cerca:</asp:Label>
							<asp:TextBox id="txtFiltro" runat="server"></asp:TextBox>
							<asp:DropDownList id="ddlSearchType" runat="server">
								<asp:ListItem Value="0" Selected="True">Almeno una parola</asp:ListItem>
								<asp:ListItem Value="1">Tutte le parole</asp:ListItem>
							</asp:DropDownList>
							<asp:Button id="btnCerca" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
							<asp:LinkButton id="lnkRicercaAvanzata" runat="server">Ricerca avanzata &raquo; &nbsp; &nbsp; &nbsp;</asp:LinkButton>
							<asp:LinkButton id="lnkAnnullaRicerca" runat="server">Annulla ricerca &raquo;</asp:LinkButton>
						</asp:panel><asp:panel id="pnlRicercaAvanzata" runat="server" Visible="False">
							<asp:Label id="lblMatricola" runat="server" Width="100px" AssociatedControlID="txtMatricola">Matricola agente:</asp:Label>
							<asp:TextBox id="txtMatricola" runat="server"></asp:TextBox>
							<asp:Label id="lblDataDa" runat="server" Width="100px" AssociatedControlID="txtDataDa">Data vendita da:</asp:Label>
							<asp:TextBox id="txtDataDa" runat="server" Width="90px"></asp:TextBox>
							<asp:Label id="lblDataA" runat="server" Width="100px" AssociatedControlID="txtDataA">Data vendita a:</asp:Label>
							<asp:TextBox id="txtDataA" runat="server" Width="90px"></asp:TextBox>
							<asp:CompareValidator id="cvDataA1" runat="server" Display="None" Operator="DataTypeCheck" Type="Date"
								ControlToValidate="txtDataA" ErrorMessage='Il campo "Data vendita a" deve contenere una data valida'></asp:CompareValidator>
							<asp:CompareValidator id="cvDataA" runat="server" Display="None" Operator="GreaterThanEqual" Type="Date"
								ControlToValidate="txtDataA" ErrorMessage='Il campo "Data vendita a" deve contenere una data maggiore o uguale a quella del campo "Vendita data da"'
								ControlToCompare="txtDataDa"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataDa" runat="server" Display="None" Operator="DataTypeCheck" Type="Date"
								ControlToValidate="txtDataDa" ErrorMessage='Il campo "Data vendita da" deve contenere una data valida'></asp:CompareValidator>
							<BR>
							<asp:Label id="lblCognome" runat="server" Width="100px" AssociatedControlID="txtCognome">Cognome:</asp:Label>
							<asp:TextBox id="txtCognome" runat="server"></asp:TextBox>
							<asp:Label id="lblNome" runat="server" Width="100px" AssociatedControlID="txtNome">Nome:</asp:Label>
							<asp:TextBox id="txtNome" runat="server"></asp:TextBox>
							<asp:Label id="lblDataNascita" runat="server" Width="100px" AssociatedControlID="txtDataNascita">Data di nascita:</asp:Label>
							<asp:TextBox id="txtDataNascita" runat="server" Width="90px"></asp:TextBox>
							<asp:CompareValidator id="cvDataNascita" runat="server" Display="None" Operator="DataTypeCheck" Type="Date"
								ControlToValidate="txtDataNascita" ErrorMessage='Il campo "Data di nascita" deve contenere una data valida.'></asp:CompareValidator>
							<BR>
							<asp:Label id="lblTessera" runat="server" Width="100px" AssociatedControlID="txtTessera">Tessera:</asp:Label>
							<asp:TextBox id="txtTessera" runat="server"></asp:TextBox>
							<asp:Label id="lblCauzione" runat="server" Width="100px" AssociatedControlID="txtCauzione">Cauzione:</asp:Label>
							<asp:TextBox id="TxtCauzione" runat="server"></asp:TextBox>
							<asp:RegularExpressionValidator id="RECauzione" runat="server" Display="None" ControlToValidate="TxtCauzione" ErrorMessage="Il campo Cauzione deve essere di tipo numerico"
								ValidationExpression="^[0-9]+[0-9]*$"></asp:RegularExpressionValidator>
							<asp:Label id="lblNote" runat="server" Width="110px" AssociatedControlID="chkNote">Utenti con le note:</asp:Label>
							<asp:CheckBox id="chkNote" runat="server" Width="30px" AutoPostBack="True"></asp:CheckBox>
							<asp:dropdownlist id=ddlTipoNota runat="server" Width="100%" DataValueField="IdTipoNota" DataTextField="Tipo" DataMember="BikePark_TipoNota" DataSource="<%# DsBiglietterie1 %>">
							</asp:dropdownlist>
							<asp:Label id="lblDataDaNote" runat="server" Width="100px" AssociatedControlID="txtDataDaNote">Data nota da:</asp:Label>
							<asp:TextBox id="txtDataDaNote" runat="server"></asp:TextBox>
							<asp:Label id="lblDataANote" runat="server" Width="100px" AssociatedControlID="txtDataANote">Data nota a:</asp:Label>
							<asp:TextBox id="txtDataANote" runat="server"></asp:TextBox>
							<asp:CompareValidator id="txtDataANote1" runat="server" Display="None" Operator="DataTypeCheck" Type="Date"
								ControlToValidate="txtDataANote" ErrorMessage='Il campo "Data note a" deve contenere una data valida'></asp:CompareValidator>
							<asp:CompareValidator id="cvDataANote" runat="server" Display="None" Operator="GreaterThanEqual" Type="Date"
								ControlToValidate="txtDataANote" ErrorMessage='Il campo "Data Note a" deve contenere una data maggiore o uguale a quella del campo "Data note da"'
								ControlToCompare="txtDataDa"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataDaNote" runat="server" Display="None" Operator="DataTypeCheck" Type="Date"
								ControlToValidate="txtDataDaNote" ErrorMessage='Il campo "Data note da" deve contenere una data valida'></asp:CompareValidator>
							<asp:Label id="lblAllegati" runat="server" Width="110px" AssociatedControlID="chkAllegati">Utenti con allegati:</asp:Label>
							<asp:CheckBox id="chkAllegati" runat="server" Width="30px"></asp:CheckBox>
							<BR>
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
							<asp:label id=lblCount runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvBikePark.Count &amp; ")" %>'>
							</asp:label>-
							<asp:button id="btnAdd2" runat="server" CssClass="bottone" Text="Nuova vendita tessera »"></asp:button></h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgBikePark runat="server" CssClass="grid" Width="100%" Visible="<%# dvBikePark.Count > 0 %>" DataSource="<%# dvBikePark %>" UseAccessibleHeader="True" GridLines="None" DataKeyField="ID" AutoGenerateColumns="False" AllowPaging="True" PagerStyle-Visible="<%# dvBikePark.Count > dgBikePark.PageSize %>">
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
								<asp:BoundColumn DataField="Tessera" SortExpression="Tessera" ReadOnly="True" HeaderText="Tessera"></asp:BoundColumn>
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
						</asp:datagrid><asp:label id=lblNoUtenti runat="server" CssClass="label" Visible="<%# dvBikePark.Count <= 0 %>">Nessun utente soddisfa i criteri di ricerca selezionati.</asp:label>
						<hr noShade SIZE="1">
						<asp:button id="btnAdd" runat="server" CssClass="bottone" Text="Nuova vendita tessera »"></asp:button></td>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
