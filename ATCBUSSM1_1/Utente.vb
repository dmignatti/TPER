Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Utente
    Private m_ID As Integer
    Private m_IDUser As String
    Private m_PWD As String
    Private m_IDResponsabile As Integer
    Private m_IDGruppo As Integer
    Private m_TipoUtente As Integer
    Private m_Cognome As String
    Private m_Nome As String
    Private m_Email As String
    Private m_Abilitato As Boolean
    Private m_DataUltimoAccesso As String
    Private m_OraUltimoAccesso As String
  Private m_NrAccessi As Integer
  Private m_Con As SqlConnection
  Private m_StoInserendo As Boolean    'DM2020.03
  Private m_RigaModifico As Integer    'DM2020.04
  Private m_StoAccettando As Boolean    'DM2020.05
  Private m_RigaAccetto As Integer    'DM2020.05


  Public Sub New(ByVal ID As Integer, ByVal oConn As SqlConnection)
    MyBase.New()
    m_Con = oConn
    FetchDataByID(ID, m_Con)
  End Sub

  Public Sub New(ByVal oConn As SqlConnection)
    MyBase.New()
    m_Con = oConn
    'FetchDataByID(ID, m_Con)
  End Sub

  Public Sub New()
    MyBase.New()
  End Sub

  '----------------------------------------------------------------------------------
  '------------------------------ PROPRIETA' ----------------------------------------
  '----------------------------------------------------------------------------------
  Public Property ID() As Integer
    Get
      Return m_ID
    End Get

    Set(ByVal Value As Integer)
      m_ID = Value
    End Set
  End Property

  Public Property IDUser() As String
    Get
      Return m_IDUser
    End Get

    Set(ByVal Value As String)
      m_IDUser = Trim(UCase(Value))
    End Set
  End Property

  Public Property PWD() As String
    Get
      Return m_PWD
    End Get

    Set(ByVal Value As String)
      m_PWD = Trim(UCase(Value))
    End Set
  End Property

  Public Property IDResponsabile() As Integer
    Get
      Return m_IDResponsabile
    End Get

    Set(ByVal Value As Integer)
      m_IDResponsabile = Value
    End Set
  End Property

  Public Property IDGruppo() As Integer
    Get
      Return m_IDGruppo
    End Get

    Set(ByVal Value As Integer)
      m_IDGruppo = Value
    End Set
  End Property

  Public Property TipoUtente() As Integer
    Get
      Return m_TipoUtente
    End Get

    Set(ByVal Value As Integer)
      m_TipoUtente = Value
    End Set
  End Property

  Public Property Cognome() As String
    Get
      Return m_Cognome
    End Get

    Set(ByVal Value As String)
      m_Cognome = Trim(Value)
    End Set
  End Property

  Public Property Nome() As String
    Get
      Return m_Nome
    End Get

    Set(ByVal Value As String)
      m_Nome = Trim(Value)
    End Set
  End Property

  Public Property Email() As String
    Get
      Return m_Email
    End Get

    Set(ByVal Value As String)
      m_Email = Trim(Value)
    End Set
  End Property

  Public Property Abilitato() As Boolean
    Get
      Return m_Abilitato
    End Get

    Set(ByVal Value As Boolean)
      m_Abilitato = Value
    End Set
  End Property

  Public Property DataUltimoAccesso() As String
    Get
      Return m_DataUltimoAccesso
    End Get

    Set(ByVal Value As String)
      m_DataUltimoAccesso = Trim(Value)
    End Set
  End Property

  Public Property OraUltimoAccesso() As String
    Get
      Return m_OraUltimoAccesso
    End Get

    Set(ByVal Value As String)
      m_OraUltimoAccesso = Trim(Value)
    End Set
  End Property

  Public Property NrAccessi() As Integer
    Get
      Return m_NrAccessi
    End Get

    Set(ByVal Value As Integer)
      m_NrAccessi = Value
    End Set
  End Property

  '----------------------------------------------------------------------------------
  '---------------------------------- METODI ----------------------------------------
  '----------------------------------------------------------------------------------
  Public Function FetchDataByID(ByVal ID As Integer, ByVal oConn As SqlConnection)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sSQL As String

    sSQL = "SELECT * FROM ATC_Utenti WHERE ID = " & ID
    cmd = New SqlCommand(sSQL, oConn)
    dr = cmd.ExecuteReader()
    While dr.Read()
      m_ID = dr.GetInt32(0)
      m_IDUser = dr.GetString(1)
      m_PWD = dr.GetString(2)
      m_IDResponsabile = dr.GetInt32(3)
      m_IDGruppo = dr.GetInt32(4)
      m_TipoUtente = dr.GetInt32(5)
      m_Cognome = dr.GetString(6)
      m_Nome = dr.GetString(7)
      m_Email = dr.GetString(8)
      m_Abilitato = dr.GetBoolean(9)
      m_DataUltimoAccesso = dr.GetString(10)
      m_OraUltimoAccesso = dr.GetString(11)
      m_NrAccessi = dr.GetInt32(12)
    End While
    dr.Close()
  End Function


  Public Function Insert() As String
    Dim sSQL As String

    sSQL = "INSERT INTO ATC_Utenti (IDUser, Pwd, IDResponsabile, IDGruppo, TipoUtente, Cognome, Nome, Email, Abilitato, DataUltimoAccesso, OraUltimoAccesso, NrAccessi) VALUES ('" & _
            Trim(Replace(m_IDUser, "'", "''")) & "', '" & _
            Trim(Replace(m_PWD, "'", "''")) & "', " & _
            m_IDResponsabile & ", " & _
            m_IDGruppo & ", " & _
            m_TipoUtente & ", '" & _
            Trim(Replace(m_Cognome, "'", "''")) & "', '" & _
            Trim(Replace(m_Nome, "'", "''")) & "', '" & _
            Trim(Replace(m_Email, "'", "''")) & "', " & _
            m_Abilitato & ", '" & DataUltimoAccesso & "', '" & _
            m_OraUltimoAccesso & "', 1" & ")"
    Insert = sSQL
  End Function

  Public Function Update() As String
    Dim sSQL As String

    sSQL = "UPDATE ATC_Utenti SET " & _
            "IDUser = '" & Trim(Replace(m_IDUser, "'", "''")) & "', " & _
            "PWD = '" & Trim(Replace(m_PWD, "'", "''")) & "', " & _
            "IDResponsabile = " & m_IDResponsabile & ", " & _
            "IDGruppo = " & m_IDGruppo & ", " & _
            "TipoUtente = " & m_TipoUtente & ", " & _
            "Cognome = '" & Trim(Replace(m_Cognome, "'", "''")) & "', " & _
            "Nome = '" & Trim(Replace(m_Nome, "'", "''")) & "', " & _
            "Email = '" & Trim(Replace(m_Email, "'", "''")) & "', " & _
            "DataUltimoAccesso = '" & m_DataUltimoAccesso & "', " & _
            "OraUltimoAccesso = '" & m_OraUltimoAccesso & "' " & _
            " WHERE ID = " & m_ID
    Update = sSQL
  End Function

  Public Function UpdateNrAccessi() As String
    Dim sSQL As String
    Dim fnc As New Funzioni
    Dim iNrAccessi As Integer
    sSQL = "SELECT ID, NrAccessi FROM ATC_Utenti WHERE ID = " & m_ID
    Dim cmdSQL As New SqlCommand(sSQL, m_Con)
    Dim myReader As SqlDataReader = cmdSQL.ExecuteReader()
    If myReader.Read() Then
      m_ID = myReader.GetInt32(0)
      m_NrAccessi = myReader.GetInt32(1)
    Else
      m_NrAccessi = 0
    End If
    m_DataUltimoAccesso = Day(Now) & "/" & Month(Now) & "/" & Year(Now)
    m_OraUltimoAccesso = TimeOfDay()
    myReader.Close()
    myReader = Nothing
    iNrAccessi = m_NrAccessi + 1

    sSQL = "UPDATE ATC_Utenti SET NrAccessi = " & iNrAccessi & ", " & _
            "DataUltimoAccesso = '" & m_DataUltimoAccesso & "', " & _
            "OraUltimoAccesso = '" & m_OraUltimoAccesso & "' " & _
            " WHERE ID = " & m_ID
    UpdateNrAccessi = sSQL
  End Function

  Public Function Delete() As String
    Dim sSQL As String

    sSQL = "DELETE FROM TipoAccesso WHERE ID = " & m_ID
    Delete = sSQL
  End Function

  Public Function Login(ByVal sUsername As String, ByVal sPassword As String, ByRef sMessaggio As String) As Boolean
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sSQL As String
    Dim sSQLUpdate As String
    Dim i As Integer
    Dim s As String
    Dim bRet As Boolean

		Try
			sSQL = "SELECT * FROM ATC_Utenti WHERE IDUser = '" & sUsername.Replace("'", "''") & "' AND pwd = '" & sPassword.Replace("'", "''") & "'"
			m_Con.Open()
			cmd = New SqlCommand(sSQL, m_Con)
			dr = cmd.ExecuteReader()
			If dr.Read Then
				'riempo l'oggetto
				m_ID = dr.Item("Id")
				m_IDUser = dr.Item("IdUSer")
				m_PWD = dr.Item("Pwd")
				m_IDResponsabile = dr.Item("IdResponsabile")
				m_TipoUtente = dr.Item("TipoUtente")
				m_Cognome = "" & dr.Item("Cognome")
				m_Nome = "" & dr.Item("Nome")
				m_Email = "" & dr.Item("EMail")
				m_Abilitato = dr.Item("Abilitato")
				m_DataUltimoAccesso = "" & dr.Item("DataUltimoAccesso")
				m_OraUltimoAccesso = "" & dr.Item("OraUltimoAccesso")
				m_NrAccessi = dr.Item("NrAccessi")
				bRet = True
			Else
				sMessaggio = "Utente non trovato"
				bRet = False
			End If
			dr.Close()
			dr = Nothing
			cmd = Nothing
			If bRet Then
				'aggiorno gli accessi
				sSQLUpdate = Me.UpdateNrAccessi()
				cmd = New SqlCommand(sSQLUpdate, m_Con)
				cmd.CommandText = sSQLUpdate
				cmd.ExecuteNonQuery()
			End If
      m_Con.Close()
      'm_Con.Dispose()
		Catch ex As Exception
			dr.Close()
      m_Con.Close()
      'm_Con.Dispose()
			bRet = False
		End Try
		Login = bRet
  End Function

  Public Function CheckAbil(ByVal IDModulo As Integer, ByVal idAzione As Integer) As Boolean
    Dim cmd As SqlCommand
    Dim sSQL As String

    CheckAbil = False
    If idAzione = 1 Then
      sSQL = "Select Count(*) From ATC_RelUtenteGruppo Where IdUtente = " & m_ID & " And IdGruppo In (Select IdGruppo From ATC_RelModuloGruppo Where IdModulo = " & IDModulo & ")"
    Else
      sSQL = "Select Count(*) From ATC_RelUtenteGruppo UG Left Join ATC_Gruppi G On UG.IDGruppo = G.ID Where G.Amministrazione <> 0 And UG.IdUtente = " & m_ID
    End If
    m_Con.Open()
    cmd = New SqlCommand(sSQL, m_Con)
    CheckAbil = cmd.ExecuteScalar >= 1
    m_Con.Close()
    ' m_Con.Dispose()
  End Function

  'DM2020.03
  Public Property bStoInserendo() As Boolean
    Get
      Return m_StoInserendo
    End Get

    Set(ByVal Value As Boolean)
      m_StoInserendo = Value
    End Set
  End Property
  'DM2020.04
  Public Property iRigaModifico() As Integer
    Get
      Return m_RigaModifico
    End Get

    Set(ByVal Value As Integer)
      m_RigaModifico = Value
    End Set
  End Property
  'DM2020.05
  Public Property bStoAccettando() As Boolean
    Get
      Return m_StoAccettando
    End Get

    Set(ByVal Value As Boolean)
      m_StoAccettando = Value
    End Set
  End Property
  'DM2020.04
  Public Property iRigaAccetto() As Integer
    Get
      Return m_RigaAccetto
    End Get

    Set(ByVal Value As Integer)
      m_RigaAccetto = Value
    End Set
  End Property
End Class
