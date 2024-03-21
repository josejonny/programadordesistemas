using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doarsangue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pegar a idade no tbxIdade
            int idade = Convert.ToInt32(tbxIdade.Text);
            //verificar se é maior ou igual a 18 anos e menor ou igual a 67 anos de idade 
            if (idade >= 18 && idade <= 67)
            {
                //se é verdadeiro inserir no label lblMsn
                //a frase "Você pode doar sangue"
                //lblMsn.Text = "Você pode doar sangue!";
                MessageBox.Show("Você pode doar sangue!", "Verificação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //lblMsn.Text = "Você NÂO pode doar sangue!";

                MessageBox.Show("Você NÃO pode doar sangue!", "Verificação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            //se não inserir no label lblMsn
            //a frase "Você NÂO pode doar sangue"
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string clima = tbxClima.Text;
            double dinheiro = Convert.ToDouble(tbxDinheiro.Text);
            if (clima == "sol" && dinheiro >= 500)
            {
                MessageBox.Show("Praia");
                pbxImg.ImageLocation = "../../../sol.png";
            }
            if (clima == "sol" && dinheiro < 500)

            {
                MessageBox.Show("Sorvete");
                pbxImg.ImageLocation = "../../../sol.png";
            }
            if (clima == "chuva" && dinheiro >= 500)

            {
                MessageBox.Show("Serra");
                pbxImg.ImageLocation = "../../../chuva.png";
            }
            if (clima == "chuva" && dinheiro < 500)
            {
                MessageBox.Show("Chocolate");
                pbxImg.ImageLocation = "../../../chuva.png";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double litros = Convert.ToDouble(txtLitros.Text);
            double valor = 5.94;
            double desconto = 0;
            if (litros <= 20) { desconto = 0.04; }
            else { desconto = 0.06; }
            double total = (litros * valor) - (litros * valor * desconto);
            tbxDesconto.Text = desconto.ToString();
            tbxTotal.Text = total.ToString();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double litros = Convert.ToDouble(txtLitros.Text);
            double valor = 5.94;
            double desconto = 0;
            if (litros <= 20) { desconto = 0.04; }
            else { desconto = 0.06; }
            double total = (litros * valor) - (litros * valor * desconto);
            tbxDesconto.Text = desconto.ToString();
            tbxTotal.Text = total.ToString();
        }
    }
}
