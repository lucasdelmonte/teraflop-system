using BunifuAnimatorNS;
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
using VISTA.Users;

namespace VISTA
{
    public partial class frmLogin : Form
    {
        #region variables
        private CONTROLADORA.Users cUser;
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        private CONTROLADORA.LoginLogoutAuds cLoginLogoutAuds;
        private int cont;
        #endregion

        #region instance
        public static frmLogin instance;
        public static frmLogin Get_Instance()
        {
            if (instance == null)
                instance = new frmLogin();
            if (instance.IsDisposed)
                instance = new frmLogin();

            return instance;
        }
        #endregion

        #region constructor
        public frmLogin()
        {
            InitializeComponent();
            cont = 0;
            trLoad.Enabled = true;
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cUser = CONTROLADORA.Users.Get_Instance();
            cLoginLogoutAuds = CONTROLADORA.LoginLogoutAuds.Get_Instance();

            lblClickHere.Font = new Font(lblClickHere.Font, FontStyle.Underline);
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
            Application.Exit();
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;     
        }
        #endregion

        #region buttons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = ctxTeraflop.Validate_Login(txtUsername.Text, txtPassword.Text);

                if (dgvUsers.Rows.Count == 1) {
                    MODELO.User oUser = new MODELO.User();
                    oUser.Cod_User = (int)dgvUsers.Rows[0].Cells[0].Value;
                    oUser.Username = (string)dgvUsers.Rows[0].Cells[1].Value;
                    oUser.Name = (string)dgvUsers.Rows[0].Cells[2].Value;
                    oUser.LastName = (string)dgvUsers.Rows[0].Cells[3].Value;
                    oUser.Password = (string)dgvUsers.Rows[0].Cells[4].Value;
                    oUser.Role = (string)dgvUsers.Rows[0].Cells[5].Value;

                    MODELO.LoginLogoutAud oLoginLogoutAud = new MODELO.LoginLogoutAud();
                    oLoginLogoutAud.Cod_User = oUser.Cod_User;
                    oLoginLogoutAud.Name = oUser.Name;
                    oLoginLogoutAud.LastName = oUser.LastName;
                    oLoginLogoutAud.Role = oUser.Role;
                    oLoginLogoutAud.AudUsuario = oUser.Username;
                    DateTime date = DateTime.Now;
                    string finalDate = date.ToString("g", CultureInfo.CreateSpecificCulture("en-US"));
                    oLoginLogoutAud.AudFandH = finalDate;
                    oLoginLogoutAud.AudAction = "Login";
                    cLoginLogoutAuds.Add_LoginLogoutAud(oLoginLogoutAud);

                    frmMenu formMenu = new frmMenu(oUser);
                    formMenu.Show();

                    this.Hide();
                } else
                {
                    DialogResult result = new DialogResult();
                    frmErrorLogin formErrorLogin = new frmErrorLogin();
                    result = formErrorLogin.ShowDialog();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }
        #endregion

        private void lblClickHere_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = ctxTeraflop.Get_User(txtUsername.Text);

            if (dgvUsers.Rows.Count == 1)
            {
                MODELO.User oUser = new MODELO.User();
                oUser.Cod_User = (int)dgvUsers.Rows[0].Cells[0].Value;
                oUser.Username = (string)dgvUsers.Rows[0].Cells[1].Value;
                oUser.Name = (string)dgvUsers.Rows[0].Cells[2].Value;
                oUser.LastName = (string)dgvUsers.Rows[0].Cells[3].Value;
                oUser.Password = (string)dgvUsers.Rows[0].Cells[4].Value;
                oUser.Role = (string)dgvUsers.Rows[0].Cells[5].Value;

                DialogResult res = new DialogResult();
                frmRecoverPassword formRecoverPassword = new frmRecoverPassword(oUser);
                res = formRecoverPassword.ShowDialog();
                if (res == DialogResult.OK)
                {
                    return;
                }
            } else
            {
                DialogResult res = new DialogResult();
                frmErrorUserFound formErrorUserFound = new frmErrorUserFound();
                res = formErrorUserFound.ShowDialog();
                if (res == DialogResult.OK)
                {
                    return;
                }
            }

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmUser formUser = new frmUser(new MODELO.User(), MODELO.ACTION.ADD, "frmLogin");
                formUser.ShowDialog();
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
    }
}
