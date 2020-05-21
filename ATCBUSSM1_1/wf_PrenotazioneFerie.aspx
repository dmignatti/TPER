<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_PrenotazioneFerie.aspx.vb" Inherits="ATCBussm1.wf_PrenotazioneFerie"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wf_prenotazioneferie</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="ATC.css">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<script type="text/javascript">  

		  function intervallo() {  

		window.history.forward();
			
		  var source;
		  
            source = document.getElementsByName("dgPrenotazioneferie:_ctl2:ddlintervalloferie")[0];
            if (typeof(source) != "undefined")
            {
			for (var i = 0; i < source.options.length; i++) {   
			//alert(source.options[i].text);
			var ultimedue; 
			ultimedue =  source.options[i].text.slice(source.options[i].text.length-2);
			//alert(ultimedue);
			if (ultimedue==" 0") 
			{
				source.options[i].style.backgroundColor = "Red"; 
			}
			else 
			{
				source.options[i].style.backgroundColor = "#e1ffd5";
			}


        }
	}
  }  
		</script>
	</HEAD>
	<body onload="intervallo()">
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
						<h6>Prenotazione ferie<br>
							<span class="label">(Le prenotazioni sono in ordine decrescente&nbsp;dalla più 
								recente alla più vecchia.<br>
								Vengono mostrate solamente le richieste che si riferiscono a periodi futuri)</span></h6>
						<hr SIZE="1" noShade>
						<asp:validationsummary id="vsErrori" runat="server" Width="100%" HeaderText="Attenzione!" CssClass="Error"></asp:validationsummary><asp:label id="lblIntervalliEsauriti" runat="server" CssClass="label"></asp:label>
						<asp:label id=Label3 runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichiestaPrenotazione1, "Tables[Accertatori_PrenotazioneIntervalliValidi]").Rows.Count <= 0 %>'>In data odierna la prenotazione ferie non è disponibile.</asp:label>
						<asp:label id=lblRichieste runat="server" CssClass="label" Visible='<%# DataBinder.Eval(DsRichiestaPrenotazione1, "Tables[Accertatori_PrenotazioneRichiesta]").Rows.Count <= 0 and DataBinder.Eval(DsRichiestaPrenotazione1, "Tables[Accertatori_PrenotazioneIntervalliValidi]").Rows.Count > 0 %>'>Non ci sono richieste di prenotazione ferie.</asp:label>
						<asp:button id="btnAddPrenotazione" runat="server" CssClass="bottone" CausesValidation="False"
							Text="Nuova prenotazione ferie"></asp:button><asp:datagrid id=dgPrenotazioneferie runat="server" Width="100%" CssClass="grid" Visible='<%# DataBinder.Eval(DsRichiestaPrenotazione1, "Tables[Accertatori_PrenotazioneRichiesta]").Rows.Count > 0 %>' DataSource="<%# DsRichiestaPrenotazione1 %>" DataMember="Accertatori_PrenotazioneRichiesta" DataKeyField="ID" UseAccessibleHeader="True" AutoGenerateColumns="False" GridLines="None">
							<Columns>
								<asp:BoundColumn DataField="ID" SortExpression="ID" ReadOnly="True" Visible="false"></asp:BoundColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lnkModifica" Visible="false" runat="server" CausesValidation="False" CommandName="Edit"
											Text="Modifica">Modifica</asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="LinkButton3" runat="server" CausesValidation="True" CommandName="Update" Text="Ok"></asp:LinkButton>&nbsp;
										<asp:LinkButton id="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancel" Text="Annulla"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="DataPrenotazione" SortExpression="DataPrenotazione" ReadOnly="True" HeaderText="Data prenotazione"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Intervallo di ferie">
									<ItemTemplate>
										<asp:Label id="Label1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nome") %>'>
										</asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:DropDownList ID="ddlintervalloferie" name ="ddlintervalloferie" Runat ="server" DataMember="Accertatori_PrenotazioneIntervalliValidi" DataSource="<%# DsRichiestaPrenotazione1 %>" DataValueField="ID" DataTextField ="Nome" >
										</asp:DropDownList>
										<asp:customvalidator id="validaintervallo" OnServerValidate="validaintervallo_OnServerValidate" runat="server"
											ErrorMessage="Esaurita disponibilità su questo intervallo." ControlToValidate="ddlintervalloferie"
											Display="None"></asp:customvalidator>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn HeaderText="Stato prenotazione">
									<ItemTemplate>
										<asp:Label id="lblStatoPrenotazione" BackColor= runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Stato") %>'>
										</asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="DataApprovazione" SortExpression="DataApprovazione" ReadOnly="True"
									HeaderText="Data di Approvazione"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="IdApprovatore" SortExpression="IdApprovatore" ReadOnly="True"
									HeaderText="Approvatore"></asp:BoundColumn>
							</Columns>
						</asp:datagrid><asp:customvalidator id="cvOnModifica" runat="server" ErrorMessage="Non è possibile modificare o eliminare questa richiesta."
							Display="None"></asp:customvalidator></td>
				</tr>
				<tr>
					<td style="HEIGHT: 4px; VERTICAL-ALIGN: top" vAlign="baseline"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-LEFT: 0px" alt="" align="left"
							src="images/corner_bl.gif" width="4" height="4"><IMG style="MARGIN-TOP: 0px; MARGIN-BOTTOM: 0px; MARGIN-RIGHT: 0px" alt="" align="right"
							src="images/corner_br.gif" width="4" height="4"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
