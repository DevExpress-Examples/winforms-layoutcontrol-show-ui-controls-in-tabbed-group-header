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
using DevExpress.Utils;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab.ViewInfo;

namespace WindowsApplication1
{
    public class MyTabbedGroupPainter : TabbedGroupPainter
    {
        public MyTabbedGroupPainter(MyLayoutControl lc)
        {
            _Lc = lc;
        }

        private MyLayoutControl _Lc;


        public override void DrawObject(ObjectInfoArgs e)
        {
            base.DrawObject(e);
            TabbedGroupViewInfo vi = e as TabbedGroupViewInfo;
            DevExpress.XtraLayout.Tab.LayoutTab tab = vi.BorderInfo.Tab;
            SkinTabControlViewInfo tabViewInfo = tab.ViewInfo as SkinTabControlViewInfo;
            Rectangle bounds = ((BaseTabControlViewInfo)tabViewInfo).HeaderInfo.AllPages.LastPage.Bounds;
            bounds.Width += bounds.X;
            bounds.X = 0;
            if (_Lc.TabGroupItems.ContainsKey(vi.Owner))
            {
                InplaceEditorInfo[] infos = _Lc.TabGroupItems[vi.Owner];
                foreach (InplaceEditorInfo info in infos)
                {
                    Rectangle checkBounds = GetItemBounds(vi.BoundsRelativeToControl, info.ItemSize, info.RightIndent);
                    info.Bounds = checkBounds;
                    if (bounds.IntersectsWith(info.Bounds))
                        return;
                    DrawEditorHelper.DrawEdit(e.Graphics, info.Edit, info.Bounds, info.EditValue);
                }
            }
        }
        private Rectangle GetItemBounds(Rectangle boundsRelativeToControl, Size size, int rightIndent)
        {
            int indent= 3;
            Rectangle result = boundsRelativeToControl;
            result.X = boundsRelativeToControl.Right - size.Width - indent - rightIndent;
            result.Y += indent;
            result.Width = size.Width;
            result.Height = size.Height;
            return result;
        }

    }
}