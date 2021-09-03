using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace punchMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //	select finn_count,  rainer_count,  both_count from dbo.doors_programmed_to_machine where date_sent = '20210730'
            fillPieChart();
        }

        private void fillPieChart()
        {
            string startdate = DateTime.Now.ToString("YYYYMMDD");
            string finn = "", rainer = "", both = "";

            SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select COALESCE(finn_count,0),  COALESCE(rainer_count,0),  COALESCE(both_count ,0) from dbo.doors_programmed_to_machine where date_sent = CAST(getdate() as date)", conn);
            

         

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                finn = reader[0].ToString();
                rainer = reader[1].ToString();
                both = reader[2].ToString();

            }




           
          


            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            try
            {
                pieChart1.Series = new SeriesCollection
                {

                    new PieSeries
                        {
                            Title = "Finn",
                            Values = new ChartValues<double> { Convert.ToDouble(finn) },
                            PushOut = 15,
                            DataLabels = true,
                            LabelPoint = labelPoint,

                        },
                    new PieSeries
                        {
                            Title = "Yawei",
                            Values = new ChartValues<double> { Convert.ToDouble(rainer) },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        },

                    new PieSeries
                        {
                            Title = "Both",
                            Values = new ChartValues<double> { Convert.ToDouble(both) },
                            DataLabels = true,
                            LabelPoint = labelPoint
                        },



                };



            pieChart1.LegendLocation = LegendLocation.Bottom;
            DefaultLegend customLegend = new DefaultLegend();
            customLegend.BulletSize = 40;
            customLegend.FontSize = 40;
            //customLegend.Foreground = Brushes.White;
            customLegend.Orientation = System.Windows.Controls.Orientation.Horizontal;

            pieChart1.DefaultLegend = customLegend;

            }
            catch
            { }




            conn.Close();



            Func<ChartPoint, string> labelPoint2 = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            try
            {
                pieChart2.Series = new SeriesCollection
                {

                    new PieSeries
                        {
                            Title = " ",
                            Values = new ChartValues<double> { 6 },
                            PushOut = 15,
                            DataLabels = true,
                            LabelPoint = labelPoint2,

                        },
                    new PieSeries
                        {
                            Title = "TARGET",
                            Values = new ChartValues<double> { 4 },
                            DataLabels = true,
                            LabelPoint = labelPoint2
                        },
                    //new PieSeries
                    //    {
                    //        Title = "Both",
                    //        Values = new ChartValues<double> { Convert.ToDouble(both) },
                    //        DataLabels = true,
                    //        LabelPoint = labelPoint
                    //    },

                };
                pieChart2.LegendLocation = LegendLocation.Bottom;
                DefaultLegend customLegend = new DefaultLegend();
                customLegend.BulletSize = 0;
                customLegend.FontSize = 40;
                //customLegend.Foreground = Brushes.White;
                customLegend.Orientation = System.Windows.Controls.Orientation.Horizontal;

                pieChart2.DefaultLegend = customLegend;

            }
            catch
            { }

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            fillPieChart();
        }
    }
}
