using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        //constructor default
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables

        private int resultado = 0;
        private string operacionSelecionada = "";
        private bool limpia = false;
        private int ultimoNumero = 0;

        #endregion

        #region Métodos

        /// <summary>
        /// Escribe en el texto en el display selecionado, evitando ceros a la izquierda.
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        private void EscribeDisplay(TextBox display,string texto)
        {
           //evita ceros a la izquierda
           if(display.Text == "0") display.Text = "";
           display.Text += texto;
        }

        /// <summary>
        /// Escribe en el texto en el display selecionado, evitando ceros a la izquierda.
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        /// <param name="texto1">Texto adicional</param>
        private void EscribeDisplay(TextBox display, string texto, string texto1)
        {
            //evita ceros a la izquierda
            if (display.Text == "0") display.Text = "";
            display.Text += texto + " " + texto1 + " ";
        }

        /// <summary>
        /// Realiza la operacion seleccionada con el resultado actual
        /// </summary>
        /// <param name="operacionSelecionada">Ultima tecla de operacion seleccionada</param>
        private void Calcula(string operacionSelecionada)
        {
            switch (operacionSelecionada)
            {
                case "suma":

                    break;
                case "resta":
                    break;
                case "multiplicacion":
                    break;
                case "division":
                    break;
            }
        }

        #endregion

        #region Eventos

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            //nuevo padron para eventos
            if (sender is Button digito)
            {
                //limpia display si usario presiono tecla de operacion anteriormente
                if (limpia)
                {
                    displayPrincipal.Text = "";
                    limpia = false;
                }
                //máximo de 11 digitos,muestra error
                if(displayPrincipal.Text.Length > 10)
                {
                    MessageBox.Show("Máximo de 11 dígitos alcanzados", "Error");
                    return;
                }
                //escribe el número en el display principal
                EscribeDisplay(displayPrincipal, digito.Text);
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            //limpia la entrada actual del display principal
            displayPrincipal.Text = "";
        }
        //TODO terminar
        private void Operacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                //selecciona operacion y escribe en display secundario
                EscribeDisplay(displaySecundario, displayPrincipal.Text, operacion.Text);
                operacionSelecionada = operacion.Tag.ToString();
                limpia = true;
                //prepara los datos para la operacion segun la solicitada
                ultimoNumero =int.Parse(displayPrincipal.Text);
                Calcula(operacionSelecionada);
            }
        }

        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            // EscribeDisplay(displayPrincipal, resultado.ToString());
            //displaySecundario.Text = "";
        }
       
        #endregion
    }
}
