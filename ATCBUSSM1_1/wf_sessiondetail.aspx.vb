Public Class wf_sessiondetail
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tblDetail As System.Web.UI.WebControls.Table
  Protected WithEvents lblSession As System.Web.UI.WebControls.Label
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Private Const m_kintCellHeight As Integer = 15

  'Private Const mk_ITEM_TITLE As String = "supGDATCSession_ItemTitle"
  'Private Const mk_ITEM_BODY As String = "supGDATCSession_ItemTable"

  'Private Const mk_DET_TITLEGRP As String = "supGDATCSession_DetailTitle0"
  Private Const mk_DET_TITLE As String = "supGDATCSession_DetailTitle1"
  'Private Const mk_DET_TITLETOT As String = "supGDATCSession_DetailTitle2"
  Private Const mk_DET_TEXT As String = "supGDATCSession_DetailLeft"
  Private Const mk_DET_DATE As String = "supGDATCSession_DetailCenter"
  Private Const mk_DET_NUMBER As String = "supGDATCSession_DetailRight"
  'Private Const mk_DET_TOTAL As String = "supGDATCSession_DetailTotal"
  'Private Const mk_DET_SUBTOTAL As String = "supGDATCSession_DetailSubTotal"
  'Private Const mk_DET_LINK As String = "supGDATCSession_DetailLink"
  Private Const mk_DET_COL0_WIDTH As Integer = 50
  Private Const mk_DET_COL1_WIDTH As Integer = 150
  Private Const mk_DET_COL2_WIDTH As Integer = 140
  Private Const mk_DET_COL3_WIDTH As Integer = 80
  'Private Const mk_ITEM_WIDTH As Integer = 820

  Private m_intSessionPK As Integer

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      m_intSessionPK = Request.QueryString(atcbConstant.QS_SessionPK)
      lblSession.Text = "Session ID: " & m_intSessionPK.ToString
      Fill()
    Catch ex As Exception
      lblSession.Text = "Errore in lettura querystring"
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    Dim i As Integer
    Try
      Dim sd As New supGDATCSessionDetail(m_intSessionPK)
      tblDetail.Rows.Clear()
      Dim row As New TableRow
      row.Cells.Add(GetCell(1, "Utente", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Computer", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Data/ora", mk_DET_TITLE, mk_DET_COL2_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Azione", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Tabella", mk_DET_TITLE, mk_DET_COL1_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Record", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Pagamento", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
      row.Cells.Add(GetCell(1, "Importo", mk_DET_TITLE, mk_DET_COL3_WIDTH, m_kintCellHeight))
      tblDetail.Rows.Add(row)
      For i = 0 To sd.Logs.UBound
        AddItem(tblDetail, sd.Logs(i))
      Next
    Catch ex As Exception
      lblSession.Text = "Errore in lettura dati"
    End Try

  End Sub

  Private Sub AddItem(ByRef tbl As Table, ByRef log As supGDATCSessionLog)

    Dim row As New TableRow
    row.Cells.Add(GetCell(1, log.UserName & " - " & log.UserID, mk_DET_TEXT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, log.ComputerName, mk_DET_TEXT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, supFunction.FormatDate(log.Time, supFunction.supDateFormatEnum.dfeDateTime), mk_DET_DATE, mk_DET_COL2_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, log.Action, mk_DET_TEXT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, log.DBTable, mk_DET_TEXT, mk_DET_COL1_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, log.DBRecord, mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    row.Cells.Add(GetCell(1, log.Payment, mk_DET_TEXT, mk_DET_COL3_WIDTH, m_kintCellHeight))
    If (log.Money > 0) Then
      row.Cells.Add(GetCell(1, supFunction.FormatEuro(log.Money, True), mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    Else
      row.Cells.Add(GetCell(1, ".", mk_DET_NUMBER, mk_DET_COL3_WIDTH, m_kintCellHeight))
    End If
    tbl.Rows.Add(row)

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As String, ByVal intHeight As Integer) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    cell.Width = Unit.Pixel(intWidth)
    cell.Height = Unit.Pixel(intHeight)
    Return cell

  End Function

End Class
