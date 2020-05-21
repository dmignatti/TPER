Imports System.Data.SqlClient

Public Class supVehicleSearch

  Public Enum VehicleStateEnum As Integer
    vsePresent
    vsePresentCompleted
    vseDemolished
    vseDeleted
    vseShadowed
    vseHND
    vseRBD
    vseRBT
    vseRSO
    vseRTP
    vseRTR
    vseRVI
  End Enum

  Protected m_intState As VehicleStateEnum
  Protected m_strPlate As String
  Protected m_intFK_TiMe As Integer
  Protected m_intFK_MaMe As Integer
  Protected m_intFK_MoMe As Integer
  Protected m_dtmDateIn_Begin As DateTime
  Protected m_dtmDateIn_End As DateTime
  Protected m_dtmDateOut_Begin As DateTime
  Protected m_dtmDateOut_End As DateTime
  Protected m_Vehicles As supVehicles

  ' ***************************************************************************************
  '     CREATION METHODS
  ' ***************************************************************************************
  Public Sub New()

    m_intState = VehicleStateEnum.vsePresent
    m_strPlate = ""
    m_intFK_TiMe = 0
    m_intFK_MaMe = 0
    m_intFK_MoMe = 0
    m_dtmDateIn_Begin = getDefaultDateBegin()
    m_dtmDateIn_End = getDefaultDateEnd()
    m_dtmDateOut_Begin = getDefaultDateBegin()
    m_dtmDateOut_End = getDefaultDateEnd()
    m_Vehicles = New supVehicles

  End Sub

  Public Sub New(ByVal intState As VehicleStateEnum, ByVal strPlate As String, ByVal intFK_TiMe As Integer, ByVal intFK_MaMe As Integer, ByVal intFK_MoMe As Integer)

    m_intState = intState
    m_strPlate = strPlate.Trim.ToUpper()
    m_intFK_TiMe = intFK_TiMe
    m_intFK_MaMe = intFK_MaMe
    m_intFK_MoMe = intFK_MoMe
    m_dtmDateIn_Begin = getDefaultDateBegin()
    m_dtmDateIn_End = getDefaultDateEnd()
    m_dtmDateOut_Begin = getDefaultDateBegin()
    m_dtmDateOut_End = getDefaultDateEnd()
    m_Vehicles = New supVehicles

  End Sub

  ' ***************************************************************************************
  '     PROPERTIES
  ' ***************************************************************************************
  Public Property State() As VehicleStateEnum
    Get
      Return m_intState
    End Get
    Set(ByVal Value As VehicleStateEnum)
      m_intState = Value
    End Set
  End Property

  Public Property Plate() As String
    Get
      Return m_strPlate
    End Get
    Set(ByVal Value As String)
      m_strPlate = Value
    End Set
  End Property

  Public Property FK_TiMe() As Integer
    Get
      Return m_intFK_TiMe
    End Get
    Set(ByVal Value As Integer)
      m_intFK_TiMe = Value
    End Set
  End Property

  Public Property FK_MaMe() As Integer
    Get
      Return m_intFK_MaMe
    End Get
    Set(ByVal Value As Integer)
      m_intFK_MaMe = Value
    End Set
  End Property

  Public Property FK_MoMe() As Integer
    Get
      Return m_intFK_MoMe
    End Get
    Set(ByVal Value As Integer)
      m_intFK_MoMe = Value
    End Set
  End Property

  Public Property DateIn_Begin() As DateTime
    Get
      Return m_dtmDateIn_Begin
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDateIn_Begin = New DateTime(Value.Year, Value.Month, Value.Day, 0, 0, 0)
    End Set
  End Property

  Public Property DateIn_End() As DateTime
    Get
      Return m_dtmDateIn_End
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDateIn_End = New DateTime(Value.Year, Value.Month, Value.Day, 23, 59, 59)
    End Set
  End Property

  Public Property DateOut_Begin() As DateTime
    Get
      Return m_dtmDateOut_Begin
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDateOut_Begin = New DateTime(Value.Year, Value.Month, Value.Day, 0, 0, 0)
    End Set
  End Property

  Public Property DateOut_End() As DateTime
    Get
      Return m_dtmDateOut_End
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDateOut_End = New DateTime(Value.Year, Value.Month, Value.Day, 23, 59, 59)
    End Set
  End Property

  Public ReadOnly Property Vehicles() As supVehicles
    Get
      Return m_Vehicles
    End Get
  End Property

  ' ***************************************************************************************
  '     PUBLIC SHARED METHODS
  ' ***************************************************************************************
  Public Shared Function getDefaultDateBegin() As DateTime
    Return New DateTime(1999, 1, 1, 0, 0, 0)
  End Function

  Public Shared Function getDefaultDateEnd() As DateTime
    Return New DateTime(2099, 12, 31, 23, 59, 59)
  End Function

  ' ***************************************************************************************
  '     PUBLIC METHODS
  ' ***************************************************************************************
  Public Sub Refresh()

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
    End Try

    cmd = New SqlCommand(GetQuery(), cnn)
    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        Do While dr.Read
          'If (m_intState = VehicleStateEnum.vseDeleted) Then
          '  m_Vehicles.Add(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetDateTime(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), "DEL")
          'ElseIf ((m_intState = VehicleStateEnum.vseDemolished) Or _
          '        (m_intState = VehicleStateEnum.vsePresent) Or _
          '        (m_intState = VehicleStateEnum.vsePresentCompleted)) Then
            m_Vehicles.Add(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetDateTime(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8))
          'End If
        Loop
      End If
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore nel caricamento dei tipi di documento.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  Public Function getDataSet() As DataSet

    Dim cnn As New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    Dim da As New SqlDataAdapter(GetQuery(), cnn)
    Dim ds As New DataSet
    da.Fill(ds)
    cnn.Close()
    da.Dispose()
    cnn.Dispose()

    Return ds

  End Function

  ' ***************************************************************************************
  '     PROTECTED METHODS
  ' ***************************************************************************************
  Protected Function GetQuery() As String

    Dim strSql As String

    strSql = "SELECT " & _
                  GetSqlFields() & _
             "FROM " & _
                  GetSqlTable() & " " & _
                  "INNER JOIN Angr_TipoMezzo ON A.Rimz_FK_TiMe = TiMe_PK " & _
                  "INNER JOIN Angr_MarcaMezzo ON A.Rimz_FK_MaMe = MaMe_PK " & _
                  "INNER JOIN Angr_ModelloMezzo ON A.Rimz_FK_MoMe = MoMe_PK " & _
             "ORDER BY " & _
                  "Rimz_Targa"
    Return strSql

  End Function

  Protected Function GetSqlFields() As String

    Dim strFields As String

    Select Case m_intState
      Case VehicleStateEnum.vseDeleted, VehicleStateEnum.vseDemolished, VehicleStateEnum.vseShadowed, VehicleStateEnum.vsePresent, VehicleStateEnum.vsePresentCompleted
        strFields = "Rimz_PK, " & _
                    "ISNULL(Rimz_Targa, '') AS [Targa], " & _
                    "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Ingresso], " & _
                    "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Uscita], " & _
                    "ISNULL(TiMe_Desc, '') AS [Tipo], " & _
                    "ISNULL(MaMe_Desc, '') AS [Marca], " & _
                    "ISNULL(MoMe_Desc, '') AS [Modello], " & _
                    "ISNULL(Rimz_NVerbale, '') AS [N. Verbale], " & _
                    "ISNULL(Rimz_Stato, '') AS [Stato] "
      Case VehicleStateEnum.vseHND
        strFields = "Rimz_PK, " & _
                    "ISNULL(Rimz_Targa, '') AS [Targa], " & _
                    "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Ingresso], " & _
                    "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Uscita], " & _
                    "ISNULL(TiMe_Desc, '') AS [Tipo], " & _
                    "ISNULL(MaMe_Desc, '') AS [Marca], " & _
                    "ISNULL(MoMe_Desc, '') AS [Modello], " & _
                    "ISNULL(VHND_NumeroContrassegno, '') AS [N. Contrass.], " & _
                    "ISNULL(VHND_RilascioContrassegno, '') AS [Rilasciato da] "
      Case VehicleStateEnum.vseRTP
        strFields = "Rimz_PK, " & _
                    "ISNULL(Rimz_Targa, '') AS [Targa], " & _
                    "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Ingresso], " & _
                    "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Uscita], " & _
                    "ISNULL(TiMe_Desc, '') AS [Tipo], " & _
                    "ISNULL(MaMe_Desc, '') AS [Marca], " & _
                    "ISNULL(MoMe_Desc, '') AS [Modello], " & _
                    "ISNULL(VRTR_DataDenuncia, '') AS [Data Denuncia], " & _
                    "ISNULL(VRTR_NumeroDenuncia, '') AS [N. Denuncia], " & _
                    "ISNULL(VRTR_CorpoDenuncia, '') AS [Corpo], " & _
                    "ISNULL(VRTR_StazioneDenuncia, '') AS [Stazione] "
      Case VehicleStateEnum.vseRVI
        strFields = "Rimz_PK, " & _
                    "ISNULL(Rimz_Targa, '') AS [Targa], " & _
                    "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Ingresso], " & _
                    "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Uscita], " & _
                    "ISNULL(TiMe_Desc, '') AS [Tipo], " & _
                    "ISNULL(MaMe_Desc, '') AS [Marca], " & _
                    "ISNULL(MoMe_Desc, '') AS [Modello], " & _
                    "ISNULL(VRVI_NoteUscita, '') AS [Note] "
      Case Else
        strFields = "Rimz_PK, " & _
                    "ISNULL(Rimz_Targa, '') AS [Targa], " & _
                    "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Ingresso], " & _
                    "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS [Uscita], " & _
                    "ISNULL(TiMe_Desc, '') AS [Tipo], " & _
                    "ISNULL(MaMe_Desc, '') AS [Marca], " & _
                    "ISNULL(MoMe_Desc, '') AS [Modello]"
    End Select

    Return strFields

  End Function

  Protected Function GetSqlTable() As String

    Dim strTable As String

    Select Case m_intState
      Case VehicleStateEnum.vseHND
        strTable = "(SELECT * " & _
                   "FROM " & _
                        "(SELECT * FROM Tabl_Rimozione WHERE " & GetWhereClause() & ") X " & _
                        "INNER JOIN Angr_VeicoloHND Y ON X.Rimz_PK = Y.VHND_FK_Rimz) A"
      Case VehicleStateEnum.vseRTP
        strTable = "(SELECT * " & _
                   "FROM " & _
                        "(SELECT * FROM Tabl_Rimozione WHERE " & GetWhereClause() & ") X " & _
                        "INNER JOIN Angr_VeicoloRTR Y ON X.Rimz_PK = Y.VRTR_FK_Rimz) A"
      Case VehicleStateEnum.vseRVI
        strTable = "(SELECT * " & _
                   "FROM " & _
                        "(SELECT * FROM Tabl_Rimozione WHERE " & GetWhereClause() & ") X " & _
                        "INNER JOIN Angr_VeicoloRVI Y ON X.Rimz_PK = Y.VRVI_FK_Rimz) A"
      Case Else
        strTable = "(SELECT * FROM Tabl_Rimozione WHERE " & GetWhereClause() & ") A"
    End Select

    Return strTable

  End Function

  Protected Function GetWhereClause() As String

    Dim strTemp As String = ""

    Select Case m_intState
      Case VehicleStateEnum.vseDeleted
        strTemp = "Rimz_Stato = 'DEL'"
      Case VehicleStateEnum.vseDemolished
        strTemp = "Rimz_Stato = 'DML'"
      Case VehicleStateEnum.vseShadowed
        strTemp = "Rimz_Stato = 'SHA'"
      Case VehicleStateEnum.vsePresent
        strTemp = "((Rimz_Stato = 'DPT') OR (Rimz_Stato = 'DSV') OR (Rimz_Stato = 'INC') OR (Rimz_Stato = 'INS'))"
      Case VehicleStateEnum.vsePresentCompleted
        strTemp = "((Rimz_Stato = 'DPT') OR (Rimz_Stato = 'DSV'))"
      Case VehicleStateEnum.vseHND
        strTemp = "Rimz_Stato = 'HND'"
      Case VehicleStateEnum.vseRBD
        strTemp = "Rimz_Stato = 'RBD'"
      Case VehicleStateEnum.vseRBT
        strTemp = "Rimz_Stato = 'RBT'"
      Case VehicleStateEnum.vseRSO
        strTemp = "Rimz_Stato = 'RSO'"
      Case VehicleStateEnum.vseRTP
        strTemp = "Rimz_Stato = 'RTP'"
      Case VehicleStateEnum.vseRTR
        strTemp = "Rimz_Stato = 'RTR'"
      Case VehicleStateEnum.vseRVI
        strTemp = "Rimz_Stato = 'RVI'"
    End Select

    If (m_strPlate <> "") Then
      strTemp = strTemp & " AND Rimz_Targa = '" & m_strPlate.Replace("'", "''") & "'"
    End If

    If (m_intFK_TiMe > 0) Then
      strTemp = strTemp & " AND Rimz_FK_TiMe = " & CStr(m_intFK_TiMe)
    End If

    If (m_intFK_MaMe > 0) Then
      strTemp = strTemp & " AND Rimz_FK_MaMe = " & CStr(m_intFK_MaMe)
    End If

    If (m_intFK_MoMe > 0) Then
      strTemp = strTemp & " AND Rimz_FK_MoMe = " & CStr(m_intFK_MoMe)
    End If

    If (m_dtmDateIn_Begin <> getDefaultDateBegin()) Then
      strTemp = strTemp & " AND Rimz_DataIngresso >= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateIn_Begin) & "', 121)"
    End If

    If (m_dtmDateIn_End <> getDefaultDateEnd()) Then
      strTemp = strTemp & " AND Rimz_DataIngresso <= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateIn_End) & "', 121)"
    End If

    If ((m_intState <> VehicleStateEnum.vseDeleted) And (m_intState <> VehicleStateEnum.vseDemolished) And (m_intState <> VehicleStateEnum.vseShadowed) And _
        (m_intState <> VehicleStateEnum.vsePresent) And (m_intState <> VehicleStateEnum.vsePresentCompleted)) Then
      If (m_dtmDateOut_Begin <> getDefaultDateBegin()) Then
        strTemp = strTemp & " AND Rimz_DataUscita >= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateOut_Begin) & "', 121)"
      End If
      If (m_dtmDateOut_End <> getDefaultDateEnd()) Then
        strTemp = strTemp & " AND Rimz_DataUscita <= CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDateOut_End) & "', 121)"
      End If
    End If

    Return strTemp

  End Function

End Class
