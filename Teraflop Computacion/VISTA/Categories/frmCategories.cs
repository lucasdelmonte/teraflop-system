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

namespace VISTA.Categories
{
    public partial class frmCategories : Form
    {
        #region instance 
        public static frmCategories instance;
        public static frmCategories Get_Instance()
        {
            if (instance == null)
                instance = new frmCategories();
            if (instance.IsDisposed)
                instance = new frmCategories();

            return instance;
        }
        #endregion

        #region variables
        private CONTROLADORA.Categories cCategories;
        private MODELO.Category oCategory;

        private CONTROLADORA.Products cProducts;
        private CONTROLADORA.Providers cProviders;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.User User;
        #endregion

        #region constructor
        public frmCategories(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            Update_Datagrids();
            User = miUser;
        }

        public frmCategories()
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
                    btnDeleteCategory.Visible = false;
                    btnModifyCategory.Visible = false;
                    return;
                }
            }
            btnDeleteCategory.Visible = true;
            btnModifyCategory.Visible = true;
        }

        private void Update_Datagrids()
        {
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = cCategories.Get_Category();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();

            dgvProviders.DataSource = null;
            dgvProviders.DataSource = cProviders.Get_Provider();
        }
        #endregion

        #region category options
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {

                frmCategory formCategory = new frmCategory(new MODELO.Category(), MODELO.ACTION.ADD);
                DialogResult result = formCategory.ShowDialog();
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

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
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
                oCategory = (MODELO.Category)dgvCategories.CurrentRow.DataBoundItem;
                frmCategory formCategory = new frmCategory(oCategory, MODELO.ACTION.MODIFY);
                DialogResult result = formCategory.ShowDialog();
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

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
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
                    oCategory = (MODELO.Category)dgvCategories.CurrentRow.DataBoundItem;
                    if (oCategory == (MODELO.Category)Fila.Cells[6].Value)
                    {
                        DialogResult res = new DialogResult();
                        frmErrorDeletedCategory formErrorDeletedCategory = new frmErrorDeletedCategory();
                        res = formErrorDeletedCategory.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (dgvCategories.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmCategory formDeleteConfirmCategory = new frmDeleteConfirmCategory();
                    result = formDeleteConfirmCategory.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cCategories.Delete_Category(oCategory);
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

        private void frmCategories_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }
    }
}
