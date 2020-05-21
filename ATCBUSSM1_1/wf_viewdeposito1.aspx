<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_viewdeposito1.aspx.vb" Inherits="ATCBussm1.wf_viewdeposito1"%>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_viewdeposito1</title>
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
                  <td colspan="5">
                    <br>
                  </td>
                </tr>
                <tr vAlign="top">
                  <td class="Filter_Label" align="right" width="15%">Targa:</td>
                  <td width="35%"><asp:textbox id="txtPlate" Runat="server" CssClass="Filter_TextBox" Width="100%"></asp:textbox></td>
                  <td class="Filter_Label" align="right" width="10%">Tipo:</td>
                  <td width="35%"><asp:dropdownlist id="ddlType" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist></td>
                  <td width="5%"></td>
                </tr>
                <tr vAlign="top">
                  <td class="Filter_Label" align="right">Marca:</td>
                  <td>
                    <asp:dropdownlist id="ddlMark" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist>
                  </td>
                  <td class="Filter_Label" align="right">Modello:</td>
                  <td>
                    <asp:dropdownlist id="ddlModel" Runat="server" CssClass="Filter_DropDownList" Width="100%" AutoPostBack="True"></asp:dropdownlist>
                  </td>
                  <td></td>
                </tr>
                <tr vAlign="top">
                  <td align="center" colSpan="5">
                    <HR color="dimgray" SIZE="1">
                  </td>
                </tr>
                <tr vAlign="top">
                  <td align="center" colSpan="5">
                    <asp:button id="btnRefresh" Runat="server" CssClass="Filter_Button" Width="90" Text="Applica"></asp:button><br>
                  </td>
                </tr>
                <tr vAlign="top">
                  <td align="center" colSpan="5">
                    <BR>
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
            <td align="center">
              <asp:table id="tbl" Runat="server" CssClass="Deposito_Table" CellSpacing="0" CellPadding="0"></asp:table>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
