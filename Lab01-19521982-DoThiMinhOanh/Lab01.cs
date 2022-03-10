using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_19521982_DoThiMinhOanh
{
    public partial class FormLab01 : Form
    {
        public FormLab01()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form Bai01 = new Lab01_Bai01();
            Bai01.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form Bai02 = new Lab01_Bai02();
            Bai02.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form Bai03 = new Lab01_Bai03();
            Bai03.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form Bai04 = new Lab01_Bai04();
            Bai04.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Form Bai05 = new Lab01_Bai05();
            Bai05.ShowDialog();
        }
    }
}
