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


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DsSettori
    Inherits DataSet
    
    Private tableSettori As SettoriDataTable
    
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
            If (Not (ds.Tables("Settori")) Is Nothing) Then
                Me.Tables.Add(New SettoriDataTable(ds.Tables("Settori")))
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
    Public ReadOnly Property Settori As SettoriDataTable
        Get
            Return Me.tableSettori
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsSettori = CType(MyBase.Clone,DsSettori)
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
        If (Not (ds.Tables("Settori")) Is Nothing) Then
            Me.Tables.Add(New SettoriDataTable(ds.Tables("Settori")))
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
        Me.tableSettori = CType(Me.Tables("Settori"),SettoriDataTable)
        If (Not (Me.tableSettori) Is Nothing) Then
            Me.tableSettori.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsSettori"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsSettori.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSettori = New SettoriDataTable
        Me.Tables.Add(Me.tableSettori)
    End Sub
    
    Private Function ShouldSerializeSettori() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SettoriRowChangeEventHandler(ByVal sender As Object, ByVal e As SettoriRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SettoriDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnId_SZF As DataColumn
        
        Private columnId_ZonaSettoreUnico As DataColumn
        
        Private columnDesc_Settore As DataColumn
        
        Private columnDesc_Dettaglio_Settore As DataColumn
        
        Private columnIdSettore As DataColumn
        
        Friend Sub New()
            MyBase.New("Settori")
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
        
        Friend ReadOnly Property Id_SZFColumn As DataColumn
            Get
                Return Me.columnId_SZF
            End Get
        End Property
        
        Friend ReadOnly Property Id_ZonaSettoreUnicoColumn As DataColumn
            Get
                Return Me.columnId_ZonaSettoreUnico
            End Get
        End Property
        
        Friend ReadOnly Property Desc_SettoreColumn As DataColumn
            Get
                Return Me.columnDesc_Settore
            End Get
        End Property
        
        Friend ReadOnly Property Desc_Dettaglio_SettoreColumn As DataColumn
            Get
                Return Me.columnDesc_Dettaglio_Settore
            End Get
        End Property
        
        Friend ReadOnly Property IdSettoreColumn As DataColumn
            Get
                Return Me.columnIdSettore
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SettoriRow
            Get
                Return CType(Me.Rows(index),SettoriRow)
            End Get
        End Property
        
        Public Event SettoriRowChanged As SettoriRowChangeEventHandler
        
        Public Event SettoriRowChanging As SettoriRowChangeEventHandler
        
        Public Event SettoriRowDeleted As SettoriRowChangeEventHandler
        
        Public Event SettoriRowDeleting As SettoriRowChangeEventHandler
        
        Public Overloads Sub AddSettoriRow(ByVal row As SettoriRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSettoriRow(ByVal Id_SZF As Integer, ByVal Id_ZonaSettoreUnico As Integer, ByVal Desc_Settore As String, ByVal Desc_Dettaglio_Settore As String, ByVal IdSettore As Integer) As SettoriRow
            Dim rowSettoriRow As SettoriRow = CType(Me.NewRow,SettoriRow)
            rowSettoriRow.ItemArray = New Object() {Id_SZF, Id_ZonaSettoreUnico, Desc_Settore, Desc_Dettaglio_Settore, IdSettore}
            Me.Rows.Add(rowSettoriRow)
            Return rowSettoriRow
        End Function
        
        Public Function FindById_SZF(ByVal Id_SZF As Integer) As SettoriRow
            Return CType(Me.Rows.Find(New Object() {Id_SZF}),SettoriRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SettoriDataTable = CType(MyBase.Clone,SettoriDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SettoriDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnId_SZF = Me.Columns("Id_SZF")
            Me.columnId_ZonaSettoreUnico = Me.Columns("Id_ZonaSettoreUnico")
            Me.columnDesc_Settore = Me.Columns("Desc_Settore")
            Me.columnDesc_Dettaglio_Settore = Me.Columns("Desc_Dettaglio_Settore")
            Me.columnIdSettore = Me.Columns("IdSettore")
        End Sub
        
        Private Sub InitClass()
            Me.columnId_SZF = New DataColumn("Id_SZF", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId_SZF)
            Me.columnId_ZonaSettoreUnico = New DataColumn("Id_ZonaSettoreUnico", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId_ZonaSettoreUnico)
            Me.columnDesc_Settore = New DataColumn("Desc_Settore", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDesc_Settore)
            Me.columnDesc_Dettaglio_Settore = New DataColumn("Desc_Dettaglio_Settore", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDesc_Dettaglio_Settore)
            Me.columnIdSettore = New DataColumn("IdSettore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdSettore)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnId_SZF}, true))
            Me.columnId_SZF.AllowDBNull = false
            Me.columnId_SZF.Unique = true
        End Sub
        
        Public Function NewSettoriRow() As SettoriRow
            Return CType(Me.NewRow,SettoriRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SettoriRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SettoriRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SettoriRowChangedEvent) Is Nothing) Then
                RaiseEvent SettoriRowChanged(Me, New SettoriRowChangeEvent(CType(e.Row,SettoriRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SettoriRowChangingEvent) Is Nothing) Then
                RaiseEvent SettoriRowChanging(Me, New SettoriRowChangeEvent(CType(e.Row,SettoriRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SettoriRowDeletedEvent) Is Nothing) Then
                RaiseEvent SettoriRowDeleted(Me, New SettoriRowChangeEvent(CType(e.Row,SettoriRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SettoriRowDeletingEvent) Is Nothing) Then
                RaiseEvent SettoriRowDeleting(Me, New SettoriRowChangeEvent(CType(e.Row,SettoriRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSettoriRow(ByVal row As SettoriRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SettoriRow
        Inherits DataRow
        
        Private tableSettori As SettoriDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSettori = CType(Me.Table,SettoriDataTable)
        End Sub
        
        Public Property Id_SZF As Integer
            Get
                Return CType(Me(Me.tableSettori.Id_SZFColumn),Integer)
            End Get
            Set
                Me(Me.tableSettori.Id_SZFColumn) = value
            End Set
        End Property
        
        Public Property Id_ZonaSettoreUnico As Integer
            Get
                Try 
                    Return CType(Me(Me.tableSettori.Id_ZonaSettoreUnicoColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSettori.Id_ZonaSettoreUnicoColumn) = value
            End Set
        End Property
        
        Public Property Desc_Settore As String
            Get
                Try 
                    Return CType(Me(Me.tableSettori.Desc_SettoreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSettori.Desc_SettoreColumn) = value
            End Set
        End Property
        
        Public Property Desc_Dettaglio_Settore As String
            Get
                Try 
                    Return CType(Me(Me.tableSettori.Desc_Dettaglio_SettoreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSettori.Desc_Dettaglio_SettoreColumn) = value
            End Set
        End Property
        
        Public Property IdSettore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableSettori.IdSettoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSettori.IdSettoreColumn) = value
            End Set
        End Property
        
        Public Function IsId_ZonaSettoreUnicoNull() As Boolean
            Return Me.IsNull(Me.tableSettori.Id_ZonaSettoreUnicoColumn)
        End Function
        
        Public Sub SetId_ZonaSettoreUnicoNull()
            Me(Me.tableSettori.Id_ZonaSettoreUnicoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDesc_SettoreNull() As Boolean
            Return Me.IsNull(Me.tableSettori.Desc_SettoreColumn)
        End Function
        
        Public Sub SetDesc_SettoreNull()
            Me(Me.tableSettori.Desc_SettoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDesc_Dettaglio_SettoreNull() As Boolean
            Return Me.IsNull(Me.tableSettori.Desc_Dettaglio_SettoreColumn)
        End Function
        
        Public Sub SetDesc_Dettaglio_SettoreNull()
            Me(Me.tableSettori.Desc_Dettaglio_SettoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdSettoreNull() As Boolean
            Return Me.IsNull(Me.tableSettori.IdSettoreColumn)
        End Function
        
        Public Sub SetIdSettoreNull()
            Me(Me.tableSettori.IdSettoreColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SettoriRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SettoriRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SettoriRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SettoriRow
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