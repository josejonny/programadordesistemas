using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formadepagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(tbxPreco.Text);
            double qtd = Convert.ToDouble(tbxQtde.Text);
            if (rbAvista.Checked == true) ;
            {
                double total = preco * qtd * 0.9;
                if (rbAprazo.Checked)
                    total = preco * qtd * 1.05;
                tbxTotal.Text = total.ToString();

            }
        }
    }
}
