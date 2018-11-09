using Calendar.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public TelaPrincipal(TelaLogin telaLogin, string nome,string email)
        {           
            InitializeComponent();
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
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var exerciseEvent = new CustomEvent
            {
                Date = dtHora.Value,
                RecurringFrequency = RecurringFrequencies.None,
                EventText = tbEvento.Text,
                ReadOnlyEvent = false
            };

            calendar1.AddEvent(exerciseEvent);
        }
    }
}
