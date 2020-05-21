Public Class supGDATCSessionDay

  Private m_dtmDay As DateTime
  Private m_Rs As supGDATCSessionRecordset

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime)

    m_dtmDay = dtmDay
    m_Rs = New supGDATCSessionRecordset

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Public ReadOnly Property Day() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

  Public ReadOnly Property Recordset() As supGDATCSessionRecordset
    Get
      Return m_Rs
    End Get
  End Property

  Public ReadOnly Property Total_BancRimz() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim record As supGDATCSessionRecord
      For Each record In m_Rs
        decTotal = decTotal + record.BancRimz
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_BancInfr() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim record As supGDATCSessionRecord
      For Each record In m_Rs
        decTotal = decTotal + record.BancInfr
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_CashRimz() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim record As supGDATCSessionRecord
      For Each record In m_Rs
        decTotal = decTotal + record.CashRimz
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total_CashInfr() As Decimal
    Get
      Dim decTotal As Decimal = 0
      Dim record As supGDATCSessionRecord
      For Each record In m_Rs
        decTotal = decTotal + record.CashInfr
      Next
      Return decTotal
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return Total_BancRimz + Total_BancInfr + Total_CashRimz + Total_CashInfr
    End Get
  End Property

End Class
