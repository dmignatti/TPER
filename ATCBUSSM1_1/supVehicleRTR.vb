Imports System.Data.SqlClient

Public Class supVehicleRTR
  Inherits supVehicleRSO

  Protected m_dtmDataDenuncia As DateTime
  Protected m_strCorpoDenuncia As String
  Protected m_strNumeroDenuncia As String
  Protected m_strStazioneDenuncia As String
  ' Dati generali di pagamento.
  Protected m_strModalitaPagamento As String
  Protected m_strValuta As String
  Protected m_strValutaSymbol As String
  ' Chiavi tariffe.
  Protected m_intFK_Bollo As Integer
  Protected m_intFK_Custodia12Ore As Integer
  Protected m_intFK_CustodiaPG As Integer
  Protected m_intFK_CustodiaSG As Integer
  ' Descrizioni tariffe.
  Protected m_strTarfChiamata As String
  Protected m_strTarfRimozione As String
  Protected m_strTarfTrasporto As String
  Protected m_strTarfBollo As String
  Protected m_strTarfCustodia12Ore As String
  Protected m_strTarfCustodiaPG As String
  Protected m_strTarfCustodiaSG As String
  ' Importo unitario tariffe.
  Protected m_decImpUnitChiamata As Decimal
  Protected m_decImpUnitRimozione As Decimal
  Protected m_decImpUnitTrasporto As Decimal
  Protected m_decImpUnitBollo As Decimal
  Protected m_decImpUnitCustodia12Ore As Decimal
  Protected m_decImpUnitCustodiaPG As Decimal
  Protected m_decImpUnitCustodiaSG As Decimal
  Protected m_decLimiteInfBollo As Decimal
  ' Importo tariffe.
  Protected m_decImpChiamata As Decimal
  Protected m_decImpRimozione As Decimal
  Protected m_decImpTrasporto As Decimal
  Protected m_decImpBollo As Decimal
  Protected m_decImpCustodia12Ore As Decimal
  Protected m_decImpCustodiaPG As Decimal
  Protected m_decImpCustodiaSG As Decimal
  ' Totali.
  Protected m_decTotRimozione As Decimal
  Protected m_decTotRimozioneBollo As Decimal
  Protected m_decTotCustodia As Decimal
  Protected m_decTotale As Decimal

  Protected m_QuietanzeCdS As supQuietanzeCdS

  ' *****************************************************************************************
  '     CREATION METHODS
  ' *****************************************************************************************
  Public Sub New(ByVal intFK_Rimz As Integer, ByVal strStato As String)

    MyBase.New(intFK_Rimz, strStato)

    m_dtmDataDenuncia = New DateTime(9999, 12, 31, 23, 59, 59)
    m_strCorpoDenuncia = ""
    m_strNumeroDenuncia = ""
    m_strStazioneDenuncia = ""

    m_strModalitaPagamento = ""
    m_strValuta = "EURO"
    m_strValutaSymbol = "€"

  End Sub

  ' *****************************************************************************************
  '     READ-ONLY PROPERTIES
  ' *****************************************************************************************
  Public ReadOnly Property FK_Bollo() As Integer
    Get
      Return m_intFK_Bollo
    End Get
  End Property

  Public ReadOnly Property FK_Custodia12Ore() As Integer
    Get
      Return m_intFK_Custodia12Ore
    End Get
  End Property

  Public ReadOnly Property FK_CustodiaPG() As Integer
    Get
      Return m_intFK_CustodiaPG
    End Get
  End Property

  Public ReadOnly Property FK_CustodiaSG() As Integer
    Get
      Return m_intFK_CustodiaSG
    End Get
  End Property

  Public ReadOnly Property TarfChiamata() As String
    Get
      Return m_strTarfChiamata
    End Get
  End Property

  Public ReadOnly Property TarfRimozione() As String
    Get
      Return m_strTarfRimozione
    End Get
  End Property

  Public ReadOnly Property TarfTrasporto() As String
    Get
      Return m_strTarfTrasporto
    End Get
  End Property

  Public ReadOnly Property TarfBollo() As String
    Get
      Return m_strTarfBollo
    End Get
  End Property

  Public ReadOnly Property TarfCustodia12Ore() As String
    Get
      Return m_strTarfCustodia12Ore
    End Get
  End Property

  Public ReadOnly Property TarfCustodiaPG() As String
    Get
      Return m_strTarfCustodiaPG
    End Get
  End Property

  Public ReadOnly Property TarfCustodiaSG() As String
    Get
      Return m_strTarfCustodiaSG
    End Get
  End Property

  Public ReadOnly Property ImpUnitChiamata() As Decimal
    Get
      Return m_decImpUnitChiamata
    End Get
  End Property

  Public ReadOnly Property ImpUnitRimozione() As Decimal
    Get
      Return m_decImpUnitRimozione
    End Get
  End Property

  Public ReadOnly Property ImpUnitTrasporto() As Decimal
    Get
      Return m_decImpUnitTrasporto
    End Get
  End Property

  Public ReadOnly Property ImpUnitBollo() As Decimal
    Get
      Return m_decImpUnitBollo
    End Get
  End Property

  Public ReadOnly Property ImpUnitCustodia12Ore() As Decimal
    Get
      Return m_decImpUnitCustodia12Ore
    End Get
  End Property

  Public ReadOnly Property ImpUnitCustodiaPG() As Decimal
    Get
      Return m_decImpUnitCustodiaPG
    End Get
  End Property

  Public ReadOnly Property ImpUnitCustodiaSG() As Decimal
    Get
      Return m_decImpUnitCustodiaSG
    End Get
  End Property

  Public ReadOnly Property LimiteInfBollo() As Decimal
    Get
      Return m_decLimiteInfBollo
    End Get
  End Property

  Public ReadOnly Property ImpChiamata() As Decimal
    Get
      Return m_decImpChiamata
    End Get
  End Property

  Public ReadOnly Property ImpRimozione() As Decimal
    Get
      Return m_decImpRimozione
    End Get
  End Property

  Public ReadOnly Property ImpTrasporto() As Decimal
    Get
      Return m_decImpTrasporto
    End Get
  End Property

  Public ReadOnly Property ImpBollo() As Decimal
    Get
      Return m_decImpBollo
    End Get
  End Property

  Public ReadOnly Property ImpCustodia12Ore() As Decimal
    Get
      Return m_decImpCustodia12Ore
    End Get
  End Property

  Public ReadOnly Property ImpCustodiaPG() As Decimal
    Get
      Return m_decImpCustodiaPG
    End Get
  End Property

  Public ReadOnly Property ImpCustodiaSG() As Decimal
    Get
      Return m_decImpCustodiaSG
    End Get
  End Property

  Public ReadOnly Property TotRimozione() As Decimal
    Get
      Return m_decTotRimozione
    End Get
  End Property

  Public ReadOnly Property TotRimozioneBollo() As Decimal
    Get
      Return m_decTotRimozioneBollo
    End Get
  End Property

  Public ReadOnly Property TotCustodia() As Decimal
    Get
      Return m_decTotCustodia
    End Get
  End Property

  Public ReadOnly Property Totale() As Decimal
    Get
      Return m_decTotale
    End Get
  End Property

  ' *****************************************************************************************
  '     PROPERTIES
  ' *****************************************************************************************
  Public Property DataDenuncia() As DateTime
    Get
      Return m_dtmDataDenuncia
    End Get
    Set(ByVal Value As DateTime)
      m_dtmDataDenuncia = Value
    End Set
  End Property

  Public Property CorpoDenuncia() As String
    Get
      Return m_strCorpoDenuncia
    End Get
    Set(ByVal Value As String)
      m_strCorpoDenuncia = Value
    End Set
  End Property

  Public Property NumeroDenuncia() As String
    Get
      Return m_strNumeroDenuncia
    End Get
    Set(ByVal Value As String)
      m_strNumeroDenuncia = Value
    End Set
  End Property

  Public Property StazioneDenuncia() As String
    Get
      Return m_strStazioneDenuncia
    End Get
    Set(ByVal Value As String)
      m_strStazioneDenuncia = Value
    End Set
  End Property

  Public Property ModalitaPagamento() As String
    Get
      Return m_strModalitaPagamento
    End Get
    Set(ByVal Value As String)
      m_strModalitaPagamento = Value
    End Set
  End Property

  Public Property QuietanzeCdS() As supQuietanzeCdS
    Get
      Return m_QuietanzeCdS
    End Get
    Set(ByVal Value As supQuietanzeCdS)
      m_QuietanzeCdS = Value
    End Set
  End Property

  ' *****************************************************************************************
  '     PUBLIC METHODS
  ' *****************************************************************************************
  Public Sub FetchRates()

    Dim tcust As New supTblCustodia(m_dtmDataIngresso, getRateDateOut())
    tcust.Fetch()

    m_intFK_Custodia12Ore = tcust.MG_TarfPK
    m_strTarfCustodia12Ore = tcust.MG_TarfDesc
    m_decImpUnitCustodia12Ore = tcust.MG_UnitCost
    m_decImpCustodia12Ore = tcust.MG_Total

    m_intFK_CustodiaPG = tcust.PG_TarfPK
    m_strTarfCustodiaPG = tcust.PG_TarfDesc
    m_decImpUnitCustodiaPG = tcust.PG_UnitCost
    m_decImpCustodiaPG = tcust.PG_Total

    m_intFK_CustodiaSG = tcust.SG_TarfPK
    m_strTarfCustodiaSG = tcust.SG_TarfDesc
    m_decImpUnitCustodiaSG = tcust.SG_UnitCost
    m_decImpCustodiaSG = tcust.SG_Total

    m_decTotCustodia = tcust.Total

    Dim trimz As New supTblRimozione(m_dtmDataRimozione, m_dtmDataUscita, m_dblPesoPC, m_intDivisore, m_blnFlagChiamata, m_intFK_FaKm, m_decTotCustodia)
    trimz.Fetch()

    m_intFK_Chiamata = trimz.DiCh_RF
    m_strTarfChiamata = trimz.DiCh_Desc
    m_decImpUnitChiamata = trimz.DiCh_UnitCost
    m_decImpChiamata = trimz.DiCh_Importo

    m_intFK_Rimozione = trimz.OpRi_RF
    m_strTarfRimozione = trimz.OpRi_Desc
    m_decImpUnitRimozione = trimz.OpRi_UnitCost
    m_decImpRimozione = trimz.OpRi_UnitCost

    m_intFK_Trasporto = trimz.Tras_RF
    m_strTarfTrasporto = trimz.Tras_Desc
    m_decImpUnitTrasporto = trimz.Tras_UnitCost
    m_decImpTrasporto = trimz.Tras_Importo

    m_intFK_Bollo = trimz.Boll_RF
    m_strTarfBollo = trimz.Boll_Desc
    m_decImpUnitBollo = trimz.Boll_UnitCost
    m_decLimiteInfBollo = trimz.Boll_LimiteInfApp
    m_decImpBollo = trimz.Boll_Importo

    m_decTotRimozione = trimz.TotRimozione
    m_decTotRimozioneBollo = trimz.TotRimozioneBollo

    ' Totale generale.
    m_decTotale = m_decTotRimozioneBollo + m_decTotCustodia

  End Sub

  Public Overloads Overrides Sub Save()

    'Dim tr As New supTransaction
    'tr.SqlCommands.Add(Me.Sql_Insert())
    'tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRTR))
    'If Not tr.Execute() Then
    '  Throw New Exception(tr.ErrorMessage)
    'End If

  End Sub

  Public Overloads Sub Save(ByVal blnPayVerbaliCdS As Boolean)

    Dim i As Integer
    Dim tr As New supTransaction

    tr.SqlCommands.Add(Sql_Insert())
    If (m_dtmDataUscita = getRateDateOut()) Then
      tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRTR))
    Else
      tr.SqlCommands.Add(MyBase.Sql_UpdateReference(supVehicleDPT.TableEnum.tbl_VRTP))
    End If
    If Not (m_QuietanzeCdS Is Nothing) Then
      If (m_QuietanzeCdS.Count > 0) Then
        For i = 0 To m_QuietanzeCdS.UBound
          tr.SqlCommands.Add(m_QuietanzeCdS(i).Sql_Insert())
        Next
      End If
      tr.SqlCommands.Add(Sql_PayVerbaliCdS())
    End If

    If Not tr.Execute() Then
      Throw New Exception(tr.ErrorMessage)
    End If

  End Sub

  ' *****************************************************************************************
  '     PROTECTED METHODS
  ' *****************************************************************************************
  Protected Overrides Function Sql_Insert() As String

    Dim strSql As String

    strSql = "INSERT INTO Angr_VeicoloRTR " & _
                  "(VRTR_Mode, VRTR_PK, VRTR_FK_Rimz, " & _
                  "VRTR_Targa, " & _
                  "VRTR_FK_User, VRTR_UserMatricola, VRTR_UserNominativo, " & _
                  "VRTR_DataIngresso, " & _
                  "VRTR_FK_TiMe, VRTR_Tipo, " & _
                  "VRTR_FK_MaMe, VRTR_Marca, " & _
                  "VRTR_FK_MoMe, VRTR_Modello, " & _
                  "VRTR_PesoPC, VRTR_Divisore, " & _
                  "VRTR_DanniRimz, VRTR_DanniScar, " & _
                  "VRTR_NoteIngresso, " & _
                  "VRTR_DataDenuncia, " & _
                  "VRTR_CorpoDenuncia, " & _
                  "VRTR_NumeroDenuncia, " & _
                  "VRTR_StazioneDenuncia, " & _
                  "VRTR_DataUscita, " & _
                  "VRTR_NumeroPatente, " & _
                  "VRTR_RilascioPatente, " & _
                  "VRTR_TipoDocumento, " & _
                  "VRTR_NumeroDocumento, " & _
                  "VRTR_RilascioDocumento, " & _
                  "VRTR_Ritr_Nome, " & _
                  "VRTR_Ritr_Cognome, " & _
                  "VRTR_Ritr_LuogoNascita, " & _
                  "VRTR_Ritr_DataNascita, " & _
                  "VRTR_Ritr_Indirizzo, " & _
                  "VRTR_Ritr_LuogoResidenza, " & _
                  "VRTR_Prop_Nome, " & _
                  "VRTR_Prop_Cognome, " & _
                  "VRTR_Prop_LuogoNascita, " & _
                  "VRTR_Prop_DataNascita, " & _
                  "VRTR_Prop_Indirizzo, " & _
                  "VRTR_Prop_LuogoResidenza, " & _
                  "VRTR_DanniRitr, " & _
                  "VRTR_NoteUscita, " & _
                  "VRTR_ModalitaPagamento, " & _
                  "VRTR_Valuta, " & _
                  "VRTR_ValutaSymbol, " & _
                  "VRTR_FK_Chiamata, " & _
                  "VRTR_FK_Rimozione, " & _
                  "VRTR_FK_Trasporto, " & _
                  "VRTR_FK_Bollo, " & _
                  "VRTR_FK_Custodia12Ore, " & _
                  "VRTR_FK_CustodiaPG, " & _
                  "VRTR_FK_CustodiaSG, " & _
                  "VRTR_TarfChiamata, " & _
                  "VRTR_TarfRimozione, " & _
                  "VRTR_TarfTrasporto, " & _
                  "VRTR_TarfBollo, " & _
                  "VRTR_TarfCustodia12Ore, " & _
                  "VRTR_TarfCustodiaPG, " & _
                  "VRTR_TarfCustodiaSG, " & _
                  "VRTR_ImpUnitChiamata, " & _
                  "VRTR_ImpUnitRimozione, " & _
                  "VRTR_ImpUnitTrasporto, " & _
                  "VRTR_ImpUnitBollo, " & _
                  "VRTR_ImpUnitCustodia12Ore, " & _
                  "VRTR_ImpUnitCustodiaPG, " & _
                  "VRTR_ImpUnitCustodiaSG, " & _
                  "VRTR_LimiteInfBollo, " & _
                  "VRTR_ImpChiamata, " & _
                  "VRTR_ImpRimozione, " & _
                  "VRTR_ImpTrasporto, " & _
                  "VRTR_ImpBollo, " & _
                  "VRTR_ImpCustodia12Ore, " & _
                  "VRTR_ImpCustodiaPG, " & _
                  "VRTR_ImpCustodiaSG, " & _
                  "VRTR_TotRimozione, " & _
                  "VRTR_TotRimozioneBollo, " & _
                  "VRTR_TotCustodia, " & _
                  "VRTR_Totale) " & _
             "VALUES "
    strSql = strSql & "('M', " & CStr(m_intPK) & ", " & CStr(m_intFK_Rimz) & ", "
    strSql = strSql & "'" & m_strTarga.Replace("'", "''") & "', "
    strSql = strSql & CStr(m_intFK_User) & ", '" & m_strUserMatricola.Replace("'", "''") & "', '" & m_strUserNominativo.Replace("'", "''") & "', "
    strSql = strSql & "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataIngresso) & "', 121), "
    strSql = strSql & CStr(m_intFK_TiMe) & ", '" & m_strTipo.Replace("'", "''") & "', "
    strSql = strSql & CStr(m_intFK_MaMe) & ", '" & m_strMarca.Replace("'", "''") & "', "
    strSql = strSql & CStr(m_intFK_MoMe) & ", '" & m_strModello.Replace("'", "''") & "', "
    strSql = strSql & supFunction.sqlDouble(m_dblPesoPC) & ", " & CStr(m_intDivisore) & ", "
    strSql = strSql & "'" & m_strDanniRimz.Replace("'", "''") & "', '" & m_strDanniScar.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strNoteIngresso.Replace("'", "''") & "', "
    strSql = strSql & "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataDenuncia) & "', 121), "
    strSql = strSql & "'" & m_strCorpoDenuncia.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strNumeroDenuncia.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strStazioneDenuncia.Replace("'", "''") & "', "
    strSql = strSql & "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmDataUscita) & "', 121), "
    strSql = strSql & "'" & m_strNumeroPatente.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRilascioPatente.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTipoDocumento.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strNumeroDocumento.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRilascioDocumento.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRitr_Nome.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRitr_Cognome.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRitr_LuogoNascita.Replace("'", "''") & "', "
    strSql = strSql & "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmRitr_DataNascita) & "', 121), "
    strSql = strSql & "'" & m_strRitr_Indirizzo.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strRitr_LuogoResidenza.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strProp_Nome.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strProp_Cognome.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strProp_LuogoNascita.Replace("'", "''") & "', "
    strSql = strSql & "CONVERT(datetime, '" & supFunction.sqlDate121(m_dtmProp_DataNascita) & "', 121), "
    strSql = strSql & "'" & m_strProp_Indirizzo.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strProp_LuogoResidenza.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strDanniRitr.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strNoteUscita.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strModalitaPagamento.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strValuta.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strValutaSymbol.Replace("'", "''") & "', "
    strSql = strSql & CStr(m_intFK_Chiamata) & ", "
    strSql = strSql & CStr(m_intFK_Rimozione) & ", "
    strSql = strSql & CStr(m_intFK_Trasporto) & ", "
    strSql = strSql & CStr(m_intFK_Bollo) & ", "
    strSql = strSql & CStr(m_intFK_Custodia12Ore) & ", "
    strSql = strSql & CStr(m_intFK_CustodiaPG) & ", "
    strSql = strSql & CStr(m_intFK_CustodiaSG) & ", "
    strSql = strSql & "'" & m_strTarfChiamata.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfRimozione.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfTrasporto.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfBollo.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfCustodia12Ore.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfCustodiaPG.Replace("'", "''") & "', "
    strSql = strSql & "'" & m_strTarfCustodiaSG.Replace("'", "''") & "', "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitChiamata) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitRimozione) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitTrasporto) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitBollo) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitCustodia12Ore) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitCustodiaPG) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpUnitCustodiaSG) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decLimiteInfBollo) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpChiamata) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpRimozione) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpTrasporto) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpBollo) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpCustodia12Ore) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpCustodiaPG) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decImpCustodiaSG) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decTotRimozione) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decTotRimozioneBollo) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decTotCustodia) & ", "
    strSql = strSql & supFunction.sqlMoney(m_decTotale) & ") "

    Return strSql

  End Function

  Protected Function getRateDateOut() As DateTime

    Dim dtmDateOut As New DateTime(9999, 12, 31, 23, 59, 59)

    If (dtmDateOut >= m_dtmDataDenuncia) Then
      dtmDateOut = m_dtmDataDenuncia
    End If

    If (dtmDateOut >= m_dtmDataBlocco) Then
      dtmDateOut = m_dtmDataBlocco
    End If

    If (dtmDateOut >= m_dtmDataUscita) Then
      dtmDateOut = m_dtmDataUscita
    End If

    Return dtmDateOut

  End Function

  Protected Function Sql_PayVerbaliCdS() As String

    Dim strSql As String

    strSql = "UPDATE " & _
                  "Angr_VerbaleCdS " & _
             "SET " & _
                  "VCdS_Pagato = 1 " & _
             "WHERE " & _
                  "VCdS_FK_Rimz = " & CStr(m_intFK_Rimz)
    Return strSql

  End Function

End Class
