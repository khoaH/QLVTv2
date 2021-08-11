namespace QLVTv2
{
    partial class frmVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedoVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefeshVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiVT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.lblSLT = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.txtTenVT = new DevExpress.XtraEditors.TextEdit();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet1 = new QLVTv2.QLVT_DATHANGDataSet1();
            this.tableAdapterManager = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.vattuTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dateNV = new DevExpress.XtraEditors.DateEdit();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(767, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.txtMaVT);
            this.groupThongTin.Controls.Add(this.lblSLT);
            this.groupThongTin.Controls.Add(this.lblDVT);
            this.groupThongTin.Controls.Add(this.lblTenVT);
            this.groupThongTin.Controls.Add(this.lblMaVT);
            this.groupThongTin.Controls.Add(this.txtSoLuongTon);
            this.groupThongTin.Controls.Add(this.txtTenVT);
            this.groupThongTin.Controls.Add(this.txtDVT);
            this.groupThongTin.Enabled = false;
            this.groupThongTin.Location = new System.Drawing.Point(6, 439);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(1073, 182);
            this.groupThongTin.TabIndex = 33;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(196, 60);
            this.txtMaVT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaVT.MenuManager = this.barManager1;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(231, 20);
            this.txtMaVT.TabIndex = 15;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemVT,
            this.btnSuaVT,
            this.btnXoaVT,
            this.btnUndoVT,
            this.btnRedoVT,
            this.btnRefeshVT,
            this.btnHuyVT,
            this.btnGhiVT});
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedoVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefeshVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuyVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiVT)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Thêm VT";
            this.btnThemVT.Id = 0;
            this.btnThemVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemVT.ImageOptions.SvgImage")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Caption = "Sửa VT";
            this.btnSuaVT.Id = 2;
            this.btnSuaVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaVT.ImageOptions.SvgImage")));
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Caption = "Xóa VT";
            this.btnXoaVT.Id = 3;
            this.btnXoaVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaVT.ImageOptions.SvgImage")));
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnUndoVT
            // 
            this.btnUndoVT.Caption = "Undo";
            this.btnUndoVT.Id = 4;
            this.btnUndoVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoVT.ImageOptions.SvgImage")));
            this.btnUndoVT.Name = "btnUndoVT";
            this.btnUndoVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRedoVT
            // 
            this.btnRedoVT.Caption = "Redo";
            this.btnRedoVT.Id = 5;
            this.btnRedoVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedoVT.ImageOptions.SvgImage")));
            this.btnRedoVT.Name = "btnRedoVT";
            this.btnRedoVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRefeshVT
            // 
            this.btnRefeshVT.Caption = "Refresh";
            this.btnRefeshVT.Id = 6;
            this.btnRefeshVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefeshVT.ImageOptions.SvgImage")));
            this.btnRefeshVT.Name = "btnRefeshVT";
            this.btnRefeshVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHuyVT
            // 
            this.btnHuyVT.Caption = "Hủy";
            this.btnHuyVT.Id = 7;
            this.btnHuyVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyVT.ImageOptions.SvgImage")));
            this.btnHuyVT.Name = "btnHuyVT";
            this.btnHuyVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Caption = "Ghi";
            this.btnGhiVT.Id = 8;
            this.btnGhiVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiVT.ImageOptions.SvgImage")));
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1092, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1092, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 607);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1092, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 607);
            // 
            // lblSLT
            // 
            this.lblSLT.AutoSize = true;
            this.lblSLT.Location = new System.Drawing.Point(544, 104);
            this.lblSLT.Name = "lblSLT";
            this.lblSLT.Size = new System.Drawing.Size(73, 13);
            this.lblSLT.TabIndex = 13;
            this.lblSLT.Text = "Số Lượng Tồn";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(549, 63);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(61, 13);
            this.lblDVT.TabIndex = 11;
            this.lblDVT.Text = "Đơn Vị Tính";
            // 
            // lblTenVT
            // 
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(150, 104);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(40, 13);
            this.lblTenVT.TabIndex = 10;
            this.lblTenVT.Text = "Tên VT";
            // 
            // lblMaVT
            // 
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(155, 60);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.Size = new System.Drawing.Size(36, 13);
            this.lblMaVT.TabIndex = 8;
            this.lblMaVT.Text = "Mã VT";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(623, 101);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(231, 20);
            this.txtSoLuongTon.TabIndex = 6;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(196, 101);
            this.txtTenVT.MenuManager = this.barManager1;
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(231, 20);
            this.txtTenVT.TabIndex = 6;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(623, 60);
            this.txtDVT.MenuManager = this.barManager1;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(231, 20);
            this.txtDVT.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.Location = new System.Drawing.Point(6, 39);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.MenuManager = this.barManager1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(1073, 394);
            this.vattuGridControl.TabIndex = 35;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1092, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 607);
            // 
            // dateNV
            // 
            this.dateNV.EditValue = null;
            this.dateNV.Location = new System.Drawing.Point(168, 139);
            this.dateNV.Margin = new System.Windows.Forms.Padding(2);
            this.dateNV.MenuManager = this.barManager1;
            this.dateNV.Name = "dateNV";
            this.dateNV.Size = new System.Drawing.Size(100, 20);
            this.dateNV.TabIndex = 32;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(409, -68);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(312, 21);
            this.cbChiNhanh.TabIndex = 34;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.dateNV);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVatTu";
            this.Text = "frmVatTu";
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupThongTin;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnSuaVT;
        private DevExpress.XtraBars.BarButtonItem btnXoaVT;
        private DevExpress.XtraBars.BarButtonItem btnUndoVT;
        private DevExpress.XtraBars.BarButtonItem btnRedoVT;
        private DevExpress.XtraBars.BarButtonItem btnRefeshVT;
        private DevExpress.XtraBars.BarButtonItem btnHuyVT;
        private DevExpress.XtraBars.BarButtonItem btnGhiVT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dateNV;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label lblSLT;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.Label lblMaVT;
        private DevExpress.XtraEditors.TextEdit txtSoLuongTon;
        private DevExpress.XtraEditors.TextEdit txtTenVT;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter vattuTableAdapter;
    }
}