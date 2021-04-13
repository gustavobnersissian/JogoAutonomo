using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;
namespace TesteDoPI3
{
    public partial class CriarPartida : Form
    {
        public CriarPartida()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            Jogo.CriarPartida(nome, senha);
            MessageBox.Show("Partida criada");
        }
    }
}
