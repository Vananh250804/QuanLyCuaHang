namespace QuanLyCuaHang.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLeft = new Guna.UI2.WinForms.Guna2Chip();
            this.panel2 = new Guna.UI2.WinForms.Guna2Chip();
            this.ptBox_login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel_Missing = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLeft.BorderColor = System.Drawing.Color.White;
            this.panelLeft.BorderRadius = 0;
            this.panelLeft.FillColor = System.Drawing.Color.Yellow;
            this.panelLeft.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(-1, -1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(335, 541);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Click += new System.EventHandler(this.guna2Chip1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderRadius = 0;
            this.panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(334, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 541);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "guna2Chip2";
            this.panel2.Click += new System.EventHandler(this.guna2Chip2_Click);
            // 
            // ptBox_login
            // 
            this.ptBox_login.Image = ((System.Drawing.Image)(resources.GetObject("ptBox_login.Image")));
            this.ptBox_login.ImageRotate = 0F;
            this.ptBox_login.Location = new System.Drawing.Point(424, 12);
            this.ptBox_login.Name = "ptBox_login";
            this.ptBox_login.Size = new System.Drawing.Size(227, 175);
            this.ptBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptBox_login.TabIndex = 2;
            this.ptBox_login.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderRadius = 15;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Username.IconLeft")));
            this.txt_Username.Location = new System.Drawing.Point(404, 262);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderText = "                           Tên đăng nhập";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(268, 36);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(478, 193);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(119, 27);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "ĐĂNG NHẬP";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderRadius = 15;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Password.IconLeft")));
            this.txt_Password.Location = new System.Drawing.Point(404, 316);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "                                Mật khẩu";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(268, 36);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // linkLabel_Missing
            // 
            this.linkLabel_Missing.AutoSize = true;
            this.linkLabel_Missing.Location = new System.Drawing.Point(410, 370);
            this.linkLabel_Missing.Name = "linkLabel_Missing";
            this.linkLabel_Missing.Size = new System.Drawing.Size(89, 13);
            this.linkLabel_Missing.TabIndex = 7;
            this.linkLabel_Missing.TabStop = true;
            this.linkLabel_Missing.Text = "Quên mật khẩu ?";
            this.linkLabel_Missing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Missing_LinkClicked);
            // 
            // btn_Login
            // 
            this.btn_Login.BorderRadius = 15;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(404, 399);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(268, 45);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(335, 541);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 541);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.linkLabel_Missing);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.ptBox_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.ptBox_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip panelLeft;
        private Guna.UI2.WinForms.Guna2Chip panel2;
        private Guna.UI2.WinForms.Guna2PictureBox ptBox_login;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelLogin;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.LinkLabel linkLabel_Missing;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}