<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_autoparchimetri.aspx.vb" Inherits="ATCBussm1.wf_autoparchimetri"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_autoparchimetri</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission>
			<table id="Table00" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px">
						<h6>Situzione di magazzino</h6>
						<hr SIZE="1" noShade>
						<table cellSpacing="0" cellPadding="0" width="100%" align="center">
							<tr>
								<td align="left"><asp:label id="LblAcquistiDSI" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNAcquistiDSI" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblVenditeDSI" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNVenditeDSI" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblResiDSI" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNResiDSI" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblRimanenzeDSI" runat="server" CssClass="label"></asp:label></td>
								<td align="right"><asp:label id="LblNRimanenzeDSI" runat="server" CssClass="label"></asp:label></td>
							</tr>
							<tr>
								<td align="left"><asp:label id="LblAcquistiStd" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNAcquistiStd" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblVenditeStd" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNVenditeStd" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblResiStd" runat="server" CssClass="label"></asp:label></td>
								<td style="PADDING-RIGHT: 40px" align="right"><asp:label id="LblNResiStd" runat="server" CssClass="label"></asp:label></td>
								<td align="left"><asp:label id="LblRimanenzeStd" runat="server" CssClass="label"></asp:label></td>
								<td align="right"><asp:label id="LblNRimanenzeStd" runat="server" CssClass="label"></asp:label></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<br>
			<table id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px">
						<h6>Ricerca</h6>
						<hr SIZE="1" noShade>
						<asp:checkbox id="ChkSoloAttivi" Runat="server" Checked="True" Text="Solo attivi"></asp:checkbox><asp:textbox id="txtFake" runat="server" Height="2px" Width="0px"></asp:textbox><asp:validationsummary id="vsErrori" runat="server" CssClass="error" Width="100%" HeaderText="Attenzione!"></asp:validationsummary><asp:panel id="pnlRicercaSemplice" runat="server">
<asp:label id="lblCerca" runat="server" AssociatedControlID="txtCerca">Cerca:</asp:label>
<asp:textbox id="txtCerca" runat="server"></asp:textbox>
<asp:dropdownlist id="ddlModifier" runat="server">
								<asp:ListItem Value="0" Selected="True">Almeno una parola</asp:ListItem>
								<asp:ListItem Value="1">Tutte le parole</asp:ListItem>
							</asp:dropdownlist>
<asp:button id="btnCerca" runat="server" CssClass="bottone" Text="Cerca"></asp:button>
<asp:LinkButton id="lnkRicercaAvanzata" runat="server">Ricerca avanzata &raquo;</asp:LinkButton>&nbsp; 
      &nbsp; &nbsp; 
