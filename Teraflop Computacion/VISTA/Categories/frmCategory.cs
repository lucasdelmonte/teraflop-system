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

namespace VISTA.Features
{
    public partial class frmCategory : Form
    {
        #region variables
        CONTROLADORA.Categories cCategories;
        MODELO.Category oCategory;
        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmCategory(MODELO.Category miCategory, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            oCategory = miCategory;
            ACTION = miACTION;

            if (ACTION != MODELO.ACTION.ADD)
            {
                txtName.Text = oCategory.NameCategory;
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

            try
            {
                oCategory.NameCategory = txtName.Text;

                if (ACTION == MODELO.ACTION.ADD)
                    cCategories.Add_Category(oCategory);
                else
                    cCategories.Modify_Category(oCategory);

                this.DialogResult = DialogResult.OK;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
