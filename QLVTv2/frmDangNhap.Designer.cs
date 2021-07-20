namespace QLVTv2
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_chinhanh = new System.Windows.Forms.ComboBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.Location = new System.Drawing.Point(109, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(109, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label3.Location = new System.Drawing.Point(111, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu :";
            // 
            // cb_chinhanh
            // 
            this.cb_chinhanh.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cb_chinhanh.FormattingEnabled = true;
            this.cb_chinhanh.Location = new System.Drawing.Point(193, 50);
            this.cb_chinhanh.Name = "cb_chinhanh";
            this.cb_chinhanh.Size = new System.Drawing.Size(121, 25);
            this.cb_chinhanh.TabIndex = 3;
            this.cb_chinhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txt_taikhoan.Location = new System.Drawing.Point(193, 80);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(121, 24);
            this.txt_taikhoan.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_chinhanh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txt_pass.Location = new System.Drawing.Point(192, 112);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(121, 24);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_dangnhap.Location = new System.Drawing.Point(126, 191);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(88, 33);
            this.btn_dangnhap.TabIndex = 6;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_thoat.Location = new System.Drawing.Point(238, 191);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(88, 33);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 276);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_chinhanh;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}