<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestioneintervallipreno.aspx.vb" Inherits="ATCBussm1.wf_gestioneintervallipreno"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Gestione intervalli prenotazione</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table id="Table01" class="Back" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<TBODY>
					<tr>
						<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
								width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
								width="4" height="4">
						</td>
					</tr>
					<tr>
						<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
							vAlign="top">
							<h6>Periodo di prenotazione selezionato:</SPAN></h6>
							<asp:datalist id=DlPeriodoPrenotazione runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsPrenotazioneM1, "Tables[Accertatori_PrenotazioniPeriodo]").Rows.Count > 0 %>' DataSource="<%# DsPrenotazioneM1 %>" DataMember="Accertatori_PrenotazioniPeriodo" DataKeyField="ID" UseAccessibleHeader="True" GridLines="Both" BorderColor="#CC9966" BackColor="White" BorderStyle="None" CellPadding="4" BorderWidth="1px">
								<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
								<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
								<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
								<ItemTemplate>
									<TABLE width="100%">
										<TR>
											<TD>
												<asp:Label id="lbl" CssClass="TitleLabel" Runat="server">
										Nome periodo: 
									</asp:Label>
												<asp:Label id="Label3" CssClass="Grid" Runat="server">
													<%# DataBinder.Eval(Container, "DataItem.Nome") %>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label5" CssClass="TitleLabel" Runat="server">
										Pubblicato: 
									</asp:Label>
												<asp:CheckBox id=chkpubb CssClass="Grid" Runat="server" checked='<%# DataBinder.Eval(Container, "DataItem.Pubblicato") %>' Enabled="False">
												</asp:CheckBox></TD>
											<TD colSpan="4">
												<asp:Label id="Label4" CssClass="TitleLabel" Runat="server">
										Numero max di intervalli previsti: 
									</asp:Label>
												<asp:Label id="Label7" CssClass="Grid" Runat="server">
													<%# DataBinder.Eval(Container, "DataItem.NumMaxIntervalli") %>
												</asp:Label></TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="Label6" CssClass="TitleLabel" Runat="server">
										Prenotabile da: 
									</asp:Label>
												<asp:Label id=Label9 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa", "{0:d}") %>'>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label23" CssClass="TitleLabel" Runat="server">
										Minuti: 
									</asp:Label>
												<asp:Label id="Label25" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaOra") %>'>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label27" CssClass="TitleLabel" Runat="server">
										Ora: 
									</asp:Label>
												<asp:Label id="Label28" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaMinuti") %>'>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label10" CssClass="TitleLabel" Runat="server">
										Prenotabile a: 
									</asp:Label>
												<asp:Label id=Label11 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA", "{0:d}") %>'>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label13" CssClass="TitleLabel" Runat="server">
										Periodo da: 
									</asp:Label>
												<asp:Label id=Label12 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa", "{0:d}") %>'>
												</asp:Label></TD>
											<TD>
												<asp:Label id="Label14" CssClass="TitleLabel" Runat="server">
										Periodo a: 
									</asp:Label>
												<asp:Label id=Label15 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PeriodoA", "{0:d}") %>'>
												</asp:Label></TD>
										</TR>
										<TR>
											<TD colSpan="4">
												<asp:LinkButton id="BtnModifica" runat="server" Text="Modifica" CausesValidation="True" CommandName="Edit"></asp:LinkButton></TD>
										</TR>
									</TABLE>
								</ItemTemplate>
								<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
								<EditItemTemplate>
									<TABLE width="100%">
										<TR>
											<TD colSpan="2">
												<asp:Label id="Label8" CssClass="TitleLabel" Runat="server">
										Nome periodo: 
									</asp:Label>
												<asp:TextBox ID="Nome" Runat="server" text ='<%# DataBinder.Eval(Container, "DataItem.Nome") %>' TextMode="MultiLine" Width="250px">
												</asp:TextBox>
											</TD>
											<TD>
												<asp:Label id="Label17" CssClass="TitleLabel" Runat="server">
										Pubblicato: 
									</asp:Label>
												<asp:CheckBox id="Pubblicato" CssClass="Grid" Runat="server" checked='<%# DataBinder.Eval(Container, "DataItem.Pubblicato") %>' Enabled="true">
												</asp:CheckBox></TD>
											<TD>
												<asp:Label id="Label18" CssClass="TitleLabel" Runat="server">
										Numero max di intervalli previsti: 
									</asp:Label>
												<asp:TextBox ID="NumMaxIntervalli" Runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.NumMaxIntervalli") %>'>
												</asp:TextBox>
											</TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="Label20" CssClass="TitleLabel" Runat="server">
										Prenotabile da: 
									</asp:Label>
												<asp:Calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="caPrenotabileDa" runat="server" BackColor="White" BorderColor="#999999" CssClass="grid" Width="112" DayNameFormat="FirstLetter" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa") %>' Height="68">
													<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
													<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
													<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
													<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
													<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
													<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
													<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
													<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
												</asp:Calendar></TD>
											<TD>
												<asp:Label id="Label19" CssClass="TitleLabel" Runat="server">
										Ora: 
									</asp:Label>
												<asp:TextBox ID="txtDAOra" Runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaOra") %>'>
												</asp:TextBox>
											</TD>
											<TD>
												<asp:Label id="Label21" CssClass="TitleLabel" Runat="server">
										Minuti: 
									</asp:Label>
												<asp:TextBox ID="txtDAMinuti" Runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaMinuti") %>'>
												</asp:TextBox>
											</TD>
											<TD>
												<asp:Label id="Label22" CssClass="TitleLabel" Runat="server">
										Prenotabile a: 
									</asp:Label>
												<asp:Calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="caPrenotabileA" runat="server" BackColor="White" BorderColor="#999999" CssClass="grid" Width="112" DayNameFormat="FirstLetter" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA") %>' Height="68">
													<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
													<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
													<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
													<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
													<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
													<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
													<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
													<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
												</asp:Calendar>
											</TD>
											<TD>
												<asp:Label id="Label24" CssClass="TitleLabel" Runat="server">
										Periodo da: 
									</asp:Label>
												<asp:Calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="caPeriodoDa" runat="server" BackColor="White" BorderColor="#999999" CssClass="grid" Width="112" DayNameFormat="FirstLetter" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa") %>' Height="68">
													<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
													<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
													<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
													<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
													<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
													<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
													<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
													<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
												</asp:Calendar></TD>
											<TD>
												<asp:Label id="Label26" CssClass="TitleLabel" Runat="server">
										Periodo a: 
									</asp:Label>
												<asp:Calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="caPeriodoA" runat="server" BackColor="White" BorderColor="#999999" CssClass="grid" Width="112" DayNameFormat="FirstLetter" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoA") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoA") %>' Height="68">
													<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
													<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
													<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
													<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
													<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
													<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
													<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
													<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
												</asp:Calendar></TD>
										</TR>
										<TR>
											<TD colSpan="4">
												<asp:LinkButton id="lnkSave" runat="server" Text="Salva" CausesValidation="true" CommandName="Update"></asp:LinkButton>&nbsp&nbsp
												<asp:LinkButton id="lnkCancel" runat="server" Text="Annulla" CausesValidation="false" CommandName="Cancel"></asp:LinkButton>
											</TD>
										</TR>
									</TABLE>
								</EditItemTemplate>
							</asp:datalist></td>
					</tr>
					<TR>
						<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
							vAlign="top">
							<h6>Intervalli di prenotazione ferie relativi al periodo sopra indicato<br>
								<span class="label">(Gli intervalli di prenotazione sono in ordine 
									crescente&nbsp;dal più vecchio al più recente.)</span></h6>
							<hr SIZE="1" noShade>
							<asp:validationsummary id="vsErrori" runat="server" Width="100%" CssClass="Error" HeaderText="Attenzione!" ValidationGroup="Pippo"></asp:validationsummary><asp:label id=lblIntervalli runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsPrenotazione1, "Tables[Accertatori_PrenotazioneIntervalli]").Rows.Count <= 0 %>'>Non sono stati definiti intervalli di prenotazione ferie.</asp:label><asp:button id="btnAddIntervallo" runat="server" CssClass="bottone" CausesValidation="False"
								Text="Nuovo intervallo di prenotazione ferie"></asp:button><asp:datagrid id=dgIntervalloPrenotazione runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsPrenotazione1, "Tables[Accertatori_PrenotazioneIntervalli]").Rows.Count > 0 %>' DataSource="<%# DsPrenotazione1 %>" DataMember="Accertatori_PrenotazioneIntervalli" DataKeyField="ID" UseAccessibleHeader="True" GridLines="None" AutoGenerateColumns="False">
								<Columns>
									<asp:BoundColumn DataField="ID" SortExpression="ID" ReadOnly="True" Visible="false" HeaderText="ID"></asp:BoundColumn>
									<asp:TemplateColumn>
										<ItemTemplate>
											<asp:LinkButton id="lnkModifica" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica" Enabled='<%# DataBinder.Eval(Container, "DataItem.NumPrenotati")=0 %>'>Modifica</asp:LinkButton>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:LinkButton id="LinkButton3" runat="server" CommandName="Update" Text="Ok"></asp:LinkButton>&nbsp;
											<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="Nome" SortExpression="Nome" ReadOnly="True" Visible="true" HeaderText="Nome"></asp:BoundColumn>
									<asp:BoundColumn DataField="Accertatori_PrenotazioniPeriodoId" SortExpression="Accertatori_PrenotazioniPeriodoId"
										ReadOnly="True" Visible="false" HeaderText="Accertatori_PrenotazioniPeriodoId"></asp:BoundColumn>
									<asp:TemplateColumn HeaderText="Intervallo Da">
										<ItemTemplate>
											<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IntervalloDa", "{0:d}") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:Calendar id="caIntervalloDa" runat="server" Width="200px" CssClass="grid" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.IntervalloDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.IntervalloDa") %>'>
												<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
												<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
												<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
												<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
												<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
												<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
												<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
												<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
											</asp:Calendar>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn HeaderText="Intervallo A">
										<ItemTemplate>
											<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IntervalloA", "{0:d}") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:Calendar id="caIntervalloA" runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.IntervalloA") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.IntervalloA") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
												<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
												<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
												<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
												<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
												<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
												<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
												<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
												<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
											</asp:Calendar>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:TemplateColumn HeaderText="Num. max prenotazioni">
										<ItemTemplate>
											<asp:Label id="Label16" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.MaxPrenotazione") %>'>
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox ID="MaxPrenotazione" Runat ="server" Text='<%# DataBinder.Eval(Container, "DataItem.MaxPrenotazione") %>'>
											</asp:TextBox>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="NumPrenotati" SortExpression="NumPrenotati" ReadOnly="True" HeaderText="Num. prenotati"></asp:BoundColumn>
									<asp:BoundColumn DataField="UltimaPrenotazione" SortExpression="UltimaPrenotazione" ReadOnly="True"
										HeaderText="Ultima prenotazione"></asp:BoundColumn>
									<asp:TemplateColumn>
										<ItemTemplate>
											<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" Enabled='<%# DataBinder.Eval(Container, "DataItem.NumPrenotati")=0 %>' >Elimina</asp:LinkButton>
										</ItemTemplate>
									</asp:TemplateColumn>
								</Columns>
							</asp:datagrid><asp:customvalidator id="cvOnModifica" runat="server" ErrorMessage="Non è possibile modificare o eliminare questa richiesta."
								Display="None"></asp:customvalidator></td>
					</TR>
					<tr>
						<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
								src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
								src="images/corner_br.gif" width="4" height="4"></td>
					</tr>
				</TBODY>
			</table>
		</form>
		</TR></TBODY></TABLE></FORM>
	</body>
</HTML>
