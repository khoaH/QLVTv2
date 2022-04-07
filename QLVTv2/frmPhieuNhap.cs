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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0; //VatTu
        private int _positionPN = 0;
        private int _positionCTPN = 0;
        String oldMPN = null;
        private TransactionControl tControl; 
        public frmPhieuNhap()
        {
            InitializeComponent();
            tControl = new TransactionControl();
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
            btnGhiPN.Enabled = btnGhi_CTPN.Enabled = btnHuyPN.Enabled = btnHuyCTPN.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
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

            tControl.prepare(new InsertTransaction(fKPhieuNhapDatHangBindingSource, "MAPN"));
            //fKPhieuNhapDatHangBindingSource.AddNew();

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
                        XtraMessageBox.Show("Trùng mã Phiếu nhập!", "", MessageBoxButtons.OK);
                        txtMaPhieu.Focus();
                        txtMaPhieu.Select(txtMaPhieu.Text.Length, 0);
                        return;
                    }
                    
                    datHangGridControl.Enabled = true;
                    PhieuNhapGroupControl.Enabled = false;
                    //isEdited = true;

                    tControl.commit();
                    this.fKPhieuNhapDatHangBindingSource.EndEdit();
                    this.fKPhieuNhapDatHangBindingSource.ResetCurrentItem();
                    this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
                    //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuyPN.Enabled = btnGhiPN.Enabled = false;
                    btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = btnUndo.Enabled = true;
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

        private int kiemTraSL(string mavt, string maddh, decimal sl)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = null;
            str_sp = "dbo.SP_CHECK_SL_DDH_PN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@maddh", SqlDbType.NChar).Value = maddh;
            Program.sqlcmd.Parameters.Add("@mavt", SqlDbType.NChar).Value = mavt;
            Program.sqlcmd.Parameters.Add("@conlai", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            int ret = -1;
            try
            {
                ret = Int32.Parse(Program.sqlcmd.Parameters["@conlai"].Value.ToString());
            }
            catch
            {
                return -1;
            }
            if (ret < sl)
                return 0; 
            else
                return 1;
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            tControl.prepare(new UpdateTransaction(fKPhieuNhapDatHangBindingSource, "MAPN"));
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
                            string delMaPN = ((DataRowView)fKPhieuNhapDatHangBindingSource[fKPhieuNhapDatHangBindingSource.Position])["MAPN"].ToString();
                            tControl.execute(new DeleteTransaction(fKPhieuNhapDatHangBindingSource, "MAPN"));
                            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;

                            //fKPhieuNhapDatHangBindingSource.RemoveCurrent();
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
            else if (kiemTraSL(lookupMVT.EditValue.ToString(), txtMaDDH.EditValue.ToString(), numSoLuong.Value) == 0)
            {
                XtraMessageBox.Show("Không đủ số lượng trong đơn đặt hàng hoặc không có mặt hàng trong đơn!", "Thông báo !", MessageBoxButtons.OK);
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
            CTPNgroupControl.Enabled = false;
            cTPNGridControl.Enabled = true;
            fKCTPNPhieuNhapBindingSource.CancelEdit();;
            btnThem_CTPN.Enabled = btnSua_CTPN.Enabled = btnXoaCTPN.Enabled = true;
            btnThemPN.Enabled = btnSuaPN.Enabled = btnXoaPN.Enabled = true;
            btnGhi_CTPN.Enabled = btnHuyCTPN.Enabled = false;
            btnLamMoi1.PerformClick();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.undo();
            datHangBindingSource.EndEdit();
            datHangBindingSource.ResetCurrentItem();
            datHangTableAdapter.Update(this.qLVT_DATHANGDataSet.DatHang);
            fKPhieuNhapDatHangBindingSource.EndEdit();
            fKPhieuNhapDatHangBindingSource.ResetCurrentItem();
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            fKCTPNPhieuNhapBindingSource.EndEdit();
            fKCTPNPhieuNhapBindingSource.ResetCurrentItem();
            cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPN);
            btnUndo.Enabled = true;
            if (tControl.undoStackSize() == 0)
            {
                btnUndo.Enabled = false;
            }

        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.redo();
            datHangBindingSource.EndEdit();
            datHangBindingSource.ResetCurrentItem();
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Update(this.qLVT_DATHANGDataSet.DatHang);
            fKPhieuNhapDatHangBindingSource.EndEdit();
            fKPhieuNhapDatHangBindingSource.ResetCurrentItem();
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Update(this.qLVT_DATHANGDataSet.PhieuNhap);
            fKCTPNPhieuNhapBindingSource.EndEdit();
            fKCTPNPhieuNhapBindingSource.ResetCurrentItem();
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Update(this.qLVT_DATHANGDataSet.CTPN);
            btnRedo.Enabled = true;
            if (tControl.redoStackSize() == 0)
            {
                btnRedo.Enabled = false;
            }

        }
    }
}