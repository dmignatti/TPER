<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_congedi_Cntrl.aspx.vb"  Inherits="ATCBussm1.wf_congedi_Cntrl"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_congedi_Cntrl</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Riepilogo congedi richiesti<br>
							<span class="label">(Le richieste sono in ordine decrescente dalla pi� recente alla 
								pi� vecchia.<br>
								Sono visibili solamente i periodi di congedo richiesti non ancora cominciati)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblCongedi runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichieste1, "Tables[RichiesteCongedi]").Rows.Count <= 0 %>'>Non ci sono richieste di congedo.</asp:label><asp:button id="btnAddCongedo" runat="server" CssClass="bottone" CausesValidation="False" Text="Nuova richiesta di congedo"></asp:button><asp:datagrid id=dgCongedi runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsRichieste1, "Tables[RichiesteCongedi]").Rows.Count > 0 %>' GridLines="None" UseAccessibleHeader="True" AutoGenerateColumns="False" DataMember="RichiesteCongedi" DataSource="<%# DsRichieste1 %>" DataKeyField="IdRichiesta">
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
										<asp:CustomValidator id="cvDal" runat="server" Display="None" ErrorMessage="Attenzione non � pi� consentito chiedere congedo."
											OnServerValidate="cvDal_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
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
										<asp:CustomValidator id="cvMaxGiorni" runat="server" Display="None" ErrorMessage="Si pu� chiedere al massimo un giorno di congedo."
											OnServerValidate="cvMaxGiorni_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvMeseDataDalAl" runat="server" ErrorMessage="Non � possibile richiedere un congedo a cavallo di due mesi."
											Display="None" OnServerValidate="cvMeseDataDalAl_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvDataDalFestiva" runat="server" ErrorMessage="Non � possibile che il primo giorno di richiesta congedo sia festivo o di riposo."
											Display="None" OnServerValidate="cvDataDalFestiva_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator ID="cvPresente" Runat="server" ErrorMessage="Richiesta gi� presente per il giorno."
											Display="None" OnServerValidate="cvPresente_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Graduatoria">
									<ItemTemplate>
										<asp:Label id=lblGraduatoria text='<%# DataBinder.Eval(Container, "DataItem.Ordine") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoRichiesta") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<asp:customvalidator id="cvOnModificaCongedo" runat="server" Display="None" ErrorMessage="Non � possibile modificare questo congedo."></asp:customvalidator><asp:customvalidator id="cvOnEliminaCongedo" runat="server" Display="None" ErrorMessage="Non � possibile eliminare questo congedo."></asp:customvalidator><asp:customvalidator id="cvTipoUtente" runat="server" Display="None" ErrorMessage="Solamente gli accertatori possono richiedere congedi e cambi turno."></asp:customvalidator>
			<div id="DivMostraFerieCongedi" align="center">
				<table>
					<tr>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblDAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
					</tr>
					<tr>
						<td colSpan="2"><asp:datagrid style="Z-INDEX: 0" id=DgMostraFerieCongedi runat="server" CssClass="grid" Width="446px" Visible="False" AutoGenerateColumns="False" DataMember="SP_PrenotazioniFerieCongedi_TBL" DataSource="<%# DsMostraFerieCongedi1 %>" BackColor="#FFFFC0" AllowCustomPaging="True" PageSize="20" ForeColor="Black">
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
