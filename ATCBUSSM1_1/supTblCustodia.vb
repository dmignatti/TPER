Imports System.Data.SqlClient

Public Class supTblCustodia

  Protected m_dtmDateIn As DateTime
  Protected m_dtmDateOut As DateTime
  Protected m_intMG_TarfPK As Integer
  Protected m_strMG_TarfDesc As String
  Protected m_decMG_UnitCost As Decimal
  Protected m_decMG_Total As Decimal
  Protected m_intPG_TarfPK As Integer
  Protected m_strPG_TarfDesc As String
  Protected m_decPG_UnitCost As Decimal
  Protected m_decPG_Total As Decimal
  Protected m_intSG_TarfPK As Integer
  Protected m_strSG_TarfDesc As String
  Protected m_decSG_UnitCost As Decimal
  Protected m_decSG_Total As Decimal

  Public Sub New(ByVal dtmDateIn As DateTime, ByVal dtmDateOut As DateTime)

    m_dtmDateIn = dtmDateIn
    m_dtmDateOut = dtmDateOut

    m_intMG_TarfPK = 0
    m_strMG_TarfDesc = ""
    m_decMG_UnitCost = 0
    m_decMG_Total = 0
    m_intPG_TarfPK = 0
    m_strPG_TarfDesc = ""
    m_decPG_UnitCost = 0
    m_decPG_Total = 0
    m_intSG_TarfPK = 0
    m_strSG_TarfDesc = ""
    m_decSG_UnitCost = 0
    m_decSG_Total = 0

  End Sub

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

  Public ReadOnly Property MG_TarfPK() As Integer
    Get
      Return m_intMG_TarfPK
    End Get
  End Property

  Public ReadOnly Property MG_TarfDesc() As String
    Get
      Return m_strMG_TarfDesc
    End Get
  End Property

  Public ReadOnly Property MG_UnitCost() As Decimal
    Get
      Return m_decMG_UnitCost
    End Get
  End Property

  Public ReadOnly Property MG_Total() As Decimal
    Get
      Return m_decMG_Total
    End Get
  End Property

  Public ReadOnly Property PG_TarfPK() As Integer
    Get
      Return m_intPG_TarfPK
    End Get
  End Property

  Public ReadOnly Property PG_TarfDesc() As String
    Get
      Return m_strPG_TarfDesc
    End Get
  End Property

  Public ReadOnly Property PG_UnitCost() As Decimal
    Get
      Return m_decPG_UnitCost
    End Get
  End Property

  Public ReadOnly Property PG_Total() As Decimal
    Get
      Return m_decPG_Total
    End Get
  End Property

  Public ReadOnly Property SG_TarfPK() As Integer
    Get
      Return m_intSG_TarfPK
    End Get
  End Property

  Public ReadOnly Property SG_TarfDesc() As String
    Get
      Return m_strSG_TarfDesc
    End Get
  End Property

  Public ReadOnly Property SG_UnitCost() As Decimal
    Get
      Return m_decSG_UnitCost
    End Get
  End Property

  Public ReadOnly Property SG_Total() As Decimal
    Get
      Return m_decSG_Total
    End Get
  End Property

  Public ReadOnly Property Total() As Decimal
    Get
      Return m_decMG_Total + m_decPG_Total + m_decSG_Total
    End Get
  End Property

  Public Sub Fetch()

    Dim cnn As New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()

    Dim cmd As New SqlCommand("dbo.getContoCustodia", cnn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.CommandTimeout = 10

    Dim prmIn As New SqlParameter
    prmIn.ParameterName = "@vchDateIn"
    prmIn.SqlDbType = SqlDbType.VarChar
    prmIn.Direction = ParameterDirection.Input
    prmIn.Value = supFunction.sqlDate121(m_dtmDateIn)
    cmd.Parameters.Add(prmIn)

    Dim prmOut As New SqlParameter
    prmOut.ParameterName = "@vchDateOut"
    prmOut.SqlDbType = SqlDbType.VarChar
    prmOut.Direction = ParameterDirection.Input
    prmOut.Value = supFunction.sqlDate121(m_dtmDateOut)
    cmd.Parameters.Add(prmOut)

    Dim dr As SqlDataReader
    dr = cmd.ExecuteReader()
    If dr.HasRows Then
      dr.Read()
      m_intMG_TarfPK = dr("MG_PK")
      m_strMG_TarfDesc = dr("MG_Desc")
      m_decMG_UnitCost = dr("MG_UnitCost")
      m_decMG_Total = dr("MG_Total")
      m_intPG_TarfPK = dr("PG_PK")
      m_strPG_TarfDesc = dr("PG_Desc")
      m_decPG_UnitCost = dr("PG_UnitCost")
      m_decPG_Total = dr("PG_Total")
      m_intSG_TarfPK = dr("SG_PK")
      m_strSG_TarfDesc = dr("SG_Desc")
      m_decSG_UnitCost = dr("SG_UnitCost")
      m_decSG_Total = dr("SG_Total")
    End If
    dr.Close()
    cnn.Close()

    cmd.Dispose()
    cnn.Dispose()

  End Sub

End Class
