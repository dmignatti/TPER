<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_deleteinfrazioni.aspx.vb" Inherits="ATCBussm1.wf_deleteinfrazioni" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_deleteinfrazioni</title>
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
        <table align="center">
          <tr valign="top">
            <td align="center">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError"></asp:Label>
            </td>
          </tr>
          <tr valign="top">
            <td align="center"><asp:HyperLink ID="hlkBack" Runat="server" CssClass="Link" NavigateUrl="javascript: window.history.back()">Indietro</asp:HyperLink></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
