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
Public Class dsListaTurniStessoTipo
    Inherits DataSet
    
    Private tabledbo_SP_ListaCambiGiornalieriStessoTipo As dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
    
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
            If (Not (ds.Tables("dbo_SP_ListaCambiGiornalieriStessoTipo")) Is Nothing) Then
                Me.Tables.Add(New dbo_SP_ListaCambiGiornalieriStessoTipoDataTable(ds.Tables("dbo_SP_ListaCambiGiornalieriStessoTipo")))
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
    Public ReadOnly Property dbo_SP_ListaCambiGiornalieriStessoTipo As dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
        Get
            Return Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsListaTurniStessoTipo = CType(MyBase.Clone,dsListaTurniStessoTipo)
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
        If (Not (ds.Tables("dbo_SP_ListaCambiGiornalieriStessoTipo")) Is Nothing) Then
            Me.Tables.Add(New dbo_SP_ListaCambiGiornalieriStessoTipoDataTable(ds.Tables("dbo_SP_ListaCambiGiornalieriStessoTipo")))
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
        Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo = CType(Me.Tables("dbo_SP_ListaCambiGiornalieriStessoTipo"),dbo_SP_ListaCambiGiornalieriStessoTipoDataTable)
        If (Not (Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo) Is Nothing) Then
            Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsListaTurniStessoTipo"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsListaTurniStessoTipo.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo = New dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
        Me.Tables.Add(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo)
    End Sub
    
    Private Function ShouldSerializedbo_SP_ListaCambiGiornalieriStessoTipo() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEventHandler(ByVal sender As Object, ByVal e As dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnDESCR As DataColumn
        
        Private columntitipl As DataColumn
        
        Private columntigrua As DataColumn
        
        Private columntisass As DataColumn
        
        Private columntisrsq As DataColumn
        
        Friend Sub New()
            MyBase.New("dbo_SP_ListaCambiGiornalieriStessoTipo")
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
        
        Friend ReadOnly Property DESCRColumn As DataColumn
            Get
                Return Me.columnDESCR
            End Get
        End Property
        
        Friend ReadOnly Property titiplColumn As DataColumn
            Get
                Return Me.columntitipl
            End Get
        End Property
        
        Friend ReadOnly Property tigruaColumn As DataColumn
            Get
                Return Me.columntigrua
            End Get
        End Property
        
        Friend ReadOnly Property tisassColumn As DataColumn
            Get
                Return Me.columntisass
            End Get
        End Property
        
        Friend ReadOnly Property tisrsqColumn As DataColumn
            Get
                Return Me.columntisrsq
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As dbo_SP_ListaCambiGiornalieriStessoTipoRow
            Get
                Return CType(Me.Rows(index),dbo_SP_ListaCambiGiornalieriStessoTipoRow)
            End Get
        End Property
        
        Public Event dbo_SP_ListaCambiGiornalieriStessoTipoRowChanged As dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEventHandler
        
        Public Event dbo_SP_ListaCambiGiornalieriStessoTipoRowChanging As dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEventHandler
        
        Public Event dbo_SP_ListaCambiGiornalieriStessoTipoRowDeleted As dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEventHandler
        
        Public Event dbo_SP_ListaCambiGiornalieriStessoTipoRowDeleting As dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEventHandler
        
        Public Overloads Sub Adddbo_SP_ListaCambiGiornalieriStessoTipoRow(ByVal row As dbo_SP_ListaCambiGiornalieriStessoTipoRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Adddbo_SP_ListaCambiGiornalieriStessoTipoRow(ByVal DESCR As String, ByVal titipl As String, ByVal tigrua As String, ByVal tisass As Decimal, ByVal tisrsq As Decimal) As dbo_SP_ListaCambiGiornalieriStessoTipoRow
            Dim rowdbo_SP_ListaCambiGiornalieriStessoTipoRow As dbo_SP_ListaCambiGiornalieriStessoTipoRow = CType(Me.NewRow,dbo_SP_ListaCambiGiornalieriStessoTipoRow)
            rowdbo_SP_ListaCambiGiornalieriStessoTipoRow.ItemArray = New Object() {DESCR, titipl, tigrua, tisass, tisrsq}
            Me.Rows.Add(rowdbo_SP_ListaCambiGiornalieriStessoTipoRow)
            Return rowdbo_SP_ListaCambiGiornalieriStessoTipoRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As dbo_SP_ListaCambiGiornalieriStessoTipoDataTable = CType(MyBase.Clone,dbo_SP_ListaCambiGiornalieriStessoTipoDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnDESCR = Me.Columns("DESCR")
            Me.columntitipl = Me.Columns("titipl")
            Me.columntigrua = Me.Columns("tigrua")
            Me.columntisass = Me.Columns("tisass")
            Me.columntisrsq = Me.Columns("tisrsq")
        End Sub
        
        Private Sub InitClass()
            Me.columnDESCR = New DataColumn("DESCR", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDESCR)
            Me.columntitipl = New DataColumn("titipl", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntitipl)
            Me.columntigrua = New DataColumn("tigrua", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntigrua)
            Me.columntisass = New DataColumn("tisass", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntisass)
            Me.columntisrsq = New DataColumn("tisrsq", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columntisrsq)
            Me.columnDESCR.ReadOnly = true
            Me.columntitipl.AllowDBNull = false
            Me.columntigrua.AllowDBNull = false
            Me.columntisass.AllowDBNull = false
            Me.columntisrsq.AllowDBNull = false
        End Sub
        
        Public Function Newdbo_SP_ListaCambiGiornalieriStessoTipoRow() As dbo_SP_ListaCambiGiornalieriStessoTipoRow
            Return CType(Me.NewRow,dbo_SP_ListaCambiGiornalieriStessoTipoRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New dbo_SP_ListaCambiGiornalieriStessoTipoRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(dbo_SP_ListaCambiGiornalieriStessoTipoRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.dbo_SP_ListaCambiGiornalieriStessoTipoRowChangedEvent) Is Nothing) Then
                RaiseEvent dbo_SP_ListaCambiGiornalieriStessoTipoRowChanged(Me, New dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent(CType(e.Row,dbo_SP_ListaCambiGiornalieriStessoTipoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.dbo_SP_ListaCambiGiornalieriStessoTipoRowChangingEvent) Is Nothing) Then
                RaiseEvent dbo_SP_ListaCambiGiornalieriStessoTipoRowChanging(Me, New dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent(CType(e.Row,dbo_SP_ListaCambiGiornalieriStessoTipoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.dbo_SP_ListaCambiGiornalieriStessoTipoRowDeletedEvent) Is Nothing) Then
                RaiseEvent dbo_SP_ListaCambiGiornalieriStessoTipoRowDeleted(Me, New dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent(CType(e.Row,dbo_SP_ListaCambiGiornalieriStessoTipoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.dbo_SP_ListaCambiGiornalieriStessoTipoRowDeletingEvent) Is Nothing) Then
                RaiseEvent dbo_SP_ListaCambiGiornalieriStessoTipoRowDeleting(Me, New dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent(CType(e.Row,dbo_SP_ListaCambiGiornalieriStessoTipoRow), e.Action))
            End If
        End Sub
        
        Public Sub Removedbo_SP_ListaCambiGiornalieriStessoTipoRow(ByVal row As dbo_SP_ListaCambiGiornalieriStessoTipoRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class dbo_SP_ListaCambiGiornalieriStessoTipoRow
        Inherits DataRow
        
        Private tabledbo_SP_ListaCambiGiornalieriStessoTipo As dbo_SP_ListaCambiGiornalieriStessoTipoDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo = CType(Me.Table,dbo_SP_ListaCambiGiornalieriStessoTipoDataTable)
        End Sub
        
        Public Property DESCR As String
            Get
                Try 
                    Return CType(Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.DESCRColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.DESCRColumn) = value
            End Set
        End Property
        
        Public Property titipl As String
            Get
                Return CType(Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.titiplColumn),String)
            End Get
            Set
                Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.titiplColumn) = value
            End Set
        End Property
        
        Public Property tigrua As String
            Get
                Return CType(Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tigruaColumn),String)
            End Get
            Set
                Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tigruaColumn) = value
            End Set
        End Property
        
        Public Property tisass As Decimal
            Get
                Return CType(Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tisassColumn),Decimal)
            End Get
            Set
                Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tisassColumn) = value
            End Set
        End Property
        
        Public Property tisrsq As Decimal
            Get
                Return CType(Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tisrsqColumn),Decimal)
            End Get
            Set
                Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.tisrsqColumn) = value
            End Set
        End Property
        
        Public Function IsDESCRNull() As Boolean
            Return Me.IsNull(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.DESCRColumn)
        End Function
        
        Public Sub SetDESCRNull()
            Me(Me.tabledbo_SP_ListaCambiGiornalieriStessoTipo.DESCRColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class dbo_SP_ListaCambiGiornalieriStessoTipoRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As dbo_SP_ListaCambiGiornalieriStessoTipoRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As dbo_SP_ListaCambiGiornalieriStessoTipoRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As dbo_SP_ListaCambiGiornalieriStessoTipoRow
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
