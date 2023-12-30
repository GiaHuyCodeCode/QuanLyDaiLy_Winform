using System.Windows.Forms;

namespace QuanLyDaiLy.GUI.DS_NHAPHANG
{
    partial class FTaoPhieu
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

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.TextBox();
            this.panelAttributes = new System.Windows.Forms.Panel();
            this.dtpNgayXuatHang = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayXuatHang = new System.Windows.Forms.TextBox();
            this.lblNgayXuatHang = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(3, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Tạo phiếu nhập hàng";
            this.lblTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAttributes
            // 
            this.panelAttributes.BackColor = System.Drawing.Color.White;
            this.panelAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttributes.Controls.Add(this.dtpNgayXuatHang);
            this.panelAttributes.Controls.Add(this.btnCancel);
            this.panelAttributes.Controls.Add(this.btnCreate);
            this.panelAttributes.Controls.Add(this.textBox5);
            this.panelAttributes.Controls.Add(this.label5);
            this.panelAttributes.Controls.Add(this.textBox4);
            this.panelAttributes.Controls.Add(this.label4);
            this.panelAttributes.Controls.Add(this.textBox3);
            this.panelAttributes.Controls.Add(this.label3);
            this.panelAttributes.Controls.Add(this.label2);
            this.panelAttributes.Controls.Add(this.textBox1);
            this.panelAttributes.Controls.Add(this.label1);
            this.panelAttributes.Controls.Add(this.txtNgayXuatHang);
            this.panelAttributes.Controls.Add(this.lblNgayXuatHang);
            this.panelAttributes.Location = new System.Drawing.Point(10, 60);
            this.panelAttributes.Name = "panelAttributes";
            this.panelAttributes.Size = new System.Drawing.Size(1260, 650);
            this.panelAttributes.TabIndex = 1;
            // 
            // dtpNgayXuatHang
            // 
            this.dtpNgayXuatHang.CalendarForeColor = System.Drawing.Color.White;
            this.dtpNgayXuatHang.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtpNgayXuatHang.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtpNgayXuatHang.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpNgayXuatHang.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpNgayXuatHang.Location = new System.Drawing.Point(310, 310);
            this.dtpNgayXuatHang.MinimumSize = new System.Drawing.Size(210, 40);
            this.dtpNgayXuatHang.Name = "dtpNgayXuatHang";
            this.dtpNgayXuatHang.Size = new System.Drawing.Size(210, 40);
            this.dtpNgayXuatHang.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(310, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(713, 427);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(210, 40);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.textBox5.Location = new System.Drawing.Point(881, 308);
            this.textBox5.MaximumSize = new System.Drawing.Size(210, 40);
            this.textBox5.MinimumSize = new System.Drawing.Size(210, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 40);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Còn lại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(709, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Còn lại";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.textBox4.Location = new System.Drawing.Point(881, 190);
            this.textBox4.MaximumSize = new System.Drawing.Size(210, 40);
            this.textBox4.MinimumSize = new System.Drawing.Size(210, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 40);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Số tiền trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(709, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số tiền trả";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.textBox3.Location = new System.Drawing.Point(881, 87);
            this.textBox3.MaximumSize = new System.Drawing.Size(210, 40);
            this.textBox3.MinimumSize = new System.Drawing.Size(210, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 40);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(709, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(138, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày nhập hàng";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.textBox1.Location = new System.Drawing.Point(310, 188);
            this.textBox1.MaximumSize = new System.Drawing.Size(210, 40);
            this.textBox1.MinimumSize = new System.Drawing.Size(210, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 40);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Mã đại lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(138, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã đại lý";
            // 
            // txtNgayXuatHang
            // 
            this.txtNgayXuatHang.BackColor = System.Drawing.Color.White;
            this.txtNgayXuatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayXuatHang.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayXuatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.txtNgayXuatHang.Location = new System.Drawing.Point(310, 85);
            this.txtNgayXuatHang.MaximumSize = new System.Drawing.Size(210, 40);
            this.txtNgayXuatHang.MinimumSize = new System.Drawing.Size(210, 40);
            this.txtNgayXuatHang.Name = "txtNgayXuatHang";
            this.txtNgayXuatHang.Size = new System.Drawing.Size(210, 40);
            this.txtNgayXuatHang.TabIndex = 5;
            this.txtNgayXuatHang.Text = "Mã phiếu nhập";
            // 
            // lblNgayXuatHang
            // 
            this.lblNgayXuatHang.AutoSize = true;
            this.lblNgayXuatHang.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayXuatHang.ForeColor = System.Drawing.Color.Black;
            this.lblNgayXuatHang.Location = new System.Drawing.Point(138, 87);
            this.lblNgayXuatHang.Name = "lblNgayXuatHang";
            this.lblNgayXuatHang.Size = new System.Drawing.Size(132, 22);
            this.lblNgayXuatHang.TabIndex = 7;
            this.lblNgayXuatHang.Text = "Mã phiếu nhập";
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Location = new System.Drawing.Point(0, 50);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1280, 670);
            this.panelCenter.TabIndex = 2;
            // 
            // FTaoPhieu
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelAttributes);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.Name = "FTaoPhieu";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAttributes.ResumeLayout(false);
            this.panelAttributes.PerformLayout();
            this.ResumeLayout(false);

        }
        private TextBox lblTitle;
        private TextBox txtNgayXuatHang;
        private Label lblNgayXuatHang;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private Button btnCreate;
        private Button btnCancel;
        private DateTimePicker dtpNgayXuatHang;


        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelAttributes;
        private System.Windows.Forms.Panel panelCenter;
    }
}