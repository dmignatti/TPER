<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_ferie.aspx.vb" Inherits="ATCBussm1.wf_ferie"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ferie</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table class="Back" id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" height="4" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Richiesta ferie<br>
							<span class="label">(Le richieste sono in ordine decrescente&nbsp;dalla più recente 
								alla più vecchia.<br>
								Vengono mostrate solamente le richieste che si riferiscono a periodi futuri)</span></h6>
						<hr noShade SIZE="1">
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichiesteFerie1, "Tables[RichiesteFerie]").Rows.Count <= 0 %>'>Non ci sono richieste.</asp:label><asp:button id="btnAddFerie" runat="server" CssClass="bottone" Text="Nuova richiesta ferie"
							CausesValidation="False"></asp:button><asp:datagrid id=dgFerie runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsRichiesteFerie1, "Tables[RichiesteFerie]").Rows.Count > 0 %>' GridLines="None" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="IdRichiesta" DataMember="RichiesteFerie" DataSource="<%# DsRichiesteFerie1 %>">
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkModifica" runat="server" CausesValidation="False" CommandName="Edit" Text="Modifica">Modifica</asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="LinkButton3" runat="server" CommandName="Update" Text="Ok"></asp:LinkButton>&nbsp;
										<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data della richiesta"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Dal Giorno">
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caDalGiorno" runat="server" Width="200px" CssClass="grid" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvDataDal" runat="server" Display="None" ErrorMessage="La data inizio deve essere "
											OnServerValidate="cvDataDal_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Al Giorno">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caAlGiorno runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
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
										<asp:CustomValidator id="cvMeseDataDalAl" runat="server" ErrorMessage="Non è possibile richiedere le ferie a cavallo di due mesi."
											Display="None" OnServerValidate="cvMeseDataDalAl_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoApprovazione") %>'>
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
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
