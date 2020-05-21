<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_ferie_congedi.aspx.vb" Inherits="ATCBussm1.wf_ferie_congedi" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ferie_congedi</title>
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; HEIGHT: 100px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Richiesta ferie:<br>
							<span class="label">(Le richieste sono in ordine decrescente&nbsp;dalla più recente 
								alla più vecchia.<br>
								Vengono mostrate solamente le richieste che si riferiscono a periodi futuri)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichiesteFerie1, "Tables[RichiesteFerie]").Rows.Count <= 0 %>'>Non ci sono richieste.</asp:label><asp:button id="btnAddFerie" runat="server" CssClass="bottone" Text="Nuova richiesta di ferie"
							CausesValidation="False"></asp:button><asp:datagrid id=dgFerie runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsRichiesteFerie1, "Tables[RichiesteFerie]").Rows.Count > 0 %>' GridLines="None" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="IdRichiesta" DataMember="RichiesteFerie" DataSource="<%# DsRichiesteFerie1 %>" >
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<P>
											<asp:LinkButton style="Z-INDEX: 0" id="lnkVisualizza" runat="server" CausesValidation="False" Text="Delete"
												CommandName="Display">Visualizza</asp:LinkButton></P>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkModifica" runat="server" CausesValidation="False" Text="Modifica" CommandName="Edit">Modifica</asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="LinkButton3" runat="server" Text="Ok" CommandName="Update"></asp:LinkButton>&nbsp;
										<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" Text="Annulla" CommandName="Cancel"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="False" Text="Delete" CommandName="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data della richiesta"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Dal Giorno">
									<ItemTemplate>
										<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caDalGiorno runat="server" Width="200px" CssClass="grid" BackColor="White" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>' BorderColor="#999999" DayNameFormat="FirstLetter">
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvDataDal" runat="server" ErrorMessage="La data inizio deve essere " Display="None"
											OnServerValidate="cvDataDal_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Al Giorno">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caAlGiorno runat="server" Width="200px" CssClass="grid" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvMinDataAl" runat="server" ErrorMessage="Non è possibile richiedere meno di 5 giorni di ferie."
											Display="None" OnServerValidate="cvMinDataAl_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvMeseDataDalAl" runat="server" ErrorMessage="Non è possibile che il primo giorno di richiesta ferie sia festivo o di riposo."
											Display="None" OnServerValidate="cvMeseDataDalAl_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id=lblStatoApprovazione runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoApprovazione") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="DataApprovazione" SortExpression="DataApprovazione" ReadOnly="True"
									HeaderText="Data di Approvazione"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="Approvatore" SortExpression="Approvatore" ReadOnly="True"
									HeaderText="Approvatore"></asp:BoundColumn>
							</Columns>
						</asp:datagrid><asp:customvalidator id="cvOnModifica" runat="server" Display="None" ErrorMessage="Non è possibile modificare o eliminare questa richiesta."></asp:customvalidator></td>
				</tr>
			</table>
			<div id="DivMostraFerieCongedi" align="center" runat="server">
				<table>
					<tr>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblDAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
					</tr>
					<tr>
						<td colSpan="2"><asp:datagrid style="Z-INDEX: 0" id=DgMostraFerieCongedi runat="server" CssClass="grid" Width="446px" Visible="False" AutoGenerateColumns="False" DataMember="SP_PrenotazioniFerieCongedi_TBL" DataSource="<%# DsMostraFerieCongedi1 %>" ForeColor="Black" BackColor="#FFFFC0" PageSize="20" AllowCustomPaging="True">
								<HeaderStyle BackColor="LightGray"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="GIORNO_DRITTO" SortExpression="GIORNO" HeaderText="DATA">
										<HeaderStyle Font-Bold="True" Width="100px"></HeaderStyle>
										<ItemStyle Wrap="False"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ListaUser" SortExpression="ListaUser" HeaderText="LISTA UTENTI">
										<HeaderStyle Font-Bold="True"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn Visible="False" DataField="num" SortExpression="num" HeaderText="PRENOTAZIONI">
										<HeaderStyle Font-Bold="True" Width="100px"></HeaderStyle>
										<ItemStyle Wrap="False"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="PosizioneSuccessiva" HeaderText="POSIZIONE DISPONIBILE">
										<HeaderStyle Font-Bold="True" Width="90px"></HeaderStyle>
										<ItemStyle Font-Size="Larger" Wrap="False" HorizontalAlign="Center"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="PosUser" HeaderText="POS UTENTE">
										<HeaderStyle Font-Bold="True" Width="90px"></HeaderStyle>
										<ItemStyle HorizontalAlign="Center"></ItemStyle>
									</asp:BoundColumn>
								</Columns>
								<PagerStyle Mode="NumericPages"></PagerStyle>
							</asp:datagrid></td>
					</tr>
				</table>
			</div>
		</form>
	</body>
</HTML>
