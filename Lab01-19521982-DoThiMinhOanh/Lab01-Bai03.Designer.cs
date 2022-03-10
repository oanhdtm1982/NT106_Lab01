namespace Lab01_19521982_DoThiMinhOanh
{
    partial class Lab01_Bai03
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
            this.NhapSoNguyen = new System.Windows.Forms.Label();
            this.tbNhap = new System.Windows.Forms.TextBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NhapSoNguyen
            // 
            this.NhapSoNguyen.AutoSize = true;
            this.NhapSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapSoNguyen.Location = new System.Drawing.Point(149, 120);
            this.NhapSoNguyen.Name = "NhapSoNguyen";
            this.NhapSoNguyen.Size = new System.Drawing.Size(199, 20);
            this.NhapSoNguyen.TabIndex = 0;
            this.NhapSoNguyen.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // tbNhap
            // 
            this.tbNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhap.Location = new System.Drawing.Point(384, 120);
            this.tbNhap.Name = "tbNhap";
            this.tbNhap.Size = new System.Drawing.Size(100, 26);
            this.tbNhap.TabIndex = 1;
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(506, 144);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(79, 35);
            this.btnDoc.TabIndex = 2;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(506, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(506, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 35);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(149, 201);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(72, 20);
            this.KetQua.TabIndex = 5;
            this.KetQua.Text = "Kết quả: ";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Enabled = false;
            this.tbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKetQua.Location = new System.Drawing.Point(248, 203);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(173, 26);
            this.tbKetQua.TabIndex = 6;
            // 
            // Lab01_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.tbNhap);
            this.Controls.Add(this.NhapSoNguyen);
            this.Name = "Lab01_Bai03";
            this.Text = "Lab01_Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhapSoNguyen;
        private System.Windows.Forms.TextBox tbNhap;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.TextBox tbKetQua;
    }
}