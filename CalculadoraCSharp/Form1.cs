using System;
using System.Drawing;
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
        private bool esperandoOperando = false;
        //boton igual repite la ultima operacion con el ultimo operando
        private bool repiteUltimaOperacion = false;
        //estado de error
        private bool estadoError = false;
        //última operación selecionada
        private string operacionActual = "";
        //ultimo estado display secundario
        private string ultimoDisplaySecundario = "";
        //números
        private int? acumulado = 0;
        private int? operando1 = 0;
        private int? operando2 = 0;
        //operando de la ultima operacion
        private int? ultimoOperando = 0;
        //numero actual en display(para cambio de signo)
        private int? numeroEnDisplay = 0;

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            if (sender is Button digito)
            {
                if(CheckeaError()) return;
                LimpiaDigitacion(esperandoOperando);
                Calculadora.CheckeaMaximoDeDigitos(displayPrincipal);
                //evita ceros a la izquierda
                if (displayPrincipal.Text == "0") Calculadora.BorraDisplay(displayPrincipal);
                operador1 = TextoANumero(displayPrincipal);
                Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            if(CheckeaError()) return;
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, "0");
        }
        
        private void BotonAllClear_Click(object sender, EventArgs e)
        {
            //reseta todo
            EstadoInicial();
        } //ok

        private void BotonOperacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                if (operacionActual != operacion.Tag.ToString())
                {
                    displaySecundario.Text = ultimoDisplaySecundario;
                    Calculadora.EscribeDisplay(displaySecundario, " " + displayPrincipal.Text + " " + operacion.Text);
                    return;
                }
                if (!esperandoOperando)
                {
                    ultimoDisplaySecundario = displaySecundario.Text;
                    repiteUltimaOperacion = false;
                    Calculadora.EscribeDisplay(displaySecundario, " " + displayPrincipal.Text + " " + operacion.Text);
                    if (operando1 != 0) ProcesaOperacion(operacionActual);
                    operando1 = TextoANumero(displayPrincipal);
                    operacionActual = operacion.Tag.ToString();
                    esperandoOperando = true;
                }
            }
        } //ok

        private void BotonResultadoOperacion_Click(object sender, EventArgs e)
        {
            //muestra el resultado de la operacion actual en el display principal
            if(CheckeaError()) return;
            Calculadora.BorraDisplay(displaySecundario);
            if (operando1 == 0)
            {    
                operando1 = acumulado;
                operando2 = ultimoOperando;
                repiteUltimaOperacion = true;
                esperandoOperando = true;
            }
            ProcesaOperacion(operacionActual);         
        } // ok

        private void BotonMasMenos_Click(object sender, EventArgs e)
        {
            numeroEnDisplay = TextoANumero(displayPrincipal);
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, Calculadora.CambiaSigno(numeroEnDisplay));
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Realiza la operacion seleccionada
        /// </summary>
        /// <param name="operacionActual">Operacion seleccionada</param>
        private void ProcesaOperacion(string operacionActual)
        {
            esperandoOperando = false;
            if (!repiteUltimaOperacion) operando2 = TextoANumero(displayPrincipal);
            switch (operacionActual)
            {
                case "suma":
                    acumulado = Calculadora.Suma(operando1, operando2);                    
                    break;
                case "resta":
                    acumulado = Calculadora.Resta(operando1, operando2);
                    break;
                case "multiplica":
                    acumulado = Calculadora.Multiplica(operando1, operando2);
                    break;
                case "divide":
                    acumulado = Calculadora.Divide(operando1, operando2);
                    break;
                default:
                    return;
            }
            operando1 = 0;
            ultimoOperando = operando2;
            MuestraResultado(acumulado);
        }

        /// <summary>
        /// Reseta el estado dela calculadora
        /// </summary>
        private void EstadoInicial()
        {
            esperandoOperando = false;
            repiteUltimaOperacion = false;
            estadoError = false;
            operacionActual = "";
            ultimoDisplaySecundario = "";
            operando1 = 0;
            operando2 = 0;
            acumulado = 0;
            ultimoOperando = 0;
            numeroEnDisplay = 0;
            HabilitaComandos();
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.BorraDisplay(displaySecundario);
            Calculadora.EscribeDisplay(displayPrincipal, "0", estadoError);  
        }

        /// <summary>
            /// Muestra el resultado de la operacion en el display principal
            /// </summary>
        private void MuestraResultado(int? acumulado)
        {
            if(acumulado == null)
            {
                estadoError = true;
                Calculadora.BorraDisplay(displayPrincipal);
                Calculadora.EscribeDisplay(displayPrincipal, "Imposible dividir por cero",estadoError);
                DeshabilitaComandos();
                return;
            }
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, acumulado.ToString());
        }

        /// <summary>
        /// Tranforma el texto numerico de un display a tipo 'int'
        /// </summary>
        /// <param name="display">Display con numeros a transformar</param>
        /// <returns></returns>
        private int? TextoANumero(TextBox display)
        {
            return int.Parse(display.Text);
        }

        /// <summary>
        /// Desabilita comandos criticos cuando error
        /// </summary>
        private void DeshabilitaComandos()
        {
            botonSumar.Enabled = false;
            botonRestar.Enabled = false;
            botonMultiplicar.Enabled = false;
            BotonDividir.Enabled = false;
            botonMasMenos.Enabled = false;
            botonPuntoDecimal.Enabled = false;

            botonSumar.BackColor = Color.DarkGray;
            botonRestar.BackColor = Color.DarkGray;
            botonMultiplicar.BackColor = Color.DarkGray;
            BotonDividir.BackColor = Color.DarkGray;
            botonMasMenos.BackColor = Color.DarkGray;
            botonPuntoDecimal.BackColor = Color.DarkGray;
        }

        /// <summary>
        /// Habilita comandos criticos cuando error fue tratado
        /// </summary>
        private void HabilitaComandos()
        {
            botonSumar.Enabled = true;
            botonRestar.Enabled = true;
            botonMultiplicar.Enabled = true;
            BotonDividir.Enabled = true;
            botonMasMenos.Enabled = true;
            botonPuntoDecimal.Enabled = true;

            botonSumar.BackColor = Color.MistyRose;
            botonRestar.BackColor = Color.MistyRose;
            botonMultiplicar.BackColor = Color.MistyRose;
            BotonDividir.BackColor = Color.MistyRose;
            botonMasMenos.BackColor = Color.MistyRose;
            botonPuntoDecimal.BackColor = Color.MistyRose;
        }

        /// <summary>
        /// reseta el estado de la calculadora luego del error
        /// </summary>
        private bool CheckeaError()
        {
            if (estadoError)
            {
                EstadoInicial();
                return true;
            }
            return false;
        }

        private void LimpiaDigitacion(bool esperandoOperando)
        {
            if (esperandoOperando)
            {
                Calculadora.BorraDisplay(displayPrincipal);
                esperandoOperando = false;
            }
        }

        #endregion       
    }
}
