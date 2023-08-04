using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VISTA.Notifications;

namespace VISTA.Reports
{
    public partial class frmReports : Form
    {
        #region variables
        private CONTEXTO.TeraflopSystem ctxTeraflop;
        CONTROLADORA.Sales cSales;
        CONTROLADORA.Categories cCategories;
        CONTROLADORA.DetailSales cDetailSales;
        CONTROLADORA.Products cProducts;
        bool firstLoad = true;
        #endregion

        #region constructor
        public frmReports()
        {
            InitializeComponent();
            ctxTeraflop = CONTEXTO.TeraflopSystem.Get_Instance();
            cSales = CONTROLADORA.Sales.Get_Instance();
            cDetailSales = CONTROLADORA.DetailSales.Get_Instance();
            cCategories = CONTROLADORA.Categories.Get_Instance();
            cProducts = CONTROLADORA.Products.Get_Instance();
            Update_Combobox(); 
            Update_Datagrid();
        }
        #endregion

        #region methods
        private void Update_Datagrid_DetailSales(MODELO.Sale oSale)
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
        public void Update_Combobox()
        {
            cbCategories.DataSource = null;
            cbCategories.DataSource = cCategories.Get_Category();
            cbCategories.DisplayMember = "NameCategory";

            cbCategories.SelectedIndex = 0;
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Update_Datagrid()
        {
            dgvSales.DataSource = null;
            dgvSales.DataSource = cSales.Get_Sale();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = cProducts.Get_Product();
        }
        public int[] GetTotalSalesMonth(string year)
        {
            string myYear = year.Split('=')[1];
            myYear = myYear.Replace("}", "").Replace(" ", "");
            int contEnero = 0;
            int contFebrero = 0;
            int contMarzo = 0;
            int contAbril = 0;
            int contMayo = 0;
            int contJunio = 0;
            int contJulio = 0;
            int contAgosto = 0;
            int contSeptiembre = 0;
            int contOctubre = 0;
            int contNoviembre = 0;
            int contDiciembre = 0;
            string[] arrayMonth;
            int totalSale;
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                arrayMonth = row.Cells["Date"].Value.ToString().Split('-');
                totalSale = Convert.ToInt32(row.Cells["Total"].Value);
                if(myYear == arrayMonth[2].ToString())
                {
                    switch (arrayMonth[1])
                    {
                        case "01":
                            contEnero = contEnero + totalSale;
                            break;
                        case "02":
                            contFebrero = contFebrero + totalSale;
                            break;
                        case "03":
                            contMarzo = contMarzo + totalSale;
                            break;
                        case "04":
                            contAbril = contAbril + totalSale;
                            break;
                        case "05":
                            contMayo = contMayo + totalSale;
                            break;
                        case "06":
                            contJunio = contJunio + totalSale;
                            break;
                        case "07":
                            contJulio = contJulio + totalSale;
                            break;
                        case "08":
                            contAgosto = contAgosto + totalSale;
                            break;
                        case "09":
                            contSeptiembre = contSeptiembre + totalSale;
                            break;
                        case "10":
                            contOctubre = contOctubre + totalSale;
                            break;
                        case "11":
                            contNoviembre = contNoviembre + totalSale;
                            break;
                        case "12":
                            contDiciembre = contDiciembre + totalSale;
                            break;
                        default:
                            break;
                    }
                }
            }
            int[] puntos = { contEnero, contFebrero, contMarzo, contAbril, contMayo, contJunio, contJulio, contAgosto, contSeptiembre, contOctubre, contNoviembre, contDiciembre };
            return puntos;
        }
        #endregion

