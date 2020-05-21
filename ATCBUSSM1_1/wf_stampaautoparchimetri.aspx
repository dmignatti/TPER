<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_stampaautoparchimetri.aspx.vb" Inherits="ATCBussm1.wf_stampaautoparchimetri"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Lista autoparchimetri</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="ATCPrint.css" type="text/css" rel="stylesheet">
		<LINK media="print" href="ATCPrint.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<table width="100%" height="100%" cellpadding="2" cellspacing="0" border="0">
				<tr>
					<td valign="top"><p Class="label">Selezionare l'anno per la visualizzazione della lista 
							degli autoparchimetri:</p>
						<asp:TextBox ID="txtanno" Runat ="server"  CssClass="label" >
						</asp:TextBox>
						<p>
							<asp:Button id="btnSend" runat="server" CssClass="bottone" Text="Visualizza"></asp:Button></p>
					</td>
					<td width="100%" valign="top"><asp:panel id="PnlAutoparchimetri" runat="server" Width="100%" Visible="false" Height="100%"><IFRAME id=FrmAutoparchimetri 
      style="WIDTH: 100%; HEIGHT: 100%" 
      src='<%=STRING.concat("http://zion/ReportServer?%2fAtcReport%2fRptAutoparchimetri&amp;rc:Toolbar=true", UrlReport()) %>' 
      frameBorder=0 width="100%" 
  height="100%"></IFRAME>
						</asp:panel>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
