<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_pianososta.aspx.vb" Inherits="ATCBussm1.wf_pianososta" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_pianososta</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Pragma" content="no-cache">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body bgColor="#ffffff">
		<form id="Form1" method="post" runat="server">
			<div align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION><br>
				<TABLE id="Table4" height="auto" cellSpacing="0" cellPadding="1" width="565" border="0">
					<TR>
						<TD><IMG alt="" src="images/PianiSosta.gif"></TD>
					</TR>
					<TR>
						<TD><asp:panel id="pnlSearch" runat="server" Width="600px">
								<FIELDSET><LEGEND class="label">Ricerca</LEGEND>
									<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
										<TR>
											<TD style="WIDTH: 230px">
												<asp:Label id="lblVia" runat="server" CssClass="label">Via </asp:Label></TD>
											<TD>
												<asp:Label id="lblZONA" runat="server" CssClass="label">Zona</asp:Label></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 230px; HEIGHT: 18px">
												<asp:TextBox id="txtVia" runat="server" Width="159px"></asp:TextBox></TD>
											<TD>
												<asp:DropDownList id=cboZona runat="server" DataValueField="IdZona" DataTextField="Zona" DataMember="LavoriStradaliZone" DataSource="<%# DsValori %>">
												</asp:DropDownList></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 230px">
												<asp:Label id="LblPeriodo" runat="server" CssClass="label">Data inizio (gg/mm/aaaa)</asp:Label></TD>
											<TD>
												<asp:Label id="LblEsecutore" runat="server" CssClass="label">Esecutore</asp:Label></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 230px; HEIGHT: 19px">
												<P>
													<asp:TextBox id="txtDal" runat="server" Width="71px"></asp:TextBox>
													<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" CssClass="lblerror" ErrorMessage="*"
														ControlToValidate="txtDal" ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator>
													<asp:RangeValidator id="RangeValidator1" runat="server" CssClass="lblError" ErrorMessage="*" ControlToValidate="txtDal"
														Type="Date" MaximumValue="9999/12/31" MinimumValue="1900/01/01"></asp:RangeValidator>
													<asp:TextBox id="txtAl" runat="server" Width="71px"></asp:TextBox>
													<asp:RangeValidator id="RangeValidator2" runat="server" CssClass="lblError" ErrorMessage="*" ControlToValidate="txtAl"
														Type="Date" MaximumValue="9999/12/31" MinimumValue="1900/1/1"></asp:RangeValidator>
													<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" CssClass="lblerror" ErrorMessage="*"
														ControlToValidate="txtAl" ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator></P>
											</TD>
											<TD style="HEIGHT: 19px">
												<asp:DropDownList id=cboEsecutore runat="server" DataValueField="IdEsecutore" DataTextField="Esecutore" DataMember="LavoriStradaliEsecutori" DataSource="<%# DsValori %>">
												</asp:DropDownList></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 230px">
												<asp:Label id="lblTipo" runat="server" CssClass="label">Tipo</asp:Label></TD>
											<TD>
												<asp:Label id="lblCausale" runat="server" CssClass="label">Causale</asp:Label></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 230px">
												<asp:DropDownList id=cboTipo runat="server" Width="200px" DataValueField="IdTipo" DataTextField="Tipo" DataMember="LavoriStradaliTipi" DataSource="<%# DsValori %>">
												</asp:DropDownList></TD>
											<TD>
												<asp:DropDownList id=cboCausale runat="server" Width="151px" DataValueField="IdCausale" DataTextField="Causale" DataMember="LavoriStradaliCausali" DataSource="<%# DsValori %>">
												</asp:DropDownList></TD>
											<TD>
												<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
										</TR>
									</TABLE>
								</FIELDSET>
								<BR>
							</asp:panel>
							<!--
							<asp:panel id="pnlConteggioV" runat="server" Width="600px">
								<FIELDSET><LEGEND class="label">Conteggi</LEGEND>
									<TABLE id="Table1" height="100%" cellSpacing="0" cellPadding="2" width="100%" border="0">
										<TR>
											<TD style="BORDER-BOTTOM: black 1px solid" colSpan="2">
												<asp:label id="lblVerticale" runat="server" CssClass="TitleLabel">Verticale</asp:label></TD>
											<TD style="BORDER-BOTTOM: black 1px solid" colSpan="4">
												<asp:label id="Label1" runat="server" CssClass="TitleLabel">Orizzontale</asp:label></TD>
											<TD style="BORDER-BOTTOM: black 1px solid" colSpan="2">
												<asp:label id="Label3" runat="server" CssClass="TitleLabel">Altro</asp:label></TD>
										</TR>
										<TR>
											<TD>
												<asp:label id="Label5" runat="server" CssClass="label">Installata</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblVertInstallata" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label8" runat="server" CssClass="label">In linea</asp:label></TD>
											<TD style="WIDTH: 15px">
												<asp:label id="lblStalliInLinea" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label11" runat="server" CssClass="label">Canc. in linea</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblStalliCancInLinea" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label14" runat="server" CssClass="label">Fittoni</asp:label></TD>
											<TD>
												<asp:label id="lblFittoni" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR>
											<TD>
												<asp:label id="Label6" runat="server" CssClass="label">Rimossa</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblVertRimossa" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label9" runat="server" CssClass="label">A pettine</asp:label></TD>
											<TD style="WIDTH: 15px">
												<asp:label id="lblStalliAPettine" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label12" runat="server" CssClass="label">Canc. a pettine</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblStalliCancAPettine" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label15" runat="server" CssClass="label">Metri lineari</asp:label></TD>
											<TD>
												<asp:label id="lblMetriLineari" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR>
											<TD>
												<asp:label id="Label7" runat="server" CssClass="label">Sostituita</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblVertSostituita" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label10" runat="server" CssClass="label">Moto</asp:label></TD>
											<TD style="WIDTH: 15px">
												<asp:label id="lblStalliMoto" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label13" runat="server" CssClass="label">Canc. moto</asp:label></TD>
											<TD style="BORDER-RIGHT: black 1px solid">
												<asp:label id="lblStalliCancMoto" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="Label16" runat="server" CssClass="label">Metri quadrati</asp:label></TD>
											<TD>
												<asp:label id="lblMetriQuadrati" runat="server" CssClass="label"></asp:label></TD>
										</TR>
									</TABLE>
								</FIELDSET>
								<BR>
							</asp:panel>
								--><asp:panel id="pnlConteggio" runat="server" Width="600px">
								<FIELDSET><LEGEND class="label">Conteggi</LEGEND>
									<TABLE id="TAbleConteggio" height="100%" cellSpacing="0" width="100%" border="0">
										<TR align="right">
											<TD></TD>
											<TD>
												<asp:label id="LblNuovi" runat="server" CssClass="TitleLabel">Nuovi</asp:label></TD>
											<TD>
												<asp:label id="LblEliminati" runat="server" CssClass="TitleLabel">Eliminati</asp:label></TD>
											<TD>
												<asp:label id="LblRipristinati" runat="server" CssClass="TitleLabel">Ripristinati</asp:label></TD>
											<TD>
												<asp:label id="LblExNovo" runat="server" CssClass="TitleLabel">Ex_Novo</asp:label></TD>
										</TR>
										<TR style="BORDER-TOP: black 1px solid" align="right">
											<TD align="left">
												<asp:label id="LblHPali" runat="server" CssClass="label">Pali</asp:label></TD>
											<TD>
												<asp:label id="LblTPaliNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTPaliEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTPaliRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTPaliExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHCartelli" runat="server" CssClass="label">Cartelli</asp:label></TD>
											<TD>
												<asp:label id="LblTCartelliNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCartelliEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCartelliRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCartelliExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHStalliO" runat="server" CssClass="label">Stalli ordinari</asp:label></TD>
											<TD>
												<asp:label id="LblTStalliONuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliOEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliORipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliOExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHStalliRR" runat="server" Width="184px" CssClass="label">Stalli a rapida rotazione</asp:label></TD>
											<TD>
												<asp:label id="LblTStalliRRNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliRREliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliRRRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTStalliRRExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHResidenti" runat="server" CssClass="label">Residenti</asp:label></TD>
											<TD>
												<asp:label id="LblTResidentiNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTResidentiEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTResidentiRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTResidentiExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHMoto" runat="server" CssClass="label">Stalli moto</asp:label></TD>
											<TD>
												<asp:label id="LblTMotoNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTMotoEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTMotoRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTMotoExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHFittoni" runat="server" CssClass="label">Fittoni</asp:label></TD>
											<TD>
												<asp:label id="LblTFittoniNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFittoniEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFittoniRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFittoniExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHForma" runat="server" CssClass="label">Formaggioni</asp:label></TD>
											<TD>
												<asp:label id="LblTFormaNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFormaEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFormaRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTFormaExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHCarsharing" runat="server" CssClass="label">Carsharing</asp:label></TD>
											<TD>
												<asp:label id="LblTCarNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCarEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCarRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCarExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHDisabili" runat="server" CssClass="label">Disabili</asp:label></TD>
											<TD>
												<asp:label id="LblTDisNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTDisEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTDisRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTDisExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHGenerici" runat="server" CssClass="label">Generici</asp:label></TD>
											<TD>
												<asp:label id="LblTGenNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTGenEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTGenRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTGenExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD style="HEIGHT: 16px" align="left">
												<asp:label id="LblHDiscoOrario" runat="server" CssClass="label">Disco Orario</asp:label></TD>
											<TD style="HEIGHT: 16px">
												<asp:label id="LblTDiscNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD style="HEIGHT: 16px">
												<asp:label id="LblTDiscEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD style="HEIGHT: 16px">
												<asp:label id="LblTDiscRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD style="HEIGHT: 16px">
												<asp:label id="LblTDiscExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
										<TR align="right">
											<TD align="left">
												<asp:label id="LblHCaricoS" runat="server" CssClass="label">Carico scarico</asp:label></TD>
											<TD>
												<asp:label id="LblTCaricoSNuovi" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCaricoSEliminati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCaricoSRipristinati" runat="server" CssClass="label"></asp:label></TD>
											<TD>
												<asp:label id="LblTCaricoSExNovo" runat="server" CssClass="label"></asp:label></TD>
										</TR>
									</TABLE>
								</FIELDSET>
								<BR>
							</asp:panel><asp:panel id="pnlRisultati" runat="server" Width="600px" Visible="False">
								<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Risultati</LEGEND>
									<asp:datagrid id=dgLavoriStradali runat="server" Width="100%" CssClass="griglia" DataMember="LavoriStradali" DataSource="<%# DsValori %>" Visible="False" BorderColor="#CCCCCC" AllowPaging="True" CellPadding="2" ForeColor="Black" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id">
										<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
										<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
										<HeaderStyle Font-Size="11pt" Font-Names="Times New Roman" Font-Bold="True" ForeColor="White"
											CssClass="RigaDataGrid" BackColor="#990033"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="Id"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="IdVia" SortExpression="IdVia" HeaderText="IdVia"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nome" SortExpression="Nome" HeaderText="Toponimo"></asp:BoundColumn>
											<asp:BoundColumn DataField="Zona" SortExpression="Zona" HeaderText="Zona"></asp:BoundColumn>
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
													<!-- a href="javascript:void(0)" onClick="javascript:window.open('<%# DataBinder.Eval(Container, "DataItem.Id", "frmViewPianoSosta.aspx?Id={0}") %>', 'Piano_Sosta', 'width=600,height=500')"-->
													<asp:LinkButton runat="server" Text="Visualizza" CommandName="View" CausesValidation="false" ID="Linkbutton4">
														<IMG alt="Dettaglio" src="images/File_View.gif" border="0" width="24" height="24">
													</asp:LinkButton>
													<!--/a-->
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="Titolo" HeaderText="Titolo"></asp:BoundColumn>
											<asp:BoundColumn DataField="DataInizio" SortExpression="DataInizio" HeaderText="Inizio" DataFormatString="{0:d}"></asp:BoundColumn>
											<asp:BoundColumn DataField="DataFine" SortExpression="DataFine" HeaderText="Fine" DataFormatString="{0:d}"></asp:BoundColumn>
										</Columns>
										<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
											CssClass="Descrizione"></PagerStyle>
									</asp:datagrid>
									<asp:label id="lblMessage" runat="server" CssClass="Label" Visible="False">Non sono presenti lavori stradali che soddisfano questi criteri di ricerca.</asp:label></FIELDSET>
								<BR>
							</asp:panel><asp:panel id="pnlModifica" runat="server" Width="600px" Visible="False">
								<FIELDSET style="LEFT: 0px; WIDTH: 100%; TOP: -8px"><LEGEND class="label">Lavoro 
										stradale</LEGEND><asp:textbox id="txtDEIdVia" runat="server" Width="64px"></asp:textbox><asp:textbox id="txtDEId" runat="server" Width="48px"></asp:textbox><asp:textbox id="txtDEFile" runat="server" Width="48px"></asp:textbox><asp:textbox id="txtDEExt" runat="server" Width="48px"></asp:textbox><asp:validationsummary id="ValidationSummary1" runat="server" Width="100%" CssClass="lblerror" HeaderText="Attenzione si sono verificati i seguenti errori:"></asp:validationsummary>
									<TABLE id="Table5" style="WIDTH: 100%; HEIGHT: 154px" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD class="label" style="HEIGHT: 23px">
												<TABLE id="Table8" cellSpacing="0" cellPadding="2" width="100%" border="0">
													<TBODY>
														<TR>
															<TD class="label" align="center" colSpan="3"><asp:label id="lblDEVia" runat="server" CssClass="titlelabel"></asp:label></TD>
											</TD>
										</TR>
										<TR>
											<TD class="label" style="WIDTH: 335px" colSpan="2">Titolo</TD>
											<td class="label">Ordinanza</td>
										</TR>
										<TR>
											<TD style="WIDTH: 335px" colSpan="2"><asp:textbox id="txtDETitle" runat="server" Width="355px" CssClass="TextFieldInput"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" CssClass="lblError" ErrorMessage='"Titolo" campo obbligatorio'
													ControlToValidate="txtDETitle" Display="None"></asp:requiredfieldvalidator></TD>
											<td><asp:textbox id="txtDEOrdinanza" runat="server" Width="166px" CssClass="TextFieldInput" Height="17px"></asp:textbox></td>
										</TR>
									</TABLE></TD>
					</TR>
					<TR>
						<TD class="label" style="HEIGHT: 24px">
							<TABLE id="Table7" cellSpacing="0" cellPadding="2" width="100%" border="0">
								<TR>
									<TD class="label" width="33%">Tipo</TD>
									<TD class="label" style="WIDTH: 190px" width="190">Data&nbsp;inizio&nbsp;(gg/mm/aaaa)</TD>
									<TD class="label" width="33%">Data&nbsp;fine&nbsp;(gg/mm/aaaa)</TD>
								</TR>
								<TR>
									<TD><asp:dropdownlist id=cboDETipo runat="server" Width="166px" CssClass="TextFieldInput" DataValueField="IdTipo" DataTextField="Tipo" DataMember="LavoriStradaliTipi" DataSource="<%# DsValori %>">
										</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" CssClass="lblError" ErrorMessage='"Tipo" campo obbligatorio'
											ControlToValidate="cboDETipo" Display="None"></asp:requiredfieldvalidator></TD>
									<TD style="WIDTH: 190px"><asp:textbox id="txtDEDataInizio" runat="server" Width="168px" CssClass="TextFieldInput" Height="17"></asp:textbox><asp:rangevalidator id="RangeValidator3" runat="server" CssClass="lblError" ErrorMessage='"Data inizio" deve essere una data valida'
											ControlToValidate="txtDEDataInizio" Type="Date" MaximumValue="9999/12/31" MinimumValue="1900/1/1" Display="None"></asp:rangevalidator><asp:regularexpressionvalidator id="RegularExpressionValidator3" runat="server" CssClass="lblerror" ErrorMessage='"Data inizio" deve essere una data valida'
											ControlToValidate="txtDEDataInizio" ValidationExpression="\d{2}/\d{2}/\d{4}" Display="None"></asp:regularexpressionvalidator></TD>
									<TD><asp:textbox id="txtDEDataFine" runat="server" Width="166px" CssClass="TextFieldInput" Height="17"></asp:textbox><asp:rangevalidator id="RangeValidator4" runat="server" CssClass="lblError" ErrorMessage='"Data fine" deve essere una data valida'
											ControlToValidate="txtDEDataFine" Type="Date" MaximumValue="9999/12/31" MinimumValue="1900/1/1" Display="None"></asp:rangevalidator><asp:regularexpressionvalidator id="RegularExpressionValidator4" runat="server" CssClass="lblerror" ErrorMessage='"Data fine" deve essere una data valida'
											ControlToValidate="txtDEDataFine" ValidationExpression="\d{2}/\d{2}/\d{4}" Display="None"></asp:regularexpressionvalidator></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD class="label">
							<TABLE id="Table6" cellSpacing="0" cellPadding="2" width="100%" border="0">
								<TR>
									<TD class="label" width="33%">Zona</TD>
									<TD class="label" width="34%">Causale</TD>
									<TD class="label" style="WIDTH: 136px" width="136">Esecutore</TD>
								</TR>
								<TR>
									<TD class="label" style="HEIGHT: 17px" width="33%"><asp:dropdownlist id=cboDEZona runat="server" Width="168px" CssClass="TextFieldInput" DataValueField="IdZona" DataTextField="Zona" DataMember="LavoriStradaliZone" DataSource="<%# DsValori %>">
										</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" CssClass="lblError" ErrorMessage='"Zona" campo obbligatorio'
											ControlToValidate="cboDEZona" Display="None"></asp:requiredfieldvalidator></TD>
									<TD class="label" style="HEIGHT: 17px" width="34%"><asp:dropdownlist id=cboDECausale runat="server" Width="168px" CssClass="TextFieldInput" DataValueField="IdCausale" DataTextField="Causale" DataMember="LavoriStradaliCausali" DataSource="<%# DsValori %>">
										</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" CssClass="lblError" ErrorMessage='"Causale" campo obbligatorio'
											ControlToValidate="cboDECausale" Display="None"></asp:requiredfieldvalidator></TD>
									<TD class="label" style="WIDTH: 136px; HEIGHT: 17px" width="136"><asp:dropdownlist id=cboDEEsecutore runat="server" Width="168px" CssClass="TextFieldInput" DataValueField="IdEsecutore" DataTextField="Esecutore" DataMember="LavoriStradaliEsecutori" DataSource="<%# DsValori %>">
										</asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" CssClass="lblError" ErrorMessage='"Esecutore" campo obbligatorio'
											ControlToValidate="cboDEEsecutore" Display="None"></asp:requiredfieldvalidator></TD>
								</TR>
								<!--TR>
											<TD class="label" width="33%"></TD>
											<TD class="label" width="34%"></TD>
											<TD class="label" style="WIDTH: 136px" width="136"></TD>
										</TR>
										<TR>
											<TD class="label" width="33%">Visualizza file</TD>
											<TD class="label" width="34%">Cancella file</TD>
											<TD class="label" style="WIDTH: 136px" width="136">Inserisci file</TD>
										</TR>
										<TR>
											<TD><asp:hyperlink id="btnView" runat="server" Target="_blank" ImageUrl="images/File_View.gif"></asp:hyperlink></TD>
											<TD width="34%"><asp:imagebutton id="btnDelete" runat="server" ImageUrl="images/File_Delete.gif" AlternateText="Elimina"></asp:imagebutton></TD>
											<TD vAlign="middle"><INPUT class="TextFieldInput" id="OrdFile" style="WIDTH: 97.24%; HEIGHT: 17px" type="file"
													size="10" name="File" runat="server">
											</TD>
										</TR--></TABLE>
						</TD>
					</TR>
					<TR>
						<TD class="label">
							<TABLE id="Table9" cellSpacing="0" cellPadding="2" width="100%" border="0">
								<TR>
									<TD class="label">
										<P>Descrizione</P>
									</TD>
								</TR>
								<TR>
									<TD><asp:textbox id="txtDETesto" runat="server" Width="100%" CssClass="TextFieldInput" Height="64px"
											rows="25" TextMode="MultiLine"></asp:textbox></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<tr>
						<td>
							<TABLE id="TABLEQtaTipi" cellSpacing="0" cellPadding="2" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 125px; HEIGHT: 22px"></TD>
									<TD style="WIDTH: 122px; HEIGHT: 22px"><asp:label id="Label2" runat="server" CssClass="TitleLabel">Nuovi</asp:label></TD>
									<TD style="WIDTH: 125px; HEIGHT: 22px"><asp:label id="Label4" runat="server" CssClass="TitleLabel">Eliminati</asp:label></TD>
									<TD style="HEIGHT: 22px"><asp:label id="Label17" runat="server" CssClass="TitleLabel">Ripristinati</asp:label></TD>
									<TD style="HEIGHT: 22px"><asp:label id="LabeX" runat="server" CssClass="TitleLabel">Ex_Novo</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label18" runat="server" CssClass="label">Pali</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtPaliNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV1" runat="server" CssClass="lblerror" ErrorMessage='"Pali nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtPaliNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtPaliEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV2" runat="server" CssClass="lblerror" ErrorMessage='"Pali eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtPaliEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtPaliRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="R3" runat="server" CssClass="lblerror" ErrorMessage='"Pali ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtPaliRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtPaliExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator12" runat="server" CssClass="lblerror" ErrorMessage='"Pali ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtPaliExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label22" runat="server" CssClass="label">Cartelli</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtCartelliNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV4" runat="server" CssClass="lblerror" ErrorMessage='"Cartelli nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtCartelliNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCartelliEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV5" runat="server" CssClass="lblerror" ErrorMessage='"Cartelli eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtCartelliEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCartelliRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV6" runat="server" CssClass="lblerror" ErrorMessage='"Cartelli ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtCartelliRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCartelliExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator11" runat="server" CssClass="lblerror" ErrorMessage='"Cartelli ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtCartelliExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label26" runat="server" CssClass="label">Stalli ordinari</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtStalliONuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV7" runat="server" CssClass="lblerror" ErrorMessage='"Stalli ordinari nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtStalliONuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliOEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV8" runat="server" CssClass="lblerror" ErrorMessage='"Stalli ordinari eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtStalliOEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliORipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV9" runat="server" CssClass="lblerror" ErrorMessage='"Stalli ordinari ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtStalliORipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliOExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator10" runat="server" CssClass="lblerror" ErrorMessage='"Stalli ordinari ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtStalliOExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 145px"><asp:label id="Label30" runat="server" Width="140px" CssClass="label">Stalli a rapida rotazione</asp:label></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliRRNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV10" runat="server" CssClass="lblerror" ErrorMessage='"Stalli a rapita rotazione nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtStalliRRNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliRREliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV11" runat="server" CssClass="lblerror" ErrorMessage='"Stalli a rapita rotazione eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtStalliRREliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliRRRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV12" runat="server" CssClass="lblerror" ErrorMessage='"Stalli a rapita rotazione ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtStalliRRRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtStalliRRExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator9" runat="server" CssClass="lblerror" ErrorMessage='"Stalli a rapita rotazione ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtStalliOExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label34" runat="server" CssClass="label">Residenti</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtResidentiNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV13" runat="server" CssClass="lblerror" ErrorMessage='"Residenti nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtResidentiNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtResidentiEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV14" runat="server" CssClass="lblerror" ErrorMessage='"Residenti eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtResidentiEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtResidentiRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV15" runat="server" CssClass="lblerror" ErrorMessage='"Residenti ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtResidentiRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtResidentiExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator8" runat="server" CssClass="lblerror" ErrorMessage='"Residenti ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtResidentiExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px; HEIGHT: 22px"><asp:label id="Label38" runat="server" CssClass="label">Stalli moto</asp:label></TD>
									<TD style="WIDTH: 122px; HEIGHT: 22px"><asp:textbox id="TxtMotoNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV16" runat="server" CssClass="lblerror" ErrorMessage='"Stalli moto nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtMotoNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px; HEIGHT: 22px"><asp:textbox id="TxtMotoEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV17" runat="server" CssClass="lblerror" ErrorMessage='"Stalli moto eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtMotoEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px; HEIGHT: 22px"><asp:textbox id="TxtMotoRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV18" runat="server" CssClass="lblerror" ErrorMessage='"Stalli moto ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtMotoRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px; HEIGHT: 22px"><asp:textbox id="TxtMotoExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator7" runat="server" CssClass="lblerror" ErrorMessage='"Stalli moto ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtMotoExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label42" runat="server" CssClass="label">Fittoni</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtFittoniNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV19" runat="server" CssClass="lblerror" ErrorMessage='"Fittoni nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtFittoniNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFittoniEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV20" runat="server" CssClass="lblerror" ErrorMessage='"Fittoni eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtFittoniEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFittoniRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV21" runat="server" CssClass="lblerror" ErrorMessage='"Fittoni ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtFittoniRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFittoniExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator6" runat="server" CssClass="lblerror" ErrorMessage='"Fittoni ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtFittoniExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label46" runat="server" CssClass="label">Formaggioni</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtFormaNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV22" runat="server" CssClass="lblerror" ErrorMessage='"Formaggioni nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtFormaNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFormaEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV23" runat="server" CssClass="lblerror" ErrorMessage='"Formaggioni eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtFormaEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFormaRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="RV24" runat="server" CssClass="lblerror" ErrorMessage='"Formaggioni ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtFormaRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtFormaExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator5" runat="server" CssClass="lblerror" ErrorMessage='"Formaggioni ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtFormaExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label1c" runat="server" CssClass="label">Carsharing</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtCarNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator13" runat="server" CssClass="lblerror" ErrorMessage='"Carsharing nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtCarNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCarEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator14" runat="server" CssClass="lblerror" ErrorMessage='"Carsharing eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtCarEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCarRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator15" runat="server" CssClass="lblerror" ErrorMessage='"Carsharing ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtCarRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCarExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator16" runat="server" CssClass="lblerror" ErrorMessage='"Carsharing ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtCarExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label3d" runat="server" CssClass="label">Disabili</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtDisabiliNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator17" runat="server" CssClass="lblerror" ErrorMessage='"Disabili nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtDisabiliNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDisabiliEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator18" runat="server" CssClass="lblerror" ErrorMessage='"Disabili eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtDisabiliEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDisabiliRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator19" runat="server" CssClass="lblerror" ErrorMessage='"Disabili ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtDisabiliRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDisabiliExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator20" runat="server" CssClass="lblerror" ErrorMessage='"Disabili ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtDisabiliExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label5g" runat="server" CssClass="label">Generici</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtGenNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator21" runat="server" CssClass="lblerror" ErrorMessage='"Generici nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtGenNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtGenEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator22" runat="server" CssClass="lblerror" ErrorMessage='"Generici eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtGenEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtGenRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator23" runat="server" CssClass="lblerror" ErrorMessage='"Generici ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtGenRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtGenExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator24" runat="server" CssClass="lblerror" ErrorMessage='"Generici ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtGenExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="Label6d" runat="server" CssClass="label">Disco orario</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtDiscNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator25" runat="server" CssClass="lblerror" ErrorMessage='"Disco orario nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtDiscNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDiscEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator26" runat="server" CssClass="lblerror" ErrorMessage='"Disco orario eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtDiscEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDiscRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator27" runat="server" CssClass="lblerror" ErrorMessage='"Disco orario ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtDiscRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtDiscExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rangevalidator28" runat="server" CssClass="lblerror" ErrorMessage='"Disco orario ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtDiscExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 125px"><asp:label id="LhCaricoScarico" runat="server" CssClass="label">Carico Scarico</asp:label></TD>
									<TD style="WIDTH: 122px"><asp:textbox id="TxtCaricoSNuovi" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rv29" runat="server" CssClass="lblerror" ErrorMessage='"Carico/scarico nuovi" deve essere un valore numerico.'
											ControlToValidate="TxtCaricoSNuovi" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCaricoSEliminati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rv30" runat="server" CssClass="lblerror" ErrorMessage='"Carico/scarico eliminati" deve essere un valore numerico.'
											ControlToValidate="TxtCaricoSEliminati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCaricoSRipristinati" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rv31" runat="server" CssClass="lblerror" ErrorMessage='"Carico/scarico ripristinati" deve essere un valore numerico.'
											ControlToValidate="TxtCaricoSRipristinati" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
									<TD style="WIDTH: 125px"><asp:textbox id="TxtCaricoSExNovo" runat="server" Width="104px" CssClass="TextFieldInput">0</asp:textbox><asp:rangevalidator id="Rv32" runat="server" CssClass="lblerror" ErrorMessage='"Carico/scarico ex_novo" deve essere un valore numerico.'
											ControlToValidate="TxtCaricoSExNovo" Type="Integer" MaximumValue="99999" MinimumValue="0" Display="None"></asp:rangevalidator></TD>
								</TR>
							</TABLE>
						</td>
					</tr>
				</TABLE>
				<P align="center"><asp:button id="btnSave" runat="server" CssClass="Bottone" Text="Salva"></asp:button>&nbsp;
					<asp:button id="btnCancel" runat="server" CssClass="Bottone" Text="Annulla" CausesValidation="False"></asp:button></P>
				</FIELDSET> </asp:panel></TD></TR></TBODY></TABLE></div>
		</form>
	</body>
</HTML>
