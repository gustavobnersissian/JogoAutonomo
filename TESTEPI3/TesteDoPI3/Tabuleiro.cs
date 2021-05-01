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
        public string[] Cor = new string[1000];
        public string[] x = new string[1000];
        public int y;
        public bool alp;

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

            string info = Jogo.ListarJogadores(idPartida);
            string[] inf = info.Split('\n');
            Cor[0] = "N";
            Cor[1] = "N";
            Cor[2] = "N";
            Cor[3] = "N";
            for (int g = 0; g < inf.Length - 1; g++)
            {
                string[] idCor = inf[g].Split(',');
                Cor[g] = idCor[0];
            }
        }



        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            //int valorDado1, valorDado2, valorDado3, valorDado4;
           // int idDado1, idDado2, idDado3, idDado4;
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
              /*  idDado1 = Convert.ToInt32(linha[0].Substring(0, 1));
                idDado2 = Convert.ToInt32(linha[1].Substring(0, 1));
                idDado3 = Convert.ToInt32(linha[2].Substring(0, 1));
                idDado4 = Convert.ToInt32(linha[3].Substring(0, 1));
              */
                picD1.Image = img[v1 - 1];
                picD2.Image = img[v2 - 1];
                picD3.Image = img[v3 - 1];
                picD4.Image = img[v4 - 1];

                lblR1.Text = Conta(v1, v2).ToString() + " e " + Conta(v3, v4).ToString();
                lblR2.Text = Conta(v1, v3).ToString() + " e " + Conta(v2, v4).ToString();
                lblR3.Text = Conta(v1, v4).ToString() + " e " + Conta(v2, v3).ToString();
              /*  
                lblR4.Text = Conta(v1, v2).ToString();
                lblR5.Text = Conta(v1, v3).ToString();
                lblR6.Text = Conta(v1, v4).ToString();
                lblR7.Text = Conta(v2, v3).ToString();
                lblR8.Text = Conta(v2, v4).ToString();
                lblR9.Text = Conta(v3, v4).ToString();
              */
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
            picAlp2.Visible = false;
            picAlp3.Visible = false;
            picAlp4.Visible = false;
            picAlp5.Visible = false;
            picAlp6.Visible = false;
            picAlp7.Visible = false;
            picAlp8.Visible = false;
            picAlp9.Visible = false;
            picAlp10.Visible = false;
            picAlp11.Visible = false;
            picAlp12.Visible = false;

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

            picAz2.Visible = false;
            picAz3.Visible = false;
            picAz4.Visible = false;
            picAz5.Visible = false;
            picAz6.Visible = false;
            picAz7.Visible = false;
            picAz8.Visible = false;
            picAz9.Visible = false;
            picAz10.Visible = false;
            picAz11.Visible = false;
            picAz12.Visible = false;

            picVd2.Visible = false;
            picVd3.Visible = false;
            picVd4.Visible = false;
            picVd5.Visible = false;
            picVd6.Visible = false;
            picVd7.Visible = false;
            picVd8.Visible = false;
            picVd9.Visible = false;
            picVd10.Visible = false;
            picVd11.Visible = false;
            picVd12.Visible = false;

            picAm2.Visible = false;
            picAm3.Visible = false;
            picAm4.Visible = false;
            picAm5.Visible = false;
            picAm6.Visible = false;
            picAm7.Visible = false;
            picAm8.Visible = false;
            picAm9.Visible = false;
            picAm10.Visible = false;
            picAm11.Visible = false;
            picAm12.Visible = false;

            string tabuleiro = Jogo.ExibirTabuleiro(IdPartida);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] linha = tabuleiro.Split('\n');
            for (int d = 0; d < linha.Length - 1; d++)
            {
                string[] x = linha[d].Split(',');

                if (x[3] != "B")
                {
                    alp = true;
                }
                else
                {
                    alp = false;
                }


                if (x[2] == Cor[0])
                {
                    y = 1;
                }
                else if (x[2] == Cor[1])
                {
                    y = 2;
                }
                else if (x[2] == Cor[2])
                {
                    y = 3;
                }
                else if (x[2] == Cor[3])
                {
                    y = 4;
                }

                switch (alp)
                {
                    case true:
                        switch (x[0])
                        {
                            case "2":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp2.Visible = true;
                                        break;
                                    case "2":
                                        picAlp2.Visible = true;
                                        picAlp2.Top = 294;
                                        break;
                                    case "3":
                                        picAlp2.Visible = true;
                                        picAlp2.Top = 259;
                                        break;
                                }
                                break;
                            case "3":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp3.Visible = true;
                                        break;
                                    case "2":
                                        picAlp3.Visible = true;
                                        picAlp3.Top = 329;
                                        break;
                                    case "3":
                                        picAlp3.Visible = true;
                                        picAlp3.Top = 294;
                                        break;
                                    case "4":
                                        picAlp3.Visible = true;
                                        picAlp3.Top = 259;
                                        break;
                                    case "5":
                                        picAlp3.Visible = true;
                                        picAlp3.Top = 224;
                                        break;
                                }
                                break;
                            case "4":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp4.Visible = true;
                                        break;
                                    case "2":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 364;
                                        break;
                                    case "3":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 329;
                                        break;
                                    case "4":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 294;
                                        break;
                                    case "5":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 259;
                                        break;
                                    case "6":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 224;
                                        break;
                                    case "7":
                                        picAlp4.Visible = true;
                                        picAlp4.Top = 189;
                                        break;
                                }
                                break;

                            case "5":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp5.Visible = true;
                                        break;
                                    case "2":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 399;
                                        break;
                                    case "3":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 364;
                                        break;
                                    case "4":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 329;
                                        break;
                                    case "5":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 294;
                                        break;
                                    case "6":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 259;
                                        break;
                                    case "7":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 224;
                                        break;
                                    case "8":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 189;
                                        break;
                                    case "9":
                                        picAlp5.Visible = true;
                                        picAlp5.Top = 154;
                                        break;
                                }
                                break;
                            case "6":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp6.Visible = true;
                                        break;
                                    case "2":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 434;
                                        break;
                                    case "3":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 399;
                                        break;
                                    case "4":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 364;
                                        break;
                                    case "5":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 329;
                                        break;
                                    case "6":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 294;
                                        break;
                                    case "7":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 259;
                                        break;
                                    case "8":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 224;
                                        break;
                                    case "9":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 189;
                                        break;
                                    case "10":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 154;
                                        break;
                                    case "11":
                                        picAlp6.Visible = true;
                                        picAlp6.Top = 119;
                                        break;
                                }
                                break;
                            case "7":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp7.Visible = true;
                                        break;
                                    case "2":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 469;
                                        break;
                                    case "3":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 434;
                                        break;
                                    case "4":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 399;
                                        break;
                                    case "5":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 364;
                                        break;
                                    case "6":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 329;
                                        break;
                                    case "7":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 294;
                                        break;
                                    case "8":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 259;
                                        break;
                                    case "9":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 224;
                                        break;
                                    case "10":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 189;
                                        break;
                                    case "11":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 154;
                                        break;
                                    case "12":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 119;
                                        break;
                                    case "13":
                                        picAlp7.Visible = true;
                                        picAlp7.Top = 84;
                                        break;
                                }
                                break;
                            case "8":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp8.Visible = true;
                                        break;
                                    case "2":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 434;
                                        break;
                                    case "3":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 399;
                                        break;
                                    case "4":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 364;
                                        break;
                                    case "5":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 329;
                                        break;
                                    case "6":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 294;
                                        break;
                                    case "7":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 259;
                                        break;
                                    case "8":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 224;
                                        break;
                                    case "9":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 189;
                                        break;
                                    case "10":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 154;
                                        break;
                                    case "11":
                                        picAlp8.Visible = true;
                                        picAlp8.Top = 119;
                                        break;
                                }
                                break;
                            case "9":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp9.Visible = true;
                                        break;
                                    case "2":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 399;
                                        break;
                                    case "3":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 364;
                                        break;
                                    case "4":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 329;
                                        break;
                                    case "5":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 294;
                                        break;
                                    case "6":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 259;
                                        break;
                                    case "7":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 224;
                                        break;
                                    case "8":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 189;
                                        break;
                                    case "9":
                                        picAlp9.Visible = true;
                                        picAlp9.Top = 154;
                                        break;
                                }
                                break;
                            case "10":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp10.Visible = true;
                                        break;
                                    case "2":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 364;
                                        break;
                                    case "3":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 329;
                                        break;
                                    case "4":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 294;
                                        break;
                                    case "5":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 259;
                                        break;
                                    case "6":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 224;
                                        break;
                                    case "7":
                                        picAlp10.Visible = true;
                                        picAlp10.Top = 189;
                                        break;
                                }
                                break;
                            case "11":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp11.Visible = true;
                                        break;
                                    case "2":
                                        picAlp11.Visible = true;
                                        picAlp11.Top = 329;
                                        break;
                                    case "3":
                                        picAlp11.Visible = true;
                                        picAlp11.Top = 294;
                                        break;
                                    case "4":
                                        picAlp11.Visible = true;
                                        picAlp11.Top = 259;
                                        break;
                                    case "5":
                                        picAlp11.Visible = true;
                                        picAlp11.Top = 224;
                                        break;
                                }
                                break;
                            case "12":
                                switch (x[1])
                                {
                                    case "1":
                                        picAlp12.Visible = true;
                                        break;
                                    case "2":
                                        picAlp12.Visible = true;
                                        picAlp12.Top = 294;
                                        break;
                                    case "3":
                                        picAlp12.Visible = true;
                                        picAlp12.Top = 259;
                                        break;
                                }
                                break;
                        }
                        break;



                    case false:
                        switch (y)
                        {
                            case 1:
                                switch (x[0])
                                {
                                    case "2":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm2.Visible = true;
                                                break;
                                            case "2":
                                                picVm2.Visible = true;
                                                picVm2.Top = 292;
                                                break;
                                            case "3":
                                                picVm2.Visible = true;
                                                picVm2.Top = 257;
                                                break;
                                        }
                                        break;
                                    case "3":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm3.Visible = true;
                                                break;
                                            case "2":
                                                picVm3.Visible = true;
                                                picVm3.Top = 327;
                                                break;
                                            case "3":
                                                picVm3.Visible = true;
                                                picVm3.Top = 292;
                                                break;
                                            case "4":
                                                picVm3.Visible = true;
                                                picVm3.Top = 257;
                                                break;
                                            case "5":
                                                picVm3.Visible = true;
                                                picVm3.Top = 222;
                                                break;
                                        }
                                        break;
                                    case "4":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm4.Visible = true;
                                                break;
                                            case "2":
                                                picVm4.Visible = true;
                                                picVm4.Top = 362;
                                                break;
                                            case "3":
                                                picVm4.Visible = true;
                                                picVm4.Top = 327;
                                                break;
                                            case "4":
                                                picVm4.Visible = true;
                                                picVm4.Top = 292;
                                                break;
                                            case "5":
                                                picVm4.Visible = true;
                                                picVm4.Top = 257;
                                                break;
                                            case "6":
                                                picVm4.Visible = true;
                                                picVm4.Top = 222;
                                                break;
                                            case "7":
                                                picVm4.Visible = true;
                                                picVm4.Top = 187;
                                                break;
                                        }
                                        break;

                                    case "5":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm5.Visible = true;
                                                break;
                                            case "2":
                                                picVm5.Visible = true;
                                                picVm5.Top = 397;
                                                break;
                                            case "3":
                                                picVm5.Visible = true;
                                                picVm5.Top = 362;
                                                break;
                                            case "4":
                                                picVm5.Visible = true;
                                                picVm5.Top = 327;
                                                break;
                                            case "5":
                                                picVm5.Visible = true;
                                                picVm5.Top = 292;
                                                break;
                                            case "6":
                                                picVm5.Visible = true;
                                                picVm5.Top = 257;
                                                break;
                                            case "7":
                                                picVm5.Visible = true;
                                                picVm5.Top = 222;
                                                break;
                                            case "8":
                                                picVm5.Visible = true;
                                                picVm5.Top = 187;
                                                break;
                                            case "9":
                                                picVm5.Visible = true;
                                                picVm5.Top = 152;
                                                break;
                                        }
                                        break;
                                    case "6":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm6.Visible = true;
                                                break;
                                            case "2":
                                                picVm6.Visible = true;
                                                picVm6.Top = 432;
                                                break;
                                            case "3":
                                                picVm6.Visible = true;
                                                picVm6.Top = 397;
                                                break;
                                            case "4":
                                                picVm6.Visible = true;
                                                picVm6.Top = 362;
                                                break;
                                            case "5":
                                                picVm6.Visible = true;
                                                picVm6.Top = 327;
                                                break;
                                            case "6":
                                                picVm6.Visible = true;
                                                picVm6.Top = 292;
                                                break;
                                            case "7":
                                                picVm6.Visible = true;
                                                picVm6.Top = 257;
                                                break;
                                            case "8":
                                                picVm6.Visible = true;
                                                picVm6.Top = 222;
                                                break;
                                            case "9":
                                                picVm6.Visible = true;
                                                picVm6.Top = 187;
                                                break;
                                            case "10":
                                                picVm6.Visible = true;
                                                picVm6.Top = 152;
                                                break;
                                            case "11":
                                                picVm6.Visible = true;
                                                picVm6.Top = 117;
                                                break;
                                        }
                                        break;
                                    case "7":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm7.Visible = true;
                                                break;
                                            case "2":
                                                picVm7.Visible = true;
                                                picVm7.Top = 467;
                                                break;
                                            case "3":
                                                picVm7.Visible = true;
                                                picVm7.Top = 432;
                                                break;
                                            case "4":
                                                picVm7.Visible = true;
                                                picVm7.Top = 397;
                                                break;
                                            case "5":
                                                picVm7.Visible = true;
                                                picVm7.Top = 362;
                                                break;
                                            case "6":
                                                picVm7.Visible = true;
                                                picVm7.Top = 327;
                                                break;
                                            case "7":
                                                picVm7.Visible = true;
                                                picVm7.Top = 292;
                                                break;
                                            case "8":
                                                picVm7.Visible = true;
                                                picVm7.Top = 257;
                                                break;
                                            case "9":
                                                picVm7.Visible = true;
                                                picVm7.Top = 222;
                                                break;
                                            case "10":
                                                picVm7.Visible = true;
                                                picVm7.Top = 187;
                                                break;
                                            case "11":
                                                picVm7.Visible = true;
                                                picVm7.Top = 152;
                                                break;
                                            case "12":
                                                picVm7.Visible = true;
                                                picVm7.Top = 117;
                                                break;
                                            case "13":
                                                picVm7.Visible = true;
                                                picVm7.Top = 82;
                                                break;
                                        }
                                        break;
                                    case "8":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm8.Visible = true;
                                                break;
                                            case "2":
                                                picVm8.Visible = true;
                                                picVm8.Top = 432;
                                                break;
                                            case "3":
                                                picVm8.Visible = true;
                                                picVm8.Top = 397;
                                                break;
                                            case "4":
                                                picVm8.Visible = true;
                                                picVm8.Top = 362;
                                                break;
                                            case "5":
                                                picVm8.Visible = true;
                                                picVm8.Top = 327;
                                                break;
                                            case "6":
                                                picVm8.Visible = true;
                                                picVm8.Top = 292;
                                                break;
                                            case "7":
                                                picVm8.Visible = true;
                                                picVm8.Top = 257;
                                                break;
                                            case "8":
                                                picVm8.Visible = true;
                                                picVm8.Top = 222;
                                                break;
                                            case "9":
                                                picVm8.Visible = true;
                                                picVm8.Top = 187;
                                                break;
                                            case "10":
                                                picVm8.Visible = true;
                                                picVm8.Top = 152;
                                                break;
                                            case "11":
                                                picVm8.Visible = true;
                                                picVm8.Top = 117;
                                                break;
                                        }
                                        break;
                                    case "9":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm9.Visible = true;
                                                break;
                                            case "2":
                                                picVm9.Visible = true;
                                                picVm9.Top = 397;
                                                break;
                                            case "3":
                                                picVm9.Visible = true;
                                                picVm9.Top = 362;
                                                break;
                                            case "4":
                                                picVm9.Visible = true;
                                                picVm9.Top = 327;
                                                break;
                                            case "5":
                                                picVm9.Visible = true;
                                                picVm9.Top = 292;
                                                break;
                                            case "6":
                                                picVm9.Visible = true;
                                                picVm9.Top = 257;
                                                break;
                                            case "7":
                                                picVm9.Visible = true;
                                                picVm9.Top = 222;
                                                break;
                                            case "8":
                                                picVm9.Visible = true;
                                                picVm9.Top = 187;
                                                break;
                                            case "9":
                                                picVm9.Visible = true;
                                                picVm9.Top = 152;
                                                break;
                                        }
                                        break;
                                    case "10":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm10.Visible = true;
                                                break;
                                            case "2":
                                                picVm10.Visible = true;
                                                picVm10.Top = 362;
                                                break;
                                            case "3":
                                                picVm10.Visible = true;
                                                picVm10.Top = 327;
                                                break;
                                            case "4":
                                                picVm10.Visible = true;
                                                picVm10.Top = 292;
                                                break;
                                            case "5":
                                                picVm10.Visible = true;
                                                picVm10.Top = 257;
                                                break;
                                            case "6":
                                                picVm10.Visible = true;
                                                picVm10.Top = 222;
                                                break;
                                            case "7":
                                                picVm10.Visible = true;
                                                picVm10.Top = 187;
                                                break;
                                        }
                                        break;
                                    case "11":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm11.Visible = true;
                                                break;
                                            case "2":
                                                picVm11.Visible = true;
                                                picVm11.Top = 327;
                                                break;
                                            case "3":
                                                picVm11.Visible = true;
                                                picVm11.Top = 292;
                                                break;
                                            case "4":
                                                picVm11.Visible = true;
                                                picVm11.Top = 257;
                                                break;
                                            case "5":
                                                picVm11.Visible = true;
                                                picVm11.Top = 222;
                                                break;
                                        }
                                        break;
                                    case "12":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVm12.Visible = true;
                                                break;
                                            case "2":
                                                picVm12.Visible = true;
                                                picVm12.Top = 292;
                                                break;
                                            case "3":
                                                picVm12.Visible = true;
                                                picVm12.Top = 257;
                                                break;
                                        }
                                        break;
                                }
                                break;





                            case 2:
                                switch (x[0])
                                {
                                    case "2":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz2.Visible = true;
                                                break;
                                            case "2":
                                                picAz2.Visible = true;
                                                picAz2.Top = 292;
                                                break;
                                            case "3":
                                                picAz2.Visible = true;
                                                picAz2.Top = 257;
                                                break;
                                        }
                                        break;
                                    case "3":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz3.Visible = true;
                                                break;
                                            case "2":
                                                picAz3.Visible = true;
                                                picAz3.Top = 327;
                                                break;
                                            case "3":
                                                picAz3.Visible = true;
                                                picAz3.Top = 292;
                                                break;
                                            case "4":
                                                picAz3.Visible = true;
                                                picAz3.Top = 257;
                                                break;
                                            case "5":
                                                picAz3.Visible = true;
                                                picAz3.Top = 222;
                                                break;
                                        }
                                        break;
                                    case "4":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz4.Visible = true;
                                                break;
                                            case "2":
                                                picAz4.Visible = true;
                                                picAz4.Top = 362;
                                                break;
                                            case "3":
                                                picAz4.Visible = true;
                                                picAz4.Top = 327;
                                                break;
                                            case "4":
                                                picAz4.Visible = true;
                                                picAz4.Top = 292;
                                                break;
                                            case "5":
                                                picAz4.Visible = true;
                                                picAz4.Top = 257;
                                                break;
                                            case "6":
                                                picAz4.Visible = true;
                                                picAz4.Top = 222;
                                                break;
                                            case "7":
                                                picAz4.Visible = true;
                                                picAz4.Top = 187;
                                                break;
                                        }
                                        break;

                                    case "5":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz5.Visible = true;
                                                break;
                                            case "2":
                                                picAz5.Visible = true;
                                                picAz5.Top = 397;
                                                break;
                                            case "3":
                                                picAz5.Visible = true;
                                                picAz5.Top = 362;
                                                break;
                                            case "4":
                                                picAz5.Visible = true;
                                                picAz5.Top = 327;
                                                break;
                                            case "5":
                                                picAz5.Visible = true;
                                                picAz5.Top = 292;
                                                break;
                                            case "6":
                                                picAz5.Visible = true;
                                                picAz5.Top = 257;
                                                break;
                                            case "7":
                                                picAz5.Visible = true;
                                                picAz5.Top = 222;
                                                break;
                                            case "8":
                                                picAz5.Visible = true;
                                                picAz5.Top = 187;
                                                break;
                                            case "9":
                                                picAz5.Visible = true;
                                                picAz5.Top = 152;
                                                break;
                                        }
                                        break;
                                    case "6":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz6.Visible = true;
                                                break;
                                            case "2":
                                                picAz6.Visible = true;
                                                picAz6.Top = 432;
                                                break;
                                            case "3":
                                                picAz6.Visible = true;
                                                picAz6.Top = 397;
                                                break;
                                            case "4":
                                                picAz6.Visible = true;
                                                picAz6.Top = 362;
                                                break;
                                            case "5":
                                                picAz6.Visible = true;
                                                picAz6.Top = 327;
                                                break;
                                            case "6":
                                                picAz6.Visible = true;
                                                picAz6.Top = 292;
                                                break;
                                            case "7":
                                                picAz6.Visible = true;
                                                picAz6.Top = 257;
                                                break;
                                            case "8":
                                                picAz6.Visible = true;
                                                picAz6.Top = 222;
                                                break;
                                            case "9":
                                                picAz6.Visible = true;
                                                picAz6.Top = 187;
                                                break;
                                            case "10":
                                                picAz6.Visible = true;
                                                picAz6.Top = 152;
                                                break;
                                            case "11":
                                                picAz6.Visible = true;
                                                picAz6.Top = 117;
                                                break;
                                        }
                                        break;
                                    case "7":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz7.Visible = true;
                                                break;
                                            case "2":
                                                picAz7.Visible = true;
                                                picAz7.Top = 467;
                                                break;
                                            case "3":
                                                picAz7.Visible = true;
                                                picAz7.Top = 432;
                                                break;
                                            case "4":
                                                picAz7.Visible = true;
                                                picAz7.Top = 397;
                                                break;
                                            case "5":
                                                picAz7.Visible = true;
                                                picAz7.Top = 362;
                                                break;
                                            case "6":
                                                picAz7.Visible = true;
                                                picAz7.Top = 327;
                                                break;
                                            case "7":
                                                picAz7.Visible = true;
                                                picAz7.Top = 292;
                                                break;
                                            case "8":
                                                picAz7.Visible = true;
                                                picAz7.Top = 257;
                                                break;
                                            case "9":
                                                picAz7.Visible = true;
                                                picAz7.Top = 222;
                                                break;
                                            case "10":
                                                picAz7.Visible = true;
                                                picAz7.Top = 187;
                                                break;
                                            case "11":
                                                picAz7.Visible = true;
                                                picAz7.Top = 152;
                                                break;
                                            case "12":
                                                picAz7.Visible = true;
                                                picAz7.Top = 117;
                                                break;
                                            case "13":
                                                picAz7.Visible = true;
                                                picAz7.Top = 82;
                                                break;
                                        }
                                        break;
                                    case "8":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz8.Visible = true;
                                                break;
                                            case "2":
                                                picAz8.Visible = true;
                                                picAz8.Top = 432;
                                                break;
                                            case "3":
                                                picAz8.Visible = true;
                                                picAz8.Top = 397;
                                                break;
                                            case "4":
                                                picAz8.Visible = true;
                                                picAz8.Top = 362;
                                                break;
                                            case "5":
                                                picAz8.Visible = true;
                                                picAz8.Top = 327;
                                                break;
                                            case "6":
                                                picAz8.Visible = true;
                                                picAz8.Top = 292;
                                                break;
                                            case "7":
                                                picAz8.Visible = true;
                                                picAz8.Top = 257;
                                                break;
                                            case "8":
                                                picAz8.Visible = true;
                                                picAz8.Top = 222;
                                                break;
                                            case "9":
                                                picAz8.Visible = true;
                                                picAz8.Top = 187;
                                                break;
                                            case "10":
                                                picAz8.Visible = true;
                                                picAz8.Top = 152;
                                                break;
                                            case "11":
                                                picAz8.Visible = true;
                                                picAz8.Top = 117;
                                                break;
                                        }
                                        break;
                                    case "9":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz9.Visible = true;
                                                break;
                                            case "2":
                                                picAz9.Visible = true;
                                                picAz9.Top = 397;
                                                break;
                                            case "3":
                                                picAz9.Visible = true;
                                                picAz9.Top = 362;
                                                break;
                                            case "4":
                                                picAz9.Visible = true;
                                                picAz9.Top = 327;
                                                break;
                                            case "5":
                                                picAz9.Visible = true;
                                                picAz9.Top = 292;
                                                break;
                                            case "6":
                                                picAz9.Visible = true;
                                                picAz9.Top = 257;
                                                break;
                                            case "7":
                                                picAz9.Visible = true;
                                                picAz9.Top = 222;
                                                break;
                                            case "8":
                                                picAz9.Visible = true;
                                                picAz9.Top = 187;
                                                break;
                                            case "9":
                                                picAz9.Visible = true;
                                                picAz9.Top = 152;
                                                break;
                                        }
                                        break;
                                    case "10":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz10.Visible = true;
                                                break;
                                            case "2":
                                                picAz10.Visible = true;
                                                picAz10.Top = 362;
                                                break;
                                            case "3":
                                                picAz10.Visible = true;
                                                picAz10.Top = 327;
                                                break;
                                            case "4":
                                                picAz10.Visible = true;
                                                picAz10.Top = 292;
                                                break;
                                            case "5":
                                                picAz10.Visible = true;
                                                picAz10.Top = 257;
                                                break;
                                            case "6":
                                                picAz10.Visible = true;
                                                picAz10.Top = 222;
                                                break;
                                            case "7":
                                                picAz10.Visible = true;
                                                picAz10.Top = 187;
                                                break;
                                        }
                                        break;
                                    case "11":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz11.Visible = true;
                                                break;
                                            case "2":
                                                picAz11.Visible = true;
                                                picAz11.Top = 327;
                                                break;
                                            case "3":
                                                picAz11.Visible = true;
                                                picAz11.Top = 292;
                                                break;
                                            case "4":
                                                picAz11.Visible = true;
                                                picAz11.Top = 257;
                                                break;
                                            case "5":
                                                picAz11.Visible = true;
                                                picAz11.Top = 222;
                                                break;
                                        }
                                        break;
                                    case "12":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAz12.Visible = true;
                                                break;
                                            case "2":
                                                picAz12.Visible = true;
                                                picAz12.Top = 292;
                                                break;
                                            case "3":
                                                picAz12.Visible = true;
                                                picAz12.Top = 257;
                                                break;
                                        }
                                        break;
                                }
                                break;





                            case 3:
                                switch (x[0])
                                {
                                    case "2":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd2.Visible = true;
                                                break;
                                            case "2":
                                                picVd2.Visible = true;
                                                picVd2.Top = 309;
                                                break;
                                            case "3":
                                                picVd2.Visible = true;
                                                picVd2.Top = 274;
                                                break;
                                        }
                                        break;
                                    case "3":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd3.Visible = true;
                                                break;
                                            case "2":
                                                picVd3.Visible = true;
                                                picVd3.Top = 344;
                                                break;
                                            case "3":
                                                picVd3.Visible = true;
                                                picVd3.Top = 309;
                                                break;
                                            case "4":
                                                picVd3.Visible = true;
                                                picVd3.Top = 274;
                                                break;
                                            case "5":
                                                picVd3.Visible = true;
                                                picVd3.Top = 239;
                                                break;
                                        }
                                        break;
                                    case "4":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd4.Visible = true;
                                                break;
                                            case "2":
                                                picVd4.Visible = true;
                                                picVd4.Top = 379;
                                                break;
                                            case "3":
                                                picVd4.Visible = true;
                                                picVd4.Top = 344;
                                                break;
                                            case "4":
                                                picVd4.Visible = true;
                                                picVd4.Top = 309;
                                                break;
                                            case "5":
                                                picVd4.Visible = true;
                                                picVd4.Top = 274;
                                                break;
                                            case "6":
                                                picVd4.Visible = true;
                                                picVd4.Top = 239;
                                                break;
                                            case "7":
                                                picVd4.Visible = true;
                                                picVd4.Top = 204;
                                                break;
                                        }
                                        break;
                                    case "5":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd5.Visible = true;
                                                break;
                                            case "2":
                                                picVd5.Visible = true;
                                                picVd5.Top = 414;
                                                break;
                                            case "3":
                                                picVd5.Visible = true;
                                                picVd5.Top = 379;
                                                break;
                                            case "4":
                                                picVd5.Visible = true;
                                                picVd5.Top = 344;
                                                break;
                                            case "5":
                                                picVd5.Visible = true;
                                                picVd5.Top = 309;
                                                break;
                                            case "6":
                                                picVd5.Visible = true;
                                                picVd5.Top = 274;
                                                break;
                                            case "7":
                                                picVd5.Visible = true;
                                                picVd5.Top = 239;
                                                break;
                                            case "8":
                                                picVd5.Visible = true;
                                                picVd5.Top = 204;
                                                break;
                                            case "9":
                                                picVd5.Visible = true;
                                                picVd5.Top = 169;
                                                break;
                                        }
                                        break;
                                    case "6":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd6.Visible = true;
                                                break;
                                            case "2":
                                                picVd6.Visible = true;
                                                picVd6.Top = 449;
                                                break;
                                            case "3":
                                                picVd6.Visible = true;
                                                picVd6.Top = 414;
                                                break;
                                            case "4":
                                                picVd6.Visible = true;
                                                picVd6.Top = 379;
                                                break;
                                            case "5":
                                                picVd6.Visible = true;
                                                picVd6.Top = 344;
                                                break;
                                            case "6":
                                                picVd6.Visible = true;
                                                picVd6.Top = 309;
                                                break;
                                            case "7":
                                                picVd6.Visible = true;
                                                picVd6.Top = 274;
                                                break;
                                            case "8":
                                                picVd6.Visible = true;
                                                picVd6.Top = 239;
                                                break;
                                            case "9":
                                                picVd6.Visible = true;
                                                picVd6.Top = 204;
                                                break;
                                            case "10":
                                                picVd6.Visible = true;
                                                picVd6.Top = 169;
                                                break;
                                            case "11":
                                                picVd6.Visible = true;
                                                picVd6.Top = 134;
                                                break;
                                        }
                                        break;
                                    case "7":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd7.Visible = true;
                                                break;
                                            case "2":
                                                picVd7.Visible = true;
                                                picVd7.Top = 484;
                                                break;
                                            case "3":
                                                picVd7.Visible = true;
                                                picVd7.Top = 449;
                                                break;
                                            case "4":
                                                picVd7.Visible = true;
                                                picVd7.Top = 414;
                                                break;
                                            case "5":
                                                picVd7.Visible = true;
                                                picVd7.Top = 379;
                                                break;
                                            case "6":
                                                picVd7.Visible = true;
                                                picVd7.Top = 344;
                                                break;
                                            case "7":
                                                picVd7.Visible = true;
                                                picVd7.Top = 309;
                                                break;
                                            case "8":
                                                picVd7.Visible = true;
                                                picVd7.Top = 274;
                                                break;
                                            case "9":
                                                picVd7.Visible = true;
                                                picVd7.Top = 239;
                                                break;
                                            case "10":
                                                picVd7.Visible = true;
                                                picVd7.Top = 204;
                                                break;
                                            case "11":
                                                picVd7.Visible = true;
                                                picVd7.Top = 169;
                                                break;
                                            case "12":
                                                picVd7.Visible = true;
                                                picVd7.Top = 134;
                                                break;
                                            case "13":
                                                picVd7.Visible = true;
                                                picVd7.Top = 99;
                                                break;
                                        }
                                        break;
                                    case "8":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd8.Visible = true;
                                                break;
                                            case "2":
                                                picVd8.Visible = true;
                                                picVd8.Top = 449;
                                                break;
                                            case "3":
                                                picVd8.Visible = true;
                                                picVd8.Top = 414;
                                                break;
                                            case "4":
                                                picVd8.Visible = true;
                                                picVd8.Top = 379;
                                                break;
                                            case "5":
                                                picVd8.Visible = true;
                                                picVd8.Top = 344;
                                                break;
                                            case "6":
                                                picVd8.Visible = true;
                                                picVd8.Top = 309;
                                                break;
                                            case "7":
                                                picVd8.Visible = true;
                                                picVd8.Top = 274;
                                                break;
                                            case "8":
                                                picVd8.Visible = true;
                                                picVd8.Top = 239;
                                                break;
                                            case "9":
                                                picVd8.Visible = true;
                                                picVd8.Top = 204;
                                                break;
                                            case "10":
                                                picVd8.Visible = true;
                                                picVd8.Top = 169;
                                                break;
                                            case "11":
                                                picVd8.Visible = true;
                                                picVd8.Top = 134;
                                                break;
                                        }
                                        break;
                                    case "9":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd9.Visible = true;
                                                break;
                                            case "2":
                                                picVd9.Visible = true;
                                                picVd9.Top = 414;
                                                break;
                                            case "3":
                                                picVd9.Visible = true;
                                                picVd9.Top = 379;
                                                break;
                                            case "4":
                                                picVd9.Visible = true;
                                                picVd9.Top = 344;
                                                break;
                                            case "5":
                                                picVd9.Visible = true;
                                                picVd9.Top = 309;
                                                break;
                                            case "6":
                                                picVd9.Visible = true;
                                                picVd9.Top = 274;
                                                break;
                                            case "7":
                                                picVd9.Visible = true;
                                                picVd9.Top = 239;
                                                break;
                                            case "8":
                                                picVd9.Visible = true;
                                                picVd9.Top = 204;
                                                break;
                                            case "9":
                                                picVd9.Visible = true;
                                                picVd9.Top = 169;
                                                break;
                                        }
                                        break;
                                    case "10":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd10.Visible = true;
                                                break;
                                            case "2":
                                                picVd10.Visible = true;
                                                picVd10.Top = 379;
                                                break;
                                            case "3":
                                                picVd10.Visible = true;
                                                picVd10.Top = 344;
                                                break;
                                            case "4":
                                                picVd10.Visible = true;
                                                picVd10.Top = 309;
                                                break;
                                            case "5":
                                                picVd10.Visible = true;
                                                picVd10.Top = 274;
                                                break;
                                            case "6":
                                                picVd10.Visible = true;
                                                picVd10.Top = 239;
                                                break;
                                            case "7":
                                                picVd10.Visible = true;
                                                picVd10.Top = 204;
                                                break;
                                        }
                                        break;
                                    case "11":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd11.Visible = true;
                                                break;
                                            case "2":
                                                picVd11.Visible = true;
                                                picVd11.Top = 344;
                                                break;
                                            case "3":
                                                picVd11.Visible = true;
                                                picVd11.Top = 309;
                                                break;
                                            case "4":
                                                picVd11.Visible = true;
                                                picVd11.Top = 274;
                                                break;
                                            case "5":
                                                picVd11.Visible = true;
                                                picVd11.Top = 239;
                                                break;
                                        }
                                        break;
                                    case "12":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picVd12.Visible = true;
                                                break;
                                            case "2":
                                                picVd12.Visible = true;
                                                picVd12.Top = 309;
                                                break;
                                            case "3":
                                                picVd12.Visible = true;
                                                picVd12.Top = 274;
                                                break;
                                        }
                                        break;
                                }
                                break;




                            case 4:
                                switch (x[0])
                                {
                                    case "2":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm2.Visible = true;
                                                break;
                                            case "2":
                                                picAm2.Visible = true;
                                                picAm2.Top = 309;
                                                break;
                                            case "3":
                                                picAm2.Visible = true;
                                                picAm2.Top = 274;
                                                break;
                                        }
                                        break;
                                    case "3":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm3.Visible = true;
                                                break;
                                            case "2":
                                                picAm3.Visible = true;
                                                picAm3.Top = 344;
                                                break;
                                            case "3":
                                                picAm3.Visible = true;
                                                picAm3.Top = 309;
                                                break;
                                            case "4":
                                                picAm3.Visible = true;
                                                picAm3.Top = 274;
                                                break;
                                            case "5":
                                                picAm3.Visible = true;
                                                picAm3.Top = 239;
                                                break;
                                        }
                                        break;
                                    case "4":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm4.Visible = true;
                                                break;
                                            case "2":
                                                picAm4.Visible = true;
                                                picAm4.Top = 379;
                                                break;
                                            case "3":
                                                picAm4.Visible = true;
                                                picAm4.Top = 344;
                                                break;
                                            case "4":
                                                picAm4.Visible = true;
                                                picAm4.Top = 309;
                                                break;
                                            case "5":
                                                picAm4.Visible = true;
                                                picAm4.Top = 274;
                                                break;
                                            case "6":
                                                picAm4.Visible = true;
                                                picAm4.Top = 239;
                                                break;
                                            case "7":
                                                picAm4.Visible = true;
                                                picAm4.Top = 204;
                                                break;
                                        }
                                        break;
                                    case "5":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm5.Visible = true;
                                                break;
                                            case "2":
                                                picAm5.Visible = true;
                                                picAm5.Top = 414;
                                                break;
                                            case "3":
                                                picAm5.Visible = true;
                                                picAm5.Top = 379;
                                                break;
                                            case "4":
                                                picAm5.Visible = true;
                                                picAm5.Top = 344;
                                                break;
                                            case "5":
                                                picAm5.Visible = true;
                                                picAm5.Top = 309;
                                                break;
                                            case "6":
                                                picAm5.Visible = true;
                                                picAm5.Top = 274;
                                                break;
                                            case "7":
                                                picAm5.Visible = true;
                                                picAm5.Top = 239;
                                                break;
                                            case "8":
                                                picAm5.Visible = true;
                                                picAm5.Top = 204;
                                                break;
                                            case "9":
                                                picAm5.Visible = true;
                                                picAm5.Top = 169;
                                                break;
                                        }
                                        break;
                                    case "6":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm6.Visible = true;
                                                break;
                                            case "2":
                                                picAm6.Visible = true;
                                                picAm6.Top = 449;
                                                break;
                                            case "3":
                                                picAm6.Visible = true;
                                                picAm6.Top = 414;
                                                break;
                                            case "4":
                                                picAm6.Visible = true;
                                                picAm6.Top = 379;
                                                break;
                                            case "5":
                                                picAm6.Visible = true;
                                                picAm6.Top = 344;
                                                break;
                                            case "6":
                                                picAm6.Visible = true;
                                                picAm6.Top = 309;
                                                break;
                                            case "7":
                                                picAm6.Visible = true;
                                                picAm6.Top = 274;
                                                break;
                                            case "8":
                                                picAm6.Visible = true;
                                                picAm6.Top = 239;
                                                break;
                                            case "9":
                                                picAm6.Visible = true;
                                                picAm6.Top = 204;
                                                break;
                                            case "10":
                                                picAm6.Visible = true;
                                                picAm6.Top = 169;
                                                break;
                                            case "11":
                                                picAm6.Visible = true;
                                                picAm6.Top = 134;
                                                break;
                                        }
                                        break;
                                    case "7":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm7.Visible = true;
                                                break;
                                            case "2":
                                                picAm7.Visible = true;
                                                picAm7.Top = 484;
                                                break;
                                            case "3":
                                                picAm7.Visible = true;
                                                picAm7.Top = 449;
                                                break;
                                            case "4":
                                                picAm7.Visible = true;
                                                picAm7.Top = 414;
                                                break;
                                            case "5":
                                                picAm7.Visible = true;
                                                picAm7.Top = 379;
                                                break;
                                            case "6":
                                                picAm7.Visible = true;
                                                picAm7.Top = 344;
                                                break;
                                            case "7":
                                                picAm7.Visible = true;
                                                picAm7.Top = 309;
                                                break;
                                            case "8":
                                                picAm7.Visible = true;
                                                picAm7.Top = 274;
                                                break;
                                            case "9":
                                                picAm7.Visible = true;
                                                picAm7.Top = 239;
                                                break;
                                            case "10":
                                                picAm7.Visible = true;
                                                picAm7.Top = 204;
                                                break;
                                            case "11":
                                                picAm7.Visible = true;
                                                picAm7.Top = 169;
                                                break;
                                            case "12":
                                                picAm7.Visible = true;
                                                picAm7.Top = 134;
                                                break;
                                            case "13":
                                                picAm7.Visible = true;
                                                picAm7.Top = 99;
                                                break;
                                        }
                                        break;
                                    case "8":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm8.Visible = true;
                                                break;
                                            case "2":
                                                picAm8.Visible = true;
                                                picAm8.Top = 449;
                                                break;
                                            case "3":
                                                picAm8.Visible = true;
                                                picAm8.Top = 414;
                                                break;
                                            case "4":
                                                picAm8.Visible = true;
                                                picAm8.Top = 379;
                                                break;
                                            case "5":
                                                picAm8.Visible = true;
                                                picAm8.Top = 344;
                                                break;
                                            case "6":
                                                picAm8.Visible = true;
                                                picAm8.Top = 309;
                                                break;
                                            case "7":
                                                picAm8.Visible = true;
                                                picAm8.Top = 274;
                                                break;
                                            case "8":
                                                picAm8.Visible = true;
                                                picAm8.Top = 239;
                                                break;
                                            case "9":
                                                picAm8.Visible = true;
                                                picAm8.Top = 204;
                                                break;
                                            case "10":
                                                picAm8.Visible = true;
                                                picAm8.Top = 169;
                                                break;
                                            case "11":
                                                picAm8.Visible = true;
                                                picAm8.Top = 134;
                                                break;
                                        }
                                        break;
                                    case "9":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm9.Visible = true;
                                                break;
                                            case "2":
                                                picAm9.Visible = true;
                                                picAm9.Top = 414;
                                                break;
                                            case "3":
                                                picAm9.Visible = true;
                                                picAm9.Top = 379;
                                                break;
                                            case "4":
                                                picAm9.Visible = true;
                                                picAm9.Top = 344;
                                                break;
                                            case "5":
                                                picAm9.Visible = true;
                                                picAm9.Top = 309;
                                                break;
                                            case "6":
                                                picAm9.Visible = true;
                                                picAm9.Top = 274;
                                                break;
                                            case "7":
                                                picAm9.Visible = true;
                                                picAm9.Top = 239;
                                                break;
                                            case "8":
                                                picAm9.Visible = true;
                                                picAm9.Top = 204;
                                                break;
                                            case "9":
                                                picAm9.Visible = true;
                                                picAm9.Top = 169;
                                                break;
                                        }
                                        break;
                                    case "10":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm10.Visible = true;
                                                break;
                                            case "2":
                                                picAm10.Visible = true;
                                                picAm10.Top = 379;
                                                break;
                                            case "3":
                                                picAm10.Visible = true;
                                                picAm10.Top = 344;
                                                break;
                                            case "4":
                                                picAm10.Visible = true;
                                                picAm10.Top = 309;
                                                break;
                                            case "5":
                                                picAm10.Visible = true;
                                                picAm10.Top = 274;
                                                break;
                                            case "6":
                                                picAm10.Visible = true;
                                                picAm10.Top = 239;
                                                break;
                                            case "7":
                                                picAm10.Visible = true;
                                                picAm10.Top = 204;
                                                break;
                                        }
                                        break;
                                    case "11":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm11.Visible = true;
                                                break;
                                            case "2":
                                                picAm11.Visible = true;
                                                picAm11.Top = 344;
                                                break;
                                            case "3":
                                                picAm11.Visible = true;
                                                picAm11.Top = 309;
                                                break;
                                            case "4":
                                                picAm11.Visible = true;
                                                picAm11.Top = 274;
                                                break;
                                            case "5":
                                                picAm11.Visible = true;
                                                picAm11.Top = 239;
                                                break;
                                        }
                                        break;
                                    case "12":
                                        switch (x[1])
                                        {
                                            case "1":
                                                picAm12.Visible = true;
                                                break;
                                            case "2":
                                                picAm12.Visible = true;
                                                picAm12.Top = 309;
                                                break;
                                            case "3":
                                                picAm12.Visible = true;
                                                picAm12.Top = 274;
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }

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