using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
    static class Utils
    {
        public static void ShowErrorMessage(String errorDescription, string type)
        {
            if (type == "warning")
                System.Windows.Forms.MessageBox.Show(errorDescription, "Warning",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else if (type == "error")
                System.Windows.Forms.MessageBox.Show(errorDescription, "Error",
                            System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            else
                System.Windows.Forms.MessageBox.Show("Wrong type of message!", "Error",
                            System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        // Amount of points
        public static int GetCountOfPoints(string min, string max, string step)
        {
            return (int)((Convert.ToDouble(max) - Convert.ToDouble(min)) / Convert.ToDouble(step));
        }
    }
}
