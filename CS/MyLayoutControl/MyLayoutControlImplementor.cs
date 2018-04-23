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
    public class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }
        protected override void InitializePaintStyles()
        {
            ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
            if (lookAndFeelOwner != null)
            {
                PaintStyles.Add(new LayoutOffice2003PaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new LayoutWindowsXPPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new MyLayoutSkinPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new Style3DPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new UltraFlatPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new FlatPaintStyle(lookAndFeelOwner));
            }
            lookAndFeelOwner = null;
        }
    }
}
