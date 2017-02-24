using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DateTime currentTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            label2.Text = currentTime.ToString("h:mm:ss tt");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            double upDownValue = Convert.ToDouble(numericUpDown1.Value);
            upDownValue = Math.Round(upDownValue, 1);
            label1.Text = "" + upDownValue;
            currentTime = currentTime.AddMinutes(upDownValue);
            label2.Text = currentTime.ToString("h:mm:ss tt");
        }
    }
}
