<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_confTurnoPatente.aspx.vb" Inherits="ATCBussm1.wf_confTurnoPatente"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_confTurnoPatente</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission><asp:panel id="pnlMessage" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px">
						<h6>Tipo Turno</h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Atttenzione!"></asp:validationsummary>
						<!-- --><asp:label id="lblCodTipo" runat="server" Width="130px" AssociatedControlID="txtCodTipo">Cod. Tipologia</asp:label><asp:textbox id=txtCodTipo runat="server" Text='<%# DataBinder.Eval(DsTipoTurni1, "Tables[TipTurno_Abilitazione].DefaultView.[0].Cod_Tipologia") %>' MaxLength="30" ReadOnly="true">
						</asp:textbox><br>
						<asp:label id="lblFlagPatente" runat="server" Width="130px" AssociatedControlID="chkFlagPatente">Patente</asp:label><asp:checkbox id=chkFlagPatente runat="server" Checked='<%# DataBinder.Eval(DsTipoTurni1, "Tables[TipTurno_Abilitazione].DefaultView.[0].Flag_Patente") %>'>
						</asp:checkbox>
						<!-- -->
						<br>
						<HR width="100%" SIZE="1">
						<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="False">&laquo; Torna ai Tipi Turni</asp:LinkButton>&nbsp;
						<asp:button id="btnSave" runat="server" Text="Salva" CssClass="bottone"></asp:button></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
