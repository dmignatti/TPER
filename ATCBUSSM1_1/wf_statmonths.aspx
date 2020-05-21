<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_statmonths.aspx.vb" Inherits="ATCBussm1.wf_statmonths" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_statmonths</title>
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
            <td class="Header1" align="center">Ingressi per mese
            </td>
          </tr>
          <tr valign="top">
            <td align="center">
              <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label>
            </td>
          </tr>
          <tr valign="top">
            <td align="center">
              <asp:table id="tblDetail" Runat="server" CssClass="supStat_DetailTable" CellPadding="0" CellSpacing="0"></asp:table>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
