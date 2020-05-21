Public Class atcbSession

  Private Const mk_strKeyName_UserID As String = "UserID"
  Private Const mk_strKeyName_SectionID As String = "SectionID"
	'Private Const mk_strKeyName_UserName As String = "UserName"
  'Private Const mk_strKeyName_LastLogin As String = "LastLogin"


  Private Const mk_intKeyCount As Integer = 3 'Resta (almeno per il momento) l'oggetto utente per compatibilità con le pagine vecchie.

  ' **************************************************************************************
  '     SHARED PROPERTIES
  ' **************************************************************************************
  Public Shared ReadOnly Property KN_UserID() As String
    Get
      Return mk_strKeyName_UserID
    End Get
  End Property

  Public Shared ReadOnly Property KN_SectionID() As String
    Get
      Return mk_strKeyName_SectionID
    End Get
  End Property

  ' **************************************************************************************
  '     PUBLIC SHARED METHODS
  ' **************************************************************************************
	Public Shared Function Open(ByRef CurrentSession As System.Web.SessionState.HttpSessionState, ByVal intUserID As Integer) As Boolean

		Try
			CurrentSession.Timeout = 3600
			CurrentSession.Add(mk_strKeyName_UserID, intUserID)
			CurrentSession.Add(mk_strKeyName_SectionID, 0)
			Return True
		Catch ex As Exception
			Return False
		End Try

	End Function

	Public Shared Sub Close(ByRef CurrentSession As System.Web.SessionState.HttpSessionState)

		Try
			If Not (CurrentSession Is Nothing) Then
				CurrentSession.Clear()
				CurrentSession.Abandon()
			End If
		Catch ex As Exception
		End Try

	End Sub

	Public Shared Function IsOn(ByRef CurrentSession As System.Web.SessionState.HttpSessionState) As Boolean

		Try
			If pSessionIsOn(CurrentSession) Then
				Return True
			Else
				Close(CurrentSession)
				Return False
			End If
		Catch ex As Exception
			Return False
		End Try

	End Function

	Public Shared Function Get_UserID(ByRef CurrentSession As System.Web.SessionState.HttpSessionState) As Integer

		Try
			Return System.Convert.ToInt32(CurrentSession(mk_strKeyName_UserID))
		Catch ex As Exception
			Return 0
		End Try

	End Function

	Public Shared Sub Set_UserID(ByRef CurrentSession As System.Web.SessionState.HttpSessionState, ByVal iValue As Integer)

		If Not (CurrentSession Is Nothing) Then
			CurrentSession(mk_strKeyName_UserID) = iValue
		End If

	End Sub

	Public Shared Function Get_SectionID(ByRef CurrentSession As System.Web.SessionState.HttpSessionState) As Integer

		Try
			Return System.Convert.ToInt32(CurrentSession(mk_strKeyName_SectionID))
		Catch ex As Exception
			Return 0
		End Try

	End Function

	Public Shared Sub Set_SectionID(ByRef CurrentSession As System.Web.SessionState.HttpSessionState, ByVal iValue As Integer)

		If Not (CurrentSession Is Nothing) Then
			CurrentSession(mk_strKeyName_SectionID) = iValue
		End If

	End Sub

	' **************************************************************************************
	'     PRIVATE SHARED METHODS
	' **************************************************************************************
	Private Shared Function pSessionIsOn(ByVal sess As System.Web.SessionState.HttpSessionState) As Boolean

		Try
			If (sess Is Nothing) Then
				Return False
			Else
				If (sess(mk_strKeyName_UserID) = 0) Then
					Return False
				Else
					Return True
				End If
			End If
		Catch ex As Exception
			Return False
		End Try

		'Try
		'  If (sess Is Nothing) Then
		'    Return False
		'  Else
		'    If (sess.Keys.Count > mk_intKeyCount) Then
		'      Return False
		'    Else
		'      If (sess(mk_strKeyName_UserID) = 0) Then
		'        Return False
		'      Else
		'        Return True
		'      End If
		'    End If
		'  End If
		'Catch ex As Exception
		'  Return False
		'End Try

	End Function

End Class
