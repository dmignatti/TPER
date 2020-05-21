Imports System.Data.SqlClient

Public Class supQuietanzeCdS
  Inherits System.Collections.CollectionBase

  Protected m_intFK_Rimz As Integer
  Protected m_intFK_User As Integer
  Protected m_strUserMatricola As String
  Protected m_strUserNominativo As String
  Protected m_strTarga As String
  Protected m_dtmDataOra As DateTime
  Protected m_strRitr_Nominativo As String

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intFK_Rimz As Integer, ByVal intFK_User As Integer, _
                ByVal strUserMatricola As String, ByVal strUserNominativo As String, _
                ByVal strTarga As String, ByVal dtmDataOra As DateTime)

    MyBase.New()

    m_intFK_Rimz = intFK_Rimz
    m_intFK_User = intFK_User
    m_strUserMatricola = strUserMatricola
    m_strUserNominativo = strUserNominativo
    m_strTarga = strTarga
    m_dtmDataOra = dtmDataOra
    Fetch()

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Default Public ReadOnly Property Item(ByVal index As Integer) As supQuietanzaCdS
    Get
      Return MyBase.List.Item(index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return MyBase.List.Count - 1
    End Get
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Sub SetTable(ByRef tbl As Table)

    Dim i As Integer
    Dim q As supQuietanzaCdS
    Dim row As TableRow

    tbl.Rows.Clear()

    For i = 0 To MyBase.List.Count - 1
      row = New TableRow
      q = MyBase.List.Item(i)
      row.Cells.Add(GetCell("", 100, HorizontalAlign.Center))
      row.Cells(0).Controls.Add(getTextBox(i))
      row.Cells.Add(GetCell(q.ListaVerbali, 100, HorizontalAlign.Center))
      row.Cells.Add(GetCell(supFunction.FormatEuro(q.Importo, False), 100, HorizontalAlign.Right))
      row.Cells.Add(GetCell(supFunction.FormatEuro(q.BolloImporto, False), 100, HorizontalAlign.Right))
      row.Cells.Add(GetCell(supFunction.FormatEuro(q.Totale, False), 100, HorizontalAlign.Right))
      tbl.Rows.Add(row)
    Next

  End Sub

  Public Sub GetGUIData(ByRef tbl As Table, ByVal intFK_MoPa As Integer, ByVal strPagamento As String, ByVal strRitr_Nominativo As String)

    Dim i As Integer
    Dim q As supQuietanzaCdS
    Dim txt As TextBox

    Try
      For i = 0 To tbl.Rows.Count - 1
        q = MyBase.List.Item(i)
        txt = tbl.Rows(i).Cells(0).FindControl("txtQCdSPK_" & CStr(i))
        q.PK = System.Convert.ToInt32(txt.Text.Trim())
        q.FK_MoPa = intFK_MoPa
        q.Pagamento = strPagamento
        q.Ritr_Nominativo = strRitr_Nominativo
      Next
    Catch ex As Exception
      Throw New Exception("Impossibile decodificare i dati inseriti dall'utente.")
    End Try

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Public Sub Fetch()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim intFK_TaIn As Integer
    Dim decImporto_TaIn, decLimiteInfApp_TaIn As Decimal
    Dim q As supQuietanzaCdS

    strSql = "SELECT " & _
                  "VCdS_PK AS QCdS_FK_VCdS, " & _
                  "VCdS_Numero AS QCdS_ListaVerbali, " & _
                  "VCdS_Agnt_Matricola AS QCdS_Agnt_Matricola, " & _
                  "VCdS_Totale AS QCdS_Importo " & _
             "FROM " & _
                  "Angr_VerbaleCdS " & _
             "WHERE " & _
                  "VCdS_FK_Rimz = " & CStr(m_intFK_Rimz) & " " & _
             "ORDER BY " & _
                  "VCdS_Numero"
    Fetch_TaIn_Data(intFK_TaIn, decImporto_TaIn, decLimiteInfApp_TaIn)

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader
    If dr.HasRows Then
      Do While dr.Read
        q = New supQuietanzaCdS
        'q.PK viene assegnato dall'utente.
        q.FK_Rimz = m_intFK_Rimz
        q.FK_User = m_intFK_User
        q.UserMatricola = m_strUserMatricola
        q.UserNominativo = m_strUserNominativo
        q.Targa = m_strTarga
        q.DataOra = m_dtmDataOra
        'q.Ritr_Nominativo = m_strRitr_Nominativo
        q.Agnt_Matricola = System.Convert.ToString(dr("QCdS_Agnt_Matricola"))
        q.FK_VCdS = System.Convert.ToInt32(dr("QCdS_FK_VCdS"))
        q.ListaVerbali = System.Convert.ToString(dr("QCdS_ListaVerbali"))
        'q.FK_MoPa viene assegnato dall'utente.
        'q.Pagamento viene assegnato dall'utente.
        q.Importo = System.Convert.ToDecimal(dr("QCdS_Importo"))
        q.BolloImporto = IIf(q.Importo < decLimiteInfApp_TaIn, 0, decImporto_TaIn)
        q.Totale = q.Importo + q.BolloImporto
        q.FK_TaIn = intFK_TaIn
        q.Importo_TaIn = decImporto_TaIn
        q.LimiteInfApp_TaIn = decLimiteInfApp_TaIn
        MyBase.List.Add(q)
      Loop
    End If
    dr.Close()
    cnn.Close()
    cmd.Dispose()
    cnn.Dispose()

  End Sub

  Protected Sub Fetch_TaIn_Data(ByRef intFK_TaIn As Integer, ByRef decImporto_TaIn As Decimal, ByRef decLimiteInfApp_TaIn As Decimal)

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "* " & _
             "FROM " & _
                  "Tabl_TassaInfrazione " & _
             "WHERE " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataOra) & "', 121) BETWEEN TaIn_DataInizio AND TaIn_DataFine"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader
    If dr.HasRows Then
      dr.Read()
      intFK_TaIn = System.Convert.ToInt32(dr("TaIn_PK"))
      decImporto_TaIn = System.Convert.ToDecimal(dr("TaIn_Importo"))
      decLimiteInfApp_TaIn = System.Convert.ToDecimal(dr("TaIn_LimiteInfApp"))
    End If
    dr.Close()
    cnn.Close()
    cmd.Dispose()
    cnn.Dispose()

  End Sub

  Protected Function GetCell(ByVal strText As String, ByVal intWidth As Integer, ByVal intAlign As HorizontalAlign) As TableCell

    Dim cell As New TableCell
    cell.Text = strText
    cell.CssClass = "supExitTableCell"
    cell.Width = Unit.Pixel(intWidth)
    cell.Height = Unit.Pixel(15)
    cell.HorizontalAlign = intAlign
    Return cell

  End Function

  Protected Function getTextBox(ByVal index As Integer) As TextBox

    Dim txt As New TextBox
    txt.ID = "txtQCdSPK_" & CStr(index)
    txt.Text = ""
    txt.CssClass = "supExitTextBox"
    txt.Width = Unit.Percentage(100)
    txt.Height = Unit.Percentage(100)
    txt.TextMode = TextBoxMode.SingleLine
    txt.MaxLength = 9
    Return txt

  End Function

End Class
