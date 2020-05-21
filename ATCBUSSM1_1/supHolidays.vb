Imports System.Data.SqlClient

Public Class supHolidays
  Inherits System.Collections.CollectionBase

  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New(ByVal dtmDateBegin As DateTime, ByVal dtmDateEnd As DateTime)

    MyBase.New()
    m_dtmDateBegin = New DateTime(dtmDateBegin.Year, dtmDateBegin.Month, dtmDateBegin.Day, 0, 0, 0)
    m_dtmDateEnd = New DateTime(dtmDateEnd.Year, dtmDateEnd.Month, dtmDateEnd.Day, 23, 59, 59)
    InitCollection()

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

  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supHoliday
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal dtmDay As DateTime) As supHoliday
    Get
      Dim hold As supHoliday
      Dim selhold As supHoliday = Nothing
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
      Return MyBase.List.Count - 1
    End Get
  End Property

  ' ***********************************************************************************************
  '     PRIVATE METHODS
  ' ***********************************************************************************************
  Private Sub InitCollection()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "* " & _
             "FROM " & _
                "Conf_Festivita " & _
             "WHERE " & _
                "Fest_Data >= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateBegin) & "', 121) AND " & _
                "Fest_Data <= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateEnd) & "', 121) " & _
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
          Dim hold As New supHoliday(System.Convert.ToDateTime(dr("Fest_Data")))
          MyBase.List.Add(hold)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento dei tipi di documento.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

End Class
