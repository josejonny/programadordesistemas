using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoprojeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("escreva, M, V ou N");
            //string turno = ConsoleWriteLine();
            string turno = textBox2.Text;
            if (turno == "M")
            {
                //Console.WriteLine("Bom dia");
                label3.Text = " Bom dia ! ";
            }
            else
            {
                if(turno == "V")
                {
                    //Console.WriteLine("Boa tarde");
                    label3.Text = " Boa Tarde ! ";
                }
                else
                {
                    if(turno == "N")
                    {
                        //Console.WriteLine("Boa Noite");
                        label3.Text = " Boa Noite !";
                    }
                    else
                    {
                        //Console.WriteLine("Valor Inválido")
                        label3.Text = "Valor Inválido";
                    }
                }
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
