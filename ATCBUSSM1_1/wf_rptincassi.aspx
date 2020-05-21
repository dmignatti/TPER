<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_rptincassi.aspx.vb" Inherits="ATCBussm1.wf_rptincassi"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_rptincassi</title>
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
            <td Class="Header1" align="center">
              Incassi di Depositeria
            </td>
          </tr>
          <tr>
            <td>&nbsp;
            </td>
          </tr>
          <tr>
            <td>
              <asp:Label ID="lblUserFilter" Runat="server" CssClass="Header3" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td>
              <asp:Label ID="lblDateFilter" Runat="server" CssClass="Header3" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td>
              <asp:Label ID="lblError" Runat="server" CssClass="lblError" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td>
              <asp:HyperLink ID="hlkBack" Runat="server" CssClass="link" Width="100%">Indietro</asp:HyperLink>
            </td>
          </tr>
          <tr>
            <td align="center">
              <input type="button" class="Link" value="Stampa" onclick="javascript: window.print()">
            </td>
          </tr>
          <tr>
            <td>
              <asp:table id="tblMain" Width="440px" CssClass="supReportTable" Runat="server" CellPadding="0"
                CellSpacing="0"></asp:table>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
