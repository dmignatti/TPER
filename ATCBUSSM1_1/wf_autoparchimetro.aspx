<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_autoparchimetro.aspx.vb" Inherits="ATCBussm1.wf_autoparchimetro"%>
<%@ Register TagPrefix="uc1" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_autoparchimetro</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:wc_checkpermission id="Wc_checkpermission1" runat="server"></uc1:wc_checkpermission><INPUT id="txtNumeratore" type="hidden" name="txtNumeratore" runat="server">
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Anagrafica</h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id="lblCognome" runat="server" Width="70px" AssociatedControlID="txtCognome">Cognome</asp:label><asp:textbox id=txtCognome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].COGNOME") %>' Width="232px">
						</asp:textbox>&nbsp;<asp:label id="lblNome" runat="server" Width="50px" AssociatedControlID="txtNome">Nome</asp:label><asp:textbox id=txtNome runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].NOME") %>' Width="230px">
						</asp:textbox><BR>
						<asp:label id="lblVia" runat="server" Width="70px" AssociatedControlID="txtVia">Via</asp:label><asp:textbox id="txtVia" runat="server" Width="472px" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].VIA") %>'>
						</asp:textbox>&nbsp;<asp:label id="lblCivico" runat="server" Width="30px" AssociatedControlID="txtCivico">N.</asp:label><asp:textbox id="txtCivico" runat="server" Width="55px" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].NUMEROVIA") %>'>
						</asp:textbox><BR>
						<asp:label id="lblCitta" runat="server" Width="70px" AssociatedControlID="txtCitta">Città</asp:label><asp:textbox id="txtCitta" runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].CITTA") %>' Width="230px">
						</asp:textbox>&nbsp;<asp:label id="lblCAP" runat="server" Width="50px" AssociatedControlID="txtCAP">CAP</asp:label><asp:textbox id=txtCAP runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].CAP") %>'>
						</asp:textbox><BR>
						<asp:label id="lblTelefono" runat="server" Width="70px" AssociatedControlID="txtTelefono">Telefono</asp:label><asp:textbox id=txtTelefono runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].TELEFONO") %>' Width="230px">
						</asp:textbox>&nbsp;<asp:label id="lblEmail" runat="server" Width="50px" AssociatedControlID="txtEmail">E-Mail</asp:label><asp:textbox id=txtEmail runat="server" Text='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].MAIL") %>' Width="230px">
						</asp:textbox>&nbsp;<asp:label id="lblAttiva" runat="server" Width="50px" AssociatedControlID="chkATTIVA">Attiva</asp:label><asp:CheckBox  id="chkAttiva" runat="server" Checked='<%# DataBinder.Eval(DsBiglietterie1, "Tables[AutoParchimetri_Anagrafica].DefaultView.[0].ATTIVA") %>'>
						</asp:CheckBox><br>
					</td>
				</tr>
				<tr>
					<td style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
						vAlign="top">
						<br>
						<asp:Label id="lblAltreAna" Visible="False" CssClass="H6" Runat="server">Attezione ci sono altre anagrafiche con lo stesso nome, cognome, città e CAP. Cliccare sulla riga della anagrafica interessata.</asp:Label>
					</td>
				</tr>
				<tr>
					<td style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right">
						<asp:DataGrid id="DGAltreAna" runat="server" CssClass="grid" Width="100%" Visible="False" DataKeyField="NUMERATORE"
							AutoGenerateColumns="False" GridLines="None">
							<Columns>
								<asp:TemplateColumn HeaderText="Cognome">
									<ItemTemplate>
										<asp:LinkButton id="lnkCognome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.COGNOME") %>' CommandName="Navigate">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Nome">
									<ItemTemplate>
										<asp:LinkButton id="lnkNome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.NOME") %>' CommandName="Navigate">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Via">
									<ItemTemplate>
										<asp:LinkButton id="lnkVia" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.VIA") %>' CommandName="Navigate">
										</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="NUMEROVIA" SortExpression="NUMEROVIA" HeaderText="Civico"></asp:BoundColumn>
								<asp:BoundColumn DataField="CITTA" SortExpression="CITTA" HeaderText="Citt&#224;">
									<ItemStyle Wrap="False"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="CAP" SortExpression="CAP" HeaderText="CAP"></asp:BoundColumn>
								<asp:BoundColumn DataField="MAIL" SortExpression="MAIL" HeaderText="Email"></asp:BoundColumn>
								<asp:BoundColumn DataField="TELEFONO" SortExpression="TELEFONO" HeaderText="Telefono"></asp:BoundColumn>
							</Columns>
						</asp:DataGrid></td>
				</tr>
				<tr>
					<td>
						<hr noShade SIZE="1">
						<asp:linkbutton id="lnkBack" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;
						<asp:button id=btnSalva runat="server" CssClass="Bottone" Text="Salva" Enabled="<%# dgAutoparchimetri.EditItemIndex = -1 %>">
						</asp:button>
						<asp:requiredfieldvalidator id="rfvCognome" runat="server" ControlToValidate="txtCognome" Display="None" ErrorMessage='Il campo "Cognome" è obbligatorio'></asp:requiredfieldvalidator>
						<asp:requiredfieldvalidator id="RfvVia" runat="server" ControlToValidate="txtVia" Display="None" ErrorMessage='Il campo "Via" è obbligatorio'></asp:requiredfieldvalidator>
						<asp:requiredfieldvalidator id="RfvN" runat="server" ControlToValidate="txtCivico" Display="None" ErrorMessage='Il campo "N." è obbligatorio'></asp:requiredfieldvalidator>
						<asp:requiredfieldvalidator id="rfvNome" runat="server" ControlToValidate="txtNome" Display="None" ErrorMessage='Il campo "Nome" è obbligatorio'></asp:requiredfieldvalidator>
						<asp:requiredfieldvalidator id="RfvCitta" runat="server" ControlToValidate="txtCitta" Display="None" ErrorMessage='Il campo "Città" è obbligatorio'></asp:requiredfieldvalidator>
						<asp:requiredfieldvalidator id="RfvCAP" runat="server" ControlToValidate="txtCAP" Display="None" ErrorMessage='Il campo "CAP" è obbligatorio'></asp:requiredfieldvalidator>
						<asp:regularexpressionvalidator id="revEmail" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage='Il campo "E-Mail" non è valido'
							ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator>
					</td>
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
						<h6>Autoparchimetri</h6>
						<hr noShade SIZE="1">
						<asp:datagrid id=dgAutoparchimetri runat="server" CssClass="grid" Width="100%" Visible="<%# dvAutoparchimetri.Count > 0 %>" DataKeyField="ID_AUTO" AutoGenerateColumns="False" DataSource="<%# dvAutoparchimetri %>" UseAccessibleHeader="True" GridLines="None">
							<Columns>
								<asp:TemplateColumn HeaderText="Matricola">
									<ItemTemplate>
										<asp:Label id="Label2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MATAUTO") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="txtMatAuto" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MATAUTO") %>'>
										</asp:TextBox>
										<asp:RequiredFieldValidator id="rfvMatauto" runat="server" ErrorMessage="Il campo &quot;Matricola&quot; dell'autoparchimetro è obbligatorio"
											Display="None" ControlToValidate="txtMatAuto"></asp:RequiredFieldValidator>
										<asp:RegularExpressionValidator id="revMatauto" runat="server" ErrorMessage="Il campo &quot;Matricola&quot; dell'autoparchimetro deve essere composto al massimo da 8 cifre"
											Display="None" ControlToValidate="txtMatAuto" ValidationExpression="\d{1,8}"></asp:RegularExpressionValidator>
										<asp:CustomValidator id="CVMatricolaAuto" runat="server" Width="53px" ErrorMessage="Attenzione hai già inserito questa matricola autoparchimetro per questa anagrafica."
											ControlToValidate="txtMatAuto" Display="None" EnableClientScript="False" OnServerValidate="CVEsisteMatricolaAuto_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Tipo">
									<ItemStyle Wrap="False"></ItemStyle>
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Tipo") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="ddlDSI" runat="server" DataSource="<%# DsBiglietterie1 %>" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.DSI") %>' DataMember="AutoParchimetri_Tipi" DataTextField="DSI" DataValueField="ID_DSI">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="DATAVENDITA" SortExpression="DATAVENDITA" ReadOnly="True" HeaderText="Data di vendita">
									<ItemStyle Wrap="False"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="DATARESO" SortExpression="DATARESO" ReadOnly="True" HeaderText="Data del reso">
									<ItemStyle Wrap="False"></ItemStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="Button1" runat="server" CssClass="bottone" Text="Modifica" CausesValidation="false"
											CommandName="Edit"></asp:Button>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Button id="Button3" runat="server" CssClass="bottone" Text="Ok" CommandName="Update"></asp:Button>&nbsp;
										<asp:Button id="Button2" runat="server" CssClass="bottone" Text="Annulla" CausesValidation="false"
											CommandName="Cancel"></asp:Button>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnDelete" runat="server" CssClass="bottone" Text="Elimina" CausesValidation="false"
											CommandName="Delete"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="1%"></HeaderStyle>
									<ItemTemplate>
										<asp:Button id="btnReso" runat="server" CssClass="Bottone" Text="Reso" CausesValidation="false"
											CommandName="Reso"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><asp:label id=lblNoAutoparchimetri runat="server" CssClass="label" Visible="<%# dvAutoparchimetri.Count <= 0 %>">Non ci sono autoparchimetri associati a questo utente.</asp:label>
						<hr noShade SIZE="1">
						<asp:linkbutton id="lnkBack2" runat="server" CausesValidation="False">&laquo; Torna alla ricerca</asp:linkbutton>&nbsp;
						<asp:button id=btnNuovo runat="server" CssClass="Bottone" Text="Aggiungi un autoparchimetro" CausesValidation="False" Enabled="<%# txtNumeratore.Value.Length > 0 And dgAutoparchimetri.EditItemIndex = -1 %>">
						</asp:button></td>
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
