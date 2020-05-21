<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_centroinbici.aspx.vb" Inherits="ATCBussm1.wf_centroinbici" smartNavigation="True"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_centroinbici</title>
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
        //alert(document.getElementById('ChkStudente').checked);

       if (document.getElementById('ChkComune').checked){
			//window.open('http://zion/ReportServer?%2fAtcReport%2fRptCentroInBiciComune&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
			window.open('http://appmob/ReportServer?%2fAtcReport%2fRptCentroInBiciComune&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
       }
       else
       {
			if (document.getElementById('ChkStudente').checked){
//				window.open('http://zion/ReportServer?%2fAtcReport%2fRptCentroInBiciStudenti&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
				window.open('http://appmob/ReportServer?%2fAtcReport%2fRptCentroInBiciStudenti&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
			}
			else
			{
				if (document.getElementById('ChkPendolare').checked){
	//				window.open('http://zion/ReportServer?%2fAtcReport%2fRptCentroInBiciStudenti&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
					window.open('http://appmob/ReportServer?%2fAtcReport%2fRptCentroInBiciPendolare&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
				}
				else
				{
					//window.open('http://zion/ReportServer?%2fAtcReport%2fRptCentroInBici&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
					window.open('http://appmob/ReportServer?%2fAtcReport%2fRptCentroInBici&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
				}
				//window.open('http://zion/ReportServer?%2fAtcReport%2fRptCentroInBici&amp;ID=' + id + '&rs%3aCommand=Render&rs%3AFormat=PDF','rel')
			}
        }
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>C'entro in bici - Dati generali</h6>
						<hr noShade SIZE="1">
						<asp:textbox id=TxtIdUtente runat="server" Visible="false" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].IdUtente") %>'>
						</asp:textbox><asp:label id="LblCauzioen" runat="server" Width="100px" AssociatedControlID="txtCauzione">Cauzione</asp:label><asp:textbox id=txtCauzione runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].Cauzione") %>'></asp:textbox><asp:requiredfieldvalidator id="Requiredfieldvalidator1" runat="server" ControlToValidate="txtNome" Display="None"
							ErrorMessage='Il campo "Nome" è obbligatorio'></asp:requiredfieldvalidator>&nbsp;
					</td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>C'entro in bici - Anagrafica dell'intestatario</h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Attenzione!" CssClass="Error"></asp:validationsummary>
						<div noWrap><asp:label id="lblChiave" runat="server" Width="100px" AssociatedControlID="txtChiave">Chiave</asp:label><asp:textbox id=txtChiave runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].CHIAVE") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvChiave" runat="server" ControlToValidate="txtChiave" Display="None" ErrorMessage='Il campo "Chiave" è obbligatorio'></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="revChiave" runat="server" ControlToValidate="txtChiave" Display="None" ErrorMessage="Il codice della chiave deve essere composto da 2 lettere e 3 numeri"
								ValidationExpression="\w{2}\d{3}"></asp:regularexpressionvalidator>&nbsp;
							<asp:checkbox id=ChkStudente Runat="server" AutoPostBack="True" Checked='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].STUDENTE") %>' Text="Studente/personale universitario" TextAlign="Left">
							</asp:checkbox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:checkbox id=ChkComune Runat="server"  AutoPostBack="True" Checked='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].COMUNE") %>' Text="Dipendente comune di Bologna" TextAlign="Left"></asp:checkbox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:checkbox id=ChkPendolare Runat="server" AutoPostBack="True" Checked='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].PENDOLARE") %>' Text="Pendolare" TextAlign="Left"></asp:checkbox><BR>
							<asp:label id="lblCognome" runat="server" Width="100px" AssociatedControlID="txtCognome">Cognome</asp:label><asp:textbox id=txtCognome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].COGNOME") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCognome" runat="server" ControlToValidate="txtCognome" Display="None" ErrorMessage='Il campo "Cognome" è obbligatorio'></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblNome" runat="server" Width="100px" AssociatedControlID="txtNome">Nome</asp:label><asp:textbox id=txtNome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].NOME") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvNome" runat="server" ControlToValidate="txtNome" Display="None" ErrorMessage='Il campo "Nome" è obbligatorio'></asp:requiredfieldvalidator><BR>
							<asp:label id="lblDataNascita" runat="server" Width="100px" AssociatedControlID="txtDataNascita">Data di nascita</asp:label><asp:textbox id=txtDataNascita runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DATA_NASCITA", "{0:d}") %>' ToolTip="Formato della data: gg/mm/aaaa"></asp:textbox><asp:requiredfieldvalidator id="rfvDataNascita" runat="server" ControlToValidate="txtDataNascita" Display="None"
								ErrorMessage='Il campo "Data di nascita" è bbligatorio'></asp:requiredfieldvalidator><asp:comparevalidator id="cvDataNascita" runat="server" ControlToValidate="txtDataNascita" Display="None"
								ErrorMessage='Il campo "Data di nascita" non è una data valida' Operator="DataTypeCheck" Type="Date"></asp:comparevalidator><asp:label id="Label2" runat="server" AssociatedControlID="txtDataNascita">(gg/mm/aaaa)</asp:label></div>
						<br>
						<h6>Indirizzo di residenza</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblResidenzaVia" runat="server" Width="100px" AssociatedControlID="txtResidenzaVia"> Via</asp:label><asp:textbox id=txtResidenzaVia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_VIA") %>' Width="384px"></asp:textbox><asp:requiredfieldvalidator id="rfvVia" runat="server" ControlToValidate="txtResidenzaVia" Display="None" ErrorMessage="Il campo &quot;Via&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaCivico" runat="server" Width="100px" AssociatedControlID="txtResidenzaCivico">Civico</asp:label><asp:textbox id=txtResidenzaCivico runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_N_CIV") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCivico" runat="server" ControlToValidate="txtResidenzaCivico" Display="None"
								ErrorMessage="Il campo &quot;Civico&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator></div>
						<div noWrap><asp:label id="lblResidenzaCap" runat="server" Width="100px" AssociatedControlID="txtResidenzaCAP">CAP</asp:label><asp:textbox id=txtResidenzaCAP runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_CAP") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvCAP" runat="server" ControlToValidate="txtResidenzaCAP" Display="None" ErrorMessage="Il campo &quot;CAP&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaComune" runat="server" Width="100px" AssociatedControlID="txtResidenzaComune">Comune</asp:label><asp:textbox id=txtResidenzaComune runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_CIT") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvComune" runat="server" ControlToValidate="txtResidenzaComune" Display="None"
								ErrorMessage="Il campo &quot;Comune&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblResidenzaProvincia" runat="server" Width="100px" AssociatedControlID="txtResidenzaProvincia">Provincia</asp:label><asp:textbox id=txtResidenzaProvincia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_PROV") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvProvincia" runat="server" ControlToValidate="txtResidenzaProvincia" Display="None"
								ErrorMessage="Il campo &quot;Provincia&quot; dell'indirizzo di residenza è obbligatorio"></asp:requiredfieldvalidator></div>
						<div noWrap><asp:label id="lblFisso" runat="server" Width="100px" AssociatedControlID="txtFisso">Tel. fisso</asp:label><asp:textbox id=txtFisso runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].TEL") %>'></asp:textbox>&nbsp;
							<asp:label id="lblCellulare" runat="server" Width="100px" AssociatedControlID="txtCellulare">Cellulare</asp:label><asp:textbox id=txtCellulare runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].CEL") %>'></asp:textbox></div>
						<% if NOT(ChkPendolare.Checked) then
						%>
						<br>
						<h6>Indirizzo del domicilio (solo se non residente a Bologna)</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblDomicilioVia" runat="server" Width="150px" AssociatedControlID="txtDomicilioVia">Via</asp:label><asp:textbox id=txtDomicilioVia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOM_VIA") %>' Width="384px"></asp:textbox><asp:requiredfieldvalidator id="rfvDomicilioVia" runat="server" ControlToValidate="txtDomicilioVia" Display="None"
								ErrorMessage="Il campo &quot;Via&quot; dell'indirizzo di domicilio è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblDomicilioCivico" runat="server" Width="100px" AssociatedControlID="txtDomicilioCivico">Civico</asp:label><asp:textbox id=txtDomicilioCivico runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOM_N_CIV") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvDomicilioCivico" runat="server" ControlToValidate="txtDomicilioCivico" Display="None"
								ErrorMessage="Il campo &quot;Civico&quot; dell'indirizzo di domicilio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator></div>
						<div noWrap><asp:label id="lblDomicilioCAP" runat="server" Width="150px" AssociatedControlID="txtDomicilioCAP">CAP</asp:label><asp:textbox id=txtDomicilioCAP runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOM_CAP") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvDomicilioCAP" runat="server" ControlToValidate="txtDomicilioCAP" Display="None"
								ErrorMessage="Il campo &quot;CAP&quot; dell'indirizzo di domicilio è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblDomicilioComune" runat="server" Width="100px" AssociatedControlID="txtDomicilioComune">Comune</asp:label><asp:textbox id=TxtDomicilioComune runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOM_CIT") %>'></asp:textbox>&nbsp;
							<asp:label id="lblDomicilioProvincia" runat="server" Width="100px" AssociatedControlID="txtDomicilioProvincia">Provincia</asp:label><asp:textbox id=txtDomicilioProvincia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOM_PROV") %>' Enabled="False"></asp:textbox></div>
						<HR width="100%" SIZE="1">
						<BR>
						<% end if
						%>
						<% if (ChkPendolare.Checked) then
						%>
						<HR width="100%" SIZE="1">
						<BR>
						<h6>Abbonamento</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="LblNumAbbonamento" runat="server" Width="144px" AssociatedControlID="txtNumeroAbbonamento">Numero abbonamento</asp:label><asp:textbox id=txtNumeroAbbonamento runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].ABBONAMENTO_NUM") %>'></asp:textbox><asp:requiredfieldvalidator id="RfvNAbbonamento" runat="server" ControlToValidate="txtNumeroAbbonamento" Display="None"
								ErrorMessage='Il campo "Numero" abbonamento è obbligatorio' Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;<asp:label id="LblOrigine" runat="server" Width="83px" AssociatedControlID="ddlOrigineAbbonamento">Rilasciato da</asp:label><asp:dropdownlist id=ddlOrigineAbbonamento runat="server" Width="137px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_OrigineAbbonamento" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="RfvddlOrigineAbbonamento" runat="server" ControlToValidate="ddlOrigineAbbonamento"
								Display="None" ErrorMessage='Il campo "Rilasciato da" abbonamento è obbligatorio' Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="Label3" runat="server" Width="50px" AssociatedControlID="txtAltro">Altro</asp:label><asp:textbox id=TxtAltro runat="server" Width="200"  Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].ABBONAMENTO_ALTRO") %>'></asp:textbox>&nbsp;</div>
						<div noWrap><asp:label id="LblTipoAbb" runat="server" Width="50px" AssociatedControlID="ddlTipoAbbonamento">Tipo</asp:label><asp:dropdownlist id=ddlTipoAbbonamento runat="server" Width="100px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_TipoAbbonamento" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="RfvddlTipoAbbonamento" runat="server" ControlToValidate="ddlTipoAbbonamento"
								Display="None" ErrorMessage='Il campo "Tipo" abbonamento è obbligatorio' Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="LblDurata" runat="server" Width="50px" AssociatedControlID="ddldurata">Durata</asp:label><asp:dropdownlist id=ddldurata runat="server" Width="100px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_DurataAbbonamento" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="Rfvddldurata" runat="server" ControlToValidate="ddldurata" Display="None" ErrorMessage='Il campo "Durata" abbonamento è obbligatorio'
								Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;<asp:label id="lblTratta" runat="server" Width="50px" AssociatedControlID="txtTratta">Tratta</asp:label><asp:textbox id=txtTratta Width="400px" runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].ABBONAMENTO_TRATTA") %>'></asp:textbox><asp:requiredfieldvalidator id="RfvTratta" runat="server" ControlToValidate="txtTratta" Display="None" ErrorMessage='Il campo "Tratta" abbonamento è obbligatorio'
								Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>
						</div>
						<HR width="100%" SIZE="1">
						<BR>
						<% end if
						%>
						<h6>Documento di identità</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblTipoDocumento" runat="server" Width="100px" AssociatedControlID="ddlTipoDocumento">Tipo</asp:label><asp:dropdownlist id=ddlTipoDocumento runat="server" Width="137px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_TipoDocumento" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="rfvTipoDocumento" runat="server" ControlToValidate="ddlTipoDocumento" Display="None"
								ErrorMessage="Il campo &quot;Tipo&quot; del documento d'identità è obbligatorio"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblNumeroDocumento" runat="server" Width="100px" AssociatedControlID="txtNumeroDocumento">Numero</asp:label><asp:textbox id=txtNumeroDocumento runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].DOCUMENTO_NUM") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvNumeroDocumento" runat="server" ControlToValidate="txtNumeroDocumento" Display="None"
								ErrorMessage="Il campo &quot;Numero&quot; del documento d'identità è obbligatorio"></asp:requiredfieldvalidator><br>
							<hr noShade SIZE="1">
							<asp:linkbutton id="lnkBack" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;
							<asp:button id="btnSalva" runat="server" Text="Salva" CssClass="bottone"></asp:button>&nbsp;<A id="lkStampa" onclick="Stampa()" href="javascript:;" runat="server">Stampa</A></div>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
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
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; HEIGHT: 178px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Anagrafica del contraente (solo se l'intestatario è minorenne)</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblParenteParentela" runat="server" Width="100px" AssociatedControlID="ddlParenteParentela">Parentela</asp:label><asp:dropdownlist id=ddlParenteParentela runat="server" Width="137px" DataSource="<%# DsBiglietterie1 %>" DataMember="CentroInBici_Parentela" DataTextField="Descrizione" DataValueField="Id"></asp:dropdownlist><asp:requiredfieldvalidator id="rfvParentela" runat="server" ControlToValidate="ddlParenteParentela" Display="None"
								ErrorMessage="Il campo &quot;Parentela&quot; dell'anagrafica del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblParenteCognome" runat="server" Width="100px" AssociatedControlID="txtParenteCognome">Cognome</asp:label><asp:textbox id=txtParenteCognome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].COGNOME_PARENTE") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteCognome" runat="server" ControlToValidate="txtParenteCognome" Display="None"
								ErrorMessage="Il campo &quot;Cognome&quot; dell'anagrafica del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblParenteNome" runat="server" Width="100px" AssociatedControlID="txtParenteNome">Nome</asp:label><asp:textbox id=txtParenteNome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].NOME_PARENTE") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteNome" runat="server" ControlToValidate="txtParenteNome" Display="None"
								ErrorMessage="Il campo &quot;Nome&quot; dell'anagrafica del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator></div>
						<br>
						<h6>Indirizzo di residenza</h6>
						<hr noShade SIZE="1">
						<div noWrap><asp:label id="lblParenteVia" runat="server" Width="100px" AssociatedControlID="txtParenteVia"> Via</asp:label><asp:textbox id=txtParenteVia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_VIA_P") %>' Width="384px"></asp:textbox><asp:requiredfieldvalidator id="rfvParenteVia" runat="server" ControlToValidate="txtParenteVia" Display="None"
								ErrorMessage="Il campo &quot;Via&quot; dell'indirizzo di residenza del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblParenteCivico" runat="server" Width="100px" AssociatedControlID="txtParenteCivico">Civico</asp:label><asp:textbox id=txtParenteCivico runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_N_CIV_P") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteCivico" runat="server" ControlToValidate="txtParenteCivico" Display="None"
								ErrorMessage="Il campo &quot;Civico&quot; dell'indirizzo del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator></div>
						<div noWrap><asp:label id="lblParenteCAP" runat="server" Width="100px" AssociatedControlID="txtParenteCAP">CAP</asp:label><asp:textbox id=txtParenteCAP runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_CAP_P") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteCAP" runat="server" ControlToValidate="txtParenteCAP" Display="None"
								ErrorMessage="Il camp &quot;CAP&quot; dell'indirizzo del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblParenteComune" runat="server" Width="100px" AssociatedControlID="txtParenteComune">Comune</asp:label><asp:textbox id=TxtParenteComune runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_CIT_P") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteComune" runat="server" ControlToValidate="txtParenteComune" Display="None"
								ErrorMessage="Il campo &quot;Comune&quot; dell'indirizzo del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator>&nbsp;
							<asp:label id="lblParenteProvincia" runat="server" Width="100px" AssociatedControlID="txtParenteProvincia">Provincia</asp:label><asp:textbox id=txtParenteProvincia runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[CentroInBici].DefaultView.[0].RES_PROV_P") %>'></asp:textbox><asp:requiredfieldvalidator id="rfvParenteProvincia" runat="server" ControlToValidate="txtParenteProvincia"
								Display="None" ErrorMessage="Il campo &quot;Provincia&quot; dell'indirizzo del contraente è obbligatorio" Enabled="False" EnableClientScript="False"></asp:requiredfieldvalidator></div>
						<HR width="100%" SIZE="1">
						<asp:linkbutton id="lnkBack2" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;
						<asp:button id="btnSalva2" runat="server" Text="Salva" CssClass="bottone"></asp:button><asp:customvalidator id="cvMinorenne" runat="server" Display="None"></asp:customvalidator><asp:customvalidator id="cvDomicilio" runat="server" Display="None"></asp:customvalidator><asp:customvalidator id="cvChiaveGiaAssegnata" runat="server" Display="None" ErrorMessage='Il campo "Chiave" contiene un codice già assegnato'></asp:customvalidator>&nbsp;<A id="lkStampa2" onclick="Stampa()" href="javascript:;" RUNAT="server">Stampa</A></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Allegati</h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgAllegati runat="server" Visible="<%# dvAllegati.Count > 0 %>" Width="100%" CssClass="grid" DataSource="<%# dvAllegati %>" UseAccessibleHeader="True" GridLines="None" DataKeyField="Id" AutoGenerateColumns="False" AllowPaging="True" PageSize="5" PagerStyle-Visible="<%# dvAllegati.Count > dgAllegati.PageSize %>">
							<Columns>
								<asp:TemplateColumn HeaderText="Preview">
									<ItemTemplate>
										<asp:HyperLink id="lnkPreview" runat="server" ImageUrl='<%# "Preview.aspx?ID=" &amp; Server.UrlEncode(DirectCast(DataBinder.Eval(Container, "DataItem.ID"), Guid).ToString()) &amp; "&amp;Prev=1" %>' NavigateUrl='<%# "Preview.aspx?ID=" &amp; Server.UrlEncode(DirectCast(DataBinder.Eval(Container, "DataItem.ID"), Guid).ToString()) &amp; "&amp;Prev=0" %>' Target="_blank">
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
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</TR>
			</table>
		</form>
	</body>
</HTML>
