<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_reportBussm.aspx.vb" Inherits="ATCBussm1.wf_reportBussm"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_reportBussm</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmReportBussm" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION>
				<br>
				<br>
				<asp:Label CssClass="label" id="LblRpt" runat="server" text='Dati aggiornati al'></asp:Label>
				<br>
				<asp:calendar id="caData" runat="server" CssClass="grid" SelectedDate="2004-08-31"></asp:calendar></DIV>
			<iframe id="report" src='' frameBorder="0" width="100%" height="600"></iframe>
		</form>
	</body>
</HTML>