<asp:linkbutton id="lnkAnnullaRicerca" runat="server">Annulla ricerca &raquo;</asp:linkbutton></asp:panel><asp:panel id="pnlRicercaAvanzata" runat="server" Visible="False">
							<asp:Label id="lblDataDa" runat="server" Width="100px" AssociatedControlID="txtDataDa">Data vendita da:</asp:Label>
							<asp:TextBox id="txtDataDa" runat="server" Width="90px"></asp:TextBox>
							<asp:Label id="lblDataA" runat="server" Width="100px" AssociatedControlID="txtDataA">Data vendita a:</asp:Label>
							<asp:TextBox id="txtDataA" runat="server" Width="90px"></asp:TextBox>
							<asp:CompareValidator id="cvDataA1" runat="server" ErrorMessage='Il campo "Data vendita a" deve contenere una data valida'
								ControlToValidate="txtDataA" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataA" runat="server" ErrorMessage='Il campo "Data vendita a" deve contenere una data maggiore o uguale a quella del campo "Vendita data da"'
								ControlToValidate="txtDataA" Type="Date" Operator="GreaterThanEqual" Display="None" ControlToCompare="txtDataDa"></asp:CompareValidator>
							<asp:CompareValidator id="cvDataDa" runat="server" ErrorMessage='Il campo "Data vendita da" deve contenere una data valida'
								ControlToValidate="txtDataDa" Type="Date" Operator="DataTypeCheck" Display="None"></asp:CompareValidator>
							<asp:LinkButton id="lnkRicercaSemplice" runat="server">&laquo; Torna alla ricerca semplice</asp:LinkButton>
							<asp:Button id="btnRicercaAvanzata" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
						</asp:panel></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<br>
			<table id="Table02" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Autoparchimetri
							<asp:label id=lblCount runat="server" CssClass="label" Text='<%# "(trovati " &amp; dvUtenti.Count() &amp; ")" %>'>
							</asp:label>-<asp:label id="lblInfVendite" runat="server" CssClass="label" Text=""></asp:label>
							<asp:button id="btnAdd2" runat="server" CssClass="Bottone" Width="200px" text="Nuovo utente autoparchimetri »"></asp:button></h6>
						<hr SIZE="1" noShade>
						<asp:datagrid id=adgUtenti runat="server" CssClass="grid" Width="100%" Visible="<%# dvUtenti.Count > 0 %>" DataSource="<%# dvUtenti %>" DataKeyField="ID" GridLines="None" UseAccessibleHeader="True" AutoGenerateColumns="False" AllowPaging="True" PagerStyle-Visible="<%# dvUtenti.Count > adgUtenti.PageSize %>" OnItemCommand="adgUtenti_ItemCommand">
							<Columns>
								<asp:TemplateColumn HeaderText="Attiva">
									<ItemTemplate>
										<asp:CheckBox ID="chkAttiva" enabled= "False" Runat = "server" Checked = '<%# DataBinder.Eval(Container, "DataItem.ATTIVA") %>'>
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Cognome">
									<ItemTemplate>
										<asp:LinkButton id="lnkCognome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.COGNOME") %>' CommandName="Navigate">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="NOME" SortExpression="NOME" HeaderText="Nome"></asp:BoundColumn>
								<asp:BoundColumn DataField="VIA" SortExpression="VIA" HeaderText="Indirizzo"></asp:BoundColumn>
								<asp:BoundColumn DataField="NUMEROVIA" SortExpression="NUMEROVIA" HeaderText="Civico"></asp:BoundColumn>
								<asp:BoundColumn DataField="CITTA" SortExpression="CITTA" HeaderText="Citt&#224;">
									<ItemStyle Wrap="False"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="CAP" SortExpression="CAP" HeaderText="CAP"></asp:BoundColumn>
								<asp:BoundColumn DataField="TIPO" SortExpression="TIPO" HeaderText="Tipo"></asp:BoundColumn>
								<asp:BoundColumn DataField="MATAUTO" SortExpression="MATAUTO" HeaderText="Mat. Autop."></asp:BoundColumn>
								<asp:BoundColumn DataField="DATAVENDITA" SortExpression="DATAVENDITA" ReadOnly="True" HeaderText="Data Vend."
									DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:BoundColumn DataField="DATARESO" SortExpression="DATARESO" ReadOnly="True" HeaderText="Data Reso"
									DataFormatString="{0:d}"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:LinkButton id="Button1" runat="server" Text="+&nbspAutop.&nbsp&raquo;" CssClass="bottone" CommandName="Navigate"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:LinkButton id="lbtReso" runat="server" CssClass="bottone" Text="Reso&nbsp»" CommandName="Navigate"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:LinkButton id="lbDelete" runat="server" CssClass="LnkbuttonImage" BorderStyle="None" CommandName="Delete">
											<img src="images/delete.png" width="16px" height="16px" border="none" /></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:LinkButton id="LnkAttiva" runat="server" CssClass ="LnkbuttonImage" Visible='<%# not DataBinder.Eval(Container, "DataItem.ATTIVA") %>' CommandName="Attiva" >
											<img src="images/activate.gif" alt="Attiva" border="none" /></asp:LinkButton>
										<asp:LinkButton id="LnkDisattiva" runat="server" CssClass ="LnkbuttonImage" Visible='<%#  DataBinder.Eval(Container, "DataItem.ATTIVA") %>' CommandName="Disattiva" >
											<img src="images/deactivate.gif" alt="Disattiva" border="none" /></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:label id=lblNoAutoparchimetri runat="server" CssClass="label" Visible="<%# dvUtenti.Count <= 0 %>">Non sono presenti voci che soddisfano i criteri di ricerca selezionati.</asp:label>
						<hr SIZE="1" noShade>
						<asp:button id="btnAddAuto" runat="server" CssClass="Bottone" Text="Nuovo utente autoparchimetri »"
							Width="200px"></asp:button></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
