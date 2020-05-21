Imports System.Data.SqlClient

Public Class supVehicleRBT
  Inherits supVehicleDPT

  Protected m_dtmDataUscita As DateTime
  Protected m_intFK_User As Integer
  Protected m_strUserMatricola As String
  Protected m_strUserNominativo As String
  Protected m_strDanniRitr As String
  Protected m_strNoteUscita As String

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)

    MyBase.New(intRimzPK, strStato)

    m_dtmDataUscita = New DateTime(9999, 12, 31, 23, 59, 59)
    m_intFK_User = 0
    m_strUserMatricola = ""
    m_strUserNominativo = ""
    m_strDanniRitr = MyBase.DanniScarico
    m_strNoteUscita = ""

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property DataUscita() As DateTime
    Get
      Return m_dtmDataUscita
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataUscita = Value
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

  Public Property DanniRitiro() As String
    Get
      Return m_strDanniRitr
    End Get
    Set(ByVal Value As String)
      m_strDanniRitr = Value
    End Set
  End Property

  Public Property NoteUscita() As String
    Get
      Return m_strNoteUscita
    End Get
    Set(ByVal Value As String)
      m_strNoteUscita = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Overridable Sub Save()

    Dim tr As New supTransaction
    tr.SqlCommands.Add(Me.Sql_Insert())
    tr.SqlCommands.Add(Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRBT))
    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overridable Function Sql_Insert() As String

    Dim strSql As String

    MyBase.SetPK(supVehicleDPT.TableEnum.tbl_VRBT)

    strSql = "INSERT INTO Angr_VeicoloRBT " & _
                  "(VRBT_Mode, VRBT_PK, VRBT_FK_Rimz, VRBT_Targa, " & _
                  "VRBT_FK_User, VRBT_UserMatricola, VRBT_UserNominativo, " & _
                  "VRBT_DataIngresso, " & _
                  "VRBT_FK_TiMe, VRBT_Tipo, " & _
                  "VRBT_FK_MaMe, VRBT_Marca, " & _
                  "VRBT_FK_MoMe, VRBT_Modello, " & _
                  "VRBT_PesoPC, VRBT_Divisore, " & _
                  "VRBT_DanniRimz, VRBT_DanniScar, " & _
                  "VRBT_NoteIngresso, " & _
                  "VRBT_DataUscita, " & _
                  "VRBT_DanniRitr, " & _
                  "VRBT_NoteUscita) " & _
             "VALUES " & _
                  "('A', " & CStr(m_intPK) & ", " & CStr(m_intFK_Rimz) & ", '" & m_strTarga.Replace("'", "''") & "', " & _
                  CStr(m_intFK_User) & ", '" & m_strUserMatricola.Replace("'", "''") & "', '" & m_strUserNominativo.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataIngresso) & "', 121), " & _
                  CStr(m_intFK_TiMe) & ", '" & m_strTipo.Replace("'", "''") & "', " & _
                  CStr(m_intFK_MaMe) & ", '" & m_strMarca.Replace("'", "''") & "', " & _
                  CStr(m_intFK_MoMe) & ", '" & m_strModello.Replace("'", "''") & "', " & _
                  supFunction.sqlDouble(m_dblPesoPC) & ", " & CStr(m_intDivisore) & ", " & _
                  "'" & m_strDanniRimz.Replace("'", "''") & "', '" & m_strDanniScar.Replace("'", "''") & "', " & _
                  "'" & m_strNoteIngresso.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataUscita) & "', 121), " & _
                  "'" & m_strDanniRitr.Replace("'", "''") & "', " & _
                  "'" & m_strNoteUscita.Replace("'", "''") & "')"

    Return strSql

  End Function

  Protected Function Sql_UpdateReference(ByVal intTabella As TableEnum) As String

    Dim strTabella As String
    Dim strStato As String
    Dim strSql As String

    Select Case intTabella
      Case TableEnum.tbl_VHND
        strTabella = "Angr_VeicoloHND"
        strStato = "HND"
      Case TableEnum.tbl_VRBD
        strTabella = "Angr_VeicoloRBD"
        strStato = "RBD"
      Case TableEnum.tbl_VRBT
        strTabella = "Angr_VeicoloRBT"
        strStato = "RBT"
      Case TableEnum.tbl_VRSO
        strTabella = "Angr_VeicoloRSO"
        strStato = "RSO"
      Case TableEnum.tbl_VRTP
        strTabella = "Angr_VeicoloRTR"
        strStato = "RTP"
      Case TableEnum.tbl_VRTR
        strTabella = "Angr_VeicoloRTR"
        strStato = "RTR"
      Case TableEnum.tbl_VRVI
        strTabella = "Angr_VeicoloRVI"
        strStato = "RVI"
    End Select

    strSql = "UPDATE " & _
                  "Tabl_Rimozione " & _
             "SET " & _
                  "Rimz_PesoPC = " & supFunction.sqlDouble(m_dblPesoPC) & ", " & _
                  "Rimz_Stato = '" & strStato & "', " & _
                  "Rimz_DataUscita = CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataUscita) & "', 121), " & _
                  "Rimz_Tabella = '" & strTabella & "', " & _
                  "Rimz_RF_Mode = 'M', " & _
                  "Rimz_RF_Record = " & CStr(m_intPK) & " " & _
             "WHERE " & _
                  "Rimz_PK = " & CStr(m_intFK_Rimz)

    Return strSql

  End Function

End Class
