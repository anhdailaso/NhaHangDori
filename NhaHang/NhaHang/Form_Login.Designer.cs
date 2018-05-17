namespace NhaHang
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_resserpass = new DevComponents.DotNetBar.ButtonX();
            this.btn_connect = new DevComponents.DotNetBar.ButtonX();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.btn_login = new DevComponents.DotNetBar.ButtonX();
            this.ckb_ghinho = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txt_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_resserpass
            // 
            this.btn_resserpass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_resserpass.BackColor = System.Drawing.Color.Blue;
            this.btn_resserpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_resserpass.BackgroundImage")));
            this.btn_resserpass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_resserpass.Location = new System.Drawing.Point(418, 356);
            this.btn_resserpass.Name = "btn_resserpass";
            this.btn_resserpass.Size = new System.Drawing.Size(93, 23);
            this.btn_resserpass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_resserpass.TabIndex = 15;
            this.btn_resserpass.Text = "đặc lại mật khẩu";
            this.btn_resserpass.Click += new System.EventHandler(this.btn_resserpass_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_connect.BackColor = System.Drawing.Color.Blue;
            this.btn_connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_connect.BackgroundImage")));
            this.btn_connect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_connect.Location = new System.Drawing.Point(122, 356);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(93, 23);
            this.btn_connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_connect.TabIndex = 14;
            this.btn_connect.Text = "cấu hình kết nối";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thoat.BackgroundImage")));
            this.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.btn_thoat.Location = new System.Drawing.Point(497, 18);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btn_thoat.Size = new System.Drawing.Size(80, 34);
            this.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "<b>thoát</b>";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(476, 254);
            this.btn_login.Name = "btn_login";
            this.btn_login.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.btn_login.Size = new System.Drawing.Size(101, 37);
            this.btn_login.TabIndex = 12;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // ckb_ghinho
            // 
            this.ckb_ghinho.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ckb_ghinho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_ghinho.Location = new System.Drawing.Point(209, 263);
            this.ckb_ghinho.Name = "ckb_ghinho";
            this.ckb_ghinho.Size = new System.Drawing.Size(15, 16);
            this.ckb_ghinho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_ghinho.TabIndex = 11;
            this.ckb_ghinho.CheckedChanged += new System.EventHandler(this.ckb_ghinho_CheckedChanged);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.Border.Class = "TextBoxBorder";
            this.txt_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Location = new System.Drawing.Point(253, 190);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(312, 32);
            this.txt_password.TabIndex = 10;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.WatermarkColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.Border.Class = "TextBoxBorder";
            this.txt_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.Location = new System.Drawing.Point(253, 130);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(312, 32);
            this.txt_id.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(603, 403);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 383);
            this.Controls.Add(this.btn_resserpass);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.ckb_ghinho);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btn_resserpass;
        private DevComponents.DotNetBar.ButtonX btn_connect;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private DevComponents.DotNetBar.ButtonX btn_login;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_ghinho;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}