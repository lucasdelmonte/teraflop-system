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
    public partial class frmBuys : Form
    {
        #region instance 
        public static frmBuys instance;
        public static frmBuys Get_Instance()
        {
            if (instance == null)
                instance = new frmBuys();
            if (instance.IsDisposed)
                instance = new frmBuys();

            return instance;
        }
        #endregion

        #region variables
        CONTROLADORA.Buys cBuys;
        MODELO.Buy oBuy;
        MODELO.User User;
        CONTROLADORA.Products cProducts;
        CONTROLADORA.Providers cProviders;
        CONTROLADORA.Deliveries cDeliveries;
        CONTROLADORA.DetailDeliveries cDetailDeliveries;
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        //849324
        //758345

        #region constructor
        public frmBuys(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            cBuys = CONTROLADORA.Buys.Get_Instance();
            cDeliveries = CONTROLADORA.Deliveries.Get_Instance();
            cDetailDeliveries = CONTROLADORA.DetailDeliveries.Get_Instance();
            Update_DatagridProduct();
            Update_Datagrid();
            lblCodeBuy.Text = Convert.ToString(dgvBuys.Rows[0].Cells[0].Value);
            User = miUser;
        }

        public frmBuys()
        {
        }
        #endregion

        #region methods
        private void Update_DatagridProduct()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();

            dgvProviders.DataSource = null;
            dgvProviders.DataSource = cProviders.Get_Provider();

            dgvDeliveries.DataSource = null;
            dgvDeliveries.DataSource = cDeliveries.Get_Delivery();

            dgvDetailDeliveries.DataSource = null;
            dgvDetailDeliveries.DataSource = cDetailDeliveries.Get_DetailDelivery();
        }
        public void Update_Datagrid()
        {
            dgvBuys.DataSource = null;
            dgvBuys.DataSource = cBuys.Get_Buy();
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
                frmBuy formBuy = new frmBuy(new MODELO.Buy(), MODELO.ACTION.ADD);
                DialogResult result = formBuy.ShowDialog();
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
            if (dgvBuys.CurrentRow == null)
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
                int Cod_Buy = Convert.ToInt32(lblCodeBuy.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Buy(Cod_Buy);
                oBuy = (MODELO.Buy)dgvBuys.CurrentRow.DataBoundItem;
                frmEditBuy formEditBuy = new frmEditBuy(oBuy, MODELO.ACTION.MODIFY);
                DialogResult result = formEditBuy.ShowDialog();
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
            if (dgvBuys.CurrentRow == null)
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
                int Cod_Buy = Convert.ToInt32(lblCodeBuy.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Buy(Cod_Buy);
                oBuy = (MODELO.Buy)dgvBuys.CurrentRow.DataBoundItem;
                if (dgvBuys.Rows.Count >= 3)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmBuy formDeleteConfirmBuy = new frmDeleteConfirmBuy();
                    result = formDeleteConfirmBuy.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cBuys.Delete_Buy(oBuy);
                        Update_Datagrid();
                    }
                }
                else
                {
                    DialogResult res = new DialogResult();
                    frmErrorDgvVoid formErrorDgvVoid = new frmErrorDgvVoid();
                    res = formErrorDgvVoid.ShowDialog();
                    if (res == DialogResult.OK)
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

        private void dgvBuys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;

            if (numRow != -1)
            {
                lblCodeBuy.Text = Convert.ToString(dgvBuys.Rows[numRow].Cells[0].Value);
            }
        }

        private void frmBuys_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }

        private void dgvBuys_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBuys.Columns[e.ColumnIndex].Name == "State")
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
