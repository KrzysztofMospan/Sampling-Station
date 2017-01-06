using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Sampling_Station
{
    public class COM_DataInterface : DataProcessing
    {
        private SerialPort sp = new SerialPort();
        private ChartingFlow cf;

        private int packet_number;

        public COM_DataInterface(ChartingFlow chartingflow)
        {
            packet_number = 1;
            cf = chartingflow;
            sp.DataReceived += new SerialDataReceivedEventHandler(DataRXHandler);
        }

        ~COM_DataInterface()
        {
            if (sp.IsOpen) try
                {
                    sp.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Serial port in COM_DataInterface destructor error!");
                }
        }

        private void DataRXHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            SerialPort sp_local = (SerialPort)sender;
            string input = sp_local.ReadLine();
            cf.UpdateCharts(packet_number, GroupToUpdate(Slice_Input(input)));
            packet_number++;
        }

        public void SerialSetUp(int baud_rate, string port_name, Parity parity, StopBits stopbits, bool rts, bool dtr, int time_out)
        {
            sp.BaudRate = baud_rate;
            sp.PortName = port_name;
            sp.Parity = parity;
            sp.StopBits = stopbits;
            sp.RtsEnable = rts;
            sp.DtrEnable = dtr;
            sp.ReadTimeout = time_out;
        }

        public void SerialStart()
        {
            try
            {
                sp.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Serial port opne operation error!");
            }
        }

        public void SerialStop()
        {
            try
            {
                sp.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Serial port close operation error!");
            }
        }
    }
}
