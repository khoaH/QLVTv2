namespace QLVTv2
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedoKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefeshKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKho = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet1 = new QLVTv2.QLVT_DATHANGDataSet1();
            this.vattuTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.KhoTableAdapter();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKho = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1104, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemKho,
            this.btnSuaKho,
            this.btnXoaKho,
            this.btnUndoKho,
            this.btnRedoKho,
            this.btnRefeshKho,
            this.btnHuyKho,
            this.btnGhiKho});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedoKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeshKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuyKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiKho)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Caption = "Thêm Kho";
            this.btnThemKho.Id = 0;
            this.btnThemKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemVT.ImageOptions.SvgImage")));
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Caption = "Sửa Kho";
            this.btnSuaKho.Id = 2;
            this.btnSuaKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaVT.ImageOptions.SvgImage")));
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Xóa Kho";
            this.btnXoaKho.Id = 3;
            this.btnXoaKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaVT.ImageOptions.SvgImage")));
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnUndoKho
            // 
            this.btnUndoKho.Caption = "Undo";
            this.btnUndoKho.Id = 4;
            this.btnUndoKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoVT.ImageOptions.SvgImage")));
            this.btnUndoKho.Name = "btnUndoKho";
            this.btnUndoKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedoKho
            // 
            this.btnRedoKho.Caption = "Redo";
            this.btnRedoKho.Id = 5;
            this.btnRedoKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedoVT.ImageOptions.SvgImage")));
            this.btnRedoKho.Name = "btnRedoKho";
            this.btnRedoKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRefeshKho
            // 
            this.btnRefeshKho.Caption = "Refresh";
            this.btnRefeshKho.Id = 6;
            this.btnRefeshKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefeshVT.ImageOptions.SvgImage")));
            this.btnRefeshKho.Name = "btnRefeshKho";
            this.btnRefeshKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHuyKho
            // 
            this.btnHuyKho.Caption = "Hủy";
            this.btnHuyKho.Id = 7;
            this.btnHuyKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyVT.ImageOptions.SvgImage")));
            this.btnHuyKho.Name = "btnHuyKho";
            this.btnHuyKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhiKho
            // 
            this.btnGhiKho.Caption = "Ghi";
            this.btnGhiKho.Id = 8;
            this.btnGhiKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiVT.ImageOptions.SvgImage")));
            this.btnGhiKho.Name = "btnGhiKho";
            this.btnGhiKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1104, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1104, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1104, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 553);
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // qLVT_DATHANGDataSet1
            // 
            this.qLVT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet1";
            this.qLVT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTv2.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.textEdit1);
            this.groupThongTin.Controls.Add(this.txtTenKho);
            this.groupThongTin.Controls.Add(this.txtMaKho);
            this.groupThongTin.Controls.Add(this.lblDiaChi);
            this.groupThongTin.Controls.Add(this.lblMaKho);
            this.groupThongTin.Controls.Add(this.txtDiaChi);
            this.groupThongTin.Enabled = false;
            this.groupThongTin.Location = new System.Drawing.Point(12, 459);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(1072, 98);
            this.groupThongTin.TabIndex = 27;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(133, 47);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(231, 20);
            this.txtMaKho.TabIndex = 15;
            this.txtMaKho.EditValueChanged += new System.EventHandler(this.txtMaVT_EditValueChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(407, 50);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.Click += new System.EventHandler(this.lblDVT_Click);
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(92, 50);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(42, 13);
            this.lblMaKho.TabIndex = 8;
            this.lblMaKho.Text = "Mã Kho";
            this.lblMaKho.Click += new System.EventHandler(this.lblMaVT_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(454, 47);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 20);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.EditValueChanged += new System.EventHandler(this.txtDVT_EditValueChanged);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(415, -136);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(312, 21);
            this.cbChiNhanh.TabIndex = 28;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Location = new System.Drawing.Point(12, 30);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1072, 423);
            this.khoGridControl.TabIndex = 28;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(751, 47);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(231, 20);
            this.textEdit1.TabIndex = 17;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txtTenKho
            // 
            this.txtTenKho.AutoSize = true;
            this.txtTenKho.Location = new System.Drawing.Point(700, 50);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(46, 13);
            this.txtTenKho.TabIndex = 16;
            this.txtTenKho.Text = "Tên Kho";
            this.txtTenKho.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(772, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemKho;
        private DevExpress.XtraBars.BarButtonItem btnSuaKho;
        private DevExpress.XtraBars.BarButtonItem btnXoaKho;
        private DevExpress.XtraBars.BarButtonItem btnUndoKho;
        private DevExpress.XtraBars.BarButtonItem btnRedoKho;
        private DevExpress.XtraBars.BarButtonItem btnRefeshKho;
        private DevExpress.XtraBars.BarButtonItem btnHuyKho;
        private DevExpress.XtraBars.BarButtonItem btnGhiKho;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.GroupBox groupThongTin;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaKho;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label txtTenKho;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}