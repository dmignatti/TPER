<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_editviezone.aspx.vb" Inherits="ATCBussm1.wf_editviezone" smartNavigation="True"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_editviezone</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center">
				<asp:ValidationSummary id="vsSommario" runat="server" CssClass="lblError" Width="100%" HeaderText="Attenzione. Si sono verificati i seguenti errori nel salvataggio:"></asp:ValidationSummary></DIV>
			<fieldset><legend class="label">Ricerca</legend><asp:label id="Label1" runat="server" CssClass="label" AssociatedControlID="txtVia">Cerca la via:</asp:label><asp:textbox id="txtVia" runat="server"></asp:textbox><asp:button id="btnCerca" runat="server" Text="Cerca"></asp:button><br>
			</fieldset>
			<fieldset><legend class="label">Vie</legend>
				<div align="center"><asp:datagrid id=dgStradario runat="server" Width="100%" CssClass="grid" PageSize="20" AutoGenerateColumns="False" UseAccessibleHeader="True" DataSource="<%# DsStradario1 %>" DataMember="StradarioBologna" DataKeyField="Guid" AllowPaging="True">
						<Columns>
							<asp:BoundColumn Visible="False" DataField="Guid" SortExpression="Guid" ReadOnly="True" HeaderText="Guid"></asp:BoundColumn>
							<asp:TemplateColumn HeaderText="Codice">
								<ItemTemplate>
									<asp:Label id="Label2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Codice") %>'>
									</asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:TextBox id="txtCodice" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Codice") %>' Width="100%">
									</asp:TextBox>
									<asp:RequiredFieldValidator id="rfvCodice" runat="server" ErrorMessage="Il campo codice è obbligatorio" ControlToValidate="txtCodice"
										Display="None"></asp:RequiredFieldValidator>
									<asp:CompareValidator id="cvCodice" runat="server" ErrorMessage="Il campo Codice deve contenere un valore numerico maggiore di 0."
										ControlToValidate="txtCodice" Display="None" Type="Integer" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
									<asp:CustomValidator OnServerValidate="cvCodiceUnivoco_OnServerValidate" id="cvCodiceUnivoco" runat="server"
										ErrorMessage="E' già presente una via con questo codice." ControlToValidate="txtCodice" Display="None"></asp:CustomValidator>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Nome">
								<ItemTemplate>
									<asp:Label id="Label3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'>
									</asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:TextBox id="txtNome" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>' Width="100%">
									</asp:TextBox>
									<asp:RequiredFieldValidator id="rfvNome" runat="server" ErrorMessage="Il campo nome è obbligatorio" ControlToValidate="txtNome"
										Display="None"></asp:RequiredFieldValidator>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica"></asp:EditCommandColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:LinkButton ID="lnkElimina" runat="server" Text="Elimina" CommandName="Delete" CausesValidation="false"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle Mode="NumericPages"></PagerStyle>
					</asp:datagrid>
					<div align="center">
						<asp:label id="lblNoVie" runat="server" CssClass="label">Non esistono vie corrispondenti ai criteri di ricerca.</asp:label>
					</div>
					<div align="center">
						<asp:button id="btnAddVia" runat="server" Text="Aggiungi una nuova via"></asp:button></div>
				</div>
			</fieldset>
		</form>
	</body>
</HTML>
