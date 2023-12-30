using QuanLyDaiLy.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.GUI.DS_DOANHSO
{
	public partial class FBaoCaoDoanhSo : Form
	{
		public FBaoCaoDoanhSo()
		{
			InitializeComponent();
		}

		private void tb_TenDL_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_Taophieu_Click(object sender, EventArgs e)
		{
			try
			{
				int thang = int.Parse(tb_Thang.Text);
				int nam = int.Parse(tb_Nam.Text);
				var (bcds, cts) = BaoCaoDoanhSoDAL.GetBaoCaoDoanhSo(thang, nam);

				lb_TongDoanhSo.Text = ((long)float.Parse(bcds.TongDoanhThu.ToString())).ToString();

				gb_Main.Controls.Clear();
				foreach (var ct in cts)
				{
					UCBaoCaoDoanhSoRow uc = new UCBaoCaoDoanhSoRow(ct);
					uc.Dock = DockStyle.Top;
					gb_Main.Controls.Add(uc);
				}
			} catch
			{
				MessageBox.Show("Thông tin không hợp lệ. Vui lòng thử lại");
			}
		}
	}
}
