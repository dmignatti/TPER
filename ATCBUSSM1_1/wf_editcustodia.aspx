<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_editcustodia.aspx.vb" Inherits="ATCBussm1.wf_editcustodia" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_editcustodia</title>
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
        <table align="center">
          <tr>
            <td></td>
          </tr>
          <tr valign="top">
            <td class="Header1" align="center">Tariffe di Custodia
            </td>
          </tr>
          <tr>
            <td></td>
          </tr>
          <tr>
            <td align="center">
              <asp:hyperlink id="hlkBack" CssClass="Link" Runat="server">Annulla</asp:hyperlink>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <table align="center" class="supDTPicker_Table" width="250">
                <tr valign="top">
                  <td colspan="4" class="Header2">Tariffe valide
                  </td>
                </tr>
                <tr valign="top">
                  <td colspan="4" class="Header2">
                  </td>
                </tr>
                <tr valign="top">
                  <td class="supDTPicker_Label" width="20%">dal</td>
                  <td width="30%"><asp:textbox id="txtDateBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
                  <td width="5%"><asp:requiredfieldvalidator id="rfvDateBegin" runat="server" ControlToValidate="txtDateBegin" ErrorMessage="*"></asp:requiredfieldvalidator></td>
                  <td align="left" width="45%"><asp:regularexpressionvalidator id="revDateBegin" runat="server" Width="100%" ControlToValidate="txtDateBegin" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                      ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
                </tr>
                <tr valign="top">
                  <td class="supDTPicker_Label">al</td>
                  <td><asp:label id="lblDateEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:label></td>
                  <td colspan="2"></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:label id="lblError" CssClass="lblError" Runat="server"></asp:label>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:table id="tbl" CssClass="supGDATCSession_Table" Runat="server" CellSpacing="0" CellPadding="0"></asp:table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:button id="btnSave" CssClass="Button" Runat="server" Text="Salva"></asp:button>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
