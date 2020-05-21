Imports System.Data.SqlClient

Public Class supVehicleRVI
  Inherits supVehicleRBT

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)
    MyBase.New(intRimzPK, strStato)
  End Sub

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Overrides Sub Save()

    Dim tr As New supTransaction
    tr.SqlCommands.Add(Me.Sql_Insert())
    tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRVI))
    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overrides Function Sql_Insert() As String

    Dim strSql As String

    strSql = "INSERT INTO Angr_VeicoloRVI " & _
                  "(VRVI_Mode, VRVI_PK, VRVI_FK_Rimz, VRVI_Targa, " & _
                  "VRVI_FK_User, VRVI_UserMatricola, VRVI_UserNominativo, " & _
                  "VRVI_DataIngresso, " & _
                  "VRVI_FK_TiMe, VRVI_Tipo, " & _
                  "VRVI_FK_MaMe, VRVI_Marca, " & _
                  "VRVI_FK_MoMe, VRVI_Modello, " & _
                  "VRVI_PesoPC, VRVI_Divisore, " & _
                  "VRVI_DanniRimz, VRVI_DanniScar, " & _
                  "VRVI_NoteIngresso, " & _
                  "VRVI_DataUscita, " & _
                  "VRVI_DanniRitr, " & _
                  "VRVI_NoteUscita) " & _
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
                  "'" & m_strDanniRitr.Replace("'", "''") & "', " & _
                  "'" & m_strNoteUscita.Replace("'", "''") & "')"

    Return strSql

  End Function

End Class
