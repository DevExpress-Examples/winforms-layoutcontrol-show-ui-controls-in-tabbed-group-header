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