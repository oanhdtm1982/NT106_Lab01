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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void tbSo1_TextChanged(object sender, EventArgs e)
        {

        }
        int num1, num2;
        long sum = 0;
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Int32.Parse(tbSo1.Text.Trim());
                num2 = Int32.Parse(tbSo2.Text.Trim());
                sum = num1 + num2;
                if (num1 != (int)num1 || num2 != (int)num2)
                {
                    throw new System.FormatException();

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("VUI LONG NHAP SO NGUYEN");
            }
            finally
            {
                tbKetQua.Text = sum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbKetQua.Text = null;
            tbSo2.Text = null;
            tbSo1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbSo1.Text = null;
            tbSo2.Text = null;
            tbKetQua.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
