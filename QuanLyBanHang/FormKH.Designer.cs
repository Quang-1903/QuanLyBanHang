namespace QuanLyBanHang
{
    partial class FormKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKH));
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.labelSDTKhach = new System.Windows.Forms.Label();
            this.labelHoTenKhach = new System.Windows.Forms.Label();
            this.labelDChiKhach = new System.Windows.Forms.Label();
            this.label_Input = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxDChiKH = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongSP = new System.Windows.Forms.TextBox();
            this.textBoxSDT_KH = new System.Windows.Forms.TextBox();
            this.textBoxHoTen_KH = new System.Windows.Forms.TextBox();
            this.listViewSP = new System.Windows.Forms.ListView();
            this.columnHeaderMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGiaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoLuongSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThanhTienSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddSP = new System.Windows.Forms.Button();
            this.buttonDelSP = new System.Windows.Forms.Button();
            this.buttonEditSP = new System.Windows.Forms.Button();
            this.buttonInputSP = new System.Windows.Forms.Button();
            this.buttonClearSP = new System.Windows.Forms.Button();
            this.labelMAQL = new System.Windows.Forms.Label();
            this.comboBoxMANV = new System.Windows.Forms.ComboBox();
            this.comboBoxMASP = new System.Windows.Forms.ComboBox();
            this.comboBoxMAQL = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMAKH = new System.Windows.Forms.Label();
            this.comboBoxMAKH = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaNhanVien
            // 
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNhanVien.Location = new System.Drawing.Point(79, 19);
            this.labelMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(132, 30);
            this.labelMaNhanVien.TabIndex = 2;
            this.labelMaNhanVien.Text = "Mã Nhân Viên";
            this.labelMaNhanVien.Click += new System.EventHandler(this.labelMaNhanVien_Click);
            // 
            // labelSDTKhach
            // 
            this.labelSDTKhach.AutoSize = true;
            this.labelSDTKhach.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDTKhach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSDTKhach.Location = new System.Drawing.Point(767, 87);
            this.labelSDTKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDTKhach.Name = "labelSDTKhach";
            this.labelSDTKhach.Size = new System.Drawing.Size(81, 30);
            this.labelSDTKhach.TabIndex = 3;
            this.labelSDTKhach.Text = "SĐT KH";
            // 
            // labelHoTenKhach
            // 
            this.labelHoTenKhach.AutoSize = true;
            this.labelHoTenKhach.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTenKhach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHoTenKhach.Location = new System.Drawing.Point(767, 21);
            this.labelHoTenKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoTenKhach.Name = "labelHoTenKhach";
            this.labelHoTenKhach.Size = new System.Drawing.Size(133, 30);
            this.labelHoTenKhach.TabIndex = 4;
            this.labelHoTenKhach.Text = "Họ và Tên KH";
            // 
            // labelDChiKhach
            // 
            this.labelDChiKhach.AutoSize = true;
            this.labelDChiKhach.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDChiKhach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDChiKhach.Location = new System.Drawing.Point(79, 83);
            this.labelDChiKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDChiKhach.Name = "labelDChiKhach";
            this.labelDChiKhach.Size = new System.Drawing.Size(109, 30);
            this.labelDChiKhach.TabIndex = 6;
            this.labelDChiKhach.Text = "Địa Chỉ KH";
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Input.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Input.Location = new System.Drawing.Point(67, 151);
            this.label_Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(191, 30);
            this.label_Input.TabIndex = 5;
            this.label_Input.Text = "Nhập mã  sản phẩm ";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSoLuong.Location = new System.Drawing.Point(757, 201);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(135, 30);
            this.labelSoLuong.TabIndex = 7;
            this.labelSoLuong.Text = "Nhập số lượng";
            // 
            // textBoxDChiKH
            // 
            this.textBoxDChiKH.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDChiKH.Location = new System.Drawing.Point(308, 77);
            this.textBoxDChiKH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDChiKH.Name = "textBoxDChiKH";
            this.textBoxDChiKH.Size = new System.Drawing.Size(357, 37);
            this.textBoxDChiKH.TabIndex = 9;
            // 
            // textBoxSoLuongSP
            // 
            this.textBoxSoLuongSP.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongSP.Location = new System.Drawing.Point(930, 199);
            this.textBoxSoLuongSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoLuongSP.Name = "textBoxSoLuongSP";
            this.textBoxSoLuongSP.Size = new System.Drawing.Size(348, 37);
            this.textBoxSoLuongSP.TabIndex = 11;
            this.textBoxSoLuongSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongSP_KeyPress);
            // 
            // textBoxSDT_KH
            // 
            this.textBoxSDT_KH.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT_KH.Location = new System.Drawing.Point(930, 77);
            this.textBoxSDT_KH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSDT_KH.Name = "textBoxSDT_KH";
            this.textBoxSDT_KH.Size = new System.Drawing.Size(348, 37);
            this.textBoxSDT_KH.TabIndex = 12;
            this.textBoxSDT_KH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSDT_KH_KeyPress);
            // 
            // textBoxHoTen_KH
            // 
            this.textBoxHoTen_KH.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen_KH.Location = new System.Drawing.Point(930, 10);
            this.textBoxHoTen_KH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHoTen_KH.Name = "textBoxHoTen_KH";
            this.textBoxHoTen_KH.Size = new System.Drawing.Size(348, 37);
            this.textBoxHoTen_KH.TabIndex = 13;
            this.textBoxHoTen_KH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHoTen_KH_KeyPress);
            // 
            // listViewSP
            // 
            this.listViewSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaSP,
            this.columnHeaderTenSP,
            this.columnHeaderGiaSP,
            this.columnHeaderSoLuongSP,
            this.columnHeaderThanhTienSP});
            this.listViewSP.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSP.FullRowSelect = true;
            this.listViewSP.HideSelection = false;
            this.listViewSP.Location = new System.Drawing.Point(54, 35);
            this.listViewSP.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSP.Name = "listViewSP";
            this.listViewSP.Size = new System.Drawing.Size(1110, 200);
            this.listViewSP.TabIndex = 14;
            this.listViewSP.UseCompatibleStateImageBehavior = false;
            this.listViewSP.View = System.Windows.Forms.View.Details;
            this.listViewSP.Click += new System.EventHandler(this.listViewSP_Click);
            // 
            // columnHeaderMaSP
            // 
            this.columnHeaderMaSP.Text = "Mã Sản Phẩm";
            this.columnHeaderMaSP.Width = 220;
            // 
            // columnHeaderTenSP
            // 
            this.columnHeaderTenSP.Text = "Tên Sản Phẩm";
            this.columnHeaderTenSP.Width = 220;
            // 
            // columnHeaderGiaSP
            // 
            this.columnHeaderGiaSP.Text = "Giá";
            this.columnHeaderGiaSP.Width = 220;
            // 
            // columnHeaderSoLuongSP
            // 
            this.columnHeaderSoLuongSP.Text = "Số Lượng";
            this.columnHeaderSoLuongSP.Width = 220;
            // 
            // columnHeaderThanhTienSP
            // 
            this.columnHeaderThanhTienSP.Text = "Thành Tiền";
            this.columnHeaderThanhTienSP.Width = 220;
            // 
            // buttonAddSP
            // 
            this.buttonAddSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSP.Location = new System.Drawing.Point(201, 699);
            this.buttonAddSP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSP.Name = "buttonAddSP";
            this.buttonAddSP.Size = new System.Drawing.Size(146, 50);
            this.buttonAddSP.TabIndex = 15;
            this.buttonAddSP.Text = "Thêm sản phẩm";
            this.buttonAddSP.UseVisualStyleBackColor = true;
            this.buttonAddSP.Click += new System.EventHandler(this.buttonAddSP_Click);
            // 
            // buttonDelSP
            // 
            this.buttonDelSP.Enabled = false;
            this.buttonDelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelSP.Location = new System.Drawing.Point(742, 699);
            this.buttonDelSP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelSP.Name = "buttonDelSP";
            this.buttonDelSP.Size = new System.Drawing.Size(145, 50);
            this.buttonDelSP.TabIndex = 16;
            this.buttonDelSP.Text = "Xóa sản phẩm";
            this.buttonDelSP.UseVisualStyleBackColor = true;
            this.buttonDelSP.Click += new System.EventHandler(this.buttonDelSP_Click);
            // 
            // buttonEditSP
            // 
            this.buttonEditSP.Enabled = false;
            this.buttonEditSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSP.Location = new System.Drawing.Point(474, 699);
            this.buttonEditSP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditSP.Name = "buttonEditSP";
            this.buttonEditSP.Size = new System.Drawing.Size(146, 50);
            this.buttonEditSP.TabIndex = 17;
            this.buttonEditSP.Text = "Sửa sản phẩm";
            this.buttonEditSP.UseVisualStyleBackColor = true;
            this.buttonEditSP.Click += new System.EventHandler(this.buttonEditSP_Click);
            // 
            // buttonInputSP
            // 
            this.buttonInputSP.Enabled = false;
            this.buttonInputSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInputSP.Location = new System.Drawing.Point(995, 699);
            this.buttonInputSP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInputSP.Name = "buttonInputSP";
            this.buttonInputSP.Size = new System.Drawing.Size(145, 50);
            this.buttonInputSP.TabIndex = 18;
            this.buttonInputSP.Text = "In hóa đơn";
            this.buttonInputSP.UseVisualStyleBackColor = true;
            this.buttonInputSP.Click += new System.EventHandler(this.buttonInputSP_Click);
            // 
            // buttonClearSP
            // 
            this.buttonClearSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSP.Location = new System.Drawing.Point(1155, 346);
            this.buttonClearSP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearSP.Name = "buttonClearSP";
            this.buttonClearSP.Size = new System.Drawing.Size(146, 50);
            this.buttonClearSP.TabIndex = 19;
            this.buttonClearSP.Text = "Reset";
            this.buttonClearSP.UseVisualStyleBackColor = true;
            this.buttonClearSP.Click += new System.EventHandler(this.buttonClearSP_Click);
            // 
            // labelMAQL
            // 
            this.labelMAQL.AutoSize = true;
            this.labelMAQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAQL.Location = new System.Drawing.Point(33, 312);
            this.labelMAQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMAQL.Name = "labelMAQL";
            this.labelMAQL.Size = new System.Drawing.Size(193, 29);
            this.labelMAQL.TabIndex = 21;
            this.labelMAQL.Text = "Nhập mã  quản lí";
            // 
            // comboBoxMANV
            // 
            this.comboBoxMANV.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMANV.FormattingEnabled = true;
            this.comboBoxMANV.Location = new System.Drawing.Point(308, 10);
            this.comboBoxMANV.Name = "comboBoxMANV";
            this.comboBoxMANV.Size = new System.Drawing.Size(357, 38);
            this.comboBoxMANV.TabIndex = 23;
            // 
            // comboBoxMASP
            // 
            this.comboBoxMASP.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMASP.FormattingEnabled = true;
            this.comboBoxMASP.Location = new System.Drawing.Point(308, 141);
            this.comboBoxMASP.Name = "comboBoxMASP";
            this.comboBoxMASP.Size = new System.Drawing.Size(357, 38);
            this.comboBoxMASP.TabIndex = 24;
            // 
            // comboBoxMAQL
            // 
            this.comboBoxMAQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMAQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMAQL.FormattingEnabled = true;
            this.comboBoxMAQL.Location = new System.Drawing.Point(331, 308);
            this.comboBoxMAQL.Name = "comboBoxMAQL";
            this.comboBoxMAQL.Size = new System.Drawing.Size(357, 33);
            this.comboBoxMAQL.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSum);
            this.groupBox1.Controls.Add(this.listViewSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1211, 297);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Bira", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tổng tiền";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSum.Location = new System.Drawing.Point(988, 255);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(176, 40);
            this.textBoxSum.TabIndex = 15;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSảnPhẩmToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 32);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            this.thôngTinSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("SVN-Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            this.thôngTinSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            this.thôngTinSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("SVN-Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.adminToolStripMenuItem.Text = "Quản lí";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // labelMAKH
            // 
            this.labelMAKH.AutoSize = true;
            this.labelMAKH.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMAKH.Location = new System.Drawing.Point(766, 145);
            this.labelMAKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMAKH.Name = "labelMAKH";
            this.labelMAKH.Size = new System.Drawing.Size(123, 30);
            this.labelMAKH.TabIndex = 28;
            this.labelMAKH.Text = "Nhập mã KH";
            // 
            // comboBoxMAKH
            // 
            this.comboBoxMAKH.Font = new System.Drawing.Font("SVN-Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMAKH.FormattingEnabled = true;
            this.comboBoxMAKH.Location = new System.Drawing.Point(931, 136);
            this.comboBoxMAKH.Name = "comboBoxMAKH";
            this.comboBoxMAKH.Size = new System.Drawing.Size(348, 38);
            this.comboBoxMAKH.TabIndex = 29;
            this.comboBoxMAKH.SelectedIndexChanged += new System.EventHandler(this.comboBoxMAKH_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.comboBoxMAKH);
            this.panel1.Controls.Add(this.labelMAKH);
            this.panel1.Controls.Add(this.comboBoxMASP);
            this.panel1.Controls.Add(this.comboBoxMANV);
            this.panel1.Controls.Add(this.textBoxHoTen_KH);
            this.panel1.Controls.Add(this.textBoxSDT_KH);
            this.panel1.Controls.Add(this.textBoxSoLuongSP);
            this.panel1.Controls.Add(this.textBoxDChiKH);
            this.panel1.Controls.Add(this.labelSoLuong);
            this.panel1.Controls.Add(this.labelDChiKhach);
            this.panel1.Controls.Add(this.label_Input);
            this.panel1.Controls.Add(this.labelHoTenKhach);
            this.panel1.Controls.Add(this.labelSDTKhach);
            this.panel1.Controls.Add(this.labelMaNhanVien);
            this.panel1.Location = new System.Drawing.Point(23, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 240);
            this.panel1.TabIndex = 30;
            // 
            // FormKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxMAQL);
            this.Controls.Add(this.labelMAQL);
            this.Controls.Add(this.buttonClearSP);
            this.Controls.Add(this.buttonInputSP);
            this.Controls.Add(this.buttonEditSP);
            this.Controls.Add(this.buttonDelSP);
            this.Controls.Add(this.buttonAddSP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "         ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.Label labelSDTKhach;
        private System.Windows.Forms.Label labelHoTenKhach;
        private System.Windows.Forms.Label labelDChiKhach;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox textBoxDChiKH;
        private System.Windows.Forms.TextBox textBoxSoLuongSP;
        private System.Windows.Forms.TextBox textBoxSDT_KH;
        private System.Windows.Forms.TextBox textBoxHoTen_KH;
        private System.Windows.Forms.ListView listViewSP;
        private System.Windows.Forms.ColumnHeader columnHeaderMaSP;
        private System.Windows.Forms.ColumnHeader columnHeaderTenSP;
        private System.Windows.Forms.ColumnHeader columnHeaderSoLuongSP;
        private System.Windows.Forms.ColumnHeader columnHeaderThanhTienSP;
        private System.Windows.Forms.Button buttonAddSP;
        private System.Windows.Forms.ColumnHeader columnHeaderGiaSP;
        private System.Windows.Forms.Button buttonDelSP;
        private System.Windows.Forms.Button buttonEditSP;
        private System.Windows.Forms.Button buttonInputSP;
        private System.Windows.Forms.Button buttonClearSP;
        private System.Windows.Forms.Label labelMAQL;
        private System.Windows.Forms.ComboBox comboBoxMANV;
        private System.Windows.Forms.ComboBox comboBoxMASP;
        private System.Windows.Forms.ComboBox comboBoxMAQL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Label labelMAKH;
        private System.Windows.Forms.ComboBox comboBoxMAKH;
        private System.Windows.Forms.Panel panel1;
    }
}

