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

namespace VISTA.Users
{
    public partial class frmUser : Form
    {
        #region variables
        CONTROLADORA.Users cUsers;
        MODELO.User oUser;
        CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmUser(MODELO.User miUser, MODELO.ACTION miACTION, string frmType)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cUsers = CONTROLADORA.Users.Get_Instance();
            oUser = miUser;
            ACTION = miACTION;

            if(frmType == "frmLogin")
                rbAdmin.Visible = false;
            else
                rbAdmin.Visible = true;

            if(ACTION != MODELO.ACTION.ADD)
            {
                txtUserName.Text = oUser.Username;
                txtName.Text = oUser.Name;
                txtLastName.Text = oUser.LastName;
                txtPassword.Text = oUser.Password;
                rbAdmin.Enabled = false;
                rbEmployee.Enabled = false;
                if (oUser.Role.ToString() == "ADMIN")
                {
                    rbAdmin.Checked = true;
                    return;
                }
                rbEmployee.Checked = true;
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
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtUserName.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPassword.Focus();
                    return;
                }
            }

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

            if (ctxTeraflop.Users.Count(x => x.Username == txtUserName.Text) > 0)
            {
                if (oUser.Username == txtUserName.Text)
                {
                    oUser.Username = txtUserName.Text;
                    oUser.Password = txtPassword.Text;
                    oUser.Name = txtName.Text;
                    oUser.LastName = txtLastName.Text;

                    cUsers.Modify_User(oUser);

                    this.DialogResult = DialogResult.OK;
                } else
                {
                    DialogResult result = new DialogResult();
                    frmErrorUsername formUsername = new frmErrorUsername();
                    result = formUsername.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                oUser.Username = txtUserName.Text;
                oUser.Password = txtPassword.Text;
                oUser.Name = txtName.Text;
                oUser.LastName = txtLastName.Text;
                if (rbAdmin.Checked == true)
                    oUser.Role = "ADMIN";
                else
                    oUser.Role = "EMPLOYEE";

                if (ACTION == MODELO.ACTION.ADD)
                    cUsers.Add_User(oUser);
                else
                    cUsers.Modify_User(oUser);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
