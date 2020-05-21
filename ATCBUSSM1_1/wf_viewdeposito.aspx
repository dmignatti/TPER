<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_viewdeposito.aspx.vb" Inherits="ATCBussm1.wf_viewdeposito" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_viewdeposito</title>
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
          <tr height="25">
            <td align="center" colSpan="4"><asp:label id="lblError" Runat="server" CssClass="lblError"></asp:label></td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:Label ID="lblTitle" Runat="server" CssClass="Header0" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <table class="Filter_Table" width="400">
                <tr vAlign="top">
                  <td class="Filter_Label" align="right" width="50" style="HEIGHT: 22px">Mostra:</td>
                  <td width="150" style="HEIGHT: 22px"><asp:dropdownlist id="ddlState" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
                  <td width="50" style="HEIGHT: 22px"></td>
                  <td width="150" style="HEIGHT: 22px"></td>
                </tr>
                <tr vAlign="top">
                  <td class="Filter_Label" align="right" width="50">Targa:</td>
                  <td width="150"><asp:textbox id="txtPlate" Runat="server" CssClass="Filter_TextBox" Width="100%"></asp:textbox></td>
                  <td class="Filter_Label" align="right" width="50">Tipo:</td>
                  <td width="150"><asp:dropdownlist id="ddlType" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
                </tr>
                <tr vAlign="top">
                </tr>
                <tr vAlign="top">
                  <td class="Filter_Label" align="right" width="50">Marca:</td>
                  <td width="150"><asp:dropdownlist id="ddlMark" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
                  <td class="Filter_Label" align="right" width="50">Modello:</td>
                  <td width="150"><asp:dropdownlist id="ddlModel" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
                </tr>
                <tr vAlign="top">
                  <td align="center" colSpan="4">
                    <HR color="dimgray" SIZE="1">
                    <asp:button id="btnRefresh" Runat="server" CssClass="Filter_Button" Width="90" Text="Applica"></asp:button><br>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:Label ID="lblCount" Runat="server" CssClass="Filter_Label" Width="400"></asp:Label>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center"><asp:table id="tbl" Runat="server" CssClass="Deposito_Table" CellSpacing="0" CellPadding="0"></asp:table></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
