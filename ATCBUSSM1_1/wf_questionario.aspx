<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_questionario.aspx.vb" Inherits="ATCBussm1.wf_questionario" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_modificapassword</title>
		<meta name="vs_showGrid" content="True">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="hguaberttp://schemas.microsoft.com/intellisense/ie5">
		<link href="ATC.css" type="text/css" rel="stylesheet">
			<link href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" runat="server" method="post">
			<asp:Panel id="pnlMessage" runat="server" HorizontalAlign="Center" Width="100%" Visible="False">
				<TABLE id="Table02" class="Message" cellSpacing="0" cellPadding="0" width="100%" align="center">
					<TR>
						<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
								width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
								width="4" height="4"></TD>
					</TR>
					<TR>
						<TD vAlign="top" align="center">
							<asp:Label id="lblMessage" runat="server">Questionario compilato correttamente.</asp:Label></TD>
					<TR>
						<TD height="4" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
								src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
								src="images/corner_br.gif" width="4" height="4"></TD>
					</TR>
				</TABLE>
				<BR>
			</asp:Panel>
			<asp:Panel ID="domande" Runat="server">
				<TABLE id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center"
					runat="server">
					<TR>
						<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
								width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
								width="4" height="4"></TD>
					</TR>
					<TR>
						<TD vAlign="top">
							<asp:Panel id="Domandeq" Runat="server">
								<asp:label id="titolo1" Runat="server" CssClass="titoloq1">QUESTIONARIO:</asp:label><br/>
								<asp:label id="titolo2" Runat="server" CssClass="titoloq2">INTRODUZIONE DI INNOVAZIONI TECNOLOGICHE NELL'ATTIVITA' DI ACCERTAMENTO 
									(Progetto Mimosa)</asp:label>
								<HR SIZE="1" noShade>
								<asp:ValidationSummary id="VSummary" runat="server" Width="100%" HeaderText="Attenzione. si sono verificati i seguenti errori:"
									CssClass="error"></asp:ValidationSummary>
								<asp:Label id="lblDomanda1" runat="server" Width="1184px" CssClass="titlelabelq">1) Quanto ritiene che la funzione di <u>
										lettura dei codici a barre dei contrassegni</u> sulle auto in sosta recentemente introdotta sui palmari in dotazione:</asp:Label>
								<BR>
								<asp:Label id="lblDomanda1a" runat="server" Width="400px" CssClass="labelq">a)	le abbia semplificato lo svolgimento di questa attività?</asp:Label>
								<asp:RequiredFieldValidator id="RV1a" runat="server" ErrorMessage="La domanda 1 a) è obbligatoria" Display="none"
									ControlToValidate="RBL1a"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL1a" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda1b" runat="server" Width="400px" CssClass="labelq">b)	riduca il rischio di compiere errori?</asp:Label>
								<asp:RequiredFieldValidator id="RV1b" runat="server" ErrorMessage="La domanda 1 b) è obbligatoria" Display="none"
									ControlToValidate="RBL1b"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL1b" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda1c" runat="server" Width="400px" CssClass="labelq">c)	abbia ridotto i tempi per svolgere gli accertamenti?</asp:Label>
								<asp:RequiredFieldValidator id="RV1c" runat="server" ErrorMessage="La domanda 1 c) è obbligatoria" Display="none"
									ControlToValidate="RBL1c"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL1c" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda2" runat="server" Width="1184px" CssClass="titlelabelq">2) Ritiene che una funzione di <u>
										lettura ottica (OCR) delle targhe delle auto</u>  in sosta se fosse presente sui palmari in dotazione potrebbe:</asp:Label>
								<BR>
								<asp:Label id="lblDomanda2a" runat="server" Width="330px" CssClass="labelq">a)	semplificare lo svolgimento della sua attività?</asp:Label>
								<asp:RequiredFieldValidator id="RV2a" runat="server" ErrorMessage="La domanda 2 a) è obbligatoria" Display="none"
									ControlToValidate="RBL2a"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL2a" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda2b" runat="server" Width="400px" CssClass="labelq">b)	ridurre il rischio di compiere errori?</asp:Label>
								<asp:RequiredFieldValidator id="RV2b" runat="server" ErrorMessage="La domanda 2 b) è obbligatoria" Display="none"
									ControlToValidate="RBL2b"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL2b" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda2c" runat="server" Width="400px" CssClass="labelq">c)	ridurre i tempi per svolgere gli accertamenti?</asp:Label>
								<asp:RequiredFieldValidator id="RV2c" runat="server" ErrorMessage="La domanda 2 c) è obbligatoria" Display="none"
									ControlToValidate="RBL2c"></asp:RequiredFieldValidator>
								<BR>
								<asp:RadioButtonList id="RBL2c" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<BR>
								<asp:Label id="lblDomanda3" runat="server" Width="1184px" CssClass="titlelabelq">3) Nel complesso, quanto si aspetta che l’introduzione di innovazioni tecnologiche possa migliorare il suo lavoro?</asp:Label>
								<asp:RequiredFieldValidator id="RV3" runat="server" ErrorMessage="La domanda 3 è obbligatoria" Display="none"
									ControlToValidate="RBL3"></asp:RequiredFieldValidator>
								<asp:RadioButtonList id="RBL3" runat="server">
									<asp:ListItem Value="Molto"></asp:ListItem>
									<asp:ListItem Value="Abbastanza"></asp:ListItem>
									<asp:ListItem Value="Poco"></asp:ListItem>
									<asp:ListItem Value="Per niente"></asp:ListItem>
								</asp:RadioButtonList>
								<HR SIZE="1" noShade>
								<asp:Button id="btnConferma" runat="server" CssClass="bottone" Text="Conferma" CausesValidation="True"></asp:Button>
							</asp:Panel></TD>
					</TR>
					<TR>
						<TD height="4" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
								src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
								src="images/corner_br.gif" width="4" height="4"></TD>
					</TR>
				</TABLE>
			</asp:Panel>
		</form>
	</body>
</HTML>
