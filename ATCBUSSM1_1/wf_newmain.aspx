<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_newmain.aspx.vb" Inherits="ATCBussm1.wf_newmain"%>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ATC ISPortal - main window 2020</title>
		<script language="javascript">
      function LoadPage(strUrl)
      {
        //document.frames.fraModule.location.href = strUrl;
        alert(strUrl);
      }
			function HideToc() 
			{
				document.getElementById("btnShowToc").style.display = "inline";
				document.getElementById("btnHideToc").style.display = "none";
				document.getElementById("tdMenu").style.display = "none";
			}
			function ShowToc() 
			{
				document.getElementById("btnShowToc").style.display = "none";
				document.getElementById("btnHideToc").style.display = "inline";
				document.getElementById("tdMenu").style.display = "block";
			}
		</script>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bottomMargin="0" bgColor="#ffffff" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="100%" cellSpacing="0" cellPadding="0" width="100%">
				<tr>
					<td colSpan="2">
						<table width="100%" align="left" cellSpacing="0" cellPadding="0" style="BORDER-BOTTOM: #cccccc 1px solid">
							<tr>
								<td class="Header" colSpan="8">
									<IMG src="images/logo_TPER.gif">
								</td>
							</tr>
							<tr>
								<td class="Header2" width="16" valign="middle"><IMG id="btnShowToc" style="DISPLAY: none" onclick="ShowToc()" src="images/showtoc.gif"><IMG id="btnHideToc" onclick="HideToc()" src="images/hidetoc.gif"></td>
								<td class="Header2" nowrap><asp:label id="Label1" runat="server" CssClass="label">Apri / Chiudi menù</asp:label></td>
								<td class="Header2" align="right" width="10%">Utente:&nbsp;
								</td>
								<td class="Header2" align="left" width="25%"><asp:label id="lblUserName" Runat="server"></asp:label></td>
								<td class="Header2" align="right" width="15%">Ultimo accesso:&nbsp;
								</td>
								<td class="Header2" align="left" width="25%"><asp:label id="lblLastAccess" Runat="server"></asp:label></td>
								<td class="Header2" align="right" width="25%"><IMG style="MARGIN: 0px" src="images/qlink_angolo.gif"></td>
								<td id="tdLogout">
									<div class="Logout"><asp:LinkButton id="lnkLogout" runat="server">Logout &raquo;</asp:LinkButton>&nbsp;</div>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr vAlign="top" height="100%">
					<td id="tdMenu">
						<table id="TableMenu" cellSpacing="0" cellPadding="0" width="100%" align="center" height="100%">
							<tr>
								<td style="HEIGHT: 4px; VERTICAL-ALIGN: top"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
										src="images/corner_tl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
										src="images/corner_tr.gif" width="4" align="right"></td>
							</tr>
							<tr>
								<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
									valign="top">
									<h6>Menù</h6>
									<hr noshade size="1">
									<iewc:treeview id="tvw" runat="server" SelectExpands="True" ShowLines="False" SelectedStyle="background-color:#dddddd;color:black;border:1px solid #999999;padding:2px;"
										Indent="10" DefaultStyle="background-color:transparent;font-family:verdana;font-size:8pt;padding:3px;color:black;"
										HoverStyle="text-decoration:none;background-color:#eeeeee;color:black;border:1px solid @999999;padding:2px;"
										BorderColor="Transparent" BackColor="Transparent" BorderStyle="None"></iewc:treeview>
									<hr noShade SIZE="1">
								</td>
							</tr>
							<tr>
								<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
										src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
										src="images/corner_br.gif" width="4" align="right"></td>
							</tr>
						</table>
					</td>
					<td width="98%"><iframe id="fraModule" name="fraModule" src="wf_welcome.aspx" frameBorder="0" width="100%"
							height="100%" style="Z-INDEX: 0"></iframe>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
