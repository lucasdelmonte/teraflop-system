using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.Customers;
using VISTA.Notifications;

namespace VISTA
{
    public partial class frmCustomers : Form
    {
        #region instance 
        public static frmCustomers instance;
        public static frmCustomers Get_Instance()
        {
            if (instance == null)
                instance = new frmCustomers();
            if (instance.IsDisposed)
                instance = new frmCustomers();

            return instance;
        }
        #endregion

        #region variables
        private CONTROLADORA.Customers cCustomers;
        private CONTROLADORA.Sales cSales;
        private CONTROLADORA.CustomerAuds cCustomerAuds;
        private MODELO.Customer oCustomer;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.User User;
        #endregion

        #region constructor
        public frmCustomers(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cCustomers = CONTROLADORA.Customers.Get_Instance();
            cCustomerAuds = CONTROLADORA.CustomerAuds.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            Update_Datagrid();
            User = miUser;
        }

        public frmCustomers()
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
                    btnDelete.Visible = false;
                    //btnModify.Visible = false;
                    return;
                }
            }
            btnDelete.Visible = true;
            //btnModify.Visible = true;
        }

        private void Update_Datagrid() {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cCustomers.Get_Customer();

            dgvSales.DataSource = null;
            dgvSales.DataSource = cSales.Get_Sale();
        }

        public void Search_Customer() {
            if (string.IsNullOrWhiteSpace(txtSearchUsername.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorVoid formErrorVoid = new frmErrorVoid();
                result = formErrorVoid.ShowDialog();
                Update_Datagrid();
                return;
            }
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = ctxTeraflop.Get_Customers(txtSearchUsername.Text);
            if (dgvCustomers.CurrentRow == null)
            {
                Update_Datagrid();
            }
        }
        #endregion

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                frmCustomer formCustomer = new frmCustomer(new MODELO.Customer(), MODELO.ACTION.ADD, User);
                DialogResult result = formCustomer.ShowDialog();
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
            if (dgvCustomers.CurrentRow == null)
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
                oCustomer = (MODELO.Customer)dgvCustomers.CurrentRow.DataBoundItem;
                frmCustomer formCustomer = new frmCustomer(oCustomer, MODELO.ACTION.MODIFY, User);
                DialogResult result = formCustomer.ShowDialog();
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
            if (dgvCustomers.CurrentRow == null)
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
                    oCustomer = (MODELO.Customer)dgvCustomers.CurrentRow.DataBoundItem;
                    if (oCustomer == (MODELO.Customer)Fila.Cells[3].Value)
                    {
                        DialogResult res = new DialogResult();
                        frmErrorDeletedCustomer formErrorDeletedCustomer = new frmErrorDeletedCustomer();
                        res = formErrorDeletedCustomer.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (dgvCustomers.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmCustomer formDeleteConfirmCustomer = new frmDeleteConfirmCustomer();
                    result = formDeleteConfirmCustomer.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cCustomers.Delete_Customer(oCustomer);
                        MODELO.CustomerAud oCustomerAud = new MODELO.CustomerAud();
                        oCustomerAud.Cod_Customer = oCustomer.Cod_Customer;
                        oCustomerAud.Name = oCustomer.Name.ToString();
                        oCustomerAud.LastName = oCustomer.LastName.ToString();
                        oCustomerAud.Email = oCustomer.Email.ToString();
                        oCustomerAud.Direction = oCustomer.Direction.ToString();
                        oCustomerAud.Telephone = oCustomer.Telephone.ToString();
                        oCustomerAud.AudUsuario = "Code: " + User.Cod_User + " - " + User.Name + " " + User.LastName;
                        oCustomerAud.AudAction = "Delete";
                        DateTime date = DateTime.Now;
                        string finalDate = date.ToString("g", CultureInfo.CreateSpecificCulture("en-US"));
                        oCustomerAud.AudFandH = finalDate;
                        cCustomerAuds.Add_CustomerAud(oCustomerAud);
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

        #region filters
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search_Customer();
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
        #endregion

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }
    }
}
