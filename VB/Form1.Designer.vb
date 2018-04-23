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

Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.myLayoutControl1 = New WindowsApplication1.MyLayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabbedControlGroup2 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.simpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            DirectCast(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.myLayoutControl1.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.simpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myLayoutControl1
            ' 
            Me.myLayoutControl1.Controls.Add(Me.labelControl1)
            Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.myLayoutControl1.Name = "myLayoutControl1"
            Me.myLayoutControl1.Root = Me.layoutControlGroup1
            Me.myLayoutControl1.Size = New System.Drawing.Size(606, 427)
            Me.myLayoutControl1.TabIndex = 0
            Me.myLayoutControl1.Text = "myLayoutControl1"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(24, 134)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(558, 13)
            Me.labelControl1.StyleController = Me.myLayoutControl1
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.tabbedControlGroup1, Me.tabbedControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(606, 427)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 89)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup7
            Me.tabbedControlGroup1.SelectedTabPageIndex = 1
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(586, 318)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup7})
            Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.CustomizationFormText = "layoutControlGroup7"
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(562, 273)
            Me.layoutControlGroup7.Text = "layoutControlGroup7"
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.Red
            Me.layoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(562, 273)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.Red
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseBackColor = True
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(562, 273)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' tabbedControlGroup2
            ' 
            Me.tabbedControlGroup2.CustomizationFormText = "tabbedControlGroup2"
            Me.tabbedControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup2.Name = "tabbedControlGroup2"
            Me.tabbedControlGroup2.SelectedTabPage = Me.layoutControlGroup6
            Me.tabbedControlGroup2.SelectedTabPageIndex = 0
            Me.tabbedControlGroup2.Size = New System.Drawing.Size(586, 89)
            Me.tabbedControlGroup2.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup6, Me.layoutControlGroup3})
            Me.tabbedControlGroup2.Text = "tabbedControlGroup2"
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6"
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleLabelItem3})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(562, 44)
            Me.layoutControlGroup6.Text = "layoutControlGroup6"
            ' 
            ' simpleLabelItem3
            ' 
            Me.simpleLabelItem3.CustomizationFormText = "LabelsimpleLabelItem3"
            Me.simpleLabelItem3.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem3.Name = "simpleLabelItem3"
            Me.simpleLabelItem3.Size = New System.Drawing.Size(562, 44)
            Me.simpleLabelItem3.Text = "LabelsimpleLabelItem3"
            Me.simpleLabelItem3.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(562, 44)
            Me.layoutControlGroup3.Text = "layoutControlGroup3"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(606, 427)
            Me.Controls.Add(Me.myLayoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.myLayoutControl1.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.simpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myLayoutControl1 As MyLayoutControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private tabbedControlGroup2 As DevExpress.XtraLayout.TabbedControlGroup
        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Private simpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup


    End Class
End Namespace

