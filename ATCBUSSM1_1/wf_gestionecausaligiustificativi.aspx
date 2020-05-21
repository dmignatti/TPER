<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestionecausaligiustificativi.aspx.vb" Inherits="ATCBussm1.wf_gestionecausaligiustificativi"%>
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
					<td style="PADDING-BOTTOM: 0px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 0px"
						vAlign="top">
						<h6>Causali giustificativi</h6>
						<H6><span class="label">(Le causali sono in ordine alfabetico crescente per nome.)</span></H6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsGiustificativi1, "Tables[Accertatori_GiustificativoCausale]").Rows.Count <= 0 %>'>Non ci sono definite causali di giustificativo.</asp:label><asp:button id="btnAddCausale" runat="server" CssClass="bottone" Text="Nuova causale giustificativo"
							CausesValidation="False"></asp:button><asp:datagrid id=dgCausaliGiustificativi runat="server" CssClass="grid" Width="100%" Visible="true" GridLines="None" AutoGenerateColumns="False" UseAccessibleHeader="True" DataKeyField="ID" DataMember="Accertatori_GiustificativoCausale" DataSource="<%# DsGiustificativi1 %>" >
							<Columns>
								<asp:BoundColumn Visible="False" DataField="ID" SortExpression="ID" ReadOnly="True" HeaderText="ID"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica"></asp:EditCommandColumn>
								<asp:TemplateColumn HeaderText="Nome">
									<ItemTemplate>
										<asp:Label id="Label5" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.Nome") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Nome" runat="server" Width="200px" TextMode="MultiLine" Rows="2" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Codice">
									<ItemTemplate>
										<asp:Label id="Label6" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.Codice") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Codice" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Codice") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Validit&#224; Da">
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ValiditaDa", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caValiditaDa" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" BackColor="White" DayNameFormat="FirstLetter" BorderColor="#999999" SelectedDate='<%# DataBinder.Eval(Container, "DataItem.ValiditaDa") %>' VisibleDate='<%# DataBinder.Eval(Container, "DataItem.ValiditaDa") %>'>
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
								<asp:TemplateColumn HeaderText="Validit&#224; A">
									<ItemTemplate>
										<asp:Label id=Label2 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ValiditaA", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id="caValiditaA" runat="server" style="Z-INDEX: 0;width:112px;height:68px;Font-size:XX-Small;" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.ValiditaA") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.ValiditaA") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
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
								<asp:TemplateColumn HeaderText="Frazionato">
									<ItemTemplate>
										<asp:CheckBox id ="chkfraz" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Frazionato") %>' Enabled ="false" >
										</asp:CheckBox>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:CheckBox id ="Frazionato" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.Frazionato") %>' Enabled ="true" >
										</asp:CheckBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Approvato">
									<ItemTemplate>
										<asp:CheckBox id ="chkappr" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.DefaultApprovato") %>' Enabled ="false" >
										</asp:CheckBox>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:CheckBox id ="DefaultApprovato" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.DefaultApprovato") %>' Enabled ="true" >
										</asp:CheckBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Senza Preavviso">
									<ItemTemplate>
										<asp:CheckBox id ="chksp" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.SenzaPreavviso") %>' Enabled ="false" >
										</asp:CheckBox>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:CheckBox id ="SenzaPreavviso" Runat="server" Checked='<%# DataBinder.Eval(Container, "DataItem.SenzaPreavviso") %>' Enabled ="true" >
										</asp:CheckBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Preavviso GG">
									<ItemTemplate>
										<asp:Label id="Label3" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.PreavvisoGG") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="PreavvisoGG" runat="server" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.PreavvisoGG") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Nr max GG">
									<ItemTemplate>
										<asp:Label id="lblnumint" Runat="server">
											<%# DataBinder.Eval(Container, "DataItem.NrMaxGG") %>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="NrMaxGG" runat="server" Width="30px" Text='<%# DataBinder.Eval(Container, "DataItem.NrMaxGG") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><asp:customvalidator id="cvOnModifica" runat="server" Display="None" ErrorMessage="Non è possibile modificare o eliminare questa causale."></asp:customvalidator></td>
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
