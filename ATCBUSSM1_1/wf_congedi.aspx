<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_congedi.aspx.vb" Inherits="ATCBussm1.wf_congedi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_congedi</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<table id="Table01" cellSpacing="0" cellPadding="0" width="100%" align="center" class="Back">
				<tr>
					<td><IMG style="MARGIN-TOP: 0px; MARGIN-LEFT: 0px" height="4" alt="" src="images/corner_tl.gif"
							width="4" align="left"><IMG height="4" style="MARGIN-TOP: 0px; MARGIN-RIGHT: 0px" alt="" src="images/corner_tr.gif"
							width="4" align="right"></td>
				</tr>
				<tr>
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						valign="top">
						<h6>Riepilogo congedi richiesti<br>
							<span class="label">(Le richieste sono in ordine decrescente dalla più recente alla 
								più vecchia.<br>
								Sono visibili solamente i periodi di congedo richiesti non ancora cominciati)</span></h6>
						<hr noshade size="1">
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Attenzione!" CssClass="Error"></asp:validationsummary>
						<asp:label id=lblCongedi runat="server" Visible='<%# DataBinder.Eval(DsRichieste1, "Tables[RichiesteCongedi]").Rows.Count <= 0 %>' CssClass="label">Non ci sono richieste di congedo.</asp:label>
						<asp:button id="btnAddCongedo" runat="server" Text="Nuova richiesta di congedo" CausesValidation="False"
							CssClass="bottone"></asp:button><asp:datagrid id=dgCongedi runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsRichieste1, "Tables[RichiesteCongedi]").Rows.Count > 0 %>' DataKeyField="IdRichiesta" DataSource="<%# DsRichieste1 %>" DataMember="RichiesteCongedi" AutoGenerateColumns="False" UseAccessibleHeader="True" GridLines="None">
							<Columns>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" Text="Elimina" CausesValidation="false" CommandName="Delete"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdRichiesta" SortExpression="IdRichiesta" HeaderText="IdRichiesta"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Dal Giorno">
									<ItemTemplate>
										<asp:Label id="Label2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caDalGiorno" runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.DalGiorno") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvDal" runat="server" Display="None" ErrorMessage="Attenzione non è più consentito chiedere congedo."
											OnServerValidate="cvDal_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Graduatoria">
									<ItemTemplate>
										<asp:Label ID="lblGraduatoria" Runat="server" text='<%# DataBinder.Eval(Container, "DataItem.Ordine") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Al Giorno">
									<ItemTemplate>
										<asp:Label id="Label3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caAlGiorno" runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>'>
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvAl" runat="server" Display="None" ErrorMessage="La data di ritorno deve essere posteriore a quella di inizio."
											OnServerValidate="cvAl_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvMaxGiorni" runat="server" Display="None" ErrorMessage="Si può chiedere al massimo un giorno di congedo."
											OnServerValidate="cvMaxGiorni_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvMeseDataDalAl" runat="server" ErrorMessage="Non è possibile richiedere un congedo a cavallo di due mesi."
											Display="None" OnServerValidate="cvMeseDataDalAl_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator ID="cvPresente" Runat="server" ErrorMessage="Richiesta già presente per il giorno."
											Display="None" OnServerValidate="cvPresente_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoRichiesta") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" height="4" alt=""
							src="images/corner_bl.gif" width="4" align="left"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" height="4" alt=""
							src="images/corner_br.gif" width="4" align="right"></td>
				</tr>
			</table>
			<asp:customvalidator id="cvOnModificaCongedo" runat="server" ErrorMessage="Non è possibile modificare questo congedo."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvOnEliminaCongedo" runat="server" ErrorMessage="Non è possibile eliminare questo congedo."
				Display="None"></asp:customvalidator><asp:customvalidator id="cvTipoUtente" runat="server" ErrorMessage="Solamente gli accertatori possono richiedere congedi e cambi turno."
				Display="None"></asp:customvalidator></form>
	</body>
</HTML>
