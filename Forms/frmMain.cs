using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSVer3.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Interface
            this.Text = "PHAN MEM QUAN LI TRANG THIET BI Y TE";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // Events
            quanLiThietBiYTeToolStripMenuItem.Click += QuanLiThietBiYTeToolStripMenuItem_Click;
            quanLiLinhKienThietBiYTeToolStripMenuItem.Click += QuanLiLinhKienThietBiYTeToolStripMenuItem_Click;
        }

        private void QuanLiLinhKienThietBiYTeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "frmTbytLk");
            if (!isOpen)
            {
                frmTbytLk newFrmTBYT_LK = new frmTbytLk();
                newFrmTBYT_LK.MdiParent = this;
                newFrmTBYT_LK.Show();
            }
            
        }

        private void QuanLiThietBiYTeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "frmTbyt");
            if (!isOpen)
            {
                frmTBYT newFrmTBYT = new frmTBYT();
                newFrmTBYT.MdiParent = this;
                newFrmTBYT.Show();
            }
        }
    }
}
