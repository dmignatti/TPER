<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_notestampa.aspx.vb" Inherits="ATCBussm1.wf_notestampa"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_notestampa</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="Validationsummary1" runat="server" DESIGNTIMEDRAGDROP="459" HeaderText="Attenzione!"
					Width="100%"></asp:validationsummary></DIV>
			<div align="center"><asp:panel id="pnlSearch" runat="server" Width="600px">
					<FIELDSET><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 227px">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label></TD>
								<TD>
									<asp:Label id="lblSezione" runat="server" CssClass="label">Sezione</asp:Label></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 227px">
									<asp:TextBox id="txtAnno" runat="server" Width="320px"></asp:TextBox></TD>
								<TD>
									<asp:DropDownList id=cboSezioneSt runat="server" Width="196px" DataMember="SezioniReport" DataSource="<%# DsNoteSezione %>" DataValueField="IdSezione" DataTextField="Descrizione">
									</asp:DropDownList></TD>
								<TD>
									<asp:CompareValidator id="cvAnno" runat="server" ValueToCompare="1980" Operator="GreaterThanEqual" Type="Integer"
										ControlToValidate="txtAnno" Display="None" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"></asp:CompareValidator>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD colSpan="2"></TD>
							</TR>
						</TABLE>
					</FIELDSET>
					<BR>
				</asp:panel></div>
			<DIV align="center"><asp:panel id="pnlNote" runat="server" Width="100%" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Note per sezione report</LEGEND><BR>
						<asp:datagrid id=dgNoteSezione runat="server" Width="100%" CssClass="grid" DataMember="NoteSezione" DataSource="<%# DsNoteSezione %>" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id" UseAccessibleHeader="True" AllowPaging="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Sezione">
									<HeaderStyle Width="120px"></HeaderStyle>
									<ItemTemplate>
										<asp:Label id=LblSezione Width="120px" text='<%# databinder.eval(container.dataitem,"Descrizione") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id=CboSezione runat="server" Width="100px" DataMember="SezioniReport" DataSource="<%# DsNoteSezione %>" DataValueField="IdSezione" DataTextField="Descrizione" Font-Size="11px">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblDataSt" Runat="server">Data</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblDt" Runat="server" text='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtDataI" Runat="server" width="70px" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:TextBox>
										<asp:RegularExpressionValidator id="REVData" runat="server" ErrorMessage="La data non è valida. Formato MM/AAAA"
											Display="None" ValidationExpression="^(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$" ControlToValidate="TxtDataI"></asp:RegularExpressionValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Nota">
									<ItemTemplate>
										<asp:Label id="LblNota" Runat="server" text='<%# databinder.eval(container.dataitem,"Nota") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtNoteST" Runat="server" TextMode="MultiLine" TEXT='<%# databinder.eval(container.dataitem,"Nota") %>' width="100%">
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;">
									<HeaderStyle Width="80px"></HeaderStyle>
								</asp:EditCommandColumn>
								<asp:TemplateColumn>
									<HeaderStyle Width="50px"></HeaderStyle>
									<ItemTemplate>
										<asp:LinkButton id="LnkDeleteNote" runat="server" CausesValidation="false" CommandName="Delete"
											Text="&lt;IMG alt=&quot;Elimina&quot; src=&quot;images/File_delete.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="LnkAggiuntaNote" runat="server">Aggiungi una nuova nota di stampa</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
