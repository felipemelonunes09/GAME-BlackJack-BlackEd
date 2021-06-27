using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_Black_Edition_0._0._6
{
    public class Baralho
    {
        private string[] baralho = new string[53];
        private string[] carta = new string[14];

        private bool Ativar1 = false;
        private bool Ativar2 = false;

        private int Naipe = 1;
        private int Contador = 1;

        //Inializa o baralho

        public void InicializarBaralho(Baralho BaralhoQueEntra)
        {
            BaralhoQueEntra.Ativar1 = true;
            BaralhoQueEntra.CriarCarta(BaralhoQueEntra);
            BaralhoQueEntra.CriarBaralho(BaralhoQueEntra);
        }

        //Criar Carta

        private void CriarCarta(Baralho BaralhoQueEntra)
        {
            for (int i = 1; i <= 13; i++) { carta[i] = Convert.ToString(i); }
        }

        // Criar Baralho

        private void CriarBaralho(Baralho BaralhoQueEntra)
        {

            for (int i = 1; i <= 52; i++)
            {
                switch (i)
                {
                    case 14: BaralhoQueEntra.Contador = 1; BaralhoQueEntra.Naipe++; break;
                    case 27: BaralhoQueEntra.Contador = 1; BaralhoQueEntra.Naipe++; break;
                    case 40: BaralhoQueEntra.Contador = 1; BaralhoQueEntra.Naipe++; break;

                }

                string Naipes = Convert.ToString(BaralhoQueEntra.Naipe);
                BaralhoQueEntra.baralho[i] = BaralhoQueEntra.carta[BaralhoQueEntra.Contador] + BaralhoQueEntra.Naipe;
                BaralhoQueEntra.Contador++;
            }

        }

        // Embaralhamento

        public void Embaralhar(Baralho BaralhoQueEntra)
        {
            Random Randomizar = new Random();
            for (int i = 1; i <= 52; i++)
            {
                int N1 = Randomizar.Next(1, 52);
                int N2 = N1;

                while (N1 == N2)
                {
                    N2 = Randomizar.Next(1, 52);
                }

                string Troca = BaralhoQueEntra.baralho[N1];
                BaralhoQueEntra.baralho[N1] = BaralhoQueEntra.baralho[N2];
                BaralhoQueEntra.baralho[N2] = Troca;
            }
        }

        //Mostrar baralho

        public void Mostrar(Baralho BaralhoQueEntra)
        {
            for (int i = 1; i <= 52; i++)
            {
                MessageBox.Show("" + BaralhoQueEntra.baralho[i]);
            }
        }

        //Manda a carta para o jogo
        public int MandarCarta()
        {
            int numero = 0;
            while (baralho[numero] == null) { numero++; }

            int Recupera = Convert.ToInt32(baralho[numero]);
            baralho[numero] = null;

            return Recupera;
        }
    }
}
    

