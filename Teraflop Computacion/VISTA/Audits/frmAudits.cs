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

namespace VISTA.Audits
{
    public partial class frmAudits : Form
    {
        #region variables
        CONTROLADORA.CustomerAuds cCustomerAuds;
        CONTROLADORA.LoginLogoutAuds cLoginLogoutAuds;
        CONTEXTO.TeraflopSystem ctxTeraflop;
        MODELO.CustomerAud oCustomerAud;
        MODELO.LoginLogoutAud oLoginLogoutAud;
        #endregion

        #region constructor
        public frmAudits()
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cCustomerAuds = CONTROLADORA.CustomerAuds.Get_Instance();
            cLoginLogoutAuds = CONTROLADORA.LoginLogoutAuds.Get_Instance();
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

        public void Update_CustomerAudDatagrid()
        {
            dgvAudits.DataSource = null;
            dgvAudits.DataSource = cCustomerAuds.Get_CustomerAud();

            dgvAudits.Columns["Cod_CustomerAud"].Visible = false;
            dgvAudits.Columns["Cod_Customer"].Visible = false;
            dgvAudits.Columns["Email"].Visible = false;
            dgvAudits.Columns["Direction"].Visible = false;
            dgvAudits.Columns["Telephone"].Visible = false;
            dgvAudits.Columns["Name"].Width = 120;

            dgvAudits.Columns["AudAction"].Width = 100;
            dgvAudits.Columns["AudAction"].HeaderText = "Action";

            dgvAudits.Columns["AudUsuario"].HeaderText = "Code - User";
            dgvAudits.Columns["AudFandH"].HeaderText = "Date / Hour";
        }
        public void Update_LoginLogoutAudDatagrid()
        {
            dgvAudits.DataSource = null;
            dgvAudits.DataSource = cLoginLogoutAuds.Get_LoginLogoutAud();

            dgvAudits.Columns["Cod_LoginLogoutAud"].Visible = false;
            dgvAudits.Columns["Cod_User"].Visible = false;
            dgvAudits.Columns["Name"].Width = 120;

            dgvAudits.Columns["AudAction"].Width = 100;
            dgvAudits.Columns["AudAction"].HeaderText = "Action";
            dgvAudits.Columns["AudFandH"].HeaderText = "Date / Hour";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Clear_Filters();
            Update_CustomerAudDatagrid();
            lblSelected.Text = "customer";
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (dgvAudits.CurrentRow == null)
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
                if(lblSelected.Text == "customer")
                {
                    oCustomerAud = (MODELO.CustomerAud)dgvAudits.CurrentRow.DataBoundItem;
                    frmCustomerAud formCustomerAud = new frmCustomerAud(oCustomerAud);
                    DialogResult result = formCustomerAud.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                    return;
                }
                if (lblSelected.Text == "login/logout")
                {
                    oLoginLogoutAud = (MODELO.LoginLogoutAud)dgvAudits.CurrentRow.DataBoundItem;
                    frmLoginLogoutAud formLoginLogoutAud = new frmLoginLogoutAud(oLoginLogoutAud);
                    DialogResult result = formLoginLogoutAud.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
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
                    return;
                }
            }
        }

        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            Clear_Filters();
            Update_LoginLogoutAudDatagrid();
            lblSelected.Text = "login/logout";
        }

        public void Clear_Filters()
        {
            txtCustomerName.Text = "";
            txtDateFrom.Text = "";
            txtDateUntil.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbApplyFilterDates.Checked)
            {
                DateTime dateFrom;
                if (!DateTime.TryParse(txtDateFrom.Text, out dateFrom))
                {
                    dateFrom = DateTime.MinValue;
                }
                DateTime dateUntil;
                if (!DateTime.TryParse(txtDateUntil.Text, out dateUntil))
                {
                    dateUntil = DateTime.MinValue;
                }
            }
        }
    }
}
