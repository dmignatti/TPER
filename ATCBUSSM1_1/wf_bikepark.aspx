<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_bikepark.aspx.vb" Inherits="ATCBussm1.wf_bikepark" smartNavigation="True" %>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_bikepark</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<script language="javascript">
<!--
	function Stampa() 
	{
        var txt = document.getElementById('txtID');
        var id =txt.value;
        window.open('http://zion/ReportServer?%2fAtcReport%2fRptBikePark&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
	}
//-->
		</script>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			&nbsp;<INPUT id="txtID" type="hidden" name="txtID" runat="server">
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Bike park - Dati generali</h6>
						<hr noShade SIZE="1">
						<asp:textbox id=TxtIdUtente runat="server" Visible="false" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].IdUtente") %>'>
						</asp:textbox><asp:label id="LblCauzioen" runat="server" Width="100px" AssociatedControlID="txtCauzione">Cauzione</asp:label><asp:textbox id=txtCauzione runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].Cauzione") %>'></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator1" runat="server" ControlToValidate="txtNome" Display="None"
							ErrorMessage='Il campo "Nome" è obbligatorio'></asp:requiredfieldvalidator>&nbsp;
					</td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Bike park - Anagrafica dell'intestatario</h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Attenzione!" CssClass="Error"></asp:validationsummary>
						<div noWrap><asp:label id="lblTessera" runat="server" Width="100px" AssociatedControlID="txtTessera">Tessera</asp:label><asp:textbox id=txtTessera runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].Tessera") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvTessera" runat="server" ControlToValidate="txtTessera" Display="None" ErrorMessage='Il campo "Tessera" è obbligatorio'></asp:requiredfieldvalidator><BR>
							<asp:label id="lblCognome" runat="server" Width="100px" AssociatedControlID="txtCognome">Cognome</asp:label><asp:textbox id=txtCognome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].COGNOME") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCognome" runat="server" ControlToValidate="txtCognome" Display="None" ErrorMessage='Il campo "Cognome" è obbligatorio'></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblNome" runat="server" Width="100px" AssociatedControlID="txtNome">Nome</asp:label><asp:textbox id=txtNome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].NOME") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvNome" runat="server" ControlToValidate="txtNome" Display="None" ErrorMessage='Il campo "Nome" è obbligatorio'></asp:requiredfieldvalidator><BR>
							<asp:label id="lblDataNascita" runat="server" Width="100px" AssociatedControlID="txtDataNascita">Data di nascita</asp:label><asp:textbox id=txtDataNascita runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].DATA_NASCITA", "{0:d}") %>' ToolTip="Formato della data: gg/mm/aaaa"></asp:textbox><asp:requiredfieldvalidator id="rfvDataNascita" runat="server" ControlToValidate="txtDataNascita" Display="None"
								ErrorMessage='Il campo "Data di nascita" è bbligatorio'></asp:requiredfieldvalidator><asp:comparevalidator id="cvDataNascita" runat="server" ControlToValidate="txtDataNascita" Display="None"
								ErrorMessage='Il campo "Data di nascita" non è una data valida' Operator="DataTypeCheck" Type="Date"></asp:comparevalidator><asp:label id="Label2" runat="server" AssociatedControlID="txtDataNascita">(gg/mm/aaaa)</asp:label></div>
						<br>
						<h6>Indirizzo di residenza</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblResidenzaVia" runat="server" Width="100px" AssociatedControlID="txtResidenzaVia"> Via</asp:label><asp:textbox id=txtResidenzaVia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].RES_VIA") %>' Width="384px"></asp:textbox><asp:requiredfieldvalidator id="rfvVia" runat="server" ControlToValidate="txtResidenzaVia" Display="None" ErrorMessage="Il campo &quot;Via&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaCivico" runat="server" Width="100px" AssociatedControlID="txtResidenzaCivico">Civico</asp:label><asp:textbox id=txtResidenzaCivico runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].RES_N_CIV") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCivico" runat="server" ControlToValidate="txtResidenzaCivico" Display="None"
								ErrorMessage="Il campo &quot;Civico&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator></div>
						<div noWrap><asp:label id="lblResidenzaCap" runat="server" Width="100px" AssociatedControlID="txtResidenzaCAP">CAP</asp:label><asp:textbox id=txtResidenzaCAP runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].RES_CAP") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCAP" runat="server" ControlToValidate="txtResidenzaCAP" Display="None" ErrorMessage="Il campo &quot;CAP&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaComune" runat="server" Width="100px" AssociatedControlID="txtResidenzaComune">Comune</asp:label><asp:textbox id=txtResidenzaComune runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].RES_CIT") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvComune" runat="server" ControlToValidate="txtResidenzaComune" Display="None"
								ErrorMessage="Il campo &quot;Comune&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaProvincia" runat="server" Width="100px" AssociatedControlID="txtResidenzaProvincia">Provincia</asp:label><asp:textbox id=txtResidenzaProvincia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].RES_PROV") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvProvincia" runat="server" ControlToValidate="txtResidenzaProvincia" Display="None"
								ErrorMessage="Il campo &quot;Provincia&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>
							<asp:CustomValidator id="CVProvinciaBO" runat="server" ErrorMessage="La residenza deve essere in provincia di Bologna"
								Display="None" ></asp:CustomValidator></div>
						<div noWrap><asp:label id="lblFisso" runat="server" Width="100px" AssociatedControlID="txtFisso">Tel. fisso</asp:label><asp:textbox id=txtFisso runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].TEL") %>'></asp:textbox>&nbsp;
							<asp:label id="lblCellulare" runat="server" Width="100px" AssociatedControlID="txtCellulare">Cellulare</asp:label><asp:textbox id=txtCellulare runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].CEL") %>'></asp:textbox></div>
						<BR>
						<h6>Documento di identità</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblTipoDocumento" runat="server" Width="100px" AssociatedControlID="ddlTipoDocumento">Tipo</asp:label><asp:dropdownlist id=ddlTipoDocumento runat="server" Width="137px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_TipoDocumento" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="rfvTipoDocumento" runat="server" ControlToValidate="ddlTipoDocumento" Display="None"
								ErrorMessage="Il campo &quot;Tipo&quot; del documento d'identità è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblNumeroDocumento" runat="server" Width="100px" AssociatedControlID="txtNumeroDocumento">Numero</asp:label><asp:textbox id=txtNumeroDocumento runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].DOCUMENTO_NUM") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvNumeroDocumento" runat="server" ControlToValidate="txtNumeroDocumento" Display="None"
								ErrorMessage="Il campo &quot;Numero&quot; del documento d'identità è obbligatorio"></asp:requiredfieldvalidator>
							<asp:label id="lblCodiceFiscale" runat="server" Width="100px" AssociatedControlID="txtCodiceFiscale">Codice fiscale</asp:label>
							<asp:textbox id="txtCodiceFiscale" runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[BikePark].DefaultView.[0].CODICEFISCALE") %>' MaxLength="16">
							</asp:textbox>
							<asp:requiredfieldvalidator id="rfvCodiceFiscale" runat="server" ControlToValidate="txtCodiceFiscale" Display="None"
								ErrorMessage='Il campo "Codice fiscale" è obbligatorio'></asp:requiredfieldvalidator>
							<br>
							<hr noShade SIZE="1">
							<asp:linkbutton id="lnkBack" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;
							<asp:button id="btnSalva" runat="server" Text="Salva" CssClass="bottone"></asp:button>&nbsp;<A id="lkStampa" onclick="Stampa()" href="javascript:;" runat="server">Stampa</A></div>
					</td>
				</tr>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
			<br>
			<table class="Back" id="Table03" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
			</table>
			<br>
			<table class="Back" id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Allegati</h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgAllegati runat="server" Visible="<%# DvAllegatiBP.Count > 0 %>" Width="100%" CssClass="grid" DataSource="<%# DvAllegatiBP %>" PagerStyle-Visible="<%# DvAllegatiBP.Count > dgAllegati.PageSize %>" PageSize="5" AllowPaging="True" AutoGenerateColumns="False" DataKeyField="Id" GridLines="None" UseAccessibleHeader="True">
							<Columns>
								<asp:TemplateColumn HeaderText="Preview">
									<ItemTemplate>
										<asp:HyperLink id="lnkPreview" runat="server" ImageUrl='<%# "PreviewBP.aspx?ID=" &amp; Server.UrlEncode(DirectCast(DataBinder.Eval(Container, "DataItem.ID"), Guid).ToString()) &amp; "&amp;Prev=1" %>' NavigateUrl='<%# "PreviewBP.aspx?ID=" &amp; Server.UrlEncode(DirectCast(DataBinder.Eval(Container, "DataItem.ID"), Guid).ToString()) &amp; "&amp;Prev=0" %>' Target="_blank">
										</asp:HyperLink>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Descrizione">
									<HeaderStyle Width="100%"></HeaderStyle>
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Description") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="txtDescription" runat="server" Width="100%" Text='<%# DataBinder.Eval(Container, "DataItem.Description") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1px"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="Button1" runat="server" Text="Modifica" CausesValidation="false" CssClass="bottone"
											CommandName="Edit"></asp:Button>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Button id="Button3" runat="server" Text="Ok" CausesValidation="False" CssClass="bottone"
											CommandName="Update"></asp:Button>&nbsp;
										<asp:Button id="Button2" runat="server" Text="Annulla" CausesValidation="false" CssClass="bottone"
											CommandName="Cancel"></asp:Button>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1px"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" Text="Elimina" CausesValidation="false" CssClass="bottone"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><asp:label id="lblFileDocumento" runat="server" Width="100px" CssClass="label">Allegato</asp:label><INPUT id="fileDocumento" type="file" name="fileDocumento" runat="server">
						<asp:button id=btnSalva3 runat="server" Text="Allega immagine" CssClass="bottone" Enabled='<%# Len("" &amp; txtID.Value) > 0 %>' CausesValidation="False">
						</asp:button><BR>
						<HR width="100%" SIZE="1">
						<asp:linkbutton id="lnkBack3" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;</td>
				</tr>
				<TR>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</TR>
			</table>
		</form>
	</body>
</HTML>
