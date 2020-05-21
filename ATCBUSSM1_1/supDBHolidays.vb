Imports System.Data.SqlClient

Public Class supDBHolidays
  Inherits System.Collections.CollectionBase

  Private m_intYear As Integer

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal intYear As Integer)

    MyBase.New()
    m_intYear = intYear

  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Year() As Integer
    Get
      Return m_intYear
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supDBHoliday
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal dtmDay As DateTime) As supDBHoliday
    Get
      Dim hold As supDBHoliday
      Dim selhold As supDBHoliday = Nothing
      For Each hold In MyBase.List
        If hold.Day.Equals(dtmDay) Then
          selhold = hold
        End If
      Next
      Return selhold
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return (MyBase.Count - 1)
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Function Add(ByVal dtmDay As DateTime, ByVal strDesc As String) As supDBHoliday

    If (Me.Item(dtmDay) Is Nothing) Then
      Dim hold As New supDBHoliday(dtmDay, strDesc)
      MyBase.List.Add(hold)
    End If

  End Function

  Public Function Fetch() As Boolean

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim dtmDateBegin As DateTime = New DateTime(m_intYear, 1, 1)
    Dim dtmDateEnd As DateTime = New DateTime(m_intYear, 12, 31)

    MyBase.List.Clear()

    strSql = "SELECT " & _
                "Fest_Data, ISNULL(Fest_Desc, '') Fest_Desc " & _
             "FROM " & _
                "Conf_Festivita " & _
             "WHERE " & _
                "Fest_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(dtmDateBegin) & "', 112) AND " & _
                "Fest_Data < CONVERT(datetime, '" & supFunction.sqlDate112(dtmDateEnd.AddDays(1)) & "', 112) " & _
             "ORDER BY " & _
                "Fest_Data"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
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
          Dim hold As New supDBHoliday(System.Convert.ToDateTime(dr("Fest_Data")), System.Convert.ToString(dr("Fest_Desc")))
          MyBase.List.Add(hold)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Impossibile reperire le festività.")
    Finally
      cmd.Dispose()
      cnn.Close()
      cnn.Dispose()
    End Try

  End Function

  Public Function FetchCount() As Integer

    Dim intCount As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim dtmDateBegin As DateTime = New DateTime(m_intYear, 1, 1)
    Dim dtmDateEnd As DateTime = New DateTime(m_intYear, 12, 31)

    strSql = "SELECT " & _
                "COUNT(*) Total " & _
             "FROM " & _
                "Conf_Festivita " & _
             "WHERE " & _
                "Fest_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(dtmDateBegin) & "', 112) AND " & _
                "Fest_Data < CONVERT(datetime, '" & supFunction.sqlDate112(dtmDateEnd.AddDays(1)) & "', 112)"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
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
        intCount = System.Convert.ToInt32(dr("Total"))
      Else
        intCount = 0
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Impossibile reperire le festività.")
    Finally
      cmd.Dispose()
      cnn.Close()
      cnn.Dispose()
    End Try

    Return intCount

  End Function

End Class
