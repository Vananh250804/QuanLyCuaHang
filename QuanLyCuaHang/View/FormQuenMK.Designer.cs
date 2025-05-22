namespace QuanLyCuaHang.View
{
    partial class FormQuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMK));
            this.panel_QuenMK = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_QuenMK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_QuenMK = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_QuenMK
            // 
            this.panel_QuenMK.BorderRadius = 0;
            this.panel_QuenMK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_QuenMK.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.panel_QuenMK.ForeColor = System.Drawing.Color.White;
            this.panel_QuenMK.Location = new System.Drawing.Point(0, 0);
            this.panel_QuenMK.Name = "panel_QuenMK";
            this.panel_QuenMK.Size = new System.Drawing.Size(496, 461);
            this.panel_QuenMK.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(131, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(263, 162);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label_QuenMK
            // 
            this.label_QuenMK.BackColor = System.Drawing.Color.Transparent;
            this.label_QuenMK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QuenMK.Location = new System.Drawing.Point(166, 180);
            this.label_QuenMK.Name = "label_QuenMK";
            this.label_QuenMK.Size = new System.Drawing.Size(183, 27);
            this.label_QuenMK.TabIndex = 4;
            this.label_QuenMK.Text = "Nhập email xác thực";
            this.label_QuenMK.Click += new System.EventHandler(this.label_QuenMK_Click);
            // 
            // txt_QuenMK
            // 
            this.txt_QuenMK.BorderRadius = 15;
            this.txt_QuenMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuenMK.DefaultText = "";
            this.txt_QuenMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QuenMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QuenMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuenMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuenMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuenMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QuenMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuenMK.Location = new System.Drawing.Point(96, 235);
            this.txt_QuenMK.Name = "txt_QuenMK";
            this.txt_QuenMK.PlaceholderText = "                                        Nhập email";
            this.txt_QuenMK.SelectedText = "";
            this.txt_QuenMK.Size = new System.Drawing.Size(325, 36);
            this.txt_QuenMK.TabIndex = 5;
            // 
            // FormQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 459);
            this.Controls.Add(this.txt_QuenMK);
            this.Controls.Add(this.label_QuenMK);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel_QuenMK);
            this.Name = "FormQuenMK";
            this.Text = "FormQuenMK";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip panel_QuenMK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_QuenMK;
        private Guna.UI2.WinForms.Guna2TextBox txt_QuenMK;
    }
}