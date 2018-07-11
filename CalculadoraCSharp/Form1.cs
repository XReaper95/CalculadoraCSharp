using System;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form 
    {
        #region Constructor

        //constructor default
        public Form1()
        {
            InitializeComponent();
            EstadoInicial();
        } 

        #endregion

        #region Variables

        private static bool tieneOperacion = false;
        private static string operacionActual = "";

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            //nuevo padron para eventos
            if (sender is Button digito)
            {
                //limpia display si usario presiono tecla de operacion anteriormente
                if (operacionActual != "")
                {
                    Calculadora.BorraDisplay(displayPrincipal);
                }
                Calculadora.CheckeaMaximoDeDigitos(displayPrincipal);

                //evita ceros a la izquierda
                if (displayPrincipal.Text == "0") Calculadora.BorraDisplay(displayPrincipal);
                
                Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            Calculadora.BorraDisplay(displayPrincipal);
        }

        private void botonAllClear_Click(object sender, EventArgs e)
        {
            //reseta todo
            EstadoInicial();
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                operacionActual = operacion.Tag.ToString();
                Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text + " " + operacion.Text);
            }
        }
     
        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            //muestra el resultado de la operacion actual en el display principal
            switch (operacionActual)
            {
                case "suma":
                    if (operacionActual != "") return;
                    operacionActual = operacion.Tag.ToString();
                    Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text + " +");
                    break;

                case "resta":

                case "multiplica":

                case "divide":

                default:
                    break;
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Reseta el estado dela calculadora
        /// </summary>
        private void EstadoInicial()
        {
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.BorraDisplay(displaySecundario);
            tieneOperacion = false;
            operacionActual = "";
            Calculadora.acumulado = 0;
        } 

        #endregion
    }
}
