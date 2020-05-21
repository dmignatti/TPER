Imports System.Data.SqlClient

Public Class supStatYears

  Private m_Totals As supStatYearDetail
  Private m_Dets As supStatYearDetails

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New()

    m_Dets = New supStatYearDetails
    Refresh()

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Details() As supStatYearDetails
    Get
      Return m_Dets
    End Get
  End Property

  Public ReadOnly Property Totals() As supStatYearDetail
    Get
      Return m_Totals
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub Refresh()

    Dim i As Integer
    Dim intTotalIn As Integer = 0
    Dim intTotalOut As Integer = 0

    Fetch_In()
    Fetch_Out()

    If (m_Dets.UBound > -1) Then
      m_Totals = New supStatYearDetail(m_Dets(0).DateBegin, m_Dets(m_Dets.UBound).DateEnd)
      For i = 0 To m_Dets.UBound
        intTotalIn = intTotalIn + m_Dets(i).TotalIn
        intTotalOut = intTotalOut + m_Dets(i).TotalOut
      Next
      m_Totals.TotalIn = intTotalIn
      m_Totals.TotalOut = intTotalOut
    End If

  End Sub

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Sub Fetch_In()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "Year(Rimz_DataIngresso) XYear, Count(*) XTotal " & _
             "FROM " & _
                  "Tabl_Rimozione " & _
             "WHERE " & _
                  "Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate112(supStatData.DayZero) & "', 112) AND " & _
                  "Rimz_DataIngresso <= CONVERT(datetime, '" & supFunction.sqlDate121(DateTime.Now) & "', 121) " & _
             "GROUP BY " & _
                  "Year(Rimz_DataIngresso) " & _
             "ORDER BY " & _
                  "Year(Rimz_DataIngresso)"

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
          m_Dets.Add(System.Convert.ToInt32(dr("XYear")))
          m_Dets(m_Dets.UBound).TotalIn = System.Convert.ToInt32(dr("XTotal"))
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

  Private Sub Fetch_Out()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "Year(Rimz_DataUscita) XYear, Count(*) XTotal " & _
             "FROM " & _
                  "Tabl_Rimozione " & _
             "WHERE " & _
                  "Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate112(supStatData.DayZero) & "', 112) AND " & _
                  "Rimz_DataIngresso <= CONVERT(datetime, '" & supFunction.sqlDate121(DateTime.Now) & "', 121) AND " & _
                  "NOT (Rimz_DataUscita IS NULL) AND " & _
                  "Rimz_Stato <> 'DML' AND " & _
                  "Rimz_Stato <> 'RBT'" & _
             "GROUP BY " & _
                  "Year(Rimz_DataUscita) " & _
             "ORDER BY " & _
                  "Year(Rimz_DataUscita)"

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
        Dim intYear As Integer
        Dim det As supStatYearDetail
        Do While dr.Read
          intYear = System.Convert.ToInt32(dr("XYear"))
          det = m_Dets.GetItem(intYear)
          If (det Is Nothing) Then
            det = m_Dets.Add(intYear)
          End If
          det.TotalOut = System.Convert.ToInt32(dr("XTotal"))
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

End Class
