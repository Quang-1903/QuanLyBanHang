namespace QuanLyBanHang
{
    partial class FormSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSP));
            this.buttonSreachSP = new System.Windows.Forms.Button();
            this.textBoxSreachSP = new System.Windows.Forms.TextBox();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.labelCTSP = new System.Windows.Forms.Label();
            this.labelMaSP = new System.Windows.Forms.Label();
            this.textBoxCountrySP = new System.Windows.Forms.TextBox();
            this.textBoxDV_SP = new System.Windows.Forms.TextBox();
            this.labelSXSP = new System.Windows.Forms.Label();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            this.labelDVT_SP = new System.Windows.Forms.Label();
            this.textBoxNameSP = new System.Windows.Forms.TextBox();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.labelGiaSP = new System.Windows.Forms.Label();
            this.textBoxCostSP = new System.Windows.Forms.TextBox();
            this.buttonAddSP = new System.Windows.Forms.Button();
            this.buttonResetTextSP = new System.Windows.Forms.Button();
            this.buttonEditSP = new System.Windows.Forms.Button();
            this.buttonDelSP = new System.Windows.Forms.Button();
            this.buttonResetSP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSreachSP
            // 
            this.buttonSreachSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSreachSP.Location = new System.Drawing.Point(51, 119);
            this.buttonSreachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSreachSP.Name = "buttonSreachSP";
            this.buttonSreachSP.Size = new System.Drawing.Size(226, 37);
            this.buttonSreachSP.TabIndex = 1;
            this.buttonSreachSP.Text = "Tìm kiếm mã sản phẩm";
            this.buttonSreachSP.UseVisualStyleBackColor = true;
            this.buttonSreachSP.Click += new System.EventHandler(this.buttonSreachSP_Click);
            // 
            // textBoxSreachSP
            // 
            this.textBoxSreachSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxSreachSP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSreachSP.Location = new System.Drawing.Point(273, 119);
            this.textBoxSreachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSreachSP.Name = "textBoxSreachSP";
            this.textBoxSreachSP.Size = new System.Drawing.Size(484, 40);
            this.textBoxSreachSP.TabIndex = 2;
            this.textBoxSreachSP.TextChanged += new System.EventHandler(this.textBoxSreachSP_TextChanged);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(-3, 177);
            this.dataGridViewSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(760, 425);
            this.dataGridViewSP.TabIndex = 3;
            this.dataGridViewSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellContentClick);
            // 
            // labelCTSP
            // 
            this.labelCTSP.AutoSize = true;
            this.labelCTSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCTSP.Location = new System.Drawing.Point(64, 6);
            this.labelCTSP.Name = "labelCTSP";
            this.labelCTSP.Size = new System.Drawing.Size(71, 30);
            this.labelCTSP.TabIndex = 4;
            this.labelCTSP.Text = "Chi Tiết";
            // 
            // labelMaSP
            // 
            this.labelMaSP.AutoSize = true;
            this.labelMaSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSP.Location = new System.Drawing.Point(9, 55);
            this.labelMaSP.Name = "labelMaSP";
            this.labelMaSP.Size = new System.Drawing.Size(85, 30);
            this.labelMaSP.TabIndex = 5;
            this.labelMaSP.Text = "Mã SP :";
            // 
            // textBoxCountrySP
            // 
            this.textBoxCountrySP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxCountrySP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountrySP.Location = new System.Drawing.Point(181, 239);
            this.textBoxCountrySP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCountrySP.Name = "textBoxCountrySP";
            this.textBoxCountrySP.Size = new System.Drawing.Size(288, 40);
            this.textBoxCountrySP.TabIndex = 6;
            this.textBoxCountrySP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountrySP_KeyPress);
            // 
            // textBoxDV_SP
            // 
            this.textBoxDV_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxDV_SP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDV_SP.Location = new System.Drawing.Point(181, 175);
            this.textBoxDV_SP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDV_SP.Name = "textBoxDV_SP";
            this.textBoxDV_SP.Size = new System.Drawing.Size(288, 40);
            this.textBoxDV_SP.TabIndex = 8;
            this.textBoxDV_SP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDV_SP_KeyPress);
            // 
            // labelSXSP
            // 
            this.labelSXSP.AutoSize = true;
            this.labelSXSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSXSP.Location = new System.Drawing.Point(9, 241);
            this.labelSXSP.Name = "labelSXSP";
            this.labelSXSP.Size = new System.Drawing.Size(100, 30);
            this.labelSXSP.TabIndex = 7;
            this.labelSXSP.Text = "Nước SX :";
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxMaSP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSP.Location = new System.Drawing.Point(181, 49);
            this.textBoxMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(288, 40);
            this.textBoxMaSP.TabIndex = 10;
            // 
            // labelDVT_SP
            // 
            this.labelDVT_SP.AutoSize = true;
            this.labelDVT_SP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDVT_SP.Location = new System.Drawing.Point(9, 177);
            this.labelDVT_SP.Name = "labelDVT_SP";
            this.labelDVT_SP.Size = new System.Drawing.Size(162, 30);
            this.labelDVT_SP.TabIndex = 9;
            this.labelDVT_SP.Text = "Đơn vị tính  SP :";
            // 
            // textBoxNameSP
            // 
            this.textBoxNameSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxNameSP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSP.Location = new System.Drawing.Point(181, 113);
            this.textBoxNameSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameSP.Name = "textBoxNameSP";
            this.textBoxNameSP.Size = new System.Drawing.Size(288, 40);
            this.textBoxNameSP.TabIndex = 12;
            this.textBoxNameSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameSP_KeyPress);
            // 
            // labelTenSP
            // 
            this.labelTenSP.AutoSize = true;
            this.labelTenSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSP.Location = new System.Drawing.Point(9, 113);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(85, 30);
            this.labelTenSP.TabIndex = 11;
            this.labelTenSP.Text = "Tên SP :";
            // 
            // labelGiaSP
            // 
            this.labelGiaSP.AutoSize = true;
            this.labelGiaSP.Font = new System.Drawing.Font("SVN-Bira", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaSP.Location = new System.Drawing.Point(9, 309);
            this.labelGiaSP.Name = "labelGiaSP";
            this.labelGiaSP.Size = new System.Drawing.Size(87, 30);
            this.labelGiaSP.TabIndex = 14;
            this.labelGiaSP.Text = "Giá SP :";
            // 
            // textBoxCostSP
            // 
            this.textBoxCostSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(226)))));
            this.textBoxCostSP.Font = new System.Drawing.Font("SVN-Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostSP.Location = new System.Drawing.Point(181, 304);
            this.textBoxCostSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCostSP.Name = "textBoxCostSP";
            this.textBoxCostSP.Size = new System.Drawing.Size(288, 40);
            this.textBoxCostSP.TabIndex = 13;
            this.textBoxCostSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostSP_KeyPress);
            // 
            // buttonAddSP
            // 
            this.buttonAddSP.Location = new System.Drawing.Point(853, 527);
            this.buttonAddSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddSP.Name = "buttonAddSP";
            this.buttonAddSP.Size = new System.Drawing.Size(111, 49);
            this.buttonAddSP.TabIndex = 15;
            this.buttonAddSP.Text = "Thêm";
            this.buttonAddSP.UseVisualStyleBackColor = true;
            this.buttonAddSP.Click += new System.EventHandler(this.buttonAddSP_Click);
            // 
            // buttonResetTextSP
            // 
            this.buttonResetTextSP.Location = new System.Drawing.Point(1093, 527);
            this.buttonResetTextSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResetTextSP.Name = "buttonResetTextSP";
            this.buttonResetTextSP.Size = new System.Drawing.Size(111, 49);
            this.buttonResetTextSP.TabIndex = 16;
            this.buttonResetTextSP.Text = "Reset";
            this.buttonResetTextSP.UseVisualStyleBackColor = true;
            this.buttonResetTextSP.Click += new System.EventHandler(this.buttonResetTextSP_Click);
            // 
            // buttonEditSP
            // 
            this.buttonEditSP.Location = new System.Drawing.Point(51, 625);
            this.buttonEditSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditSP.Name = "buttonEditSP";
            this.buttonEditSP.Size = new System.Drawing.Size(181, 53);
            this.buttonEditSP.TabIndex = 17;
            this.buttonEditSP.Text = "Sửa";
            this.buttonEditSP.UseVisualStyleBackColor = true;
            this.buttonEditSP.Click += new System.EventHandler(this.buttonEditSP_Click);
            // 
            // buttonDelSP
            // 
            this.buttonDelSP.Location = new System.Drawing.Point(536, 625);
            this.buttonDelSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelSP.Name = "buttonDelSP";
            this.buttonDelSP.Size = new System.Drawing.Size(181, 53);
            this.buttonDelSP.TabIndex = 18;
            this.buttonDelSP.Text = "Xóa";
            this.buttonDelSP.UseVisualStyleBackColor = true;
            this.buttonDelSP.Click += new System.EventHandler(this.buttonDelSP_Click);
            // 
            // buttonResetSP
            // 
            this.buttonResetSP.Location = new System.Drawing.Point(293, 625);
            this.buttonResetSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResetSP.Name = "buttonResetSP";
            this.buttonResetSP.Size = new System.Drawing.Size(181, 53);
            this.buttonResetSP.TabIndex = 19;
            this.buttonResetSP.Text = "Reset";
            this.buttonResetSP.UseVisualStyleBackColor = true;
            this.buttonResetSP.Click += new System.EventHandler(this.buttonResetSP_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelGiaSP);
            this.panel1.Controls.Add(this.textBoxCostSP);
            this.panel1.Controls.Add(this.textBoxNameSP);
            this.panel1.Controls.Add(this.labelTenSP);
            this.panel1.Controls.Add(this.textBoxMaSP);
            this.panel1.Controls.Add(this.labelDVT_SP);
            this.panel1.Controls.Add(this.textBoxDV_SP);
            this.panel1.Controls.Add(this.labelSXSP);
            this.panel1.Controls.Add(this.textBoxCountrySP);
            this.panel1.Controls.Add(this.labelMaSP);
            this.panel1.Controls.Add(this.labelCTSP);
            this.panel1.Location = new System.Drawing.Point(819, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 399);
            this.panel1.TabIndex = 20;
            // 
            // FormSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonResetSP);
            this.Controls.Add(this.buttonDelSP);
            this.Controls.Add(this.buttonEditSP);
            this.Controls.Add(this.buttonResetTextSP);
            this.Controls.Add(this.buttonAddSP);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.textBoxSreachSP);
            this.Controls.Add(this.buttonSreachSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.FormSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSreachSP;
        private System.Windows.Forms.TextBox textBoxSreachSP;
        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.Label labelCTSP;
        private System.Windows.Forms.Label labelMaSP;
        private System.Windows.Forms.TextBox textBoxCountrySP;
        private System.Windows.Forms.TextBox textBoxDV_SP;
        private System.Windows.Forms.Label labelSXSP;
        private System.Windows.Forms.TextBox textBoxMaSP;
        private System.Windows.Forms.Label labelDVT_SP;
        private System.Windows.Forms.TextBox textBoxNameSP;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.Label labelGiaSP;
        private System.Windows.Forms.TextBox textBoxCostSP;
        private System.Windows.Forms.Button buttonAddSP;
        private System.Windows.Forms.Button buttonResetTextSP;
        private System.Windows.Forms.Button buttonEditSP;
        private System.Windows.Forms.Button buttonDelSP;
        private System.Windows.Forms.Button buttonResetSP;
        private System.Windows.Forms.Panel panel1;
    }
}