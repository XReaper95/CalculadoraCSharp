using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public static class  Calculadora
    {
        #region Variables

        

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
        /// Escribe en el texto en el display selecionado, evitando ceros a la izquierda.
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        /// <param name="texto1">Texto adicional</param>
        internal static void EscribeDisplay(TextBox display, string texto, string texto1)
        {
            //evita ceros a la izquierda
            display.Text += texto + " " + texto1 + " ";
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
        /// Realiza la operacion seleccionada con el resultado actual
        /// </summary>
        /// <param name="operacionSelecionada">Ultima tecla de operacion seleccionada</param>
        internal static int CalculaResultado(string operacion, int entrada)
        {
            int resultado = 0;

            switch (operacion)
            {
                case "suma":
                    resultado += entrada;
                    return resultado;
                //case "resta":
                //  resultado -= entrada;
                //return resultado;
                //case "multiplicacion":
                //    return resultado;
                //case "division":
                //    return resultado;
                default:
                    return resultado;
            }
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
