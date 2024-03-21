namespace Geometria
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

        private void button1_Click(object sender, EventArgs e)
        {
            double n5 = double.Parse(textBaseMaiorT.Text);
            double n6 = double.Parse(textBaseMenorT.Text);
            double n7 = double.Parse(textAlturaTra.Text);
            double n8 = (n5 + n6) * n7 / 2;
            textResTra.Text = n8.ToString();
        }

        private void CalcularQua_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBaseQ.Text);
            double n2 = double.Parse(textAlturaQ.Text);
            double multiplicar = n1 * n2;
            textResQua.Text = multiplicar.ToString();
        }

        private void CalcularTri_Click(object sender, EventArgs e)
        {
            double n3 = double.Parse(textBaseTri.Text);
            double n4 = double.Parse(textAlturaTri.Text);
            double multiplicar = (n3 * n4) / 2;
            textResTri.Text = multiplicar.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double n9 = double.Parse(textNota1.Text);
            double n10 = double.Parse(textNota2.Text);
            double n11 = double.Parse(textNota3.Text);
            double n12 = (n9 + n10 + n11) / 3;
            textMedNotas.Text = n12.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n13 = double.Parse(textQde.Text);
            double n14 = double.Parse(textPreco.Text);
            double n15 = n13 * n14;
            textValorFinal.Text = n15.ToString();
        }
    }
}