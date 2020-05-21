<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_exitvhnd.aspx.vb" Inherits="ATCBussm1.wf_exitvhnd"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_exitvhnd</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
          <td class="supExitHeader1" align="left" colSpan="7">&nbsp; Contrassegno di 
            invalidità
          </td>
        </tr>
        <tr>
          <td class="supExitHeader2" align="right" width="15%">Numero:
          </td>
          <td class="supExitHeader2" align="left" width="20%">
            <asp:textbox id="txtNumContrassegno" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox>
          </td>
          <td class="supExitHeader2" align="center" width="10%">
            <asp:requiredfieldvalidator id="revNumContrassegno" runat="server" ErrorMessage="*" ControlToValidate="txtNumContrassegno"></asp:requiredfieldvalidator>
          </td>
          <td class="supExitHeader2" align="right" width="15%">Rilasciato da:
          </td>
          <td class="supExitHeader2" align="left" width="20%">
            <asp:textbox id="txtRilContrassegno" Runat="server" Width="100%" CssClass="supExitTextBox"></asp:textbox>
          </td>
          <td class="supExitHeader2" align="center" width="10%"></td>
          <td class="supExitHeader2" align="center" width="10%">
            <asp:requiredfieldvalidator id="revRilContrassegno" runat="server" ErrorMessage="*" ControlToValidate="txtRilContrassegno"></asp:requiredfieldvalidator>
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="left" colSpan="7">&nbsp;
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
      <table cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr vAlign="middle" height="50">
          <td align="center" width="50%"><asp:button id="btnSave" Runat="server" CssClass="Button" Text="Salva"></asp:button></td>
          <td align="center" width="50%"><asp:hyperlink id="hlkBack" Runat="server" CssClass="Link">Annulla</asp:hyperlink></td>
        </tr>
      </table>
    </form>
  </body>
</HTML>
