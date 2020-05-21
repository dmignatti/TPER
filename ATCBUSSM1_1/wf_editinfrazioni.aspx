<%@ Page Language="vb" AutoEventWireup="false" Codebehind="wf_editinfrazioni.aspx.vb" Inherits="ATCBussm1.wf_editinfrazioni" %>
<%@ Register TagPrefix="ChkPerm" TagName="wc_checkpermission" Src="wc_checkpermission.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>wf_editinfrazioni</title>
    <script language="javascript">
		
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
			var txt_1 = document.getElementById("txtCodice_"+index);
			var txt_2 = document.getElementById("txtArticolo_"+index);
			var txt_3 = document.getElementById("txtDesc_"+index);
			var txt_4 = document.getElementById("txtImporto_"+index);
			if (chk.checked)
			{
				txt_1.style.backgroundColor = "Yellow";
				txt_2.style.backgroundColor = "Yellow";
				txt_3.style.backgroundColor = "Yellow";
				txt_4.style.backgroundColor = "Yellow";
			}
			else
			{
				txt_1.style.backgroundColor = "White";
				txt_2.style.backgroundColor = "White";
				txt_3.style.backgroundColor = "White";
				txt_4.style.backgroundColor = "White";
			}
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
        <table align="center">
          <tr>
            <td></td>
          </tr>
          <tr valign="top">
            <td class="Header1" align="center">Tariffe di Infrazioni al C.d.S.
            </td>
          </tr>
          <tr>
            <td></td>
          </tr>
          <tr>
            <td align="center">
              <asp:HyperLink ID="hlkBack" Runat="server" CssClass="Link">Annulla</asp:HyperLink>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <table align="center" class="supDTPicker_Table" width="250">
                <tr valign="top">
                  <td colspan="4" class="Header2">Tariffe valide
                  </td>
                </tr>
                <tr valign="top">
                  <td colspan="4" class="Header2">
                  </td>
                </tr>
                <tr valign="top">
                  <td class="supDTPicker_Label" width="20%">dal</td>
                  <td width="30%"><asp:textbox id="txtDateBegin" CssClass="supDTPicker_txtDay" Runat="server"></asp:textbox></td>
                  <td width="5%"><asp:requiredfieldvalidator id="rfvDateBegin" runat="server" ControlToValidate="txtDateBegin" ErrorMessage="*"></asp:requiredfieldvalidator></td>
                  <td align="left" width="45%"><asp:regularexpressionvalidator id="revDateBegin" runat="server" Width="100%" ControlToValidate="txtDateBegin" ValidationExpression="^(0[1-9]|1\d|2[0-8]|29((?!.02)|(?=.02)(?=.02.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00)))|30(?!.02)|31(?!.(0[2469]|11)))/(0[1-9]|1[0-2])/((1[6-9]|[2-9]\d)\d{2})$"
                      ErrorMessage="data errata"></asp:regularexpressionvalidator></td>
                </tr>
                <tr valign="top">
                  <td class="supDTPicker_Label">al</td>
                  <td><asp:label id="lblDateEnd" CssClass="supDTPicker_txtDay" Runat="server"></asp:label></td>
                  <td colspan="2"></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <table width="500">
                <tr>
                  <td class="Header2" width="30%">Sostituisci importo di €:
                  </td>
                  <td width="15%">
                    <asp:TextBox id="txtOldRate" Runat="server" CssClass="supDTPicker_txtYear"></asp:TextBox>
                  </td>
                  <td class="Header2" width="30%">con importo di €:
                  </td>
                  <td width="15%">
                    <asp:TextBox id="txtNewRate" Runat="server" CssClass="supDTPicker_txtYear"></asp:TextBox>
                  </td>
                  <td width="10%">
                    <asp:Button ID="btnGo" Runat="server" CssClass="supDTPicker_LRButton" Text="Vai"></asp:Button>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:label id="lblError" CssClass="lblError" Runat="server"></asp:label>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:table id="tbl" Runat="server" CssClass="supGDATCSession_Table" CellPadding="0" CellSpacing="0"></asp:table>
            </td>
          </tr>
          <tr vAlign="top">
            <td align="center">
              <asp:Button ID="btnSave" Runat="server" CssClass="Button" Text="Salva"></asp:Button>
            </td>
          </tr>
        </table>
      </div>
      <INPUT ID="hidRows" type="hidden" runat="server" NAME="hidRows">
    </form>
  </body>
</HTML>
