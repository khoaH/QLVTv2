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
using DevExpress.Data.Filtering;

namespace QLVTv2
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lay_dspm(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cb_chinhanh.DataSource = Program.bds_dspm;
            cb_chinhanh.DisplayMember = "TENCN";
            cb_chinhanh.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kế nối về cơ sở dữ liệu gốc.\n Bạn xem lại Tên Server của Publisher, và tên CSDL", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cb_chinhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
            lay_dspm("SELECT * FROM Get_Subcribes");
            cb_chinhanh.SelectedIndex = 1;
            cb_chinhanh.SelectedIndex = 0;
        }


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text.Trim() == "" || txt_pass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống ", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txt_taikhoan.Text;
            Program.password = txt_pass.Text;

            if (Program.KetNoi() == 0)
                return;

            Program.mChinhanh = cb_chinhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.txtMaNV.Text = "Mã NV = " + Program.username;
            Program.frmChinh.txtHoTen.Text = "Họ Tên = " + Program.mHoten;
            Program.frmChinh.txtNhom.Text = "Nhóm = " + Program.mGroup;
            Program.frmChinh.btnNhanVien.Enabled = true;
            //Program.frmChinh.HienThiMenu();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            if (Program.frmChinh != null)
                Program.frmChinh.Close();
            Close();
        }
    }

}