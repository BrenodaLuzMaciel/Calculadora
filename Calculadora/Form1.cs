using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        double num1 = 0.0;
        double num2 = 0.0;
        string resultado = string.Empty;
        string opcao = string.Empty;



        private void btn1_Click(object sender, EventArgs e)
        {

            txtDisplay.Text += "1";
            txtTotal.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            txtTotal.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            txtTotal.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            txtTotal.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            txtTotal.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            txtTotal.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            txtTotal.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            txtTotal.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            txtTotal.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            txtTotal.Text += "0";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
            txtTotal.Text += ",";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            txtDisplay.Clear();
            txtTotal.Text += "/";
            opcao = "/";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            txtDisplay.Clear();
            txtTotal.Text += "*";
            opcao = "*";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            txtDisplay.Clear();
            txtTotal.Text += "-";
            opcao = "-";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            txtDisplay.Clear();
            txtTotal.Text += "+";
            opcao = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            switch (opcao)
            {
                case "+":
                    resultado = (num1 + num2).ToString();
                    break;
                case "-":
                    resultado = (num1 - num2).ToString();
                    break;
                case "/":
                    resultado = (num1 / num2).ToString();
                    break;
                case "*":
                    resultado = (num1 * num2).ToString();
                    break;
            }

            txtDisplay.Clear();
            txtDisplay.Text = "=";

            resultado.ToString();
            txtTotal.Text = txtTotal.Text + "=" + resultado.ToString(CultureInfo.InvariantCulture);
            txtDisplay.Text = resultado.ToString(CultureInfo.InvariantCulture);

        }

        private void btnLimpa1_Click(object sender, EventArgs e)
        {   
            string apagar = txtTotal.Text;
            apagar = apagar.Remove(apagar.Length - 1);
            txtTotal.Text = apagar;

            string apagar2 = txtDisplay.Text;
            apagar2 = apagar2.Remove(apagar2.Length - 1);
            txtDisplay.Text = apagar2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtTotal.Clear();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
