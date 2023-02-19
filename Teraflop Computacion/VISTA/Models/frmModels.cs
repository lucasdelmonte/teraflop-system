using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.Features;
using VISTA.Notifications;

namespace VISTA.Models
{
    public partial class frmModels : Form
    {
        #region instance 
        public static frmModels instance;
        public static frmModels Get_Instance()
        {
            if (instance == null)
                instance = new frmModels();
            if (instance.IsDisposed)
                instance = new frmModels();

            return instance;
        }
        #endregion

        #region variables
        private CONTROLADORA.Models cModels;
        private MODELO.Model oModel;
        private CONTROLADORA.Products cProducts;
        private CONTROLADORA.Providers cProviders;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.User User;
        #endregion

        #region constructor
        public frmModels(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cModels = CONTROLADORA.Models.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            Update_Datagrids();
            User = miUser;
        }

        public frmModels()
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
                    btnDeleteModel.Visible = false;
                    btnModifyModel.Visible = false;
                    return;
                }
            }
            btnDeleteModel.Visible = true;
            btnModifyModel.Visible = true;
        }
        private void Update_Datagrids()
        {
            dgvModels.DataSource = null;
            dgvModels.DataSource = cModels.Get_Model();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();

            dgvProviders.DataSource = null;
            dgvProviders.DataSource = cProviders.Get_Provider();
        }
        #endregion

        #region model options
        private void btnAddModel_Click(object sender, EventArgs e)
        {
            try
            {

                frmModel formModel = new frmModel(new MODELO.Model(), MODELO.ACTION.ADD);
                DialogResult result = formModel.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrids();
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

        private void btnModifyModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.CurrentRow == null)
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
                oModel = (MODELO.Model)dgvModels.CurrentRow.DataBoundItem;
                frmModel formModel = new frmModel(oModel, MODELO.ACTION.MODIFY);
                DialogResult result = formModel.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Datagrids();
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

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.CurrentRow == null)
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
                foreach (DataGridViewRow Fila in dgvProducts.Rows)
                {
                    oModel = (MODELO.Model)dgvModels.CurrentRow.DataBoundItem;
                    if (oModel == (MODELO.Model)Fila.Cells[4].Value)
                    {
                        DialogResult res = new DialogResult();
                        frmErrorDeletedModel formErrorDeletedModel = new frmErrorDeletedModel();
                        res = formErrorDeletedModel.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (dgvModels.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmModel formDeleteConfirmModel = new frmDeleteConfirmModel();
                    result = formDeleteConfirmModel.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cModels.Delete_Model(oModel);
                        Update_Datagrids();
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

        private void frmModels_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }
    }
}
