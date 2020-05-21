<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestioneblocchi.aspx.vb" Inherits="ATCBussm1.wf_gestioneblocchi" smartNavigation="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gestioneblocchi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Blocco 
					cambi turno giornaliero</legend>
				<p>I blocchi sono ordinate per il campo "Data inizio" in maniera crescente.<br>
				</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricola" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricola" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStato" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStato" runat="server">
								<OPTION title="Tutti" value="Tutti"></OPTION>
								<OPTION title="Attivi" value="Attivi" selected></OPTION>
								<OPTION title="Terminati" value="Terminati"></OPTION>
								<OPTION title="Annullati" value="Annullati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiorno" Runat="server" CssClass="label">Data inizio blocco: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DataInizio" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="btnFiltro" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
					<tr>
						<td colSpan="5"><asp:button id="BtnNuovo" runat="server" CssClass="bottone" Text="Nuovo blocco"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgBlocchiGiornalieri runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="Accertatori_BloccoCambioGiornaliero" DataKeyField="ID" DataSource="<%# DsBlocco1 %>" UseAccessibleHeader="True">
					<Columns>
						<asp:BoundColumn DataField="ID" SortExpression="ID" ReadOnly="True" Visible="false" HeaderText="ID"></asp:BoundColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lnkModifica" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica" Visible= '<%#  DataBinder.Eval(Container, "DataItem.Stato")="Attivo" %>'>Modifica</asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="LinkButton3" runat="server" CommandName="Update" Text="Ok"></asp:LinkButton>&nbsp;
								<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Data inizio">
							<ItemTemplate>
								<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.InizioOn", "{0:d}") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Calendar id="caInizioOn" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.InizioOn") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.InizioOn") %>'>
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
						<asp:TemplateColumn HeaderText="Inserito da">
							<ItemTemplate>
								<asp:Label id="LblInseritoDa" runat="server" Text='<%#  DataBinder.Eval(Container, "DataItem.InseritoDa") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Operatore di mobilità">
							<ItemTemplate>
								<asp:Label id="Label2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CognomeNome") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:DropDownList id="ddlOperatore" runat="server" DataMember="ATC_Utenti" DataSource="<%# DsBlocco1 %>" DataValueField="ID" DataTextField="CognomeNome" SelectedValue='<%# DataBinder.Eval(Container, "DataItem.AccertatoreId") %>' >
								</asp:DropDownList>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Motivo">
							<ItemTemplate>
								<asp:Label id="Label3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Motivo") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox ID="txtMotivo" Runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Motivo") %>' TextMode="MultiLine">
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Data fine blocco">
							<ItemTemplate>
								<asp:Label id="LblFineOn" runat="server" Text='<%#  DataBinder.Eval(Container, "DataItem.FineOn") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Calendar id="caFineOn" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.FineOn") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.FineOn") %>'>
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
						<asp:TemplateColumn HeaderText="Terminato da">
							<ItemTemplate>
								<asp:Label id="LblTerminatoDa" runat="server" Text='<%#  DataBinder.Eval(Container, "DataItem.TerminatoDa") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Stato del blocco">
							<ItemTemplate>
								<asp:Label id="LblStato" runat="server" Text='<%#  DataBinder.Eval(Container, "DataItem.Stato") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lnkTermina" runat="server" CausesValidation="False" CommandName="Termina" Text="Termina" Visible= '<%#  DataBinder.Eval(Container, "DataItem.Stato")="Attivo" %>'>Termina</asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lnkAnnulla" runat="server" CausesValidation="False" CommandName="Annulla" Text="Annulla" Visible= '<%#  DataBinder.Eval(Container, "DataItem.Stato")="Attivo" %>'>Annulla blocco</asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
							</EditItemTemplate>
						</asp:TemplateColumn>
					</Columns>
				</asp:datagrid></fieldset>
			&nbsp;
			<br>
			&nbsp;
			<br>
			&nbsp;
			<br>
			&nbsp;
			<br>
			&nbsp;
			<br>
			&nbsp;
		</form>
	</body>
</HTML>
