Imports System.Data.SqlClient

Public Class supTransactionCnn

  Private m_strErrMsg As String
  Private m_Cmds As supSqlCommands

  ' *********************************************************************************************
  '     CREATION METHODS
  ' *********************************************************************************************
  Public Sub New()

    m_strErrMsg = ""
    m_Cmds = New supSqlCommands

  End Sub

  ' *********************************************************************************************
  '     PROPERTIES
  ' *********************************************************************************************
  Public ReadOnly Property SqlCommands() As supSqlCommands
    Get
      Return m_Cmds
    End Get
  End Property

  Public ReadOnly Property ErrorMessage() As String
    Get
      Return m_strErrMsg
    End Get
  End Property

  ' *********************************************************************************************
  '     PUBLIC METHODS
  ' *********************************************************************************************
  Public Function Execute() As Boolean

    Dim i As Integer
    Dim cnn As System.Data.SqlClient.SqlConnection
    Dim trn As System.Data.SqlClient.SqlTransaction

    Dim RC As Boolean = False

    CutNullCommands()
    If (m_Cmds.Count = 0) Then
      m_strErrMsg = "Nessun comando è stato eseguito."
    Else
      If OpenConnection(cnn) Then
        If BeginTransaction(cnn, trn) Then
          If ExecuteCommands(cnn, trn) Then
            RC = CommitTransaction(trn)
          Else
            RollbackTransaction(trn)
          End If
          trn.Dispose()
        End If
        cnn.Close()
      End If
      cnn.Dispose()
    End If

    Return RC

  End Function

  ' *********************************************************************************************
  '     PROTECTED METHODS
  ' *********************************************************************************************
  Protected Function OpenConnection(ByRef cnn As SqlConnection) As Boolean

    Try
      cnn = New System.Data.SqlClient.SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
      cnn.Open()
      Return True
    Catch ex As Exception
      m_strErrMsg = "Impossibile stabilire la connessione al database."
      Return False
    End Try

  End Function

  Protected Function BeginTransaction(ByRef cnn As SqlConnection, ByRef trn As SqlTransaction) As Boolean

    Try
      trn = cnn.BeginTransaction()
      Return True
    Catch ex As Exception
      m_strErrMsg = "Inizio transazione fallito."
      Return False
    End Try

  End Function

  Protected Function CommitTransaction(ByRef trn As SqlTransaction) As Boolean

    Try
      trn.Commit()
      Return True
    Catch ex As Exception
      m_strErrMsg = "Commit transazione fallito."
      Return False
    End Try

  End Function

  Protected Sub RollbackTransaction(ByRef trn As SqlTransaction)

    Try
      trn.Rollback()
      m_strErrMsg = "Errore in uno dei comandi SQL."
    Catch ex As Exception
      m_strErrMsg = "Rollback transazione fallito."
    End Try

  End Sub

  Protected Sub CutNullCommands()

    Dim i As Integer = 0

    Do While (i <= m_Cmds.UBound)
      If (m_Cmds(i).Text.Equals("")) Then
        m_Cmds.RemoveAt(i)
      Else
        i = i + 1
      End If
    Loop

  End Sub

  Protected Function ExecuteCommands(ByRef cnn As SqlConnection, ByRef trn As SqlTransaction) As Boolean

    Dim i As Integer

    Try
      For i = 0 To m_Cmds.UBound
        Dim cmd As New System.Data.SqlClient.SqlCommand(m_Cmds(i).Text, cnn, trn)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
      Next
      Return True
    Catch ex As Exception
      Return False
    End Try

  End Function

End Class
