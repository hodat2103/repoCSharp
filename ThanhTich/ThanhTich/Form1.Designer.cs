namespace ThanhTich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbGiaiDau = new System.Windows.Forms.ComboBox();
            this.dgvThanhTich = new System.Windows.Forms.DataGridView();
            this.tBLTHANHTICHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHANHTICHDataSet = new ThanhTich.THANHTICHDataSet();
            this.txtThanhTichDatDuoc = new System.Windows.Forms.TextBox();
            this.chkTimKiem = new System.Windows.Forms.CheckBox();
            this.chkTimKiemTheoNgayDatGiai = new System.Windows.Forms.CheckBox();
            this.chkTimKiemTheoMaGiaiDau = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbbTimKiemTheoMaGiaiDau = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayDatGiai = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaGiaiDau = new System.Windows.Forms.TextBox();
            this.txtTimKiemTheoNgayDatGiai = new System.Windows.Forms.TextBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.tBLTHANHTICHTableAdapter = new ThanhTich.THANHTICHDataSetTableAdapters.TBLTHANHTICHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTHANHTICHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTICHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÀNH TÍCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thành tích đạt được";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giải đấu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbbNam.Location = new System.Drawing.Point(127, 125);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(288, 28);
            this.cbbNam.TabIndex = 8;
            // 
            // cbbGiaiDau
            // 
            this.cbbGiaiDau.FormattingEnabled = true;
            this.cbbGiaiDau.Items.AddRange(new object[] {
            "Giải bóng đá Vô địch Quốc gia Việt Nam (V. League 1)",
            "Giải bóng đá Cúp Quốc gia"});
            this.cbbGiaiDau.Location = new System.Drawing.Point(144, 181);
            this.cbbGiaiDau.Name = "cbbGiaiDau";
            this.cbbGiaiDau.Size = new System.Drawing.Size(271, 28);
            this.cbbGiaiDau.TabIndex = 9;
            this.cbbGiaiDau.SelectedIndexChanged += new System.EventHandler(this.cbbGiaiDau_SelectedIndexChanged);
            // 
            // dgvThanhTich
            // 
            this.dgvThanhTich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhTich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhTich.Location = new System.Drawing.Point(30, 363);
            this.dgvThanhTich.Name = "dgvThanhTich";
            this.dgvThanhTich.RowHeadersWidth = 62;
            this.dgvThanhTich.RowTemplate.Height = 28;
            this.dgvThanhTich.Size = new System.Drawing.Size(1085, 303);
            this.dgvThanhTich.TabIndex = 10;
            this.dgvThanhTich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhTich_CellClick);
            // 
            // tBLTHANHTICHBindingSource
            // 
            this.tBLTHANHTICHBindingSource.DataMember = "TBLTHANHTICH";
            this.tBLTHANHTICHBindingSource.DataSource = this.tHANHTICHDataSet;
            // 
            // tHANHTICHDataSet
            // 
            this.tHANHTICHDataSet.DataSetName = "THANHTICHDataSet";
            this.tHANHTICHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtThanhTichDatDuoc
            // 
            this.txtThanhTichDatDuoc.Location = new System.Drawing.Point(222, 235);
            this.txtThanhTichDatDuoc.Name = "txtThanhTichDatDuoc";
            this.txtThanhTichDatDuoc.Size = new System.Drawing.Size(193, 26);
            this.txtThanhTichDatDuoc.TabIndex = 11;
            // 
            // chkTimKiem
            // 
            this.chkTimKiem.AutoSize = true;
            this.chkTimKiem.Location = new System.Drawing.Point(481, 148);
            this.chkTimKiem.Name = "chkTimKiem";
            this.chkTimKiem.Size = new System.Drawing.Size(97, 24);
            this.chkTimKiem.TabIndex = 13;
            this.chkTimKiem.Text = "Tìm kiếm";
            this.chkTimKiem.UseVisualStyleBackColor = true;
            this.chkTimKiem.CheckedChanged += new System.EventHandler(this.chkTimKiem_CheckedChanged);
            // 
            // chkTimKiemTheoNgayDatGiai
            // 
            this.chkTimKiemTheoNgayDatGiai.AutoSize = true;
            this.chkTimKiemTheoNgayDatGiai.Location = new System.Drawing.Point(481, 254);
            this.chkTimKiemTheoNgayDatGiai.Name = "chkTimKiemTheoNgayDatGiai";
            this.chkTimKiemTheoNgayDatGiai.Size = new System.Drawing.Size(226, 24);
            this.chkTimKiemTheoNgayDatGiai.TabIndex = 14;
            this.chkTimKiemTheoNgayDatGiai.Text = "Tìm kiếm theo ngày đạt giải";
            this.chkTimKiemTheoNgayDatGiai.UseVisualStyleBackColor = true;
            this.chkTimKiemTheoNgayDatGiai.CheckedChanged += new System.EventHandler(this.chkTimKiemTheoNgayDatGiai_CheckedChanged);
            // 
            // chkTimKiemTheoMaGiaiDau
            // 
            this.chkTimKiemTheoMaGiaiDau.AutoSize = true;
            this.chkTimKiemTheoMaGiaiDau.Location = new System.Drawing.Point(481, 198);
            this.chkTimKiemTheoMaGiaiDau.Name = "chkTimKiemTheoMaGiaiDau";
            this.chkTimKiemTheoMaGiaiDau.Size = new System.Drawing.Size(218, 24);
            this.chkTimKiemTheoMaGiaiDau.TabIndex = 15;
            this.chkTimKiemTheoMaGiaiDau.Text = "Tìm kiếm theo mã giải đấu";
            this.chkTimKiemTheoMaGiaiDau.UseVisualStyleBackColor = true;
            this.chkTimKiemTheoMaGiaiDau.CheckedChanged += new System.EventHandler(this.chkTimKiemTheoMaGiaiDau_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(483, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(944, 75);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(830, 75);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(714, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(600, 74);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbTimKiemTheoMaGiaiDau
            // 
            this.cbbTimKiemTheoMaGiaiDau.FormattingEnabled = true;
            this.cbbTimKiemTheoMaGiaiDau.Location = new System.Drawing.Point(713, 194);
            this.cbbTimKiemTheoMaGiaiDau.Name = "cbbTimKiemTheoMaGiaiDau";
            this.cbbTimKiemTheoMaGiaiDau.Size = new System.Drawing.Size(217, 28);
            this.cbbTimKiemTheoMaGiaiDau.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ngày đạt giải";
            // 
            // dtpNgayDatGiai
            // 
            this.dtpNgayDatGiai.Location = new System.Drawing.Point(193, 292);
            this.dtpNgayDatGiai.Name = "dtpNgayDatGiai";
            this.dtpNgayDatGiai.Size = new System.Drawing.Size(222, 26);
            this.dtpNgayDatGiai.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã giải đấu";
            // 
            // txtMaGiaiDau
            // 
            this.txtMaGiaiDau.Location = new System.Drawing.Point(164, 75);
            this.txtMaGiaiDau.Name = "txtMaGiaiDau";
            this.txtMaGiaiDau.Size = new System.Drawing.Size(251, 26);
            this.txtMaGiaiDau.TabIndex = 32;
            // 
            // txtTimKiemTheoNgayDatGiai
            // 
            this.txtTimKiemTheoNgayDatGiai.Location = new System.Drawing.Point(712, 254);
            this.txtTimKiemTheoNgayDatGiai.Name = "txtTimKiemTheoNgayDatGiai";
            this.txtTimKiemTheoNgayDatGiai.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemTheoNgayDatGiai.TabIndex = 33;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(897, 138);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(122, 34);
            this.btnXuatExcel.TabIndex = 34;
            this.btnXuatExcel.Text = "XUẤT EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // tBLTHANHTICHTableAdapter
            // 
            this.tBLTHANHTICHTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 681);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.txtTimKiemTheoNgayDatGiai);
            this.Controls.Add(this.txtMaGiaiDau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNgayDatGiai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbTimKiemTheoMaGiaiDau);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.chkTimKiemTheoMaGiaiDau);
            this.Controls.Add(this.chkTimKiemTheoNgayDatGiai);
            this.Controls.Add(this.chkTimKiem);
            this.Controls.Add(this.txtThanhTichDatDuoc);
            this.Controls.Add(this.dgvThanhTich);
            this.Controls.Add(this.cbbGiaiDau);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTHANHTICHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHTICHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbGiaiDau;
        private System.Windows.Forms.DataGridView dgvThanhTich;
        private System.Windows.Forms.TextBox txtThanhTichDatDuoc;
        private System.Windows.Forms.CheckBox chkTimKiem;
        private System.Windows.Forms.CheckBox chkTimKiemTheoNgayDatGiai;
        private System.Windows.Forms.CheckBox chkTimKiemTheoMaGiaiDau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbbTimKiemTheoMaGiaiDau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayDatGiai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaGiaiDau;
        private System.Windows.Forms.TextBox txtTimKiemTheoNgayDatGiai;
        private System.Windows.Forms.Button btnXuatExcel;
        private THANHTICHDataSet tHANHTICHDataSet;
        private System.Windows.Forms.BindingSource tBLTHANHTICHBindingSource;
        private THANHTICHDataSetTableAdapters.TBLTHANHTICHTableAdapter tBLTHANHTICHTableAdapter;
    }
}

