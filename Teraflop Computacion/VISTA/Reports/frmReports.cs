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
        public void countSalesMonth()
        {
            string[] arrayMonth;
            int totalSale;
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                arrayMonth = row.Cells["Date"].Value.ToString().Split('-');
                totalSale = Convert.ToInt32(row.Cells["Total"].Value);
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

            #region Test code
            //string[] series = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //int[] puntos = { contEnero, contFebrero, contMarzo, contAbril, contMayo, contJunio, contJulio, contAgosto, contSeptiembre, contOctubre, contNoviembre, contDiciembre };
            /*
            //grReportSales.Titles.Clear();
            //grReportSales.Series.Clear();
            //grReportSales.ChartAreas.Clear();
            for (int i = 0; i < series.Length; i++)
            {
                // Configuramos las series
                Series serie = new Series(series[i]);
                serie.ChartType = SeriesChartType.Line;

                // Configuramos los valores
                serie.XValueMember = "Sales";
                serie.YValueMembers = "Total";
                serie.IsValueShownAsLabel = true;
                grReportSales.Series.Add(serie);
            }
            Series serie1 = new Series("Enero");
            serie1.ChartType = SeriesChartType.Line;
            serie1.XValueMember = "Sales1";
            serie1.YValueMembers = "Total1";
            serie1.IsValueShownAsLabel = true;
            grReportSales.Series.Add(serie1);
            serie1.Points.Add(6);


            Series serie2 = new Series("Febrero");
            serie2.ChartType = SeriesChartType.Line;
            serie2.XValueMember = "Meses";
            serie2.YValueMembers = "Cantidad";
            serie2.IsValueShownAsLabel = true;
            grReportSales.Series.Add(serie2);
            serie2.Points.Add(3);
            //grReportSales.DataSource = dgvSales.DataSource;
            int cont = 0;
            foreach (var serie in grReportSales.Series)
            {
                if (cont < puntos.Length)
                {
                    serie.Label = puntos[cont].ToString();
                    serie.Points.Add(puntos[cont]);
                    cont++;
                }
            }*/

            // Ingresando los datos en el grafico
            /*
            for (int i = 0; i < puntos.Length; i++)
            {
                // Agregamos los titulos
                //Series serie = grReportSales.Series.Add(series[i]);

                // Agregamos los valores segun la cantidad
                //serie.Label = puntos[i].ToString();

                //serie.Points.Add(puntos[i]);
            }*/
            #endregion
        }
        #endregion

        private void frmReports_Load(object sender, EventArgs e)
        {
            Update_Datagrid();
            countSalesMonth();

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
                int[] puntos = { contEnero, contFebrero, contMarzo, contAbril, contMayo, contJunio, contJulio, contAgosto, contSeptiembre, contOctubre, contNoviembre, contDiciembre };

                foreach (var year in years)
                {
                    List<double> values = new List<double>();
                    for (int i = 0; i < puntos.Length; i++)
                    {
                        values.Add(puntos[i]);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
                }
                cartesianChart1.Series = series;

                #region Test code
                // Cambiamos el color
                //grReportSales.Palette = ChartColorPalette.Excel;

                // Agregamos el area de la grafica
                // ChartArea areaGrafico = new ChartArea();
                // areaGrafico.Area3DStyle.Enable3D = true;
                //grReportSales.ChartAreas.Add(areaGrafico);

                // Cambiamos y configuramos el titulo
                //Title titulo = new Title("Months of highest sales");
                //titulo.Font = new Font("Alata", 11, FontStyle.Regular);
                //grReportSales.Titles.Add(titulo);
                #endregion
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
