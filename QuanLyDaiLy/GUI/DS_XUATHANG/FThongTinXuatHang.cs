﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.GUI.DS_XUATHANG
{
    public partial class FThongTinXuatHang : Form
    {
        public FThongTinXuatHang()
        {
            InitializeComponent();
        }

        private void btn_Taophieu_Click(object sender, EventArgs e)
        {
            FTaoPhieu fTaoPhieu = new FTaoPhieu();
            fTaoPhieu.ShowDialog ();
        }
    }
}
