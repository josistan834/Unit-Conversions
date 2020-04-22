using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            try
            {
                num1 = Convert.ToDouble(inputBox.Text);
            }
            catch
            {
                outputBox.Text = "Please enter a valid number";
            }

            if (option1.Checked)
            {
                double num2 = ITC(num1);
                outputBox.Text = $"{num1} Inches = {num2} Centimeters";
            }
            else if (option2.Checked)
            {
                double num2 = FTC(num1);
                outputBox.Text = $"{num1} Feet = {num2} Centimeters";
            }
            else if (option3.Checked)
            {
                double num2 = YTM(num1);
                outputBox.Text = $"{num1} Yards = {num2} Meters";
            }
            else if (option4.Checked)
            {
                double num2 = MTK(num1);
                outputBox.Text = $"{num1} Miles = {num2} Kilometers";
            }
        }
        public static double ITC(double num1)
        {
            double output = num1 * 2.54;
            return output;
        }
        public static double FTC(double num1)
        {
            double output = num1 * 30.48;
            return output;
        }
        public static double YTM(double num1)
        {
            double output = num1 * 0.91;
            return output;
        }
        public static double MTK(double num1)
        {
            double output = num1 * 1.6;
            return output;
        }
    }
}
