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
    public partial class frmLoginLogoutAud : Form
    {
        #region variables
        CONTROLADORA.LoginLogoutAuds cLoginLogoutAuds;
        CONTEXTO.TeraflopSystem ctxTeraflop;
        MODELO.LoginLogoutAud oLoginLogoutAud;
        #endregion

        public frmLoginLogoutAud(MODELO.LoginLogoutAud miLoginLogoutAud)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cLoginLogoutAuds = CONTROLADORA.LoginLogoutAuds.Get_Instance();
            oLoginLogoutAud = miLoginLogoutAud;

            txtCodAudit.Text = oLoginLogoutAud.Cod_LoginLogoutAud.ToString();
            txtUser.Text = oLoginLogoutAud.AudUsuario.ToString();
            txtDateHour.Text = oLoginLogoutAud.AudFandH.ToString();
            txtAction.Text = oLoginLogoutAud.AudAction.ToString();

            txtCodUser.Text = oLoginLogoutAud.Cod_User.ToString();
            txtName.Text = oLoginLogoutAud.Name.ToString();
            txtLastName.Text = oLoginLogoutAud.LastName.ToString();
            txtRole.Text = oLoginLogoutAud.Role.ToString();
        }

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
