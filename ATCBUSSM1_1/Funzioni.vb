Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Funzioni
    Public Sub New()
        MyBase.New()
    End Sub

    Function DataPerSQL(ByVal sData As String) As String
        Dim myArray() As String = Split(sData, "/")
        Dim s As String = myArray(1) & "/" & myArray(0) & "/" & myArray(2)
        Return s
    End Function

    Function FormattaData3(ByVal v As String) As String
        Dim n
        n = v
        If n = "0" Or n = "" Then
            FormattaData3 = ""
            Exit Function
        End If
        If Len(n) = 6 Then
            'FormattaData3 = Mid(n, 5, 2) & "/" & Mid(n, 3, 2) & "/" & Mid(n, 1, 2)
        Else
            FormattaData3 = Mid(n, 7, 2) & "/" & Mid(n, 5, 2) & "/" & Mid(n, 1, 4)
        End If
  End Function

  Function pCheckPermit(ByVal idModule As Integer, ByVal IdGroup As Integer, ByVal IdAction As Integer) As Boolean
    Dim Con As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim Com As New SqlCommand("Select Count(*) From ATC_RelMdouloGruppo Where IdModulo = @1 And IdGruppo = @2 And IdAction = @3", Con)
    Com.Parameters.Add("@1", SqlDbType.Int)
    Com.Parameters.Add("@2", SqlDbType.Int)
    Com.Parameters.Add("@3", SqlDbType.Int)
    Com.Parameters("@1").Value = idModule
    Com.Parameters("@2").Value = IdGroup
    Com.Parameters("@3").Value = IdAction
    pCheckPermit = Com.ExecuteScalar = 1
  End Function

  Public Shared Function FillReader(ByRef dr As SqlDataReader, ByVal strCnnString As String, ByVal sSqlQuery As String, ByRef cnn As SqlConnection) As Boolean

    Dim cmd As SqlCommand
    Try
      cnn.Open()
      cmd = New System.Data.SqlClient.SqlCommand(sSqlQuery, cnn)
      dr = cmd.ExecuteReader()
      Return True
    Catch ex As Exception
      Throw ex
    End Try
    cmd.Dispose()

  End Function

  Private Function GetPageID(ByVal nomePagina As String) As Integer
    Dim strSql As String
    Dim dr As SqlDataReader
    Dim ret As Integer
    Dim cnn As New System.Data.SqlClient.SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))

    strSql = "SELECT ID FROM ATC_DescrPagine WHERE NomePagina = '" & nomePagina & "'"
    If FillReader(dr, ConfigurationSettings.AppSettings("ConnectionString"), strSql, cnn) Then
      If dr.HasRows Then
        dr.Read()
        ret = dr("ID")
      Else
        ret = -1
      End If
      dr.Close()
    Else
      ret = -1
    End If
    cnn.Close()
    cnn.Dispose()
    Return ret

  End Function

  Function DescrPagina(ByVal NomePagina As String) As String
    Dim Descrizione As String
    Dim myReader As SqlDataReader
    Dim strSQL As String = "SELECT Descrizione FROM ATC_DescrPagine WHERE NomePagina = '" & NomePagina & "'"
    Dim cnn As New System.Data.SqlClient.SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))

    If FillReader(myReader, ConfigurationSettings.AppSettings("ConnectionString"), strSQL, cnn) Then
      If myReader.Read Then
        Descrizione = myReader.GetString(0)
      Else
        Descrizione = "Pagina non trovata"
      End If
      myReader.Close()
    End If
    cnn.Close()
    cnn.Dispose()
    DescrPagina = Descrizione

  End Function

  Function ScriviLog(ByVal IdUser As String, ByVal NomePagina As String, ByVal DescrAggiuntiva As String, ByVal IPAddress As String)

    Dim oConn As SqlConnection
    oConn = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    oConn.Open()

    Dim Descrizione As String = DescrPagina(NomePagina)
    Dim strSQL As String
    Dim myCommand As New SqlCommand
    Dim myTrans As SqlTransaction
    myTrans = oConn.BeginTransaction(IsolationLevel.ReadCommitted)
    myCommand.Connection = oConn
    myCommand.Transaction = myTrans

    strSQL = "INSERT INTO ATC_LOG (IdUser, IPClient, DescrAzione, IDPagina, navigatore) VALUES ('"
    strSQL = strSQL & UCase(IdUser) & "', '" & IPAddress & "', '" & Replace(Descrizione, "'", "`") & " - " & Replace(DescrAggiuntiva, "'", "`") & "', " & GetPageID(NomePagina) & ",'" & NomePagina & "')"
    Try
      myCommand.CommandText = strSQL
      myCommand.ExecuteNonQuery()
      myTrans.Commit()
    Catch e As Exception
      myTrans.Rollback()
    Finally
      oConn.Close()
    End Try

    oConn = Nothing

  End Function

  Function Questionario_Compilato(ByVal id As String, ByVal ipaddress As String, ByVal tipoutente As Integer) As Boolean
    Dim oConn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Dim cmd As New SqlCommand
    Dim res As Boolean
    res = True
    'res = False
    'If tipoutente = 2 Then


    '  Try
    '    oConn.Open()
    '    cmd.Connection = oConn
    '    cmd.CommandText = "SELECT count(*) as n " & _
    '    " FROM Accertatori_Questionario where Matricola = '" & id & "'"
    '    Dim n As Integer
    '    n = Convert.ToInt32(cmd.ExecuteScalar)
    '    If n > 0 Then
    '      res = True
    '    End If
    '    cmd.Dispose()
    '    oConn.Close()
    '    oConn.Dispose()

    '  Catch ex As Exception
    '    ScriviLog(id, "wf_questionario.aspx", "Errore nel controllo compilazione: " & ex.Message, ipaddress)
    '  End Try
    'Else
    '  res = True
    'End If
    Questionario_Compilato = res

  End Function
End Class
