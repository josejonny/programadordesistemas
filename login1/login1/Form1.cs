using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // pegar os valores das caixas de texto tbxLogin e tbxSenha
            string login = txbLogin.Text;
            string senha = txbSenha.Text;
            // verificar se Usuário e senha são válido
            if (login == "adm")
            {
                if (senha == "admin123")
                {
                    MsnConfirm.ForeColor = Color.Green;
                    MsnConfirm.Text = "Bem-Vindo! Ok, Acesso Confirmado!";
                    
                }
                else
                {
                    MsnConfirm.ForeColor = Color.Red;
                    MsnConfirm.Text = "Senha incorreta!";
                }
            }
            else
            {
                MsnConfirm.ForeColor = Color.Red;
                MsnConfirm.Text = "Login incorreto.";
            }
            // modificar o label MsnConfirm
        }
    }
}
