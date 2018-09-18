using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_win_CalculatorAss
{
    public partial class Form1 : Form
    {
        double Result = 0;
        string Operation;
        bool CalculationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox_result.Text = "0";

        }
       
        private void m(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") | CalculationPerformed)
            {
                textBox_result.Clear();
            }
            Button btn = sender as Button;
            this.textBox_result.Text += btn.Text;           
            CalculationPerformed = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Result = Convert.ToDouble(textBox_result.Text);
            Operation = btn.Text;
           
           CalculationPerformed = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Result = Convert.ToDouble(textBox_result.Text);
            Operation = btn.Text;
           
            CalculationPerformed = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Result = Convert.ToDouble(textBox_result.Text);
            Operation = btn.Text;
           
           CalculationPerformed = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Result = Convert.ToDouble(textBox_result.Text);
            Operation = btn.Text;
           
            CalculationPerformed = true;
        }

       

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            Result = 0;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
           
            switch (Operation)
            {
                case "+":                    
                    textBox_result.Text = (Result + Convert.ToDouble(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (Result - Convert.ToDouble(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (Result * Convert.ToDouble(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (Result / Convert.ToDouble(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {                     
                    this.textBox_result.Text += btn.Text;
                }
            }
            CalculationPerformed = false;
        }
    }
}
