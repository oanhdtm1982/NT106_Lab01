namespace Lab01_19521982_DoThiMinhOanh
{
    partial class Lab01_Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NhapSoTien = new System.Windows.Forms.Label();
            this.tbTienCanDoi = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.SoTienDaDoi = new System.Windows.Forms.Label();
            this.tbTienDaDoi = new System.Windows.Forms.TextBox();
            this.TyGiaQuyDoi = new System.Windows.Forms.Label();
            this.tbTyGia = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NhapSoTien
            // 
            this.NhapSoTien.AutoSize = true;
            this.NhapSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapSoTien.Location = new System.Drawing.Point(105, 67);
            this.NhapSoTien.Name = "NhapSoTien";
            this.NhapSoTien.Size = new System.Drawing.Size(122, 20);
            this.NhapSoTien.TabIndex = 0;
            this.NhapSoTien.Text = "Số tiền cần đổi: ";
            // 
            // tbTienCanDoi
            // 
            this.tbTienCanDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienCanDoi.Location = new System.Drawing.Point(234, 67);
            this.tbTienCanDoi.Name = "tbTienCanDoi";
            this.tbTienCanDoi.Size = new System.Drawing.Size(156, 26);
            this.tbTienCanDoi.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.comboBox.Location = new System.Drawing.Point(428, 67);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDoi.Location = new System.Drawing.Point(109, 143);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(281, 35);
            this.btnChuyenDoi.TabIndex = 3;
            this.btnChuyenDoi.Text = "Chuyển Đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // SoTienDaDoi
            // 
            this.SoTienDaDoi.AutoSize = true;
            this.SoTienDaDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoTienDaDoi.Location = new System.Drawing.Point(105, 231);
            this.SoTienDaDoi.Name = "SoTienDaDoi";
            this.SoTienDaDoi.Size = new System.Drawing.Size(114, 20);
            this.SoTienDaDoi.TabIndex = 4;
            this.SoTienDaDoi.Text = "Số tiền đã đổi: ";
            // 
            // tbTienDaDoi
            // 
            this.tbTienDaDoi.Enabled = false;
            this.tbTienDaDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienDaDoi.Location = new System.Drawing.Point(234, 231);
            this.tbTienDaDoi.Name = "tbTienDaDoi";
            this.tbTienDaDoi.Size = new System.Drawing.Size(156, 26);
            this.tbTienDaDoi.TabIndex = 5;
            // 
            // TyGiaQuyDoi
            // 
            this.TyGiaQuyDoi.AutoSize = true;
            this.TyGiaQuyDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyGiaQuyDoi.Location = new System.Drawing.Point(105, 294);
            this.TyGiaQuyDoi.Name = "TyGiaQuyDoi";
            this.TyGiaQuyDoi.Size = new System.Drawing.Size(112, 20);
            this.TyGiaQuyDoi.TabIndex = 6;
            this.TyGiaQuyDoi.Text = "Tỷ giá quy đổi: ";
            // 
            // tbTyGia
            // 
            this.tbTyGia.Enabled = false;
            this.tbTyGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTyGia.Location = new System.Drawing.Point(234, 291);
            this.tbTyGia.Name = "tbTyGia";
            this.tbTyGia.Size = new System.Drawing.Size(156, 26);
            this.tbTyGia.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(428, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(428, 260);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbTyGia);
            this.Controls.Add(this.TyGiaQuyDoi);
            this.Controls.Add(this.tbTienDaDoi);
            this.Controls.Add(this.SoTienDaDoi);
            this.Controls.Add(this.btnChuyenDoi);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.tbTienCanDoi);
            this.Controls.Add(this.NhapSoTien);
            this.Name = "Lab01_Bai04";
            this.Text = "Lab01_Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhapSoTien;
        private System.Windows.Forms.TextBox tbTienCanDoi;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Label SoTienDaDoi;
        private System.Windows.Forms.TextBox tbTienDaDoi;
        private System.Windows.Forms.Label TyGiaQuyDoi;
        private System.Windows.Forms.TextBox tbTyGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}