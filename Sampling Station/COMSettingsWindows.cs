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
    public partial class COMSettingsWindows : Form
    {
        COM_DataInterface datainterface;
        public COMSettingsWindows(COM_DataInterface comdi)
        {
            datainterface = comdi;
            InitializeComponent();
            RefreshCOMComboBox(PortNameComboBox);
        }

        private void RefreshCOMComboBox(ComboBox combobox)
        {
            string[] coms = SerialPort.GetPortNames();
            combobox.Items.Clear();
            foreach(string name in coms)
            {
                combobox.Items.Add(name);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, Parity> Parity_dict = new Dictionary<string, Parity>();
            Parity_dict.Add("Even", Parity.Even);
            Parity_dict.Add("Mark", Parity.Mark);
            Parity_dict.Add("None", Parity.None);
            Parity_dict.Add("Odd", Parity.Odd);
            Parity_dict.Add("Space", Parity.Space);

            Dictionary<string, StopBits> StopBits_dict = new Dictionary<string, StopBits>();
            StopBits_dict.Add("None", StopBits.None);
            StopBits_dict.Add("1", StopBits.One);
            StopBits_dict.Add("1.5", StopBits.OnePointFive);
            StopBits_dict.Add("2", StopBits.Two);

            try
            {
                datainterface.SerialSetUp(Int32.Parse(BaudTextBox.Text), PortNameComboBox.Text, Parity_dict[ParityComboBox.Text], StopBits_dict[StopBitsComboBox.Text], RTSCheckBox.Enabled, DTRCheckBox.Enabled, Int32.Parse(TimeoutTextBox.Text));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error parsing serial port setting!");
            }

            try
            {
                datainterface.SetSeparator(Char.Parse(SeparatorTextBox.Text));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error parsing separator!");
            }

            datainterface.Slice_Mask(InputMaskTextBox.Text);
            
            COMSettingsWindows.ActiveForm.Close();
        }

        private void PortNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PortNameComboBox_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            COMSettingsWindows.ActiveForm.Close();
        }

        private void PortNameComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshCOMComboBox(PortNameComboBox);
        }
    }
}
