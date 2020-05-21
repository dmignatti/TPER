﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Diagnostics.DebuggerStepThrough(), _
 System.ComponentModel.ToolboxItem(True)> _
Public Class dsCambiTurnoGiornalieri1
  Inherits DataSet

  Private tableAccertatori As AccertatoriDataTable

  Private tableRichiesteCambiTurno As RichiesteCambiTurnoDataTable

  Public Sub New()
    MyBase.New()
    Me.InitClass()
    Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
    AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
    AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
  End Sub

  Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
    MyBase.New()
    Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)), String)
    If (Not (strSchema) Is Nothing) Then
      Dim ds As DataSet = New DataSet
      ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
      If (Not (ds.Tables("Accertatori")) Is Nothing) Then
        Me.Tables.Add(New AccertatoriDataTable(ds.Tables("Accertatori")))
      End If
      If (Not (ds.Tables("RichiesteCambiTurno")) Is Nothing) Then
        Me.Tables.Add(New RichiesteCambiTurnoDataTable(ds.Tables("RichiesteCambiTurno")))
      End If
      Me.DataSetName = ds.DataSetName
      Me.Prefix = ds.Prefix
      Me.Namespace = ds.Namespace
      Me.Locale = ds.Locale
      Me.CaseSensitive = ds.CaseSensitive
      Me.EnforceConstraints = ds.EnforceConstraints
      Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
      Me.InitVars()
    Else
      Me.InitClass()
    End If
    Me.GetSerializationData(info, context)
    Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
    AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
    AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
  End Sub

  <System.ComponentModel.Browsable(False), _
   System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
  Public ReadOnly Property Accertatori() As AccertatoriDataTable
    Get
      Return Me.tableAccertatori
    End Get
  End Property

  <System.ComponentModel.Browsable(False), _
   System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
  Public ReadOnly Property RichiesteCambiTurno() As RichiesteCambiTurnoDataTable
    Get
      Return Me.tableRichiesteCambiTurno
    End Get
  End Property

  Public Overrides Function Clone() As DataSet
    Dim cln As dsCambiTurnoGiornalieri = CType(MyBase.Clone, dsCambiTurnoGiornalieri)
    cln.InitVars()
    Return cln
  End Function

  Protected Overrides Function ShouldSerializeTables() As Boolean
    Return False
  End Function

  Protected Overrides Function ShouldSerializeRelations() As Boolean
    Return False
  End Function

  Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
    Me.Reset()
    Dim ds As DataSet = New DataSet
    ds.ReadXml(reader)
    If (Not (ds.Tables("Accertatori")) Is Nothing) Then
      Me.Tables.Add(New AccertatoriDataTable(ds.Tables("Accertatori")))
    End If
    If (Not (ds.Tables("RichiesteCambiTurno")) Is Nothing) Then
      Me.Tables.Add(New RichiesteCambiTurnoDataTable(ds.Tables("RichiesteCambiTurno")))
    End If
    Me.DataSetName = ds.DataSetName
    Me.Prefix = ds.Prefix
    Me.Namespace = ds.Namespace
    Me.Locale = ds.Locale
    Me.CaseSensitive = ds.CaseSensitive
    Me.EnforceConstraints = ds.EnforceConstraints
    Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
    Me.InitVars()
  End Sub

  Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
    Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
    Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
    stream.Position = 0
    Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
  End Function

  Friend Sub InitVars()
    Me.tableAccertatori = CType(Me.Tables("Accertatori"), AccertatoriDataTable)
    If (Not (Me.tableAccertatori) Is Nothing) Then
      Me.tableAccertatori.InitVars()
    End If
    Me.tableRichiesteCambiTurno = CType(Me.Tables("RichiesteCambiTurno"), RichiesteCambiTurnoDataTable)
    If (Not (Me.tableRichiesteCambiTurno) Is Nothing) Then
      Me.tableRichiesteCambiTurno.InitVars()
    End If
  End Sub

  Private Sub InitClass()
    Me.DataSetName = "dsCambiTurnoGiornalieri"
    Me.Prefix = ""
    Me.Namespace = "http://www.tempuri.org/dsCambiTurnoGiornalieri.xsd"
    Me.Locale = New System.Globalization.CultureInfo("it-IT")
    Me.CaseSensitive = False
    Me.EnforceConstraints = True
    Me.tableAccertatori = New AccertatoriDataTable
    Me.Tables.Add(Me.tableAccertatori)
    Me.tableRichiesteCambiTurno = New RichiesteCambiTurnoDataTable
    Me.Tables.Add(Me.tableRichiesteCambiTurno)
  End Sub

  Private Function ShouldSerializeAccertatori() As Boolean
    Return False
  End Function

  Private Function ShouldSerializeRichiesteCambiTurno() As Boolean
    Return False
  End Function

  Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
    If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
      Me.InitVars()
    End If
  End Sub

  Public Delegate Sub AccertatoriRowChangeEventHandler(ByVal sender As Object, ByVal e As AccertatoriRowChangeEvent)

  Public Delegate Sub RichiesteCambiTurnoRowChangeEventHandler(ByVal sender As Object, ByVal e As RichiesteCambiTurnoRowChangeEvent)

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class AccertatoriDataTable
    Inherits DataTable
    Implements System.Collections.IEnumerable

    Private columnMatricola As DataColumn

    Private columnAccertatore As DataColumn

    Private columnData As DataColumn

    Private columnTurno As DataColumn

    Private columnCognomeNome As DataColumn

    Private columnID As DataColumn

    Friend Sub New()
      MyBase.New("Accertatori")
      Me.InitClass()
    End Sub

    Friend Sub New(ByVal table As DataTable)
      MyBase.New(table.TableName)
      If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
        Me.CaseSensitive = table.CaseSensitive
      End If
      If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
        Me.Locale = table.Locale
      End If
      If (table.Namespace <> table.DataSet.Namespace) Then
        Me.Namespace = table.Namespace
      End If
      Me.Prefix = table.Prefix
      Me.MinimumCapacity = table.MinimumCapacity
      Me.DisplayExpression = table.DisplayExpression
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Count() As Integer
      Get
        Return Me.Rows.Count
      End Get
    End Property

    Friend ReadOnly Property MatricolaColumn() As DataColumn
      Get
        Return Me.columnMatricola
      End Get
    End Property

    Friend ReadOnly Property AccertatoreColumn() As DataColumn
      Get
        Return Me.columnAccertatore
      End Get
    End Property

    Friend ReadOnly Property DataColumn() As DataColumn
      Get
        Return Me.columnData
      End Get
    End Property

    Friend ReadOnly Property TurnoColumn() As DataColumn
      Get
        Return Me.columnTurno
      End Get
    End Property

    Friend ReadOnly Property CognomeNomeColumn() As DataColumn
      Get
        Return Me.columnCognomeNome
      End Get
    End Property

    Friend ReadOnly Property IDColumn() As DataColumn
      Get
        Return Me.columnID
      End Get
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As AccertatoriRow
      Get
        Return CType(Me.Rows(index), AccertatoriRow)
      End Get
    End Property

    Public Event AccertatoriRowChanged As AccertatoriRowChangeEventHandler

    Public Event AccertatoriRowChanging As AccertatoriRowChangeEventHandler

    Public Event AccertatoriRowDeleted As AccertatoriRowChangeEventHandler

    Public Event AccertatoriRowDeleting As AccertatoriRowChangeEventHandler

    Public Overloads Sub AddAccertatoriRow(ByVal row As AccertatoriRow)
      Me.Rows.Add(row)
    End Sub

    Public Overloads Function AddAccertatoriRow(ByVal Matricola As Decimal, ByVal Accertatore As String, ByVal Data As Date, ByVal Turno As Decimal, ByVal CognomeNome As String) As AccertatoriRow
      Dim rowAccertatoriRow As AccertatoriRow = CType(Me.NewRow, AccertatoriRow)
      rowAccertatoriRow.ItemArray = New Object() {Matricola, Accertatore, Data, Turno, CognomeNome, Nothing}
      Me.Rows.Add(rowAccertatoriRow)
      Return rowAccertatoriRow
    End Function

    Public Function FindByMatricola(ByVal Matricola As Decimal) As AccertatoriRow
      Return CType(Me.Rows.Find(New Object() {Matricola}), AccertatoriRow)
    End Function

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Me.Rows.GetEnumerator
    End Function

    Public Overrides Function Clone() As DataTable
      Dim cln As AccertatoriDataTable = CType(MyBase.Clone, AccertatoriDataTable)
      cln.InitVars()
      Return cln
    End Function

    Protected Overrides Function CreateInstance() As DataTable
      Return New AccertatoriDataTable
    End Function

    Friend Sub InitVars()
      Me.columnMatricola = Me.Columns("Matricola")
      Me.columnAccertatore = Me.Columns("Accertatore")
      Me.columnData = Me.Columns("Data")
      Me.columnTurno = Me.Columns("Turno")
      Me.columnCognomeNome = Me.Columns("CognomeNome")
      Me.columnID = Me.Columns("ID")
    End Sub

    Private Sub InitClass()
      Me.columnMatricola = New DataColumn("Matricola", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnMatricola)
      Me.columnAccertatore = New DataColumn("Accertatore", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnAccertatore)
      Me.columnData = New DataColumn("Data", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnData)
      Me.columnTurno = New DataColumn("Turno", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnTurno)
      Me.columnCognomeNome = New DataColumn("CognomeNome", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnCognomeNome)
      Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnID)
      Me.Constraints.Add(New UniqueConstraint("dsCambiTurnoGiornalieriKey1", New DataColumn() {Me.columnMatricola}, True))
      Me.columnMatricola.AllowDBNull = False
      Me.columnMatricola.Unique = True
      Me.columnAccertatore.ReadOnly = True
      Me.columnID.AutoIncrement = True
      Me.columnID.ReadOnly = True
    End Sub

    Public Function NewAccertatoriRow() As AccertatoriRow
      Return CType(Me.NewRow, AccertatoriRow)
    End Function

    Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
      Return New AccertatoriRow(builder)
    End Function

    Protected Overrides Function GetRowType() As System.Type
      Return GetType(AccertatoriRow)
    End Function

    Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanged(e)
      If (Not (Me.AccertatoriRowChangedEvent) Is Nothing) Then
        RaiseEvent AccertatoriRowChanged(Me, New AccertatoriRowChangeEvent(CType(e.Row, AccertatoriRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanging(e)
      If (Not (Me.AccertatoriRowChangingEvent) Is Nothing) Then
        RaiseEvent AccertatoriRowChanging(Me, New AccertatoriRowChangeEvent(CType(e.Row, AccertatoriRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleted(e)
      If (Not (Me.AccertatoriRowDeletedEvent) Is Nothing) Then
        RaiseEvent AccertatoriRowDeleted(Me, New AccertatoriRowChangeEvent(CType(e.Row, AccertatoriRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleting(e)
      If (Not (Me.AccertatoriRowDeletingEvent) Is Nothing) Then
        RaiseEvent AccertatoriRowDeleting(Me, New AccertatoriRowChangeEvent(CType(e.Row, AccertatoriRow), e.Action))
      End If
    End Sub

    Public Sub RemoveAccertatoriRow(ByVal row As AccertatoriRow)
      Me.Rows.Remove(row)
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class AccertatoriRow
    Inherits DataRow

    Private tableAccertatori As AccertatoriDataTable

    Friend Sub New(ByVal rb As DataRowBuilder)
      MyBase.New(rb)
      Me.tableAccertatori = CType(Me.Table, AccertatoriDataTable)
    End Sub

    Public Property Matricola() As Decimal
      Get
        Return CType(Me(Me.tableAccertatori.MatricolaColumn), Decimal)
      End Get
      Set(ByVal Value As Decimal)
        Me(Me.tableAccertatori.MatricolaColumn) = Value
      End Set
    End Property

    Public Property Accertatore() As String
      Get
        Try
          Return CType(Me(Me.tableAccertatori.AccertatoreColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableAccertatori.AccertatoreColumn) = Value
      End Set
    End Property

    Public Property Data() As Date
      Get
        Try
          Return CType(Me(Me.tableAccertatori.DataColumn), Date)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Date)
        Me(Me.tableAccertatori.DataColumn) = Value
      End Set
    End Property

    Public Property Turno() As Decimal
      Get
        Try
          Return CType(Me(Me.tableAccertatori.TurnoColumn), Decimal)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Decimal)
        Me(Me.tableAccertatori.TurnoColumn) = Value
      End Set
    End Property

    Public Property CognomeNome() As String
      Get
        Try
          Return CType(Me(Me.tableAccertatori.CognomeNomeColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableAccertatori.CognomeNomeColumn) = Value
      End Set
    End Property

    Public Property ID() As Integer
      Get
        Try
          Return CType(Me(Me.tableAccertatori.IDColumn), Integer)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Integer)
        Me(Me.tableAccertatori.IDColumn) = Value
      End Set
    End Property

    Public Function IsAccertatoreNull() As Boolean
      Return Me.IsNull(Me.tableAccertatori.AccertatoreColumn)
    End Function

    Public Sub SetAccertatoreNull()
      Me(Me.tableAccertatori.AccertatoreColumn) = System.Convert.DBNull
    End Sub

    Public Function IsDataNull() As Boolean
      Return Me.IsNull(Me.tableAccertatori.DataColumn)
    End Function

    Public Sub SetDataNull()
      Me(Me.tableAccertatori.DataColumn) = System.Convert.DBNull
    End Sub

    Public Function IsTurnoNull() As Boolean
      Return Me.IsNull(Me.tableAccertatori.TurnoColumn)
    End Function

    Public Sub SetTurnoNull()
      Me(Me.tableAccertatori.TurnoColumn) = System.Convert.DBNull
    End Sub

    Public Function IsCognomeNomeNull() As Boolean
      Return Me.IsNull(Me.tableAccertatori.CognomeNomeColumn)
    End Function

    Public Sub SetCognomeNomeNull()
      Me(Me.tableAccertatori.CognomeNomeColumn) = System.Convert.DBNull
    End Sub

    Public Function IsIDNull() As Boolean
      Return Me.IsNull(Me.tableAccertatori.IDColumn)
    End Function

    Public Sub SetIDNull()
      Me(Me.tableAccertatori.IDColumn) = System.Convert.DBNull
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class AccertatoriRowChangeEvent
    Inherits EventArgs

    Private eventRow As AccertatoriRow

    Private eventAction As DataRowAction

    Public Sub New(ByVal row As AccertatoriRow, ByVal action As DataRowAction)
      MyBase.New()
      Me.eventRow = row
      Me.eventAction = action
    End Sub

    Public ReadOnly Property Row() As AccertatoriRow
      Get
        Return Me.eventRow
      End Get
    End Property

    Public ReadOnly Property Action() As DataRowAction
      Get
        Return Me.eventAction
      End Get
    End Property
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class RichiesteCambiTurnoDataTable
    Inherits DataTable
    Implements System.Collections.IEnumerable

    Private columnts As dataColumn

    Private columnIdRichiesta As dataColumn

    Private columnIdAccertatoreRichiedente As dataColumn

    Private columnTurnoRichiedente As dataColumn

    Private columnIdAccertatoreDestinatario As dataColumn

    Private columnTurnoDestinatario As dataColumn

    Private columnDestinatario As dataColumn

    Private columndata As dataColumn

    Private columnStatoRichiesta As dataColumn

    Private columnStatoApprovazione As dataColumn

    Private columnID As dataColumn

    Private columnMatricolaAccertatoreDestinatario As dataColumn

    Friend Sub New()
      MyBase.New("RichiesteCambiTurno")
      Me.InitClass()
    End Sub

    Friend Sub New(ByVal table As DataTable)
      MyBase.New(table.TableName)
      If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
        Me.CaseSensitive = table.CaseSensitive
      End If
      If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
        Me.Locale = table.Locale
      End If
      If (table.Namespace <> table.DataSet.Namespace) Then
        Me.Namespace = table.Namespace
      End If
      Me.Prefix = table.Prefix
      Me.MinimumCapacity = table.MinimumCapacity
      Me.DisplayExpression = table.DisplayExpression
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Count() As Integer
      Get
        Return Me.Rows.Count
      End Get
    End Property

    Friend ReadOnly Property tsColumn() As dataColumn
      Get
        Return Me.columnts
      End Get
    End Property

    Friend ReadOnly Property IdRichiestaColumn() As dataColumn
      Get
        Return Me.columnIdRichiesta
      End Get
    End Property

    Friend ReadOnly Property IdAccertatoreRichiedenteColumn() As dataColumn
      Get
        Return Me.columnIdAccertatoreRichiedente
      End Get
    End Property

    Friend ReadOnly Property TurnoRichiedenteColumn() As dataColumn
      Get
        Return Me.columnTurnoRichiedente
      End Get
    End Property

    Friend ReadOnly Property IdAccertatoreDestinatarioColumn() As dataColumn
      Get
        Return Me.columnIdAccertatoreDestinatario
      End Get
    End Property

    Friend ReadOnly Property TurnoDestinatarioColumn() As dataColumn
      Get
        Return Me.columnTurnoDestinatario
      End Get
    End Property

    Friend ReadOnly Property DestinatarioColumn() As dataColumn
      Get
        Return Me.columnDestinatario
      End Get
    End Property

    Friend ReadOnly Property dataColumn() As dataColumn
      Get
        Return Me.columndata
      End Get
    End Property

    Friend ReadOnly Property StatoRichiestaColumn() As dataColumn
      Get
        Return Me.columnStatoRichiesta
      End Get
    End Property

    Friend ReadOnly Property StatoApprovazioneColumn() As dataColumn
      Get
        Return Me.columnStatoApprovazione
      End Get
    End Property

    Friend ReadOnly Property IDColumn() As dataColumn
      Get
        Return Me.columnID
      End Get
    End Property

    Friend ReadOnly Property MatricolaAccertatoreDestinatarioColumn() As dataColumn
      Get
        Return Me.columnMatricolaAccertatoreDestinatario
      End Get
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As RichiesteCambiTurnoRow
      Get
        Return CType(Me.Rows(index), RichiesteCambiTurnoRow)
      End Get
    End Property

    Public Event RichiesteCambiTurnoRowChanged As RichiesteCambiTurnoRowChangeEventHandler

    Public Event RichiesteCambiTurnoRowChanging As RichiesteCambiTurnoRowChangeEventHandler

    Public Event RichiesteCambiTurnoRowDeleted As RichiesteCambiTurnoRowChangeEventHandler

    Public Event RichiesteCambiTurnoRowDeleting As RichiesteCambiTurnoRowChangeEventHandler

    Public Overloads Sub AddRichiesteCambiTurnoRow(ByVal row As RichiesteCambiTurnoRow)
      Me.Rows.Add(row)
    End Sub

    Public Overloads Function AddRichiesteCambiTurnoRow(ByVal ts As Date, ByVal IdRichiesta As System.Guid, ByVal IdAccertatoreRichiedente As Integer, ByVal TurnoRichiedente As String, ByVal IdAccertatoreDestinatario As Integer, ByVal TurnoDestinatario As String, ByVal Destinatario As String, ByVal data As Date, ByVal StatoRichiesta As String, ByVal StatoApprovazione As String, ByVal MatricolaAccertatoreDestinatario As String) As RichiesteCambiTurnoRow
      Dim rowRichiesteCambiTurnoRow As RichiesteCambiTurnoRow = CType(Me.NewRow, RichiesteCambiTurnoRow)
      rowRichiesteCambiTurnoRow.ItemArray = New Object() {ts, IdRichiesta, IdAccertatoreRichiedente, TurnoRichiedente, IdAccertatoreDestinatario, TurnoDestinatario, Destinatario, data, StatoRichiesta, StatoApprovazione, Nothing, MatricolaAccertatoreDestinatario}
      Me.Rows.Add(rowRichiesteCambiTurnoRow)
      Return rowRichiesteCambiTurnoRow
    End Function

    Public Function FindByIdRichiesta(ByVal IdRichiesta As System.Guid) As RichiesteCambiTurnoRow
      Return CType(Me.Rows.Find(New Object() {IdRichiesta}), RichiesteCambiTurnoRow)
    End Function

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Me.Rows.GetEnumerator
    End Function

    Public Overrides Function Clone() As DataTable
      Dim cln As RichiesteCambiTurnoDataTable = CType(MyBase.Clone, RichiesteCambiTurnoDataTable)
      cln.InitVars()
      Return cln
    End Function

    Protected Overrides Function CreateInstance() As DataTable
      Return New RichiesteCambiTurnoDataTable
    End Function

    Friend Sub InitVars()
      Me.columnts = Me.Columns("ts")
      Me.columnIdRichiesta = Me.Columns("IdRichiesta")
      Me.columnIdAccertatoreRichiedente = Me.Columns("IdAccertatoreRichiedente")
      Me.columnTurnoRichiedente = Me.Columns("TurnoRichiedente")
      Me.columnIdAccertatoreDestinatario = Me.Columns("IdAccertatoreDestinatario")
      Me.columnTurnoDestinatario = Me.Columns("TurnoDestinatario")
      Me.columnDestinatario = Me.Columns("Destinatario")
      Me.columndata = Me.Columns("data")
      Me.columnStatoRichiesta = Me.Columns("StatoRichiesta")
      Me.columnStatoApprovazione = Me.Columns("StatoApprovazione")
      Me.columnID = Me.Columns("ID")
      Me.columnMatricolaAccertatoreDestinatario = Me.Columns("MatricolaAccertatoreDestinatario")
    End Sub

    Private Sub InitClass()
      Me.columnts = New DataColumn("ts", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnts)
      Me.columnIdRichiesta = New DataColumn("IdRichiesta", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnIdRichiesta)
      Me.columnIdAccertatoreRichiedente = New DataColumn("IdAccertatoreRichiedente", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnIdAccertatoreRichiedente)
      Me.columnTurnoRichiedente = New DataColumn("TurnoRichiedente", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnTurnoRichiedente)
      Me.columnIdAccertatoreDestinatario = New DataColumn("IdAccertatoreDestinatario", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnIdAccertatoreDestinatario)
      Me.columnTurnoDestinatario = New DataColumn("TurnoDestinatario", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnTurnoDestinatario)
      Me.columnDestinatario = New DataColumn("Destinatario", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnDestinatario)
      Me.columndata = New DataColumn("data", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columndata)
      Me.columnStatoRichiesta = New DataColumn("StatoRichiesta", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnStatoRichiesta)
      Me.columnStatoApprovazione = New DataColumn("StatoApprovazione", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnStatoApprovazione)
      Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnID)
      Me.columnMatricolaAccertatoreDestinatario = New DataColumn("MatricolaAccertatoreDestinatario", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnMatricolaAccertatoreDestinatario)
      Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnIdRichiesta}, True))
      Me.columnIdRichiesta.AllowDBNull = False
      Me.columnIdRichiesta.Unique = True
      Me.columnDestinatario.ReadOnly = True
      Me.columnStatoRichiesta.ReadOnly = True
      Me.columnStatoApprovazione.ReadOnly = True
      Me.columnID.AutoIncrement = True
      Me.columnID.ReadOnly = True
    End Sub

    Public Function NewRichiesteCambiTurnoRow() As RichiesteCambiTurnoRow
      Return CType(Me.NewRow, RichiesteCambiTurnoRow)
    End Function

    Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
      Return New RichiesteCambiTurnoRow(builder)
    End Function

    Protected Overrides Function GetRowType() As System.Type
      Return GetType(RichiesteCambiTurnoRow)
    End Function

    Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanged(e)
      If (Not (Me.RichiesteCambiTurnoRowChangedEvent) Is Nothing) Then
        RaiseEvent RichiesteCambiTurnoRowChanged(Me, New RichiesteCambiTurnoRowChangeEvent(CType(e.Row, RichiesteCambiTurnoRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanging(e)
      If (Not (Me.RichiesteCambiTurnoRowChangingEvent) Is Nothing) Then
        RaiseEvent RichiesteCambiTurnoRowChanging(Me, New RichiesteCambiTurnoRowChangeEvent(CType(e.Row, RichiesteCambiTurnoRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleted(e)
      If (Not (Me.RichiesteCambiTurnoRowDeletedEvent) Is Nothing) Then
        RaiseEvent RichiesteCambiTurnoRowDeleted(Me, New RichiesteCambiTurnoRowChangeEvent(CType(e.Row, RichiesteCambiTurnoRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleting(e)
      If (Not (Me.RichiesteCambiTurnoRowDeletingEvent) Is Nothing) Then
        RaiseEvent RichiesteCambiTurnoRowDeleting(Me, New RichiesteCambiTurnoRowChangeEvent(CType(e.Row, RichiesteCambiTurnoRow), e.Action))
      End If
    End Sub

    Public Sub RemoveRichiesteCambiTurnoRow(ByVal row As RichiesteCambiTurnoRow)
      Me.Rows.Remove(row)
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class RichiesteCambiTurnoRow
    Inherits DataRow

    Private tableRichiesteCambiTurno As RichiesteCambiTurnoDataTable

    Friend Sub New(ByVal rb As DataRowBuilder)
      MyBase.New(rb)
      Me.tableRichiesteCambiTurno = CType(Me.Table, RichiesteCambiTurnoDataTable)
    End Sub

    Public Property ts() As Date
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.tsColumn), Date)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Date)
        Me(Me.tableRichiesteCambiTurno.tsColumn) = Value
      End Set
    End Property

    Public Property IdRichiesta() As System.Guid
      Get
        Return CType(Me(Me.tableRichiesteCambiTurno.IdRichiestaColumn), System.Guid)
      End Get
      Set(ByVal Value As System.Guid)
        Me(Me.tableRichiesteCambiTurno.IdRichiestaColumn) = Value
      End Set
    End Property

    Public Property IdAccertatoreRichiedente() As Integer
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.IdAccertatoreRichiedenteColumn), Integer)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Integer)
        Me(Me.tableRichiesteCambiTurno.IdAccertatoreRichiedenteColumn) = Value
      End Set
    End Property

    Public Property TurnoRichiedente() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.TurnoRichiedenteColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.TurnoRichiedenteColumn) = Value
      End Set
    End Property

    Public Property IdAccertatoreDestinatario() As Integer
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.IdAccertatoreDestinatarioColumn), Integer)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Integer)
        Me(Me.tableRichiesteCambiTurno.IdAccertatoreDestinatarioColumn) = Value
      End Set
    End Property

    Public Property TurnoDestinatario() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.TurnoDestinatarioColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.TurnoDestinatarioColumn) = Value
      End Set
    End Property

    Public Property Destinatario() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.DestinatarioColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.DestinatarioColumn) = Value
      End Set
    End Property

    Public Property data() As Date
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.dataColumn), Date)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Date)
        Me(Me.tableRichiesteCambiTurno.dataColumn) = Value
      End Set
    End Property

    Public Property StatoRichiesta() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.StatoRichiestaColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.StatoRichiestaColumn) = Value
      End Set
    End Property

    Public Property StatoApprovazione() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.StatoApprovazioneColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.StatoApprovazioneColumn) = Value
      End Set
    End Property

    Public Property ID() As Integer
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.IDColumn), Integer)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As Integer)
        Me(Me.tableRichiesteCambiTurno.IDColumn) = Value
      End Set
    End Property

    Public Property MatricolaAccertatoreDestinatario() As String
      Get
        Try
          Return CType(Me(Me.tableRichiesteCambiTurno.MatricolaAccertatoreDestinatarioColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableRichiesteCambiTurno.MatricolaAccertatoreDestinatarioColumn) = Value
      End Set
    End Property

    Public Function IstsNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.tsColumn)
    End Function

    Public Sub SettsNull()
      Me(Me.tableRichiesteCambiTurno.tsColumn) = System.Convert.DBNull
    End Sub

    Public Function IsIdAccertatoreRichiedenteNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.IdAccertatoreRichiedenteColumn)
    End Function

    Public Sub SetIdAccertatoreRichiedenteNull()
      Me(Me.tableRichiesteCambiTurno.IdAccertatoreRichiedenteColumn) = System.Convert.DBNull
    End Sub

    Public Function IsTurnoRichiedenteNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.TurnoRichiedenteColumn)
    End Function

    Public Sub SetTurnoRichiedenteNull()
      Me(Me.tableRichiesteCambiTurno.TurnoRichiedenteColumn) = System.Convert.DBNull
    End Sub

    Public Function IsIdAccertatoreDestinatarioNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.IdAccertatoreDestinatarioColumn)
    End Function

    Public Sub SetIdAccertatoreDestinatarioNull()
      Me(Me.tableRichiesteCambiTurno.IdAccertatoreDestinatarioColumn) = System.Convert.DBNull
    End Sub

    Public Function IsTurnoDestinatarioNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.TurnoDestinatarioColumn)
    End Function

    Public Sub SetTurnoDestinatarioNull()
      Me(Me.tableRichiesteCambiTurno.TurnoDestinatarioColumn) = System.Convert.DBNull
    End Sub

    Public Function IsDestinatarioNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.DestinatarioColumn)
    End Function

    Public Sub SetDestinatarioNull()
      Me(Me.tableRichiesteCambiTurno.DestinatarioColumn) = System.Convert.DBNull
    End Sub

    Public Function IsdataNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.dataColumn)
    End Function

    Public Sub SetdataNull()
      Me(Me.tableRichiesteCambiTurno.dataColumn) = System.Convert.DBNull
    End Sub

    Public Function IsStatoRichiestaNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.StatoRichiestaColumn)
    End Function

    Public Sub SetStatoRichiestaNull()
      Me(Me.tableRichiesteCambiTurno.StatoRichiestaColumn) = System.Convert.DBNull
    End Sub

    Public Function IsStatoApprovazioneNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.StatoApprovazioneColumn)
    End Function

    Public Sub SetStatoApprovazioneNull()
      Me(Me.tableRichiesteCambiTurno.StatoApprovazioneColumn) = System.Convert.DBNull
    End Sub

    Public Function IsIDNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.IDColumn)
    End Function

    Public Sub SetIDNull()
      Me(Me.tableRichiesteCambiTurno.IDColumn) = System.Convert.DBNull
    End Sub

    Public Function IsMatricolaAccertatoreDestinatarioNull() As Boolean
      Return Me.IsNull(Me.tableRichiesteCambiTurno.MatricolaAccertatoreDestinatarioColumn)
    End Function

    Public Sub SetMatricolaAccertatoreDestinatarioNull()
      Me(Me.tableRichiesteCambiTurno.MatricolaAccertatoreDestinatarioColumn) = System.Convert.DBNull
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class RichiesteCambiTurnoRowChangeEvent
    Inherits EventArgs

    Private eventRow As RichiesteCambiTurnoRow

    Private eventAction As DataRowAction

    Public Sub New(ByVal row As RichiesteCambiTurnoRow, ByVal action As DataRowAction)
      MyBase.New()
      Me.eventRow = row
      Me.eventAction = action
    End Sub

    Public ReadOnly Property Row() As RichiesteCambiTurnoRow
      Get
        Return Me.eventRow
      End Get
    End Property

    Public ReadOnly Property Action() As DataRowAction
      Get
        Return Me.eventAction
      End Get
    End Property
  End Class
End Class
