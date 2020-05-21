<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_TB_TURNI_AE.aspx.vb" Inherits="ATCBussm1.wf_TB_TURNI_AE"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_modulo</title>
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
						<H6 style="Z-INDEX: 0">Aggiungi i turni nella lista "accertamento esteso"
						</H6>
						<H6>
							<hr SIZE="1" noShade>
						</H6>
						<H6>
							<TABLE id="Table1" cellSpacing="0" cellPadding="2" width="100%">
								<TR>
									<TD vAlign="top" width="50%">
										<H6>Tutti i turni</H6>
										<asp:label id="Label1" runat="server" Width="50px" AssociatedControlID="txtSearch">cerca:</asp:label><asp:textbox id="txtSearch" runat="server"></asp:textbox><asp:button id="btnSearch" runat="server" Text="Cerca" CssClass="bottone" CausesValidation="False"></asp:button><asp:textbox id="txtFake" runat="server" CssClass="Hidden"></asp:textbox><BR>
										<asp:datagrid id=dgGruppi runat="server" Width="100%" CssClass="Grid" DataSource="<%# dvGruppi %>" PagerStyle-Visible="<%# dvGruppi.Count > dgGruppi.PageSize %>" Visible="<%# dvGruppi.Count > 0 %>" PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="TUCTUR">
											<Columns>
												<asp:TemplateColumn>
													<ItemTemplate>
														<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
													</ItemTemplate>
												</asp:TemplateColumn>
												<asp:BoundColumn DataField="TUCTUR" SortExpression="TUCTUR" HeaderText="Turni"></asp:BoundColumn>
												<asp:BoundColumn DataField="TUGRUA" SortExpression="TUGRUA" HeaderText="Gruppi"></asp:BoundColumn>
												<asp:BoundColumn DataField="TUTIPL" SortExpression="TUTIPL" HeaderText="Tipo"></asp:BoundColumn>
												<asp:BoundColumn Visible="False" DataField="TUCTUR_ORDER" SortExpression="TUCTUR_ORDER" ReadOnly="True"
													HeaderText="TUCTUR_ORDER"></asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
										</asp:datagrid><asp:label id=lblNoProdotti runat="server" CssClass="label" Visible="<%# dvGruppi.Count <= 0 %>">Non ci sono gruppi da associare.</asp:label></TD>
									<TD width="1%"><asp:button id=btnAdd runat="server" Text=">>" CssClass="Bottone" CausesValidation="False" Enabled="<%# dvGruppi.Count > 0 %>">
										</asp:button><BR>
										<asp:button id=btnRemove tabIndex=2 runat="server" Text="<<" CssClass="Bottone" CausesValidation="False" Enabled='<%# DataBinder.Eval(DsTURNIAE2, "Tables[GruppiDelModulo]").Rows.Count > 0 %>'>
										</asp:button><BR>
									</TD>
									<TD vAlign="top" width="50%">
										<H6>Turni di accertamento esteso</H6>
										<asp:textbox id="TextBox1" runat="server" Width="0px"></asp:textbox><BR>
										<asp:datagrid id=dgGruppiDelModulo runat="server" Width="100%" CssClass="Grid" DataSource="<%# DsTURNIAE2 %>" PagerStyle-Visible='<%# DataBinder.Eval(DsTURNIAE2, "Tables[GruppiDelModulo]").Rows.Count > dgGruppiDelModulo.PageSize %>' Visible='<%# DataBinder.Eval(DsTURNIAE2, "Tables[GruppiDelModulo]").Rows.Count > 0 %>' PageSize="20" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="TURNI" DataMember="GruppiDelModulo">
											<Columns>
												<asp:TemplateColumn>
													<ItemTemplate>
														<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
													</ItemTemplate>
												</asp:TemplateColumn>
												<asp:BoundColumn DataField="TURNI" SortExpression="TURNI" HeaderText="TURNI"></asp:BoundColumn>
												<asp:BoundColumn DataField="GRUPPI" SortExpression="GRUPPI" HeaderText="GRUPPI"></asp:BoundColumn>
												<asp:BoundColumn DataField="TIPO" SortExpression="TIPO" HeaderText="TIPO"></asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
										</asp:datagrid><asp:label id=lblNoCarichi runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsTURNIAE2, "Tables[GruppiDelModulo]").Rows.Count <= 0 %>'>Non esistono gruppi con accesso al modulo selezionato.</asp:label></TD>
								</TR>
							</TABLE>
						</H6>
						<H6>
							<hr SIZE="1" noShade>
						</H6>
						<H6>&nbsp;</H6>
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
