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
Public Class DsTURNIAE
    Inherits DataSet
    
    Private tableGruppiDelModulo As GruppiDelModuloDataTable
    
    Private tableATC_Gruppi As ATC_GruppiDataTable
    
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
            If (Not (ds.Tables("GruppiDelModulo")) Is Nothing) Then
                Me.Tables.Add(New GruppiDelModuloDataTable(ds.Tables("GruppiDelModulo")))
            End If
            If (Not (ds.Tables("ATC_Gruppi")) Is Nothing) Then
                Me.Tables.Add(New ATC_GruppiDataTable(ds.Tables("ATC_Gruppi")))
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
    Public ReadOnly Property GruppiDelModulo As GruppiDelModuloDataTable
        Get
            Return Me.tableGruppiDelModulo
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ATC_Gruppi As ATC_GruppiDataTable
        Get
            Return Me.tableATC_Gruppi
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsTURNIAE = CType(MyBase.Clone,DsTURNIAE)
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
        If (Not (ds.Tables("GruppiDelModulo")) Is Nothing) Then
            Me.Tables.Add(New GruppiDelModuloDataTable(ds.Tables("GruppiDelModulo")))
        End If
        If (Not (ds.Tables("ATC_Gruppi")) Is Nothing) Then
            Me.Tables.Add(New ATC_GruppiDataTable(ds.Tables("ATC_Gruppi")))
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
        Me.tableGruppiDelModulo = CType(Me.Tables("GruppiDelModulo"),GruppiDelModuloDataTable)
        If (Not (Me.tableGruppiDelModulo) Is Nothing) Then
            Me.tableGruppiDelModulo.InitVars
        End If
        Me.tableATC_Gruppi = CType(Me.Tables("ATC_Gruppi"),ATC_GruppiDataTable)
        If (Not (Me.tableATC_Gruppi) Is Nothing) Then
            Me.tableATC_Gruppi.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsTURNIAE"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsTURNIAE.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableGruppiDelModulo = New GruppiDelModuloDataTable
        Me.Tables.Add(Me.tableGruppiDelModulo)
        Me.tableATC_Gruppi = New ATC_GruppiDataTable
        Me.Tables.Add(Me.tableATC_Gruppi)
    End Sub
    
    Private Function ShouldSerializeGruppiDelModulo() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeATC_Gruppi() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub GruppiDelModuloRowChangeEventHandler(ByVal sender As Object, ByVal e As GruppiDelModuloRowChangeEvent)
    
    Public Delegate Sub ATC_GruppiRowChangeEventHandler(ByVal sender As Object, ByVal e As ATC_GruppiRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GruppiDelModuloDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTURNI As DataColumn
        
        Private columnGRUPPI As DataColumn
        
        Private columnTIPO As DataColumn
        
        Friend Sub New()
            MyBase.New("GruppiDelModulo")
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
        
        Friend ReadOnly Property TURNIColumn As DataColumn
            Get
                Return Me.columnTURNI
            End Get
        End Property
        
        Friend ReadOnly Property GRUPPIColumn As DataColumn
            Get
                Return Me.columnGRUPPI
            End Get
        End Property
        
        Friend ReadOnly Property TIPOColumn As DataColumn
            Get
                Return Me.columnTIPO
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As GruppiDelModuloRow
            Get
                Return CType(Me.Rows(index),GruppiDelModuloRow)
            End Get
        End Property
        
        Public Event GruppiDelModuloRowChanged As GruppiDelModuloRowChangeEventHandler
        
        Public Event GruppiDelModuloRowChanging As GruppiDelModuloRowChangeEventHandler
        
        Public Event GruppiDelModuloRowDeleted As GruppiDelModuloRowChangeEventHandler
        
        Public Event GruppiDelModuloRowDeleting As GruppiDelModuloRowChangeEventHandler
        
        Public Overloads Sub AddGruppiDelModuloRow(ByVal row As GruppiDelModuloRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddGruppiDelModuloRow(ByVal TURNI As String, ByVal GRUPPI As String, ByVal TIPO As String) As GruppiDelModuloRow
            Dim rowGruppiDelModuloRow As GruppiDelModuloRow = CType(Me.NewRow,GruppiDelModuloRow)
            rowGruppiDelModuloRow.ItemArray = New Object() {TURNI, GRUPPI, TIPO}
            Me.Rows.Add(rowGruppiDelModuloRow)
            Return rowGruppiDelModuloRow
        End Function
        
        Public Function FindByTURNI(ByVal TURNI As String) As GruppiDelModuloRow
            Return CType(Me.Rows.Find(New Object() {TURNI}),GruppiDelModuloRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As GruppiDelModuloDataTable = CType(MyBase.Clone,GruppiDelModuloDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New GruppiDelModuloDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTURNI = Me.Columns("TURNI")
            Me.columnGRUPPI = Me.Columns("GRUPPI")
            Me.columnTIPO = Me.Columns("TIPO")
        End Sub
        
        Private Sub InitClass()
            Me.columnTURNI = New DataColumn("TURNI", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTURNI)
            Me.columnGRUPPI = New DataColumn("GRUPPI", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnGRUPPI)
            Me.columnTIPO = New DataColumn("TIPO", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTIPO)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnTURNI}, true))
            Me.columnTURNI.AllowDBNull = false
            Me.columnTURNI.Unique = true
            Me.columnGRUPPI.AllowDBNull = false
            Me.columnTIPO.AllowDBNull = false
        End Sub
        
        Public Function NewGruppiDelModuloRow() As GruppiDelModuloRow
            Return CType(Me.NewRow,GruppiDelModuloRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New GruppiDelModuloRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(GruppiDelModuloRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.GruppiDelModuloRowChangedEvent) Is Nothing) Then
                RaiseEvent GruppiDelModuloRowChanged(Me, New GruppiDelModuloRowChangeEvent(CType(e.Row,GruppiDelModuloRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.GruppiDelModuloRowChangingEvent) Is Nothing) Then
                RaiseEvent GruppiDelModuloRowChanging(Me, New GruppiDelModuloRowChangeEvent(CType(e.Row,GruppiDelModuloRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.GruppiDelModuloRowDeletedEvent) Is Nothing) Then
                RaiseEvent GruppiDelModuloRowDeleted(Me, New GruppiDelModuloRowChangeEvent(CType(e.Row,GruppiDelModuloRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.GruppiDelModuloRowDeletingEvent) Is Nothing) Then
                RaiseEvent GruppiDelModuloRowDeleting(Me, New GruppiDelModuloRowChangeEvent(CType(e.Row,GruppiDelModuloRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveGruppiDelModuloRow(ByVal row As GruppiDelModuloRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GruppiDelModuloRow
        Inherits DataRow
        
        Private tableGruppiDelModulo As GruppiDelModuloDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableGruppiDelModulo = CType(Me.Table,GruppiDelModuloDataTable)
        End Sub
        
        Public Property TURNI As String
            Get
                Return CType(Me(Me.tableGruppiDelModulo.TURNIColumn),String)
            End Get
            Set
                Me(Me.tableGruppiDelModulo.TURNIColumn) = value
            End Set
        End Property
        
        Public Property GRUPPI As String
            Get
                Return CType(Me(Me.tableGruppiDelModulo.GRUPPIColumn),String)
            End Get
            Set
                Me(Me.tableGruppiDelModulo.GRUPPIColumn) = value
            End Set
        End Property
        
        Public Property TIPO As String
            Get
                Return CType(Me(Me.tableGruppiDelModulo.TIPOColumn),String)
            End Get
            Set
                Me(Me.tableGruppiDelModulo.TIPOColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class GruppiDelModuloRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As GruppiDelModuloRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As GruppiDelModuloRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As GruppiDelModuloRow
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
    Public Class ATC_GruppiDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTUCTUR As DataColumn
        
        Private columnTUCTUR_ORDER As DataColumn
        
        Private columnTUGRUA As DataColumn
        
        Private columnTUTIPL As DataColumn
        
        Friend Sub New()
            MyBase.New("ATC_Gruppi")
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
        
        Friend ReadOnly Property TUCTURColumn As DataColumn
            Get
                Return Me.columnTUCTUR
            End Get
        End Property
        
        Friend ReadOnly Property TUCTUR_ORDERColumn As DataColumn
            Get
                Return Me.columnTUCTUR_ORDER
            End Get
        End Property
        
        Friend ReadOnly Property TUGRUAColumn As DataColumn
            Get
                Return Me.columnTUGRUA
            End Get
        End Property
        
        Friend ReadOnly Property TUTIPLColumn As DataColumn
            Get
                Return Me.columnTUTIPL
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ATC_GruppiRow
            Get
                Return CType(Me.Rows(index),ATC_GruppiRow)
            End Get
        End Property
        
        Public Event ATC_GruppiRowChanged As ATC_GruppiRowChangeEventHandler
        
        Public Event ATC_GruppiRowChanging As ATC_GruppiRowChangeEventHandler
        
        Public Event ATC_GruppiRowDeleted As ATC_GruppiRowChangeEventHandler
        
        Public Event ATC_GruppiRowDeleting As ATC_GruppiRowChangeEventHandler
        
        Public Overloads Sub AddATC_GruppiRow(ByVal row As ATC_GruppiRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddATC_GruppiRow(ByVal TUCTUR As String, ByVal TUCTUR_ORDER As Long, ByVal TUGRUA As String, ByVal TUTIPL As String) As ATC_GruppiRow
            Dim rowATC_GruppiRow As ATC_GruppiRow = CType(Me.NewRow,ATC_GruppiRow)
            rowATC_GruppiRow.ItemArray = New Object() {TUCTUR, TUCTUR_ORDER, TUGRUA, TUTIPL}
            Me.Rows.Add(rowATC_GruppiRow)
            Return rowATC_GruppiRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ATC_GruppiDataTable = CType(MyBase.Clone,ATC_GruppiDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ATC_GruppiDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTUCTUR = Me.Columns("TUCTUR")
            Me.columnTUCTUR_ORDER = Me.Columns("TUCTUR_ORDER")
            Me.columnTUGRUA = Me.Columns("TUGRUA")
            Me.columnTUTIPL = Me.Columns("TUTIPL")
        End Sub
        
        Private Sub InitClass()
            Me.columnTUCTUR = New DataColumn("TUCTUR", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTUCTUR)
            Me.columnTUCTUR_ORDER = New DataColumn("TUCTUR_ORDER", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTUCTUR_ORDER)
            Me.columnTUGRUA = New DataColumn("TUGRUA", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTUGRUA)
            Me.columnTUTIPL = New DataColumn("TUTIPL", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTUTIPL)
            Me.columnTUCTUR.AllowDBNull = false
            Me.columnTUCTUR_ORDER.AllowDBNull = false
            Me.columnTUGRUA.AllowDBNull = false
            Me.columnTUTIPL.AllowDBNull = false
        End Sub
        
        Public Function NewATC_GruppiRow() As ATC_GruppiRow
            Return CType(Me.NewRow,ATC_GruppiRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ATC_GruppiRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ATC_GruppiRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ATC_GruppiRowChangedEvent) Is Nothing) Then
                RaiseEvent ATC_GruppiRowChanged(Me, New ATC_GruppiRowChangeEvent(CType(e.Row,ATC_GruppiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ATC_GruppiRowChangingEvent) Is Nothing) Then
                RaiseEvent ATC_GruppiRowChanging(Me, New ATC_GruppiRowChangeEvent(CType(e.Row,ATC_GruppiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ATC_GruppiRowDeletedEvent) Is Nothing) Then
                RaiseEvent ATC_GruppiRowDeleted(Me, New ATC_GruppiRowChangeEvent(CType(e.Row,ATC_GruppiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ATC_GruppiRowDeletingEvent) Is Nothing) Then
                RaiseEvent ATC_GruppiRowDeleting(Me, New ATC_GruppiRowChangeEvent(CType(e.Row,ATC_GruppiRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveATC_GruppiRow(ByVal row As ATC_GruppiRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ATC_GruppiRow
        Inherits DataRow
        
        Private tableATC_Gruppi As ATC_GruppiDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableATC_Gruppi = CType(Me.Table,ATC_GruppiDataTable)
        End Sub
        
        Public Property TUCTUR As String
            Get
                Return CType(Me(Me.tableATC_Gruppi.TUCTURColumn),String)
            End Get
            Set
                Me(Me.tableATC_Gruppi.TUCTURColumn) = value
            End Set
        End Property
        
        Public Property TUCTUR_ORDER As Long
            Get
                Return CType(Me(Me.tableATC_Gruppi.TUCTUR_ORDERColumn),Long)
            End Get
            Set
                Me(Me.tableATC_Gruppi.TUCTUR_ORDERColumn) = value
            End Set
        End Property
        
        Public Property TUGRUA As String
            Get
                Return CType(Me(Me.tableATC_Gruppi.TUGRUAColumn),String)
            End Get
            Set
                Me(Me.tableATC_Gruppi.TUGRUAColumn) = value
            End Set
        End Property
        
        Public Property TUTIPL As String
            Get
                Return CType(Me(Me.tableATC_Gruppi.TUTIPLColumn),String)
            End Get
            Set
                Me(Me.tableATC_Gruppi.TUTIPLColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ATC_GruppiRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ATC_GruppiRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ATC_GruppiRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ATC_GruppiRow
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
