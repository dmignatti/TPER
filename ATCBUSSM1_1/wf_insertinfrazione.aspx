<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_insertinfrazione.aspx.vb" Inherits="ATCBussm1.wf_insertinfrazione" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_insertinfrazione</title>
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
        <table class="supNewInfr_Table" cellSpacing="5" cellPadding="1" align="center">
          <tr vAlign="top" height="20">
            <td class="Header0" colSpan="5" align="center">Nuova Infrazione C.d.S.
            </td>
          </tr>
          <tr vAlign="top" height="20">
            <td class="Header2" colSpan="5" align="center"><asp:Label ID="lblMessage" Runat="server"></asp:Label>
            </td>
          </tr>
          <tr vAlign="top">
            <td class="Header2" width="80"><br>
            </td>
            <td class="Header2" width="80"><br>
            </td>
            <td class="Header2" width="80"><br>
            </td>
            <td class="Header2" width="80"><br>
            </td>
            <td class="Header2" width="50"><br>
            </td>
          </tr>
          <tr vAlign="top" height="20">
            <td class="supNewInfr_Label">Codice
            </td>
            <td><asp:textbox id="txtCodice" CssClass="supNewInfr_TextBox" Runat="server"></asp:textbox></td>
            <td class="supNewInfr_Label">Articolo
            </td>
            <td><asp:textbox id="txtArticolo" CssClass="supNewInfr_TextBox" Runat="server"></asp:textbox></td>
            <td class="supNewInfr_Label"></td>
          </tr>
          <tr vAlign="top" height="60">
            <td class="supNewInfr_Label">Descrizione
            </td>
            <td colSpan="3"><asp:textbox id="txtDesc" CssClass="supNewInfr_TextBox" Runat="server" TextMode="MultiLine"></asp:textbox></td>
            <td class="supNewInfr_Label"></td>
          </tr>
          <tr vAlign="top" height="20">
            <td class="supNewInfr_Label">Importo (€)
            </td>
            <td><asp:textbox id="txtImporto" CssClass="supNewInfr_TextBox" Runat="server"></asp:textbox></td>
            <td class="supNewInfr_Label" colSpan="3"></td>
          </tr>
          <tr vAlign="top" height="20">
            <td class="supNewInfr_Label">Data inizio
            </td>
            <td><asp:label id="lblDateBegin" CssClass="supNewInfr_Date" Runat="server"></asp:label></td>
            <td class="supNewInfr_Label">Data fine
            </td>
            <td><asp:label id="lblDateEnd" CssClass="supNewInfr_Date" Runat="server"></asp:label></td>
            <td class="supNewInfr_Label"></td>
          </tr>
          <tr vAlign="top" height="20">
            <td class="supNewInfr_Label" colSpan="5"><br>
            </td>
          </tr>
          <tr vAlign="top" height="20">
            <td align="center" colSpan="2"><asp:button id="btnSave" CssClass="Button" Runat="server" Text="Salva"></asp:button></td>
            <td><br>
            </td>
            <td align="center" colSpan="2"><asp:hyperlink id="hlkBack" CssClass="Button" Runat="server">Annulla</asp:hyperlink></td>
          </tr>
        </table>
        <br>
        <table align="center">
          <tr vAlign="top">
            <td><asp:label id="lblError" CssClass="lblError" Runat="server"></asp:label></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
