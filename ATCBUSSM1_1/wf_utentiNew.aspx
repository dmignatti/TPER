<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_utentiNew.aspx.vb" Inherits="ATCBussm1.wf_utentiNew"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_utentiNew</title>
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
			<table class="Back" id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center">
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
						<asp:TextBox id="txtFake" runat="server" CssClass="Hidden"></asp:TextBox><asp:Label id="lblCerca" runat="server" AssociatedControlID="txtFiltro">Cerca:</asp:Label><asp:TextBox id="txtFiltro" runat="server"></asp:TextBox><asp:DropDownList id="ddlSearchType" runat="server">
							<asp:ListItem Value="0" Selected="True">Almeno una parola</asp:ListItem>
							<asp:ListItem Value="1">Tutte le parole</asp:ListItem>
						</asp:DropDownList><asp:Button id="btnCerca" runat="server" Text="Cerca" CssClass="bottone"></asp:Button>
					</td>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
			<br>
			<table id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG height="4" style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						valign="top">
						<h6>Utenti
							<asp:Label id="lblCount" runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvUtenti.Count &amp; ")" %>'>
							</asp:Label></h6>
						<hr noshade size="1">
						<asp:DataGrid id="dgUtenti" runat="server" DataSource="<%# dvUtenti %>" DataKeyField="ID" UseAccessibleHeader="True" AutoGenerateColumns="False" Width="100%" CssClass="grid" Visible="<%# dvUtenti.Count > 0 %>" AllowPaging="True" PagerStyle-Visible="<%# dvUtenti.Count > dgUtenti.PageSize %>" GridLines="None" >
							<Columns>
								<asp:TemplateColumn HeaderText="IDUser">
									<ItemTemplate>
										<asp:LinkButton id="lnkIdUser" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IDUser") %>' CommandName="Select">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Pwd" SortExpression="Pwd" ReadOnly="True" HeaderText="Pwd"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="EMail">
									<ItemTemplate>
										<asp:HyperLink id="lnkEmail" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EMail") %>' Target="_blank" NavigateUrl='<%# "mailto:" &amp; DataBinder.Eval(Container, "DataItem.EMail") %>'>
										</asp:HyperLink>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Abil.">
									<ItemTemplate>
										<asp:CheckBox id="chkAbilitato" runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Abilitato") %>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="DataUltimoAccesso" SortExpression="DataUltimoAccesso" ReadOnly="True"
									HeaderText="Data ult. acc."></asp:BoundColumn>
								<asp:BoundColumn DataField="OraUltimoAccesso" SortExpression="OraUltimoAccesso" ReadOnly="True" HeaderText="Ora ult. acc."></asp:BoundColumn>
								<asp:BoundColumn DataField="NrAccessi" SortExpression="NrAccessi" ReadOnly="True" HeaderText="Nr. acc."></asp:BoundColumn>
								<asp:BoundColumn DataField="DescrizioneTipoUtente" SortExpression="DescrizioneTipoUtente" ReadOnly="True"
									HeaderText="Tipo"></asp:BoundColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="bottone" Text="Elimina" CausesValidation="false"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
						<asp:Label id="lblNoUtenti" runat="server" Visible="<%# dvUtenti.Count <= 0 %>" CssClass="label">Non sono presenti utenti.</asp:Label>
						<hr noshade size="1">
						<asp:Button id="btnAddUser" runat="server" CssClass="Bottone" Text="Aggiungi un nuovo utente &raquo;"></asp:Button>
					</td>
				</tr>
				<TR>
					<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></TD>
				</TR>
			</table>
		</form>
	</body>
</HTML>
