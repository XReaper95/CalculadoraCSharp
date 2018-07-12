using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public static class  Calculadora
    {
        #region Variables privadas

        private static readonly int FUENTE_NUMEROS = 36;
        private static readonly int FUENTE_LETRAS = 16; 

        #endregion

        #region Métodos

        /// <summary>
        /// Escribe en el texto en el display selecionado.
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        internal static void EscribeDisplay(TextBox display, string texto)
        {
            display.Text += texto;
        } //ok

        /// <summary>
        /// Escribe en el texto en el display selecionado.Prepara texto para mensage de error
        /// </summary>
        /// <param name="display">Display a ser usado</param>
        /// <param name="texto">Texto a ser mostrado</param>
        internal static void EscribeDisplay(TextBox display, string texto, bool estadoError)
        {
            CambiaFuente(display, FUENTE_NUMEROS);
            if (estadoError) CambiaFuente(display, FUENTE_LETRAS);
            display.Text += texto;
        } //ok

        /// <summary>
        /// Borra la salida actual del display
        /// </summary>
        /// <param name="display">Display a ser borrado</param>
        internal static void BorraDisplay(TextBox display)
        {
            display.Text = "";
        } //ok

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
        } // ok

        /// <summary>
        /// Realiza la suma de los numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        internal static int? Suma(int? numero1, int? numero2)
        {
            return numero1 + numero2;
        } // ok

        /// <summary>
        /// Realiza la resta de los numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        internal static int? Resta(int? numero1, int? numero2)
        {
            return numero1 - numero2;
        } // ok

        /// <summary>
        /// Realiza la multiplicacion de los numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        internal static int? Multiplica(int? numero1, int? numero2)
        {
            return numero1 * numero2;
        } //ok

        /// <summary>
        /// Realiza la division correcta de los números
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        internal static int? Divide(int? numero1, int? numero2)
        {
            if (numero2 == 0) return null;
            return numero1 / numero2;
        }  //ok

        /// <summary>
        /// Cambia el signo del número diferente de cero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        internal static string CambiaSigno(int? numero)
        {
            if (numero != 0)
            {
                numero = -numero;
                return numero.ToString();
            }
            else return "0";
        } 
        
        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Cambia el tamaño de la fuente del display seleccionado
        /// </summary>
        /// <param name="display"></param>
        /// <param name="tamano"></param>
        private static void CambiaFuente(TextBox display, int tamano)
        {
            display.Font = new System.Drawing.Font(display.Font.FontFamily,tamano);
            display.Anchor = AnchorStyles.Left;
            if(tamano == FUENTE_NUMEROS) display.Anchor = AnchorStyles.Right;
        } 

        #endregion
    }
}
