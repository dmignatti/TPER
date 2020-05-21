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
Public Class dsStradario
    Inherits DataSet
    
    Private tableStradarioBologna As StradarioBolognaDataTable
    
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
            If (Not (ds.Tables("StradarioBologna")) Is Nothing) Then
                Me.Tables.Add(New StradarioBolognaDataTable(ds.Tables("StradarioBologna")))
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
    Public ReadOnly Property StradarioBologna As StradarioBolognaDataTable
        Get
            Return Me.tableStradarioBologna
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsStradario = CType(MyBase.Clone,dsStradario)
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
        If (Not (ds.Tables("StradarioBologna")) Is Nothing) Then
            Me.Tables.Add(New StradarioBolognaDataTable(ds.Tables("StradarioBologna")))
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
        Me.tableStradarioBologna = CType(Me.Tables("StradarioBologna"),StradarioBolognaDataTable)
        If (Not (Me.tableStradarioBologna) Is Nothing) Then
            Me.tableStradarioBologna.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsStradario"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsStradario.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableStradarioBologna = New StradarioBolognaDataTable
        Me.Tables.Add(Me.tableStradarioBologna)
    End Sub
    
    Private Function ShouldSerializeStradarioBologna() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub StradarioBolognaRowChangeEventHandler(ByVal sender As Object, ByVal e As StradarioBolognaRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class StradarioBolognaDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCodice As DataColumn
        
        Private columnNome As DataColumn
        
        Private columnSettoreZona As DataColumn
        
        Private columnGuid As DataColumn
        
        Friend Sub New()
            MyBase.New("StradarioBologna")
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
        
        Friend ReadOnly Property CodiceColumn As DataColumn
            Get
                Return Me.columnCodice
            End Get
        End Property
        
        Friend ReadOnly Property NomeColumn As DataColumn
            Get
                Return Me.columnNome
            End Get
        End Property
        
        Friend ReadOnly Property SettoreZonaColumn As DataColumn
            Get
                Return Me.columnSettoreZona
            End Get
        End Property
        
        Friend ReadOnly Property GuidColumn As DataColumn
            Get
                Return Me.columnGuid
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As StradarioBolognaRow
            Get
                Return CType(Me.Rows(index),StradarioBolognaRow)
            End Get
        End Property
        
        Public Event StradarioBolognaRowChanged As StradarioBolognaRowChangeEventHandler
        
        Public Event StradarioBolognaRowChanging As StradarioBolognaRowChangeEventHandler
        
        Public Event StradarioBolognaRowDeleted As StradarioBolognaRowChangeEventHandler
        
        Public Event StradarioBolognaRowDeleting As StradarioBolognaRowChangeEventHandler
        
        Public Overloads Sub AddStradarioBolognaRow(ByVal row As StradarioBolognaRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddStradarioBolognaRow(ByVal Codice As Integer, ByVal Nome As String, ByVal SettoreZona As Short, ByVal Guid As System.Guid) As StradarioBolognaRow
            Dim rowStradarioBolognaRow As StradarioBolognaRow = CType(Me.NewRow,StradarioBolognaRow)
            rowStradarioBolognaRow.ItemArray = New Object() {Codice, Nome, SettoreZona, Guid}
            Me.Rows.Add(rowStradarioBolognaRow)
            Return rowStradarioBolognaRow
        End Function
        
        Public Function FindByGuid(ByVal Guid As System.Guid) As StradarioBolognaRow
            Return CType(Me.Rows.Find(New Object() {Guid}),StradarioBolognaRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As StradarioBolognaDataTable = CType(MyBase.Clone,StradarioBolognaDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New StradarioBolognaDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCodice = Me.Columns("Codice")
            Me.columnNome = Me.Columns("Nome")
            Me.columnSettoreZona = Me.Columns("SettoreZona")
            Me.columnGuid = Me.Columns("Guid")
        End Sub
        
        Private Sub InitClass()
            Me.columnCodice = New DataColumn("Codice", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodice)
            Me.columnNome = New DataColumn("Nome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNome)
            Me.columnSettoreZona = New DataColumn("SettoreZona", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSettoreZona)
            Me.columnGuid = New DataColumn("Guid", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGuid)
            Me.Constraints.Add(New UniqueConstraint("dsStradarioKey1", New DataColumn() {Me.columnGuid}, true))
            Me.columnGuid.AllowDBNull = false
            Me.columnGuid.Unique = true
        End Sub
        
        Public Function NewStradarioBolognaRow() As StradarioBolognaRow
            Return CType(Me.NewRow,StradarioBolognaRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New StradarioBolognaRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(StradarioBolognaRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.StradarioBolognaRowChangedEvent) Is Nothing) Then
                RaiseEvent StradarioBolognaRowChanged(Me, New StradarioBolognaRowChangeEvent(CType(e.Row,StradarioBolognaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.StradarioBolognaRowChangingEvent) Is Nothing) Then
                RaiseEvent StradarioBolognaRowChanging(Me, New StradarioBolognaRowChangeEvent(CType(e.Row,StradarioBolognaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.StradarioBolognaRowDeletedEvent) Is Nothing) Then
                RaiseEvent StradarioBolognaRowDeleted(Me, New StradarioBolognaRowChangeEvent(CType(e.Row,StradarioBolognaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.StradarioBolognaRowDeletingEvent) Is Nothing) Then
                RaiseEvent StradarioBolognaRowDeleting(Me, New StradarioBolognaRowChangeEvent(CType(e.Row,StradarioBolognaRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveStradarioBolognaRow(ByVal row As StradarioBolognaRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class StradarioBolognaRow
        Inherits DataRow
        
        Private tableStradarioBologna As StradarioBolognaDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableStradarioBologna = CType(Me.Table,StradarioBolognaDataTable)
        End Sub
        
        Public Property Codice As Integer
            Get
                Try 
                    Return CType(Me(Me.tableStradarioBologna.CodiceColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableStradarioBologna.CodiceColumn) = value
            End Set
        End Property
        
        Public Property Nome As String
            Get
                Try 
                    Return CType(Me(Me.tableStradarioBologna.NomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableStradarioBologna.NomeColumn) = value
            End Set
        End Property
        
        Public Property SettoreZona As Short
            Get
                Try 
                    Return CType(Me(Me.tableStradarioBologna.SettoreZonaColumn),Short)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableStradarioBologna.SettoreZonaColumn) = value
            End Set
        End Property
        
        Public Property Guid As System.Guid
            Get
                Return CType(Me(Me.tableStradarioBologna.GuidColumn),System.Guid)
            End Get
            Set
                Me(Me.tableStradarioBologna.GuidColumn) = value
            End Set
        End Property
        
        Public Function IsCodiceNull() As Boolean
            Return Me.IsNull(Me.tableStradarioBologna.CodiceColumn)
        End Function
        
        Public Sub SetCodiceNull()
            Me(Me.tableStradarioBologna.CodiceColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNomeNull() As Boolean
            Return Me.IsNull(Me.tableStradarioBologna.NomeColumn)
        End Function
        
        Public Sub SetNomeNull()
            Me(Me.tableStradarioBologna.NomeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSettoreZonaNull() As Boolean
            Return Me.IsNull(Me.tableStradarioBologna.SettoreZonaColumn)
        End Function
        
        Public Sub SetSettoreZonaNull()
            Me(Me.tableStradarioBologna.SettoreZonaColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class StradarioBolognaRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As StradarioBolognaRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As StradarioBolognaRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As StradarioBolognaRow
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
