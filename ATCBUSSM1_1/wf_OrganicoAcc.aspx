<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_OrganicoAcc.aspx.vb" Inherits="ATCBussm1.wf_OrganicoAcc"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_OrganicoAcc</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmOrganico" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSOrganicoAcc" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary></DIV>
			<DIV align="center"><asp:panel id="PnlRicerca" runat="server" Width="700px" Visible="TRUE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 297px" align="right">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Anno</asp:Label>
									<asp:TextBox id="txtAnno" runat="server" Width="67px"></asp:TextBox></TD>
								<TD align="left">
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button>
									<asp:RequiredFieldValidator id="rfvAnno" runat="server" ErrorMessage="Il campo Anno è obbligatorio." ControlToValidate="txtAnno"
										Display="None"></asp:RequiredFieldValidator>
									<asp:CompareValidator id="cvAnno" runat="server" ErrorMessage="Il campo Anno deve essere di tipo numerico e maggiore di 1980"
										ControlToValidate="txtAnno" Display="None" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="1980"></asp:CompareValidator></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="PnlOrganico" runat="server" Width="700px" Visible="false">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Organico operatori della 
							mobilità</LEGEND><BR>
						<BR>
						<asp:datagrid id="DgOrganicoAcc" runat="server" Width="100%" Visible="true" CssClass="grid" BorderColor="#CCCCCC" CellPadding="2" ForeColor="Black" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id" DataMember="OrganicoAcc" DataSource="<%# DsOrganicoAcc %>" UseAccessibleHeader="True">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle CssClass="RigaDataGrid"></HeaderStyle>
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
										<asp:TextBox id="TxtDataI" Runat="server" width="70px" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:TextBox>
										<asp:RegularExpressionValidator id="REVData" runat="server" Display="None" ValidationExpression="^(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
											ControlToValidate="TxtDataI" ErrorMessage="La data non è valida. Formato MM/AAAA"></asp:RegularExpressionValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHFullTEff" Runat="server">Full time eff.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblFullTEff" Runat="server" text='<%# databinder.eval(container.dataitem,"FullTEff") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtFullTEff" Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"FullTEff") %>'>
										</asp:TextBox>
										<asp:CustomValidator id="CVFTE" runat="server" Width="53px" Display="None" ControlToValidate="TxtFullTEff"
											ErrorMessage="Full time eff. non valido. Formato numerico." OnServerValidate="CVFTE_OnServerValidate"
											EnableClientScript="False"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHPartTEff" Runat="server">Part time eff.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblPartTEff" Runat="server" text='<%# databinder.eval(container.dataitem,"PartTEff") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtPartTEff" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"PartTEff") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVPTE" runat="server" Width="53px" ErrorMessage="Part time eff. non valido. Formato numerico."
											ControlToValidate="TxtPartTEff" Display="None" EnableClientScript="False" OnServerValidate="CVPTE_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHEquivEff" Runat="server">Equivalenti eff.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblEquivEff" Runat="server" text='<%# databinder.eval(container.dataitem,"EquivEff") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtEquivEff" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"EquivEff") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVEQE" runat="server" Width="53px" ErrorMessage="Equivalenti eff. non valido. Formato numerico."
											ControlToValidate="TxtEquivEff" Display="None" EnableClientScript="False" OnServerValidate="CVEQE_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHFullTAsp" Runat="server">Full time asp.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblFullTAsp" Runat="server" text='<%# databinder.eval(container.dataitem,"FullTAsp") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtFullTAsp" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"FullTAsp") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVFTA" runat="server" Width="53px" ErrorMessage="Full time asp. non valido. Formato numerico."
											ControlToValidate="TxtFullTAsp" Display="None" EnableClientScript="False" OnServerValidate="CVFTA_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHPartTAsp" Runat="server">Part time asp.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblPartTAsp" Runat="server" text='<%# databinder.eval(container.dataitem,"PartTAsp") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtPartTAsp" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"PartTAsp") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVPTA" runat="server" Width="53px" ErrorMessage="Part time asp. non valido. Formato numerico."
											ControlToValidate="TxtPartTAsp" Display="None" EnableClientScript="False" OnServerValidate="CVPTA_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHEquivAsp" Runat="server">Equivalenti asp.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblEquivAsp" Runat="server" text='<%# databinder.eval(container.dataitem,"EquivAsp") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtEquivAsp" Runat="server" TEXT='<%# databinder.eval(container.dataitem,"EquivAsp") %>' width="70px">
										</asp:TextBox>
										<asp:CustomValidator id="CVEQA" runat="server" Width="53px" ErrorMessage="Equivalenti asp. non valido. Formato numerico."
											ControlToValidate="TxtEquivAsp" Display="None" EnableClientScript="False" OnServerValidate="CVEQA_OnServerValidate"></asp:CustomValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="DataCreazione" SortExpression="DataCreazione" HeaderText="DataCreazione"></asp:BoundColumn>
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
								CssClass="Descrizione"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo mese</asp:LinkButton></FIELDSET>
					<BR>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="PnlNoteStampa" runat="server" Width="700px" Visible="FALSE">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Note per la stampa</LEGEND><BR>
						<asp:datagrid id="DgNote" runat="server" Width="100%" Visible="TRUE" CssClass="grid" BorderColor="#CCCCCC" CellPadding="2" ForeColor="Black" AutoGenerateColumns="False" GridLines="Vertical" DataKeyField="Id" DataMember="OrganicoNoteSt" DataSource="<%# DsOrganicoAcc %>" UseAccessibleHeader="True">
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Id" SortExpression="Id" ReadOnly="True" HeaderText="Id"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHDataN" Runat="server">Data</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblDtN" Runat="server" text='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"yyyy") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtDataN" Runat="server" width="70px" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"yyyy") %>'>
										</asp:TextBox>
										<asp:RegularExpressionValidator id="REVDataN" runat="server" Display="None" ValidationExpression="^((1[6-9]|[2-9]\d)\d{2})$"
											ControlToValidate="TxtDataN" ErrorMessage="La data non è valida. Formato MM/AAAA"></asp:RegularExpressionValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHNote" Runat="server">Note per la stampa</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblNote" Runat="server" text='<%# databinder.eval(container.dataitem,"Nota") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtNote" Runat="server" width="470px" TEXT='<%# databinder.eval(container.dataitem,"Nota") %>' TextMode="MultiLine">
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="LnkDelNota" runat="server" Text='<IMG alt="Elimina" src="images/File_delete.gif" border="0" width="24" height="24">'
											CommandName="Delete" CausesValidation="false"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><BR>
						<asp:LinkButton id="LnkAggNota" runat="server">Aggiungi un nuova nota</asp:LinkButton></FIELDSET>
					<BR>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
