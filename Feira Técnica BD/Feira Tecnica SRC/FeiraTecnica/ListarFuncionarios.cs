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
    public partial class ListarFuncionarios : Form
    {
        TelaPrincipal telaP;
        string email;
        string database = @"..\..\..\..\db sqlite\feiratecnica.db";
        SQLiteConnection conexao = new SQLiteConnection();
        public ListarFuncionarios(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            telaP = telaPrincipal;
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            comboBox1.SelectedIndex = 0;
        }

        private void ListarFuncionarios_Load(object sender, EventArgs e)
        {
            
        }

        private void ListarFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
            telaP.Show();
            
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                AtualizarFunc();
                
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                AtualizarCliente();
                
                
            }
            if (comboBox1.SelectedIndex == 2)
            {
                AtualizarUsuario();
                

            }
        }

        private void AtualizarFunc()
        {
            conexao.Open();
            string buscarFuncionarios = "SELECT * FROM `funcionarios` WHERE `demitido` = '0'";
            SQLiteCommand comandoBuscarPessoas = new SQLiteCommand(buscarFuncionarios, conexao);           
            SQLiteDataReader reader = comandoBuscarPessoas.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtFuncionarios.DataSource = table;
            btApagarRegistro.Text = "Demitir Funcionário";
            if (btApagarRegistro.Enabled == false)
            {
                btApagarRegistro.Enabled = true;
            }
            conexao.Close();
        }

        private void AtualizarCliente()
        {
            conexao.Open();
            string buscarFuncionarios = "SELECT * FROM `clientes` WHERE `ativo` = '1'";
            SQLiteCommand comandoBuscarPessoas = new SQLiteCommand(buscarFuncionarios, conexao);
            SQLiteDataReader reader = comandoBuscarPessoas.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtFuncionarios.DataSource = table;
            
            btApagarRegistro.Text = "Apagar Registro";
            if (btApagarRegistro.Enabled == false)
            {
                btApagarRegistro.Enabled = true;
            }
            conexao.Close();
        }

        private void AtualizarUsuario()
        {
            conexao.Open();
            string buscarFuncionarios = "SELECT * FROM `usuario` WHERE `ativo` = '1'";
            SQLiteCommand comandoBuscarPessoas = new SQLiteCommand(buscarFuncionarios, conexao);
            SQLiteDataReader reader = comandoBuscarPessoas.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtFuncionarios.DataSource = table;
            
            btApagarRegistro.Text = "Apagar Registro";
            btApagarRegistro.Enabled = false;
            conexao.Close();
        }

        private void btApagarRegistro_Click(object sender, EventArgs e)
        {
            if (btApagarRegistro.Text == "Demitir Funcionário")
            {
                demitir();
            }
            if (btApagarRegistro.Text == "Apagar Registro")
            {
                apagarRegistroCliente();
            }
        }

        private void apagarRegistroCliente()
        {
            int id;
            if (dtFuncionarios.SelectedRows[0].Cells[0] != null)
            {
                conexao.Open();
                id = Convert.ToInt32(dtFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
                string mudarCliente = "UPDATE `clientes` SET `ativo` = '" + 0 + "' WHERE `id` = '" + id + "'";
                SQLiteCommand ComandoDeletarCliente = new SQLiteCommand(mudarCliente, conexao);               
                ComandoDeletarCliente.ExecuteNonQuery();
                SQLiteCommand checar = new SQLiteCommand("SELECT `email` FROM `clientes` WHERE `id` = '" + id + "'", conexao);
                SQLiteDataReader myReader;
                myReader = checar.ExecuteReader();
                while (myReader.Read())
                {
                    email = myReader["email"].ToString();
                }
                SQLiteCommand apagarUsuario = new SQLiteCommand("UPDATE `usuario` SET `ativo` = '" + 0 + "' WHERE `email` = '" + email + "'", conexao);
                apagarUsuario.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show(email);
                AtualizarCliente();
               
            }
           
        }

        private void demitir()
        {
            int id;
            if (dtFuncionarios.SelectedRows[0].Cells[0] != null)
            {
                conexao.Open();
                id = Convert.ToInt32(dtFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
                string mudarFunc = "UPDATE `funcionarios` SET `demitido` = '" + 1 + "' WHERE `id` = '" + id + "'";
                SQLiteCommand ComandoMudarSenhaFunc = new SQLiteCommand(mudarFunc, conexao);
                ComandoMudarSenhaFunc.ExecuteNonQuery();
                SQLiteCommand checar =new SQLiteCommand("SELECT `email` FROM `funcionarios` WHERE `id` = '"+id+"'", conexao);
                SQLiteDataReader myReader;
                myReader = checar.ExecuteReader();
                while (myReader.Read())
                {
                    email = myReader["email"].ToString();
                }
                SQLiteCommand apagarUsuario=new SQLiteCommand( "UPDATE `usuario` SET `ativo` = '" + 0 + "' WHERE `email` = '" + email + "'",conexao);
                apagarUsuario.ExecuteNonQuery();
                conexao.Close();
                AtualizarFunc();
                conexao.Close();
            }
            else
            {
                MessageBox.Show("selecione o funcionário q deseja demitir", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           


        }
    }
}
