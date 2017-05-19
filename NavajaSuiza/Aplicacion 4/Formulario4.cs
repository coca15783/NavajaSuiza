using NavajaSuiza.Aplicacion_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_4  //Namespace aplicación 4
{
    /// <summary>
    /// Clase principal del formulario de la aplicación 4.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Formulario4 : Form
    {
        /// <summary>
        /// Constructor de la clase Formulario 4.
        /// </summary>

        public Formulario4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Función que lanza una excepción si el número es menor que 0 y mayor que 100.
        /// </summary>
        /// <param name="numero"></param>
        static public void rango(int numero)
        {
            if (numero < 0 || numero > 100)
            {
                throw new excepcionRango("Número fuera de rango.");
            }
        }
        ///<summary>
        ///Funcion que muestra la tabla de multiplicar de un número.
        ///</summary>
        private void mostrarTabla()
        {
            int numero;
            string tabla;
            string mensaje;

            bool resultado = Int32.TryParse(tNumero.Text, out numero);

            tabla = tTablaLogica.tabla(numero);

            try
            {
                rango(numero);
                if (String.IsNullOrWhiteSpace((tNumero.Text)))
                {
                    mensaje = "Introduce un número.";
                }
                else
                {
                        if (resultado)
                        {
                            mensaje = tabla;
                        }
                        else
                        {
                            mensaje = "Has introducido un carácter";
                        }
                 }
  
                MessageBox.Show(mensaje);
            }
            catch (excepcionRango ex)
            {
                MessageBox.Show("Número fuera de rango. " + ex.Message);
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
        /// Boton que ejecuta la función tabla y muestra su resultado.
        /// </summary>
        /// <remarks>
        /// El número introducido tiene que estar entre o y 100.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void mostrarTabla(object sender, EventArgs e)
        {
            mostrarTabla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tNumero.MaxLength = 20;    //He limitado la longitud del textBox a 50 carácteres.
        }
    }
}