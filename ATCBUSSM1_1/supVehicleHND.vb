Imports System.Data.SqlClient

Public Class supVehicleHND
  Inherits supVehicleRSO

  Protected m_strNumeroContrassegno As String
  Protected m_strRilascioContrassegno As String

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)

    MyBase.New(intRimzPK, strStato)

    m_strNumeroContrassegno = ""
    m_strRilascioContrassegno = ""

  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Public Property NumeroContrassegno() As String
    Get
      Return m_strNumeroContrassegno
    End Get
    Set(ByVal Value As String)
      m_strNumeroContrassegno = Value
    End Set
  End Property

  Public Property RilascioContrassegno() As String
    Get
      Return m_strRilascioContrassegno
    End Get
    Set(ByVal Value As String)
      m_strRilascioContrassegno = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Overrides Sub Save()

    Dim tr As New supTransaction
    tr.SqlCommands.Add(Me.Sql_Insert())
    tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VHND))
    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overrides Function Sql_Insert() As String

    Dim strSql As String

    strSql = "INSERT INTO Angr_VeicoloHND " & _
                  "(VHND_Mode, VHND_PK, VHND_FK_Rimz, VHND_Targa, " & _
                  "VHND_FK_User, VHND_UserMatricola, VHND_UserNominativo, " & _
                  "VHND_DataIngresso, " & _
                  "VHND_FK_TiMe, VHND_Tipo, " & _
                  "VHND_FK_MaMe, VHND_Marca, " & _
                  "VHND_FK_MoMe, VHND_Modello, " & _
                  "VHND_PesoPC, VHND_Divisore, " & _
                  "VHND_DanniRimz, VHND_DanniScar, " & _
                  "VHND_NoteIngresso, " & _
                  "VHND_DataUscita, " & _
                  "VHND_NumeroContrassegno, " & _
                  "VHND_RilascioContrassegno, " & _
                  "VHND_NumeroPatente, " & _
                  "VHND_RilascioPatente, " & _
                  "VHND_TipoDocumento, " & _
                  "VHND_NumeroDocumento, " & _
                  "VHND_RilascioDocumento, " & _
                  "VHND_Ritr_Nome, " & _
                  "VHND_Ritr_Cognome, " & _
                  "VHND_Ritr_LuogoNascita, " & _
                  "VHND_Ritr_DataNascita, " & _
                  "VHND_Ritr_Indirizzo, " & _
                  "VHND_Ritr_LuogoResidenza, " & _
                  "VHND_Prop_Nome, " & _
                  "VHND_Prop_Cognome, " & _
                  "VHND_Prop_LuogoNascita, " & _
                  "VHND_Prop_DataNascita, " & _
                  "VHND_Prop_Indirizzo, " & _
                  "VHND_Prop_LuogoResidenza, " & _
                  "VHND_DanniRitr, " & _
                  "VHND_NoteUscita) " & _
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
                  "'" & m_strNumeroContrassegno.Replace("'", "''") & "', " & _
                  "'" & m_strRilascioContrassegno.Replace("'", "''") & "', " & _
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
