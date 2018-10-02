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
        string usuario = "";

        public TelaPrincipal(TelaLogin telaLogin, string usuario)
        {
            InitializeComponent();
            telaL = telaLogin;
            this.usuario = usuario;
            lbUsuario.Text = "Olá " + usuario + ",";
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaL.Show();
        }

        private void menuItemListarFuncionarios_Click(object sender, EventArgs e)
        {
            TelaBancoDados tela = new TelaBancoDados(this);

            tela.Show();

            this.Hide();
        }
    }
}
