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
