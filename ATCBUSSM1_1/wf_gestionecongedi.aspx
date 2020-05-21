<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestionecongedi.aspx.vb" Inherits="ATCBussm1.wf_gestionecongedi" smartNavigation="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gestionecongedi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<fieldset style="Z-INDEX: 0; PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di congedi frazionati</legend>
				<p>Le richieste sono ordinate per il campo "Dal Giorno" in maniera decrescente.<br>
					A parità di&nbsp;data le richieste sono ordinate anche per il campo "Dalle ore" 
					in maniera decrescente.<br>
					A parità di orario le richieste sono ordinate anche per il campo "Data 
					richiesta" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricola" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricola" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStato" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStato" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Convertito in intero" value="Convertito in intero"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiorno" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DalGiorno" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="btnFiltro" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCongediFrazionati runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCongediFrazionati" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="Data" SortExpression="Data" HeaderText="Data" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Dalle Ore">
							<ItemTemplate>
								<asp:Label id=lblDalleOre runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalleOre") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalleOre") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Alle Ore">
							<ItemTemplate>
								<asp:Label id="lblAlleOre" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlleOre") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id="TextBox2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlleOre") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Intero">
							<ItemTemplate>
								<asp:Label id="Label12" runat="server" Text='<%#  DataBinder.Eval(Container, "DataItem.Intero") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Conferma" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:Button Runat="server" ID="BtnConverti" Visible='<%# DataBinder.Eval(Container, "DataItem.Intero")=true and DataBinder.Eval(Container, "DataItem.stato")=0 %>' CommandName="Converti" Text ="Converti in intero">
								</asp:Button>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Garantiti" SortExpression="Garantiti" HeaderText="Garantiti">
							<HeaderStyle Width="25px"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<br>
			<!------ -->
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di congedi garantiti</legend>
				<p>Le richieste sono ordinate per il campo "Dal Giorno" in maniera decrescente.<br>
					A parità di&nbsp;data le richieste sono ordinate anche per il campo "Dalle ore" 
					in maniera decrescente.<br>
					A parità di orario le richieste sono ordinate anche per il campo "Data 
					richiesta" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="Label16" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="TxtMatricolaCGA" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="Label17" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoCGA" name="Select1" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Convertito in intero" value="Convertito in intero"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoGCA" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DalGiornoCGA" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="BtnFiltroCGA" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCongediGarantiti runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCongediGarantiti" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="IdAccertatore" SortExpression="IdAccertatore" HeaderText="IdAccertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="DalGiorno" SortExpression="DalGiorno" HeaderText="Dal Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="AlGiorno" SortExpression="AlGiorno" HeaderText="Al Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Ordine" SortExpression="Ordine" HeaderText="Graduatoria"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<!---- --><br>
			<fieldset style="Z-INDEX: 1; PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di congedo</legend>
				<p>Le richieste sono ordinate per il campo "Dal Giorno" in maniera decrescente. A 
					parità di&nbsp;data le richieste sono ordinate anche per il campo "Data 
					richiesta" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricolaC" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaC" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStatoC" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoC" name="ddlStatoC" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoC" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0" id="DalGiornoC" runat="server" Font-Size="XX-Small" Height="68px"
								Width="112px"></asp:calendar></td>
						<td><asp:button id="btnFiltroC" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCongedi runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCongedi" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" ReadOnly="True" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="IdAccertatore" SortExpression="IdAccertatore" HeaderText="IdAccertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="DalGiorno" SortExpression="DalGiorno" HeaderText="Dal Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="AlGiorno" SortExpression="AlGiorno" HeaderText="Al Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="Ordine" SortExpression="Ordine" HeaderText="Graduatoria"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<br>
			<fieldset style="Z-INDEX: 3; PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di ferie</legend>
				<p>Le richieste sono ordinate per il campo "Dal Giorno" in maniera decrescente. A 
					parità di&nbsp;data le richieste sono ordinate anche per il campo "Data 
					richiesta" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricolaF" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaF" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStatoF" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoF" name="ddlStatoF" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoF" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0" id="DalGiornoF" runat="server" Font-Size="XX-Small" Height="68px"
								Width="112px"></asp:calendar></td>
						<td><asp:button id="btnFiltroF" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgFerie runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteFerie" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:ButtonColumn Text="Visualizza" CommandName="Select"></asp:ButtonColumn>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="DalGiorno" SortExpression="DalGiorno" HeaderText="Dal Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="AlGiorno" SortExpression="AlGiorno" HeaderText="Al Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="Ordine" SortExpression="Ordine" HeaderText="Graduatoria"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<div id="DivMostraFerieCongedi" align="center">
				<table>
					<tr>
						<td style="FONT-WEIGHT: bold" bgColor="activeborder" width="100%" colSpan="2" align="center"><asp:label id="lblUTENTE" runat="server" BackColor="ActiveBorder"></asp:label></td>
					</tr>
					<tr>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblDAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
						<td bgColor="activeborder" width="50%" align="center"><asp:label id="lblAL" runat="server" BackColor="ActiveBorder"></asp:label></td>
					</tr>
					<tr>
						<td colSpan="2"><asp:datagrid style="Z-INDEX: 0" id=DgMostraFerieCongedi runat="server" CssClass="grid" Width="446px" AutoGenerateColumns="False" DataMember="SP_PrenotazioniFerieCongedi_TBL" DataSource="<%# DsMostraFerieCongedi1 %>" BackColor="#FFFFC0" Visible="False" AllowCustomPaging="True" PageSize="20" ForeColor="Black">
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
									<asp:BoundColumn Visible="False" DataField="PosizioneSuccessiva" HeaderText="POSIZIONE DISPONIBILE">
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
			<br>
			<!-- Giustificativi -->
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Giustificativi</legend>
				<p>Le richieste sono ordinate per il campo "Data Da" in maniera decrescente.<br>
					A parità di orario le richieste sono ordinate anche per il campo "Data 
					inserimento" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="Label8" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaRG" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="Label11" runat="server" CssClass="label">Causale giustificativo: </asp:label><asp:dropdownlist id=ddlCausali Runat="server" DataMember="Accertatori_Causale" DataSource="<%# DsAmministrazioneCongedi1 %>" DataValueField="ID" DataTextField="Nome"></asp:dropdownlist></td>
						<td><asp:label id="Label9" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoRG" name="Select1" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoRG" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DalGiornoRG" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="btnFiltroRG" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgGiustificativi runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="Accertatori_GiustificativoRichiesta" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="ID">
					<Columns>
						<asp:BoundColumn DataField="DataRichiesta" SortExpression="DataRichiesta" HeaderText="Data DataRichiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="Causale" SortExpression="Causale" HeaderText="Causale"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="OraDa" SortExpression="OraDa" HeaderText="Data da" DataFormatString="{0:dd/MM/yyyy HH:mm}"></asp:BoundColumn>
						<asp:BoundColumn DataField="OraA" SortExpression="OraA" HeaderText="Data a" DataFormatString="{0:dd/MM/yyyy HH:mm}"></asp:BoundColumn>
						<asp:BoundColumn DataField="ORDINE" SortExpression="ORDINE" ReadOnly="True" HeaderText="Ordine">
							<HeaderStyle Width="36px"></HeaderStyle>
							<ItemStyle Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Conferma" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
						<asp:BoundColumn Visible="False" DataField="codice" SortExpression="codice" ReadOnly="True" HeaderText="codice"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Frazionato" SortExpression="Frazionato" ReadOnly="True"
							HeaderText="Frazionato"></asp:BoundColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<!-- SPOSTAMENTO GIORNO DI RIPOSTO - DM2020.04 --><br>
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Spostamento 
					giorno di riposo</legend>
				<p>Le richieste sono ordinate per il campo "Data Da" in maniera decrescente.<br>
					A parità di orario le richieste sono ordinate anche per il campo "Data 
					inserimento" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="LblMatricolaSPR" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="TxtMatricolaSPR" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="LblTipoSPR" Runat="server" CssClass="label">Tipo: </asp:label><SELECT style="Z-INDEX: 0" id="DdlTipoSPR" name="SelectSPR" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Data" value="Data"></OPTION>
								<OPTION title="Straordinario" value="Straordinario"></OPTION>
								<OPTION title="Ferie" value="Ferie"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="LblStatoSPR" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="DdlStatoSPR" name="Select1" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoSPR" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DalGiornoSPR" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="btnFiltroSPR" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=DgSpostamentoRiposo runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteSpostamentoRiposo" DataSource="<%# DsSpostamentoRiposo1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data Richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="TipoSpostamento" SortExpression="TipoSpostamento" HeaderText="Tipo"></asp:BoundColumn>
						<asp:BoundColumn DataField="DalGiorno" SortExpression="DalGiorno" HeaderText="Dal Giorno" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="AlGiorno" SortExpression="AlGiorno" HeaderText="GG o Orario" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Conferma" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
						<asp:BoundColumn Visible="False" DataField="DalleOre" SortExpression="DalleOre" ReadOnly="True" HeaderText="DalleOre"></asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="AlleOre" SortExpression="AlleOre" ReadOnly="True" HeaderText="AlleOre"></asp:BoundColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<br>
			<!-- DM2020.03.b -->
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di cambio turno</legend>
				<p>Le richieste sono ordinate per il campo "Data" in maniera decrescente. A parità 
					di&nbsp;data le richieste sono ordinate anche per il campo "Data richiesta" in 
					maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="Label13" Runat="server" CssClass="label">Matricola richiedente: </asp:label><asp:textbox id="txtMatricolaStessoT" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="Label14" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoStessoT" name="ddlStatoCTG" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoStessoT" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0" id="DalGiornoStessoT" runat="server" Font-Size="XX-Small" Height="68px"
								Width="112px"></asp:calendar></td>
						<td><asp:button id="BtnFiltroStessoT" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCambiTurnoStessoT runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCambiTurnoStessoTipo" DataSource="<%# DsCambiTurnoGiornalieriStessoTipo1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNomeRichiedente" SortExpression="CognomeNomeRichiedente" HeaderText="Accertatore Richiedente"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" HeaderText="Turno Richiedente"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" HeaderText="Turno Richiesto"></asp:BoundColumn>
						<asp:BoundColumn DataField="data" SortExpression="data" HeaderText="Data" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<!---- fine cambio turno --><br>
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di scambio turno giornalieri</legend>
				<p>Le richieste sono ordinate per il campo "Data" in maniera decrescente. A parità 
					di&nbsp;data le richieste sono ordinate anche per il campo "Data richiesta" in 
					maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricolaCTG" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaCTG" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStatoCTG" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoCTG" name="ddlStatoCTG" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoCTG" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0" id="DalGiornoCTG" runat="server" Font-Size="XX-Small" Height="68px"
								Width="112px"></asp:calendar></td>
						<td><asp:button id="btnFiltroCTG" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCambiTurno runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCambiTurno" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNomeRichiedente" SortExpression="CognomeNomeRichiedente" HeaderText="Accertatore Richiedente"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" HeaderText="Turno Richiedente">
							<HeaderStyle Width="80px"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNomeDestinatario" SortExpression="CognomeNomeDestinatario" HeaderText="Accertatore Destinatario"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" HeaderText="Turno Destinatario">
							<HeaderStyle Width="80px"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="data" SortExpression="data" HeaderText="Data" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato Approvazione">
							<HeaderStyle Width="85px"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
						<asp:BoundColumn DataField="Necessari" SortExpression="Necessari" HeaderText="Necessari">
							<HeaderStyle Width="50px"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<br>
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Richieste 
					di scambio turno mensili</legend>
				<p>Le richieste sono ordinate per il campo "Mese" in maniera decrescente. A parità 
					di&nbsp;data le richieste sono ordinate anche per il campo "Data richiesta" in 
					maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="lblMatricolaCTM" Runat="server" CssClass="label">Matricola richiedente: </asp:label><asp:textbox id="txtMatricolaCTM" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="lblStatoCTM" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoCTM" name="ddlStatoCTM" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoCTM" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0" id="DalGiornoCTM" runat="server" Font-Size="XX-Small" Height="68px"
								Width="112px"></asp:calendar></td>
						<td><asp:button id="btnFiltroCTM" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgCambiTurnoMensili runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="RichiesteCambiTurnoMensile" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="IdRichiesta">
					<Columns>
						<asp:BoundColumn DataField="ts" SortExpression="ts" HeaderText="Data richiesta"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNomeRichiedente" SortExpression="CognomeNomeRichiedente" HeaderText="Accertatore Richiedente"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoRichiedente" SortExpression="TurnoRichiedente" HeaderText="Turno Richiedente"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNomeDestinatario" SortExpression="CognomeNomeDestinatario" HeaderText="Accertatore Destinatario"></asp:BoundColumn>
						<asp:BoundColumn DataField="TurnoDestinatario" SortExpression="TurnoDestinatario" HeaderText="Turno Destinatario"></asp:BoundColumn>
						<asp:BoundColumn DataField="data" SortExpression="data" HeaderText="Mese" DataFormatString="{0:Y}"></asp:BoundColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Approva" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
			<br>
			<!-- DM2020.03.e -->
			<fieldset style="PADDING-BOTTOM: 5px; PADDING-LEFT: 5px; PADDING-RIGHT: 5px; PADDING-TOP: 5px"><legend>Elenco 
					mancata timbratura</legend>
				<p>Le richieste sono ordinate per il campo "Data" in maniera decrescente.<br>
					A parità di&nbsp;data le richieste sono ordinate anche per il campo "Entrata1" 
					in maniera decrescente.<br>
					A parità di orario le richieste sono ordinate anche per il campo "Data 
					inserimento" in maniera crescente.</p>
				<table>
					<tr>
						<td><asp:label id="Label1" Runat="server" CssClass="label">Matricola: </asp:label><asp:textbox id="txtMatricolaMT" Runat="server" CssClass="grid"></asp:textbox></td>
						<td><asp:label id="Label2" Runat="server" CssClass="label">Stato approvazione: </asp:label><SELECT style="Z-INDEX: 0" id="ddlStatoMT" name="Select1" runat="server">
								<OPTION title="Tutti" selected value="Tutti"></OPTION>
								<OPTION title="Approvati" value="Approvati"></OPTION>
								<OPTION title="Da approvare" value="Da approvare"></OPTION>
								<OPTION title="Rifiutati" value="Rifiutati"></OPTION>
							</SELECT>
						</td>
						<td><asp:label id="lblDalGiornoMT" Runat="server" CssClass="label">Dal giorno: </asp:label></td>
						<td><asp:calendar style="Z-INDEX: 0; FONT-SIZE: xx-small" id="DalGiornoMT" runat="server" Font-Size="XX-Small"
								Height="68" Width="112"></asp:calendar></td>
						<td><asp:button id="btnFiltroMT" Runat="server" CssClass="bottone" Text="Ricerca"></asp:button></td>
					</tr>
				</table>
				<asp:datagrid id=dgMancataTimbratura runat="server" CssClass="grid" Width="100%" AutoGenerateColumns="False" DataMember="Accertatori_MancataTimbratura" DataSource="<%# DsAmministrazioneCongedi1 %>" UseAccessibleHeader="True" DataKeyField="ID">
					<Columns>
						<asp:BoundColumn DataField="DataInserimento" SortExpression="DataInserimento" HeaderText="Data inserimento"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" HeaderText="Accertatore"></asp:BoundColumn>
						<asp:BoundColumn DataField="Data" SortExpression="Data" HeaderText="Data" DataFormatString="{0:d}"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Entrata1">
							<ItemTemplate>
								<asp:Label id="Label4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalleOre1","{0:00}") & ":" & DataBinder.Eval(Container, "DataItem.DalleMin1","{0:00}")  %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Uscita1">
							<ItemTemplate>
								<asp:Label id="Label5" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlleOre1","{0:00}") & ":" & DataBinder.Eval(Container, "DataItem.AlleMin1","{0:00}") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Entrata2">
							<ItemTemplate>
								<asp:Label id="Label6" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DalleOre2","{0:00}") & ":" & DataBinder.Eval(Container, "DataItem.DalleMin2","{0:00}")  %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Uscita2">
							<ItemTemplate>
								<asp:Label id="Label7" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AlleOre2","{0:00}") & ":" & DataBinder.Eval(Container, "DataItem.AlleMin2","{0:00}") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="StatoApprovazione" SortExpression="StatoApprovazione" HeaderText="Stato dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="DataApprovazione" SortExpression="DataApprovazione" HeaderText="Data dell'Approvazione"></asp:BoundColumn>
						<asp:BoundColumn DataField="Approvatore" SortExpression="Approvatore" HeaderText="Approvatore"></asp:BoundColumn>
						<asp:ButtonColumn Text="Conferma" CommandName="Approva"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Rifiuta" CommandName="Rifiuta"></asp:ButtonColumn>
						<asp:ButtonColumn Text="Annulla" CommandName="Annulla"></asp:ButtonColumn>
					</Columns>
				</asp:datagrid></fieldset>
		</form>
	</body>
</HTML>
