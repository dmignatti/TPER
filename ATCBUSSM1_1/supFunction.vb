Imports System.Data.SqlClient

Public Class supFunction

  Public Enum supDateFormatEnum As Integer
    dfeShortDate
    dfeStandard
    dfeLongDate
    dfeDateTime
    dfeDateHourMin
  End Enum

  Public Enum supMonthNameEnum As Integer
    mneShortName
    mneStandard
  End Enum

  Public Enum supWeekdayNameEnum As Integer
    wneShortName
    wneStandard
  End Enum

  'Public Shared Function FillReader(ByRef dr As System.Data.SqlClient.SqlDataReader, ByVal strCnnString As String, ByVal sSqlQuery As String, ByRef OpenCnn As SqlConnection) As Boolean

  '  Dim cnn As System.Data.SqlClient.SqlConnection
  '  Dim cmd As System.Data.SqlClient.SqlCommand

  '  Try
  '    cnn = New System.Data.SqlClient.SqlConnection(strCnnString)
  '    cnn.Open()
  '    cmd = New System.Data.SqlClient.SqlCommand(sSqlQuery, cnn)
  '    dr = cmd.ExecuteReader()
  '    cmd.Dispose()
  '    OpenCnn = cnn
  '    Return True
  '  Catch ex As Exception
  '    Return False
  '  End Try
  '  cnn.Close()
  '  cnn.Dispose()

  'End Function

  Public Shared Function Round(ByVal decValue As Decimal, ByVal intDecimals As Integer) As Decimal

    Dim i, intFactor, intSign As Integer
    Dim decBroken As Decimal

    ' decValue è sempre positivo!!!
    intSign = Math.Sign(decValue)
    decValue = Math.Abs(decValue)

    ' Calcolo il fattore con un loop perché la funzione 
    ' potenza è più lenta della moltiplicazione.
    intFactor = 1
    For i = 1 To intDecimals
      intFactor = intFactor * 10
    Next

    ' Assicuro che decValue abbia una sola cifra dopo la virgola.
    decValue = Int(decValue * intFactor * 10) / 10

    ' Prendo parte decimale e parte intera.
    decBroken = (decValue - Int(decValue)) * 10
    decValue = Int(decValue)

    ' Arrotondamento.
    If (decBroken > 5) Then
      decValue = decValue + 1
    End If

    ' Riporto il valore al suo ordine di grandezza.
    decValue = decValue / intFactor

    Return (intSign * decValue)

  End Function

  Public Shared Function sqlDate121(ByVal dtmValue As DateTime) As String

    Return FormatNumber(dtmValue.Year, 4) & "-" & FormatNumber(dtmValue.Month, 2) & "-" & FormatNumber(dtmValue.Day, 2) & " " & _
           FormatNumber(dtmValue.Hour, 2) & ":" & FormatNumber(dtmValue.Minute, 2) & ":" & FormatNumber(dtmValue.Second, 2)

  End Function

  Public Shared Function sqlDate112(ByVal dtmValue As DateTime) As String
    Return FormatNumber(dtmValue.Year, 4) & FormatNumber(dtmValue.Month, 2) & FormatNumber(dtmValue.Day, 2)
  End Function

  Public Shared Function sqlMoney(ByVal decValue As Decimal) As String
    Return CStr(Round(decValue, 2)).Replace(",", ".")
  End Function

  Public Shared Function sqlDouble(ByVal dblValue As Double) As String

    Dim decvalue As Decimal = System.Convert.ToDecimal(dblValue)
    Return CStr(Round(decvalue, 2)).Replace(",", ".")

  End Function

  Public Shared Function FormatNumber(ByVal intNumber As Integer, ByVal intLenght As Integer) As String

    Dim i As Integer
    Dim sTemp As String = intNumber.ToString

    Do While (sTemp.Length < intLenght)
      sTemp = "0" & sTemp
    Loop

    Return sTemp

  End Function

  Public Shared Function FormatDate(ByVal dtmDate As DateTime, ByVal intFormat As supDateFormatEnum) As String

    Select Case intFormat
      Case supDateFormatEnum.dfeShortDate
        Return FormatNumber(dtmDate.Day, 2) & "/" & FormatNumber(dtmDate.Month, 2) & "/" & Right(dtmDate.Year.ToString, 2)
      Case supDateFormatEnum.dfeStandard
        Return FormatNumber(dtmDate.Day, 2) & "/" & FormatNumber(dtmDate.Month, 2) & "/" & FormatNumber(dtmDate.Year, 4)
      Case supDateFormatEnum.dfeLongDate
        Return FormatNumber(dtmDate.Day, 2) & " " & MonthName(dtmDate.Month, supMonthNameEnum.mneShortName) & " " & FormatNumber(dtmDate.Year, 4)
      Case supDateFormatEnum.dfeDateTime
        Return FormatNumber(dtmDate.Day, 2) & "/" & FormatNumber(dtmDate.Month, 2) & "/" & FormatNumber(dtmDate.Year, 4) & " " & FormatNumber(dtmDate.Hour, 2) & ":" & FormatNumber(dtmDate.Minute, 2) & ":" & FormatNumber(dtmDate.Second, 2)
      Case supDateFormatEnum.dfeDateHourMin
        Return FormatNumber(dtmDate.Day, 2) & "/" & FormatNumber(dtmDate.Month, 2) & "/" & FormatNumber(dtmDate.Year, 4) & " " & FormatNumber(dtmDate.Hour, 2) & ":" & FormatNumber(dtmDate.Minute, 2)
    End Select

  End Function

  Public Shared Function MonthName(ByVal intMonth As Integer, ByVal Mode As supMonthNameEnum) As String

    Select Case intMonth
      Case 1
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Gennaio", "Gen")
      Case 2
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Febbraio", "Feb")
      Case 3
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Marzo", "Mar")
      Case 4
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Aprile", "Apr")
      Case 5
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Maggio", "Mag")
      Case 6
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Giugno", "Giu")
      Case 7
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Luglio", "Lug")
      Case 8
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Agosto", "Ago")
      Case 9
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Settembre", "Set")
      Case 10
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Ottobre", "Ott")
      Case 11
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Novembre", "Nov")
      Case 12
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Dicembre", "Dic")
      Case Else
        Return IIf(Mode = supMonthNameEnum.mneStandard, "Error", "Err")
    End Select

  End Function

  Public Shared Function MonthNumber(ByVal strMonth As String) As Integer

    If ((strMonth = "Gennaio") Or (strMonth = "Gen")) Then
      Return 1
    ElseIf ((strMonth = "Febbraio") Or (strMonth = "Feb")) Then
      Return 2
    ElseIf ((strMonth = "Marzo") Or (strMonth = "Mar")) Then
      Return 3
    ElseIf ((strMonth = "Aprile") Or (strMonth = "Apr")) Then
      Return 4
    ElseIf ((strMonth = "Maggio") Or (strMonth = "Mag")) Then
      Return 5
    ElseIf ((strMonth = "Giugno") Or (strMonth = "Giu")) Then
      Return 6
    ElseIf ((strMonth = "Luglio") Or (strMonth = "Lug")) Then
      Return 7
    ElseIf ((strMonth = "Agosto") Or (strMonth = "Ago")) Then
      Return 8
    ElseIf ((strMonth = "Settembre") Or (strMonth = "Set")) Then
      Return 9
    ElseIf ((strMonth = "Ottobre") Or (strMonth = "Ott")) Then
      Return 10
    ElseIf ((strMonth = "Novembre") Or (strMonth = "Nov")) Then
      Return 11
    ElseIf ((strMonth = "Dicembre") Or (strMonth = "Dic")) Then
      Return 12
    Else
      Return 0
    End If

  End Function

  Public Shared Function WeekdayName(ByVal dtmDay As DateTime, ByVal Mode As supWeekdayNameEnum) As String

    Select Case dtmDay.DayOfWeek
      Case DayOfWeek.Monday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Lunedì", "LUN")
      Case DayOfWeek.Tuesday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Martedì", "MAR")
      Case DayOfWeek.Wednesday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Mercoledì", "MER")
      Case DayOfWeek.Thursday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Giovedì", "GIO")
      Case DayOfWeek.Friday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Venerdì", "VEN")
      Case DayOfWeek.Saturday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Sabato", "SAB")
      Case DayOfWeek.Sunday
        Return IIf(Mode = supWeekdayNameEnum.wneStandard, "Domenica", "DOM")
    End Select

  End Function

  Public Overloads Shared Sub Fill_DllMonth(ByVal ddl As System.Web.UI.WebControls.DropDownList)

    Dim i, intMonth As Integer

    ddl.Items.Clear()
    For i = 0 To 11
      intMonth = i + 1
      ddl.Items.Add(MonthName(intMonth, supMonthNameEnum.mneStandard))
    Next

  End Sub

  Public Overloads Shared Sub Fill_DllMonth(ByVal ddl As System.Web.UI.WebControls.DropDownList, ByVal intSelMonth As Integer)

    Dim i, intMonth As Integer

    ddl.Items.Clear()
    For i = 0 To 11
      intMonth = i + 1
      ddl.Items.Add(MonthName(intMonth, supMonthNameEnum.mneStandard))
      If (intMonth = intSelMonth) Then
        ddl.SelectedIndex = i
      End If
    Next

  End Sub

  Public Shared Function FormatEuro(ByVal decMoney As Decimal, ByVal btnSymbol As Boolean) As String

    If btnSymbol Then
      Return "€ " & FormatIntMoney(decMoney) & "," & FormatCentMoney(decMoney)
    Else
      Return FormatIntMoney(decMoney) & "," & FormatCentMoney(decMoney)
    End If

  End Function

  Public Shared Function GUIFormatPesoPC(ByVal dblValue As Double) As String

    Dim intIntPart, intDecPart As Integer
    Dim strIntPart, strDecPart As String

    intIntPart = Int(dblValue)
    intDecPart = Int((dblValue - intIntPart) * 100)

    strIntPart = CStr(intIntPart)
    If (Len(strIntPart) < 2) Then
      strIntPart = "0" & strIntPart
    ElseIf (Len(strIntPart) > 2) Then
      Throw New Exception("Il peso di un veicolo non può essere superiore a 9999 kg")
    End If

    strDecPart = CStr(intDecPart)
    If (Len(strDecPart) < 2) Then
      strDecPart = strDecPart & "0"
    End If

    Return strIntPart & "," & strDecPart

  End Function

  Public Shared Function FormatIntMoney(ByVal decMoney As Decimal) As String

    ' Formattazione euro.
    Dim strTemp As String = Int(decMoney).ToString
    Dim strEuro As String = ""

    strTemp = StrReverse(strTemp)
    Do While (strTemp.Length > 3)
      strEuro = strEuro & Mid(strTemp, 1, 3) & "."
      strTemp = Mid(strTemp, 4)
    Loop
    strEuro = strEuro & strTemp
    strEuro = StrReverse(strEuro)

    Return strEuro

  End Function

  Public Shared Function FormatCentMoney(ByVal decMoney As Decimal) As String

    ' Formattazione centesimi.
    Dim strCents As String = System.Convert.ToInt32(Round(decMoney - Int(decMoney), 2) * 100).ToString
    If (strCents.Length = 1) Then
      strCents = "0" & strCents
    End If

    Return strCents

  End Function

  Public Shared Function FormatInteger(ByVal intValue As Integer) As String
    Return FormatIntMoney(System.Convert.ToDecimal(intValue))
  End Function

  Public Shared Function FormatDecimal(ByVal decValue As Decimal) As String
    Return FormatEuro(decValue, False)
  End Function

  Public Shared Function IsDecimal(ByVal strValue As String) As Boolean

    Dim i As Integer

    Dim chrArr() As Char = strValue.ToCharArray()

    Dim intMaxCount As Integer = strValue.Length
    Dim intSepCount As Integer = 0
    Dim intDigitCount As Integer = 0

    For i = 0 To (intMaxCount - 1)
      If Char.IsDigit(chrArr(i)) Then
        intDigitCount = intDigitCount + 1
      Else
        If (chrArr(i) = ",") Then
          intSepCount = intSepCount + 1
        End If
      End If
    Next
    If (intDigitCount + intSepCount = intMaxCount) Then
      If (intDigitCount < intMaxCount) Then
        Return (intSepCount = 1)
      Else
        Return True
      End If
    Else
      Return False
    End If

  End Function

  Public Shared Function IsMoney_Euro(ByVal strValue As String) As Boolean

    Dim i As Integer

    ' Elimino eventuali separatori di migliaia.
    'strValue = strValue.Replace(".", "")

    ' Controllo che la stringa sia ben formata.
    strValue = strValue.Trim

    Dim intMaxCount As Integer = strValue.Length
    Dim intSepCount As Integer = 0
    Dim intDigitCount As Integer = 0
    Dim chrArr() As Char = strValue.ToCharArray()

    For i = 0 To (intMaxCount - 1)
      If Char.IsDigit(chrArr(i)) Then
        intDigitCount = intDigitCount + 1
      Else
        If (chrArr(i) = ",") Then
          intSepCount = intSepCount + 1
        End If
      End If
    Next
    Dim blnWellBuilt As Boolean
    If (intDigitCount + intSepCount = intMaxCount) Then
      If (intDigitCount < intMaxCount) Then
        If (intSepCount = 1) Then
          blnWellBuilt = True
        Else
          Throw New System.Exception("Un importo valido può contenere un separatore soltanto.")
          blnWellBuilt = False
        End If
      Else
        blnWellBuilt = True
      End If
    Else
      Throw New System.Exception("Un importo valido può contenere soltanto cifre ed un separatore.")
      blnWellBuilt = False
    End If
    ' Se la stringa è ben formata ...
    If blnWellBuilt Then
      Dim intPosition As Integer
      Dim decTemp As Decimal
      intPosition = InStr(1, strValue, ",")
      If (intPosition < 1) Then
        If (strValue.Length = 0) Then
          Throw New System.Exception("Una stringa nulla non può essere considerata un importo valido.")
          Return False
        Else
          Return True
        End If
      Else
        If (strValue.Length = 1) Then
          Throw New System.Exception("La stringa ',' non può essere considerata un importo valido.")
          Return False
        Else
          If (intPosition = strValue.Length) Then
            Return True
          Else
            If (Len(Mid(strValue, intPosition + 1)) = 2) Then
              Return True
            Else
              Throw New System.Exception("E' possibile specificare soltanto due decimali.")
              Return False
            End If
          End If
        End If
      End If
    Else
      Return False
    End If

  End Function

  Public Shared Function ToMoney_Euro(ByVal strValue As String) As Decimal

    Dim decTemp, decInt, decDec As Decimal

    strValue = strValue.Trim()

    If IsMoney_Euro(strValue) Then
      Dim intPosition = InStr(1, strValue, ",")
      If (intPosition < 1) Then
        decTemp = System.Convert.ToDecimal(strValue)
      ElseIf (intPosition = 1) Then
        decTemp = System.Convert.ToDecimal(Mid(strValue, 2)) / 100
        decTemp = Decimal.Truncate(decTemp * 100) / 100
      Else
        If (intPosition = strValue.Length) Then
          decTemp = System.Convert.ToDecimal(Mid(strValue, 1, intPosition - 1))
        Else
          decInt = System.Convert.ToDecimal(Mid(strValue, 1, intPosition - 1))
          decDec = System.Convert.ToDecimal(Mid(strValue, intPosition + 1))
          decDec = decDec / 100
          decDec = Int(decDec * 100)
          decDec = decDec / 100
          decTemp = decInt + decDec
        End If
      End If
      Return decTemp
    Else
      Return 0
    End If

  End Function

  Public Shared Function ToDouble(ByVal strValue As String) As Double

    Dim strSep As String = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator

    If IsDecimal(strValue) Then
      strValue = strValue.Replace(",", strSep)
      Return System.Convert.ToDouble(strValue)
    Else
      Return 0
    End If

  End Function

  Public Shared Function GetDelta(ByVal decNumerator As Decimal, ByVal decDenominator As Decimal) As Decimal

    Dim intSign As Integer
    Dim decDelta As Decimal

    If (decDenominator = 0) Then
      Return 0
    Else
      decDelta = (decNumerator / decDenominator) * 100 - 100
      decDelta = supFunction.Round(decDelta, 2)
      Return decDelta
    End If

  End Function

  Public Shared Function GetStringDelta(ByVal decNumerator As Decimal, ByVal decDenominator As Decimal) As String

    Dim decTemp As Decimal = GetDelta(decNumerator, decDenominator)

    If (decTemp >= 0) Then
      Return "+" & Math.Abs(decTemp).ToString & "%"
    Else
      Return "-" & Math.Abs(decTemp).ToString & "%"
    End If

  End Function

  Public Shared Function GetSectionID(ByVal strSectionDesc As String) As Integer

    Dim intSectionID As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "Sect_ID " & _
             "FROM " & _
                  "Tabl_Section " & _
             "WHERE " & _
                  "Sect_Desc = '" & strSectionDesc.Replace("'", "''").Trim & "'"

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
        intSectionID = dr.GetInt32(0)
        dr.Close()
      Else
        dr.Close()
        Throw New Exception("")
      End If
    Catch ex As Exception
      Throw New Exception("Impossibile reperire la sezione comandi.")
    Finally
      cmd.Dispose()
      cnn.Close()
      cnn.Dispose()
    End Try

    Return intSectionID

  End Function

  'Public Shared Sub WriteLog(ByVal strInput As String, ByVal strOutput As String, ByVal decOutput As Decimal)

  '  'Dim sSql As String
  '  'Dim tr As New supTransaction

  '  'sSql = "INSERT INTO Prova " & _
  '  '            "(strInput, strOutput, decOut)" & _
  '  '       "VALUES " & _
  '  '            "('" & strInput & "', '" & strOutput & "', " & sqlMoney(decOutput) & ")"
  '  'tr.SqlCommands.Add(sSql)
  '  'tr.Execute()

  'End Sub

  Public Shared Sub Fill_ddlVehicleType(ByRef ddl As DropDownList)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()
    ddl.Items.Add("*")
    ddl.Items(0).Value = 0

    strSql = "SELECT " & _
                  "TiMe_PK, TiMe_Desc " & _
             "FROM " & _
                  "Angr_TipoMezzo " & _
             "ORDER BY " & _
                  "TiMe_Desc"

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
          ddl.Items.Add(dr.GetString(1))
          ddl.Items(ddl.Items.Count - 1).Value = dr.GetInt32(0)
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

  Public Shared Sub Fill_ddlVehicleMark(ByRef ddl As DropDownList, ByVal intFK_TiMe As Integer)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()
    ddl.Items.Add("*")
    ddl.Items(0).Value = 0

    strSql = "SELECT " & _
                  "MaMe_PK, MaMe_Desc " & _
             "FROM " & _
                  "Angr_MarcaMezzo " & _
             "WHERE " & _
                  "MaMe_FK_TiMe = " & CStr(intFK_TiMe) & " " & _
             "ORDER BY " & _
                  "MaMe_Desc"

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
          ddl.Items.Add(dr.GetString(1))
          ddl.Items(ddl.Items.Count - 1).Value = dr.GetInt32(0)
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

  Public Shared Sub Fill_ddlVehicleModel(ByRef ddl As DropDownList, ByVal intFK_TiMe As Integer, ByVal intFK_MaMe As Integer)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()
    ddl.Items.Add("*")
    ddl.Items(0).Value = 0

    strSql = "SELECT " & _
                  "MoMe_PK, MoMe_Desc " & _
             "FROM " & _
                  "Angr_ModelloMezzo " & _
             "WHERE " & _
                  "MoMe_FK_TiMe = " & CStr(intFK_TiMe) & " AND " & _
                  "MoMe_FK_MaMe = " & CStr(intFK_MaMe) & " " & _
             "ORDER BY " & _
                  "MoMe_Desc"

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
          ddl.Items.Add(dr.GetString(1))
          ddl.Items(ddl.Items.Count - 1).Value = dr.GetInt32(0)
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

  Public Overloads Shared Function DecodeDate(ByVal strDateValue As String) As DateTime

    Dim intDay, intMonth, intYear As Integer
    Try
      intDay = System.Convert.ToInt32(Mid(strDateValue, 1, 2))
      intMonth = System.Convert.ToInt32(Mid(strDateValue, 4, 2))
      intYear = System.Convert.ToInt32(Mid(strDateValue, 7, 4))
      Return New DateTime(intYear, intMonth, intDay)
    Catch ex As Exception
      Throw New Exception("Impossibile convertire la stringa in data.")
    End Try

  End Function

  Public Overloads Shared Function DecodeDate(ByVal strDateValue As String, ByVal strTimeValue As String) As DateTime

    Dim intDay, intMonth, intYear, intHour, intMinute As Integer
    Try
      intDay = System.Convert.ToInt32(Mid(strDateValue, 1, 2))
      intMonth = System.Convert.ToInt32(Mid(strDateValue, 4, 2))
      intYear = System.Convert.ToInt32(Mid(strDateValue, 7, 4))
      intHour = System.Convert.ToInt32(Mid(strTimeValue, 1, 2))
      intMinute = System.Convert.ToInt32(Mid(strTimeValue, 4, 2))
      Return New DateTime(intYear, intMonth, intDay, intHour, intMinute, 0)
    Catch ex As Exception
      Throw New Exception("Impossibile convertire la stringa in data.")
    End Try

  End Function

  Public Shared Sub FillDdlGDATCUser(ByRef ddl As DropDownList, ByVal blnAddItemAll As Boolean, ByVal blnNullItem As Boolean)

    Dim strSql, strUserName, strUserPK As String
    Dim litem As ListItem
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()

    If blnAddItemAll Then
      litem = New ListItem("Tutti gli utenti", "0")
      ddl.Items.Add(litem)
    Else
      If blnNullItem Then
        litem = New ListItem(" ", "0")
        ddl.Items.Add(litem)
      End If
    End If

    strSql = "SELECT " & _
                  "* " & _
             "FROM " & _
                  "Angr_User " & _
             "ORDER BY " & _
                  "User_LastName, User_FirstName, User_LoginName"

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
          strUserName = System.Convert.ToString(dr("User_LastName")) & " " & _
                        System.Convert.ToString(dr("User_FirstName")) & " " & _
                        "(" & System.Convert.ToString(dr("User_LoginName")) & ")"
          strUserPK = System.Convert.ToString(dr("User_PK"))
          litem = New ListItem(strUserName, strUserPK)
          ddl.Items.Add(litem)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento degli utenti.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    ddl.SelectedIndex = 0

  End Sub

  Public Shared Sub FillDdlGDATCPagamento(ByRef ddl As DropDownList, ByVal blnNullItem As Boolean)

    Dim strSql As String
    Dim litem As ListItem
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()
    If blnNullItem Then
      litem = New ListItem(" ", "0")
      ddl.Items.Add(litem)
    End If

    strSql = "SELECT " & _
                  "MoPa_PK, MoPa_Desc " & _
             "FROM " & _
                  "Angr_ModalitaPagamento " & _
             "ORDER BY " & _
                  "MoPa_Desc"

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
          litem = New ListItem(System.Convert.ToString(dr("MoPa_Desc")), System.Convert.ToString(dr("MoPa_PK")))
          ddl.Items.Add(litem)
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento delle modalita di pagamento.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

    ddl.SelectedIndex = 0

  End Sub

  Public Shared Sub FillDdlGDATCTipoDocumento(ByRef ddl As DropDownList, ByVal blnNullItem As Boolean)

    Dim strSql As String
    Dim litem As ListItem
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    ddl.Items.Clear()
    If blnNullItem Then
      litem = New ListItem(" ", "0")
      ddl.Items.Add(litem)
    End If

    strSql = "SELECT " & _
                  "TiDo_PK, TiDo_Desc " & _
             "FROM " & _
                  "Angr_TipoDocumento " & _
             "ORDER BY " & _
                  "TiDo_Desc"

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
          litem = New ListItem(System.Convert.ToString(dr("TiDo_Desc")), System.Convert.ToString(dr("TiDo_PK")))
          ddl.Items.Add(litem)
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

    ddl.SelectedIndex = 0

  End Sub

End Class
