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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }
        float num1, num2, num3;
        float min = 0, max = 0;
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(tbSo1.Text.Trim());
                num2 = float.Parse(tbSo2.Text.Trim());
                num3 = float.Parse(tbSo3.Text.Trim());
                if (num1 < num2)
                {
                    min = num1;
                    max = num2;
                    if (min > num3)
                    {
                        min = num3;
                    }
                    if (max < num3)
                    {
                        max = num3;
                    }
                }
                else
                {
                    min = num2;
                    max = num1;
                    if (min > num3)
                    {
                        min = num3;
                    }
                    if (max < num3)
                    {
                        max = num3;
                    }
                }
                if (num1 != (float)num1 || num2 != (float)num2 || num3 != (float)num3)
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
                tbSoLonNhat.Text = max.ToString();
                tbSoNhoNhat.Text = min.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbSo1.Text = null;
            tbSo2.Text = null;
            tbSo3.Text = null;
            tbSoLonNhat.Text = null;
            tbSoNhoNhat.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
