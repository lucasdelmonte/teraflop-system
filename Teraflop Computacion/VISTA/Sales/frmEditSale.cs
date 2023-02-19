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
using System.Runtime.InteropServices;

namespace VISTA.Sales
{
    public partial class frmEditSale : Form
    {
        #region variables
        CONTROLADORA.Sales cSales;
        CONTROLADORA.Products cProducts;
        MODELO.Sale oSale;

        MODELO.ACTION ACTION;
        #endregion

        #region constructor
        public frmEditSale(MODELO.Sale miSale, MODELO.ACTION miACTION)
        {
            InitializeComponent();
            cProducts = CONTROLADORA.Products.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            oSale = miSale;
            ACTION = miACTION;
            Update_Datagrid();

            if (ACTION != MODELO.ACTION.ADD)
            {
                try
                {
                    txtNumber.Text = oSale.Cod_Sale.ToString();
                    txtDate.Text = oSale.Date;
                    txtTotalDisabled.Text = oSale.Total.ToString();
                    txtTotal.Text = "$ " + oSale.Total.ToString();
                    txtName.Text = oSale.oCustomer.Name + " " + oSale.oCustomer.LastName;
                    txtDirection.Text = oSale.oCustomer.Direction;
                    txtTelephone.Text = oSale.oCustomer.Telephone;
                    setStates(oSale.State.ToString());
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
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

        #region methods
        private void Update_Datagrid()
        {
            try
            {
                foreach (var detail in oSale.DetailSale)
                {
                    dgvDetailSales.Rows.Add(detail.oProduct.Name, "$ " + detail.Price, detail.Amount, "$ " + detail.Total);
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
        private void setStates(string miSaleState)
        {
            foreach (var i in Enum.GetValues(typeof(MODELO.STATE)))
            {
                string role = Convert.ToString((MODELO.STATE)i);
                cbSaleStatus.Items.Add(role);
            }
            cbSaleStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (miSaleState)
            {
                case "REQUESTED":
                    cbSaleStatus.SelectedIndex = 0;
                    break;
                case "IN_PROCESS":
                    cbSaleStatus.SelectedIndex = 1;
                    break;
                case "FINISHED":
                    cbSaleStatus.SelectedIndex = 2;
                    break;
            }
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

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void iconCompress_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region ticket
        private void btnGenerateTicket_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("Business Teraflop Computacion "); 
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Direction: Bv Oroño 370"); 
            Ticket1.TextoIzquierda("Telelephone: +54-3476589504");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoIzquierda("Sale date: " + txtDate.Text); 
            Ticket1.TextoIzquierda("Ticket number: " + txtNumber.Text); 
            Ticket1.TextoIzquierda("Ticket date: " + DateTime.Now.ToShortDateString() + " <=> Hour: " + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Client: " + txtName.Text);
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            
            foreach (var detail in oSale.DetailSale)
            {
                string detailNameModel = Convert.ToString(detail.oProduct.oModel.NameModel);
                double detailPrice = Convert.ToDouble(detail.Price);
                int detailAmount = detail.Amount;
                double detailTotal = Convert.ToDouble(detail.Total);
                Ticket1.AgregaArticulo(detailNameModel, detailPrice, detailAmount, detailTotal);
            }

            clsFactura.CreaTicket.LineasGuion();

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total ", double.Parse(txtTotalDisabled.Text)); 
            Ticket1.TextoIzquierda(" ");

            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Thank you very much for    *"); 
            Ticket1.TextoCentro("*          choosing us!          *");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");

            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);
        }
        #endregion

        #region button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (oSale.State != cbSaleStatus.SelectedItem.ToString())
            {
                oSale.State = cbSaleStatus.SelectedItem.ToString();
                cSales.Modify_Sale(oSale);
            }

            this.DialogResult = DialogResult.OK;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
