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
    public partial class frmProvider : Form
    {
        #region variables
        CONTROLADORA.Providers cProviders;
        CONTROLADORA.Categories cCategories;
        MODELO.Provider oProvider;

        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmProvider(MODELO.Provider miProvider, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            oProvider = miProvider;
            ACTION = miACTION;
            Update_Combobox();
        }
        #endregion

        #region methods
        public void Update_Combobox()
        {
            cbCategory.DataSource = null;
            cbCategory.DataSource = cCategories.Get_Category();
            cbCategory.DisplayMember = "NameCategory";

            cbCategory.SelectedIndex = 0;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
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

        #region grid buttons and cb methods
        private int contRow = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool exist = false;
            int numRow = 0;

            if (contRow == 0)
            {
                dgvCategory.Rows.Add(cbCategory.SelectedItem);
                contRow++;
            } 
            else
            {
                foreach (DataGridViewRow Fila in dgvCategory.Rows)
                {
                    try
                    {
                        string nameInCell = Convert.ToString(Fila.Cells[0].Value);
                        if (nameInCell == txtNameCategory.Text)
                        {
                            exist = true;
                            numRow = Fila.Index;
                        }
                    }
                    catch (Exception)
                    {
                        DialogResult resultado = new DialogResult();
                        frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                        resultado = formErrorUnexpected.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                if (exist != true)
                {
                    dgvCategory.Rows.Add(cbCategory.SelectedItem);
                    contRow++;
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MODELO.Category oCategory;

            oCategory = (MODELO.Category)cbCategory.SelectedItem;
            txtNameCategory.Text = oCategory.NameCategory;
        }

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
            if (string.IsNullOrWhiteSpace(txtDirection.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDirection.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtTelephone.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtWebsite.Text))
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtWebsite.Focus();
                    return;
                }
            }
            if (cbCategory.SelectedItem == null)
            {
                DialogResult result = new DialogResult();
                frmErrorIncorrect formError = new frmErrorIncorrect();
                result = formError.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbCategory.Focus();
                    return;
                }
            }

            try
            {
                oProvider.Name = txtName.Text;
                oProvider.Direction = txtDirection.Text;
                oProvider.Telephone = txtTelephone.Text;
                oProvider.Website = txtWebsite.Text;

                if (contRow != 0)
                {
                    List<MODELO.Category> listCategory = new List<MODELO.Category>();

                    try
                    {

                        foreach (DataGridViewRow Fila in dgvCategory.Rows)
                        {
                            MODELO.Category oCategory;
                            oCategory = (MODELO.Category)Fila.Cells[0].Value;

                            listCategory.Add(oCategory);
                        }
                        oProvider.Category = listCategory;

                        cProviders.Add_Provider(oProvider);

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
                } else
                {
                    DialogResult resultado = new DialogResult();
                    frmErrorVoidGrid formErrorVoidGrid = new frmErrorVoidGrid();
                    resultado = formErrorVoidGrid.ShowDialog();
                    if (resultado == DialogResult.OK)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (contRow > 0)
                {
                    if (dgvCategory.CurrentRow.Index != -1)
                    {
                        dgvCategory.Rows.RemoveAt(dgvCategory.CurrentRow.Index);
                        contRow--;
                    }
                    else
                    {
                        DialogResult resultado = new DialogResult();
                        frmErrorSelectedGrid formErrorSelectedGrid = new frmErrorSelectedGrid();
                        resultado = formErrorSelectedGrid.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            return;
                        }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
