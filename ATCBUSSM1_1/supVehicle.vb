Imports System.Data.SqlClient

Public Class supVehicle

  Protected m_intPK As Integer
  Protected m_dtmDateIn As DateTime
  Protected m_dtmDateOut As DateTime
  Protected m_strPlate As String
  Protected m_strType As String
  Protected m_strMark As String
  Protected m_strModel As String
  Protected m_strNVerbale As String
  Protected m_strState As String

  ' ********************************************************************************************
  '     CREATION METHODS
  ' ********************************************************************************************
  Public Sub New(ByVal intPK As Integer)

    m_intPK = intPK
    m_strPlate = ""
    m_dtmDateIn = New DateTime(9999, 12, 31, 23, 59, 59)
    m_dtmDateOut = m_dtmDateIn
    m_strType = ""
    m_strMark = ""
    m_strModel = ""
    m_strNVerbale = ""
    m_strState = ""

  End Sub

  Public Sub New(ByVal intPK As Integer, ByVal dtmDateIn As DateTime, ByVal dtmDateOut As DateTime, ByVal strPlate As String, ByVal strType As String, ByVal strMark As String, ByVal strModel As String, ByVal strNVerbale As String, ByVal strState As String)

    m_intPK = intPK
    m_strPlate = strPlate
    m_dtmDateIn = dtmDateIn
    m_dtmDateOut = dtmDateOut
    m_strType = strType
    m_strMark = strMark
    m_strModel = strModel
    m_strNVerbale = strNVerbale
    m_strState = strState

  End Sub

  ' ********************************************************************************************
  '     PROPERTIES
  ' ********************************************************************************************
  Public ReadOnly Property PK() As Integer
    Get
      Return m_intPK
    End Get
  End Property

  Public ReadOnly Property DateIn() As DateTime
    Get
      Return m_dtmDateIn
    End Get
  End Property

  Public ReadOnly Property DateOut() As DateTime
    Get
      Return m_dtmDateOut
    End Get
  End Property

  Public ReadOnly Property Plate() As String
    Get
      Return m_strPlate
    End Get
  End Property

  Public ReadOnly Property Type() As String
    Get
      Return m_strType
    End Get
  End Property

  Public ReadOnly Property Mark() As String
    Get
      Return m_strMark
    End Get
  End Property

  Public ReadOnly Property Model() As String
    Get
      Return m_strModel
    End Get
  End Property

  Public ReadOnly Property NVerbale() As String
    Get
      Return m_strNVerbale
    End Get
  End Property

  Public ReadOnly Property State() As String
    Get
      Return m_strState
    End Get
  End Property

  ' ********************************************************************************************
  '     PUBLIC SHARED METHODS
  ' ********************************************************************************************
  Public Shared Function VehicleIsLocked(ByVal intPK As Integer) As Boolean

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT COUNT(*) FROM Tabl_Lock WHERE Lock_TableName = 'Tabl_Rimozione' AND Lock_RecordID = " & CStr(intPK)

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader()
    If dr.HasRows() Then
      dr.Read()
      If (dr.GetInt32(0) > 0) Then
        Return True
      Else
        Return False
      End If
    Else
      Return False
    End If
    dr.Close()
    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()

  End Function

  ' ********************************************************************************************
  '     PUBLIC METHODS
  ' ********************************************************************************************
  Public Sub Fetch()

    Dim strSql As String
    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    strSql = "SELECT " & _
                  "Rimz_PK, " & _
                  "ISNULL(Rimz_Targa, '') AS Rimz_Targa, " & _
                  "ISNULL(Rimz_DataIngresso, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS Rimz_DataIngresso, " & _
                  "ISNULL(Rimz_DataUscita, CONVERT(datetime, '9999-12-31 23:59:59', 121)) AS Rimz_DataUscita, " & _
                  "ISNULL(TiMe_Desc, '') AS TiMe_Desc, " & _
                  "ISNULL(MaMe_Desc, '') AS MaMe_Desc, " & _
                  "ISNULL(MoMe_Desc, '') AS MoMe_Desc, " & _
                  "ISNULL(Rimz_NVerbale, '') AS Rimz_NVerbale, " & _
                  "ISNULL(Rimz_Stato, '') AS Rimz_Stato " & _
             "FROM " & _
                  "(SELECT " & _
                        "* " & _
                  "FROM " & _
                        "Tabl_Rimozione " & _
                  "WHERE " & _
                        "Rimz_PK = " & CStr(m_intPK) & ") A " & _
                  "INNER JOIN Angr_TipoMezzo B ON A.Rimz_FK_TiMe = B.TiMe_PK " & _
                  "INNER JOIN Angr_MarcaMezzo C ON A.Rimz_FK_MaMe = C.MaMe_PK " & _
                  "INNER JOIN Angr_ModelloMezzo D ON A.Rimz_FK_MoMe = D.MoMe_PK"

    cnn = New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()
    cmd = New SqlCommand(strSql, cnn)
    dr = cmd.ExecuteReader()
    If dr.HasRows() Then
      dr.Read()
      m_strPlate = System.Convert.ToString(dr("Rimz_Targa"))
      m_dtmDateIn = System.Convert.ToDateTime(dr("Rimz_DataIngresso"))
      m_dtmDateOut = System.Convert.ToDateTime(dr("Rimz_DataUscita"))
      m_strType = System.Convert.ToString(dr("TiMe_Desc"))
      m_strMark = System.Convert.ToString(dr("MaMe_Desc"))
      m_strModel = System.Convert.ToString(dr("MoMe_Desc"))
      m_strNVerbale = System.Convert.ToString(dr("Rimz_NVerbale"))
      m_strState = System.Convert.ToString(dr("Rimz_Stato"))
    End If
    dr.Close()
    cmd.Dispose()
    cnn.Close()
    cnn.Dispose()

  End Sub

End Class
