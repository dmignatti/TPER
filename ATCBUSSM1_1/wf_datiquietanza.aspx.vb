Public Class wf_datiquietanza
  Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents lblTableName As System.Web.UI.WebControls.Label
  Protected WithEvents lblRecordID As System.Web.UI.WebControls.Label
  Protected WithEvents lblUserLogin As System.Web.UI.WebControls.Label
  Protected WithEvents lblUserName As System.Web.UI.WebControls.Label
  Protected WithEvents lblError As System.Web.UI.WebControls.Label
  Protected WithEvents hlkBack As System.Web.UI.WebControls.HyperLink

  'NOTE: The following placeholder declaration is required by the Web Form Designer.
  'Do not delete or move it.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim intVehicleID As Integer
    Dim intState As supVehicleSearch.VehicleStateEnum

    Try
      intVehicleID = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleID))
      intState = System.Convert.ToInt32(Request.QueryString(atcbConstant.QS_VehicleState))
      Fetch(intVehicleID, intState)
    Catch ex As Exception
      lblError.Text = ex.Message
    End Try

  End Sub

  Private Sub Fetch(ByVal intVehicleID As Integer, ByVal intState As supVehicleSearch.VehicleStateEnum)

    Dim strSql, strFP As String
    Dim cnn As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader

    strFP = GetFieldPrefix(intState)

    strSql = "SELECT " & _
                  strFP & "Mode AS XMode, " & strFP & "PK AS XPK, " & _
                  "ISNULL(" & strFP & "UserMatricola, '') AS XUserMatricola, " & _
                  "ISNULL(" & strFP & "UserNominativo, '') AS XUserNominativo " & _
             "FROM " & _
                  GetTableName(intState) & " " & _
             "WHERE " & _
                  strFP & "FK_Rimz = " & CStr(intVehicleID)
    cnn = New SqlClient.SqlConnection(atcbConstant.CS_CnnStringGDATC)
    Try
      cnn.Open()
    Catch ex As Exception
      cnn.Dispose()
      Throw New Exception("Impossibile stabilire una connessione ai dati.")
    End Try

    cmd = New SqlClient.SqlCommand(strSql, cnn)
    Try
      dr = cmd.ExecuteReader()
      dr.Read()
      lblTableName.Text = GetTableName(intState)
      lblRecordID.Text = System.Convert.ToString(dr("XMode")) & " " & System.Convert.ToString(dr("XPK"))
      lblUserLogin.Text = System.Convert.ToString(dr("XUserMatricola"))
      lblUserName.Text = System.Convert.ToString(dr("XUserNominativo"))
      dr.Close()
    Catch ex As Exception
      Throw New Exception("Errore di accesso ai dati.")
    Finally
      cnn.Close()
      cmd.Dispose()
      cnn.Dispose()
    End Try

  End Sub

  Private Function GetTableName(ByVal intState As supVehicleSearch.VehicleStateEnum) As String

    Select Case intState
      Case supVehicleSearch.VehicleStateEnum.vseHND
        Return "Angr_VeicoloHND"
      Case supVehicleSearch.VehicleStateEnum.vseRBD
        Return "Angr_VeicoloRBD"
      Case supVehicleSearch.VehicleStateEnum.vseRBT
        Return "Angr_VeicoloRBT"
      Case supVehicleSearch.VehicleStateEnum.vseRSO
        Return "Angr_VeicoloRSO"
      Case supVehicleSearch.VehicleStateEnum.vseRTP, supVehicleSearch.VehicleStateEnum.vseRTR
        Return "Angr_VeicoloRTR"
      Case supVehicleSearch.VehicleStateEnum.vseRVI
        Return "Angr_VeicoloRVI"
      Case Else
        Return ""
    End Select

  End Function

  Private Function GetFieldPrefix(ByVal intState As supVehicleSearch.VehicleStateEnum) As String

    Select Case intState
      Case supVehicleSearch.VehicleStateEnum.vseHND
        Return "VHND_"
      Case supVehicleSearch.VehicleStateEnum.vseRBD
        Return "VRBD_"
      Case supVehicleSearch.VehicleStateEnum.vseRBT
        Return "VRBT_"
      Case supVehicleSearch.VehicleStateEnum.vseRSO
        Return "VRSO_"
      Case supVehicleSearch.VehicleStateEnum.vseRTP, supVehicleSearch.VehicleStateEnum.vseRTR
        Return "VRTR_"
      Case supVehicleSearch.VehicleStateEnum.vseRVI
        Return "VRVI_"
      Case Else
        Return ""
    End Select

  End Function

End Class
