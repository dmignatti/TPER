<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_StoricoSettoreSosta.aspx.vb" Inherits="ATCBussm1.wf_StoricoSettoreSosta"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_StoricoSettoreSosta</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmStoricoSettoreSosta" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSDatiSintesi" runat="server" DESIGNTIMEDRAGDROP="459" HeaderText="Attenzione!"
					Width="100%"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Visible="TRUE">
					<TABLE class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
						<TR>
							<TD style="HEIGHT: 21px"><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
									width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
									width="4" align="right"></TD>
						</TR>
						<TR>
							<TD style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px">
								<H6>Aggiorna storico&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								</H6>
								<HR noShade SIZE="1">
								<asp:Label id="LblMese" runat="server" AssociatedControlID="CboMese" CssClass="label">Mese:</asp:Label>
								<asp:DropDownList id="CboMese" runat="server" CssClass="label" AutoPostBack="true">
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
								</asp:DropDownList>
								<asp:Label id="lblAnno" runat="server" CssClass="label">&nbsp;&nbsp;Anno:</asp:Label>
								<asp:TextBox id="txtAnno" runat="server"></asp:TextBox>
								<asp:Button id="btnASPianoSosta" runat="server" CssClass="bottone" Text="Aggiorna storico piano sosta"></asp:Button>
								<asp:RequiredFieldValidator id="rfvAnno" runat="server" Font-Size="Smaller" ErrorMessage="Il campo Anno è obbligatorio."
									Display="None" ControlToValidate="txtAnno"></asp:RequiredFieldValidator>
								<asp:CompareValidator id="cvAnno" runat="server" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
									Display="None" ControlToValidate="txtAnno" Operator="GreaterThanEqual" ValueToCompare="1980" Type="Integer"></asp:CompareValidator></TD>
						</TR>
						<TR>
							<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
									src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
									src="images/corner_br.gif" width="4" align="right">
								<asp:Label id="lblAggPianoSostaOk" runat="server" CssClass="label">Aggiornamento dello storico del piano sosta eseguito con successo.</asp:Label></TD>
						</TR>
					</TABLE>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
