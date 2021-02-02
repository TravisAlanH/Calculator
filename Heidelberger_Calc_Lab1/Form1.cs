using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heidelberger_Calc_Lab1
{
    public partial class Form1 : Form
    {

        string userInput = string.Empty;
        string operationOne = string.Empty;
        string operationTwo = string.Empty;
        char operationType;
        double results = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "0";
            txtInputOutput.Text += userInput;
        }

        private void one_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "1";
            txtInputOutput.Text += userInput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "2";
            txtInputOutput.Text += userInput;
        }

        private void three_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "3";
            txtInputOutput.Text += userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "4";
            txtInputOutput.Text += userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "5";
            txtInputOutput.Text += userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "6";
            txtInputOutput.Text += userInput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "7";
            txtInputOutput.Text += userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += "8";
            txtInputOutput.Text += userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += 
                "9";
            txtInputOutput.Text += userInput;
        }

        private void dec_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            userInput += ".";
            txtInputOutput.Text += userInput;
        }

        private void posNeg_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = String.Empty;
            double number;
            double.TryParse(userInput, out number);
            number = number * -1;
            userInput = number.ToString();
            txtInputOutput.Text = userInput;

        }

        private void multipy_Click(object sender, EventArgs e)
        {
            operationOne = userInput;
            operationType = '*';
            userInput = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operationOne = userInput;
            operationType = '/';
            userInput = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operationOne = userInput;
            operationType = '-';
            userInput = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operationOne = userInput;
            operationType = '+';
            userInput = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            operationTwo = userInput;
            double numOne, numTwo;
            double.TryParse(operationOne, out numOne);
            double.TryParse(operationTwo, out numTwo);

            if (operationType == '+')
            {
                results = numOne + numTwo;
                txtInputOutput.Text = results.ToString();
            }
            else if(operationType == '-')
            {
                results = numOne - numTwo;
                txtInputOutput.Text = results.ToString();
            }
            else if (operationType == '*')
            {
                results = numOne * numTwo;
                txtInputOutput.Text = results.ToString();
            }
            else if (operationType == '/')
            {
                if (numTwo != 0)
                {
                    results = numOne - numTwo;
                    txtInputOutput.Text = results.ToString();
                }
                else
                {
                    txtInputOutput.Text = "cannot div by 0";
                }
            }
            else if (operationType == 's')
            {
                results = Math.Pow(numOne, numTwo);
                txtInputOutput.Text = results.ToString();
            }
            userInput = results.ToString();
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = string.Empty;
            operationOne = string.Empty;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = string.Empty;
            userInput = string.Empty;
            operationOne = string.Empty;
            operationTwo = string.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (userInput.Length == 0)
            {
                txtInputOutput.Text = userInput;
            }
            else
            {
                txtInputOutput.Text = string.Empty;
                userInput = userInput.Remove(userInput.Length - 1, 1);
                txtInputOutput.Text = userInput;
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(userInput, out number);
            txtInputOutput.Text = "";
            number = Math.Sqrt(number);
            userInput = number.ToString();
            txtInputOutput.Text = userInput;
        }

        private void xPowTwo_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(userInput, out number);
            txtInputOutput.Text = "";
            number = number * number;
            userInput = number.ToString();
            txtInputOutput.Text = userInput;
        }

        private void xPowY_Click(object sender, EventArgs e)
        {
            operationOne = userInput;
            operationType = 's';
            userInput = string.Empty;
        }

        private void oneDivX_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = string.Empty;
            double number;
            double.TryParse(userInput, out number);
            number = 1 / number;
            userInput = number.ToString();
            txtInputOutput.Text = userInput;
        }
    }
}
