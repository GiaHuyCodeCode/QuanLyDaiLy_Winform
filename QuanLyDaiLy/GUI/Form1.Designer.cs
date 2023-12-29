namespace QuanLyDaiLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CongNo = new System.Windows.Forms.Button();
            this.btn_ThuTien = new System.Windows.Forms.Button();
            this.btn_XuatHang = new System.Windows.Forms.Button();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.btn_DaiLy = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_GridView = new System.Windows.Forms.Panel();
            this.panel_ChiTiet = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_CongNo);
            this.panel1.Controls.Add(this.btn_ThuTien);
            this.panel1.Controls.Add(this.btn_XuatHang);
            this.panel1.Controls.Add(this.btn_NhapHang);
            this.panel1.Controls.Add(this.btn_DaiLy);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 541);
            this.panel1.TabIndex = 0;
            // 
            // btn_CongNo
            // 
            this.btn_CongNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CongNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CongNo.Location = new System.Drawing.Point(0, 369);
            this.btn_CongNo.Name = "btn_CongNo";
            this.btn_CongNo.Size = new System.Drawing.Size(200, 61);
            this.btn_CongNo.TabIndex = 6;
            this.btn_CongNo.Text = "CÔNG NỢ";
            this.btn_CongNo.UseVisualStyleBackColor = false;
            this.btn_CongNo.Click += new System.EventHandler(this.btn_CongNo_Click);
            // 
            // btn_ThuTien
            // 
            this.btn_ThuTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThuTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThuTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThuTien.Location = new System.Drawing.Point(0, 308);
            this.btn_ThuTien.Name = "btn_ThuTien";
            this.btn_ThuTien.Size = new System.Drawing.Size(200, 61);
            this.btn_ThuTien.TabIndex = 5;
            this.btn_ThuTien.Text = "PHIẾU THU TIỀN";
            this.btn_ThuTien.UseVisualStyleBackColor = false;
            this.btn_ThuTien.Click += new System.EventHandler(this.btn_ThuTien_Click);
            // 
            // btn_XuatHang
            // 
            this.btn_XuatHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_XuatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_XuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatHang.Location = new System.Drawing.Point(0, 247);
            this.btn_XuatHang.Name = "btn_XuatHang";
            this.btn_XuatHang.Size = new System.Drawing.Size(200, 61);
            this.btn_XuatHang.TabIndex = 4;
            this.btn_XuatHang.Text = "PHIẾU XUẤT HÀNG";
            this.btn_XuatHang.UseVisualStyleBackColor = false;
            this.btn_XuatHang.Click += new System.EventHandler(this.btn_XuatHang_Click);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_NhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.Location = new System.Drawing.Point(0, 186);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(200, 61);
            this.btn_NhapHang.TabIndex = 3;
            this.btn_NhapHang.Text = "PHIẾU NHẬP HÀNG";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_DaiLy
            // 
            this.btn_DaiLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DaiLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DaiLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DaiLy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DaiLy.Location = new System.Drawing.Point(0, 125);
            this.btn_DaiLy.Name = "btn_DaiLy";
            this.btn_DaiLy.Size = new System.Drawing.Size(200, 61);
            this.btn_DaiLy.TabIndex = 2;
            this.btn_DaiLy.Text = "ĐẠI LÝ";
            this.btn_DaiLy.UseVisualStyleBackColor = false;
            this.btn_DaiLy.Click += new System.EventHandler(this.btn_DaiLy_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(0, 64);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(200, 61);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "HOME";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 64);
            this.panel6.TabIndex = 0;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.pictureBox1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(200, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1000, 40);
            this.panel_Top.TabIndex = 1;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_GridView);
            this.panel_Main.Controls.Add(this.panel_ChiTiet);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(200, 40);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1000, 501);
            this.panel_Main.TabIndex = 2;
            // 
            // panel_GridView
            // 
            this.panel_GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_GridView.Location = new System.Drawing.Point(0, 182);
            this.panel_GridView.Name = "panel_GridView";
            this.panel_GridView.Size = new System.Drawing.Size(1000, 360);
            this.panel_GridView.TabIndex = 3;
            // 
            // panel_ChiTiet
            // 
            this.panel_ChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChiTiet.Location = new System.Drawing.Point(0, 0);
            this.panel_ChiTiet.Name = "panel_ChiTiet";
            this.panel_ChiTiet.Size = new System.Drawing.Size(1000, 182);
            this.panel_ChiTiet.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 19);
            this.panel2.TabIndex = 7;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 449);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(200, 50);
            this.btn_DangXuat.TabIndex = 8;
            this.btn_DangXuat.Text = "ĐĂNG XUẤT";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDaiLy.Properties.Resources.icons8_power_301;
            this.pictureBox1.Location = new System.Drawing.Point(961, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 541);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button btn_CongNo;
        private System.Windows.Forms.Button btn_ThuTien;
        private System.Windows.Forms.Button btn_XuatHang;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Button btn_DaiLy;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_GridView;
        private System.Windows.Forms.Panel panel_ChiTiet;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

