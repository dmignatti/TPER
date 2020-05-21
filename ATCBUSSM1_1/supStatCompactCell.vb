Public Class supStatCompactCell

  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_CountIn As supStatCount
  Private m_CountOut As supStatCount
  Private m_intDayGap As Integer
  Private m_intHourGap As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime, ByVal intDayGap As Integer, ByVal intHourGap As Integer)

    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    m_intDayGap = intDayGap
    m_intHourGap = intHourGap
    m_CountIn = New supStatCount
    m_CountOut = New supStatCount

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property DateBegin() As DateTime
    Get
      Return m_dtmDateBegin
    End Get
  End Property

  Public ReadOnly Property DateEnd() As DateTime
    Get
      Return m_dtmDateEnd
    End Get
  End Property

  Public ReadOnly Property DayGap() As Integer
    Get
      Return m_intDayGap
    End Get
  End Property

  Public ReadOnly Property HourGap() As Integer
    Get
      Return m_intHourGap
    End Get
  End Property

  Public ReadOnly Property CountIn() As supStatCount
    Get
      Return m_CountIn
    End Get
  End Property

  Public ReadOnly Property CountOut() As supStatCount
    Get
      Return m_CountOut
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Function Get_DeltaIn(ByVal decOverallIn As Decimal) As Decimal
    'Return supFunction.GetDelta(Get_DayAverageIn, decOverallIn)
    Return supFunction.GetDelta(m_CountIn.Value, decOverallIn)
  End Function

  Public Function Get_DeltaOut(ByVal decOverallOut As Decimal) As Decimal
    'Return supFunction.GetDelta(Get_DayAverageOut, decOverallOut)
    Return supFunction.GetDelta(m_CountOut.Value, decOverallOut)
  End Function

  Public Function Get_StrDeltaIn(ByVal decOverallIn As Decimal) As String
    'Return supFunction.GetStringDelta(Get_DayAverageIn, decOverallIn)
    Return supFunction.GetStringDelta(m_CountIn.Value, decOverallIn)
  End Function

  Public Function Get_StrDeltaOut(ByVal decOverallOut As Decimal) As String
    'Return supFunction.GetStringDelta(Get_DayAverageOut, decOverallOut)
    Return supFunction.GetStringDelta(m_CountOut.Value, decOverallOut)
  End Function

  Public Function Get_DayAverageIn() As Decimal

    Dim decCount As Decimal = System.Convert.ToDecimal(m_CountIn.Value)
    Return supFunction.Round(decCount / m_intDayGap, 2)

  End Function

  Public Function Get_DayAverageOut() As Decimal

    Dim decCount As Decimal = System.Convert.ToDecimal(m_CountOut.Value)
    Return supFunction.Round(decCount / m_intDayGap, 2)

  End Function

  Public Function Get_HourAverageIn() As Decimal

    Dim decCount As Decimal = System.Convert.ToDecimal(m_CountIn.Value)
    Return supFunction.Round(decCount / (m_intDayGap * m_intHourGap), 2)

  End Function

  Public Function Get_HourAverageOut() As Decimal

    Dim decCount As Decimal = System.Convert.ToDecimal(m_CountOut.Value)
    Return supFunction.Round(decCount / (m_intDayGap * m_intHourGap), 2)

  End Function

End Class
