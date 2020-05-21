<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_marchemodelli.aspx.vb" Inherits="ATCBussm1.wf_marchemodelli" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_marchemodelli</title>
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
        <table class="supDTPicker_Table" width="400">
          <tr>
            <td colSpan="6"></td>
          </tr>
          <tr>
            <td class="Header1" colSpan="6">Selezionare l'intervallo di tempo
            </td>
          </tr>
          <tr>
            <td colSpan="6"></td>
          </tr>
          <tr>
            <td class="Header2" colSpan="6">Le date devono rispettare il formato gg/mm/aaaa
            </td>
          </tr>
          <tr>
            <td colSpan="6"></td>
          </tr>
          <tr>
            <td width="15%"></td>
            <td class="supDTPicker_Label" width="15%">dal:
            </td>
            <td width="20%"><asp:textbox id="txtDateBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td width="5%"><asp:requiredfieldvalidator id="rfvDateBegin" runat="server" ControlToValidate="txtDateBegin" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td align="left" width="45%" colSpan="2"><asp:regularexpressionvalidator id="revDateBegin" runat="server" Width="100%" ControlToValidate="txtDateBegin" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
          </tr>
          <tr>
            <td></td>
            <td class="supDTPicker_Label">al:
            </td>
            <td><asp:textbox id="txtDateEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
            <td><asp:requiredfieldvalidator id="rfvDateEnd" runat="server" ControlToValidate="txtDateEnd" ErrorMessage="*"></asp:requiredfieldvalidator></td>
            <td align="left" colSpan="2"><asp:regularexpressionvalidator id="revDateEnd" runat="server" Width="100%" ControlToValidate="txtDateEnd" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
          </tr>
          <tr>
            <td>
            </td>
            <td class="supDTPicker_Label" align="right">vedi:
            </td>
            <td align="center" colSpan="3">
              <asp:dropdownlist id="ddlShow" AutoPostBack="True" Runat="server" CssClass="DTPicker_TextBox"></asp:dropdownlist>
            </td>
            <td>
            </td>
          </tr>
          <tr>
            <td colSpan="6"></td>
          </tr>
          <tr>
            <td></td>
            <td></td>
            <td colSpan="2"><asp:button id="btnRefresh" CssClass="supDTPicker_UDButton" Runat="server" Text="Applica"></asp:button></td>
            <td></td>
            <td></td>
          </tr>
          <tr>
            <td colSpan="6"></td>
          </tr>
          <tr>
            <td colSpan="6">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td colSpan="6"></td>
          </tr>
        </table>
        <br>
        <asp:datagrid id="grd" Width="600px" Runat="server" CssClass="" AllowPaging="True" OnPageIndexChanged="saltapagina">
          <HeaderStyle CssClass="GRD_Header"></HeaderStyle>
          <ItemStyle CssClass="GRD_BodyOdd"></ItemStyle>
          <AlternatingItemStyle CssClass="GRD_BodyEven"></AlternatingItemStyle>
          <PagerStyle NextPageText="Successiva" Font-Bold="True" PrevPageText="Precedente&#160;" HorizontalAlign="Center"
            ForeColor="#29448B" CssClass="descrizione"></PagerStyle>
        </asp:datagrid>
      </div>
    </form>
  </body>
</HTML>
