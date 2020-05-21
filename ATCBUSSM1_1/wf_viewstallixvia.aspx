<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_viewstallixvia.aspx.vb" Inherits="ATCBussm1.wf_viewstallixvia"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_viewstallixvia</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSStalli" runat="server" DESIGNTIMEDRAGDROP="459" HeaderText="Attenzione!" Width="100%"></asp:validationsummary></DIV>
			<div align="center"><asp:panel id="pnlSearch" runat="server" Width="600px">
					<FIELDSET><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 227px">
									<asp:Label id="lblVia" runat="server" CssClass="label">Via</asp:Label></TD>
								<TD>
									<asp:Label id="lblPeriodo" runat="server" CssClass="label">Zona</asp:Label></TD>
								<TD style="WIDTH: 92px">
									<asp:Label id="Label2" runat="server" CssClass="label">Data Al (gg/mm/aaaa)</asp:Label></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 227px">
									<asp:TextBox id="txtVia" runat="server" Width="320px"></asp:TextBox></TD>
								<TD>
									<asp:DropDownList id=cboSettori runat="server" Width="196px" DataValueField="IdSettore" DataTextField="Desc_Dettaglio_Settore" DataSource="<%# DsSettori %>" DataMember="Settori">
									</asp:DropDownList></TD>
								<TD style="WIDTH: 92px">
									<asp:TextBox id="TxtAl" runat="server" Width="73px"></asp:TextBox>
									<asp:RangeValidator id="RangeValidator1" runat="server" CssClass="lblError" ErrorMessage="*" ControlToValidate="TxtAl"
										Type="Date" MaximumValue="9999/12/31" MinimumValue="1900/01/01"></asp:RangeValidator></TD>
								<TD>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Visualizza"></asp:Button></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></div>
			<DIV align="center"><asp:panel id="PnlStatistica" runat="server" Width="100%" Visible="false">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Statistica Stalli per via</LEGEND><IFRAME id=FrmStatistica style="WIDTH: 100%; HEIGHT: 450px" 
src='<%=STRING.concat("http://zion/ReportServer?%2fAtcReport%2fRptStalliXVia&amp;rc:Toolbar=true", UrlReport()) %>' 
frameBorder=0 width="100%" height=450></IFRAME>
					</FIELDSET>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
