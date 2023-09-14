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
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.XtraLayout
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1

    Public Class MyLayoutControlImplementor
        Inherits LayoutControlImplementor

        Public Sub New(ByVal owner As ILayoutControlOwner)
            MyBase.New(owner)
        End Sub

        Protected Overrides Sub InitializePaintStyles()
            Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
            If lookAndFeelOwner IsNot Nothing Then
                PaintStyles.Add(New LayoutOffice2003PaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New MyLayoutSkinPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New Style3DPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New UltraFlatPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New FlatPaintStyle(lookAndFeelOwner))
            End If

            lookAndFeelOwner = Nothing
        End Sub
    End Class
End Namespace
