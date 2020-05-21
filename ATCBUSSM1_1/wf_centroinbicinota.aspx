<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_centroinbicinota.aspx.vb" Inherits="ATCBussm1.wf_centroinbicinota"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_centroinbicinota</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission><INPUT id="txtID" type="hidden" name="txtID" runat="server">
			<table class="Back" id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Nota</h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" HeaderText="Attenzione!" Width="100%" CLASS="error"></asp:validationsummary>
						<div>
							<asp:Label id="LblData" runat="server" AssociatedControlID="txtData" Width="60px">Data:</asp:Label><br>
							<asp:TextBox Width="160px" id="txtData" runat="server"  Text='<%# format(DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici_Note].DefaultView.[0].Data"),"dd/MM/yyyy") %>'>
							</asp:TextBox>
							<asp:CompareValidator id="cvData" runat="server" ErrorMessage='Il campo "Data" deve contenere una data valida'
								ControlToValidate="txtData" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
						</div>
						<div>
							<asp:label id="lblTipoNota" runat="server" AssociatedControlID="ddlTipoNota" Width="60px">Tipo:</asp:label><br>
							<asp:dropdownlist id=ddlTipoNota runat="server" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_TipoNota" DataTextField="Tipo" DataValueField="IdTipoNota" SelectedValue='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici_Note].DefaultView.[0].IdTipoNota") %>'>
							</asp:dropdownlist></div>
						<div>
							<asp:Label id="lblNota" runat="server" AssociatedControlID="txtNota" Width="60px">Nota:</asp:Label><br>
							<asp:TextBox Width="100%" id="txtNota" runat="server" TextMode="MultiLine" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici_Note].DefaultView.[0].Nota") %>'>
							</asp:TextBox></div>
						<hr noShade SIZE="1">
						<asp:LinkButton id="lnkBack" runat="server">&laquo; Torna alle note</asp:LinkButton>&nbsp;
						<asp:Button id="btnSalva" runat="server" Text="Salva" CssClass="bottone"></asp:Button></td>
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
