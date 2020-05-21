Imports System.Data.SqlClient

Public Class supTarfIntervals
  Inherits System.Collections.CollectionBase

  Public Enum TarfType As Integer
    tteForBollo
    tteForCustodia
    tteForInfrazioniCds
    tteForRimozione
  End Enum

  Private m_blnCanAddNew As Boolean
  Private m_intType As TarfType

  ' ****************************************************************************************
  '     CREATION METHODS
  ' ****************************************************************************************
  Public Sub New(ByVal intType As TarfType)

    MyBase.New()
    m_intType = intType
    Refresh()

  End Sub

  ' ****************************************************************************************
  '     PROPERTIES
  ' ****************************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As supTarfInterval
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Public ReadOnly Property Type() As TarfType
    Get
      Return m_intType
    End Get
  End Property

  Public ReadOnly Property CanAddNew() As Boolean
    Get
      Return m_blnCanAddNew
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.List.Count - 1)
    End Get
  End Property

  ' ****************************************************************************************
  '     PUBLIC METHODS
  ' ****************************************************************************************
  Public Sub Refresh()

    Dim dtmDataInizio, dtmDataFine As DateTime
    Dim ti As supTarfInterval
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Select Case m_intType
      Case TarfType.tteForBollo
        strSql = get_SqlBoll()
      Case TarfType.tteForCustodia
        strSql = get_SqlCust()
      Case TarfType.tteForInfrazioniCds
        strSql = get_SqlInfr()
      Case TarfType.tteForRimozione
        strSql = get_SqlRimz()
    End Select

    m_blnCanAddNew = True

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
    End Try

    cmd = New SqlCommand(strSql, cnn)
    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        Do While dr.Read
          dtmDataInizio = System.Convert.ToDateTime(dr("DataInizio"))
          dtmDataFine = System.Convert.ToDateTime(dr("DataFine"))
          ti = New supTarfInterval(m_intType, dtmDataInizio, dtmDataFine)
          If m_blnCanAddNew Then
            If ti.CanUpdate Then
              m_blnCanAddNew = False
            End If
          End If
          MyBase.List.Add(ti)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  ' ****************************************************************************************
  '     PRIVATE METHODS
  ' ****************************************************************************************
  Private Function get_SqlBoll() As String

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                "Tarf_DataInizio DataInizio, " & _
                "Tarf_DataFine DataFine " & _
             "FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm = 4 " & _
             "ORDER BY " & _
                "Tarf_DataInizio DESC"

    Return strSql

  End Function

  Private Function get_SqlCust() As String

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                "Tarf_DataInizio DataInizio, " & _
                "Tarf_DataFine DataFine " & _
             "FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm IN (5, 6, 7)  " & _
             "ORDER BY " & _
                "Tarf_DataInizio DESC"

    Return strSql

  End Function

  Private Function get_SqlInfr() As String

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                "Infr_DataInizio DataInizio, " & _
                "Infr_DataFine DataFine " & _
             "FROM " & _
                "Angr_Infrazione " & _
             "ORDER BY " & _
                "Infr_DataInizio DESC"

    Return strSql

  End Function

  Private Function get_SqlRimz() As String

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                "Tarf_DataInizio DataInizio, " & _
                "Tarf_DataFine DataFine " & _
             "FROM " & _
                "Tabl_Tariffa " & _
             "WHERE " & _
                "Tarf_FK_CaIm IN (1, 2, 3)  " & _
             "ORDER BY " & _
                "Tarf_DataInizio DESC"

    Return strSql

  End Function

  Private Function GetMaxDataInizio() As DateTime

    Dim dtmMax As DateTime = New DateTime(1990, 1, 1)
    Dim ti As supTarfInterval

    For Each ti In MyBase.List
      If (ti.DataInizio > dtmMax) Then
        dtmMax = ti.DataInizio
      End If
    Next

    Return dtmMax

  End Function

End Class
