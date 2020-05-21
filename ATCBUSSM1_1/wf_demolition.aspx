<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_demolition.aspx.vb" Inherits="ATCBussm1.wf_demolition" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_demolition</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff">
    <form id="Form1" method="post" runat="server">
      <div class="Header0" align="center"><CHKPERM:WC_CHECKPERMISSION id="Wc_checkpermission1" runat="server"></CHKPERM:WC_CHECKPERMISSION><br>
        <table class="Filter_Table" align="center">
          <tr vAlign="top">
            <td align="center" colSpan="2"><asp:label id="lblTitle" Width="100%" CssClass="HEADER2" Runat="server"></asp:label></td>
          </tr>
          <tr vAlign="top">
            <td align="right">Targa:</td>
            <td align="left"><asp:label id="lblPlate" Width="150" CssClass="" Runat="server"></asp:label></td>
          </tr>
          <tr vAlign="top">
            <td align="right">Note:</td>
            <td align="right"><asp:textbox id="txtNotes" Width="300" CssClass="" Runat="server" TextMode="MultiLine" Height="100"
                MaxLength="255"></asp:textbox></td>
          </tr>
          <tr vAlign="top">
            <td align="center" colSpan="2">
              <table height="100%" width="100%" align="center">
                <tr vAlign="middle" height="100%">
                  <td align="center" width="50%"><asp:button id="btnExecute" CssClass="Button" Runat="server"></asp:button></td>
                  <td align="center" width="50%"><asp:hyperlink id="hlkBack" CssClass="Button" Runat="server">Annulla</asp:hyperlink></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center" colSpan="2"><asp:label id="lblError" CssClass="lblError" Runat="server"></asp:label></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
