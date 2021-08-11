namespace QLVTv2
{
    partial class frmTaoTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedoNV = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet1 = new QLVTv2.QLVT_DATHANGDataSet1();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter1 = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.DatHangTableAdapter();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoNV = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienTableAdapter1 = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.NhanVienTableAdapter();
            this.rbChiNhanh = new System.Windows.Forms.RadioButton();
            this.rbCongTy = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemNV,
            this.btnSuaNV,
            this.btnXoaNV,
            this.btnUndoNV,
            this.btnRedoNV,
            this.barEditItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedoNV)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm NV";
            this.btnThemNV.Id = 0;
            this.btnThemNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNV.ImageOptions.SvgImage")));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Caption = "Sửa NV";
            this.btnSuaNV.Id = 2;
            this.btnSuaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNV.ImageOptions.SvgImage")));
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa NV";
            this.btnXoaNV.Id = 3;
            this.btnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNV.ImageOptions.SvgImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnUndoNV
            // 
            this.btnUndoNV.Caption = "Undo";
            this.btnUndoNV.Id = 4;
            this.btnUndoNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoNV.ImageOptions.SvgImage")));
            this.btnUndoNV.Name = "btnUndoNV";
            this.btnUndoNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedoNV
            // 
            this.btnRedoNV.Caption = "Redo";
            this.btnRedoNV.Id = 5;
            this.btnRedoNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedoNV.ImageOptions.SvgImage")));
            this.btnRedoNV.Name = "btnRedoNV";
            this.btnRedoNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(642, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(642, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(642, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 10;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(162, 172);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(52, 13);
            this.lblLuong.TabIndex = 13;
            this.lblLuong.Text = "Mật Khẩu";
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(162, 131);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(54, 13);
            this.lblHoTenNV.TabIndex = 10;
            this.lblHoTenNV.Text = "Tài Khoản";
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // datHangTableAdapter1
            // 
            this.datHangTableAdapter1.ClearBeforeFill = true;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.btnCancelLogin);
            this.groupThongTin.Controls.Add(this.btnAddLogin);
            this.groupThongTin.Controls.Add(this.comboBoxEdit1);
            this.groupThongTin.Controls.Add(this.rbUser);
            this.groupThongTin.Controls.Add(this.rbCongTy);
            this.groupThongTin.Controls.Add(this.rbChiNhanh);
            this.groupThongTin.Controls.Add(this.lblLuong);
            this.groupThongTin.Controls.Add(this.label1);
            this.groupThongTin.Controls.Add(this.lblHoTenNV);
            this.groupThongTin.Controls.Add(this.txtTenNV);
            this.groupThongTin.Controls.Add(this.txtHoNV);
            this.groupThongTin.Enabled = false;
            this.groupThongTin.Location = new System.Drawing.Point(20, 291);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(609, 254);
            this.groupThongTin.TabIndex = 17;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(225, 165);
            this.txtTenNV.MenuManager = this.barManager1;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(226, 20);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(225, 128);
            this.txtHoNV.MenuManager = this.barManager1;
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(226, 20);
            this.txtHoNV.TabIndex = 6;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // rbChiNhanh
            // 
            this.rbChiNhanh.AutoSize = true;
            this.rbChiNhanh.Location = new System.Drawing.Point(175, 97);
            this.rbChiNhanh.Name = "rbChiNhanh";
            this.rbChiNhanh.Size = new System.Drawing.Size(74, 17);
            this.rbChiNhanh.TabIndex = 17;
            this.rbChiNhanh.TabStop = true;
            this.rbChiNhanh.Text = "Chi Nhánh";
            this.rbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rbCongTy
            // 
            this.rbCongTy.AutoSize = true;
            this.rbCongTy.Location = new System.Drawing.Point(270, 97);
            this.rbCongTy.Name = "rbCongTy";
            this.rbCongTy.Size = new System.Drawing.Size(65, 17);
            this.rbCongTy.TabIndex = 18;
            this.rbCongTy.TabStop = true;
            this.rbCongTy.Text = "Công Ty";
            this.rbCongTy.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(364, 97);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(47, 17);
            this.rbUser.TabIndex = 19;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(225, 71);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(226, 20);
            this.comboBoxEdit1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã NV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.Location = new System.Drawing.Point(225, 206);
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAddLogin.TabIndex = 21;
            this.btnAddLogin.Text = "Add Login";
            this.btnAddLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Location = new System.Drawing.Point(376, 206);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLogin.TabIndex = 21;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 560);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraBars.BarButtonItem btnSuaNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnUndoNV;
        private DevExpress.XtraBars.BarButtonItem btnRedoNV;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblHoTenNV;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtHoNV;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.DatHangTableAdapter datHangTableAdapter1;
        private QLVT_DATHANGDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbCongTy;
        private System.Windows.Forms.RadioButton rbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnAddLogin;
    }
}