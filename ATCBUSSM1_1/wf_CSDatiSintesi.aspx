<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_CSDatiSintesi.aspx.vb" Inherits="ATCBussm1.wf_CSDatiSintesi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_CSDatiSintesi</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmCarSharing" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSDatiSintesi" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Visible="TRUE" Width="700px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 297px" align="right">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label>
									<asp:TextBox id="txtAnno" runat="server" Width="67px"></asp:TextBox></TD>
								<TD align="left">
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
									<asp:RequiredFieldValidator id="rfvAnno" runat="server" ControlToValidate="txtAnno" Display="None" ErrorMessage="Il campo Anno è obbligatorio"></asp:RequiredFieldValidator>
									<asp:CompareValidator id="cvAnno" runat="server" ControlToValidate="txtAnno" Display="None" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
										ValueToCompare="1980" Operator="GreaterThanEqual" Type="Integer"></asp:CompareValidator></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlCarSharing" runat="server" Visible="FALSE" Width="700px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Consumi aziendali - Car Sharing</LEGEND><BR>
						<asp:datagrid id=dgCarSharing runat="server" Width="100%" Visible="TRUE" CssClass="grid" BorderColor="#CCCCCC" CellPadding="2" ForeColor="Black" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id" DataMember="CS" DataSource="<%# DsCarSharing %>" UseAccessibleHeader="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="Operatore" Runat="server">Data</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblDt" Runat="server" text='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtDataI" Runat="server" width="70px" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:TextBox>
										<asp:RegularExpressionValidator id="REVData" runat="server" ErrorMessage="La data non è valida. Formato MM/AAAA"
											Display="None" ValidationExpression="^(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$" ControlToValidate="TxtDataI"></asp:RegularExpressionValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblIncassiC" Runat="server">Incassi</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblIncassi" Runat="server" text='<%# databinder.eval(container.dataitem,"Incassi") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtIncassi" Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"Incassi") %>'>
										</asp:TextBox>
										<asp:RequiredFieldValidator id="rfvIncassi" runat="server" ErrorMessage="Il campo Incassi è obbligatorio." Display="None"
											ControlToValidate="TxtIncassi"></asp:RequiredFieldValidator>
										<asp:CompareValidator id="cvIncassi" runat="server" ErrorMessage="Il campo Incassi deve essere di tipo numerico."
											Display="None" ControlToValidate="TxtIncassi" Type="Double" Operator="DataTypeCheck"></asp:CompareValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblKmMeseC" Runat="server">Km</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblKmMese" Runat="server" text='<%# databinder.eval(container.dataitem,"KmMese") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblTempoUtC" Runat="server">Tempo</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblTempoUt" Runat="server" text='<%# databinder.eval(container.dataitem,"TempoUt") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblCorse" Runat="server">Corse</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblN_Corse" Runat="server" text='<%# databinder.eval(container.dataitem,"N_Corse") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblAuto" Runat="server">Auto</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblN_Auto" Runat="server" text='<%# databinder.eval(container.dataitem,"N_Auto") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtN_Auto" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"N_Auto") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVN_Auto" runat="server" Width="53px" ErrorMessage="N° auto non valido. Formato numerico."
											ControlToValidate="TxtN_Auto" Display="None" EnableClientScript="False" OnServerValidate="CVN_Auto_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>									
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblParcheggi" Runat="server">Parcheggi</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblN_Parcheggi" Runat="server" text='<%# databinder.eval(container.dataitem,"N_Parcheggi") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtN_Parcheggi" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"N_Parcheggi") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVN_Parcheggi" runat="server" Width="53px" ErrorMessage="N° parcheggi non valido. Formato numerico."
											ControlToValidate="TxtN_Parcheggi" Display="None" EnableClientScript="False" OnServerValidate="CVN_Parcheggi_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblUtenti" Runat="server">Utenti</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblN_Utenti" Runat="server" text='<%# databinder.eval(container.dataitem,"N_Utenti") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtN_Utenti" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"N_Utenti") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVN_Utenti" runat="server" Width="53px" ErrorMessage="N° utenti non valido. Formato numerico."
											ControlToValidate="TxtN_Utenti" Display="None" EnableClientScript="False" OnServerValidate="CVN_Utenti_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblUtentiTessere" Runat="server">Utenti/tessere</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblN_Utentitessere" Runat="server" text='<%# databinder.eval(container.dataitem,"N_Utenti_tessere") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="DataCreazione" SortExpression="DataCreazione" HeaderText="DataCreazione"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="&lt;IMG alt=&quot;Elimina&quot; src=&quot;images/File_delete.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo mese</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
