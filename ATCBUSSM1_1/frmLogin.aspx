<%@ Page Language="vb" AutoEventWireup="false" Codebehind="frmLogin.aspx.vb" Inherits="ATCBussm1.frmLogin" %>
<%@ Register TagName="PageFooter" TagPrefix="PageFooter" Src="PageFooterMain.ascx" %>
<%@ Register TagName="PageHeader" TagPrefix="PageHeader" Src="PageHeader.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ATC ISPortal</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body style="MARGIN: 0px">
		<form id="Form1" method="post" runat="server">
			<div class="Header" style="BORDER-BOTTOM: #999999 1px solid">
				<IMG src="images/logo_TPER">
			</div>
			<br>
			<div align="center">
				<table class="box" cellpadding="4" border="0" cellspacing="0" width="350">
					<tr>
						<td class="BottomBorder">
							<h6>Entra nel Portale</h6>
						</td>
					</tr>
					<tr>
						<td class="BottomBorder">
							<asp:ValidationSummary id="vsErrors" runat="server" HeaderText="Attenzione!" Width="100%" CssClass="Error"></asp:ValidationSummary>
							<div align="right">
								<asp:label id="lblUser" runat="server" CssClass="Label">Username:&nbsp;&nbsp;</asp:label>
								<asp:textbox id="Userid" runat="server" Width="155px"></asp:textbox><BR>
								<BR>
								<asp:label id="lblPassword" runat="server" CssClass="Label">Password:&nbsp;&nbsp;</asp:label>
								<asp:textbox id="Password" runat="server" MaxLength="20" TextMode="Password" Width="155px"></asp:textbox><br>
								<br>
								<asp:button id="cmdConferma" runat="server" CssClass="Bottone" Text="Accedi »"></asp:button></div>
							<div align="center">
								<asp:CustomValidator id="cvLogin" runat="server" CssClass="lblerror" ErrorMessage="Nome utente o password non validi."
									Display="None" EnableClientScript="False"></asp:CustomValidator>
								<asp:Label id="messaggio" runat="server" CssClass="lblerror"></asp:Label>
								<asp:requiredfieldvalidator id="UseridValidator" runat="server" ErrorMessage='Il campo "Username" è obbligatorio.'
									Display="None" ControlToValidate="Userid"></asp:requiredfieldvalidator>
								<asp:requiredfieldvalidator id="rfvPassword" runat="server" ErrorMessage='Il campo "Password" è obbligatorio'
									Display="None" ControlToValidate="Password"></asp:requiredfieldvalidator></div>
						</td>
					</tr>
					<tr>
						<td align="center">
							<asp:HyperLink id="lnkInnovatech" runat="server" ImageUrl="images/VAREmilia.gif" Target="_blank"
								NavigateUrl="http://www.innovatech.it">Var Emilia Romagna</asp:HyperLink></td>
					</tr>
				</table>
			</div>
		</form>
	</body>
</HTML>
