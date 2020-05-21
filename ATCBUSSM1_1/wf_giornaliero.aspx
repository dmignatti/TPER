<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_giornaliero.aspx.vb" Inherits="ATCBussm1.wf_giornaliero"%>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_giornaliero</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
					<td valign="top"><p Class="label">Selezionare la data per la visualizzazione del 
							giornaliero:</p>
						<asp:calendar id="caData" runat="server" CssClass="grid"></asp:calendar>
						<p>
							<asp:Button id="btnSyncAS400" runat="server" CssClass="bottone" Width="180px" Text="Aggiornamento dei dati da AS400"></asp:Button></p>
					</td>
					<td width="100%" valign="top"><iframe height="90%" id="report" src='http://zion/ReportServer?/Giornaliero/rsGiornaliero&amp;rc:Toolbar=true&amp;rc:Parameters=false&amp;rc:DocMap=false&amp;data=<%=String.Concat(caData.SelectedDate.Day, "/", caData.SelectedDate.Month, "/", caData.SelectedDate.Year)%>' frameBorder=0 width="100%">
						</iframe>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
