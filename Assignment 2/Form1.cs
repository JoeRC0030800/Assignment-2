using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);

                double TotalResistance = R1 + R2;

                label1.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox3.Text);
                double R2 = Convert.ToDouble(textBox4.Text);
                double R3 = Convert.ToDouble(textBox5.Text);

                double TotalResistance = R1 + R2 + R3;

                label7.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
            

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox6.Text);
                double R2 = Convert.ToDouble(textBox7.Text);
                double R3 = Convert.ToDouble(textBox8.Text);
                double R4 = Convert.ToDouble(textBox9.Text);

                double TotalResistance = R1 + R2 + R3 + R4;

                label12.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox10.Text);
                double R2 = Convert.ToDouble(textBox11.Text);
                double R3 = Convert.ToDouble(textBox12.Text);
                double R4 = Convert.ToDouble(textBox13.Text);
                double R5 = Convert.ToDouble(textBox14.Text);

                double TotalResistance = R1 + R2 + R3 + R4 + R5;

                label18.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
           

         }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox15.Text);
                double R2 = Convert.ToDouble(textBox16.Text);

                double Resistance = (1 / R1) + (1 / R2);
                double TotalResistance = (1 / Resistance);
                

                label21.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox17.Text);
                double R2 = Convert.ToDouble(textBox18.Text);
                double R3 = Convert.ToDouble(textBox19.Text);

                double Resistance = (1 / R1) + (1 / R2) + (1 / R3);
                double TotalResistance = (1 / Resistance);

                label25.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox20.Text);
                double R2 = Convert.ToDouble(textBox21.Text);
                double R3 = Convert.ToDouble(textBox22.Text);
                double R4 = Convert.ToDouble(textBox23.Text);

                double Resistance = (1 / R1) + (1 / R2) + (1 / R3) + (1 / R4);
                double TotalResistance = (1 / Resistance);

                label30.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox24.Text);
                double R2 = Convert.ToDouble(textBox25.Text);
                double R3 = Convert.ToDouble(textBox26.Text);
                double R4 = Convert.ToDouble(textBox27.Text);
                double R5 = Convert.ToDouble(textBox28.Text);

                double Resistance = (1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5);
                double TotalResistance = (1 / Resistance);

                label36.Text = "Total Resistance =" + TotalResistance.ToString("0.00");
            }
            catch
            {

            }
        }
    }
}
