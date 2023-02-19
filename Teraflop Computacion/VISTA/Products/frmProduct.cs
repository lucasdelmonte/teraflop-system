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
    public partial class frmProduct : Form
    {
        #region variables
        CONTROLADORA.Products cProducts;
        MODELO.Product oProduct;

        CONTROLADORA.Marks cMarks;
        CONTROLADORA.Models cModels;
        CONTROLADORA.Categories cCategories;

        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmProduct(MODELO.Product miProduct, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cMarks = CONTROLADORA.Marks.Get_Instance();
            cModels = CONTROLADORA.Models.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            Update_Combobox();
            oProduct = miProduct;
            ACTION = miACTION;

            if (ACTION != MODELO.ACTION.ADD)
            {
                try
                {
                    txtBarcode.Text = oProduct.Barcode;
                    txtName.Text = oProduct.Name;
                    txtStock.Text = oProduct.Stock.ToString();
                    cbMark.SelectedItem = oProduct.oMark;
                    cbModel.SelectedItem = oProduct.oModel;
                    cbCategory.SelectedItem = oProduct.oCategory;
                    txtPurchasePrice.Text = oProduct.Purchase_Price.ToString();

                    // Formatear precios
                    decimal valueCashPrice = Convert.ToDecimal(oProduct.Price_Cash);
                    string valueCashPriceFormatedd = valueCashPrice.ToString("0.##");
                    decimal valueCardPrice = Convert.ToDecimal(oProduct.Price_Card);
                    string valueCardPriceFormatedd = valueCardPrice.ToString("0.##");
                    txtCashPrice.Text = "$ " + valueCashPriceFormatedd;
                    txtCardPrice.Text = "$ " + valueCardPriceFormatedd;
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
        }
        #endregion

        #region method
        public void Update_Combobox()
        {
            cbMark.DataSource = null;
            cbMark.DataSource = cMarks.Get_Mark();
            cbMark.DisplayMember = "NameMark";

            cbModel.DataSource = null;
            cbModel.DataSource = cModels.Get_Model();
            cbModel.DisplayMember = "NameModel";

            cbCategory.DataSource = null;
            cbCategory.DataSource = cCategories.Get_Category();
            cbCategory.DisplayMember = "NameCategory";

            cbCategory.SelectedIndex = 0;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMark.SelectedIndex = 0;
            cbMark.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.SelectedIndex = 0;
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region buttons
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtBarcode.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtName.Focus();
                    return;
                }
            }
            int stock;
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
            if (cbMark.SelectedItem == null)
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbMark.Focus();
                    return;
                }
            }
            if (cbModel.SelectedItem == null)
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbModel.Focus();
                    return;
                }
            }
            if (cbCategory.SelectedItem == null)
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbCategory.Focus();
                    return;
                }
            }
            decimal price;
            if (!decimal.TryParse(txtPurchasePrice.Text, out price))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPurchasePrice.Focus();
                    return;
                }
            }

            try
            {
                oProduct.Barcode = txtBarcode.Text;
                oProduct.Name = txtName.Text;
                oProduct.Stock = stock;
                oProduct.oMark = (MODELO.Mark)cbMark.SelectedItem;
                oProduct.oModel = (MODELO.Model)cbModel.SelectedItem;
                oProduct.oCategory = (MODELO.Category)cbCategory.SelectedItem;
                oProduct.Purchase_Price = price;

                if (ACTION == MODELO.ACTION.ADD)
                    cProducts.Add_Product(oProduct);
                else
                    cProducts.Modify_Product(oProduct);

                this.DialogResult = DialogResult.OK;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region topBar
        int posY = 0;
        int posX = 0;
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            //Esto sirve para que se pueda mover el formulario desde el panel superior
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

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
