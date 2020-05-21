<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_statuscite.aspx.vb" Inherits="ATCBussm1.wf_statuscite"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>Ricerca veicoli</title>
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
        <table class="supDTPicker_Table" width="450">
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
          <tr>
            <td class="Header1" colSpan="7">Selezionare tipo di uscita ed intervallo di tempo
            </td>
          </tr>
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
          <tr>
            <td class="Header2" colSpan="7">Le date devono rispettare il formato gg/mm/aaaa
            </td>
          </tr>
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" width="10%">Stato:
            </td>
            <td width="80%" colSpan="5"><asp:dropdownlist id="ddlState" Width="100%" CssClass="supDTPicker_Label" Runat="server"></asp:dropdownlist></td>
            <td width="10%"></td>
          </tr>
          <tr>
            <td></td>
            <td class="Header2" colSpan="4">Intervallo di entrata
            </td>
            <td colspan="2"></td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" width="10%">dal:
            </td>
            <td width="20%"><asp:textbox id="txtDateInBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td align="left" width="15%"><asp:regularexpressionvalidator id="revDateInBegin" runat="server" Width="100%" ControlToValidate="txtDateInBegin"
                ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
            <td class="supDTPicker_Label" width="10%">al:
            </td>
            <td width="20%"><asp:textbox id="txtDateInEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td align="left" width="15%"><asp:regularexpressionvalidator id="revDateInEnd" runat="server" Width="100%" ControlToValidate="txtDateInEnd" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
            <td width="10%"></td>
          </tr>
          <tr>
            <td></td>
            <td class="Header2" colSpan="4">Intervallo di uscita
            </td>
            <td colspan="2"></td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" width="10%">dal:
            </td>
            <td width="20%"><asp:textbox id="txtDateOutBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td align="left" width="15%"><asp:regularexpressionvalidator id="revDateOutBegin" runat="server" Width="100%" ControlToValidate="txtDateOutBegin"
                ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
            <td class="supDTPicker_Label" width="10%">al:
            </td>
            <td width="20%"><asp:textbox id="txtDateOutEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td align="left" width="15%"><asp:regularexpressionvalidator id="revDateOutEnd" runat="server" Width="100%" ControlToValidate="txtDateOutEnd"
                ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
            <td width="10%"></td>
          </tr>
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
          <tr>
            <td colSpan="7" align="center"><asp:button id="btnRefresh" CssClass="button" Runat="server" Text="Applica"></asp:button></td>
          </tr>
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
          <tr>
            <td colSpan="7">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td colSpan="7"><br>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
