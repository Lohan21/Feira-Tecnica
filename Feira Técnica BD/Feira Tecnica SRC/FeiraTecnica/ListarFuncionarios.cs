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
        string database = "feiratecnica.db";
        SQLiteConnection conexao = new SQLiteConnection();
        public ListarFuncionarios(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            telaP = telaPrincipal;
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            conexao.Open();
            string buscarFuncionarios = "SELECT * FROM `funcionarios` WHERE `demitido` = '0'";
            SQLiteCommand comandoBuscarPessoas = new SQLiteCommand(buscarFuncionarios, conexao);
            SQLiteDataReader reader = comandoBuscarPessoas.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dtFuncionarios.DataSource = table;
        }

        private void ListarFuncionarios_Load(object sender, EventArgs e)
        {
            
        }

        private void ListarFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
            telaP.Show();
            
            
            
            
        }
    }
}
