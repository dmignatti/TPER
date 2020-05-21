<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestioneperiodipreno.aspx.vb" Inherits="ATCBussm1.wf_gestioneperiodipreno"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ferie</title>
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
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" alt="" align="left" src="images/corner_tl.gif"
							width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" align="right" src="images/corner_tr.gif"
							width="4" height="4"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; HEIGHT: 287px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Periodo di prenotazione ferie<br>
							<span class="label">(I periodi di prenotazione sono in ordine decrescente&nbsp;dal 
								più recente al più vecchio.)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Attenzione!" CssClass="Error"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsPrenotazione1, "Tables[Accertatori_PrenotazioniPeriodo]").Rows.Count <= 0 %>'>Non ci sono stati definiti periodi di prenotazione ferie.</asp:label><asp:button id="btnAddPeriodo" runat="server" CssClass="bottone" CausesValidation="False" Text="Nuovo periodo di prenotazione ferie"></asp:button><asp:datagrid id=dgPeriodoPrenotazione runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsPrenotazione1, "Tables[Accertatori_PrenotazioniPeriodo]").Rows.Count > 0 %>' DataSource="<%# DsPrenotazione1 %>" DataMember="Accertatori_PrenotazioniPeriodo" DataKeyField="ID" UseAccessibleHeader="True" AutoGenerateColumns="False" GridLines="None">
							<Columns>
								<asp:BoundColumn DataField="ID" SortExpression="ID" ReadOnly="True" Visible="false" HeaderText="ID"></asp:BoundColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkModifica" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica">Modifica</asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="LinkButton3" runat="server" CommandName="Update" Text="Ok"></asp:LinkButton>&nbsp;
										<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Pubblicato">
									<ItemTemplate>
										<asp:CheckBox id ="chkpub" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Pubblicato") %>' Enabled ="false" >
										</asp:CheckBox>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:CheckBox id ="Pubblicato" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Pubblicato") %>' Enabled ="true" >
										</asp:CheckBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Nome">
									<ItemTemplate>
										<asp:Label id="Label5" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.Nome") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Nome" runat="server" Width="250px" TextMode="MultiLine" Rows="3" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Prenotabile Da">
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caPrenotabileDa" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDa") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="XX-Small" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Ora Da">
									<ItemTemplate>
										<asp:Label id="Label6" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaOra") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="PrenotabileDaOra" runat="server" MaxLength="2" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaOra") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Minuti Da">
									<ItemTemplate>
										<asp:Label id="Label7" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaMinuti") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="PrenotabileDaMinuti" runat="server" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileDaMinuti") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Prenotabile A">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caPrenotabileA runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PrenotabileA") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="XX-Small" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Periodo Da">
									<ItemTemplate>
										<asp:Label id="Label3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caPeriodoDa" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoDa") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="XX-Small" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Periodo A">
									<ItemTemplate>
										<asp:Label id="Label4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PeriodoA", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caPeriodoA runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoA") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.PeriodoA") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="XX-Small" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Max interv.">
									<ItemTemplate>
										<asp:Label id="lblnumint" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.NumMaxIntervalli") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="NumMaxIntervalli" runat="server" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.NumMaxIntervalli") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><asp:customvalidator id="cvOnModifica" runat="server" ErrorMessage="Non è possibile modificare o eliminare questa richiesta."
							Display="None"></asp:customvalidator></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
