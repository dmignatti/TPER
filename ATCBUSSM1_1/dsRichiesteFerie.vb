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
Public Class dsRichiesteFerie
    Inherits DataSet
    
    Private tableRichiesteFerie As RichiesteFerieDataTable
    
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
            If (Not (ds.Tables("RichiesteFerie")) Is Nothing) Then
                Me.Tables.Add(New RichiesteFerieDataTable(ds.Tables("RichiesteFerie")))
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
    Public ReadOnly Property RichiesteFerie As RichiesteFerieDataTable
        Get
            Return Me.tableRichiesteFerie
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsRichiesteFerie = CType(MyBase.Clone,dsRichiesteFerie)
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
        If (Not (ds.Tables("RichiesteFerie")) Is Nothing) Then
            Me.Tables.Add(New RichiesteFerieDataTable(ds.Tables("RichiesteFerie")))
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
        Me.tableRichiesteFerie = CType(Me.Tables("RichiesteFerie"),RichiesteFerieDataTable)
        If (Not (Me.tableRichiesteFerie) Is Nothing) Then
            Me.tableRichiesteFerie.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsRichiesteFerie"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsRichiesteFerie.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableRichiesteFerie = New RichiesteFerieDataTable
        Me.Tables.Add(Me.tableRichiesteFerie)
    End Sub
    
    Private Function ShouldSerializeRichiesteFerie() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub RichiesteFerieRowChangeEventHandler(ByVal sender As Object, ByVal e As RichiesteFerieRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteFerieDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnApprovatore As DataColumn
        
        Private columnIdRichiesta As DataColumn
        
        Private columnIdAccertatore As DataColumn
        
        Private columnDalGiorno As DataColumn
        
        Private columnAlGiorno As DataColumn
        
        Private columnStatoApprovazione As DataColumn
        
        Private columnDataApprovazione As DataColumn
        
        Private columnIdApprovatore As DataColumn
        
        Private columnts As DataColumn
        
        Friend Sub New()
            MyBase.New("RichiesteFerie")
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
        
        Friend ReadOnly Property ApprovatoreColumn As DataColumn
            Get
                Return Me.columnApprovatore
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
        
        Friend ReadOnly Property StatoApprovazioneColumn As DataColumn
            Get
                Return Me.columnStatoApprovazione
            End Get
        End Property
        
        Friend ReadOnly Property DataApprovazioneColumn As DataColumn
            Get
                Return Me.columnDataApprovazione
            End Get
        End Property
        
        Friend ReadOnly Property IdApprovatoreColumn As DataColumn
            Get
                Return Me.columnIdApprovatore
            End Get
        End Property
        
        Friend ReadOnly Property tsColumn As DataColumn
            Get
                Return Me.columnts
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As RichiesteFerieRow
            Get
                Return CType(Me.Rows(index),RichiesteFerieRow)
            End Get
        End Property
        
        Public Event RichiesteFerieRowChanged As RichiesteFerieRowChangeEventHandler
        
        Public Event RichiesteFerieRowChanging As RichiesteFerieRowChangeEventHandler
        
        Public Event RichiesteFerieRowDeleted As RichiesteFerieRowChangeEventHandler
        
        Public Event RichiesteFerieRowDeleting As RichiesteFerieRowChangeEventHandler
        
        Public Overloads Sub AddRichiesteFerieRow(ByVal row As RichiesteFerieRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddRichiesteFerieRow(ByVal Approvatore As String, ByVal IdRichiesta As System.Guid, ByVal IdAccertatore As Integer, ByVal DalGiorno As Date, ByVal AlGiorno As Date, ByVal StatoApprovazione As String, ByVal DataApprovazione As Date, ByVal IdApprovatore As Integer, ByVal ts As Date) As RichiesteFerieRow
            Dim rowRichiesteFerieRow As RichiesteFerieRow = CType(Me.NewRow,RichiesteFerieRow)
            rowRichiesteFerieRow.ItemArray = New Object() {Approvatore, IdRichiesta, IdAccertatore, DalGiorno, AlGiorno, StatoApprovazione, DataApprovazione, IdApprovatore, ts}
            Me.Rows.Add(rowRichiesteFerieRow)
            Return rowRichiesteFerieRow
        End Function
        
        Public Function FindByIdRichiesta(ByVal IdRichiesta As System.Guid) As RichiesteFerieRow
            Return CType(Me.Rows.Find(New Object() {IdRichiesta}),RichiesteFerieRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As RichiesteFerieDataTable = CType(MyBase.Clone,RichiesteFerieDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New RichiesteFerieDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnApprovatore = Me.Columns("Approvatore")
            Me.columnIdRichiesta = Me.Columns("IdRichiesta")
            Me.columnIdAccertatore = Me.Columns("IdAccertatore")
            Me.columnDalGiorno = Me.Columns("DalGiorno")
            Me.columnAlGiorno = Me.Columns("AlGiorno")
            Me.columnStatoApprovazione = Me.Columns("StatoApprovazione")
            Me.columnDataApprovazione = Me.Columns("DataApprovazione")
            Me.columnIdApprovatore = Me.Columns("IdApprovatore")
            Me.columnts = Me.Columns("ts")
        End Sub
        
        Private Sub InitClass()
            Me.columnApprovatore = New DataColumn("Approvatore", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnApprovatore)
            Me.columnIdRichiesta = New DataColumn("IdRichiesta", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdRichiesta)
            Me.columnIdAccertatore = New DataColumn("IdAccertatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdAccertatore)
            Me.columnDalGiorno = New DataColumn("DalGiorno", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDalGiorno)
            Me.columnAlGiorno = New DataColumn("AlGiorno", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAlGiorno)
            Me.columnStatoApprovazione = New DataColumn("StatoApprovazione", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStatoApprovazione)
            Me.columnDataApprovazione = New DataColumn("DataApprovazione", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDataApprovazione)
            Me.columnIdApprovatore = New DataColumn("IdApprovatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdApprovatore)
            Me.columnts = New DataColumn("ts", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnts)
            Me.Constraints.Add(New UniqueConstraint("dsRichiesteFerieKey1", New DataColumn() {Me.columnIdRichiesta}, true))
            Me.columnApprovatore.ReadOnly = true
            Me.columnIdRichiesta.AllowDBNull = false
            Me.columnIdRichiesta.Unique = true
        End Sub
        
        Public Function NewRichiesteFerieRow() As RichiesteFerieRow
            Return CType(Me.NewRow,RichiesteFerieRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RichiesteFerieRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RichiesteFerieRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RichiesteFerieRowChangedEvent) Is Nothing) Then
                RaiseEvent RichiesteFerieRowChanged(Me, New RichiesteFerieRowChangeEvent(CType(e.Row,RichiesteFerieRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RichiesteFerieRowChangingEvent) Is Nothing) Then
                RaiseEvent RichiesteFerieRowChanging(Me, New RichiesteFerieRowChangeEvent(CType(e.Row,RichiesteFerieRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RichiesteFerieRowDeletedEvent) Is Nothing) Then
                RaiseEvent RichiesteFerieRowDeleted(Me, New RichiesteFerieRowChangeEvent(CType(e.Row,RichiesteFerieRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RichiesteFerieRowDeletingEvent) Is Nothing) Then
                RaiseEvent RichiesteFerieRowDeleting(Me, New RichiesteFerieRowChangeEvent(CType(e.Row,RichiesteFerieRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveRichiesteFerieRow(ByVal row As RichiesteFerieRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteFerieRow
        Inherits DataRow
        
        Private tableRichiesteFerie As RichiesteFerieDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableRichiesteFerie = CType(Me.Table,RichiesteFerieDataTable)
        End Sub
        
        Public Property Approvatore As String
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.ApprovatoreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.ApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property IdRichiesta As System.Guid
            Get
                Return CType(Me(Me.tableRichiesteFerie.IdRichiestaColumn),System.Guid)
            End Get
            Set
                Me(Me.tableRichiesteFerie.IdRichiestaColumn) = value
            End Set
        End Property
        
        Public Property IdAccertatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.IdAccertatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.IdAccertatoreColumn) = value
            End Set
        End Property
        
        Public Property DalGiorno As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.DalGiornoColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.DalGiornoColumn) = value
            End Set
        End Property
        
        Public Property AlGiorno As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.AlGiornoColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.AlGiornoColumn) = value
            End Set
        End Property
        
        Public Property StatoApprovazione As String
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.StatoApprovazioneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.StatoApprovazioneColumn) = value
            End Set
        End Property
        
        Public Property DataApprovazione As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.DataApprovazioneColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.DataApprovazioneColumn) = value
            End Set
        End Property
        
        Public Property IdApprovatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.IdApprovatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.IdApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property ts As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteFerie.tsColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteFerie.tsColumn) = value
            End Set
        End Property
        
        Public Function IsApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.ApprovatoreColumn)
        End Function
        
        Public Sub SetApprovatoreNull()
            Me(Me.tableRichiesteFerie.ApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdAccertatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.IdAccertatoreColumn)
        End Function
        
        Public Sub SetIdAccertatoreNull()
            Me(Me.tableRichiesteFerie.IdAccertatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDalGiornoNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.DalGiornoColumn)
        End Function
        
        Public Sub SetDalGiornoNull()
            Me(Me.tableRichiesteFerie.DalGiornoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAlGiornoNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.AlGiornoColumn)
        End Function
        
        Public Sub SetAlGiornoNull()
            Me(Me.tableRichiesteFerie.AlGiornoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.StatoApprovazioneColumn)
        End Function
        
        Public Sub SetStatoApprovazioneNull()
            Me(Me.tableRichiesteFerie.StatoApprovazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.DataApprovazioneColumn)
        End Function
        
        Public Sub SetDataApprovazioneNull()
            Me(Me.tableRichiesteFerie.DataApprovazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.IdApprovatoreColumn)
        End Function
        
        Public Sub SetIdApprovatoreNull()
            Me(Me.tableRichiesteFerie.IdApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstsNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteFerie.tsColumn)
        End Function
        
        Public Sub SettsNull()
            Me(Me.tableRichiesteFerie.tsColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteFerieRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As RichiesteFerieRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As RichiesteFerieRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As RichiesteFerieRow
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
