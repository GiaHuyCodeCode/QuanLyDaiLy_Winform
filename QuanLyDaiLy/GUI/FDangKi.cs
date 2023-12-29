using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.GUI
{
    public partial class FDangKi : Form
    {
        public FDangKi()
        {
            InitializeComponent();
        }

        private void FDangKi_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
        }
    }
}
