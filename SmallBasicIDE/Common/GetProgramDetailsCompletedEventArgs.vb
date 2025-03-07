﻿Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics

Namespace Microsoft.SmallVisualBasic.com.smallbasic
    <GeneratedCode("System.Web.Services", "4.0.30319.1")>
    <DesignerCategory("code")>
    <DebuggerStepThrough>
    Public Class GetProgramDetailsCompletedEventArgs
        Inherits AsyncCompletedEventArgs

        Private results As Object()

        Public ReadOnly Property Result As ProgramDetails
            Get
                RaiseExceptionIfNecessary()
                Return CType(results(0), ProgramDetails)
            End Get
        End Property

        Friend Sub New(results As Object(), exception As Exception, cancelled As Boolean, userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
    End Class
End Namespace
