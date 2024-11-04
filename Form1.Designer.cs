namespace TH_4_11_2024
{
    partial class Form1
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
            this.DataKH = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.HoaDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataKH
            // 
            this.DataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKH.Location = new System.Drawing.Point(-2, 34);
            this.DataKH.Name = "DataKH";
            this.DataKH.RowHeadersWidth = 51;
            this.DataKH.RowTemplate.Height = 24;
            this.DataKH.Size = new System.Drawing.Size(618, 348);
            this.DataKH.TabIndex = 4;
            this.DataKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataKH_CellContentClick);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(13, 389);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 5;
            this.them.Text = " Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(103, 389);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(193, 389);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = " Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // HoaDon
            // 
            this.HoaDon.Location = new System.Drawing.Point(283, 389);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(136, 23);
            this.HoaDon.TabIndex = 8;
            this.HoaDon.Text = "In Hóa Đơn";
            this.HoaDon.UseVisualStyleBackColor = true;
            this.HoaDon.Click += new System.EventHandler(this.HoaDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số Điện Thoại";
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(738, 310);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(225, 22);
            this.SDT.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = " Tên Khách Hàng";
            // 
            // TenKH
            // 
            this.TenKH.Location = new System.Drawing.Point(738, 269);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(225, 22);
            this.TenKH.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(738, 233);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(225, 22);
            this.MaKH.TabIndex = 10;
            this.MaKH.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = " Địa Chỉ";
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(738, 349);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(225, 22);
            this.DiaChi.TabIndex = 16;
            // 
            // DV
            // 
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DV.Location = new System.Drawing.Point(623, 34);
            this.DV.Name = "DV";
            this.DV.RowHeadersWidth = 51;
            this.DV.RowTemplate.Height = 24;
            this.DV.Size = new System.Drawing.Size(419, 193);
            this.DV.TabIndex = 18;
            this.DV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DV_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.DV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.HoaDon);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.DataKH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataKH;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button HoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiaChi;
        private System.Windows.Forms.DataGridView DV;
    }
}

