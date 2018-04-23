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
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.XtraLayout
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins

Namespace WindowsApplication1
    Public Class MyLayoutSkinPaintStyle
        Inherits LayoutSkinPaintStyle

        Private _LayoutControl As MyLayoutControl
        Public Sub New(ByVal lookAndFeelOwner As ISupportLookAndFeel)
            MyBase.New(lookAndFeelOwner)
            _LayoutControl = TryCast(lookAndFeelOwner, MyLayoutControl)

        End Sub


        Public Overrides Function GetTabbedGroupPainter() As TabbedGroupPainter
            Return New MyTabbedGroupPainter(_LayoutControl)
        End Function
    End Class
End Namespace