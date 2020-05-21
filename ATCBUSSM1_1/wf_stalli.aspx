<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_stalli.aspx.vb" Inherits="ATCBussm1.wf_stalli" smartNavigation="True"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_stalli</title>
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
			<DIV align="center"><asp:validationsummary id="VSStalli" runat="server" DESIGNTIMEDRAGDROP="459" HeaderText="Attenzione!" Width="100%"></asp:validationsummary></DIV>
			<div align="center"><asp:panel id="pnlSearch" runat="server" Width="600px">
					<FIELDSET><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 227px">
									<asp:Label id="lblVia" runat="server" CssClass="label">Via</asp:Label></TD>
								<TD>
									<asp:Label id="lblPeriodo" runat="server" CssClass="label">Zona</asp:Label></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 227px">
									<asp:TextBox id="txtVia" runat="server" Width="320px"></asp:TextBox></TD>
								<TD>
									<asp:DropDownList id=cboSettori runat="server" Width="196px" DataValueField="ID_SZF" DataTextField="Desc_Dettaglio_Settore" DataSource="<%# DsStalli %>" DataMember="Settori">
									</asp:DropDownList></TD>
								<TD>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
							</TR>
							<TR>
								<TD>
									<asp:LinkButton id="LnkStampa" style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif"
										runat="server" CommandName="Add" CausesValidation="false" ForeColor="DarkBlue"><IMG alt="Aggiungi" src="images/Impost.gif" border="0" width="18" height="18" align="absbottom"> Note stampa</asp:LinkButton></TD>
								<TD colSpan="2"></TD>
							</TR>
						</TABLE>
					</FIELDSET>
					<BR>
				</asp:panel></div>
			<DIV align="center"><asp:panel id="pnlStalli" runat="server" Width="100%" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Stalli - Piano sosta</LEGEND><BR>
						<asp:datagrid id=dgStalli runat="server" Width="100%" CssClass="grid" DataSource="<%# DsStalli %>" DataMember="Stalli" UseAccessibleHeader="True" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False" AllowPaging="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="id" SortExpression="id" ReadOnly="True" HeaderText="id"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CivKey" SortExpression="CivKey" ReadOnly="True" HeaderText="CivKey"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Via">
									<ItemTemplate>
										<asp:Label id="LblIVia" Runat="server" text='<%# databinder.eval(container.dataitem,"Nome") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboVia" runat="server" Width="250px" Font-Size="10px" DataSource="<%# DsStalli %>" DataMember="StradarioBologna" DataTextField="Nome" DataValueField="Codice" >
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="ID_SZF" SortExpression="ID_SZF" ReadOnly="True" HeaderText="ID_SZF"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Settore">
									<ItemTemplate>
										<asp:Label id="Label1" Runat="server" Font-Size = "8px" text='<%# databinder.eval(container.dataitem,"Desc_Dettaglio_Settore") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboSettore" runat="server" Width="100px" Font-Size="10px" DataSource="<%# DsStalli %>" DataMember="Settori" DataTextField="Desc_Dettaglio_Settore" DataValueField="Id_SZF" >
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Note">
									<ItemTemplate>
										<asp:Label id="LblINote" Runat="server" text='<%# databinder.eval(container.dataitem,"Note") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtNote" Runat="server" TextMode="MultiLine" Font-Size = "8px" TEXT='<%# databinder.eval(container.dataitem,"Note") %>' width="100px">
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Ord.">
									<ItemTemplate>
										<asp:Label id="LblIBlu" Runat="server" text='<%# databinder.eval(container.dataitem,"Blu") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtBlu" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Blu") %>' width="40px" STYLE="Text_align:RIGHT;">
										</asp:TextBox>
										<asp:CustomValidator id="CVBlu" runat="server" Width="53px" ErrorMessage="Stalli blu non validi. Formato numerico."
											ControlToValidate="TxtBlu" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="R.R.">
									<ItemTemplate>
										<asp:Label id="LblIVerde" Runat="server" text='<%# databinder.eval(container.dataitem,"Verde") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtVerde" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Verde") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVVerde" runat="server" Width="53px" ErrorMessage="Stalli verde non validi. Formato numerico."
											ControlToValidate="TxtVerde" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Disab.">
									<ItemTemplate>
										<asp:Label id="LblIHandi" Runat="server" text='<%# databinder.eval(container.dataitem,"Handi") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtHandi" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Handi") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVHandi" runat="server" Width="53px" ErrorMessage="Stalli handicap non validi. Formato numerico."
											ControlToValidate="TxtHandi" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Res.">
									<ItemTemplate>
										<asp:Label id="LblIResidenti" Runat="server" text='<%# databinder.eval(container.dataitem,"Residenti") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtResidenti" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Residenti") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="Customvalidator2" runat="server" Width="53px" ErrorMessage="Stalli residenti non validi. Formato numerico."
											ControlToValidate="TxtResidenti" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Gen.">
									<ItemTemplate>
										<asp:Label id="LblIRiservatoGenerico" Runat="server" text='<%# databinder.eval(container.dataitem,"RiservatoGenerico") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtRiservatoGenerico" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"RiservatoGenerico") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVRiservatoGenerico" runat="server" Width="53px" ErrorMessage="Budget non valido. Formato numerico."
											ControlToValidate="TxtRiservatoGenerico" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="C/Scarico">
									<ItemTemplate>
										<asp:Label id="LblICaricoScarico" Runat="server" text='<%# databinder.eval(container.dataitem,"CaricoScarico") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtCaricoScarico" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"CaricoScarico") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVCaricoScarico" runat="server" Width="53px" ErrorMessage="Stalli carico scarico non validi. Formato numerico."
											ControlToValidate="TxtCaricoScarico" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Moto">
									<ItemTemplate>
										<asp:Label id="LblIMoto" Runat="server" text='<%# databinder.eval(container.dataitem,"Moto") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtMoto" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Moto") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVMoto" runat="server" Width="53px" ErrorMessage="Moto non valido. Formato numerico."
											ControlToValidate="TxtMoto" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="D.Orario">
									<ItemTemplate>
										<asp:Label id="LblIdiscoorario" Runat="server" text='<%# databinder.eval(container.dataitem,"discoorario") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Txtdiscoorario" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"discoorario") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVdiscoorario" runat="server" Width="53px" ErrorMessage="Stalli disco orario non validi. Formato numerico."
											ControlToValidate="Txtdiscoorario" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Sospesi">
									<ItemTemplate>
										<asp:Label id="LblIsospesi" Runat="server" text='<%# databinder.eval(container.dataitem,"sospesi") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Txtsospesi" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"sospesi") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVsospesi" runat="server" Width="53px" ErrorMessage="Stalli sospesi non validi. Formato numerico."
											ControlToValidate="Txtsospesi" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Libera">
									<ItemTemplate>
										<asp:Label id="LblIlibera" Runat="server" text='<%# databinder.eval(container.dataitem,"libera") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="Txtlibera" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"libera") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="CVlibera" runat="server" Width="53px" ErrorMessage="Libera non valido. Formato numerico."
											ControlToValidate="Txtlibera" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Carsharing">
									<ItemTemplate>
										<asp:Label id="LblCarsharing" Runat="server" text='<%# databinder.eval(container.dataitem,"Carsharing") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtCarsharing" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"Carsharing") %>' width="50px">
										</asp:TextBox>
										<asp:CustomValidator id="Customvalidator1" runat="server" Width="53px" ErrorMessage="Carsharing non valido. Formato numerico."
											ControlToValidate="TxtCarsharing" Display="None" EnableClientScript="False" OnServerValidate="CVNumerico_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
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
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi una nuova riga di stalli</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlNote" runat="server" Width="100%" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Stalli - Note stampa</LEGEND><BR>
						<asp:datagrid id=dgNoteSt runat="server" Width="100%" CssClass="grid" DataSource="<%# DsStalli %>" DataMember="StalliNoteSt" UseAccessibleHeader="True" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
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
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
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
