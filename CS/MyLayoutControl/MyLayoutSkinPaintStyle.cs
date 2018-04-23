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