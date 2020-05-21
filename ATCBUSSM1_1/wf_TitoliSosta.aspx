<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_TitoliSosta.aspx.vb" Inherits="ATCBussm1.wfTitoliSosta"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>TitoliSosta</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmTitoliSosta" method="post" runat="server">
			<DIV align="center">&nbsp;</DIV>
			<DIV align="center"><asp:validationsummary id="VSTitoliSosta" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="pnlTitoloSosta" runat="server" Width="700px" Visible="FALSE">
<FIELDSET style="WIDTH: 100%"><LEGEND class=label>Titoli sosta - Raggruppamento 
per zona</LEGEND><BR>
<asp:datagrid id=dgTitoloSosta runat="server" Width="100%" Visible="False" DataSource="<%# DsTitoliSosta %>" DataMember="TitoliSostaD" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="2" UseAccessibleHeader="True" CssClass="grid" AllowPaging="True">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle CssClass="RigaDataGrid"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Codice titolo sosta">
									<ItemTemplate>
										<asp:Label id="LblCodice" text='<%# databinder.eval(container.dataitem,"CodiceTit") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtCodice" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"CodiceTit") %>' width="100px">
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Raggruppamento zona">
									<ItemTemplate>
										<asp:Label id=LblDivisione Visible="true" Runat="server" text='<%# DataBinder.Eval(container.dataitem, "DescrizioneDiv") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id=CboDescrizione runat="server" Width="151px" DataMember="DivisioneZona" DataSource="<%# DsTitoliSosta %>" DataTextField="Descrizione" DataValueField="Id" AutoPostBack="True">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="Divisione" ReadOnly="True" HeaderText="Divisione"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; " CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; " EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="&lt;IMG alt=&quot;Elimina&quot; src=&quot;images/File_delete.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><BR><BR>
<asp:LinkButton id=lnkAddnew runat="server">Aggiungi un nuovo codice titolo</asp:LinkButton></FIELDSET> 
<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
