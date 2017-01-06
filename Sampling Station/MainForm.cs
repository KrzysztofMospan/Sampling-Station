using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Sampling_Station
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ChartingFlow chartingflow;
        COM_DataInterface com_datainterface;

        public void configured(bool state)
        {
            if (state)
            {
                DataTransferStartButton.Enabled = true;
                //DataTransferStopButton.Enabled = true;
                ChangeChartsSizeButton.Enabled = true;
            }
            else
            {
                DataTransferStartButton.Enabled = false;
                //DataTransferStopButton.Enabled = false;
                ChangeChartsSizeButton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartingflow = new ChartingFlow(ChartsPanel, 300, 300);
            com_datainterface = new COM_DataInterface(chartingflow);
            COMSettingsForm cw = new COMSettingsForm(this, com_datainterface);
            if (chartingflow.GetAreChartsCreated()) chartingflow.SetAreChartsCreated(false);
            cw.Show();
        }

        private void DataTransferStartButton_Click(object sender, EventArgs e)
        {
            if (!chartingflow.GetAreChartsCreated()) chartingflow.CreateCharts(com_datainterface.getSlicedMask());
            else chartingflow.ClearChartsPoints();
            com_datainterface.SerialStart();
            DataTransferStartButton.Enabled = false;
            DataTransferStopButton.Enabled = true;
        }

        private void newConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DataTransferStopButton_Click(object sender, EventArgs e)
        {
            com_datainterface.SerialStop();
            DataTransferStopButton.Enabled = false;
            DataTransferStartButton.Enabled = true;
        }

        private void ChangeChartsSizeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
