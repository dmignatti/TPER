Imports System.Data.SqlClient

Public Class supTblVerbaliCdS

  Protected m_intFK_Rimz As Integer
  Protected m_decTotal As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intFK_Rimz As Integer)
    m_intFK_Rimz = intFK_Rimz
  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property Total() As Decimal
    Get
      Return m_decTotal
    End Get
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Sub FillTable(ByRef tbl As Table)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim row As TableRow

    m_decTotal = 0

    strSql = "SELECT " & _
                  "VCdS_Numero, " & _
                  "VCdS_Codifica_1, VCdS_Importo_1, " & _
                  "VCdS_Codifica_2, VCdS_Importo_2, " & _
                  "VCdS_Codifica_3, VCdS_Importo_3, " & _
                  "VCdS_BolloImporto, VCdS_TotaleBollo " & _
             "FROM " & _
                  "Angr_VerbaleCdS " & _
             "WHERE " & _
                  "VCdS_FK_Rimz = " & CStr(m_intFK_Rimz) & " " & _
             "ORDER BY " & _
                  "VCdS_Numero"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader

    If dr.HasRows Then
      Do While dr.Read
        row = New TableRow
        row.Cells.Add(GetCell(System.Convert.ToString(dr("VCdS_Numero")), 75, HorizontalAlign.Center))
        row.Cells.Add(GetCell(System.Convert.ToString(dr("VCdS_Codifica_1")), 75, HorizontalAlign.Center))
        row.Cells.Add(GetCell(supFunction.FormatEuro(System.Convert.ToDecimal(dr("VCdS_Importo_1")), False), 75, HorizontalAlign.Right))
        row.Cells.Add(GetCell(System.Convert.ToString(dr("VCdS_Codifica_2")), 75, HorizontalAlign.Center))
        row.Cells.Add(GetCell(supFunction.FormatEuro(System.Convert.ToDecimal(dr("VCdS_Importo_2")), False), 75, HorizontalAlign.Right))
        row.Cells.Add(GetCell(System.Convert.ToString(dr("VCdS_Codifica_3")), 75, HorizontalAlign.Center))
        row.Cells.Add(GetCell(supFunction.FormatEuro(System.Convert.ToDecimal(dr("VCdS_Importo_3")), False), 75, HorizontalAlign.Right))
        row.Cells.Add(GetCell(supFunction.FormatEuro(System.Convert.ToDecimal(dr("VCdS_BolloImporto")), False), 75, HorizontalAlign.Right))
        row.Cells.Add(GetCell(supFunction.FormatEuro(System.Convert.ToDecimal(dr("VCdS_TotaleBollo")), False), 112.5, HorizontalAlign.Right))
        m_decTotal = m_decTotal + System.Convert.ToDecimal(dr("VCdS_TotaleBollo"))
        tbl.Rows.Add(row)
      Loop
    End If
    dr.Close()
    cnn.Close()

    cmd.Dispose()
    cnn.Dispose()

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Shared Function GetCell(ByVal strText As String, ByVal intWidth As Integer, ByVal intAlign As HorizontalAlign) As TableCell

    Dim cell As New TableCell
    cell.Text = strText
    cell.CssClass = "supExitTableCell"
    cell.Width = Unit.Pixel(intWidth)
    cell.Height = Unit.Pixel(15)
    cell.HorizontalAlign = intAlign
    Return cell

  End Function

End Class
