namespace Lab01_19521982_DoThiMinhOanh
{
    partial class Lab01_Bai05
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
            this.NhapA = new System.Windows.Forms.Label();
            this.tbNhapA = new System.Windows.Forms.TextBox();
            this.tbNhapB = new System.Windows.Forms.TextBox();
            this.NhapB = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbS1 = new System.Windows.Forms.TextBox();
            this.tbS2 = new System.Windows.Forms.TextBox();
            this.tbS3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NhapA
            // 
            this.NhapA.AutoSize = true;
            this.NhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapA.Location = new System.Drawing.Point(87, 65);
            this.NhapA.Name = "NhapA";
            this.NhapA.Size = new System.Drawing.Size(70, 20);
            this.NhapA.TabIndex = 0;
            this.NhapA.Text = "Nhập A: ";
            // 
            // tbNhapA
            // 
            this.tbNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapA.Location = new System.Drawing.Point(187, 64);
            this.tbNhapA.Name = "tbNhapA";
            this.tbNhapA.Size = new System.Drawing.Size(160, 26);
            this.tbNhapA.TabIndex = 1;
            // 
            // tbNhapB
            // 
            this.tbNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapB.Location = new System.Drawing.Point(517, 65);
            this.tbNhapB.Name = "tbNhapB";
            this.tbNhapB.Size = new System.Drawing.Size(160, 26);
            this.tbNhapB.TabIndex = 3;
            // 
            // NhapB
            // 
            this.NhapB.AutoSize = true;
            this.NhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapB.Location = new System.Drawing.Point(417, 66);
            this.NhapB.Name = "NhapB";
            this.NhapB.Size = new System.Drawing.Size(74, 20);
            this.NhapB.TabIndex = 2;
            this.NhapB.Text = "Nhập B:  ";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(108, 144);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(210, 36);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính các giá trị";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(364, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(533, 144);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(87, 229);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(74, 20);
            this.KetQua.TabIndex = 7;
            this.KetQua.Text = "Kết Quả";
            // 
            // tbA
            // 
            this.tbA.Enabled = false;
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(187, 229);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(213, 26);
            this.tbA.TabIndex = 8;
            // 
            // tbB
            // 
            this.tbB.Enabled = false;
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(187, 261);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(213, 26);
            this.tbB.TabIndex = 9;
            // 
            // tbS1
            // 
            this.tbS1.Enabled = false;
            this.tbS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbS1.Location = new System.Drawing.Point(187, 293);
            this.tbS1.Name = "tbS1";
            this.tbS1.Size = new System.Drawing.Size(213, 26);
            this.tbS1.TabIndex = 10;
            // 
            // tbS2
            // 
            this.tbS2.Enabled = false;
            this.tbS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbS2.Location = new System.Drawing.Point(187, 325);
            this.tbS2.Name = "tbS2";
            this.tbS2.Size = new System.Drawing.Size(213, 26);
            this.tbS2.TabIndex = 11;
            // 
            // tbS3
            // 
            this.tbS3.Enabled = false;
            this.tbS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbS3.Location = new System.Drawing.Point(187, 357);
            this.tbS3.Name = "tbS3";
            this.tbS3.Size = new System.Drawing.Size(213, 26);
            this.tbS3.TabIndex = 12;
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbS3);
            this.Controls.Add(this.tbS2);
            this.Controls.Add(this.tbS1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.tbNhapB);
            this.Controls.Add(this.NhapB);
            this.Controls.Add(this.tbNhapA);
            this.Controls.Add(this.NhapA);
            this.Name = "Lab01_Bai05";
            this.Text = "Lab01_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhapA;
        private System.Windows.Forms.TextBox tbNhapA;
        private System.Windows.Forms.TextBox tbNhapB;
        private System.Windows.Forms.Label NhapB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbS1;
        private System.Windows.Forms.TextBox tbS2;
        private System.Windows.Forms.TextBox tbS3;
    }
}