        private void frmReports_Load(object sender, EventArgs e)
        {
            Update_Datagrid();

            try
            {
                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Months",
                    FontSize = 16,
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                });
                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Total sales",
                    FontSize = 16,
                    LabelFormatter = value => value.ToString("C", new System.Globalization.CultureInfo("en-US"))
                }); 

                cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
                // Init data
                cartesianChart1.Series.Clear();

                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                var years = (from o in dgvSales.DataSource as List<MODELO.Sale>
                             select new { Year = o.Date.Split('-')[2] }).Distinct(); // Me quedo con el año

                // Productos de ejemplo
                /*
                 * 423765
                 * 758345
                 * 927384
                 */

                foreach (var year in years)
                {
                    int[] puntos = GetTotalSalesMonth(year.ToString());
                    List<double> values = new List<double>();
                    for (int i = 0; i < puntos.Length; i++)
                    {
                        values.Add(puntos[i]);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
                }
                cartesianChart1.Series = series;
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

        private void rbBestSellers_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBestSellers.Checked)
            {
                cbCategories.Visible = true;
                cartesianChart1.Visible = false;
                cartesianChart2.Visible = true;
                if(firstLoad == true)
                {
                    cartesianChart2.Series.Clear();
                    cartesianChart2.AxisX.Clear();
                    cartesianChart2.AxisY.Clear();
                    Get_Product_Category();
                    firstLoad = false;
                }
            }
        }

        private void rbTotalSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalSales.Checked)
            {
                cbCategories.Visible = false;
                cartesianChart2.Visible = false;
                cartesianChart1.Visible = true;
            }
        }

        private void Get_Product_Category()
        {
            try
            {
                cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Months",
                    FontSize = 16,
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                });
                cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Number of sales (total units)",
                    FontSize = 16,
                    LabelFormatter = value => value.ToString()
                });

                cartesianChart2.LegendLocation = LiveCharts.LegendLocation.Right;
                // Init data
                cartesianChart2.Series.Clear();

                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                var products = (from o in dgvProducts.DataSource as List<MODELO.Product>
                                select new { Name = o.Name, Category = o.oCategory.NameCategory }).Distinct();

                foreach (var product in products.ToArray())
                {
                    string myProduct = product.Name;
                    string myCategory = product.Category;
                    if (myCategory.ToString() == txtNameCategory.Text)
                    {
                        int[] puntos = GetUnitSales(myProduct.ToString(), myCategory.ToString());
                        List<double> values = new List<double>();
                        for (int i = 0; i < puntos.Length; i++)
                        {
                            values.Add(puntos[i]);
                        }
                        series.Add(new LineSeries() { Title = product.Name.ToString(), Values = new ChartValues<double>(values) });
                    }
                }
                cartesianChart2.Series = series;
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
        public int[] GetUnitSales(string myProduct, string myCategory)
        {
            
            int contEnero = 0;
            int contFebrero = 0;
            int contMarzo = 0;
            int contAbril = 0;
            int contMayo = 0;
            int contJunio = 0;
            int contJulio = 0;
            int contAgosto = 0;
            int contSeptiembre = 0;
            int contOctubre = 0;
            int contNoviembre = 0;
            int contDiciembre = 0;
            string[] arrayMonth;
            int totalSale;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                arrayMonth = row.Cells["Date"].Value.ToString().Split('-');

                MODELO.Sale oSale = (MODELO.Sale)row.DataBoundItem;
                int cod = (int)row.Cells["Cod_Sale"].Value;
                dgvDetailSales.DataSource = null;
                dgvDetailSales.DataSource =  ctxTeraflop.Get_Sale(cod);

                if(oSale.DetailSale != null)
                {
                    foreach (MODELO.DetailSale detailSale in oSale.DetailSale)
                    {
                        totalSale = detailSale.Amount;

                        if(detailSale.oProduct.oCategory.NameCategory.ToString() == myCategory && detailSale.oProduct.Name.ToString() == myProduct)
                        {
                            switch (arrayMonth[1])
                            {
                                case "01":
                                    contEnero = contEnero + totalSale;
                                    break;
                                case "02":
                                    contFebrero = contFebrero + totalSale;
                                    break;
                                case "03":
                                    contMarzo = contMarzo + totalSale;
                                    break;
                                case "04":
                                    contAbril = contAbril + totalSale;
                                    break;
                                case "05":
                                    contMayo = contMayo + totalSale;
                                    break;
                                case "06":
                                    contJunio = contJunio + totalSale;
                                    break;
                                case "07":
                                    contJulio = contJulio + totalSale;
                                    break;
                                case "08":
                                    contAgosto = contAgosto + totalSale;
                                    break;
                                case "09":
                                    contSeptiembre = contSeptiembre + totalSale;
                                    break;
                                case "10":
                                    contOctubre = contOctubre + totalSale;
                                    break;
                                case "11":
                                    contNoviembre = contNoviembre + totalSale;
                                    break;
                                case "12":
                                    contDiciembre = contDiciembre + totalSale;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            int[] puntos = { contEnero, contFebrero, contMarzo, contAbril, contMayo, contJunio, contJulio, contAgosto, contSeptiembre, contOctubre, contNoviembre, contDiciembre };
            return puntos;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            MODELO.Category oCategory;

            oCategory = (MODELO.Category)cbCategories.SelectedItem;
            txtNameCategory.Text = oCategory.NameCategory.ToString();

            if(rbBestSellers.Checked)
            {
                Get_Product_Category();
            }
            if(rbBestSellers.Checked && firstLoad == false )
            {
                cartesianChart2.Series.Clear();
                cartesianChart2.AxisX.Clear();
                cartesianChart2.AxisY.Clear();
                Get_Product_Category();
            }
        }
    }
}
