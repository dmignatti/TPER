<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_NuovoCongedo.aspx.vb" Inherits="ATCBussm1.wf_NuovoCongedo"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_NuovoCongedo</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblNomeAccertatore" runat="server">Accertatore:</asp:label><asp:label id="lblAccertatore" runat="server"></asp:label><asp:label id="lblLabelFerie" runat="server">Giorni di ferie disponibili:</asp:label><asp:label id="lblFerie" runat="server"></asp:label><asp:label id="lblLabelAnticipoFerie" runat="server">Giorni di ferie anticipabili:</asp:label><asp:label id="lblAnticipoFerie" runat="server"></asp:label><br>
			<fieldset>
				<legend>
					Ricerca periodo</legend>
				<asp:label id="lblDa" runat="server">Visualizza richieste da:</asp:label><asp:textbox id="txtDa" runat="server"></asp:textbox><asp:label id="lblA" runat="server">a:</asp:label><asp:textbox id="txtA" runat="server"></asp:textbox><asp:button id="btnSearch" runat="server" Text="Visualizza"></asp:button>
				<asp:DataGrid id="dgRisultati" runat="server" Width="100%"></asp:DataGrid>
			</fieldset>
			<fieldset><legend>Richiesta</legend><asp:label id="lblNote" runat="server">Per inserire un permesso solo di alcune ore, immettere la stessa data nel campo "dal giorno" e nel campo "al giorno"</asp:label><asp:validationsummary id="vsErrors" runat="server" Width="100%" HeaderText="Si sono verificati i seguenti errori:"></asp:validationsummary><br>
				<br>
				<br>
				<asp:table id="Table1" runat="server">
					<asp:TableRow>
						<asp:TableCell>
							<asp:Label id="lblDalGiorno" runat="server" AssociatedControlID="txtDalGiorno">dal giorno:</asp:Label>
						</asp:TableCell>
						<asp:TableCell>
							<asp:Label id="lblAlGiorno" runat="server" AssociatedControlID="txtAlGiorno">al giorno:</asp:Label>
						</asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell>
							<asp:TextBox id="txtDalGiorno" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator ControlToValidate="txtDalGiorno" id="rfvDalGiorno" runat="server" Display="None"
								ErrorMessage='Il campo "dal giorno" è obbligatorio'></asp:RequiredFieldValidator>
						</asp:TableCell>
						<asp:TableCell>
							<asp:TextBox id="txtAlGiorno" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator ControlToValidate="txtAlGiorno" id="rfvAlGiorno" runat="server" Display="None" ErrorMessage='Il campo "al giorno" è obbligatorio'></asp:RequiredFieldValidator>
						</asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell>
							<asp:Label id="lblDalleOre" runat="server" AssociatedControlID="txtDalleOre">dalle ore:</asp:Label>
						</asp:TableCell>
						<asp:TableCell>
							<asp:Label id="lblAlleOre" runat="server" AssociatedControlID="txtAlleOre">alle ore</asp:Label>
						</asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell>
							<asp:TextBox id="txtDalleOre" runat="server"></asp:TextBox>
						</asp:TableCell>
						<asp:TableCell>
							<asp:TextBox id="txtAlleOre" runat="server"></asp:TextBox>
						</asp:TableCell>
					</asp:TableRow>
				</asp:table>
				<hr noShade SIZE="1">
				<div align="right"><asp:button id="btnAnnulla" runat="server" Text="Annulla richiesta"></asp:button><asp:button id="btnSalva" runat="server" Text="Invia richiesta"></asp:button></div>
			</fieldset>
			<asp:customvalidator id="cvPermessoOrario" runat="server" ErrorMessage='Per inserire un permesso orario i campi "dal giorno" e "al giorno" devono contenere la stessa data'
				Display="None" EnableClientScript="False"></asp:customvalidator><asp:customvalidator id="cvPermessoOrario2" runat="server" ErrorMessage='Per richiedere un permesso orario inserire sia "dalle ore" sia "alle ore"'
				Display="None"></asp:customvalidator><asp:comparevalidator id="cvDalGiorno" runat="server" ErrorMessage='Il campo "dal giorno" deve contenere una data valida'
				Display="None" Type="Date" Operator="DataTypeCheck" ControlToValidate="txtDalGiorno"></asp:comparevalidator><asp:comparevalidator id="cvAlGiorno" runat="server" ErrorMessage='Il campo "al giorno" deve contenere una data valida'
				Display="None" Type="Date" Operator="DataTypeCheck" ControlToValidate="txtAlGiorno"></asp:comparevalidator><asp:comparevalidator id="cvDalAlGiorno" runat="server" ErrorMessage='La data del campo "dal giorno " deve essere precedente o uguale a quella del campo "al giorno"'
				Display="None" ControlToCompare="txtAlGiorno" Operator="LessThanEqual" ControlToValidate="txtDalGiorno"></asp:comparevalidator><asp:customvalidator id="cvPermessoOrario3" runat="server" ErrorMessage="L'ora del campo &quot;dalle ore&quot; deve essere precedente a quella del campo &quot;alle ore&quot;"
				Display="None"></asp:customvalidator><asp:customvalidator id="cvMinimoFerie" runat="server" ErrorMessage="Il periodo di ferie minimo è di {0:d} giorni"
				Display="None"></asp:customvalidator><asp:customvalidator id="cvMassimoFerie" runat="server" ErrorMessage="Il periodo di ferie massimo è di {0:d} giorni"
				Display="None"></asp:customvalidator><br>
		</form>
	</body>
</HTML>
