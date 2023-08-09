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
using VISTA.Notifications;

namespace VISTA.Customers
{
    public partial class frmCustomer : Form
    {
        #region variables
        CONTROLADORA.Customers cCustomers;
        CONTROLADORA.CustomerAuds cCustomerAuds;
        MODELO.Customer oCustomer;
        MODELO.User oUser;
        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmCustomer(MODELO.Customer miCustomer, MODELO.ACTION miACTION, MODELO.User miUser)
        {
            InitializeComponent();
            cCustomers = CONTROLADORA.Customers.Get_Instance();
            cCustomerAuds = CONTROLADORA.CustomerAuds.Get_Instance();
            oCustomer = miCustomer;
            oUser = miUser;
            ACTION = miACTION;

            if (ACTION != MODELO.ACTION.ADD)
            {
                txtCode.Text = oCustomer.Cod_Customer.ToString();
                txtName.Text = oCustomer.Name;
                txtLastName.Text = oCustomer.LastName;
                txtEmail.Text = oCustomer.Email;
                txtDirection.Text = oCustomer.Direction;
                txtTelephone.Text = oCustomer.Telephone;
            }
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

        #region buttons
        private void btnAccept_Click(object sender, EventArgs e)
        {
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
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtLastName.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtEmail.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtDirection.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDirection.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtTelephone.Focus();
                    return;
                }
            }

            try
            {
                oCustomer.Name = txtName.Text;
                oCustomer.LastName = txtLastName.Text;
                oCustomer.Email = txtEmail.Text;
                oCustomer.Direction = txtDirection.Text;
                oCustomer.Telephone = txtTelephone.Text;

                MODELO.CustomerAud oCustomerAud = new MODELO.CustomerAud();
                oCustomerAud.Name = txtName.Text;
                oCustomerAud.LastName = txtLastName.Text;
                oCustomerAud.Email = txtEmail.Text;
                oCustomerAud.Direction = txtDirection.Text;
                oCustomerAud.Telephone = txtTelephone.Text;
                oCustomerAud.AudUsuario = "Code: " + oUser.Cod_User + " - " + oUser.Name +" "+ oUser.LastName;
                DateTime date = DateTime.Now;
                string finalDate = date.ToString("g", CultureInfo.CreateSpecificCulture("en-US"));
                oCustomerAud.AudFandH = DateTime.Parse(finalDate);

                if (ACTION == MODELO.ACTION.ADD)
                {
                    cCustomers.Add_Customer(oCustomer);
                    oCustomerAud.AudAction = "Add";
                }
                else
                {
                    cCustomers.Modify_Customer(oCustomer);
                    oCustomerAud.AudAction = "Modify";
                }
                oCustomerAud.Cod_Customer = oCustomer.Cod_Customer;
                cCustomerAuds.Add_CustomerAud(oCustomerAud);
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
    }
}
