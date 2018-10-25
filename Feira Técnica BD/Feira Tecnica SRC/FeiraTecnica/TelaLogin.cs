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
    public partial class TelaLogin : Form
    {
        string database = "feiratecnica.db";

        SQLiteConnection conexao = new SQLiteConnection();
        public TelaLogin()
        {
            InitializeComponent();
#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            int administrador = 1;

            string usuario = tbUsuario.Text;
            SQLiteCommand Login = new SQLiteCommand("SELECT `usuario`, `senha` FROM `usuario` WHERE `usuario` = '" + tbUsuario.Text + "' AND `senha` = '" + tbSenha.Text + "' AND `administrador` = '"+administrador+"'", conexao);
            SQLiteDataReader myReader;
            conexao.Open();
            myReader = Login.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {

                count += 1;

            }

            if (count == 1)
            {
                
                TelaPrincipal tela = new TelaPrincipal(this,usuario);


                tela.Show();
                tbUsuario.Clear();
                tbSenha.Clear();
                conexao.Close();

                this.Hide();

            }
            else if (count == 0)
            {
                conexao.Close();              
                Logar();
            }

        }

        private void Logar()
        {

            string usuario = tbUsuario.Text;
            SQLiteCommand Login = new SQLiteCommand("SELECT `usuario`, `senha` FROM `usuario` WHERE `usuario` = '" + tbUsuario.Text + "' AND `senha` = '" + tbSenha.Text + "'", conexao);
            SQLiteDataReader myReader;
            conexao.Open();
            myReader = Login.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {

                count += 1;

            }

            if (count == 1)
            {
                TelaPrincipal tela = new TelaPrincipal(this,usuario);

                tela.Show();
                tbUsuario.Clear();
                tbSenha.Clear();
                conexao.Close();
                this.Hide();

            }
            else if (count == 0)
            {
                MessageBox.Show("Usuário ou senha inválidos", "Erro");
                conexao.Close();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar a aplicação?", "Confirmar saída", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
           
            telaRegistro telaRegistro = new telaRegistro(this);
            telaRegistro.Show();
            conexao.Close();
            this.Hide();
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
    }
}
