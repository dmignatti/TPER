<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_giorniriposoassistenti.aspx.vb" Inherits="ATCBussm1.wf_giorniriposoassistenti"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Riposi</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<script language="javascript">
<!--
	function Stampa() 
	{
        var txt = document.getElementById('txtID');
        var id =txt.value;


			window.open('wf_stampariposi.aspx?IDMatr=' + id,'rel');

	}
//-->
		</script>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmRiposi" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSDatiSintesi" runat="server" DESIGNTIMEDRAGDROP="459" HeaderText="Attenzione!"
					Width="100%"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Width="700px" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" border="0" cellSpacing="2" cellPadding="0" width="100%" height="100%">
							<TR>
								<TD align="right"><INPUT id="txtID" type="hidden" name="txtID" runat="server">
									<asp:Label id="lblmatricola" runat="server" CssClass="label">Matricola</asp:Label>
									<asp:TextBox id="Txtmatricola" runat="server"></asp:TextBox>
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label>
									<asp:TextBox id="txtAnno" runat="server" Width="67px"></asp:TextBox></TD>
								<TD align="right">
									<asp:Label id="LblMese" runat="server" CssClass="label">Mese</asp:Label>
									<asp:DropDownList id="CboMese" runat="server" Width="151px">
										<asp:ListItem Selected="True" Value="0">Tutti</asp:ListItem>
										<asp:ListItem Selected="False" Value="1">Gennaio</asp:ListItem>
										<asp:ListItem Selected="False" Value="2">Febbraio</asp:ListItem>
										<asp:ListItem Selected="False" Value="3">Marzo</asp:ListItem>
										<asp:ListItem Selected="False" Value="4">Aprile</asp:ListItem>
										<asp:ListItem Selected="False" Value="5">Maggio</asp:ListItem>
										<asp:ListItem Selected="False" Value="6">Giugno</asp:ListItem>
										<asp:ListItem Selected="False" Value="7">Luglio</asp:ListItem>
										<asp:ListItem Selected="False" Value="8">Agosto</asp:ListItem>
										<asp:ListItem Selected="False" Value="9">Settembre</asp:ListItem>
										<asp:ListItem Selected="False" Value="10">Ottobre</asp:ListItem>
										<asp:ListItem Selected="False" Value="11">Novembre</asp:ListItem>
										<asp:ListItem Selected="False" Value="12">Dicembre</asp:ListItem>
									</asp:DropDownList></TD>
								<TD align="left">
									<asp:CompareValidator id="cvAnno" runat="server" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
										Display="None" ControlToValidate="txtAnno" Type="Integer" Operator="GreaterThanEqual" ValueToCompare="1980"></asp:CompareValidator>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>&nbsp;<A id="lkStampa" onclick="Stampa()" href="javascript:;" runat="server">Stampa</A></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlGiorniSpeciali" runat="server" Width="700px" Visible="true">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">
							<asp:Label id="lbllegend" Runat="server">Giorni Riposo. Numero totale estratto: </asp:Label></LEGEND><BR>
						<asp:datagrid id=dgRiposi runat="server" Width="100%" Visible="TRUE" CssClass="grid" UseAccessibleHeader="True" CellPadding="2" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id" DataMember="Riposi" DataSource="<%# DsRiposiTutti1 %>">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle CssClass="RigaDataGrid"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="ID" ReadOnly="True" HeaderText="ID"></asp:BoundColumn>
								<asp:BoundColumn DataField="TTMATR" ReadOnly="True" HeaderText="MATRICOLA"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Data">
									<ItemTemplate>
										<asp:Label id="LblData" runat="server" Text='<%# Format(CType(DataBinder.Eval(Container, "DataItem.DataRiposo"),DateTime),"dd/MM/yyyy") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Mese">
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# Format(CType(DataBinder.Eval(Container, "DataItem.DataRiposo"),DateTime),"MMMM") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Giorno della settimana">
									<ItemTemplate>
										<asp:Label id="Label2" runat="server" Text='<%# Format(CType(DataBinder.Eval(Container, "DataItem.DataRiposo"),DateTime),"dddd") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Evento">
									<ItemTemplate>
										<asp:Label id="LblEvento" text='RIPOSO' Runat="server"></asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
					</FIELDSET>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
