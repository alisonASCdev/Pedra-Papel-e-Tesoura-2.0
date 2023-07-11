using System.Diagnostics.Eventing.Reader;

namespace Pedra__Papel_e_Tesoura_2._0
{
    public partial class Form1 : Form
    {
        private string usuario, maquina;
        private string resultado;
        private int pontosUsuario = 0;
        private int pontosComputador = 0;
        bool fimDeJogo = false;

        private string[] opcoes =  {
      "PEDRA",
      "PAPEL",
      "TESOURA"
    };

        public Form1()
        {
            InitializeComponent();


            // while (fimDeJogo != true)
        }

        private void SelecaoUsuario(string selecao)
        {
            bt_resultado.Text = selecao;
            usuario = selecao;
            escolhaMaquina();

            if (usuario == maquina)
            {
                btm_w.Text = "Empate ";
                btm_w2.Text = "Empate ";
            }
            else if (usuario == "PEDRA" && maquina == "TESOURA")
            {
                pontosUsuario++;
                btm_w.Text = "Ganhou ";
                btm_w2.Text = "Perdeu ";
            }
            else if (usuario == "PAPEL" && maquina == "PEDRA")
            {
                pontosUsuario++;
                btm_w.Text = "Ganhou ";
                btm_w2.Text = "Perdeu ";
            }
            else if (usuario == "TESOURA" && maquina == "PAPEL")
            {
                pontosUsuario++;
                btm_w.Text = "Ganhou ";
                btm_w2.Text = "Perdeu ";
            }
            else
            {
                pontosComputador++;
                btm_w2.Text = "Ganhou ";
                btm_w.Text = "Perdeu";
            }
            btm_resultado1.Text = pontosUsuario.ToString();
            btm_resultado2.Text = pontosComputador.ToString();

        }
        private void escolhaMaquina()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);

            maquina = opcoes[sorteio];

            textBox1.Text = opcoes[sorteio].ToString();


        }

        private void bt_pedra_Click(object sender, EventArgs e)
        {
            int pedra;
            SelecaoUsuario("PEDRA");
        }

        private void bt_papel_Click(object sender, EventArgs e)
        {
            int papel;
            SelecaoUsuario("PAPEL");
        }

        private void bt_tesoura_Click(object sender, EventArgs e)
        {
            int tesoura;
            SelecaoUsuario("TESOURA");
        }


    }
}