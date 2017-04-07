using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp

    // This program was written by Gail Mosdell (Modified by Nicholas Watt)
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {
        // array used to store const doubles
        double[] convert_Data = new double[5] { 0.3937, 3.28084, 32, 0.0328, 0.621371 };

        public frm_Main()
        {
            InitializeComponent();
        }

        // Provided Global Variables and Constants
        double dbl_UofM, dbl_Convert;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Convert_to_CMtoI()
        {
            // validate user entry and convert to a double
            if (!double.TryParse(tb_CM_to_Inches.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please enter a valid number of Centimetres.");
                tb_CM_to_Inches.Clear();
                tb_CM_to_Inches.Focus();
            }
            else
            {
                dbl_Convert = dbl_UofM * convert_Data[0];
                lb_Convert.Items.Add(dbl_Convert + " Inches");
            }
        }
        private void Convert_M_to_Feet()
        {
            // validate user entry and convert to a double
            if (!double.TryParse(tb_M_to_Feet.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please enter a valid number of Metres.");
                tb_M_to_Feet.Clear();
                tb_M_to_Feet.Focus();
            }
            else
            {
                dbl_Convert = dbl_UofM * convert_Data[1];
                lb_Convert.Items.Add(dbl_Convert + " Feet");
            }
        }
        private void Convert_Cel_to_Fah()
        {
            // validate user entry and convert to a double
            if (!double.TryParse(tb_Cel_to_Fah.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please enter a valid degree of Celsius.");
                tb_Cel_to_Fah.Clear();
                tb_Cel_to_Fah.Focus();
            }
            else
            {
                dbl_Convert = dbl_UofM  * 9 / 5 + convert_Data[2];
                lb_Convert.Items.Add(dbl_Convert + " Fahrenheit");
            }
        }
        private void Convert_CM_to_Feet()
        {
            // validate user entry and convert to a double
            if (!double.TryParse(tb_CM_to_Feet.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please enter a valid number of Centimetres.");
                tb_CM_to_Feet.Clear();
                tb_CM_to_Feet.Focus();
            }
            else
            {
                dbl_Convert = dbl_UofM * convert_Data[3];
                lb_Convert.Items.Add(dbl_Convert + " Feet");
            }
        }
        private void Convert_KM_TO_Miles()
        {
            // validate user entry and convert to a double
            if (!double.TryParse(tb_KM_to_Miles.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please enter a valid number of Kilometres.");
                tb_KM_to_Miles.Clear();
                tb_KM_to_Miles.Focus();
            }
            else
            {
                dbl_Convert = dbl_UofM * convert_Data[4];
                lb_Convert.Items.Add(dbl_Convert + " Miles");
            }
        }
        // Displays all conversions in a listbox
        private void btn_ConvertAll_Click(object sender, EventArgs e)
        {
            lb_Convert.Items.Clear();

            Convert_to_CMtoI();
            Convert_M_to_Feet();
            Convert_Cel_to_Fah();
            Convert_CM_to_Feet();
            Convert_KM_TO_Miles();
        }
    }
}
