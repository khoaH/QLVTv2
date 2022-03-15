namespace QLVTv2
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenNV = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.dateNV = new DevExpress.XtraEditors.DateEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVTv2.QLVT_DATHANGDataSet();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCNNV = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChiNV = new DevExpress.XtraEditors.TextEdit();
            this.spnStatusNV = new DevExpress.XtraEditors.SpinEdit();
            this.spnLuongNV = new DevExpress.XtraEditors.SpinEdit();
            this.groupChuyen = new System.Windows.Forms.GroupBox();
            this.btnHuyChuyenCN = new System.Windows.Forms.Button();
            this.btnChuyenCN = new System.Windows.Forms.Button();
            this.cbChiNhanhChuyen = new System.Windows.Forms.ComboBox();
            this.lblChiNhanhDen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.nhanVienTableAdapter = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.nhanVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhanVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fKDatHangNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStatusNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLuongNV.Properties)).BeginInit();
            this.groupChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).BeginInit();
            this.nhanVienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).BeginInit();
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
            this.btnRefreshNV,
            this.btnHuyNV,
            this.btnGhiNV,
            this.btnChuyenNV,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedoNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuyNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenNV)});
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
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNV_ItemClick);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Caption = "Sửa NV";
            this.btnSuaNV.Id = 2;
            this.btnSuaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNV.ImageOptions.SvgImage")));
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSuaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaNV_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa NV";
            this.btnXoaNV.Id = 3;
            this.btnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNV.ImageOptions.SvgImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnUndoNV
            // 
            this.btnUndoNV.Caption = "Undo";
            this.btnUndoNV.Id = 4;
            this.btnUndoNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoNV.ImageOptions.SvgImage")));
            this.btnUndoNV.Name = "btnUndoNV";
            this.btnUndoNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoNV_ItemClick);
            // 
            // btnRedoNV
            // 
            this.btnRedoNV.Caption = "Redo";
            this.btnRedoNV.Id = 5;
            this.btnRedoNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedoNV.ImageOptions.SvgImage")));
            this.btnRedoNV.Name = "btnRedoNV";
            this.btnRedoNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRedoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedoNV_ItemClick);
            // 
            // btnRefreshNV
            // 
            this.btnRefreshNV.Caption = "Refresh";
            this.btnRefreshNV.Id = 6;
            this.btnRefreshNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshNV.ImageOptions.SvgImage")));
            this.btnRefreshNV.Name = "btnRefreshNV";
            this.btnRefreshNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshNV_ItemClick);
            // 
            // btnHuyNV
            // 
            this.btnHuyNV.Caption = "Hủy";
            this.btnHuyNV.Id = 7;
            this.btnHuyNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyNV.ImageOptions.SvgImage")));
            this.btnHuyNV.Name = "btnHuyNV";
            this.btnHuyNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuyNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyNV_ItemClick);
            // 
            // btnGhiNV
            // 
            this.btnGhiNV.Caption = "Ghi";
            this.btnGhiNV.Id = 8;
            this.btnGhiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiNV.ImageOptions.SvgImage")));
            this.btnGhiNV.Name = "btnGhiNV";
            this.btnGhiNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiNV_ItemClick);
            // 
            // btnChuyenNV
            // 
            this.btnChuyenNV.Caption = "Chuyển Chi Nhánh";
            this.btnChuyenNV.Id = 9;
            this.btnChuyenNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenNV.ImageOptions.SvgImage")));
            this.btnChuyenNV.Name = "btnChuyenNV";
            this.btnChuyenNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyenNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenNV_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1899, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 817);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1899, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 783);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1899, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 783);
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
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.dateNV);
            this.groupThongTin.Controls.Add(this.txtMaNV);
            this.groupThongTin.Controls.Add(this.lblStatus);
            this.groupThongTin.Controls.Add(this.lblLuong);
            this.groupThongTin.Controls.Add(this.lblMaCN);
            this.groupThongTin.Controls.Add(this.lblDiaChi);
            this.groupThongTin.Controls.Add(this.lblHoTenNV);
            this.groupThongTin.Controls.Add(this.lblNgaySinh);
            this.groupThongTin.Controls.Add(this.lblMaNv);
            this.groupThongTin.Controls.Add(this.txtTenNV);
            this.groupThongTin.Controls.Add(this.txtHoNV);
            this.groupThongTin.Controls.Add(this.txtMaCNNV);
            this.groupThongTin.Controls.Add(this.txtDiaChiNV);
            this.groupThongTin.Controls.Add(this.spnStatusNV);
            this.groupThongTin.Controls.Add(this.spnLuongNV);
            this.groupThongTin.Enabled = false;
            this.groupThongTin.Location = new System.Drawing.Point(14, 402);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.groupThongTin.Size = new System.Drawing.Size(914, 386);
            this.groupThongTin.TabIndex = 5;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            this.groupThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateNV
            // 
            this.dateNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "NGAYSINH", true));
            this.dateNV.EditValue = null;
            this.dateNV.Location = new System.Drawing.Point(261, 104);
            this.dateNV.MenuManager = this.barManager1;
            this.dateNV.Name = "dateNV";
            this.dateNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNV.Size = new System.Drawing.Size(150, 28);
            this.dateNV.TabIndex = 16;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            this.nhanVienBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienBindingSource_CurrentChanged_1);
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(102, 104);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(150, 28);
            this.txtMaNV.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(644, 213);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 19);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Trạng Thái Xóa";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(484, 213);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(54, 19);
            this.lblLuong.TabIndex = 13;
            this.lblLuong.Text = "Lương";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(644, 80);
            this.lblMaCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(108, 19);
            this.lblMaCN.TabIndex = 12;
            this.lblMaCN.Text = "Mã Chi Nhánh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(484, 80);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 19);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(102, 213);
            this.lblHoTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(87, 19);
            this.lblHoTenNV.TabIndex = 10;
            this.lblHoTenNV.Text = "Họ Tên NV";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(261, 76);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 19);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Location = new System.Drawing.Point(102, 76);
            this.lblMaNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(55, 19);
            this.lblMaNv.TabIndex = 8;
            this.lblMaNv.Text = "Mã NV";
            this.lblMaNv.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "TEN", true));
            this.txtTenNV.Location = new System.Drawing.Point(261, 243);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.MenuManager = this.barManager1;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(150, 28);
            this.txtTenNV.TabIndex = 7;
            // 
            // txtHoNV
            // 
            this.txtHoNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "HO", true));
            this.txtHoNV.Location = new System.Drawing.Point(102, 241);
            this.txtHoNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoNV.MenuManager = this.barManager1;
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(150, 28);
            this.txtHoNV.TabIndex = 6;
            // 
            // txtMaCNNV
            // 
            this.txtMaCNNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MACN", true));
            this.txtMaCNNV.Location = new System.Drawing.Point(644, 108);
            this.txtMaCNNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCNNV.MenuManager = this.barManager1;
            this.txtMaCNNV.Name = "txtMaCNNV";
            this.txtMaCNNV.Properties.ReadOnly = true;
            this.txtMaCNNV.Size = new System.Drawing.Size(150, 28);
            this.txtMaCNNV.TabIndex = 5;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "DIACHI", true));
            this.txtDiaChiNV.Location = new System.Drawing.Point(484, 108);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiNV.MenuManager = this.barManager1;
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(150, 28);
            this.txtDiaChiNV.TabIndex = 4;
            // 
            // spnStatusNV
            // 
            this.spnStatusNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.spnStatusNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnStatusNV.Location = new System.Drawing.Point(644, 241);
            this.spnStatusNV.Margin = new System.Windows.Forms.Padding(4);
            this.spnStatusNV.MenuManager = this.barManager1;
            this.spnStatusNV.Name = "spnStatusNV";
            this.spnStatusNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnStatusNV.Properties.ReadOnly = true;
            this.spnStatusNV.Size = new System.Drawing.Size(150, 28);
            this.spnStatusNV.TabIndex = 3;
            this.spnStatusNV.EditValueChanged += new System.EventHandler(this.spnStatusNV_EditValueChanged);
            // 
            // spnLuongNV
            // 
            this.spnLuongNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "LUONG", true));
            this.spnLuongNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnLuongNV.Location = new System.Drawing.Point(484, 241);
            this.spnLuongNV.Margin = new System.Windows.Forms.Padding(4);
            this.spnLuongNV.MenuManager = this.barManager1;
            this.spnLuongNV.Name = "spnLuongNV";
            this.spnLuongNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnLuongNV.Size = new System.Drawing.Size(150, 28);
            this.spnLuongNV.TabIndex = 2;
            this.spnLuongNV.EditValueChanged += new System.EventHandler(this.spnLuongNV_EditValueChanged);
            // 
            // groupChuyen
            // 
            this.groupChuyen.Controls.Add(this.btnHuyChuyenCN);
            this.groupChuyen.Controls.Add(this.btnChuyenCN);
            this.groupChuyen.Controls.Add(this.cbChiNhanhChuyen);
            this.groupChuyen.Controls.Add(this.lblChiNhanhDen);
            this.groupChuyen.Controls.Add(this.dataGridView1);
            this.groupChuyen.Enabled = false;
            this.groupChuyen.Location = new System.Drawing.Point(956, 402);
            this.groupChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.groupChuyen.Name = "groupChuyen";
            this.groupChuyen.Padding = new System.Windows.Forms.Padding(4);
            this.groupChuyen.Size = new System.Drawing.Size(914, 386);
            this.groupChuyen.TabIndex = 6;
            this.groupChuyen.TabStop = false;
            this.groupChuyen.Text = "Chuyển Chi Nhánh";
            // 
            // btnHuyChuyenCN
            // 
            this.btnHuyChuyenCN.Location = new System.Drawing.Point(585, 26);
            this.btnHuyChuyenCN.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyChuyenCN.Name = "btnHuyChuyenCN";
            this.btnHuyChuyenCN.Size = new System.Drawing.Size(112, 34);
            this.btnHuyChuyenCN.TabIndex = 5;
            this.btnHuyChuyenCN.Text = "Hủy";
            this.btnHuyChuyenCN.UseVisualStyleBackColor = true;
            this.btnHuyChuyenCN.Click += new System.EventHandler(this.btnHuyChuyenCN_Click);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Location = new System.Drawing.Point(464, 26);
            this.btnChuyenCN.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.Size = new System.Drawing.Size(112, 34);
            this.btnChuyenCN.TabIndex = 4;
            this.btnChuyenCN.Text = "Chuyển";
            this.btnChuyenCN.UseVisualStyleBackColor = true;
            this.btnChuyenCN.Click += new System.EventHandler(this.btnChuyenCN_Click);
            // 
            // cbChiNhanhChuyen
            // 
            this.cbChiNhanhChuyen.Enabled = false;
            this.cbChiNhanhChuyen.FormattingEnabled = true;
            this.cbChiNhanhChuyen.Location = new System.Drawing.Point(135, 29);
            this.cbChiNhanhChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.cbChiNhanhChuyen.Name = "cbChiNhanhChuyen";
            this.cbChiNhanhChuyen.Size = new System.Drawing.Size(310, 27);
            this.cbChiNhanhChuyen.TabIndex = 3;
            this.cbChiNhanhChuyen.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanhChuyen_SelectedIndexChanged);
            // 
            // lblChiNhanhDen
            // 
            this.lblChiNhanhDen.AutoSize = true;
            this.lblChiNhanhDen.Location = new System.Drawing.Point(8, 34);
            this.lblChiNhanhDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNhanhDen.Name = "lblChiNhanhDen";
            this.lblChiNhanhDen.Size = new System.Drawing.Size(122, 19);
            this.lblChiNhanhDen.TabIndex = 1;
            this.lblChiNhanhDen.Text = "Chi Nhánh Đến:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(1342, -1);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(466, 27);
            this.cbChiNhanh.TabIndex = 7;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBindingNavigator
            // 
            this.nhanVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhanVienBindingNavigator.BindingSource = this.nhanVienBindingSource;
            this.nhanVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhanVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhanVienBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nhanVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nhanVienBindingNavigatorSaveItem});
            this.nhanVienBindingNavigator.Location = new System.Drawing.Point(0, 34);
            this.nhanVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhanVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhanVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhanVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhanVienBindingNavigator.Name = "nhanVienBindingNavigator";
            this.nhanVienBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.nhanVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhanVienBindingNavigator.Size = new System.Drawing.Size(1899, 31);
            this.nhanVienBindingNavigator.TabIndex = 21;
            this.nhanVienBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // nhanVienBindingNavigatorSaveItem
            // 
            this.nhanVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhanVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienBindingNavigatorSaveItem.Image")));
            this.nhanVienBindingNavigatorSaveItem.Name = "nhanVienBindingNavigatorSaveItem";
            this.nhanVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.nhanVienBindingNavigatorSaveItem.Text = "Save Data";
            this.nhanVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.nhanVienBindingNavigatorSaveItem_Click_1);
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 65);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1899, 322);
            this.nhanVienGridControl.TabIndex = 21;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa,
            this.colrowguid});
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 112;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 30;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 112;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 30;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            this.colLUONG.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 112;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 30;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 112;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.MinWidth = 30;
            this.colrowguid.Name = "colrowguid";
            this.colrowguid.Visible = true;
            this.colrowguid.VisibleIndex = 8;
            this.colrowguid.Width = 112;
            // 
            // fKDatHangNhanVienBindingSource
            // 
            this.fKDatHangNhanVienBindingSource.DataMember = "FK_DatHang_NhanVien";
            this.fKDatHangNhanVienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 817);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.nhanVienBindingNavigator);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.groupChuyen);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStatusNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLuongNV.Properties)).EndInit();
            this.groupChuyen.ResumeLayout(false);
            this.groupChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).EndInit();
            this.nhanVienBindingNavigator.ResumeLayout(false);
            this.nhanVienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraBars.BarButtonItem btnSuaNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnUndoNV;
        private DevExpress.XtraBars.BarButtonItem btnRedoNV;
        private DevExpress.XtraBars.BarButtonItem btnRefreshNV;
        private DevExpress.XtraBars.BarButtonItem btnHuyNV;
        private DevExpress.XtraBars.BarButtonItem btnGhiNV;
        private DevExpress.XtraBars.BarButtonItem btnChuyenNV;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.GroupBox groupChuyen;
        private System.Windows.Forms.Button btnHuyChuyenCN;
        private System.Windows.Forms.Button btnChuyenCN;
        private System.Windows.Forms.ComboBox cbChiNhanhChuyen;
        private System.Windows.Forms.Label lblChiNhanhDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaNv;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtHoNV;
        private DevExpress.XtraEditors.TextEdit txtMaCNNV;
        private DevExpress.XtraEditors.TextEdit txtDiaChiNV;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.DateEdit dateNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.SpinEdit spnStatusNV;
        private DevExpress.XtraEditors.SpinEdit spnLuongNV;
        private System.Windows.Forms.BindingNavigator nhanVienBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nhanVienBindingNavigatorSaveItem;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource fKDatHangNhanVienBindingSource;
    }
}