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
    public partial class Jogo : Form
    {
        public Configurador ConfiguradorPrimario; //FORMACAÇÃO DO ULTIMO CONFIGURADOR
        public Label[] LabelNomes = new Label[6]; //LABEL DOS NOMES DOS JOGADORES
        public Label[] LabelFichas = new Label[6]; //LABEL DAS FICHAS DOS JOGADORES
        public Label[] LabelAposta = new Label[6]; //LABEL DAS APOSTA DO JOGADORES
        public PictureBox[] PictureBoxFichas = new PictureBox[6]; //PICTUREBOX PARA AS FICHAS
        public PictureBox[,] CartasJogadores = new PictureBox[6,12]; //CRIA UMA MATRIZ DE PICTURE BOX PARA ARMAZENAR AS IMAGENS DE CARTAS

        private int AnimationStart; //VARIAVEL  DE SETAR ANIMAÇÃO

        public System.Threading.Thread aqui;

        public Jogo(Configurador ConfiguradorEntrada) //CONSTRUTOR PARA RECEBER O CONFIGURADOR
        {
            this.ConfiguradorPrimario = ConfiguradorEntrada;
            InitializeComponent();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {





            // IMPLICA OS LABEL DOS NOMES EM UM VETOR PARA PODEMOS LOOPARLOS ===========================

            this.LabelNomes[0] = LabelJogador_0;
            this.LabelNomes[1] = LabelDealer;
            this.LabelNomes[2] = LabelJogador1;
            this.LabelNomes[3] = LabelJogador2;
            this.LabelNomes[4] = LabelJogador3;
            this.LabelNomes[5] = LabelJogador4;

            //===========================================================================================

            //IMPLICA OS LABEL DAS FICHAS EM UM VEROT PARA LOOPAR =======================================

            this.LabelFichas[0] = LabelFichasJogador0;
            this.LabelFichas[1] = LabelFichasDealer;
            this.LabelFichas[2] = LabelFichasJogador1;
            this.LabelFichas[3] = LabelFichasJogador2;
            this.LabelFichas[4] = LabelFichasJogador3;
            this.LabelFichas[5] = LabelFichasJogador4;

            // IMPLICA TODOS OS LABEL DE APOSTA EM UM VETOR ===========================================

            this.LabelAposta[0] = labelApostaJogador0;
            this.LabelAposta[1] = labelApostaDealer;
            this.LabelAposta[2] = labelApostaJogador1;
            this.LabelAposta[3] = labelApostaJogador2;
            this.LabelAposta[4] = labelApostaJogador3;
            this.LabelAposta[5] = labelApostaJogador4;

            // ==========================================================================================

            //IMPLICA TODOS OS PICTURE BOX NO VETOR PARA LOOPAR ========================================

            this.PictureBoxFichas[0] = PictureBoxFichasJogador0;
            this.PictureBoxFichas[1] = PictureBoxFichasDealer;
            this.PictureBoxFichas[2] = PictureBoxFichasJogador1;
            this.PictureBoxFichas[3] = PictureBoxFichasJogador2;
            this.PictureBoxFichas[4] = PictureBoxFichasJogador3;
            this.PictureBoxFichas[5] = PictureBoxFichasJogador4;

            //==========================================================================================

            //Jogador 0

            this.CartasJogadores[0, 0] = CartaJ0C1;
            this.CartasJogadores[0, 1] = CartaJ0C2;
            this.CartasJogadores[0, 2] = CartaJ0C3;
            this.CartasJogadores[0, 3] = CartaJ0C4;
            this.CartasJogadores[0, 4] = CartaJ0C5;
            this.CartasJogadores[0, 5] = CartaJ0C6;
            this.CartasJogadores[0, 6] = CartaJ0C7;
            this.CartasJogadores[0, 7] = CartaJ0C8;
            this.CartasJogadores[0, 8] = CartaJ0C9;
            this.CartasJogadores[0, 9] = CartaJ0C10;
            this.CartasJogadores[0, 10] = CartaJ0C11;
            this.CartasJogadores[0, 11] = CartaJ0C12;

            //Dealer 1

            this.CartasJogadores[1, 0] = CartaJdC1;
            this.CartasJogadores[1, 1] = CartaJdC2;
            this.CartasJogadores[1, 2] = CartaJdC3;
            this.CartasJogadores[1, 3] = CartaJdC4;
            this.CartasJogadores[1, 4] = CartaJdC5;
            this.CartasJogadores[1, 5] = CartaJdC6;
            this.CartasJogadores[1, 6] = CartaJdC7;
            this.CartasJogadores[1, 7] = CartaJdC8;
            this.CartasJogadores[1, 8] = CartaJdC9;
            this.CartasJogadores[1, 9] = CartaJdC10;
            this.CartasJogadores[1, 10] = CartaJdC11;
            this.CartasJogadores[1, 11] = CartaJdC12;

            //Jogador 1

            this.CartasJogadores[2, 0] = CartaJ1C1;
            this.CartasJogadores[2, 1] = CartaJ1C2;
            this.CartasJogadores[2, 2] = CartaJ1C3;
            this.CartasJogadores[2, 3] = CartaJ1C4;
            this.CartasJogadores[2, 4] = CartaJ1C5;
            this.CartasJogadores[2, 5] = CartaJ1C6;
            this.CartasJogadores[2, 6] = CartaJ1C7;
            this.CartasJogadores[2, 7] = CartaJ1C8;
            this.CartasJogadores[2, 8] = CartaJ1C9;
            this.CartasJogadores[2, 9] = CartaJ1C10;
            this.CartasJogadores[2, 10] = CartaJ1C11;
            this.CartasJogadores[2, 11] = CartaJ1C12;

            //Jogador 2



            this.CartasJogadores[3, 0] = CartaJ2C1;
            this.CartasJogadores[3, 1] = CartaJ2C2;
            this.CartasJogadores[3, 2] = CartaJ2C3;
            this.CartasJogadores[3, 3] = CartaJ2C4;
            this.CartasJogadores[3, 4] = CartaJ2C5;
            this.CartasJogadores[3, 5] = CartaJ2C6;
            this.CartasJogadores[3, 6] = CartaJ2C7;
            this.CartasJogadores[3, 7] = CartaJ2C8;
            this.CartasJogadores[3, 8] = CartaJ2C9;
            this.CartasJogadores[3, 9] = CartaJ2C10;
            this.CartasJogadores[3, 10] = CartaJ2C11;
            this.CartasJogadores[3, 11] = CartaJ2C12;

            //Jogador 3

            this.CartasJogadores[4, 0] = CartaJ3C1;
            this.CartasJogadores[4, 1] = CartaJ3C2;
            this.CartasJogadores[4, 2] = CartaJ3C3;
            this.CartasJogadores[4, 3] = CartaJ3C4;
            this.CartasJogadores[4, 4] = CartaJ3C5;
            this.CartasJogadores[4, 5] = CartaJ3C6;
            this.CartasJogadores[4, 6] = CartaJ3C7;
            this.CartasJogadores[4, 7] = CartaJ3C8;
            this.CartasJogadores[4, 8] = CartaJ3C9;
            this.CartasJogadores[4, 9] = CartaJ3C10;
            this.CartasJogadores[4, 10] = CartaJ3C11;
            this.CartasJogadores[4, 11] = CartaJ3C12;

            //Jogador 4 

            this.CartasJogadores[5, 0] = CartaJ4C1;
            this.CartasJogadores[5, 1] = CartaJ4C2;
            this.CartasJogadores[5, 2] = CartaJ4C3;
            this.CartasJogadores[5, 3] = CartaJ4C4;
            this.CartasJogadores[5, 4] = CartaJ4C5;
            this.CartasJogadores[5, 5] = CartaJ4C6;
            this.CartasJogadores[5, 6] = CartaJ4C7;
            this.CartasJogadores[5, 7] = CartaJ4C8;
            this.CartasJogadores[5, 8] = CartaJ4C9;
            this.CartasJogadores[5, 9] = CartaJ4C10;
            this.CartasJogadores[5, 10] = CartaJ4C11;
            this.CartasJogadores[5, 11] = CartaJ4C12;

            //COLOCA TODOS OS NOMES E METODOS ================================================================================================================================

            for (int Numero = 0; Numero <= 5; Numero++) //LOOP QUE VAI DE 0 ATE O NUMERO MAXIMO NO VETOR
            {
                if(this.ConfiguradorPrimario.Jogadores[Numero].AtivadorJogo == true) //VERIFICA QUAIS JOGADORES ESTAO ATIVOS NO JOGO
                {
                    if (this.ConfiguradorPrimario.Jogadores[Numero].Nome != "") //CASO OS JOGADORES NAO TENHAM NOME IMPLICA UM NOME QUALQUER
                    {
                        this.LabelNomes[Numero].Text = this.ConfiguradorPrimario.Jogadores[Numero].Nome; //CASO NAO TENHA NOMES IMPLICA OS NOMES NOS LABEL
                    }


                    this.LabelAposta[Numero].Text = Convert.ToString(this.ConfiguradorPrimario.Jogadores[Numero].Aposta); //IMPLICA AS APOSTAS NO LABEL DELAS
                    this.LabelFichas[Numero].Text = Convert.ToString(this.ConfiguradorPrimario.Jogadores[Numero].Fichas); //IMPLICA AS FICHAS NO LALBEL DELAS     
                    this.ConfiguradorPrimario.ConfigurarPicFichas(this.ConfiguradorPrimario.Jogadores[Numero].Fichas, this.PictureBoxFichas[Numero]); //ENVIA PARA O CONFIGURADOR CONFIGURAR AS FICHAS DO JOGADOR E O PICTURE BOX
                }
            }

            AtivarObjetos(); //ATIVA OS OBJETOS DOS JOGADORES ATIVOS

            //=========================================================================================================================================================
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if (this.ConfiguradorPrimario.ConfirmarAlgo("Você realmente deseja sair do jogo?")) { this.Close(); } //CASO QUEIRA SAIR PERGUNTA CASO SIM SAI SENAO NAO SAI
        }


        public void AtivarObjetos() //SETA OS OBEJTOS DE TODOS OS JOGADORES COMO TRUE OU FALSE
        {
            for(int Numero = 0; Numero <= 5; Numero++) //LOOP PARA PASSAR PELOS JOGADORES
            {
                if(ConfiguradorPrimario.Jogadores[Numero].AtivadorJogo == true) //SE OS JOGADORES ESTIVEREM ATIVOS
                {
                    this.LabelNomes[Numero].Visible = true; //ATIVA OS NOMES
                    this.LabelFichas[Numero].Visible = true; //ATIVA OS FICHAS
                    this.LabelAposta[Numero].Visible = true; //ATIVA AS APOSTAS 
                    this.PictureBoxFichas[Numero].Visible = true; //ATIVA A IMAGEM DAS FICHAS
                }
            }
        }

        private bool VerificarJogador(int Jogador, bool Verificador) { if (this.ConfiguradorPrimario.Jogadores[Jogador].ValidadorDePlayer == Verificador && this.ConfiguradorPrimario.Jogadores[Jogador].AtivadorJogo == true && this.ConfiguradorPrimario.Jogadores[Jogador].AtivadorPartida == true) { return true; } return false; }

        private void BotaoIniciar_Click(object sender, EventArgs e)
        {
            BotaoIniciar.Visible = false; //TIRA VISIBILIDADE DO BOTAO

            ///=========================//AQUI TEORICAMENTE VEM UM LOOOP  //===============================================

            this.ConfiguradorPrimario.Baralhos.Embaralhar(this.ConfiguradorPrimario.Baralhos); //EMBARALHO O BARALHO ATRAVES DE UM METODO QUE EENVIVA O PROPIO BARALHO 

            for (int Jogador = 0; Jogador <= 5; Jogador++) //LOOP PARA PASSAR ENTRE OS JOGADORES
            {
                if (this.ConfiguradorPrimario.Jogadores[Jogador].AtivadorJogo == true) //SE PS JOGADORES ESTIVEREM NO JOGO
                {

                    for (int Numero = 0; Numero <= 1; Numero++) //LOOP PARA REPETIR DAR 2 VEZES UM CARTA PARA O JOGADOR
                    {
                        DarCarta(this.ConfiguradorPrimario.Jogadores[Jogador], this.CartasJogadores[Jogador, Numero]); //DAR CARTAA MANDA COMO PARAMETRO QUAL JOGADOR É O SEU PICTURE BOX E SE É UM PLAYER
                    }

                    MessageBox.Show("" + ConfiguradorPrimario.Jogadores[Jogador].Nome + " Recebeu duas cartas", "Aviso"); //FALA QUE RECEBEU DUAS CARTAS 
                }
            }

         

            for(int Jogador = 0; Jogador <= 5; Jogador++) //LOOP PARA PASSAR ENTRE OS JOGADORES 
            {

                //ABRIR INTERFACE DE APOSTA 

                MessageBox.Show("Jogador: " + this.ConfiguradorPrimario.Jogadores[Jogador].Nome + "\n Fichas: " + this.ConfiguradorPrimario.Jogadores[Jogador].Fichas + "\n Player: " + this.ConfiguradorPrimario.Jogadores[Jogador].ValidadorDePlayer + "\n Habilitado: " + this.ConfiguradorPrimario.Jogadores[Jogador].AtivadorJogo);

                if (VerificarJogador(Jogador, true)) //SE FOR UM PLAYER ABRE A INTERFACE DE APOSTA
                {
                    InterfaceAposta InterfaceParaApostar = new InterfaceAposta(this, this.ConfiguradorPrimario.Jogadores[Jogador]); //CRIA A INTERFACE DE APOSTA
                    InterfaceParaApostar.ShowDialog(); //ABRIR INTERFACE DE APOSTA

                }
                if(VerificarJogador(Jogador, false))
                {

                    this.ConfiguradorPrimario.inteligenciaDeAposta.PensarAposta(this.ConfiguradorPrimario.Jogadores[Jogador]); //CHAMA METODO PARA PENSAR NA APOSTA

                    this.LabelAposta[Jogador].Text = Convert.ToString(this.ConfiguradorPrimario.Jogadores[Jogador].Aposta); //ATUALIZA AS FICHAS
                    this.LabelFichas[Jogador].Text = Convert.ToString(this.ConfiguradorPrimario.Jogadores[Jogador].Fichas); //ATUALIZA A APOSTA

                    this.ConfiguradorPrimario.ConfigurarPicFichas(this.ConfiguradorPrimario.Jogadores[Jogador].Fichas, PictureBoxFichas[Jogador]); //ATUALIZA A IMAGENS DAS FICHAS COMBASE NA APOSTA QUE ELE JA FIZERAM

                    MessageBox.Show("O " + this.ConfiguradorPrimario.Jogadores[Jogador].Nome + " Apostou exatamente " + this.ConfiguradorPrimario.Jogadores[Jogador].Aposta + " Fichas"); //NOTIFICA O QUANTO FOI APOSTADO
                }
            }

            labelSomaAposta.Text = Convert.ToString(this.ConfiguradorPrimario.SomaAposta()); //PEGA O LABEL PARA COLOCAR Á SOMA DE TODAS AS APOSTAS
            MessageBox.Show("Clique em\n\n Sim - Para adicionar uma carta\n\n Não - Para recusar\n\n \\(:T)/", "Aviso"); //AVISO  PARA TOCA NO BARALHO

            for (int Jogador = 0; Jogador <= 5; Jogador++) //LOOP PARA PASSAR ENTRE OS JOGADORES
            {

                this.AnimationStart = 3;
                if (VerificarJogador(Jogador, true)) //SE FOR UM PLAYER E O ATIVADOR DE PARTIDA DELE ESTIVER ATIVO
                {

                    bool Pular = true; ; //Variavel que diz quando ele deve parar

                    while (Pular) //ENQUATO PULAR FOR VERDADEIRO
                    {
                        if (this.ConfiguradorPrimario.ConfirmarAlgo("" + this.ConfiguradorPrimario.Jogadores[Jogador].Nome + " Você deseja pegar mais alguma carta?")) //PERGUNTA SE O JOGADOR DESEJA MAIS UMA CARTA
                        {
                            DarCarta(this.ConfiguradorPrimario.Jogadores[Jogador], this.CartasJogadores[Jogador, AnimationStart]); //ACIONA O DAR CARTA E ENVIA SEUS PARAMETROS;
                            AnimationStart++; //    INICIO DE ANIMAÇÃO A
                        }
                        else //SE ELE NAO QUISER UMA CARTA
                        {
                            Pular = false; //SE ELE NAO QUISER MAIS UMA CARTA ENTAO FECHA ANIMAÇÃO
                        }
                    }
                }

                if (VerificarJogador(Jogador,false))  //E O JOGADOR FOI UM BOT E ESTIVER ATIVO
                { 
                    while(this.ConfiguradorPrimario.inteligenciaDeCarta.PensarEmCarta(Jogador)) //ENQUANTO ESTE METODO DE RETORNO FOR ATIVO PEGAR UMA CARTA PARA O JOGADOR
                    {
                        DarCarta(this.ConfiguradorPrimario.Jogadores[Jogador], this.CartasJogadores[Jogador, AnimationStart]); //ACIONA O METODO DE DAR CARTAS E SEUS PARAMETROS
                        AnimationStart++;  //INICIO DA ANIMAÇÃO NOVAMENTE
                    }
                }
            }

        }

        //========================================================================================================================================================

        private void DarCarta(Jogador Player, PictureBox ImagemAnalisada) //METODO PARA DAR UMA CARTA PARA O JOGADOR E CONFIGURAR SUA IMAGEM
        {
            int Carta = this.ConfiguradorPrimario.Baralhos.MandarCarta(); //COLOCA A CARTA EM UMA VARIAVEL 

           if (Carta >= 11 && Carta <= 14 && Player.ValidadorDePlayer == true) //SE CASO FOR UM AS FARA  A PERGUNTA SE O JOGADOR FOR UM PLAYER
            {
                if (ConfiguradorPrimario.ConfirmarAlgo("Você tem um as, deseja fazer fazer-lo valer 21?")) { Carta = 1; } //SE ELE DESEJAR VAI TORNAR-LO UM 1 QUE É CODIGO PARA 11
            }

            int PosicaoX = ImagemAnalisada.Location.X; //PEGA A POSICAO DO PRIMEIRO PICTURE BOX // X
            int PosicaoY = ImagemAnalisada.Location.Y; //PEGA A POSICAO DO PRIMEIRO PICTURE BOX // Y


            if (AnimarCarta(PosicaoX,PosicaoY, pictureBoxBaralho, Carta)) //CASO RETORNE TRUE ATIVAR IMAGEM DA CARTA E RETORNA VALOR DA MAO // E ENVIA JOGADOR  E ENVIA FOTO DO BARALHO
            {
                this.ConfiguradorPrimario.SetarImagensFichas(Carta, ImagemAnalisada); //METODO QUE SETA A IMAGEM DA FICHA ENVIA COMO PARAMETRO O VALOR E O PICTURE A SER ANALISADO
                Player.AddCarta(Carta); //PEGA O METODO E ENVIA O NUMERO DA CARTA
                int Valor = this.ConfiguradorPrimario.InterpretaMao(Player); //MANDA PARA INTERPRETAR A MAO DELE E  RETORNAR A SOMA

                MessageBox.Show("A soma de mao  dessa pessoa e " + Valor);

            }
            else  //CASO NAO 
            {
                if (this.ConfiguradorPrimario.ConfirmarAlgo("Um erro foi encontrado, deseja reiniciar?") == false) //CONFIRMAMENTO CASO ERRO ACONTENÇA 
                {
                    this.Close(); //CASO SIM FECHA FORM ATUAL 
                }
            }
        }

        private void pictureBoxBaralho_Click(object sender, EventArgs e)
        {

        }

        //============================================================================================================================================================

        public bool AnimarCarta(int X, int Y, PictureBox CartaAnimic, int Valor)
        {

            Point Volta = CartaAnimic.Location; //PONTO PARA VOLTAR

            int BaralhoX = CartaAnimic.Location.X; //PEGA X DO BARALHO
            int BaralhoY = CartaAnimic.Location.Y; //PEGA Y DO BARALHO

            int Velocidade = 10; //VELOCIDADE RAPIDA
            int Velocidade1 = 1; //VELOCIDAE  LENTA

            AtulizarImagens(); //ATUALIZA
;
            CartaAnimic.Visible = true; //ATIVA A VISIBILIDADE

            while (X != BaralhoX || Y != BaralhoY) //ENQUANTO  POSICAO DO X FOR DIFERENTE QUE A DO BARAALHO E O Y TAMBEM FOR DIFERENTE
            {

                if (BaralhoX > X) { BaralhoX -= Velocidade; } //SE X FOR MAIOR DIMINUI
                if (BaralhoX < X) { BaralhoX += Velocidade; } //SE  X FOR MENOR AUMENTA

                if (BaralhoY > Y) { BaralhoY -= Velocidade; } //SE X FOR MAIOR DIMINUI
                if (BaralhoY < Y) { BaralhoY += Velocidade; } //SE  X FOR MENOR AUMENTA

                if (BaralhoX > X) { BaralhoX -= Velocidade1; } //SE X FOR MAIOR DIMINUI
                if (BaralhoX < X) { BaralhoX += Velocidade1; } //SE  X FOR MENOR AUMENTA

                if (BaralhoY > Y) { BaralhoY -= Velocidade1; } //SE X FOR MAIOR DIMINUI
                if (BaralhoY < Y) { BaralhoY += Velocidade1; } //SE  X FOR MENOR AUMENTA


                CartaAnimic.Location = new Point(BaralhoX, BaralhoY); //SETA O NOVA POSIÇÃO
                CartaAnimic.Refresh(); //REFRESCA NO BARALHO
                CartaAnimic.Update(); //DA UM UPDATE NO BARALHO

            }

            CartaAnimic.Visible = false; //DESATIVA A VISIBIDADE
            CartaAnimic.Location = Volta; //VOLTA PARA A POSIÇÃO INICIAL
            return true; //RETORNA COMO TRUE O VALOR
        }




        //===============================================================================================================

        private void AtulizarImagens() //IRA ATUALIZAR IMAGENS DAR REFRESH E UPDATE
        {

            for (int Numero = 0; Numero <= 5; Numero++) {


                this.LabelNomes[Numero].Refresh(); this.LabelNomes[Numero].Update(); //ATUALIZA OS LABEL NOME
                this.LabelFichas[Numero].Refresh(); this.LabelFichas[Numero].Update(); //ATUALIZA OS LABEL FICHAS
                this.PictureBoxFichas[Numero].Refresh(); this.PictureBoxFichas[Numero].Update(); //ATUALIZA OS PICTUREBOX FICHAS
        }


            for (int Numero = 0; Numero <= 5; Numero++) //ATUALIZA OS PICTURE BOX DAS CARTASS
            {
                for (int numero = 0; numero <= 11; numero++)  //ATUALIZA OS PICTURE BOX DAS CARTASS
                {
                    this.CartasJogadores[Numero, numero].Refresh();
                    this.CartasJogadores[Numero, numero].Update();
                }
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSim_Click(object sender, EventArgs e) //METODO DO BOTAO DE ADD SIM UMA CARTA
        {
        }

        private void buttonNao_Click(object sender, EventArgs e) //METODO DO BATAO NAO DE ADD UMA CARTA
        {
        }
    }
}
