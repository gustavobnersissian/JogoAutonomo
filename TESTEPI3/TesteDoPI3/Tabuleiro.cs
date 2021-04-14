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
    public partial class Tabuleiro : Form
    {
        public string Senha { get; set; }
        public int IdJogador { get; set; }
        public int IdPartida { get; set; }
        Image[] img = new Image[6];
        public Tabuleiro(int idJogador, string senhaJogador, int idPartida)
        {
            InitializeComponent();
            this.IdPartida = idPartida;
            this.IdJogador = idJogador;
            this.Senha = senhaJogador;
            img[0] = picImg1.Image;
            img[1] = picImg2.Image;
            img[2] = picImg3.Image;
            img[3] = picImg4.Image;
            img[4] = picImg5.Image;
            img[5] = picImg6.Image;
        }



        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            //int valorDado1, valorDado2, valorDado3, valorDado4;
            int idDado1, idDado2, idDado3, idDado4;
            int v1, v2, v3, v4;
            int idJog = IdJogador;
            string senhaJog = Senha;

            //MessageBox.Show(idJog.ToString());
            //MessageBox.Show(senhaJog);
            string retorno = Jogo.RolarDados(idJog, senhaJog);


            retorno = retorno.Replace("\r", "");

            if (retorno.Substring(0, 4) == "ERRO")
            {
                lblRetornoErro.Text = retorno;
            }
            if (retorno.Substring(0, 4) != "ERRO")
            {
                string[] linha = retorno.Split('\n');
                v1 = Convert.ToInt32(linha[0].Substring(1, 1));
                v2 = Convert.ToInt32(linha[1].Substring(1, 1));
                v3 = Convert.ToInt32(linha[2].Substring(1, 1));
                v4 = Convert.ToInt32(linha[3].Substring(1, 1));
                idDado1 = Convert.ToInt32(linha[0].Substring(0, 1));
                idDado2 = Convert.ToInt32(linha[1].Substring(0, 1));
                idDado3 = Convert.ToInt32(linha[2].Substring(0, 1));
                idDado4 = Convert.ToInt32(linha[3].Substring(0, 1));

                txtId1.Text = idDado1.ToString();
                txtId2.Text = idDado2.ToString();
                txtId3.Text = idDado3.ToString();
                txtId4.Text = idDado4.ToString();

                txtValor1.Text = v1.ToString();
                txtValor2.Text = v2.ToString();
                txtValor3.Text = v3.ToString();
                txtValor4.Text = v4.ToString();

                picD1.Image = img[v1 - 1];
                picD2.Image = img[v2 - 1];
                picD3.Image = img[v3 - 1];
                picD4.Image = img[v4 - 1];
            }

         }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int idJog = IdJogador;
            string senhaJog = Senha;
            string ordem = txtOrdem.Text;
            string trilha = txtTrilha.Text;
            lblRetornoErro.Text = Jogo.Mover(idJog, senhaJog, ordem, trilha);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            int idJog = IdJogador;
            string senhaJog = Senha;
            lblRetornoErro.Text = Jogo.Parar(idJog, senhaJog);
        }

        private void btnExbTab_Click(object sender, EventArgs e)
        {
            lblExbTab.Text = Jogo.ExibirTabuleiro(IdPartida);
        }
    }
}