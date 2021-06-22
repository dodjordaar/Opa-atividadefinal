using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Opa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void limpar()
        {
            tb_nomeuser.Clear();
            tb_username.Clear();
            tb_emailuser.Clear();
            tb_senhauser.Clear();
            tb_repsenhauser.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Arqo;Integrated Security=True";
            comando.Connection = conexao;
            comando.CommandText = "insert into arqo_log_info (nome_log_info, username_log_info, senha_log_info, email_log_info) values" +
                    "(@nome_log_info,@username_log_info,@senha_log_info,@email_log_info)";
            comando.Parameters.AddWithValue("@nome_log_info", tb_nomeuser.Text);
            comando.Parameters.AddWithValue("@username_log_info", tb_username.Text);
            comando.Parameters.AddWithValue("@email_log_info", tb_emailuser.Text);
            comando.Parameters.AddWithValue("@senha_log_info", tb_senhauser.Text);
            int LinhasAfetadas = 0;
            if(tb_nomeuser.Text.Length<1)
            {
                MessageBox.Show("O campo nome está vazio.");
                return;
            }
            else if(tb_username.Text.Length<1)
            {
                MessageBox.Show("O campo username está vazio.");
                return;
            }
            else if (tb_emailuser.Text.Length < 1)
            {
                MessageBox.Show("O campo email está vazio.");
                return;
            }
            else if (tb_senhauser.Text.Length < 1)
            {
                MessageBox.Show("O campo senha está vazio.");
                return;
            }
            else if (tb_repsenhauser.Text.Length < 1)
            {
                MessageBox.Show("O campo senha está vazio.");
                return;
            }
                try
            {
                conexao.Open();
                LinhasAfetadas = comando.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Conexão com o banco não alcançada.");
            }
            finally
            {
                conexao.Close();
                MessageBox.Show($"Registro efetuado.\n" +
                    $"Linhas afetadas: {LinhasAfetadas}");
            }
            limpar();
        }

        private void tb_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
