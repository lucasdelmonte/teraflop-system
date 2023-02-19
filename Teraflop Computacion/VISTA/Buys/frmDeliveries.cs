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
    public partial class frmDeliveries: Form
    {
        #region variables
        CONTROLADORA.Deliveries cDeliveries;
        CONTROLADORA.Buys cBuys;
        MODELO.Delivery oDelivery;
        MODELO.Buy oBuy;
        #endregion

        public frmDeliveries(MODELO.Buy miBuy)
        {
            InitializeComponent();
            cDeliveries = CONTROLADORA.Deliveries.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            oBuy = miBuy;
            Update_Datagrid();
        }

        #region methods
        private void Update_Datagrid()
        {
            try
            {
                dgvDeliveries.DataSource = null;
                dgvDeliveries.DataSource = oBuy.Delivery;

                if (oBuy.Delivery == null)
                {
                    frmErrorNotDeliveries formErrorNotDeliveries = new frmErrorNotDeliveries();
                    DialogResult result = formErrorNotDeliveries.ShowDialog();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmDetailDeliveries formDeliveries = new frmDetailDeliveries(new MODELO.Delivery(), MODELO.ACTION.ADD, oBuy);
                DialogResult result = formDeliveries.ShowDialog();
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
        private void btnConsult_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDeliveries.CurrentRow == null)
                {
                    DialogResult res = new DialogResult();
                    frmErrorSelectedGrid formErrorSelectedGrid = new frmErrorSelectedGrid();
                    res = formErrorSelectedGrid.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        return;
                    }
                }

                oDelivery = (MODELO.Delivery)dgvDeliveries.CurrentRow.DataBoundItem;
                frmDetailDeliveries formDeliveries = new frmDetailDeliveries(oDelivery, oBuy, MODELO.ACTION.CONSULT);
                DialogResult result = formDeliveries.ShowDialog();
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

        private void dgvDeliveries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDeliveries.Columns[e.ColumnIndex].Name == "dateDataGridViewTextBoxColumn")
            {
                if (e.Value.ToString().Contains("null"))
                {
                    //dgvDeliveries.Rows[e.RowIndex].Visible = false;
                }
            }
        }
    }
}
