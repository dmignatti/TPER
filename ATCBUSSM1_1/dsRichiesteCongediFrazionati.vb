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
Public Class dsRichiesteCongediFrazionati
    Inherits DataSet
    
    Private tableRichiesteCongediFrazionati As RichiesteCongediFrazionatiDataTable
    
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
            If (Not (ds.Tables("RichiesteCongediFrazionati")) Is Nothing) Then
                Me.Tables.Add(New RichiesteCongediFrazionatiDataTable(ds.Tables("RichiesteCongediFrazionati")))
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
    Public ReadOnly Property RichiesteCongediFrazionati As RichiesteCongediFrazionatiDataTable
        Get
            Return Me.tableRichiesteCongediFrazionati
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsRichiesteCongediFrazionati = CType(MyBase.Clone,dsRichiesteCongediFrazionati)
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
        If (Not (ds.Tables("RichiesteCongediFrazionati")) Is Nothing) Then
            Me.Tables.Add(New RichiesteCongediFrazionatiDataTable(ds.Tables("RichiesteCongediFrazionati")))
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
        Me.tableRichiesteCongediFrazionati = CType(Me.Tables("RichiesteCongediFrazionati"),RichiesteCongediFrazionatiDataTable)
        If (Not (Me.tableRichiesteCongediFrazionati) Is Nothing) Then
            Me.tableRichiesteCongediFrazionati.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsRichiesteCongediFrazionati"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsRichiesteCongediFrazionati.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableRichiesteCongediFrazionati = New RichiesteCongediFrazionatiDataTable
        Me.Tables.Add(Me.tableRichiesteCongediFrazionati)
    End Sub
    
    Private Function ShouldSerializeRichiesteCongediFrazionati() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub RichiesteCongediFrazionatiRowChangeEventHandler(ByVal sender As Object, ByVal e As RichiesteCongediFrazionatiRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediFrazionatiDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnApprovatore As DataColumn
        
        Private columnIdRichiesta As DataColumn
        
        Private columnIdAccertatore As DataColumn
        
        Private columnData As DataColumn
        
        Private columnDalleOre As DataColumn
        
        Private columnAlleOre As DataColumn
        
        Private columnStatoApprovazione As DataColumn
        
        Private columnDataApprovazione As DataColumn
        
        Private columnIdApprovatore As DataColumn
        
        Private columnts As DataColumn
        
        Private columnIntero As DataColumn
        
        Friend Sub New()
            MyBase.New("RichiesteCongediFrazionati")
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
        
        Friend ReadOnly Property DataColumn As DataColumn
            Get
                Return Me.columnData
            End Get
        End Property
        
        Friend ReadOnly Property DalleOreColumn As DataColumn
            Get
                Return Me.columnDalleOre
            End Get
        End Property
        
        Friend ReadOnly Property AlleOreColumn As DataColumn
            Get
                Return Me.columnAlleOre
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
        
        Friend ReadOnly Property InteroColumn As DataColumn
            Get
                Return Me.columnIntero
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As RichiesteCongediFrazionatiRow
            Get
                Return CType(Me.Rows(index),RichiesteCongediFrazionatiRow)
            End Get
        End Property
        
        Public Event RichiesteCongediFrazionatiRowChanged As RichiesteCongediFrazionatiRowChangeEventHandler
        
        Public Event RichiesteCongediFrazionatiRowChanging As RichiesteCongediFrazionatiRowChangeEventHandler
        
        Public Event RichiesteCongediFrazionatiRowDeleted As RichiesteCongediFrazionatiRowChangeEventHandler
        
        Public Event RichiesteCongediFrazionatiRowDeleting As RichiesteCongediFrazionatiRowChangeEventHandler
        
        Public Overloads Sub AddRichiesteCongediFrazionatiRow(ByVal row As RichiesteCongediFrazionatiRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddRichiesteCongediFrazionatiRow(ByVal Approvatore As String, ByVal IdRichiesta As System.Guid, ByVal IdAccertatore As Integer, ByVal Data As Date, ByVal DalleOre As Long, ByVal AlleOre As Long, ByVal StatoApprovazione As String, ByVal DataApprovazione As Date, ByVal IdApprovatore As Integer, ByVal ts As Date, ByVal Intero As Boolean) As RichiesteCongediFrazionatiRow
            Dim rowRichiesteCongediFrazionatiRow As RichiesteCongediFrazionatiRow = CType(Me.NewRow,RichiesteCongediFrazionatiRow)
            rowRichiesteCongediFrazionatiRow.ItemArray = New Object() {Approvatore, IdRichiesta, IdAccertatore, Data, DalleOre, AlleOre, StatoApprovazione, DataApprovazione, IdApprovatore, ts, Intero}
            Me.Rows.Add(rowRichiesteCongediFrazionatiRow)
            Return rowRichiesteCongediFrazionatiRow
        End Function
        
        Public Function FindByIdRichiesta(ByVal IdRichiesta As System.Guid) As RichiesteCongediFrazionatiRow
            Return CType(Me.Rows.Find(New Object() {IdRichiesta}),RichiesteCongediFrazionatiRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As RichiesteCongediFrazionatiDataTable = CType(MyBase.Clone,RichiesteCongediFrazionatiDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New RichiesteCongediFrazionatiDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnApprovatore = Me.Columns("Approvatore")
            Me.columnIdRichiesta = Me.Columns("IdRichiesta")
            Me.columnIdAccertatore = Me.Columns("IdAccertatore")
            Me.columnData = Me.Columns("Data")
            Me.columnDalleOre = Me.Columns("DalleOre")
            Me.columnAlleOre = Me.Columns("AlleOre")
            Me.columnStatoApprovazione = Me.Columns("StatoApprovazione")
            Me.columnDataApprovazione = Me.Columns("DataApprovazione")
            Me.columnIdApprovatore = Me.Columns("IdApprovatore")
            Me.columnts = Me.Columns("ts")
            Me.columnIntero = Me.Columns("Intero")
        End Sub
        
        Private Sub InitClass()
            Me.columnApprovatore = New DataColumn("Approvatore", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnApprovatore)
            Me.columnIdRichiesta = New DataColumn("IdRichiesta", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdRichiesta)
            Me.columnIdAccertatore = New DataColumn("IdAccertatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdAccertatore)
            Me.columnData = New DataColumn("Data", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnData)
            Me.columnDalleOre = New DataColumn("DalleOre", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDalleOre)
            Me.columnAlleOre = New DataColumn("AlleOre", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAlleOre)
            Me.columnStatoApprovazione = New DataColumn("StatoApprovazione", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStatoApprovazione)
            Me.columnDataApprovazione = New DataColumn("DataApprovazione", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDataApprovazione)
            Me.columnIdApprovatore = New DataColumn("IdApprovatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdApprovatore)
            Me.columnts = New DataColumn("ts", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnts)
            Me.columnIntero = New DataColumn("Intero", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIntero)
            Me.Constraints.Add(New UniqueConstraint("dsRichiesteCongediFrazionatiKey1", New DataColumn() {Me.columnIdRichiesta}, true))
            Me.columnApprovatore.ReadOnly = true
            Me.columnIdRichiesta.AllowDBNull = false
            Me.columnIdRichiesta.Unique = true
            Me.columnStatoApprovazione.ReadOnly = true
        End Sub
        
        Public Function NewRichiesteCongediFrazionatiRow() As RichiesteCongediFrazionatiRow
            Return CType(Me.NewRow,RichiesteCongediFrazionatiRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RichiesteCongediFrazionatiRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RichiesteCongediFrazionatiRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RichiesteCongediFrazionatiRowChangedEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediFrazionatiRowChanged(Me, New RichiesteCongediFrazionatiRowChangeEvent(CType(e.Row,RichiesteCongediFrazionatiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RichiesteCongediFrazionatiRowChangingEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediFrazionatiRowChanging(Me, New RichiesteCongediFrazionatiRowChangeEvent(CType(e.Row,RichiesteCongediFrazionatiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RichiesteCongediFrazionatiRowDeletedEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediFrazionatiRowDeleted(Me, New RichiesteCongediFrazionatiRowChangeEvent(CType(e.Row,RichiesteCongediFrazionatiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RichiesteCongediFrazionatiRowDeletingEvent) Is Nothing) Then
                RaiseEvent RichiesteCongediFrazionatiRowDeleting(Me, New RichiesteCongediFrazionatiRowChangeEvent(CType(e.Row,RichiesteCongediFrazionatiRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveRichiesteCongediFrazionatiRow(ByVal row As RichiesteCongediFrazionatiRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediFrazionatiRow
        Inherits DataRow
        
        Private tableRichiesteCongediFrazionati As RichiesteCongediFrazionatiDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableRichiesteCongediFrazionati = CType(Me.Table,RichiesteCongediFrazionatiDataTable)
        End Sub
        
        Public Property Approvatore As String
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.ApprovatoreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.ApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property IdRichiesta As System.Guid
            Get
                Return CType(Me(Me.tableRichiesteCongediFrazionati.IdRichiestaColumn),System.Guid)
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.IdRichiestaColumn) = value
            End Set
        End Property
        
        Public Property IdAccertatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.IdAccertatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.IdAccertatoreColumn) = value
            End Set
        End Property
        
        Public Property Data As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.DataColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.DataColumn) = value
            End Set
        End Property
        
        Public Property DalleOre As Long
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.DalleOreColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.DalleOreColumn) = value
            End Set
        End Property
        
        Public Property AlleOre As Long
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.AlleOreColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.AlleOreColumn) = value
            End Set
        End Property
        
        Public Property StatoApprovazione As String
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.StatoApprovazioneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.StatoApprovazioneColumn) = value
            End Set
        End Property
        
        Public Property DataApprovazione As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.DataApprovazioneColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.DataApprovazioneColumn) = value
            End Set
        End Property
        
        Public Property IdApprovatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.IdApprovatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.IdApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property ts As Date
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.tsColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.tsColumn) = value
            End Set
        End Property
        
        Public Property Intero As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableRichiesteCongediFrazionati.InteroColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRichiesteCongediFrazionati.InteroColumn) = value
            End Set
        End Property
        
        Public Function IsApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.ApprovatoreColumn)
        End Function
        
        Public Sub SetApprovatoreNull()
            Me(Me.tableRichiesteCongediFrazionati.ApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdAccertatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.IdAccertatoreColumn)
        End Function
        
        Public Sub SetIdAccertatoreNull()
            Me(Me.tableRichiesteCongediFrazionati.IdAccertatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.DataColumn)
        End Function
        
        Public Sub SetDataNull()
            Me(Me.tableRichiesteCongediFrazionati.DataColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDalleOreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.DalleOreColumn)
        End Function
        
        Public Sub SetDalleOreNull()
            Me(Me.tableRichiesteCongediFrazionati.DalleOreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAlleOreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.AlleOreColumn)
        End Function
        
        Public Sub SetAlleOreNull()
            Me(Me.tableRichiesteCongediFrazionati.AlleOreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.StatoApprovazioneColumn)
        End Function
        
        Public Sub SetStatoApprovazioneNull()
            Me(Me.tableRichiesteCongediFrazionati.StatoApprovazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.DataApprovazioneColumn)
        End Function
        
        Public Sub SetDataApprovazioneNull()
            Me(Me.tableRichiesteCongediFrazionati.DataApprovazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.IdApprovatoreColumn)
        End Function
        
        Public Sub SetIdApprovatoreNull()
            Me(Me.tableRichiesteCongediFrazionati.IdApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IstsNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.tsColumn)
        End Function
        
        Public Sub SettsNull()
            Me(Me.tableRichiesteCongediFrazionati.tsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInteroNull() As Boolean
            Return Me.IsNull(Me.tableRichiesteCongediFrazionati.InteroColumn)
        End Function
        
        Public Sub SetInteroNull()
            Me(Me.tableRichiesteCongediFrazionati.InteroColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RichiesteCongediFrazionatiRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As RichiesteCongediFrazionatiRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As RichiesteCongediFrazionatiRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As RichiesteCongediFrazionatiRow
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
