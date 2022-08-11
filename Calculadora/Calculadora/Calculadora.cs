using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""){
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe uma operação a ser realizada!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""){
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe uma operação a ser realizada!");
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""){
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe uma operação a ser realizada!");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""){
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe uma operação a ser realizada!");
            }
        }
        


    }
}
