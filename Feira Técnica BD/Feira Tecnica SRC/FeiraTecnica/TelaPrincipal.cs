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

        public TelaPrincipal(TelaLogin telaLogin, string nome)
        {           
            InitializeComponent();
            lbUsuario.Text = "Olá: "+nome+".";
            telaL = telaLogin;
            
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaRegistroFuncionario registroFunc = new TelaRegistroFuncionario(this);
            this.Hide();
            registroFunc.Show();


            
        }
    }
}
