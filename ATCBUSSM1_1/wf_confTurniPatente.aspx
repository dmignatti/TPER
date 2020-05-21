<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_confTurniPatente.aspx.vb" Inherits="ATCBussm1.wf_confTurniPatente"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_confTurniPatente</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission><asp:panel id="pnlMessage" runat="server" HorizontalAlign="Center" Width="100%" Visible="False">
				<TABLE id="Table02" class="Message" cellSpacing="0" cellPadding="0" align="center">
					<TR>
						<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
								width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
								width="4" height="4"></TD>
					</TR>
					<TR>
						<TD style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
							vAlign="top">
							<asp:Label id="lblMessage" runat="server">Modifica/inserimento dati corretta.</asp:Label></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
								src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
								src="images/corner_br.gif" width="4" height="4"></TD>
					</TR>
				</TABLE>
				<BR>
			</asp:panel>
			<table id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<!-- -->
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Assegnazioni Turni/Patente</h6>
						<hr SIZE="1" noShade>
						<!--<asp:validationsummary id="ValidationSummary1" runat="server" Width="100%" HeaderText="Attenzione. si sono verificati i seguenti errori:"></asp:validationsummary>-->
						<!-- -->
						<asp:DataGrid id="dgTipoTurni" runat="server" DataSource="<%# dvTipoTurni %>" DataKeyField="CodiceTipologia" UseAccessibleHeader="True" AutoGenerateColumns="False" Width="100%" CssClass="grid" Visible="<%# dvTipoTurni.Count > 0 %>" AllowPaging="True" PagerStyle-Visible="<%# dvTipoTurni.Count > dgTipoTurni.PageSize %>" GridLines="None" >
							<Columns>
								<asp:TemplateColumn HeaderText="Cod.Turno">
									<ItemTemplate>
										<asp:LinkButton id="lnkCodTurno" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CodiceTipologia") %>' CommandName="Select">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="TipologiaTurno" SortExpression="TipologiaTurno" ReadOnly="True" HeaderText="Turno"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Patente">
									<ItemTemplate>
										<asp:CheckBox id="chkPatente" runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Flag_Patente") %>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
						<hr SIZE="1" noShade>
						<!--<asp:button id="btnConferma" runat="server" Text="Conferma" CssClass="bottone"></asp:button>-->
					</td>
				</tr>
				<!-- -->
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
