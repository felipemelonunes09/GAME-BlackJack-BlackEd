using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_Black_Edition_0._0._6
{
    public partial class InterfaceAposta : Form
    {
        public Jogo JogoSecundario; //FORM PARA PODEMOS MODIFICAR A PARTIR DAQUI
        public Jogador Player; //JOGADOR QUE ENTRADA

        public InterfaceAposta(Jogo JogoEntrado, Jogador JogadorEntrado)
        {
            this.JogoSecundario = JogoEntrado;
            this.Player = JogadorEntrado;
            InitializeComponent();
        }

        private void InterfaceAposta_Load(object sender, EventArgs e)
        {
            this.labelNomeJogador.Text = this.Player.Nome; //COLOCA O NOME DO JOGADOR
            this.labelNumeroFichas.Text = Convert.ToString(this.Player.Fichas); //CONVERTE PARA STRINNG E IMPLICA A FICHAS EM SEU LABEL
            this.labelNumeroAposta.Text = Convert.ToString(this.Player.Aposta); //CONVERTE PARA STRING E IMPLICA A APOSTA EM SEU LABEL
        }
         
        private void ColocarUmaAposta(int ValorAposta) //METODO PARA COLOCAR UMA APOSTA
        {

            if (ValorAposta > Player.Fichas) //SE O VALOR TEORICO FOR MAIOR QUE AS FICHAS
            {
                MessageBox.Show("Va com calma você não tem essas fichas", "Aviso"); //AVISO QUE ELE NAO PODE APOSTAR TUDO ISSO 
            }
            else //SE O VALOR TEORICO FOR MENO QUE AS FICHAS
            {
                this.Player.Fichas -= ValorAposta; //TIRA DAS FICHAS OI VALOR QUE QUER SE APOSTADO
                this.Player.Aposta += ValorAposta; //SOMA AO VALOR DE APOSTA

                AtualizarTextos(); //ATUALIZA OS TEXTOS E IMAGENS
            }
        }

        private void AtualizarTextos() //METODO PARA IMPLICAR OS TEXTOS
        {
            this.labelNumeroFichas.Text = Convert.ToString(this.Player.Fichas); //CONVERTE PARA STRINNG E IMPLICA A FICHAS EM SEU LABEL
            this.labelNumeroAposta.Text = Convert.ToString(this.Player.Aposta); //CONVERTE PARA STRING E IMPLICA A APOSTA EM SEU LABEL
             
            this.JogoSecundario.LabelFichas[this.Player.Numero].Text = Convert.ToString(this.Player.Fichas); //IMPLICA AS APOSTA NA INTERFACE DE JOGO 
            this.JogoSecundario.LabelAposta[this.Player.Numero].Text = Convert.ToString(this.Player.Aposta); //IMPLICA AS APOSTA NA INTERFACE DE JOGO 

            this.JogoSecundario.ConfiguradorPrimario.ConfigurarPicFichas(Player.Fichas, this.JogoSecundario.PictureBoxFichas[Player.Numero]); //CONFIGURAR AS IMAGENS DE FICHAS

        }

        private void PictureBox50Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(50); //COLOCAR UMA APOSTA DE 50
        }

        private void PictureBox125Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(125); //COLOCAR UMA APOSTA DE 125
        }

        private void pictureBox250Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(250); //COLOCAR UMA APOSTA DE 250
        }

        private void pictureBox500Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(500); //COLOCAR UMA APOSTA DE 500
        }

        private void pictureBox1000Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(1000); //COLOCAR UMA APOSTA DE 1000
        }

        private void pictureBox5000Fichas_Click(object sender, EventArgs e)
        {
            ColocarUmaAposta(5000); //COLOCAR UMA APOSTA DE 5000
        }

        private void labelConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
