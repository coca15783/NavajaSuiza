using NavajaSuiza.Aplicacion_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NavajaSuiza.Aplicación_1  //Namespace aplicación 1
{
    /// <summary>
    /// Clase principal del formulario de la aplicación 1.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Formulario1 : Form
    {

        /// <summary>
        /// Constructor de la clase Formulario1.
        /// </summary>

        public Formulario1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función .
        /// </summary>
        private bool limitartextBox()
        {
            bool resultado;

            if (textBox1.MaxLength >= 20)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        /// <summary>
        /// Función encargada de mostrar los billetes.
        /// </summary>
        private void mostrarBilletes()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dinero;
            int x;
            string mensaje;
            bool textLimitado;

            mensaje = "";
            dinero = Dinero.Dinero;
            textLimitado = limitartextBox();

            // Prueba Caja Blanca

            try
            {
                if (textLimitado == true)
                {
                    if (String.IsNullOrWhiteSpace((textBox1.Text)))
                    {
                        mensaje = "Introduce un número de pesetas en metalico";
                    }
                    else
                    {

                        bool resultado = Int32.TryParse(textBox1.Text, out dinero);

                        if (resultado)
                        {
                            mensaje = Dinero.mostrarDatos();
                        }
                        else
                        {
                            mensaje = "Has introducido un carácter";
                        }

                        /*
                        Dinero.Dinero = int.Parse(textBox1.Text);
                        MessageBox.Show(Dinero.mostrarDatos());
                        MessageBox.Show("Has instroducido un carácter");
                        */

                    }

                }
                else
                {
                    mensaje = "No puedes introducir mas de 20 carácteres";
                }

                MessageBox.Show(mensaje);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error:" + ex.Message);
            }

        }

        /// <summary>
        /// Boton que ejecuta la función mostrarBilletes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {

            mostrarBilletes();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }
    }
}