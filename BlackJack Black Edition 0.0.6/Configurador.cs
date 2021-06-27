using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJack_Black_Edition_0._0._6
{
    public class Configurador
    {
        public Jogador[] Jogadores = new Jogador[6];  //VETOR QUE CONTEM TODOS OS JOGADORES
        public Baralho Baralhos = new Baralho(); //CLASSE DO BARALHO JA FORMADO
        public InteligenciaDeAposta inteligenciaDeAposta = new InteligenciaDeAposta(); //INTELIGENCIA NAO SO DE APOSTA DE BOOTSA
        public InteligenciaDeCarta inteligenciaDeCarta;

        private int SomaTodasAposta; //SOMA DE TODAS AS APOSTAS



        public Configurador() //CONSTRUTOR QUE IMPLICA TODOS OS JOGADORES NO VETOR E IMPOE QUE NENHUM SAO PLAYER
        {
            for(int Numero = 0; Numero <= 5; Numero++) //LOOP PARA CRIAR OS JOGADORES
            {
                this.Jogadores[Numero] = new Jogador(); //CRIA E IMPLICA OS JOGADORES NO VETOR
                this.Jogadores[Numero].ValidadorDePlayer = false; //FALA QUE TODOS SAO BOTS
                this.Jogadores[Numero].Numero = Numero; //IMPLICA O NUMERO DELE NELE MESMO DENTRO DO CONSTRUTOR
                this.Jogadores[Numero].AtivadorJogo = true; //TODOS OS JOGADORES COMO PADRÃO JOGAM 
                this.Jogadores[Numero].Nome = ""; //TIRA TODOS OS NOMES
            }

            inteligenciaDeCarta = new InteligenciaDeCarta(this); //CRIA A CLASSE AQUI NO CONSTRUTOR
            this.Baralhos.InicializarBaralho(this.Baralhos); //INICIALIZA O BARALHO E JA FICO COM ELA CONTIDO A PROGRAMAÇÃO 
        }

        //CONFIGURA O PICTURE BOX DAS FICHAS ===============================================================================================================

        public void ConfigurarPicFichas(int Fichas, PictureBox ImagemAnalisada) //RECEBE O NUMERO DE FICHAS E O PICTUREBOX A SER ANALISADO
        {
            if(Fichas <= 2000) { ImagemAnalisada.Image = Properties.Resources.ficha_50; } //SETA COMO 50 
            if(Fichas > 2000 && Fichas <= 4000) { ImagemAnalisada.Image = Properties.Resources.ficha_125; } //SETA COMO 125
            if(Fichas > 4000 && Fichas <= 5500) { ImagemAnalisada.Image = Properties.Resources.ficha_250; } //SETA COMO 250 
            if(Fichas > 5500 && Fichas <= 6000) { ImagemAnalisada.Image = Properties.Resources.ficha_500; } //SETA COMO 500
            if(Fichas > 6000 && Fichas <= 6500) { ImagemAnalisada.Image = Properties.Resources.ficha_1k;  } //SETA COMO 1K
            if(Fichas > 6500) { ImagemAnalisada.Image = Properties.Resources.ficha_5k; } //SETA COMO 5K
        }

        //==================================================================================================================================================



        //VERIFICA SE UM VALOR É VDD OU FALSO =============================================================================================================

        public bool Confirmar(bool Verficardor) //Verificar ele recebe um valor e retorna ou um falso ou true
        {
            if (Verficardor) { return true; } //Retorna vdd
            return false; //Retorna fake
        }

        //ESSA FUNÇÃO IRA FAZER UM CONFIRMAMENTO IRA EMITIR UMA MENSAGEM PARA CONFIRMAR ALGO OU NAO E RETORNA O VALOR =====================================
        public bool ConfirmarAlgo(string Texto)
        {
            MessageBoxButtons Botao = MessageBoxButtons.YesNo; //CRIA UM BOTAO 
            DialogResult Decisao = MessageBox.Show(Texto,"Aviso" ,Botao); //CRIA UM DIALOGO QUE APRESENTA UMA MENSAGEM COM UM BOTAO

            if(Decisao == DialogResult.Yes) { return true; } //CASO SIM RETORNA COMO VERDADE
            if(Decisao == DialogResult.No) { return false; } //CADO NAO RETORNA COMO FALSO

            return false;   //CASO NADA SEJA DECIDIDO RETORNA FALSO
        }

        private void SetarPlayerAtivosMultiPLayer(int Quantidade) //SETA OS PLAYER TUDO QUE É FALSO É ´PLAYER TUDO QUE É TRUE É JOGADOR
        {
            for (int Numero = (Quantidade - 1); Numero >= 0; Numero--) //LOOP QUE COMEÇA COM A QUANTIDADE E VAI DECAINDO ATE O 0 //Quantidade - 1 POIS ASSIM O 0 NAO SERA UTILIZADO
            {
                this.Jogadores[Numero].ValidadorDePlayer = true; //SETA O VALIDADOR DE PLAYER DELE COMO ATIVO AGR SENDO ELE UM PLAYER NAO UM NPC
            }
        }

        //INERPRETA A MAO E COLOCA UMA IMAGEM NELA QUE FOI ENVIADA =============================================================================================
        public void SetarImagensFichas(int Entrada, PictureBox Mao)
        {
            if (Mao.Image == null) //CASO A IMAGEM ESTEJA VAZIO
            {
                Mao.Visible = true; //SETA COMO TRUE
                switch (Entrada) //ESCOLHA ENTRE O NUMERO QUE FOI ENVIADA
                {

                    //Espadas
                    case 11: Mao.Image = Properties.Resources._As_Espadas; break;
                    case 21: Mao.Image = Properties.Resources._2_Espadas; break;
                    case 31: Mao.Image = Properties.Resources._3_Espadas; break;
                    case 41: Mao.Image = Properties.Resources._4_Espadas; break;
                    case 51: Mao.Image = Properties.Resources._5_Espadas; break;
                    case 61: Mao.Image = Properties.Resources._6_Espadas; break;
                    case 71: Mao.Image = Properties.Resources._7_Espadas; break;
                    case 81: Mao.Image = Properties.Resources._8_Espadas; break;
                    case 91: Mao.Image = Properties.Resources._9_Espadas; break;
                    case 101: Mao.Image = Properties.Resources._10_Espadas; break;
                    case 111: Mao.Image = Properties.Resources.Rei_Espadas; break;
                    case 121: Mao.Image = Properties.Resources.Rainha_Espadas; break;
                    case 131: Mao.Image = Properties.Resources.Jack_Espadas; break;

                    //Copas
                    case 12: Mao.Image = Properties.Resources._As_Copas; break;
                    case 22: Mao.Image = Properties.Resources._2_Copas; break;
                    case 32: Mao.Image = Properties.Resources._3_Copas; break;
                    case 42: Mao.Image = Properties.Resources._4_Copas; break;
                    case 52: Mao.Image = Properties.Resources._5_Copas; break;
                    case 62: Mao.Image = Properties.Resources._6_Copas; break;
                    case 72: Mao.Image = Properties.Resources._7_Copas; break;
                    case 82: Mao.Image = Properties.Resources._8_Copas; break;
                    case 92: Mao.Image = Properties.Resources._9_Copas; break;
                    case 102: Mao.Image = Properties.Resources._10_Copas; break;
                    case 112: Mao.Image = Properties.Resources.Rei_Copas; break;
                    case 122: Mao.Image = Properties.Resources.Rainha_Copas; break;
                    case 132: Mao.Image = Properties.Resources.Jack_Copas; break;

                    //Paus
                    case 13: Mao.Image = Properties.Resources._As_Paus; break;
                    case 23: Mao.Image = Properties.Resources._2_Paus; break;
                    case 33: Mao.Image = Properties.Resources._3_Paus; break;
                    case 43: Mao.Image = Properties.Resources._4_Paus; break;
                    case 53: Mao.Image = Properties.Resources._5_Paus; break;
                    case 63: Mao.Image = Properties.Resources._6_Paus; break;
                    case 73: Mao.Image = Properties.Resources._7_Paus; break;
                    case 83: Mao.Image = Properties.Resources._8_Paus; break;
                    case 93: Mao.Image = Properties.Resources._9_Paus; break;
                    case 103: Mao.Image = Properties.Resources._10_Paus; break;
                    case 113: Mao.Image = Properties.Resources.Rei_Paus; break;
                    case 123: Mao.Image = Properties.Resources.Rainha_Paus; break;
                    case 133: Mao.Image = Properties.Resources.Jack_Paus; break;

                    //Ouros
                    case 14: Mao.Image = Properties.Resources._As_Ouros; break;
                    case 24: Mao.Image = Properties.Resources._2_Ouros; break;
                    case 34: Mao.Image = Properties.Resources._3_Ouros; break;
                    case 44: Mao.Image = Properties.Resources._4_Ouros; break;
                    case 54: Mao.Image = Properties.Resources._5_Ouros; break;
                    case 64: Mao.Image = Properties.Resources._6_Ouros; break;
                    case 74: Mao.Image = Properties.Resources._7_Ouros; break;
                    case 84: Mao.Image = Properties.Resources._8_Ouros; break;
                    case 94: Mao.Image = Properties.Resources._9_Ouros; break;
                    case 104: Mao.Image = Properties.Resources._10_Ouros; break;
                    case 114: Mao.Image = Properties.Resources.Rei_Ouros; break;
                    case 124: Mao.Image = Properties.Resources.Rainha_Ouros; break;
                    case 134: Mao.Image = Properties.Resources.Jack_Ouros; break;
                }

                if(Entrada == 1) { Mao.Image = Properties.Resources._As_Ouros;} //CASO O AS ESTEJA VALENDO 11 COLOCA ESTA IMAGEM
            }
        }
        //=========================================================================================================================

        public int InterpretaMao(Jogador Player) //INTERPRETAR E SOMAR A MAO
        {
            int Soma = 0; //SOMA DE TODAS CARTA QUE É 0
            int Carta; //NUMERO DA CARTA
            
            for (int Numero = 0; Numero <= 10; Numero++) //LOOP DA MAO
            {

                Carta = Convert.ToInt32(Player.Mao[Numero]); //CONVERTE PARA UM INTEIRO JA QUE A MAO É UMA STRING

                if (Carta == 1) { Soma += 11; }

              
                if(Carta >= 11 && Carta <= 14) { Soma += 1; }
                if (Carta >= 21 && Carta <= 24) { Soma += 2; }
                if (Carta >= 31 && Carta <= 34) { Soma += 3; }
                if (Carta >= 41 && Carta <= 44) { Soma += 4; }
                if (Carta >= 51 && Carta <= 54) { Soma += 5; }
                if (Carta >= 61 && Carta <= 64) { Soma += 6; }
                if (Carta >= 71 && Carta <= 74) { Soma += 7; }
                if (Carta >= 81 && Carta <= 84) { Soma += 8; }
                if (Carta >= 91 && Carta <= 94) { Soma += 9; }
                if (Carta >= 101 && Carta <= 104) { Soma += 10; }
                if (Carta >= 111 && Carta <= 114) { Soma += 10; }
                if (Carta >= 121 && Carta <= 124) { Soma += 10; }
                if (Carta >= 131 && Carta <= 134) { Soma += 10; }

            }
            return Soma;
        }

        //=============================================================================================================================================

        public int SomaAposta() //METODO DE SOMA APOSTAS
        {
            SomaTodasAposta = 0; //ZERA A SOMA DE TODAS AS APOSTASS

            for (int Jogador = 0; Jogador <= 5; Jogador++) //LOOP PARA PASSAR ENTRE OS JOGADODRES
            {
                SomaTodasAposta += this.Jogadores[Jogador].Aposta; //COLOCA TODAS AS APOSTAS EM UMAM VARIAVEL
            }

            return SomaTodasAposta; //RETORNA A SOMA PARA O PROGRAMA 
        }


    } 
}
