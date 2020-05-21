<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_holidayedit.aspx.vb" Inherits="ATCBussm1.wf_holidayedit" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_holidayedit</title>
    <script language="javascript">
      
      var m_strParamYear = <%=m_strParamYear%>
      var m_strParamModuleID = <%=m_strParamModuleID%>
      
      function Body_OnLoad()
		  {
			  var hid = document.getElementById("hidRows");
			  if (hid!=null)
			  {
				  if (!isNaN(hid.value))
				  {
					  var i;
					  for(i=1; i<=hid.value; i++)
					  {chkSel_Click(i);}
				  }
			  }
		  }
  		
		  function BeforeDelete()
		  {
			  if (CheckForDelete())
			  {return "I record checkati verranno cancellati. Vuoi procedere?";}
			  else
			  {return "Salvare i dati?";}
		  }
  		
		  function CheckForDelete()
		  {
			  var bRC=false;
			  var hid = document.getElementById("hidRows");
			  if (hid!=null)
			  {
				  var i;
				  var count = hid.value;
				  for(i=1; i<=count; i++)
				  {
					  var chk = document.getElementById("chkSel_"+i);
					  if (chk.checked)
					  {bRC=true;}
				  }
			  }
			  return bRC;
		  }
  		
		  function chkSel_Click(index)
		  {
			  var chk = document.getElementById("chkSel_"+index);
			  var ddlMonth = document.getElementById("ddlMonth_"+index);
			  var txtDay = document.getElementById("txtDay_"+index);
			  var txtDesc = document.getElementById("txtDesc_"+index);
			  if (chk.checked)
			  {
				  ddlMonth.style.backgroundColor = "Yellow";
				  txtDay.style.backgroundColor = "Yellow";
				  txtDesc.style.backgroundColor = "Yellow";
			  }
			  else
			  {
				  ddlMonth.style.backgroundColor = "White";
				  txtDay.style.backgroundColor = "White";
				  txtDesc.style.backgroundColor = "White";
			  }
		  }
		  
      function btnApply_onClick()
      {window.navigate(pGetUrl(pGetYear()));}
      
      function btnPYear_onClick()
      {
        var intYear = pGetYear();
        intYear--;
        window.navigate(pGetUrl(intYear));
      }
      
      function btnNYear_onClick()
      {
        var intYear = pGetYear();
        intYear++;
        window.navigate(pGetUrl(intYear));
      }
      
      function btnThisYear_onClick()
      {window.navigate(pGetUrl('x'));}
      
      function pGetUrl(intYear)
      {
        var strUrl = 'wf_holidayedit.aspx?';
        strUrl = strUrl + m_strParamYear + '=' + String(intYear) + '&'; 
        strUrl = strUrl + m_strParamModuleID;
        return strUrl;
      }
      
      function pGetYear()
      {
        var txt = document.getElementById('txtYear');
        return txt.value;
      }
    </script>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="JavaScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
    <meta http-equiv="Pragma" content="no-cache">
    <LINK href="ATC.css" type="text/css" rel="stylesheet">
  </HEAD>
  <body bgColor="#ffffff" onload="javascript: Body_OnLoad()">
    <form id="Form1" method="post" runat="server">
      <div align="center">
        <ChkPerm:wc_checkpermission id="Wc_checkpermission1" runat="server"></ChkPerm:wc_checkpermission><br>
        <table align="center" width="500">
          <tr height="65">
            <td>
              <table class="supDTPicker_Table" align="center" width="150">
                <tr>
                  <td></td>
                  <td>
                    <input class="supDTPicker_UDButton" id="btnApply" onclick="javascript: btnApply_onClick()"
                      type="button" value="Applica">
                  </td>
                  <td></td>
                </tr>
                <tr>
                  <td width="20%">
                    <input class="supDTPicker_LRButton" id="btnPYear" onclick="javascript: btnPYear_onClick()"
                      type="button" value="<">
                  </td>
                  <td width="60%">
                    <asp:textbox id="txtYear" Runat="server" CssClass="supDTPicker_txtYear"></asp:textbox>
                  </td>
                  <td width="20%">
                    <input class="supDTPicker_LRButton" id="btnNYear" onclick="javascript: btnNYear_onClick()"
                      type="button" value=">">
                  </td>
                </tr>
                <tr>
                  <td></td>
                  <td>
                    <input class="supDTPicker_UDButton" id="btnThisYear" onclick="javascript: btnThisYear_onClick()"
                      type="button" value="Anno corrente">
                  </td>
                  <td></td>
                </tr>
              </table>
              <br>
            </td>
            <td align="left" valign="top" width="30%">
              <table width="100%">
                <tr>
                  <td align="left" valign="top">
                    <asp:Label ID="lblState" Runat="server" CssClass="supHolidayConf_Message"></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td><br>
                  </td>
                </tr>
                <tr>
                  <td align="left" valign="top">
                    <asp:Label ID="lblEaster" Runat="server" CssClass="supHolidayConf_InputCtl"></asp:Label>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td align="center" valign="top" width="40%">
              <asp:Table ID="tbl" Runat="server" CssClass="supHolidayConf_Table" CellPadding="0" CellSpacing="2"></asp:Table>
            </td>
            <td align="left" valign="top" width="30%">
              <table width="100%">
                <tr>
                  <td width="20"></td>
                  <td>
                    <asp:Button ID="btnSave" Runat="server" CssClass="FlatButton" Text="Salva" Width="100px"></asp:Button>
                  </td>
                </tr>
                <tr>
                  <td width="20"></td>
                  <td>
                    <asp:Button ID="btnAdd" Runat="server" CssClass="FlatButton" Text="Aggiungi" Width="100px"></asp:Button>
                  </td>
                </tr>
                <tr>
                  <td width="20"></td>
                  <td>
                    <asp:Button ID="btnImport" Runat="server" CssClass="FlatButton" Text="Come anno prec." Width="100px"></asp:Button>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
        <INPUT ID="hidRows" type="hidden" runat="server" NAME="hidRows">
      </div>
    </form>
  </body>
</HTML>
