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
        private TransactionControl tControl;
        private bool insertTransaction;
        public frmPhieuXuat()
        {
            insertTransaction = false;
            InitializeComponent();
            tControl = new TransactionControl();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
            txtDonGia.Enabled = txtHoTenKH.Enabled = txtMACTPX.Enabled = txtMaKho.Enabled = txtMaNV.Enabled = txtMaPX.Enabled = txtSoLuong.Enabled = lookUpVT.Enabled = datePX.Enabled = false;
            btnGhiCTPX.Enabled = btnGhiPX.Enabled = btnHuyCTPX.Enabled = btnHuyPX.Enabled = false;
            btnThemCTPX.Enabled = btnThemPX.Enabled = btnSuaCTPX.Enabled = btnSuaPX.Enabled = btnXoaCTPX.Enabled = btnXoaPX.Enabled = true;


        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            phieuXuatGridControl.Enabled = false;
            CTPXGridControl.Enabled = false;

            tControl.prepare(new InsertTransaction(phieuXuatBindingSource, "MAPX"));

            txtMaNV.Enabled = txtHoTenKH.Enabled = txtMaKho.Enabled = txtMaPX.Enabled = datePX.Enabled = true;
            btnGhiPX.Enabled = btnHuyPX.Enabled = true;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = false;

            txtMaNV.EditValue = Program.username;
            txtMaNV.Text = Program.username;

            insertTransaction = true;
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            tControl.prepare(new UpdateTransaction(phieuXuatBindingSource, "Mapx"));
            phieuXuatGridControl.Enabled = false;
            CTPXGridControl.Enabled = false;
            txtMaNV.Enabled = txtHoTenKH.Enabled = txtMaKho.Enabled = txtMaPX.Enabled = datePX.Enabled = true;
            btnGhiPX.Enabled = btnHuyPX.Enabled = true;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = false;
            insertTransaction = false;
        }

        private void btnGhiPX_Click(object sender, EventArgs e)
        {
            groupBox1.Focus();
            if (txtMaPX.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu xuất không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPX.Focus();
                return;
            }
            if (datePX.Text.Trim() == "")
            {
                MessageBox.Show("Ngày phiếu xuất không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePX.Focus();
                return;
            }
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách hàng không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenKH.Focus();
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã NV không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được bỏ trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKho.Focus();
                return;
            }
            if (khoBindingSource.Find("MAKHO", txtMaKho.Text.Trim()) == -1)
            {
                MessageBox.Show("Mã kho không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKho.Focus();
                return;
            }
            Convert.ToInt32(txtMaNV.Text.Trim());
            int nvp = 0;
            for (; nvp < nhanVienBindingSource.Count; nvp++) 
            {
                if (((DataRowView)nhanVienBindingSource[nvp])["MANV"].ToString().Trim() == txtMaNV.Text.Trim())
                {
                    int status = Convert.ToInt32(((DataRowView)nhanVienBindingSource[nvp])["TrangThaiXoa"]);
                    string name = ((DataRowView)nhanVienBindingSource[nvp])["TEN"].ToString();
                    break;
                }
            }

            if (nvp == nhanVienBindingSource.Count)
            {
                MessageBox.Show("Mã NV không tồn tại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (Convert.ToInt32(((DataRowView)nhanVienBindingSource[nvp])["TrangThaiXoa"]) == 1)
            {
                MessageBox.Show("Nhân viên đã chuyển chi nhánh", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            try
            {
                if (insertTransaction)
                {
                    if (kiemTraPX(txtMaPX.Text.Trim()) == 1)
                    {
                        XtraMessageBox.Show("Trùng mã Phiếu Xuất!", "", MessageBoxButtons.OK);
                        txtMaPX.Focus();
                        txtMaPX.Select(txtMaPX.Text.Length, 0);
                        return;
                    }
                }
                phieuXuatGridControl.Enabled = true;
                txtDonGia.Enabled = txtHoTenKH.Enabled = txtMACTPX.Enabled = txtMaKho.Enabled = txtMaNV.Enabled = txtMaPX.Enabled = txtSoLuong.Enabled = lookUpVT.Enabled = datePX.Enabled = false;
                btnGhiCTPX.Enabled = btnGhiPX.Enabled = btnHuyCTPX.Enabled = btnHuyPX.Enabled = false;
                btnThemCTPX.Enabled = btnThemPX.Enabled = btnSuaCTPX.Enabled = btnSuaPX.Enabled = btnXoaCTPX.Enabled = btnXoaPX.Enabled = true;

                tControl.commit();
                this.phieuXuatBindingSource.EndEdit();
                this.phieuXuatBindingSource.ResetCurrentItem();
                this.phieuXuatTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuXuat);
                XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                btnHuyPX.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                btnHuyPX.PerformClick();
                return;
            }
        }

        private int kiemTraPX(string mapx)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_CHECKID_PX";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MAPX", SqlDbType.NChar).Value = mapx;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có
            }
            else if (ret == "0")
            {
                return 0; //chưa có
            }
            return 0;

        }

        private void btnHuyPX_Click(object sender, EventArgs e)
        {
            phieuNhapBindingSource.CancelEdit();

            phieuXuatGridControl.Enabled = true;
            CTPXGridControl.Enabled = true;

            txtMaNV.Enabled = txtHoTenKH.Enabled = txtMaKho.Enabled = txtMaPX.Enabled = datePX.Enabled = false;
            btnGhiPX.Enabled = btnHuyPX.Enabled = false;
            btnThemPX.Enabled = btnSuaPX.Enabled = btnXoaPX.Enabled = true;
            frmPhieuXuat_Load(sender, e);
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
        }

        private void btnXoaCTPX_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaCTPX_Click(object sender, EventArgs e)
        {

        }

        private void btnGhiCTPX_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyCTPX_Click(object sender, EventArgs e)
        {

        }
    }
}