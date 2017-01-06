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

        //ChartingFlow chartingflow = new ChartingFlow(ChartsPanel);

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

        }

        private void DataTransferStartButton_Click(object sender, EventArgs e)
        {

        }

        private void newConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
