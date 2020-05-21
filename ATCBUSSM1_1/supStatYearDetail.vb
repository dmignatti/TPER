Imports System.Data.SqlClient

Public Class supStatYearDetail

  Private m_intYear As Integer
  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime
  Private m_intDayCount As Integer
  Private m_intTotalIn As Integer
  Private m_intTotalOut As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    m_intYear = dtmDateBegin.Year
    m_dtmDateBegin = dtmDateBegin
    m_dtmDateEnd = dtmDateEnd
    m_intDayCount = DateDiff(DateInterval.Day, m_dtmDateBegin, m_dtmDateEnd) + 1
    m_intTotalIn = 0
    m_intTotalOut = 0

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Year() As Integer
    Get
      Return m_intYear
    End Get
  End Property

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

  Public ReadOnly Property DayCount() As Integer
    Get
      Return m_intDayCount
    End Get
  End Property

  Public Property TotalIn() As Integer
    Get
      Return m_intTotalIn
    End Get
    Set(ByVal Value As Integer)
      m_intTotalIn = Value
    End Set
  End Property

  Public Property TotalOut() As Integer
    Get
      Return m_intTotalOut
    End Get
    Set(ByVal Value As Integer)
      m_intTotalOut = Value
    End Set
  End Property

  Public ReadOnly Property AverageIn() As Decimal
    Get
      Dim decTotal As Decimal = System.Convert.ToDecimal(m_intTotalIn)
      Dim decAvg As Decimal
      If (m_intDayCount > 0) Then
        Return supFunction.Round(decTotal / m_intDayCount, 2)
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property AverageOut() As Decimal
    Get
      Dim decTotal As Decimal = System.Convert.ToDecimal(m_intTotalOut)
      Dim decAvg As Decimal
      If (m_intDayCount > 0) Then
        Return supFunction.Round(decTotal / m_intDayCount, 2)
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property DeltaIn() As String
    Get
      Dim intPrevTotalIn As Integer = pFetchTotalIn(m_dtmDateBegin.AddYears(-1), m_dtmDateEnd.AddYears(-1))
      Return supFunction.GetStringDelta(m_intTotalIn, intPrevTotalIn)
    End Get
  End Property

  Public ReadOnly Property DeltaOut() As String
    Get
      Dim intPrevTotalOut As Integer = pFetchTotalOut(m_dtmDateBegin.AddYears(-1), m_dtmDateEnd.AddYears(-1))
      Return supFunction.GetStringDelta(m_intTotalOut, intPrevTotalOut)
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Function GetComparison() As supStatYearDetail

    Dim dtmDateBegin As DateTime = m_dtmDateBegin.AddYears(-1)
    Dim dtmDateEnd As DateTime = m_dtmDateEnd.AddYears(-1)
    Dim det As New supStatYearDetail(dtmDateBegin, dtmDateEnd)
    det.TotalIn = pFetchTotalIn(dtmDateBegin, dtmDateEnd)
    det.TotalOut = pFetchTotalOut(dtmDateBegin, dtmDateEnd)
    Return det

  End Function

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Function pFetchTotalIn(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime) As Integer

    Dim intTotal As Integer
    Dim strSql As String

    strSql = "SELECT " & _
                  "Count(*) XTotal " & _
             "FROM " & _
                  "Tabl_Rimozione " & _
             "WHERE " & _
                  "Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBegin) & "', 121) AND " & _
                  "Rimz_DataIngresso <= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateEnd) & "', 121)"
    intTotal = pGetCount(strSql)

    Return intTotal

  End Function

  Private Function pFetchTotalOut(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime) As Integer

    Dim intTotal As Integer
    Dim strSql As String

    strSql = "SELECT " & _
                  "Count(*) XTotal " & _
             "FROM " & _
                  "Tabl_Rimozione " & _
             "WHERE " & _
                  "Rimz_DataUscita >= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBegin) & "', 121) AND " & _
                  "Rimz_DataUscita <= CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateEnd) & "', 121) AND " & _
                  "NOT (Rimz_DataUscita IS NULL) AND " & _
                  "Rimz_Stato <> 'DML' AND " & _
                  "Rimz_Stato <> 'RBT'"
    intTotal = pGetCount(strSql)

    Return intTotal

  End Function

  Private Function pGetCount(ByVal strSql As String) As Integer

    Dim intRC As Integer
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

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
        dr.Read()
        intRC = System.Convert.ToInt32(dr("XTotal"))
      Else
        intRC = 0
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    Return intRC

  End Function

End Class
