namespace QuanLyBanHang
{
    partial class FormQLAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLAdmin));
            this.label = new System.Windows.Forms.Label();
            this.dataGridViewAdminQL = new System.Windows.Forms.DataGridView();
            this.labelHoTenQL = new System.Windows.Forms.Label();
            this.textBoxHoTenQL = new System.Windows.Forms.TextBox();
            this.textBoxDChiQL = new System.Windows.Forms.TextBox();
            this.labelDChiQL = new System.Windows.Forms.Label();
            this.textBoxSDT_QL = new System.Windows.Forms.TextBox();
            this.labelSDT_QL = new System.Windows.Forms.Label();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.labelTK = new System.Windows.Forms.Label();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.buttonAdd_QL = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReset_QL = new System.Windows.Forms.Button();
            this.buttonEdit_QL = new System.Windows.Forms.Button();
            this.buttonDel_QL = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminQL)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Xin chào ";
            // 
            // dataGridViewAdminQL
            // 
            this.dataGridViewAdminQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminQL.Location = new System.Drawing.Point(433, 31);
            this.dataGridViewAdminQL.Name = "dataGridViewAdminQL";
            this.dataGridViewAdminQL.RowHeadersWidth = 51;
            this.dataGridViewAdminQL.RowTemplate.Height = 24;
            this.dataGridViewAdminQL.Size = new System.Drawing.Size(667, 180);
            this.dataGridViewAdminQL.TabIndex = 1;
            this.dataGridViewAdminQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminQL_CellContentClick);
            // 
            // labelHoTenQL
            // 
            this.labelHoTenQL.AutoSize = true;
            this.labelHoTenQL.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTenQL.Location = new System.Drawing.Point(7, 16);
            this.labelHoTenQL.Name = "labelHoTenQL";
            this.labelHoTenQL.Size = new System.Drawing.Size(103, 30);
            this.labelHoTenQL.TabIndex = 2;
            this.labelHoTenQL.Text = "Họ Tên QL";
            // 
            // textBoxHoTenQL
            // 
            this.textBoxHoTenQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxHoTenQL.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTenQL.Location = new System.Drawing.Point(149, 11);
            this.textBoxHoTenQL.Name = "textBoxHoTenQL";
            this.textBoxHoTenQL.Size = new System.Drawing.Size(218, 35);
            this.textBoxHoTenQL.TabIndex = 3;
            this.textBoxHoTenQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHoTenQL_KeyPress);
            // 
            // textBoxDChiQL
            // 
            this.textBoxDChiQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxDChiQL.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDChiQL.Location = new System.Drawing.Point(149, 74);
            this.textBoxDChiQL.Name = "textBoxDChiQL";
            this.textBoxDChiQL.Size = new System.Drawing.Size(218, 35);
            this.textBoxDChiQL.TabIndex = 5;
            this.textBoxDChiQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDChiQL_KeyPress);
            // 
            // labelDChiQL
            // 
            this.labelDChiQL.AutoSize = true;
            this.labelDChiQL.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDChiQL.Location = new System.Drawing.Point(7, 79);
            this.labelDChiQL.Name = "labelDChiQL";
            this.labelDChiQL.Size = new System.Drawing.Size(107, 30);
            this.labelDChiQL.TabIndex = 4;
            this.labelDChiQL.Text = "Địa Chỉ QL";
            // 
            // textBoxSDT_QL
            // 
            this.textBoxSDT_QL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxSDT_QL.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT_QL.Location = new System.Drawing.Point(149, 145);
            this.textBoxSDT_QL.Name = "textBoxSDT_QL";
            this.textBoxSDT_QL.Size = new System.Drawing.Size(218, 35);
            this.textBoxSDT_QL.TabIndex = 7;
            this.textBoxSDT_QL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSDT_QL_KeyPress);
            // 
            // labelSDT_QL
            // 
            this.labelSDT_QL.AutoSize = true;
            this.labelSDT_QL.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT_QL.Location = new System.Drawing.Point(7, 150);
            this.labelSDT_QL.Name = "labelSDT_QL";
            this.labelSDT_QL.Size = new System.Drawing.Size(46, 30);
            this.labelSDT_QL.TabIndex = 6;
            this.labelSDT_QL.Text = "SĐT";
            // 
            // textBoxTK
            // 
            this.textBoxTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxTK.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTK.Location = new System.Drawing.Point(149, 209);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(218, 35);
            this.textBoxTK.TabIndex = 9;
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTK.Location = new System.Drawing.Point(7, 214);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(96, 30);
            this.labelTK.TabIndex = 8;
            this.labelTK.Text = "Tài Khoản";
            // 
            // textBoxMK
            // 
            this.textBoxMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxMK.Font = new System.Drawing.Font("SVN-Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMK.Location = new System.Drawing.Point(149, 271);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(218, 35);
            this.textBoxMK.TabIndex = 11;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.Location = new System.Drawing.Point(7, 276);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(93, 30);
            this.labelMK.TabIndex = 10;
            this.labelMK.Text = "Mật Khẩu";
            // 
            // buttonAdd_QL
            // 
            this.buttonAdd_QL.Location = new System.Drawing.Point(56, 372);
            this.buttonAdd_QL.Name = "buttonAdd_QL";
            this.buttonAdd_QL.Size = new System.Drawing.Size(100, 39);
            this.buttonAdd_QL.TabIndex = 12;
            this.buttonAdd_QL.Text = "Thêm";
            this.buttonAdd_QL.UseVisualStyleBackColor = true;
            this.buttonAdd_QL.Click += new System.EventHandler(this.buttonAdd_QL_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(225, 372);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 39);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Làm mới";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReset_QL
            // 
            this.buttonReset_QL.Location = new System.Drawing.Point(491, 267);
            this.buttonReset_QL.Name = "buttonReset_QL";
            this.buttonReset_QL.Size = new System.Drawing.Size(104, 45);
            this.buttonReset_QL.TabIndex = 14;
            this.buttonReset_QL.Text = "Reset";
            this.buttonReset_QL.UseVisualStyleBackColor = true;
            this.buttonReset_QL.Click += new System.EventHandler(this.buttonReset_QL_Click);
            // 
            // buttonEdit_QL
            // 
            this.buttonEdit_QL.Location = new System.Drawing.Point(704, 267);
            this.buttonEdit_QL.Name = "buttonEdit_QL";
            this.buttonEdit_QL.Size = new System.Drawing.Size(104, 45);
            this.buttonEdit_QL.TabIndex = 15;
            this.buttonEdit_QL.Text = "Sửa";
            this.buttonEdit_QL.UseVisualStyleBackColor = true;
            this.buttonEdit_QL.Click += new System.EventHandler(this.buttonEdit_QL_Click);
            // 
            // buttonDel_QL
            // 
            this.buttonDel_QL.Location = new System.Drawing.Point(924, 267);
            this.buttonDel_QL.Name = "buttonDel_QL";
            this.buttonDel_QL.Size = new System.Drawing.Size(104, 45);
            this.buttonDel_QL.TabIndex = 16;
            this.buttonDel_QL.Text = "Xóa";
            this.buttonDel_QL.UseVisualStyleBackColor = true;
            this.buttonDel_QL.Click += new System.EventHandler(this.buttonDel_QL_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMK);
            this.panel1.Controls.Add(this.labelMK);
            this.panel1.Controls.Add(this.textBoxTK);
            this.panel1.Controls.Add(this.labelTK);
            this.panel1.Controls.Add(this.textBoxSDT_QL);
            this.panel1.Controls.Add(this.labelSDT_QL);
            this.panel1.Controls.Add(this.textBoxDChiQL);
            this.panel1.Controls.Add(this.labelDChiQL);
            this.panel1.Controls.Add(this.textBoxHoTenQL);
            this.panel1.Controls.Add(this.labelHoTenQL);
            this.panel1.Location = new System.Drawing.Point(5, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 318);
            this.panel1.TabIndex = 17;
            // 
            // FormQLAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDel_QL);
            this.Controls.Add(this.buttonEdit_QL);
            this.Controls.Add(this.buttonReset_QL);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd_QL);
            this.Controls.Add(this.dataGridViewAdminQL);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQLAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLAdmin";
            this.Load += new System.EventHandler(this.FormQLAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminQL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridViewAdminQL;
        private System.Windows.Forms.Label labelHoTenQL;
        private System.Windows.Forms.TextBox textBoxHoTenQL;
        private System.Windows.Forms.TextBox textBoxDChiQL;
        private System.Windows.Forms.Label labelDChiQL;
        private System.Windows.Forms.TextBox textBoxSDT_QL;
        private System.Windows.Forms.Label labelSDT_QL;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Button buttonAdd_QL;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset_QL;
        private System.Windows.Forms.Button buttonEdit_QL;
        private System.Windows.Forms.Button buttonDel_QL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}