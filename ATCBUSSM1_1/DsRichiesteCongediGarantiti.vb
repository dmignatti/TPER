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
Public Class DsRichiesteCongediGarantiti
    Inherits DataSet
    
    Private tableRichiesteCongediGarantiti As RichiesteCongediGarantitiDataTable
    
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
            If (Not (ds.Tables("RichiesteCongediGarantiti")) Is Nothing) Then
                Me.Tables.Add(New RichiesteCongediGarantitiDataTable(ds.Tables("RichiesteCongediGarantiti")))
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
    Public ReadOnly Property RichiesteCongediGarantiti As RichiesteCongediGarantitiDataTable
        Get
            Return Me.tableRichiesteCongediGarantiti
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsRichiesteCongediGarantiti = CType(MyBase.Clone,DsRichiesteCongediGarantiti)
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
        If (Not (ds.Tables("RichiesteCongediGarantiti")) Is Nothing) Then
            Me.Tables.Add(New RichiesteCongediGarantitiDataTable(ds.Tables("RichiesteCongediGarantiti")))
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
        Me.tableRichiesteCongediGarantiti = CType(Me.Tables("RichiesteCongediGarantiti"),RichiesteCongediGarantitiDataTable)
        If (Not (Me.tableRichiesteCongediGarantiti) Is Nothing) Then
            Me.tableRichiesteCongediGarantiti.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsRichiesteCongediGarantiti"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsRichiesteCongediGarantiti.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableRichiesteCongediGarantiti = New RichiesteCongediGarantitiDataTable
        Me.Tables.Add(Me.tableRichiesteCongediGarantiti)
    End Sub
    
    Private Function ShouldSerializeRichiesteCongediGarantiti() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub RichiesteCongediGarantitiRowChangeEventHandler(ByVal sender As Object, ByVal e As RichiesteCongediGarantitiRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediGarantitiDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnIdRichiesta As DataColumn
        
        Private columnIdAccertatore As DataColumn
        
        Private columnDalGiorno As DataColumn
        
        Private columnAlGiorno As DataColumn
        
        Private columnOrdine As DataColumn
        
        Private columnStatoRichiesta As DataColumn
        
        Private columnts As DataColumn
        
        Friend Sub New()
            MyBase.New("RichiesteCongediGarantiti")
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
        
        Friend ReadOnly Property IdRichiestaColumn As DataColumn
            Get
                Return Me.columnIdRichiesta
            End Get
        End Property
        
        Friend ReadOnly Property IdAccertatoreColumn As DataColumn
            Get
                Return Me.columnIdAccertatore
            End Get
        End Property
        
        Friend ReadOnly Property DalGiornoColumn As DataColumn
            Get
                Return Me.columnDalGiorno
            End Get
        End Property
        
        Friend ReadOnly Property AlGiornoColumn As DataColumn
            Get
                Return Me.columnAlGiorno
            End Get
        End Property
        
        Friend ReadOnly Property OrdineColumn As DataColumn
            Get
                Return Me.columnOrdine
            End Get
        End Property
        
        Friend ReadOnly Property StatoRichiestaColumn As DataColumn
            Get
                Return Me.columnStatoRichiesta
            End Get
        End Property
        
        Friend ReadOnly Property tsColumn As DataColumn
            Get
                Return Me.columnts
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As RichiesteCongediGarantitiRow
            Get
                Return CType(Me.Rows(index),RichiesteCongediGarantitiRow)
            End Get
        End Property
        
        Public Event RichiesteCongediGarantitiRowChanged As RichiesteCongediGarantitiRowChangeEventHandler
        
        Public Event RichiesteCongediGarantitiRowChanging As RichiesteCongediGarantitiRowChangeEventHandler
        
        Public Event RichiesteCongediGarantitiRowDeleted As RichiesteCongediGarantitiRowChangeEventHandler
        
        Public Event RichiesteCongediGarantitiRowDeleting As RichiesteCongediGarantitiRowChangeEventHandler
        
        Public Overloads Sub AddRichiesteCongediGarantitiRow(ByVal row As RichiesteCongediGarantitiRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddRichiesteCongediGarantitiRow(ByVal IdRichiesta As System.Guid, ByVal IdAccertatore As Integer, ByVal DalGiorno As Date, ByVal AlGiorno As Date, ByVal Ordine As Integer, ByVal StatoRichiesta As String, ByVal ts As Date) As RichiesteCongediGarantitiRow
            Dim rowRichiesteCongediGarantitiRow As RichiesteCongediGarantitiRow = CType(Me.NewRow,RichiesteCongediGarantitiRow)
            rowRichiesteCongediGarantitiRow.ItemArray = New Object() {IdRichiesta, IdAccertatore, DalGiorno, AlGiorno, Ordine, StatoRichiesta, ts}
            Me.Rows.Add(rowRichiesteCongediGarantitiRow)
            Return rowRichiesteCongediGarantitiRow
        End Function
        
        Public Function FindByIdRichiesta(ByVal IdRichiesta As System.Guid) As RichiesteCongediGarantitiRow
            Return CType(Me.Rows.Find(New Object() {IdRichiesta}),RichiesteCongediGarantitiRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As RichiesteCongediGarantitiDataTable = CType(MyBase.Clone,RichiesteCongediGarantitiDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New RichiesteCongediGarantitiDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnIdRichiesta = Me.Columns("IdRichiesta")
            Me.columnIdAccertatore = Me.Columns("IdAccertatore")
            Me.columnDalGiorno = Me.Columns("DalGiorno")
            Me.columnAlGiorno = Me.Columns("AlGiorno")
            Me.columnOrdine = Me.Columns("Ordine")
            Me.columnStatoRichiesta = Me.Columns("StatoRichiesta")
            Me.columnts = Me.Columns("ts")
        End Sub
        
        Private Sub InitClass()
            Me.columnIdRichiesta = New DataColumn("IdRichiesta", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdRichiesta)
            Me.columnIdAccertatore = New DataColumn("IdAccertatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdAccertatore)
            Me.columnDalGiorno = New DataColumn("DalGiorno", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDalGiorno)
            Me.columnAlGiorno = New DataColumn("AlGiorno", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAlGiorno)
            Me.columnOrdine = New DataColumn("Ordine", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrdine)
            Me.columnStatoRichiesta = New DataColumn("StatoRichiesta", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStatoRichiesta)
            Me.columnts = New DataColumn("ts", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnts)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnIdRichiesta}, true))
            Me.columnIdRichiesta.AllowDBNull = false
            Me.columnIdRichiesta.Unique = true
            Me.columnOrdine.ReadOnly = true
            Me.columnStatoRichiesta.ReadOnly = true
        End Sub
        
        Public Function NewRichiesteCongediGarantitiRow() As RichiesteCongediGarantitiRow
            Return CType(Me.NewRow,RichiesteCongediGarantitiRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RichiesteCongediGarantitiRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RichiesteCongediGarantitiRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RichiesteCongediGarantitiRowChangedEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediGarantitiRowChanged(Me, New RichiesteCongediGarantitiRowChangeEvent(CType(e.Row,RichiesteCongediGarantitiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RichiesteCongediGarantitiRowChangingEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediGarantitiRowChanging(Me, New RichiesteCongediGarantitiRowChangeEvent(CType(e.Row,RichiesteCongediGarantitiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RichiesteCongediGarantitiRowDeletedEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediGarantitiRowDeleted(Me, New RichiesteCongediGarantitiRowChangeEvent(CType(e.Row,RichiesteCongediGarantitiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RichiesteCongediGarantitiRowDeletingEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediGarantitiRowDeleting(Me, New RichiesteCongediGarantitiRowChangeEvent(CType(e.Row,RichiesteCongediGarantitiRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveRichiesteCongediGarantitiRow(ByVal row As RichiesteCongediGarantitiRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediGarantitiRow
        Inherits DataRow
        
        Private tableRichiesteCongediGarantiti As RichiesteCongediGarantitiDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableRichiesteCongediGarantiti = CType(Me.Table,RichiesteCongediGarantitiDataTable)
        End Sub
        
        Public Property IdRichiesta As System.Guid
            Get
                Return CType(Me(Me.tableRichiesteCongediGarantiti.IdRichiestaColumn),System.Guid)
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.IdRichiestaColumn) = value
            End Set
        End Property
        
        Public Property IdAccertatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.IdAccertatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.IdAccertatoreColumn) = value
            End Set
        End Property
        
        Public Property DalGiorno As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.DalGiornoColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.DalGiornoColumn) = value
            End Set
        End Property
        
        Public Property AlGiorno As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.AlGiornoColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.AlGiornoColumn) = value
            End Set
        End Property
        
        Public Property Ordine As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.OrdineColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.OrdineColumn) = value
            End Set
        End Property
        
        Public Property StatoRichiesta As String
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.StatoRichiestaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.StatoRichiestaColumn) = value
            End Set
        End Property
        
        Public Property ts As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediGarantiti.tsColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediGarantiti.tsColumn) = value
            End Set
        End Property
        
        Public Function IsIdAccertatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.IdAccertatoreColumn)
        End Function
        
        Public Sub SetIdAccertatoreNull()
            Me(Me.tableRichiesteCongediGarantiti.IdAccertatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDalGiornoNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.DalGiornoColumn)
        End Function
        
        Public Sub SetDalGiornoNull()
            Me(Me.tableRichiesteCongediGarantiti.DalGiornoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAlGiornoNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.AlGiornoColumn)
        End Function
        
        Public Sub SetAlGiornoNull()
            Me(Me.tableRichiesteCongediGarantiti.AlGiornoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrdineNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.OrdineColumn)
        End Function
        
        Public Sub SetOrdineNull()
            Me(Me.tableRichiesteCongediGarantiti.OrdineColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoRichiestaNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.StatoRichiestaColumn)
        End Function
        
        Public Sub SetStatoRichiestaNull()
            Me(Me.tableRichiesteCongediGarantiti.StatoRichiestaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstsNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediGarantiti.tsColumn)
        End Function
        
        Public Sub SettsNull()
            Me(Me.tableRichiesteCongediGarantiti.tsColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediGarantitiRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As RichiesteCongediGarantitiRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As RichiesteCongediGarantitiRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As RichiesteCongediGarantitiRow
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
