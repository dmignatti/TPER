﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2503
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


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DsTipoTurni
    Inherits DataSet
    
    Private tableTipoTurni As TipoTurniDataTable
    
    Private tableTipTurno_Abilitazione As TipTurno_AbilitazioneDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("TipoTurni")) Is Nothing) Then
                Me.Tables.Add(New TipoTurniDataTable(ds.Tables("TipoTurni")))
            End If
            If (Not (ds.Tables("TipTurno_Abilitazione")) Is Nothing) Then
                Me.Tables.Add(New TipTurno_AbilitazioneDataTable(ds.Tables("TipTurno_Abilitazione")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property TipoTurni As TipoTurniDataTable
        Get
            Return Me.tableTipoTurni
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property TipTurno_Abilitazione As TipTurno_AbilitazioneDataTable
        Get
            Return Me.tableTipTurno_Abilitazione
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsTipoTurni = CType(MyBase.Clone,DsTipoTurni)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("TipoTurni")) Is Nothing) Then
            Me.Tables.Add(New TipoTurniDataTable(ds.Tables("TipoTurni")))
        End If
        If (Not (ds.Tables("TipTurno_Abilitazione")) Is Nothing) Then
            Me.Tables.Add(New TipTurno_AbilitazioneDataTable(ds.Tables("TipTurno_Abilitazione")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableTipoTurni = CType(Me.Tables("TipoTurni"),TipoTurniDataTable)
        If (Not (Me.tableTipoTurni) Is Nothing) Then
            Me.tableTipoTurni.InitVars
        End If
        Me.tableTipTurno_Abilitazione = CType(Me.Tables("TipTurno_Abilitazione"),TipTurno_AbilitazioneDataTable)
        If (Not (Me.tableTipTurno_Abilitazione) Is Nothing) Then
            Me.tableTipTurno_Abilitazione.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsTipoTurni"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsTipoTurni.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableTipoTurni = New TipoTurniDataTable
        Me.Tables.Add(Me.tableTipoTurni)
        Me.tableTipTurno_Abilitazione = New TipTurno_AbilitazioneDataTable
        Me.Tables.Add(Me.tableTipTurno_Abilitazione)
    End Sub
    
    Private Function ShouldSerializeTipoTurni() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeTipTurno_Abilitazione() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub TipoTurniRowChangeEventHandler(ByVal sender As Object, ByVal e As TipoTurniRowChangeEvent)
    
    Public Delegate Sub TipTurno_AbilitazioneRowChangeEventHandler(ByVal sender As Object, ByVal e As TipTurno_AbilitazioneRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipoTurniDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCodiceTipologia As DataColumn
        
        Private columnTipologiaTurno As DataColumn
        
        Private columnFlag_Patente As DataColumn
        
        Friend Sub New()
            MyBase.New("TipoTurni")
            Me.InitClass
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
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CodiceTipologiaColumn As DataColumn
            Get
                Return Me.columnCodiceTipologia
            End Get
        End Property
        
        Friend ReadOnly Property TipologiaTurnoColumn As DataColumn
            Get
                Return Me.columnTipologiaTurno
            End Get
        End Property
        
        Friend ReadOnly Property Flag_PatenteColumn As DataColumn
            Get
                Return Me.columnFlag_Patente
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TipoTurniRow
            Get
                Return CType(Me.Rows(index),TipoTurniRow)
            End Get
        End Property
        
        Public Event TipoTurniRowChanged As TipoTurniRowChangeEventHandler
        
        Public Event TipoTurniRowChanging As TipoTurniRowChangeEventHandler
        
        Public Event TipoTurniRowDeleted As TipoTurniRowChangeEventHandler
        
        Public Event TipoTurniRowDeleting As TipoTurniRowChangeEventHandler
        
        Public Overloads Sub AddTipoTurniRow(ByVal row As TipoTurniRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTipoTurniRow(ByVal CodiceTipologia As String, ByVal TipologiaTurno As String, ByVal Flag_Patente As Boolean) As TipoTurniRow
            Dim rowTipoTurniRow As TipoTurniRow = CType(Me.NewRow,TipoTurniRow)
            rowTipoTurniRow.ItemArray = New Object() {CodiceTipologia, TipologiaTurno, Flag_Patente}
            Me.Rows.Add(rowTipoTurniRow)
            Return rowTipoTurniRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TipoTurniDataTable = CType(MyBase.Clone,TipoTurniDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TipoTurniDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCodiceTipologia = Me.Columns("CodiceTipologia")
            Me.columnTipologiaTurno = Me.Columns("TipologiaTurno")
            Me.columnFlag_Patente = Me.Columns("Flag_Patente")
        End Sub
        
        Private Sub InitClass()
            Me.columnCodiceTipologia = New DataColumn("CodiceTipologia", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodiceTipologia)
            Me.columnTipologiaTurno = New DataColumn("TipologiaTurno", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTipologiaTurno)
            Me.columnFlag_Patente = New DataColumn("Flag_Patente", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFlag_Patente)
            Me.columnFlag_Patente.ReadOnly = true
        End Sub
        
        Public Function NewTipoTurniRow() As TipoTurniRow
            Return CType(Me.NewRow,TipoTurniRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TipoTurniRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TipoTurniRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TipoTurniRowChangedEvent) Is Nothing) Then
                RaiseEvent TipoTurniRowChanged(Me, New TipoTurniRowChangeEvent(CType(e.Row,TipoTurniRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TipoTurniRowChangingEvent) Is Nothing) Then
                RaiseEvent TipoTurniRowChanging(Me, New TipoTurniRowChangeEvent(CType(e.Row,TipoTurniRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TipoTurniRowDeletedEvent) Is Nothing) Then
                RaiseEvent TipoTurniRowDeleted(Me, New TipoTurniRowChangeEvent(CType(e.Row,TipoTurniRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TipoTurniRowDeletingEvent) Is Nothing) Then
                RaiseEvent TipoTurniRowDeleting(Me, New TipoTurniRowChangeEvent(CType(e.Row,TipoTurniRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTipoTurniRow(ByVal row As TipoTurniRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipoTurniRow
        Inherits DataRow
        
        Private tableTipoTurni As TipoTurniDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTipoTurni = CType(Me.Table,TipoTurniDataTable)
        End Sub
        
        Public Property CodiceTipologia As String
            Get
                Try 
                    Return CType(Me(Me.tableTipoTurni.CodiceTipologiaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipoTurni.CodiceTipologiaColumn) = value
            End Set
        End Property
        
        Public Property TipologiaTurno As String
            Get
                Try 
                    Return CType(Me(Me.tableTipoTurni.TipologiaTurnoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipoTurni.TipologiaTurnoColumn) = value
            End Set
        End Property
        
        Public Property Flag_Patente As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableTipoTurni.Flag_PatenteColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipoTurni.Flag_PatenteColumn) = value
            End Set
        End Property
        
        Public Function IsCodiceTipologiaNull() As Boolean
            Return Me.IsNull(Me.tableTipoTurni.CodiceTipologiaColumn)
        End Function
        
        Public Sub SetCodiceTipologiaNull()
            Me(Me.tableTipoTurni.CodiceTipologiaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTipologiaTurnoNull() As Boolean
            Return Me.IsNull(Me.tableTipoTurni.TipologiaTurnoColumn)
        End Function
        
        Public Sub SetTipologiaTurnoNull()
            Me(Me.tableTipoTurni.TipologiaTurnoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFlag_PatenteNull() As Boolean
            Return Me.IsNull(Me.tableTipoTurni.Flag_PatenteColumn)
        End Function
        
        Public Sub SetFlag_PatenteNull()
            Me(Me.tableTipoTurni.Flag_PatenteColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipoTurniRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TipoTurniRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TipoTurniRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TipoTurniRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipTurno_AbilitazioneDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnId As DataColumn
        
        Private columnCod_Tipologia As DataColumn
        
        Private columnFlag_Patente As DataColumn
        
        Private columnCreateOn As DataColumn
        
        Private columnModifiedOn As DataColumn
        
        Private columnCreatedBy As DataColumn
        
        Private columnModifiedBy As DataColumn
        
        Friend Sub New()
            MyBase.New("TipTurno_Abilitazione")
            Me.InitClass
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
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property IdColumn As DataColumn
            Get
                Return Me.columnId
            End Get
        End Property
        
        Friend ReadOnly Property Cod_TipologiaColumn As DataColumn
            Get
                Return Me.columnCod_Tipologia
            End Get
        End Property
        
        Friend ReadOnly Property Flag_PatenteColumn As DataColumn
            Get
                Return Me.columnFlag_Patente
            End Get
        End Property
        
        Friend ReadOnly Property CreateOnColumn As DataColumn
            Get
                Return Me.columnCreateOn
            End Get
        End Property
        
        Friend ReadOnly Property ModifiedOnColumn As DataColumn
            Get
                Return Me.columnModifiedOn
            End Get
        End Property
        
        Friend ReadOnly Property CreatedByColumn As DataColumn
            Get
                Return Me.columnCreatedBy
            End Get
        End Property
        
        Friend ReadOnly Property ModifiedByColumn As DataColumn
            Get
                Return Me.columnModifiedBy
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TipTurno_AbilitazioneRow
            Get
                Return CType(Me.Rows(index),TipTurno_AbilitazioneRow)
            End Get
        End Property
        
        Public Event TipTurno_AbilitazioneRowChanged As TipTurno_AbilitazioneRowChangeEventHandler
        
        Public Event TipTurno_AbilitazioneRowChanging As TipTurno_AbilitazioneRowChangeEventHandler
        
        Public Event TipTurno_AbilitazioneRowDeleted As TipTurno_AbilitazioneRowChangeEventHandler
        
        Public Event TipTurno_AbilitazioneRowDeleting As TipTurno_AbilitazioneRowChangeEventHandler
        
        Public Overloads Sub AddTipTurno_AbilitazioneRow(ByVal row As TipTurno_AbilitazioneRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTipTurno_AbilitazioneRow(ByVal Id As System.Guid, ByVal Cod_Tipologia As String, ByVal Flag_Patente As Boolean, ByVal CreateOn As Date, ByVal ModifiedOn As Date, ByVal CreatedBy As String, ByVal ModifiedBy As String) As TipTurno_AbilitazioneRow
            Dim rowTipTurno_AbilitazioneRow As TipTurno_AbilitazioneRow = CType(Me.NewRow,TipTurno_AbilitazioneRow)
            rowTipTurno_AbilitazioneRow.ItemArray = New Object() {Id, Cod_Tipologia, Flag_Patente, CreateOn, ModifiedOn, CreatedBy, ModifiedBy}
            Me.Rows.Add(rowTipTurno_AbilitazioneRow)
            Return rowTipTurno_AbilitazioneRow
        End Function
        
        Public Function FindById(ByVal Id As System.Guid) As TipTurno_AbilitazioneRow
            Return CType(Me.Rows.Find(New Object() {Id}),TipTurno_AbilitazioneRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TipTurno_AbilitazioneDataTable = CType(MyBase.Clone,TipTurno_AbilitazioneDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TipTurno_AbilitazioneDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnId = Me.Columns("Id")
            Me.columnCod_Tipologia = Me.Columns("Cod_Tipologia")
            Me.columnFlag_Patente = Me.Columns("Flag_Patente")
            Me.columnCreateOn = Me.Columns("CreateOn")
            Me.columnModifiedOn = Me.Columns("ModifiedOn")
            Me.columnCreatedBy = Me.Columns("CreatedBy")
            Me.columnModifiedBy = Me.Columns("ModifiedBy")
        End Sub
        
        Private Sub InitClass()
            Me.columnId = New DataColumn("Id", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId)
            Me.columnCod_Tipologia = New DataColumn("Cod_Tipologia", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCod_Tipologia)
            Me.columnFlag_Patente = New DataColumn("Flag_Patente", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFlag_Patente)
            Me.columnCreateOn = New DataColumn("CreateOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCreateOn)
            Me.columnModifiedOn = New DataColumn("ModifiedOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnModifiedOn)
            Me.columnCreatedBy = New DataColumn("CreatedBy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCreatedBy)
            Me.columnModifiedBy = New DataColumn("ModifiedBy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnModifiedBy)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnId}, true))
            Me.columnId.AllowDBNull = false
            Me.columnId.Unique = true
        End Sub
        
        Public Function NewTipTurno_AbilitazioneRow() As TipTurno_AbilitazioneRow
            Return CType(Me.NewRow,TipTurno_AbilitazioneRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TipTurno_AbilitazioneRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TipTurno_AbilitazioneRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TipTurno_AbilitazioneRowChangedEvent) Is Nothing) Then
                RaiseEvent TipTurno_AbilitazioneRowChanged(Me, New TipTurno_AbilitazioneRowChangeEvent(CType(e.Row,TipTurno_AbilitazioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TipTurno_AbilitazioneRowChangingEvent) Is Nothing) Then
                RaiseEvent TipTurno_AbilitazioneRowChanging(Me, New TipTurno_AbilitazioneRowChangeEvent(CType(e.Row,TipTurno_AbilitazioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TipTurno_AbilitazioneRowDeletedEvent) Is Nothing) Then
                RaiseEvent TipTurno_AbilitazioneRowDeleted(Me, New TipTurno_AbilitazioneRowChangeEvent(CType(e.Row,TipTurno_AbilitazioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TipTurno_AbilitazioneRowDeletingEvent) Is Nothing) Then
                RaiseEvent TipTurno_AbilitazioneRowDeleting(Me, New TipTurno_AbilitazioneRowChangeEvent(CType(e.Row,TipTurno_AbilitazioneRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTipTurno_AbilitazioneRow(ByVal row As TipTurno_AbilitazioneRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipTurno_AbilitazioneRow
        Inherits DataRow
        
        Private tableTipTurno_Abilitazione As TipTurno_AbilitazioneDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTipTurno_Abilitazione = CType(Me.Table,TipTurno_AbilitazioneDataTable)
        End Sub
        
        Public Property Id As System.Guid
            Get
                Return CType(Me(Me.tableTipTurno_Abilitazione.IdColumn),System.Guid)
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.IdColumn) = value
            End Set
        End Property
        
        Public Property Cod_Tipologia As String
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.Cod_TipologiaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.Cod_TipologiaColumn) = value
            End Set
        End Property
        
        Public Property Flag_Patente As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.Flag_PatenteColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.Flag_PatenteColumn) = value
            End Set
        End Property
        
        Public Property CreateOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.CreateOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.CreateOnColumn) = value
            End Set
        End Property
        
        Public Property ModifiedOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.ModifiedOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.ModifiedOnColumn) = value
            End Set
        End Property
        
        Public Property CreatedBy As String
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.CreatedByColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.CreatedByColumn) = value
            End Set
        End Property
        
        Public Property ModifiedBy As String
            Get
                Try 
                    Return CType(Me(Me.tableTipTurno_Abilitazione.ModifiedByColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTipTurno_Abilitazione.ModifiedByColumn) = value
            End Set
        End Property
        
        Public Function IsCod_TipologiaNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.Cod_TipologiaColumn)
        End Function
        
        Public Sub SetCod_TipologiaNull()
            Me(Me.tableTipTurno_Abilitazione.Cod_TipologiaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFlag_PatenteNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.Flag_PatenteColumn)
        End Function
        
        Public Sub SetFlag_PatenteNull()
            Me(Me.tableTipTurno_Abilitazione.Flag_PatenteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCreateOnNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.CreateOnColumn)
        End Function
        
        Public Sub SetCreateOnNull()
            Me(Me.tableTipTurno_Abilitazione.CreateOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsModifiedOnNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.ModifiedOnColumn)
        End Function
        
        Public Sub SetModifiedOnNull()
            Me(Me.tableTipTurno_Abilitazione.ModifiedOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCreatedByNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.CreatedByColumn)
        End Function
        
        Public Sub SetCreatedByNull()
            Me(Me.tableTipTurno_Abilitazione.CreatedByColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsModifiedByNull() As Boolean
            Return Me.IsNull(Me.tableTipTurno_Abilitazione.ModifiedByColumn)
        End Function
        
        Public Sub SetModifiedByNull()
            Me(Me.tableTipTurno_Abilitazione.ModifiedByColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TipTurno_AbilitazioneRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TipTurno_AbilitazioneRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TipTurno_AbilitazioneRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TipTurno_AbilitazioneRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
