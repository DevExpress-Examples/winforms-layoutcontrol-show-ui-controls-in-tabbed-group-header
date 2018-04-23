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
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
    Public NotInheritable Class DrawEditorHelper

        Private Sub New()
        End Sub



        Public Shared Sub DrawEdit(ByVal g As Graphics, ByVal edit As RepositoryItem, ByVal r As Rectangle, ByVal value As Object)
            Dim info As BaseEditViewInfo = TryCast(edit.CreateViewInfo(), BaseEditViewInfo)
            Dim painter As BaseEditPainter = edit.CreatePainter()
            info.EditValue = value
            info.Bounds = r
            info.CalcViewInfo(g)
            Dim args As New ControlGraphicsInfoArgs(info, New GraphicsCache(g), r)
            painter.Draw(args)
            args.Cache.Dispose()
        End Sub
    End Class
End Namespace
