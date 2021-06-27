using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Black_Edition_0._0._6
{
    public class InteligenciaDeAposta
    {

        private int ValorMao; //VALOR DA MAO EM GERAL 
        private int ValorModificado; //VALOR QUE PODE RETORNAR PARA VIRAR UMA APOSTA
        private int ValorReserva; //VALOR UTILZADO EM METODOS DE RESERVAS QUANDO O METODO PRINCIPAL PRECISA DE SUA COORDENAÇAO

        private int ValorReal; //VALOR QUE SERA REALMENTE UTILIZADO PARA A TROCA DE APOSTA

        private int[] ValoresAposta = new int[6]; //NUNMERO DO VETOR PARA SER ADD NAS APOSTAS


        private Random Randomizar = new Random();


        private Jogador Player; //PLAYER QUE FOI ENTRADO

        public void PensarAposta(Jogador JogadorEntrada) //METODO PARA QUE ELE PENSE EM UMA APOSTA E ENTRA O PLAYER PARA QUE POSSASO O COMPREENDELO 
        {
            Player = JogadorEntrada; //PLAYER IMPLICADO
            ValorMao = InterpretaMao(); //CALCULAR BONITA 

            // VALORES DAS APOSTAS ===================

            ValoresAposta[0] = 0;
            ValoresAposta[1] = 50;
            ValoresAposta[2] = 125;
            ValoresAposta[3] = 250;
            ValoresAposta[4] = 500;
            ValoresAposta[5] = 1000;

            //VALORES DAS APOSTAS ==================================

            //PRIMEIRA COISA /E ANALISAR SUA PROPIA MAO ===========


            ValorReal = AnalisarBaseMao(); //COMEÇA COM UMA ANALISE DE SUA PROPIA MAO
            AnalisarPossibilidadeDeAposta(); //ANALISE COM BASE FINAL EM APOSTAS

            //======================================================

        }

        private void AnalisarPossibilidadeDeAposta() //ANALISAR SE ELE REALEMNTE PODE APOSTAR
        {
            if(ValorReal > Player.Fichas) //SE O VALOR FOR MAIOS QUE OS DAS FICHAS
            {
                ValorReal = 0; //ZERA O VALOR REAL 

                if(Player.Fichas >= 5000) { ValorReal += ValoresAposta[Randomizar.Next(4,5)]; } //CASO ESTEJA ALTO APOSTE ALTO TMB
                if(Player.Fichas > 1000 && Player.Fichas < 5000) { ValorReal += ValoresAposta[5]; } //CASO ESTEJA AQUI ELE APOSTA 1000
                if(Player.Fichas >= 100 && Player.Fichas <= 1000) { ValorReal += ValoresAposta[Randomizar.Next(1, 3)]; } //RANDOMIZA ALGO POREM COM A POSSIBILIDADE DE SER ALGO UM POUCO ALTO
                if(Player.Fichas < 100 && Player.Fichas > 10) { ValorReal += ValoresAposta[Randomizar.Next(1,2)]; } //RANDOMIZA ALGO NESTE FAIXA CASO ESTEJA MEIO BAIXO 
                if(Player.Fichas > 0 && Player.Fichas <= 10) { ValorReal = 1; } //CASO ESTEJA MT BAIXO APOSTE 1
            }
            else
            {

                Player.Fichas -= ValorReal; //TIRA DAS FICHAS
                Player.Aposta += ValorReal; //SOMA NA APOSTA
            }
        }



        private int AnalisarBaseMao() //ANALISAR SUA APOSTA COM BASE NA MAO
        {


            ValorModificado = 0; //ZERA O VALO ANTES DE TUDO 

            //SE MAO DELE FOR IGUAL A 21
            if (ValorMao == 21) { ValorModificado = ValoresAposta[Randomizar.Next(4, 5)]; } //RANDOMIZA ENTRE 500  OU 1000  

            if(ValorMao >= 17 && ValorMao <= 20) { ValorModificado = ValoresAposta[Randomizar.Next(3,4)];} //RANDOMIZA ALGO ENTRE 250 OU 500 
            if(ValorMao == 16) { ValorModificado = ValoresAposta[Randomizar.Next(4)]; } //CASO SUA VALHA 16 APOSTARA EXATAMENTE 500
            if(ValorMao > 10 && ValorMao <= 15) { ValorModificado = AnalisarVitorias(); } //CASO SUA MAO VALHA MENOS QUE ISSO ANALISARA AS VITORIAS
            if(ValorMao <= 10) { ValorModificado = AnalisarDerrotas(); } //CASO SUA MAO VALHA MENOS QUE ISSO ANALISARA SUAS DERROTAS


            //BASICAMENTE AQUI SERVER PARA TENTAR DESCENTRALIZAR A APOSTA FAZENDO ASSIM UMA MARGEM DE ERRO

            int Rand = Randomizar.Next(1, 10); //RANDOMIZA UM "BINARIO";

           

            if (Rand == 1) { ValorModificado += ValoresAposta[1]; }
            if (Rand == 2) { ValorModificado += ValoresAposta[2]; }
            if (Rand == 3) { ValorModificado += ValoresAposta[3]; }
            if (Rand == 4) { ValorModificado += ValoresAposta[4]; }


            return ValorModificado; //RETORNA VALOR

            //================================================================================================
        }

        private int AnalisarDerrotas()
        {
            ValorReserva = 0; //ZERA O VALOR ANTES DE TUDO

            if (Player.DerotasSeguidas == 0) { ValorReserva += ValoresAposta[Randomizar.Next(2,3)]; } //CASO NAO TENHA PERDIDO NENHUMA PODE APOSTAR UM POUCO MAIS ALTO
            if(Player.DerotasSeguidas >= 1 && Player.DerotasSeguidas <= 2) { ValorReserva += ValoresAposta[2]; } //CASO JA TENHA PERDIDO ALGUMA APOSTA UM POUXO MAIS BAIXO 
            if(Player.DerotasSeguidas >= 3) { ValorReserva += ValoresAposta[Randomizar.Next(1, 2)]; } //CASO TENHA PERDIDAS VARIAS APOSTA BAIXO


            return ValorReserva; //RETORNA VALOR
        }

        private int AnalisarVitorias()
        {
            ValorReserva = 0; //AMTES DE TIDP ZERA O VALOR

            if(Player.VitoriasSeguidas == 0) { ValorReserva += ValoresAposta[Randomizar.Next(1,2)]; } //CASO O JOGADOR NAO TENHA NENHUMA VITORIA SEGUIDA
            if(Player.VitoriasSeguidas > 1 && Player.VitoriasSeguidas <= 2) { ValorReserva += ValoresAposta[3]; } //ATRIBUI UM VALOR FIXO AO JOGADOR CASO ELE ESTEJA NESTE NUMERO 
            if (Player.VitoriasSeguidas >= 3) { ValorReserva += ValoresAposta[Randomizar.Next(3, 4)]; } //RANDOMIZA ALGO ENTRE 500 E 250     

            return ValorReserva; //RETONA O VALOR
        }


        private int InterpretaMao() //INTERPRETAR E SOMAR A MAO
        {
            int Soma = 0; //SOMA DE TODAS CARTA QUE É 0
            int Carta; //NUMERO DA CARTA

            for (int Numero = 0; Numero <= 10; Numero++) //LOOP DA MAO
            {

                Carta = Convert.ToInt32(Player.Mao[Numero]); //CONVERTE PARA UM INTEIRO JA QUE A MAO É UMA STRING

                if (Carta == 1) { Soma += 11; }


                if (Carta >= 11 && Carta <= 14) { Soma += 1; }
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

    }
}
