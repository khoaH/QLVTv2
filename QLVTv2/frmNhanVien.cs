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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnUndoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRedoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefeshNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nhanVienBindingSource.RemoveFilter();
                fill_Tables();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGhiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnChuyenNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnChuyenCN_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyChuyenCN_Click(object sender, EventArgs e)
        {

        }

        private void cbChiNhanhChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spnMaNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void spnLuongNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void spnStatusNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLVT_DATHANGDataSet1.NhanVien);
            fill_Tables();
            groupThongTin.Enabled = false;

            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.mChinhanh;

            cbChiNhanhChuyen.Items.Add(Program.mChinhanh == 0 ? "Chi nhánh 2" : "Chi nhánh 1");

            if (Program.mGroup == "CONGTY")
            {
                cbChiNhanh.Enabled = true;
                btnThemNV.Enabled = btnXoaNV.Enabled = btnHuyNV.Enabled = groupThongTin.Enabled = btnSuaNV.Enabled = btnGhiNV.Enabled = false;
            }
            else
            {
                cbChiNhanh.Enabled = false;
                groupThongTin.Enabled = false;
                groupChuyen.Enabled = false;
                btnGhiNV.Enabled = false;
            }


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void fill_Tables()
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRedoNV.PerformClick();
            try
            {
                if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                // Gán chi nhánh mới
                Program.servername = cbChiNhanh.SelectedValue.ToString();
                // Dùng htkn để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
                if (Program.mChinhanh != cbChiNhanh.SelectedIndex)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                // Dung tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show($"Không thể kết nối đến server {Program.servername}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    fill_Tables();
                    // Lấy mã chi nhánh hiện tại
                    //  macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString(); // khong can do khong su dung macn khac ma dang nhap khi write data (constraint phan quyen)
                    //   MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }

        }
    }
}