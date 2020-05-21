<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_statisticavie.aspx.vb" Inherits="ATCBussm1.wf_statisticavie"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_statisticavie</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmStatisticaVie" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSConsumiAz" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlParametri" runat="server" Visible="TRUE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Parametri di lancio statistica</LEGEND>
						<TABLE id="TBParametri">
							<TR>
								<TD style="HEIGHT: 42px">
									<asp:Label id="LblNVie" runat="server" CssClass="label" AssociatedControlID="TxtNVie">Numero di vie:</asp:Label></TD>
								<TD style="HEIGHT: 42px">
									<asp:TextBox id="TxtNVie" Visible="true" Runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator id="rfvVie" runat="server" ErrorMessage="Il campo Vie è obbligatorio." Display="None"
										ControlToValidate="TxtNVie"></asp:RequiredFieldValidator>
									<asp:CompareValidator id="cvvVie" runat="server" ErrorMessage="Il campo Vie deve essere un valore numerico maggiore di 10"
										Display="None" ValueToCompare="10" Type="Integer" Operator="GreaterThanEqual" ControlToValidate="TxtNVie"></asp:CompareValidator>
								<TD style="HEIGHT: 42px">
									<asp:Label id="LblSintesi" runat="server" CssClass="label" AssociatedControlID="ChkSintesi">Solo sintesi:</asp:Label></TD>
								<TD style="HEIGHT: 42px">
									<asp:CheckBox id="ChkSintesi" CssClass="Label" Runat="server" Checked="True"></asp:CheckBox></TD>
								<TD style="HEIGHT: 42px"></TD>
							</TR>
							<TR>
								<TD>
									<asp:Label id="LblDa" runat="server" CssClass="label" AssociatedControlID="CalDa">Data da:</asp:Label></TD>
								<TD>
									<asp:calendar id="CalDa" runat="server" CssClass="grid" SelectedDate="2005-01-01"></asp:calendar>
								<TD>
									<asp:Label id="LblA" runat="server" CssClass="label" AssociatedControlID="CalA" >Data a:</asp:Label></TD>
								<TD>
									<asp:calendar id="CalA" runat="server" CssClass="grid" SelectedDate="2005-12-31"></asp:calendar></TD>
								<TD>
									<asp:Button id="btnSend" runat="server" CssClass="bottone" Text="Visualizza"></asp:Button></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center" style="WIDTH: 100%; HEIGHT: 100%"><asp:panel id="PnlStatistica" runat="server" Visible="false" Width="100%" Height ="100%">
					<FIELDSET style="WIDTH: 100%; HEIGHT: 100%"><LEGEND class="label">Statistica vie di Bologna</LEGEND><IFRAME id="FrmStatistica" src='<%="http://zion/ReportServer?%2fStatisticaComune%2fRptPrincipaleSC" & UrlReport() %>' frameBorder="0" width="100%" height="100%"></IFRAME>
					</FIELDSET>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
