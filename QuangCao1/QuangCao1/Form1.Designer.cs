namespace QuangCao1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuangCao = new System.Windows.Forms.Label();
            this.lblTenDaiDien = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblMangXaHoi = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.chkTimKiemDuLieu = new System.Windows.Forms.CheckBox();
            this.chkTimTenDaiDien = new System.Windows.Forms.CheckBox();
            this.chkTimSanPham = new System.Windows.Forms.CheckBox();
            this.txtTimTenDaiDien = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTenDaiDien = new System.Windows.Forms.TextBox();
            this.cboMangXaHoi = new System.Windows.Forms.ComboBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.cboTimSanPham = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tENDAIDIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANGXAHOIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANGCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khamSucKhoeDataSet = new QuangCao1.KhamSucKhoeDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qUANGCAOTableAdapter = new QuangCao1.KhamSucKhoeDataSetTableAdapters.QUANGCAOTableAdapter();
            this.tableAdapterManager = new QuangCao1.KhamSucKhoeDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANGCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khamSucKhoeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuangCao
            // 
            this.lblQuangCao.AutoSize = true;
            this.lblQuangCao.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuangCao.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblQuangCao.Location = new System.Drawing.Point(468, 24);
            this.lblQuangCao.Name = "lblQuangCao";
            this.lblQuangCao.Size = new System.Drawing.Size(170, 39);
            this.lblQuangCao.TabIndex = 0;
            this.lblQuangCao.Text = "Quảng Cáo";
            // 
            // lblTenDaiDien
            // 
            this.lblTenDaiDien.AutoSize = true;
            this.lblTenDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDaiDien.Location = new System.Drawing.Point(12, 126);
            this.lblTenDaiDien.Name = "lblTenDaiDien";
            this.lblTenDaiDien.Size = new System.Drawing.Size(97, 16);
            this.lblTenDaiDien.TabIndex = 1;
            this.lblTenDaiDien.Text = "Tên Đại Diện";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(12, 179);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(77, 16);
            this.lblSanPham.TabIndex = 2;
            this.lblSanPham.Text = "Sản Phẩm";
            // 
            // lblMangXaHoi
            // 
            this.lblMangXaHoi.AutoSize = true;
            this.lblMangXaHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangXaHoi.Location = new System.Drawing.Point(303, 126);
            this.lblMangXaHoi.Name = "lblMangXaHoi";
            this.lblMangXaHoi.Size = new System.Drawing.Size(95, 16);
            this.lblMangXaHoi.TabIndex = 3;
            this.lblMangXaHoi.Text = "Mạng Xã Hội";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(303, 179);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(71, 16);
            this.lblNoiDung.TabIndex = 4;
            this.lblNoiDung.Text = "Nội Dung";
            // 
            // chkTimKiemDuLieu
            // 
            this.chkTimKiemDuLieu.AutoSize = true;
            this.chkTimKiemDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimKiemDuLieu.Location = new System.Drawing.Point(738, 81);
            this.chkTimKiemDuLieu.Name = "chkTimKiemDuLieu";
            this.chkTimKiemDuLieu.Size = new System.Drawing.Size(149, 20);
            this.chkTimKiemDuLieu.TabIndex = 5;
            this.chkTimKiemDuLieu.Text = "Tìm Kiếm Dữ Liệu";
            this.chkTimKiemDuLieu.UseVisualStyleBackColor = true;
            this.chkTimKiemDuLieu.CheckedChanged += new System.EventHandler(this.chkTimKiemDuLieu_CheckedChanged);
            // 
            // chkTimTenDaiDien
            // 
            this.chkTimTenDaiDien.AutoSize = true;
            this.chkTimTenDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimTenDaiDien.Location = new System.Drawing.Point(621, 122);
            this.chkTimTenDaiDien.Name = "chkTimTenDaiDien";
            this.chkTimTenDaiDien.Size = new System.Drawing.Size(149, 20);
            this.chkTimTenDaiDien.TabIndex = 6;
            this.chkTimTenDaiDien.Text = "Tìm Tên Đại Diện";
            this.chkTimTenDaiDien.UseVisualStyleBackColor = true;
            this.chkTimTenDaiDien.CheckedChanged += new System.EventHandler(this.chkTimTenDaiDien_CheckedChanged);
            // 
            // chkTimSanPham
            // 
            this.chkTimSanPham.AutoSize = true;
            this.chkTimSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimSanPham.Location = new System.Drawing.Point(621, 175);
            this.chkTimSanPham.Name = "chkTimSanPham";
            this.chkTimSanPham.Size = new System.Drawing.Size(129, 20);
            this.chkTimSanPham.TabIndex = 7;
            this.chkTimSanPham.Text = "Tìm Sản Phẩm";
            this.chkTimSanPham.UseVisualStyleBackColor = true;
            this.chkTimSanPham.CheckedChanged += new System.EventHandler(this.chkTimSanPham_CheckedChanged);
            // 
            // txtTimTenDaiDien
            // 
            this.txtTimTenDaiDien.Location = new System.Drawing.Point(776, 118);
            this.txtTimTenDaiDien.Name = "txtTimTenDaiDien";
            this.txtTimTenDaiDien.Size = new System.Drawing.Size(223, 22);
            this.txtTimTenDaiDien.TabIndex = 8;
            this.txtTimTenDaiDien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimTenDaiDien_KeyDown);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(415, 174);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(182, 22);
            this.txtNoiDung.TabIndex = 9;
            // 
            // txtTenDaiDien
            // 
            this.txtTenDaiDien.Location = new System.Drawing.Point(115, 120);
            this.txtTenDaiDien.Name = "txtTenDaiDien";
            this.txtTenDaiDien.Size = new System.Drawing.Size(173, 22);
            this.txtTenDaiDien.TabIndex = 10;
            // 
            // cboMangXaHoi
            // 
            this.cboMangXaHoi.FormattingEnabled = true;
            this.cboMangXaHoi.Items.AddRange(new object[] {
            "Facebook",
            "Zalo",
            "Instagram",
            "TikTok"});
            this.cboMangXaHoi.Location = new System.Drawing.Point(415, 118);
            this.cboMangXaHoi.Name = "cboMangXaHoi";
            this.cboMangXaHoi.Size = new System.Drawing.Size(182, 24);
            this.cboMangXaHoi.TabIndex = 11;
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Items.AddRange(new object[] {
            "Bóng đá",
            "Áo tập luyện",
            "Áo di chuyển",
            "Áo thi đấu",
            "Bóng đá"});
            this.cboSanPham.Location = new System.Drawing.Point(115, 172);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(173, 24);
            this.cboSanPham.TabIndex = 12;
            // 
            // cboTimSanPham
            // 
            this.cboTimSanPham.FormattingEnabled = true;
            this.cboTimSanPham.Items.AddRange(new object[] {
            "Bóng đá",
            "Áo tập luyện",
            "Áo di chuyển",
            "Áo thi đấu",
            "Bóng đá"});
            this.cboTimSanPham.Location = new System.Drawing.Point(776, 171);
            this.cboTimSanPham.Name = "cboTimSanPham";
            this.cboTimSanPham.Size = new System.Drawing.Size(223, 24);
            this.cboTimSanPham.TabIndex = 13;
            this.cboTimSanPham.SelectedIndexChanged += new System.EventHandler(this.cboTimSanPham_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.Location = new System.Drawing.Point(15, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Olive;
            this.btnXoa.Location = new System.Drawing.Point(375, 246);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Location = new System.Drawing.Point(200, 246);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Purple;
            this.btnLuu.Location = new System.Drawing.Point(554, 246);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuyBo.Location = new System.Drawing.Point(749, 246);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(107, 34);
            this.btnHuyBo.TabIndex = 18;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Teal;
            this.btnTimKiem.Location = new System.Drawing.Point(963, 246);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 34);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(1180, 246);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(127, 34);
            this.btnXuatExcel.TabIndex = 20;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
        
            // 
            // dgvMain
            // 
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tENDAIDIENDataGridViewTextBoxColumn,
            this.sANPHAMDataGridViewTextBoxColumn,
            this.mANGXAHOIDataGridViewTextBoxColumn,
            this.nOIDUNGDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.qUANGCAOBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.GridColor = System.Drawing.Color.Black;
            this.dgvMain.Location = new System.Drawing.Point(48, 315);
            this.dgvMain.Name = "dgvMain";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(1259, 338);
            this.dgvMain.TabIndex = 21;
            // 
            // tENDAIDIENDataGridViewTextBoxColumn
            // 
            this.tENDAIDIENDataGridViewTextBoxColumn.DataPropertyName = "TENDAIDIEN";
            this.tENDAIDIENDataGridViewTextBoxColumn.HeaderText = "Tên Đại Diện";
            this.tENDAIDIENDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.tENDAIDIENDataGridViewTextBoxColumn.Name = "tENDAIDIENDataGridViewTextBoxColumn";
            this.tENDAIDIENDataGridViewTextBoxColumn.Width = 220;
            // 
            // sANPHAMDataGridViewTextBoxColumn
            // 
            this.sANPHAMDataGridViewTextBoxColumn.DataPropertyName = "SANPHAM";
            this.sANPHAMDataGridViewTextBoxColumn.HeaderText = "Sản Phẩm";
            this.sANPHAMDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.sANPHAMDataGridViewTextBoxColumn.Name = "sANPHAMDataGridViewTextBoxColumn";
            this.sANPHAMDataGridViewTextBoxColumn.Width = 220;
            // 
            // mANGXAHOIDataGridViewTextBoxColumn
            // 
            this.mANGXAHOIDataGridViewTextBoxColumn.DataPropertyName = "MANGXAHOI";
            this.mANGXAHOIDataGridViewTextBoxColumn.HeaderText = "Mạng Xã Hội";
            this.mANGXAHOIDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.mANGXAHOIDataGridViewTextBoxColumn.Name = "mANGXAHOIDataGridViewTextBoxColumn";
            this.mANGXAHOIDataGridViewTextBoxColumn.Width = 220;
            // 
            // nOIDUNGDataGridViewTextBoxColumn
            // 
            this.nOIDUNGDataGridViewTextBoxColumn.DataPropertyName = "NOIDUNG";
            this.nOIDUNGDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.nOIDUNGDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.nOIDUNGDataGridViewTextBoxColumn.Name = "nOIDUNGDataGridViewTextBoxColumn";
            this.nOIDUNGDataGridViewTextBoxColumn.Width = 220;
            // 
            // qUANGCAOBindingSource
            // 
            this.qUANGCAOBindingSource.DataMember = "QUANGCAO";
            this.qUANGCAOBindingSource.DataSource = this.khamSucKhoeDataSet;
            // 
            // khamSucKhoeDataSet
            // 
            this.khamSucKhoeDataSet.DataSetName = "KhamSucKhoeDataSet";
            this.khamSucKhoeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuangCao1.Properties.Resources.quang_cao;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // qUANGCAOTableAdapter
            // 
            this.qUANGCAOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QUANGCAOTableAdapter = this.qUANGCAOTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuangCao1.KhamSucKhoeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VETableAdapter = null;
            this.tableAdapterManager.YTETableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTimSanPham);
            this.Controls.Add(this.cboSanPham);
            this.Controls.Add(this.cboMangXaHoi);
            this.Controls.Add(this.txtTenDaiDien);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtTimTenDaiDien);
            this.Controls.Add(this.chkTimSanPham);
            this.Controls.Add(this.chkTimTenDaiDien);
            this.Controls.Add(this.chkTimKiemDuLieu);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblMangXaHoi);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.lblTenDaiDien);
            this.Controls.Add(this.lblQuangCao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANGCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khamSucKhoeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuangCao;
        private System.Windows.Forms.Label lblTenDaiDien;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblMangXaHoi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.CheckBox chkTimKiemDuLieu;
        private System.Windows.Forms.CheckBox chkTimTenDaiDien;
        private System.Windows.Forms.CheckBox chkTimSanPham;
        private System.Windows.Forms.TextBox txtTimTenDaiDien;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTenDaiDien;
        private System.Windows.Forms.ComboBox cboMangXaHoi;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.ComboBox cboTimSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KhamSucKhoeDataSet khamSucKhoeDataSet;
        private System.Windows.Forms.BindingSource qUANGCAOBindingSource;
        private KhamSucKhoeDataSetTableAdapters.QUANGCAOTableAdapter qUANGCAOTableAdapter;
        private KhamSucKhoeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDAIDIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANGXAHOIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIDUNGDataGridViewTextBoxColumn;
    }
}

