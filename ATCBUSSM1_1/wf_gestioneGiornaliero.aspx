<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gestioneGiornaliero.aspx.vb" Inherits="ATCBussm1.wf_gestioneGiornaliero" smartNavigation="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_gestioneGiornaliero</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<fieldset><legend>Turni</legend>
				<table>
					<tr>
						<td>
							<asp:Button id="BTNAbilita" runat="server" Text="Abilita giornaliero" ></asp:Button>
							<asp:Button id="BTNDisabilita" runat="server" Text="Disabilita giornaliero" ></asp:Button>
						</td>
					</tr>
				</table>
				<asp:table id="Table1" runat="server">
					<asp:TableRow>
						<asp:TableCell VerticalAlign="Top" Width="1%">
							<asp:Calendar runat="server" CssClass="grid" ID="caDataGiornaliero"></asp:Calendar>
							<p>
								<asp:Button id="btnSyncAS400" runat="server" Width="180px" CssClass="bottone" Text="Aggiornamento dei dati da AS400"></asp:Button></p>
						</asp:TableCell>
						<asp:TableCell VerticalAlign="Top" Width="100%">
							<asp:DataGrid runat="server" DataKeyField="Turno" AutoGenerateColumns="False" Width="100%" DataMember="Turni" CssClass="grid" UseAccessibleHeader="True" ID="dgTurni" DataSource='<%# DsVestizione1 %>'>
								<Columns>
									<asp:BoundColumn DataField="Turno" SortExpression="Turno" ReadOnly="True" HeaderText="Turno"></asp:BoundColumn>
									<asp:BoundColumn DataField="TipologiaTurno" SortExpression="TipologiaTurno" ReadOnly="True" HeaderText="TipologiaTurno"></asp:BoundColumn>
									<asp:BoundColumn DataField="DescrizionePercorso" SortExpression="DescrizionePercorso" ReadOnly="True"
										HeaderText="DescrizionePercorso"></asp:BoundColumn>
									<asp:TemplateColumn HeaderText="Nota">
										<ItemTemplate>
											<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nota") %>' ID="Label2">
											</asp:Label>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:TextBox TextMode="MultiLine" Width="100%" Rows="2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nota") %>' ID="Textbox1">
											</asp:TextBox>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:EditCommandColumn Visible="False" ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica"></asp:EditCommandColumn>
								</Columns>
							</asp:DataGrid>
						</asp:TableCell>
					</asp:TableRow>
				</asp:table></fieldset>
			<br>
			<fieldset><legend>Accertatori
				</legend>
				<asp:datagrid id=dgVestizione runat="server" UseAccessibleHeader="True" DataSource="<%# DsVestizione1 %>" DataMember="Accertatori" AutoGenerateColumns="False" DataKeyField="Matricola" Width="100%" CssClass="grid">
					<Columns>
						<asp:BoundColumn DataField="Matricola" SortExpression="Matricola" ReadOnly="True" HeaderText="Matricola"></asp:BoundColumn>
						<asp:BoundColumn DataField="CognomeNome" SortExpression="CognomeNome" ReadOnly="True" HeaderText="Cognome Nome"></asp:BoundColumn>
						<asp:BoundColumn DataField="Gruppo" SortExpression="Gruppo" ReadOnly="True" HeaderText="Gruppo"></asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Turno">
							<ItemTemplate>
								<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Turno") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:DropDownList id="ddlTurno" runat="server" DataSource="<%# dvTurni %>" DataTextField="Turno" DataValueField="Turno">
								</asp:DropDownList>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Ok" CancelText="Annulla" EditText="Modifica"></asp:EditCommandColumn>
					</Columns>
				</asp:datagrid></fieldset>
		</form>
	</body>
</HTML>
