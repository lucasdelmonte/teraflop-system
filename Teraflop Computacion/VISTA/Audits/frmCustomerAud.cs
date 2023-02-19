using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Audits
{
    public partial class frmCustomerAud : Form
    {

        #region variables
        CONTROLADORA.CustomerAuds cCustomerAuds;
        CONTEXTO.TeraflopSystem ctxTeraflop;
        MODELO.CustomerAud oCustomerAud;
        #endregion

        #region constructor
        public frmCustomerAud(MODELO.CustomerAud miCustomerAud)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cCustomerAuds = CONTROLADORA.CustomerAuds.Get_Instance();
            oCustomerAud = miCustomerAud;

            txtCodAudit.Text = oCustomerAud.Cod_CustomerAud.ToString();
            txtUser.Text = oCustomerAud.AudUsuario.ToString();
            txtDateHour.Text = oCustomerAud.AudFandH;
            txtAction.Text = oCustomerAud.AudAction.ToString();

            txtCodCustomer.Text = oCustomerAud.Cod_Customer.ToString();
            txtName.Text = oCustomerAud.Name.ToString();
            txtLastName.Text = oCustomerAud.LastName.ToString();
            txtEmail.Text = oCustomerAud.Email.ToString();
            txtDirection.Text = oCustomerAud.Direction.ToString();
            txtTelephone.Text = oCustomerAud.Telephone.ToString();
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
    }
}
