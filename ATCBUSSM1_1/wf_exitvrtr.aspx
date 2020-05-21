<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_exitvrtr.aspx.vb" Inherits="ATCBussm1.wf_exitvrtr"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_exitvrtr</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION><br>
        <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label></div>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">Dati del cittadino che 
            ritira il veicolo
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" width="15%">Cognome:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtRitrCognome" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"><asp:requiredfieldvalidator id="rfvRitrCognome" runat="server" ErrorMessage="*" ControlToValidate="txtRitrCognome"></asp:requiredfieldvalidator></td>
          <td class="supExitHeader2" align="right" width="15%">Nome:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtRitrNome" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="center" width="10%"><asp:requiredfieldvalidator id="rfvRitrNome" runat="server" ErrorMessage="*" ControlToValidate="txtRitrNome"></asp:requiredfieldvalidator></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right">Luogo di nascita:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtRitrLuogoNascita" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"><asp:requiredfieldvalidator id="rfvRitrLuogoNascita" runat="server" ErrorMessage="*" ControlToValidate="txtRitrLuogoNascita"></asp:requiredfieldvalidator></td>
          <td class="supExitHeader2" align="right">Data di nascita:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtRitrDataNascita" Runat="server" Width="70" CssClass="supExitTextBox"></asp:textbox>&nbsp; 
            (gg/mm/aaaa)</td>
          <td class="supExitHeader2" align="center"><asp:regularexpressionvalidator id="revRitrDataNascita" runat="server" Width="100%" ErrorMessage="E" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
              ControlToValidate="txtRitrDataNascita"></asp:regularexpressionvalidator></td>
          <td class="supExitHeader2" align="center"><asp:requiredfieldvalidator id="rfvRitrDataNascita" runat="server" ErrorMessage="*" ControlToValidate="txtRitrDataNascita"></asp:requiredfieldvalidator></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right">Luogo di residenza:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtRitrLuogoResidenza" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"><asp:requiredfieldvalidator id="rfvRitrLuogoResidenza" runat="server" ErrorMessage="*" ControlToValidate="txtRitrLuogoResidenza"></asp:requiredfieldvalidator></td>
          <td class="supExitHeader2" align="right">Indirizzo:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtRitrIndirizzo" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="center"><asp:requiredfieldvalidator id="rfvRitrIndirizzo" runat="server" ErrorMessage="*" ControlToValidate="txtRitrIndirizzo"></asp:requiredfieldvalidator></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">Documento presentato
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left" colSpan="7">&nbsp; Patente di guida
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" width="15%">Numero:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtNumPatente" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="right" width="15%">Rilasciata da:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtRilPatente" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left" colSpan="7">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left">&nbsp; oppure</td>
          <td class="supExitHeader2" align="left" colSpan="4"><asp:dropdownlist id="ddlTipoDocumento" Runat="Server" Width="100%" CssClass="supExitTextBox"></asp:dropdownlist></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right">Numero:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtNumDocumento" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="right">Rilasciato da:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtRilDocumento" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">Dati del proprietario del 
            veicolo (se diversi da sopra)
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" width="15%">Cognome:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtPropCognome" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="right" width="15%">Nome:
          </td>
          <td class="supExitHeader2" align="left" width="20%"><asp:textbox id="txtPropNome" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="center" width="10%"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right">Luogo di nascita:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtPropLuogoNascita" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="right">Data di nascita:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtPropDataNascita" Runat="server" Width="70" CssClass="supExitTextBox"></asp:textbox>&nbsp; 
            (gg/mm/aaaa)</td>
          <td class="supExitHeader2" align="center"><asp:regularexpressionvalidator id="revPropDataNascita" runat="server" Width="100%" ErrorMessage="E" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
              ControlToValidate="txtPropDataNascita"></asp:regularexpressionvalidator></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right">Luogo di residenza:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtPropLuogoResidenza" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="right">Indirizzo:
          </td>
          <td class="supExitHeader2" align="left"><asp:textbox id="txtPropIndirizzo" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox></td>
          <td class="supExitHeader2" align="center"></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="3">Danni rilevati all'atto del 
            ritiro</td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="center" width="33.3%">Strisciature
          </td>
          <td class="supExitHeader1" align="center" width="33.4%">Ammaccature
          </td>
          <td class="supExitHeader1" align="center" width="33.3%">Rotture
          </td>
        </tr>
        <tr>
          <td align="center" colSpan="3"><asp:table id="tblDamage" Runat="server"></asp:table></td>
        </tr>
      </table>
      <br>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">Servizi di Rimozione e 
            Custodia
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="center" width="15%">Causale</td>
          <td class="supExitHeader1" align="center" width="60%">Descrizione tariffa 
            applicata</td>
          <td class="supExitHeader1" align="center" width="10%">Imp. unit.</td>
          <td class="supExitHeader1" align="center" width="10%">Importo</td>
          <td class="supExitHeader1" align="center" width="5%"></td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left" colSpan="5">&nbsp; &nbsp; Rimozione
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Diritto di chiamata
          </td>
          <td class="supExitHeader2" align="left"><asp:label id="lblChiamataDesc" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblChiamataImpUnit" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblChiamataImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Op. conn. rimozione
          </td>
          <td class="supExitHeader2" align="left"><asp:label id="lblOpCoRimzDesc" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblOpCoRimzImpUnit" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblOpCoRimzImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Trasporto
          </td>
          <td class="supExitHeader2" align="left"><asp:label id="lblTrasportoDesc" Runat="server" Width="100%" CssClass="supExitTableCellLR"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTrasportoImpUnit" Runat="server" Width="100%" CssClass="supExitTableCellLR"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTrasportoImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" colSpan="3">&nbsp; Totale rimozione
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTotRimozione" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Bollo
          </td>
          <td class="supExitTableCellLR" align="left">&nbsp; Spese aggiuntive
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblBolloImpUnit" Runat="server" Width="100%" CssClass="supExitTableCellLR"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblBolloImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" colSpan="3">&nbsp; Totale rimozione + 
            bollo
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTotRimozioneBollo" Runat="server" Width="100%" CssClass="supExitTableCellLRLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left" colSpan="5">&nbsp; &nbsp; Custodia
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Prime 12 ore
          </td>
          <td class="supExitTableCell" align="left">&nbsp; Tariffa unica
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustMGImpUnit" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustMGImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Primo giorno
          </td>
          <td class="supExitTableCell" align="left">&nbsp; Tariffa unica
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustPGImpUnit" Runat="server" Width="100%" CssClass="supExitTableCell"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustPGImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; Dal secondo giorno
          </td>
          <td class="supExitTableCellLR" align="left">&nbsp; Tariffa unica
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustSGImpUnit" Runat="server" Width="100%" CssClass="supExitTableCellLR"></asp:label></td>
          <td class="supExitHeader2" align="right"><asp:label id="lblCustSGImporto" Runat="server" Width="100%" CssClass="supExitTableCellLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" colSpan="3">&nbsp; Totale custodia
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTotCustodia" Runat="server" Width="100%" CssClass="supExitTableCellLRLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" colSpan="3">&nbsp; Totale rimozione + 
            bollo + custodia
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTotRimozioneCustodia" Runat="server" Width="100%" CssClass="supExitTableCellLRLC"></asp:label></td>
          <td></td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="10">Sanzioni per infrazioni al 
            Codice della Strada
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="10">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="center" width="10%">N.Verbale</td>
          <td class="supExitHeader1" align="center" width="10%">Cod.Infr. 1</td>
          <td class="supExitHeader1" align="center" width="10%">Importo</td>
          <td class="supExitHeader1" align="center" width="10%">Cod.Infr. 2</td>
          <td class="supExitHeader1" align="center" width="10%">Importo</td>
          <td class="supExitHeader1" align="center" width="10%">Cod.Infr. 3</td>
          <td class="supExitHeader1" align="center" width="10%">Importo</td>
          <td class="supExitHeader1" align="center" width="10%">Bollo</td>
          <td class="supExitHeader1" align="center" width="15%">Totale verbale</td>
          <td class="supExitHeader1" align="center" width="5%"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" colSpan="9"><asp:table id="tblSanzioni" Runat="server" Width="100%" CssClass="supExitTable" CellPadding="0"
              CellSpacing="0"></asp:table></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" colSpan="10"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" colSpan="8">Totale sanzioni &nbsp;
          </td>
          <td class="supExitHeader2" align="right"><asp:label id="lblTotSanzioni" Runat="server" Width="100%" CssClass="supExitTableCellLRLC"></asp:label></td>
          <td class="supExitHeader2" align="center"></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" colSpan="10">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" colSpan="10">&nbsp;
            <asp:checkbox id="chkSanzioni" Runat="server" CssClass="supExitHeader1" Text="L'utente intede pagare l'importo relativo alle sanzioni"
              AutoPostBack="True"></asp:checkbox></td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" colSpan="10">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table id="tblQuietanzeCdS" runat="server" class="supExitTable" cellSpacing="0" cellPadding="0"
        width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">Quietanze di pagamento 
            infrazioni al C.d.S
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="left">&nbsp; pagamento</td>
          <td class="supExitHeader2" align="left" colspan="5">
            <asp:dropdownlist id="ddlPagamento" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:dropdownlist>
          </td>
          <td class="supExitHeader2" align="center">
            <asp:requiredfieldvalidator id="rfvPagamento" runat="server" ControlToValidate="ddlPagamento" ErrorMessage="*"></asp:requiredfieldvalidator>
          </td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="center" width="100">&nbsp;</td>
          <td class="supExitHeader2" align="center" width="100">N.Quietanza</td>
          <td class="supExitHeader2" align="center" width="100">N.Verbale</td>
          <td class="supExitHeader2" align="center" width="100">Importo</td>
          <td class="supExitHeader2" align="center" width="100">Bollo</td>
          <td class="supExitHeader2" align="center" width="100">Totale</td>
          <td class="supExitHeader2" align="center" width="150">&nbsp;</td>
        </tr>
        <tr valign="top">
          <td class="supExitHeader2" align="center">&nbsp;</td>
          <td class="supExitHeader2" align="left" colSpan="5">&nbsp;
            <asp:Table ID="tblQCdSData" Runat="server" CellPadding="0" CellSpacing="0" CssClass="supExitTable"
              Width="100%"></asp:Table>
          </td>
          <td class="supExitHeader2" align="center">&nbsp;</td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="7">&nbsp;
          </td>
        </tr>
      </table>
      <br>
      <table cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr vAlign="middle" height="50">
          <td align="center" width="50%"><asp:button id="btnSave" Runat="server" CssClass="Button" Text="Salva"></asp:button></td>
          <td align="center" width="50%"><asp:hyperlink id="hlkBack" Runat="server" CssClass="Link">Annulla</asp:hyperlink></td>
        </tr>
      </table>
    </form>
  </body>
</HTML>
