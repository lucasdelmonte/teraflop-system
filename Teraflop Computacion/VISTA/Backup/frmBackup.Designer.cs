
namespace VISTA.Backup
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.iconCompress = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSaveBackup = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConectar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRouteRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPathRestore = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCompress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.gbSaveBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnTopBar.Controls.Add(this.iconCompress);
            this.pnTopBar.Controls.Add(this.iconClose);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(509, 33);
            this.pnTopBar.TabIndex = 1;
            this.pnTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseMove);
            // 
            // iconCompress
            // 
            this.iconCompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCompress.Image = ((System.Drawing.Image)(resources.GetObject("iconCompress.Image")));
            this.iconCompress.Location = new System.Drawing.Point(452, 6);
            this.iconCompress.Name = "iconCompress";
            this.iconCompress.Size = new System.Drawing.Size(23, 23);
            this.iconCompress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCompress.TabIndex = 59;
            this.iconCompress.TabStop = false;
            this.iconCompress.Click += new System.EventHandler(this.iconCompress_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(480, 6);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(23, 23);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 58;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Alata", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 96;
            this.label3.Text = "Backup name:";
            // 
            // gbSaveBackup
            // 
            this.gbSaveBackup.Controls.Add(this.label2);
            this.gbSaveBackup.Controls.Add(this.btnConectar);
            this.gbSaveBackup.Controls.Add(this.txtBackupName);
            this.gbSaveBackup.Controls.Add(this.pictureBox4);
            this.gbSaveBackup.Controls.Add(this.label3);
            this.gbSaveBackup.Controls.Add(this.bunifuCustomLabel1);
            this.gbSaveBackup.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaveBackup.ForeColor = System.Drawing.Color.Black;
            this.gbSaveBackup.Location = new System.Drawing.Point(12, 110);
            this.gbSaveBackup.Name = "gbSaveBackup";
            this.gbSaveBackup.Size = new System.Drawing.Size(485, 148);
            this.gbSaveBackup.TabIndex = 102;
            this.gbSaveBackup.TabStop = false;
            this.gbSaveBackup.Text = "Create backup";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(193, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(147, 24);
            this.bunifuCustomLabel1.TabIndex = 117;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 116;
            this.label2.Text = "Example: TeraflopSystemDD-MM-YY";
            // 
            // btnConectar
            // 
            this.btnConectar.Activecolor = System.Drawing.Color.Transparent;
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConectar.BackColor = System.Drawing.Color.Transparent;
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConectar.BorderRadius = 0;
            this.btnConectar.ButtonText = "Create";
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConectar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConectar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConectar.Iconimage")));
            this.btnConectar.Iconimage_right = null;
            this.btnConectar.Iconimage_right_Selected = null;
            this.btnConectar.Iconimage_Selected = null;
            this.btnConectar.IconMarginLeft = 0;
            this.btnConectar.IconMarginRight = 0;
            this.btnConectar.IconRightVisible = true;
            this.btnConectar.IconRightZoom = 0D;
            this.btnConectar.IconVisible = true;
            this.btnConectar.IconZoom = 50D;
            this.btnConectar.IsTab = false;
            this.btnConectar.Location = new System.Drawing.Point(386, 96);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConectar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConectar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConectar.selected = false;
            this.btnConectar.Size = new System.Drawing.Size(108, 43);
            this.btnConectar.TabIndex = 115;
            this.btnConectar.Text = "Create";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConectar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnConectar.TextFont = new System.Drawing.Font("Consolas", 11.75F);
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtBackupName
            // 
            this.txtBackupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupName.BackColor = System.Drawing.Color.Silver;
            this.txtBackupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBackupName.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupName.ForeColor = System.Drawing.Color.White;
            this.txtBackupName.Location = new System.Drawing.Point(120, 51);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(353, 23);
            this.txtBackupName.TabIndex = 91;
            this.txtBackupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(117, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(359, 12);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRouteRestore);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.txtPathRestore);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 174);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restore backup";
            // 
            // btnRouteRestore
            // 
            this.btnRouteRestore.Activecolor = System.Drawing.Color.Transparent;
            this.btnRouteRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRouteRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRouteRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRouteRestore.BorderRadius = 0;
            this.btnRouteRestore.ButtonText = "Route";
            this.btnRouteRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRouteRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnRouteRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRouteRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRouteRestore.Iconimage")));
            this.btnRouteRestore.Iconimage_right = null;
            this.btnRouteRestore.Iconimage_right_Selected = null;
            this.btnRouteRestore.Iconimage_Selected = null;
            this.btnRouteRestore.IconMarginLeft = 0;
            this.btnRouteRestore.IconMarginRight = 0;
            this.btnRouteRestore.IconRightVisible = true;
            this.btnRouteRestore.IconRightZoom = 0D;
            this.btnRouteRestore.IconVisible = true;
            this.btnRouteRestore.IconZoom = 50D;
            this.btnRouteRestore.IsTab = false;
            this.btnRouteRestore.Location = new System.Drawing.Point(396, 47);
            this.btnRouteRestore.Margin = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.btnRouteRestore.Name = "btnRouteRestore";
            this.btnRouteRestore.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRouteRestore.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRouteRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRouteRestore.selected = false;
            this.btnRouteRestore.Size = new System.Drawing.Size(98, 38);
            this.btnRouteRestore.TabIndex = 117;
            this.btnRouteRestore.Text = "Route";
            this.btnRouteRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRouteRestore.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnRouteRestore.TextFont = new System.Drawing.Font("Consolas", 11.75F);
            this.btnRouteRestore.Click += new System.EventHandler(this.btnRouteRestore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Activecolor = System.Drawing.Color.Transparent;
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestore.BorderRadius = 0;
            this.btnRestore.ButtonText = "Restore";
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestore.Iconimage")));
            this.btnRestore.Iconimage_right = null;
            this.btnRestore.Iconimage_right_Selected = null;
            this.btnRestore.Iconimage_Selected = null;
            this.btnRestore.IconMarginLeft = 0;
            this.btnRestore.IconMarginRight = 0;
            this.btnRestore.IconRightVisible = true;
            this.btnRestore.IconRightZoom = 0D;
            this.btnRestore.IconVisible = true;
            this.btnRestore.IconZoom = 50D;
            this.btnRestore.IsTab = false;
            this.btnRestore.Location = new System.Drawing.Point(377, 130);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRestore.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestore.selected = false;
            this.btnRestore.Size = new System.Drawing.Size(120, 39);
            this.btnRestore.TabIndex = 116;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestore.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnRestore.TextFont = new System.Drawing.Font("Consolas", 11.75F);
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtPathRestore
            // 
            this.txtPathRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRestore.BackColor = System.Drawing.Color.Silver;
            this.txtPathRestore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathRestore.Enabled = false;
            this.txtPathRestore.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathRestore.ForeColor = System.Drawing.Color.White;
            this.txtPathRestore.Location = new System.Drawing.Point(9, 54);
            this.txtPathRestore.Name = "txtPathRestore";
            this.txtPathRestore.ReadOnly = true;
            this.txtPathRestore.Size = new System.Drawing.Size(355, 23);
            this.txtPathRestore.TabIndex = 91;
            this.txtPathRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Alata", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(185, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "Backup Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.Crimson;
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(389, 460);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Crimson;
            this.btnBack.OnHovercolor = System.Drawing.Color.Red;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(108, 29);
            this.btnBack.TabIndex = 105;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(509, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSaveBackup);
            this.Controls.Add(this.pnTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup";
            this.pnTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCompress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.gbSaveBackup.ResumeLayout(false);
            this.gbSaveBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.PictureBox iconCompress;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPathRestore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbSaveBackup;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnRouteRestore;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestore;
        private Bunifu.Framework.UI.BunifuFlatButton btnConectar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}