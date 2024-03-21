using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS; Initial Catalog=Biblioteca;Integrated Security=true");
            SqlCommand command = new SqlCommand("select sum(capacidade) as soma from dbo.Sala where Sala like '%' + @Sala + '%'", sql);
            command.Parameters.Add("@Sala", SqlDbType.VarChar).Value = txtSala.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == true)
                {
                    drms.Read();
                    //iduserTextBox.Text = Convert.ToString(drms["iduser"]);
                    txtSoma.Text = Convert.ToString(drms["soma"]);  
                }
                else
                {
                    MessageBox.Show("Nome não Encontrado!", "SYSTEMA NEOTECH",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS; Initial Catalog=Biblioteca;Integrated Security=true");
            SqlCommand command = new SqlCommand("select Avg(capacidade) as media from dbo.Sala where Sala like '%' + @Sala + '%'", sql);
            command.Parameters.Add("@Sala", SqlDbType.VarChar).Value = txtSala.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == true)
                {
                    drms.Read();
                    //iduserTextBox.Text = COnvert.ToString(drms["iduser"]);
                    txtMedia.Text = Convert.ToString(drms["media"]);
                }
                else
                {
                    MessageBox.Show("Nome não Encontrado!", "SYSTEMA NEOTECH",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
