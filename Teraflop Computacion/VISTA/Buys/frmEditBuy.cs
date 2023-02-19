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
    public partial class frmEditBuy : Form
    {
        #region variables
        CONTROLADORA.Buys cBuys;
        CONTROLADORA.Products cProducts;
        CONTROLADORA.Providers cProviders;
        CONTROLADORA.Deliveries cDeliveries;
        MODELO.Buy oBuy;

        MODELO.ACTION ACTION;

        bool recivedCompleted = true;
        bool requested = true;
        #endregion

        #region constructor
        public frmEditBuy(MODELO.Buy miBuy, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            cDeliveries = CONTROLADORA.Deliveries.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            oBuy = miBuy;
            ACTION = miACTION;
            Update_Datagrid();

            if (ACTION != MODELO.ACTION.ADD)
            {
                try
                {
                    txtNumber.Text = oBuy.Cod_Buy.ToString();
                    txtDate.Text = oBuy.Date;

                    txtName.Text = oBuy.oProvider.Name;
                    txtDirection.Text = oBuy.oProvider.Direction;
                    txtTelephone.Text = oBuy.oProvider.Telephone;
                    txtWebsite.Text = oBuy.oProvider.Website;
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
            Update_State();
        }
        #endregion

        #region methods
        private void Update_State() 
        {
            CONTROLADORA.ContextState oContextState = new CONTROLADORA.ContextState();

            if (recivedCompleted == true && requested == false)
            {
                oContextState.State = new FinishedState();
            }
            else if (recivedCompleted == false && requested == false)
            {
                oContextState.State = new InProgressState();
            }
            else
            {
                oContextState.State = new RequestedState();
            }
            oContextState.changeStateBuy(oBuy);
            cBuys.Modify_Buy(oBuy);
            txtState.Text = oBuy.State.ToString();
        }
        private void Update_Datagrid()
        {
            try
            {
                dgvDeliveries.DataSource = null;
                dgvDeliveries.DataSource = cDeliveries.Get_Delivery();

                if (oBuy.DetailBuy != null)
                {
                    foreach (var detail in oBuy.DetailBuy)
                    {
                        dgvDetailBuys.Rows.Add(detail.oProduct.Name, detail.Amount, detail.Received);
                        if (detail.Amount != detail.Received)
                            recivedCompleted = false;

                        if (detail.Received != 0)
                            requested = false;
                    }
                } else
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
                DialogResult result = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                result = formErrorUnexpected.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }
        private void setStates(string miBuyState)
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.STATE)))
            {
                string role = Convert.ToString((MODELO.STATE)i);
                cbBuyStatus.Items.Add(role);
            }
            cbBuyStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (miBuyState)
            {
                case "REQUESTED":
                    cbBuyStatus.SelectedIndex = 0;
                    break;
                case "IN_PROCESS":
                    cbBuyStatus.SelectedIndex = 1;
                    break;
                case "FINISHED":
                    cbBuyStatus.SelectedIndex = 2;
                    break;
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

        #region button
        private void btnCheckDeliveries_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                frmDeliveries formDelivery = new frmDeliveries(oBuy);
                result = formDelivery.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrid();
                    return;
                }
            }
            catch (Exception) 
            { 
                DialogResult result = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                result = formErrorUnexpected.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrid();
                    return;
                }
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            return;
            if (oBuy.State != cbBuyStatus.SelectedItem.ToString())
            {
                oBuy.State = cbBuyStatus.SelectedItem.ToString();
                cBuys.Modify_Buy(oBuy);
            }
        }
        #endregion
    }
}
