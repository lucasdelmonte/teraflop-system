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

namespace VISTA.Products
{
    public partial class frmUpdateStock : Form
    {
        #region variables
        CONTROLADORA.Products cProducts;
        MODELO.Product oProduct;
        #endregion

        #region constructor
        public frmUpdateStock(MODELO.Product miProduct)
        {
            InitializeComponent();
            cProducts = CONTROLADORA.Products.Get_Instance();
            oProduct = miProduct;
            lblNameProduct.Text = oProduct.Name.ToString();
            lblStockProduct.Text = oProduct.Stock.ToString();
        }
        #endregion

        #region topBar
        int posY = 0;
        int posX = 0;
        private void plColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        #endregion

        #region buttons
        private void btnAccept_Click(object sender, EventArgs e)
        {
            int stockUpdated = 0;
            int stock;
            try
            {
                if (!int.TryParse(txtStock.Text, out stock))
                {
                    DialogResult result = new DialogResult();
                    frmErrorIncorrect formError = new frmErrorIncorrect();
                    result = formError.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtStock.Focus();
                        return;
                    }
                }
                if (rbAddStock.Checked)
                {
                    stockUpdated = oProduct.Stock + Int32.Parse(txtStock.Text);
                }
                else
                {
                    stockUpdated = oProduct.Stock - Int32.Parse(txtStock.Text);
                    if (stockUpdated < 0)
                    {
                        DialogResult result = new DialogResult();
                        frmErrorWrongStock formErrorWrongStock = new frmErrorWrongStock();
                        result = formErrorWrongStock.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
            
                oProduct.Stock = stockUpdated;
                cProducts.Modify_Product(oProduct);
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

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        private void rbAddStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddStock.Checked)
            {
                gbUpdateStock.Text = "Add stock";
            }
        }

        private void rbRemoveStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemoveStock.Checked)
            {
                gbUpdateStock.Text = "Remove stock";
            }
        }
    }
}
