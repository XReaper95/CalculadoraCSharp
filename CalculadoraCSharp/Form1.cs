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
        private bool limpiaDisplay;
        //estado de error
        private bool estadoError;
        //última operación selecionada
        private string operacionActual;
        //ultimo estado display secundario
        private string ultimoDisplaySecundario;
        //números
        private float? resultado;
        private float? operando1;
        private float? ultimoOperando2;
        private float? operando2;  

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            if (sender is Button digito)
            {
                if (!Error())
                {
                    //si usuario entró operacion, prepara segundo operando
                    if (limpiaDisplay)
                    {
                        Calculadora.BorraDisplay(displayPrincipal);
                        limpiaDisplay = false;
                    }
                    Calculadora.CheckeaMaximoDeDigitos(displayPrincipal);
                    //evita ceros a la izquierda
                    if (displayPrincipal.Text == "0") Calculadora.BorraDisplay(displayPrincipal);
                    //muestra digitación
                    Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
                }
                else
                {
                    Calculadora.BorraDisplay(displayPrincipal);
                    Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
                }
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            if(Error()) return;
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, "0");
        }
        
        private void BotonAllClear_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void BotonOperacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                if (operando1 == null)
                {
                    operando1 = DisplayANumero(displayPrincipal);
                    CambiaOperacion(operacion);
                    ultimoDisplaySecundario = displaySecundario.Text.Substring(0, displaySecundario.Text.Length - 1);
                    limpiaDisplay = true;
                }
                else if (!limpiaDisplay)
                {
                    
                    operando2 = DisplayANumero(displayPrincipal);
                    resultado = Calculadora.Calcula(operacionActual, operando1, operando2);
                    Calculadora.EscribeDisplay(displaySecundario, " " + displayPrincipal.Text + " " + operacion.Text);
                    operacionActual = operacion.Tag.ToString();
                    MuestraResultado(resultado);
                    ultimoDisplaySecundario = displaySecundario.Text.Substring(0, displaySecundario.Text.Length - 1);
                    operando1 = resultado;
                    operando2 = null;
                    limpiaDisplay = true;
                    return;
                }
                else
                {
                    Calculadora.BorraDisplay(displaySecundario);
                    Calculadora.EscribeDisplay(displaySecundario, ultimoDisplaySecundario + operacion.Text);
                    operacionActual = operacion.Tag.ToString();
                    return;
                }
            }
        } //TODO refactorizar

        private void BotonResultadoOperacion_Click(object sender, EventArgs e)
        {
            if(Error()) return;
            if (operando1 == null && !limpiaDisplay) return;
            if (operando2 == null) operando2 = DisplayANumero(displayPrincipal);
            else if(limpiaDisplay) RepiteUltimaOperacion();
            resultado = Calculadora.Calcula(operacionActual, operando1, operando2);
            Calculadora.BorraDisplay(displaySecundario);
            MuestraResultado(resultado);
            operando1 = null;
            ultimoOperando2 = operando2;
            limpiaDisplay = true;
        }//TODO refactorizar

        private void BotonMasMenos_Click(object sender, EventArgs e)
        {
            float? numeroEnDisplay_temp = DisplayANumero(displayPrincipal);
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, Calculadora.CambiaSigno(numeroEnDisplay_temp));
        }

        private void BotonPuntoDecimal_Click(object sender, EventArgs e)
        {
            if(displayPrincipal.Text.Contains(",") && !limpiaDisplay) return;
            if (limpiaDisplay)
            {
                Calculadora.BorraDisplay(displayPrincipal);
                Calculadora.EscribeDisplay(displayPrincipal, "0");
                limpiaDisplay = false;
            }
            Calculadora.EscribeDisplay(displayPrincipal, ",");
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Reseta el estado dela calculadora
        /// </summary>
        private void EstadoInicial()
        {
            limpiaDisplay = false;
            estadoError = false;
            operacionActual = null;
            ultimoDisplaySecundario = "";
            operando1 = null;
            operando2 = null;
            ultimoOperando2 = 0;
            resultado = 0;
            HabilitaComandos();
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.BorraDisplay(displaySecundario);
            Calculadora.EscribeDisplay(displayPrincipal, "0", estadoError);  
        }

        /// <summary>
            /// Muestra el resultado de la operacion en el display principal
            /// </summary>
        private void MuestraResultado(float? resultado)
        {
            //muestra error
            if(resultado == null)
            {
                estadoError = true;
                Calculadora.BorraDisplay(displayPrincipal);
                Calculadora.EscribeDisplay(displayPrincipal, "Imposible dividir por cero",estadoError);
                DeshabilitaComandos();
                return;
            }
            Calculadora.BorraDisplay(displayPrincipal);
            Calculadora.EscribeDisplay(displayPrincipal, resultado.ToString());
        }

        /// <summary>
        /// Tranforma el texto numerico de un display a tipo 'int'
        /// </summary>
        /// <param name="display">Display con numeros a transformar</param>
        /// <returns></returns>
        private float? DisplayANumero(TextBox display)
        {
            return float.Parse(display.Text);
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
        private bool Error()
        {
            if (estadoError)
            {
                EstadoInicial();
                return true;
            }
            return false;
        } 

        /// <summary>
        /// Cambia de operacion, y actualiza display secundario
        /// </summary>
        /// <param name="operacion"></param>
        private void CambiaOperacion(Button operacion)
        {
            ultimoDisplaySecundario = displaySecundario.Text;
            Calculadora.EscribeDisplay(displaySecundario, " " + displayPrincipal.Text + " " + operacion.Text);
            operacionActual = operacion.Tag.ToString();
        }//TODO refactorizar
        
        /// <summary>
        /// Prepara los operandos para repetir la ultima operación, si se toca el botón igual.
        /// </summary>
        private void RepiteUltimaOperacion()
        {
            operando1 = DisplayANumero(displayPrincipal);
            operando2 = ultimoOperando2;
        }

        #endregion
    }
}
