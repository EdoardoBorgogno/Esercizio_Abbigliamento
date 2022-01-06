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
        List<Garment> garmentsList;

        /// <summary>
        /// Constuctor
        /// </summary>
        public Report()
        {
            InitializeComponent();

            garmentsList = ClassData.readGarmentDataFromStock();

            if(garmentsList.Count == 0)
            {
                this.Controls.Clear();
                this.Controls.Add(new noGarmentReport());
            }
            else
            {
                //save number of garment for each type
                foreach (var garment in garmentsList)
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
        }

        //On control load manage pie.
        private void Report_Load(object sender, EventArgs e)
        {

            try
            {
                managePanel();

                manageCharts();
            }
            catch (Exception)
            {
                new WarningForm("Errore", "Problema con il caricamento della pagina!");
            }
            
        }

        //Function for manage panel.
        private void managePanel()
        {
            numberGarment_lblNum.Text = (data["Bags"] + data["Jackets"] + data["Shoes"] + data["Sweaters"] + data["Trousers"]).ToString();

            bestBrand_lblNum.Text = searchBestBrand();

            string mediumPrice = (totalStockPrice() / garmentsList.Count).ToString("n2");
            mediumPrice_lblNum.Text = mediumPrice;
        }

        //Function for sum all price of garment in stock
        private double totalStockPrice()
        {
            double total = 0.0;

            foreach(var garment in garmentsList)
            {
                total += garment._garmentPrice;
            }

            return total;
        }

        //Function for search the most inserted brand
        private string searchBestBrand()
        {
            Dictionary<string, int> brandDic = new Dictionary<string, int>();

            string mostOccurance = string.Empty;

            foreach(var garment in garmentsList)
            {
                if (brandDic.ContainsKey(garment._garmentBrand))
                {
                    brandDic[garment._garmentBrand]++;
                }
                else
                {
                    brandDic.Add(garment._garmentBrand, 1);
                }
            }

            int max = 0;
            foreach(var item in brandDic)
            {
                if(item.Value > max)
                {
                    mostOccurance = item.Key;
                    max = item.Value;
                }
            }

            return mostOccurance;
        }

        //Function for manage graph load
        private void manageCharts()
        {
            pieChartDesign();
            solidGaugeDesign();

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

        //Function for set the style properties of solid gauge
        private void solidGaugeDesign()
        {
            solidGauge.From = 0;
            solidGauge.To = 10;
            solidGauge.Value = 0;
            solidGauge.Visible = true;

            solidGauge.Base.GaugeActiveFill = System.Windows.Media.Brushes.OrangeRed;
        }

        //Function for search the highest price in list
        private double maxPriceAllGarments()
        {
            double maxPrice = 0;

            foreach(var garment in garmentsList)
            {
                if(garment._garmentPrice > maxPrice)
                {
                    maxPrice = garment._garmentPrice; 
                }
            }

            return Math.Round(maxPrice);
        }

        //Function for set the style properties of pieChart
        private void pieChartDesign()
        {
            garmentPie.AnimationsSpeed = TimeSpan.Zero;
            garmentPie.DisableAnimations = true;
            garmentPie.Visible = true;
            garmentPie.HoverPushOut = 3;

            garmentPie.LegendLocation = LegendLocation.Top;
        }

        //Function for change the data in solid gauge
        private void cmbTypeSolidGauge_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = 0;
            int countGarment = 0;
            double max = 0;

            foreach(var garment in garmentsList)
            {
                string typeOfGarment = cmbTypeSolidGauge.SelectedItem.ToString();
                if (garment.garmentClassTypeString == typeOfGarment)
                {
                    total += garment._garmentPrice;
                    countGarment++;

                    if (garment._garmentPrice > max)
                        max = garment._garmentPrice;
                }
            }
        
            solidGauge.Value = Math.Round(total / countGarment, 0);
            solidGauge.To = Math.Round(max, 0);
        }
    }
}