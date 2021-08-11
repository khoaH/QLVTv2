using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVTv2
{
    public partial class frmPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet1.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuXuat);

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }
    }
}