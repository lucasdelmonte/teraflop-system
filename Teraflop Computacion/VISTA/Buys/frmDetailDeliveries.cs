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
    public partial class frmDetailDeliveries : Form
    {
        #region variables
        CONTROLADORA.DetailDeliveries cDetailDeliveries;
        CONTROLADORA.Products cProducts;
        CONTROLADORA.Buys cBuys;
        CONTROLADORA.Deliveries cDeliveries;
        MODELO.Product oProduct;
        MODELO.Delivery oDelivery;
        MODELO.Buy oBuy;


        MODELO.ACTION ACTION;
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmDetailDeliveries(MODELO.Delivery miDelivery, MODELO.ACTION miAccion, MODELO.Buy miBuy)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cDetailDeliveries = CONTROLADORA.DetailDeliveries.Get_Instance();
            cDeliveries = CONTROLADORA.Deliveries.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            oDelivery = miDelivery;
            ACTION = miAccion;
            oBuy = miBuy;
            dgvDetailDeliveryConsult.Visible = false;
            Update_Datagrid();
            Update_Combobox();
        }
        public frmDetailDeliveries(MODELO.Delivery miDelivery, MODELO.Buy miBuy, MODELO.ACTION miAction)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cDetailDeliveries = CONTROLADORA.DetailDeliveries.Get_Instance();
            cDeliveries = CONTROLADORA.Deliveries.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            oBuy = miBuy;
            oDelivery = miDelivery;
            ACTION = miAction;
            Update_DatagridConsult();
            if(ACTION == MODELO.ACTION.CONSULT)
            {
                gbDeliveryDetail.Width = 1034;
                dgvDetailDeliveryConsult.Height = 411;
                gbDeliveryDetail.Location = new Point(12, 36);
                gbDeliveryData.Visible = false;
                btnFinalizeDelivery.Visible = false;

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

        #region methods
        private void Update_Datagrid()
        {
            try
            {
                if (oBuy.DetailBuy != null)
                {
                    foreach (var detail in oBuy.DetailBuy)
                    {
                        dgvDetailDeliveries.Rows.Add(detail.oProduct.Barcode, detail.oProduct.Name, detail.Amount, 0, detail.Cod_DetailBuy);
                    }
                }
                else
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
        private void Update_DatagridConsult()
        {
            try
            {
                if (oDelivery.DetailDelivery != null)
                {
                    foreach (var detail in oDelivery.DetailDelivery)
                    {
                        foreach (var detailBuy in oBuy.DetailBuy)
                        {
                            if(detailBuy.oProduct.Barcode == detail.oProduct.Barcode)
                                if(detailBuy.Amount == detailBuy.Received)
                                    dgvDetailDeliveryConsult.Rows.Add(detail.oProduct.Name, detailBuy.Amount, detail.Amount, detailBuy.Received, "COMPLETED");
                                else
                                    dgvDetailDeliveryConsult.Rows.Add(detail.oProduct.Name, detailBuy.Amount, detail.Amount, detailBuy.Received, "PENDING");
                        }
                    }
                }
                else
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
        public void Update_Combobox()
        {
            cbProduct.DataSource = null;
            cbProduct.DataSource = cProducts.Get_Product();
            cbProduct.DisplayMember = "Name";
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
                    txtPrice.Text = "";
                    btnAdd.Enabled = false;
                    return;
                }
                btnAdd.Enabled = true;
                txtNameProduct.Text = dgvProducts.Rows[0].Cells[1].Value.ToString();
                txtStock.Text = dgvProducts.Rows[0].Cells[2].Value.ToString();
                txtModel.Text = dgvProducts.Rows[0].Cells[3].Value.ToString();
                txtMark.Text = dgvProducts.Rows[0].Cells[4].Value.ToString();
                txtCategory.Text = dgvProducts.Rows[0].Cells[5].Value.ToString();

                decimal Price_Cash = (Convert.ToDecimal(dgvProducts.Rows[0].Cells[6].Value) * Convert.ToDecimal(1.60));
                txtPrice.Text = Price_Cash.ToString("N2");
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

            foreach (DataGridViewRow Fila in dgvDetailDeliveries.Rows)
            {
                try
                {
                    string nameInCell = Convert.ToString(Fila.Cells[1].Value);
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
            if (amount > Convert.ToInt32(dgvDetailDeliveries.Rows[numRow].Cells[2].Value) || amount <= 0)
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
            if (exist == true)
            {
                /* Examples
                 485948
                 159483
                 927384
                */
                if((int)dgvDetailDeliveries.Rows[numRow].Cells[2].Value >= amount)
                {
                    dgvDetailDeliveries.Rows[numRow].Cells[3].Value = amount;
                } else
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
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        int Cod_Product;
        private void btnFinalizeDelivery_Click(object sender, EventArgs e)
        {
            List<MODELO.DetailDelivery> listDetailDeliveries = new List<MODELO.DetailDelivery>();

            try
            {
                foreach (DataGridViewRow Fila in dgvDetailDeliveries.Rows)
                {
                    MODELO.DetailDelivery oDetailDelivery = new MODELO.DetailDelivery();

                    foreach (MODELO.Product oProduct in cbProduct.Items)
                    {
                        if (oProduct.Barcode == Fila.Cells[0].Value)
                        {
                            cbProduct.SelectedItem = oProduct;
                            Cod_Product = oProduct.Cod_Product;
                        }
                    }
                    foreach (MODELO.DetailBuy oDetailBuy in oBuy.DetailBuy)
                    {
                        if ((int)oDetailBuy.Cod_DetailBuy == (int)Fila.Cells[4].Value)
                        {
                            int oldReceived = Convert.ToInt32(oDetailBuy.Received);
                            int newReceived = Convert.ToInt32(Fila.Cells[3].Value); 
                            int amountRequest = Convert.ToInt32(Fila.Cells[2].Value);

                            int amount = oldReceived + newReceived;
                            if (amount > amountRequest)
                            {
                                DialogResult result = new DialogResult();
                                frmErrorDeliveryAmount formErrorDeliveryAmount = new frmErrorDeliveryAmount();
                                result = formErrorDeliveryAmount.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    return;
                                }
                            }
                            oDetailBuy.Received = amount;
                        }
                        
                    }
                    // Empieza actualizar stock
                    dgvProduct.DataSource = ctxTeraflop.Get_Product_Stock(Cod_Product);
                    oProduct = (MODELO.Product)dgvProduct.CurrentRow.DataBoundItem;
                    
                    foreach (var product in cbProduct.Items)
                    {
                        MODELO.Product oProductCompare = (MODELO.Product)product;
                        if (oProductCompare.Cod_Product == oProduct.Cod_Product)
                        {
                            Int32 stock = Convert.ToInt32(oProduct.Stock);
                            Int32 newStock = Convert.ToInt32(Fila.Cells[3].Value);
                            oProductCompare.Stock = (int)(stock + newStock);

                            cProducts.Modify_Product(oProductCompare);
                        }
                    }
                    // Termina actualizar stock
                    oDetailDelivery.oProduct = (MODELO.Product)cbProduct.SelectedItem;
                    oDetailDelivery.Amount = Convert.ToInt32(Fila.Cells[3].Value);
                    cDetailDeliveries.Add_DetailDelivery(oDetailDelivery);
                    listDetailDeliveries.Add(oDetailDelivery); 
                }
                oDelivery.DetailDelivery = listDetailDeliveries;
                var dateAndTime = DateTime.Now;
                var date = dateAndTime.Date.ToString("dd-MM-yyyy");
                oDelivery.Date = date;

                cDeliveries.Add_Delivery(oDelivery);

                oBuy.Delivery.Add(oDelivery);

                cBuys.Modify_Buy(oBuy);

                this.DialogResult = DialogResult.OK;
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
    }
}
