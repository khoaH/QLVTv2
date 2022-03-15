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
using System.Data.SqlClient;

namespace QLVTv2
{
    public partial class frmDatHang : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0; //VatTu
        private int _positionVT = 0;
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.CTPN' table. You can move, or remove it, as needed.

        }

        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            datHangBindingSource.AddNew();
            groupThongTinDDH.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (txtMaVatTu.Text.Trim() == "")
            //{

            //    MessageBox.Show("Mã Vật tư không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
            //    txtMaVatTu.Focus();
            //}
            //else if (txtTenVT.Text.Trim() == "")
            //{
            //    MessageBox.Show("Tên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
            //    txtTenVT.Focus();
            //}
            //else if (txtDonViTinh.Text.Trim() == "")
            //{
            //    MessageBox.Show("Đơn vị tính không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
            //    txtTenVT.Focus();
            //}
            //else if (txtSoLuong.Text.Trim() == "")
            //{
            //    MessageBox.Show("Số lượng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
            //    txtSoLuong.Focus();
            //}
            //else
            //{
                try
                {
                //if (string.Compare(oldMVT, txtMaVatTu.Text.Trim()) != 0 && kiemtraVT(txtMaVatTu.Text.Trim(), 0) == 1)
                //{
                //    XtraMessageBox.Show("Trùng mã Vật tư!", "", MessageBoxButtons.OK);
                //    txtMaVatTu.Focus();
                //    txtMaVatTu.Select(txtMaVatTu.Text.Length, 0);
                //    return;
                //}
                //else if (string.Compare(oldTVT, txtTenVT.Text.Trim()) != 0 && kiemtraVT(standardString(txtTenVT.Text), 1) == 1)
                //{
                //    XtraMessageBox.Show("Trùng tên Vật tư!", "", MessageBoxButtons.OK);
                //    txtTenVT.Focus();
                //    return;
                //}
                    phieuNhapGridControl.Enabled = true;
                    groupThongTinDDH.Enabled = false;
                    //isEdited = true;

                    this.datHangBindingSource.EndEdit();
                    this.datHangBindingSource.ResetCurrentItem();
                    this.datHangTableAdapter.Update(this.qLVT_DATHANGDataSet.DatHang);
                    //txtMaVatTu.Enabled = true;

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuy.PerformClick();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }

        private void btnSuaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupThongTinDDH.Enabled = true;
        }

        private void btnXoaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (datHangBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                if (fKCTDDHDatHangBindingSource.Count > 0)
                {
                    XtraMessageBox.Show("Đơn hàng đã có hàng. Không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            datHangBindingSource.RemoveCurrent();
                            this.datHangTableAdapter.Update(this.qLVT_DATHANGDataSet.DatHang);
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi xóa đơn đặt hàng. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }

        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatHang_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _position = datHangBindingSource.Position;
            txtMaCTDDH.Text = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();
            txtMaCTDDH.EditValue = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();

            _positionVT = fKCTDDHDatHangBindingSource.Position;
            _position = datHangBindingSource.Position;
            groupChiTietDDH.Enabled = true;
            datHangGridControl.Enabled = false;
            cTDDHGridControl.Enabled = false;

            fKCTDDHDatHangBindingSource.AddNew();
            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnXoaDDH.Enabled = true;
            btnGhiVT.Enabled = btnHuyVT.Enabled = true;

        }

        private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _position = datHangBindingSource.Position;
            txtMaCTDDH.Text = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();
            txtMaCTDDH.EditValue = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();

            _positionVT = fKCTDDHDatHangBindingSource.Position;
            _position = datHangBindingSource.Position;
            groupChiTietDDH.Enabled = true;
            datHangGridControl.Enabled = false;
            cTDDHGridControl.Enabled = false;

            btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = false;
            btnThemDDH.Enabled = btnSuaDDH.Enabled = btnXoaDDH.Enabled = true;
            btnGhiVT.Enabled = btnHuyVT.Enabled = true;

        }

        private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _position = fKCTDDHDatHangBindingSource.Position;
            if (fKCTDDHDatHangBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa Vật Tư ?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    try
                    {
                        fKCTDDHDatHangBindingSource.RemoveCurrent();
                        this.cTDDHTableAdapter.Update(this.qLVT_DATHANGDataSet.CTDDH);

                        btnHuyVT.PerformClick();
                        btnRefesh.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa Phiếu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        btnRefesh.PerformClick();
                        return;
                    }
                }
            }
        }

        private void btnHuyVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fKCTDDHDatHangBindingSource.CancelEdit();
            groupChiTietDDH.Enabled = false;
            cTDDHGridControl.Enabled = true;
            btnGhiVT.Enabled = btnHuyVT.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = true;
            //btnRefesh.PerformClick();


        }

        private int kiemtraCTDDH(string check_str1, string check_str2) //Kiểm tra
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_CHECKID_CTPN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MADDH", SqlDbType.NChar).Value = check_str1;
            Program.sqlcmd.Parameters.Add("@MAVT", SqlDbType.NChar).Value = check_str2;
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

        int flagSua = 0;

        private void btnGhiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (spnSoLuongCTDDH.Value < 1)
            {
                XtraMessageBox.Show("Số lượng không hợp lệ, phải lớn hơn 0", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            else if (spnDonGiaVT.Value < 1)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ, phải lớn hơn 0", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else if (flagSua != 1 && kiemtraCTDDH(txtMaDDHCT.EditValue.ToString(), lookupMVT.EditValue.ToString()) == 1)
            {
                XtraMessageBox.Show("Phiếu đã có mặt hàng này. Vui lòng nhập liệu ở phiếu khác hoặc đổi mặt hàng khác!", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            try
            {
                cTDDHGridControl.Enabled = true;
                groupChiTietDDH.Enabled = false;
                //isEdited = true;

                this.fKCTDDHDatHangBindingSource.EndEdit();
                this.fKCTDDHDatHangBindingSource.ResetCurrentItem();
                this.cTDDHTableAdapter.Update(this.qLVT_DATHANGDataSet.CTDDH);
                //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);
                flagSua = 0;
                XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                btnGhiVT.Enabled = false;
                btnThemVT.Enabled = btnSuaVT.Enabled = btnXoaVT.Enabled = true;
                btnThemDDH.Enabled = btnSuaDDH.Enabled = btnXoaDDH.Enabled = true;
                btnHuyVT.PerformClick();
                btnRefesh.PerformClick();

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Cannot insert duplicate"))
                {
                    XtraMessageBox.Show("Hàng đã có ở phiếu này " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                }
                else
                {
                    XtraMessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                }

                groupChiTietDDH.Enabled = true;
                //btnHuyCTPN.PerformClick();
                return;
            }
        }

        private void btnRefreshVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}