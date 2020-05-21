Imports System.Data.SqlClient

Public Class supSeaboMonth
  Inherits System.Collections.CollectionBase

  Private m_intMonth As Integer
  Private m_intYear As Integer
  Private m_dtmDateBegin As DateTime
  Private m_dtmDateEnd As DateTime

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New(ByVal intMonth As Integer, ByVal intYear As Integer)

    MyBase.New()

    Dim i As Integer
    Dim dtmDay As DateTime

    m_intMonth = intMonth
    m_intYear = intYear
    m_dtmDateEnd = New DateTime(m_intYear, m_intMonth, DateTime.DaysInMonth(m_intYear, m_intMonth))
    m_dtmDateBegin = New DateTime(m_intYear, m_intMonth, 1)

    dtmDay = m_dtmDateBegin
    Do While (dtmDay <= m_dtmDateEnd)
      Dim sd As New supSeaboDay(dtmDay)
      MyBase.List.Add(sd)
      dtmDay = dtmDay.AddDays(1)
    Loop

    Fetch()

  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Default Public Overloads ReadOnly Property Item(ByVal dtmDay As DateTime) As supSeaboDay
    Get
      Dim Index As Integer = DateDiff(DateInterval.Day, m_dtmDateBegin, dtmDay)
      Return MyBase.List(Index)
    End Get
  End Property

  Default Public Overloads ReadOnly Property Item(ByVal Index As Integer) As supSeaboDay
    Get
      Return MyBase.List(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return MyBase.List.Count - 1
    End Get
  End Property

  ' *********************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************
  Public Function Save() As Boolean

    Dim i As Integer
    Dim tr As New supTransaction

    For i = 0 To Me.UBound
      tr.SqlCommands.Add(Me.Item(i).SqlCommand)
    Next

    Return tr.Execute()

  End Function

  ' *********************************************************************************************
  '     PRIVATE METHODS
  ' *********************************************************************************************
  Private Sub Fetch()

    Dim dtmDay As DateTime
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                "CaSe_Data " & _
             "FROM " & _
                "Conf_CalendarioSeabo " & _
             "WHERE " & _
                "CaSe_Data >= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateBegin) & "', 112) AND " & _
                "CaSe_Data <= CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDateEnd) & "', 112) " & _
             "ORDER BY " & _
                "CaSe_Data"

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
          dtmDay = System.Convert.ToDateTime(dr("CaSe_Data"))
          If Not (Me.Item(dtmDay) Is Nothing) Then
            Me.Item(dtmDay).Checked = True
          End If
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
