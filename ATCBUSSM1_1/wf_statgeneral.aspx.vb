Public Class wf_statgeneral
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblS1WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1WVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1TVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS1HVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2WVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2HVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3TVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3WVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS3HVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0TVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0WVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HVI As System.Web.UI.WebControls.Label
  Protected WithEvents lblS0HVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT0HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT1HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT2HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3TCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3TCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3TDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3TDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3THI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3THO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3WHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HCI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HCO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HDI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HDO As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HHI As System.Web.UI.WebControls.Label
  Protected WithEvents lblT3HHO As System.Web.UI.WebControls.Label
  Protected WithEvents lblTCount As System.Web.UI.WebControls.Label
  Protected WithEvents lblSCount As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TVAO As System.Web.UI.WebControls.Label
  Protected WithEvents lblS2TVO As System.Web.UI.WebControls.Label
  Protected WithEvents lblTInterval As System.Web.UI.WebControls.Label
  Protected WithEvents lblSInterval As System.Web.UI.WebControls.Label
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents btnRefresh As System.Web.UI.WebControls.Button
  Protected WithEvents txtDateBegin As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateBegin As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateBegin As System.Web.UI.WebControls.RegularExpressionValidator
  Protected WithEvents txtDateEnd As System.Web.UI.WebControls.TextBox
  Protected WithEvents rfvDateEnd As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents revDateEnd As System.Web.UI.WebControls.RegularExpressionValidator

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private m_dtmDateBegin, m_dtmDateEnd As DateTime

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      If IsPostBack Then
        m_dtmDateBegin = supFunction.DecodeDate(txtDateBegin.Text)
        m_dtmDateEnd = supFunction.DecodeDate(txtDateEnd.Text)
      Else
        m_dtmDateBegin = New DateTime(DateTime.Today.Year, 1, 1)
        m_dtmDateEnd = DateTime.Today
        txtDateBegin.Text = supFunction.FormatDate(m_dtmDateBegin, supFunction.supDateFormatEnum.dfeStandard)
        txtDateEnd.Text = supFunction.FormatDate(m_dtmDateEnd, supFunction.supDateFormatEnum.dfeStandard)
      End If
      Fill()
      lblError.Text = ""
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

    GC.Collect(GC.MaxGeneration)

  End Sub

  Private Sub Fill()

    ' *************************************************************************
    '     PRIMA TABELLA
    ' *************************************************************************
    Dim dtmDayZero As DateTime = supStatData.DayZero
    Dim dtmToday As DateTime = DateTime.Today
    'Dim dtmToday As DateTime = New DateTime(2003, 12, 31)
    Dim OAStat As New supStatCompact(dtmDayZero, dtmToday)
    OAStat.Fill()

    lblTInterval.Text = supFunction.FormatDate(dtmDayZero, supFunction.supDateFormatEnum.dfeLongDate) & " - " & supFunction.FormatDate(dtmToday, supFunction.supDateFormatEnum.dfeLongDate)
    lblTCount.Text = "gg. " & OAStat.DayCount.ToString
    ' Prima riga: totali su 24 ore.
    lblT0TCI.Text = OAStat.Rows(0).AllDays.CountIn.Value
    lblT0TCO.Text = OAStat.Rows(0).AllDays.CountOut.Value
    lblT0TDI.Text = OAStat.Rows(0).AllDays.Get_DayAverageIn
    lblT0TDO.Text = OAStat.Rows(0).AllDays.Get_DayAverageOut
    lblT0THI.Text = OAStat.Rows(0).AllDays.Get_HourAverageIn
    lblT0THO.Text = OAStat.Rows(0).AllDays.Get_HourAverageOut

    lblT0WCI.Text = OAStat.Rows(0).WorkingDays.CountIn.Value
    lblT0WCO.Text = OAStat.Rows(0).WorkingDays.CountOut.Value
    lblT0WDI.Text = OAStat.Rows(0).WorkingDays.Get_DayAverageIn
    lblT0WDO.Text = OAStat.Rows(0).WorkingDays.Get_DayAverageOut
    lblT0WHI.Text = OAStat.Rows(0).WorkingDays.Get_HourAverageIn
    lblT0WHO.Text = OAStat.Rows(0).WorkingDays.Get_HourAverageOut

    lblT0HCI.Text = OAStat.Rows(0).Holidays.CountIn.Value
    lblT0HCO.Text = OAStat.Rows(0).Holidays.CountOut.Value
    lblT0HDI.Text = OAStat.Rows(0).Holidays.Get_DayAverageIn
    lblT0HDO.Text = OAStat.Rows(0).Holidays.Get_DayAverageOut
    lblT0HHI.Text = OAStat.Rows(0).Holidays.Get_HourAverageIn
    lblT0HHO.Text = OAStat.Rows(0).Holidays.Get_HourAverageOut

    ' Seconda riga: fascia oraria 7-20.
    lblT1TCI.Text = OAStat.Rows(1).AllDays.CountIn.Value
    lblT1TCO.Text = OAStat.Rows(1).AllDays.CountOut.Value
    lblT1TDI.Text = OAStat.Rows(1).AllDays.Get_DayAverageIn
    lblT1TDO.Text = OAStat.Rows(1).AllDays.Get_DayAverageOut
    lblT1THI.Text = OAStat.Rows(1).AllDays.Get_HourAverageIn
    lblT1THO.Text = OAStat.Rows(1).AllDays.Get_HourAverageOut

    lblT1WCI.Text = OAStat.Rows(1).WorkingDays.CountIn.Value
    lblT1WCO.Text = OAStat.Rows(1).WorkingDays.CountOut.Value
    lblT1WDI.Text = OAStat.Rows(1).WorkingDays.Get_DayAverageIn
    lblT1WDO.Text = OAStat.Rows(1).WorkingDays.Get_DayAverageOut
    lblT1WHI.Text = OAStat.Rows(1).WorkingDays.Get_HourAverageIn
    lblT1WHO.Text = OAStat.Rows(1).WorkingDays.Get_HourAverageOut

    lblT1HCI.Text = OAStat.Rows(1).Holidays.CountIn.Value
    lblT1HCO.Text = OAStat.Rows(1).Holidays.CountOut.Value
    lblT1HDI.Text = OAStat.Rows(1).Holidays.Get_DayAverageIn
    lblT1HDO.Text = OAStat.Rows(1).Holidays.Get_DayAverageOut
    lblT1HHI.Text = OAStat.Rows(1).Holidays.Get_HourAverageIn
    lblT1HHO.Text = OAStat.Rows(1).Holidays.Get_HourAverageOut

    ' Terza riga: fascia oraria 20-24.
    lblT2TCI.Text = OAStat.Rows(2).AllDays.CountIn.Value
    lblT2TCO.Text = OAStat.Rows(2).AllDays.CountOut.Value
    lblT2TDI.Text = OAStat.Rows(2).AllDays.Get_DayAverageIn
    lblT2TDO.Text = OAStat.Rows(2).AllDays.Get_DayAverageOut
    lblT2THI.Text = OAStat.Rows(2).AllDays.Get_HourAverageIn
    lblT2THO.Text = OAStat.Rows(2).AllDays.Get_HourAverageOut

    lblT2WCI.Text = OAStat.Rows(2).WorkingDays.CountIn.Value
    lblT2WCO.Text = OAStat.Rows(2).WorkingDays.CountOut.Value
    lblT2WDI.Text = OAStat.Rows(2).WorkingDays.Get_DayAverageIn
    lblT2WDO.Text = OAStat.Rows(2).WorkingDays.Get_DayAverageOut
    lblT2WHI.Text = OAStat.Rows(2).WorkingDays.Get_HourAverageIn
    lblT2WHO.Text = OAStat.Rows(2).WorkingDays.Get_HourAverageOut

    lblT2HCI.Text = OAStat.Rows(2).Holidays.CountIn.Value
    lblT2HCO.Text = OAStat.Rows(2).Holidays.CountOut.Value
    lblT2HDI.Text = OAStat.Rows(2).Holidays.Get_DayAverageIn
    lblT2HDO.Text = OAStat.Rows(2).Holidays.Get_DayAverageOut
    lblT2HHI.Text = OAStat.Rows(2).Holidays.Get_HourAverageIn
    lblT2HHO.Text = OAStat.Rows(2).Holidays.Get_HourAverageOut

    ' Quarta riga: fascia oraria 0-7.
    lblT3TCI.Text = OAStat.Rows(3).AllDays.CountIn.Value
    lblT3TCO.Text = OAStat.Rows(3).AllDays.CountOut.Value
    lblT3TDI.Text = OAStat.Rows(3).AllDays.Get_DayAverageIn
    lblT3TDO.Text = OAStat.Rows(3).AllDays.Get_DayAverageOut
    lblT3THI.Text = OAStat.Rows(3).AllDays.Get_HourAverageIn
    lblT3THO.Text = OAStat.Rows(3).AllDays.Get_HourAverageOut

    lblT3WCI.Text = OAStat.Rows(3).WorkingDays.CountIn.Value
    lblT3WCO.Text = OAStat.Rows(3).WorkingDays.CountOut.Value
    lblT3WDI.Text = OAStat.Rows(3).WorkingDays.Get_DayAverageIn
    lblT3WDO.Text = OAStat.Rows(3).WorkingDays.Get_DayAverageOut
    lblT3WHI.Text = OAStat.Rows(3).WorkingDays.Get_HourAverageIn
    lblT3WHO.Text = OAStat.Rows(3).WorkingDays.Get_HourAverageOut

    lblT3HCI.Text = OAStat.Rows(3).Holidays.CountIn.Value
    lblT3HCO.Text = OAStat.Rows(3).Holidays.CountOut.Value
    lblT3HDI.Text = OAStat.Rows(3).Holidays.Get_DayAverageIn
    lblT3HDO.Text = OAStat.Rows(3).Holidays.Get_DayAverageOut
    lblT3HHI.Text = OAStat.Rows(3).Holidays.Get_HourAverageIn
    lblT3HHO.Text = OAStat.Rows(3).Holidays.Get_HourAverageOut

    ' *************************************************************************
    '     SECONDA TABELLA
    ' *************************************************************************
    Dim Stat As New supStatCompact(m_dtmDateBegin, m_dtmDateEnd)
    Stat.Fill()

    lblSInterval.Text = supFunction.FormatDate(m_dtmDateBegin, supFunction.supDateFormatEnum.dfeLongDate) & " - " & supFunction.FormatDate(m_dtmDateEnd, supFunction.supDateFormatEnum.dfeLongDate)
    lblSCount.Text = "gg. " & Stat.DayCount.ToString
    ' Prima riga: totali su 24 ore.
    lblS0TCI.Text = Stat.Rows(0).AllDays.CountIn.Value
    lblS0TCO.Text = Stat.Rows(0).AllDays.CountOut.Value
    lblS0TDI.Text = Stat.Rows(0).AllDays.Get_DayAverageIn
    lblS0TDO.Text = Stat.Rows(0).AllDays.Get_DayAverageOut
    lblS0THI.Text = Stat.Rows(0).AllDays.Get_HourAverageIn
    lblS0THO.Text = Stat.Rows(0).AllDays.Get_HourAverageOut
    'lblS0TVI.Text = Stat.Rows(0).AllDays.Get_StrDeltaIn(OAStat.Rows(0).AllDays.Get_DayAverageIn)
    'lblS0TVO.Text = Stat.Rows(0).AllDays.Get_StrDeltaOut(OAStat.Rows(0).AllDays.Get_DayAverageOut)
    lblS0TVI.Text = Stat.Rows(0).AllDays.Get_StrDeltaIn(OAStat.Rows(0).AllDays.CountIn.Value)
    lblS0TVO.Text = Stat.Rows(0).AllDays.Get_StrDeltaOut(OAStat.Rows(0).AllDays.CountOut.Value)

    lblS0WCI.Text = Stat.Rows(0).WorkingDays.CountIn.Value
    lblS0WCO.Text = Stat.Rows(0).WorkingDays.CountOut.Value
    lblS0WDI.Text = Stat.Rows(0).WorkingDays.Get_DayAverageIn
    lblS0WDO.Text = Stat.Rows(0).WorkingDays.Get_DayAverageOut
    lblS0WHI.Text = Stat.Rows(0).WorkingDays.Get_HourAverageIn
    lblS0WHO.Text = Stat.Rows(0).WorkingDays.Get_HourAverageOut
    'lblS0WVI.Text = Stat.Rows(0).WorkingDays.Get_StrDeltaIn(OAStat.Rows(0).WorkingDays.Get_DayAverageIn)
    'lblS0WVO.Text = Stat.Rows(0).WorkingDays.Get_StrDeltaOut(OAStat.Rows(0).WorkingDays.Get_DayAverageOut)
    lblS0WVI.Text = Stat.Rows(0).WorkingDays.Get_StrDeltaIn(OAStat.Rows(0).WorkingDays.CountIn.Value)
    lblS0WVO.Text = Stat.Rows(0).WorkingDays.Get_StrDeltaOut(OAStat.Rows(0).WorkingDays.CountOut.Value)

    lblS0HCI.Text = Stat.Rows(0).Holidays.CountIn.Value
    lblS0HCO.Text = Stat.Rows(0).Holidays.CountOut.Value
    lblS0HDI.Text = Stat.Rows(0).Holidays.Get_DayAverageIn
    lblS0HDO.Text = Stat.Rows(0).Holidays.Get_DayAverageOut
    lblS0HHI.Text = Stat.Rows(0).Holidays.Get_HourAverageIn
    lblS0HHO.Text = Stat.Rows(0).Holidays.Get_HourAverageOut
    'lblS0HVI.Text = Stat.Rows(0).Holidays.Get_StrDeltaIn(OAStat.Rows(0).Holidays.Get_DayAverageIn)
    'lblS0HVO.Text = Stat.Rows(0).Holidays.Get_StrDeltaOut(OAStat.Rows(0).Holidays.Get_DayAverageOut)
    lblS0HVI.Text = Stat.Rows(0).Holidays.Get_StrDeltaIn(OAStat.Rows(0).Holidays.CountIn.Value)
    lblS0HVO.Text = Stat.Rows(0).Holidays.Get_StrDeltaOut(OAStat.Rows(0).Holidays.CountOut.Value)

    ' Seconda riga: fascia oraria 7-20.
    lblS1TCI.Text = Stat.Rows(1).AllDays.CountIn.Value
    lblS1TCO.Text = Stat.Rows(1).AllDays.CountOut.Value
    lblS1TDI.Text = Stat.Rows(1).AllDays.Get_DayAverageIn
    lblS1TDO.Text = Stat.Rows(1).AllDays.Get_DayAverageOut
    lblS1THI.Text = Stat.Rows(1).AllDays.Get_HourAverageIn
    lblS1THO.Text = Stat.Rows(1).AllDays.Get_HourAverageOut
    'lblS1TVI.Text = Stat.Rows(1).AllDays.Get_StrDeltaIn(OAStat.Rows(1).AllDays.Get_DayAverageIn)
    'lblS1TVO.Text = Stat.Rows(1).AllDays.Get_StrDeltaOut(OAStat.Rows(1).AllDays.Get_DayAverageOut)
    lblS1TVI.Text = Stat.Rows(1).AllDays.Get_StrDeltaIn(OAStat.Rows(1).AllDays.CountIn.Value)
    lblS1TVO.Text = Stat.Rows(1).AllDays.Get_StrDeltaOut(OAStat.Rows(1).AllDays.CountOut.Value)

    lblS1WCI.Text = Stat.Rows(1).WorkingDays.CountIn.Value
    lblS1WCO.Text = Stat.Rows(1).WorkingDays.CountOut.Value
    lblS1WDI.Text = Stat.Rows(1).WorkingDays.Get_DayAverageIn
    lblS1WDO.Text = Stat.Rows(1).WorkingDays.Get_DayAverageOut
    lblS1WHI.Text = Stat.Rows(1).WorkingDays.Get_HourAverageIn
    lblS1WHO.Text = Stat.Rows(1).WorkingDays.Get_HourAverageOut
    'lblS1WVI.Text = Stat.Rows(1).WorkingDays.Get_StrDeltaIn(OAStat.Rows(1).WorkingDays.Get_DayAverageIn)
    'lblS1WVO.Text = Stat.Rows(1).WorkingDays.Get_StrDeltaOut(OAStat.Rows(1).WorkingDays.Get_DayAverageOut)
    lblS1WVI.Text = Stat.Rows(1).WorkingDays.Get_StrDeltaIn(OAStat.Rows(1).WorkingDays.CountIn.Value)
    lblS1WVO.Text = Stat.Rows(1).WorkingDays.Get_StrDeltaOut(OAStat.Rows(1).WorkingDays.CountOut.Value)

    lblS1HCI.Text = Stat.Rows(1).Holidays.CountIn.Value
    lblS1HCO.Text = Stat.Rows(1).Holidays.CountOut.Value
    lblS1HDI.Text = Stat.Rows(1).Holidays.Get_DayAverageIn
    lblS1HDO.Text = Stat.Rows(1).Holidays.Get_DayAverageOut
    lblS1HHI.Text = Stat.Rows(1).Holidays.Get_HourAverageIn
    lblS1HHO.Text = Stat.Rows(1).Holidays.Get_HourAverageOut
    'lblS1HVI.Text = Stat.Rows(1).Holidays.Get_StrDeltaIn(OAStat.Rows(1).Holidays.Get_DayAverageIn)
    'lblS1HVO.Text = Stat.Rows(1).Holidays.Get_StrDeltaOut(OAStat.Rows(1).Holidays.Get_DayAverageOut)
    lblS1HVI.Text = Stat.Rows(1).Holidays.Get_StrDeltaIn(OAStat.Rows(1).Holidays.CountIn.Value)
    lblS1HVO.Text = Stat.Rows(1).Holidays.Get_StrDeltaOut(OAStat.Rows(1).Holidays.CountOut.Value)

    ' Terza riga: fascia oraria 20-24.
    lblS2TCI.Text = Stat.Rows(2).AllDays.CountIn.Value
    lblS2TCO.Text = Stat.Rows(2).AllDays.CountOut.Value
    lblS2TDI.Text = Stat.Rows(2).AllDays.Get_DayAverageIn
    lblS2TDO.Text = Stat.Rows(2).AllDays.Get_DayAverageOut
    lblS2THI.Text = Stat.Rows(2).AllDays.Get_HourAverageIn
    lblS2THO.Text = Stat.Rows(2).AllDays.Get_HourAverageOut
    'lblS2TVI.Text = Stat.Rows(2).AllDays.Get_StrDeltaIn(OAStat.Rows(2).AllDays.Get_DayAverageIn)
    'lblS2TVO.Text = Stat.Rows(2).AllDays.Get_StrDeltaOut(OAStat.Rows(2).AllDays.Get_DayAverageOut)
    lblS2TVI.Text = Stat.Rows(2).AllDays.Get_StrDeltaIn(OAStat.Rows(2).AllDays.CountIn.Value)
    lblS2TVO.Text = Stat.Rows(2).AllDays.Get_StrDeltaOut(OAStat.Rows(2).AllDays.CountOut.Value)

    lblS2WCI.Text = Stat.Rows(2).WorkingDays.CountIn.Value
    lblS2WCO.Text = Stat.Rows(2).WorkingDays.CountOut.Value
    lblS2WDI.Text = Stat.Rows(2).WorkingDays.Get_DayAverageIn
    lblS2WDO.Text = Stat.Rows(2).WorkingDays.Get_DayAverageOut
    lblS2WHI.Text = Stat.Rows(2).WorkingDays.Get_HourAverageIn
    lblS2WHO.Text = Stat.Rows(2).WorkingDays.Get_HourAverageOut
    'lblS2WVI.Text = Stat.Rows(2).WorkingDays.Get_StrDeltaIn(OAStat.Rows(2).WorkingDays.Get_DayAverageIn)
    'lblS2WVO.Text = Stat.Rows(2).WorkingDays.Get_StrDeltaOut(OAStat.Rows(2).WorkingDays.Get_DayAverageOut)
    lblS2WVI.Text = Stat.Rows(2).WorkingDays.Get_StrDeltaIn(OAStat.Rows(2).WorkingDays.CountIn.Value)
    lblS2WVO.Text = Stat.Rows(2).WorkingDays.Get_StrDeltaOut(OAStat.Rows(2).WorkingDays.CountOut.Value)

    lblS2HCI.Text = Stat.Rows(2).Holidays.CountIn.Value
    lblS2HCO.Text = Stat.Rows(2).Holidays.CountOut.Value
    lblS2HDI.Text = Stat.Rows(2).Holidays.Get_DayAverageIn
    lblS2HDO.Text = Stat.Rows(2).Holidays.Get_DayAverageOut
    lblS2HHI.Text = Stat.Rows(2).Holidays.Get_HourAverageIn
    lblS2HHO.Text = Stat.Rows(2).Holidays.Get_HourAverageOut
    'lblS2HVI.Text = Stat.Rows(2).Holidays.Get_StrDeltaIn(OAStat.Rows(2).Holidays.Get_DayAverageIn)
    'lblS2HVO.Text = Stat.Rows(2).Holidays.Get_StrDeltaOut(OAStat.Rows(2).Holidays.Get_DayAverageOut)
    lblS2HVI.Text = Stat.Rows(2).Holidays.Get_StrDeltaIn(OAStat.Rows(2).Holidays.CountIn.Value)
    lblS2HVO.Text = Stat.Rows(2).Holidays.Get_StrDeltaOut(OAStat.Rows(2).Holidays.CountOut.Value)

    ' Quarta riga: fascia oraria 0-7.
    lblS3TCI.Text = Stat.Rows(3).AllDays.CountIn.Value
    lblS3TCO.Text = Stat.Rows(3).AllDays.CountOut.Value
    lblS3TDI.Text = Stat.Rows(3).AllDays.Get_DayAverageIn
    lblS3TDO.Text = Stat.Rows(3).AllDays.Get_DayAverageOut
    lblS3THI.Text = Stat.Rows(3).AllDays.Get_HourAverageIn
    lblS3THO.Text = Stat.Rows(3).AllDays.Get_HourAverageOut
    'lblS3TVI.Text = Stat.Rows(3).AllDays.Get_StrDeltaIn(OAStat.Rows(3).AllDays.Get_DayAverageIn)
    'lblS3TVO.Text = Stat.Rows(3).AllDays.Get_StrDeltaOut(OAStat.Rows(3).AllDays.Get_DayAverageOut)
    lblS3TVI.Text = Stat.Rows(3).AllDays.Get_StrDeltaIn(OAStat.Rows(3).AllDays.CountIn.Value)
    lblS3TVO.Text = Stat.Rows(3).AllDays.Get_StrDeltaOut(OAStat.Rows(3).AllDays.CountOut.Value)

    lblS3WCI.Text = Stat.Rows(3).WorkingDays.CountIn.Value
    lblS3WCO.Text = Stat.Rows(3).WorkingDays.CountOut.Value
    lblS3WDI.Text = Stat.Rows(3).WorkingDays.Get_DayAverageIn
    lblS3WDO.Text = Stat.Rows(3).WorkingDays.Get_DayAverageOut
    lblS3WHI.Text = Stat.Rows(3).WorkingDays.Get_HourAverageIn
    lblS3WHO.Text = Stat.Rows(3).WorkingDays.Get_HourAverageOut
    'lblS3WVI.Text = Stat.Rows(3).WorkingDays.Get_StrDeltaIn(OAStat.Rows(3).WorkingDays.Get_DayAverageIn)
    'lblS3WVO.Text = Stat.Rows(3).WorkingDays.Get_StrDeltaOut(OAStat.Rows(3).WorkingDays.Get_DayAverageOut)
    lblS3WVI.Text = Stat.Rows(3).WorkingDays.Get_StrDeltaIn(OAStat.Rows(3).WorkingDays.CountIn.Value)
    lblS3WVO.Text = Stat.Rows(3).WorkingDays.Get_StrDeltaOut(OAStat.Rows(3).WorkingDays.CountOut.Value)

    lblS3HCI.Text = Stat.Rows(3).Holidays.CountIn.Value
    lblS3HCO.Text = Stat.Rows(3).Holidays.CountOut.Value
    lblS3HDI.Text = Stat.Rows(3).Holidays.Get_DayAverageIn
    lblS3HDO.Text = Stat.Rows(3).Holidays.Get_DayAverageOut
    lblS3HHI.Text = Stat.Rows(3).Holidays.Get_HourAverageIn
    lblS3HHO.Text = Stat.Rows(3).Holidays.Get_HourAverageOut
    'lblS3HVI.Text = Stat.Rows(3).Holidays.Get_StrDeltaIn(OAStat.Rows(3).Holidays.Get_DayAverageIn)
    'lblS3HVO.Text = Stat.Rows(3).Holidays.Get_StrDeltaOut(OAStat.Rows(3).Holidays.Get_DayAverageOut)
    lblS3HVI.Text = Stat.Rows(3).Holidays.Get_StrDeltaIn(OAStat.Rows(3).Holidays.CountIn.Value)
    lblS3HVO.Text = Stat.Rows(3).Holidays.Get_StrDeltaOut(OAStat.Rows(3).Holidays.CountOut.Value)

  End Sub

End Class
