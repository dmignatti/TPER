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
Public Class DSApprovaPreno
    Inherits DataSet
    
    Private tableAccertatori_PrenotazioneRichiesta As Accertatori_PrenotazioneRichiestaDataTable
    
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
            If (Not (ds.Tables("Accertatori_PrenotazioneRichiesta")) Is Nothing) Then
                Me.Tables.Add(New Accertatori_PrenotazioneRichiestaDataTable(ds.Tables("Accertatori_PrenotazioneRichiesta")))
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
    Public ReadOnly Property Accertatori_PrenotazioneRichiesta As Accertatori_PrenotazioneRichiestaDataTable
        Get
            Return Me.tableAccertatori_PrenotazioneRichiesta
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSApprovaPreno = CType(MyBase.Clone,DSApprovaPreno)
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
        If (Not (ds.Tables("Accertatori_PrenotazioneRichiesta")) Is Nothing) Then
            Me.Tables.Add(New Accertatori_PrenotazioneRichiestaDataTable(ds.Tables("Accertatori_PrenotazioneRichiesta")))
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
        Me.tableAccertatori_PrenotazioneRichiesta = CType(Me.Tables("Accertatori_PrenotazioneRichiesta"),Accertatori_PrenotazioneRichiestaDataTable)
        If (Not (Me.tableAccertatori_PrenotazioneRichiesta) Is Nothing) Then
            Me.tableAccertatori_PrenotazioneRichiesta.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSApprovaPreno"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSApprovaPreno.xsd"
        Me.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAccertatori_PrenotazioneRichiesta = New Accertatori_PrenotazioneRichiestaDataTable
        Me.Tables.Add(Me.tableAccertatori_PrenotazioneRichiesta)
    End Sub
    
    Private Function ShouldSerializeAccertatori_PrenotazioneRichiesta() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Accertatori_PrenotazioneRichiestaRowChangeEventHandler(ByVal sender As Object, ByVal e As Accertatori_PrenotazioneRichiestaRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Accertatori_PrenotazioneRichiestaDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnAccertatoreId As DataColumn
        
        Private columnAccertatori_PrenotazioneIntervalliId As DataColumn
        
        Private columnStatoPrenotazione As DataColumn
        
        Private columnDataPrenotazione As DataColumn
        
        Private columnDataApprovazione As DataColumn
        
        Private columnIdApprovatore As DataColumn
        
        Private columnCreateOn As DataColumn
        
        Private columnModifiedOn As DataColumn
        
        Private columnCreatedBy As DataColumn
        
        Private columnModifiedBy As DataColumn
        
        Private columnmatricola As DataColumn
        
        Private columnCognomeNome As DataColumn
        
        Private columnNome As DataColumn
        
        Private columnApprovatore As DataColumn
        
        Private columnStatoApprovazione As DataColumn
        
        Friend Sub New()
            MyBase.New("Accertatori_PrenotazioneRichiesta")
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
        
        Friend ReadOnly Property Accertatori_PrenotazioneIntervalliIdColumn As DataColumn
            Get
                Return Me.columnAccertatori_PrenotazioneIntervalliId
            End Get
        End Property
        
        Friend ReadOnly Property StatoPrenotazioneColumn As DataColumn
            Get
                Return Me.columnStatoPrenotazione
            End Get
        End Property
        
        Friend ReadOnly Property DataPrenotazioneColumn As DataColumn
            Get
                Return Me.columnDataPrenotazione
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
        
        Friend ReadOnly Property CreateOnColumn As DataColumn
            Get
                Return Me.columnCreateOn
            End Get
        End Property
        
        Friend ReadOnly Property ModifiedOnColumn As DataColumn
            Get
                Return Me.columnModifiedOn
            End Get
        End Property
        
        Friend ReadOnly Property CreatedByColumn As DataColumn
            Get
                Return Me.columnCreatedBy
            End Get
        End Property
        
        Friend ReadOnly Property ModifiedByColumn As DataColumn
            Get
                Return Me.columnModifiedBy
            End Get
        End Property
        
        Friend ReadOnly Property matricolaColumn As DataColumn
            Get
                Return Me.columnmatricola
            End Get
        End Property
        
        Friend ReadOnly Property CognomeNomeColumn As DataColumn
            Get
                Return Me.columnCognomeNome
            End Get
        End Property
        
        Friend ReadOnly Property NomeColumn As DataColumn
            Get
                Return Me.columnNome
            End Get
        End Property
        
        Friend ReadOnly Property ApprovatoreColumn As DataColumn
            Get
                Return Me.columnApprovatore
            End Get
        End Property
        
        Friend ReadOnly Property StatoApprovazioneColumn As DataColumn
            Get
                Return Me.columnStatoApprovazione
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Accertatori_PrenotazioneRichiestaRow
            Get
                Return CType(Me.Rows(index),Accertatori_PrenotazioneRichiestaRow)
            End Get
        End Property
        
        Public Event Accertatori_PrenotazioneRichiestaRowChanged As Accertatori_PrenotazioneRichiestaRowChangeEventHandler
        
        Public Event Accertatori_PrenotazioneRichiestaRowChanging As Accertatori_PrenotazioneRichiestaRowChangeEventHandler
        
        Public Event Accertatori_PrenotazioneRichiestaRowDeleted As Accertatori_PrenotazioneRichiestaRowChangeEventHandler
        
        Public Event Accertatori_PrenotazioneRichiestaRowDeleting As Accertatori_PrenotazioneRichiestaRowChangeEventHandler
        
        Public Overloads Sub AddAccertatori_PrenotazioneRichiestaRow(ByVal row As Accertatori_PrenotazioneRichiestaRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAccertatori_PrenotazioneRichiestaRow( _
                    ByVal ID As System.Guid,  _
                    ByVal AccertatoreId As Integer,  _
                    ByVal Accertatori_PrenotazioneIntervalliId As System.Guid,  _
                    ByVal StatoPrenotazione As Integer,  _
                    ByVal DataPrenotazione As Date,  _
                    ByVal DataApprovazione As Date,  _
                    ByVal IdApprovatore As Integer,  _
                    ByVal CreateOn As Date,  _
                    ByVal ModifiedOn As Date,  _
                    ByVal CreatedBy As String,  _
                    ByVal ModifiedBy As String,  _
                    ByVal matricola As String,  _
                    ByVal CognomeNome As String,  _
                    ByVal Nome As String,  _
                    ByVal Approvatore As String,  _
                    ByVal StatoApprovazione As String) As Accertatori_PrenotazioneRichiestaRow
            Dim rowAccertatori_PrenotazioneRichiestaRow As Accertatori_PrenotazioneRichiestaRow = CType(Me.NewRow,Accertatori_PrenotazioneRichiestaRow)
            rowAccertatori_PrenotazioneRichiestaRow.ItemArray = New Object() {ID, AccertatoreId, Accertatori_PrenotazioneIntervalliId, StatoPrenotazione, DataPrenotazione, DataApprovazione, IdApprovatore, CreateOn, ModifiedOn, CreatedBy, ModifiedBy, matricola, CognomeNome, Nome, Approvatore, StatoApprovazione}
            Me.Rows.Add(rowAccertatori_PrenotazioneRichiestaRow)
            Return rowAccertatori_PrenotazioneRichiestaRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Accertatori_PrenotazioneRichiestaDataTable = CType(MyBase.Clone,Accertatori_PrenotazioneRichiestaDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Accertatori_PrenotazioneRichiestaDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnAccertatoreId = Me.Columns("AccertatoreId")
            Me.columnAccertatori_PrenotazioneIntervalliId = Me.Columns("Accertatori_PrenotazioneIntervalliId")
            Me.columnStatoPrenotazione = Me.Columns("StatoPrenotazione")
            Me.columnDataPrenotazione = Me.Columns("DataPrenotazione")
            Me.columnDataApprovazione = Me.Columns("DataApprovazione")
            Me.columnIdApprovatore = Me.Columns("IdApprovatore")
            Me.columnCreateOn = Me.Columns("CreateOn")
            Me.columnModifiedOn = Me.Columns("ModifiedOn")
            Me.columnCreatedBy = Me.Columns("CreatedBy")
            Me.columnModifiedBy = Me.Columns("ModifiedBy")
            Me.columnmatricola = Me.Columns("matricola")
            Me.columnCognomeNome = Me.Columns("CognomeNome")
            Me.columnNome = Me.Columns("Nome")
            Me.columnApprovatore = Me.Columns("Approvatore")
            Me.columnStatoApprovazione = Me.Columns("StatoApprovazione")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnAccertatoreId = New DataColumn("AccertatoreId", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAccertatoreId)
            Me.columnAccertatori_PrenotazioneIntervalliId = New DataColumn("Accertatori_PrenotazioneIntervalliId", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAccertatori_PrenotazioneIntervalliId)
            Me.columnStatoPrenotazione = New DataColumn("StatoPrenotazione", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStatoPrenotazione)
            Me.columnDataPrenotazione = New DataColumn("DataPrenotazione", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDataPrenotazione)
            Me.columnDataApprovazione = New DataColumn("DataApprovazione", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDataApprovazione)
            Me.columnIdApprovatore = New DataColumn("IdApprovatore", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdApprovatore)
            Me.columnCreateOn = New DataColumn("CreateOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCreateOn)
            Me.columnModifiedOn = New DataColumn("ModifiedOn", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnModifiedOn)
            Me.columnCreatedBy = New DataColumn("CreatedBy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCreatedBy)
            Me.columnModifiedBy = New DataColumn("ModifiedBy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnModifiedBy)
            Me.columnmatricola = New DataColumn("matricola", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmatricola)
            Me.columnCognomeNome = New DataColumn("CognomeNome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCognomeNome)
            Me.columnNome = New DataColumn("Nome", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNome)
            Me.columnApprovatore = New DataColumn("Approvatore", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnApprovatore)
            Me.columnStatoApprovazione = New DataColumn("StatoApprovazione", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStatoApprovazione)
            Me.columnID.AllowDBNull = false
            Me.columnCognomeNome.ReadOnly = true
            Me.columnApprovatore.ReadOnly = true
        End Sub
        
        Public Function NewAccertatori_PrenotazioneRichiestaRow() As Accertatori_PrenotazioneRichiestaRow
            Return CType(Me.NewRow,Accertatori_PrenotazioneRichiestaRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Accertatori_PrenotazioneRichiestaRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Accertatori_PrenotazioneRichiestaRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Accertatori_PrenotazioneRichiestaRowChangedEvent) Is Nothing) Then
                RaiseEvent Accertatori_PrenotazioneRichiestaRowChanged(Me, New Accertatori_PrenotazioneRichiestaRowChangeEvent(CType(e.Row,Accertatori_PrenotazioneRichiestaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Accertatori_PrenotazioneRichiestaRowChangingEvent) Is Nothing) Then
                RaiseEvent Accertatori_PrenotazioneRichiestaRowChanging(Me, New Accertatori_PrenotazioneRichiestaRowChangeEvent(CType(e.Row,Accertatori_PrenotazioneRichiestaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Accertatori_PrenotazioneRichiestaRowDeletedEvent) Is Nothing) Then
                RaiseEvent Accertatori_PrenotazioneRichiestaRowDeleted(Me, New Accertatori_PrenotazioneRichiestaRowChangeEvent(CType(e.Row,Accertatori_PrenotazioneRichiestaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Accertatori_PrenotazioneRichiestaRowDeletingEvent) Is Nothing) Then
                RaiseEvent Accertatori_PrenotazioneRichiestaRowDeleting(Me, New Accertatori_PrenotazioneRichiestaRowChangeEvent(CType(e.Row,Accertatori_PrenotazioneRichiestaRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAccertatori_PrenotazioneRichiestaRow(ByVal row As Accertatori_PrenotazioneRichiestaRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Accertatori_PrenotazioneRichiestaRow
        Inherits DataRow
        
        Private tableAccertatori_PrenotazioneRichiesta As Accertatori_PrenotazioneRichiestaDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAccertatori_PrenotazioneRichiesta = CType(Me.Table,Accertatori_PrenotazioneRichiestaDataTable)
        End Sub
        
        Public Property ID As System.Guid
            Get
                Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.IDColumn),System.Guid)
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.IDColumn) = value
            End Set
        End Property
        
        Public Property AccertatoreId As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.AccertatoreIdColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.AccertatoreIdColumn) = value
            End Set
        End Property
        
        Public Property Accertatori_PrenotazioneIntervalliId As System.Guid
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliIdColumn),System.Guid)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliIdColumn) = value
            End Set
        End Property
        
        Public Property StatoPrenotazione As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoPrenotazioneColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoPrenotazioneColumn) = value
            End Set
        End Property
        
        Public Property DataPrenotazione As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.DataPrenotazioneColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.DataPrenotazioneColumn) = value
            End Set
        End Property
        
        Public Property DataApprovazione As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.DataApprovazioneColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.DataApprovazioneColumn) = value
            End Set
        End Property
        
        Public Property IdApprovatore As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.IdApprovatoreColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.IdApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property CreateOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.CreateOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.CreateOnColumn) = value
            End Set
        End Property
        
        Public Property ModifiedOn As Date
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedOnColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedOnColumn) = value
            End Set
        End Property
        
        Public Property CreatedBy As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.CreatedByColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.CreatedByColumn) = value
            End Set
        End Property
        
        Public Property ModifiedBy As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedByColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedByColumn) = value
            End Set
        End Property
        
        Public Property matricola As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.matricolaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.matricolaColumn) = value
            End Set
        End Property
        
        Public Property CognomeNome As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.CognomeNomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.CognomeNomeColumn) = value
            End Set
        End Property
        
        Public Property Nome As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.NomeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.NomeColumn) = value
            End Set
        End Property
        
        Public Property Approvatore As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.ApprovatoreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.ApprovatoreColumn) = value
            End Set
        End Property
        
        Public Property StatoApprovazione As String
            Get
                Try 
                    Return CType(Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoApprovazioneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoApprovazioneColumn) = value
            End Set
        End Property
        
        Public Function IsAccertatoreIdNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.AccertatoreIdColumn)
        End Function
        
        Public Sub SetAccertatoreIdNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.AccertatoreIdColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAccertatori_PrenotazioneIntervalliIdNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliIdColumn)
        End Function
        
        Public Sub SetAccertatori_PrenotazioneIntervalliIdNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.Accertatori_PrenotazioneIntervalliIdColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoPrenotazioneNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.StatoPrenotazioneColumn)
        End Function
        
        Public Sub SetStatoPrenotazioneNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoPrenotazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataPrenotazioneNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.DataPrenotazioneColumn)
        End Function
        
        Public Sub SetDataPrenotazioneNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.DataPrenotazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDataApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.DataApprovazioneColumn)
        End Function
        
        Public Sub SetDataApprovazioneNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.DataApprovazioneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsIdApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.IdApprovatoreColumn)
        End Function
        
        Public Sub SetIdApprovatoreNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.IdApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCreateOnNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.CreateOnColumn)
        End Function
        
        Public Sub SetCreateOnNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.CreateOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsModifiedOnNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedOnColumn)
        End Function
        
        Public Sub SetModifiedOnNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedOnColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCreatedByNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.CreatedByColumn)
        End Function
        
        Public Sub SetCreatedByNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.CreatedByColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsModifiedByNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedByColumn)
        End Function
        
        Public Sub SetModifiedByNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.ModifiedByColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsmatricolaNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.matricolaColumn)
        End Function
        
        Public Sub SetmatricolaNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.matricolaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCognomeNomeNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.CognomeNomeColumn)
        End Function
        
        Public Sub SetCognomeNomeNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.CognomeNomeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNomeNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.NomeColumn)
        End Function
        
        Public Sub SetNomeNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.NomeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsApprovatoreNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.ApprovatoreColumn)
        End Function
        
        Public Sub SetApprovatoreNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.ApprovatoreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStatoApprovazioneNull() As Boolean
            Return Me.IsNull(Me.tableAccertatori_PrenotazioneRichiesta.StatoApprovazioneColumn)
        End Function
        
        Public Sub SetStatoApprovazioneNull()
            Me(Me.tableAccertatori_PrenotazioneRichiesta.StatoApprovazioneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Accertatori_PrenotazioneRichiestaRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Accertatori_PrenotazioneRichiestaRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Accertatori_PrenotazioneRichiestaRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Accertatori_PrenotazioneRichiestaRow
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
