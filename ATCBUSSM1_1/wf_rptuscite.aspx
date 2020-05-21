<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_rptuscite.aspx.vb" Inherits="ATCBussm1.wf_rptuscite"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_rptuscite</title>
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
        <table>
          <tr>
            <td align="center" colSpan="2"><asp:label id="lblTitle" Width="100%" CssClass="Header1" Runat="server"></asp:label><br>
            </td>
          </tr>
          <tr>
            <td class="Header3" width="20%">Ingresso:</td>
            <td width="80%"><asp:label id="lblDateInFilter" Width="100%" CssClass="Header3" Runat="server"></asp:label></td>
          </tr>
          <tr>
            <td class="Header3">Uscita:</td>
            <td><asp:label id="lblDateOutFilter" Width="100%" CssClass="Header3" Runat="server"></asp:label></td>
          </tr>
          <tr>
            <td class="Header3">Totale veicoli:</td>
            <td><asp:label id="lblTotCount" Width="100%" CssClass="Header3" Runat="server"></asp:label></td>
          </tr>
          <tr>
            <td colSpan="2"><asp:label id="lblError" Width="100%" CssClass="lblError" Runat="server"></asp:label></td>
          </tr>
          <tr>
            <td colSpan="2"><asp:hyperlink id="hlkBack" Width="100%" CssClass="link" Runat="server" NavigateUrl="javascript: window.history.back();">Indietro</asp:hyperlink></td>
          </tr>
          <tr>
            <td colspan="2" align="center"><asp:table id="tbl" Width="650px" CssClass="supReportTable" Runat="server" CellSpacing="0"
                CellPadding="0"></asp:table></td>
          </tr>
        </table>
      </div>
      <DIV></DIV>
    </form>
  </body>
</HTML>
