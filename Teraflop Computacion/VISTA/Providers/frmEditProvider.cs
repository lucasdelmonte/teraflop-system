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
    public partial class frmEditProvider : Form
    {
        #region variables
        CONTROLADORA.Providers cProviders;
        CONTROLADORA.Categories cCategories;
        MODELO.Provider oProvider;
        private CONTEXTO.TeraflopSystem ctxTeraflop;

        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmEditProvider(MODELO.Provider miProvider, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cProviders = CONTROLADORA.Providers.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            oProvider = miProvider;
            ACTION = miACTION;
            Update_Datagrid();
            Update_Combobox();

            if (ACTION != MODELO.ACTION.ADD)
            {
                try
                {
                    txtName.Text = oProvider.Name;
                    txtDirection.Text = oProvider.Direction;
                    txtTelephone.Text = oProvider.Telephone;
                    txtWebsite.Text = oProvider.Website;
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

        #region methods
        private void Update_Datagrid()
        {
            try
            {
                if (oProvider.Category != null)
                {
                    foreach (var category in oProvider.Category)
                    {
                        dgvCategory.Rows.Add(category.Cod_Category, category.NameCategory);
                    }
                } else
                {
                    DialogResult result = new DialogResult();
                    frmErrorNoCategoryRelated formErrorNoCategoryRelated = new frmErrorNoCategoryRelated();
                    result = formErrorNoCategoryRelated.ShowDialog();
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
        public void Update_Combobox()
        {
            cbCategory.DataSource = null;
            cbCategory.DataSource = cCategories.Get_Category();
            cbCategory.DisplayMember = "NameCategory";
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MODELO.Category oCategory;

            oCategory = (MODELO.Category)cbCategory.SelectedItem;
            txtNameCategory.Text = oCategory.NameCategory;
        }
        #endregion

        #region grid button
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
                if (exist == true)
                {
                    dgvCategory.Rows[numRow].Cells[0].Value = cbCategory.SelectedItem;
                }
                else
                {
                    dgvCategory.Rows.Add(cbCategory.SelectedItem);
                    contRow++;
                }
            }
        }
        #endregion

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
                bool ignoreCode = true;

                if (ignoreCode)
                {
                    cProviders.Modify_Provider(oProvider);

                    this.DialogResult = DialogResult.OK;
                } 
                else
                {
                    if (dgvCategory.Rows.Count >= 1)
                    {
                        List<MODELO.Category> listCategory = new List<MODELO.Category>();
                        int Cod_Category;
                        string NameCategory;

                        try
                        {
                            foreach (DataGridViewRow Fila in dgvCategory.Rows)
                            {
                                //MODELO.Category oCategory;
                                // Obtenemos los datos del oCategory que necesitamos
                                Cod_Category = Convert.ToInt32(Fila.Cells[0].Value);
                                NameCategory = Convert.ToString(Fila.Cells[1].Value);
                                // Envio los datos y busco la coincidencia
                                // Cargo los datos obtenido en el dgvTest
                                dgvTest.DataSource = ctxTeraflop.Get_Category(Cod_Category, NameCategory);
                                // Al tener el oCategory guardado lo capturo y lo guardo
                                //oCategory = (MODELO.Category)dgvTest.CurrentRow.DataBoundItem;
                                //oCategory.Cod_Category = Convert.ToInt32(dgvTest.CurrentRow.Cells[0].Value);
                                //oCategory.NameCategory = Convert.ToString(dgvTest.CurrentRow.Cells[1].Value);
                                // Cargo el oCategory en la lista
                                //listCategory.Add(oCategory);
                            }
                            oProvider.Category = listCategory;

                            cProviders.Modify_Provider(oProvider);

                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                            /*
                            DialogResult result = new DialogResult();
                            frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                            result = formErrorUnexpected.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                return;
                            }
                            */
                        }
                    }
                    else
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
    }
}
