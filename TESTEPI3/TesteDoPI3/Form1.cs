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
    public partial class Form1 : Form
    {
        public int idPartida { get; set; }
        bool jogadorEntrou = false;
        public Form1()
        {
            InitializeComponent();

            lblVersao.Text = "Versão " + Jogo.Versao;   

        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarPartida criarPartida = new CriarPartida();
            criarPartida.ShowDialog();

        }

        private void btnExibirPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("/r", "");
            string[] linha = retorno.Split('\n');
            List<Partida> partidas = new List<Partida>();

            for (int i = 0; i < linha.Length - 1; i++)
            {   
                Partida p = new Partida();
                string[] itens = linha[i].Split(',');
                p.idPartida = Convert.ToInt32(itens[0]);
                p.nome = itens[1];
                p.data = itens[2];
                p.status = itens[3];
                partidas.Add(p);
            }

            dgvPartidas.DataSource = partidas;
            dgvPartidas.Columns[4].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            txtListJog.Text = Jogo.ListarJogadores(idPartida);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJog.Text;
            string senha = txtSenhaPt.Text;
            int id = Convert.ToInt32(txtId.Text);
            string jogador = Jogo.EntrarPartida(id, nome, senha);
            lblRetornoJogador.Text = jogador;

            if (jogador.Substring(0, 4) != "ERRO")
            {
                string[] x = jogador.Split(',');
                txtIdJog.Text = x[0];
                txtSenhaJog.Text = x[1];
                txtCorJog.Text = x[2];
                
               
                jogadorEntrou = true;

                if (jogadorEntrou)
                {
                    btnIniciar.BackColor = Color.Green;
                }
                
            }
        }

        private void dgvPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if(this.dgvPartidas.Columns[e.ColumnIndex].Name == "status")
            {
                if(e.Value.ToString().Contains("J"))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (e.Value.ToString().Contains("A"))
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
            }
            
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(jogadorEntrou == false)
            {
                lblRetornoJogador.Text = "Precisa estar em uma partida";
            }
            if(jogadorEntrou)
            {
                int id = Convert.ToInt32(txtId.Text);
                int idJogador = Convert.ToInt32(txtIdJog.Text);
                string senhaJogador = txtSenhaJog.Text;
                lblRetornoJogador.Text = Jogo.IniciarPartida(idJogador, senhaJogador);
                MessageBox.Show("Você iniciou uma partida!");

                Tabuleiro tabuleiro = new Tabuleiro(idJogador, senhaJogador, id);
                tabuleiro.ShowDialog();
                
            }
            
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int idJogador = Convert.ToInt32(txtIdJog.Text);
            string senhaJogador = txtSenhaJog.Text;
            Tabuleiro tabuleiro = new Tabuleiro(idJogador, senhaJogador, id);
            tabuleiro.ShowDialog();
        }
    }
}
