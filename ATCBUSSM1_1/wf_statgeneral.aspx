<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_statgeneral.aspx.vb" Inherits="ATCBussm1.wf_statgeneral" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title></title>
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
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="Header1" colSpan="8">Selezionare l'intervallo di tempo
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="Header2" colSpan="8">Le date devono rispettare il formato gg/mm/aaaa
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td class="supDTPicker_Label" align="right" width="12.5%">dal: &nbsp;
            </td>
            <td align="left" width="23.5%">
              <asp:textbox id="txtDateBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox>
            </td>
            <td align="center" width="7%">
              <asp:requiredfieldvalidator id="rfvDateBegin" runat="server" ControlToValidate="txtDateBegin" ErrorMessage="*"></asp:requiredfieldvalidator>
            </td>
            <td align="center" width="7%">
              <asp:regularexpressionvalidator id="revDateBegin" runat="server" Width="100%" ControlToValidate="txtDateBegin" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="E"></asp:regularexpressionvalidator>
            </td>
            <td class="supDTPicker_Label" align="right" width="12.5%">al: &nbsp;
            </td>
            <td align="left" width="23.5%">
              <asp:textbox id="txtDateEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox>
            </td>
            <td align="center" width="7%">
              <asp:requiredfieldvalidator id="rfvDateEnd" runat="server" ControlToValidate="txtDateEnd" ErrorMessage="*"></asp:requiredfieldvalidator>
            </td>
            <td align="center" width="7%">
              <asp:regularexpressionvalidator id="revDateEnd" runat="server" Width="100%" ControlToValidate="txtDateEnd" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                ErrorMessage="E"></asp:regularexpressionvalidator>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td colSpan="8" align="center">
              <asp:button id="btnRefresh" CssClass="Button" Runat="server" Text="Applica" Width="90"></asp:button>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
          <tr>
            <td colSpan="8" align="center">
              <asp:Label ID="lblError" Runat="server" CssClass="lblError" Width="100%"></asp:Label>
            </td>
          </tr>
          <tr>
            <td colSpan="8">&nbsp;</td>
          </tr>
        </table>
        <br>
        <table align="center" class="supStat_Table">
          <tr class="supStat_TableRow">
            <td class="supStat_TableTitle"></td>
            <td class="supStat_TableTitle">Totale da inizio attività</td>
            <td colspan="2" class="supStat_TableTitle"><asp:Label ID="lblTInterval" Runat="server"></asp:Label></td>
          </tr>
          <tr class="supStat_TableRow">
            <td class="supStat_TableFirstCell"><asp:Label ID="lblTCount" Runat="server"></asp:Label></td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0THO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0WHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT0HHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F1">
            <td class="supStat_TableFirstCell">f.o. 7-20</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1THO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1WHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT1HHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F2">
            <td class="supStat_TableFirstCell">f.o. 20-24</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2THO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2WHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT2HHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F3">
            <td class="supStat_TableFirstCell">f.o. 0-7</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3THO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3WHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblT3HHO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
        <br>
        <table align="center" class="supStat_Table">
          <tr class="supStat_TableRow">
            <td class="supStat_TableTitle"></td>
            <td class="supStat_TableTitle">Totale periodo selezionato</td>
            <td colspan="2" class="supStat_TableTitle"><asp:Label ID="lblSInterval" Runat="server"></asp:Label></td>
          </tr>
          <tr class="supStat_TableRow">
            <td class="supStat_TableFirstCell"><asp:Label ID="lblSCount" Runat="server"></asp:Label></td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0THO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0TVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS0WVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HCI" Runat="server"></asp:Label></td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HCO" Runat="server"></asp:Label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HDI" Runat="server"></asp:Label></td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HDO" Runat="server"></asp:Label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HHI" Runat="server"></asp:Label></td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HHO" Runat="server"></asp:Label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HVI" Runat="server"></asp:Label></td>
                  <td class="supStat_CellNumber"><asp:Label ID="lblS0HVO" Runat="server"></asp:Label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F1">
            <td class="supStat_TableFirstCell">f.o. 7-20</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1THO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1TVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1WVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS1HVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F2">
            <td class="supStat_TableFirstCell">f.o. 20-24</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2THO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2TVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2WVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS2HVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr class="supStat_TableRow_F3">
            <td class="supStat_TableFirstCell">f.o. 0-7</td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">tutti</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3THI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3THO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3TVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">feriali</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3WVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
            <td class="supStat_TableCell">
              <table cellspacing="0" class="supStat_CellTable">
                <tr>
                  <td colspan="4" class="supStat_CellTitle">festivi</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">*</td>
                  <td class="supStat_CellSubTitle">ingresso</td>
                  <td class="supStat_CellSubTitle">uscita</td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">totale</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HCI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HCO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/g</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HDI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HDO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">media/h</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HHI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HHO" Runat="server"></asp:label></td>
                </tr>
                <tr>
                  <td colspan="2" class="supStat_CellText">delta su media tot.</td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HVI" Runat="server"></asp:label></td>
                  <td class="supStat_CellNumber"><asp:label id="lblS3HVO" Runat="server"></asp:label></td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
