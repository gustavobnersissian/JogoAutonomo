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
            string retorno = Jogo.CriarPartida(nome, senha);
            if(retorno.Substring(0,1) != "E")
            {
                MessageBox.Show("Partida Criada");
            }
            else
            {
                MessageBox.Show(retorno);
            }
        }
    }
}
