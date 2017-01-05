﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sampling_Station
{
    class ChartingFlow
    {
        FlowLayoutPanel panel;
        Dictionary<string, Chart> charts = new Dictionary<string, Chart>();

        private int chartHeight, chartWidth;

        public ChartingFlow(FlowLayoutPanel flowlayoutpanel, int Height=100, int Width=100)
        {
            panel = flowlayoutpanel;
            chartHeight = Height;
            chartWidth = Width;
        }

        ~ChartingFlow()
        {

        }

        public void CreateCharts(string[] input_smask)
        {
            foreach(string title in input_smask)
            {
                Chart chart = new Chart();
                ChartArea chartArea1 = new ChartArea();
                Series series1 = new Series();

                chart.Titles.Add(title);
                chartArea1.Name = "ChartArea1";
                chart.ChartAreas.Add(chartArea1);
                chart.Location = new System.Drawing.Point(3, 3);
                chart.Name = "chart1";
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                series1.IsVisibleInLegend = false;
                series1.Legend = "Legend1";
                series1.Name = "Series1";
                chart.Series.Add(series1);
                chart.Size = new System.Drawing.Size(chartWidth, chartHeight);
                chart.TabIndex = 0;
                chart.Text = "chart1";

                panel.Controls.Add(chart);

                charts.Add(title, chart);
            }
        }

        public void UpdateCharts(int packet_number, Dictionary<string, double> values)
        {
            foreach(Chart chart in charts.Values)
            {
                chart.Series.First().Points.AddXY(packet_number, values[chart.Titles.First().ToString()]);
            }
        }
    }
}
