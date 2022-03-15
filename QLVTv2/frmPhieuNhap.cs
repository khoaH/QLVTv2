﻿using System;
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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0; //VatTu
        private int _positionPN = 0;
        private int _positionCTPN = 0;
        String oldMVT = null;
        String oldTVT = null;
        String oldMPN = null;
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPN' table. You can move, or remove it, as needed.

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            btnGhiPN.Enabled = btnGhi_CTPN.Enabled = btnHuyPN.Enabled = btnHuyCTPN.Enabled = btnGhi.Enabled = false;
            btnThemPN.Enabled = btnThem_CTPN.Enabled = btnSuaPN.Enabled = btnSua_CTPN.Enabled = btnXoaPN.Enabled = btnXoaCTPN.Enabled = true;
            datHangGridControl.Enabled = true;
            PhieuNhapGroupControl.Enabled = CTPNgroupControl.Enabled = false;

        }

        private void lblMaNv_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spinEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            PhieuNhapGroupControl.Enabled = true;
            datHangGridControl.Enabled = false;
            fKPhieuNhapDatHangBindingSource.AddNew();
            txtMaPhieu.ReadOnly = false;
            btnHuyPN.Enabled = btnGhiPN.Enabled = true;
            btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = false;
            txtMaNhanVien.EditValue = Program.username;
            txtMaNhanVien.Text = Program.username;
            _position = datHangBindingSource.Position;
            txtMaDDH.Text = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();
            txtMaDDH.EditValue = ((DataRowView)datHangBindingSource[_position])["MasoDDH"].ToString();
            txtMaKho.Text = ((DataRowView)datHangBindingSource[_position])["MAKHO"].ToString();
            txtMaKho.EditValue = ((DataRowView)datHangBindingSource[_position])["MAKHO"].ToString();
        }

        private void btnGhiPN_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text.Trim() == "")
            {

                MessageBox.Show("Mã Phiếu nhập không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaPhieu.Focus();
            }
            else if (txtNgayNhap.Text.Trim() == "")
            {
                MessageBox.Show("Ngày nhập không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtNgayNhap.Focus();
            }
            else if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaNhanVien.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaKho.Focus();
            }
            else
            {
                try
                {
                    if (String.Compare(oldMPN, txtMaPhieu.Text.Trim()) != 0 && kiemtraPS(txtMaPhieu.Text.Trim()) == 1)
                    {
                        XtraMessageBox.Show("Trùng mã vật Phiếu nhập!", "", MessageBoxButtons.OK);
                        txtMaPhieu.Focus();
                        txtMaPhieu.Select(txtMaPhieu.Text.Length, 0);
                        return;
                    }
                    
                    datHangGridControl.Enabled = true;
                    PhieuNhapGroupControl.Enabled = false;
                    //isEdited = true;

                    this.fKPhieuNhapDatHangBindingSource.EndEdit();
                    this.fKPhieuNhapDatHangBindingSource.ResetCurrentItem();
                    this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
                    //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuyPN.Enabled = btnGhiPN.Enabled = false;
                    btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = true;
                    btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = true;
                    btnHuyPN.PerformClick();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        private int kiemtraPS(string check_str) //Kiểm tra Phiếu nhập
        {
            //type =0: ID
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_CHECKID_PN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MAPHIEU", SqlDbType.NChar).Value = check_str;
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

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            PhieuNhapGroupControl.Enabled = true;
            datHangGridControl.Enabled = false;
            txtMaPhieu.ReadOnly = false;
            btnHuyPN.Enabled = btnGhiPN.Enabled = true;
            btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = false;
        }

        private void btnHuyPN_Click(object sender, EventArgs e)
        {
            fKPhieuNhapDatHangBindingSource.CancelEdit();
            PhieuNhapGroupControl.Enabled = false;
            datHangGridControl.Enabled = true;
            btnGhiPN.Enabled = btnHuyPN.Enabled = false;
            btnLamMoi1.PerformClick();
        }

        private void btnLamMoi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmDatHang_Load(sender, e);
            if (_position > 0)
            {
                datHangBindingSource.Position = _position;
            }
            if (_positionPN > 0)
            {
                fKPhieuNhapDatHangBindingSource.Position = _positionPN;
            }
            if (_positionCTPN > 0)
            {
                fKCTPNPhieuNhapBindingSource.Position = _positionCTPN;
            }
            btnThoat.Enabled = true;
            //XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (fKPhieuNhapDatHangBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                if (fKCTPNPhieuNhapBindingSource.Count > 0)
                {
                    XtraMessageBox.Show("Phiếu đã nhập hàng. Không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa phiếu ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            fKPhieuNhapDatHangBindingSource.RemoveCurrent();
                            this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi xóa phiếu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnThem_CTPN_Click(object sender, EventArgs e)
        {
            _positionCTPN = fKCTPNPhieuNhapBindingSource.Position;
            _positionPN = fKPhieuNhapDatHangBindingSource.Position;
            CTPNgroupControl.Enabled = true;
            cTPNGridControl.Enabled = false;

            fKCTPNPhieuNhapBindingSource.AddNew();
            btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = true;
            btnGhi_CTPN.Enabled = btnHuyCTPN.Enabled = true;
           
        }
        int flagSua = 0;

        private void btnGhi_CTPN_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value < 1)
            {
                XtraMessageBox.Show("Số lượng không hợp lệ, phải lớn hơn 0", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            else if (numDonGia.Value < 1)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ, phải lớn hơn 0", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else if (flagSua != 1 && kiemtraCTPN(txtMaPhieuNhap.EditValue.ToString(), lookupMVT.EditValue.ToString()) == 1)
            {
                XtraMessageBox.Show("Phiếu đã có mặt hàng này. Vui lòng nhập liệu ở phiếu khác hoặc đổi mặt hàng khác!", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            try
            {
                cTPNGridControl.Enabled = true;
                CTPNgroupControl.Enabled = false;
                //isEdited = true;

                this.fKCTPNPhieuNhapBindingSource.EndEdit();
                this.fKCTPNPhieuNhapBindingSource.ResetCurrentItem();
                this.cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPN);
                //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);
                flagSua = 0;
                XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                btnGhi_CTPN.Enabled = false;
                btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = true;
                btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = true;
                btnHuyCTPN.PerformClick();
                btnLamMoi1.PerformClick();

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

                CTPNgroupControl.Enabled = true;
                //btnHuyCTPN.PerformClick();
                return;
            }
        }
        private int kiemtraCTPN(string check_str1, string check_str2) //Kiểm tra Phát sinh
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_CHECKID_CTPN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MAPHIEU", SqlDbType.NChar).Value = check_str1;
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
        private DataSet GetMVT_DDH(string maDDH) //Kiểm tra Phát sinh
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_GET_CTDDH_VATTU ";

            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@maddh", SqlDbType.NChar).Value = maDDH;     
            var adapt = new SqlDataAdapter();
            adapt.SelectCommand = Program.sqlcmd;
            var dataset = new DataSet();
            adapt.Fill(dataset);

            return dataset;
            
            //Program.sqlcmd = Program.conn.CreateCommand();
            //Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            //Program.sqlcmd.CommandText = str_sp;
            //Program.sqlcmd.Parameters.Add("@maddh", SqlDbType.NChar).Value = maDDH;      
            //Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            //Program.sqlcmd.ExecuteNonQuery();

            //String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            //if (ret == "1")
            //{
            //    return 1; //đã có
            //}
            //else if (ret == "0")
            //{
            //    return 0; //chưa có
            //}
            //return 0;
        }

        private void btnSua_CTPN_Click(object sender, EventArgs e)
        {
            _positionCTPN = fKCTPNPhieuNhapBindingSource.Position;
            _positionPN = fKPhieuNhapDatHangBindingSource.Position;
            CTPNgroupControl.Enabled = true;
            cTPNGridControl.Enabled = false;
            flagSua = 1;
            btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = false;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = true;
            btnGhi_CTPN.Enabled = btnHuyCTPN.Enabled = true;

        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            _positionPN = fKPhieuNhapDatHangBindingSource.Position;
            _positionCTPN = fKCTPNPhieuNhapBindingSource.Position;
            if (fKCTPNPhieuNhapBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa Phiếu Nhập ?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    try
                    {
                        fKCTPNPhieuNhapBindingSource.RemoveCurrent();
                        this.cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPN);
                        
                        btnHuyCTPN.PerformClick();
                        btnLamMoi1.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa Phiếu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        btnLamMoi1.PerformClick();
                        return;
                    }
                }
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuyCTPN_Click(object sender, EventArgs e)
        {

        }
    }
}