<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_sintesi.aspx.vb" Inherits="ATCBussm1.wf_sintesi"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_StatisticaBussm</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmStatisticaBussm" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center">&nbsp;</DIV>
			<table id="Tabella" height="100%" width="100%">
				<tr>
					<td style="WIDTH: 131px" vAlign="top">
						<DIV align="center"><asp:validationsummary id="VSConsumiAz" runat="server" Font-Size="Smaller" Height="184px" Width="110px"
								HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary><asp:panel id="PnlParametri" runat="server" Width="62px" Visible="TRUE" Height="130px">
								<FIELDSET style="WIDTH: 100%; HEIGHT: 130px"><LEGEND class="label">Parametro di lancio</LEGEND>
									<TABLE id="TBParametri" style="WIDTH: 123px; HEIGHT: 50px">
										<TR>
											<TD>
												<asp:Label id="LblAnno" runat="server" AssociatedControlID="TxtAnno" CssClass="label">Anno:</asp:Label></TD>
										</TR>
										<TR>
											<TD>
												<asp:TextBox id="TxtAnno" Width="83px" Visible="true" Runat="server">2005</asp:TextBox>
												<asp:RequiredFieldValidator id="rfvAnno" runat="server" Display="None" ControlToValidate="TxtAnno" ErrorMessage="Il campo Anno è obbligatorio"></asp:RequiredFieldValidator>
												<asp:CompareValidator id="cvAnno" runat="server" Display="None" ControlToValidate="TxtAnno" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
													ValueToCompare="1980" Operator="GreaterThan" Type="Integer"></asp:CompareValidator></TD>
										</TR>
									</TABLE>
									<BR>
									<asp:Button id="btnSend" runat="server" CssClass="bottone" Text="Visualizza"></asp:Button></FIELDSET>
								<BR>
							</asp:panel></DIV>
					</td>
					<td>
						<DIV align="center" style="WIDTH: 100%; HEIGHT: 100%"><asp:panel id="PnlStatistica" runat="server" Width="100%" Height="100%" Visible="false">
								<FIELDSET style="WIDTH: 100%; HEIGHT: 100%"><LEGEND class="label">Statistica sintesi</LEGEND><IFRAME id=FrmStatistica 
      style="WIDTH: 100%; HEIGHT: 100%" 
      src='<%=STRING.concat("http://zion/ReportServer?%2fStatisticaComune%2fRptSintesiParcometri&amp;rc:Toolbar=true", UrlReport()) %>' 
      frameBorder=0 width="100%" height="100%"></IFRAME>
								</FIELDSET>
							</asp:panel></DIV>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
