<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [DrawEditorHelper.cs](./CS/MyLayoutControl/DrawEditorHelper.cs) (VB: [DrawEditorHelper.vb](./VB/MyLayoutControl/DrawEditorHelper.vb))
* [InplaceEditorInfo.cs](./CS/MyLayoutControl/InplaceEditorInfo.cs) (VB: [InplaceEditorInfo.vb](./VB/MyLayoutControl/InplaceEditorInfo.vb))
* [MyLayoutControl.cs](./CS/MyLayoutControl/MyLayoutControl.cs) (VB: [MyLayoutControlImplementor.vb](./VB/MyLayoutControl/MyLayoutControlImplementor.vb))
* [MyLayoutControlImplementor.cs](./CS/MyLayoutControl/MyLayoutControlImplementor.cs) (VB: [MyLayoutControlImplementor.vb](./VB/MyLayoutControl/MyLayoutControlImplementor.vb))
* [MyLayoutSkinPaintStyle.cs](./CS/MyLayoutControl/MyLayoutSkinPaintStyle.cs) (VB: [MyLayoutSkinPaintStyle.vb](./VB/MyLayoutControl/MyLayoutSkinPaintStyle.vb))
* [MyTabbedGroupPainter.cs](./CS/MyLayoutControl/MyTabbedGroupPainter.cs) (VB: [MyTabbedGroupPainter.vb](./VB/MyLayoutControl/MyTabbedGroupPainter.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to place controls in a LayoutControl's tabbed group header 


<p><br />
By default, it is not possible to place any control within a tabbed group header, because the LayoutControl's layout can be widely customized (groups can be moved and hidden, their direction can be changed). However, you can emulate controls by custom drawing them. This example demonstrates how to draw a CheckBox and ProgressBar in headers.</p>

<br/>


