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

        Image[] img = new Image[6];
        
        public Tabuleiro(int idJogador, string senhaJogador)
        {
            InitializeComponent();
            this.IdJogador = idJogador;
            this.Senha = senhaJogador;
            img[0] = picD1.Image;
            img[1] = picD2.Image;
            img[2] = picD3.Image;
            img[3] = picD4.Image;
            img[4] = picD5.Image;
            img[5] = picD6.Image;
            

            
        }

      

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            
            string retorno = Jogo.RolarDados(IdJogador, Senha);


            int valordado1, valordado2, valordado3, valordado4;
            int idDado1, idDado2, idDado3, idDado4;
            int v1;

            retorno = retorno.Replace("\r", "");

            //picBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(x);
            if (retorno.Substring(0, 4) == "ERRO")
            {
                lblRetornoErro.Text = retorno;
            }
            else if (retorno.Substring(0, 4) != "ERRO")
            {

                string[] linha = retorno.Split('\n');
                linha[0] = lblResultados.Text;
                linha[1] = lblResultados.Text;
            }
                /*
                valordado3 = Convert.ToInt32(linha[2].Substring(1, 1));
                valordado4 = Convert.ToInt32(linha[3].Substring(1, 1));
                idDado1 = Convert.ToInt32(linha[0].Substring(0, 1));
                idDado2 = Convert.ToInt32(linha[0].Substring(0, 1));
                idDado3 = Convert.ToInt32(linha[0].Substring(0, 1));
                idDado4 = Convert.ToInt32(linha[0].Substring(0, 1));
              */         
            
        }

        
       
    }
}
