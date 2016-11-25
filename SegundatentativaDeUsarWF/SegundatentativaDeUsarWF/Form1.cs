using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundatentativaDeUsarWF
{
    public partial class Form1 : Form
    {


        Double Total;
        Double UltimoNumero;
        String Operador;


        private void Limpar()
        {

            Total = 0;
            UltimoNumero = 0;
            Operador = "+";
            mtbResultado.Text = "0";

        }

        private void Calcular()
        {
            switch (Operador)
            {
                case "+": Total = Total + UltimoNumero;
                    break;

                case "-": Total = Total + UltimoNumero;
                    break;

                case "x": Total = Total + UltimoNumero;
                    break;

                case "/": Total = Total / UltimoNumero;
                    break;

            }


            UltimoNumero = 0;
            mtbResultado.Text = Total.ToString();
        }
        public Form1()
        {
            InitializeComponent();

            Total = 0;
            UltimoNumero = 0;
            Operador = "+";

        }

        private void BTLimpar_Click(object sender, EventArgs e)
        {

            Limpar();
        }



        private void BTNumero(object sender, EventArgs e)
        {

            if (UltimoNumero == 0)
            {

                mtbResultado.Text = (sender as Button).Text;
            }
            else
            {
                mtbResultado.Text = mtbResultado.Text + (sender as Button).Text; // vai adicionar o numero clicado ao numero anterior, (sender as Button).Text = vai adiconar ao numero anterior o numero que estiver escrito no texto no botao que clicámos
            }
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

        }

        private void BTOperador(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

            Calcular();

            Operador = (sender as Button).Text;
        }

        private void BtIgual_Click(object sender, EventArgs e)
        {
            Calcular();
            Operador = "+";
            Total = 0;
        }
    }
}
