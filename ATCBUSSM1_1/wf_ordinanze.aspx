<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_ordinanze.aspx.vb" Inherits="ATCBussm1.wf_ordinanze" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ordinanze</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bgColor="#ffffff">
		<form id="Form1" method="post" runat="server">
			<div align="center">
				<ChkPerm:wc_checkpermission id="Wc_checkpermission1" runat="server"></ChkPerm:wc_checkpermission><br>
				<TABLE id="Table4" height="auto" cellSpacing="0" cellPadding="1" width="565" align="center"
					border="0">
					<TR vAlign="top" height="auto">
						<TD align="center"><IMG alt="" src="images/Ordinanze.gif"></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 46px" align="center"><asp:panel id="pnlSearch" runat="server">
								<FIELDSET><LEGEND class="label">Ricerca</LEGEND>
									<TABLE cellSpacing="0" cellPadding="2" width="100%">
										<TR>
											<TD class="label">Via</TD>
											<TD class="label">Ordinanza</TD>
										</TR>
										<TR>
											<TD>
												<asp:TextBox id="txtVia" runat="server" CssClass="TextFieldInput" Width="176px"></asp:TextBox></TD>
											<TD>
												<asp:TextBox id="txtOrdinanza" runat="server" CssClass="TextFieldInput"></asp:TextBox></TD>
										</TR>
										<TR>
											<TD class="label">
												<asp:CheckBox id="chkStorico" runat="server"></asp:CheckBox><LABEL class="label" for="chkStorico">Includi 
													storico</LABEL></TD>
											<TD>
												<asp:button id="btnSubmit" runat="server" CssClass="Bottone" Text="Cerca"></asp:button></TD>
										</TR>
									</TABLE>
								</FIELDSET>
								<BR>
							</asp:panel><asp:panel id="pnlRisultati" runat="server" Visible="False">
								<FIELDSET><LEGEND class="label">Risultati</LEGEND>
									<asp:datagrid id=dgOrdinanze runat="server" CssClass="griglia" Width="550px" Visible="False" DataMember="Ordinanze" DataSource="<%# DsOrdinanze %>" GridLines="Vertical" AutoGenerateColumns="False" ForeColor="Black" CellPadding="2" AllowPaging="True" PageSize="12" BorderColor="#CCCCCC" DataKeyField="Id">
										<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
										<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
										<HeaderStyle Font-Size="11pt" Font-Names="Times New Roman" Font-Bold="True" ForeColor="White"
											CssClass="RigaDataGrid" BackColor="#990033"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="Id"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="Codice" SortExpression="Codice" HeaderText="Codice"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nome" HeaderText="Toponimo"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="Agg.">
												<HeaderStyle Width="24px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton runat="server" Text="Aggiungi" CommandName="Add" CausesValidation="false" ID="Linkbutton3">
														<IMG alt="Aggiungi" src="images/File_Add.gif" border="0" width="24" height="24">
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn HeaderText="Mod.">
												<HeaderStyle Width="24px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton runat="server" Text="Modifica" CommandName="Edit" CausesValidation="false" ID="Linkbutton1">
														<IMG alt="Modifica" src="images/File_Edit.gif" border="0" width="24" height="24">
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn HeaderText="Canc.">
												<HeaderStyle Width="24px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton runat="server" Text="Elimina" CommandName="Delete" CausesValidation="false" ID="Linkbutton2">
														<IMG alt="Cancella" src="images/File_Delete.gif" border="0" width="24" height="24">
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn HeaderText="Visual.">
												<HeaderStyle Width="24px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton runat="server" Text="Visualizza" CommandName="View" CausesValidation="false" ID="Linkbutton4">
														<IMG alt="Visualizza" src="images/File_View.gif" border="0" width="24" height="24">
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="Ordinanza" HeaderText="Ordinanza"></asp:BoundColumn>
											<asp:BoundColumn DataField="Titolo" HeaderText="Titolo"></asp:BoundColumn>
											<asp:BoundColumn DataField="dal" HeaderText="dal" DataFormatString="{0:d}"></asp:BoundColumn>
											<asp:BoundColumn DataField="al" HeaderText="al" DataFormatString="{0:d}"></asp:BoundColumn>
											<asp:BoundColumn DataField="TipoOrdinanza" HeaderText="Tipo"></asp:BoundColumn>
										</Columns>
										<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
											CssClass="Descrizione"></PagerStyle>
									</asp:datagrid>
									<asp:label id="lblMessage" runat="server" CssClass="Label" Visible="False">Non sono presenti ordinanze che soddisfano i criteri di ricerca.</asp:label></FIELDSET>
								<BR>
							</asp:panel><asp:panel id="pnlEditOrd" runat="server" Width="100%" Visible="False">
								<FIELDSET><LEGEND class="label">Dettaglio</LEGEND>
									<asp:TextBox id="txtdeId" runat="server" Width="48px"></asp:TextBox>
									<asp:TextBox id="txtdeIdVia" runat="server" Width="64px"></asp:TextBox>
									<asp:TextBox id="txtDEFile" runat="server" Width="48px"></asp:TextBox>
									<asp:TextBox id="txtDEExt" runat="server" Width="48px"></asp:TextBox>
									<asp:ValidationSummary id="ValidationSummary1" runat="server" CssClass="lblerror" Width="100%" HeaderText="Attenzione si sono verificati i seguenti errori:"></asp:ValidationSummary>
									<TABLE id="Table5" style="WIDTH: 100%; HEIGHT: 154px" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD class="label" style="HEIGHT: 23px">
												<TABLE id="Table8" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TR>
														<TD class="label" align="center">
															<asp:Label id="lblDEVia" runat="server" CssClass="TitleLabel"></asp:Label></TD>
													</TR>
													<TR>
														<TD class="label">Titolo</TD>
													</TR>
													<TR>
														<TD>
															<asp:TextBox id="txtDETitle" runat="server" CssClass="TextFieldInput" Width="544px"></asp:TextBox>
															<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" CssClass="lblerror" ErrorMessage='"Titolo" campo obbligatorio'
																Display="None" ControlToValidate="txtDETitle"></asp:RequiredFieldValidator></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD class="label" style="HEIGHT: 24px">
												<TABLE id="Table11" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TR>
														<TD class="label" width="33%">Ordinanza N.</TD>
														<TD class="label" style="WIDTH: 190px" width="190"></TD>
														<TD class="label" width="33%">&nbsp;Tipo</TD>
													</TR>
													<TR>
														<TD>
															<asp:TextBox id="txtDEOrdinanza" runat="server" CssClass="TextFieldInput" Width="174px" Height="17"></asp:TextBox>
															<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" CssClass="lblerror" ErrorMessage='"Ordinanza" campo obbligatorio'
																Display="None" ControlToValidate="txtDEOrdinanza"></asp:RequiredFieldValidator></TD>
														<TD style="WIDTH: 190px"></TD>
														<TD>
															<asp:DropDownList id=cboDETipo runat="server" CssClass="TextFieldInput" Width="166px" DataMember="OrdinanzeTipi" DataSource="<%# DsOrdinanze %>" DataValueField="Id" DataTextField="Tipo">
															</asp:DropDownList>
															<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" CssClass="lblerror" ErrorMessage='"Tipo" campo obbligatorio'
																Display="None" ControlToValidate="cboDETipo"></asp:RequiredFieldValidator></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD class="label" style="HEIGHT: 24px">
												<TABLE id="Table7" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TR>
														<TD class="label" style="HEIGHT: 18px" width="33%">validità dal (gg/mm/aaaa)</TD>
														<TD class="label" style="WIDTH: 190px; HEIGHT: 18px" width="190"></TD>
														<TD class="label" width="33%">validità al (gg/mm/aaaa)</TD>
													</TR>
													<TR>
														<TD>
															<asp:TextBox id="txtDEDal" runat="server" CssClass="TextFieldInput" Width="174px" Height="17"></asp:TextBox>
															<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" CssClass="lblerror" ErrorMessage='"Validità dal" campo obbligatorio'
																Display="None" ControlToValidate="txtDEDal"></asp:RequiredFieldValidator>
															<asp:RangeValidator id="RangeValidator1" runat="server" CssClass="lblError" ErrorMessage='"Validità dal" deve essere una data valida'
																Display="None" ControlToValidate="txtDEDal" MaximumValue="31/12/9999" MinimumValue="1/1/1900" Type="Date"></asp:RangeValidator></TD>
														<TD style="WIDTH: 190px"></TD>
														<TD>
															<asp:TextBox id="txtDEAl" runat="server" CssClass="TextFieldInput" Width="166px" Height="17"></asp:TextBox>
															<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" CssClass="lblerror" ErrorMessage='"Validità al" campo obbligatorio'
																Display="None" ControlToValidate="txtDEAl"></asp:RequiredFieldValidator>
															<asp:RangeValidator id="RangeValidator2" runat="server" CssClass="lblError" ErrorMessage='"Validità al" deve essere una data valida'
																Display="None" ControlToValidate="txtDEAl" MaximumValue="31/12/9999" MinimumValue="1/1/1900" Type="Date"></asp:RangeValidator></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD class="label">
												<TABLE id="Table6" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TR>
														<TD class="label" width="33%">Visualizza file</TD>
														<TD class="label" width="34%">Cancella file</TD>
														<TD class="label" style="WIDTH: 136px" width="136">Inserisci file</TD>
													</TR>
													<TR>
														<TD>
															<asp:HyperLink id="btnView" runat="server" ImageUrl="images/File_View.gif" Target="_blank"></asp:HyperLink></TD>
														<TD width="34%">
															<asp:ImageButton id="btnDelete" runat="server" ImageUrl="images/File_Delete.gif" AlternateText="Elimina"></asp:ImageButton></TD>
														<TD vAlign="middle"><INPUT class="TextFieldInput" id="OrdFile" style="WIDTH: 97.24%; HEIGHT: 17px" type="file"
																size="10" name="File" runat="server">
														</TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD class="label">
												<TABLE id="Table9" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TR>
														<TD class="label">
															<P>Testo</P>
														</TD>
													</TR>
													<TR>
														<TD>
															<asp:TextBox id="txtDETesto" runat="server" CssClass="TextFieldInput" Width="100%" Height="177px"
																TextMode="MultiLine" rows="25"></asp:TextBox></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
									<P>
										<asp:Button id="btnSave" runat="server" CssClass="Bottone" Text="Salva"></asp:Button>&nbsp;
										<asp:Button id="btnCancel" runat="server" CssClass="Bottone" Text="Annulla" CausesValidation="False"></asp:Button></P>
								</FIELDSET>
								<BR>
							</asp:panel></TD>
					</TR>
				</TABLE>
			</div>
		</form>
	</body>
</HTML>
