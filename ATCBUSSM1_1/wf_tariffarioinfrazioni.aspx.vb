Public Class wf_tariffarioinfrazioni
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents hlkAddNew As System.Web.UI.WebControls.HyperLink
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents lblError As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Private Const mk_CellHeight As Integer = 15
  Private Const mk_COLSTATE_WIDTH As Integer = 100
  Private Const mk_COLDATE_WIDTH As Integer = 100
  Private Const mk_COLLINK_WIDTH As Integer = 100

  Private Const mk_CSS_TITLEGRP As String = "supGDATCSession_DetailTitle0"
  Private Const mk_CSS_TITLE As String = "supGDATCSession_DetailTitle1"
  Private Const mk_CSS_TEXT As String = "supGDATCSession_DetailLeft"
  Private Const mk_CSS_DATE As String = "supGDATCSession_DetailCenter"
  Private Const mk_CSS_LINK As String = "supGDATCSession_DetailLink"

  Private m_Tarfs As supTarfIntervals

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      Dim dtmTomorrow As DateTime = DateTime.Today.AddDays(1)
      m_Tarfs = New supTarfIntervals(supTarfIntervals.TarfType.tteForInfrazioniCds)
      hlkAddNew.Visible = m_Tarfs.CanAddNew
      hlkAddNew.NavigateUrl = "wf_editinfrazioni.aspx?" & _
                              atcbConstant.QS_DateBegin & "=" & supFunction.FormatDate(dtmTomorrow, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                              atcbConstant.QS_DateEnd & "=31/12/9999" & "&" & _
                              atcbConstant.QS_DBMode & "=" & CStr(atcbConstant.DBModeEnum.dbmForInsert) & "&" & _
                              atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)
      Fill()
    Catch ex As Exception
    End Try

  End Sub

  Private Sub Fill()

    Dim i As Integer
    Try
      tbl.Rows.Clear()
      Dim row As New TableRow
      row.Cells.Add(GetCell(1, "Stato", mk_CSS_TITLE, mk_COLSTATE_WIDTH, mk_CellHeight))
      row.Cells.Add(GetCell(1, "Data inizio tariffa", mk_CSS_TITLE, mk_COLDATE_WIDTH, mk_CellHeight))
      row.Cells.Add(GetCell(1, "Data fine tariffa", mk_CSS_TITLE, mk_COLDATE_WIDTH, mk_CellHeight))
      row.Cells.Add(GetCell(4, "Operazioni possibili", mk_CSS_TITLEGRP, 4 * mk_COLLINK_WIDTH, mk_CellHeight))
      tbl.Rows.Add(row)
      For i = 0 To m_Tarfs.UBound
        AddItem(m_Tarfs(i))
      Next
    Catch ex As Exception
      'lblSession.Text = "Errore in lettura dati"
    End Try

  End Sub

  Private Sub AddItem(ByRef ti As supTarfInterval)

    Dim sNavigateUrl As String
    Dim hlk As HyperLink
    Dim row As New TableRow

    ' Stato.
    row.Cells.Add(GetCell(1, ti.State, mk_CSS_TEXT, mk_COLSTATE_WIDTH, mk_CellHeight))
    ' Data inizio.
    row.Cells.Add(GetCell(1, supFunction.FormatDate(ti.DataInizio, supFunction.supDateFormatEnum.dfeStandard), mk_CSS_DATE, mk_COLDATE_WIDTH, mk_CellHeight))
    ' Data fine.
    row.Cells.Add(GetCell(1, supFunction.FormatDate(ti.DataFine, supFunction.supDateFormatEnum.dfeStandard), mk_CSS_DATE, mk_COLDATE_WIDTH, mk_CellHeight))
    ' READ.
    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))
    sNavigateUrl = "wf_viewinfrazioni.aspx?" & _
                   atcbConstant.QS_DateBegin & "=" & supFunction.FormatDate(ti.DataInizio, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                   atcbConstant.QS_DateEnd & "=" & supFunction.FormatDate(ti.DataFine, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                   atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)
    row.Cells(row.Cells.Count - 1).Controls.Add(GetLink("Vedi", mk_CSS_LINK, ti.DataInizio, ti.DataFine, sNavigateUrl))
    ' INSERT.
    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))
    If ti.CanAppendInfr Then
      sNavigateUrl = "wf_insertinfrazione.aspx?" & _
                     atcbConstant.QS_DateBegin & "=" & supFunction.FormatDate(ti.DataInizio, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_DateEnd & "=" & supFunction.FormatDate(ti.DataFine, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)
      row.Cells(row.Cells.Count - 1).Controls.Add(GetLink("Nuova infrazione", mk_CSS_LINK, ti.DataInizio, ti.DataFine, sNavigateUrl))
    End If
    ' UPDATE.
    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))
    If ti.CanUpdate Then
      sNavigateUrl = "wf_editinfrazioni.aspx?" & _
                     atcbConstant.QS_DateBegin & "=" & supFunction.FormatDate(ti.DataInizio, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_DateEnd & "=" & supFunction.FormatDate(ti.DataFine, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_DBMode & "=" & CStr(atcbConstant.DBModeEnum.dbmForUpdate) & "&" & _
                     atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)
      row.Cells(row.Cells.Count - 1).Controls.Add(GetLink("Modifica", mk_CSS_LINK, ti.DataInizio, ti.DataFine, sNavigateUrl))
    End If
    tbl.Rows.Add(row)
    ' DELETE.
    row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))
    If ti.CanDelete Then
      sNavigateUrl = "wf_deleteinfrazioni.aspx?" & _
                     atcbConstant.QS_DateBegin & "=" & supFunction.FormatDate(ti.DataInizio, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_DateEnd & "=" & supFunction.FormatDate(ti.DataFine, supFunction.supDateFormatEnum.dfeStandard) & "&" & _
                     atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID)
      row.Cells(row.Cells.Count - 1).Controls.Add(GetLink("Elimina", mk_CSS_LINK, ti.DataInizio, ti.DataFine, sNavigateUrl))
    End If
    tbl.Rows.Add(row)

    'row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))
    'row.Cells.Add(GetCell(1, "", mk_CSS_TEXT, mk_COLLINK_WIDTH, mk_CellHeight))

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

  Public Function GetLink(ByVal strText As String, ByVal strCssClass As String, ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime, ByVal strNavigateUrl As String) As HyperLink

    Dim hlk As New HyperLink
    hlk.Text = strText
    hlk.CssClass = strCssClass
    hlk.NavigateUrl = strNavigateUrl
    hlk.Target = "_self"

    Return hlk
    'hlk.NavigateUrl = "wf_sessiondetail.aspx?" & atcbConstant.QS_SessionPK & "=" & rcd.PK.ToString

  End Function

End Class
