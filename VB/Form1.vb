Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports System.ComponentModel
Imports DevExpress.XtraLayout
Imports System.Diagnostics

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Dim checkInfo As New InplaceEditorInfo(New RepositoryItemCheckEdit(), New Size(20, 20), True)
			AddHandler checkInfo.MouseDown, AddressOf checkInfo_MouseDown
			Dim riBE As New RepositoryItemButtonEdit()
			Dim buttonInfo As New InplaceEditorInfo(riBE, New Size(30, 20), Nothing)
			riBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			riBE.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
			riBE.Buttons(0).Caption = "Test"
			riBE.AutoHeight = False
			AddHandler buttonInfo.MouseDown, AddressOf buttonInfo_MouseDown
			buttonInfo.RightIndent = 25
			Dim riHE As New RepositoryItemHyperLinkEdit()
			Dim hyperLinkInfo As New InplaceEditorInfo(riHE, New Size(120, 20), "http://devexpress.com/")
			hyperLinkInfo.RightIndent = 60
			riHE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			AddHandler hyperLinkInfo.MouseDown, AddressOf hyperLinkInfo_MouseDown
			myLayoutControl1.TabGroupItems.Add(tabbedControlGroup1, New InplaceEditorInfo() { checkInfo, buttonInfo, hyperLinkInfo })
			Dim progressBarInfo As New InplaceEditorInfo(New RepositoryItemProgressBar(), New Size(40, 20), 10)
			AddHandler progressBarInfo.MouseDown, AddressOf progressBarInfo_MouseDown
			checkInfo = New InplaceEditorInfo(New RepositoryItemCheckEdit(), New Size(20, 20), True)
			AddHandler checkInfo.MouseDown, AddressOf checkInfo_MouseDown
			checkInfo.RightIndent = 40
			myLayoutControl1.TabGroupItems.Add(tabbedControlGroup2, New InplaceEditorInfo() { progressBarInfo, checkInfo })

		End Sub

		Private Sub hyperLinkInfo_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
			Dim info As InplaceEditorInfo = TryCast(sender, InplaceEditorInfo)
			Process.Start(info.EditValue.ToString())
		End Sub

		Private Sub buttonInfo_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Test")
		End Sub

		Private r As New Random()
		Private Sub progressBarInfo_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
			Dim info As InplaceEditorInfo = TryCast(sender, InplaceEditorInfo)
			info.EditValue = 10 + r.Next(80)
		End Sub

		Private Sub checkInfo_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
			Dim info As InplaceEditorInfo = TryCast(sender, InplaceEditorInfo)
			If True.Equals(info.EditValue) Then
				info.EditValue = False
			Else
				info.EditValue = True
			End If
		End Sub

	End Class
End Namespace