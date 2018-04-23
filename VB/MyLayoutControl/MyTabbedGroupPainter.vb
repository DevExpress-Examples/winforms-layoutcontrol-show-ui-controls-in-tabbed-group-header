Imports Microsoft.VisualBasic
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
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
	Public Class MyTabbedGroupPainter
		Inherits TabbedGroupPainter
		Public Sub New(ByVal lc As MyLayoutControl)
			_Lc = lc
		End Sub

		Private _Lc As MyLayoutControl


		Public Overrides Overloads Sub DrawObject(ByVal e As ObjectInfoArgs)
			MyBase.DrawObject(e)
			Dim vi As TabbedGroupViewInfo = TryCast(e, TabbedGroupViewInfo)
			Dim tab As DevExpress.XtraLayout.Tab.LayoutTab = vi.BorderInfo.Tab
			Dim tabViewInfo As SkinTabControlViewInfo = TryCast(tab.ViewInfo, SkinTabControlViewInfo)
			Dim bounds As Rectangle = (CType(tabViewInfo, BaseTabControlViewInfo)).HeaderInfo.AllPages.LastPage.Bounds
			bounds.Width += bounds.X
			bounds.X = 0
			If _Lc.TabGroupItems.ContainsKey(vi.Owner) Then
				Dim infos() As InplaceEditorInfo = _Lc.TabGroupItems(vi.Owner)
				For Each info As InplaceEditorInfo In infos
					Dim checkBounds As Rectangle = GetItemBounds(vi.BoundsRelativeToControl, info.ItemSize, info.RightIndent)
					info.Bounds = checkBounds
					If bounds.IntersectsWith(info.Bounds) Then
						Return
					End If
					DrawEditorHelper.DrawEdit(e.Graphics, info.Edit, info.Bounds, info.EditValue)
				Next info
			End If
		End Sub
		Private Function GetItemBounds(ByVal boundsRelativeToControl As Rectangle, ByVal size As Size, ByVal rightIndent As Integer) As Rectangle
			Dim indent As Integer= 3
			Dim result As Rectangle = boundsRelativeToControl
			result.X = boundsRelativeToControl.Right - size.Width - indent - rightIndent
			result.Y += indent
			result.Width = size.Width
			result.Height = size.Height
			Return result
		End Function

	End Class
End Namespace