﻿
namespace VISTA.Notifications
{
    partial class frmErrorLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrorLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustom = new System.Windows.Forms.Label();
            this.btnAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMessajeDefault = new System.Windows.Forms.Label();
            this.plColor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.plColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblCustom);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.lblMessajeDefault);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 120);
            this.panel2.TabIndex = 6;
            // 
            // lblCustom
            // 
            this.lblCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Alata", 10.75F);
            this.lblCustom.Location = new System.Drawing.Point(4, 92);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(122, 24);
            this.lblCustom.TabIndex = 4;
            this.lblCustom.Text = "Custom messaje";
            this.lblCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustom.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Activecolor = System.Drawing.Color.Crimson;
            this.btnAccept.BackColor = System.Drawing.Color.Crimson;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.BorderRadius = 0;
            this.btnAccept.ButtonText = "Accept";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccept.Iconimage = null;
            this.btnAccept.Iconimage_right = null;
            this.btnAccept.Iconimage_right_Selected = null;
            this.btnAccept.Iconimage_Selected = null;
            this.btnAccept.IconMarginLeft = 0;
            this.btnAccept.IconMarginRight = 0;
            this.btnAccept.IconRightVisible = true;
            this.btnAccept.IconRightZoom = 0D;
            this.btnAccept.IconVisible = true;
            this.btnAccept.IconZoom = 90D;
            this.btnAccept.IsTab = false;
            this.btnAccept.Location = new System.Drawing.Point(330, 85);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Normalcolor = System.Drawing.Color.Crimson;
            this.btnAccept.OnHovercolor = System.Drawing.Color.Red;
            this.btnAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccept.selected = false;
            this.btnAccept.Size = new System.Drawing.Size(83, 29);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Textcolor = System.Drawing.Color.White;
            this.btnAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblMessajeDefault
            // 
            this.lblMessajeDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessajeDefault.AutoSize = true;
            this.lblMessajeDefault.Font = new System.Drawing.Font("Alata", 10.75F);
            this.lblMessajeDefault.Location = new System.Drawing.Point(71, 23);
            this.lblMessajeDefault.Name = "lblMessajeDefault";
            this.lblMessajeDefault.Size = new System.Drawing.Size(270, 24);
            this.lblMessajeDefault.TabIndex = 0;
            this.lblMessajeDefault.Text = "Incorrect username and / or password";
            this.lblMessajeDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plColor
            // 
            this.plColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.plColor.Controls.Add(this.pictureBox1);
            this.plColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.plColor.Location = new System.Drawing.Point(0, 0);
            this.plColor.Name = "plColor";
            this.plColor.Size = new System.Drawing.Size(419, 116);
            this.plColor.TabIndex = 5;
            this.plColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plColor_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmErrorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 236);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmErrorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "frmErrorLogin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustom;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccept;
        private System.Windows.Forms.Label lblMessajeDefault;
        private System.Windows.Forms.Panel plColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}