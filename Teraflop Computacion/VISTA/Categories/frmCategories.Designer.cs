
namespace VISTA.Categories
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.codCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSeach = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProviderCompare = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifyCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.dgvCategories);
            this.gbCategory.Controls.Add(this.txtSearchCategory);
            this.gbCategory.Controls.Add(this.pictureBox2);
            this.gbCategory.Controls.Add(this.btnSearchCategory);
            this.gbCategory.Controls.Add(this.lblSeach);
            this.gbCategory.Controls.Add(this.dgvProducts);
            this.gbCategory.Controls.Add(this.dgvProviderCompare);
            this.gbCategory.Controls.Add(this.dgvProviders);
            this.gbCategory.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.ForeColor = System.Drawing.Color.White;
            this.gbCategory.Location = new System.Drawing.Point(12, 4);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(977, 536);
            this.gbCategory.TabIndex = 30;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeight = 40;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCategoryDataGridViewTextBoxColumn,
            this.nameCategoryDataGridViewTextBoxColumn});
            this.dgvCategories.DataSource = this.categoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvCategories.Location = new System.Drawing.Point(7, 27);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategories.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(964, 500);
            this.dgvCategories.TabIndex = 54;
            // 
            // codCategoryDataGridViewTextBoxColumn
            // 
            this.codCategoryDataGridViewTextBoxColumn.DataPropertyName = "Cod_Category";
            this.codCategoryDataGridViewTextBoxColumn.HeaderText = "Cod_Category";
            this.codCategoryDataGridViewTextBoxColumn.Name = "codCategoryDataGridViewTextBoxColumn";
            this.codCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameCategoryDataGridViewTextBoxColumn
            // 
            this.nameCategoryDataGridViewTextBoxColumn.DataPropertyName = "NameCategory";
            this.nameCategoryDataGridViewTextBoxColumn.HeaderText = "NameCategory";
            this.nameCategoryDataGridViewTextBoxColumn.Name = "nameCategoryDataGridViewTextBoxColumn";
            this.nameCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(MODELO.Category);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.txtSearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCategory.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.ForeColor = System.Drawing.Color.White;
            this.txtSearchCategory.Location = new System.Drawing.Point(130, 30);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(189, 23);
            this.txtSearchCategory.TabIndex = 53;
            this.txtSearchCategory.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(122)))));
            this.btnSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.btnSearchCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCategory.BorderRadius = 0;
            this.btnSearchCategory.ButtonText = "Search";
            this.btnSearchCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchCategory.Iconimage = null;
            this.btnSearchCategory.Iconimage_right = null;
            this.btnSearchCategory.Iconimage_right_Selected = null;
            this.btnSearchCategory.Iconimage_Selected = null;
            this.btnSearchCategory.IconMarginLeft = 0;
            this.btnSearchCategory.IconMarginRight = 0;
            this.btnSearchCategory.IconRightVisible = false;
            this.btnSearchCategory.IconRightZoom = 0D;
            this.btnSearchCategory.IconVisible = false;
            this.btnSearchCategory.IconZoom = 90D;
            this.btnSearchCategory.IsTab = false;
            this.btnSearchCategory.Location = new System.Drawing.Point(581, 100);
            this.btnSearchCategory.Margin = new System.Windows.Forms.Padding(9, 37, 9, 37);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.btnSearchCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.btnSearchCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchCategory.selected = false;
            this.btnSearchCategory.Size = new System.Drawing.Size(165, 185);
            this.btnSearchCategory.TabIndex = 2;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchCategory.Textcolor = System.Drawing.Color.White;
            this.btnSearchCategory.TextFont = new System.Drawing.Font("Alata", 10.75F);
            this.btnSearchCategory.Visible = false;
            // 
            // lblSeach
            // 
            this.lblSeach.AutoSize = true;
            this.lblSeach.Location = new System.Drawing.Point(3, 33);
            this.lblSeach.Name = "lblSeach";
            this.lblSeach.Size = new System.Drawing.Size(123, 24);
            this.lblSeach.TabIndex = 1;
            this.lblSeach.Text = "Search by name:";
            this.lblSeach.Visible = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(50, 132);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(742, 107);
            this.dgvProducts.TabIndex = 61;
            // 
            // dgvProviderCompare
            // 
            this.dgvProviderCompare.AllowUserToAddRows = false;
            this.dgvProviderCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categories});
            this.dgvProviderCompare.Location = new System.Drawing.Point(456, 89);
            this.dgvProviderCompare.Name = "dgvProviderCompare";
            this.dgvProviderCompare.ReadOnly = true;
            this.dgvProviderCompare.Size = new System.Drawing.Size(372, 150);
            this.dgvProviderCompare.TabIndex = 63;
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
            this.dgvProviders.Location = new System.Drawing.Point(22, 89);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(357, 150);
            this.dgvProviders.TabIndex = 62;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Activecolor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCategory.BorderRadius = 0;
            this.btnDeleteCategory.ButtonText = "   Delete";
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Iconimage")));
            this.btnDeleteCategory.Iconimage_right = null;
            this.btnDeleteCategory.Iconimage_right_Selected = null;
            this.btnDeleteCategory.Iconimage_Selected = null;
            this.btnDeleteCategory.IconMarginLeft = 0;
            this.btnDeleteCategory.IconMarginRight = 0;
            this.btnDeleteCategory.IconRightVisible = true;
            this.btnDeleteCategory.IconRightZoom = 0D;
            this.btnDeleteCategory.IconVisible = true;
            this.btnDeleteCategory.IconZoom = 80D;
            this.btnDeleteCategory.IsTab = false;
            this.btnDeleteCategory.Location = new System.Drawing.Point(305, 554);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteCategory.selected = false;
            this.btnDeleteCategory.Size = new System.Drawing.Size(98, 37);
            this.btnDeleteCategory.TabIndex = 66;
            this.btnDeleteCategory.Text = "   Delete";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnDeleteCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.Activecolor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifyCategory.BorderRadius = 0;
            this.btnModifyCategory.ButtonText = "   Modify";
            this.btnModifyCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifyCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifyCategory.Iconimage")));
            this.btnModifyCategory.Iconimage_right = null;
            this.btnModifyCategory.Iconimage_right_Selected = null;
            this.btnModifyCategory.Iconimage_Selected = null;
            this.btnModifyCategory.IconMarginLeft = 0;
            this.btnModifyCategory.IconMarginRight = 0;
            this.btnModifyCategory.IconRightVisible = true;
            this.btnModifyCategory.IconRightZoom = 0D;
            this.btnModifyCategory.IconVisible = true;
            this.btnModifyCategory.IconZoom = 80D;
            this.btnModifyCategory.IsTab = false;
            this.btnModifyCategory.Location = new System.Drawing.Point(161, 554);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifyCategory.selected = false;
            this.btnModifyCategory.Size = new System.Drawing.Size(98, 37);
            this.btnModifyCategory.TabIndex = 65;
            this.btnModifyCategory.Text = "   Modify";
            this.btnModifyCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifyCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnModifyCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.BorderRadius = 0;
            this.btnAddCategory.ButtonText = "   Add";
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Iconimage")));
            this.btnAddCategory.Iconimage_right = null;
            this.btnAddCategory.Iconimage_right_Selected = null;
            this.btnAddCategory.Iconimage_Selected = null;
            this.btnAddCategory.IconMarginLeft = 0;
            this.btnAddCategory.IconMarginRight = 0;
            this.btnAddCategory.IconRightVisible = true;
            this.btnAddCategory.IconRightZoom = 0D;
            this.btnAddCategory.IconVisible = true;
            this.btnAddCategory.IconZoom = 80D;
            this.btnAddCategory.IsTab = false;
            this.btnAddCategory.Location = new System.Drawing.Point(17, 554);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCategory.selected = false;
            this.btnAddCategory.Size = new System.Drawing.Size(91, 37);
            this.btnAddCategory.TabIndex = 64;
            this.btnAddCategory.Text = "   Add";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnAddCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MODELO.Customer);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1001, 599);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnModifyCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.gbCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSeach;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvProviderCompare;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categories;
        private System.Windows.Forms.DataGridView dgvProviders;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifyCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchCategory;
    }
}