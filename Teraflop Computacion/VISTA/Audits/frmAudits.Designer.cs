
namespace VISTA.Audits
{
    partial class frmAudits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.iconCompress = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.gbAudits = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUntil = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtDateUntil = new System.Windows.Forms.TextBox();
            this.lineDateUntil = new System.Windows.Forms.PictureBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.lineDateFrom = new System.Windows.Forms.PictureBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lineName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAudits = new System.Windows.Forms.DataGridView();
            this.btnConsult = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelected = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLoginLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbApplyFilterDates = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCompress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.gbAudits.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineDateUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnTopBar.Size = new System.Drawing.Size(1117, 33);
            this.pnTopBar.TabIndex = 101;
            this.pnTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseMove);
            // 
            // iconCompress
            // 
            this.iconCompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCompress.Image = ((System.Drawing.Image)(resources.GetObject("iconCompress.Image")));
            this.iconCompress.Location = new System.Drawing.Point(1060, 5);
            this.iconCompress.Name = "iconCompress";
            this.iconCompress.Size = new System.Drawing.Size(23, 23);
            this.iconCompress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCompress.TabIndex = 63;
            this.iconCompress.TabStop = false;
            this.iconCompress.Click += new System.EventHandler(this.iconCompress_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1088, 5);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(23, 23);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 62;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // gbAudits
            // 
            this.gbAudits.Controls.Add(this.groupBox2);
            this.gbAudits.Controls.Add(this.dgvAudits);
            this.gbAudits.Controls.Add(this.btnConsult);
            this.gbAudits.Controls.Add(this.dgvProduct);
            this.gbAudits.Controls.Add(this.dgvProducts);
            this.gbAudits.Controls.Add(this.dgvClients);
            this.gbAudits.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAudits.ForeColor = System.Drawing.Color.Black;
            this.gbAudits.Location = new System.Drawing.Point(192, 34);
            this.gbAudits.Name = "gbAudits";
            this.gbAudits.Size = new System.Drawing.Size(913, 538);
            this.gbAudits.TabIndex = 102;
            this.gbAudits.TabStop = false;
            this.gbAudits.Text = "Audits";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbApplyFilterDates);
            this.groupBox2.Controls.Add(this.lblUntil);
            this.groupBox2.Controls.Add(this.lblFrom);
            this.groupBox2.Controls.Add(this.txtDateUntil);
            this.groupBox2.Controls.Add(this.lineDateUntil);
            this.groupBox2.Controls.Add(this.txtDateFrom);
            this.groupBox2.Controls.Add(this.lineDateFrom);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.lineName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 106);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Font = new System.Drawing.Font("Alata", 12F);
            this.lblUntil.ForeColor = System.Drawing.Color.Black;
            this.lblUntil.Location = new System.Drawing.Point(700, 28);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(49, 27);
            this.lblUntil.TabIndex = 112;
            this.lblUntil.Text = "Until:";
            this.lblUntil.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Alata", 12F);
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(504, 28);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 27);
            this.lblFrom.TabIndex = 111;
            this.lblFrom.Text = "From:";
            this.lblFrom.Visible = false;
            // 
            // txtDateUntil
            // 
            this.txtDateUntil.BackColor = System.Drawing.Color.DarkGray;
            this.txtDateUntil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateUntil.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateUntil.ForeColor = System.Drawing.Color.Black;
            this.txtDateUntil.Location = new System.Drawing.Point(753, 28);
            this.txtDateUntil.Name = "txtDateUntil";
            this.txtDateUntil.Size = new System.Drawing.Size(132, 23);
            this.txtDateUntil.TabIndex = 109;
            this.txtDateUntil.Visible = false;
            // 
            // lineDateUntil
            // 
            this.lineDateUntil.Image = ((System.Drawing.Image)(resources.GetObject("lineDateUntil.Image")));
            this.lineDateUntil.Location = new System.Drawing.Point(749, 48);
            this.lineDateUntil.Name = "lineDateUntil";
            this.lineDateUntil.Size = new System.Drawing.Size(146, 10);
            this.lineDateUntil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineDateUntil.TabIndex = 110;
            this.lineDateUntil.TabStop = false;
            this.lineDateUntil.Visible = false;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.BackColor = System.Drawing.Color.DarkGray;
            this.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateFrom.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.ForeColor = System.Drawing.Color.Black;
            this.txtDateFrom.Location = new System.Drawing.Point(562, 28);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(132, 23);
            this.txtDateFrom.TabIndex = 107;
            this.txtDateFrom.Visible = false;
            // 
            // lineDateFrom
            // 
            this.lineDateFrom.Image = ((System.Drawing.Image)(resources.GetObject("lineDateFrom.Image")));
            this.lineDateFrom.Location = new System.Drawing.Point(558, 48);
            this.lineDateFrom.Name = "lineDateFrom";
            this.lineDateFrom.Size = new System.Drawing.Size(146, 10);
            this.lineDateFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineDateFrom.TabIndex = 108;
            this.lineDateFrom.TabStop = false;
            this.lineDateFrom.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Alata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(73, 28);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 23);
            this.txtCustomerName.TabIndex = 105;
            // 
            // lineName
            // 
            this.lineName.Image = ((System.Drawing.Image)(resources.GetObject("lineName.Image")));
            this.lineName.Location = new System.Drawing.Point(69, 48);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(146, 10);
            this.lineName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineName.TabIndex = 106;
            this.lineName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alata", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 102;
            // 
            // dgvAudits
            // 
            this.dgvAudits.AllowUserToAddRows = false;
            this.dgvAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAudits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAudits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvAudits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAudits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAudits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAudits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAudits.ColumnHeadersHeight = 40;
            this.dgvAudits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAudits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAudits.EnableHeadersVisualStyles = false;
            this.dgvAudits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvAudits.Location = new System.Drawing.Point(6, 139);
            this.dgvAudits.Name = "dgvAudits";
            this.dgvAudits.ReadOnly = true;
            this.dgvAudits.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.dgvAudits.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAudits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAudits.Size = new System.Drawing.Size(901, 354);
            this.dgvAudits.TabIndex = 122;
            // 
            // btnConsult
            // 
            this.btnConsult.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsult.BorderRadius = 0;
            this.btnConsult.ButtonText = "Consult";
            this.btnConsult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsult.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConsult.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsult.Iconimage = null;
            this.btnConsult.Iconimage_right = null;
            this.btnConsult.Iconimage_right_Selected = null;
            this.btnConsult.Iconimage_Selected = null;
            this.btnConsult.IconMarginLeft = 0;
            this.btnConsult.IconMarginRight = 0;
            this.btnConsult.IconRightVisible = true;
            this.btnConsult.IconRightZoom = 0D;
            this.btnConsult.IconVisible = true;
            this.btnConsult.IconZoom = 90D;
            this.btnConsult.IsTab = false;
            this.btnConsult.Location = new System.Drawing.Point(6, 501);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsult.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnConsult.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsult.selected = false;
            this.btnConsult.Size = new System.Drawing.Size(77, 29);
            this.btnConsult.TabIndex = 121;
            this.btnConsult.Text = "Consult";
            this.btnConsult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsult.Textcolor = System.Drawing.Color.White;
            this.btnConsult.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ColumnHeadersVisible = false;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Category,
            this.Amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.dgvProduct.Location = new System.Drawing.Point(25, 264);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(171)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(25)))));
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(615, 227);
            this.dgvProduct.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 54.98211F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 220;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 50F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(25, 200);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(294, 150);
            this.dgvProducts.TabIndex = 108;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(25, 108);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(309, 150);
            this.dgvClients.TabIndex = 109;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Crimson;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Back";
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
            this.btnCancel.Location = new System.Drawing.Point(986, 580);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Crimson;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(119, 29);
            this.btnCancel.TabIndex = 123;
            this.btnCancel.Text = "Back";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblSelected);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnLoginLogout);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 583);
            this.panel1.TabIndex = 124;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Alata", 12F);
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(3, 550);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(73, 27);
            this.lblSelected.TabIndex = 62;
            this.lblSelected.Text = "Selected";
            this.lblSelected.Visible = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Activecolor = System.Drawing.Color.Transparent;
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.BorderRadius = 0;
            this.btnCustomers.ButtonText = "Customers";
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Iconimage")));
            this.btnCustomers.Iconimage_right = null;
            this.btnCustomers.Iconimage_right_Selected = null;
            this.btnCustomers.Iconimage_Selected = null;
            this.btnCustomers.IconMarginLeft = 0;
            this.btnCustomers.IconMarginRight = 0;
            this.btnCustomers.IconRightVisible = true;
            this.btnCustomers.IconRightZoom = 0D;
            this.btnCustomers.IconVisible = true;
            this.btnCustomers.IconZoom = 80D;
            this.btnCustomers.IsTab = false;
            this.btnCustomers.Location = new System.Drawing.Point(7, 116);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCustomers.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCustomers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomers.selected = false;
            this.btnCustomers.Size = new System.Drawing.Size(172, 37);
            this.btnCustomers.TabIndex = 55;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnCustomers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Alata", 11F);
            this.lblName.ForeColor = System.Drawing.Color.Salmon;
            this.lblName.Location = new System.Drawing.Point(12, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 24);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Select option:";
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.Activecolor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoginLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginLogout.BorderRadius = 0;
            this.btnLoginLogout.ButtonText = "Login / Logout";
            this.btnLoginLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoginLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoginLogout.Iconimage")));
            this.btnLoginLogout.Iconimage_right = null;
            this.btnLoginLogout.Iconimage_right_Selected = null;
            this.btnLoginLogout.Iconimage_Selected = null;
            this.btnLoginLogout.IconMarginLeft = 0;
            this.btnLoginLogout.IconMarginRight = 0;
            this.btnLoginLogout.IconRightVisible = true;
            this.btnLoginLogout.IconRightZoom = 0D;
            this.btnLoginLogout.IconVisible = true;
            this.btnLoginLogout.IconZoom = 80D;
            this.btnLoginLogout.IsTab = false;
            this.btnLoginLogout.Location = new System.Drawing.Point(7, 59);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoginLogout.selected = false;
            this.btnLoginLogout.Size = new System.Drawing.Size(172, 37);
            this.btnLoginLogout.TabIndex = 45;
            this.btnLoginLogout.Text = "Login / Logout";
            this.btnLoginLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoginLogout.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.btnLoginLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // cbApplyFilterDates
            // 
            this.cbApplyFilterDates.AutoSize = true;
            this.cbApplyFilterDates.Location = new System.Drawing.Point(730, 70);
            this.cbApplyFilterDates.Name = "cbApplyFilterDates";
            this.cbApplyFilterDates.Size = new System.Drawing.Size(165, 28);
            this.cbApplyFilterDates.TabIndex = 113;
            this.cbApplyFilterDates.Text = "Apply filter by dates";
            this.cbApplyFilterDates.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alata", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 114;
            this.label2.Text = "Name:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alata", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(392, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 115;
            this.label3.Text = "Dates range:";
            this.label3.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 0;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = null;
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 90D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(11, 69);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(77, 29);
            this.btnFilter.TabIndex = 124;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmAudits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1117, 614);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbAudits);
            this.Controls.Add(this.pnTopBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAudits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audits";
            this.pnTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCompress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.gbAudits.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineDateUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.PictureBox iconCompress;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.GroupBox gbAudits;
        private System.Windows.Forms.DataGridView dgvAudits;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsult;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoginLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomers;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateUntil;
        private System.Windows.Forms.PictureBox lineDateUntil;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.PictureBox lineDateFrom;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.PictureBox lineName;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbApplyFilterDates;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
    }
}