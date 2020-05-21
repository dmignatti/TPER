Public Class supDBHoliday

  Private m_dtmDay As DateTime
  Private m_strDesc As String

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New(ByVal dtmDay As DateTime, ByVal strDesc As String)

    m_dtmDay = dtmDay
    m_strDesc = strDesc

  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Public ReadOnly Property Day() As DateTime
    Get
      Return m_dtmDay
    End Get
  End Property

  Public ReadOnly Property Desc() As String
    Get
      Return m_strDesc
    End Get
  End Property

  Public ReadOnly Property SqlInsert() As String
    Get
      Dim strSql As String
      strSql = "INSERT INTO Conf_Festivita " & _
                  "(Fest_Data, " & _
                  "Fest_Anno, " & _
                  "Fest_Desc) " & _
               "VALUES " & _
                  "(CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDay) & "', 112), " & _
                  m_dtmDay.Year.ToString & ", " & _
                  "'" & m_strDesc.Replace("'", "''") & "')"
      Return strSql
    End Get
  End Property

  Public ReadOnly Property SqlUpdate() As String
    Get
      Dim strSql As String
      strSql = "UPDATE " & _
                  "Conf_Festivita " & _
               "SET " & _
                  "Fest_Desc = '" & m_strDesc.Replace("'", "''") & "' " & _
               "WHERE " & _
                  "Fest_Data = CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDay) & "', 112)"
      Return strSql
    End Get
  End Property

  Public ReadOnly Property SqlDelete() As String
    Get
      Dim strSql As String
      strSql = "DELETE FROM Conf_Festivita " & _
             "WHERE " & _
                  "Fest_Data = CONVERT(datetime, '" & supFunction.sqlDate112(m_dtmDay) & "', 112)"
      Return strSql
    End Get
  End Property

  ' *********************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************
  Public Shadows Function Equals(ByVal hold As supDBHoliday) As Boolean
    Return ((hold.Day = m_dtmDay) And (hold.Desc = m_strDesc))
  End Function

End Class
