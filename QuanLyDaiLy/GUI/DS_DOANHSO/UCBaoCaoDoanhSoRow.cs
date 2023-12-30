using QuanLyDaiLy.DTO;
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
	public partial class UCBaoCaoDoanhSoRow : UserControl
	{
		public UCBaoCaoDoanhSoRow(CtBcds ct)
		{
			InitializeComponent();
			lb_MaDaiLy.Text = ct.MaDaiLy;
			lb_SoPhieuXuat.Text = ct.SoPhieuXuat.ToString();
			lb_TongTriGia.Text = ct.TongTriGia.ToString();
			lb_TyLe.Text = ct.TyLe.ToString();
		}

		private void lb_SoPhieuXuat_Click(object sender, EventArgs e)
		{

		}

		private void lb_TongTriGia_Click(object sender, EventArgs e)
		{

		}

		private void lb_TyLe_Click(object sender, EventArgs e)
		{

		}

		private void lb_MaDaiLy_Click(object sender, EventArgs e)
		{

		}
	}
}
