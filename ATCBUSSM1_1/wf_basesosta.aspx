<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_basesosta.aspx.vb" Inherits="ATCBussm1.wf_basesosta"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_basesosta</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="FrmBaseSosta" method="post" runat="server">
			<CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION>
			<asp:panel id="pnlPianoSosta" runat="server" Visible="FALSE" Width="100%">
				<TABLE class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
					<TR>
						<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
								width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
								width="4" align="right"></TD>
					</TR>
					<TR>
						<TD style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px"
							vAlign="top">
							<H6>Dati di base - Piano sosta</H6>
							<HR noShade SIZE="1">
							<asp:validationsummary id="VSDatiSintesi" runat="server" HeaderText="Attenzione!" Width="100%" CssClass="error"></asp:validationsummary>
							<asp:datagrid id="dgPianoSosta" runat="server" Width="100%" Visible="False" UseAccessibleHeader="True" CssClass="grid" CellPadding="2" AutoGenerateColumns="False" DataKeyField="Id" DataMember="PianoSostaZona" DataSource="<%# DsPianoSosta %>" GridLines="None">
								<ItemStyle CssClass="RigaDataGrid"></ItemStyle>
								<HeaderStyle Wrap="False" CssClass="RigaDataGrid"></HeaderStyle>
								<Columns>
									<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
									<asp:BoundColumn Visible="False" DataField="IdZona" ReadOnly="True" HeaderText="IdZona"></asp:BoundColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHZona" Runat="server">Zona</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIZona" Runat="server" text='<%# databinder.eval(container.dataitem,"Zona") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:DropDownList id="CboZona" runat="server" Width="50px" DataSource="<%# DsPianoSosta %>" DataMember="LavoriStradaliZone" DataTextField="Zona" DataValueField="IdZona" AutoPostBack="True" >
											</asp:DropDownList>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHOrdinaria" Runat="server">Ordinaria</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIOrdinaria" Runat="server" text='<%# databinder.eval(container.dataitem,"Ordinaria") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtOrdinaria" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Ordinaria") %>' width="70px">
											</asp:TextBox>
											<asp:CustomValidator id="CVOrdinaria" runat="server" Width="53px" ErrorMessage="Segnaletica ordinaria non valida. Formato numerico."
												ControlToValidate="TxtOrdinaria" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHRapidaRot" Runat="server">A rapida rot.</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIRapidaRot" Runat="server" text='<%# databinder.eval(container.dataitem,"RapidaRot") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtRapidaRot" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"RapidaRot") %>' width="70px">
											</asp:TextBox>
											<asp:CustomValidator id="CVRapidaRot" runat="server" Width="53px" ErrorMessage="Segnaletica a rapida rotazione non valida. Formato numerico."
												ControlToValidate="TxtRapidaRot" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHResidenti" Runat="server">Residenti</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIResidenti" Runat="server" text='<%# databinder.eval(container.dataitem,"Residenti") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtResidenti" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Residenti") %>' width="70px">
											</asp:TextBox>
											<asp:CustomValidator id="CVResidenti" runat="server" Width="53px" ErrorMessage="Segnaletica residenti non valida. Formato numerico."
												ControlToValidate="TxtResidenti" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHDisabili" Runat="server">Disabili</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LlbIDisabili" Runat="server" text='<%# databinder.eval(container.dataitem,"Disabili") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtDisabili" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Disabili") %>' width="60px">
											</asp:TextBox>
											<asp:CustomValidator id="CVDisabili" runat="server" Width="53px" ErrorMessage="Segnaletica disabili non valida. Formato numerico."
												ControlToValidate="TxtDisabili" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHGenerici" Runat="server">Generici</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIGenerici" Runat="server" text='<%# databinder.eval(container.dataitem,"Generici") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtGenerici" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Generici") %>' width="60px">
											</asp:TextBox>
											<asp:CustomValidator id="CVGenerici" runat="server" Width="53px" ErrorMessage="Segnaletica generici non valida. Formato numerico."
												ControlToValidate="TxtGenerici" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHCarico_scarico" Runat="server">Carico/ scarico</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblICarico_scarico" Runat="server" text='<%# databinder.eval(container.dataitem,"Carico_scarico") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtCarico_scarico" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Carico_scarico") %>' width="60px">
											</asp:TextBox>
											<asp:CustomValidator id="CVCarico_scarico" runat="server" Width="53px" ErrorMessage="Segnaletica carico/scarico non valida. Formato numerico."
												ControlToValidate="TxtCarico_scarico" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn>
										<HeaderTemplate>
											<asp:Label id="LblHPostiMoto" Runat="server">Posti moto</asp:Label>
										</HeaderTemplate>
										<ItemTemplate>
											<asp:Label id="LblIPostiMoto" Runat="server" text='<%# databinder.eval(container.dataitem,"PostiMoto") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox id="TxtPostiMoto" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"PostiMoto") %>' width="70px">
											</asp:TextBox>
											<asp:CustomValidator id="CVPostiMoto" runat="server" Width="53px" ErrorMessage="Segnaletica posti moto non valida. Formato numerico."
												ControlToValidate="TxtPostiMoto" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
										CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
										EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
									<asp:TemplateColumn>
										<ItemTemplate>
											<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="&lt;IMG alt=&quot;Elimina&quot; src=&quot;images/File_delete.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:LinkButton>
										</ItemTemplate>
									</asp:TemplateColumn>
								</Columns>
								<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" CssClass="Descrizione"></PagerStyle>
							</asp:datagrid>
							<HR noShade SIZE="1">
							<asp:Button id="btnAddNew" runat="server" CssClass="bottone" Text="Aggiungi una nuova riga posti sosta per zona"></asp:Button></TD>
					<TR>
						<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
								src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
								src="images/corner_br.gif" width="4" align="right"></TD>
					</TR>
				</TABLE>
			</asp:panel>
		</form>
	</body>
</HTML>
