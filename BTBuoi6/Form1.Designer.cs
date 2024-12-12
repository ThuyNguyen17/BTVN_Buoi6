namespace BTBuoi6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxKhoa);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên:";
       
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(79, 113);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(148, 21);
            this.comboBoxKhoa.TabIndex = 2;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(79, 157);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(163, 20);
            this.txtDTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm TB:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(79, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(163, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Số SV:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(345, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 234);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Khoa";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm TB";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btThem
            // 
            this.btThem.ImageKey = "(none)";
            this.btThem.Location = new System.Drawing.Point(35, 355);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(144, 355);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(259, 355);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chứcNăngToolStripMenuItem.Image")));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Quản Lý Khoa";
            // 
            // tìmKiếmToolStripMenuItem1
            // 
            this.tìmKiếmToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem1.Image")));
            this.tìmKiếmToolStripMenuItem1.Name = "tìmKiếmToolStripMenuItem1";
            this.tìmKiếmToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.tìmKiếmToolStripMenuItem1.Text = "Tìm Kiếm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

