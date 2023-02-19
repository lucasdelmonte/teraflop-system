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

namespace VISTA.Providers
{
    public partial class frmProviders : Form
    {
        #region instance 
        public static frmProviders instance;
        public static frmProviders Get_Instance()
        {
            if (instance == null)
                instance = new frmProviders();
            if (instance.IsDisposed)
                instance = new frmProviders();

            return instance;
        }
        #endregion

        #region variables
        CONTROLADORA.Providers cProviders;
        MODELO.Provider oProvider;
        MODELO.User User;
        CONTROLADORA.Categories cCategories;

        private CONTEXTO.TeraflopSystem ctxTeraflop;
        #endregion

        #region constructor
        public frmProviders(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            Update_DatagridCategory();
            Update_Datagrid();
            User = miUser;
            lblCodeProvider.Text = Convert.ToString(dgvProviders.Rows[0].Cells[0].Value);
        }

        public frmProviders()
        { 
        }
        #endregion

        #region methods
        public void Update_DatagridCategory()
        {
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = cCategories.Get_Category();
        }
        public void Update_Datagrid()
        {
            dgvProviders.DataSource = null;
            dgvProviders.DataSource = cProviders.Get_Provider();
        }
        private void Validate_Role()
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.ROLE)))
            {
                string role = Convert.ToString((MODELO.ROLE)i);
                if (role == User.Role && User.Role == "EMPLOYEE")
                {
                    btnDelete.Visible = false;
                    btnAdd.Visible = false; 
                    btnConsult.Location = new Point(18, 555);
                    return;
                }
            }
        }
        #endregion

        #region buttons
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmProvider formProvider = new frmProvider(new MODELO.Provider(), MODELO.ACTION.ADD);
                DialogResult result = formProvider.ShowDialog();
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
            if (dgvProviders.CurrentRow == null)
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
                // Revisar
                int Cod_Provider = Convert.ToInt32(lblCodeProvider.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Provider(Cod_Provider);
                oProvider = (MODELO.Provider)dgvProviders.CurrentRow.DataBoundItem;

                frmEditProvider formEditProvider = new frmEditProvider(oProvider, MODELO.ACTION.MODIFY);
                DialogResult result = formEditProvider.ShowDialog();
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
            if (dgvProviders.CurrentRow == null)
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
                int Cod_Provider = Convert.ToInt32(lblCodeProvider.Text);
                dgvTest.DataSource = ctxTeraflop.Get_Provider(Cod_Provider);
                oProvider = (MODELO.Provider)dgvProviders.CurrentRow.DataBoundItem;

                if (dgvProviders.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmProvider formDeleteConfirmProvider = new frmDeleteConfirmProvider();
                    result = formDeleteConfirmProvider.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cProviders.Delete_Provider(oProvider);
                        Update_Datagrid();
                    }
                } else
                {
                    DialogResult result = new DialogResult();
                    frmErrorDgvVoid formErrorDgvVoid = new frmErrorDgvVoid();
                    result = formErrorDgvVoid.ShowDialog();
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

        private void dgvProviders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;

            if (numRow != -1)
            {
                lblCodeProvider.Text = Convert.ToString(dgvProviders.Rows[numRow].Cells[0].Value);
            }
        }

        private void frmProviders_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }
    }
}
