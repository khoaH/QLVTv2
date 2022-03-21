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
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0;
        String oldMVT = null;
        String oldTVT = null;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            groupBoxVatTu.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnHuy.Enabled = btnSua.Enabled = barButtonItem1.Enabled = false;
                groupBoxVatTu.Enabled = false;
            }
            else
            {
                groupBoxVatTu.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHuy.Enabled = btnSua.Enabled = barButtonItem1.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled
                = btnXoa.Enabled
                = btnSua.Enabled
                = btnLamMoi.Enabled = false;
            
            groupBoxVatTu.Enabled = true;
            gridControlVatTu.Enabled = false;
            vattuBindingSource.AddNew();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaVatTu.Text.Trim() == "")
            {

                MessageBox.Show("Mã Vật tư không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaVatTu.Focus();
            }
            else if (txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenVT.Focus();
            }
            else if (txtDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenVT.Focus();
            }
            else if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoLuong.Focus();
            }
            else
            {
                try
                {
                    if (string.Compare(oldMVT, txtMaVatTu.Text.Trim()) != 0 && kiemtraVT(txtMaVatTu.Text.Trim(), 0) == 1)
                    {
                        XtraMessageBox.Show("Trùng mã Vật tư!", "", MessageBoxButtons.OK);
                        txtMaVatTu.Focus();
                        txtMaVatTu.Select(txtMaVatTu.Text.Length, 0);
                        return;
                    }
                    else if (string.Compare(oldTVT, txtTenVT.Text.Trim()) != 0 && kiemtraVT(standardString(txtTenVT.Text), 1) == 1)
                    {
                        XtraMessageBox.Show("Trùng tên Vật tư!", "", MessageBoxButtons.OK);
                        txtTenVT.Focus();
                        return;
                    }
                    gridControlVatTu.Enabled = true;
                    groupBoxVatTu.Enabled = false;
                    //isEdited = true;

                    this.vattuBindingSource.EndEdit();
                    this.vattuBindingSource.ResetCurrentItem();
                    this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                    txtMaVatTu.Enabled = true;

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    btnHuy.PerformClick();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi ghi dữ liệu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        private int kiemtraVT(string check_str, int type) //
        {
            String str_sp = null;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            str_sp = type == 0 ? "dbo.SP_CHECKID" : type == 1 ? "dbo.SP_CHECKNAME" : "";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            if (type == 0)
            {
                Program.sqlcmd.Parameters.Add("@Ma", SqlDbType.NChar).Value = check_str;
                Program.sqlcmd.Parameters.Add("@Type", SqlDbType.NChar).Value = "MAVT";
            }
            else if (type == 1)
            {
                Program.sqlcmd.Parameters.Add("@Name", SqlDbType.NChar).Value = check_str;
                Program.sqlcmd.Parameters.Add("@Type", SqlDbType.NChar).Value = "TENVT";
            }

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
        public string standardString(string strSource)
        {
            strSource = strSource.Trim();
            while (strSource.IndexOf("  ") != -1)
            {
                strSource = strSource.Replace("  ", " ");
            }
            return strSource;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vattuBindingSource.CancelEdit();
            btnThem.Enabled
               = btnXoa.Enabled
               = btnSua.Enabled
               = btnLamMoi.Enabled = true;
            groupBoxVatTu.Enabled = false;
            gridControlVatTu.Enabled = true;
            frmVatTu_Load(sender, e);
            if (_position > 0)
            {
                vattuBindingSource.Position = _position;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVatTu_Load(sender, e);
            btnThoat.Enabled = true;
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vattuBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                if (fKCTDDHVatTuBindingSource.Count > 0)
                {
                    XtraMessageBox.Show("Vật tư hiện tại đã nhập hàng. Không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn xóa Vật tư ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            vattuBindingSource.RemoveCurrent();
                            this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi xóa Vật tư. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled
              = btnXoa.Enabled
              = btnSua.Enabled
              = btnLamMoi.Enabled
              = btnThoat.Enabled = false;
            txtMaVatTu.Enabled = false;
            groupBoxVatTu.Enabled = true;
            gridControlVatTu.Enabled = false;
            oldMVT = txtMaVatTu.Text.Trim();
            oldTVT = txtTenVT.Text.Trim();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }

}