Public Class atcbConstant

  Public Enum DBModeEnum As Integer
    dbmForInsert
    dbmForUpdate
    dbmForDelete
    dbmForSelect
  End Enum

  Public Const QS_DateBegin As String = "DateBegin"
  Public Const QS_DateEnd As String = "DateEnd"
  Public Const QS_DateInBegin As String = "DateInBegin"
  Public Const QS_DateInEnd As String = "DateInEnd"
  Public Const QS_DateOutBegin As String = "DateOutBegin"
  Public Const QS_DateOutEnd As String = "DateOutEnd"
  Public Const QS_DateIn As String = "DateIn"
  Public Const QS_DateOut As String = "DateOut"
  Public Const QS_TimeIn As String = "TimeIn"
  Public Const QS_TimeOut As String = "TimeOut"

  Public Const QS_SectionID As String = "SectionID"
  Public Const QS_SessionPK As String = "SessionID"
  Public Const QS_SelectedDay As String = "SelDay"
  Public Const QS_SelectedMonth As String = "SelMonth"
  Public Const QS_SelectedYear As String = "SelYear"
  Public Const QS_DayBegin As String = "DayBegin"
  Public Const QS_MonthBegin As String = "MonthBegin"
  Public Const QS_YearBegin As String = "YearBegin"
  Public Const QS_DayEnd As String = "DayEnd"
  Public Const QS_MonthEnd As String = "MonthEnd"
  Public Const QS_YearEnd As String = "YearEnd"
  Public Const QS_DBMode As String = "DBMode"

  Public Const QS_Mode As String = "Mode"
  Public Const QS_ModuleID As String = "ModuleID"
  Public Const QS_VehicleID As String = "VehicleID"
  Public Const QS_VehiclePlate As String = "VehiclePlate"
  Public Const QS_VehicleState As String = "VehicleState"
  Public Const QS_GDATCUser As String = "GDATCUser"


  Public Shared ReadOnly Property CS_CnnStringATCBUSSM() As String
    Get
      Return ConfigurationSettings.AppSettings("ConnectionString")
    End Get
  End Property

  Public Shared ReadOnly Property CS_CnnStringGDATC() As String
    Get
      Return ConfigurationSettings.AppSettings("ConnectionStringDepositerie")
    End Get
  End Property

End Class
