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
    public partial class MenuSecundario : Form
    {
        public Configurador ConfigurandoFinal; //CONFIGURADOR DO SEGUNDO MENU

        public MenuSecundario(Configurador ConfiguradorMenuInicial) //CONSTRUTOR QUE RECEBE O CONFIGURADOR DO MEN PRINCIAL E APLICA NELE
        {
            this.ConfigurandoFinal = ConfiguradorMenuInicial; //APLICA O CONFIGURADOR NELE
            InitializeComponent();
        }


        private void Fechar_Click(object sender, EventArgs e)
        {
            if (this.ConfigurandoFinal.ConfirmarAlgo("Você tem certeza que quer sair do jogo?")) { this.Close(); } //FECHA CASO ELE REALMENTE QUEIRA SAIR
        }

        private void MenuSecundario_Load(object sender, EventArgs e)
        {
            AjeitarTela();
            Apresentador.Text = (this.ConfigurandoFinal.Jogadores[0].Nome + " Bem Vindo ao Jogo"); //SETA NO APRESENTANDOR O NOME DO JOGADOR 0
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            if (this.ConfigurandoFinal.ConfirmarAlgo("Você tem certeza que quer sair do jogo?")) { this.Close(); } //FECHA CASO ELE REALMENTE QUEIRA SAIR
        }

        private void BotaoJogar_Click(object sender, EventArgs e)
        {
            Jogo Jogar = new Jogo(this.ConfigurandoFinal); //INSTANCIANDO E COLOCANDO O CONFIGURADO FINAL NO CONTENDOR DO 
            Jogar.ShowDialog(); //ABRE A INTERFACE DE JOGO
            this.Close(); //FECHA ESTE FORM
        }

        private void AjeitarTela() //METODO PARA ANALISAR A TELA E ORGANIZAR SUAS COISAS
        {
            //AQUI ORGANUZAREMOS A LOGO NOVAMENTE

            Point PonteiroLogo = new Point(Convert.ToInt32((this.Width - this.pictureBox1.Size.Width) / 2), Convert.ToInt32(this.Height - 500) / 2); //PEGA OS TAMANHEOS DE SETA O PONTEIRO
            pictureBox1.Location = PonteiroLogo;

            //AQUI MUDAREMOS OS TAMANNHOS DOS BOTOES PARA SE ADAPTAR A TELA

            BotaoJogar.Size = new Size(Convert.ToInt32(this.Width), BotaoJogar.Height); //AQUI NESTE METODO PASSAMOS POR PARAMETROS O TAMANHO DA TELA Q ELA VAI VIRAR E TMB MANDAMOS O QUE ELE VAI MUDAR
            BotaoRegras.Size = new Size(Convert.ToInt32(this.Width), BotaoRegras.Height);
            BotaoConfiguracao.Size = new Size(Convert.ToInt32(this.Width), BotaoConfiguracao.Height);
            BotaoSair.Size = new Size(Convert.ToInt32(this.Width), BotaoSair.Height);


            Point PonteiroBotaoJogar = new Point( Convert.ToInt32((this.Width - this.BotaoJogar.Width) / 2), Convert.ToInt32(this.Height - (-100)) / 2); //AQUI MUDAMOS P PONTEIRO PARA A POSIÇÃO  QUE QUEREMOS
            Point PonteiroRegras = new Point( Convert.ToInt32((this.Width - this.BotaoRegras.Width ) / 2), Convert.ToInt32(this.Height - (-171)) / 2);
            Point PonteiroConfiguracao = new Point(Convert.ToInt32((this.Width - this.BotaoConfiguracao.Width) / 2), Convert.ToInt32(this.Height - (-242)) / 2 );
            Point PonteiroSair = new Point(Convert.ToInt32((this.Width - this.BotaoSair.Width) / 2), Convert.ToInt32(this.Height - (-313)) / 2);

            //AQUI SETAMOS SUAS POSIÇÕES

            BotaoJogar.Location = PonteiroBotaoJogar;
            BotaoRegras.Location = PonteiroRegras;
            BotaoConfiguracao.Location = PonteiroConfiguracao;
            BotaoSair.Location = PonteiroSair;

            //AQUI IREMOS POSICIONAR O LETREIRO

            Point PonteiroLetreiro = new Point(Convert.ToInt32((this.Width - this.Apresentador.Width) / 2), Convert.ToInt32(this.Height - (this.Apresentador.Height)) / 2);

            //ARUMA LETREIRO NEW

            Point PonteiroNew = new Point( 560 , BotaoConfiguracao.Location.Y - (-4) ); //CRIA PONTEIRO 
            labelLetreiroNew.Location = PonteiroNew; //COLOCA PONTEIRO NA POSIÇÃO 

        }

        private void SetarBorda(Button Entrada, bool ZeroOuUm) //AQUI IREMOS SERA SE A BORDA SERA 0 OU 1
        {
            if (ZeroOuUm) //SE A VARIVEL FOR VERDADEIRA
            {
                Entrada.FlatAppearance.BorderSize = 1; //SETA A BORDA COMO 1 O VOLUME DELA
            }
            else
            {
                Entrada.FlatAppearance.BorderSize = 0; //SENAO SETA ELA COMO 0
            }
        }


        private void BotaoJogar_MouseEnter(object sender, EventArgs e)
        {
            SetarBorda(BotaoJogar, true); //METODO PARA MUDAR A BORDA
        }

        private void BotaoJogar_MouseLeave(object sender, EventArgs e)
        {
            SetarBorda(BotaoJogar, false); //METODO PARA MUDAR A BORDA PARA 0
        }

        private void BotaoSair_MouseEnter(object sender, EventArgs e)
        {
            SetarBorda(BotaoSair, true);
        }

        private void BotaoSair_MouseLeave(object sender, EventArgs e)
        {
            SetarBorda(BotaoSair, false);
        }

        private void BotaoRegras_MouseLeave(object sender, EventArgs e)
        {
            SetarBorda(BotaoRegras, false);
        }

        private void BotaoRegras_MouseEnter(object sender, EventArgs e)
        {
            SetarBorda(BotaoRegras, true);
        }

        private void BotaoConfiguracao_MouseEnter(object sender, EventArgs e)
        {
            SetarBorda(BotaoConfiguracao, true);
        }

        private void BotaoConfiguracao_MouseLeave(object sender, EventArgs e)
        {
            SetarBorda(BotaoConfiguracao, false);
        }

        private void BotaoConfiguracao_Click(object sender, EventArgs e)
        {
            InterfaceConfiguracao AbrirConfiguracoes = new InterfaceConfiguracao(this.ConfigurandoFinal); //IMPLICA A CLASSE DE CONFIGURACOES EM UM OBJETO
            AbrirConfiguracoes.ShowDialog(); //ABRE A INTERFACE
            this.Close(); //FECHA ESTA INTERFACE
        }
    }
}
