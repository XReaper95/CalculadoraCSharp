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

        private static string operacionSelecionada = "";
        private static bool limpia = false;

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
                Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            //limpia la entrada actual del display principal
            displayPrincipal.Text = "";
        }
        
        private void Operacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                //prepara los datos para la operacion segun la solicitada
                numeroEntrada = Calculadora.
                Calculadora.Calcula(operacionSelecionada, numeroEntrada);

                //selecciona operacion y escribe en display secundario
                Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text, operacion.Text);
                operacionSelecionada = operacion.Tag.ToString();
                limpia = true;
                
            }
        }

        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            Calcula(operacionSelecionada, int.Parse(displayPrincipal.Text));
            EscribeDisplay(displayPrincipal, resultado.ToString());
            displaySecundario.Text = "";
        }
       
        #endregion
    }
}
