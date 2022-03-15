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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label donViTinhlabel;
            System.Windows.Forms.Label tenVatTuLabel;
            System.Windows.Forms.Label maVatTuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtMaVatTu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenVT = new DevExpress.XtraEditors.TextEdit();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxVatTu = new System.Windows.Forms.GroupBox();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlVatTu = new DevExpress.XtraGrid.GridControl();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVTv2.QLVT_DATHANGDataSet();
            this.vattuTableAdapter = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVTv2.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.fKCTDDHVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            donViTinhlabel = new System.Windows.Forms.Label();
            tenVatTuLabel = new System.Windows.Forms.Label();
            maVatTuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.groupBoxVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHVatTuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(531, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Số lượng";
            // 
            // donViTinhlabel
            // 
            donViTinhlabel.AutoSize = true;
            donViTinhlabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            donViTinhlabel.Location = new System.Drawing.Point(256, 102);
            donViTinhlabel.Name = "donViTinhlabel";
            donViTinhlabel.Size = new System.Drawing.Size(84, 15);
            donViTinhlabel.TabIndex = 2;
            donViTinhlabel.Text = "Đơn vị tính";
            // 
            // tenVatTuLabel
            // 
            tenVatTuLabel.AutoSize = true;
            tenVatTuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tenVatTuLabel.Location = new System.Drawing.Point(531, 50);
            tenVatTuLabel.Name = "tenVatTuLabel";
            tenVatTuLabel.Size = new System.Drawing.Size(77, 15);
            tenVatTuLabel.TabIndex = 2;
            tenVatTuLabel.Text = "Tên Vật tư";
            // 
            // maVatTuLabel
            // 
            maVatTuLabel.AutoSize = true;
            maVatTuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            maVatTuLabel.Location = new System.Drawing.Point(256, 50);
            maVatTuLabel.Name = "maVatTuLabel";
            maVatTuLabel.Size = new System.Drawing.Size(70, 15);
            maVatTuLabel.TabIndex = 0;
            maVatTuLabel.Text = "Mã Vật tư";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1376, 24);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
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
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ghi";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picture.Location = new System.Drawing.Point(19, 23);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(105, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.txtMaVatTu.Location = new System.Drawing.Point(346, 48);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Properties.MaxLength = 5;
            this.txtMaVatTu.Size = new System.Drawing.Size(148, 20);
            this.txtMaVatTu.TabIndex = 1;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.txtTenVT.Location = new System.Drawing.Point(621, 48);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Properties.MaxLength = 40;
            this.txtTenVT.Size = new System.Drawing.Size(148, 20);
            this.txtTenVT.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.txtDonViTinh.Location = new System.Drawing.Point(346, 100);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Properties.MaxLength = 40;
            this.txtDonViTinh.Size = new System.Drawing.Size(148, 20);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 8;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thóat";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl2.Location = new System.Drawing.Point(0, 24);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(0, 617);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.barButtonItem1,
            this.btnHuy,
            this.btnThoat,
            this.btnLamMoi});
            this.barManager2.MainMenu = this.bar4;
            this.barManager2.MaxItemId = 9;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(1376, 24);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl4.Location = new System.Drawing.Point(0, 641);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(1376, 0);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1376, 24);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(0, 617);
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "SOLUONGTON", true));
            this.txtSoLuong.Location = new System.Drawing.Point(621, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.MaxLength = 40;
            this.txtSoLuong.Size = new System.Drawing.Size(148, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // groupBoxVatTu
            // 
            this.groupBoxVatTu.AutoSize = true;
            this.groupBoxVatTu.Controls.Add(this.picture);
            this.groupBoxVatTu.Controls.Add(this.txtMaVatTu);
            this.groupBoxVatTu.Controls.Add(label1);
            this.groupBoxVatTu.Controls.Add(donViTinhlabel);
            this.groupBoxVatTu.Controls.Add(tenVatTuLabel);
            this.groupBoxVatTu.Controls.Add(maVatTuLabel);
            this.groupBoxVatTu.Controls.Add(this.txtTenVT);
            this.groupBoxVatTu.Controls.Add(this.txtDonViTinh);
            this.groupBoxVatTu.Controls.Add(this.txtSoLuong);
            this.groupBoxVatTu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxVatTu.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.groupBoxVatTu.Location = new System.Drawing.Point(0, 486);
            this.groupBoxVatTu.Name = "groupBoxVatTu";
            this.groupBoxVatTu.Size = new System.Drawing.Size(1376, 155);
            this.groupBoxVatTu.TabIndex = 48;
            this.groupBoxVatTu.TabStop = false;
            this.groupBoxVatTu.Text = "Nhập vật tư";
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gridControlVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // gridControlVatTu
            // 
            this.gridControlVatTu.DataSource = this.vattuBindingSource;
            this.gridControlVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlVatTu.Location = new System.Drawing.Point(0, 24);
            this.gridControlVatTu.MainView = this.gridView1;
            this.gridControlVatTu.Name = "gridControlVatTu";
            this.gridControlVatTu.Size = new System.Drawing.Size(1376, 456);
            this.gridControlVatTu.TabIndex = 46;
            this.gridControlVatTu.UseEmbeddedNavigator = true;
            this.gridControlVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTv2.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // fKCTDDHVatTuBindingSource
            // 
            this.fKCTDDHVatTuBindingSource.DataMember = "FK_CTDDH_VatTu";
            this.fKCTDDHVatTuBindingSource.DataSource = this.vattuBindingSource;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 641);
            this.Controls.Add(this.groupBoxVatTu);
            this.Controls.Add(this.gridControlVatTu);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmVatTu";
            this.Text = "frmVatTu";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.groupBoxVatTu.ResumeLayout(false);
            this.groupBoxVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHVatTuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.PictureBox picture;
        private DevExpress.XtraEditors.TextEdit txtMaVatTu;
        private DevExpress.XtraEditors.TextEdit txtTenVT;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private System.Windows.Forms.GroupBox groupBoxVatTu;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraGrid.GridControl gridControlVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource fKCTDDHVatTuBindingSource;
    }
}