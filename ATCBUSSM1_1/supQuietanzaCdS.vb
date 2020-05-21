Imports System.Data.SqlClient

Public Class supQuietanzaCdS

  Protected m_intPK As Integer
  Protected m_intFK_Rimz As Integer
  Protected m_intFK_User As Integer
  Protected m_strUserMatricola As String
  Protected m_strUserNominativo As String
  Protected m_strTarga As String
  Protected m_dtmDataOra As DateTime
  Protected m_strRitr_Nominativo As String
  Protected m_strAgnt_Matricola As String
  Protected m_intFK_VCdS As Integer
  Protected m_strListaVerbali As String
  Protected m_intFK_MoPa As Integer
  Protected m_strPagamento As String
  Protected m_decImporto As Decimal
  Protected m_decBolloImporto As Decimal
  Protected m_decTotale As Decimal
  Protected m_intFK_TaIn As Integer
  Protected m_decImporto_TaIn As Decimal
  Protected m_decLimiteInfApp_TaIn As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New()

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property PK() As Integer
    Get
      Return m_intPK
    End Get
    Set(ByVal Value As Integer)
      m_intPK = Value
    End Set
  End Property

  Public Property FK_Rimz() As Integer
    Get
      Return m_intFK_Rimz
    End Get
    Set(ByVal Value As Integer)
      m_intFK_Rimz = Value
    End Set
  End Property

  Public Property FK_User() As Integer
    Get
      Return m_intFK_User
    End Get
    Set(ByVal Value As Integer)
      m_intFK_User = Value
    End Set
  End Property

  Public Property UserMatricola() As String
    Get
      Return m_strUserMatricola
    End Get
    Set(ByVal Value As String)
      m_strUserMatricola = Value
    End Set
  End Property

  Public Property UserNominativo() As String
    Get
      Return m_strUserNominativo
    End Get
    Set(ByVal Value As String)
      m_strUserNominativo = Value
    End Set
  End Property

  Public Property Targa() As String
    Get
      Return m_strTarga
    End Get
    Set(ByVal Value As String)
      m_strTarga = Value
    End Set
  End Property

  Public Property DataOra() As DateTime
    Get
      Return m_dtmDataOra
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataOra = Value
    End Set
  End Property

  Public Property Ritr_Nominativo() As String
    Get
      Return m_strRitr_Nominativo
    End Get
    Set(ByVal Value As String)
      m_strRitr_Nominativo = Value
    End Set
  End Property

  Public Property Agnt_Matricola() As String
    Get
      Return m_strAgnt_Matricola
    End Get
    Set(ByVal Value As String)
      m_strAgnt_Matricola = Value
    End Set
  End Property

  Public Property FK_VCdS() As Integer
    Get
      Return m_intFK_VCdS
    End Get
    Set(ByVal Value As Integer)
      m_intFK_VCdS = Value
    End Set
  End Property

  Public Property ListaVerbali() As String
    Get
      Return m_strListaVerbali
    End Get
    Set(ByVal Value As String)
      m_strListaVerbali = Value
    End Set
  End Property

  Public Property FK_MoPa() As Integer
    Get
      Return m_intFK_MoPa
    End Get
    Set(ByVal Value As Integer)
      m_intFK_MoPa = Value
    End Set
  End Property

  Public Property Pagamento() As String
    Get
      Return m_strPagamento
    End Get
    Set(ByVal Value As String)
      m_strPagamento = Value
    End Set
  End Property

  Public Property Importo() As Decimal
    Get
      Return m_decImporto
    End Get
    Set(ByVal Value As Decimal)
      m_decImporto = Value
    End Set
  End Property

  Public Property BolloImporto() As Decimal
    Get
      Return m_decBolloImporto
    End Get
    Set(ByVal Value As Decimal)
      m_decBolloImporto = Value
    End Set
  End Property

  Public Property Totale() As Decimal
    Get
      Return m_decTotale
    End Get
    Set(ByVal Value As Decimal)
      m_decTotale = Value
    End Set
  End Property

  Public Property FK_TaIn() As Integer
    Get
      Return m_intFK_TaIn
    End Get
    Set(ByVal Value As Integer)
      m_intFK_TaIn = Value
    End Set
  End Property

  Public Property Importo_TaIn() As Decimal
    Get
      Return m_decImporto_TaIn
    End Get
    Set(ByVal Value As Decimal)
      m_decImporto_TaIn = Value
    End Set
  End Property

  Public Property LimiteInfApp_TaIn() As Decimal
    Get
      Return m_decLimiteInfApp_TaIn
    End Get
    Set(ByVal Value As Decimal)
      m_decLimiteInfApp_TaIn = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Function Sql_Insert() As String

    Dim strSql As String

    strSql = "INSERT INTO Angr_QuietanzaCdS " & _
                  "(QCdS_Mode, QCdS_PK, QCdS_FK_Rimz, " & _
                  "QCdS_FK_User, QCdS_UserMatricola, " & _
                  "QCdS_UserNominativo, QCdS_Targa, " & _
                  "QCdS_DataOra, " & _
                  "QCdS_Ritr_Nominativo, " & _
                  "QCdS_Agnt_Matricola, " & _
                  "QCdS_FK_VCdS, QCdS_ListaVerbali, " & _
                  "QCdS_FK_MoPa, QCdS_Pagamento, " & _
                  "QCdS_Valuta, " & _
                  "QCdS_Importo, " & _
                  "QCdS_BolloImporto, " & _
                  "QCdS_Totale, " & _
                  "QCdS_FK_TaIn, " & _
                  "QCdS_Importo_TaIn, " & _
                  "QCdS_LimiteInfApp_TaIn, " & _
                  "QCdS_Stato) " & _
             "VALUES " & _
                  "('M', " & CStr(m_intPK) & ", " & CStr(m_intFK_Rimz) & ", " & _
                  CStr(m_intFK_User) & ", '" & m_strUserMatricola.Replace("'", "''") & "', " & _
                  "'" & m_strUserNominativo.Replace("'", "''") & "', '" & m_strTarga.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataOra) & "', 121), " & _
                  "'" & m_strRitr_Nominativo.Replace("'", "''") & "', " & _
                  "'" & m_strAgnt_Matricola.Replace("'", "''") & "', " & _
                  CStr(m_intFK_VCdS) & ", '" & m_strListaVerbali.Replace("'", "''") & "', " & _
                  CStr(m_intFK_MoPa) & ", '" & m_strPagamento.Replace("'", "''") & "', " & _
                  "'€', " & _
                  supFunction.sqlMoney(m_decImporto) & ", " & _
                  supFunction.sqlMoney(m_decBolloImporto) & ", " & _
                  supFunction.sqlMoney(m_decTotale) & ", " & _
                  CStr(m_intFK_TaIn) & ", " & _
                  supFunction.sqlMoney(m_decImporto_TaIn) & ", " & _
                  supFunction.sqlMoney(m_decLimiteInfApp_TaIn) & ", " & _
                  "'0')"
    Return strSql

  End Function

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************

End Class
