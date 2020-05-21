<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_StatisticaBussm.aspx.vb" Inherits="ATCBussm1.wf_StatisticaBussm"%>
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
			<table id="Tabella" height="633" width="935" style="WIDTH: 935px; HEIGHT: 633px">
				<tr>
					<td style="WIDTH: 131px" vAlign="top">
						<DIV align="center"><asp:validationsummary id="VSConsumiAz" runat="server" Font-Size="Smaller" Height="88px" Width="110px"
								HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary><asp:panel id="PnlParametri" runat="server" Width="62px" Visible="TRUE" Height="492px">
								<FIELDSET style="WIDTH: 100%; HEIGHT: 465px"><LEGEND class="label">Parametri di lancio</LEGEND>
									<TABLE id="TBParametri" style="WIDTH: 123px; HEIGHT: 157px">
										<TR>
											<TD>
												<asp:Label id="LblMese" runat="server" CssClass="label" AssociatedControlID="CboMese">Mese:</asp:Label></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 13px">
												<asp:DropDownList id="CboMese" runat="server" CssClass="label">
													<asp:ListItem Value="1">Gennaio</asp:ListItem>
													<asp:ListItem Value="2">Febbraio</asp:ListItem>
													<asp:ListItem Value="3">Marzo</asp:ListItem>
													<asp:ListItem Value="4">Aprile</asp:ListItem>
													<asp:ListItem Value="5">Maggio</asp:ListItem>
													<asp:ListItem Value="6">Giugno</asp:ListItem>
													<asp:ListItem Value="7">Luglio</asp:ListItem>
													<asp:ListItem Value="8">Agosto</asp:ListItem>
													<asp:ListItem Value="9">Settembre</asp:ListItem>
													<asp:ListItem Value="10">Ottobre</asp:ListItem>
													<asp:ListItem Value="11">Novembre</asp:ListItem>
													<asp:ListItem Value="12">Dicembre</asp:ListItem>
												</asp:DropDownList></TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="LblAnno" runat="server" CssClass="label" AssociatedControlID="TxtAnno">Anno:</asp:Label></TD>
										</TR>
										<TR>
											<TD>
												<asp:TextBox id="TxtAnno" Width="83px" Visible="true" Runat="server"></asp:TextBox>
												<asp:RequiredFieldValidator id="rfvAnno" runat="server" ErrorMessage="Il campo Anno è obbligatorio" ControlToValidate="TxtAnno"
													Display="None"></asp:RequiredFieldValidator>
												<asp:CompareValidator id="cvAnno" runat="server" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
													ControlToValidate="TxtAnno" Display="None" Type="Integer" Operator="GreaterThan" ValueToCompare="1980"></asp:CompareValidator></TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="LblVisualizza" runat="server" CssClass="label">Visualizza:</asp:Label></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkPianoSosta" runat="server" CssClass="label" Text="Piano sosta" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkParcRiv" runat="server" CssClass="label" Text="Parcometri e rivendite " Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkRicavi" runat="server" CssClass="label" Text="Ricavi" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkAutoparchimetri" runat="server" CssClass="label" Checked="True" text="Autoparchimetri"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkOrganico" runat="server" CssClass="label" Text="Organico" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkSanzioni" runat="server" CssClass="label" Text="Sanzioni sosta" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkParcometri" runat="server" CssClass="label" Text="Parcometri" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkNote" runat="server" CssClass="label" Text="Note segnaletica" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkParcheggi" runat="server" CssClass="label" Checked="True" text="Parcheggi"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkCarsharing" runat="server" CssClass="label" Text="Carsharing" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkDepositeria" runat="server" CssClass="label" Text="Depositeria" Checked="True"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkCSRicaviPerUsiInterni" runat="server" CssClass="label" Text="C.S. Ricavi per usi interni"
													Checked="False"></asp:CheckBox></TD>
										</TR>
										<TR>
											<TD>
												<asp:CheckBox id="ChkCSConsumiAziendali" runat="server" CssClass="label" Text="C.S. Consumi aziendali"
													Checked="False"></asp:CheckBox></TD>
										</TR>
									</TABLE>
									<BR>
									<asp:Button id="btnSend" runat="server" CssClass="bottone" Text="Visualizza"></asp:Button></FIELDSET>
								<BR>
							</asp:panel></DIV>
					</td>
					<td>
						<DIV align="center"><asp:panel id="PnlStatistica" runat="server" Width="100%" Visible="false" Height="100%">
								<FIELDSET style="WIDTH: 100%; HEIGHT: 654px"><LEGEND class="label">Statistica Settore 
										SOSTA</LEGEND><IFRAME id=FrmStatistica 
      style="WIDTH: 100%; HEIGHT: 100%" 
      src='<%=STRING.concat("http://zion/ReportServer?%2fAtcReport%2fRptBussm&amp;rc:Toolbar=true", UrlReport()) %>' 
      frameBorder=0 width="100%" height="100%"></IFRAME>
								</FIELDSET>
							</asp:panel></DIV>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
