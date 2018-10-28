using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeiraTecnica
{
    public partial class telaRegistro : Form
    {
        TelaLogin telaL;
        string database = "feiratecnica.db";
        SQLiteConnection conexao = new SQLiteConnection();



        public telaRegistro(TelaLogin telaLogin)
        {
            InitializeComponent();
#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            rbFisica.Checked = true;
            tbCNPJ.Enabled = false;
            
            telaL = telaLogin;

        }

        private void TelaRegistro_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            telaL.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaL.Show();
            this.Hide();            
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarCliente();     
        }

        private void RegistrarCliente()
        {
            try
            {
                string celular, nome, Email, Rua, Bairro, Cidade, Complemento, Senha, UF, CEP, usuario;
                DateTime DataN;
                int Numero;
                bool sexo;
                sexo = true;


                if (cbMasculino.Checked)
                {

                    sexo = true;
                }
                else if (cbFeminino.Checked)
                {

                    sexo = false;
                }

                nome = tbNome.Text.ToString();
                usuario = tbUsuario.Text.ToString();
                Email = tbEmail.Text.ToString();
                DataN = tbNascimento.Value;
                Rua = tbEndereco.Text.ToString();
                Bairro = tbBairro.Text.ToString();
                Cidade = tbCidade.Text.ToString();
                Complemento = tbComplemento.Text.ToString();
                Senha = tbSenha.Text.ToString();
                UF = tbUF.Text.ToString();
                Boolean cliente = true, administrador = false;

                celular = tbCelular.Text;

                Numero = Convert.ToInt32(tbNumero.Text);
                CEP = tbCEP.Text;
                if ((cbMasculino.Checked == false) && (cbFeminino.Checked == false))
                {
                    MessageBox.Show("erro no registro, selecione seu sexo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EmailEhValido(Email))
                {
                    try
                    {
                        SalvarNoBanco(celular, nome, Email, Rua, Bairro, Cidade, Complemento, Senha, UF, CEP, usuario, DataN, Numero, sexo, cliente, administrador);

                        MessageBox.Show("Registro feito com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        button2_Click(null, null);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show(exception.InnerException.ToString(), "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("E-mail inválido!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                conexao.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("preencha todos os valores corretamente para se registrar!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private bool EmailEhValido(string email)
        {
            bool retorno = true;

            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            conexao.Open();

            SQLiteCommand consulta = new SQLiteCommand("SELECT `email` FROM `usuario` WHERE `email` = '" + email + "'", conexao);
            SQLiteDataReader myReader = consulta.ExecuteReader();

            while (myReader.Read())
            {
                retorno = false;
            }           

            return retorno;
        }

        private void SalvarNoBanco(string celular, string nome, string Email, string Rua, string Bairro, string Cidade, string Complemento, string Senha, string UF, string CEP, string usuario, DateTime DataN, int Numero, bool sexo, bool cliente, bool administrador)
        {
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            conexao.Open();
            string criarRegistroPessoa = "INSERT INTO `clientes` (`nome`,`email`,`celular`,`data_nascimento`,`senha`,`cpf`,`cnpj`,`sexo`, `tipo`, `rua`,`numero_casa`,`complemento_endereco`,`bairro`,`cep`,`cidade`,`uf`,`codigo_servico`) VALUES ('" + nome + "','" + Email + "','" + celular + "','" + DataN.ToString("yyyy-MM-dd") + "','" + Senha + "','" + tbCPF.Text + "','" + tbCNPJ.Text + "','" + sexo + "','" + cliente + "','" + Rua + "','" + Numero + "','" + Complemento + "','" + Bairro + "','" + CEP + "','" + Cidade + "','" + UF + "','" + null + "');";
            string criarRegistroUsuario = "INSERT INTO `usuario` (`usuario`,`senha`,`tipo`,`administrador`,`email`) VALUES ('" + usuario + "','" + Senha + "','" + cliente + "','" + administrador + "','" + Email + "');";
            SQLiteCommand comandoCriarRegistroPessoa = new SQLiteCommand(criarRegistroPessoa, conexao);
            SQLiteCommand comandoCriarRegistroUsuario = new SQLiteCommand(criarRegistroUsuario, conexao);
            comandoCriarRegistroPessoa.ExecuteNonQuery();
            comandoCriarRegistroUsuario.ExecuteNonQuery();            
        }

        private void rbFisica_Click(object sender, EventArgs e)
        {
            tbCPF.Enabled = true;
            tbCNPJ.Enabled = false;
        }

        private void rbEmpresarial_Click(object sender, EventArgs e)
        {
            tbCNPJ.Enabled = true;
            tbCPF.Enabled = false;
        }

        private void cbMasculino_Click(object sender, EventArgs e)
        {
            cbFeminino.Checked = false;
        }

        private void cbFeminino_Click(object sender, EventArgs e)
        {
            cbMasculino.Checked = false;
        }

        private void tbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void checarNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }
       

        private void tbCelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbCEP_Leave(object sender, EventArgs e)
        {
            WebCEP webCep = new WebCEP(tbCEP.Text);
            tbEndereco.Text = webCep.TipoLogradouro + " " + webCep.Logradouro;
            tbBairro.Text = webCep.Bairro;
            tbUF.Text = webCep.UF;
            tbCidade.Text = webCep.Cidade;
        }
    }
}
