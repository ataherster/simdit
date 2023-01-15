Option Strict Off
Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel

Public Class Laporan
    Inherits ReportClass

    Private vResourceName As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Property ResourceName() As String
        Get
            Return vResourceName
        End Get
        Set(ByVal value As String)
            vResourceName = value
        End Set
    End Property

End Class