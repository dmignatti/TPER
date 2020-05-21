<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gruppo.aspx.vb" Inherits="ATCBussm1.wf_gruppo"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gruppo</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission>
			<table id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG height="4" style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						valign="top">
						<h6>Gruppo</h6>
						<hr noshade size="1">
						<asp:ValidationSummary id="vsErrori" runat="server" HeaderText="Attenzione!" Width="100%"></asp:ValidationSummary><INPUT id="txtId" type="hidden" name="txtId" runat="server">
						<asp:Label id="lblDescrizione" runat="server" AssociatedControlID="txtDescrizione" Width="90px">Descrizione</asp:Label>
						<asp:TextBox id="txtDescrizione" runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Gruppi].DefaultView.[0].Descrizione") %>'>
						</asp:TextBox>
						<asp:RequiredFieldValidator id="rfvDescrizione" runat="server" ErrorMessage="Il campo Descrizione è obbligatorio"
							Display="None" ControlToValidate="txtDescrizione"></asp:RequiredFieldValidator><BR>
						<asp:Label id="lblAbilitato" runat="server" AssociatedControlID="chkAbilitato" Width="90px">Abilitato</asp:Label>
						<asp:CheckBox id="chkAbilitato" runat="server" Checked='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Gruppi].DefaultView.[0].Abilitato") %>'>
						</asp:CheckBox><BR>
						<HR width="100%" SIZE="1">
						<asp:LinkButton id="lnkBack" runat="server" CausesValidation="False">&laquo; Torna ai gruppi</asp:LinkButton>&nbsp;
						<asp:Button id="btnSave" runat="server" Text="Salva" CssClass="Bottone"></asp:Button>
						<asp:CustomValidator id="cvGruppo" runat="server" ErrorMessage="Esiste già un gruppo con la stessa descrizione"
							Display="None"></asp:CustomValidator>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
			<br>
			<table id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG height="4" style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						valign="top">
						<h6>Aggiungi utenti al gruppo</h6>
						<hr noshade size="1">
						<TABLE id="Table1" cellSpacing="0" cellPadding="2" width="100%">
							<TR>
								<TD vAlign="top" width="50%">
									<H6>Tutti gli utenti</H6>
									<asp:label id="lblSearch" runat="server" Width="50px" AssociatedControlID="txtSearch">cerca:</asp:label>
									<asp:TextBox id="txtSearch" runat="server"></asp:TextBox>
									<asp:Button id="btnSearch" runat="server" Text="Cerca" CssClass="bottone" CausesValidation="False"></asp:Button>
									<asp:TextBox id="txtFake" runat="server" CssClass="Hidden"></asp:TextBox><BR>
									<asp:datagrid id="dgUtenti" runat="server" Width="100%" DataSource="<%# dvUtenti %>" CssClass="Grid" PagerStyle-Visible="<%# dvUtenti.Count > dgUtenti.PageSize %>" Visible="<%# dvUtenti.Count > 0 %>" PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="ID">
										<Columns>
											<asp:TemplateColumn>
												<ItemTemplate>
													<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="IDUser" SortExpression="IDUser" HeaderText="IDUser"></asp:BoundColumn>
											<asp:BoundColumn DataField="Cognome" SortExpression="Cognome" HeaderText="Cognome"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nome" SortExpression="Nome" HeaderText="Nome"></asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<asp:Label id="lblNoProdotti" runat="server" Visible="<%# dvUtenti.Count <= 0 %>" CssClass="label">Non ci sono utenti da associare.</asp:Label></TD>
								<TD width="1%">
									<asp:button id="btnAdd" runat="server" Text=">>" CssClass="Bottone" Enabled="<%# dvUtenti.Count > 0 And txtId.Value.Length > 0 %>" CausesValidation="False">
									</asp:button><BR>
									<asp:button id="btnRemove" tabIndex="2" runat="server" Text="<<" CssClass="Bottone" Enabled='<%# DataBinder.Eval(DsUtenti1, "Tables[UtentiDelGruppo]").Rows.Count > 0  And txtId.Value.Length > 0 %>' CausesValidation="False">
									</asp:button><BR>
								</TD>
								<TD vAlign="top" width="50%">
									<H6>Utenti del gruppo</H6>
									<asp:TextBox id="TextBox1" runat="server" Width="0px"></asp:TextBox><BR>
									<asp:datagrid id="dgUtentiDelGruppo" runat="server" Width="100%" DataMember="UtentiDelGruppo" DataSource="<%# DsUtenti1 %>" CssClass="Grid" PagerStyle-Visible='<%# DataBinder.Eval(dsUtenti1, "Tables[UtentiDelGruppo]").Rows.Count > dgUtentiDelGruppo.PageSize %>' Visible='<%# DataBinder.Eval(DsUtenti1, "Tables[UtentiDelGruppo]").Rows.Count > 0 %>' PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="ID">
										<Columns>
											<asp:TemplateColumn>
												<ItemTemplate>
													<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="IDUser" SortExpression="IDUser" HeaderText="IDUser"></asp:BoundColumn>
											<asp:BoundColumn DataField="Cognome" SortExpression="Cognome" HeaderText="Cognome"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nome" SortExpression="Nome" HeaderText="Nome"></asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<asp:Label id="lblNoCarichi" runat="server" Visible='<%# DataBinder.Eval(DsUtenti1, "Tables[UtentiDelGruppo]").Rows.Count <= 0 %>' CssClass="label">Non sono presenti utenti in questo gruppo.</asp:Label></TD>
							</TR>
						</TABLE>
						<hr size="1" noshade>
						<asp:LinkButton id="LinkButton1" runat="server" CausesValidation="False">&laquo; Torna ai gruppi</asp:LinkButton>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
