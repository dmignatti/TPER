<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gruppiNew.aspx.vb" Inherits="ATCBussm1.wf_gruppiNew"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gruppiNew</title>
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
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Gruppi
							<asp:Label id="lblCount" runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvGruppi.Count &amp; ")" %>'>
							</asp:Label></h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgGruppi runat="server" CssClass="grid" UseAccessibleHeader="True" Width="100%" DataSource="<%# dvGruppi %>" DataKeyField="ID" GridLines="None" AutoGenerateColumns="False">
							<Columns>
								<asp:TemplateColumn HeaderText="Descrizione">
									<ItemTemplate>
										<asp:LinkButton id="lnkGruppo" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Descrizione") %>' CommandName="Select">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Abilitato">
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:CheckBox id="chkEnabled" runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Abilitato") %>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="bottone" Text="Elimina" CommandName="Delete"
											CausesValidation="false"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid>
						<asp:Label id="lblNoGruppi" runat="server" Visible="<%# dvGruppi.Count <= 0 %>" CssClass="label">Non sono presenti gruppi di utenti.</asp:Label>
						<hr noShade SIZE="1">
						<asp:Button id="btnAddGroup" runat="server" CssClass="Bottone" Text="Aggiungi un nuovo gruppo &raquo;"></asp:Button></td>
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
