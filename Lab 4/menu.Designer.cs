namespace Lab_4
{
    partial class menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtEmailKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.txtNgayDatHang = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtMaKhachHangFK = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4DataSet2 = new Lab_4.Lab4DataSet2();
            this.dataGridViewDonDatHang = new System.Windows.Forms.DataGridView();
            this.maĐHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayĐHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4DataSet3 = new Lab_4.Lab4DataSet3();
            this.btn_ThemKhachHang = new System.Windows.Forms.Button();
            this.btn_XoaKhachHang = new System.Windows.Forms.Button();
            this.btn_SuaKhachHang = new System.Windows.Forms.Button();
            this.btn_ThemDonDatHang = new System.Windows.Forms.Button();
            this.btn_SuaDonDatHang = new System.Windows.Forms.Button();
            this.khachHangTableAdapter = new Lab_4.Lab4DataSet2TableAdapters.KhachHangTableAdapter();
            this.donDatHangTableAdapter = new Lab_4.Lab4DataSet3TableAdapters.DonDatHangTableAdapter();
            this.btn_XoaDonDatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(407, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1487, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn đặt hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(990, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 1080);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 492);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1060, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã đặt hàng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1060, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày đặt hàng: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1060, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Trạng thái: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1060, 420);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã khách hàng: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1060, 488);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mã nhân viên: ";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(201, 160);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(300, 26);
            this.txtMaKhachHang.TabIndex = 12;
            // 
            // txtEmailKhachHang
            // 
            this.txtEmailKhachHang.Location = new System.Drawing.Point(201, 488);
            this.txtEmailKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailKhachHang.Name = "txtEmailKhachHang";
            this.txtEmailKhachHang.Size = new System.Drawing.Size(300, 26);
            this.txtEmailKhachHang.TabIndex = 13;
            // 
            // txtSoDienThoaiKhachHang
            // 
            this.txtSoDienThoaiKhachHang.Location = new System.Drawing.Point(201, 409);
            this.txtSoDienThoaiKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoaiKhachHang.Name = "txtSoDienThoaiKhachHang";
            this.txtSoDienThoaiKhachHang.Size = new System.Drawing.Size(300, 26);
            this.txtSoDienThoaiKhachHang.TabIndex = 14;
            // 
            // txtDiaChiKhachHang
            // 
            this.txtDiaChiKhachHang.Location = new System.Drawing.Point(201, 323);
            this.txtDiaChiKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            this.txtDiaChiKhachHang.Size = new System.Drawing.Size(300, 26);
            this.txtDiaChiKhachHang.TabIndex = 15;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(201, 241);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(300, 26);
            this.txtTenKhachHang.TabIndex = 16;
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Location = new System.Drawing.Point(1208, 160);
            this.txtMaDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(288, 26);
            this.txtMaDatHang.TabIndex = 17;
            // 
            // txtNgayDatHang
            // 
            this.txtNgayDatHang.Location = new System.Drawing.Point(1208, 235);
            this.txtNgayDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayDatHang.Name = "txtNgayDatHang";
            this.txtNgayDatHang.Size = new System.Drawing.Size(288, 26);
            this.txtNgayDatHang.TabIndex = 18;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(1208, 317);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(288, 26);
            this.txtTrangThai.TabIndex = 19;
            // 
            // txtMaKhachHangFK
            // 
            this.txtMaKhachHangFK.Location = new System.Drawing.Point(1208, 409);
            this.txtMaKhachHangFK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhachHangFK.Name = "txtMaKhachHangFK";
            this.txtMaKhachHangFK.Size = new System.Drawing.Size(288, 26);
            this.txtMaKhachHangFK.TabIndex = 20;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(1208, 483);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(288, 26);
            this.txtMaNhanVien.TabIndex = 21;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AutoGenerateColumns = false;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewKhachHang.DataSource = this.khachHangBindingSource;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(4, 546);
            this.dataGridViewKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 62;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(934, 386);
            this.dataGridViewKhachHang.TabIndex = 22;
            this.dataGridViewKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellContentClick);
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.lab4DataSet2;
            // 
            // lab4DataSet2
            // 
            this.lab4DataSet2.DataSetName = "Lab4DataSet2";
            this.lab4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewDonDatHang
            // 
            this.dataGridViewDonDatHang.AutoGenerateColumns = false;
            this.dataGridViewDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maĐHDataGridViewTextBoxColumn,
            this.ngayĐHDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn1,
            this.maNVDataGridViewTextBoxColumn});
            this.dataGridViewDonDatHang.DataSource = this.donDatHangBindingSource;
            this.dataGridViewDonDatHang.Location = new System.Drawing.Point(1052, 546);
            this.dataGridViewDonDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDonDatHang.Name = "dataGridViewDonDatHang";
            this.dataGridViewDonDatHang.RowHeadersWidth = 62;
            this.dataGridViewDonDatHang.Size = new System.Drawing.Size(856, 386);
            this.dataGridViewDonDatHang.TabIndex = 23;
            this.dataGridViewDonDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonDatHang_CellContentClick);
            // 
            // maĐHDataGridViewTextBoxColumn
            // 
            this.maĐHDataGridViewTextBoxColumn.DataPropertyName = "MaĐH";
            this.maĐHDataGridViewTextBoxColumn.HeaderText = "MaĐH";
            this.maĐHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maĐHDataGridViewTextBoxColumn.Name = "maĐHDataGridViewTextBoxColumn";
            this.maĐHDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayĐHDataGridViewTextBoxColumn
            // 
            this.ngayĐHDataGridViewTextBoxColumn.DataPropertyName = "NgayĐH";
            this.ngayĐHDataGridViewTextBoxColumn.HeaderText = "NgayĐH";
            this.ngayĐHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayĐHDataGridViewTextBoxColumn.Name = "ngayĐHDataGridViewTextBoxColumn";
            this.ngayĐHDataGridViewTextBoxColumn.Width = 150;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // maKHDataGridViewTextBoxColumn1
            // 
            this.maKHDataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.maKHDataGridViewTextBoxColumn1.Name = "maKHDataGridViewTextBoxColumn1";
            this.maKHDataGridViewTextBoxColumn1.Width = 150;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 150;
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";
            this.donDatHangBindingSource.DataSource = this.lab4DataSet3;
            // 
            // lab4DataSet3
            // 
            this.lab4DataSet3.DataSetName = "Lab4DataSet3";
            this.lab4DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(552, 231);
            this.btn_ThemKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(112, 35);
            this.btn_ThemKhachHang.TabIndex = 24;
            this.btn_ThemKhachHang.Text = "Thêm";
            this.btn_ThemKhachHang.UseVisualStyleBackColor = true;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
            // 
            // btn_XoaKhachHang
            // 
            this.btn_XoaKhachHang.Location = new System.Drawing.Point(702, 231);
            this.btn_XoaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XoaKhachHang.Name = "btn_XoaKhachHang";
            this.btn_XoaKhachHang.Size = new System.Drawing.Size(112, 35);
            this.btn_XoaKhachHang.TabIndex = 25;
            this.btn_XoaKhachHang.Text = "Xóa";
            this.btn_XoaKhachHang.UseVisualStyleBackColor = true;
            this.btn_XoaKhachHang.Click += new System.EventHandler(this.btn_XoaKhachHang_Click);
            // 
            // btn_SuaKhachHang
            // 
            this.btn_SuaKhachHang.Location = new System.Drawing.Point(839, 231);
            this.btn_SuaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SuaKhachHang.Name = "btn_SuaKhachHang";
            this.btn_SuaKhachHang.Size = new System.Drawing.Size(112, 35);
            this.btn_SuaKhachHang.TabIndex = 26;
            this.btn_SuaKhachHang.Text = "Sửa";
            this.btn_SuaKhachHang.UseVisualStyleBackColor = true;
            this.btn_SuaKhachHang.Click += new System.EventHandler(this.btn_SuaKhachHang_Click);
            // 
            // btn_ThemDonDatHang
            // 
            this.btn_ThemDonDatHang.Location = new System.Drawing.Point(1530, 237);
            this.btn_ThemDonDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ThemDonDatHang.Name = "btn_ThemDonDatHang";
            this.btn_ThemDonDatHang.Size = new System.Drawing.Size(112, 35);
            this.btn_ThemDonDatHang.TabIndex = 28;
            this.btn_ThemDonDatHang.Text = "Thêm";
            this.btn_ThemDonDatHang.UseVisualStyleBackColor = true;
            this.btn_ThemDonDatHang.Click += new System.EventHandler(this.btn_ThemDonDatHang_Click);
            // 
            // btn_SuaDonDatHang
            // 
            this.btn_SuaDonDatHang.Location = new System.Drawing.Point(1796, 238);
            this.btn_SuaDonDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SuaDonDatHang.Name = "btn_SuaDonDatHang";
            this.btn_SuaDonDatHang.Size = new System.Drawing.Size(112, 35);
            this.btn_SuaDonDatHang.TabIndex = 30;
            this.btn_SuaDonDatHang.Text = "Sửa";
            this.btn_SuaDonDatHang.UseVisualStyleBackColor = true;
            this.btn_SuaDonDatHang.Click += new System.EventHandler(this.btn_SuaDonDatHang_Click);
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // donDatHangTableAdapter
            // 
            this.donDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // btn_XoaDonDatHang
            // 
            this.btn_XoaDonDatHang.Location = new System.Drawing.Point(1662, 239);
            this.btn_XoaDonDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XoaDonDatHang.Name = "btn_XoaDonDatHang";
            this.btn_XoaDonDatHang.Size = new System.Drawing.Size(112, 35);
            this.btn_XoaDonDatHang.TabIndex = 31;
            this.btn_XoaDonDatHang.Text = "Xóa";
            this.btn_XoaDonDatHang.UseVisualStyleBackColor = true;
            this.btn_XoaDonDatHang.Click += new System.EventHandler(this.btn_XoaDonDatHang_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btn_XoaDonDatHang);
            this.Controls.Add(this.btn_SuaDonDatHang);
            this.Controls.Add(this.btn_ThemDonDatHang);
            this.Controls.Add(this.btn_SuaKhachHang);
            this.Controls.Add(this.btn_XoaKhachHang);
            this.Controls.Add(this.btn_ThemKhachHang);
            this.Controls.Add(this.dataGridViewDonDatHang);
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaKhachHangFK);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtNgayDatHang);
            this.Controls.Add(this.txtMaDatHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtDiaChiKhachHang);
            this.Controls.Add(this.txtSoDienThoaiKhachHang);
            this.Controls.Add(this.txtEmailKhachHang);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtEmailKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoaiKhachHang;
        private System.Windows.Forms.TextBox txtDiaChiKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaDatHang;
        private System.Windows.Forms.TextBox txtNgayDatHang;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtMaKhachHangFK;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.DataGridView dataGridViewDonDatHang;
        private System.Windows.Forms.Button btn_ThemKhachHang;
        private System.Windows.Forms.Button btn_XoaKhachHang;
        private System.Windows.Forms.Button btn_SuaKhachHang;
        private System.Windows.Forms.Button btn_ThemDonDatHang;
        private System.Windows.Forms.Button btn_SuaDonDatHang;
        private Lab4DataSet2 lab4DataSet2;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private Lab4DataSet2TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Lab4DataSet3 lab4DataSet3;
        private System.Windows.Forms.BindingSource donDatHangBindingSource;
        private Lab4DataSet3TableAdapters.DonDatHangTableAdapter donDatHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maĐHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayĐHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_XoaDonDatHang;
    }
}