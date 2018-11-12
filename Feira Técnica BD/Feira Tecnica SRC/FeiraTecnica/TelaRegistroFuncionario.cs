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
    public partial class TelaRegistroFuncionario : Form
    {
        TelaPrincipal principal;
        string database = "feiratecnica.db";
        SQLiteConnection conexao = new SQLiteConnection();
        public TelaRegistroFuncionario(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            cmbSetores.SelectedIndex = 0;
            principal = telaPrincipal;
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarFuncionario();
        }

        private void RegistrarFuncionario()
        {
            try
            {
                string nome, Email, Rua, Bairro, Cidade, Complemento, Senha, UF, usuario, celular, CEP;
                DateTime DataN;
                int Numero, setor;
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
                Boolean cliente = false, administrador = false;

                celular = tbCelular.Text;

                setor = 1;
                if (cmbSetores.SelectedIndex==0)
                {
                    setor = 1;
                }
                if (cmbSetores.SelectedIndex == 1)
                {
                    setor = 2;
                }
                if (cmbSetores.SelectedIndex == 2)
                {
                    setor = 3;
                }
                if (cmbSetores.SelectedIndex == 03)
                {
                    setor = 4;
                }

                Numero = Convert.ToInt32(tbNumero.Text);
                CEP = tbCEP.Text;
                if ((cbMasculino.Checked == false) && (cbFeminino.Checked == false))
                {
                    MessageBox.Show("erro no registro, selecione seu sexo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (UsuarioValido(usuario))
                {
                    try
                    {
                        SalvarNoBanco(celular, nome, Email, Rua, Bairro, Cidade, Complemento, Senha, UF, CEP, usuario, DataN, Numero, sexo, cliente, administrador, setor);

                        MessageBox.Show("Registro feito com sucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btVoltar_Click(null, null);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show(exception.InnerException.ToString(), "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário já registrado!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("preencha todos os valores corretamente para se registrar!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SalvarNoBanco(string celular, string nome, string Email, string Rua, string Bairro, string Cidade, string Complemento, string Senha, string UF, string CEP, string usuario, DateTime DataN, int Numero, bool sexo, bool cliente, bool administrador, int setor)
        {
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            conexao.Open();
            string criarRegistroPessoa = "INSERT INTO `funcionarios` (`nome`,`email`,`celular`,`data_nascimento`,`senha`,`cpf`,`cnpj`,`sexo`,`codigo_cargo`,`rua`,`numero_casa`,`complemento_endereco`,`bairro`,`cep`,`cidade`,`uf`,`setor_id`) VALUES ('" + nome + "','" + Email + "','" + celular + "','" + DataN + "','" + Senha + "','" + tbCPF.Text + "','" + tbCNPJ.Text + "','" + sexo + "','" + null + "','" + Rua + "','" + Numero + "','" + Complemento + "','" + Bairro + "','" + CEP + "','" + Cidade + "','" + UF + "','" + setor + "');";
            string criarRegistroUsuario = "INSERT INTO `usuario` (`usuario`,`senha`,`tipo`,`administrador`,`email`) VALUES ('" + usuario + "','" + Senha + "','" + cliente + "','" + administrador + "','" + Email + "');";
            SQLiteCommand comandoCriarRegistroPessoa = new SQLiteCommand(criarRegistroPessoa, conexao);
            SQLiteCommand comandoCriarRegistroUsuario = new SQLiteCommand(criarRegistroUsuario, conexao);
            comandoCriarRegistroPessoa.ExecuteNonQuery();
            comandoCriarRegistroUsuario.ExecuteNonQuery();
            conexao.Close();
        }

        private bool UsuarioValido(string usuario)
        {
            bool retorno = true;

            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            conexao.Open();

            SQLiteCommand consulta = new SQLiteCommand("SELECT `usuario` FROM `usuario` WHERE `usuario` = '" + usuario + "'", conexao);
            SQLiteDataReader myReader = consulta.ExecuteReader();

            while (myReader.Read())
            {
                retorno = false;
            }
            conexao.Close();

            return retorno;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaRegistroFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
           principal.Show();
        }

        private void rbEmpresarial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEmpresarial_Click(object sender, EventArgs e)
        {
            tbCNPJ.Enabled = true;
            tbCPF.Enabled = false;
        }

        private void rbFisica_Click(object sender, EventArgs e)
        {
            tbCNPJ.Enabled = false;
            tbCPF.Enabled = true;
        }

        private void TelaRegistroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
             checarNumero(e);
        }

        private void cbMasculino_Click(object sender, EventArgs e)
        {
            cbMasculino.Checked = true;
            cbFeminino.Checked = false;
        }

        private void cbFeminino_Click(object sender, EventArgs e)
        {
            cbMasculino.Checked = false;
            cbFeminino.Checked = true;
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
