using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public static class  Calculadora
    {
        #region Variables

        public static int acumulado = 0;

        #endregion

        #region Métodos

        /// <summary>
        /// Escribe en el texto en el display selecionado, evitando ceros a la izquierda.
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        internal static void EscribeDisplay(TextBox display, string texto)
        {
            //evita ceros a la izquierda
            display.Text += texto;
        }

        /// <summary>
        /// Borra la salida actual del display
        /// </summary>
        /// <param name="display">Display a ser borrado</param>
        internal static void BorraDisplay(TextBox display)
        {
            display.Text = "";
        }

        /// <summary>
        /// Realiza la suma del numero en el display con el resultado total
        /// </summary>
        /// <param name="acumulado">Resultado total</param>
        /// <param name="displayConOperando">Display con elemento a sumar</param>
        /// <returns></returns>
        internal static void Suma(int acumulado, TextBox displayConOperando)
        {
            acumulado =  acumulado + int.Parse(displayConOperando.Text);
        }

        //TODO implementar
        internal static int Resta(int operando1, int operando2)
        {
            return 0;
        }

        //TODO implementar
        internal static int Multiplica(int operando1, int operando2)
        {
            return 0;
        }

        //TODO implementar
        internal static int? Divide(int operando1, int operando2)
        {
            return null;
        }

        /// <summary>
        /// Muestra error cuando el display sobrepasar los 11 digiros
        /// </summary>
        /// <param name="display">Discpley a chekear</param>
        internal static void CheckeaMaximoDeDigitos(TextBox display)
        {
            if (display.Text.Length > 10)
            {
                MessageBox.Show("Máximo de 11 dígitos alcanzados", "Error");
                return;
            }
        }


    #endregion
}
}
