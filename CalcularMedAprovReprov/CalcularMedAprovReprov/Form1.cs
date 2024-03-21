namespace CalcularMedAprovReprov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textNota1.Text);
            double n2 = double.Parse(textNota2.Text);
            double n3 = double.Parse(textNota3.Text);
            double media = (n1 + n2 + n3) / 3;
            if (media >= 7)
            {
                textRes4.Text = " O aluno está aprovado.";
            }
            else if (media < 7 && media >= 4)

            {
                textRes4.Text = " O aluno está de recuperação.";
            }

            //se a media for abaixo de 7 e maoir ou igual a 4 o aluno está de repcuperação
            //se for abaixo de 4 está reprovado
            else
            {
                textRes4.Text = " O aluno está reprovado.";
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            //1.Ler a Quantidade e o preço se a vista oua prazo;
            //se a vista  vai desconto de 10%
            //se a prazo vai mesmo preço
            //2.Ler 2 números e a operação ( soma ou multilicação );
            //se o usuário escolher soma então somar os 2 números;
            //se o usuário escolher multiiplicação então multiplicar os 2 núumeros
            //
            double p = double.Parse(textPreco6.Text);
            double q = double.Parse(textQde1.Text);
            int m = int.Parse(textVezes2.Text);
            double total = p * q;
            double desconto = 0;

            if (m == 1)
            {
                desconto = 0.1 * total;

            }
            textVTotal5.Text = total.ToString();
            textVDesc3.Text = desconto.ToString();
            textVTCDesc4.Text = (total - desconto).ToString();
        }

        private void textPreco6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textN1.Text);
            double n2 = double.Parse(textN2.Text);
            string operador = comboBox1.Text;
            double resultado = 0;
            if (operador == "Somar")
            {
                resultado = n1 + n2;
            }
            if (operador == "Multiplicar")
            {
                resultado = n1 * n2;
            }
            if (operador == "Subtrair")
            {
                resultado = n1 - n2;
            }
            if (operador == "Dividir")
            {
                resultado = n1 / n2;
            }
            textRes.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string clima = comboClima2.Text;
            if (clima == "Sol")
            {
                label19.Text = " Que tal ir à praia. ";
            }
            else
            {
                label19.Text = " melhor assistir algo na netflix. ";
            }
        }

        private void comboClima2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        // verificar o usuário e a senha corretas
        {
            string usuario = textBox2.Text;
            string senha = textBox1.Text;
            if (usuario == "senac" && senha == "1234")
            {
                label21.Text = " Seja Bem Vindo ( a )! ";
            }
            else if ( usuario != "senac" && senha == "1234" )
            {
                label21.Text = "Usuário Incorreto ";
            }
            else if ( usuario == "senac" && senha != "1234")
            {
                label21.Text = " Senha Incorreta ";
            }
            else
            {
                label21.Text = " Usuário e Senha Incorretos ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if ( checkBox1.Checked)
            {
                contador = contador + 1;
            }
            if ( checkBox2.Checked)
            {
                contador = contador + 1;
            }
            if ( checkBox3.Checked)
            {
                contador = contador + 1;
            }
            if ( checkBox4.Checked)
            {
                contador = contador + 1;
            }
            if ( checkBox5.Checked)
            {
                contador = contador + 1;
            }
            if (contador == 5 )
            {
                MessageBox.Show("Assassino");
            }
            if (contador == 4 || contador == 3) ;
            {
                MessageBox.Show("Cúmplice");
            }
            if ( contador == 2) 
            {
                MessageBox.Show("Suspeito");
            }
            if (contador == 1 )
            {
                MessageBox.Show("Inocente");
            }
        }
       
        
    }
}