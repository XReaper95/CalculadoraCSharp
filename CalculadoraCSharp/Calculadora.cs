﻿using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public static class  Calculadora
    {
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
        /// Realiza la suma del numero en el display con el resultado total
        /// </summary>
        /// <param name="resultado">Resultado total</param>
        /// <param name="displayConOperando">Display con elemento a sumar</param>
        /// <returns></returns>
        internal static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        } // ok

        internal static int Resta(int numero1, int numero2)
        {
            return 0;
        } //TODO implementar

        internal static int Multiplica(int numero1, int numero2)
        {
            return 0;
        } //TODO implementar

        internal static int? Divide(int numero1, int numero2)
        {
            return null;
        } //TODO implementar

        internal static int CambiaSigno(int numero)
        {
            return 0;
        } //TODO implementar

        #endregion
    }
}
