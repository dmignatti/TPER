<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_utente.aspx.vb" Inherits="ATCBussm1.wf_utente"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_utente</title>
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
			<table id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Utente</h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" HeaderText="Atttenzione!" Width="100%"></asp:validationsummary><INPUT id="txtId" type="hidden" name="txtId" runat="server">
						<asp:label id="lblIdUser" runat="server" Width="130px" AssociatedControlID="txtIdUser">IdUser</asp:label><asp:textbox id=txtIdUser runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].IDUser") %>' MaxLength="30">
						</asp:textbox><asp:requiredfieldvalidator id="rfvIdUSer" runat="server" ControlToValidate="txtIdUser" Display="None" ErrorMessage="Il campo IdUser è obbligatorio"></asp:requiredfieldvalidator><BR>
						<asp:label id="lblPassword" runat="server" Width="130px" AssociatedControlID="txtPassword">Password</asp:label><asp:textbox id=txtPassword runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].Pwd") %>' MaxLength="10">
						</asp:textbox><asp:requiredfieldvalidator id="rfvPassword" runat="server" ControlToValidate="txtPassword" Display="None" ErrorMessage="Il campo Password è obbligatorio"></asp:requiredfieldvalidator><BR>
						<asp:label id="lblCognome" runat="server" Width="130px" AssociatedControlID="txtCognome">Cognome</asp:label><asp:textbox id=txtCognome runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].Cognome") %>'>
						</asp:textbox><BR>
						<asp:label id="lblNome" runat="server" Width="130px" AssociatedControlID="txtNome">Nome</asp:label><asp:textbox id=txtNome runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].Nome") %>'>
						</asp:textbox><BR>
						<asp:label id="lblEmail" runat="server" Width="130px" AssociatedControlID="txtEmail">Email</asp:label><asp:textbox id=txtEmail runat="server" Text='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].EMail") %>'>
						</asp:textbox><asp:regularexpressionvalidator id="revEmail" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="L'indirizzo Email non è valido"
							ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator><BR>
						<asp:label id="lblTipoUtente" runat="server" Width="130px" AssociatedControlID="ddlTipoUtente">Tipo utente</asp:label><asp:dropdownlist id=ddlTipoUtente runat="server" Width="155px" SelectedValue='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].TipoUtente") %>' DataValueField="ID" DataTextField="Descrizione" DataMember="ATC_TipoUtente" DataSource="<%# DsUtenti1 %>">
						</asp:dropdownlist><BR>
						<asp:label id="lblAbilitato" runat="server" Width="130px" AssociatedControlID="chkAbilitato">Abilitato</asp:label>
						<asp:checkbox id=chkAbilitato runat="server" Checked='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].Abilitato") %>'>
						</asp:checkbox>
						<BR>
						<asp:Label id="lblPatente" Runat="server" Width="130px" AssociatedControlID="chkPatente">Patente</asp:Label>
						<asp:CheckBox ID="chkPatente" Runat="server" Checked='<%# DataBinder.Eval(DsUtenti1, "Tables[ATC_Utenti].DefaultView.[0].Flag_Patente") %>'>
						</asp:CheckBox>
						<br>
						<HR width="100%" SIZE="1">
						<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="False">&laquo; Torna agli utenti</asp:LinkButton>&nbsp;
						<asp:button id="btnSave" runat="server" Text="Salva" CssClass="bottone"></asp:button>
						<asp:CustomValidator id="cvIdUser" runat="server" ErrorMessage="Esiste già un utente con lo stesso IDUser"
							Display="None"></asp:CustomValidator></td>
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
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Aggiungi o rimuovi gruppi di appartenenza</h6>
						<hr noShade SIZE="1">
						<TABLE id="Table1" cellSpacing="0" cellPadding="2" width="100%">
							<TR>
								<TD vAlign="top" width="50%">
									<H6>Tutti i gruppi</H6>
									<asp:label id="Label1" runat="server" Width="50px" AssociatedControlID="txtSearch">cerca:</asp:label>
									<asp:TextBox id="txtSearch" runat="server"></asp:TextBox>
									<asp:Button id="btnSearch" runat="server" Text="Cerca" CssClass="bottone" CausesValidation="False"></asp:Button>
									<asp:TextBox id="txtFake" runat="server" CssClass="Hidden"></asp:TextBox><BR>
									<asp:datagrid id="dgGruppi" runat="server" Width="100%" DataSource="<%# dvGruppi %>" CssClass="Grid" PagerStyle-Visible="<%# dvGruppi.Count > dgGruppi.PageSize %>" Visible="<%# dvGruppi.Count > 0 %>" PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="ID">
										<Columns>
											<asp:TemplateColumn>
												<ItemTemplate>
													<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="Descrizione" SortExpression="Descrizione" HeaderText="Descrizione"></asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<asp:Label id="lblNoProdotti" runat="server" Visible="<%# dvGruppi.Count <= 0 %>" CssClass="label">Non ci sono gruppi da associare.</asp:Label></TD>
								<TD width="1%">
									<asp:button id="btnAdd" runat="server" Text=">>" CssClass="Bottone" Enabled="<%# dvGruppi.Count > 0 And txtId.Value.Length > 0 %>" CausesValidation="False">
									</asp:button><BR>
									<asp:button id="btnRemove" tabIndex="2" runat="server" Text="<<" CssClass="Bottone" Enabled='<%# DataBinder.Eval(DsUtenti1, "Tables[GruppiDiAppartenenza]").Rows.Count > 0  And txtId.Value.Length > 0 %>' CausesValidation="False">
									</asp:button><BR>
								</TD>
								<TD vAlign="top" width="50%">
									<H6>Gruppi di appartenenza</H6>
									<asp:TextBox id="TextBox1" runat="server" Width="0px"></asp:TextBox><BR>
									<asp:datagrid id="dgGruppoDiAppartenenza" runat="server" Width="100%" DataMember="GruppiDiAppartenenza" DataSource="<%# DsUtenti1 %>" CssClass="Grid" PagerStyle-Visible='<%# DataBinder.Eval(dsUtenti1, "Tables[GruppiDiAppartenenza]").Rows.Count > dgGruppoDiAppartenenza.PageSize %>' Visible='<%# DataBinder.Eval(DsUtenti1, "Tables[GruppiDiAppartenenza]").Rows.Count > 0 %>' PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="ID">
										<Columns>
											<asp:TemplateColumn>
												<ItemTemplate>
													<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="Descrizione" SortExpression="Descrizione" HeaderText="Descrizione"></asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<asp:Label id="lblNoCarichi" runat="server" Visible='<%# DataBinder.Eval(DsUtenti1, "Tables[GruppiDiAppartenenza]").Rows.Count <= 0 %>' CssClass="label">L'utente non appartiene ad alcun gruppo.</asp:Label></TD>
							</TR>
						</TABLE>
						<hr size="1" noshade>
						<asp:LinkButton id="LinkButton1" runat="server" CausesValidation="False">&laquo; Torna agli utenti</asp:LinkButton></td>
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
