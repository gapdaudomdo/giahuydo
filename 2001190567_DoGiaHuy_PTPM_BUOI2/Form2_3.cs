﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace _2001190567_DoGiaHuy_PTPM_BUOI2
{
    public partial class Form2_3 : Form
    {
        public Form2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocChuSo dt = new DocChuSo();
            MessageBox.Show(dt.ChuyenSoSangChuoi(1505));
        }
    }
}
