<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_GiorniSpecialiPS.aspx.vb" Inherits="ATCBussm1.wf_GiorniSpecialiPS"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_GiorniSpecialiPS</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmGiorniSpeciali" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSDatiSintesi" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Width="700px" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" border="0" cellSpacing="2" cellPadding="0" width="100%" height="100%">
							<TR>
								<TD align="right">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label>
									<asp:TextBox id="txtAnno" runat="server" Width="67px"></asp:TextBox></TD>
								<TD align="right">
									<asp:Label id="LblEventi" runat="server" CssClass="label">Eventi</asp:Label>
									<asp:DropDownList id=CboEventoG runat="server" Width="151px" DataTextField="Descrizione" DataValueField="Id" DataSource="<%# DsPSostaGSpeciali %>" DataMember="PSostaEventoGG" AutoPostBack="True">
									</asp:DropDownList></TD>
								<TD align="right">
									<asp:Label id="LblProvv" runat="server" CssClass="label">Provvedimenti</asp:Label>
									<asp:DropDownList id=CboProvvG runat="server" Width="151px" DataTextField="Descrizione" DataValueField="Id" DataSource="<%# DsPSostaGSpeciali %>" DataMember="PSostaProvvGG" AutoPostBack="True">
									</asp:DropDownList></TD>
								<TD align="left">
									<asp:CompareValidator id="cvAnno" runat="server" ValueToCompare="1980" Operator="GreaterThanEqual" Type="Integer"
										ControlToValidate="txtAnno" Display="None" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"></asp:CompareValidator>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlGiorniSpeciali" runat="server" Width="700px" Visible="FALSE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Piano Sosta - Giorni Speciali</LEGEND><BR>
						<asp:datagrid id=dgGiorniSpeciali runat="server" Width="100%" Visible="TRUE" CssClass="grid" DataSource="<%# DsPSostaGSpeciali %>" DataMember="PSostaGiorni" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="2" UseAccessibleHeader="True">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle CssClass="RigaDataGrid"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Data">
									<ItemTemplate>
										<asp:Label id="LblData" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Data", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="calGiorno" runat="server" Font-Size="X-Small" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.Data") %>' Height="137px">
										</asp:Calendar>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Evento">
									<ItemTemplate>
										<asp:Label id="LblEvento" text='<%# databinder.eval(container.dataitem,"DescrEvento") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboGEvento" runat="server" Width="151px" AutoPostBack="True" DataMember="PSostaEventoGG" DataSource="<%# DsPSostaGSpeciali %>" DataValueField="Id" DataTextField="Descrizione">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Provvedimento">
									<ItemTemplate>
										<asp:Label id="LblProvvedimento" text='<%# databinder.eval(container.dataitem, "DescrProvv") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboGProvv" runat="server" Width="151px" AutoPostBack="True" DataMember="PSostaProvvGG" DataSource="<%# DsPSostaGSpeciali %>" DataValueField="Id" DataTextField="Descrizione">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="IdEvento" ReadOnly="True" HeaderText="IdEvento"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdProvv" ReadOnly="True" HeaderText="IdProvv"></asp:BoundColumn>
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
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo giorno</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
