Imports System.Data.SqlClient
'Imports System.Web.UI.WebControls
Imports Microsoft.Web.UI.WebControls


Public Class atcbWUser

	' *****************************************************************************************
	'     METODI DI REPERIMENTO DATI
	' *****************************************************************************************
	Public Shared Sub FetchGeneral(ByVal intUserID As Integer, ByRef strUserName As String, ByRef strLastLogin As String)

		Dim strSql As String
    Dim cnn As SqlConnection
		Dim cmd As SqlCommand
		Dim dr As SqlDataReader

		strSql = "SELECT " & _
									"Cognome, Nome, " & _
									"DataUltimoAccesso, OraUltimoAccesso " & _
						 "FROM " & _
									"ATC_Utenti " & _
						 "WHERE " & _
									"ATC_Utenti.[ID] = " & CStr(intUserID)

		cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
		Try
			cnn.Open()
		Catch ex As Exception
			cnn.Dispose()
			Throw New Exception("Impossibile stabilire una connessione ai dati.")
		End Try

		cmd = New SqlCommand(strSql, cnn)
		Try
			dr = cmd.ExecuteReader()
			If dr.HasRows Then
				dr.Read()
				strUserName = System.Convert.ToString(dr("Cognome")) & " " & System.Convert.ToString(dr("Nome"))
				strLastLogin = System.Convert.ToString(dr("DataUltimoAccesso")) & " " & System.Convert.ToString(dr("OraUltimoAccesso"))
			End If
			dr.Close()
		Catch ex As Exception
			Throw New Exception("Impossibile reperire i dati dell'utente.")
		Finally
			cmd.Dispose()
			cnn.Close()
			cnn.Dispose()
		End Try

	End Sub

	Public Shared Function CheckModule(ByVal intUserID As Integer, ByVal intModuleID As Integer) As Boolean

		Dim blnRC As Boolean
		Dim strSql As String
		Dim cnn As SqlConnection
		Dim cmd As SqlCommand
		Dim dr As SqlDataReader

		strSql = "SELECT " & _
									"(ISNULL(COUNT(*), 0)) AS TotCount " & _
						 "FROM " & _
									"(SELECT * FROM ATC_ModuliPortale WHERE ATC_ModuliPortale.[ID] = " & intModuleID.ToString() & " AND ATC_ModuliPortale.[Abilitato] = 1) A " & _
									"INNER JOIN ATC_RelModuloGruppo B ON A.[ID] = B.[IDModulo] " & _
									"INNER JOIN (SELECT * FROM ATC_RelUtenteGruppo WHERE ATC_RelUtenteGruppo.[IDUtente] = " & intUserID.ToString() & ") C ON B.[IDGruppo] = C.[IDGruppo]"

		cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
		Try
			cnn.Open()
		Catch ex As Exception
			cnn.Dispose()
			Throw New Exception("Impossibile stabilire una connessione ai dati.")
		End Try

		cmd = New SqlCommand(strSql, cnn)
		Try
			dr = cmd.ExecuteReader()
			If dr.HasRows Then
				dr.Read()
				blnRC = (System.Convert.ToInt32(dr("TotCount")) > 0)
			Else
				blnRC = False
			End If
			dr.Close()
		Catch ex As Exception
			Throw New Exception("Impossibile reperire il modulo.")
		Finally
			cnn.Close()
			cmd.Dispose()
			cnn.Dispose()
		End Try

		Return blnRC

	End Function

	' *****************************************************************************************
	'     METODI DI LOGIN
	' *****************************************************************************************
	Public Shared Sub Login(ByVal strLoginName As String, ByVal strPassword As String, ByRef intUserID As Integer)

		Dim strSql As String
		Dim cnn As SqlConnection
		Dim cmd As SqlCommand
		Dim dr As SqlDataReader

		intUserID = 0

    strSql = "SELECT " & _
        "ATC_Utenti.[ID], ATC_Utenti.[Pwd] " & _
       "FROM " & _
        "ATC_Utenti " & _
       "WHERE  (Abilitato = 1) and  " & _
        "ATC_Utenti.[IDUser] = '" & strLoginName.Replace("'", "''") & "'"

		cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
		Try
			cnn.Open()
		Catch ex As Exception
			cnn.Dispose()
			Throw New Exception("Impossibile stabilire una connessione ai dati.")
		End Try

		cmd = New SqlCommand(strSql, cnn)
		Try
			dr = cmd.ExecuteReader()
			If dr.HasRows Then
				dr.Read()
				If (strPassword = System.Convert.ToString(dr("Pwd"))) Then
					intUserID = System.Convert.ToInt32(dr("ID"))
					dr.Close()
				Else
					dr.Close()
					Throw New Exception("")
				End If
			End If
		Catch ex As Exception
			Throw New Exception("Impossibile effettare il login.")
		Finally
			cmd.Dispose()
			cnn.Close()
			cnn.Dispose()
		End Try

	End Sub

	Public Shared Function Login(ByVal strLoginName As String) As Integer

		Dim strSql As String
		Dim cnn As SqlConnection
		Dim cmd As SqlCommand
		Dim dr As SqlDataReader

		Dim intUserID As Integer = 0

    strSql = "SELECT " & _
     "ATC_Utenti.[ID], ATC_Utenti.[Pwd] " & _
     "FROM " & _
     "ATC_Utenti " & _
     "WHERE (Abilitato = 1) and " & _
     "ATC_Utenti.[IDUser] = '" & strLoginName.Replace("'", "''") & "'"

		cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
		Try
			cnn.Open()
		Catch ex As Exception
			cnn.Dispose()
			Login = 0
			Throw New Exception("Impossibile stabilire una connessione ai dati.")
		End Try

		cmd = New SqlCommand(strSql, cnn)
		Try
			dr = cmd.ExecuteReader()
			If dr.HasRows Then
				dr.Read()
				intUserID = System.Convert.ToInt32(dr("ID"))
				dr.Close()
			End If
		Catch ex As Exception
			Login = 0
			Throw New Exception("Impossibile effettare il login.")
		Finally
			cmd.Dispose()
			cnn.Close()
			cnn.Dispose()
		End Try

		Login = intUserID

	End Function

	' *****************************************************************************************
	'     METODI DI CREAZIONE MENU
	' *****************************************************************************************
	Public Shared Sub LoadMenuMain(ByVal intUserID As Integer, ByRef tbl As Table)

		Dim intCount, intColWidth As Integer
		Dim strSql As String
		Dim cnn As SqlConnection
		Dim cmd As SqlCommand
		Dim dr As SqlDataReader
		Dim row As TableRow

		tbl.Rows.Clear()
		tbl.Width = Unit.Percentage(100)
		tbl.CellPadding = 1
		tbl.CellSpacing = 1
		tbl.CssClass = "tbrMenu"

		strSql = "SELECT DISTINCT " & _
			"A.FK_Sect, B.Sect_Desc " & _
			"FROM " & _
			"ATC_ModuliPortale A " & _
			"INNER JOIN Tabl_Section B ON A.[FK_Sect] = B.[Sect_PK] " & _
			"INNER JOIN ATC_RelModuloGruppo C ON A.[ID] = C.[IDModulo] " & _
			"INNER JOIN ATC_RelUtenteGruppo D ON C.[IDGruppo] = D.[IDGruppo] " & _
			"WHERE " & _
			"D.[IDUtente] = " & CStr(intUserID) & " AND " & _
			"A.[Abilitato] = 1 " & _
			"ORDER BY " & _
			"Sect_Desc"

		cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
		Try
			cnn.Open()
		Catch ex As Exception
			cnn.Dispose()
			Throw New Exception("Impossibile stabilire una connessione ai dati.")
		End Try

		cmd = New SqlCommand(strSql, cnn)
		Try
			dr = cmd.ExecuteReader()
			If dr.HasRows() Then
				intCount = 0
				intColWidth = tbl.Width.Value / 5
				Do While dr.Read()
					If ((intCount Mod 5) = 0) Then
						row = New TableRow
						tbl.Rows.Add(row)
						intCount = intCount + 1
					End If
					row.Cells.Add(GetCell(0, "", "tbrMenu_SubItem", 20, 10))
					row.Cells(row.Cells.Count - 1).Controls.Add(GetHyperLink(CStr(dr("Sect_Desc")), "wf_main.aspx?" & atcbConstant.QS_SectionID & "=" & CStr(dr("FK_Sect"))))
				Loop
				dr.Close()
			Else
				dr.Close()
				Throw New Exception("")
			End If
		Catch ex As Exception
			Throw New Exception("Nessuna sezione comandi abilitata")
		Finally
			cmd.Dispose()
			cnn.Close()
			cnn.Dispose()
		End Try

	End Sub

	Public Overloads Shared Sub LoadMenu(ByVal intUserID As Integer, ByVal intSection As Integer, ByRef tbl As Table)

		Dim i, intColWidth As Integer
		Dim row As TableRow
		Dim pMods As New atcbModules(intUserID, intSection)

		Try
			tbl.Rows.Clear()
			tbl.Width = Unit.Percentage(100)
			tbl.CellPadding = 1
			tbl.CellSpacing = 1
			tbl.CssClass = "tbrMenu"
			intColWidth = tbl.Width.Value / 5
			For i = 0 To pMods.UBound
				If ((i Mod 5) = 0) Then
					row = New TableRow
					tbl.Rows.Add(row)
				End If
				row.Cells.Add(GetCell(0, "", "tbrMenu_SubItem", 20, 10))
				row.Cells(row.Cells.Count - 1).Controls.Add(GetHyperLink(pMods(i).Desc, pMods(i).NavigateUrl))
			Next
		Catch ex As Exception
			Throw ex
		End Try

	End Sub

	'Public Overloads Shared Sub LoadMenu(ByVal intUserID As Integer, ByRef tvw As TreeView)

	'  Dim strSql, strSqlSections, strSqlModules, strSqlPermission As String
	'  Dim strParentTK As String
	'  Dim cnn As SqlConnection
	'  Dim cmd As SqlCommand
	'  Dim dr As SqlDataReader
	'  Dim nd, ndLastSection As TreeNode

	'  ' Permission dell'utente loggato.
	'  strSqlPermission = _
	'  "SELECT DISTINCT " & _
	'      "X.[ID] " & _
	'  "FROM " & _
	'      "ATC_ModuliPortale X " & _
	'      "INNER JOIN ATC_RelModuloGruppo Y ON X.[ID] = Y.[IDModulo] " & _
	'      "INNER JOIN ATC_RelUtenteGruppo Z ON Y.[IDGruppo] = Z.[IDGruppo] " & _
	'  "WHERE " & _
	'      "Z.IDUtente = " & CStr(intUserID)

	'  ' Preleva le sezioni.
	'  strSqlSections = _
	'  "SELECT " & _
	'      "('S') AS XFlag, Sect_TK AS XTK, Sect_Desc AS XDesc, " & _
	'      "('') AS XPage, (NULL) AS XQSMode " & _
	'  "FROM " & _
	'      "Tabl_Section " & _
	'  "WHERE " & _
	'      "EXISTS " & _
	'      "(SELECT " & _
	'          "* " & _
	'      "FROM " & _
	'          "(SELECT " & _
	'              "A.Sect_TK AS TK " & _
	'          "FROM " & _
	'              "Tabl_Section A " & _
	'              "INNER JOIN ATC_ModuliPortale B ON A.Sect_PK = B.FK_Sec " & _
	'          "WHERE " & _
	'              "B.[ID] IN(" & strSqlPermission & ")) W " & _
	'      "WHERE " & _
	'          "W.TK LIKE Sect_TK + '%')"

	'  ' Preleva i dati dei moduli abilitati.
	'  strSqlModules = _
	'  "SELECT " & _
	'      "('M') AS XFlag, (B.Sect_TK + ';M') AS XTK, A.Descrizione AS XDesc, " & _
	'      "A.CosaLancio AS XPage, A.QSMode AS XQSMode " & _
	'  "FROM " & _
	'      "ATC_ModuliPortale A " & _
	'      "INNER JOIN Tabl_Section B ON A.FK_Sec = B.Sect_PK " & _
	'  "WHERE " & _
	'      "A.[ID] IN (" & strSqlPermission & ")"

	'  ' Preleva l'albero dei menu.
	'  strSql = "(" & strSqlSections & " UNION " & strSqlModules & ") ORDER BY XTK, XDesc"
	'  cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
	'  cnn.Open()
	'  cmd = New SqlCommand(strSql, cnn)
	'  dr = cmd.ExecuteReader()
	'  If dr.HasRows Then
	'    Do While dr.Read()
	'      nd = New TreeNode
	'      nd.Text = dr("XDesc")
	'      nd.NodeData = dr("XTK")
	'      If (dr("XFlag") = "M") Then
	'        ' Il nodo da aggiungere è un modulo, e va aggiunto all'ultima sezione.
	'        nd.NavigateUrl = ""
	'        nd.Target = ""
	'        ndLastSection.Nodes.Add(nd)
	'      ElseIf (dr("XFlag") = "S") Then
	'        ' Il nodo da aggiungere è una sezione.
	'        If (InStr(1, nd.NodeData, ";") = 0) Then
	'          ' La sezione è primitiva (non ha parent).
	'          tvw.Nodes.Add(nd)
	'        Else
	'          ' Ricerca a ritroso del nodo sezione padre.
	'          strParentTK = StrReverse(Mid(StrReverse(nd.NodeData), InStr(1, StrReverse(nd.NodeData), ";") + 1))
	'          Do While (strParentTK <> ndLastSection.NodeData)
	'            ndLastSection = ndLastSection.Parent
	'          Loop
	'          ndLastSection.Nodes.Add(nd)
	'        End If
	'        ndLastSection = nd
	'      End If
	'    Loop
	'  End If
	'  dr.Close()
	'  cmd.Dispose()
	'  cnn.Close()
	'  cnn.Dispose()

	'End Sub

    Public Overloads Shared Sub LoadMenu(ByVal intUserID As Integer, ByRef tvw As TreeView)

        Dim strSql, strSqlSections, strSqlModules, strSqlPermission As String
        Dim strNodeUrl As String
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim nd, ndLastSection As TreeNode

        ' Permission dell'utente loggato.
        strSqlPermission = _
        "SELECT DISTINCT " & _
         "X.[ID] " & _
        "FROM " & _
         "ATC_ModuliPortale X " & _
         "INNER JOIN ATC_RelModuloGruppo Y ON X.[ID] = Y.[IDModulo] " & _
         "INNER JOIN ATC_RelUtenteGruppo Z ON Y.[IDGruppo] = Z.[IDGruppo] " & _
        "WHERE " & _
         "Z.IDUtente = " & CStr(intUserID)

        ' Preleva le sezioni.
        strSqlSections = _
        "SELECT " & _
         "('S') AS XFlag, Sect_TK AS XTK, Sect_Desc AS XDesc, " & _
         "('') AS XPage, (0) AS XID, (NULL) AS XQSMode " & _
        "FROM " & _
         "Tabl_Section " & _
        "WHERE " & _
         "EXISTS " & _
         "(SELECT " & _
         "* " & _
         "FROM " & _
         "(SELECT " & _
         "A.Sect_TK AS TK " & _
         "FROM " & _
         "Tabl_Section A " & _
         "INNER JOIN ATC_ModuliPortale B ON A.Sect_PK = B.FK_Sect " & _
         "WHERE " & _
         "B.[ID] IN(" & strSqlPermission & ")) W " & _
         "WHERE " & _
         "W.TK LIKE Sect_TK + '%')"

        ' Preleva i dati dei moduli abilitati.
        strSqlModules = _
        "SELECT " & _
         "('M') AS XFlag, (B.Sect_TK + ';M') AS XTK, A.Descrizione AS XDesc, " & _
         "A.CosaLancio AS XPage, A.[ID] AS XID, A.QSMode AS XQSMode " & _
        "FROM " & _
         "ATC_ModuliPortale A " & _
         "INNER JOIN Tabl_Section B ON A.FK_Sect = B.Sect_PK " & _
        "WHERE " & _
         "A.[ID] IN (" & strSqlPermission & ")"

        ' Preleva l'albero dei menu.
        strSql = "(" & strSqlSections & " UNION " & strSqlModules & ") ORDER BY XTK, XDesc"

        cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
        Try
            cnn.Open()
        Catch ex As Exception
            cnn.Dispose()
            Throw New Exception("Impossibile stabilire una connessione ai dati.")
        End Try

        cmd = New SqlCommand(strSql, cnn)
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Do While dr.Read()
                    nd = New TreeNode
                    'nd.DefaultStyle = Get_DefaultStyle()
                    'nd.HoverStyle = Get_HoverStyle()
                    'nd.SelectedStyle = Get_SelectedStyle()
                    nd.Text = dr("XDesc")
                    nd.NodeData = dr("XTK")
                    If (InStr(1, nd.NodeData, ";") = 0) Then
                        ' La sezione è primitiva (non ha parent).
                        tvw.Nodes.Add(nd)
                        ndLastSection = nd
                    Else
                        If (dr("XFlag") = "M") Then
                            ' Il nodo da aggiungere è un modulo.
                            strNodeUrl = System.Convert.ToString(dr("XPage")) & "?" & atcbConstant.QS_ModuleID & "=" & System.Convert.ToString(dr("XID"))
                            If (System.Convert.ToInt32(dr("XQSMode")) <> 0) Then
                                strNodeUrl = strNodeUrl & "&" & atcbConstant.QS_Mode & "=" & System.Convert.ToString(dr("XQSMode"))
                            End If
                            nd.NavigateUrl = strNodeUrl
                            nd.Target = "fraModule"
                        Else
                            nd.NavigateUrl = "wf_welcome.aspx"
                            nd.Target = "fraModule"
                        End If
                        AddNode(dr("XFlag"), nd, ndLastSection)
                    End If
                Loop
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile costruire la mappa del sito.")
        Finally
            cmd.Dispose()
            cnn.Close()
            cnn.Dispose()
        End Try

    End Sub

    Public Shared Sub AddNode(ByVal strXFlag As String, ByRef nd As TreeNode, ByRef ndLastSection As TreeNode)

        Dim strParentTK As String = StrReverse(Mid(StrReverse(nd.NodeData), InStr(1, StrReverse(nd.NodeData), ";") + 1))

        ' Ricerca a ritroso del nodo sezione padre.
        Do While (strParentTK <> ndLastSection.NodeData)
            ndLastSection = ndLastSection.Parent
        Loop
        ndLastSection.Nodes.Add(nd)
        If (strXFlag = "S") Then
            ndLastSection = nd
        End If

    End Sub

    Protected Shared Function Get_DefaultStyle() As Microsoft.Web.UI.WebControls.CssCollection

        Dim stl As New Microsoft.Web.UI.WebControls.CssCollection
        stl.Add("border", "none")
        stl.Add("background", "White")
        stl.Add("color", "Black")
        stl.Add("font-family", "tahoma")
        stl.Add("font-size", "8pt")
        Return stl

    End Function

    Protected Shared Function Get_HoverStyle() As Microsoft.Web.UI.WebControls.CssCollection

        Dim stl As New Microsoft.Web.UI.WebControls.CssCollection
        stl.Add("border", "none")
        stl.Add("background", "White")
        stl.Add("color", "Black")
        stl.Add("font-family", "tahoma")
        stl.Add("font-weight", "bold")
        stl.Add("font-size", "8pt")
        stl.Add("text-decoration", "underline")
        Return stl

    End Function

    Protected Shared Function Get_SelectedStyle() As Microsoft.Web.UI.WebControls.CssCollection

        Dim stl As New Microsoft.Web.UI.WebControls.CssCollection
        stl.Add("border", "solid 1px Black")
        stl.Add("background", "Firebrick")
        stl.Add("color", "White")
        stl.Add("font-family", "tahoma")
        stl.Add("font-weight", "bold")
        stl.Add("font-size", "8pt")
        Return stl

    End Function

    ' *****************************************************************************************
    '     METODI DI INTERAZIONE CON Tabl_Rimozione
    ' *****************************************************************************************
    Public Shared Function GetVehicleState(ByVal intVehicleID As Integer) As String

        Dim strState As String
        Dim strSql As String
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        strSql = "SELECT " & _
         "Rimz_Stato " & _
         "FROM " & _
         "Tabl_Rimozione " & _
         "WHERE " & _
         "Rimz_PK = " & CStr(intVehicleID) & " AND " & _
         "((Rimz_Stato = 'DSV') OR (Rimz_Stato = 'DPT') OR (Rimz_Stato = 'INC') OR (Rimz_Stato = 'INS'))"

        cnn = New SqlConnection(atcbConstant.CS_CnnStringATCBUSSM)
        Try
            cnn.Open()
        Catch ex As Exception
            cnn.Dispose()
            Throw New Exception("Impossibile stabilire una connessione ai dati.")
        End Try

        cmd = New SqlCommand(strSql, cnn)
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                strState = dr.GetString(0)
                dr.Close()
            Else
                dr.Close()
                Throw New Exception("")
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile reperire i dati del veicolo.")
        Finally
            cmd.Dispose()
            cnn.Close()
            cnn.Dispose()
        End Try

        Return strState

    End Function

    Public Shared Function DemolishVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        If supVehicle.VehicleIsLocked(intVehicleID) Then
            Throw New Exception("Impossibile cancellare il veicolo. Il record è lockato da un altro utente.")
        Else
            strSql = "UPDATE " & _
             "Tabl_Rimozione " & _
             "SET " & _
             "Rimz_StatoOld = Rimz_Stato, " & _
             "Rimz_Stato = 'DML' " & _
             "WHERE " & _
             "Rimz_PK = " & CStr(intVehicleID)
            tr.SqlCommands.Add(strSql)
            strSql = "INSERT INTO Log_Bussm " & _
             "(LBus_DataOra, " & _
             "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
             "LBus_FK_Rimz, LBus_Targa, " & _
             "LBus_Action, LBus_Note) " & _
             "VALUES " & _
             "(GETDATE(), " & _
             CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
             CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
             "'Demolizione', '" & strNote.Replace("'", "''") & "')"
            tr.SqlCommands.Add(strSql)
            Return tr.Execute()
        End If

    End Function

    Public Shared Function RecoverDemolishedVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        strSql = "UPDATE " & _
         "Tabl_Rimozione " & _
         "SET " & _
         "Rimz_Stato = Rimz_StatoOld, " & _
         "Rimz_StatoOld = NULL " & _
         "WHERE " & _
         "Rimz_PK = " & CStr(intVehicleID)
        tr.SqlCommands.Add(strSql)
        strSql = "INSERT INTO Log_Bussm " & _
         "(LBus_DataOra, " & _
         "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
         "LBus_FK_Rimz, LBus_Targa, " & _
         "LBus_Action, LBus_Note) " & _
         "VALUES " & _
         "(GETDATE(), " & _
         CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
         CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
         "'Annullamento demolizione', '" & strNote.Replace("'", "''") & "')"
        tr.SqlCommands.Add(strSql)
        Return tr.Execute()

    End Function

    Public Shared Function DeleteVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        If supVehicle.VehicleIsLocked(intVehicleID) Then
            Throw New Exception("Impossibile cancellare il veicolo. Il record è lockato da un altro utente.")
        Else
            strSql = "UPDATE " & _
             "Tabl_Rimozione " & _
             "SET " & _
             "Rimz_StatoOld = Rimz_Stato, " & _
             "Rimz_Stato = 'DEL' " & _
             "WHERE " & _
             "Rimz_PK = " & CStr(intVehicleID)
            tr.SqlCommands.Add(strSql)
            strSql = "INSERT INTO Log_Bussm " & _
             "(LBus_DataOra, " & _
             "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
             "LBus_FK_Rimz, LBus_Targa, " & _
             "LBus_Action, LBus_Note) " & _
             "VALUES " & _
             "(GETDATE(), " & _
             CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
             CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
             "'Cancellazione', '" & strNote.Replace("'", "''") & "')"
            tr.SqlCommands.Add(strSql)
            Return tr.Execute()
        End If

    End Function

    Public Shared Function RecoverDeletedVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        strSql = "UPDATE " & _
         "Tabl_Rimozione " & _
         "SET " & _
         "Rimz_Stato = Rimz_StatoOld, " & _
         "Rimz_StatoOld = NULL " & _
         "WHERE " & _
         "Rimz_PK = " & CStr(intVehicleID)
        tr.SqlCommands.Add(strSql)
        strSql = "INSERT INTO Log_Bussm " & _
         "(LBus_DataOra, " & _
         "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
         "LBus_FK_Rimz, LBus_Targa, " & _
         "LBus_Action, LBus_Note) " & _
         "VALUES " & _
         "(GETDATE(), " & _
         CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
         CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
         "'Annullamento cancellazione', '" & strNote.Replace("'", "''") & "')"
        tr.SqlCommands.Add(strSql)
        Return tr.Execute()

    End Function

    Public Shared Function ShadowVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        If supVehicle.VehicleIsLocked(intVehicleID) Then
            Throw New Exception("Impossibile cancellare il veicolo. Il record è lockato da un altro utente.")
        Else
            strSql = "UPDATE " & _
             "Tabl_Rimozione " & _
             "SET " & _
             "Rimz_StatoOld = Rimz_Stato, " & _
             "Rimz_Stato = 'SHA' " & _
             "WHERE " & _
             "Rimz_PK = " & CStr(intVehicleID)
            tr.SqlCommands.Add(strSql)
            strSql = "INSERT INTO Log_Bussm " & _
             "(LBus_DataOra, " & _
             "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
             "LBus_FK_Rimz, LBus_Targa, " & _
             "LBus_Action, LBus_Note) " & _
             "VALUES " & _
             "(GETDATE(), " & _
             CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
             CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
             "'Shadowing', '" & strNote.Replace("'", "''") & "')"
            tr.SqlCommands.Add(strSql)
            Return tr.Execute()
        End If

    End Function

    Public Shared Function RecoverShadowedVehicle(ByVal intUserID As Integer, ByVal intVehicleID As Integer, ByVal strTarga As String, ByVal strNote As String) As Boolean

        Dim strUserName, strLastLogin As String
        Dim strSql As String
        Dim tr As New supTransaction

        FetchGeneral(intUserID, strUserName, strLastLogin)
        strSql = "UPDATE " & _
         "Tabl_Rimozione " & _
         "SET " & _
         "Rimz_Stato = Rimz_StatoOld, " & _
         "Rimz_StatoOld = NULL " & _
         "WHERE " & _
         "Rimz_PK = " & CStr(intVehicleID)
        tr.SqlCommands.Add(strSql)
        strSql = "INSERT INTO Log_Bussm " & _
         "(LBus_DataOra, " & _
         "LBus_Bussm_FK_User, LBus_Bussm_UserName, " & _
         "LBus_FK_Rimz, LBus_Targa, " & _
         "LBus_Action, LBus_Note) " & _
         "VALUES " & _
         "(GETDATE(), " & _
         CStr(intUserID) & ", '" & strUserName.Replace("'", "''") & "', " & _
         CStr(intVehicleID) & ", '" & strTarga.Replace("'", "''") & "', " & _
         "'Annullamento shadowing', '" & strNote.Replace("'", "''") & "')"
        tr.SqlCommands.Add(strSql)
        Return tr.Execute()

    End Function

    ' *****************************************************************************************
    '     METODI DI PRIVATI VARI
    ' *****************************************************************************************
    Private Shared Function GetCell(ByVal intColSpan As Integer, ByVal strText As String, ByVal strCssClass As String, ByVal intWidth As Integer, ByVal intHeight As Integer) As TableCell

        Dim cell As New TableCell
        If (intColSpan > 1) Then
            cell.ColumnSpan = intColSpan
        End If
        cell.Text = strText
        cell.CssClass = strCssClass
        cell.Width = Unit.Percentage(intWidth)
        cell.Height = Unit.Pixel(intHeight)
        Return cell

    End Function

    Private Shared Function GetHyperLink(ByVal strText As String, ByVal strNavigateUrl As String) As HyperLink

        Dim hlk As New HyperLink
        hlk.Text = strText
        hlk.Width = Unit.Percentage(100)
        hlk.Font.Name = "Tahoma"
        hlk.Font.Size = FontUnit.Point(8)
        hlk.ForeColor = System.Drawing.Color.Navy
        hlk.NavigateUrl = strNavigateUrl
        Return hlk

    End Function

    Public Shared Function BlockDayCount(ByVal intVehicleID As Integer, ByVal dtmDateBlock As DateTime) As Boolean

        Dim strSql As String
        Dim tr As New supTransaction

        strSql = "UPDATE " & _
         "Tabl_Rimozione " & _
         "SET " & _
         "Rimz_DateBlock = CONVERT(datetime, '" & supFunction.sqlDate121(dtmDateBlock) & "', 121) " & _
         "WHERE " & _
         "Rimz_PK = " & intVehicleID

        tr.SqlCommands.Add(strSql)
        Return tr.Execute()

    End Function

End Class
