Imports System.Data.SqlClient

Public Class supTblDamages

  Protected Const m_kstrCheckBoxNameRoot As String = "chkDamage_"

  ' *******************************************************************************************
  '     PUBLIC SHARED METHODS
  ' *******************************************************************************************
  Public Shared Sub FillTable(ByRef tbl As Table, ByVal strDmgString As String)

    Dim i, intPK, intFK_CaDa As Integer
    Dim intRowCount(2) As Integer
    Dim blnChecked As Boolean
    Dim strDesc As String
    Dim ds As DataSet
    Dim row As TableRow

    strDmgString = NormalizeDamageString(strDmgString)
    For i = 0 To intRowCount.Length - 1
      intRowCount(i) = 0
    Next
    InitTable(tbl)
    ds = FetchDamages()

    For i = 0 To ds.Tables(0).Rows.Count - 1
      intPK = System.Convert.ToInt32(ds.Tables(0).Rows(i).Item("Dann_PK"))
      intFK_CaDa = System.Convert.ToInt32(ds.Tables(0).Rows(i).Item("Dann_FK_CaDa"))
      strDesc = System.Convert.ToString(ds.Tables(0).Rows(i).Item("Dann_Desc"))
      blnChecked = ExistsInDamageString(strDmgString, intPK)
      Select Case intFK_CaDa
        Case 1
          row = New TableRow
          row.Cells.Add(GetCell())
          row.Cells(0).Controls.Add(GetCheckBox(intPK, intFK_CaDa, strDesc, blnChecked))
          row.Cells.Add(GetCell())
          row.Cells.Add(GetCell())
          tbl.Rows.Add(row)
          intRowCount(0) = intRowCount(0) + 1
        Case 2
          If (tbl.Rows.Count > intRowCount(1)) Then
            row = tbl.Rows(intRowCount(1))
            row.Cells(1).Controls.Add(GetCheckBox(intPK, intFK_CaDa, strDesc, blnChecked))
          Else
            row = New TableRow
            row.Cells.Add(GetCell())
            row.Cells.Add(GetCell())
            row.Cells(1).Controls.Add(GetCheckBox(intPK, intFK_CaDa, strDesc, blnChecked))
            row.Cells.Add(GetCell())
            tbl.Rows.Add(row)
          End If
          intRowCount(1) = intRowCount(1) + 1
        Case 3
          If (tbl.Rows.Count > intRowCount(2)) Then
            row = tbl.Rows(intRowCount(2))
            row.Cells(2).Controls.Add(GetCheckBox(intPK, intFK_CaDa, strDesc, blnChecked))
          Else
            row = New TableRow
            row.Cells.Add(GetCell())
            row.Cells.Add(GetCell())
            row.Cells.Add(GetCell())
            row.Cells(2).Controls.Add(GetCheckBox(intPK, intFK_CaDa, strDesc, blnChecked))
            tbl.Rows.Add(row)
          End If
          intRowCount(2) = intRowCount(2) + 1
      End Select
    Next

  End Sub

  Public Shared Function GetDamageString(ByRef tbl As Table) As String

    Dim i, j As Integer
    Dim chk As CheckBox
    Dim intPK, intFK_CaDa As Integer
    Dim strCaDa(2) As String

    For i = 0 To tbl.Rows.Count - 1
      For j = 0 To 2
        For Each chk In tbl.Rows(i).Cells(j).Controls
          If chk.Checked Then
            ParseCheckBoxID(chk.ID, intPK, intFK_CaDa)
            strCaDa(intFK_CaDa - 1) = strCaDa(intFK_CaDa - 1) & CStr(intPK) & ";"
          End If
        Next
      Next
    Next

    Return "S" & strCaDa(0) & "A" & strCaDa(1) & "R" & strCaDa(2)

  End Function

  ' *******************************************************************************************
  '     PROTECTED SHARED METHODS
  ' *******************************************************************************************
  Protected Shared Function NormalizeDamageString(ByVal strDmgString As String) As String

    strDmgString = UCase(strDmgString).Replace("S", "").Replace("A", "").Replace("R", "")
    If (Left(strDmgString, 1) <> ";") Then strDmgString = ";" & strDmgString
    If (Right(strDmgString, 1) <> ";") Then strDmgString = strDmgString & ";"
    Return strDmgString

  End Function

  Protected Shared Function ExistsInDamageString(ByVal strDmgString As String, ByVal intPK As Integer) As Boolean
    Return (InStr(1, strDmgString, ";" & CStr(intPK) & ";") > 0)
  End Function

  Protected Shared Function FetchDamages() As DataSet

    Dim strSql As String

    strSql = "SELECT " & _
                  "* " & _
             "FROM " & _
                  "Tabl_Danno " & _
             "WHERE " & _
                  "LTRIM(RTRIM(Dann_Desc)) <> '' " & _
             "ORDER BY " & _
                  "Dann_FK_CaDa"

    Dim cnn As New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    Dim da As New SqlDataAdapter(strSql, cnn)
    Dim ds As New DataSet
    da.Fill(ds)
    cnn.Close()
    da.Dispose()
    cnn.Dispose()
    Return ds

  End Function

  Protected Shared Function InitTable(ByRef tbl As Table)

    tbl.Rows.Clear()
    tbl.CellPadding = 0
    tbl.CellSpacing = 0
    tbl.CssClass = "supReportTable"

  End Function

  Protected Shared Function GetCell() As TableCell

    Dim cell As New TableCell
    cell.CssClass = "supReportDetail"
    cell.Width = Unit.Pixel(250)
    cell.Height = Unit.Pixel(15)
    cell.HorizontalAlign = HorizontalAlign.Left
    Return cell

  End Function

  Protected Shared Function GetCheckBox(ByVal intPK As Integer, ByVal intFK_CaDa As Integer, ByVal strDesc As String, ByVal blnChecked As Boolean) As CheckBox

    Dim chk As New CheckBox
    chk.ID = GetCheckBoxName(intPK, intFK_CaDa)
    chk.Text = strDesc
    chk.Checked = blnChecked
    chk.Enabled = Not blnChecked
    Return chk

  End Function

  Protected Shared Function GetCheckBoxName(ByVal intPK As Integer, ByVal intFK_CaDa As Integer) As String
    Return m_kstrCheckBoxNameRoot & CStr(intFK_CaDa) & "_" & CStr(intPK)
  End Function

  Protected Shared Sub ParseCheckBoxID(ByVal strChkName As String, ByRef intPK As Integer, ByRef intFK_CaDa As Integer)

    Dim strChkIndex As String = Mid(strChkName, Len(m_kstrCheckBoxNameRoot) + 1)
    intFK_CaDa = System.Convert.ToInt32(Mid(strChkIndex, 1, InStr(1, strChkIndex, "_") - 1))
    intPK = System.Convert.ToInt32(Mid(strChkIndex, InStr(1, strChkIndex, "_") + 1))

  End Sub

End Class
