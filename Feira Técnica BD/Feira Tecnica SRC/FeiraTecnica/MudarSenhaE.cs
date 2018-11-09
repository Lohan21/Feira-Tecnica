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
    public partial class MudarSenhaE : Form
    {
        TelaLogin telaL;
        string database = "feiratecnica.db";
        string email;
        string senha;
        SQLiteConnection conexao = new SQLiteConnection();
        public MudarSenhaE(TelaLogin telaLogin)
        {
            InitializeComponent();
            telaL = telaLogin;
#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");

        }

        private void MudarSenha_Click(object sender, EventArgs e)
        {
            email = tbEmail.Text.ToString();
            senha = tbNewSenha1.Text.ToString();
            if (senha != tbNewSenha2.Text)
            {
                MessageBox.Show("digite a mesma senha coretamente", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbNewSenha1.Text == null || tbNewSenha2.Text == null)
            {
                MessageBox.Show("Digite a sua nova senha", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNewSenha1.Focus();
                return;
            }
            if (email == null)
            {
                MessageBox.Show("Por Favor digite um Email", "erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            conexao.Open();
            SQLiteCommand mudarSenha = new SQLiteCommand("SELECT `tipo` FROM `usuario` WHERE `email` = '" + email + "'", conexao);
            SQLiteCommand checar = new SQLiteCommand("SELECT `ativo` FROM `usuario` WHERE `email` = '" + email + "'", conexao);

            SQLiteDataReader myReader;
            myReader = mudarSenha.ExecuteReader();
            string tipo = "";
            string ativo = "";
            while (myReader.Read())
            {
                tipo = myReader["tipo"].ToString();


            }
            myReader = checar.ExecuteReader();
            while (myReader.Read())
            {
                ativo = myReader["ativo"].ToString();

            }
            MessageBox.Show(ativo);
            if (ativo != "True")
            {
                MessageBox.Show("email invalido!", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SQLiteCommand mudarSenhaUsuario = new SQLiteCommand("UPDATE `usuario` SET `senha` = '" + senha + "' WHERE `email` = '" + email + "'",conexao);
            mudarSenhaUsuario.ExecuteNonQuery();
            if (tipo == "true")
            {
                mudarSenhaCliente();
            }
            else if (tipo == "false")
            {
                mudarSenhafunc();
            }
            conexao.Close();
            MessageBox.Show("Senha mudada com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mudarSenhafunc()
        {
            SQLiteCommand mudarSenhaUsuario = new SQLiteCommand("UPDATE `funcionarios` SET `senha` = '" + senha + "' WHERE `email` = '" + email + "'", conexao);
        }

        private void mudarSenhaCliente()
        {
            SQLiteCommand mudarSenhaUsuario = new SQLiteCommand("UPDATE `clientes` SET `senha` = '" + senha + "' WHERE `email` = '" + email + "'", conexao);
        }

        private void MudarSenhaE_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
            telaL.Show();
            
        }
    }
}
