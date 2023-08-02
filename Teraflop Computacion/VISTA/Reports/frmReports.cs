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
        CONTROLADORA.Sales cSales;
        #endregion

        #region constructor
        public frmReports()
        {
            InitializeComponent();
            cSales = CONTROLADORA.Sales.Get_Instance();
        }
        #endregion

        #region methods
        public void Update_Datagrid()
        {
            dgvSales.DataSource = null;
            dgvSales.DataSource = cSales.Get_Sale();
        }
        public int[] GetSalesMonth(string year)
        {
            string myYear = year.Split('=')[1];
            myYear = myYear.Replace("}", "").Replace(" ", "");
            //MessageBox.Show("hola", myYear, MessageBoxButtons.OK);
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
                    Title = "Number of sales",
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
                    int[] puntos = GetSalesMonth(year.ToString());
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
    }
}
