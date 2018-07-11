using System;
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
                    Calculadora.BorraDisplay(displayPrincipal);
                    limpia = false;
                }
                Calculadora.CheckeaMaximoDeDigitos(displayPrincipal);
                
                Calculadora.EscribeDisplay(displayPrincipal, digito.Text);
            }
        }
        
        private void BotonClearEntry_Click(object sender, EventArgs e)
        {
            Calculadora.BorraDisplay(displayPrincipal);
        }
        
        private void Operacion_Click(object sender, EventArgs e)
        {
            if (sender is Button operacion)
            {
                //prepara los datos segun la operacion solicitada
                Calculadora.numeroEntrada = int.Parse(displayPrincipal.Text);
                Calculadora.Calcula(Calculadora.operacionSelecionada, Calculadora.numeroEntrada);

                //selecciona operacion y escribe en display secundario
                Calculadora.EscribeDisplay(displaySecundario, displayPrincipal.Text, operacion.Text);
                Calculadora.operacionSelecionada = operacion.Tag.ToString();
                limpia = true;
                
            }
        }
        //TODO implementar boton igual
        private void ResultadoOperacion_Click(object sender, EventArgs e)
        {
            
        }
       
        #endregion
    }
}
