namespace QuanLyDaiLy.GUI.DS_THUTIEN
{
    partial class FThongTinThuTien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date_NgayTN = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Dienthoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaDL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenDL = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // date_NgayTN
            // 
            this.date_NgayTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayTN.Location = new System.Drawing.Point(194, 117);
            this.date_NgayTN.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgayTN.Name = "date_NgayTN";
            this.date_NgayTN.Size = new System.Drawing.Size(289, 32);
            this.date_NgayTN.TabIndex = 22;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(1018, 174);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(311, 64);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "IN PHIẾU";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(1018, 85);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(311, 64);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "THÊM PHIẾU";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(1018, 4);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(311, 54);
            this.btn_Load.TabIndex = 18;
            this.btn_Load.Text = "LOAD";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 290);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Tim);
            this.panel1.Controls.Add(this.date_NgayTN);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Load);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_Dienthoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_MaDL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_TenDL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 327);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "NGÀY THU TIỀN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "SỐ TIỀN THU:";
            // 
            // tb_Dienthoai
            // 
            this.tb_Dienthoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dienthoai.Location = new System.Drawing.Point(194, 282);
            this.tb_Dienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Dienthoai.Name = "tb_Dienthoai";
            this.tb_Dienthoai.Size = new System.Drawing.Size(289, 34);
            this.tb_Dienthoai.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÃ ĐẠI LÝ:";
            // 
            // tb_MaDL
            // 
            this.tb_MaDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaDL.Location = new System.Drawing.Point(194, 66);
            this.tb_MaDL.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaDL.Name = "tb_MaDL";
            this.tb_MaDL.Size = new System.Drawing.Size(289, 34);
            this.tb_MaDL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ PHIẾU THU:";
            // 
            // tb_TenDL
            // 
            this.tb_TenDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenDL.Location = new System.Drawing.Point(194, 15);
            this.tb_TenDL.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TenDL.Name = "tb_TenDL";
            this.tb_TenDL.Size = new System.Drawing.Size(289, 34);
            this.tb_TenDL.TabIndex = 1;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(1018, 259);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(311, 64);
            this.btn_Tim.TabIndex = 23;
            this.btn_Tim.Text = "TÌM KIẾM";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // FThongTinThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongTinThuTien";
            this.Text = "FThongTinThuTien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date_NgayTN;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Dienthoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenDL;
        private System.Windows.Forms.Button btn_Tim;
    }
}