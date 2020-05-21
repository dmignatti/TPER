<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_permessi.aspx.vb" Inherits="ATCBussm1.wf_permessi" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_permessi</title>
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
        <TABLE id="Table2" cellSpacing="0" cellPadding="2" width="565" border="0">
          <TR>
            <TD><asp:label id="Label1" runat="server" Height="16px" Width="120px" CssClass="label">Seleziona il modulo:</asp:label><br>
              <asp:dropdownlist id="cboModuli" runat="server" Width="100%" CssClass="TextFieldInput" AutoPostBack="True"></asp:dropdownlist></TD>
          </TR>
          <TR>
            <TD><asp:label id="Label3" runat="server" CssClass="label">Selezionare  i gruppi da rimuovere:</asp:label></TD>
          </TR>
          <TR>
            <TD><asp:listbox id="lstGruppiModulo" runat="server" Height="96px" Width="100%" CssClass="TextFieldInput"
                AutoPostBack="True" SelectionMode="Multiple"></asp:listbox></TD>
          </TR>
          <TR>
            <TD align="right"><asp:button id="btnDel" runat="server" Width="73px" CssClass="Bottone" Text="Rimuovi"></asp:button></TD>
          </TR>
          <TR>
            <TD><asp:label id="Label2" runat="server" CssClass="label">Selezionare i gruppi da aggiungere:</asp:label></TD>
          </TR>
          <TR>
            <TD><asp:listbox id="lstGruppi" runat="server" Height="88px" Width="100%" CssClass="TextFieldInput"
                AutoPostBack="True" SelectionMode="Multiple"></asp:listbox></TD>
          </TR>
          <TR>
            <TD align="right"><asp:button id="btnAdd" runat="server" Width="74px" CssClass="Bottone" Text="Aggiungi"></asp:button></TD>
          </TR>
        </TABLE>
      </div>
    </form>
  </body>
</HTML>
