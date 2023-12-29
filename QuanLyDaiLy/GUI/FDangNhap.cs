using QuanLyDaiLy.GUI;
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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            FDangKi dangki = new FDangKi();
            dangki.Show();
            dangki.BringToFront();

        }
    }
}
