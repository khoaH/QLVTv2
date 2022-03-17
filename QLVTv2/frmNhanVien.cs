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
        public int vitri;
        public string macn;
        private bool insertSession = false;
        private TransactionControl tControl;
        public frmNhanVien()
        {
            InitializeComponent();
            vitri = 0;
            macn = "";
            tControl = new TransactionControl();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupThongTin.Enabled = true;
            nhanVienGridControl.Enabled = false;
            //nhanVienBindingSource.AddNew();
            tControl.prepare(new InsertTransaction(nhanVienBindingSource, "MANV"));
            txtMaCNNV.Text = "CN1";
            txtMaCNNV.EditValue = "CN1";
            spnStatusNV.Text = "0";
            spnStatusNV.EditValue = "0";

        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.prepare(new UpdateTransaction(nhanVienBindingSource, "MANV"));
            groupThongTin.Enabled = true;
            nhanVienGridControl.Enabled = false;

        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fKDatHangNhanVienBindingSource.Count > 0)
            {
                MessageBox.Show("NV đã có đơn hàng !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    try
                    {
                        //nhanVienBindingSource.RemoveCurrent();
                        tControl.execute(new DeleteTransaction(nhanVienBindingSource, "MANV"));
                        this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnUndoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.undo();
            nhanVienBindingSource.EndEdit();
            nhanVienBindingSource.ResetCurrentItem();
            nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
            btnRedoNV.Enabled = true;
            if (tControl.undoStackSize() == 0)
            {
                btnUndoNV.Enabled = false;
            }
        }

        private void btnRedoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefreshNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            //this.Validate();
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            if (txtHoNV.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtHoNV.Focus();
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenNV.Focus();
            }
            if (txtDiaChiNV.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChiNV.Focus();
            }
            if (dateNV.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                dateNV.Focus();
            }
            if (spnLuongNV.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                spnLuongNV.Focus();
            }

            else
            {
                try
                {
                    nhanVienGridControl.Enabled = true;
                    groupThongTin.Enabled = false;

                    tControl.commit();
                    this.nhanVienBindingSource.EndEdit();
                    this.nhanVienBindingSource.ResetCurrentItem();
                    this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                    this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);
                    //this.nhanVienTableAdapter1.Update(this.qLVT_DATHANGDataSet.NhanVien);
                    //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuyNV.PerformClick();
                }
                catch (Exception ex)
                {
                    nhanVienGridControl.Enabled = false;
                    groupThongTin.Enabled = true;
                    MessageBox.Show("Lỗi ghi Nhân Viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                    return;
                }
            }

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
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.


            fill_Tables();
            groupThongTin.Enabled = false;

            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            Program.bds_dspm.Filter = "TENCN LIKE 'CHI%'";
            cbChiNhanh.SelectedIndex = Program.mChinhanh;
            cbChiNhanhChuyen.Items.Add(Program.mChinhanh == 0 ? "Chi nhánh 2" : "Chi nhánh 1");

            if (Program.mGroup == "CONGTY")
            {
                cbChiNhanh.Enabled = true;
                btnThemNV.Enabled = btnXoaNV.Enabled = btnHuyNV.Enabled = btnSuaNV.Enabled = btnGhiNV.Enabled = btnUndoNV.Enabled = btnRedoNV.Enabled = false;
                groupThongTin.Enabled = false;
            }
            else
            {
                cbChiNhanh.Enabled = false;
                groupThongTin.Enabled = false;
                groupChuyen.Enabled = true;
                btnGhiNV.Enabled = true;
            }


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void fill_Tables()
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);

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

        private void nhanVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            btnThemNV.Enabled
               = btnXoaNV.Enabled
               = btnSuaNV.Enabled
               = btnUndoNV.Enabled
               = btnRefreshNV.Enabled = true;
            groupThongTin.Enabled = false;
            nhanVienGridControl.Enabled = true;
            frmNhanVien_Load(sender, e);
            //if (_position > 0)
            //{
            //    mONHOCBindingSource.Position = _position;
            //}

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void nhanVienBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        //private void btnRefreshNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{

        //}
    }
}