<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_Parcheggi.aspx.vb" Inherits="ATCBussm1.wf_Parcheggi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_Parcheggi</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmParcheggi" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSParcheggio" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary><br>
			</DIV>
			<DIV align="center"><asp:panel id="pnlParcheggi" runat="server" Visible="TRUE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Parcheggi</LEGEND><BR>
						<asp:datagrid id=dgParcheggi runat="server" Width="100%" CssClass="griglia" DataSource="<%# DsParcheggi %>" DataMember="Parcheggi" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False" ForeColor="Black" CellPadding="2" BorderColor="#CCCCCC">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle Font-Size="11pt" Font-Names="Times New Roman" Font-Bold="True" ForeColor="White"
								CssClass="RigaDataGrid" BackColor="#990033"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:BoundColumn DataField="Nome" HeaderText="Nome"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHPosti" Runat="server">N° Posti</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblPosti Runat="server" text='<%# databinder.eval(container.dataitem,"Posti") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TxtPosti Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"Posti") %>'>
										</asp:TextBox>
										<asp:CustomValidator id="CVPosti" runat="server" Width="53px" ErrorMessage="N° posti è numerico" Display="None"
											OnServerValidate="CVPosti_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHPercOccup" Runat="server">% Occup.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblPercOccup Runat="server" text='<%# databinder.eval(container.dataitem,"PercOccup") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TxtPercOccup Runat="server" width="50px" TEXT='<%# databinder.eval(container.dataitem,"PercOccup") %>'>
										</asp:TextBox>
										<asp:CustomValidator id="CVPercOcc" runat="server" ErrorMessage="% di occupazione è numerico" ControlToValidate="TxtPercOccup"
											Display="None" OnServerValidate="CVPercOcc_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHConnPNV" Runat="server">Conn. PNV</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblConnPNV text='<%# databinder.eval(container.dataitem,"ConnPNV") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboConnesso" runat="server" Width="71px">
											<asp:ListItem Value="1" Selected="True">Si</asp:ListItem>
											<asp:ListItem Value="0">No</asp:ListItem>
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHAutom" Runat="server">Autom./Assist.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblAutom text='<%# databinder.eval(container.dataitem,"Autom") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboAutom" runat="server" Width="135px">
											<asp:ListItem Value="1" Selected="True">AUTOM.</asp:ListItem>
											<asp:ListItem Value="0">ASSIST.</asp:ListItem>
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHNote" Runat="server">Note</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblNote text='<%# databinder.eval(container.dataitem,"Note") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TxtNote Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Note") %>' width="151px" TextMode="MultiLine">
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" Text='<IMG alt="Elimina" src="images/File_delete.gif" border="0" width="24" height="24">'
											CommandName="Delete" CausesValidation="false"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo parcheggio</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
