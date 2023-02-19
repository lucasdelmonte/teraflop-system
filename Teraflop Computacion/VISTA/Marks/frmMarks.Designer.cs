
namespace VISTA.Marks
{
    partial class frmMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarks));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProviderCompare = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gbMark = new System.Windows.Forms.GroupBox();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.codMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtSearchMark = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteMark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifyMark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddMark = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.gbMark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(100, 235);
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
            this.dgvProviderCompare.Location = new System.Drawing.Point(506, 192);
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
            this.dgvProviders.Location = new System.Drawing.Point(72, 192);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(357, 150);
            this.dgvProviders.TabIndex = 65;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gbMark
            // 
            this.gbMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMark.Controls.Add(this.dgvMarks);
            this.gbMark.Controls.Add(this.dataGridView1);
            this.gbMark.Controls.Add(this.dataGridView2);
            this.gbMark.Controls.Add(this.dataGridView3);
            this.gbMark.Controls.Add(this.txtSearchMark);
            this.gbMark.Controls.Add(this.pictureBox1);
            this.gbMark.Controls.Add(this.label1);
            this.gbMark.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMark.ForeColor = System.Drawing.Color.White;
            this.gbMark.Location = new System.Drawing.Point(12, 4);
            this.gbMark.Name = "gbMark";
            this.gbMark.Size = new System.Drawing.Size(977, 537);
            this.gbMark.TabIndex = 67;
            this.gbMark.TabStop = false;
            this.gbMark.Text = "Mark";
            // 
            // dgvMarks
            // 
            this.dgvMarks.AllowUserToAddRows = false;
            this.dgvMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarks.AutoGenerateColumns = false;
            this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMarks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.dgvMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarks.ColumnHeadersHeight = 40;
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMarkDataGridViewTextBoxColumn,
            this.nameMarkDataGridViewTextBoxColumn});
            this.dgvMarks.DataSource = this.markBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarks.EnableHeadersVisualStyles = false;
            this.dgvMarks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvMarks.Location = new System.Drawing.Point(7, 27);
            this.dgvMarks.MultiSelect = false;
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.ReadOnly = true;
            this.dgvMarks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarks.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.dgvMarks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarks.Size = new System.Drawing.Size(964, 504);
            this.dgvMarks.TabIndex = 54;
            // 
            // codMarkDataGridViewTextBoxColumn
            // 
            this.codMarkDataGridViewTextBoxColumn.DataPropertyName = "Cod_Mark";
            this.codMarkDataGridViewTextBoxColumn.HeaderText = "Cod_Mark";
            this.codMarkDataGridViewTextBoxColumn.Name = "codMarkDataGridViewTextBoxColumn";
            this.codMarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameMarkDataGridViewTextBoxColumn
            // 
            this.nameMarkDataGridViewTextBoxColumn.DataPropertyName = "NameMark";
            this.nameMarkDataGridViewTextBoxColumn.HeaderText = "NameMark";
            this.nameMarkDataGridViewTextBoxColumn.Name = "nameMarkDataGridViewTextBoxColumn";
            this.nameMarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataSource = typeof(MODELO.Mark);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 107);
            this.dataGridView1.TabIndex = 64;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(519, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(372, 150);
            this.dataGridView2.TabIndex = 66;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Categories";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(85, 193);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(357, 150);
            this.dataGridView3.TabIndex = 65;
            // 
            // txtSearchMark
            // 
            this.txtSearchMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.txtSearchMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchMark.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMark.ForeColor = System.Drawing.Color.White;
            this.txtSearchMark.Location = new System.Drawing.Point(130, 30);
            this.txtSearchMark.Name = "txtSearchMark";
            this.txtSearchMark.Size = new System.Drawing.Size(189, 23);
            this.txtSearchMark.TabIndex = 53;
            this.txtSearchMark.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by name:";
            this.label1.Visible = false;
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Activecolor = System.Drawing.Color.Transparent;
            this.btnDeleteMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteMark.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteMark.BorderRadius = 0;
            this.btnDeleteMark.ButtonText = "   Delete";
            this.btnDeleteMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMark.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteMark.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteMark.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteMark.Iconimage")));
            this.btnDeleteMark.Iconimage_right = null;
            this.btnDeleteMark.Iconimage_right_Selected = null;
            this.btnDeleteMark.Iconimage_Selected = null;
            this.btnDeleteMark.IconMarginLeft = 0;
            this.btnDeleteMark.IconMarginRight = 0;
            this.btnDeleteMark.IconRightVisible = true;
            this.btnDeleteMark.IconRightZoom = 0D;
            this.btnDeleteMark.IconVisible = true;
            this.btnDeleteMark.IconZoom = 80D;
            this.btnDeleteMark.IsTab = false;
            this.btnDeleteMark.Location = new System.Drawing.Point(306, 555);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDeleteMark.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDeleteMark.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteMark.selected = false;
            this.btnDeleteMark.Size = new System.Drawing.Size(98, 37);
            this.btnDeleteMark.TabIndex = 60;
            this.btnDeleteMark.Text = "   Delete";
            this.btnDeleteMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteMark.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnDeleteMark.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // btnModifyMark
            // 
            this.btnModifyMark.Activecolor = System.Drawing.Color.Transparent;
            this.btnModifyMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyMark.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifyMark.BorderRadius = 0;
            this.btnModifyMark.ButtonText = "   Modify";
            this.btnModifyMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyMark.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifyMark.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifyMark.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifyMark.Iconimage")));
            this.btnModifyMark.Iconimage_right = null;
            this.btnModifyMark.Iconimage_right_Selected = null;
            this.btnModifyMark.Iconimage_Selected = null;
            this.btnModifyMark.IconMarginLeft = 0;
            this.btnModifyMark.IconMarginRight = 0;
            this.btnModifyMark.IconRightVisible = true;
            this.btnModifyMark.IconRightZoom = 0D;
            this.btnModifyMark.IconVisible = true;
            this.btnModifyMark.IconZoom = 80D;
            this.btnModifyMark.IsTab = false;
            this.btnModifyMark.Location = new System.Drawing.Point(162, 555);
            this.btnModifyMark.Name = "btnModifyMark";
            this.btnModifyMark.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModifyMark.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnModifyMark.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifyMark.selected = false;
            this.btnModifyMark.Size = new System.Drawing.Size(98, 37);
            this.btnModifyMark.TabIndex = 59;
            this.btnModifyMark.Text = "   Modify";
            this.btnModifyMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifyMark.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnModifyMark.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyMark.Click += new System.EventHandler(this.btnModifyMark_Click);
            // 
            // btnAddMark
            // 
            this.btnAddMark.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMark.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMark.BorderRadius = 0;
            this.btnAddMark.ButtonText = "   Add";
            this.btnAddMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMark.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddMark.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddMark.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddMark.Iconimage")));
            this.btnAddMark.Iconimage_right = null;
            this.btnAddMark.Iconimage_right_Selected = null;
            this.btnAddMark.Iconimage_Selected = null;
            this.btnAddMark.IconMarginLeft = 0;
            this.btnAddMark.IconMarginRight = 0;
            this.btnAddMark.IconRightVisible = true;
            this.btnAddMark.IconRightZoom = 0D;
            this.btnAddMark.IconVisible = true;
            this.btnAddMark.IconZoom = 80D;
            this.btnAddMark.IsTab = false;
            this.btnAddMark.Location = new System.Drawing.Point(18, 555);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddMark.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddMark.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddMark.selected = false;
            this.btnAddMark.Size = new System.Drawing.Size(91, 37);
            this.btnAddMark.TabIndex = 58;
            this.btnAddMark.Text = "   Add";
            this.btnAddMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMark.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnAddMark.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // frmMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1001, 599);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnModifyMark);
            this.Controls.Add(this.gbMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvProviderCompare);
            this.Controls.Add(this.dgvProviders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarks";
            this.Text = "frmMarks";
            this.Load += new System.EventHandler(this.frmMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.gbMark.ResumeLayout(false);
            this.gbMark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvProviderCompare;
        private System.Windows.Forms.DataGridViewComboBoxColumn Categories;
        private System.Windows.Forms.DataGridView dgvProviders;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox gbMark;
        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.TextBox txtSearchMark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteMark;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifyMark;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource markBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}