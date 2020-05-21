Imports System
Imports System.Data

Public Class ModuloPortale
    Private m_ID As Integer
    Private m_Descrizione As String
    Private m_Abilitato As Boolean
    Private m_CosaLancio As String

    Public Sub New()
        MyBase.New()
    End Sub

    '----------------------------------------------------------------------------------
    '------------------------------ PROPRIETA' ----------------------------------------
    '----------------------------------------------------------------------------------
    Public Property ID() As Integer
        Get
            Return m_ID
        End Get

        Set(ByVal Value As Integer)
            m_ID = Value
        End Set
    End Property

    Public Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get

        Set(ByVal Value As String)
            m_Descrizione = Trim(Value)
        End Set
    End Property

    Public Property Abilitato() As Boolean
        Get
            Return m_Abilitato
        End Get

        Set(ByVal Value As Boolean)
            m_Abilitato = Value
        End Set
    End Property

    Public Property CosaLancio() As String
        Get
            Return m_CosaLancio
        End Get

        Set(ByVal Value As String)
            m_CosaLancio = Trim(Value)
        End Set
    End Property


End Class
