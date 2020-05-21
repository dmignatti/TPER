Imports System.Data.SqlClient

Public Class atcbModules
  Inherits System.Collections.CollectionBase

  ' *********************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************
  Public Sub New()

    MyBase.New()
    Fetch()

  End Sub

  Public Sub New(ByVal intUserID As Integer)

    MyBase.New()
    Fetch(intUserID)

  End Sub

  Public Sub New(ByVal intUserID As Integer, ByVal intSection As Integer)

    MyBase.New()
    Fetch(intUserID, intSection)

  End Sub

  ' *********************************************************************************
  '     PROPERTIES
  ' *********************************************************************************
  Default Public ReadOnly Property Item(ByVal Index As Integer) As atcbModule
    Get
      Return MyBase.List.Item(Index)
    End Get
  End Property

  Public ReadOnly Property UBound() As Integer
    Get
      Return MyBase.List.Count - 1
    End Get
  End Property

  ' *********************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************
  Public Function Contains(ByVal intModuleID As Integer) As Boolean

    Dim RC As Boolean
    Dim pMod As atcbModule

    RC = False
    For Each pMod In MyBase.List
      If (pMod.ID = intModuleID) Then
        RC = True
        Exit For
      End If
    Next
    Return RC

  End Function

  ' *********************************************************************************
  '     PRIVATE METHODS
  ' *********************************************************************************
  Private Overloads Sub Fetch()

    Dim strSql As String

    strSql = "SELECT " & _
                  "* " & _
             "FROM " & _
                  "ATC_ModuliPortale " & _
             "WHERE " & _
                  "ATC_ModuliPortale.[Abilitato] = 1 " & _
             "ORDER BY " & _
                  "ATC_ModuliPortale.[Descrizione]"
    Fill(strSql)

  End Sub

  Private Overloads Sub Fetch(ByVal intUserID As Integer)

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                  "A.* " & _
             "FROM " & _
                  "ATC_ModuliPortale A " & _
                  "INNER JOIN ATC_RelModuloGruppo B ON A.[ID] = B.[IDModulo] " & _
                  "INNER JOIN ATC_RelUtenteGruppo C ON B.[IDGruppo] = C.[IDGruppo] " & _
             "WHERE " & _
                  "C.[IDUtente] = " & CStr(intUserID) & " AND " & _
                  "A.[Abilitato] = 1 " & _
             "ORDER BY " & _
                  "A.[Descrizione]"
    Fill(strSql)

  End Sub

  Private Overloads Sub Fetch(ByVal intUserID As Integer, ByVal intSection As Integer)

    Dim strSql As String

    strSql = "SELECT DISTINCT " & _
                  "A.* " & _
             "FROM " & _
                  "ATC_ModuliPortale A " & _
                  "INNER JOIN ATC_RelModuloGruppo B ON A.[ID] = B.[IDModulo] " & _
                  "INNER JOIN ATC_RelUtenteGruppo C ON B.[IDGruppo] = C.[IDGruppo] " & _
             "WHERE " & _
                  "C.[IDUtente] = " & CStr(intUserID) & " AND " & _
                  "A.[Abilitato] = 1 AND " & _
                  "A.[FK_Sect] = " & CStr(intSection) & " " & _
             "ORDER BY " & _
                  "A.[Descrizione]"
    Fill(strSql)

  End Sub

  Private Sub Fill(ByVal strQuerySql As String)

    Dim blnEnabled As Boolean
    Dim intID As Integer
    Dim strDesc, strPageToLoad As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
    End Try

    cmd = New SqlCommand(strQuerySql, cnn)
    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        Do While dr.Read
          intID = System.Convert.ToInt32(dr("ID"))
          blnEnabled = System.Convert.ToBoolean(dr("Abilitato"))
          strDesc = System.Convert.ToString(dr("Descrizione"))
          strPageToLoad = System.Convert.ToString(dr("CosaLancio"))
          MyBase.List.Add(New atcbModule(intID, strDesc, blnEnabled, strPageToLoad))
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Impossibile reperire i link ai moduli")
    Finally
      cmd.Dispose()
      cnn.Close()
      cnn.Dispose()
    End Try

  End Sub

End Class
