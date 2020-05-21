<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_viewcustodia.aspx.vb" Inherits="ATCBussm1.wf_viewcustodia" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_viewcustodia</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div align="center">
        <ChkPerm:wc_checkpermission id="Wc_checkpermission1" runat="server"></ChkPerm:wc_checkpermission><br>
        <table width="100%" align="center">
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
          <tr vAlign="top">
            <td align="center" width="50%">
              <asp:HyperLink ID="hlkBack" Runat="server" CssClass="Link" NavigateUrl="javascript: window.history.back()">Indietro</asp:HyperLink>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <table align="center" class="supDTPicker_Table" width="200">
                <tr>
                  <td colspan="4" align="center" class="Header2">Tariffe valide</td>
                </tr>
                <tr>
                  <td align="left" class="supDTPicker_Label" width="20">
                    dal
                  </td>
                  <td align="left" class="Header2" width="80"><asp:label id="lblDateBegin" Runat="server" CssClass=""></asp:label></td>
                  <td align="left" class="supDTPicker_Label" width="20">al
                  </td>
                  <td align="left" class="Header2" width="80"><asp:label id="lblDateEnd" Runat="server" CssClass=""></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center"><asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label></td>
          </tr>
          <tr vAlign="top">
            <td align="center" colSpan="4"><asp:table id="tbl" Runat="server" CssClass="supGDATCSession_Table" CellPadding="0" CellSpacing="0"></asp:table></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
