<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_ammpwdaccertatori.aspx.vb" Inherits="ATCBussm1.wf_ammpwdaccertatori"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ammpwdaccertatori</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="pnlMessage" runat="server" HorizontalAlign="Center" Width="100%" Visible="False">
				<TABLE class="Message" id="Table02" cellSpacing="0" cellPadding="0" align="center">
					<TR>
						<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
								width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
								width="4" align="right"></TD>
					</TR>
					<TR>
						<TD style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
							vAlign="top">
							<asp:Label id="lblMessage" runat="server">Password modificata correttamente.</asp:Label></TD>
					</TR>
					<TR>
						<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
								src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
								src="images/corner_br.gif" width="4" align="right"></TD>
					</TR>
				</TABLE>
				<BR>
			</asp:Panel>
			<table id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG height="4" style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						valign="top">
						<h6>Cambia la password</h6>
						<hr noshade size="1">
						<asp:ValidationSummary id="ValidationSummary1" runat="server" HeaderText="Attenzione. si sono verificati i seguenti errori:"
							Width="100%" CssClass="Error"></asp:ValidationSummary>
						<asp:Label id="lblAccertatore" runat="server" AssociatedControlID="ddlAccertatori" CssClass="label"
							Width="130px"> Accertatore:</asp:Label>
						<asp:DropDownList id="ddlAccertatori" runat="server" Width="137px" DataSource="<%# dvAccertatori %>" DataTextField="IDUser" DataValueField="ID">
						</asp:DropDownList><br>
						<asp:Label id="lblPassword" runat="server" AssociatedControlID="txtPassword" CssClass="label"
							Width="130px">Nuova password:</asp:Label>
						<asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator id="rfvPassword" runat="server" ErrorMessage="Il campo Password � obbligatorio"
							Display="None" ControlToValidate="txtPassword"></asp:RequiredFieldValidator><br>
						<asp:Label id="lblConfermaPassword" runat="server" CssClass="label" AssociatedControlID="txtConfermaPassword"
							Width="130px">Conferma password:</asp:Label>
						<asp:TextBox id="txtConfermaPassword" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator id="rfvConfermaPassword" runat="server" ErrorMessage="Il campo Conferma password � obbligatorio"
							Display="None" ControlToValidate="txtConfermaPassword"></asp:RequiredFieldValidator>
						<asp:CompareValidator id="cvPassword" runat="server" ErrorMessage="La password e la conferma non corrispondono."
							Display="None" ControlToValidate="txtPassword" ControlToCompare="txtConfermaPassword"></asp:CompareValidator>
						<hr noshade size="1">
						<asp:Button id="btnConferma" runat="server" Text="Conferma" CssClass="bottone"></asp:Button>
					</td>
				</tr>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
