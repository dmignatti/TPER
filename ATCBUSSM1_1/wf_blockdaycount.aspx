<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_blockdaycount.aspx.vb" Inherits="ATCBussm1.wf_blockdaycount"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_blockdaycount</title>
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
        <table class="Filter_Table" width="400" align="center">
          <tr>
            <td class="Header1" align="center" colSpan="5"><br>
              Dati vettura<br>
              <br>
            </td>
          </tr>
          <tr>
            <td class="Filter_Label" align="right" width="15%">Targa:
            </td>
            <td width="35%"><asp:label id="lblPlate" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td class="Filter_Label" align="right" width="10%">Tipo:
            </td>
            <td width="35%"><asp:label id="lblType" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td width="5%"></td>
          </tr>
          <tr>
            <td class="Filter_Label" align="right">Marca:
            </td>
            <td><asp:label id="lblMark" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td class="Filter_Label" align="right">Modello:
            </td>
            <td><asp:label id="lblModel" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td></td>
          </tr>
          <tr>
            <td class="Filter_Label" align="right">Ingresso:
            </td>
            <td><asp:label id="lblDateIn" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td class="Filter_Label" align="right">N.Verbale:
            </td>
            <td><asp:label id="lblNVerbale" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td></td>
          </tr>
          <tr>
            <td class="Filter_Label" align="right">Stato:
            </td>
            <td><asp:label id="lblState" CssClass="Filter_TextBox" Runat="server"></asp:label></td>
            <td colSpan="3"></td>
          </tr>
          <tr>
            <td class="Header1" align="center" colSpan="5"><br>
              Conteggio giorni di custodia bloccato al<br>
              <br>
            </td>
          </tr>
          <tr>
            <td class="Filter_Label" align="right" width="15%">data:
            </td>
            <td align="left" width="35%"><asp:textbox id="txtDateBlock" CssClass="Filter_TextBox" Runat="server" Width="70"></asp:textbox></td>
            <td class="Filter_Label" align="right" width="10%">ora:
            </td>
            <td align="left" width="35%"><asp:textbox id="txtTimeBlock" CssClass="Filter_TextBox" Runat="server" Width="50"></asp:textbox></td>
            <td width="5%"></td>
          </tr>
          <tr>
            <td colSpan="5"><br>
            </td>
          </tr>
          <tr>
            <td align="center" colSpan="2"><asp:button id="btnSave" Text="Salva" CssClass="Button" Runat="server"></asp:button></td>
            <td align="center" colSpan="3"><asp:hyperlink id="hlkBack" CssClass="link" Runat="server" NavigateUrl="">Annulla</asp:hyperlink></td>
          </tr>
          <tr>
            <td colspan="5" align="center">
              <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label>
            </td>
          </tr>
          <tr>
            <td colspan="5" align="center">
              <asp:regularexpressionvalidator id="revDateBlock" runat="server" Width="100%" ControlToValidate="txtDateBlock" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="La data non è valida. Formato GG/MM/AAAA"></asp:regularexpressionvalidator>
            </td>
          </tr>
          <tr>
            <td colspan="5" align="center">
              <asp:regularexpressionvalidator id="revTimeBlock" runat="server" Width="100%" ControlToValidate="txtTimeBlock" ValidationExpression="^([0-1]\d|2[0-3]):([0-5]\d)$"
                ErrorMessage="L'ora non è valida. Formato HH:MM"></asp:regularexpressionvalidator>
            </td>
          </tr>
          <tr>
            <td colspan="5" align="center">
              <asp:requiredfieldvalidator id="rfvDateBlock" runat="server" ErrorMessage="La data è obbligatoria. Formato GG/MM/AAAA" ControlToValidate="txtDateBlock"></asp:requiredfieldvalidator>
            </td>
          </tr>
          <tr>
            <td colspan="5" align="center">
              <asp:requiredfieldvalidator id="rfvTimeBlock" runat="server" ErrorMessage="L'ora è obbligatoria. Formato HH:MM" ControlToValidate="txtTimeBlock"></asp:requiredfieldvalidator>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
