<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_CSConsumiAz.aspx.vb" Inherits="ATCBussm1.wf_CSConsumiAz" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_CSConsumiAz</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="ATC.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="FrmConsumiCS" method="post" runat="server">
			<DIV align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION></DIV>
			<DIV align="center"><asp:validationsummary id="VSConsumiAz" runat="server" Width="100%" HeaderText="Attenzione!" DESIGNTIMEDRAGDROP="459"></asp:validationsummary><br>
			</DIV>
			<DIV align="center"><asp:panel id="Panel1" runat="server" Visible="TRUE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Ricerca</LEGEND>
						<TABLE id="tblSearch" height="100%" cellSpacing="2" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 72px; HEIGHT: 18px">
									<asp:Label id="lblAnno" runat="server" CssClass="label">Mese/Anno</asp:Label></TD>
								<TD style="WIDTH: 210px; HEIGHT: 18px">
									<asp:Label id="LblGruppo" runat="server" CssClass="label">Gruppo aziendale</asp:Label></TD>
								<TD style="WIDTH: 217px; HEIGHT: 18px">
									<asp:Label id="LblCentroC" runat="server" CssClass="label">Centro di costo aziendale</asp:Label></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 72px">
									<asp:TextBox id="txtMeseAnno" runat="server" Width="100px"></asp:TextBox></TD>
								<TD style="WIDTH: 210px">
									<asp:DropDownList id=cboGruppo runat="server" Width="200px" DataSource="<%# DsConsumi %>" DataMember="CS_Gruppi" DataTextField="GruppoCS" DataValueField="IdGruppoCS">
									</asp:DropDownList></TD>
								<TD style="WIDTH: 217px">
									<asp:DropDownList id=cboCentro runat="server" Width="200px" DataSource="<%# DsConsumi %>" DataMember="CS_Centri" DataTextField="CentroCS" DataValueField="IdCentroCS">
									</asp:DropDownList></TD>
								<TD>
									<asp:Button id="btnFind" runat="server" CssClass="bottone" Text="Cerca"></asp:Button></TD>
							</TR>
							<TR height="24">
								<TD colSpan="2">
									<asp:LinkButton id="LnkGruppo" style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif"
										runat="server" ForeColor="DarkBlue" CausesValidation="false" CommandName="Add"><IMG alt="Aggiungi" src="images/Impost.gif" border="0" width="18" height="18" align="absbottom"> Gruppi Consumo</asp:LinkButton></TD>
								<TD colSpan="2">
									<asp:LinkButton id="LnkCentro" style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif"
										runat="server" ForeColor="DarkBlue" CausesValidation="false" CommandName="Add"><IMG alt="Aggiungi" src="images/Impost.gif" border="0" width="18" height="18" align="absbottom"> Centri Consumo</asp:LinkButton></TD>
							</TR>
						</TABLE>
					</FIELDSET>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="pnlConsumi" runat="server" Visible="FALSE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Consumi aziendali - Car Sharing</LEGEND><BR>
						<asp:datagrid id=dgConsumiCS runat="server" Width="100%" Visible="TRUE" CssClass="grid" DataSource="<%# DsConsumi %>" DataMember="Consumi" ForeColor="Black" UseAccessibleHeader="True" DataKeyField="Id" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="2" BorderColor="#CCCCCC">
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
										<asp:Label id="LblDataI" Text='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:textbox id="TxtDataC" runat="server" width="70px" TEXT='<%# FORMAT(databinder.eval(container.dataitem,"Data"),"MM/yyyy") %>'>
										</asp:textbox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHGroup" Runat="server">Gruppo Az.</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblGrupA" Text='<%# databinder.eval(container.dataitem,"GruppoCS") %>' Runat="server">
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboGroup" runat="server" Width="150px" DataSource="<%# DsConsumi %>" DataMember="CS_Gruppi" DataTextField="GruppoCS" DataValueField="IdGruppoCS" AutoPostBack="True" >
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHCentro" Runat="server">Centro Consumo</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblCentro" Runat="server" text='<%# databinder.eval(container.dataitem,"CentroCS") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList id="CboCentroA" runat="server" Width="150px" DataSource="<%# DsConsumi %>" DataMember="CS_Centri" DataTextField="CentroCS" DataValueField="IdCentroCS" AutoPostBack="false">
										</asp:DropDownList>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="IdCentroCCS" SortExpression="IdCentroCCS" ReadOnly="True"
									HeaderText="Centro"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdGruppoCCS" SortExpression="IdGruppoCCS" ReadOnly="True"
									HeaderText="Gruppo"></asp:BoundColumn>
								<asp:TemplateColumn>
									<HeaderTemplate>
										<asp:Label id="LblHValore" Runat="server">Valore</asp:Label>
									</HeaderTemplate>
									<ItemTemplate>
										<asp:Label id="LblIValore" Runat="server" text='<%# databinder.eval(container.dataitem,"Valore") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id="TxtValore" Runat="server" width="70px" TEXT='<%# databinder.eval(container.dataitem,"Valore") %>'>
										</asp:TextBox>
										<asp:CompareValidator id="cvValore" runat="server" Display="None" ControlToValidate="TxtValore" ErrorMessage="Il campo Valore deve essere di tipo numerico."
											Type="Double" Operator="DataTypeCheck"></asp:CompareValidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkDelete" runat="server" Text='<IMG alt="Elimina" src="images/File_delete.gif" border="0" width="24" height="24">'
											CommandName="Delete" CausesValidation="false"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle NextPageText="Successiva" PrevPageText="Precedente" HorizontalAlign="Center" ForeColor="#29448B"
								CssClass="Descrizione"></PagerStyle>
						</asp:datagrid><BR>
						<BR>
						<asp:LinkButton id="lnkAddnew" runat="server">Aggiungi un nuovo consumo</asp:LinkButton></FIELDSET>
					<BR>
					<BR>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="PnlCentri" runat="server" Visible="FALSE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Centro consumo aziendale - 
							CarSharing</LEGEND><BR>
						<asp:datagrid id=DgCentri runat="server" Width="100%" Visible="true" CssClass="grid" DataSource="<%# DsConsumi %>" DataMember="CS_Centri" ForeColor="Black" UseAccessibleHeader="True" DataKeyField="IdCentroCS" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="2" BorderColor="#CCCCCC">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle CssClass="RigaDataGrid"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="IdCentroCS" SortExpression="IdCentroCS" ReadOnly="True"
									HeaderText="IdCentroCS"></asp:BoundColumn>
								<asp:BoundColumn DataField="CentroCS" SortExpression="CentroCS" HeaderText="Centro"></asp:BoundColumn>
								<asp:BoundColumn DataField="OrdineC" SortExpression="OrdineC" HeaderText="OrdineC"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="LnkDelCentro" runat="server" Text='<IMG alt="Elimina" src="images/File_delete.gif" border="0" width="24" height="24">'
											CommandName="Delete" CausesValidation="false"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><BR>
						<asp:LinkButton id="LnkAggCentro" runat="server">Aggiungi un nuovo centro</asp:LinkButton></FIELDSET>
					<BR>
					<BR>
				</asp:panel></DIV>
			<DIV align="center"><asp:panel id="PnlGruppi" runat="server" Visible="FALSE" Width="600px">
					<FIELDSET style="WIDTH: 100%"><LEGEND class="label">Gruppo consumo aziendale - 
							CarSharing</LEGEND><BR>
						<asp:datagrid id=DgGruppi runat="server" Width="100%" Visible="TRUE" CssClass="griglia" DataSource="<%# DsConsumi %>" DataMember="CS_Gruppi" ForeColor="Black" DataKeyField="IdGruppoCS" GridLines="Vertical" AutoGenerateColumns="False" CellPadding="2" BorderColor="#CCCCCC">
							<SelectedItemStyle ForeColor="HighlightText" BackColor="Highlight"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F0F0F0"></AlternatingItemStyle>
							<ItemStyle Font-Names="Verdana" CssClass="RigaDataGrid"></ItemStyle>
							<HeaderStyle Font-Size="11pt" Font-Names="Times New Roman" Font-Bold="True" ForeColor="White"
								CssClass="RigaDataGrid" BackColor="#990033"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="IdGruppoCS" SortExpression="IdGruppoCS" ReadOnly="True"
									HeaderText="IdGruppoCS"></asp:BoundColumn>
								<asp:BoundColumn DataField="GruppoCS" SortExpression="GruppoCS" HeaderText="Gruppo"></asp:BoundColumn>
								<asp:BoundColumn DataField="OrdineG" SortExpression="OrdineG" HeaderText="OrdineG"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="&lt;IMG alt=&quot;Conferma&quot; src=&quot;images/File_Save.gif&quot; border=&quot;0&quot; "
									CancelText="&lt;IMG alt=&quot;Annulla&quot; src=&quot;images/File_Cancel.gif&quot; border=&quot;0&quot; "
									EditText="&lt;IMG alt=&quot;Modifica&quot; src=&quot;images/File_Edit.gif&quot; border=&quot;0&quot; width=&quot;24&quot; height=&quot;24&quot;&gt;"></asp:EditCommandColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="LnkDelGruppo" runat="server" Text='<IMG alt="Elimina" src="images/File_delete.gif" border="0" width="24" height="24">'
											CommandName="Delete" CausesValidation="false"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid><BR>
						<asp:LinkButton id="LnkAggGruppo" runat="server">Aggiungi un nuovo gruppo</asp:LinkButton></FIELDSET>
					<BR>
					<BR>
				</asp:panel></DIV>
		</form>
	</body>
</HTML>
