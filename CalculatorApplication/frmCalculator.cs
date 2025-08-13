using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApplication.CalculatorApplication;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(firstnumber.Text);
            num2 = Convert.ToDouble(secondnumber.Text);
            string selectedOperator = comboBox1.SelectedItem.ToString();
            switch (selectedOperator)
            {
                case "+":
                    cal.CalculateEvent = new CalculatorClass.Formula<double>(cal.GetSum);
                    answer.Text = cal.GetSum(num1, num2).ToString();
                    break;
                case "-":
                    cal.CalculateEvent = new CalculatorClass.Formula<double>(cal.GetDifference);
                    answer.Text = cal.GetDifference(num1, num2).ToString();
                    break;
                case "*":
                    cal.CalculateEvent = new CalculatorClass.Formula<double>(cal.GetProduct);
                    answer.Text = cal.GetProduct(num1, num2).ToString();
                    break;
                case "/":
                    cal.CalculateEvent = new CalculatorClass.Formula<double>(cal.GetQuotient);
                    answer.Text = cal.GetQuotient(num1, num2).ToString();
                    break;

            }
        }
    }
}

