using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
       
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox3.Text == "0") || (isOperationPerformed))
                maskedTextBox3.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!maskedTextBox3.Text.Contains("."))
                    maskedTextBox3.Text = maskedTextBox3.Text + button.Text;
            }
            else
                maskedTextBox3.Text = maskedTextBox3.Text + button.Text;
           
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0 )
            {
                button.PerformClick();
                operationPerformed = button.Text;
                label1.Text = resultValue + " " +
                    operationPerformed;
                isOperationPerformed = true; 



            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(maskedTextBox3.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }

           
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            maskedTextBox3.Text = "0";
            resultValue = 0;

        }

     

        private void Button16_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    maskedTextBox3.Text = (resultValue + double.Parse(maskedTextBox3.Text)).ToString();
                    break;
                case "-":
                    maskedTextBox3.Text = (resultValue - double.Parse(maskedTextBox3.Text)).ToString();
                    break;
                case "/":
                    maskedTextBox3.Text = (resultValue / double.Parse(maskedTextBox3.Text)).ToString();
                    break;
                case "*":
                    maskedTextBox3.Text = (resultValue * double.Parse(maskedTextBox3.Text)).ToString();
                    break;
                case "%":
                    maskedTextBox3.Text = (resultValue / 100).ToString();
                    break;
                default:
                    break;
            }

            resultValue = double.Parse(maskedTextBox3.Text);
            label1.Text = "";
        }
    }
}
