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
    public partial class telaRegistro : Form
    {
        TelaLogin telaL;
        public telaRegistro(TelaLogin telaLogin)
        {
            InitializeComponent();
            telaL = telaLogin;
        }

        private void telaRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaL.Show();
        }
    }
}
