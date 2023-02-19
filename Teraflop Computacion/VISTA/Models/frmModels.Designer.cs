
namespace VISTA.Models
{
    partial class frmModels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModels));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProviderCompare = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gbModels = new System.Windows.Forms.GroupBox();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.codModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchModel = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteModel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifyModel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddModel = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.gbModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(110, 233);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(742, 107);
            this.dgvProducts.TabIndex = 64;
            // 
            // dgvProviderCompare
            // 
            this.dgvProviderCompare.AllowUserToAddRows = false;
            this.dgvProviderCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categories});
            this.dgvProviderCompare.Location = new System.Drawing.Point(516, 190);
            this.dgvProviderCompare.Name = "dgvProviderCompare";
            this.dgvProviderCompare.ReadOnly = true;
            this.dgvProviderCompare.Size = new System.Drawing.Size(372, 150);
            this.dgvProviderCompare.TabIndex = 66;
            // 
            // Categories
            // 
            this.Categories.HeaderText = "Categories";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // dgvProviders
            // 
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Location = new System.Drawing.Point(82, 190);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(357, 150);
            this.dgvProviders.TabIndex = 65;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gbModels
            // 
            this.gbModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbModels.Controls.Add(this.dgvModels);
            this.gbModels.Controls.Add(this.txtSearchModel);
            this.gbModels.Controls.Add(this.pictureBox3);
            this.gbModels.Controls.Add(this.label2);
            this.gbModels.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModels.ForeColor = System.Drawing.Color.White;
            this.gbModels.Location = new System.Drawing.Point(12, 4);
            this.gbModels.Name = "gbModels";
            this.gbModels.Size = new System.Drawing.Size(977, 537);
            this.gbModels.TabIndex = 67;
            this.gbModels.TabStop = false;
            this.gbModels.Text = "Models";
            // 
            // dgvModels
            // 
            this.dgvModels.AllowUserToAddRows = false;
            this.dgvModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModels.AutoGenerateColumns = false;
            this.dgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.dgvModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvModels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModels.ColumnHeadersHeight = 40;
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codModelDataGridViewTextBoxColumn,
            this.nameModelDataGridViewTextBoxColumn});
            this.dgvModels.DataSource = this.modelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModels.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModels.EnableHeadersVisualStyles = false;
            this.dgvModels.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvModels.Location = new System.Drawing.Point(7, 27);
            this.dgvModels.MultiSelect = false;
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.ReadOnly = true;
            this.dgvModels.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModels.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.dgvModels.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModels.Size = new System.Drawing.Size(964, 504);
            this.dgvModels.TabIndex = 54;
            // 
            // codModelDataGridViewTextBoxColumn
            // 
            this.codModelDataGridViewTextBoxColumn.DataPropertyName = "Cod_Model";
            this.codModelDataGridViewTextBoxColumn.HeaderText = "Cod_Model";
            this.codModelDataGridViewTextBoxColumn.Name = "codModelDataGridViewTextBoxColumn";
            this.codModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameModelDataGridViewTextBoxColumn
            // 
            this.nameModelDataGridViewTextBoxColumn.DataPropertyName = "NameModel";
            this.nameModelDataGridViewTextBoxColumn.HeaderText = "NameModel";
            this.nameModelDataGridViewTextBoxColumn.Name = "nameModelDataGridViewTextBoxColumn";
            this.nameModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MODELO.Model);
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.txtSearchModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchModel.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchModel.ForeColor = System.Drawing.Color.White;
            this.txtSearchModel.Location = new System.Drawing.Point(130, 30);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(189, 23);
            this.txtSearchModel.TabIndex = 53;
            this.txtSearchModel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(126, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by name:";
            this.label2.Visible = false;
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Activecolor = System.Drawing.Color.Transparent;
            this.btnDeleteModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteModel.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteModel.BorderRadius = 0;
            this.btnDeleteModel.ButtonText = "   Delete";
            this.btnDeleteModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteModel.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteModel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteModel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteModel.Iconimage")));
            this.btnDeleteModel.Iconimage_right = null;
            this.btnDeleteModel.Iconimage_right_Selected = null;
            this.btnDeleteModel.Iconimage_Selected = null;
            this.btnDeleteModel.IconMarginLeft = 0;
            this.btnDeleteModel.IconMarginRight = 0;
            this.btnDeleteModel.IconRightVisible = true;
            this.btnDeleteModel.IconRightZoom = 0D;
            this.btnDeleteModel.IconVisible = true;
            this.btnDeleteModel.IconZoom = 80D;
            this.btnDeleteModel.IsTab = false;
            this.btnDeleteModel.Location = new System.Drawing.Point(306, 555);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDeleteModel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDeleteModel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteModel.selected = false;
            this.btnDeleteModel.Size = new System.Drawing.Size(98, 37);
            this.btnDeleteModel.TabIndex = 70;
            this.btnDeleteModel.Text = "   Delete";
            this.btnDeleteModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteModel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnDeleteModel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteModel.Click += new System.EventHandler(this.btnDeleteModel_Click);
            // 
            // btnModifyModel
            // 
            this.btnModifyModel.Activecolor = System.Drawing.Color.Transparent;
            this.btnModifyModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyModel.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifyModel.BorderRadius = 0;
            this.btnModifyModel.ButtonText = "   Modify";
            this.btnModifyModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyModel.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifyModel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifyModel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifyModel.Iconimage")));
            this.btnModifyModel.Iconimage_right = null;
            this.btnModifyModel.Iconimage_right_Selected = null;
            this.btnModifyModel.Iconimage_Selected = null;
            this.btnModifyModel.IconMarginLeft = 0;
            this.btnModifyModel.IconMarginRight = 0;
            this.btnModifyModel.IconRightVisible = true;
            this.btnModifyModel.IconRightZoom = 0D;
            this.btnModifyModel.IconVisible = true;
            this.btnModifyModel.IconZoom = 80D;
            this.btnModifyModel.IsTab = false;
            this.btnModifyModel.Location = new System.Drawing.Point(162, 555);
            this.btnModifyModel.Name = "btnModifyModel";
            this.btnModifyModel.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModifyModel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnModifyModel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifyModel.selected = false;
            this.btnModifyModel.Size = new System.Drawing.Size(98, 37);
            this.btnModifyModel.TabIndex = 69;
            this.btnModifyModel.Text = "   Modify";
            this.btnModifyModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifyModel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnModifyModel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyModel.Click += new System.EventHandler(this.btnModifyModel_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddModel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddModel.BorderRadius = 0;
            this.btnAddModel.ButtonText = "   Add";
            this.btnAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddModel.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddModel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddModel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddModel.Iconimage")));
            this.btnAddModel.Iconimage_right = null;
            this.btnAddModel.Iconimage_right_Selected = null;
            this.btnAddModel.Iconimage_Selected = null;
            this.btnAddModel.IconMarginLeft = 0;
            this.btnAddModel.IconMarginRight = 0;
            this.btnAddModel.IconRightVisible = true;
            this.btnAddModel.IconRightZoom = 0D;
            this.btnAddModel.IconVisible = true;
            this.btnAddModel.IconZoom = 80D;
            this.btnAddModel.IsTab = false;
            this.btnAddModel.Location = new System.Drawing.Point(18, 555);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddModel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddModel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddModel.selected = false;
            this.btnAddModel.Size = new System.Drawing.Size(91, 37);
            this.btnAddModel.TabIndex = 68;
            this.btnAddModel.Text = "   Add";
            this.btnAddModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddModel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnAddModel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // frmModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1001, 599);
            this.Controls.Add(this.gbModels);
            this.Controls.Add(this.btnDeleteModel);
            this.Controls.Add(this.btnModifyModel);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvProviderCompare);
            this.Controls.Add(this.dgvProviders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModels";
            this.Text = "frmModels";
            this.Load += new System.EventHandler(this.frmModels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.gbModels.ResumeLayout(false);
            this.gbModels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvProviderCompare;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categories;
        private System.Windows.Forms.DataGridView dgvProviders;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox gbModels;
        private System.Windows.Forms.DataGridView dgvModels;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteModel;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifyModel;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modelBindingSource;
    }
}