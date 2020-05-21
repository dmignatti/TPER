<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_exitvrvi.aspx.vb" Inherits="ATCBussm1.wf_exitvrvi"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_exitvrvi</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION><br>
        <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label></div>
      <table class="supExitTable" cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr>
          <td class="supExitHeader0" align="center" colSpan="3">Danni rilevati all'atto del 
            ritiro</td>
        </tr>
        <tr>
          <td class="supExitHeader0" align="center" colSpan="5">&nbsp;
          </td>
        </tr>
        <tr>
          <td class="supExitHeader1" align="center" width="33.3%">Strisciature
          </td>
          <td class="supExitHeader1" align="center" width="33.4%">Ammaccature
          </td>
          <td class="supExitHeader1" align="center" width="33.3%">Rotture
          </td>
        </tr>
        <tr>
          <td align="center" colSpan="3"><asp:table id="tblDamage" Runat="server"></asp:table></td>
        </tr>
      </table>
      <br>
      <table cellSpacing="0" cellPadding="0" width="750" align="center">
        <tr vAlign="middle" height="50">
          <td align="center" width="50%"><asp:button id="btnSave" Runat="server" CssClass="Button" Text="Salva"></asp:button></td>
          <td align="center" width="50%"><asp:hyperlink id="hlkBack" Runat="server" CssClass="Link">Annulla</asp:hyperlink></td>
        </tr>
      </table>
    </form>
  </body>
</HTML>
