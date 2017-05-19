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
        /// Función encargada de mostrar los billetes.
        /// </summary>
        private void mostrarBilletes()
        {
            tBilletesLogica Dinero = new tBilletesLogica();

            int dinero;
            string mensaje;

            bool resultado = Int32.TryParse(tDinero.Text, out dinero);

            mensaje = "";
            Dinero.Dinero = dinero;

            // Prueba Caja Blanca

            try
            {
                if (String.IsNullOrWhiteSpace((tDinero.Text)))
                {
                    mensaje = "Introduce un número de pesetas en metalico";
                }
                else
                {
                    if (resultado)
                    {
                        mensaje = Dinero.mostrarDatos();
                    }
                    else
                    {
                        mensaje = "Has introducido un carácter";
                    }
                }

                MessageBox.Show(mensaje);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato no es el correcto:" + ex.Message);
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

        private void mostrarBilletes(object sender, EventArgs e)
        {

            mostrarBilletes();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tDinero.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }
    }
}