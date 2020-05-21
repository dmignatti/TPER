<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_centroinbicinote.aspx.vb" Inherits="ATCBussm1.wf_centroinbicinote"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_centroinbicinote</title>
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
						<h6>Note</h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgNote runat="server" AutoGenerateColumns="False" DataKeyField="Id" GridLines="None" UseAccessibleHeader="True" CssClass="grid" DataSource="<%# dvNote %>" Width="100%" Visible="<%# dvNote.Count > 0 %>" PagerStyle-Visible="<%# dvNote.Count > dgNote.PageSize %>" AllowPaging="True">
							<Columns>
								<asp:BoundColumn DataField="Data" SortExpression="Data" ReadOnly="True" HeaderText="Data" DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Nota">
									<ItemTemplate>
										<asp:LinkButton id="lnkTipoNota" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Tipo") %>' CommandName="Select">
										</asp:LinkButton><BR>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nota") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="Bottone" Text="Elimina" CausesValidation="false"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:label id=lblNoNote runat="server" CssClass="label" Visible="<%# dvNote.Count <= 0 %>">Non sono presenti note per questo utente.</asp:label>
						<hr noShade SIZE="1">
						<asp:LinkButton id="LinkButton1" runat="server">&laquo; Torna alla ricerca</asp:LinkButton>&nbsp;
						<asp:button id="btnAdd" runat="server" CssClass="bottone" Text="Aggiungi una nuova nota"></asp:button></td>
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
