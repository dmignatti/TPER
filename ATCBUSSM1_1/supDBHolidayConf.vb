Public Class supDBHolidayConf

  Private m_intYear As Integer
  Private m_Holds As supDBHolidays

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal intYear As Integer)

    m_intYear = intYear
    m_Holds = New supDBHolidays(m_intYear)

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Year() As Integer
    Get
      Return m_intYear
    End Get
  End Property

  Public ReadOnly Property Easter() As DateTime
    Get
      Return GetEaster(m_intYear)
    End Get
  End Property

  Public ReadOnly Property Holidays() As supDBHolidays
    Get
      Return m_Holds
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Function Fetch() As Boolean
    Return m_Holds.Fetch()
  End Function

  Public Function FetchCount() As Integer
    Return m_Holds.FetchCount()
  End Function

  Public Function Save() As Boolean

    Dim i As Integer
    Dim tr As New supTransactionCnn
    Dim tmpHold As supDBHoliday
    Dim OldHolds As New supDBHolidays(m_intYear)

    OldHolds.Fetch()
    ' Prima aggiungo i nuovi item ed aggiorno quelli modificati ...
    For i = 0 To m_Holds.UBound
      tmpHold = OldHolds(m_Holds(i).Day)
      If (tmpHold Is Nothing) Then
        tr.SqlCommands.Add(m_Holds(i).SqlInsert)
      Else
        If Not tmpHold.Equals(m_Holds(i)) Then
          tr.SqlCommands.Add(m_Holds(i).SqlUpdate)
        End If
      End If
    Next
    ' ... poi cancello gli item non riconfermati.
    For i = 0 To OldHolds.UBound
      tmpHold = m_Holds(OldHolds(i).Day)
      If (tmpHold Is Nothing) Then
        tr.SqlCommands.Add(OldHolds(i).SqlDelete)
      End If
    Next

    Return tr.Execute()

  End Function

  ' ***********************************************************************************************
  '     PUBLIC SHARED METHODS
  ' ***********************************************************************************************
  Public Shared Function GetEaster(ByVal intYear As Integer) As DateTime

    Dim a, b, c, d, e, f, g, h, i, j, k, l As Integer
    Dim intMonth, intDay As Integer
    Dim dtmEster As Date

    Try
      a = intYear Mod 19
      b = intYear \ 100
      c = intYear Mod 100
      d = b \ 4
      e = b Mod 4
      f = (b + 8) \ 25
      g = (b - f + 1) \ 3
      h = (19 * a + b - d - g + 15) Mod 30
      i = c \ 4
      j = c Mod 4
      k = (32 + 2 * e + 2 * i - h - j) Mod 7
      l = (a + 11 * h + 22 * k) \ 451
      intMonth = (h + k - 7 * l + 114) \ 31
      intDay = ((h + k - 7 * l + 114) Mod 31) + 1
      dtmEster = New DateTime(intYear, 1, 1)
      dtmEster = dtmEster.AddMonths(intMonth - 1).AddDays(intDay - 1)
      Return dtmEster
    Catch ex As Exception
      Return Nothing
    End Try

  End Function

End Class
