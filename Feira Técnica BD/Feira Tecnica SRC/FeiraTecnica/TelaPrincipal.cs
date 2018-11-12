using Calendar.NET;
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
    public partial class TelaPrincipal : Form
    {
        TelaLogin telaL;
        string mail;
        SQLiteConnection conexao = new SQLiteConnection();
        string database = "feiratecnica.db";

        public TelaPrincipal(TelaLogin telaLogin, string nome,string email)
        {           
            InitializeComponent();

#if DEBUG
            database = @"..\..\..\..\db sqlite\feiratecnica.db";
#endif
            conexao = new SQLiteConnection("Data Source=" + database + ";Version=3;");

            lbUsuario.Text = "Olá: "+nome+".";
            telaL = telaLogin;
            mail = email;
            
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaL.Show();
        }

        private void menuItemListarFuncionarios_Click(object sender, EventArgs e)
        {

            ListarFuncionarios listarFunc = new ListarFuncionarios(this);
            this.Hide();
            listarFunc.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaRegistroFuncionario registroFunc = new TelaRegistroFuncionario(this);
            this.Hide();
            registroFunc.Show();            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar a aplicação?", "Confirmar saída", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MudarSenhas MS = new MudarSenhas(this, mail);
            this.Hide();
            MS.Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            calendar1.CalendarDate = DateTime.Now;
            calendar1.CalendarView = CalendarViews.Month;

            dtHora.CustomFormat = @"dddd, dd/MM/yyyy -> HH:mm";
            dtHora.Value = DateTime.Now;

            CarregarEventos();
        }

        private void CarregarEventos()
        {
            SQLiteCommand consulta = new SQLiteCommand("SELECT `evento`,`data` FROM `agenda` WHERE `email` = '" + mail + "' and ativo = 1", conexao);
            SQLiteDataReader myReader;
            conexao.Open();
            myReader = consulta.ExecuteReader();
            while (myReader.Read())
            {
                ExibirEventos(myReader["evento"].ToString(), Convert.ToDateTime(myReader["data"]));
            }
            conexao.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            GravarEvento(tbEvento.Text, dtHora.Value);
            ExibirEventos(tbEvento.Text, dtHora.Value);
        }

        private void GravarEvento(string evento, DateTime data)
        {
            string gravarEvento = "INSERT INTO `agenda` (`evento`,`data`,`email`) VALUES ('" + evento + "','" + data.ToString("yyyy-MM-dd HH:mm") + "','" + mail + "');";
            conexao.Open();
            SQLiteCommand comandogravarEvento = new SQLiteCommand(gravarEvento, conexao);
            comandogravarEvento.ExecuteNonQuery();
            conexao.Close();
        }

        private void ExibirEventos(string evento, DateTime data)
        {
            var exerciseEvent = new CustomEvent
            {
                Date = data,
                RecurringFrequency = RecurringFrequencies.None,
                EventText = evento,
                ReadOnlyEvent = false
            };

            calendar1.AddEvent(exerciseEvent);
        }              
    }
}
