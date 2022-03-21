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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {

        public string macn;
        private TransactionControl tControl;
        public frmKho()
        {
            InitializeComponent();
            tControl = new TransactionControl();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet1.DatHang);
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
            macn = (Program.mChinhanh == 0 ? "CN1" : "CN2");
            groupThongTin.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                btnThemKho.Enabled = btnXoaKho.Enabled = btnHuyKho.Enabled = btnSuaKho.Enabled = false;
                groupThongTin.Enabled = false;
            }
            else
            {
                groupThongTin.Enabled = false;
                btnThemKho.Enabled = btnXoaKho.Enabled = btnHuyKho.Enabled = btnSuaKho.Enabled = true;
            }

        }

        private void txtMaVT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemKho.Enabled
                = btnXoaKho.Enabled
                = btnSuaKho.Enabled
                = btnRefeshKho.Enabled = false;

            groupThongTin.Enabled = true;
            khoGridControl.Enabled = false;
            tControl.prepare(new InsertTransaction(khoBindingSource, "MAKHO"));
            //khoBindingSource1.AddNew();

        }

  
        private void btnSuaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.prepare(new UpdateTransaction(khoBindingSource, "MAKHO"));
            txtMaCNKho.Text = macn;
            txtMaCNKho.EditValue = macn;
            groupThongTin.Enabled = true;
            khoGridControl.Enabled = false;
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fKDatHangKhoBindingSource.Count > 0 || fKPhieuNhapKhoBindingSource.Count > 0 || fKPhieuXuatKhoBindingSource.Count > 0)
            {
                MessageBox.Show($"{txtMaKho.Text} {txtTenKho.Text} đã có thông tin phiếu nên không thể xóa", "Lỗi xóa kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string delMaKho = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaKho = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString();
                        tControl.execute(new DeleteTransaction(khoBindingSource, "MAKHO"));
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet1.Kho);
                        btnUndoKho.Enabled = true;
                        btnRedoKho.Enabled = false;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuXuat);

                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet1.PhieuNhap);

                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet1.DatHang);

                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);

                        khoBindingSource.Position = khoBindingSource.Find("MAKHO", delMaKho);
                    }
            }
            if (khoBindingSource.Count == 0)
                btnXoaKho.Enabled = false;
        }

        private void btnRefeshKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                khoBindingSource.RemoveFilter();
                fill_table();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoBindingSource.CancelEdit();
            btnThemKho.Enabled
               = btnXoaKho.Enabled
               = btnSuaKho.Enabled
               = btnUndoKho.Enabled
               = btnRedoKho.Enabled
               = btnRefeshKho.Enabled = true;
            groupThongTin.Enabled = false;
            khoGridControl.Enabled = true;
            frmKho_Load(sender, e);
        }

        private void btnGhiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupThongTin.Focus();
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã Kho không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaKho.Focus();
            }
            else if (txtMaKho.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã Kho không được lớn hơn 4 ký tự !", "Thông báo !", MessageBoxButtons.OK);
                txtMaKho.Focus();
            }
            else if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên Kho không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenKho.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa Chỉ Kho không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else
            {
                string command1 = $"exec SP_CHECK_TEN_KHO '{txtTenKho.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(command1);
                if (Program.myReader != null)
                {
                    if (Program.myReader.Read())
                    {
                        MessageBox.Show($"Tên kho đã tồn tại");
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }

                try
                {
                    string command = $"select TENKHO from KHO where MAKHO = '{txtMaKho.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        if (Program.myReader.Read())
                        {
                            MessageBox.Show($"Mã kho tồn tại: {txtMaKho.Text} {Program.myReader.GetString(0)}");
                            Program.myReader.Close();
                            return;
                        }
                        else
                        {

                            ((DataRowView)khoBindingSource.Current)["MACN"] = macn;
                            tControl.commit(); // lay data cho redo
                            khoBindingSource.EndEdit();
                            khoBindingSource.ResetCurrentItem();
                            this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet1.Kho);
                            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet1);
                            XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                        }
                        Program.myReader.Close();
                    }
                    btnThemKho.Enabled
                       = btnXoaKho.Enabled
                       = btnSuaKho.Enabled
                       = btnUndoKho.Enabled
                       = btnRedoKho.Enabled
                       = btnRefeshKho.Enabled = true;
                    groupThongTin.Enabled = false;
                    khoGridControl.Enabled = true;


                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnUndoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.undo();
            khoBindingSource.EndEdit();
            khoBindingSource.ResetCurrentItem();
            khoTableAdapter1.Update(this.qLVT_DATHANGDataSet.Kho);
            btnRedoKho.Enabled = true;
            if (tControl.undoStackSize() == 0)
            {
                btnUndoKho.Enabled = false;
            }

        }

        private void btnRedoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tControl.redo();
            khoBindingSource.EndEdit();
            khoBindingSource.ResetCurrentItem();
            this.khoTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter1.Update(this.qLVT_DATHANGDataSet.Kho);
            btnUndoKho.Enabled = true;
            if (tControl.redoStackSize() == 0)
            {
                btnRedoKho.Enabled = false;
            }
        }

        private void fill_table()
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
        }

        private void khoGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}