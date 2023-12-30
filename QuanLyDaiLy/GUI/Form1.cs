using QuanLyDaiLy.DTO;
using QuanLyDaiLy.GUI.DS_CONGNO;
using QuanLyDaiLy.GUI.DS_DAILY;
using QuanLyDaiLy.GUI.DS_NHAPHANG;
using QuanLyDaiLy.GUI.DS_THUNO;
using QuanLyDaiLy.GUI.DS_THUTIEN;
using QuanLyDaiLy.GUI.DS_XUATHANG;
using QuanLyDaiLy.GUI.DS_DOANHSO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Method
        private Form activeForm = null;
        //open new file
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        #region Events
        private void btn_Home_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_DaiLy_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            openChildForm(new FThongTinDaiLy());
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            openChildForm(new FThongTinNhapHang());
        }

        private void btn_XuatHang_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            openChildForm(new FThongTinXuatHang());
        }

        private void btn_ThuTien_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            openChildForm(new FThongTinThuTien());
        }

        private void btn_CongNo_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            openChildForm(new FThongTinThuNo());
        }

		private void btn_DoanhSo_Click(object sender, EventArgs e)
		{
            panel_Main.Controls.Clear();
            openChildForm(new FBaoCaoDoanhSo());
		}

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            this.Close();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}



}

