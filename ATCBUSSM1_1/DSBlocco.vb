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
Public Class DSBlocco
    Inherits DataSet
    
    Private tableATC_Utenti As ATC_UtentiDataTable
    
    Private tableAccertatori_BloccoCambioGiornaliero As Accertatori_BloccoCambioGiornalieroDataTable
    
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
            If (Not (ds.Tables("ATC_Utenti")) Is Nothing) Then
                Me.Tables.Add(New ATC_UtentiDataTable(ds.Tables("ATC_Utenti")))
            End If
            If (Not (ds.Tables("Accertatori_BloccoCambioGiornaliero")) Is Nothing) Then
                Me.Tables.Add(New Accertatori_BloccoCambioGiornalieroDataTable(ds.Tables("Accertatori_BloccoCambioGiornaliero")))
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
    Public ReadOnly Property ATC_Utenti As ATC_UtentiDataTable
        Get
            Return Me.tableATC_Utenti
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Accertatori_BloccoCambioGiornaliero As Accertatori_BloccoCambioGiornalieroDataTable
        Get
            Return Me.tableAccertatori_BloccoCambioGiornaliero
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSBlocco = CType(MyBase.Clone,DSBlocco)
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
        If (Not (ds.Tables("ATC_Utenti")) Is Nothing) Then
            Me.Tables.Add(New ATC_UtentiDataTable(ds.Tables("ATC_Utenti")))
        End If
        If (Not (ds.Tables("Accertatori_BloccoCambioGiornaliero")) Is Nothing) Then
            Me.Tables.Add(New Accertatori_BloccoCambioGiornalieroDataTable(ds.Tables("Accertatori_BloccoCambioGiornaliero")))
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
        Me.tableATC_Utenti = CType(Me.Tables("ATC_Utenti"),ATC_UtentiDataTable)
        If (Not (Me.tableATC_Utenti) Is Nothing) Then
            Me.tableATC_Utenti.InitVars
        End If
        Me.tableAccertatori_BloccoCambioGiornaliero = CType(Me.Tables("Accertatori_BloccoCambioGiornaliero"),Accertatori_BloccoCambioGiornalieroDataTable)
        If (Not (Me.tableAccertatori_BloccoCambioGiornaliero) Is Nothing) Then
            Me.tableAccertatori_BloccoCambioGiornaliero.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSBlocco"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSBlocco.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableATC_Utenti = New ATC_UtentiDataTable
        Me.Tables.Add(Me.tableATC_Utenti)
        Me.tableAccertatori_BloccoCambioGiornaliero = New Accertatori_BloccoCambioGiornalieroDataTable
        Me.Tables.Add(Me.tableAccertatori_BloccoCambioGiornaliero)
    End Sub
    
    Private Function ShouldSerializeATC_Utenti() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeAccertatori_BloccoCambioGiornaliero() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ATC_UtentiRowChangeEventHandler(ByVal sender As Object, ByVal e As ATC_UtentiRowChangeEvent)
    
    Public Delegate Sub Accertatori_BloccoCambioGiornalieroRowChangeEventHandler(ByVal sender As Object, ByVal e As Accertatori_BloccoCambioGiornalieroRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ATC_UtentiDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnCognomeNome As DataColumn
        
        Friend Sub New()
            MyBase.New("ATC_Utenti")
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
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property CognomeNomeColumn As DataColumn
            Get
                Return Me.columnCognomeNome
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ATC_UtentiRow
            Get
                Return CType(Me.Rows(index),ATC_UtentiRow)
            End Get
        End Property
        
        Public Event ATC_UtentiRowChanged As ATC_UtentiRowChangeEventHandler
        
        Public Event ATC_UtentiRowChanging As ATC_UtentiRowChangeEventHandler
        
        Public Event ATC_UtentiRowDeleted As ATC_UtentiRowChangeEventHandler
        
        Public Event ATC_UtentiRowDeleting As ATC_UtentiRowChangeEventHandler
        
        Public Overloads Sub AddATC_UtentiRow(ByVal row As ATC_UtentiRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddATC_UtentiRow(ByVal CognomeNome As String) As ATC_UtentiRow
            Dim rowATC_UtentiRow As ATC_UtentiRow = CType(Me.NewRow,ATC_UtentiRow)
            rowATC_UtentiRow.ItemArray = New Object() {Nothing, CognomeNome}
            Me.Rows.Add(rowATC_UtentiRow)
            Return rowATC_UtentiRow
        End Function
        
        Public Function FindByID(ByVal ID As Integer) As ATC_UtentiRow
            Return CType(Me.Rows.Find(New Object() {ID}),ATC_UtentiRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ATC_UtentiDataTable = CType(MyBase.Clone,ATC_UtentiDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ATC_UtentiDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnCognomeNome = Me.Columns("CognomeNome")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnCognomeNome = New DataColumn("CognomeNome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCognomeNome)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AutoIncrement = true
            Me.columnID.AllowDBNull = false
            Me.columnID.ReadOnly = true
            Me.columnID.Unique = true
            Me.columnCognomeNome.ReadOnly = true
        End Sub
        
        Public Function NewATC_UtentiRow() As ATC_UtentiRow
            Return CType(Me.NewRow,ATC_UtentiRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ATC_UtentiRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ATC_UtentiRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ATC_UtentiRowChangedEvent) Is Nothing) Then
                RaiseEvent ATC_UtentiRowChanged(Me, New ATC_UtentiRowChangeEvent(CType(e.Row,ATC_UtentiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ATC_UtentiRowChangingEvent) Is Nothing) Then
                RaiseEvent ATC_UtentiRowChanging(Me, New ATC_UtentiRowChangeEvent(CType(e.Row,ATC_UtentiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ATC_UtentiRowDeletedEvent) Is Nothing) Then
                RaiseEvent ATC_UtentiRowDeleted(Me, New ATC_UtentiRowChangeEvent(CType(e.Row,ATC_UtentiRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ATC_UtentiRowDeletingEvent) Is Nothing) Then
                RaiseEvent ATC_UtentiRowDeleting(Me, New ATC_UtentiRowChangeEvent(CType(e.Row,ATC_UtentiRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveATC_UtentiRow(ByVal row As ATC_UtentiRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ATC_UtentiRow
        Inherits DataRow
        
        Private tableATC_Utenti As ATC_UtentiDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableATC_Utenti = CType(Me.Table,ATC_UtentiDataTable)
        End Sub
        
        Public Property ID As Integer
            Get
                Return CType(Me(Me.tableATC_Utenti.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableATC_Utenti.IDColumn) = value
            End Set
        End Property
        
        Public Property CognomeNome As String
            Get
                Try 
                    Return CType(Me(Me.tableATC_Utenti.CognomeNomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableATC_Utenti.CognomeNomeColumn) = value
            End Set
        End Property
        
        Public Function IsCognomeNomeNull() As Boolean
            Return Me.IsNull(Me.tableATC_Utenti.CognomeNomeColumn)
        End Function
        
        Public Sub SetCognomeNomeNull()
            Me(Me.tableATC_Utenti.CognomeNomeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ATC_UtentiRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ATC_UtentiRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ATC_UtentiRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ATC_UtentiRow
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
    Public Class Accertatori_BloccoCambioGiornalieroDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnAccertatoreId As DataColumn
        
        Private columnCognomeNome As DataColumn
        
        Private columnAggiornamentoOn As DataColumn
        
        Private columnInizioOn As DataColumn
        
        Private columnFineOn As DataColumn
        
        Private columnMotivo As DataColumn
        
        Private columnIdInizioBy As DataColumn
        
        Private columnIdFineBy As DataColumn
        
        Private columnStato As DataColumn
        
        Private columnInseritoDa As DataColumn
        
        Private columnTerminatoDa As DataColumn
        
        Friend Sub New()
            MyBase.New("Accertatori_BloccoCambioGiornaliero")
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
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property AccertatoreIdColumn As DataColumn
            Get
                Return Me.columnAccertatoreId
            End Get
        End Property
        
        Friend ReadOnly Property CognomeNomeColumn As DataColumn
            Get
                Return Me.columnCognomeNome
            End Get
        End Property
        
        Friend ReadOnly Property AggiornamentoOnColumn As DataColumn
            Get
                Return Me.columnAggiornamentoOn
            End Get
        End Property
        
        Friend ReadOnly Property InizioOnColumn As DataColumn
            Get
                Return Me.columnInizioOn
            End Get
        End Property
        
        Friend ReadOnly Property FineOnColumn As DataColumn
            Get
                Return Me.columnFineOn
            End Get
        End Property
        
        Friend ReadOnly Property MotivoColumn As DataColumn
            Get
                Return Me.columnMotivo
            End Get
        End Property
        
        Friend ReadOnly Property IdInizioByColumn As DataColumn
            Get
                Return Me.columnIdInizioBy
            End Get
        End Property
        
        Friend ReadOnly Property IdFineByColumn As DataColumn
            Get
                Return Me.columnIdFineBy
            End Get
        End Property
        
        Friend ReadOnly Property StatoColumn As DataColumn
            Get
                Return Me.columnStato
            End Get
        End Property
        
        Friend ReadOnly Property InseritoDaColumn As DataColumn
            Get
                Return Me.columnInseritoDa
            End Get
        End Property
        
        Friend ReadOnly Property TerminatoDaColumn As DataColumn
            Get
                Return Me.columnTerminatoDa
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Accertatori_BloccoCambioGiornalieroRow
            Get
                Return CType(Me.Rows(index),Accertatori_BloccoCambioGiornalieroRow)
            End Get
        End Property
        
        Public Event Accertatori_BloccoCambioGiornalieroRowChanged As Accertatori_BloccoCambioGiornalieroRowChangeEventHandler
        
        Public Event Accertatori_BloccoCambioGiornalieroRowChanging As Accertatori_BloccoCambioGiornalieroRowChangeEventHandler
        
        Public Event Accertatori_BloccoCambioGiornalieroRowDeleted As Accertatori_BloccoCambioGiornalieroRowChangeEventHandler
        
        Public Event Accertatori_BloccoCambioGiornalieroRowDeleting As Accertatori_BloccoCambioGiornalieroRowChangeEventHandler
        
        Public Overloads Sub AddAccertatori_BloccoCambioGiornalieroRow(ByVal row As Accertatori_BloccoCambioGiornalieroRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAccertatori_BloccoCambioGiornalieroRow(ByVal ID As System.Guid, ByVal AccertatoreId As Integer, ByVal CognomeNome As String, ByVal AggiornamentoOn As Date, ByVal InizioOn As Date, ByVal FineOn As Date, ByVal Motivo As String, ByVal IdInizioBy As Integer, ByVal IdFineBy As Integer, ByVal Stato As String, ByVal InseritoDa As String, ByVal TerminatoDa As String) As Accertatori_BloccoCambioGiornalieroRow
            Dim rowAccertatori_BloccoCambioGiornalieroRow As Accertatori_BloccoCambioGiornalieroRow = CType(Me.NewRow,Accertatori_BloccoCambioGiornalieroRow)
            rowAccertatori_BloccoCambioGiornalieroRow.ItemArray = New Object() {ID, AccertatoreId, CognomeNome, AggiornamentoOn, InizioOn, FineOn, Motivo, IdInizioBy, IdFineBy, Stato, InseritoDa, TerminatoDa}
            Me.Rows.Add(rowAccertatori_BloccoCambioGiornalieroRow)
            Return rowAccertatori_BloccoCambioGiornalieroRow
        End Function
        
        Public Function FindByID(ByVal ID As System.Guid) As Accertatori_BloccoCambioGiornalieroRow
            Return CType(Me.Rows.Find(New Object() {ID}),Accertatori_BloccoCambioGiornalieroRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Accertatori_BloccoCambioGiornalieroDataTable = CType(MyBase.Clone,Accertatori_BloccoCambioGiornalieroDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Accertatori_BloccoCambioGiornalieroDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnAccertatoreId = Me.Columns("AccertatoreId")
            Me.columnCognomeNome = Me.Columns("CognomeNome")
            Me.columnAggiornamentoOn = Me.Columns("AggiornamentoOn")
            Me.columnInizioOn = Me.Columns("InizioOn")
            Me.columnFineOn = Me.Columns("FineOn")
            Me.columnMotivo = Me.Columns("Motivo")
            Me.columnIdInizioBy = Me.Columns("IdInizioBy")
            Me.columnIdFineBy = Me.Columns("IdFineBy")
            Me.columnStato = Me.Columns("Stato")
            Me.columnInseritoDa = Me.Columns("InseritoDa")
            Me.columnTerminatoDa = Me.Columns("TerminatoDa")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnAccertatoreId = New DataColumn("AccertatoreId", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAccertatoreId)
            Me.columnCognomeNome = New DataColumn("CognomeNome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCognomeNome)
            Me.columnAggiornamentoOn = New DataColumn("AggiornamentoOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAggiornamentoOn)
            Me.columnInizioOn = New DataColumn("InizioOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInizioOn)
            Me.columnFineOn = New DataColumn("FineOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFineOn)
            Me.columnMotivo = New DataColumn("Motivo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMotivo)
            Me.columnIdInizioBy = New DataColumn("IdInizioBy", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdInizioBy)
            Me.columnIdFineBy = New DataColumn("IdFineBy", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdFineBy)
            Me.columnStato = New DataColumn("Stato", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStato)
            Me.columnInseritoDa = New DataColumn("InseritoDa", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInseritoDa)
            Me.columnTerminatoDa = New DataColumn("TerminatoDa", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTerminatoDa)
            Me.Constraints.Add(New UniqueConstraint("DSBloccoKey1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
            Me.columnCognomeNome.ReadOnly = true
        End Sub
        
        Public Function NewAccertatori_BloccoCambioGiornalieroRow() As Accertatori_BloccoCambioGiornalieroRow
            Return CType(Me.NewRow,Accertatori_BloccoCambioGiornalieroRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Accertatori_BloccoCambioGiornalieroRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Accertatori_BloccoCambioGiornalieroRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Accertatori_BloccoCambioGiornalieroRowChangedEvent) Is Nothing) Then
                RaiseEvent Accertatori_BloccoCambioGiornalieroRowChanged(Me, New Accertatori_BloccoCambioGiornalieroRowChangeEvent(CType(e.Row,Accertatori_BloccoCambioGiornalieroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Accertatori_BloccoCambioGiornalieroRowChangingEvent) Is Nothing) Then
                RaiseEvent Accertatori_BloccoCambioGiornalieroRowChanging(Me, New Accertatori_BloccoCambioGiornalieroRowChangeEvent(CType(e.Row,Accertatori_BloccoCambioGiornalieroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Accertatori_BloccoCambioGiornalieroRowDeletedEvent) Is Nothing) Then
                RaiseEvent Accertatori_BloccoCambioGiornalieroRowDeleted(Me, New Accertatori_BloccoCambioGiornalieroRowChangeEvent(CType(e.Row,Accertatori_BloccoCambioGiornalieroRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Accertatori_BloccoCambioGiornalieroRowDeletingEvent) Is Nothing) Then
                RaiseEvent Accertatori_BloccoCambioGiornalieroRowDeleting(Me, New Accertatori_BloccoCambioGiornalieroRowChangeEvent(CType(e.Row,Accertatori_BloccoCambioGiornalieroRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAccertatori_BloccoCambioGiornalieroRow(ByVal row As Accertatori_BloccoCambioGiornalieroRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Accertatori_BloccoCambioGiornalieroRow
        Inherits DataRow
        
        Private tableAccertatori_BloccoCambioGiornaliero As Accertatori_BloccoCambioGiornalieroDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAccertatori_BloccoCambioGiornaliero = CType(Me.Table,Accertatori_BloccoCambioGiornalieroDataTable)
        End Sub
        
        Public Property ID As System.Guid
            Get
                Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.IDColumn),System.Guid)
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.IDColumn) = value
            End Set
        End Property
        
        Public Property AccertatoreId As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.AccertatoreIdColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.AccertatoreIdColumn) = value
            End Set
        End Property
        
        Public Property CognomeNome As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.CognomeNomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.CognomeNomeColumn) = value
            End Set
        End Property
        
        Public Property AggiornamentoOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.AggiornamentoOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.AggiornamentoOnColumn) = value
            End Set
        End Property
        
        Public Property InizioOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.InizioOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.InizioOnColumn) = value
            End Set
        End Property
        
        Public Property FineOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.FineOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.FineOnColumn) = value
            End Set
        End Property
        
        Public Property Motivo As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.MotivoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.MotivoColumn) = value
            End Set
        End Property
        
        Public Property IdInizioBy As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdInizioByColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdInizioByColumn) = value
            End Set
        End Property
        
        Public Property IdFineBy As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdFineByColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdFineByColumn) = value
            End Set
        End Property
        
        Public Property Stato As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.StatoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.StatoColumn) = value
            End Set
        End Property
        
        Public Property InseritoDa As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.InseritoDaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.InseritoDaColumn) = value
            End Set
        End Property
        
        Public Property TerminatoDa As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_BloccoCambioGiornaliero.TerminatoDaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_BloccoCambioGiornaliero.TerminatoDaColumn) = value
            End Set
        End Property
        
        Public Function IsAccertatoreIdNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.AccertatoreIdColumn)
        End Function
        
        Public Sub SetAccertatoreIdNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.AccertatoreIdColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCognomeNomeNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.CognomeNomeColumn)
        End Function
        
        Public Sub SetCognomeNomeNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.CognomeNomeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAggiornamentoOnNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.AggiornamentoOnColumn)
        End Function
        
        Public Sub SetAggiornamentoOnNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.AggiornamentoOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInizioOnNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.InizioOnColumn)
        End Function
        
        Public Sub SetInizioOnNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.InizioOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFineOnNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.FineOnColumn)
        End Function
        
        Public Sub SetFineOnNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.FineOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMotivoNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.MotivoColumn)
        End Function
        
        Public Sub SetMotivoNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.MotivoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdInizioByNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.IdInizioByColumn)
        End Function
        
        Public Sub SetIdInizioByNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdInizioByColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdFineByNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.IdFineByColumn)
        End Function
        
        Public Sub SetIdFineByNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.IdFineByColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.StatoColumn)
        End Function
        
        Public Sub SetStatoNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.StatoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInseritoDaNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.InseritoDaColumn)
        End Function
        
        Public Sub SetInseritoDaNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.InseritoDaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTerminatoDaNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_BloccoCambioGiornaliero.TerminatoDaColumn)
        End Function
        
        Public Sub SetTerminatoDaNull()
            Me(Me.tableAccertatori_BloccoCambioGiornaliero.TerminatoDaColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Accertatori_BloccoCambioGiornalieroRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Accertatori_BloccoCambioGiornalieroRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Accertatori_BloccoCambioGiornalieroRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Accertatori_BloccoCambioGiornalieroRow
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
