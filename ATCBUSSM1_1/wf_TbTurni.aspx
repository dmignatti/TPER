<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_TbTurni.aspx.vb" Inherits="ATCBussm1.wf_TbTurni"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_TbTurni</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<H6>Aggiungi i turni da selezionare per gli scambi turno</H6>
						<H6>
						</H6>
						<H6>
							<hr noShade SIZE="1">
						</H6>
						<H6>
							<TABLE id="Table1" cellSpacing="0" cellPadding="2" width="100%">
								<TR>
									<TD vAlign="top" width="50%">
										<H6>Tutti i turni</H6>
										<asp:label id="Label1" runat="server" AssociatedControlID="txtSearch" Width="50px">cerca:</asp:label><asp:textbox id="txtSearch" runat="server"></asp:textbox><asp:button id="btnSearch" runat="server" CausesValidation="False" CssClass="bottone" Text="Cerca"></asp:button><asp:textbox id="txtFake" runat="server" CssClass="Hidden"></asp:textbox><BR>
										<asp:datagrid id=dgGruppi runat="server" Width="100%" CssClass="Grid" DataKeyField="TITIPL" UseAccessibleHeader="True" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" PageSize="20" Visible="<%# dvTurni.Count > 0 %>" PagerStyle-Visible="<%# dvTurni.Count > dgGruppi.PageSize %>" DataSource="<%# dvTurni %>" >
											<Columns>
												<asp:TemplateColumn>
													<ItemTemplate>
														<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
													</ItemTemplate>
												</asp:TemplateColumn>
												<asp:BoundColumn DataField="TITIPL" SortExpression="TITIPL" HeaderText="Turno"></asp:BoundColumn>
												<asp:BoundColumn DataField="TIDTIP" SortExpression="TIDTIP" HeaderText="Descrizione"></asp:BoundColumn>
												<asp:BoundColumn DataField="TIGRUA" SortExpression="TIGRUA" HeaderText="Gruppo"></asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
										</asp:datagrid><asp:label id=lblNoProdotti runat="server" CssClass="label" Visible="<%# dvTurni.Count <= 0 %>">Non ci sono turni da associare.</asp:label></TD>
									<TD width="1%"><asp:button id=btnAdd runat="server" CausesValidation="False" CssClass="Bottone" Text=">>" Enabled="<%# dvTurni.Count > 0 %>">
										</asp:button><BR>
										<asp:button id=btnRemove tabIndex=2 runat="server" CausesValidation="False" CssClass="Bottone" Text="<<" Enabled='<%# DataBinder.Eval(DsTurni1, "Tables[TB_CAMBI_TURNO]").Rows.Count > 0 %>'>
										</asp:button><BR>
									</TD>
									<TD vAlign="top" width="50%">
										<H6>Turni scelti per gli scambi turno</H6>
										<H6>
											<asp:textbox id="TextBox1" runat="server" Width="0px"></asp:textbox><BR>
											<asp:datagrid id=dgGruppiDelModulo runat="server" Width="100%" CssClass="Grid" DataKeyField="TITIPL" UseAccessibleHeader="True" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" PageSize="20" Visible='<%# DataBinder.Eval(DsTurni1, "Tables[TB_CAMBI_TURNO]").Rows.Count > 0 %>' PagerStyle-Visible='<%# DataBinder.Eval(dsTURNI1, "Tables[TB_CAMBI_TURNO]").Rows.Count > dgGruppiDelModulo.PageSize %>' DataSource="<%# DsTURNI1 %>" DataMember="TB_CAMBI_TURNO">
												<Columns>
													<asp:TemplateColumn>
														<ItemTemplate>
															<asp:CheckBox id="chkSelected" runat="server"></asp:CheckBox>
														</ItemTemplate>
													</asp:TemplateColumn>
													<asp:BoundColumn DataField="TITIPL" SortExpression="TITIPL" HeaderText="Turno"></asp:BoundColumn>
													<asp:BoundColumn DataField="TIDTIP" SortExpression="TIDTIP" HeaderText="Descrizione"></asp:BoundColumn>
													<asp:BoundColumn DataField="TIGRUA" SortExpression="TIGRUA" HeaderText="Gruppo"></asp:BoundColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Center" Wrap="False" Mode="NumericPages"></PagerStyle>
											</asp:datagrid><asp:label id=lblNoCarichi runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DSTURNI1, "Tables[TB_CAMBI_TURNO]").Rows.Count <= 0 %>'>Non esistono gruppi con accesso al modulo selezionato.</asp:label></H6>
									</TD>
								</TR>
							</TABLE>
						</H6>
						<H6>
							<hr noShade SIZE="1">
						</H6>
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
