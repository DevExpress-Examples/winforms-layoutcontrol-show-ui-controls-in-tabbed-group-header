// Developer Express Code Central Example:
// How to place controls in a LayoutControl's tabbed group header
// 
// By default, it is not possible to place any control within a tabbed group
// header, because the LayoutControl's layout can be widely customized (groups can
// be moved and hidden, their direction can be changed). However, you can emulate
// controls by custom drawing them. This example demonstrates how to draw a
// CheckBox and ProgressBar in headers.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2811

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout.Registrator;
using DevExpress.XtraLayout;
using DevExpress.LookAndFeel;
using DevExpress.XtraLayout.Painting;
using DevExpress.XtraLayout.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;

namespace WindowsApplication1
{
    public class MyLayoutSkinPaintStyle : LayoutSkinPaintStyle
    {
        private MyLayoutControl _LayoutControl;
        public MyLayoutSkinPaintStyle(ISupportLookAndFeel lookAndFeelOwner) : base(lookAndFeelOwner) 
        {
            _LayoutControl = lookAndFeelOwner as MyLayoutControl;

        }


        public override TabbedGroupPainter GetTabbedGroupPainter()
        {
            return new MyTabbedGroupPainter(_LayoutControl);
        }
    }
}