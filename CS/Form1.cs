using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;
using DevExpress.XtraLayout;
using System.Diagnostics;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();

            InplaceEditorInfo checkInfo = new InplaceEditorInfo(new RepositoryItemCheckEdit(), new Size(20, 20), true);
            checkInfo.MouseDown += checkInfo_MouseDown;
            RepositoryItemButtonEdit riBE = new RepositoryItemButtonEdit();
            InplaceEditorInfo buttonInfo = new InplaceEditorInfo(riBE, new Size(30, 20), null);
            riBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            riBE.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            riBE.Buttons[0].Caption = "Test";
            riBE.AutoHeight = false;
            buttonInfo.MouseDown += buttonInfo_MouseDown;
            buttonInfo.RightIndent = 25;
            RepositoryItemHyperLinkEdit riHE = new RepositoryItemHyperLinkEdit();
            InplaceEditorInfo hyperLinkInfo = new InplaceEditorInfo(riHE, new Size(120, 20), "http://devexpress.com/");
            hyperLinkInfo.RightIndent = 60;
            riHE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            hyperLinkInfo.MouseDown += new EventHandler(hyperLinkInfo_MouseDown);
            myLayoutControl1.TabGroupItems.Add(tabbedControlGroup1, new InplaceEditorInfo[] { checkInfo, buttonInfo, hyperLinkInfo });
            InplaceEditorInfo progressBarInfo = new InplaceEditorInfo(new RepositoryItemProgressBar(), new Size(40, 20), 10);
            progressBarInfo.MouseDown += progressBarInfo_MouseDown;
            checkInfo = new InplaceEditorInfo(new RepositoryItemCheckEdit(), new Size(20, 20), true);
            checkInfo.MouseDown += checkInfo_MouseDown;
            checkInfo.RightIndent = 40;
            myLayoutControl1.TabGroupItems.Add(tabbedControlGroup2, new InplaceEditorInfo[] { progressBarInfo, checkInfo });

        }

        void hyperLinkInfo_MouseDown(object sender, EventArgs e)
        {
            InplaceEditorInfo info = sender as InplaceEditorInfo;
            Process.Start(info.EditValue.ToString());
        }

        void buttonInfo_MouseDown(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        Random r = new Random();
        void progressBarInfo_MouseDown(object sender, EventArgs e)
        {
            InplaceEditorInfo info = sender as InplaceEditorInfo;
            info.EditValue = 10 + r.Next(80);
        }

        void checkInfo_MouseDown(object sender, EventArgs e)
        {
            InplaceEditorInfo info = sender as InplaceEditorInfo;
            info.EditValue = true.Equals(info.EditValue) ? false : true;
        }

    }
}