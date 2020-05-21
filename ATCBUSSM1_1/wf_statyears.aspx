<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_statyears.aspx.vb" Inherits="ATCBussm1.wf_statyears" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_statyears</title>
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
          <tr valign="top">
            <td class="Header1" align="center">Ingressi per anno
            </td>
          </tr>
          <tr height="auto">
            <td align="center">
              <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label>
            </td>
          </tr>
          <tr height="100%">
            <td vAlign="top" align="center"><asp:table id="tblDetail" Runat="server" CssClass=""></asp:table></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
