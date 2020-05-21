<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_gruppi.aspx.vb" Inherits="ATCBussm1.wf_gruppi" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_gruppi</title>
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
            <TD><asp:label id="Label1" runat="server" CssClass="label">Amministrazione dei gruppi di utenza:</asp:label></TD>
          </TR>
          <TR>
            <TD><asp:listbox id="lstGruppi" runat="server" Width="100%" CssClass="textfieldinput"></asp:listbox></TD>
          </TR>
          <TR>
            <TD align="right"><asp:button id="btnAdd" runat="server" Width="152px" CssClass="bottone" Text="Aggiungi un nuovo gruppo"></asp:button>&nbsp;<asp:button id="btnModify" runat="server" Width="168px" CssClass="bottone" Text="Modifica il gruppo selezionato"></asp:button>&nbsp;<asp:button id="btnRemove" runat="server" Width="160px" CssClass="bottone" Text="Elimina il gruppo selezionato"></asp:button></TD>
          </TR>
          <TR>
            <TD><asp:panel id="pnlGroup" runat="server" Visible="False">
                <TABLE id="Table3" cellSpacing="0" cellPadding="2" width="100%" border="0">
                  <TR>
                    <TD>
                      <asp:TextBox id="txtId" runat="server" CssClass="textfieldinput" Visible="False">ID</asp:TextBox></TD>
                    <TD></TD>
                  </TR>
                  <TR>
                    <TD>
                      <asp:Label id="Label2" runat="server" CssClass="label">Descrizione</asp:Label></TD>
                    <TD>
                      <asp:TextBox id="txtDescription" runat="server" CssClass="textfieldinput"></asp:TextBox>
                      <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" CssClass="label" ErrorMessage="*" ControlToValidate="txtDescription"></asp:RequiredFieldValidator></TD>
                  </TR>
                </TABLE>
                <TABLE id="Table4" cellSpacing="0" cellPadding="2" width="100%" border="0">
                  <TR>
                    <TD>
                      <asp:Label id="Label3" runat="server" CssClass="label">Utenti appartenenti al gruppo</asp:Label></TD>
                  </TR>
                  <TR>
                    <TD>
                      <asp:ListBox id="lstUtentiGruppo" runat="server" CssClass="textfieldinput" Width="100%" AutoPostBack="True"></asp:ListBox></TD>
                  </TR>
                  <TR>
                    <TD align="right">
                      <asp:Button id="btnRemoveUser" runat="server" CssClass="bottone" Text="Rimuovi l'utente dal gruppo"></asp:Button></TD>
                  </TR>
                  <TR>
                    <TD>
                      <asp:Label id="Label4" runat="server" CssClass="label">Utenti del sistema</asp:Label></TD>
                  </TR>
                  <TR>
                    <TD>
                      <asp:ListBox id="lstUtenti" runat="server" CssClass="textfieldinput" Width="100%" AutoPostBack="True"></asp:ListBox></TD>
                  </TR>
                  <TR>
                    <TD align="right">
                      <asp:Button id="btnAddUser" runat="server" CssClass="bottone" Text="Aggiungi l'utente al gruppo"></asp:Button></TD>
                  </TR>
                  <TR>
                    <TD>
                      <asp:Label id="lblError" runat="server" CssClass="Label"></asp:Label></TD>
                  </TR>
                  <TR>
                    <TD align="center">
                      <asp:Button id="btnSave" runat="server" CssClass="bottone" Text="Salva"></asp:Button>&nbsp;
                      <asp:Button id="Button1" runat="server" CssClass="Bottone" Text="Annulla" CausesValidation="False"></asp:Button></TD>
                  </TR>
                </TABLE>
              </asp:panel></TD>
          </TR>
        </TABLE>
      </div>
    </form>
  </body>
</HTML>
