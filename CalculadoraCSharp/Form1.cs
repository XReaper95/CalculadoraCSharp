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

        //proxima digitacion limpia el display principal
        private static bool esperandoOperando = false;
        //boton igual repite la ultima operacion con el ultimo operando
        private static bool repiteUltimaOperacion = false;
        private static string operacionActual = "";
        private static int acumulado = 0;
        private static int operando1 = 0;
        private static int operando2 = 0;
        //operando de la ultima operacion
        private static int ultimoOperando = 0;

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            //nuevo padron para eventos
            if (sender is Button digito)
            {
                //limpia display si usario presiono tecla de operacion anteriormente
                if (esperandoOperando)
                {
                    Calculadora.BorraDisplay(displayPrincipal);
                    esperandoOperando = false;
                }
                Calculadora.CheckeaMaximoDeDigitos(displayPrincipal);

                //evita ceros a la izquierda
                if (displayPrincipal.Text == "0") Calculadora.BorraDisplay(displayPrincipal);
                
                Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
            }
        } //ok
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, "0");
        } //ok
        
        private void BotonAllClear_Click(object sender, EventArgs e)
        {
            //reseta todo
            EstadoInicial();
        } //ok

        private void Operacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                if (!esperandoOperando)
                {
                    repiteUltimaOperacion = false;
                    Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text + " " + operacion.Text);
                    if (operando1 != 0) ProcesaOperacion(operacionActual);
                    operando1 = TextoANumero(displayPrincipal);
                    operacionActual = operacion.Tag.ToString();
                    esperandoOperando = true;
                }
            }
        } //TODO retrabajar

        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            //muestra el resultado de la operacion actual en el display principal
            Calculadora.BorraDisplay(displaySecundario);
            if (operando1 == 0)
            {
                operando1 = acumulado;
                operando2 = ultimoOperando;
                repiteUltimaOperacion = true;
                esperandoOperando = true;
            }
            ProcesaOperacion(operacionActual);         
        } //TODO retrabajar

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Realiza la operacion seleccionada
        /// </summary>
        /// <param name="operacionActual">Operacion seleccionada</param>
        private void ProcesaOperacion(string operacionActual)
        {
            switch (operacionActual)
            {
                case "suma":
                    esperandoOperando = false;
                    if(!repiteUltimaOperacion) operando2 = TextoANumero(displayPrincipal);
                    acumulado = Calculadora.Suma(operando1, operando2);
                    operando1 = 0;
                    ultimoOperando = operando2;
                    MuestraResultado(acumulado);
                    break;

                case "resta":

                case "multiplica":

                case "divide":

                default:
                    break;
            }
        } //TODO implementar resta, multip y div

        /// <summary>
        /// Reseta el estado dela calculadora
        /// </summary>
        private void EstadoInicial()
        {
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.BorraDisplay(displaySecundario);
            Calculadora.EscribeDisplay(displayPrincipal, "0");
            esperandoOperando = false;
            operacionActual = "";
            operando1 = 0;
            operando2 = 0;
            ultimoOperando = 0;
            acumulado = 0;
        } //ok

        /// <summary>
            /// Muestra el resultado de la operacion en el display principal
            /// </summary>
        private void MuestraResultado(int acumulado)
        {
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, acumulado.ToString());
        } //ok

        /// <summary>
        /// Tranforma el texto numerico de un display a tipo 'int'
        /// </summary>
        /// <param name="display">Display con numeros a transformar</param>
        /// <returns></returns>
        private int TextoANumero(TextBox display)
        {
            return int.Parse(display.Text);
        } //ok

        #endregion
    }
}
