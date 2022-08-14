using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class RomanCalculator : Form
    {
        public RomanCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            resetControl();
            if (!String.IsNullOrEmpty(txtFirstNumber.Text) && !String.IsNullOrEmpty(txtSecondNumber.Text))
            {
                string firstRomanNumber = txtFirstNumber.Text;
                string secondRomanNumber = txtSecondNumber.Text;

                string sum = RomanNumberCalculator.CalculateSum(firstRomanNumber, secondRomanNumber);
                txtSum.Text = sum;
                if (txtSum.Text.Equals("INVALID"))
                    txtSum.ForeColor = Color.Red;
                else
                    txtSum.ForeColor = Color.Black;
            }
            else if(String.IsNullOrEmpty(txtFirstNumber.Text) && String.IsNullOrEmpty(txtSecondNumber.Text))
            {
                lblFirstNumber.Text = "Please enter first number for addition";
                lblSecondNumber.Text = "Please enter second number for addition";
            }
            else if(String.IsNullOrEmpty(txtFirstNumber.Text))
            {
                lblFirstNumber.Text = "Please enter first number for addition";
            }
            else
            {
                lblSecondNumber.Text = "Please enter second number for addition";
            }
        }
        private void resetControl()
        {
            lblFirstNumber.Text = "";
            lblSecondNumber.Text = "";
            txtSum.Text = "";
        }
    }
}
