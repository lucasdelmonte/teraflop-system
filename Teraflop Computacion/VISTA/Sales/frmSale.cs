using CONTROLADORA;
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
    public partial class frmSale : Form
    {
        #region variables
        CONTROLADORA.DetailSales cDetailSales;
        CONTROLADORA.Products cProducts;
        MODELO.Product oProduct;
        CONTROLADORA.Customers cCustomers;
        CONTROLADORA.Sales cSales;
        MODELO.Sale oSale;

        MODELO.ACTION ACTION;
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmSale(MODELO.Sale miSale, MODELO.ACTION miAccion)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cCustomers = CONTROLADORA.Customers.Get_Instance();
            cDetailSales = CONTROLADORA.DetailSales.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            oSale = miSale;
            ACTION = miAccion;
            rbCard.Enabled = true;
            rbCash.Enabled = true;
            Update_Combobox();
        }
        #endregion

        #region methods
        public void Update_Combobox() {
            cbProduct.DataSource = null;
            cbProduct.DataSource = cProducts.Get_Product();
            cbProduct.DisplayMember = "Name";

            cbCustomer.DataSource = null;
            cbCustomer.DataSource = cCustomers.Get_Customer();
            cbCustomer.DisplayMember = "Name " + "LastName";
        }
        public void Calculate_Total() {
            total = 0;

            foreach (DataGridViewRow Fila in dgvDetailSales.Rows)
            {
                total += Convert.ToDouble(Fila.Cells[3].Value);
                lblTotal.Text = "$ " + total.ToString();
            }
        }
        #endregion

        #region topBar
        int posY = 0;
        int posX = 0;
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
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

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region grid button
        private int contRow = 0;
        double total = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(txtAmount.Text, out amount))
            {
                DialogResult resultado = new DialogResult();
                frmErrorAmount formErrorAmount = new frmErrorAmount();
                resultado = formErrorAmount.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    txtAmount.Focus();
                    return;
                }
            }
            if (amount > Convert.ToInt32(txtStock.Text))
            {
                DialogResult resultado = new DialogResult();
                frmErrorAmount formErrorAmount = new frmErrorAmount();
                resultado = formErrorAmount.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    txtAmount.Focus();
                    return;
                }
            }

            bool exist = false;
            int numRow = 0;

            if (contRow == 0)
            {
                dgvDetailSales.Rows.Add(cbProduct.SelectedItem, txtPrice.Text, txtAmount.Text);
                double amountRow = Convert.ToDouble(dgvDetailSales.Rows[contRow].Cells[1].Value) * Convert.ToDouble(dgvDetailSales.Rows[contRow].Cells[2].Value);
                dgvDetailSales.Rows[contRow].Cells[3].Value = amountRow;
                contRow++;
                Calculate_Total();
                txtName.Text = cbProduct.SelectedItem.ToString();
            }
            else {
                foreach (DataGridViewRow Fila in dgvDetailSales.Rows) {
                    try
                    {
                        string nameInCell = Convert.ToString(Fila.Cells[0].Value);
                        MessageBox.Show(Fila.Cells[0].Value.ToString() + "       " + txtName.Text);
                        if (nameInCell == txtNameProduct.Text)
                        {
                            exist = true;
                            numRow = Fila.Index;
                        }
                    }
                    catch (Exception)
                    {
                        DialogResult resultado = new DialogResult();
                        frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                        resultado = formErrorUnexpected.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (exist == true)
                {
                    MessageBox.Show(exist.ToString());
                    dgvDetailSales.Rows[numRow].Cells[2].Value = Convert.ToDouble(txtAmount.Text);
                    double amountRow = Convert.ToDouble(dgvDetailSales.Rows[numRow].Cells[1].Value) * Convert.ToDouble(dgvDetailSales.Rows[numRow].Cells[2].Value);
                    dgvDetailSales.Rows[numRow].Cells[3].Value = amountRow;
                    Calculate_Total();
                }
                else {
                    dgvDetailSales.Rows.Add(cbProduct.SelectedItem, txtPrice.Text, txtAmount.Text);
                    double amountRow = Convert.ToDouble(dgvDetailSales.Rows[contRow].Cells[1].Value) * Convert.ToDouble(dgvDetailSales.Rows[contRow].Cells[2].Value);
                    dgvDetailSales.Rows[contRow].Cells[3].Value = amountRow;
                    contRow++;
                    Calculate_Total();
                }
            }

            rbCard.Enabled = false;
            rbCash.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (contRow > 0)
                {
                    if (dgvDetailSales.CurrentRow.Index != -1)
                    {
                        total -= (Convert.ToDouble(dgvDetailSales.Rows[dgvDetailSales.CurrentRow.Index].Cells[3].Value));
                        lblTotal.Text = "$ " + total.ToString();
                        dgvDetailSales.Rows.RemoveAt(dgvDetailSales.CurrentRow.Index);
                        contRow--;
                        Calculate_Total();
                    }
                    else
                    {
                        DialogResult resultado = new DialogResult();
                        frmErrorSelectedGrid formErrorSelectedGrid = new frmErrorSelectedGrid();
                        resultado = formErrorSelectedGrid.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            return;
                        }
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

        private void btnFinalizeSale_Click(object sender, EventArgs e)
        {
            if (contRow != 0)
            {
                List<MODELO.DetailSale> listDetailSales = new List<MODELO.DetailSale>();

                try
                {
                    foreach (DataGridViewRow Fila in dgvDetailSales.Rows)
                    {
                        MODELO.DetailSale oDetailSale = new MODELO.DetailSale();
                        oDetailSale.oProduct = (MODELO.Product)Fila.Cells[0].Value;
                        oDetailSale.Price = Convert.ToDecimal(Fila.Cells[1].Value);
                        oDetailSale.Amount = Convert.ToInt32(Fila.Cells[2].Value);
                        // Formatear total
                        decimal valor = Convert.ToDecimal(Fila.Cells[3].Value);
                        string dosDecimal = valor.ToString("0.##");
                        oDetailSale.Total = Convert.ToDecimal(dosDecimal);

                        // Empieza actualizar stock
                        int Cod_Product = oDetailSale.oProduct.Cod_Product;
                        dgvProduct.DataSource = ctxTeraflop.Get_Product_Stock(Cod_Product);
                        oProduct = (MODELO.Product)dgvProduct.CurrentRow.DataBoundItem;

                        foreach (var product in cbProduct.Items)
                        {
                            MODELO.Product oProductCompare = (MODELO.Product)product;
                            if (oProductCompare.Cod_Product == oProduct.Cod_Product) 
                            {
                                Int32 stock = Convert.ToInt32(oProduct.Stock);
                                Int32 newStock = Convert.ToInt32(Fila.Cells[2].Value);
                                oProductCompare.Stock = (int)(stock - newStock);

                                cProducts.Modify_Product(oProductCompare);
                            }
                        }
                        // Termina actualizar stock

                        listDetailSales.Add(oDetailSale);
                    }

                    oSale.DetailSale = listDetailSales;

                    var dateAndTime = DateTime.Now;
                    var date = dateAndTime.Date.ToString("dd-MM-yyyy");
                    oSale.Date = date;
                    oSale.Total = total;
                    oSale.oCustomer = (MODELO.Customer)cbCustomer.SelectedItem;

                    CONTROLADORA.ContextState oContextState = new CONTROLADORA.ContextState();
                    oContextState.State = new RequestedState();
                    oContextState.changeStateSale(oSale);

                    cSales.Add_Sale(oSale);

                    DialogResult result = new DialogResult();
                    frmSuccessfully formSuccessfully = new frmSuccessfully(oSale.State.ToString());
                    result = formSuccessfully.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
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
            else
            {
                DialogResult resultado = new DialogResult();
                frmErrorVoidGrid formErrorVoidGrid = new frmErrorVoidGrid();
                resultado = formErrorVoidGrid.ShowDialog();
                if (resultado == DialogResult.OK)
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

        #region checkedChanged
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count == 1)
            {
                decimal Price_Cash = (Convert.ToDecimal(dgvProducts.Rows[0].Cells[6].Value) * Convert.ToDecimal(1.60));
                txtPrice.Text = Price_Cash.ToString("N2");
            }
        }
        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count == 1)
            {
                decimal Price_Cash = (Convert.ToDecimal(dgvProducts.Rows[0].Cells[6].Value) * Convert.ToDecimal(1.60));
                decimal Price_Card = (Price_Cash * Convert.ToDecimal(1.10));

                txtPrice.Text = Price_Card.ToString("N2");
            }
        }
        #endregion

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            oProduct = (MODELO.Product)cbProduct.SelectedItem;

            if (oProduct.Stock == 0)
            {
                btnAdd.Enabled = false;
                return;
            }
            btnAdd.Enabled = true;
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = ctxTeraflop.Get_Product_ByBarCode(txtBarCode.Text);

                if (dgvProducts.Rows.Count == 0) 
                {
                    txtNameProduct.Text = "";
                    txtStock.Text = "";
                    txtModel.Text = "";
                    txtMark.Text = "";
                    txtCategory.Text = "";
                    txtName.Text = "";
                    txtCode.Text = "";
                    txtPrice.Text = "";
                    return;
                }
            
                txtCode.Text = dgvProducts.Rows[0].Cells[0].Value.ToString();
                txtNameProduct.Text = dgvProducts.Rows[0].Cells[1].Value.ToString();
                txtStock.Text = dgvProducts.Rows[0].Cells[2].Value.ToString();
                if ((int)dgvProducts.Rows[0].Cells[2].Value == 0)
                {
                    btnAdd.Enabled = false;
                    return;
                }
                txtModel.Text = dgvProducts.Rows[0].Cells[3].Value.ToString();
                txtMark.Text = dgvProducts.Rows[0].Cells[4].Value.ToString();
                txtCategory.Text = dgvProducts.Rows[0].Cells[5].Value.ToString();
                if (rbCash.Checked == true)
                {
                    decimal Price_Cash = (Convert.ToDecimal(dgvProducts.Rows[0].Cells[6].Value) * Convert.ToDecimal(1.60));
                    txtPrice.Text = Price_Cash.ToString("N2");
                }
                else
                {
                    decimal Price_Cash = (Convert.ToDecimal(dgvProducts.Rows[0].Cells[6].Value) * Convert.ToDecimal(1.60));
                    decimal Price_Card = (Price_Cash * Convert.ToDecimal(1.10));

                    txtPrice.Text = Price_Card.ToString("N2");
                }
                btnAdd.Enabled = true;

                foreach (MODELO.Product oProduct in cbProduct.Items)
                {
                    if(oProduct.Cod_Product.ToString() == txtCode.Text)
                    {
                        cbProduct.SelectedItem = oProduct;
                    }
                }
            }
            catch (Exception)
            {
                DialogResult resultado = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                resultado = formErrorUnexpected.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int stock;
                if (!int.TryParse(txtSearchClient.Text, out stock))
                {
                    return;
                }
                int codTest = Convert.ToInt32(txtSearchClient.Text);
                dgvClients.DataSource = ctxTeraflop.Get_Client_ByCode(codTest);

                if (dgvClients.Rows.Count == 0)
                {
                    txtFullName.Text = "";
                    btnFinalizeDelivery.Enabled = false;
                    return;
                }
                btnFinalizeDelivery.Enabled = true;

                txtFullName.Text = dgvClients.Rows[0].Cells[1].Value.ToString() + " " + dgvClients.Rows[0].Cells[2].Value.ToString(); 

                foreach (MODELO.Customer oCustomer in cbCustomer.Items)
                {
                    if (oCustomer.Cod_Customer.ToString() == txtSearchClient.Text)
                    {
                        cbCustomer.SelectedItem = oCustomer;
                    }
                }
            }
            catch (Exception)
            {
                DialogResult resultado = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                resultado = formErrorUnexpected.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            if (txtFullName.Text == "")
            {
                btnFinalizeDelivery.Enabled = false;
                return;
            }
            btnFinalizeDelivery.Enabled = true;
        }
    }
}
