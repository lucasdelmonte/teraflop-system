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
    public partial class frmUsers : Form
    {
        #region instance 
        public static frmUsers instance;
        public static frmUsers Get_Instance()
        {
            if (instance == null)
                instance = new frmUsers();
            if (instance.IsDisposed)
                instance = new frmUsers();

            return instance;
        }
        #endregion

        #region variables
        MODELO.User oUser;
        CONTROLADORA.Users cUsers;
        CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmUsers(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cUsers = CONTROLADORA.Users.Get_Instance();
            Update_Datagrid();
            lblUser_Code.Text = miUser.Cod_User.ToString();
        }
        public frmUsers()
        {
        }
        #endregion

        #region methods
        private void Update_Datagrid()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = cUsers.Get_User();
        }
        #endregion

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                frmUser formUser = new frmUser(new MODELO.User(), MODELO.ACTION.ADD, "frmAction");
                result = formUser.ShowDialog();
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
            if (dgvUsers.CurrentRow == null)
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
                oUser = (MODELO.User)dgvUsers.CurrentRow.DataBoundItem;
                frmUser formUser = new frmUser(oUser, MODELO.ACTION.MODIFY, "frmAction");
                DialogResult result = formUser.ShowDialog();
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
            if (dgvUsers.CurrentRow == null)
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
                if (dgvUsers.Rows.Count >= 2)
                {
                    oUser = (MODELO.User)dgvUsers.CurrentRow.DataBoundItem;
                    if (oUser.Cod_User.ToString() == lblUser_Code.Text)
                    {
                        DialogResult res = new DialogResult();
                        frmErrorDeletedUser formErrorDeletedUser = new frmErrorDeletedUser();
                        res = formErrorDeletedUser.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            return;
                        }
                    }
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmUser formDeleteConfirmUser = new frmDeleteConfirmUser();
                    result = formDeleteConfirmUser.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cUsers.Delete_User(oUser);
                        Update_Datagrid();
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
    }
}
