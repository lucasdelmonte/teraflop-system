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
    public partial class frmMark : Form
    {
        #region variables
        CONTROLADORA.Marks cMarks;
        MODELO.Mark oMark;
        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmMark(MODELO.Mark miMark, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cMarks = CONTROLADORA.Marks.Get_Instance();
            oMark = miMark;
            ACTION = miACTION;

            if (ACTION != MODELO.ACTION.ADD)
            {
                txtName.Text = oMark.NameMark;
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
                oMark.NameMark = txtName.Text;

                if (ACTION == MODELO.ACTION.ADD)
                {
                    cMarks.Add_Mark(oMark);
                }
                else
                {
                    cMarks.Modify_Mark(oMark);
                }
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
