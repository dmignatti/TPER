<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_incassi.aspx.vb" Inherits="ATCBussm1.wf_incassi"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_incassi</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div align="center">
        <ChkPerm:wc_checkpermission id="Wc_checkpermission1" runat="server"></ChkPerm:wc_checkpermission><br>
        <table class="supDTPicker_Table" width="400">
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="Header1" colSpan="8">Selezionare utente ed intervalli di tempo
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="Header2" colSpan="8">Le date devono rispettare il formato gg/mm/aaaa
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" align="right">Utente: &nbsp;
            </td>
            <td colSpan="5" align="left"><asp:dropdownlist id="ddlUser" Width="100%" CssClass="supDTPicker_Label" Runat="server"></asp:dropdownlist></td>
            <td colspan="2"></td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" align="right" width="16.5%">dal: &nbsp;
            </td>
            <td align="left" width="23.5%">
              <asp:textbox id="txtDateBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox>
            </td>
            <td align="center" width="5%">
              <asp:requiredfieldvalidator id="rfvDateBegin" runat="server" ControlToValidate="txtDateBegin" ErrorMessage="*"></asp:requiredfieldvalidator>
            </td>
            <td align="center" width="5%">
              <asp:regularexpressionvalidator id="revDateBegin" runat="server" Width="100%" ControlToValidate="txtDateBegin" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="E"></asp:regularexpressionvalidator>
            </td>
            <td class="supDTPicker_Label" align="right" width="16.5%">al: &nbsp;
            </td>
            <td align="left" width="23.5%">
              <asp:textbox id="txtDateEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox>
            </td>
            <td align="center" width="5%">
              <asp:requiredfieldvalidator id="rfvDateEnd" runat="server" ControlToValidate="txtDateEnd" ErrorMessage="*"></asp:requiredfieldvalidator>
            </td>
            <td align="center" width="5%">
              <asp:regularexpressionvalidator id="revDateEnd" runat="server" Width="100%" ControlToValidate="txtDateEnd" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="E"></asp:regularexpressionvalidator>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td colSpan="8">
              <asp:button id="btnRefresh" CssClass="Button" Runat="server" Text="Applica" Width="90"></asp:button>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td colSpan="8" align="center">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
