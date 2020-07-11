using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyblockEnchantCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture) * 160;
                double number2 = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                string result = calcProfits(number1, number2).ToString();
                if (number1 > number2)
                result = "-" + calcProfits(number1, number2).ToString();
                label1.Text = "You will make " + result + " coins of profit.";
            }catch(Exception ex2)
            {
                label1.Text = "Error";
                MessageBox.Show(ex2.Message, "Veks Bazaar Craft Calculator");
            } 
        }
        public double calcProfits(double nr1, double nr2)
        {
            return Math.Abs(nr1 - nr2);
        }
    }
}
