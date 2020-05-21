<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_utenti.aspx.vb" Inherits="ATCBussm1.wf_utenti" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_utenti</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bgColor="#ffffff">
		<form id="Form1" method="post" runat="server">
			<div align="center">
				<ChkPerm:wc_checkpermission id="Wc_checkpermission1" runat="server"></ChkPerm:wc_checkpermission>
				<asp:Button id="btnSyncAS400" runat="server" CssClass="bottone" Text="Sincronizza l'organico degli accertatori"></asp:Button><br>
				<TABLE id="Table2" cellSpacing="0" cellPadding="2" width="565" border="0">
					<TR>
						<TD><asp:label id="Label9" runat="server" CssClass="label">Amministrazione utenti</asp:label></TD>
					</TR>
					<TR>
						<TD><asp:listbox id="lstUtenti" runat="server" Height="123px" Width="100%" CssClass="TextFieldInput"></asp:listbox></TD>
					</TR>
					<TR>
						<TD align="right"><asp:button id="BtnAdd" runat="server" Width="155px" CssClass="Bottone" Text="Aggiungi un nuovo utente"></asp:button>&nbsp;<asp:button id="BtnModify" runat="server" Width="157px" CssClass="Bottone" Text="Modifica l'utente selezionato"></asp:button>&nbsp;<asp:button id="btnRemove" runat="server" Width="163px" CssClass="Bottone" Text="Rimuovi l'utente selezionato"></asp:button></TD>
					</TR>
				</TABLE>
				<asp:panel id="pnlUtente" runat="server" Height="80px" Visible="False">
					<TABLE id="Table4" cellSpacing="0" cellPadding="2" width="565" border="0">
						<TR>
							<TD>
								<TABLE id="Table3" cellSpacing="0" cellPadding="2" width="100%" border="0">
									<TR>
										<TD>
											<asp:TextBox id="txtId" runat="server" CssClass="TextFieldInput" Width="24px" Visible="False">Id</asp:TextBox></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label4" runat="server" CssClass="label">Nome utente:</asp:label></TD>
										<TD>
											<asp:textbox id="txtUserId" runat="server" CssClass="TextFieldInput" Width="144px"></asp:textbox>
											<asp:requiredfieldvalidator id="Requiredfieldvalidator4" runat="server" ErrorMessage="RequiredFieldValidator"
												ControlToValidate="txtUserId">*</asp:requiredfieldvalidator></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label5" runat="server" CssClass="label">Password:</asp:label></TD>
										<TD>
											<asp:textbox id="txtPwd" runat="server" CssClass="TextFieldInput" Width="144px"></asp:textbox>
											<asp:requiredfieldvalidator id="Requiredfieldvalidator5" runat="server" ErrorMessage="RequiredFieldValidator"
												ControlToValidate="txtPwd">*</asp:requiredfieldvalidator></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label1" runat="server" CssClass="label">Nome:</asp:label></TD>
										<TD>
											<asp:TextBox id="txtName" runat="server" CssClass="TextFieldInput" Width="144px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label2" runat="server" CssClass="label">Cognome:</asp:label></TD>
										<TD>
											<asp:TextBox id="txtSurname" runat="server" CssClass="TextFieldInput" Width="144px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label3" runat="server" CssClass="label">Email:</asp:label></TD>
										<TD>
											<asp:TextBox id="txtEmail" runat="server" CssClass="TextFieldInput" Width="144px"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD>
											<asp:label id="Label6" runat="server" CssClass="label">Abilitato:</asp:label></TD>
										<TD>
											<asp:CheckBox id="chkEnabled" runat="server" CssClass="label"></asp:CheckBox></TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
						<TR>
							<TD>
								<asp:Label id="Label7" runat="server" CssClass="label">Gruppi ai quali appartiene l'utente:</asp:Label></TD>
						</TR>
						<TR>
							<TD>
								<asp:ListBox id="lstGruppiUtente" runat="server" CssClass="TextFieldInput" Width="100%" SelectionMode="Multiple"
									AutoPostBack="True"></asp:ListBox></TD>
						</TR>
						<TR>
							<TD align="right">
								<asp:Button id="btnRemoveGroup" runat="server" Text="Rimuovi" CssClass="Bottone"></asp:Button></TD>
						</TR>
						<TR>
							<TD>
								<asp:Label id="Label8" runat="server" CssClass="label">Selezionare i gruppi da aggiungere all'utente:</asp:Label></TD>
						</TR>
						<TR>
							<TD style="HEIGHT: 70px">
								<asp:ListBox id="lstGruppi" runat="server" CssClass="TextFieldInput" Width="100%" SelectionMode="Multiple"
									AutoPostBack="True"></asp:ListBox></TD>
						</TR>
						<TR>
							<TD align="right">
								<asp:Button id="btnAddGroup" runat="server" Text="Aggiungi" CssClass="Bottone"></asp:Button></TD>
						</TR>
						<TR>
							<TD>
								<asp:Label id="lblError" runat="server" CssClass="label"></asp:Label></TD>
						</TR>
						<TR>
							<TD align="center">
								<asp:Button id="BtnSave" runat="server" Text="Salva" CssClass="Bottone"></asp:Button>&nbsp;
								<asp:Button id="btnCancel" runat="server" Text="Annulla" CssClass="Bottone" CausesValidation="False"></asp:Button></TD>
						</TR>
					</TABLE>
				</asp:panel>
			</div>
		</form>
	</body>
</HTML>
