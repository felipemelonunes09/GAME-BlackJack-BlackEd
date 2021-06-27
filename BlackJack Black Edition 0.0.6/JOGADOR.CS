using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_Black_Edition_0._0._6
{
    public class Jogador
    {
        //CARACTERISTICAS PRIVADAS ===========================================================================================================

        public int Aposta = 0; //APOSTA APENAS PODENDO MOSTRAR E NAO SETA 

        //====================================================================================================================================

        //CARACTERISTICAS PUBLICAS ===========================================================================================================

        public string Nome; //NOME ATRIBUIDO AO JOGADOR
        public string[] Mao = new string[11]; //MAO DO JOGADOR 

        public int Numero; //NUMERO DO JOGADOR EM RELAÇÃO A VETOR
        public int Fichas = 5000;  //FICHAS DE TODOS JOGADORES QUE COMEÇAM COM 5000

        public int VitoriasSeguidas; //QUANTIDADE DE VITORIAS QUE O JOGADOR TEVE SEGUIDAS
        public int DerotasSeguidas; //QUANTIDADE DE DERROTAS SEGUIDAS QUE O JOGADOR JA TEVE

        public bool ValidadorDePlayer; //VALIDA SE É UM BOT OU UM PLAYER
        public bool AtivadorJogo; //ATIVADOR QUE DIZ SE ELE ESTA NO JOGO OU NÃO
        public bool AtivadorPartida; //ATIVADOR QUE DIZ SE ELE ESTA NA PARTIDA OU NÃO 

    

        public void AddCarta(int Numero) //METODO PARA ADD CARTA E VERIFICAR SE PODE SER MANDADO UMA CARTA E RECEBE UM NUMERO PARA SER IMPLICADO
        {
            int Num = 0; //NUM PARA PASSAR NO VETOR DA MAO
            while(Mao[Num] != null) //LOOP ENQUANTO NAO ACHAR UM POSIÇÃO CONTINUA
            {
                Num++; //SOMA ENQUANTO NAO ACHAR UM POSICAO
            }
            
            Mao[Num] = Convert.ToString(Numero); //QUANDO ACHAR UM POSIÇÃO IMPLICA ELA NO LUGAR CERTO
        }
    }
}
