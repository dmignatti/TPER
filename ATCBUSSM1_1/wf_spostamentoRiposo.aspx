<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_spostamentoRiposo.aspx.vb" Inherits="ATCBussm1.wf_spostamentoRiposo"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_SpostamentoRiposo</title>
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
						<h6>Richiesta spostamento riposo<br>
							<span class="label">(Le richieste sono in ordine decrescente&nbsp;dalla più recente 
								alla più vecchia.<br>
								Vengono mostrate solamente le richieste che si riferiscono a periodi futuri)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" HeaderText="Attenzione!" Width="100%"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichiesteSpostamentoRiposo1, "Tables[RichiesteSpostamentoRiposo]").Rows.Count <= 0 %>'>Non ci sono richieste.</asp:label><asp:button id="btnAdd" runat="server" CssClass="bottone" Text="Nuova richiesta spostamento Riposo"
							CausesValidation="False"></asp:button><asp:panel id="pnlData" runat="server" Visible="False">
							<HR SIZE="1" noShade>
							<H6 style="COLOR: blue">Quale riposo vuoi spostare?
								<asp:DropDownList id="DdlData" runat="server"></asp:DropDownList></H6>
							<HR SIZE="1" noShade>
							<asp:Button id="btnOk" runat="server" CssClass="bottone" Text="   Ok   "></asp:Button>
							<asp:Button id="btnAnnulla" runat="server" CssClass="bottone" Text="Annulla" CausesValidation="False"></asp:Button>
							<HR SIZE="1" noShade>
						</asp:panel><asp:datagrid id=dgSpostamentoRiposo runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsRichiesteSpostamentoRiposo1, "Tables[RichiesteSpostamentoRiposo]").Rows.Count > 0 %>' DataSource="<%# DsRichiesteSpostamentoRiposo1 %>" DataMember="RichiesteSpostamentoRiposo" DataKeyField="IdRichiesta" UseAccessibleHeader="True" AutoGenerateColumns="False" GridLines="None">
							<Columns>
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
								<asp:BoundColumn DataField="DalGiorno" SortExpression="DalGiorno" ReadOnly="True" HeaderText="Dal Giorno"
									DataFormatString="{0:dd/MM/yyyy}"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Al Giorno">
									<ItemTemplate>
										<asp:Label id=LblALGIORNO runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlGiorno", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caAlGiorno runat="server" CssClass="grid" Width="200px" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.AlGiorno") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvMinDataAl" runat="server" Display="None" ErrorMessage="Non è possibile richiedere giorni festivi."
											OnServerValidate="cvMinDataAl_OnServerValidate"></asp:CustomValidator>
										<asp:CustomValidator id="cvMeseDataDalAl" runat="server" Display="None" ErrorMessage="Non è possibile richiedere le ferie a cavallo di due mesi."
											OnServerValidate="cvMeseDataDalAl_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn SortExpression="TipoSpostamento" HeaderText="Tipo">
									<ItemTemplate>
										<asp:Label id=LblTIPO runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TipoSpostamento") %>' ToolTip="F: Ferie - S: Straordinari - altrimenti scelgo una data">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<P>
											<asp:RadioButton id="RTipoD" runat="server" Text="Data" GroupName="TIPO" Checked="True"></asp:RadioButton>
											<asp:RadioButton style="Z-INDEX: 0" id="RTipoS" runat="server" Text="Straordinario" GroupName="TIPO"></asp:RadioButton>
											<asp:RadioButton style="Z-INDEX: 0" id="RTipoF" runat="server" Text="Ferie" GroupName="TIPO"></asp:RadioButton></P>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Dalle Ore">
									<ItemTemplate>
										<asp:Label id=LblDalleOre runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalleOre") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<TABLE style="Z-INDEX: 0" id="Table2" border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD>
													<asp:Label id="Label3" runat="server">Ore</asp:Label></TD>
												<TD>
													<asp:Label id="Label4" runat="server">Minuti</asp:Label></TD>
											</TR>
											<TR>
												<TD>
													<asp:DropDownList id="ddlDalleOre" runat="server">
														<asp:ListItem Value="0">00</asp:ListItem>
														<asp:ListItem Value="1">01</asp:ListItem>
														<asp:ListItem Value="2">02</asp:ListItem>
														<asp:ListItem Value="3">03</asp:ListItem>
														<asp:ListItem Value="4">04</asp:ListItem>
														<asp:ListItem Value="5">05</asp:ListItem>
														<asp:ListItem Value="6">06</asp:ListItem>
														<asp:ListItem Value="7" Selected="True">07</asp:ListItem>
														<asp:ListItem Value="8">08</asp:ListItem>
														<asp:ListItem Value="9">09</asp:ListItem>
														<asp:ListItem Value="10">10</asp:ListItem>
														<asp:ListItem Value="11">11</asp:ListItem>
														<asp:ListItem Value="12">12</asp:ListItem>
														<asp:ListItem Value="13">13</asp:ListItem>
														<asp:ListItem Value="14">14</asp:ListItem>
														<asp:ListItem Value="15">15</asp:ListItem>
														<asp:ListItem Value="16">16</asp:ListItem>
														<asp:ListItem Value="17">17</asp:ListItem>
														<asp:ListItem Value="18">18</asp:ListItem>
														<asp:ListItem Value="19">19</asp:ListItem>
														<asp:ListItem Value="20">20</asp:ListItem>
														<asp:ListItem Value="21">21</asp:ListItem>
														<asp:ListItem Value="22">22</asp:ListItem>
														<asp:ListItem Value="23">23</asp:ListItem>
													</asp:DropDownList></TD>
												<TD>
													<asp:DropDownList id="ddlDaMinuti" runat="server">
														<asp:ListItem Value="0">00</asp:ListItem>
														<asp:ListItem Value="1">01</asp:ListItem>
														<asp:ListItem Value="2">02</asp:ListItem>
														<asp:ListItem Value="3">03</asp:ListItem>
														<asp:ListItem Value="4">04</asp:ListItem>
														<asp:ListItem Value="5">05</asp:ListItem>
														<asp:ListItem Value="6">06</asp:ListItem>
														<asp:ListItem Value="7">07</asp:ListItem>
														<asp:ListItem Value="8">08</asp:ListItem>
														<asp:ListItem Value="9">09</asp:ListItem>
														<asp:ListItem Value="10">10</asp:ListItem>
														<asp:ListItem Value="11">11</asp:ListItem>
														<asp:ListItem Value="12">12</asp:ListItem>
														<asp:ListItem Value="13">13</asp:ListItem>
														<asp:ListItem Value="14">14</asp:ListItem>
														<asp:ListItem Value="15">15</asp:ListItem>
														<asp:ListItem Value="16">16</asp:ListItem>
														<asp:ListItem Value="17">17</asp:ListItem>
														<asp:ListItem Value="18">18</asp:ListItem>
														<asp:ListItem Value="19">19</asp:ListItem>
														<asp:ListItem Value="20">20</asp:ListItem>
														<asp:ListItem Value="21">21</asp:ListItem>
														<asp:ListItem Value="22">22</asp:ListItem>
														<asp:ListItem Value="23">23</asp:ListItem>
														<asp:ListItem Value="24">24</asp:ListItem>
														<asp:ListItem Value="25">25</asp:ListItem>
														<asp:ListItem Value="26">26</asp:ListItem>
														<asp:ListItem Value="27">27</asp:ListItem>
														<asp:ListItem Value="28">28</asp:ListItem>
														<asp:ListItem Value="29">29</asp:ListItem>
														<asp:ListItem Value="30">30</asp:ListItem>
														<asp:ListItem Value="31">31</asp:ListItem>
														<asp:ListItem Value="32">32</asp:ListItem>
														<asp:ListItem Value="33">33</asp:ListItem>
														<asp:ListItem Value="34">34</asp:ListItem>
														<asp:ListItem Value="35">35</asp:ListItem>
														<asp:ListItem Value="36">36</asp:ListItem>
														<asp:ListItem Value="37">37</asp:ListItem>
														<asp:ListItem Value="38">38</asp:ListItem>
														<asp:ListItem Value="39">39</asp:ListItem>
														<asp:ListItem Value="40">40</asp:ListItem>
														<asp:ListItem Value="41">41</asp:ListItem>
														<asp:ListItem Value="42">42</asp:ListItem>
														<asp:ListItem Value="43">43</asp:ListItem>
														<asp:ListItem Value="44">44</asp:ListItem>
														<asp:ListItem Value="45">45</asp:ListItem>
														<asp:ListItem Value="46">46</asp:ListItem>
														<asp:ListItem Value="47">47</asp:ListItem>
														<asp:ListItem Value="48">48</asp:ListItem>
														<asp:ListItem Value="49">49</asp:ListItem>
														<asp:ListItem Value="50">50</asp:ListItem>
														<asp:ListItem Value="51">51</asp:ListItem>
														<asp:ListItem Value="52">52</asp:ListItem>
														<asp:ListItem Value="53">53</asp:ListItem>
														<asp:ListItem Value="54">54</asp:ListItem>
														<asp:ListItem Value="55">55</asp:ListItem>
														<asp:ListItem Value="56">56</asp:ListItem>
														<asp:ListItem Value="57">57</asp:ListItem>
														<asp:ListItem Value="58">58</asp:ListItem>
														<asp:ListItem Value="59">59</asp:ListItem>
													</asp:DropDownList></TD>
											</TR>
										</TABLE>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Alle Ore">
									<ItemTemplate>
										<asp:Label id=LblAlleOre runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlleOre") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<TABLE style="Z-INDEX: 0" id="Table3" border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD>
													<asp:Label id="Label6" runat="server">Ore</asp:Label></TD>
												<TD>
													<asp:Label id="Label5" runat="server">Minuti</asp:Label></TD>
											</TR>
											<TR>
												<TD>
													<asp:DropDownList id="ddlAlleOre" runat="server">
														<asp:ListItem Value="0">00</asp:ListItem>
														<asp:ListItem Value="1">01</asp:ListItem>
														<asp:ListItem Value="2">02</asp:ListItem>
														<asp:ListItem Value="3">03</asp:ListItem>
														<asp:ListItem Value="4">04</asp:ListItem>
														<asp:ListItem Value="5">05</asp:ListItem>
														<asp:ListItem Value="6">06</asp:ListItem>
														<asp:ListItem Value="7" Selected="True">07</asp:ListItem>
														<asp:ListItem Value="8">08</asp:ListItem>
														<asp:ListItem Value="9">09</asp:ListItem>
														<asp:ListItem Value="10">10</asp:ListItem>
														<asp:ListItem Value="11">11</asp:ListItem>
														<asp:ListItem Value="12">12</asp:ListItem>
														<asp:ListItem Value="13">13</asp:ListItem>
														<asp:ListItem Value="14">14</asp:ListItem>
														<asp:ListItem Value="15">15</asp:ListItem>
														<asp:ListItem Value="16">16</asp:ListItem>
														<asp:ListItem Value="17">17</asp:ListItem>
														<asp:ListItem Value="18">18</asp:ListItem>
														<asp:ListItem Value="19">19</asp:ListItem>
														<asp:ListItem Value="20">20</asp:ListItem>
														<asp:ListItem Value="21">21</asp:ListItem>
														<asp:ListItem Value="22">22</asp:ListItem>
														<asp:ListItem Value="23">23</asp:ListItem>
													</asp:DropDownList></TD>
												<TD>
													<asp:DropDownList id="ddlAMinuti" runat="server">
														<asp:ListItem Value="0">00</asp:ListItem>
														<asp:ListItem Value="1">01</asp:ListItem>
														<asp:ListItem Value="2">02</asp:ListItem>
														<asp:ListItem Value="3">03</asp:ListItem>
														<asp:ListItem Value="4">04</asp:ListItem>
														<asp:ListItem Value="5">05</asp:ListItem>
														<asp:ListItem Value="6">06</asp:ListItem>
														<asp:ListItem Value="7">07</asp:ListItem>
														<asp:ListItem Value="8">08</asp:ListItem>
														<asp:ListItem Value="9">09</asp:ListItem>
														<asp:ListItem Value="10">10</asp:ListItem>
														<asp:ListItem Value="11">11</asp:ListItem>
														<asp:ListItem Value="12">12</asp:ListItem>
														<asp:ListItem Value="13">13</asp:ListItem>
														<asp:ListItem Value="14">14</asp:ListItem>
														<asp:ListItem Value="15">15</asp:ListItem>
														<asp:ListItem Value="16">16</asp:ListItem>
														<asp:ListItem Value="17">17</asp:ListItem>
														<asp:ListItem Value="18">18</asp:ListItem>
														<asp:ListItem Value="19">19</asp:ListItem>
														<asp:ListItem Value="20">20</asp:ListItem>
														<asp:ListItem Value="21">21</asp:ListItem>
														<asp:ListItem Value="22">22</asp:ListItem>
														<asp:ListItem Value="23">23</asp:ListItem>
														<asp:ListItem Value="24">24</asp:ListItem>
														<asp:ListItem Value="25">25</asp:ListItem>
														<asp:ListItem Value="26">26</asp:ListItem>
														<asp:ListItem Value="27">27</asp:ListItem>
														<asp:ListItem Value="28">28</asp:ListItem>
														<asp:ListItem Value="29">29</asp:ListItem>
														<asp:ListItem Value="30">30</asp:ListItem>
														<asp:ListItem Value="31">31</asp:ListItem>
														<asp:ListItem Value="32">32</asp:ListItem>
														<asp:ListItem Value="33">33</asp:ListItem>
														<asp:ListItem Value="34">34</asp:ListItem>
														<asp:ListItem Value="35">35</asp:ListItem>
														<asp:ListItem Value="36">36</asp:ListItem>
														<asp:ListItem Value="37">37</asp:ListItem>
														<asp:ListItem Value="38">38</asp:ListItem>
														<asp:ListItem Value="39">39</asp:ListItem>
														<asp:ListItem Value="40">40</asp:ListItem>
														<asp:ListItem Value="41">41</asp:ListItem>
														<asp:ListItem Value="42">42</asp:ListItem>
														<asp:ListItem Value="43">43</asp:ListItem>
														<asp:ListItem Value="44">44</asp:ListItem>
														<asp:ListItem Value="45">45</asp:ListItem>
														<asp:ListItem Value="46">46</asp:ListItem>
														<asp:ListItem Value="47">47</asp:ListItem>
														<asp:ListItem Value="48">48</asp:ListItem>
														<asp:ListItem Value="49">49</asp:ListItem>
														<asp:ListItem Value="50">50</asp:ListItem>
														<asp:ListItem Value="51">51</asp:ListItem>
														<asp:ListItem Value="52">52</asp:ListItem>
														<asp:ListItem Value="53">53</asp:ListItem>
														<asp:ListItem Value="54">54</asp:ListItem>
														<asp:ListItem Value="55">55</asp:ListItem>
														<asp:ListItem Value="56">56</asp:ListItem>
														<asp:ListItem Value="57">57</asp:ListItem>
														<asp:ListItem Value="58">58</asp:ListItem>
														<asp:ListItem Value="59">59</asp:ListItem>
													</asp:DropDownList></TD>
											</TR>
										</TABLE>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn Visible="False" HeaderText="Stato dell'Approvazione">
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
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
