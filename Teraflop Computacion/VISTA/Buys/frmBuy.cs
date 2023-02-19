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

namespace VISTA.Buys
{
    public partial class frmBuy : Form
    {
        #region variables
        CONTROLADORA.DetailBuys cDetailBuys;
        CONTROLADORA.Products cProducts;
        MODELO.Product oProduct;
        CONTROLADORA.Providers cProviders;
        CONTROLADORA.Buys cBuys;
        MODELO.Buy oBuy;

        MODELO.ACTION ACTION;
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmBuy(MODELO.Buy miBuy, MODELO.ACTION miAccion)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            cDetailBuys = CONTROLADORA.DetailBuys.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            oBuy = miBuy;
            ACTION = miAccion;
            Update_Combobox();
        }
        #endregion

        #region methods
        public void Update_Combobox()
        {
            cbProduct.DataSource = null;
            cbProduct.DataSource = cProducts.Get_Product();
            cbProduct.DisplayMember = "Name";

            cbProvider.DataSource = null;
            cbProvider.DataSource = cProviders.Get_Provider();
            cbProvider.DisplayMember = "Name";

            cbProduct.SelectedIndex = 0;
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvider.SelectedIndex = 0;
            cbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            oProduct = (MODELO.Product)cbProduct.SelectedItem;
            txtName.Text = oProduct.Name.ToString();
            txtCategory.Text = oProduct.oCategory.NameCategory.ToString();
            txtMark.Text = oProduct.oMark.NameMark.ToString();
            txtModel.Text = oProduct.oModel.NameModel.ToString();
            txtStock.Text = oProduct.Stock.ToString();
            btnAdd.Enabled = true;
        }

        #region grid button
        private int contRow = 0;

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

            bool exist = false;
            int numRow = 0;

            if (contRow == 0)
            {
                dgvDetailBuys.Rows.Add(cbProduct.SelectedItem, txtCategory.Text, txtAmount.Text);
                contRow++;
            }
            else
            {
                foreach (DataGridViewRow Fila in dgvDetailBuys.Rows)
                {
                    try
                    {
                        string nameInCell = Convert.ToString(Fila.Cells[0].Value);
                        if (nameInCell == txtName.Text)
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
                    dgvDetailBuys.Rows[numRow].Cells[2].Value = Convert.ToDouble(txtAmount.Text);
                }
                else
                {
                    dgvDetailBuys.Rows.Add(cbProduct.SelectedItem, txtCategory.Text, txtAmount.Text);
                    contRow++;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (contRow > 0)
                {
                    if (dgvDetailBuys.CurrentRow.Index != -1)
                    {
                        dgvDetailBuys.Rows.RemoveAt(dgvDetailBuys.CurrentRow.Index);
                        contRow--;
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
                List<MODELO.DetailBuy> listDetailBuys = new List<MODELO.DetailBuy>();

                try
                {
                    foreach (DataGridViewRow Fila in dgvDetailBuys.Rows)
                    {
                        MODELO.DetailBuy oDetailBuy = new MODELO.DetailBuy();
                        oDetailBuy.oProduct = (MODELO.Product)Fila.Cells[0].Value;
                        oDetailBuy.Amount = Convert.ToInt32(Fila.Cells[2].Value);

                        listDetailBuys.Add(oDetailBuy);
                    }
                    List<MODELO.Delivery> listDeliveries = new List<MODELO.Delivery>(); // contiene a delivery

                    List<MODELO.DetailDelivery> listDetailDeliveries = new List<MODELO.DetailDelivery>(); // contiene los detalles de delivery

                    MODELO.Delivery oDelivery = new MODELO.Delivery();

                    MODELO.DetailDelivery oDetailDelivery = new MODELO.DetailDelivery();

                    oDetailDelivery.Cod_DetailDelivery = 0;
                    oDetailDelivery.Amount = 0;
                    var cont = 0;
                    foreach (DataGridViewRow Fila in dgvDetailBuys.Rows)
                    {
                        if (cont == 0)
                        {
                            oDetailDelivery.oProduct = (MODELO.Product)Fila.Cells[0].Value;
                        }
                        cont++;
                    }
                    listDetailDeliveries.Add(oDetailDelivery);
                    oDelivery.Cod_Delivery = 0;
                    oDelivery.Date = "null";
                    oDelivery.DetailDelivery = listDetailDeliveries;

                    listDeliveries.Add(oDelivery);

                    oBuy.DetailBuy = listDetailBuys;
                    oBuy.Delivery = listDeliveries;

                    var dateAndTime = DateTime.Now;
                    var date = dateAndTime.Date.ToString("dd-MM-yyyy");
                    oBuy.Date = date;
                    oBuy.oProvider = (MODELO.Provider)cbProvider.SelectedItem;

                    CONTROLADORA.ContextState oContextState = new CONTROLADORA.ContextState();
                    oContextState.State = new RequestedState();
                    oContextState.changeStateBuy(oBuy);

                    cBuys.Add_Buy(oBuy);

                    DialogResult result = new DialogResult();
                    frmSuccessfully formSuccessfully = new frmSuccessfully(oBuy.State.ToString());
                    result = formSuccessfully.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
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
                    btnAdd.Enabled = false;
                    return;
                }
                btnAdd.Enabled = true;

                txtCode.Text = dgvProducts.Rows[0].Cells[0].Value.ToString();
                txtNameProduct.Text = dgvProducts.Rows[0].Cells[1].Value.ToString();
                txtStock.Text = dgvProducts.Rows[0].Cells[2].Value.ToString();
                txtModel.Text = dgvProducts.Rows[0].Cells[3].Value.ToString();
                txtMark.Text = dgvProducts.Rows[0].Cells[4].Value.ToString();
                txtCategory.Text = dgvProducts.Rows[0].Cells[5].Value.ToString();

                foreach (MODELO.Product oProduct in cbProduct.Items)
                {
                    if (oProduct.Cod_Product.ToString() == txtCode.Text)
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

        private void frmBuy_Load(object sender, EventArgs e)
        {
            txtNameProduct.Text = "";
            txtStock.Text = "";
            txtModel.Text = "";
            txtMark.Text = "";
            txtCategory.Text = "";
            txtName.Text = "";
            txtCode.Text = "";
            btnAdd.Enabled = false;
        }
    }
}
