using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pega a imformação da caixa de texto e atribui na
            //variável nome
            string nome = tbxNome.Text;
            string senha = tbxSenha.Text;
            //pega a senha da variável e insere no label
            lbltexto.Text = "Bem-vindo: " + " sua senha é " + senha;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
