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
using VISTA.Products;
using VISTA.Categories;
using VISTA.Models;
using VISTA.Marks;
using VISTA.Sales;
using VISTA.Providers;
using VISTA.Buys;
using VISTA.Users;
using VISTA.Reports;
using BunifuAnimatorNS;
using VISTA.Audits;
using System.Globalization;

namespace VISTA
{
    public partial class frmMenu : Form
    {
        #region variables
        CONTEXTO.TeraflopSystem ctxTeraflop;
        CONTROLADORA.LoginLogoutAuds cLoginLogoutAuds;
        MODELO.User oUser;
        private int cont;
        #endregion

        #region constructors
        public frmMenu(MODELO.User miUser)
        {
            InitializeComponent();
            cont = 0;
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cLoginLogoutAuds = CONTROLADORA.LoginLogoutAuds.Get_Instance();
            oUser = miUser;
            Update_Labels(oUser);
        }
        public frmMenu()
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            lblUsername.Text = "test";
            lblName.Text = "LucasDev";
            lblName.Text = "DEV";
        }
        #endregion

        #region topBar
        int posY = 0;
        int posX = 0;
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
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
        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
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
        private void pbIconTitle_MouseMove(object sender, MouseEventArgs e)
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
        private void iconClose_Click(object sender, EventArgs e)
        {
            frmExitApplication formExitApplication = new frmExitApplication();
            DialogResult result = formExitApplication.ShowDialog();
            if (result == DialogResult.OK)
            {
                Audit_LoginLogout();
                Application.Exit();
            }
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region methods
        private void Validate_Role()
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.ROLE)))
            {
                string role = Convert.ToString((MODELO.ROLE)i);
                if (role == oUser.Role && oUser.Role == "EMPLOYEE")
                {
                    btnUsers.Visible = false;
                    btnCategory.Visible = false;
                    btnMark.Visible = false;
                    btnModel.Visible = false;
                    btnReports.Visible = false;
                    btnAudits.Visible = false;
                    btnProducts.Location = new Point(10, 224);
                    btnSales.Location = new Point(10, 267);
                    btnProviders.Location = new Point(10, 310);
                    btnShopping.Location = new Point(10, 356);
                    return;
                }
            }
            btnUsers.Visible = true;
        }
        private void Audit_LoginLogout()
        {
            MODELO.LoginLogoutAud oLoginLogoutAud = new MODELO.LoginLogoutAud();
            oLoginLogoutAud.Cod_User = oUser.Cod_User;
            oLoginLogoutAud.Name = oUser.Name;
            oLoginLogoutAud.LastName = oUser.LastName;
            oLoginLogoutAud.Role = oUser.Role;
            oLoginLogoutAud.AudUsuario = oUser.Username;
            DateTime date = DateTime.Now;
            string finalDate = date.ToString("g", CultureInfo.CreateSpecificCulture("en-US"));
            oLoginLogoutAud.AudFandH = finalDate;
            oLoginLogoutAud.AudAction = "Logout";
            cLoginLogoutAuds.Add_LoginLogoutAud(oLoginLogoutAud);
        }
        private void clearTextButtons(bool open)
        {
            if (open)
            {
                btnMenu.Left = 22;
                btnMyAccount.Text = "";
                btnMyAccount.Left = 22;
                btnUsers.Text = "";
                btnUsers.Left = 26;
                btnCustomers.Text = "";
                btnCustomers.Left = 22;
                btnCategory.Text = "";
                btnCategory.Left = 22;
                btnModel.Text = "";
                btnModel.Left = 22;
                btnMark.Text = "";
                btnMark.Left = 22;
                btnProducts.Text = "";
                btnProducts.Left = 22;
                btnSales.Text = "";
                btnSales.Left = 22;
                btnProviders.Text = "";
                btnProviders.Left = 22;
                btnShopping.Text = "";
                btnShopping.Left = 22;
                btnReports.Text = "";
                btnReports.Left = 22;
                btnExit.Text = "";
                btnExit.Left = 22;
                lblName.Visible = false;
                label2.Visible = false;
                return;
            }
            btnMenu.Left = 8;
            btnMyAccount.Text = "    My account";
            btnMyAccount.Left = 8;
            btnUsers.Text = "       Users";
            btnUsers.Left = 13;
            btnCustomers.Text = "       Customers";
            btnCustomers.Left = 8;
            btnCategory.Text = "       Categories";
            btnCategory.Left = 8;
            btnModel.Text = "       Models";
            btnModel.Left = 8;
            btnMark.Text = "       Marks";
            btnMark.Left = 8;
            btnProducts.Text = "       Products";
            btnProducts.Left = 8;
            btnSales.Text = "       Sales";
            btnSales.Left = 8;
            btnProviders.Text = "       Providers";
            btnProviders.Left = 8;
            btnShopping.Text = "       Shoppings";
            btnShopping.Left = 8;
            btnReports.Text = "       Reports";
            btnReports.Left = 8;
            btnExit.Text = "       Exit";
            btnExit.Left = 8;
            lblName.Visible = true;
            label2.Visible = true;

        }
        private void Selected_Buttons(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            try
            {
                btnUsers.Textcolor = Color.FromArgb(214, 214, 206);
                btnCustomers.Textcolor = Color.FromArgb(214, 214, 206);
                btnProducts.Textcolor = Color.FromArgb(214, 214, 206);
                btnCategory.Textcolor = Color.FromArgb(214, 214, 206);
                btnModel.Textcolor = Color.FromArgb(214, 214, 206);
                btnMark.Textcolor = Color.FromArgb(214, 214, 206);
                btnProviders.Textcolor = Color.FromArgb(214, 214, 206);
                btnSales.Textcolor = Color.FromArgb(214, 214, 206);
                btnShopping.Textcolor = Color.FromArgb(214, 214, 206);
                btnReports.Textcolor = Color.FromArgb(214, 214, 206);

                sender.selected = true;

                if (sender.selected)
                {
                    sender.Textcolor = Color.FromArgb(235, 216, 208);
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

        private void Follow_Button(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            try
            {
                pbSelected.Top = sender.Top;
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

        private Form formActive = null;

        private void Open_Form(Form FormChild)
        {
            try
            {
                if (formActive != null)
                {
                    formActive.Close();
                }
                formActive = FormChild;
                FormChild.TopLevel = false;
                FormChild.Dock = DockStyle.Fill;
                pnPrimary.Controls.Add(FormChild);
                pnPrimary.Tag = FormChild;
                FormChild.BringToFront();
                FormChild.Show();
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Open_Form(new frmCustomers(oUser));
            Validate_Role();
        }

        private void Update_Labels(MODELO.User oUser)
        {
            lblUsername.Text = oUser.Username;
            lblName.Text = oUser.Name;
            lblRole.Text = oUser.Role;
        }
        #endregion

        #region leftBar    
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                frmUser formUser = new frmUser(oUser, MODELO.ACTION.MODIFY, "frmAction");
                result = formUser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Update_Labels(oUser);
                    return;
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmUsers(oUser));
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmCustomers(oUser));
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmProducts(oUser));
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

        private void btnCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmCategories(oUser));
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

        private void btnModel_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmModels(oUser));
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

        private void btnMark_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmMarks(oUser));
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

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmSales(oUser));
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

        private void btnProviders_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmProviders(oUser));
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

        private void btnShopping_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmBuys(oUser));
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                Selected_Buttons((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Follow_Button((Bunifu.Framework.UI.BunifuFlatButton)sender);
                Open_Form(new frmReports());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExitApplication formExitApplication = new frmExitApplication();
            DialogResult result = formExitApplication.ShowDialog();
            if (result == DialogResult.OK)
            {
                Audit_LoginLogout();
                Application.Exit();
            }
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 81)
            { //Menu minimizado
                panel1.Visible = false;
                panel1.Width = 169;
                AnimacionSidebar1.Show(panel1);
                clearTextButtons(false);
            }
            else
            { //panel1 maximizado
                panel1.Visible = false;
                panel1.Width = 81;
                AnimacionSidebar2.Show(panel1);
                clearTextButtons(true);
            }
        }

        private void btnAudits_Click(object sender, EventArgs e)
        {
            try
            {
                frmAudits formAudits = new frmAudits();
                formAudits.ShowDialog();
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

        private void trLoad_Tick(object sender, EventArgs e)
        {
            cont++;
        }
    }
}
