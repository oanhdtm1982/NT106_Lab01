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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }
        int num1, num2;
        long A = 1;
        long B = 1;
        long S1 = 0;
        long S2 = 0;
        long S3 = 0;
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Int32.Parse(tbNhapA.Text.Trim());
                num2 = Int32.Parse(tbNhapB.Text.Trim());
                for (int i = num1; i > 0; i--)
                {
                    A = A * i;
                }
                for (int j = num2; j > 0; j--)
                {
                    B = B * j;
                }

                for (int i = 1; i <= num1; i++)
                {
                    S1 += i;
                }
                for (int j = 1; j <= num2; j++)
                {
                    S2 += j;
                }

                for (int i = 1; i <= num2; i++)
                {
                    S3 += (long)Math.Pow(num1, i);
                }
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
                tbA.Text = "A! = " + A.ToString();
                tbB.Text = "A! = " + B.ToString();
                tbS1.Text = "S1 = " + S1.ToString();
                tbS2.Text = "S2 = " + S2.ToString();
                tbS3.Text = "S3 = " + S3.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNhapA.Text = null;
            tbNhapB.Text = null;
            tbA.Text = null;
            tbB.Text = null;
            tbS1.Text = null;
            tbS2.Text = null;
            tbS3.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
