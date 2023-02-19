using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Notifications
{
    public partial class frmRecoverPassword : Form
    {
        #region variables
        CONTROLADORA.Users cUsers;
        MODELO.User oUser;
        #endregion

        #region constructor
        public frmRecoverPassword(MODELO.User miUser)
        {
            InitializeComponent();
            cUsers = CONTROLADORA.Users.Get_Instance();
            oUser = miUser;
        }
        #endregion

        #region topBar and buttons
        private void btnAccept_Click(object sender, EventArgs e)
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("teraflop.computacion@gmail.com");
            Correo.To.Add("teraflop.computacion@gmail.com");
            Correo.Subject = ("Teraflop system password recovery method for: " + oUser.Name + " " + oUser.LastName);
            Correo.Body = "Hello " + oUser.Name + ", you have requested to recover your password: " + oUser.Password;
            Correo.Priority = MailPriority.Normal;

            SmtpClient ServerEmail = new SmtpClient();
            ServerEmail.Credentials = new NetworkCredential("teraflop.computacion@gmail.com", "qhqohuxbamwxiaqt");
            ServerEmail.Host = "smtp.gmail.com";
            ServerEmail.Port = 587;
            ServerEmail.EnableSsl = true;

            try
            {
                ServerEmail.Send(Correo);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK);
                DialogResult res = new DialogResult();
                frmErrorUnexpected formErrorUnexpected = new frmErrorUnexpected();
                res = formErrorUnexpected.ShowDialog();
                if (res == DialogResult.OK)
                {
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        int posY = 0;
        int posX = 0;
        private void plColor_MouseMove(object sender, MouseEventArgs e)
        {
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
        #endregion
    }
}
