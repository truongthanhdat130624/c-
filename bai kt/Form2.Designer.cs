﻿namespace bai_kt
{
    partial class Form2
    {
        private System.Windows.Forms.PictureBox pictureBoxStudent; // PictureBox để hiển thị ảnh
        private System.Windows.Forms.Button buttonChooseImage;   // Nút để chọn ảnh
        private System.Windows.Forms.DataGridView dgvDanhSach; // DataGridView để hiển thị danh sách sinh viên
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.MaskedTextBox mtxtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.mtxtMaSV = new System.Windows.Forms.MaskedTextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDiemLoc = new System.Windows.Forms.ComboBox();
            this.cbGioiTinhLoc = new System.Windows.Forms.ComboBox();
            this.cbKhoaLoc = new System.Windows.Forms.ComboBox();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(539, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonChooseImage);
            this.groupBox1.Controls.Add(this.pictureBoxStudent);
            this.groupBox1.Controls.Add(this.mtxtMaSV);
            this.groupBox1.Controls.Add(this.txtDiemTB);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(782, 65);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 13;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(694, 67);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 12;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(694, 27);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(148, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Năm sinh";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(959, 21);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(79, 35);
            this.buttonChooseImage.TabIndex = 9;
            this.buttonChooseImage.Text = "Chọn ảnh";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(848, 14);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(105, 89);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 8;
            this.pictureBoxStudent.TabStop = false;
            // 
            // mtxtMaSV
            // 
            this.mtxtMaSV.Location = new System.Drawing.Point(129, 29);
            this.mtxtMaSV.Name = "mtxtMaSV";
            this.mtxtMaSV.Size = new System.Drawing.Size(145, 22);
            this.mtxtMaSV.TabIndex = 9;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(397, 29);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(208, 22);
            this.txtDiemTB.TabIndex = 8;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Ngoại ngữ",
            "Công nghệ thông tin",
            "Quản trị kinh doanh"});
            this.cbKhoa.Location = new System.Drawing.Point(397, 66);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(208, 24);
            this.cbKhoa.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(145, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(239, 31);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 44);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Sửa";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(450, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(628, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 45);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(12, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1078, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeight = 29;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Hinh,
            this.NgaySinh,
            this.GioiTinh,
            this.HoTen,
            this.DiemTB,
            this.Khoa});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 27);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1066, 193);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(1143, 324);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(110, 45);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Khoa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giới tính";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Điểm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDiemLoc);
            this.groupBox4.Controls.Add(this.cbGioiTinhLoc);
            this.groupBox4.Controls.Add(this.cbKhoaLoc);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(1062, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 218);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bộ Lọc";
            // 
            // cbDiemLoc
            // 
            this.cbDiemLoc.FormattingEnabled = true;
            this.cbDiemLoc.Items.AddRange(new object[] {
            "Dưới 5",
            "5 đến 7",
            "Trên 7"});
            this.cbDiemLoc.Location = new System.Drawing.Point(81, 143);
            this.cbDiemLoc.Name = "cbDiemLoc";
            this.cbDiemLoc.Size = new System.Drawing.Size(124, 24);
            this.cbDiemLoc.TabIndex = 15;
            // 
            // cbGioiTinhLoc
            // 
            this.cbGioiTinhLoc.FormattingEnabled = true;
            this.cbGioiTinhLoc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinhLoc.Location = new System.Drawing.Point(81, 87);
            this.cbGioiTinhLoc.Name = "cbGioiTinhLoc";
            this.cbGioiTinhLoc.Size = new System.Drawing.Size(124, 24);
            this.cbGioiTinhLoc.TabIndex = 15;
            // 
            // cbKhoaLoc
            // 
            this.cbKhoaLoc.FormattingEnabled = true;
            this.cbKhoaLoc.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kế Toán",
            "Ngoại Ngữ",
            "Điện tử"});
            this.cbKhoaLoc.Location = new System.Drawing.Point(81, 29);
            this.cbKhoaLoc.Name = "cbKhoaLoc";
            this.cbKhoaLoc.Size = new System.Drawing.Size(124, 24);
            this.cbKhoaLoc.TabIndex = 15;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 120;
            // 
            // Hinh
            // 
            this.Hinh.HeaderText = "Hình";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 160;
            // 
            // DiemTB
            // 
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Width = 125;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 140;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1307, 559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbDiemLoc;
        private System.Windows.Forms.ComboBox cbGioiTinhLoc;
        private System.Windows.Forms.ComboBox cbKhoaLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}
