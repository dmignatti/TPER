<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_datiquietanza.aspx.vb" Inherits="ATCBussm1.wf_datiquietanza"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_datiquietanza</title>
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
        <br>
        <asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label><br>
        <br>
        <table class="supExitTable" cellSpacing="0" cellPadding="0" width="450" align="center">
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;</td>
          </tr>
          <tr>
            <td class="supExitHeader1" align="left" colSpan="4">&nbsp;Operazione</td>
          </tr>
          <tr>
            <td class="supExitHeader2" align="right" width="15%">Tabella: &nbsp;
            </td>
            <td class="supExitHeader2" align="left" width="25%"><asp:label id="lblTableName" Width="100%" Runat="server"></asp:label></td>
            <td class="supExitHeader2" align="right" width="15%">Record: &nbsp;
            </td>
            <td class="supExitHeader2" align="left" width="45%"><asp:label id="lblRecordID" Width="100%" Runat="server"></asp:label></td>
          <tr>
            <td class="supExitHeader1" align="left" colSpan="4">&nbsp;Utente</td>
          </tr>
          <tr>
            <td class="supExitHeader2" align="right">Matricola: &nbsp;
            </td>
            <td class="supExitHeader2" align="left"><asp:label id="lblUserLogin" Width="100%" Runat="server"></asp:label></td>
            <td class="supExitHeader2" align="right">Nominativo: &nbsp;
            </td>
            <td class="supExitHeader2" align="left"><asp:label id="lblUserName" Width="100%" Runat="server"></asp:label></td>
          </tr>
          <tr>
            <td class="supExitHeader0" align="center" colSpan="4">&nbsp;</td>
          </tr>
        </table>
        <br>
        <br>
        <asp:HyperLink ID="hlkBack" Runat="server" CssClass="Link" NavigateUrl="javascript: window.history.back()">Indietro</asp:HyperLink>
        <br>
        <br>
      </div>
    </form>
  </body>
</HTML>
