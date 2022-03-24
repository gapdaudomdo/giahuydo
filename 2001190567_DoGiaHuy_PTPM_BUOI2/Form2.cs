using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001190567_DoGiaHuy_PTPM_BUOI2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string tendangnhap = "";

        private void button1_Click(object sender, EventArgs e)
        {
            tendangnhap = textBox1.Text;
            if (tendangnhap == "giahuydo" && textBox2.Text == "123")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!!!");
            }
        
        } 


    }
}
