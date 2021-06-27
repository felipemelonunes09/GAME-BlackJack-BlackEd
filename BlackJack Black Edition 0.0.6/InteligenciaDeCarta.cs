using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Black_Edition_0._0._6
{
    public class InteligenciaDeCarta
    {
        private Configurador Interno; //CONFIGURADOR INTERNO DESSA CLASSE
        private int Jogador;
        private int Maux;
        private int Minx;

        public InteligenciaDeCarta(Configurador Entrada) //CONSTRUTOR DA CLASSE QUE IMPLCA O CONFIGURADOR NECESSARIO PARA A CLASSE FUNCIONAR
        {
            this.Interno = Entrada;

        }

        private bool ProcuraValor(int De, int Ate) //METODO QUE PROCURA UM VALOR DENTRO DO CODIGO QUE VOCE MANDA
        {
            for (int Carta = 0; Carta <= 10; Carta++) //Carta >= 11 && Carta <= 14
            {
                if (De <= Convert.ToInt32(Interno.Jogadores[Jogador].Mao[Carta]) && Ate >= Convert.ToInt32(Interno.Jogadores[Jogador].Mao[Carta]))
                { //VERIFICAÇÃO PARA VER SE ESSE CODIGO EXISTE
                    return true; //SE ACHAR RETORNA TRUE
                }

            }
            return false; //SE NAO ACHAR RETORNA FALSE
        }

        private bool FundBasic()
        {
            if (this.Interno.InterpretaMao(this.Interno.Jogadores[Jogador]) <= 10)
            {
                return true;
            }

            OlhaCartas();

            return false;
        }

        private void OlhaCartas()
        {
            int Ma = 0, Me = 0;
            for (int Joju = 0; Joju <= 5; Joju++) //PASSA POR TODOS OS JOGADORES
            {
                for (int Carta = 0; Carta <= 10; Carta++) //PASSA POR TODA A MAO
                {
                    if (64 <= Convert.ToInt32(Interno.Jogadores[Joju].Mao[Carta])) //VE SE O NUMERO E MAIOR OU MENOR QUE 5 NO CASO 64
                    {
                        Ma++;
                    }
                    else
                    {
                        Me++;
                    }
                }
            }
            this.Maux = Ma;
            this.Minx = Me;
        }

        public bool PensarEmCarta(int Jogador) //METODO PARA PEENSAR EM UMA CARTA
        {

            this.Jogador = Jogador;

            if (Jogador == 1) { return PensamentoDealer(); } //CASO FOR O DEALER ENTRA NA LOGICA DE PENSAMENTO DELE E CHAMA O METODO QUE JA RETORNA UM TRUE OU FALSE-
            else { return PensamentoJogador(); }

        }



        private bool PensamentoDealer() //LOGICA DE PENSAMENTO DO DEALER
        {
            if (FundBasic()) { return true; }

            if (Interno.Jogadores[Jogador].DerotasSeguidas <= 4 && Interno.Jogadores[Jogador].Fichas >= 2000 && Interno.Jogadores[Jogador].Fichas <= 900) //LOGICA DA PATROA
            {

                if (Minx >= Maux && Interno.InterpretaMao(Interno.Jogadores[Jogador]) >= 15) // AVALIA SE PODE OU NAO RETORNAR
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) < 15)
                {
                    return true;
                }

                if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) >= 15 && Interno.InterpretaMao(Interno.Jogadores[Jogador]) <= 21) //PRIMEIRO FUNDAMENTO DO DEALER
                {
                    if (ProcuraValor(11, 14)) //SE ELE ACHAR A CARTA QUE QUER ENTAO RETORNA TRUE
                    {
                        return false; //RETORNANDO O VALOR
                    }
                    else //SENAO ACHAR
                    {
                        return true; //RETORNA FALSE
                    }
                }

                return false;

            }
            //TIPO O CONGIFURADOR ELE TEM OS JOGADORES 
            //E ATRAVES CONFIGURADOR VOCE POSSO A MAIORIAS DAS CLASSES DO PROGRAMA
            //FUNCÇOES COMO SOMA DE TODAS AS CARTA OU OU INTERPRETAÇÃO EM GERAL FUNÇÕES BASICAS JA ESTAO CONTIDAS NO CONFIGURADOR

            return false;
        }


        private bool PensamentoJogador()
        {
            if (FundBasic()) { return true; }

            Random Randomizar = new Random();
            int N1 = Randomizar.Next(0, 4);

            if (5000 >= Interno.Jogadores[Jogador].Fichas || 5000 <= Interno.Jogadores[Jogador].Fichas || N1 == 0) //MODO 1
            {
                if (Minx >= 5 && Maux <= 5)
                {
                    return true;
                }
                else
                {
                    if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) <= 17)
                    {
                        return true;
                    }
                    else { return false; }
                }

            }//FIM MODO 1
            else
            {
                if (4000 >= Interno.Jogadores[Jogador].Fichas || N1 == 1) //MODO 2
                {
                    if (Maux >= 3 || Minx <= 4)
                    {
                        return true;
                    }
                    else { return false; }

                } //FIM MODO 2
                else
                {
                    if (3000 >= Interno.Jogadores[Jogador].Fichas || N1 == 2) //MODO 3
                    {
                        if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) <= 17)
                        {
                            return true;
                        }

                        if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) >= 17) //PRIMEIRO FUNDAMENTO DO DEALER
                        {
                            if (ProcuraValor(11, 14)) //SE ELE ACHAR A CARTA QUE QUER ENTAO RETORNA TRUE
                            {
                                return false; //RETORNANDO O VALOR
                            }
                            else //SENAO ACHAR
                            {
                                return true; //RETORNA FALSE
                            }

                        } //FIM MODO 3
                        else
                        {
                            if (2000 >= Interno.Jogadores[Jogador].Fichas || N1 == 3) //MODO 4
                            {
                                if (Interno.Jogadores[Jogador].DerotasSeguidas <= 4 || Interno.Jogadores[Jogador].Fichas >= 2000 && Interno.Jogadores[Jogador].Fichas <= 900) //LOGICA DA PATROA
                                {

                                    if (Minx >= Maux) // AVALIA SE PODE OU NAO RETORNAR
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }

                            } //FIM MODO 4
                            else
                            {
                                if (1000 >= Interno.Jogadores[Jogador].Fichas || N1 == 4) //MODO 5
                                {
                                    if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) >= 15)
                                    {
                                        if (Interno.InterpretaMao(Interno.Jogadores[Jogador]) <= 17)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        if (Minx >= Maux) // AVALIA SE PODE OU NAO RETORNAR
                                        {
                                            return false;
                                        }
                                        else
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }//FIM MODO 5
                        }
                    }
                }
            }

            return false;
        }

    }
}