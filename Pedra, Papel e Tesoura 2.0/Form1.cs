using System.Diagnostics.Eventing.Reader;

namespace Pedra__Papel_e_Tesoura_2._0
{
    public partial class Form1 : Form
    {
        private string usuario, maquina;
        private string resultado;

        private string[] opcoes =  {
      "PEDRA",
      "PAPEL",
      "TESOURA"
    };

        public Form1()
        {
            InitializeComponent();


            int pontosUsuario = 0;
            int pontosComputador = 0;
            bool fimDeJogo = false;



            //while (fimDeJogo != true)
        }

        private void SelecaoUsuario(string selecao)
        {
            bt_resultado.Text = selecao;
            usuario = selecao;
            escolhaMaquina();

            if (usuario == maquina)
            {

            }
            else if (usuario == "Pedra" && maquina == "Tesoura")
            {

            }
            else if (usuario == "Papel" && maquina == "Pedra")
            {

            }
            else if (usuario == "Tesoura" && maquina == "Papel")
            {

            }

        }
        private void escolhaMaquina()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);

            maquina = opcoes[sorteio];

        }

        private void bt_pedra_Click(object sender, EventArgs e)
        {
            int pedra;
            SelecaoUsuario("Pedra");
        }

        private void bt_papel_Click(object sender, EventArgs e)
        {
            int papel;
            SelecaoUsuario("Papel");
        }

        private void bt_tesoura_Click(object sender, EventArgs e)
        {
            int tesoura;
            SelecaoUsuario("Tesoura");
        }



        private void bt_resultado_TextChanged(object sender, EventArgs e)
        {

        }


    }
}