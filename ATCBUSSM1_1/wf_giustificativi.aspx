<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_giustificativi.aspx.vb" Inherits="ATCBussm1.wf_giustificativi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_congedifrazionati</title>
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
						<h6>Richieste giustificativi<br>
							<span class="label">(Le richieste sono in ordine decrescente&nbsp;dalla più recente 
								alla più vecchia.)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" CssClass="Error" Width="100%" HeaderText="Attenzione!"></asp:validationsummary><asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsGiustificativi1, "Tables[Accertatori_GiustificativoRichiesta]").Rows.Count <= 0 %>'>Non ci sono richieste.</asp:label><br>
						<asp:label id="Label6" cssclass="label" runat="server">Causali giustificativi: </asp:label><asp:dropdownlist id=ddlCausali Runat="server" DataMember="Accertatori_Causale" DataSource="<%# DsGiustificativi1 %>" DataTextField="Nome" DataValueField="ID"></asp:dropdownlist><br>
						<asp:button id="btnAddRichiesta" runat="server" CssClass="bottone" Text="Nuova richiesta giustificativo"
							CausesValidation="False"></asp:button><asp:datagrid id=dgGiustificativi runat="server" CssClass="grid" Width="100%" Visible='<%# DataBinder.Eval(DsGiustificativi1, "Tables[Accertatori_GiustificativoRichiesta]").Rows.Count > 0 %>' DataMember="Accertatori_GiustificativoRichiesta" DataSource="<%# DsGiustificativi1 %>" GridLines="None" AutoGenerateColumns="False" DataKeyField="ID" UseAccessibleHeader="True">
							<Columns>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica">
									<ItemStyle Wrap="False"></ItemStyle>
								</asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="Delete">Elimina</asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" ReadOnly="True" HeaderText="Accertatore"></asp:BoundColumn>
								<asp:BoundColumn DataField="DataRichiesta" SortExpression="DataRichiesta" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
								<asp:BoundColumn DataField="Causale" SortExpression="Causale" ReadOnly="True" HeaderText="Causale"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="Accertatori_GiustificativoCausaleId" SortExpression="Accertatori_GiustificativoCausaleId"
									ReadOnly="True" HeaderText="Accertatori_GiustificativoCausaleId"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="Frazionato" SortExpression="Frazionato" ReadOnly="True"
									HeaderText="Frazionato"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="DefaultApprovato" SortExpression="DefaultApprovato" ReadOnly="True"
									HeaderText="Appr"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="PreavvisoGG" SortExpression="PreavvisoGG" ReadOnly="True"
									HeaderText="Preavv"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="NrMaxGG" SortExpression="NrMaxGG" ReadOnly="True" HeaderText="NrMaxGG"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Data da">
									<ItemTemplate>
										<asp:Label id=LblDataDa runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DataDa", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caDataDa runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.DataDa") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.DataDa") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
											<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
											<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
											<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
											<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#FFFFCC"></DayHeaderStyle>
											<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="#666666"></SelectedDayStyle>
											<TitleStyle Font-Bold="True" BorderColor="Black"></TitleStyle>
											<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
											<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
										</asp:Calendar>
										<asp:CustomValidator id="cvMinData" runat="server" ErrorMessage="Non si può inserire una richiesta di giustificativo passata."
											Display="None" OnServerValidate="cvMinData_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Ora da">
									<ItemStyle Wrap="False"></ItemStyle>
									<ItemTemplate>
										<asp:Label id=lblOreMinDa runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Ora_Da", "{0:00}") &amp; ":" &amp;  DataBinder.Eval(Container, "DataItem.Minuti_Da", "{0:00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<TABLE border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD>
													<asp:Label id="LblOraDa" runat="server">Ore</asp:Label></TD>
												<TD>
													<asp:Label id="LblMinutiDa" runat="server">Minuti</asp:Label></TD>
											</TR>
											<TR>
												<TD>
													<asp:DropDownList id="ddlOraDa" runat="server">
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
													<asp:DropDownList id="ddlMinutiDa" runat="server">
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
								<asp:TemplateColumn HeaderText="Data a">
									<ItemTemplate>
										<asp:Label id=LblDataA runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DataA", "{0:d}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Calendar id=caDataA runat="server" Width="200px" CssClass="grid" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.DataA") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.DataA") %>' BorderColor="#999999" DayNameFormat="FirstLetter" BackColor="White">
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
								<asp:TemplateColumn HeaderText="Ora a">
									<ItemStyle Wrap="False"></ItemStyle>
									<ItemTemplate>
										<asp:Label id=lblOraMinA runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Ora_A", "{0:00}") &amp; ":" &amp;  DataBinder.Eval(Container, "DataItem.Minuti_A", "{0:00}") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<TABLE border="0" cellSpacing="0" cellPadding="0">
											<TR>
												<TD>
													<asp:Label id="LblOraA" runat="server">Ore</asp:Label></TD>
												<TD>
													<asp:Label id="LblMinutiA" runat="server">Minuti</asp:Label></TD>
											</TR>
											<TR>
												<TD>
													<asp:DropDownList id="ddlOraA" runat="server">
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
													<asp:DropDownList id="ddlMinutiA" runat="server">
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
										<asp:CustomValidator id="cvAlleOre" runat="server" Display="None" ErrorMessage="Controllare la correttezza degli orari inseriti."
											OnServerValidate="cvAlleOre_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato dell'Approvazione">
									<ItemTemplate>
										<asp:Label id="lblStatoApprovazione" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.StatoApprovazione") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="DataApprovazione" SortExpression="DataApprovazione" ReadOnly="True"
									HeaderText="Data dell'Approvazione"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="Approvatore" SortExpression="Approvatore" ReadOnly="True"
									HeaderText="Approvatore"></asp:BoundColumn>
								<asp:BoundColumn DataField="ORDINE" SortExpression="ORDINE" ReadOnly="True" HeaderText="Ordine">
									<HeaderStyle Width="40px"></HeaderStyle>
									<ItemStyle Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CODICE" SortExpression="CODICE" ReadOnly="True" HeaderText="CODICE"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="DataDa" SortExpression="DataDa" ReadOnly="True" HeaderText="DataDa"></asp:BoundColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
			<asp:customvalidator id="cvOnModifica" runat="server" Display="None" ErrorMessage="Non è possibile modificare o eliminare questa richiesta."></asp:customvalidator><asp:customvalidator id="cvTipoUtente" runat="server" Display="None" ErrorMessage="Solamente gli accertatori possono richiedere congedi e cambi turno."></asp:customvalidator></form>
	</body>
</HTML>
