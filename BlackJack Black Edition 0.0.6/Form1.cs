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
    public partial class MenuInicial : Form
    {
        public Configurador ConfigurandoInicial = new Configurador(); //CRIA O PRIMEIRO CONFIGURADOR QUE IRA SER PASSADO ADIANTE

        public MenuInicial()
        {
            InitializeComponent();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            AjeitaTela();
       }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if(this.ConfigurandoInicial.ConfirmarAlgo("Você tem certeza que quer sair do jogo?")) { this.Close(); } //SE O RETORNO FOR VERDADEIRO FECHA A INSTANCIA
        }

        private void BlackJackLogo_Click(object sender, EventArgs e)
        {
        }

        private void UmJogador_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "") { InstanciarNovoMenu(); } //SE TIVER UM NOME INSTANCIA OUTRO MENU
            else { MessageBox.Show("Digite um Nome","Aviso!!!"); } //SENAO MANDA UM AVISO
        }

        private void AjeitaTela() //AJEITA CONDIGURAÇÃO DE TELA
        {
            //COLOCANDO A LOGO NO LUGAR CERTO 


            Point PonteiroLogo = new Point( Convert.ToInt32((this.Width - 349) / 2), Convert.ToInt32((this.Height - 500) / 2) );
            this.BlackJackLogo.Location = PonteiroLogo;

            //==========================================


            //COLOCNDO O TEXT BOX NO LUGAR CERTO

            Point PonteiroCaixaTexto = new Point(Convert.ToInt32((this.Width - 278) / 2), Convert.ToInt32(this.Height - (-70)) / 2);
            this.textBox5.Location = PonteiroCaixaTexto;

            //COLOCA O BOTAO NO LUGAR CERTO

            Point PonteiroBotao = new Point( Convert.ToInt32((this.Width - 157) / 2), Convert.ToInt32(this.Height - (-300)) / 2);
            this.UmJogador.Location = PonteiroBotao;
        }

       

       




        private void MultiJogadores_Click(object sender, EventArgs e)
        {
        }

        private void SairUmJogador_Click(object sender, EventArgs e)
        {
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoJogador0_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = ""; //QUANDO CLIKADO MUDA O TEXTO PARA NADA UE
        }

        private void QuantidadeJogadoresText_Click(object sender, EventArgs e)
        {
        }

        private void OK_Click(object sender, EventArgs e)
        {
        }

        private void InstanciarNovoMenu() 
        {
            this.ConfigurandoInicial.Jogadores[1].Nome = "Dealer"; //SETA  NOME DO JOGADOR 1 COMO DEALER

            this.ConfigurandoInicial.Jogadores[0].Nome = textBox5.Text; //COLOCA O NOME INSTANCIADO NO JOGADOR DO VETOR
            this.ConfigurandoInicial.Jogadores[0].ValidadorDePlayer = true; //SETA QUE O JOGADOR 0 SERA PLAYER;

            for (int jogadore = 2; jogadore <= 5; jogadore++)  //LOOP PARA PASSAR ENTRE OS JOGADORES
            {
                this.ConfigurandoInicial.Jogadores[jogadore].Nome = "Jogador " + jogadore; //SETA OS NOMES DE TODOS OS JOGADORES
            }



            MenuSecundario NovoForm = new MenuSecundario(this.ConfigurandoInicial); //COLOCA O CONFIFURADOR NO CONSTRUTOR E INSTANCIA A CLASSE
            NovoForm.ShowDialog(); //MOSTRA O FORM
            this.Close(); //FECHA ESSE FORM 



        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBox5.Text != "") { InstanciarNovoMenu(); }
                else { MessageBox.Show("Digite um Nome","Aviso!!!"); }
            }
        }

        private void UmJogador_MouseEnter(object sender, EventArgs e)
        {
            UmJogador.FlatAppearance.BorderColor = Color.Blue; //MUDAR A COR PARA AZUL QUANDO TIVER EM CIMA O MOUSE
        }

        private void UmJogador_MouseLeave(object sender, EventArgs e)
        {
            UmJogador.FlatAppearance.BorderColor = Color.White; //RETORNA A COR PARA BRANCO QUANDO O MOUSE SAI
        }
    }
}
