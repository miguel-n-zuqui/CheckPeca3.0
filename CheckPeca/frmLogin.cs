using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheckPeca
{
    public partial class frmLogin : Form
    {
        string strConexao = @"Data Source=BM-PC\SQLEXPRESS;Initial Catalog=db_check_peca;User ID=sa;Password=sql2017";
        SqlConnection objConexao;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            objConexao = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT usuario FROM Usuario WHERE usuario = @email";
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            objConexao.Open();
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "INSERT INTO Usuario(usuario, senha) VALUES(@mail, @senha)";
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.ExecuteNonQuery();
                objConexao.Close();
                MessageBox.Show("Usuario cadastrado no Sistema");
                DialogResult resposta = MessageBox.Show("Entrar agora?", "Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta.ToString() == "Yes")
                {
                    this.Hide();
                    frmPrincipal fPrincipal = new frmPrincipal();
                    fPrincipal.ShowDialog();
                    objConexao.Close();
                }
            }
            else
            {
                cmd.CommandText = "SELECT senha FROM Usuario WHERE usuario = @e";
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                if (txtSenha.Text == cmd.ExecuteScalar().ToString())
                {
                    this.Hide();
                    frmPrincipal fPrincipal = new frmPrincipal();
                    fPrincipal.ShowDialog();
                    objConexao.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                    objConexao.Close();
                }
            }
            
        }
    }
}
