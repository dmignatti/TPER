<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_reportpresenze.aspx.vb" Inherits="ATCBussm1.wf_reportpresenze"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Ufficio presenze</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><asp:panel id="PnlStatistica" runat="server" Width="100%"  Height="100%">
					<FIELDSET style="WIDTH: 100%; HEIGHT: 654px"><LEGEND class="label">Report per ufficio presenze</LEGEND><IFRAME id=FrmStatistica style="WIDTH: 100%; HEIGHT: 100%" 
src='http://appsql/ReportServer/Pages/ReportViewer.aspx?%2fUfficioPresenze%2fRptPresenze&amp;rc:Parameters=true&amp;rc:DocMap=false&amp;rs:Command=Render' 
frameBorder=0 width="100%" height="100%"></IFRAME>
					</FIELDSET>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
