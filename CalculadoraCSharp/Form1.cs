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
        private static int numeroEntrada = 0;
        private static string operacionActual = "";
        private static string operacionAnterior = "";
        private static int resultado = 0; 

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            
            //nuevo padron para eventos
            if (sender is Button digito)
            {
                //limpia display si usario presiono tecla de operacion anteriormente
                if (tieneOperacion)
                {
                    Calculadora.BorraDisplay(displayPrincipal);
                    tieneOperacion = false;
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
                //prepara los datos segun la operacion solicitada
                numeroEntrada = int.Parse(displayPrincipal.Text);
                resultado = Calculadora.CalculaResultado(operacionActual, numeroEntrada);
                numeroEntrada = 0;

                //selecciona operacion y escribe en display secundario
                Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text, operacion.Text);
                operacionActual = operacion.Tag.ToString();
                operacionAnterior = operacionActual;
                operacionActual = "";
                tieneOperacion = true;
                
            }
        }
     
        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            //muestra el resultado de la operacion actual en el display principal
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, resultado.ToString());
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
            numeroEntrada = 0;
            operacionActual = "";
            operacionAnterior = "";
            resultado = 0;
        } 

        #endregion
    }
}
