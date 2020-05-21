<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_ricavisosta.aspx.vb" Inherits="ATCBussm1.wf_ricavisosta"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_ricavisosta</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmRicaviSosta" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSDatiSintesi" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Visible="TRUE" Width="700px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 297px" align="right">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label>
									<asp:TextBox id="txtAnno" runat="server" Width="67px"></asp:TextBox>
									<asp:CompareValidator id="cvAnno" runat="server" ValueToCompare="1980" Operator="GreaterThan" Type="Integer"
										Display="None" ControlToValidate="TxtAnno" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"></asp:CompareValidator></TD>
								<TD align="left">
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
								<TD align="left">
									<asp:Button id="btnAggiorna" runat="server" CssClass="bottone" Text="Aggiorna consuntivo"></asp:Button></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlRicaviSosta" runat="server" Visible="FALSE" Width="700px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricavi - Titoli sosta</LEGEND><BR>
						<asp:DataGrid id=DgRicaviSosta runat="server" Width="100%" Visible="TRUE" CssClass="grid" UseAccessibleHeader="True" DataSource="<%# DsRicaviSosta %>" DataMember="RicaviSosta" DataKeyField="Id" AutoGenerateColumns="False">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHData" Runat="server">Data</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblDt" Runat="server" text='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TxtDataI Runat="server" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>' width="70px">
										</asp:TextBox>
										<asp:RegularExpressionValidator id="REVData" runat="server" ErrorMessage="La data non è valida. Formato MM/AAAA"
											ControlToValidate="TxtDataI" ValidationExpression="^(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$" Display="None"></asp:RegularExpressionValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblConsuntivo" Runat="server">Consuntivo ordinario</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblCons" Runat="server" text='<%# format(iif(isdbnull(databinder.eval(container.dataitem,"Consuntivo")),0,databinder.eval(container.dataitem,"Consuntivo"))/1.2,"#,##0.00") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHBudget" Runat="server">Budget</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id=LblIBudget Runat="server" text='<%# format(databinder.eval(container.dataitem,"Budget"),"#,##0") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TxtBudget Runat="server" TEXT='<%# format(databinder.eval(container.dataitem,"Budget"),"#,##0") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVBudget" runat="server" Width="53px" ErrorMessage="Budget non valido. Formato numerico."
											ControlToValidate="TxtBudget" Display="None" EnableClientScript="False" OnServerValidate="CVBudget_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHDelta" Runat="server">Delta %</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblIDelta" Runat="server" text='<%# Format((iif(isdbnull(databinder.eval(container.dataitem,"Consuntivo")),0,databinder.eval(container.dataitem,"Consuntivo"))/1.2 + iif(isdbnull(databinder.eval(container.dataitem,"ConsuntivoFiere")),0,databinder.eval(container.dataitem,"ConsuntivoFiere")) - iif(isdbnull(databinder.eval(container.dataitem,"Budget")),0,databinder.eval(container.dataitem,"Budget")))/iif(databinder.eval(container.dataitem,"Budget")=0,1,databinder.eval(container.dataitem,"Budget")),"##0.## %") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="&lt;IMG alt=&quot;Elimina&quot; src=&quot;images/File_delete.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:DataGrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo mese</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
