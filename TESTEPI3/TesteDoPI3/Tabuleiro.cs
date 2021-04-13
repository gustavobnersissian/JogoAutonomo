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
        public Tabuleiro(int idJogador, string senhaJogador)
        {
            InitializeComponent();

            this.IdJogador = idJogador;
            this.Senha = senhaJogador;
        }

      

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            // int idDado1, idDado2, idDado3, idDado4;
            int valordado1, valordado2; //valordado3, valordado4;
            int idJog = IdJogador;
            string senhaJog = Senha;

            //MessageBox.Show(idJog.ToString());
            //MessageBox.Show(senhaJog);
            string retorno = Jogo.RolarDados(idJog, senhaJog);
            

            
            
            //retorno = retorno.Replace("\r", "");

            /*if (retorno.Substring(0, 4) == "ERRO")
            {

                lblRetornoErro.Text = retorno;
            }*/
             if (retorno.Substring(0, 4) != "ERRO")
            {
                string[] linha = retorno.Split('\n');
                valordado1 = Convert.ToInt32(linha[0].Substring(1, 1));
                valordado2 = Convert.ToInt32(linha[1].Substring(1, 1));
               // valordado3 = Convert.ToInt32(linha[2].Substring(1, 1));
               // valordado4 = Convert.ToInt32(linha[3].Substring(1, 1));
               // idDado1 = Convert.ToInt32(linha[0].Substring(0,1));
               // idDado2 = Convert.ToInt32(linha[1].Substring(0, 1));
               // idDado3 = Convert.ToInt32(linha[2].Substring(0, 1));
               // idDado4 = Convert.ToInt32(linha[3].Substring(0, 1));
                textBox1.Text = valordado1.ToString();
                textBox2.Text = valordado2.ToString();
            }

        }

        
       
    }
}
