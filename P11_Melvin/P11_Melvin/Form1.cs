using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_Melvin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Delegates
        delegate double Addition(double a, double b);
        public double Add(double a, double b) { return a + b; }

        delegate double Multiply(double x, double y);
        public double Multi(double x, double y) { return x * y; }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double input1, input2;
                if (!double.TryParse(txt1.Text, out input1) || !double.TryParse(txt2.Text, out input2))
                {
                    //failed
                    MessageBox.Show("Invalid input. Please enter numbers!");
                    return; 
                }

                //Method portion
                input1 = double.Parse(txt1.Text);
                input2 = double.Parse(txt2.Text);

                Addition operation1 = Add;
                double result = operation1(input1, input2);

                string output = result.ToString();

                lblOutput.Text = output;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


            private void btnMultiply_Click(object sender, EventArgs e)
            {
                try
                {

                double input1, input2;

                    if (!double.TryParse(txt1.Text, out input1) || !double.TryParse(txt2.Text, out input2))
                    {
                        MessageBox.Show("Invalid input. Please enter numbers!");
                        return;
                    }

                input1 = double.Parse(txt1.Text);
                input2 = double.Parse(txt2.Text);
                
                Multiply operation2 = Multi;
                double result = operation2(input1, input2);

                string output = result.ToString();

                lblOutput.Text = output;

            }
            catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
    }
}
