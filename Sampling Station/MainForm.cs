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
                DataTransferStopButton.Enabled = true;
            }
            else
            {
                DataTransferStartButton.Enabled = false;
                DataTransferStopButton.Enabled = false;
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
            COMSettingsWindows cw = new COMSettingsWindows(com_datainterface);
            cw.Show();
        }

        private void DataTransferStartButton_Click(object sender, EventArgs e)
        {
            chartingflow.CreateCharts(com_datainterface.getSlicedMask());
            com_datainterface.SerialStart();
        }

        private void newConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DataTransferStopButton_Click(object sender, EventArgs e)
        {
            com_datainterface.SerialStop();
        }
    }
}
