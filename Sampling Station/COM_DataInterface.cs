using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Sampling_Station
{
    class COM_DataInterface : DataProcessing
    {
        private SerialPort sp = new SerialPort();

        private int packet_numer;

        public COM_DataInterface()
        {
            packet_numer = 0;
        }

        ~COM_DataInterface()
        {

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
