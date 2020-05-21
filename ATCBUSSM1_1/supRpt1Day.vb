Public Class supRpt1Day

  Protected m_dtmDay As DateTime
  Protected m_Sessions As supRpt1Sessions

  Protected m_decTotRimzBanc As Decimal
  Protected m_decTotRimzCash As Decimal
  Protected m_decTotInfrBanc As Decimal
  Protected m_decTotInfrCash As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime)

    m_dtmDay = dtmDay
    m_Sessions = New supRpt1Sessions
    m_decTotRimzBanc = -1
    m_decTotRimzCash = -1
    m_decTotInfrBanc = -1
    m_decTotInfrCash = -1

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property DayValue() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

  Public ReadOnly Property Sessions() As supRpt1Sessions
    Get
      Return m_Sessions
    End Get
  End Property

  Public ReadOnly Property TotRimzBanc() As Decimal
    Get
      If (m_decTotRimzBanc = -1) Then
        getTotal()
      End If
      Return m_decTotRimzBanc
    End Get
  End Property

  Public ReadOnly Property TotRimzCash() As Decimal
    Get
      If (m_decTotRimzCash = -1) Then
        getTotal()
      End If
      Return m_decTotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotInfrBanc() As Decimal
    Get
      If (m_decTotInfrBanc = -1) Then
        getTotal()
      End If
      Return m_decTotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotInfrCash() As Decimal
    Get
      If (m_decTotInfrCash = -1) Then
        getTotal()
      End If
      Return m_decTotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotInfr() As Decimal
    Get
      Return TotInfrBanc + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotRimz() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotBanc() As Decimal
    Get
      Return TotRimzBanc + TotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotCash() As Decimal
    Get
      Return TotRimzCash + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash + TotInfrBanc + TotInfrCash
    End Get
  End Property

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Sub getTotal()

    Dim i As Integer

    m_decTotRimzBanc = 0
    m_decTotRimzCash = 0
    m_decTotInfrBanc = 0
    m_decTotInfrCash = 0

    For i = 0 To m_Sessions.UBound
      m_decTotRimzBanc = m_decTotRimzBanc + m_Sessions(i).TotRimzBanc
      m_decTotRimzCash = m_decTotRimzCash + m_Sessions(i).TotRimzCash
      m_decTotInfrBanc = m_decTotInfrBanc + m_Sessions(i).TotInfrBanc
      m_decTotInfrCash = m_decTotInfrCash + m_Sessions(i).TotInfrCash
    Next

  End Sub

End Class
