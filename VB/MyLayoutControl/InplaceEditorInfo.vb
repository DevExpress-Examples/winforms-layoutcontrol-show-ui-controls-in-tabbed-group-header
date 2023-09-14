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
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1

    Public Class InplaceEditorInfo

        Public Sub New(ByVal edit As RepositoryItem, ByVal size As Size, ByVal value As Object)
            _Edit = edit
            _ItemSize = size
            _EditValue = value
        End Sub

        Private _Bounds As Rectangle

        Public Property Bounds As Rectangle
            Get
                Return _Bounds
            End Get

            Set(ByVal value As Rectangle)
                _Bounds = value
            End Set
        End Property

        Private _EditValue As Object

        Public Property EditValue As Object
            Get
                Return _EditValue
            End Get

            Set(ByVal value As Object)
                _EditValue = value
            End Set
        End Property

        Private _Edit As RepositoryItem

        Public Property Edit As RepositoryItem
            Get
                Return _Edit
            End Get

            Set(ByVal value As RepositoryItem)
                _Edit = value
            End Set
        End Property

        Private _ItemSize As Size

        Public Property ItemSize As Size
            Get
                Return _ItemSize
            End Get

            Set(ByVal value As Size)
                _ItemSize = value
            End Set
        End Property

        Private _RightIndent As Integer

        Public Property RightIndent As Integer
            Get
                Return _RightIndent
            End Get

            Set(ByVal value As Integer)
                _RightIndent = value
            End Set
        End Property

        Public Event MouseDown As EventHandler

        Public Sub RaiseMouseDown()
            RaiseEvent MouseDown(Me, New EventArgs())
        End Sub
    End Class
End Namespace
