using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.Notifications;

namespace VISTA.Sales
{
    public partial class frmSales : Form
    {
        #region instance 
        public static frmSales instance;
        public static frmSales Get_Instance()
        {
            if (instance == null)
                instance = new frmSales();
            if (instance.IsDisposed)
                instance = new frmSales();

            return instance;
        }
        #endregion

        #region variables
        CONTROLADORA.Sales cSales;
        MODELO.Sale oSale;
        MODELO.User User;
        CONTROLADORA.Products cProducts;
        
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmSales(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            Update_DatagridProduct();
            Update_Datagrid();
            User = miUser;
            lblCodeSale.Text = Convert.ToString(dgvSales.Rows[0].Cells[0].Value);
        }

        public frmSales()
        {
        }
        #endregion

        #region methods
        private void Update_DatagridProduct()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();
        }
        public void Update_Datagrid() {
            dgvSales.DataSource = null;
            dgvSales.DataSource = cSales.Get_Sale();
        }
        private void Validate_Role()
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.ROLE)))
            {
                string role = Convert.ToString((MODELO.ROLE)i);
                if (role == User.Role && User.Role == "EMPLOYEE")
                {
                    btnDelete.Visible = false;
                    return;
                }
            }
        }
        #endregion

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmSale formSale = new frmSale(new MODELO.Sale(), MODELO.ACTION.ADD);
                DialogResult result = formSale.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrid();
                }
            }
            catch (Exception)
            {
                DialogResult result = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                result = formErrorUnexpected.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvSales.CurrentRow == null)
            {
                DialogResult result = new DialogResult();
                frmErrorSelectedGrid formErrorSelectedGrid = new frmErrorSelectedGrid();
                result = formErrorSelectedGrid.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                int Cod_Sale = Convert.ToInt32(lblCodeSale.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Sale(Cod_Sale);
                oSale = (MODELO.Sale)dgvSales.CurrentRow.DataBoundItem;

                frmEditSale formEditSale = new frmEditSale(oSale, MODELO.ACTION.MODIFY);
                DialogResult result = formEditSale.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrid();
                }
            }
            catch (Exception)
            {
                DialogResult result = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                result = formErrorUnexpected.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSales.CurrentRow == null)
            {
                DialogResult result = new DialogResult();
                frmErrorSelectedGrid formErrorSelectedGrid = new frmErrorSelectedGrid();
                result = formErrorSelectedGrid.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            try
            {
                int Cod_Sale = Convert.ToInt32(lblCodeSale.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Sale(Cod_Sale);
                oSale = (MODELO.Sale)dgvSales.CurrentRow.DataBoundItem;

                if (dgvSales.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmSale formDeleteConfirmSale = new frmDeleteConfirmSale();
                    result = formDeleteConfirmSale.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cSales.Delete_Sale(oSale);
                        Update_Datagrid();
                    }
                } else
                {
                    DialogResult result = new DialogResult();
                    frmErrorDgvVoid formErrorDgvVoid = new frmErrorDgvVoid();
                    result = formErrorDgvVoid.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }

            }
            catch (Exception)
            {
                DialogResult result = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                result = formErrorUnexpected.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }
        #endregion

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;

            if (numRow != -1)
            {
                lblCodeSale.Text = Convert.ToString(dgvSales.Rows[numRow].Cells[0].Value);
            }
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }

        private void dgvSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSales.Columns[e.ColumnIndex].Name == "State") 
            {
                if (e.Value.ToString().Contains("REQUESTED"))  
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#d3d3d3");
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (e.Value.ToString().Contains("IN_PROCESS"))
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#88d7ff");
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (e.Value.ToString().Contains("FINISHED"))
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#9fff88");
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
