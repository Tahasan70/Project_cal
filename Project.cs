using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        private void Calculate(string operation)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double result = 0;

                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                lblResult.Text = "Result: " + result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
