﻿namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    partial class Danhchosinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Danhchosinhvien));
            this.txbTendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkpass = new System.Windows.Forms.CheckBox();
            this.errorPic2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.errorPic1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTendangnhap
            // 
            this.txbTendangnhap.AcceptsTab = true;
            this.txbTendangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbTendangnhap.BorderRadius = 15;
            this.txbTendangnhap.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txbTendangnhap.DefaultText = "";
            this.txbTendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbTendangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTendangnhap.Location = new System.Drawing.Point(116, 172);
            this.txbTendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txbTendangnhap.Name = "txbTendangnhap";
            this.txbTendangnhap.PasswordChar = '\0';
            this.txbTendangnhap.PlaceholderText = "Tên đăng nhập";
            this.txbTendangnhap.SelectedText = "";
            this.txbTendangnhap.Size = new System.Drawing.Size(257, 56);
            this.txbTendangnhap.TabIndex = 7;
            this.txbTendangnhap.TextChanged += new System.EventHandler(this.txbTendangnhap_TextChanged);
            this.txbTendangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTendangnhap_KeyPress);
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.AcceptsTab = true;
            this.txbMatkhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbMatkhau.BorderRadius = 15;
            this.txbMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatkhau.DefaultText = "";
            this.txbMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txbMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMatkhau.Location = new System.Drawing.Point(116, 232);
            this.txbMatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.PasswordChar = '*';
            this.txbMatkhau.PlaceholderText = "Mật khẩu";
            this.txbMatkhau.SelectedText = "";
            this.txbMatkhau.Size = new System.Drawing.Size(257, 52);
            this.txbMatkhau.TabIndex = 6;
            this.txbMatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatkhau_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quên mật khẩu ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangnhap.BorderRadius = 15;
            this.btnDangnhap.BorderThickness = 1;
            this.btnDangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnDangnhap.FocusedColor = System.Drawing.Color.Transparent;
            this.btnDangnhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangnhap.IndicateFocus = true;
            this.btnDangnhap.Location = new System.Drawing.Point(97, 342);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(318, 55);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hướng dẫn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(160, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dành Cho Sinh Viên";
            // 
            // checkpass
            // 
            this.checkpass.AutoSize = true;
            this.checkpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkpass.Location = new System.Drawing.Point(116, 289);
            this.checkpass.Name = "checkpass";
            this.checkpass.Size = new System.Drawing.Size(95, 17);
            this.checkpass.TabIndex = 9;
            this.checkpass.Text = "Hiện mật khẩu";
            this.checkpass.UseVisualStyleBackColor = true;
            this.checkpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // errorPic2
            // 
            this.errorPic2.BackColor = System.Drawing.Color.Transparent;
            this.errorPic2.FillColor = System.Drawing.Color.Transparent;
            this.errorPic2.Image = global::ChuongTrinhQuanLyKyTuXa_Version3.Properties.Resources.process_error_icon_1024x1024_qxlzzqvg;
            this.errorPic2.ImageRotate = 0F;
            this.errorPic2.InitialImage = ((System.Drawing.Image)(resources.GetObject("errorPic2.InitialImage")));
            this.errorPic2.Location = new System.Drawing.Point(377, 247);
            this.errorPic2.Margin = new System.Windows.Forms.Padding(2);
            this.errorPic2.Name = "errorPic2";
            this.errorPic2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.errorPic2.Size = new System.Drawing.Size(28, 27);
            this.errorPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPic2.TabIndex = 0;
            this.errorPic2.TabStop = false;
            this.errorPic2.Visible = false;
            // 
            // errorPic1
            // 
            this.errorPic1.BackColor = System.Drawing.Color.Transparent;
            this.errorPic1.FillColor = System.Drawing.Color.Transparent;
            this.errorPic1.Image = global::ChuongTrinhQuanLyKyTuXa_Version3.Properties.Resources.process_error_icon_1024x1024_qxlzzqvg;
            this.errorPic1.ImageRotate = 0F;
            this.errorPic1.InitialImage = ((System.Drawing.Image)(resources.GetObject("errorPic1.InitialImage")));
            this.errorPic1.Location = new System.Drawing.Point(377, 192);
            this.errorPic1.Margin = new System.Windows.Forms.Padding(2);
            this.errorPic1.Name = "errorPic1";
            this.errorPic1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.errorPic1.Size = new System.Drawing.Size(28, 27);
            this.errorPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPic1.TabIndex = 1;
            this.errorPic1.TabStop = false;
            this.errorPic1.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ChuongTrinhQuanLyKyTuXa_Version3.Properties.Resources.Logo_UEH_xanh;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(131, 1);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(242, 129);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Danhchosinhvien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 408);
            this.Controls.Add(this.checkpass);
            this.Controls.Add(this.errorPic2);
            this.Controls.Add(this.errorPic1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMatkhau);
            this.Controls.Add(this.txbTendangnhap);
            this.Controls.Add(this.guna2PictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Danhchosinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txbTendangnhap;
        private Guna.UI2.WinForms.Guna2TextBox txbMatkhau;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox errorPic1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox errorPic2;
        private System.Windows.Forms.CheckBox checkpass;
    }
}