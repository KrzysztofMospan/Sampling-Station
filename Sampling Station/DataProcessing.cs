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

        private bool Slice_Mask(string input_nsmask)
        {
            input_smask = input_nsmask.Split(separator);

            if (input_smask.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<double[]> Slice_Input(string input)
        {
            List<double[]> output = new List<double[]>();
            double[] temp = new double[2];
            string[] input_sliced = input.Split(separator);
            for (int n = 0; n < input_sliced.Length; n += 2)
            {
                try
                {
                    temp[0] = Double.Parse(input_sliced[n]);
                    temp[1] = Double.Parse(input_sliced[n + 1]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Double parsing error!");
                }
                output.Add(temp);
            }
            return output;
        }

        private Dictionary<string, double[]> Interpret()
        {
            return null;
        }
    }
}
