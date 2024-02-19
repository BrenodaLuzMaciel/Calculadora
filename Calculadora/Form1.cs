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

        List<string> list = new List<string>();
        double num2 = 0.0;
        double result = 0.0;
        string option = string.Empty;
        string total = string.Empty;



        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDividir.Text;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnMultiplicar.Text;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSubtrair.Text;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnIgual.Text;
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnVirg.Text;
        }

        private void btnLimpa1_Click(object sender, EventArgs e)
        {
            string apagar = txtDisplay.Text;
            apagar = apagar.Remove(apagar.Length - 1);
            txtDisplay.Text = apagar;
        }
    }
}
