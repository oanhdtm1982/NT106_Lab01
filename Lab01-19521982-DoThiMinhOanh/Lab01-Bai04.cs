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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }
        float num = 0;
        float result = 1;
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            string var = comboBox.Text;
            try
            {
                num = float.Parse(tbTienCanDoi.Text.Trim());

                switch (var)
                {
                    case "USD":
                        {
                            result = num * 22772;
                            break;
                        }
                    case "EUR":
                        {
                            result = num * 28132;
                            break;
                        }
                    case "GBP":
                        {
                            result = num * 31538;
                            break;
                        }
                    case "SGD":
                        {
                            result = num * 17286;
                            break;
                        }
                    case "JPY":
                        {
                            result = num * 214;
                            break;
                        }
                }
                if (num != (float)num)
                {
                    throw new System.FormatException();
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("VUI LONG NHAP DUNG SO TIEN CAN CHUYEN DOI");
            }
            finally
            {
                tbTienDaDoi.Text = result.ToString();

                switch (var)
                {
                    case "USD":
                        {
                            tbTyGia.Text = "1 USD = 22772 VND";
                            break;
                        }
                    case "EUR":
                        {
                            tbTyGia.Text = "1 EUR = 28132 VND";
                            break;
                        }
                    case "GBP":
                        {
                            tbTyGia.Text = "1 GBP = 31538 VND";
                            break;
                        }
                    case "SGD":
                        {
                            tbTyGia.Text = "1 SGD = 17286 VND";
                            break;
                        }
                    case "JPY":
                        {
                            tbTyGia.Text = "1 JPY = 214 VND";
                            break;
                        }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbTienCanDoi.Text = null;
            tbTienDaDoi.Text = null;
            tbTyGia.Text = null;
            comboBox.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
