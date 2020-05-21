<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_permessiNew.aspx.vb" Inherits="ATCBussm1.wf_permessiNew"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_permessiNew</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
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
						<asp:TextBox id="txtFake" runat="server" CssClass="Hidden"></asp:TextBox><asp:Label id="lblCerca" runat="server" AssociatedControlID="txtFiltro" CssClass="label">Cerca:</asp:Label><asp:TextBox id="txtFiltro" runat="server"></asp:TextBox><asp:DropDownList id="ddlSearchType" runat="server">
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
						<h6>Moduli del portale
							<asp:Label id="lblCount" runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvModuli.Count &amp; ")" %>'>
							</asp:Label></h6>
						<hr noshade size="1">
						<asp:DataGrid id="dgModuli" runat="server" UseAccessibleHeader="True" Width="100%" CssClass="grid" GridLines="None" DataSource="<%# dvModuli %>" DataKeyField="ID" AutoGenerateColumns="False" AllowPaging="True" PagerStyle-Visible="<%# dvModuli.Count > dgModuli.PageSize %>" Visible="<%# dvModuli.Count > 0 %>">
							<Columns>
								<asp:BoundColumn DataField="Sect_Desc" SortExpression="Sect_Desc" HeaderText="Men&#249;"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Modulo">
									<ItemTemplate>
										<asp:LinkButton id="lnkSelect" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Descrizione") %>' CommandName="Select">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Abilitato">
									<ItemTemplate>
										<asp:CheckBox id="chkAbilitato" runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Abilitato") %>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
						<asp:Label id="lblNoModuli" runat="server" CssClass="label" Visible="<%# dvModuli.Count <= 0 %>">
						Non sono presenti moduli.
						</asp:Label>
					</td>
				</tr>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
