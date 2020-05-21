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
Public Class DsNoteSezione
    Inherits DataSet
    
    Private tableSezioniReport As SezioniReportDataTable
    
    Private tableNoteSezione As NoteSezioneDataTable
    
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
            If (Not (ds.Tables("SezioniReport")) Is Nothing) Then
                Me.Tables.Add(New SezioniReportDataTable(ds.Tables("SezioniReport")))
            End If
            If (Not (ds.Tables("NoteSezione")) Is Nothing) Then
                Me.Tables.Add(New NoteSezioneDataTable(ds.Tables("NoteSezione")))
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
    Public ReadOnly Property SezioniReport As SezioniReportDataTable
        Get
            Return Me.tableSezioniReport
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property NoteSezione As NoteSezioneDataTable
        Get
            Return Me.tableNoteSezione
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsNoteSezione = CType(MyBase.Clone,DsNoteSezione)
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
        If (Not (ds.Tables("SezioniReport")) Is Nothing) Then
            Me.Tables.Add(New SezioniReportDataTable(ds.Tables("SezioniReport")))
        End If
        If (Not (ds.Tables("NoteSezione")) Is Nothing) Then
            Me.Tables.Add(New NoteSezioneDataTable(ds.Tables("NoteSezione")))
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
        Me.tableSezioniReport = CType(Me.Tables("SezioniReport"),SezioniReportDataTable)
        If (Not (Me.tableSezioniReport) Is Nothing) Then
            Me.tableSezioniReport.InitVars
        End If
        Me.tableNoteSezione = CType(Me.Tables("NoteSezione"),NoteSezioneDataTable)
        If (Not (Me.tableNoteSezione) Is Nothing) Then
            Me.tableNoteSezione.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsNoteSezione"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsNoteSezione.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSezioniReport = New SezioniReportDataTable
        Me.Tables.Add(Me.tableSezioniReport)
        Me.tableNoteSezione = New NoteSezioneDataTable
        Me.Tables.Add(Me.tableNoteSezione)
    End Sub
    
    Private Function ShouldSerializeSezioniReport() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeNoteSezione() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SezioniReportRowChangeEventHandler(ByVal sender As Object, ByVal e As SezioniReportRowChangeEvent)
    
    Public Delegate Sub NoteSezioneRowChangeEventHandler(ByVal sender As Object, ByVal e As NoteSezioneRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SezioniReportDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnIdSezione As DataColumn
        
        Private columnDescrizione As DataColumn
        
        Friend Sub New()
            MyBase.New("SezioniReport")
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
        
        Friend ReadOnly Property IdSezioneColumn As DataColumn
            Get
                Return Me.columnIdSezione
            End Get
        End Property
        
        Friend ReadOnly Property DescrizioneColumn As DataColumn
            Get
                Return Me.columnDescrizione
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SezioniReportRow
            Get
                Return CType(Me.Rows(index),SezioniReportRow)
            End Get
        End Property
        
        Public Event SezioniReportRowChanged As SezioniReportRowChangeEventHandler
        
        Public Event SezioniReportRowChanging As SezioniReportRowChangeEventHandler
        
        Public Event SezioniReportRowDeleted As SezioniReportRowChangeEventHandler
        
        Public Event SezioniReportRowDeleting As SezioniReportRowChangeEventHandler
        
        Public Overloads Sub AddSezioniReportRow(ByVal row As SezioniReportRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSezioniReportRow(ByVal IdSezione As Integer, ByVal Descrizione As String) As SezioniReportRow
            Dim rowSezioniReportRow As SezioniReportRow = CType(Me.NewRow,SezioniReportRow)
            rowSezioniReportRow.ItemArray = New Object() {IdSezione, Descrizione}
            Me.Rows.Add(rowSezioniReportRow)
            Return rowSezioniReportRow
        End Function
        
        Public Function FindByIdSezione(ByVal IdSezione As Integer) As SezioniReportRow
            Return CType(Me.Rows.Find(New Object() {IdSezione}),SezioniReportRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SezioniReportDataTable = CType(MyBase.Clone,SezioniReportDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SezioniReportDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnIdSezione = Me.Columns("IdSezione")
            Me.columnDescrizione = Me.Columns("Descrizione")
        End Sub
        
        Private Sub InitClass()
            Me.columnIdSezione = New DataColumn("IdSezione", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdSezione)
            Me.columnDescrizione = New DataColumn("Descrizione", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescrizione)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnIdSezione}, true))
            Me.columnIdSezione.AllowDBNull = false
            Me.columnIdSezione.Unique = true
        End Sub
        
        Public Function NewSezioniReportRow() As SezioniReportRow
            Return CType(Me.NewRow,SezioniReportRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SezioniReportRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SezioniReportRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SezioniReportRowChangedEvent) Is Nothing) Then
                RaiseEvent SezioniReportRowChanged(Me, New SezioniReportRowChangeEvent(CType(e.Row,SezioniReportRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SezioniReportRowChangingEvent) Is Nothing) Then
                RaiseEvent SezioniReportRowChanging(Me, New SezioniReportRowChangeEvent(CType(e.Row,SezioniReportRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SezioniReportRowDeletedEvent) Is Nothing) Then
                RaiseEvent SezioniReportRowDeleted(Me, New SezioniReportRowChangeEvent(CType(e.Row,SezioniReportRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SezioniReportRowDeletingEvent) Is Nothing) Then
                RaiseEvent SezioniReportRowDeleting(Me, New SezioniReportRowChangeEvent(CType(e.Row,SezioniReportRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSezioniReportRow(ByVal row As SezioniReportRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SezioniReportRow
        Inherits DataRow
        
        Private tableSezioniReport As SezioniReportDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSezioniReport = CType(Me.Table,SezioniReportDataTable)
        End Sub
        
        Public Property IdSezione As Integer
            Get
                Return CType(Me(Me.tableSezioniReport.IdSezioneColumn),Integer)
            End Get
            Set
                Me(Me.tableSezioniReport.IdSezioneColumn) = value
            End Set
        End Property
        
        Public Property Descrizione As String
            Get
                Try 
                    Return CType(Me(Me.tableSezioniReport.DescrizioneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSezioniReport.DescrizioneColumn) = value
            End Set
        End Property
        
        Public Function IsDescrizioneNull() As Boolean
            Return Me.IsNull(Me.tableSezioniReport.DescrizioneColumn)
        End Function
        
        Public Sub SetDescrizioneNull()
            Me(Me.tableSezioniReport.DescrizioneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SezioniReportRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SezioniReportRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SezioniReportRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SezioniReportRow
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
    Public Class NoteSezioneDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnId As DataColumn
        
        Private columnNota As DataColumn
        
        Private columnData As DataColumn
        
        Private columnIdSezione As DataColumn
        
        Private columnDescrizione As DataColumn
        
        Friend Sub New()
            MyBase.New("NoteSezione")
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
        
        Friend ReadOnly Property NotaColumn As DataColumn
            Get
                Return Me.columnNota
            End Get
        End Property
        
        Friend ReadOnly Property DataColumn As DataColumn
            Get
                Return Me.columnData
            End Get
        End Property
        
        Friend ReadOnly Property IdSezioneColumn As DataColumn
            Get
                Return Me.columnIdSezione
            End Get
        End Property
        
        Friend ReadOnly Property DescrizioneColumn As DataColumn
            Get
                Return Me.columnDescrizione
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As NoteSezioneRow
            Get
                Return CType(Me.Rows(index),NoteSezioneRow)
            End Get
        End Property
        
        Public Event NoteSezioneRowChanged As NoteSezioneRowChangeEventHandler
        
        Public Event NoteSezioneRowChanging As NoteSezioneRowChangeEventHandler
        
        Public Event NoteSezioneRowDeleted As NoteSezioneRowChangeEventHandler
        
        Public Event NoteSezioneRowDeleting As NoteSezioneRowChangeEventHandler
        
        Public Overloads Sub AddNoteSezioneRow(ByVal row As NoteSezioneRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddNoteSezioneRow(ByVal Id As System.Guid, ByVal Nota As String, ByVal Data As Date, ByVal IdSezione As Integer, ByVal Descrizione As String) As NoteSezioneRow
            Dim rowNoteSezioneRow As NoteSezioneRow = CType(Me.NewRow,NoteSezioneRow)
            rowNoteSezioneRow.ItemArray = New Object() {Id, Nota, Data, IdSezione, Descrizione}
            Me.Rows.Add(rowNoteSezioneRow)
            Return rowNoteSezioneRow
        End Function
        
        Public Function FindById(ByVal Id As System.Guid) As NoteSezioneRow
            Return CType(Me.Rows.Find(New Object() {Id}),NoteSezioneRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As NoteSezioneDataTable = CType(MyBase.Clone,NoteSezioneDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New NoteSezioneDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnId = Me.Columns("Id")
            Me.columnNota = Me.Columns("Nota")
            Me.columnData = Me.Columns("Data")
            Me.columnIdSezione = Me.Columns("IdSezione")
            Me.columnDescrizione = Me.Columns("Descrizione")
        End Sub
        
        Private Sub InitClass()
            Me.columnId = New DataColumn("Id", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId)
            Me.columnNota = New DataColumn("Nota", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNota)
            Me.columnData = New DataColumn("Data", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnData)
            Me.columnIdSezione = New DataColumn("IdSezione", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdSezione)
            Me.columnDescrizione = New DataColumn("Descrizione", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescrizione)
            Me.Constraints.Add(New UniqueConstraint("DsNoteSezioneKey1", New DataColumn() {Me.columnId}, true))
            Me.columnId.AllowDBNull = false
            Me.columnId.Unique = true
        End Sub
        
        Public Function NewNoteSezioneRow() As NoteSezioneRow
            Return CType(Me.NewRow,NoteSezioneRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New NoteSezioneRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(NoteSezioneRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.NoteSezioneRowChangedEvent) Is Nothing) Then
                RaiseEvent NoteSezioneRowChanged(Me, New NoteSezioneRowChangeEvent(CType(e.Row,NoteSezioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.NoteSezioneRowChangingEvent) Is Nothing) Then
                RaiseEvent NoteSezioneRowChanging(Me, New NoteSezioneRowChangeEvent(CType(e.Row,NoteSezioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.NoteSezioneRowDeletedEvent) Is Nothing) Then
                RaiseEvent NoteSezioneRowDeleted(Me, New NoteSezioneRowChangeEvent(CType(e.Row,NoteSezioneRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.NoteSezioneRowDeletingEvent) Is Nothing) Then
                RaiseEvent NoteSezioneRowDeleting(Me, New NoteSezioneRowChangeEvent(CType(e.Row,NoteSezioneRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveNoteSezioneRow(ByVal row As NoteSezioneRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class NoteSezioneRow
        Inherits DataRow
        
        Private tableNoteSezione As NoteSezioneDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableNoteSezione = CType(Me.Table,NoteSezioneDataTable)
        End Sub
        
        Public Property Id As System.Guid
            Get
                Return CType(Me(Me.tableNoteSezione.IdColumn),System.Guid)
            End Get
            Set
                Me(Me.tableNoteSezione.IdColumn) = value
            End Set
        End Property
        
        Public Property Nota As String
            Get
                Try 
                    Return CType(Me(Me.tableNoteSezione.NotaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNoteSezione.NotaColumn) = value
            End Set
        End Property
        
        Public Property Data As Date
            Get
                Try 
                    Return CType(Me(Me.tableNoteSezione.DataColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNoteSezione.DataColumn) = value
            End Set
        End Property
        
        Public Property IdSezione As Integer
            Get
                Try 
                    Return CType(Me(Me.tableNoteSezione.IdSezioneColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNoteSezione.IdSezioneColumn) = value
            End Set
        End Property
        
        Public Property Descrizione As String
            Get
                Try 
                    Return CType(Me(Me.tableNoteSezione.DescrizioneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNoteSezione.DescrizioneColumn) = value
            End Set
        End Property
        
        Public Function IsNotaNull() As Boolean
            Return Me.IsNull(Me.tableNoteSezione.NotaColumn)
        End Function
        
        Public Sub SetNotaNull()
            Me(Me.tableNoteSezione.NotaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataNull() As Boolean
            Return Me.IsNull(Me.tableNoteSezione.DataColumn)
        End Function
        
        Public Sub SetDataNull()
            Me(Me.tableNoteSezione.DataColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdSezioneNull() As Boolean
            Return Me.IsNull(Me.tableNoteSezione.IdSezioneColumn)
        End Function
        
        Public Sub SetIdSezioneNull()
            Me(Me.tableNoteSezione.IdSezioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescrizioneNull() As Boolean
            Return Me.IsNull(Me.tableNoteSezione.DescrizioneColumn)
        End Function
        
        Public Sub SetDescrizioneNull()
            Me(Me.tableNoteSezione.DescrizioneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class NoteSezioneRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As NoteSezioneRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As NoteSezioneRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As NoteSezioneRow
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