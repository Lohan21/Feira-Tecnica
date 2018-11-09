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
    public partial class MudarSenha : Form
    {
        TelaPrincipal telaP;
        string email;
        SQLiteConnection conexao = new SQLiteConnection();
        string database = "feiratecnica.db";
        public MudarSenha(TelaPrincipal telaPrincipal, string mail)
        {
            InitializeComponent();
#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            email = mail;
            telaP = telaPrincipal;
            

        }

        private void MudarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btChangeSenha_Click(object sender, EventArgs e)
        {
            string senha = tbNewSenha.Text.ToString();
            if (senha != tbNewSenha2.Text)
            {
                MessageBox.Show("digite a mesma senha coretamente", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string mudarSenhaUsuario = "UPDATE `usuario` SET `senha` = '" + senha + "' WHERE `email` = '"+email+"'";
            string mudarSenhaCliente = "UPDATE `clientes` SET `senha` = '" + senha + "' WHERE `email` = '" + email + "'";
            string mudarSenhaFuncionario = "UPDATE `funcionarios` SET `senha` = '" + senha + "' WHERE `email` = '" + email + "'";
            conexao.Open();
            SQLiteCommand comandoMudarSenhaUsuario = new SQLiteCommand(mudarSenhaUsuario, conexao);
            comandoMudarSenhaUsuario.ExecuteNonQuery();
            conexao.Close();
            SQLiteCommand checar = new SQLiteCommand("SELECT `tipo` FROM `usuario` WHERE `email` = '" + email + "' ",conexao);
            SQLiteDataReader myreader;
            conexao.Open();
            myreader = checar.ExecuteReader();
            string tipo = "";
            while (myreader.Read())
            {
                tipo = myreader["tipo"].ToString();
                
            }
            conexao.Close();
            MessageBox.Show(tipo);
            if (tipo == "True")
            {
                conexao.Open();
                SQLiteCommand ComandomudarsenhaCliente = new SQLiteCommand(mudarSenhaCliente, conexao);
                ComandomudarsenhaCliente.ExecuteNonQuery();
                conexao.Close();
            }
            else
            {
                conexao.Open();
                SQLiteCommand ComandomudarsenhaFuncionario = new SQLiteCommand(mudarSenhaFuncionario, conexao);
                ComandomudarsenhaFuncionario.ExecuteNonQuery();
                conexao.Close();
            }

        }
    }
}
