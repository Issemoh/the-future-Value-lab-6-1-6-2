﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_future_value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvesment.Text);
            decimal yearlyInerestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInerestRate / 12 / 100;

            decimal futureValue = this.CalculateFutureValua(
                monthlyInvestment, monthlyInterestRate, months);
            
                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvesment.Focus();
            }
         private decimal CalculateFutureValua(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months)
            {
                decimal futureValue = 0m;
                for (int i = 0; i < months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment)
                                * (1 + monthlyInterestRate);
                }
            return futureValue;
            
           }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = ""; 
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtMonthlyInvesment.Clear();
            txtInterestRate.Clear();
            txtYears.Clear();
            txtFutureValue.Clear();
        }

        private void txtInterestRate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtInterestRate.Text = "12";
        }
    }  
}
