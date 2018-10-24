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

        private void telaRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaL.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                bool sexo, tipo;
                tipo = true;
                sexo = true;


                if (cbMasculino.Checked)
                {

                    sexo = true;
                }
                else if (cbFeminino.Checked)
                {

                    sexo = false;
                }


                if (rbFisica.Checked)
                {
                    tipo = true;
                }
                else if (rbEmpresarial.Checked)
                {
                    tipo = false;
                }

                nome = tbNome.Text.ToString();
                usuario = tbUsuario.Text.ToString();
                Email = tbEmail.Text.ToString();
                DataN = tbNascimento.Value;
                Rua = tbRua.Text.ToString();
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

                conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
                conexao.Open();
                string criarRegistroPessoa = "INSERT INTO `clientes` (`nome`,`email`,`celular`,`data_nascimento`,`senha`,`cpf`,`cnpj`,`sexo`,`tipo`,`rua`,`numero_casa`,`complemento_endereco`,`bairro`,`cep`,`cidade`,`uf`,`codigo_servico`) VALUES ('" + nome + "','" + Email + "','" + celular + "','" + DataN.ToString("yyyy-MM-dd") + "','" + Senha + "','" + tbCPF.Text + "','" + tbCNPJ.Text + "','" + sexo + "','" + tipo + "','" + Rua + "','" + Numero + "','" + Complemento + "','" + Bairro + "','" + CEP + "','" + Cidade + "','" + UF + "','" + null + "');";
                string criarRegistroUsuario = "INSERT INTO `usuario` (`usuario`,`senha`,`tipo`,`administrador`,`email`) VALUES ('" + usuario + "','" + Senha + "','" + cliente + "','" + administrador + "','" + Email + "');";
                SQLiteCommand comandoCriarRegistroPessoa = new SQLiteCommand(criarRegistroPessoa, conexao);
                SQLiteCommand comandoCriarRegistroUsuario = new SQLiteCommand(criarRegistroUsuario, conexao);
                comandoCriarRegistroPessoa.ExecuteNonQuery();
                comandoCriarRegistroUsuario.ExecuteNonQuery();
                MessageBox.Show("Registro feito com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conexao.Close();

                button2_Click(null, null);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("preencha todos os valores corretamente para se registrar!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cbMasculino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbFeminino_CheckedChanged(object sender, EventArgs e)
        {
          

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

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }

        private void tbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
       

        private void tbCelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checarNumero(e);
        }
    }
}
