using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sampling_Station
{
    public class DataProcessing
    {
        private char separator;
        private string[] input_smask; // input sliced mask

        public DataProcessing()
        {
            separator = ','; // Default separator 
        }

        ~DataProcessing()
        {

        }

        public void SetSeparator(char separator_local)
        {
            separator = separator_local;
        }

        public void Slice_Mask(string input_nsmask)
        {
            input_smask = input_nsmask.Split(separator);
        }

        public string[] getSlicedMask()
        {
            return input_smask;
        }

        public List<double> Slice_Input(string input)
        {
            List<double> output = new List<double>();
            string[] sliced_input = input.Split(separator);
            double temp = new double();
            foreach (string slice in sliced_input)
            {
                try
                {
                    temp = Double.Parse(slice);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Double parsing error!");
                }
                output.Add(temp);
            }
            return output;
        }

        public Dictionary<string, double> GroupToUpdate(List<double> value)
        {
            Dictionary<string, double> output = new Dictionary<string, double>();
            foreach(string title in input_smask)
            {
                output.Add(title, value[0]);
                value.RemoveAt(0);
            }
            return output;
        }
    }
}
