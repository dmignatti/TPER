Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class ListaModuliPortale
    Private m_Array As New System.Collections.ArrayList()

    '----------------------------------------------------------------------------------
    '------------------------------ PROPRIETA' ----------------------------------------
    '----------------------------------------------------------------------------------
    Public ReadOnly Property Count() As Integer
        Get
            Return m_Array.Count
        End Get
    End Property

    Public ReadOnly Property Item(ByVal iIndex As Integer) As ModuloPortale
        Get
            Return m_Array(iIndex)
        End Get
    End Property

    '----------------------------------------------------------------------------------
    '---------------------------------- METODI ----------------------------------------
    '----------------------------------------------------------------------------------
    Public Function Add(ByVal oModuloPortale As ModuloPortale)
        m_Array.Add(oModuloPortale)
    End Function

    Public Function Remove(ByVal iIndex As Integer)
        m_Array.RemoveAt(iIndex)
    End Function

    Public Function clear()
        m_Array.Clear()
    End Function

    Public Function IsPresent(ByVal oModuloPortale As ModuloPortale) As Boolean
        Return m_Array.Contains(oModuloPortale)
    End Function

    Public Function Fetch(ByVal oConn As SqlConnection)
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim fnc As New Funzioni()
        Dim sSQL As String = "select * from ATC_ModuliPortale WHERE Abilitato = 1 ORDER BY ID"
        cmd = New SqlCommand(sSQL, oConn)
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim oModuloPortale As New ModuloPortale()
            oModuloPortale.ID = dr.GetInt32(0)
            oModuloPortale.Descrizione = dr.GetString(1)
            oModuloPortale.Abilitato = dr.GetBoolean(2)
            oModuloPortale.CosaLancio = dr.GetString(3)
            m_Array.Add(oModuloPortale)
        End While
        dr.Close()
        cmd.Dispose()
    End Function

End Class
