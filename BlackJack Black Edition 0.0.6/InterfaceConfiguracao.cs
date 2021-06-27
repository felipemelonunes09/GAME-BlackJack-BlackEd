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
    public partial class InterfaceConfiguracao : Form
    {
        private Configurador Interno; //CONFIGURADOR INTERNO DAQUI

        public InterfaceConfiguracao(Configurador Entrada) //CONSTRUTORR ENVIANDO O PROPIO CONFIGURADOR
        {
            this.Interno = Entrada; //PEGA A ENTRADA E IMPLICA NO INTERNO
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
        }


        private void InterfaceConfiguracao_Load(object sender, EventArgs e)
        {
            AjeitarTela();


        }

        //METODO QUE ALINHAS TUDO E COLOCA OS BOTTOES DENTRO DO VETOR

        private void AjeitarTela()
        {

            //AQUI VEM UM MONTE DE PONTEIRO COM CALCULOS COMPLICADOS PARA DEPOIS SETARMOS AS POSIÇÕES

            Point PonteiroLetreiro = new Point(Convert.ToInt32((this.Width - this.labelLetreiroConfiguracoes.Width) / 2), Convert.ToInt32(this.Height - 80) / 2);

            //AQUI SETAMOS AS POSIÇÃO COM OS PONTEIRO 

            this.labelLetreiroConfiguracoes.Location = PonteiroLetreiro;
        }

        //==============================================================
    }
}
