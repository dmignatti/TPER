Imports System.Data.SqlClient

Public Class supRpt1Session

  Protected m_intID As Integer
  Protected m_dtmDay As DateTime
  Protected m_Details As supRpt1Details

  Protected m_decTotRimzBanc As Decimal
  Protected m_decTotRimzCash As Decimal
  Protected m_decTotInfrBanc As Decimal
  Protected m_decTotInfrCash As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intID As Integer, ByVal dtmDay As DateTime)

    m_intID = intID
    m_dtmDay = dtmDay
    m_Details = New supRpt1Details
    m_decTotRimzBanc = -1
    m_decTotRimzCash = -1
    m_decTotInfrBanc = -1
    m_decTotInfrCash = -1

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property ID() As Integer
    Get
      Return m_intID
    End Get
  End Property

  Public ReadOnly Property Details() As supRpt1Details
    Get
      Return m_Details
    End Get
  End Property

  Public ReadOnly Property TotRimzBanc() As Decimal
    Get
      If (m_decTotRimzBanc = -1) Then
        m_decTotRimzBanc = getTotal(supRpt1Detail.FlagEnum.Servizi, supRpt1Detail.PaymentEnum.Bancomat)
      End If
      Return m_decTotRimzBanc
    End Get
  End Property

  Public ReadOnly Property TotRimzCash() As Decimal
    Get
      If (m_decTotRimzCash = -1) Then
        m_decTotRimzCash = getTotal(supRpt1Detail.FlagEnum.Servizi, supRpt1Detail.PaymentEnum.Cash)
      End If
      Return m_decTotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotInfrBanc() As Decimal
    Get
      If (m_decTotInfrBanc = -1) Then
        m_decTotInfrBanc = getTotal(supRpt1Detail.FlagEnum.Multa, supRpt1Detail.PaymentEnum.Bancomat)
      End If
      Return m_decTotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotInfrCash() As Decimal
    Get
      If (m_decTotInfrCash = -1) Then
        m_decTotInfrCash = getTotal(supRpt1Detail.FlagEnum.Multa, supRpt1Detail.PaymentEnum.Cash)
      End If
      Return m_decTotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotInfr() As Decimal
    Get
      Return TotInfrBanc + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property TotRimz() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash
    End Get
  End Property

  Public ReadOnly Property TotBanc() As Decimal
    Get
      Return TotRimzBanc + TotInfrBanc
    End Get
  End Property

  Public ReadOnly Property TotCash() As Decimal
    Get
      Return TotRimzCash + TotInfrCash
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return TotRimzBanc + TotRimzCash + TotInfrBanc + TotInfrCash
    End Get
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Function GetComment() As String

    Dim strComment As String = ""
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dtmDateOpen, dtmDateClose As DateTime
    Dim decRimzBanc, decRimzCash, decInfrBanc, decInfrCash As Decimal

    strSql = "SELECT * FROM Tabl_Sessione WHERE Sess_PK = " & CStr(m_intID)

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader()

    If dr.HasRows Then
      dr.Read()
      dtmDateOpen = System.Convert.ToDateTime(dr("Sess_DateOpen"))
      dtmDateClose = System.Convert.ToDateTime(dr("Sess_DateClose"))
      decRimzBanc = System.Convert.ToDecimal(dr("Sess_BancRimz"))
      decRimzCash = System.Convert.ToDecimal(dr("Sess_CashRimz"))
      decInfrBanc = System.Convert.ToDecimal(dr("Sess_BancInfr"))
      decInfrCash = System.Convert.ToDecimal(dr("Sess_CashInfr"))
      ' Data inizio.
      If (dtmDateOpen.Date <> m_dtmDay) Then
        strComment = "Inizio sess.: " & supFunction.FormatDate(dtmDateOpen, supFunction.supDateFormatEnum.dfeDateTime)
      End If
      ' Data fine.
      If (dtmDateClose.Date <> m_dtmDay) Then
        If Not strComment.Equals("") Then
          strComment = strComment & " - "
        End If
        If (dtmDateClose >= New DateTime(9999, 12, 31, 0, 0, 0)) Then
          strComment = strComment & "Sessione aperta"
        Else
          strComment = strComment & "Fine sess.: " & supFunction.FormatDate(dtmDateClose, supFunction.supDateFormatEnum.dfeDateTime)
        End If
      End If
      If ((dtmDateOpen.Date <> m_dtmDay) Or (dtmDateClose.Date <> m_dtmDay)) Then
        ' Servizi bancomat.
        If (decRimzBanc <> m_decTotRimzBanc) Then
          If Not strComment.Equals("") Then
            strComment = strComment & " - "
          End If
          strComment = strComment & "Resto sessione Serv. Banc.: " & supFunction.FormatEuro(decRimzBanc - m_decTotRimzBanc, True)
        End If
        ' Servizi contanti.
        If (decRimzCash <> m_decTotRimzCash) Then
          If Not strComment.Equals("") Then
            strComment = strComment & " - "
          End If
          strComment = strComment & "Resto sessione Serv. Cont.: " & supFunction.FormatEuro(decRimzCash - m_decTotRimzCash, True)
        End If
        ' Sanzioni bancomat.
        If (decInfrBanc <> m_decTotInfrBanc) Then
          If Not strComment.Equals("") Then
            strComment = strComment & " - "
          End If
          strComment = strComment & "Resto sessione Sanz. Banc.: " & supFunction.FormatEuro(decInfrBanc - m_decTotInfrBanc, True)
        End If
        ' Sanzioni contanti.
        If (decInfrCash <> m_decTotInfrCash) Then
          If Not strComment.Equals("") Then
            strComment = strComment & " - "
          End If
          strComment = strComment & "Resto sessione Sanz. Cont.: " & supFunction.FormatEuro(decInfrCash - m_decTotInfrCash, True)
        End If
      End If
    Else
      strComment = "Errore: sessione non trovata"
    End If

    dr.Close()
    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()

    Return strComment

  End Function

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Function getTotal(ByVal intFlag As supRpt1Detail.FlagEnum, ByVal intPayment As supRpt1Detail.PaymentEnum) As Decimal

    Dim i As Integer
    Dim decTotal As Decimal = 0

    For i = 0 To m_Details.UBound
      If ((m_Details(i).Flag = intFlag) And (m_Details(i).Payment = intPayment)) Then
        decTotal = decTotal + m_Details(i).Money
      End If
    Next

    Return decTotal

  End Function

End Class
