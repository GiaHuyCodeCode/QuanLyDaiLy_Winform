namespace QuanLyDaiLy.GUI.DS_DOANHSO
{
	partial class UCBaoCaoDoanhSoRow
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lb_MaDaiLy = new System.Windows.Forms.Label();
			this.lb_SoPhieuXuat = new System.Windows.Forms.Label();
			this.lb_TongTriGia = new System.Windows.Forms.Label();
			this.lb_TyLe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_MaDaiLy
			// 
			this.lb_MaDaiLy.AutoSize = true;
			this.lb_MaDaiLy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_MaDaiLy.Location = new System.Drawing.Point(52, 18);
			this.lb_MaDaiLy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_MaDaiLy.Name = "lb_MaDaiLy";
			this.lb_MaDaiLy.Size = new System.Drawing.Size(112, 32);
			this.lb_MaDaiLy.TabIndex = 29;
			this.lb_MaDaiLy.Text = "Mã đại lý";
			this.lb_MaDaiLy.Click += new System.EventHandler(this.lb_MaDaiLy_Click);
			// 
			// lb_SoPhieuXuat
			// 
			this.lb_SoPhieuXuat.AutoSize = true;
			this.lb_SoPhieuXuat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_SoPhieuXuat.Location = new System.Drawing.Point(311, 18);
			this.lb_SoPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_SoPhieuXuat.Name = "lb_SoPhieuXuat";
			this.lb_SoPhieuXuat.Size = new System.Drawing.Size(161, 32);
			this.lb_SoPhieuXuat.TabIndex = 30;
			this.lb_SoPhieuXuat.Text = "Số phiếu xuất";
			this.lb_SoPhieuXuat.Click += new System.EventHandler(this.lb_SoPhieuXuat_Click);
			// 
			// lb_TongTriGia
			// 
			this.lb_TongTriGia.AutoSize = true;
			this.lb_TongTriGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_TongTriGia.Location = new System.Drawing.Point(596, 18);
			this.lb_TongTriGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_TongTriGia.Name = "lb_TongTriGia";
			this.lb_TongTriGia.Size = new System.Drawing.Size(137, 32);
			this.lb_TongTriGia.TabIndex = 31;
			this.lb_TongTriGia.Text = "Tổng trị giá";
			this.lb_TongTriGia.Click += new System.EventHandler(this.lb_TongTriGia_Click);
			// 
			// lb_TyLe
			// 
			this.lb_TyLe.AutoSize = true;
			this.lb_TyLe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_TyLe.Location = new System.Drawing.Point(889, 18);
			this.lb_TyLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_TyLe.Name = "lb_TyLe";
			this.lb_TyLe.Size = new System.Drawing.Size(65, 32);
			this.lb_TyLe.TabIndex = 32;
			this.lb_TyLe.Text = "Tỷ lệ";
			this.lb_TyLe.Click += new System.EventHandler(this.lb_TyLe_Click);
			// 
			// UCBaoCaoDoanhSoRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lb_TyLe);
			this.Controls.Add(this.lb_TongTriGia);
			this.Controls.Add(this.lb_SoPhieuXuat);
			this.Controls.Add(this.lb_MaDaiLy);
			this.Name = "UCBaoCaoDoanhSoRow";
			this.Size = new System.Drawing.Size(1161, 69);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_MaDaiLy;
		private System.Windows.Forms.Label lb_SoPhieuXuat;
		private System.Windows.Forms.Label lb_TongTriGia;
		private System.Windows.Forms.Label lb_TyLe;
	}
}
