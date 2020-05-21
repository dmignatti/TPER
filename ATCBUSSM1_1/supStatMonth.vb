Imports System.Data.SqlClient

Public Class supStatMonth

  Private m_Items As supStatMonthEntries

  ' ***********************************************************************************************
  '     CREATION METHODS
  ' ***********************************************************************************************
  Public Sub New()
    m_Items = New supStatMonthEntries
  End Sub

  ' ***********************************************************************************************
  '     PROPERTIES
  ' ***********************************************************************************************
  Public ReadOnly Property Items() As supStatMonthEntries
    Get
      Return m_Items
    End Get
  End Property

  ' ***********************************************************************************************
  '     PUBLIC METHODS
  ' ***********************************************************************************************
  Public Sub Refresh()

    Dim intYear, intMonth, intFlag, intTotal As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "XYear, XMonth, XFlag, SUM(Total) XTotal " & _
             "FROM " & _
                  "(SELECT " & _
                        "XYear, XMonth, XDate, XFlag, COUNT(*) Total " & _
                  "FROM " & _
                        "(SELECT " & _
                              "Year(Rimz_DataIngresso) XYear, Month(Rimz_DataIngresso) XMonth, XDate, (CASE WHEN (YDate IS NULL) THEN 0 ELSE CASE WHEN (XHour < 7) THEN 1 ELSE 0 END END) XFlag " & _
                        "FROM " & _
                              "(SELECT " & _
                                    "*, Year(Rimz_DataIngresso) XYear, Month(Rimz_DataIngresso) XMonth, " & _
                                    "(10000 * Year(Rimz_DataIngresso) + 100 * Month(Rimz_DataIngresso) + Day(Rimz_DataIngresso)) XDate, " & _
                                    "(DATEPART(hh, Rimz_DataIngresso)) XHour " & _
                              "FROM " & _
                                    "Tabl_Rimozione " & _
                              "WHERE " & _
                                    "Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate112(supStatData.DayZero) & "', 112)) X " & _
                              "LEFT OUTER JOIN " & _
                              "(SELECT " & _
                                    "(10000 * Year(CaSe_Data) + 100 * Month(CaSe_Data) + Day(CaSe_Data)) YDate " & _
                              "FROM " & _
                                    "Conf_CalendarioSeabo) Y ON X.XDate = Y.YDate) Z " & _
                        "GROUP BY " & _
                            "XYear, XMonth, XDate, XFlag) A " & _
             "GROUP BY " & _
                  "XYear, XMonth, XFlag " & _
             "ORDER BY " & _
                  "XYear, XMonth, XFlag"

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
          intYear = System.Convert.ToInt32(dr("XYear"))
          intMonth = System.Convert.ToInt32(dr("XMonth"))
          intFlag = System.Convert.ToInt32(dr("XFlag"))
          intTotal = System.Convert.ToInt32(dr("XTotal"))
          If (intFlag = 0) Then
            m_Items(intYear, intMonth).NormalCount = intTotal
          Else
            m_Items(intYear, intMonth).SeaboCount = intTotal
          End If
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore in caricamento Statistiche Mensile Ingressi")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

End Class
