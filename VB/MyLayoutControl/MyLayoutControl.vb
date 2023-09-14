' Developer Express Code Central Example:
' How to place controls in a LayoutControl's tabbed group header
' 
' By default, it is not possible to place any control within a tabbed group
' header, because the LayoutControl's layout can be widely customized (groups can
' be moved and hidden, their direction can be changed). However, you can emulate
' controls by custom drawing them. This example demonstrates how to draw a
' CheckBox and ProgressBar in headers.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2811
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing
Imports System.Runtime.InteropServices

Namespace WindowsApplication1

    <System.ComponentModel.DesignerCategory("")>
    Public Class MyLayoutControl
        Inherits LayoutControl

        Private _GroupItems As Dictionary(Of TabbedGroup, InplaceEditorInfo()) = New Dictionary(Of TabbedGroup, InplaceEditorInfo())()

        Public Property TabGroupItems As Dictionary(Of TabbedGroup, InplaceEditorInfo())
            Get
                Return _GroupItems
            End Get

            Set(ByVal value As Dictionary(Of TabbedGroup, InplaceEditorInfo()))
                _GroupItems = value
            End Set
        End Property

        Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
            Return New MyLayoutControlImplementor(Me)
        End Function

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            CheckCustomEditorsClick(e)
        End Sub

        Private Function FindEditorInfo(ByVal location As Point, <Out> ByRef key As TabbedGroup, <Out> ByRef resultInfo As InplaceEditorInfo) As Boolean
            key = Nothing
            resultInfo = Nothing
            For Each pair As KeyValuePair(Of TabbedGroup, InplaceEditorInfo()) In TabGroupItems
                For Each info As InplaceEditorInfo In pair.Value
                    If info.Bounds.Contains(location) Then
                        key = pair.Key
                        resultInfo = info
                        Return True
                    End If
                Next
            Next

            Return False
        End Function

        Private Sub CheckCustomEditorsClick(ByVal e As MouseEventArgs)
            Dim key As TabbedGroup
            Dim resultInfo As InplaceEditorInfo
            If FindEditorInfo(e.Location, key, resultInfo) Then OnEditorClick(key, resultInfo)
        End Sub

        Private Sub OnEditorClick(ByVal group As TabbedGroup, ByVal info As InplaceEditorInfo)
            info.RaiseMouseDown()
            Refresh()
        End Sub
    End Class
End Namespace
