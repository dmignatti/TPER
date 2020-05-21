<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_monthseabo.aspx.vb" Inherits="ATCBussm1.wf_monthseabo" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_monthseabo</title>
    <script language="javascript">
      
      var m_strParamMonth = <%=m_strParamMonth%>
      var m_strParamYear = <%=m_strParamYear%>
      var m_strParamModuleID = <%=m_strParamModuleID%>
      
      function btnApply_onClick()
      {window.navigate(pGetUrl(pGetMonth(), pGetYear()));}
      
      function btnPMonth_onClick()
      {
        var intMonth = pGetMonth();
        var intYear = pGetYear();
        intMonth--;
        if (intMonth < 1)
        {
          intMonth = 12;
          intYear--;
        }
        window.navigate(pGetUrl(intMonth, intYear));
      }
      
      function btnNMonth_onClick()
      {
        var intMonth = pGetMonth();
        var intYear = pGetYear();
        intMonth++;
        if (intMonth > 12)
        {
          intMonth = 1;
          intYear++;
        }
        window.navigate(pGetUrl(intMonth, intYear));
      }
      
      function btnThisMonth_onClick()
      {window.navigate(pGetUrl('x', 'x'));}
      
      function pGetUrl(intMonth, intYear)
      {
        var strUrl = 'wf_monthseabo.aspx?';
        strUrl = strUrl + m_strParamMonth + '=' + String(intMonth) + '&'; 
        strUrl = strUrl + m_strParamYear + '=' + String(intYear) + '&'; 
        strUrl = strUrl + m_strParamModuleID;
        return strUrl;
      }
      
      function pGetMonth()
      {
        var sel = document.getElementById('ddlMonth');
        var intMonth = sel.selectedIndex;
        return intMonth + 1;
      }
      
      function pGetYear()
      {
        var txt = document.getElementById('txtYear');
        return txt.value;
      }
      
    </script>
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
          <tr>
            <td align="center">
              <table class="supDTPicker_Table" align="center" width="250">
                <tr>
                  <td></td>
                  <td colSpan="2">
                    <input class="supDTPicker_UDButton" id="btnApply" onclick="javascript: btnApply_onClick()"
                      type="button" value="Applica">
                  </td>
                  <td></td>
                </tr>
                <tr>
                  <td width="15%"><input class="supDTPicker_LRButton" id="btnPMonth" onclick="javascript: btnPMonth_onClick()"
                      type="button" value="<">
                  </td>
                  <TD width="40%">
                    <asp:dropdownlist id="ddlMonth" CssClass="supDTPicker_ddlMonth" Runat="server"></asp:dropdownlist></TD>
                  <td width="30%">
                    <asp:TextBox ID="txtYear" Runat="server" CssClass="supDTPicker_txtYear"></asp:TextBox>
                  </td>
                  <td width="15%"><input class="supDTPicker_LRButton" id="btnNMonth" onclick="javascript: btnNMonth_onClick()"
                      type="button" value=">">
                  </td>
                </tr>
                <tr>
                  <td></td>
                  <td colSpan="2"><input class="supDTPicker_UDButton" id="btnThisMonth" onclick="javascript: btnThisMonth_onClick()"
                      type="button" value="Mese corrente">
                  </td>
                  <td></td>
                </tr>
              </table>
              <br>
            </td>
            <td></td>
          </tr>
          <tr>
            <td vAlign="top" width="500"><asp:table id="tbl" CssClass="supCalendarSeabo_Table" Runat="server" CellSpacing="0"></asp:table></td>
            <td vAlign="top" width="130">
              <table>
                <tr>
                  <td width="20"></td>
                  <td><asp:button id="btnAll" Text="Seleziona tutti" CssClass="FlatButton" Runat="server" Width="100px"></asp:button></td>
                </tr>
                <tr>
                  <td width="20"></td>
                  <td><asp:button id="btnNone" Text="Deseleziona tutti" CssClass="FlatButton" Runat="server" Width="100px"></asp:button></td>
                </tr>
                <tr>
                  <td width="20"></td>
                  <td><asp:button id="btnSave" Text="Salva" CssClass="FlatButton" Runat="server" Width="100px"></asp:button></td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</HTML>
