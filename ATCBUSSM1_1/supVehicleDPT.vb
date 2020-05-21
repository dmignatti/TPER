Imports System.Data.SqlClient

Public Class supVehicleDPT

  Protected Enum TableEnum As Integer
    tbl_VHND
    tbl_VRBD
    tbl_VRBT
    tbl_VRSO
    tbl_VRTR
    tbl_VRTP
    tbl_VRVI
  End Enum

  Protected m_intPK As Integer
  Protected m_intFK_Rimz As Integer
  Protected m_dtmDataIngresso As DateTime
  Protected m_strTarga As String
  Protected m_intFK_TiMe As Integer
  Protected m_strTipo As String
  Protected m_intFK_MaMe As Integer
  Protected m_strMarca As String
  Protected m_intFK_MoMe As Integer
  Protected m_strModello As String
  Protected m_dblPesoPC As Double
  Protected m_strNoteIngresso As String
  Protected m_intFK_Rimv As Integer
  Protected m_strNVerbale As String
  Protected m_dtmDataRimozione As DateTime
  Protected m_blnFlagChiamata As Boolean
  Protected m_intFK_FaKm As Integer
  Protected m_intFK_DRim As Integer
  Protected m_strDittaRimz As String
  Protected m_intFK_Carr As Integer
  Protected m_strTargaCarrAttr As String
  Protected m_strMatrCarrAttr As String
  Protected m_intDivisore As Integer
  Protected m_strDanniRimz As String
  Protected m_strDanniScar As String
  Protected m_strStato As String
  'Protected m_strStatoOld As String
  Protected m_dtmDataBlocco As DateTime
  'Protected m_strTabella As String
  'Protected m_strRF_Mode As String
  'Protected m_intRF_Record As Integer
  Protected m_intFK_Chiamata As Integer
  Protected m_intFK_Rimozione As Integer
  Protected m_intFK_Trasporto As Integer
  'Protected m_intFK_Bollo As Integer

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intRimzPK As Integer, ByVal strStato As String)

    m_intFK_Rimz = intRimzPK
    m_strStato = strStato
    FetchRefData()

  End Sub

  ' *****************************************************************************************
  '     READ-ONLY PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property FK_Rimz() As Integer
    Get
      Return m_intFK_Rimz
    End Get
  End Property

  Public ReadOnly Property DataIngresso() As DateTime
    Get
      Return m_dtmDataIngresso
    End Get
  End Property

  Public ReadOnly Property Targa() As String
    Get
      Return m_strTarga
    End Get
  End Property

  Public ReadOnly Property FK_TiMe() As Integer
    Get
      Return m_intFK_TiMe
    End Get
  End Property

  Public ReadOnly Property Tipo() As String
    Get
      Return m_strTipo
    End Get
  End Property

  Public ReadOnly Property FK_MaMe() As Integer
    Get
      Return m_intFK_MaMe
    End Get
  End Property

  Public ReadOnly Property Marca() As String
    Get
      Return m_strMarca
    End Get
  End Property

  Public ReadOnly Property FK_MoMe() As Integer
    Get
      Return m_intFK_MoMe
    End Get
  End Property

  Public ReadOnly Property Modello() As String
    Get
      Return m_strModello
    End Get
  End Property

  Public ReadOnly Property NoteIngresso() As String
    Get
      Return m_strNoteIngresso
    End Get
  End Property

  Public ReadOnly Property FK_Rimv() As Integer
    Get
      Return m_intFK_Rimv
    End Get
  End Property

  Public ReadOnly Property NVerbale() As String
    Get
      Return m_strNVerbale
    End Get
  End Property

  Public ReadOnly Property DataRimozione() As DateTime
    Get
      Return m_dtmDataRimozione
    End Get
  End Property

  Public ReadOnly Property FlagChiamata() As Boolean
    Get
      Return m_blnFlagChiamata
    End Get
  End Property

  Public ReadOnly Property FK_FaKm() As Integer
    Get
      Return m_intFK_FaKm
    End Get
  End Property

  Public ReadOnly Property FK_DRim() As Integer
    Get
      Return m_intFK_DRim
    End Get
  End Property

  Public ReadOnly Property DittaRimozione() As String
    Get
      Return m_strDittaRimz
    End Get
  End Property

  Public ReadOnly Property FK_Carr() As Integer
    Get
      Return m_intFK_Carr
    End Get
  End Property

  Public ReadOnly Property TargaCarro() As String
    Get
      Return m_strTargaCarrAttr
    End Get
  End Property

  Public ReadOnly Property MatricolaCarro() As String
    Get
      Return m_strMatrCarrAttr
    End Get
  End Property

  Public ReadOnly Property Divisore() As Integer
    Get
      Return m_intDivisore
    End Get
  End Property

  Public ReadOnly Property DanniRimozione() As String
    Get
      Return m_strDanniRimz
    End Get
  End Property

  Public ReadOnly Property DanniScarico() As String
    Get
      Return m_strDanniScar
    End Get
  End Property

  Public ReadOnly Property Stato() As String
    Get
      Return m_strStato
    End Get
  End Property

  'Public ReadOnly Property StatoOld() As String
  '  Get
  '    Return m_strStatoOld
  '  End Get
  'End Property

  Public ReadOnly Property DataBlocco() As DateTime
    Get
      Return m_dtmDataBlocco
    End Get
  End Property

  'Public ReadOnly Property Tabella() As String
  '  Get
  '    Return m_strTabella
  '  End Get
  'End Property

  'Public ReadOnly Property RF_Mode() As String
  '  Get
  '    Return m_strRF_Mode
  '  End Get
  'End Property

  'Public ReadOnly Property RF_Record() As Integer
  '  Get
  '    Return m_intRF_Record
  '  End Get
  'End Property

  Public ReadOnly Property FK_Chiamata() As Integer
    Get
      Return m_intFK_Chiamata
    End Get
  End Property

  Public ReadOnly Property FK_Rimozione() As Integer
    Get
      Return m_intFK_Rimozione
    End Get
  End Property

  Public ReadOnly Property FK_Trasporto() As Integer
    Get
      Return m_intFK_Trasporto
    End Get
  End Property

  'Public ReadOnly Property FK_Bollo() As Integer
  '  Get
  '    Return m_intFK_Bollo
  '  End Get
  'End Property
  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property PK() As Integer
    Get
      Return m_intPK
    End Get
    Set(ByVal Value As Integer)
      m_intPK = Value
    End Set
  End Property

  Public Property PesoPC() As Double
    Get
      Return m_dblPesoPC
    End Get
    Set(ByVal Value As Double)
      m_dblPesoPC = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Sub FetchRefData()

    Dim intErr As Integer
    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "Rimz_PK, Rimz_DataIngresso, Rimz_Targa, " & _
                  "Rimz_FK_TiMe, Rimz_Tipo, Rimz_FK_MaMe, Rimz_Marca, " & _
                  "Rimz_FK_MoMe, Rimz_Modello, Rimz_PesoPC, " & _
                  "ISNULL(Rimz_NoteIngresso, '') AS Rimz_NoteIngresso, " & _
                  "ISNULL(Rimz_FK_Rimv, 0) AS Rimz_FK_Rimv, " & _
                  "ISNULL(Rimz_NVerbale, '') AS Rimz_NVerbale, " & _
                  "Rimz_DataRimz, Rimz_FlagChiamata, Rimz_FK_FaKm, " & _
                  "Rimz_FK_DRim, Rimz_DittaRimz, " & _
                  "Rimz_FK_Carr, Rimz_TargaCarrAttr, Rimz_MatrCarrAttr, " & _
                  "Rimz_Divisore, Rimz_Stato, " & _
                  "ISNULL(Rimz_DanniRimz, '') AS Rimz_DanniRimz, " & _
                  "ISNULL(Rimz_DanniScar, '') AS Rimz_DanniScar, " & _
                  "ISNULL(Rimz_DateBlock, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS Rimz_DateBlock, " & _
                  "Rimz_FK_Chiamata, Rimz_FK_Rimozione, Rimz_FK_Trasporto " & _
             "FROM " & _
                  "Tabl_Rimozione " & _
             "WHERE " & _
                  "Rimz_PK = " & CStr(m_intFK_Rimz) & " AND " & _
                  "Rimz_Stato = '" & m_strStato & "'"
    Try
      cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
      cnn.Open()
      cmd = New SqlCommand(strSql, cnn)
      cmd.CommandTimeout = 10
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        m_dtmDataIngresso = dr("Rimz_DataIngresso")
        m_strTarga = dr("Rimz_Targa")
        m_intFK_TiMe = dr("Rimz_FK_TiMe")
        m_strTipo = dr("Rimz_Tipo")
        m_intFK_MaMe = dr("Rimz_FK_MaMe")
        m_strMarca = dr("Rimz_Marca")
        m_intFK_MoMe = dr("Rimz_FK_MoMe")
        m_strModello = dr("Rimz_Modello")
        m_dblPesoPC = dr("Rimz_PesoPC")
        m_strNoteIngresso = dr("Rimz_NoteIngresso")
        m_intFK_Rimv = dr("Rimz_FK_Rimv")
        m_strNVerbale = dr("Rimz_NVerbale")
        m_dtmDataRimozione = dr("Rimz_DataRimz")
        m_blnFlagChiamata = dr("Rimz_FlagChiamata")
        m_intFK_FaKm = dr("Rimz_FK_FaKm")
        m_intFK_DRim = dr("Rimz_FK_DRim")
        m_strDittaRimz = dr("Rimz_DittaRimz")
        m_intFK_Carr = dr("Rimz_FK_Carr")
        m_strTargaCarrAttr = dr("Rimz_TargaCarrAttr")
        m_strMatrCarrAttr = dr("Rimz_MatrCarrAttr")
        m_intDivisore = dr("Rimz_Divisore")
        m_strDanniRimz = dr("Rimz_DanniRimz")
        m_strDanniScar = dr("Rimz_DanniScar")
        m_dtmDataBlocco = dr("Rimz_DateBlock")
        m_intFK_Chiamata = dr("Rimz_FK_Chiamata")
        m_intFK_Rimozione = dr("Rimz_FK_Rimozione")
        m_intFK_Trasporto = dr("Rimz_FK_Trasporto")
      Else
        intErr = 2
      End If
      dr.Close()
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    Catch ex As Exception
      intErr = 1
      If Not (cmd Is Nothing) Then
        cmd.Dispose()
      End If
      If Not (cnn Is Nothing) Then
        If (cnn.State <> ConnectionState.Closed) Then
          cnn.Close()
        End If
        cnn.Dispose()
      End If
    End Try

    Select Case intErr
      Case 1
        Throw New Exception("Si sono verificati errori nel prelevamento dei dati.")
      Case 2
        Throw New Exception("Il veicolo non è in deposito")
    End Select

  End Sub

  Protected Sub SetPK(ByVal intTabella As TableEnum)

    Dim blnError As Boolean = False
    Dim strTabella As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim prm As SqlParameter
    Dim dr As SqlDataReader

    Select Case intTabella
      Case TableEnum.tbl_VHND
        strTabella = "Angr_VeicoloHND"
      Case TableEnum.tbl_VRBD
        strTabella = "Angr_VeicoloRBD"
      Case TableEnum.tbl_VRBT
        strTabella = "Angr_VeicoloRBT"
      Case TableEnum.tbl_VRSO
        strTabella = "Angr_VeicoloRSO"
      Case TableEnum.tbl_VRTP, TableEnum.tbl_VRTR
        strTabella = "Angr_VeicoloRTR"
      Case TableEnum.tbl_VRVI
        strTabella = "Angr_VeicoloRVI"
    End Select

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()

    cmd = New SqlCommand("dbo.getNewPK", cnn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.CommandTimeout = 10

    prm = New SqlParameter
    prm.ParameterName = "@strTableName"
    prm.SqlDbType = SqlDbType.VarChar
    prm.Size = 50
    prm.Direction = ParameterDirection.Input
    prm.Value = strTabella
    cmd.Parameters.Add(prm)

    Try
      dr = cmd.ExecuteReader()
      If dr.HasRows Then
        dr.Read()
        m_intPK = System.Convert.ToInt32(dr("NewPK"))
        If (m_intPK = 0) Then
          blnError = True
        End If
      Else
        blnError = True
      End If
    Catch ex As Exception
      dr.Close()
      blnError = True
    End Try

    cnn.Close()
    cmd.Dispose()
    cnn.Dispose()

    If blnError Then
      Throw New Exception("Errore di accesso ai dati. Riprovare l'operazione.")
    End If

  End Sub

End Class
