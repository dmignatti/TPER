Public Class wf_monthseabo
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tbl As System.Web.UI.WebControls.Table
  Protected WithEvents btnSave As System.Web.UI.WebControls.Button
  Protected WithEvents btnAll As System.Web.UI.WebControls.Button
  Protected WithEvents btnNone As System.Web.UI.WebControls.Button
  Protected WithEvents ddlMonth As System.Web.UI.WebControls.DropDownList
  Protected WithEvents txtYear As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

  Protected m_strParamMonth As String
  Protected m_strParamYear As String
  Protected m_strParamModuleID As String

  Private m_intYear As Integer
  Private m_intMonth As Integer
  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_Holds As supHolidays
  Private m_SMonth As supSeaboMonth

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      m_strParamMonth = Chr(39) & atcbConstant.QS_SelectedMonth & Chr(39)
      m_strParamYear = Chr(39) & atcbConstant.QS_SelectedYear & Chr(39)
      m_strParamModuleID = Chr(39) & atcbConstant.QS_ModuleID & "=" & Request.QueryString(atcbConstant.QS_ModuleID) & Chr(39)
    Catch ex As Exception
    End Try

    ' Legge il mese e l'anno selezionati; imposta le date ed i relativi controlli.
    Try
      m_intMonth = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_SelectedMonth))
      m_intYear = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_SelectedYear))
      m_dtmDateBegin = New DateTime(m_intYear, m_intMonth, 1)
      m_dtmDateEnd = New DateTime(m_intYear, m_intMonth, DateTime.DaysInMonth(m_intYear, m_intMonth))
    Catch ex As Exception
      m_intMonth = DateTime.Now.Month
      m_intYear = DateTime.Now.Year
      m_dtmDateBegin = New DateTime(m_intYear, m_intMonth, 1)
      m_dtmDateEnd = New DateTime(m_intYear, m_intMonth, DateTime.DaysInMonth(m_intYear, m_intMonth))
    End Try
    supFunction.Fill_DllMonth(ddlMonth, m_intMonth)
    txtYear.Text = CStr(m_intYear)

    m_Holds = New supHolidays(m_dtmDateBegin, m_dtmDateEnd)
    SetCalendar()
    m_SMonth = New supSeaboMonth(m_intMonth, m_intYear)
    If Not IsPostBack Then
      Fill()
    End If

  End Sub

  Private Sub SetCalendar()

    Dim i As Integer

    For i = 1 To 11
      Dim dtmDay As DateTime = New DateTime(m_intYear, m_intMonth, i)
      AddRow(dtmDay)
    Next

  End Sub

  Private Sub AddRow(ByVal dtmDay As DateTime)

    Dim row As New System.Web.UI.WebControls.TableRow
    AddItem(row, dtmDay)
    If (dtmDay.AddDays(11).Month = m_intMonth) Then
      AddSeparator(row)
      AddItem(row, dtmDay.AddDays(11))
    End If
    If (dtmDay.AddDays(22).Month = m_intMonth) Then
      AddSeparator(row)
      AddItem(row, dtmDay.AddDays(22))
    End If
    tbl.Rows.Add(row)

  End Sub

  Private Sub AddItem(ByVal row As System.Web.UI.WebControls.TableRow, ByVal dtmDay As DateTime)

    Const kiHeight As Integer = 24

    Dim blnIsHoliday As Boolean = (Not (m_Holds(dtmDay) Is Nothing) Or (dtmDay.DayOfWeek = DayOfWeek.Sunday))

    Dim fCell As New System.Web.UI.WebControls.TableCell
    fCell.Text = supFunction.WeekdayName(dtmDay, supFunction.supWeekdayNameEnum.wneShortName)
    fCell.Width = Unit.Pixel(30)
    fCell.Height = Unit.Pixel(kiHeight)

    Dim sCell As New System.Web.UI.WebControls.TableCell
    sCell.Text = supFunction.FormatDate(dtmDay, supFunction.supDateFormatEnum.dfeLongDate)
    sCell.Width = Unit.Pixel(70)
    fCell.Height = Unit.Pixel(kiHeight)

    If blnIsHoliday Then
      fCell.CssClass = "supCalendarSeabo_CellHoliday"
      sCell.CssClass = "supCalendarSeabo_CellHoliday"
    Else
      fCell.CssClass = "supCalendarSeabo_CellDate"
      sCell.CssClass = "supCalendarSeabo_CellDate"
    End If

    Dim tCell As New System.Web.UI.WebControls.TableCell
    Dim chk As New System.Web.UI.WebControls.CheckBox
    chk.ID = "chk_" & dtmDay.Day.ToString
    chk.Attributes.Add("Runat", "server")
    tCell.Controls.Add(chk)
    tCell.CssClass = "supCalendarSeabo_CellCheck"
    tCell.Width = Unit.Pixel(25)
    fCell.Height = Unit.Pixel(kiHeight)

    row.Cells.Add(fCell)
    row.Cells.Add(sCell)
    row.Cells.Add(tCell)

  End Sub

  Private Sub AddSeparator(ByVal row As System.Web.UI.WebControls.TableRow)

    Dim cell As New System.Web.UI.WebControls.TableCell
    cell.Text = ""
    cell.Width = Unit.Pixel(15)
    cell.CssClass = "supCalendarSeabo_CellSeparator"
    row.Cells.Add(cell)

  End Sub

  Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click

    Dim i As Integer
    Dim chk As System.Web.UI.WebControls.CheckBox

    For i = 1 To DateTime.DaysInMonth(m_intYear, m_intMonth)
      chk = tbl.FindControl("chk_" & i.ToString)
      If Not (chk Is Nothing) Then
        chk.Checked = True
      End If
    Next

  End Sub

  Private Sub btnNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNone.Click

    Dim i As Integer
    Dim chk As System.Web.UI.WebControls.CheckBox

    For i = 1 To DateTime.DaysInMonth(m_intYear, m_intMonth)
      chk = tbl.FindControl("chk_" & i.ToString)
      If Not (chk Is Nothing) Then
        chk.Checked = False
      End If
    Next

  End Sub

  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    If Not (m_SMonth Is Nothing) Then
      ' Recupera i dati dall' interfaccia.
      Dim i, index As Integer
      Dim chk As System.Web.UI.WebControls.CheckBox
      For i = 0 To m_SMonth.UBound
        index = i + 1
        chk = tbl.FindControl("chk_" & index.ToString)
        m_SMonth(i).NewChecked() = chk.Checked
      Next
      ' Salva i dati.
      m_SMonth.Save()
    End If

  End Sub

  Private Sub Fill()

    If Not (m_SMonth Is Nothing) Then

      Dim i, index As Integer
      Dim chk As System.Web.UI.WebControls.CheckBox

      For i = 0 To m_SMonth.UBound
        index = i + 1
        If m_SMonth(i).Checked Then
          chk = tbl.FindControl("chk_" & index.ToString)
          chk.Checked = True
        End If
      Next

    End If

  End Sub

End Class
