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
