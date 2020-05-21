<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_confMobilita.aspx.vb" Inherits="ATCBussm1.wf_confMobilita"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_confMobilita</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:panel id="pnlMessage" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
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
						<h6>Configurazione eccezioni mobilità</h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="ValidationSummary1" runat="server" Width="100%" HeaderText="Attenzione. si sono verificati i seguenti errori:"></asp:validationsummary>
						<asp:label id="lblNr_CambiGStessoTipo" runat="server" Width="175px" CssClass="label" AssociatedControlID="txtNr_CambiGStessoTipo">Num. cambi stesso giorno:</asp:label>
						<asp:textbox id="txtNr_CambiGStessoTipo" runat="server"></asp:textbox>
						<br>
						<asp:label id="lblNr_CambiMStessoTipo" runat="server" Width="175px" CssClass="label" AssociatedControlID="txtNr_CambiMStessoTipo">Num. cambi stesso mese:</asp:label>
						<asp:textbox id="txtNr_CambiMStessoTipo" runat="server"></asp:textbox>
						<br>
						<hr SIZE="1" noShade>
						<asp:button id="btnConferma" runat="server" CssClass="bottone" Text="Conferma"></asp:button>
						<asp:CustomValidator Runat="server" ID="cvInputField" Display="None" ErrorMessage="Entrambi i valori sono obbligatori e numerici"></asp:CustomValidator>
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
