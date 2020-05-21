Public Class supTarfInterval

  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime
  Private m_intType As supTarfIntervals.TarfType

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New(ByVal intType As supTarfIntervals.TarfType, ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)
    m_intType = intType

    'm_dtmDataInizio = dtmDataInizio
    'm_dtmDataFine = dtmDataFine

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Public ReadOnly Property CanAppendInfr() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataFine)
    End Get
  End Property

  Public ReadOnly Property CanUpdate() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataInizio)
    End Get
  End Property

  Public ReadOnly Property CanDelete() As Boolean
    Get
      Return (DateTime.Now < m_dtmDataInizio)
    End Get
  End Property

  Public ReadOnly Property DataInizio() As DateTime
    Get
      Return m_dtmDataInizio
    End Get
  End Property

  Public ReadOnly Property DataFine() As DateTime
    Get
      Return m_dtmDataFine
    End Get
  End Property

  Public ReadOnly Property State() As String
    Get
      If CanAppendInfr Then
        If CanUpdate Then
          Return "Mai applicato"
        Else
          Return "In vigore"
        End If
      Else
        Return "Scaduto"
      End If
    End Get
  End Property

  Public ReadOnly Property Type() As supTarfIntervals.TarfType
    Get
      Return m_intType
    End Get
  End Property

End Class
