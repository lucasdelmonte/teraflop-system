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

namespace VISTA.Marks
{
    public partial class frmMarks : Form
    {
        #region instance 
        public static frmMarks instance;
        public static frmMarks Get_Instance()
        {
            if (instance == null)
                instance = new frmMarks();
            if (instance.IsDisposed)
                instance = new frmMarks();

            return instance;
        }
        #endregion

        #region variables
        private CONTROLADORA.Marks cMarks;
        private MODELO.Mark oMark;
        private CONTROLADORA.Products cProducts;
        private CONTROLADORA.Providers cProviders;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.User User;
        #endregion

        #region constructor
        public frmMarks(MODELO.User miUser)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cMarks = CONTROLADORA.Marks.Get_Instance();

            cProducts = CONTROLADORA.Products.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            Update_Datagrids();
            User = miUser;
        }

        public frmMarks()
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
                    btnDeleteMark.Visible = false;
                    btnModifyMark.Visible = false;
                    return;
                }
            }
            btnDeleteMark.Visible = true;
            btnModifyMark.Visible = true;
        }
        private void Update_Datagrids()
        {
            dgvMarks.DataSource = null;
            dgvMarks.DataSource = cMarks.Get_Mark();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();

            dgvProviders.DataSource = null;
            dgvProviders.DataSource = cProviders.Get_Provider();
        }
        #endregion

        #region mark options
        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {

                frmMark formMark = new frmMark(new MODELO.Mark(), MODELO.ACTION.ADD);
                DialogResult result = formMark.ShowDialog();
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

        private void btnModifyMark_Click(object sender, EventArgs e)
        {
            if (dgvMarks.CurrentRow == null)
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
                oMark = (MODELO.Mark)dgvMarks.CurrentRow.DataBoundItem;
                frmMark formMark = new frmMark(oMark, MODELO.ACTION.MODIFY);
                DialogResult result = formMark.ShowDialog();
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

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (dgvMarks.CurrentRow == null)
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
                    oMark = (MODELO.Mark)dgvMarks.CurrentRow.DataBoundItem;
                    if (oMark == (MODELO.Mark)Fila.Cells[5].Value)
                    {
                        DialogResult res = new DialogResult();
                        frmErrorDeletedMark formErrorDeletedMark = new frmErrorDeletedMark();
                        res = formErrorDeletedMark.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (dgvMarks.Rows.Count >= 2)
                {
                    DialogResult result = new DialogResult();
                    frmDeleteConfirmMark formDeleteConfirmMark = new frmDeleteConfirmMark();
                    result = formDeleteConfirmMark.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cMarks.Delete_Mark(oMark);
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

        private void frmMarks_Load(object sender, EventArgs e)
        {
            Validate_Role();
        }
    }
}
