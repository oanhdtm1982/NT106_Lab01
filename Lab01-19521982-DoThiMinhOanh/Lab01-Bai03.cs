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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }
        int num;
        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                num = Int32.Parse(tbNhap.Text.Trim());
                switch (num)
                {
                    case 0:
                        tbKetQua.Text = "Không";
                        break;
                    case 1:
                        tbKetQua.Text = "Một";
                        break;
                    case 2:
                        tbKetQua.Text = "Hai";
                        break;
                    case 3:
                        tbKetQua.Text = "Ba";
                        break;
                    case 4:
                        tbKetQua.Text = "Bốn";
                        break;
                    case 5:
                        tbKetQua.Text = "Năm";
                        break;
                    case 6:
                        tbKetQua.Text = "Sáu";
                        break;
                    case 7:
                        tbKetQua.Text = "Bảy";
                        break;
                    case 8:
                        tbKetQua.Text = "Tám";
                        break;
                    case 9:
                        tbKetQua.Text = "Chín";
                        break;
                }
                if (num / 10 != 0)
                {
                    throw new System.FormatException();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("VUI LONG NHAP SO CO MOT CHU SO");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNhap.Text = null;
            tbKetQua.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
