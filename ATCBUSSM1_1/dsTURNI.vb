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
Public Class dsTURNI
    Inherits DataSet
    
    Private tableTB_CAMBI_TURNO As TB_CAMBI_TURNODataTable
    
    Private tableAMTIP00F As AMTIP00FDataTable
    
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
            If (Not (ds.Tables("TB_CAMBI_TURNO")) Is Nothing) Then
                Me.Tables.Add(New TB_CAMBI_TURNODataTable(ds.Tables("TB_CAMBI_TURNO")))
            End If
            If (Not (ds.Tables("AMTIP00F")) Is Nothing) Then
                Me.Tables.Add(New AMTIP00FDataTable(ds.Tables("AMTIP00F")))
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
    Public ReadOnly Property TB_CAMBI_TURNO As TB_CAMBI_TURNODataTable
        Get
            Return Me.tableTB_CAMBI_TURNO
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property AMTIP00F As AMTIP00FDataTable
        Get
            Return Me.tableAMTIP00F
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsTURNI = CType(MyBase.Clone,dsTURNI)
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
        If (Not (ds.Tables("TB_CAMBI_TURNO")) Is Nothing) Then
            Me.Tables.Add(New TB_CAMBI_TURNODataTable(ds.Tables("TB_CAMBI_TURNO")))
        End If
        If (Not (ds.Tables("AMTIP00F")) Is Nothing) Then
            Me.Tables.Add(New AMTIP00FDataTable(ds.Tables("AMTIP00F")))
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
        Me.tableTB_CAMBI_TURNO = CType(Me.Tables("TB_CAMBI_TURNO"),TB_CAMBI_TURNODataTable)
        If (Not (Me.tableTB_CAMBI_TURNO) Is Nothing) Then
            Me.tableTB_CAMBI_TURNO.InitVars
        End If
        Me.tableAMTIP00F = CType(Me.Tables("AMTIP00F"),AMTIP00FDataTable)
        If (Not (Me.tableAMTIP00F) Is Nothing) Then
            Me.tableAMTIP00F.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsTURNI"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsTURNI.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableTB_CAMBI_TURNO = New TB_CAMBI_TURNODataTable
        Me.Tables.Add(Me.tableTB_CAMBI_TURNO)
        Me.tableAMTIP00F = New AMTIP00FDataTable
        Me.Tables.Add(Me.tableAMTIP00F)
    End Sub
    
    Private Function ShouldSerializeTB_CAMBI_TURNO() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeAMTIP00F() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub TB_CAMBI_TURNORowChangeEventHandler(ByVal sender As Object, ByVal e As TB_CAMBI_TURNORowChangeEvent)
    
    Public Delegate Sub AMTIP00FRowChangeEventHandler(ByVal sender As Object, ByVal e As AMTIP00FRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TB_CAMBI_TURNODataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTITIPL As DataColumn
        
        Private columnTIDTIP As DataColumn
        
        Private columnTIGRUA As DataColumn
        
        Friend Sub New()
            MyBase.New("TB_CAMBI_TURNO")
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
        
        Friend ReadOnly Property TITIPLColumn As DataColumn
            Get
                Return Me.columnTITIPL
            End Get
        End Property
        
        Friend ReadOnly Property TIDTIPColumn As DataColumn
            Get
                Return Me.columnTIDTIP
            End Get
        End Property
        
        Friend ReadOnly Property TIGRUAColumn As DataColumn
            Get
                Return Me.columnTIGRUA
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TB_CAMBI_TURNORow
            Get
                Return CType(Me.Rows(index),TB_CAMBI_TURNORow)
            End Get
        End Property
        
        Public Event TB_CAMBI_TURNORowChanged As TB_CAMBI_TURNORowChangeEventHandler
        
        Public Event TB_CAMBI_TURNORowChanging As TB_CAMBI_TURNORowChangeEventHandler
        
        Public Event TB_CAMBI_TURNORowDeleted As TB_CAMBI_TURNORowChangeEventHandler
        
        Public Event TB_CAMBI_TURNORowDeleting As TB_CAMBI_TURNORowChangeEventHandler
        
        Public Overloads Sub AddTB_CAMBI_TURNORow(ByVal row As TB_CAMBI_TURNORow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTB_CAMBI_TURNORow(ByVal TITIPL As String, ByVal TIDTIP As String, ByVal TIGRUA As String) As TB_CAMBI_TURNORow
            Dim rowTB_CAMBI_TURNORow As TB_CAMBI_TURNORow = CType(Me.NewRow,TB_CAMBI_TURNORow)
            rowTB_CAMBI_TURNORow.ItemArray = New Object() {TITIPL, TIDTIP, TIGRUA}
            Me.Rows.Add(rowTB_CAMBI_TURNORow)
            Return rowTB_CAMBI_TURNORow
        End Function
        
        Public Function FindByTITIPL(ByVal TITIPL As String) As TB_CAMBI_TURNORow
            Return CType(Me.Rows.Find(New Object() {TITIPL}),TB_CAMBI_TURNORow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TB_CAMBI_TURNODataTable = CType(MyBase.Clone,TB_CAMBI_TURNODataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TB_CAMBI_TURNODataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTITIPL = Me.Columns("TITIPL")
            Me.columnTIDTIP = Me.Columns("TIDTIP")
            Me.columnTIGRUA = Me.Columns("TIGRUA")
        End Sub
        
        Private Sub InitClass()
            Me.columnTITIPL = New DataColumn("TITIPL", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTITIPL)
            Me.columnTIDTIP = New DataColumn("TIDTIP", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTIDTIP)
            Me.columnTIGRUA = New DataColumn("TIGRUA", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTIGRUA)
            Me.Constraints.Add(New UniqueConstraint("dsTURNIKey2", New DataColumn() {Me.columnTITIPL}, true))
            Me.columnTITIPL.AllowDBNull = false
            Me.columnTITIPL.Unique = true
            Me.columnTIDTIP.AllowDBNull = false
            Me.columnTIGRUA.AllowDBNull = false
        End Sub
        
        Public Function NewTB_CAMBI_TURNORow() As TB_CAMBI_TURNORow
            Return CType(Me.NewRow,TB_CAMBI_TURNORow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TB_CAMBI_TURNORow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TB_CAMBI_TURNORow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TB_CAMBI_TURNORowChangedEvent) Is Nothing) Then
                RaiseEvent TB_CAMBI_TURNORowChanged(Me, New TB_CAMBI_TURNORowChangeEvent(CType(e.Row,TB_CAMBI_TURNORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TB_CAMBI_TURNORowChangingEvent) Is Nothing) Then
                RaiseEvent TB_CAMBI_TURNORowChanging(Me, New TB_CAMBI_TURNORowChangeEvent(CType(e.Row,TB_CAMBI_TURNORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TB_CAMBI_TURNORowDeletedEvent) Is Nothing) Then
                RaiseEvent TB_CAMBI_TURNORowDeleted(Me, New TB_CAMBI_TURNORowChangeEvent(CType(e.Row,TB_CAMBI_TURNORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TB_CAMBI_TURNORowDeletingEvent) Is Nothing) Then
                RaiseEvent TB_CAMBI_TURNORowDeleting(Me, New TB_CAMBI_TURNORowChangeEvent(CType(e.Row,TB_CAMBI_TURNORow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTB_CAMBI_TURNORow(ByVal row As TB_CAMBI_TURNORow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TB_CAMBI_TURNORow
        Inherits DataRow
        
        Private tableTB_CAMBI_TURNO As TB_CAMBI_TURNODataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTB_CAMBI_TURNO = CType(Me.Table,TB_CAMBI_TURNODataTable)
        End Sub
        
        Public Property TITIPL As String
            Get
                Return CType(Me(Me.tableTB_CAMBI_TURNO.TITIPLColumn),String)
            End Get
            Set
                Me(Me.tableTB_CAMBI_TURNO.TITIPLColumn) = value
            End Set
        End Property
        
        Public Property TIDTIP As String
            Get
                Return CType(Me(Me.tableTB_CAMBI_TURNO.TIDTIPColumn),String)
            End Get
            Set
                Me(Me.tableTB_CAMBI_TURNO.TIDTIPColumn) = value
            End Set
        End Property
        
        Public Property TIGRUA As String
            Get
                Return CType(Me(Me.tableTB_CAMBI_TURNO.TIGRUAColumn),String)
            End Get
            Set
                Me(Me.tableTB_CAMBI_TURNO.TIGRUAColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TB_CAMBI_TURNORowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TB_CAMBI_TURNORow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TB_CAMBI_TURNORow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TB_CAMBI_TURNORow
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
    Public Class AMTIP00FDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTITIPL As DataColumn
        
        Private columnTIDTIP As DataColumn
        
        Private columnTIGRUA As DataColumn
        
        Friend Sub New()
            MyBase.New("AMTIP00F")
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
        
        Friend ReadOnly Property TITIPLColumn As DataColumn
            Get
                Return Me.columnTITIPL
            End Get
        End Property
        
        Friend ReadOnly Property TIDTIPColumn As DataColumn
            Get
                Return Me.columnTIDTIP
            End Get
        End Property
        
        Friend ReadOnly Property TIGRUAColumn As DataColumn
            Get
                Return Me.columnTIGRUA
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AMTIP00FRow
            Get
                Return CType(Me.Rows(index),AMTIP00FRow)
            End Get
        End Property
        
        Public Event AMTIP00FRowChanged As AMTIP00FRowChangeEventHandler
        
        Public Event AMTIP00FRowChanging As AMTIP00FRowChangeEventHandler
        
        Public Event AMTIP00FRowDeleted As AMTIP00FRowChangeEventHandler
        
        Public Event AMTIP00FRowDeleting As AMTIP00FRowChangeEventHandler
        
        Public Overloads Sub AddAMTIP00FRow(ByVal row As AMTIP00FRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAMTIP00FRow(ByVal TITIPL As String, ByVal TIDTIP As String, ByVal TIGRUA As String) As AMTIP00FRow
            Dim rowAMTIP00FRow As AMTIP00FRow = CType(Me.NewRow,AMTIP00FRow)
            rowAMTIP00FRow.ItemArray = New Object() {TITIPL, TIDTIP, TIGRUA}
            Me.Rows.Add(rowAMTIP00FRow)
            Return rowAMTIP00FRow
        End Function
        
        Public Function FindByTITIPL(ByVal TITIPL As String) As AMTIP00FRow
            Return CType(Me.Rows.Find(New Object() {TITIPL}),AMTIP00FRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AMTIP00FDataTable = CType(MyBase.Clone,AMTIP00FDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AMTIP00FDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTITIPL = Me.Columns("TITIPL")
            Me.columnTIDTIP = Me.Columns("TIDTIP")
            Me.columnTIGRUA = Me.Columns("TIGRUA")
        End Sub
        
        Private Sub InitClass()
            Me.columnTITIPL = New DataColumn("TITIPL", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTITIPL)
            Me.columnTIDTIP = New DataColumn("TIDTIP", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTIDTIP)
            Me.columnTIGRUA = New DataColumn("TIGRUA", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTIGRUA)
            Me.Constraints.Add(New UniqueConstraint("dsTURNIKey1", New DataColumn() {Me.columnTITIPL}, true))
            Me.columnTITIPL.AllowDBNull = false
            Me.columnTITIPL.Unique = true
            Me.columnTIDTIP.AllowDBNull = false
            Me.columnTIGRUA.ReadOnly = true
        End Sub
        
        Public Function NewAMTIP00FRow() As AMTIP00FRow
            Return CType(Me.NewRow,AMTIP00FRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AMTIP00FRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AMTIP00FRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AMTIP00FRowChangedEvent) Is Nothing) Then
                RaiseEvent AMTIP00FRowChanged(Me, New AMTIP00FRowChangeEvent(CType(e.Row,AMTIP00FRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AMTIP00FRowChangingEvent) Is Nothing) Then
                RaiseEvent AMTIP00FRowChanging(Me, New AMTIP00FRowChangeEvent(CType(e.Row,AMTIP00FRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AMTIP00FRowDeletedEvent) Is Nothing) Then
                RaiseEvent AMTIP00FRowDeleted(Me, New AMTIP00FRowChangeEvent(CType(e.Row,AMTIP00FRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AMTIP00FRowDeletingEvent) Is Nothing) Then
                RaiseEvent AMTIP00FRowDeleting(Me, New AMTIP00FRowChangeEvent(CType(e.Row,AMTIP00FRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAMTIP00FRow(ByVal row As AMTIP00FRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AMTIP00FRow
        Inherits DataRow
        
        Private tableAMTIP00F As AMTIP00FDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAMTIP00F = CType(Me.Table,AMTIP00FDataTable)
        End Sub
        
        Public Property TITIPL As String
            Get
                Return CType(Me(Me.tableAMTIP00F.TITIPLColumn),String)
            End Get
            Set
                Me(Me.tableAMTIP00F.TITIPLColumn) = value
            End Set
        End Property
        
        Public Property TIDTIP As String
            Get
                Return CType(Me(Me.tableAMTIP00F.TIDTIPColumn),String)
            End Get
            Set
                Me(Me.tableAMTIP00F.TIDTIPColumn) = value
            End Set
        End Property
        
        Public Property TIGRUA As String
            Get
                Try 
                    Return CType(Me(Me.tableAMTIP00F.TIGRUAColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAMTIP00F.TIGRUAColumn) = value
            End Set
        End Property
        
        Public Function IsTIGRUANull() As Boolean
            Return Me.IsNull(Me.tableAMTIP00F.TIGRUAColumn)
        End Function
        
        Public Sub SetTIGRUANull()
            Me(Me.tableAMTIP00F.TIGRUAColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AMTIP00FRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AMTIP00FRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AMTIP00FRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AMTIP00FRow
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
