using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public static class  Calculadora
    {
        #region Variables

        private static int resultado = 0;
        private static int numeroEntrada = 0;
        
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
            if (display.Text == "0" || resultado != 0) display.Text = "";
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
            if (display.Text == "0" || resultado != 0) display.Text = "";
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
        internal static void Calcula(string operacionSelecionada, int entradaNumerica)
        {
            switch (operacionSelecionada)
            {
                case "suma":
                    resultado += numeroEntrada;
                    break;
                case "resta":
                    resultado -= numeroEntrada;
                    break;
                case "multiplicacion":
                    break;
                case "division":
                    break;
            }
        }

        

        #endregion
    }
}
