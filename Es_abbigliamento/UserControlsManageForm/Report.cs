using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace Es_abbigliamento.UserControlsManageForm
{
    /// <summary>
    /// Report page.
    /// </summary>
    public partial class Report : UserControl
    {
        // Control report : in this control there re statistics about your stock
        // In this control the graphs are create with livecharts pack. ==> https://lvcharts.net/

        //Global variables
        Dictionary<string, double> data = new Dictionary<string, double>()
        {
            {"Bags", 0 },
            {"Jackets", 0 },
            {"Shoes", 0 },
            {"Sweaters", 0 },
            {"Trousers", 0 }
        };

        /// <summary>
        /// Constuctor
        /// </summary>
        public Report()
        {
            InitializeComponent();

            //save number of garment for each type
            foreach (var garment in ClassData.readGarmentDataFromStock())
            {
                switch (garment.garmentClassTypeString)
                {
                    case "Bag":
                        data["Bags"]++;
                        break;
                    case "Jackets":
                        data["Jackets"]++;
                        break;
                    case "Shoe":
                        data["Shoes"]++;
                        break;
                    case "Sweater":
                        data["Sweaters"]++;
                        break;
                    case "Trousers":
                        data["Trousers"]++;
                        break;
                }
            }
        }

        //On control load manage pie.
        private void Report_Load(object sender, EventArgs e)
        {

            try
            {
                manageCharts();
            }
            catch (Exception)
            {
                new WarningForm("Errore", "Problema con il caricamento della pagina!");
            }
            
        }

        //Function for manage graph load
        private void manageCharts()
        {
            pieChartDesign();

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("");

            SeriesCollection piechartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Bags",
                    Values = new ChartValues<double> {data["Bags"]},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.OrangeRed
                },
                new PieSeries
                {
                    Title = "Jackets",
                    Values = new ChartValues<double> {data["Jackets"] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.MediumPurple
                },
                new PieSeries
                {
                    Title = "Shoes",
                    Values = new ChartValues<double> {data["Shoes"] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.DodgerBlue
                },
                new PieSeries
                {
                    Title = "Sweaters",
                    Values = new ChartValues<double> {data["Sweaters"] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Gold
                },
                new PieSeries
                {
                    Title = "Trousers",
                    Values = new ChartValues<double> {data["Trousers"] },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Green
                }
            };

            garmentPie.Series = piechartData;
        }

        //Function for set the style properties of pieChart
        private void pieChartDesign()
        {
            garmentPie.AnimationsSpeed = TimeSpan.Zero;
            garmentPie.DisableAnimations = true;
            garmentPie.Visible = true;
            garmentPie.HoverPushOut = 3;

            garmentPie.LegendLocation = LegendLocation.Right;
        }
    }
}