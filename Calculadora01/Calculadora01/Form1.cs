using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //pegar o valor do Fator1oNúmero e atribuir e, uma variável
            double n1 = double.Parse(tbxN1.Text);
            //pegar o valor do Fator2oNúmero e atribuir em uma variável
            double n2 = double.Parse(tbxN2.Text);
            //calcular soma
            double soma = n1 + n2;
            //exibir o resultado na caixa de texto tbnResultado
            tbxResultado.Text = soma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pegar o valor do Fator1oNúmero e atribuir e, uma variável
            double n1 = double.Parse(tbxN1.Text);
            //pegar o valor do Fator2oNúmero e atribuir em uma variável
            double n2 = double.Parse(tbxN2.Text);
            //calcular soma
            double soma = n1 + n2;
            //exibir o resultado na caixa de texto tbnResultado
            tbxResultado.Text = soma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pegar o valor do Fator1oNúmero e atribuir e, uma variável
            double n1 = double.Parse(tbxN1.Text);
            //pegar o valor do Fator2oNúmero e atribuir em uma variável
            double n2 = double.Parse(tbxN2.Text);
            //calcular subtração
            double dividir = n1 / n2;
            //exibir o resultado na caixa de texto tbnResultado
            tbxResultado.Text = dividir.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pegar o valor do Fator1oNúmero e atribuir e, uma variável
            double n1 = double.Parse(tbxN1.Text);
            //pegar o valor do Fator2oNúmero e atribuir em uma variável
            double n2 = double.Parse(tbxN2.Text);
            //calcular subtração
            double subtrair = n1 - n2;
            //exibir o resultado na caixa de texto tbnResultado
            tbxResultado.Text = subtrair.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pegar o valor do Fator1oNúmero e atribuir e, uma variável
            double n1 = double.Parse(tbxN1.Text);
            //pegar o valor do Fator2oNúmero e atribuir em uma variável
            double n2 = double.Parse(tbxN2.Text);
            //calcular multiplicar
            double multiplicar = n1 * n2;
            //exibir o resultado na caixa de texto tbnResultado
            tbxResultado.Text = multiplicar.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbxN1.Text = "";
            tbxN2.Text = "";
            tbxResultado.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Criar uma Janela que calcula o Juros Simples
            double Capital = double.Parse(txtCapital.Text);
            double Juros = double.Parse(txtTaxa.Text);
            double Tempo = double.Parse(txtTempo.Text);
            // calcular Capital * Taxa/100 * Tempo
            double calcular txtCapital * txtTaxa/100 * txtTempo;
            tbxResultado.Text = calcular.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Criar uma Janela que calcula o Juros Simples
            double Capital = double.Parse(txtCapital.Text);
            double Juros = double.Parse(txtTaxa.Text);
            double Tempo = double.Parse(txtTempo.Text);
            // calcular Capital * Taxa/100 * Tempo
            double calcular txtCapital* txtTaxa/ 100 * txtTempo;
            tbxResultado.Text = calcular.ToString();
        }

        private void Capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {
            //Criar uma Janela que calcula o Juros Simples
            double Capital = double.Parse(txtCapital.Text);
            double Juros = double.Parse(txtTaxa.Text);
            double Tempo = double.Parse(txtTempo.Text);
            // calcular Capital * Taxa/100 * Tempo
            double calcular txtCapital * txtTaxa/ 100 * txtTempo;
            tbxResultado.Text = calcular.ToString();
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                //Contabiliza que marcou sim
            {
                MessageBox.Show("Marcado");
            }
            else
            {
                MessageBox.Show("Não Marcado");
            }
        }
    }
  


}
