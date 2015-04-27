using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchBillCalculator
{
    public partial class lunchBillCalculatorApp : Form
    {

        private double riceUnit;
        private double fishUnit;
        private double meatUnit;

        private double discount;
        private double vatValue;
        private double gross; 
        private double vatPercentage = 0.05;
        
        private double riceUnitPrice = 20;
        private double fishUnitPrice = 80;
        private double meatUnitPrice = 100;

        private double riceTotalPrice;
        private double fishTotalPrice;
        private double meatTotalPrice;
        private double totalBill;
        private double vatAmount;
        private double discountAmount;
        
        public lunchBillCalculatorApp()
        {
            InitializeComponent();
        }


        private void showTotalButton_Click(object sender, EventArgs e)
        {
            riceUnit = double.Parse(riceUnitTextBox.Text);
            riceTotalPrice = riceUnit * riceUnitPrice;


            fishUnit = double.Parse(fishUnitTextBox.Text);
            fishTotalPrice = fishUnit * fishUnitPrice;

            meatUnit = double.Parse(meatUnitTextBox.Text);
            meatTotalPrice = meatUnit*meatUnitPrice;

            gross = riceTotalPrice + fishTotalPrice + meatTotalPrice;

            totalGrossTextBox.Text = gross.ToString();

            totalGrossTextBox.Enabled = false;


        }

        private void showNetBillButton_Click(object sender, EventArgs e)
        {
            

            gross = double.Parse(totalGrossTextBox.Text);
            discount = double.Parse(discountTextBox.Text);

            discountAmount = gross*discount/100;

             vatAmount = gross*vatPercentage;

             totalBill = (gross - discountAmount) + vatAmount;


            MessageBox.Show("Sir,Please pay the bill of amount : " +totalBill+ " tk to the Shopkeeper.");

            riceUnitTextBox.Text = "";
            fishUnitTextBox.Text = "";
            meatUnitTextBox.Text = "";

            discountTextBox.Text = "";
            totalGrossTextBox.Text = "";



        }
    }
}
