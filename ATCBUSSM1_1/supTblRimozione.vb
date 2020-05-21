Imports System.Data.SqlClient

Public Class supTblRimozione

  Protected m_dtmDataRimozione As DateTime
  Protected m_dtmDataUscita As DateTime
  Protected m_dblPesoPC As Double
  Protected m_intDivisore As Integer
  Protected m_blnFlagChiamata As Boolean
  Protected m_intFK_FaKm As Integer
  Protected m_decTotCustodia As Decimal

  Protected m_intDiCh_PK As Integer
  Protected m_strDiCh_Desc As String
  Protected m_decDiCh_UnitCost As Decimal
  Protected m_decDiCh_Importo As Decimal

  Protected m_intOpRi_PK As Integer
  Protected m_strOpRi_Desc As String
  Protected m_decOpRi_UnitCost As Decimal
  Protected m_decOpRi_Importo As Decimal

  Protected m_intTras_PK As Integer
  Protected m_strTras_Desc As String
  Protected m_decTras_UnitCost As Decimal
  Protected m_decTras_Importo As Decimal

  Protected m_intBoll_PK As Integer
  Protected m_strBoll_Desc As String
  Protected m_decBoll_UnitCost As Decimal
  Protected m_decBoll_Importo As Decimal
  Protected m_decBoll_LimiteInfApp As Decimal

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal dtmDataRimozione As DateTime, ByVal dtmDataUscita As DateTime, ByVal dblPesoPC As Double, ByVal intDivisore As Integer, _
                ByVal blnFlagChiamata As Boolean, ByVal intFK_FaKm As Integer, ByVal decTotCustodia As Decimal)

    m_dtmDataRimozione = dtmDataRimozione
    m_dtmDataUscita = dtmDataUscita
    m_dblPesoPC = dblPesoPC
    m_intDivisore = intDivisore
    m_blnFlagChiamata = blnFlagChiamata
    m_intFK_FaKm = intFK_FaKm
    m_decTotCustodia = decTotCustodia

    m_intDiCh_PK = 0
    m_strDiCh_Desc = ""
    m_decDiCh_UnitCost = 0
    m_decDiCh_Importo = 0

    m_intOpRi_PK = 0
    m_strOpRi_Desc = ""
    m_decOpRi_UnitCost = 0
    m_decOpRi_Importo = 0

    m_intTras_PK = 0
    m_strTras_Desc = ""
    m_decTras_UnitCost = 0
    m_decTras_Importo = 0

    m_intBoll_PK = 0
    m_strBoll_Desc = ""
    m_decBoll_UnitCost = 0
    m_decBoll_Importo = 0
    m_decBoll_LimiteInfApp = 0

  End Sub

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property DiCh_RF() As Integer
    Get
      Return m_intDiCh_PK
    End Get
  End Property

  Public ReadOnly Property DiCh_Desc() As String
    Get
      Return m_strDiCh_Desc
    End Get
  End Property

  Public ReadOnly Property DiCh_UnitCost() As Decimal
    Get
      Return m_decDiCh_UnitCost
    End Get
  End Property

  Public ReadOnly Property DiCh_Importo() As Decimal
    Get
      Return m_decDiCh_Importo
    End Get
  End Property

  Public ReadOnly Property OpRi_RF() As Integer
    Get
      Return m_intOpRi_PK
    End Get
  End Property

  Public ReadOnly Property OpRi_Desc() As String
    Get
      Return m_strOpRi_Desc
    End Get
  End Property

  Public ReadOnly Property OpRi_UnitCost() As Decimal
    Get
      Return m_decOpRi_UnitCost
    End Get
  End Property

  Public ReadOnly Property OpRi_Importo() As Decimal
    Get
      Return m_decOpRi_Importo
    End Get
  End Property

  Public ReadOnly Property Tras_RF() As Integer
    Get
      Return m_intTras_PK
    End Get
  End Property

  Public ReadOnly Property Tras_Desc() As String
    Get
      Return m_strTras_Desc
    End Get
  End Property

  Public ReadOnly Property Tras_UnitCost() As Decimal
    Get
      Return m_decTras_UnitCost
    End Get
  End Property

  Public ReadOnly Property Tras_Importo() As Decimal
    Get
      Return m_decTras_Importo
    End Get
  End Property

  Public ReadOnly Property TotRimozione() As Decimal
    Get
      Return m_decDiCh_Importo + m_decOpRi_Importo + m_decTras_Importo
    End Get
  End Property

  Public ReadOnly Property Boll_RF() As Integer
    Get
      Return m_intBoll_PK
    End Get
  End Property

  Public ReadOnly Property Boll_Desc() As String
    Get
      Return m_strBoll_Desc
    End Get
  End Property

  Public ReadOnly Property Boll_UnitCost() As Decimal
    Get
      Return m_decBoll_UnitCost
    End Get
  End Property

  Public ReadOnly Property Boll_Importo() As Decimal
    Get
      Return m_decBoll_Importo
    End Get
  End Property

  Public ReadOnly Property Boll_LimiteInfApp() As Decimal
    Get
      Return m_decBoll_LimiteInfApp
    End Get
  End Property

  Public ReadOnly Property TotRimozioneBollo() As Decimal
    Get
      Return m_decDiCh_Importo + m_decOpRi_Importo + m_decTras_Importo + m_decBoll_Importo
    End Get
  End Property

  ' *****************************************************************************************
  '     METHODS
  ' *****************************************************************************************
  Public Sub Fetch()

    Dim cnn As New SqlConnection(atcbConstant.CS_CnnStringGDATC)
    cnn.Open()

    Dim cmd As New SqlCommand("dbo.getContoRimozione", cnn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.CommandTimeout = 10

    Dim prmPeso As New SqlParameter
    prmPeso.ParameterName = "@fltPeso"
    prmPeso.SqlDbType = SqlDbType.Float
    prmPeso.Direction = ParameterDirection.Input
    prmPeso.Value = m_dblPesoPC
    cmd.Parameters.Add(prmPeso)

    Dim prmFK_FaKm As New SqlParameter
    prmFK_FaKm.ParameterName = "@intFaKm"
    prmFK_FaKm.SqlDbType = SqlDbType.Int
    prmFK_FaKm.Direction = ParameterDirection.Input
    prmFK_FaKm.Value = m_intFK_FaKm
    cmd.Parameters.Add(prmFK_FaKm)

    Dim prmDivisore As New SqlParameter
    prmDivisore.ParameterName = "@intDivisore"
    prmDivisore.SqlDbType = SqlDbType.Int
    prmDivisore.Direction = ParameterDirection.Input
    prmDivisore.Value = m_intDivisore
    cmd.Parameters.Add(prmDivisore)

    Dim prmFlagChiamata As New SqlParameter
    prmFlagChiamata.ParameterName = "@bitFlagChiamata"
    prmFlagChiamata.SqlDbType = SqlDbType.Bit
    prmFlagChiamata.Direction = ParameterDirection.Input
    prmFlagChiamata.Value = m_blnFlagChiamata
    cmd.Parameters.Add(prmFlagChiamata)

    Dim prmDataRimozione As New SqlParameter
    prmDataRimozione.ParameterName = "@vchDateRimz"
    prmDataRimozione.SqlDbType = SqlDbType.VarChar
    prmDataRimozione.Direction = ParameterDirection.Input
    prmDataRimozione.Value = supFunction.sqlDate121(m_dtmDataRimozione)
    cmd.Parameters.Add(prmDataRimozione)

    Dim prmDataUscita As New SqlParameter
    prmDataUscita.ParameterName = "@vchDateOut"
    prmDataUscita.SqlDbType = SqlDbType.VarChar
    prmDataUscita.Direction = ParameterDirection.Input
    prmDataUscita.Value = supFunction.sqlDate121(m_dtmDataUscita)
    cmd.Parameters.Add(prmDataUscita)

    Dim prmTotCustodia As New SqlParameter
    prmTotCustodia.ParameterName = "@monTotCustodia"
    prmTotCustodia.SqlDbType = SqlDbType.Money
    prmTotCustodia.Direction = ParameterDirection.Input
    prmTotCustodia.Value = m_decTotCustodia
    cmd.Parameters.Add(prmTotCustodia)

    Dim dr As SqlDataReader
    dr = cmd.ExecuteReader()
    If dr.HasRows Then
      dr.Read()
      m_intDiCh_PK = dr("DiCh_PK")
      m_strDiCh_Desc = dr("DiCh_Desc")
      m_decDiCh_UnitCost = dr("DiCh_UnitCost")
      m_decDiCh_Importo = dr("DiCh_Total")

      m_intOpRi_PK = dr("OpRi_PK")
      m_strOpRi_Desc = dr("OpRi_Desc")
      m_decOpRi_UnitCost = dr("OpRi_UnitCost")
      m_decOpRi_Importo = dr("OpRi_Total")

      m_intTras_PK = dr("Tras_PK")
      m_strTras_Desc = dr("Tras_Desc")
      m_decTras_UnitCost = dr("Tras_UnitCost")
      m_decTras_Importo = dr("Tras_Total")

      m_intBoll_PK = dr("Boll_PK")
      m_strBoll_Desc = dr("Boll_Desc")
      m_decBoll_UnitCost = dr("Boll_UnitCost")
      m_decBoll_Importo = dr("Boll_Total")
      m_decBoll_LimiteInfApp = dr("Boll_LimiteInfApp")
    End If
    dr.Close()
    cnn.Close()

    cmd.Dispose()
    cnn.Dispose()

  End Sub

End Class
