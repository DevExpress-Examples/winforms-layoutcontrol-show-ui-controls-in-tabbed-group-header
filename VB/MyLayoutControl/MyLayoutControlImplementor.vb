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
