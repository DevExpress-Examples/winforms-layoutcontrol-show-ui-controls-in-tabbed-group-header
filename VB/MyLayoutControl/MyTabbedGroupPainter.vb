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
Imports DevExpress.XtraLayout.Painting
Imports DevExpress.XtraLayout.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1

    Public Class MyTabbedGroupPainter
        Inherits TabbedGroupPainter

        Public Sub New(ByVal lc As MyLayoutControl)
            _Lc = lc
        End Sub

        Private _Lc As MyLayoutControl

        Public Overrides Sub DrawObject(ByVal e As ObjectInfoArgs)
            MyBase.DrawObject(e)
            Dim vi As TabbedGroupViewInfo = TryCast(e, TabbedGroupViewInfo)
            Dim tab As DevExpress.XtraLayout.Tab.LayoutTab = vi.BorderInfo.Tab
            Dim tabViewInfo As SkinTabControlViewInfo = TryCast(tab.ViewInfo, SkinTabControlViewInfo)
            Dim bounds As Rectangle = CType(tabViewInfo, BaseTabControlViewInfo).HeaderInfo.AllPages.LastPage.Bounds
            bounds.Width += bounds.X
            bounds.X = 0
            If _Lc.TabGroupItems.ContainsKey(vi.Owner) Then
                Dim infos As InplaceEditorInfo() = _Lc.TabGroupItems(vi.Owner)
                For Each info As InplaceEditorInfo In infos
                    Dim checkBounds As Rectangle = GetItemBounds(vi.BoundsRelativeToControl, info.ItemSize, info.RightIndent)
                    info.Bounds = checkBounds
                    If bounds.IntersectsWith(info.Bounds) Then Return
                    DrawEdit(e.Graphics, info.Edit, info.Bounds, info.EditValue)
                Next
            End If
        End Sub

        Private Function GetItemBounds(ByVal boundsRelativeToControl As Rectangle, ByVal size As Size, ByVal rightIndent As Integer) As Rectangle
            Dim indent As Integer = 3
            Dim result As Rectangle = boundsRelativeToControl
            result.X = boundsRelativeToControl.Right - size.Width - indent - rightIndent
            result.Y += indent
            result.Width = size.Width
            result.Height = size.Height
            Return result
        End Function
    End Class
End Namespace
