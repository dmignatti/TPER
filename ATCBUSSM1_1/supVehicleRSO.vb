Imports System.Data.SqlClient

Public Class supVehicleRSO
  Inherits supVehicleRBT

  Protected m_strNumeroPatente As String
  Protected m_strRilascioPatente As String
  Protected m_strTipoDocumento As String
  Protected m_strNumeroDocumento As String
  Protected m_strRilascioDocumento As String
  Protected m_strRitr_Nome As String
  Protected m_strRitr_Cognome As String
  Protected m_strRitr_LuogoNascita As String
  Protected m_dtmRitr_DataNascita As Date
  Protected m_strRitr_Indirizzo As String
  Protected m_strRitr_LuogoResidenza As String
  Protected m_strProp_Nome As String
  Protected m_strProp_Cognome As String
  Protected m_strProp_LuogoNascita As String
  Protected m_dtmProp_DataNascita As Date
  Protected m_strProp_Indirizzo As String
  Protected m_strProp_LuogoResidenza As String

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)

    MyBase.New(intRimzPK, strStato)

    m_strNumeroPatente = ""
    m_strRilascioPatente = ""
    m_strTipoDocumento = ""
    m_strNumeroDocumento = ""
    m_strRilascioDocumento = ""
    m_strRitr_Nome = ""
    m_strRitr_Cognome = ""
    m_strRitr_LuogoNascita = ""
    m_dtmRitr_DataNascita = New DateTime(9999, 12, 31, 23, 59, 59)
    m_strRitr_Indirizzo = ""
    m_strRitr_LuogoResidenza = ""
    m_strProp_Nome = ""
    m_strProp_Cognome = ""
    m_strProp_LuogoNascita = ""
    m_dtmProp_DataNascita = New DateTime(9999, 12, 31, 23, 59, 59)
    m_strProp_Indirizzo = ""
    m_strProp_LuogoResidenza = ""

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property NumeroPatente() As String
    Get
      Return m_strNumeroPatente
    End Get
    Set(ByVal Value As String)
      m_strNumeroPatente = Value
    End Set
  End Property

  Public Property RilascioPatente() As String
    Get
      Return m_strRilascioPatente
    End Get
    Set(ByVal Value As String)
      m_strRilascioPatente = Value
    End Set
  End Property

  Public Property TipoDocumento() As String
    Get
      Return m_strTipoDocumento
    End Get
    Set(ByVal Value As String)
      m_strTipoDocumento = Value
    End Set
  End Property

  Public Property NumeroDocumento() As String
    Get
      Return m_strNumeroDocumento
    End Get
    Set(ByVal Value As String)
      m_strNumeroDocumento = Value
    End Set
  End Property

  Public Property RilascioDocumento() As String
    Get
      Return m_strRilascioDocumento
    End Get
    Set(ByVal Value As String)
      m_strRilascioDocumento = Value
    End Set
  End Property

  Public Property Ritr_Nome() As String
    Get
      Return m_strRitr_Nome
    End Get
    Set(ByVal Value As String)
      m_strRitr_Nome = Value
    End Set
  End Property

  Public Property Ritr_Cognome() As String
    Get
      Return m_strRitr_Cognome
    End Get
    Set(ByVal Value As String)
      m_strRitr_Cognome = Value
    End Set
  End Property

  Public Property Ritr_LuogoNascita() As String
    Get
      Return m_strRitr_LuogoNascita
    End Get
    Set(ByVal Value As String)
      m_strRitr_LuogoNascita = Value
    End Set
  End Property

  Public Property Ritr_DataNascita() As DateTime
    Get
      Return m_dtmRitr_DataNascita
    End Get
    Set(ByVal Value As DateTime)
      m_dtmRitr_DataNascita = Value
    End Set
  End Property

  Public Property Ritr_Indirizzo() As String
    Get
      Return m_strRitr_Indirizzo
    End Get
    Set(ByVal Value As String)
      m_strRitr_Indirizzo = Value
    End Set
  End Property

  Public Property Ritr_LuogoResidenza() As String
    Get
      Return m_strRitr_LuogoResidenza
    End Get
    Set(ByVal Value As String)
      m_strRitr_LuogoResidenza = Value
    End Set
  End Property

  Public Property Prop_Nome() As String
    Get
      Return m_strProp_Nome
    End Get
    Set(ByVal Value As String)
      m_strProp_Nome = Value
    End Set
  End Property

  Public Property Prop_Cognome() As String
    Get
      Return m_strProp_Cognome
    End Get
    Set(ByVal Value As String)
      m_strProp_Cognome = Value
    End Set
  End Property

  Public Property Prop_LuogoNascita() As String
    Get
      Return m_strProp_LuogoNascita
    End Get
    Set(ByVal Value As String)
      m_strProp_LuogoNascita = Value
    End Set
  End Property

  Public Property Prop_DataNascita() As DateTime
    Get
      Return m_dtmProp_DataNascita
    End Get
    Set(ByVal Value As DateTime)
      m_dtmProp_DataNascita = Value
    End Set
  End Property

  Public Property Prop_Indirizzo() As String
    Get
      Return m_strProp_Indirizzo
    End Get
    Set(ByVal Value As String)
      m_strProp_Indirizzo = Value
    End Set
  End Property

  Public Property Prop_LuogoResidenza() As String
    Get
      Return m_strProp_LuogoResidenza
    End Get
    Set(ByVal Value As String)
      m_strProp_LuogoResidenza = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Overrides Sub Save()

    Dim tr As New supTransaction
    tr.SqlCommands.Add(Me.Sql_Insert())
    tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRSO))
    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overrides Function Sql_Insert() As String

    Dim strSql As String

    strSql = "INSERT INTO Angr_VeicoloRSO " & _
                  "(VRSO_Mode, VRSO_PK, VRSO_FK_Rimz, VRSO_Targa, " & _
                  "VRSO_FK_User, VRSO_UserMatricola, VRSO_UserNominativo, " & _
                  "VRSO_DataIngresso, " & _
                  "VRSO_FK_TiMe, VRSO_Tipo, " & _
                  "VRSO_FK_MaMe, VRSO_Marca, " & _
                  "VRSO_FK_MoMe, VRSO_Modello, " & _
                  "VRSO_PesoPC, VRSO_Divisore, " & _
                  "VRSO_DanniRimz, VRSO_DanniScar, " & _
                  "VRSO_NoteIngresso, " & _
                  "VRSO_DataUscita, " & _
                  "VRSO_NumeroPatente, " & _
                  "VRSO_RilascioPatente, " & _
                  "VRSO_TipoDocumento, " & _
                  "VRSO_NumeroDocumento, " & _
                  "VRSO_RilascioDocumento, " & _
                  "VRSO_Ritr_Nome, " & _
                  "VRSO_Ritr_Cognome, " & _
                  "VRSO_Ritr_LuogoNascita, " & _
                  "VRSO_Ritr_DataNascita, " & _
                  "VRSO_Ritr_Indirizzo, " & _
                  "VRSO_Ritr_LuogoResidenza, " & _
                  "VRSO_Prop_Nome, " & _
                  "VRSO_Prop_Cognome, " & _
                  "VRSO_Prop_LuogoNascita, " & _
                  "VRSO_Prop_DataNascita, " & _
                  "VRSO_Prop_Indirizzo, " & _
                  "VRSO_Prop_LuogoResidenza, " & _
                  "VRSO_DanniRitr, " & _
                  "VRSO_NoteUscita) " & _
             "VALUES " & _
                  "('M', " & CStr(m_intPK) & ", " & CStr(m_intFK_Rimz) & ", '" & m_strTarga.Replace("'", "''") & "', " & _
                  CStr(m_intFK_User) & ", '" & m_strUserMatricola.Replace("'", "''") & "', '" & m_strUserNominativo.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataIngresso) & "', 121), " & _
                  CStr(m_intFK_TiMe) & ", '" & m_strTipo.Replace("'", "''") & "', " & _
                  CStr(m_intFK_MaMe) & ", '" & m_strMarca.Replace("'", "''") & "', " & _
                  CStr(m_intFK_MoMe) & ", '" & m_strModello.Replace("'", "''") & "', " & _
                  supFunction.sqlDouble(m_dblPesoPC) & ", " & CStr(m_intDivisore) & ", " & _
                  "'" & m_strDanniRimz.Replace("'", "''") & "', '" & m_strDanniScar.Replace("'", "''") & "', " & _
                  "'" & m_strNoteIngresso.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataUscita) & "', 121), " & _
                  "'" & m_strNumeroPatente.Replace("'", "''") & "', " & _
                  "'" & m_strRilascioPatente.Replace("'", "''") & "', " & _
                  "'" & m_strTipoDocumento.Replace("'", "''") & "', " & _
                  "'" & m_strNumeroDocumento.Replace("'", "''") & "', " & _
                  "'" & m_strRilascioDocumento.Replace("'", "''") & "', " & _
                  "'" & m_strRitr_Nome.Replace("'", "''") & "', " & _
                  "'" & m_strRitr_Cognome.Replace("'", "''") & "', " & _
                  "'" & m_strRitr_LuogoNascita.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmRitr_DataNascita) & "', 121), " & _
                  "'" & m_strRitr_Indirizzo.Replace("'", "''") & "', " & _
                  "'" & m_strRitr_LuogoResidenza.Replace("'", "''") & "', " & _
                  "'" & m_strProp_Nome.Replace("'", "''") & "', " & _
                  "'" & m_strProp_Cognome.Replace("'", "''") & "', " & _
                  "'" & m_strProp_LuogoNascita.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmProp_DataNascita) & "', 121), " & _
                  "'" & m_strProp_Indirizzo.Replace("'", "''") & "', " & _
                  "'" & m_strProp_LuogoResidenza.Replace("'", "''") & "', " & _
                  "'" & m_strDanniRitr.Replace("'", "''") & "', " & _
                  "'" & m_strNoteUscita.Replace("'", "''") & "')"

    Return strSql

  End Function

End Class
