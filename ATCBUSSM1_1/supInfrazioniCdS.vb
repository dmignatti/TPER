Public Class supInfrazioniCdS
  Inherits System.Collections.CollectionBase

  Private m_dtmDataInizio As DateTime
  Private m_dtmDataFine As DateTime

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New()

    MyBase.New()
    m_dtmDataInizio = New DateTime(1900, 1, 1, 0, 0, 0)
    m_dtmDataFine = New DateTime(9999, 12, 31, 23, 59, 59)

  End Sub

  Public Sub New(ByVal dtmDataInizio As DateTime, ByVal dtmDataFine As DateTime)

    MyBase.New()
    m_dtmDataInizio = New DateTime(dtmDataInizio.Year, dtmDataInizio.Month, dtmDataInizio.Day, 0, 0, 0)
    m_dtmDataFine = New DateTime(dtmDataFine.Year, dtmDataFine.Month, dtmDataFine.Day, 23, 59, 59)

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
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

  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supInfrazioneCdS
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal strCodice As String) As supInfrazioneCdS
    Get

      Dim infr As supInfrazioneCdS
      Dim selinfr As supInfrazioneCdS = Nothing

      For Each infr In MyBase.List
        If (infr.Codice = strCodice) Then
          selinfr = infr
          Exit For
        End If
      Next

      Return selinfr

    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.Count - 1)
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Function Add(ByVal intPK As Integer, ByVal strCodice As String, ByVal strArticolo As String, ByVal strDesc As String, ByVal decImporto As Decimal) As supInfrazioneCdS

    Dim infr As New supInfrazioneCdS(intPK, m_dtmDataInizio, m_dtmDataFine)
    infr.Codice = strCodice
    infr.Articolo = strArticolo
    infr.Desc = strDesc
    infr.Importo = decImporto
    MyBase.List.Add(infr)

  End Function

End Class
