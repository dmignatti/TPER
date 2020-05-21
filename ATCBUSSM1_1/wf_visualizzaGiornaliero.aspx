<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_visualizzaGiornaliero.aspx.vb" Inherits="ATCBussm1.wf_visualizzaGiornaliero" smartNavigation="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_visualizzaGiornaliero</title>
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
			<fieldset><legend>Turni accertatori</legend><asp:table id="Table1" runat="server">
					<asp:TableRow>
						<asp:TableCell VerticalAlign="Top" Width="1%">
							<asp:Calendar runat="server" CssClass="grid" ID="caDataGiornaliero"></asp:Calendar>
						</asp:TableCell>
						<asp:TableCell VerticalAlign="Top" Width="100%">
							<asp:datagrid id="dgVestizione" runat="server" CssClass="grid" Width="100%" DataKeyField="Matricola" AutoGenerateColumns="False" DataMember="AccertatoriTurno" Visible =False  DataSource="<%# DsVestizione1 %>" UseAccessibleHeader="True">
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
									<asp:TemplateColumn HeaderText="TipologiaTurno">
										<ItemTemplate>
											<asp:Label id="Label2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TipologiaTurno") %>'>
											</asp:Label>
										</ItemTemplate>
									</asp:TemplateColumn>
								</Columns>
							</asp:datagrid>
						</asp:TableCell>
					</asp:TableRow>
				</asp:table></fieldset>
			&nbsp;
			<br>
		</form>
	</body>
</HTML>
