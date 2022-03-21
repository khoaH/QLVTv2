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
            this.qLVT_DATHANGDataSet1 = new QLVTv2.QLVT_DATHANGDataSet1();
            this.vattuTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaCNKho = new DevExpress.XtraEditors.TextEdit();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ChiNhanh = new System.Windows.Forms.Label();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKho = new System.Windows.Forms.Label();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.qLVT_DATHANGDataSet = new QLVTv2.QLVT_DATHANGDataSet();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.khoTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.KhoTableAdapter();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.khoTableAdapter1 = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager1 = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.fKDatHangKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.DatHangTableAdapter();
            this.fKPhieuNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.PhieuNhapTableAdapter();
            this.fKPhieuXuatKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVTv2.QLVT_DATHANGDataSet1TableAdapters.PhieuXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuXuatKhoBindingSource)).BeginInit();
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
            this.barDockControlRight.Location = new System.Drawing.Point(1656, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 510);
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
            this.btnThemKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKho.ImageOptions.SvgImage")));
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKho_ItemClick);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Caption = "Sửa Kho";
            this.btnSuaKho.Id = 2;
            this.btnSuaKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaKho.ImageOptions.SvgImage")));
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSuaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKho_ItemClick);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Xóa Kho";
            this.btnXoaKho.Id = 3;
            this.btnXoaKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKho.ImageOptions.SvgImage")));
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKho_ItemClick);
            // 
            // btnUndoKho
            // 
            this.btnUndoKho.Caption = "Undo";
            this.btnUndoKho.Id = 4;
            this.btnUndoKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoKho.ImageOptions.SvgImage")));
            this.btnUndoKho.Name = "btnUndoKho";
            this.btnUndoKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndoKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoKho_ItemClick);
            // 
            // btnRedoKho
            // 
            this.btnRedoKho.Caption = "Redo";
            this.btnRedoKho.Id = 5;
            this.btnRedoKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedoKho.ImageOptions.SvgImage")));
            this.btnRedoKho.Name = "btnRedoKho";
            this.btnRedoKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRedoKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedoKho_ItemClick);
            // 
            // btnRefeshKho
            // 
            this.btnRefeshKho.Caption = "Refresh";
            this.btnRefeshKho.Id = 6;
            this.btnRefeshKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefeshKho.ImageOptions.SvgImage")));
            this.btnRefeshKho.Name = "btnRefeshKho";
            this.btnRefeshKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefeshKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefeshKho_ItemClick);
            // 
            // btnHuyKho
            // 
            this.btnHuyKho.Caption = "Hủy";
            this.btnHuyKho.Id = 7;
            this.btnHuyKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyKho.ImageOptions.SvgImage")));
            this.btnHuyKho.Name = "btnHuyKho";
            this.btnHuyKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuyKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyKho_ItemClick);
            // 
            // btnGhiKho
            // 
            this.btnGhiKho.Caption = "Ghi";
            this.btnGhiKho.Id = 8;
            this.btnGhiKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiKho.ImageOptions.SvgImage")));
            this.btnGhiKho.Name = "btnGhiKho";
            this.btnGhiKho.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhiKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiKho_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1656, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 544);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1656, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 510);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1656, 34);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 510);
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
            this.groupThongTin.Controls.Add(this.txtMaCNKho);
            this.groupThongTin.Controls.Add(this.lbl_ChiNhanh);
            this.groupThongTin.Controls.Add(this.txtTenKho);
            this.groupThongTin.Controls.Add(this.lblTenKho);
            this.groupThongTin.Controls.Add(this.txtMaKho);
            this.groupThongTin.Controls.Add(this.lblDiaChi);
            this.groupThongTin.Controls.Add(this.lblMaKho);
            this.groupThongTin.Controls.Add(this.txtDiaChi);
            this.groupThongTin.Enabled = false;
            this.groupThongTin.Location = new System.Drawing.Point(18, 379);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.groupThongTin.Size = new System.Drawing.Size(1608, 136);
            this.groupThongTin.TabIndex = 27;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            // 
            // txtMaCNKho
            // 
            this.txtMaCNKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MACN", true));
            this.txtMaCNKho.Enabled = false;
            this.txtMaCNKho.Location = new System.Drawing.Point(1126, 20);
            this.txtMaCNKho.MenuManager = this.barManager1;
            this.txtMaCNKho.Name = "txtMaCNKho";
            this.txtMaCNKho.Size = new System.Drawing.Size(150, 28);
            this.txtMaCNKho.TabIndex = 19;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVT_DATHANGDataSet1;
            // 
            // lbl_ChiNhanh
            // 
            this.lbl_ChiNhanh.AutoSize = true;
            this.lbl_ChiNhanh.Location = new System.Drawing.Point(1035, 24);
            this.lbl_ChiNhanh.Name = "lbl_ChiNhanh";
            this.lbl_ChiNhanh.Size = new System.Drawing.Size(83, 19);
            this.lbl_ChiNhanh.TabIndex = 18;
            this.lbl_ChiNhanh.Text = "Chi Nhánh";
            // 
            // txtTenKho
            // 
            this.txtTenKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "TENKHO", true));
            this.txtTenKho.Location = new System.Drawing.Point(1126, 69);
            this.txtTenKho.MenuManager = this.barManager1;
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(346, 28);
            this.txtTenKho.TabIndex = 17;
            // 
            // lblTenKho
            // 
            this.lblTenKho.AutoSize = true;
            this.lblTenKho.Location = new System.Drawing.Point(1050, 73);
            this.lblTenKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKho.Name = "lblTenKho";
            this.lblTenKho.Size = new System.Drawing.Size(68, 19);
            this.lblTenKho.TabIndex = 16;
            this.lblTenKho.Text = "Tên Kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(200, 69);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(346, 28);
            this.txtMaKho.TabIndex = 15;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(610, 73);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 19);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(138, 73);
            this.lblMaKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(61, 19);
            this.lblMaKho.TabIndex = 8;
            this.lblMaKho.Text = "Mã Kho";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(681, 69);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(346, 28);
            this.txtDiaChi.TabIndex = 4;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(622, -199);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(466, 27);
            this.cbChiNhanh.TabIndex = 28;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.khoGridControl.Location = new System.Drawing.Point(18, 44);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1608, 326);
            this.khoGridControl.TabIndex = 28;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.khoGridControl.Click += new System.EventHandler(this.khoGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 30;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 112;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.MinWidth = 30;
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Width = 112;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1158, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(466, 27);
            this.comboBox1.TabIndex = 29;
            // 
            // khoTableAdapter1
            // 
            this.khoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = this.khoTableAdapter1;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // fKDatHangKhoBindingSource
            // 
            this.fKDatHangKhoBindingSource.DataMember = "FK_DatHang_Kho";
            this.fKDatHangKhoBindingSource.DataSource = this.khoBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhieuNhapKhoBindingSource
            // 
            this.fKPhieuNhapKhoBindingSource.DataMember = "FK_PhieuNhap_Kho";
            this.fKPhieuNhapKhoBindingSource.DataSource = this.khoBindingSource;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhieuXuatKhoBindingSource
            // 
            this.fKPhieuXuatKhoBindingSource.DataMember = "FK_PhieuXuat_Kho";
            this.fKPhieuXuatKhoBindingSource.DataSource = this.khoBindingSource;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 544);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet1)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuXuatKhoBindingSource)).EndInit();
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
        private QLVT_DATHANGDataSet1 qLVT_DATHANGDataSet1;
        private QLVT_DATHANGDataSet1TableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private System.Windows.Forms.Label lblTenKho;
        private System.Windows.Forms.ComboBox comboBox1;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter1;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.TextEdit txtMaCNKho;
        private System.Windows.Forms.Label lbl_ChiNhanh;
        private System.Windows.Forms.BindingSource fKDatHangKhoBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource fKPhieuNhapKhoBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource fKPhieuXuatKhoBindingSource;
        private QLVT_DATHANGDataSet1TableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
    }
}