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
using System.Drawing;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class InplaceEditorInfo
    {

        public InplaceEditorInfo(RepositoryItem edit, Size size, object value)
        {
            _Edit = edit;
            _ItemSize = size;
            _EditValue = value;
        }

        private Rectangle _Bounds;
        public Rectangle Bounds
        {
            get { return _Bounds; }
            set { _Bounds = value; }
        }

        private object _EditValue;
        public object EditValue
        {
            get { return _EditValue; }
            set { _EditValue = value; }
        }

        private RepositoryItem _Edit;
        public RepositoryItem Edit
        {
            get { return _Edit; }
            set { _Edit = value; }
        }
        private Size _ItemSize;
        public Size ItemSize
        {
            get { return _ItemSize; }
            set { _ItemSize = value; }
        }

        private int _RightIndent;
        public int RightIndent
        {
            get { return _RightIndent; }
            set { _RightIndent = value; }
        }


        public event EventHandler MouseDown;

        public void RaiseMouseDown()
        {
            if (MouseDown != null)
                MouseDown(this, new EventArgs());
        }
    }

   
}
