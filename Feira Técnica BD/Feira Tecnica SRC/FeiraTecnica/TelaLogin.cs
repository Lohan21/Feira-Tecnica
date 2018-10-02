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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string senha = tbSenha.Text;

            if (usuario != "" && senha != "")
            {
                TelaPrincipal tela = new TelaPrincipal(this, usuario);

                tela.Show();

                this.Hide();

                tbUsuario.Clear();
                tbSenha.Clear();
            }
            else
            {
                MessageBox.Show("Digite o usuário e a senha");
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
            this.Hide();
        }
    }
}
