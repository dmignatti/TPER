Imports System.Data.SqlClient

Public Class supVehicleRBD
  Inherits supVehicleRBT

  Protected m_dtmDataDenuncia As DateTime
  Protected m_strCorpoDenuncia As String
  Protected m_strNumeroDenuncia As String
  Protected m_strStazioneDenuncia As String

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)

    MyBase.New(intRimzPK, strStato)

    m_dtmDataDenuncia = New DateTime(9999, 12, 31, 23, 59, 59)
    m_strCorpoDenuncia = ""
    m_strNumeroDenuncia = ""
    m_strStazioneDenuncia = ""

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property DataDenuncia() As DateTime
    Get
      Return m_dtmDataDenuncia
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataDenuncia = Value
    End Set
  End Property

  Public Property CorpoDenuncia() As String
    Get
      Return m_strCorpoDenuncia
    End Get
    Set(ByVal Value As String)
      m_strCorpoDenuncia = Value
    End Set
  End Property

  Public Property NumeroDenuncia() As String
    Get
      Return m_strNumeroDenuncia
    End Get
    Set(ByVal Value As String)
      m_strNumeroDenuncia = Value
    End Set
  End Property

  Public Property StazioneDenuncia() As String
    Get
      Return m_strStazioneDenuncia
    End Get
    Set(ByVal Value As String)
      m_strStazioneDenuncia = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Overrides Sub Save()

    Dim tr As New supTransaction
    tr.SqlCommands.Add(Me.Sql_Insert())
    tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRBD))
    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overrides Function Sql_Insert() As String

    Dim strSql As String

    MyBase.SetPK(supVehicleDPT.TableEnum.tbl_VRBD)

    strSql = "INSERT INTO Angr_VeicoloRBD " & _
                  "(VRBD_Mode, VRBD_PK, VRBD_FK_Rimz, VRBD_Targa, " & _
                  "VRBD_FK_User, VRBD_UserMatricola, VRBD_UserNominativo, " & _
                  "VRBD_DataIngresso, " & _
                  "VRBD_FK_TiMe, VRBD_Tipo, " & _
                  "VRBD_FK_MaMe, VRBD_Marca, " & _
                  "VRBD_FK_MoMe, VRBD_Modello, " & _
                  "VRBD_PesoPC, VRBD_Divisore, " & _
                  "VRBD_DanniRimz, VRBD_DanniScar, " & _
                  "VRBD_NoteIngresso, " & _
                  "VRBD_DataDenuncia, " & _
                  "VRBD_CorpoDenuncia, " & _
                  "VRBD_NumeroDenuncia, " & _
                  "VRBD_StazioneDenuncia, " & _
                  "VRBD_DataUscita, " & _
                  "VRBD_DanniRitr, " & _
                  "VRBD_NoteUscita) " & _
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
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataDenuncia) & "', 121), " & _
                  "'" & m_strCorpoDenuncia.Replace("'", "''") & "', " & _
                  "'" & m_strNumeroDenuncia.Replace("'", "''") & "', " & _
                  "'" & m_strStazioneDenuncia.Replace("'", "''") & "', " & _
                  "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataUscita) & "', 121), " & _
                  "'" & m_strDanniRitr.Replace("'", "''") & "', " & _
                  "'" & m_strNoteUscita.Replace("'", "''") & "')"

    Return strSql

  End Function



End Class
