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
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyLayoutControl : LayoutControl
    {

        private Dictionary<TabbedGroup, InplaceEditorInfo[]> _GroupItems = new Dictionary<TabbedGroup, InplaceEditorInfo[]>();

        public Dictionary<TabbedGroup, InplaceEditorInfo[]> TabGroupItems
        {
            get
            {
                return _GroupItems;
            }
            set
            {
                _GroupItems = value;
            }
        }


        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            CheckCustomEditorsClick(e);
        }
        private bool FindEditorInfo(Point location, out TabbedGroup key, out InplaceEditorInfo resultInfo)
        {
            key = null;
            resultInfo = null;
            foreach (KeyValuePair<TabbedGroup, InplaceEditorInfo[]> pair in TabGroupItems)
            {
                foreach (InplaceEditorInfo info in pair.Value)
                {
                    if (info.Bounds.Contains(location))
                    {
                        key = pair.Key;
                        resultInfo = info;
                        return true;
                    }
                }
            }
            return false;
        }
        private void CheckCustomEditorsClick(MouseEventArgs e)
        {
            TabbedGroup key;
            InplaceEditorInfo resultInfo;
            if (FindEditorInfo(e.Location, out key, out resultInfo))
                OnEditorClick(key, resultInfo);
        }
        private void OnEditorClick(TabbedGroup group, InplaceEditorInfo info)
        {
            info.RaiseMouseDown();
            Refresh();
        }
    }
}