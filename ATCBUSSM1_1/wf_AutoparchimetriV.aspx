<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_AutoparchimetriV.aspx.vb" Inherits="ATCBussm1.wf_AutoparchimetriV"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_AutoparchimetriV</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmAutoPV" method="post" runat="server">
			<CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Visible="TRUE">
					<TABLE class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
						<TR>
							<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
									width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
									width="4" align="right"></TD>
						</TR>
						<TR>
							<TD style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px">
								<H6>Ricerca</H6>
								<HR noShade SIZE="1">
								<asp:validationsummary id="VSAutoparchimetri" runat="server" Width="100%" HeaderText="Attenzione!"></asp:validationsummary>
								<asp:Label id="lblAnno" runat="server" CssClass="label">Anno:</asp:Label>
								<asp:TextBox id="txtAnno" runat="server"></asp:TextBox>
								<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
								<asp:RequiredFieldValidator id="rfvAnno" runat="server" Font-Size="Smaller" ErrorMessage="Il campo Anno è obbligatorio."
									Display="None" ControlToValidate="txtAnno"></asp:RequiredFieldValidator>
								<asp:CompareValidator id="cvAnno" runat="server" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
									Display="None" ControlToValidate="txtAnno" Operator="GreaterThanEqual" ValueToCompare="1980" Type="Integer"></asp:CompareValidator></TD>
						</TR>
						<TR>
							<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
									src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
									src="images/corner_br.gif" width="4" align="right"></TD>
						</TR>
					</TABLE>
				</asp:panel></DIV>
			<br>
			<DIV align="center"><asp:panel id="pnlAutoPV" runat="server" Visible="FALSE">
					<TABLE class="Back" id="Table02" cellSpacing="0" cellPadding="0" width="100%" align="center">
						<TR>
							<TD><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
									width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
									width="4" align="right"></TD>
						</TR>
						<TR>
							<TD style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 0px; PADDING-TOP: 0px">
								<H6>Autoparchimetri acquistati
									<asp:Label id=lblCount runat="server" Visible="<%# dvAutoparchimetri.Count > 0 %>" CssClass="label" Text='<%# "(trovati " &amp; dvAutoparchimetri.Count &amp; ")" %>'>
									</asp:Label></H6>
								<HR noShade SIZE="1">
								<asp:datagrid id=dgAutoPV runat="server" Visible="<%# dvAutoparchimetri.Count > 0 %>" Width="100%" CssClass="grid" OnCancelCommand="pDataGridCancel" OnUpdateCommand="pDataGridUpdate" BorderColor="#CCCCCC" CellPadding="2" ForeColor="Black" AutoGenerateColumns="False" GridLines="None" DataKeyField="Id" DataSource="<%# dvAutoparchimetri %>" OnEditCommand="pDataGridEdit" OnItemCreated="pItemCreated" OnDeleteCommand="pDataGridDelete" UseAccessibleHeader="True">
									<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
									<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
									<HeaderStyle ForeColor="White" CssClass="RigaDataGrid"></HeaderStyle>
									<Columns>
										<asp:BoundColumn Visible="False" DataField="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHData" Runat="server">Data</asp:Label>
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
												<asp:Label id="LblHAcquistiATC" Runat="server">Acquisti standard</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblAcquistiATC" Runat="server" text='<%# databinder.eval(container.dataitem,"AcquistiATC") %>'>
												</asp:Label>
											</ItemTemplate>
											<EditItemTemplate>
												<asp:TextBox id="TxtAcquistiATC" Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"AcquistiATC") %>'>
												</asp:TextBox>
												<asp:CustomValidator id="CVAcqATC" runat="server" Width="53px" Display="None" ErrorMessage="Acquisti standard non valido. Formato numerico."
													ControlToValidate="TxtAcquistiATC" OnServerValidate="CVAcqATC_OnServerValidate" EnableClientScript="False"></asp:CustomValidator>
											</EditItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHAcquistiDSI" Runat="server">Acquisti DSI</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblAcquistiDSI" Runat="server" text='<%# databinder.eval(container.dataitem,"AcquistiDSI") %>'>
												</asp:Label>
											</ItemTemplate>
											<EditItemTemplate>
												<asp:TextBox id="TxtAcquistiDSI" Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"AcquistiDSI") %>'>
												</asp:TextBox>
												<asp:CustomValidator id="CVAcqDSI" runat="server" Width="53px" Display="None" ErrorMessage="Acquisti DSI non valido. Formato numerico."
													ControlToValidate="TxtAcquistiDSI" OnServerValidate="CVAcqDSI_OnServerValidate" EnableClientScript="False"></asp:CustomValidator>
											</EditItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHVenditeSTD" Runat="server">Vendite STD</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblVenditeSTD" Runat="server" text='<%# databinder.eval(container.dataitem,"VenditeSTD") %>'>
												</asp:Label>
											</ItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHVenditeDSI" Runat="server">Vendite DSI</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblVenditeDSI" Runat="server" text='<%# databinder.eval(container.dataitem,"VenditeDSI") %>'>
												</asp:Label>
											</ItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHResiSTD" Runat="server">Resi STD</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblResiSTD" Runat="server" text='<%# databinder.eval(container.dataitem,"ResiSTD") %>'>
												</asp:Label>
											</ItemTemplate>
										</asp:TemplateColumn>
										<asp:TemplateColumn>
											<HeaderTemplate>
												<asp:Label id="LblHResiDSI" Runat="server">Resi DSI</asp:Label>
											</HeaderTemplate>
											<ItemTemplate>
												<asp:Label id="LblResiDSI" Runat="server" text='<%# databinder.eval(container.dataitem,"ResiDSI") %>'>
												</asp:Label>
											</ItemTemplate>
										</asp:TemplateColumn>
										<asp:BoundColumn Visible="False" DataField="DataCreazione" HeaderText="DataCreazione"></asp:BoundColumn>
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
								</asp:datagrid>
								<asp:Label id=lblNoAutoparchimetri runat="server" Visible="<%# dvAutoparchimetri.Count <= 0 %>" CssClass="label">Non sono stati venduti autoparchimetri nell'anno selezionato.</asp:Label>
								<HR noShade SIZE="1">
								<asp:Button id="btnAddMonth" runat="server" CssClass="bottone" Text="Aggiungi un nuovo mese"></asp:Button></TD>
						</TR>
						<TR>
							<TD style="VERTICAL-ALIGN: top; HEIGHT: 4px" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
									src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
									src="images/corner_br.gif" width="4" align="right"></TD>
						</TR>
					</TABLE>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
