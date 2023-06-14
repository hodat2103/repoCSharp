namespace BangVe_BV
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
            this.lblBangVe = new System.Windows.Forms.Label();
            this.lblDoiThu = new System.Windows.Forms.Label();
            this.lblKhanDai = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.lblNgayThiDau = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtDoiThu = new System.Windows.Forms.TextBox();
            this.cboTimTenKhanDai = new System.Windows.Forms.ComboBox();
            this.cboKhanDai = new System.Windows.Forms.ComboBox();
            this.chkTimKiemDuLieu = new System.Windows.Forms.CheckBox();
            this.chkTimNgayThiDau = new System.Windows.Forms.CheckBox();
            this.chkTimTenKhanDai = new System.Windows.Forms.CheckBox();
            this.dtpTimNgayThiDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThiDau = new System.Windows.Forms.DateTimePicker();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.vEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khamSucKhoeDataSet1 = new BangVe_BV.KhamSucKhoeDataSet1();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vETableAdapter = new BangVe_BV.KhamSucKhoeDataSet1TableAdapters.VETableAdapter();
            this.tableAdapterManager = new BangVe_BV.KhamSucKhoeDataSet1TableAdapters.TableAdapterManager();
            this.mAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOITHUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHANDAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTHIDAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khamSucKhoeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBangVe
            // 
            this.lblBangVe.AutoSize = true;
            this.lblBangVe.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangVe.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblBangVe.Location = new System.Drawing.Point(449, 23);
            this.lblBangVe.Name = "lblBangVe";
            this.lblBangVe.Size = new System.Drawing.Size(155, 38);
            this.lblBangVe.TabIndex = 0;
            this.lblBangVe.Text = "Bảng Vé";
            // 
            // lblDoiThu
            // 
            this.lblDoiThu.AutoSize = true;
            this.lblDoiThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiThu.Location = new System.Drawing.Point(29, 162);
            this.lblDoiThu.Name = "lblDoiThu";
            this.lblDoiThu.Size = new System.Drawing.Size(67, 18);
            this.lblDoiThu.TabIndex = 1;
            this.lblDoiThu.Text = "Đối Thủ";
            // 
            // lblKhanDai
            // 
            this.lblKhanDai.AutoSize = true;
            this.lblKhanDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhanDai.Location = new System.Drawing.Point(29, 217);
            this.lblKhanDai.Name = "lblKhanDai";
            this.lblKhanDai.Size = new System.Drawing.Size(76, 18);
            this.lblKhanDai.TabIndex = 2;
            this.lblKhanDai.Text = "Khán Đài";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVe.Location = new System.Drawing.Point(302, 165);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(58, 18);
            this.lblGiaVe.TabIndex = 3;
            this.lblGiaVe.Text = "Giá Vé";
            // 
            // lblNgayThiDau
            // 
            this.lblNgayThiDau.AutoSize = true;
            this.lblNgayThiDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThiDau.Location = new System.Drawing.Point(302, 217);
            this.lblNgayThiDau.Name = "lblNgayThiDau";
            this.lblNgayThiDau.Size = new System.Drawing.Size(109, 18);
            this.lblNgayThiDau.TabIndex = 4;
            this.lblNgayThiDau.Text = "Ngày Thi Đấu";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(429, 156);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(175, 22);
            this.txtGiaVe.TabIndex = 5;
            // 
            // txtDoiThu
            // 
            this.txtDoiThu.Location = new System.Drawing.Point(111, 161);
            this.txtDoiThu.Name = "txtDoiThu";
            this.txtDoiThu.Size = new System.Drawing.Size(174, 22);
            this.txtDoiThu.TabIndex = 6;
            // 
            // cboTimTenKhanDai
            // 
            this.cboTimTenKhanDai.FormattingEnabled = true;
            this.cboTimTenKhanDai.Items.AddRange(new object[] {
            "T1",
            "M1",
            "P1",
            "B1"});
            this.cboTimTenKhanDai.Location = new System.Drawing.Point(813, 211);
            this.cboTimTenKhanDai.Name = "cboTimTenKhanDai";
            this.cboTimTenKhanDai.Size = new System.Drawing.Size(174, 24);
            this.cboTimTenKhanDai.TabIndex = 7;
            this.cboTimTenKhanDai.SelectedIndexChanged += new System.EventHandler(this.cboTimTenKhanDai_SelectedIndexChanged);
            // 
            // cboKhanDai
            // 
            this.cboKhanDai.FormattingEnabled = true;
            this.cboKhanDai.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "C1",
            "C2",
            "C3",
            "C4",
            "D1",
            "D2",
            "D3",
            "D4"});
            this.cboKhanDai.Location = new System.Drawing.Point(111, 211);
            this.cboKhanDai.Name = "cboKhanDai";
            this.cboKhanDai.Size = new System.Drawing.Size(174, 24);
            this.cboKhanDai.TabIndex = 8;
            // 
            // chkTimKiemDuLieu
            // 
            this.chkTimKiemDuLieu.AutoSize = true;
            this.chkTimKiemDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimKiemDuLieu.Location = new System.Drawing.Point(706, 105);
            this.chkTimKiemDuLieu.Name = "chkTimKiemDuLieu";
            this.chkTimKiemDuLieu.Size = new System.Drawing.Size(182, 24);
            this.chkTimKiemDuLieu.TabIndex = 9;
            this.chkTimKiemDuLieu.Text = "Tìm Kiếm Dữ Liệu";
            this.chkTimKiemDuLieu.UseVisualStyleBackColor = true;
            this.chkTimKiemDuLieu.CheckedChanged += new System.EventHandler(this.chkTimKiemDuLieu_CheckedChanged);
            // 
            // chkTimNgayThiDau
            // 
            this.chkTimNgayThiDau.AutoSize = true;
            this.chkTimNgayThiDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimNgayThiDau.Location = new System.Drawing.Point(632, 160);
            this.chkTimNgayThiDau.Name = "chkTimNgayThiDau";
            this.chkTimNgayThiDau.Size = new System.Drawing.Size(153, 20);
            this.chkTimNgayThiDau.TabIndex = 10;
            this.chkTimNgayThiDau.Text = "Tìm Ngày Thi Đấu";
            this.chkTimNgayThiDau.UseVisualStyleBackColor = true;
            this.chkTimNgayThiDau.CheckedChanged += new System.EventHandler(this.chkTimNgayThiDau_CheckedChanged);
            // 
            // chkTimTenKhanDai
            // 
            this.chkTimTenKhanDai.AutoSize = true;
            this.chkTimTenKhanDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimTenKhanDai.Location = new System.Drawing.Point(632, 218);
            this.chkTimTenKhanDai.Name = "chkTimTenKhanDai";
            this.chkTimTenKhanDai.Size = new System.Drawing.Size(151, 20);
            this.chkTimTenKhanDai.TabIndex = 11;
            this.chkTimTenKhanDai.Text = "Tìm Tên Khán Đài";
            this.chkTimTenKhanDai.UseVisualStyleBackColor = true;
            this.chkTimTenKhanDai.CheckedChanged += new System.EventHandler(this.chkTimTenKhanDai_CheckedChanged);
            // 
            // dtpTimNgayThiDau
            // 
            this.dtpTimNgayThiDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimNgayThiDau.Location = new System.Drawing.Point(813, 159);
            this.dtpTimNgayThiDau.Name = "dtpTimNgayThiDau";
            this.dtpTimNgayThiDau.Size = new System.Drawing.Size(174, 22);
            this.dtpTimNgayThiDau.TabIndex = 12;
            this.dtpTimNgayThiDau.ValueChanged += new System.EventHandler(this.dtpTimNgayThiDau_ValueChanged);
            // 
            // dtpNgayThiDau
            // 
            this.dtpNgayThiDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThiDau.Location = new System.Drawing.Point(429, 213);
            this.dtpNgayThiDau.Name = "dtpNgayThiDau";
            this.dtpNgayThiDau.Size = new System.Drawing.Size(175, 22);
            this.dtpNgayThiDau.TabIndex = 13;
            // 
            // dgvMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAVEDataGridViewTextBoxColumn,
            this.dOITHUDataGridViewTextBoxColumn,
            this.kHANDAIDataGridViewTextBoxColumn,
            this.gIAVEDataGridViewTextBoxColumn,
            this.nGAYTHIDAUDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.vEBindingSource;
            this.dgvMain.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMain.Location = new System.Drawing.Point(32, 362);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(1247, 347);
            this.dgvMain.TabIndex = 14;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // vEBindingSource
            // 
            this.vEBindingSource.DataMember = "VE";
            this.vEBindingSource.DataSource = this.khamSucKhoeDataSet1;
            // 
            // khamSucKhoeDataSet1
            // 
            this.khamSucKhoeDataSet1.DataSetName = "KhamSucKhoeDataSet1";
            this.khamSucKhoeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Location = new System.Drawing.Point(32, 290);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Teal;
            this.btnSua.Location = new System.Drawing.Point(170, 290);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Olive;
            this.btnXoa.Location = new System.Drawing.Point(336, 290);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnLuu.Location = new System.Drawing.Point(482, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.Crimson;
            this.btnHuyBo.Location = new System.Drawing.Point(645, 290);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 33);
            this.btnHuyBo.TabIndex = 19;
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(813, 290);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 33);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatExcel.Location = new System.Drawing.Point(953, 290);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(128, 33);
            this.btnXuatExcel.TabIndex = 21;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(1140, 290);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(139, 33);
            this.btnXuatBaoCao.TabIndex = 22;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BangVe_BV.Properties.Resources.vé_đb;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(111, 110);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(174, 22);
            this.txtMaVe.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Vé";
            // 
            // vETableAdapter
            // 
            this.vETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QUANGCAOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BangVe_BV.KhamSucKhoeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VETableAdapter = this.vETableAdapter;
            this.tableAdapterManager.YTETableAdapter = null;
            // 
            // mAVEDataGridViewTextBoxColumn
            // 
            this.mAVEDataGridViewTextBoxColumn.DataPropertyName = "MAVE";
            this.mAVEDataGridViewTextBoxColumn.HeaderText = "Mã Vé";
            this.mAVEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.mAVEDataGridViewTextBoxColumn.Name = "mAVEDataGridViewTextBoxColumn";
            this.mAVEDataGridViewTextBoxColumn.Width = 190;
            // 
            // dOITHUDataGridViewTextBoxColumn
            // 
            this.dOITHUDataGridViewTextBoxColumn.DataPropertyName = "DOITHU";
            this.dOITHUDataGridViewTextBoxColumn.HeaderText = "Đối Thủ";
            this.dOITHUDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dOITHUDataGridViewTextBoxColumn.Name = "dOITHUDataGridViewTextBoxColumn";
            this.dOITHUDataGridViewTextBoxColumn.Width = 190;
            // 
            // kHANDAIDataGridViewTextBoxColumn
            // 
            this.kHANDAIDataGridViewTextBoxColumn.DataPropertyName = "KHANDAI";
            this.kHANDAIDataGridViewTextBoxColumn.HeaderText = "Khán Đài";
            this.kHANDAIDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.kHANDAIDataGridViewTextBoxColumn.Name = "kHANDAIDataGridViewTextBoxColumn";
            this.kHANDAIDataGridViewTextBoxColumn.Width = 190;
            // 
            // gIAVEDataGridViewTextBoxColumn
            // 
            this.gIAVEDataGridViewTextBoxColumn.DataPropertyName = "GIAVE";
            this.gIAVEDataGridViewTextBoxColumn.HeaderText = "Giá Vé";
            this.gIAVEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gIAVEDataGridViewTextBoxColumn.Name = "gIAVEDataGridViewTextBoxColumn";
            this.gIAVEDataGridViewTextBoxColumn.Width = 190;
            // 
            // nGAYTHIDAUDataGridViewTextBoxColumn
            // 
            this.nGAYTHIDAUDataGridViewTextBoxColumn.DataPropertyName = "NGAYTHIDAU";
            this.nGAYTHIDAUDataGridViewTextBoxColumn.HeaderText = "Ngày Thi Đấu";
            this.nGAYTHIDAUDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nGAYTHIDAUDataGridViewTextBoxColumn.Name = "nGAYTHIDAUDataGridViewTextBoxColumn";
            this.nGAYTHIDAUDataGridViewTextBoxColumn.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 752);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.dtpNgayThiDau);
            this.Controls.Add(this.dtpTimNgayThiDau);
            this.Controls.Add(this.chkTimTenKhanDai);
            this.Controls.Add(this.chkTimNgayThiDau);
            this.Controls.Add(this.chkTimKiemDuLieu);
            this.Controls.Add(this.cboKhanDai);
            this.Controls.Add(this.cboTimTenKhanDai);
            this.Controls.Add(this.txtDoiThu);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.lblNgayThiDau);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.lblKhanDai);
            this.Controls.Add(this.lblDoiThu);
            this.Controls.Add(this.lblBangVe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khamSucKhoeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBangVe;
        private System.Windows.Forms.Label lblDoiThu;
        private System.Windows.Forms.Label lblKhanDai;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.Label lblNgayThiDau;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtDoiThu;
        private System.Windows.Forms.ComboBox cboTimTenKhanDai;
        private System.Windows.Forms.ComboBox cboKhanDai;
        private System.Windows.Forms.CheckBox chkTimKiemDuLieu;
        private System.Windows.Forms.CheckBox chkTimNgayThiDau;
        private System.Windows.Forms.CheckBox chkTimTenKhanDai;
        private System.Windows.Forms.DateTimePicker dtpTimNgayThiDau;
        private System.Windows.Forms.DateTimePicker dtpNgayThiDau;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label1;
        private KhamSucKhoeDataSet1 khamSucKhoeDataSet1;
        private System.Windows.Forms.BindingSource vEBindingSource;
        private KhamSucKhoeDataSet1TableAdapters.VETableAdapter vETableAdapter;
        private KhamSucKhoeDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOITHUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHANDAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTHIDAUDataGridViewTextBoxColumn;
    }
}

