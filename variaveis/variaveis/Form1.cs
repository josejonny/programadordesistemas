using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tBxN1.Text);
            int n2 = Convert.ToInt32(tBxN2.Text);
            int soma = n1 + n2;
            tBxResult.Text = soma.ToString();
        }

    }
}
