
namespace VISTA.Products
{
    partial class frmUpdateStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStock));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.plColor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessajeDefault = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAddStock = new System.Windows.Forms.RadioButton();
            this.rbRemoveStock = new System.Windows.Forms.RadioButton();
            this.btnAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUpdateStock = new System.Windows.Forms.GroupBox();
            this.txtStock = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.plColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUpdateStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // plColor
            // 
            this.plColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.plColor.Controls.Add(this.pictureBox2);
            this.plColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.plColor.Location = new System.Drawing.Point(0, 0);
            this.plColor.Name = "plColor";
            this.plColor.Size = new System.Drawing.Size(562, 116);
            this.plColor.TabIndex = 12;
            this.plColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plColor_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(250, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 98);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.gbUpdateStock);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.rbRemoveStock);
            this.panel2.Controls.Add(this.rbAddStock);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStockProduct);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNameProduct);
            this.panel2.Controls.Add(this.lblMessajeDefault);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 233);
            this.panel2.TabIndex = 13;
            // 
            // lblMessajeDefault
            // 
            this.lblMessajeDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessajeDefault.AutoSize = true;
            this.lblMessajeDefault.Font = new System.Drawing.Font("Alata", 10.75F);
            this.lblMessajeDefault.Location = new System.Drawing.Point(12, 17);
            this.lblMessajeDefault.Name = "lblMessajeDefault";
            this.lblMessajeDefault.Size = new System.Drawing.Size(160, 24);
            this.lblMessajeDefault.TabIndex = 0;
            this.lblMessajeDefault.Text = "Update product stock:";
            this.lblMessajeDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Alata", 10.75F);
            this.lblNameProduct.Location = new System.Drawing.Point(174, 17);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(104, 24);
            this.lblNameProduct.TabIndex = 5;
            this.lblNameProduct.Text = "Product name";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alata", 10.75F);
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockProduct
            // 
            this.lblStockProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockProduct.AutoSize = true;
            this.lblStockProduct.Font = new System.Drawing.Font("Alata", 10.75F);
            this.lblStockProduct.Location = new System.Drawing.Point(123, 53);
            this.lblStockProduct.Name = "lblStockProduct";
            this.lblStockProduct.Size = new System.Drawing.Size(47, 24);
            this.lblStockProduct.TabIndex = 7;
            this.lblStockProduct.Text = "Stock";
            this.lblStockProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alata", 10.75F);
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select action:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbAddStock
            // 
            this.rbAddStock.AutoSize = true;
            this.rbAddStock.Checked = true;
            this.rbAddStock.Location = new System.Drawing.Point(124, 108);
            this.rbAddStock.Name = "rbAddStock";
            this.rbAddStock.Size = new System.Drawing.Size(61, 31);
            this.rbAddStock.TabIndex = 113;
            this.rbAddStock.TabStop = true;
            this.rbAddStock.Text = "Add";
            this.rbAddStock.UseVisualStyleBackColor = true;
            this.rbAddStock.CheckedChanged += new System.EventHandler(this.rbAddStock_CheckedChanged);
            // 
            // rbRemoveStock
            // 
            this.rbRemoveStock.AutoSize = true;
            this.rbRemoveStock.Location = new System.Drawing.Point(124, 141);
            this.rbRemoveStock.Name = "rbRemoveStock";
            this.rbRemoveStock.Size = new System.Drawing.Size(89, 31);
            this.rbRemoveStock.TabIndex = 114;
            this.rbRemoveStock.Text = "Remove";
            this.rbRemoveStock.UseVisualStyleBackColor = true;
            this.rbRemoveStock.CheckedChanged += new System.EventHandler(this.rbRemoveStock_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.BorderRadius = 0;
            this.btnAccept.ButtonText = "Accept";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.btnAccept.Location = new System.Drawing.Point(448, 198);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccept.selected = false;
            this.btnAccept.Size = new System.Drawing.Size(108, 29);
            this.btnAccept.TabIndex = 115;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Textcolor = System.Drawing.Color.White;
            this.btnAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Crimson;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(6, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Crimson;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(108, 29);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alata", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 99;
            this.label3.Text = "Stock:";
            // 
            // gbUpdateStock
            // 
            this.gbUpdateStock.Controls.Add(this.txtStock);
            this.gbUpdateStock.Controls.Add(this.label3);
            this.gbUpdateStock.Controls.Add(this.pictureBox1);
            this.gbUpdateStock.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateStock.ForeColor = System.Drawing.Color.Black;
            this.gbUpdateStock.Location = new System.Drawing.Point(254, 59);
            this.gbUpdateStock.Name = "gbUpdateStock";
            this.gbUpdateStock.Size = new System.Drawing.Size(300, 130);
            this.gbUpdateStock.TabIndex = 117;
            this.gbUpdateStock.TabStop = false;
            this.gbUpdateStock.Text = "Add stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Silver;
            this.txtStock.BorderColor = System.Drawing.Color.Transparent;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Alata", 12F);
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(62, 53);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(51, 23);
            this.txtStock.TabIndex = 100;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plColor);
            this.Font = new System.Drawing.Font("Alata", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmUpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateStock";
            this.plColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUpdateStock.ResumeLayout(false);
            this.gbUpdateStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel plColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbUpdateStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccept;
        private System.Windows.Forms.RadioButton rbRemoveStock;
        private System.Windows.Forms.RadioButton rbAddStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblMessajeDefault;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStock;
    }
}