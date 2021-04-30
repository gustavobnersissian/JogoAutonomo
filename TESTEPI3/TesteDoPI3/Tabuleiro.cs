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

        public int Conta(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }
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

                lblR1.Text = Conta(v1, v2).ToString() + " e " + Conta(v3, v4).ToString();
                lblR2.Text = Conta(v1, v3).ToString() + " e " + Conta(v2, v4).ToString();
                lblR3.Text = Conta(v1, v4).ToString() + " e " + Conta(v2, v3).ToString();
                lblR4.Text = Conta(v1, v2).ToString();
                lblR5.Text = Conta(v1, v3).ToString();
                lblR6.Text = Conta(v1, v4).ToString();
                lblR7.Text = Conta(v2, v3).ToString();
                lblR8.Text = Conta(v2, v4).ToString();
                lblR9.Text = Conta(v3, v4).ToString();
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
            picVm2.Visible = false;
            picVm3.Visible = false;
            picVm4.Visible = false;
            picVm5.Visible = false;
            picVm6.Visible = false;
            picVm7.Visible = false;
            picVm8.Visible = false;
            picVm9.Visible = false;
            picVm10.Visible = false;
            picVm11.Visible = false;
            picVm12.Visible = false;

            lblExbTab.Text = Jogo.ExibirTabuleiro(IdPartida);
            int[] v = new int[3];
            string[] linha = lblExbTab.Text.Split('\n');
            string[] x2 = linha[0].Split(',');
            v[0] = Convert.ToInt32(x2[0]);
            v[1] = Convert.ToInt32(x2[1]);
            v[2] = Convert.ToInt32(x2[2]);

            switch (v[0])
            {
                case 2:
                    switch (v[1])
                    {
                        case 1:
                            picVm2.Visible = true;
                            break;
                        case 2:
                            picVm2.Visible = true;
                            picVm2.Top = 292;
                            break;
                        case 3:
                            picVm2.Visible = true;
                            picVm2.Top = 257;
                            break;
                    }
                    break;
                case 3:
                    switch (v[1])
                    {
                        case 1:
                            picVm3.Visible = true;
                            break;
                        case 2:
                            picVm3.Visible = true;
                            picVm3.Top = 327;
                            break;
                        case 3:
                            picVm3.Visible = true;
                            picVm3.Top = 292;
                            break;
                        case 4:
                            picVm3.Visible = true;
                            picVm3.Top = 257;
                            break;
                        case 5:
                            picVm3.Visible = true;
                            picVm3.Top = 222;
                            break;
                    }
                    break;
                case 4:
                    switch (v[1])
                    {
                        case 1:
                            picVm4.Visible = true;
                            break;
                        case 2:
                            picVm4.Visible = true;
                            picVm4.Top = 362;
                            break;
                        case 3:
                            picVm4.Visible = true;
                            picVm4.Top = 327;
                            break;
                        case 4:
                            picVm4.Visible = true;
                            picVm4.Top = 292;
                            break;
                        case 5:
                            picVm4.Visible = true;
                            picVm4.Top = 257;
                            break;
                        case 6:
                            picVm4.Visible = true;
                            picVm4.Top = 222;
                            break;
                        case 7:
                            picVm4.Visible = true;
                            picVm4.Top = 187;
                            break;
                    }
                    break;
                case 5:
                    switch (v[1])
                    {
                        case 1:
                            picVm5.Visible = true;
                            break;
                        case 2:
                            picVm5.Visible = true;
                            picVm5.Top = 397;
                            break;
                        case 3:
                            picVm5.Visible = true;
                            picVm5.Top = 362;
                            break;
                        case 4:
                            picVm5.Visible = true;
                            picVm5.Top = 327;
                            break;
                        case 5:
                            picVm5.Visible = true;
                            picVm5.Top = 292;
                            break;
                        case 6:
                            picVm5.Visible = true;
                            picVm5.Top = 257;
                            break;
                        case 7:
                            picVm5.Visible = true;
                            picVm5.Top = 222;
                            break;
                        case 8:
                            picVm5.Visible = true;
                            picVm5.Top = 187;
                            break;
                        case 9:
                            picVm5.Visible = true;
                            picVm5.Top = 152;
                            break;
                    }
                    break;
                case 6:
                    switch (v[1])
                    {
                        case 1:
                            picVm6.Visible = true;
                            break;
                        case 2:
                            picVm6.Visible = true;
                            picVm6.Top = 432;
                            break;
                        case 3:
                            picVm6.Visible = true;
                            picVm6.Top = 397;
                            break;
                        case 4:
                            picVm6.Visible = true;
                            picVm6.Top = 362;
                            break;
                        case 5:
                            picVm6.Visible = true;
                            picVm6.Top = 327;
                            break;
                        case 6:
                            picVm6.Visible = true;
                            picVm6.Top = 292;
                            break;
                        case 7:
                            picVm6.Visible = true;
                            picVm6.Top = 257;
                            break;
                        case 8:
                            picVm6.Visible = true;
                            picVm6.Top = 222;
                            break;
                        case 9:
                            picVm6.Visible = true;
                            picVm6.Top = 187;
                            break;
                        case 10:
                            picVm6.Visible = true;
                            picVm6.Top = 152;
                            break;
                        case 11:
                            picVm6.Visible = true;
                            picVm6.Top = 117;
                            break;
                    }
                    break;
                case 7:
                    switch (v[1])
                    {
                        case 1:
                            picVm7.Visible = true;
                            break;
                        case 2:
                            picVm7.Visible = true;
                            picVm7.Top = 467;
                            break;
                        case 3:
                            picVm7.Visible = true;
                            picVm7.Top = 432;
                            break;
                        case 4:
                            picVm7.Visible = true;
                            picVm7.Top = 397;
                            break;
                        case 5:
                            picVm7.Visible = true;
                            picVm7.Top = 362;
                            break;
                        case 6:
                            picVm7.Visible = true;
                            picVm7.Top = 327;
                            break;
                        case 7:
                            picVm7.Visible = true;
                            picVm7.Top = 292;
                            break;
                        case 8:
                            picVm7.Visible = true;
                            picVm7.Top = 257;
                            break;
                        case 9:
                            picVm7.Visible = true;
                            picVm7.Top = 222;
                            break;
                        case 10:
                            picVm7.Visible = true;
                            picVm7.Top = 187;
                            break;
                        case 11:
                            picVm7.Visible = true;
                            picVm7.Top = 152;
                            break;
                        case 12:
                            picVm7.Visible = true;
                            picVm7.Top = 117;
                            break;
                        case 13:
                            picVm7.Visible = true;
                            picVm7.Top = 82;
                            break;
                    }
                    break;
                case 8:
                    switch (v[1])
                    {
                        case 1:
                            picVm8.Visible = true;
                            break;
                        case 2:
                            picVm8.Visible = true;
                            picVm8.Top = 432;
                            break;
                        case 3:
                            picVm8.Visible = true;
                            picVm8.Top = 397;
                            break;
                        case 4:
                            picVm8.Visible = true;
                            picVm8.Top = 362;
                            break;
                        case 5:
                            picVm8.Visible = true;
                            picVm8.Top = 327;
                            break;
                        case 6:
                            picVm8.Visible = true;
                            picVm8.Top = 292;
                            break;
                        case 7:
                            picVm8.Visible = true;
                            picVm8.Top = 257;
                            break;
                        case 8:
                            picVm8.Visible = true;
                            picVm8.Top = 222;
                            break;
                        case 9:
                            picVm8.Visible = true;
                            picVm8.Top = 187;
                            break;
                        case 10:
                            picVm8.Visible = true;
                            picVm8.Top = 152;
                            break;
                        case 11:
                            picVm8.Visible = true;
                            picVm8.Top = 117;
                            break;
                    }
                    break;
                case 9:
                    switch (v[1])
                    {
                        case 1:
                            picVm9.Visible = true;
                            break;
                        case 2:
                            picVm9.Visible = true;
                            picVm9.Top = 397;
                            break;
                        case 3:
                            picVm9.Visible = true;
                            picVm9.Top = 362;
                            break;
                        case 4:
                            picVm9.Visible = true;
                            picVm9.Top = 327;
                            break;
                        case 5:
                            picVm9.Visible = true;
                            picVm9.Top = 292;
                            break;
                        case 6:
                            picVm9.Visible = true;
                            picVm9.Top = 257;
                            break;
                        case 7:
                            picVm9.Visible = true;
                            picVm9.Top = 222;
                            break;
                        case 8:
                            picVm9.Visible = true;
                            picVm9.Top = 187;
                            break;
                        case 9:
                            picVm9.Visible = true;
                            picVm9.Top = 152;
                            break;
                    }
                    break;
                case 10:
                    switch (v[1])
                    {
                        case 1:
                            picVm10.Visible = true;
                            break;
                        case 2:
                            picVm10.Visible = true;
                            picVm10.Top = 362;
                            break;
                        case 3:
                            picVm10.Visible = true;
                            picVm10.Top = 327;
                            break;
                        case 4:
                            picVm10.Visible = true;
                            picVm10.Top = 292;
                            break;
                        case 5:
                            picVm10.Visible = true;
                            picVm10.Top = 257;
                            break;
                        case 6:
                            picVm10.Visible = true;
                            picVm10.Top = 222;
                            break;
                        case 7:
                            picVm10.Visible = true;
                            picVm10.Top = 187;
                            break;
                    }
                    break;
                case 11:
                    switch (v[1])
                    {
                        case 1:
                            picVm11.Visible = true;
                            break;
                        case 2:
                            picVm11.Visible = true;
                            picVm11.Top = 327;
                            break;
                        case 3:
                            picVm11.Visible = true;
                            picVm11.Top = 292;
                            break;
                        case 4:
                            picVm11.Visible = true;
                            picVm11.Top = 257;
                            break;
                        case 5:
                            picVm11.Visible = true;
                            picVm11.Top = 222;
                            break;
                    }
                    break;
                case 12:
                    switch (v[1])
                    {
                        case 1:
                            picVm12.Visible = true;
                            break;
                        case 2:
                            picVm12.Visible = true;
                            picVm12.Top = 292;
                            break;
                        case 3:
                            picVm12.Visible = true;
                            picVm12.Top = 257;
                            break;
                    }
                    break;
            }

        }

        private void btnNarrar_Click(object sender, EventArgs e)
        {
            txtNarrar.Text = Jogo.ExibirHistorico(IdPartida);
        }

        private void btnVerVez_Click(object sender, EventArgs e)
        {
            lblVerVez.Text = Jogo.VerificarVez(IdPartida);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVerVez.Text = Jogo.VerificarVez(IdPartida);
        }
    }
}