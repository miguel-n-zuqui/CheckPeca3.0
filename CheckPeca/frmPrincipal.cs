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
    public partial class frmPrincipal : Form
    {
        string strConexao = @"Data Source=BM-PC\SQLEXPRESS;Initial Catalog=db_check_peca;User ID=sa;Password=sql2017";
        SqlConnection objConexao;
        int alterar = 0;
        int aprovadas = 0;
        int reprovadas = 0;
       
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public string CalcularDias(DateTime DataInicio, DateTime DataFim)
        {
            if (DataInicio.Year > DataFim.Year)
            {
                return "Data Incorreta";
            }
            else if (DataInicio.Month > DataFim.Month)
            {
                return "Data Incorreta";
            }
            else if (DataInicio.Day > DataFim.Day)
            {
                return "Data Incorreta";
            }
            else
            {
                return "Data Correta";
            }
        }

        private void btSalvas_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(mtxtData.Text) > DateTime.Now)
            {
                MessageBox.Show("Data Inválida");
            }
            else
            {
                MessageBox.Show(CalcularDias(Convert.ToDateTime(mtxtData.Text), System.DateTime.Now));
                if (VerificaEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Email incorreto!");
                }
            }
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter daFun = new SqlDataAdapter("SELECT * FROM Peca", strConexao);
            daFun.Fill(tabela);
            cbPecas.DataSource = tabela;
            cbPecas.DisplayMember = "nome";
            cbPecas.ValueMember = "id";
        }

        private void mtxtData_TextChanged(object sender, EventArgs e)
        {
            this.alterar = 1;
        }

        private void cbPecas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.alterar == 1)
            {
                txtPecasAprovadas.Enabled = true;
                txtPecasReprovadas.Enabled = true;
                txtPrejuizo.Enabled = true;
            }
        }

        private void txtPecasAprovadas_Leave(object sender, EventArgs e)
        {
            if (txtPecasAprovadas.Text.Length == 0)
            {
                aprovadas = 0;
            }
            else
            {
                aprovadas = Convert.ToInt32(txtPecasAprovadas.Text);
            }
            if (txtPecasReprovadas.Text.Length == 0)
            {
                reprovadas = 0;
            }
            else
            {
                reprovadas = Convert.ToInt32(txtPecasReprovadas.Text);
            }
            txtPecasProduzidas.Text = (aprovadas + reprovadas).ToString();

            if (Convert.ToInt32(txtPecasReprovadas.Text) > Convert.ToInt32(txtPecasAprovadas.Text))
            {
                txtPecasReprovadas.ResetText();
                MessageBox.Show("A quantidade de peças reprovadas não pode ser maior que a quantidade de peças produzidas.");
            }
        }

        public double PrejuicoEstimado(int quantidade)
        {
            objConexao = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT valor FROM Peca WHERE id = @cod";
            cmd.Parameters.AddWithValue("@cod", cbPecas.SelectedValue);
            objConexao.Open();
            double valor = Convert.ToDouble(cmd.ExecuteScalar());

            return valor * quantidade;
        }

        private void txtPecasReprovadas_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPecasReprovadas.Text) > 10)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
            if (txtPecasAprovadas.Text.Length == 0)
            {
                aprovadas = 0;
            }
            else
            {
                aprovadas = Convert.ToInt32(txtPecasAprovadas.Text);
            }
            if (txtPecasReprovadas.Text.Length == 0)
            {
                reprovadas = 0;
            }
            else
            {
                reprovadas = Convert.ToInt32(txtPecasReprovadas.Text);
            }
            txtPecasProduzidas.Text = (aprovadas + reprovadas).ToString();

            if (Convert.ToInt32(txtPecasReprovadas.Text) > Convert.ToInt32(txtPecasAprovadas.Text))
            {
                txtPecasReprovadas.ResetText();
                MessageBox.Show("A quantidade de peças reprovadas não pode ser maior que a quantidade de peças produzidas.");
            }
            txtPrejuizo.Text = PrejuicoEstimado(reprovadas).ToString("C2");
        }

        public bool VerificaEmail(string email)
        {
            string endereco = "";
            string dominio = "";
            bool verificador = false;
            int cont = 0;
            int contPonto = 0;

            for (int i = 0; i < email.Length; i++)
            {
                if (email.Substring(i,1) == "@")
                {
                    verificador = true;
                }
            }

            if (verificador)
            {
                while (email.Substring(cont, 1) != "@")
                {
                    endereco += email.Substring(cont, 1);
                    cont++;
                }
                dominio = email.Substring(cont + 1, email.Length - (cont+1));
                cont = 0;
                if (endereco.Length < 3)
                {
                    verificador = false;
                }
                else
                {
                    while (cont < dominio.Length)
                    {
                        if (dominio.Substring(cont,1) == ".")
                        {
                            contPonto++;
                        }
                        cont++;
                    }
                    if (contPonto == 0)
                    {
                        verificador = false;
                    }
                }
            }
            return verificador;
        }
    }
}
