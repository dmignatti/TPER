<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_tariffarioinfrazioni.aspx.vb" Inherits="ATCBussm1.wf_tariffarioinfrazioni" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_tariffarioinfrazioni</title>
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
        <table>
          <tr>
            <td></td>
          </tr>
          <tr vAlign="top">
            <td class="Header1" align="center">Tariffe di Infrazioni al C.d.S.
            </td>
          </tr>
          <tr>
            <td></td>
          </tr>
          <tr height="25">
            <td colspan="4" align="center">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError"></asp:Label>
            </td>
          </tr>
          <tr>
            <td></td>
          </tr>
          <tr vAlign="top">
            <td class="Header2" align="center">Tariffari definiti
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:Table ID="tbl" Runat="server" CssClass="supGDATCSession_Table" CellPadding="0" CellSpacing="0"></asp:Table>
            </td>
          </tr>
          <tr vAlign="top">
            <td class="Header2">
              <asp:HyperLink ID="hlkAddNew" Runat="server" CssClass="Link">Nuovo Tariffario</asp:HyperLink>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
