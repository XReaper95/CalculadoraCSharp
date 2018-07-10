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

        //string showOnDisplayPrincipal = "";
        //string showOnDisplaySecundario = "";

        #endregion

        #region Métodos

       private void EscribeDisplay(TextBox display,string texto)
        {
           //evita ceros a la izquierda
           if(display.Text == "0") display.Text = "";
           display.Text += texto;
        }

        #endregion

        #region Eventos
        private void BotonNumerico(object sender, EventArgs e)
        {
            //nuevo padron para eventos
            if (sender is Button digito)
            {
                //máximo de 11 digitos,muestra error
                if(displayPrincipal.Text.Length > 10)
                {
                    MessageBox.Show("Máximo de 11 dígitos alcanzados", "Error");
                    return;
                }
                //escribe el número en ambos display 
                EscribeDisplay(displayPrincipal, digito.Text);
                EscribeDisplay(displaySecundario, digito.Text);
            }
        }
        #endregion
    }
}
