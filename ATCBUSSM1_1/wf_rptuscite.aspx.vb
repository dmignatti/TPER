Public Class wf_rptuscite
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents lblDateInFilter As System.Web.UI.WebControls.Label
  Protected WithEvents lblDateOutFilter As System.Web.UI.WebControls.Label
  Protected WithEvents lblTotCount As System.Web.UI.WebControls.Label

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim intState As supVehicleSearch.VehicleStateEnum
    Dim dtmDateInBegin, dtmDateInEnd, dtmDateOutBegin, dtmDateOutEnd As DateTime
    Dim vs As supVehicleSearch

    Try
      intState = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleState))
      dtmDateInBegin = System.Convert.ToDateTime(Request.QueryString(atcbConstant.QS_DateInBegin))
      dtmDateInEnd = System.Convert.ToDateTime(Request.QueryString(atcbConstant.QS_DateInEnd))
      dtmDateOutBegin = System.Convert.ToDateTime(Request.QueryString(atcbConstant.QS_DateOutBegin))
      dtmDateOutEnd = System.Convert.ToDateTime(Request.QueryString(atcbConstant.QS_DateOutEnd))
      WriteTitle(intState)
      WriteFilter(lblDateInFilter, dtmDateInBegin, dtmDateInEnd)
      WriteFilter(lblDateOutFilter, dtmDateOutBegin, dtmDateOutEnd)
      vs = New supVehicleSearch
      vs.State = intState
      vs.DateIn_Begin = dtmDateInBegin
      vs.DateIn_End = dtmDateInEnd
      vs.DateOut_Begin = dtmDateOutBegin
      vs.DateOut_End = dtmDateOutEnd
      'vs.Refresh()
      'Fill(vs)
      Fill(vs.getDataSet(), intState)
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub WriteTitle(ByVal intState As supVehicleSearch.VehicleStateEnum)

    Select Case intState
      Case supVehicleSearch.VehicleStateEnum.vseDemolished
        lblTitle.Text = "Veicoli demoliti"
      Case supVehicleSearch.VehicleStateEnum.vseHND
        lblTitle.Text = "Veicoli ritirati senza onere perché appartenenti ad invalidi"
      Case supVehicleSearch.VehicleStateEnum.vseRBD
        lblTitle.Text = "Veicoli usciti irregolarmente da deposito"
      Case supVehicleSearch.VehicleStateEnum.vseRBT
        lblTitle.Text = "Veicoli prelevati perché risultati rubati"
      Case supVehicleSearch.VehicleStateEnum.vseRSO
        lblTitle.Text = "Veicoli ritirati senza onere"
      Case supVehicleSearch.VehicleStateEnum.vseRTP
        lblTitle.Text = "Veicoli ritirati dietro regolare pagamento postdatato"
      Case supVehicleSearch.VehicleStateEnum.vseRTR
        lblTitle.Text = "Veicoli ritirati dietro regolare pagamento"
      Case supVehicleSearch.VehicleStateEnum.vseRVI
        lblTitle.Text = "Veicoli ritirati senza onere perché appartenenti ad istituzioni"
    End Select

  End Sub

  Private Sub WriteFilter(ByRef lbl As Label, ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    Dim strText As String = ""

    If (dtmDateBegin <> supVehicleSearch.getDefaultDateBegin) Then
      strText = "da " & supFunction.FormatDate(dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard)
    End If
    If (DateDiff(DateInterval.Day, dtmDateEnd, supVehicleSearch.getDefaultDateEnd) <> 0) Then
      strText = strText & " fino a " & supFunction.FormatDate(dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)
    End If

    lbl.Text = strText

  End Sub

  'Private Sub Fill(ByRef vs As supVehicleSearch)
  Private Sub Fill(ByRef ds As DataSet, ByVal intState As supVehicleSearch.VehicleStateEnum)

    Dim i As Integer

    tbl.Rows.Clear()

    lblTotCount.Text = System.Convert.ToString(ds.Tables(0).Rows.Count)

    AddHeader(ds, intState)
    For i = 0 To ds.Tables(0).Rows.Count - 1
      AddRow(ds.Tables(0).Rows(i), intState)
    Next

  End Sub

  'Private Sub AddHeader()

  '  Dim row As New TableRow
  '  row.Cells.Add(GetCell(0, "Targa", "Deposito_HeaderCell", 80, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, "Ingresso", "Deposito_HeaderCell", 110, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, "Uscita", "Deposito_HeaderCell", 110, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, "Tipo", "Deposito_HeaderCell", 110, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, "Marca", "Deposito_HeaderCell", 120, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, "Modello", "Deposito_HeaderCell", 120, 15, HorizontalAlign.Center))
  '  tbl.Rows.Add(row)

  'End Sub

  Private Sub AddHeader(ByRef ds As DataSet, ByVal intState As supVehicleSearch.VehicleStateEnum)

    Dim i As Integer
    Dim intColWidth, intTblWidth As Integer
    Dim row As New TableRow

    intTblWidth = 0

    If ((intState <> supVehicleSearch.VehicleStateEnum.vseDeleted) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vseDemolished) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vseShadowed) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vsePresent) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vsePresentCompleted)) Then
      row.Cells.Add(GetCell(0, "", "Deposito_HeaderCell", intColWidth, 15, HorizontalAlign.Center))
      intTblWidth = 70
    End If

    For i = 1 To ds.Tables(0).Columns.Count - 1
      Select Case ds.Tables(0).Columns(i).DataType.FullName
        Case "System.Int32"
          intColWidth = 80
        Case "System.String"
          intColWidth = 100
        Case "System.DateTime"
          intColWidth = 120
      End Select
      intTblWidth = intTblWidth + intColWidth
      row.Cells.Add(GetCell(0, ds.Tables(0).Columns(i).ColumnName, "Deposito_HeaderCell", intColWidth, 15, HorizontalAlign.Center))
    Next
    tbl.Rows.Add(row)
    tbl.Width = Unit.Pixel(intTblWidth)

  End Sub

  'Private Sub AddRow(ByRef vh As supVehicle)

  '  Dim row As New TableRow
  '  row.Cells.Add(GetCell(0, vh.Plate, "Deposito_DataCell", 0, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, supFunction.FormatDate(vh.DateIn, supFunction.supDateFormatEnum.dfeDateHourMin), "Deposito_DataCell", 0, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, supFunction.FormatDate(vh.DateOut, supFunction.supDateFormatEnum.dfeDateHourMin), "Deposito_DataCell", 0, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, vh.Type, "Deposito_DataCell", 0, 15, HorizontalAlign.Center))
  '  row.Cells.Add(GetCell(0, vh.Mark, "Deposito_DataCell", 0, 15, HorizontalAlign.Left))
  '  row.Cells.Add(GetCell(0, vh.Model, "Deposito_DataCell", 0, 15, HorizontalAlign.Left))
  '  tbl.Rows.Add(row)

  'End Sub

  Private Sub AddRow(ByRef dr As DataRow, ByVal intState As supVehicleSearch.VehicleStateEnum)

    Dim i As Integer
    Dim intAlign As HorizontalAlign
    Dim row As New TableRow
    Dim hlk As HyperLink

    If ((intState <> supVehicleSearch.VehicleStateEnum.vseDeleted) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vseDemolished) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vseShadowed) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vsePresent) And _
        (intState <> supVehicleSearch.VehicleStateEnum.vsePresentCompleted)) Then
      hlk = New HyperLink
      hlk.Text = "Dettagli"
      hlk.NavigateUrl = "wf_datiquietanza.aspx?" & _
                        atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & "&" & _
                        atcbConstant.QS_Mode & "=" & Request.QueryString(atcbConstant.QS_Mode) & "&" & _
                        atcbConstant.QS_VehicleID & "=" & CStr(dr(0)) & "&" & _
                        atcbConstant.QS_VehicleState & "=" & CStr(intState)
      hlk.CssClass = ""
      hlk.Width = Unit.Percentage(100)
      hlk.Height = Unit.Percentage(100)

      row.Cells.Add(GetCell(0, "", "Deposito_DataCell", 0, 15, HorizontalAlign.Center))
      row.Cells(0).Controls.Add(hlk)
    End If

    For i = 1 To dr.Table.Columns.Count - 1
      Select Case dr.Table.Columns(i).DataType.FullName
        Case "System.Int32"
          intAlign = HorizontalAlign.Right
        Case "System.String"
          intAlign = HorizontalAlign.Left
        Case "System.DateTime"
          intAlign = HorizontalAlign.Center
      End Select
      row.Cells.Add(GetCell(0, dr(i), "Deposito_DataCell", 0, 15, intAlign))
    Next
    tbl.Rows.Add(row)

  End Sub

  Private Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intHeight As Integer, ByVal intAlignment As HorizontalAlign) As TableCell

    Dim cell As New TableCell
    If (intColSpan > 1) Then
      cell.ColumnSpan = intColSpan
    End If
    cell.Text = strText
    cell.CssClass = strCssClass
    If (intWidth > 0) Then
      cell.Width = Unit.Pixel(intWidth)
    End If
    If (intHeight > 0) Then
      cell.Height = Unit.Pixel(intHeight)
    End If
    cell.HorizontalAlign = intAlignment
    Return cell

  End Function

End Class
