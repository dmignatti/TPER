<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_dativeicoloexit.aspx.vb" Inherits="ATCBussm1.wf_dativeicoloexit"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_dativeicoloexit</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div class="Header0" align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION><br>
        Controllare i dati prima di procedere<br>
        <br>
        <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label><br>
        <br>
        <table class="supExitTable" id="tblDatiVeicolo" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">Dati veicolo in ingresso
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">&nbsp;
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left" width="75">&nbsp; data
            </td>
            <td class="supExitHeader1" align="left" width="170"><asp:label id="lblDataIngresso" Runat="server" CssClass=""></asp:label></td>
            <td class="supExitHeader1" align="center" width="25"></td>
            <td class="supExitHeader1" align="center" width="25"></td>
            <td class="supExitHeader1" align="left" width="75">&nbsp; targa
            </td>
            <td class="supExitHeader1" align="left" width="150"><asp:label id="lblTarga" Runat="server" CssClass="" Width="100%"></asp:label></td>
            <td class="supExitHeader1" align="center" width="25"></td>
            <td class="supExitHeader1" align="center" width="25"></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left">&nbsp; tipo
            </td>
            <td class="supExitHeader1" align="left"><asp:label id="lblTipo" Runat="server" CssClass="" Width="100%"></asp:label></td>
            <td class="supExitHeader1" align="center"></td>
            <td class="supExitHeader1" align="center"></td>
            <td class="supExitHeader1" align="left">&nbsp; marca
            </td>
            <td class="supExitHeader1" align="left"><asp:label id="lblMarca" Runat="server" CssClass="" Width="100%"></asp:label></td>
            <td class="supExitHeader1" align="center"></td>
            <td class="supExitHeader1" align="center"></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left">&nbsp; modello
            </td>
            <td class="supExitHeader1" align="left"><asp:label id="lblModello" Runat="server" CssClass="" Width="100%"></asp:label></td>
            <td class="supExitHeader1" align="center"></td>
            <td class="supExitHeader1" align="center"></td>
            <td class="supExitHeader1" align="left">&nbsp; peso (q.li)
            </td>
            <td class="supExitHeader1" align="left"><asp:textbox id="txtPesoPC" Runat="server" CssClass="supExitTextBox" Width="60"></asp:textbox>&nbsp; 
              (qq,kk)</td>
            <td class="supExitHeader1" align="center"><asp:requiredfieldvalidator id="rfvPesoPC" runat="server" ControlToValidate="txtPesoPC" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center"><asp:regularexpressionvalidator id="revPesoPC" runat="server" Width="100%" ControlToValidate="txtPesoPC" ErrorMessage="E"
                ValidationExpression="^(\d\d),(\d\d)$"></asp:regularexpressionvalidator></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table class="supExitTable" id="tblQuietanza" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">Dati della quietanza
            </td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
          <tr>
            <td class="supExitHeader1" align="left" width="75">&nbsp; numero q.</td>
            <td class="supExitHeader2" align="left" width="445"><asp:textbox id="txtPK" Runat="server" CssClass="supExitTextBox" Width="100"></asp:textbox></td>
            <td class="supExitHeader2" align="center" width="25"><asp:requiredfieldvalidator id="rfvPK" runat="server" ControlToValidate="txtPK" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader2" align="center" width="25"></td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table class="supExitTable" id="tblDatiUscita" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">Dati veicolo in uscita
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">&nbsp;
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left" width="75">&nbsp; data
            </td>
            <td class="supExitHeader1" align="left" width="170"><asp:textbox id="txtDataUscita" Runat="server" CssClass="supExitTextBox" Width="70"></asp:textbox>&nbsp; 
              (gg/mm/aaaa)
            </td>
            <td class="supExitHeader1" align="center" width="25"><asp:requiredfieldvalidator id="rfvDataUscita" runat="server" ControlToValidate="txtDataUscita" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center" width="25"><asp:regularexpressionvalidator id="revDataUscita" runat="server" Width="100%" ControlToValidate="txtDataUscita"
                ErrorMessage="E" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"></asp:regularexpressionvalidator></td>
            <td class="supExitHeader1" align="left" width="75">&nbsp; ora
            </td>
            <td class="supExitHeader1" align="left" width="150"><asp:textbox id="txtOraUscita" Runat="server" CssClass="supExitTextBox" Width="50"></asp:textbox>&nbsp; 
              (hh:mm)
            </td>
            <td class="supExitHeader1" align="center" width="25"><asp:requiredfieldvalidator id="rfvOraUscita" runat="server" ControlToValidate="txtOraUscita" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center" width="25"><asp:regularexpressionvalidator id="revOraUscita" runat="server" Width="100%" ControlToValidate="txtOraUscita" ErrorMessage="E"
                ValidationExpression="^([0-1]\d|2[0-3]):([0-5]\d)$"></asp:regularexpressionvalidator></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left">&nbsp; tipo
            </td>
            <td class="supExitHeader1" align="left" colSpan="5"><asp:dropdownlist id="ddlExitType" Runat="server" CssClass="supExitTextBox" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
            <td class="supExitHeader1" align="center"><asp:requiredfieldvalidator id="rfvExitType" runat="server" ControlToValidate="ddlExitType" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center"></td>
          </tr>
          <tr vAlign="top">
            <td class="supExitHeader1" align="left">&nbsp; note</td>
            <td class="supExitHeader2" align="left" colSpan="5"><asp:textbox id="txtNoteUscita" Runat="server" CssClass="supExitTextBox" Width="100%" MaxLength="500"
                Height="100" TextMode="MultiLine"></asp:textbox></td>
            <td class="supExitHeader2" align="center"></td>
            <td class="supExitHeader2" align="center"></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table class="supExitTable" id="tblOperatore" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">Dati dell'operatore di 
              depositeria
            </td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
          <tr>
            <td class="supExitHeader1" align="left" width="75">&nbsp; operatore</td>
            <td class="supExitHeader2" align="left" width="445"><asp:dropdownlist id="ddlUser" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:dropdownlist></td>
            <td class="supExitHeader2" align="center" width="25"><asp:requiredfieldvalidator id="rfvUser" runat="server" ControlToValidate="ddlUser" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader2" align="center" width="25"></td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table class="supExitTable" id="tblPagamento" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">Dati relativi al pagamento 
              dei servizi e delle sanzioni
            </td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
          <tr>
            <td class="supExitHeader1" align="left" width="75">&nbsp; pagamento</td>
            <td class="supExitHeader2" align="left" width="445"><asp:dropdownlist id="ddlPagamento" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:dropdownlist></td>
            <td class="supExitHeader2" align="center" width="25"><asp:requiredfieldvalidator id="rfvPagamento" runat="server" ControlToValidate="ddlPagamento" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader2" align="center" width="25"></td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table class="supExitTable" id="tblDenuncia" cellSpacing="0" cellPadding="0" width="570"
          align="center" runat="server">
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">Dati della denuncia di 
              furto
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">&nbsp;
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left" width="75">&nbsp; numero
            </td>
            <td class="supExitHeader1" align="left" width="170"><asp:textbox id="txtNumeroDenuncia" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:textbox></td>
            <td class="supExitHeader1" align="center" width="25"><asp:requiredfieldvalidator id="rfvNumeroDenuncia" runat="server" ControlToValidate="txtNumeroDenuncia" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center" width="25">&nbsp;
            </td>
            <td class="supExitHeader1" align="left" width="75">&nbsp; sporta a
            </td>
            <td class="supExitHeader1" align="left" width="150"><asp:dropdownlist id="ddlCorpoDenuncia" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:dropdownlist></td>
            <td class="supExitHeader1" align="center" width="25"><asp:requiredfieldvalidator id="rfvCorpoDenuncia" runat="server" ControlToValidate="ddlCorpoDenuncia" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center" width="25">&nbsp;
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left">&nbsp; in data
            </td>
            <td class="supExitHeader1" align="left"><asp:textbox id="txtDataDenuncia" Runat="server" CssClass="supExitTextBox" Width="70"></asp:textbox>&nbsp; 
              (gg/mm/aaaa)
            </td>
            <td class="supExitHeader1" align="center"><asp:requiredfieldvalidator id="rfvDataDenuncia" runat="server" ControlToValidate="txtDataDenuncia" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center"><asp:regularexpressionvalidator id="revDataDenuncia" runat="server" Width="100%" ControlToValidate="txtDataDenuncia"
                ErrorMessage="E" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"></asp:regularexpressionvalidator></td>
            <td class="supExitHeader1" align="left">&nbsp; alle ore
            </td>
            <td class="supExitHeader1" align="left"><asp:textbox id="txtOraDenuncia" Runat="server" CssClass="supExitTextBox" Width="50"></asp:textbox>&nbsp; 
              (hh:mm)
            </td>
            <td class="supExitHeader1" align="center"><asp:requiredfieldvalidator id="rfvOraDenuncia" runat="server" ControlToValidate="txtOraDenuncia" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center"><asp:regularexpressionvalidator id="revOraDenuncia" runat="server" Width="100%" ControlToValidate="txtOraDenuncia"
                ErrorMessage="E" ValidationExpression="^([0-1]\d|2[0-3]):([0-5]\d)$"></asp:regularexpressionvalidator></td>
          </tr>
          <tr height="20">
            <td class="supExitHeader1" align="left">&nbsp; alla staz.
            </td>
            <td class="supExitHeader1" align="left" colSpan="5"><asp:textbox id="txtStazioneDenuncia" Runat="server" CssClass="supExitTextBox" Width="100%"></asp:textbox></td>
            <td class="supExitHeader1" align="center"><asp:requiredfieldvalidator id="rfvStazioneDenuncia" runat="server" ControlToValidate="txtStazioneDenuncia"
                ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td class="supExitHeader1" align="center">&nbsp;
            </td>
          </tr>
          <tr height="20">
            <td class="supExitHeader0" align="center" colSpan="8">&nbsp;
            </td>
          </tr>
        </table>
        <br>
        <table cellSpacing="0" cellPadding="0" width="570" align="center">
          <tr vAlign="middle" height="50">
            <td align="center" width="50%"><asp:hyperlink id="hlkBack" Runat="server" CssClass="Link">Indietro</asp:hyperlink></td>
            <td align="center" width="50%"><asp:button id="btnGo" Runat="server" CssClass="Link" Text="Avanti"></asp:button></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
