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
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter1.Fill(this.qLVT_DATHANGDataSet.Kho);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet1.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet1.Kho);
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

        private void lblMaVT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDVT_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDVT_EditValueChanged(object sender, EventArgs e)
        {

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
            khoBindingSource1.AddNew();

        }

  
        private void btnSuaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefeshKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuyKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private int kiemtra(string check_str) //
        {
            String str_sp = null;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            str_sp = "dbo.SP_CHECKID_KHO";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@Ma", SqlDbType.NChar).Value = check_str;
            Program.sqlcmd.Parameters.Add("@Type", SqlDbType.NChar).Value = "MAVT";
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1;
            }
            else if (ret == "0")
            {
                return 0;
            }
            return 0;
        }

        private void btnGhiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "")
            {

                MessageBox.Show("Mã Vật tư không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaKho.Focus();
            }
            else if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenKho.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else
            {
                try
                {
                    if (kiemtra(txtMaKho.Text.Trim()) == 1)
                    {
                        XtraMessageBox.Show("Trùng mã Vật tư!", "", MessageBoxButtons.OK);
                        txtMaKho.Focus();
                        txtMaKho.Select(txtMaKho.Text.Length, 0);
                        return;
                    }
                    khoGridControl.Enabled = true;
                    groupThongTin.Enabled = false;
                    //isEdited = true;

                    this.khoBindingSource1.EndEdit();
                    this.khoBindingSource1.ResetCurrentItem();
                    this.khoTableAdapter1.Update(this.qLVT_DATHANGDataSet.Kho);
                    txtMaKho.Enabled = true;

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuyKho.PerformClick();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}