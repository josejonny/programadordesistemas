﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometria1
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //pegra o texto da caixa de texto tbxArea
            double b = Convert.ToDouble(tbxBase.Text);
            //pegar o texto da caixa de texto tbxAltura
            double a = Convert.ToDouble(tbxAltura.Text);
            //calcular a àrea do triângulo
            double area = (b * a) / 2;
            //inserir o valor área na caixa de texto tbxArea
            tbxArea.Text = area.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxBase.Text = "";
            tbxAltura.Text = "";
            tbxArea.Text = "";
            tbxBase.Focus();
        }
    }
}
