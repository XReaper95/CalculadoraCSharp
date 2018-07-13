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
        /// Muestra el texto en el display
        /// </summary>
        /// <param name="display"></param>
        /// <param name="texto"></param>
        internal static void EscribeDisplay(TextBox display, string texto)
        {
            display.Text += texto;
        } //ok
        /// <summary>
        /// Muestra resultado en el display, formata si exite error
        /// </summary>
        /// <param name="display"></param>
        /// <param name="texto"></param>
        /// <param name="estadoError"></param>
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
        /// Realiza la operacion sobre los operandos
        /// </summary>
        /// <param name="operacionActual"></param>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <returns>Resultado de la operacion</returns>
        internal static int? Calcula(string operacion, int? operando1, int? operando2)
        {
            switch (operacion)
            {
                case "suma":
                    return Suma(operando1, operando2);
                case "resta":
                    return  Resta(operando1, operando2);
                case "multiplica":
                    return Multiplica(operando1, operando2);
                case "divide":
                    return Divide(operando1, operando2);
                default:
                    return null;
            }
        } //ok

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
        /// Realiza la suma de los numeros
        /// </summary>
        /// <param name="sumando1"></param>
        /// <param name="sumando2"></param>
        /// <returns></returns>
        private static int? Suma(int? sumando1, int? sumando2)
        {
            return sumando1 + sumando2;
        } // ok

        /// <summary>
        /// Realiza la resta de los numeros
        /// </summary>
        /// <param name="minuendo"></param>
        /// <param name="sustraendo"></param>
        /// <returns></returns>
        private static int? Resta(int? minuendo, int? sustraendo)
        {
            return minuendo - sustraendo;
        } // ok

        /// <summary>
        /// Realiza la multiplicacion de los numeros
        /// </summary>
        /// <param name="multiplicando"></param>
        /// <param name="multiplicador"></param>
        /// <returns></returns>
        private static int? Multiplica(int? multiplicando, int? multiplicador)
        {
            return multiplicando * multiplicador;
        } //ok

        /// <summary>
        /// Realiza la division correcta de los números
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        private static int? Divide(int? dividendo, int? divisor)
        {
            if (divisor == 0) return null;
            return dividendo / divisor;
        }  //ok

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
        }  //ok

        #endregion
    }
}
