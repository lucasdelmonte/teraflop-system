using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.Products;
using VISTA.Notifications;

namespace VISTA.Products
{
    public partial class frmProducts : Form
    {
        #region instance 
        public static frmProducts instance;
        public static frmProducts Get_Instance()
        {
            if (instance == null)
                instance = new frmProducts();
            if (instance.IsDisposed)
                instance = new frmProducts();

            return instance;
        }
        #endregion

        #region variables
        private CONTROLADORA.Products cProducts;
        private MODELO.Product oProduct;
        private CONTROLADORA.Sales cSales;
        private MODELO.Sale oSale;
        private CONTROLADORA.DetailSales cDetailSales;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.User User;
        #endregion

        #region constructor
        public frmProducts(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            cDetailSales = CONTROLADORA.DetailSales.Get_Instance();
            Update_Datagrid();
            User = miUser;
        }

        public frmProducts()
        {
        }
        #endregion

        #region methods
        private void Validate_Role()
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.ROLE)))
            {
                string role = Convert.ToString((MODELO.ROLE)i);
                if (role == User.Role && User.Role == "EMPLOYEE")
                {
                    //btnDelete.Visible = false;
                    btnModify.Visible = false;
                    btnDelete.Location = new Point(162, 555);
                    return;
                }
            }
            //btnDelete.Visible = true;
            btnModify.Visible = true;
        }

        private void Update_Datagrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();

            dgvSales.DataSource = null;
            dgvSales.DataSource = cSales.Get_Sale();

            dgvDetailSale.DataSource = null;
            dgvDetailSale.DataSource = cDetailSales.Get_DetailSale();
        }
        #endregion

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmProduct formProduct = new frmProduct(new MODELO.Product(), MODELO.ACTION.ADD);
                DialogResult result = formProduct.ShowDialog();
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
            if (dgvProducts.CurrentRow == null)
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
                oProduct = (MODELO.Product)dgvProducts.CurrentRow.DataBoundItem;
                frmProduct formProduct = new frmProduct(oProduct, MODELO.ACTION.MODIFY);
                DialogResult result = formProduct.ShowDialog();
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
            if (dgvProducts.CurrentRow == null)
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
                foreach (DataGridViewRow Fila in dgvSales.Rows)
                {
                    oProduct = (MODELO.Product)dgvProducts.CurrentRow.DataBoundItem;
                    oSale = (MODELO.Sale)Fila.DataBoundItem;

                    foreach (var DetailSale in oSale.DetailSale)
                    {
                        if (oProduct == DetailSale.oProduct)
                        {
                            DialogResult res = new DialogResult();
                            frmErrorDeletedCategory formErrorDeletedCategory = new frmErrorDeletedCategory();
                            res = formErrorDeletedCategory.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                return;
                            }
                        }
                    }
                }
                if (dgvProducts.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmProduct formDeleteConfirmProduct = new frmDeleteConfirmProduct();
                    result = formDeleteConfirmProduct.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cProducts.Delete_Product(oProduct);
                        Update_Datagrid();
                    }
                }
                else
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

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
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
                oProduct = (MODELO.Product)dgvProducts.CurrentRow.DataBoundItem;
                frmUpdateStock formUpdateStock = new frmUpdateStock(oProduct);
                DialogResult result = formUpdateStock.ShowDialog();
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
                throw;
            }
        }
        #endregion

        private void frmProducts_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "stockDataGridViewTextBoxColumn")
            {
                int value = (int)e.Value;
                if (value == 0)
                { 
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#ff8888");
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (value > 0 && value <= 5)
                { 
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#eeff83");
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (value > 5)
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#9fff88");
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
