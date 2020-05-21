<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_stampaANAautoparchimetri.aspx.vb" Inherits="ATCBussm1.wf_stampaANAautoparchimetri"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Lista anagrafiche autoparchimetri</title>
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
					<td width="100%" valign="top"><asp:panel id="PnlAutoparchimetri" runat="server" Width="100%" Visible="true" Height="100%">
					<IFRAME id="FrmAutoparchimetri"  
						style="WIDTH: 100%; HEIGHT: 100%" src='http://appsql/ReportServer?%2fAtcReport%2fRptAnaAutoparchimetri&amp;rc:Toolbar=true&rc:DocMap=false' frameBorder=0 width="100%" zion
						height="100%"></IFRAME>
						</asp:panel>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
