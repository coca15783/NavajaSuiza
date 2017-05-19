using NavajaSuiza.Aplicacion_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_2  //Namespace aplicación 2
{
    /// <summary>
    /// Clase principal del formulario de la aplicación 2.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Formulario2 : Form
    {
        /// <summary>
        /// Constructor de la clase Formulario2.
        /// </summary>

        public Formulario2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Función que lanza una excepción si el número es mayor que 15.
        /// </summary>
        /// <param name="numero"></param>
        public void rango(long numero) 
        {
            if(numero>15)
            {
                throw new excepcionRango("Número fuera de rango.");
            }
        }
        ///<summary>
        ///Funcion que muestra el factorial de un número.
        ///</summary>

        private void mostrarFactorial()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            long numero;
            string mensaje;
            long res;

            bool resultado = long.TryParse(tNumero.Text, out numero);
            Factorial.Numero = numero;
            res = Factorial.factorial();


            //Prueba Caja Blanca
            try
            {
                rango(numero);

                if (String.IsNullOrWhiteSpace((tNumero.Text)))
                {
                    mensaje = "Introduce un número.";
                }
                else
                {

                    if (numero >= 0)
                    {
                        if (resultado)
                        {
                            mensaje = res.ToString();
                        }
                        else
                        {
                            mensaje = "Has introducido un carácter.";
                        }
                    }
                    else
                    {
                       mensaje = "Introduce un número positivo.";
                    }
                }
                MessageBox.Show(mensaje);
            }
            catch (excepcionRango ex)
            {
                MessageBox.Show("Número fuera de rango: " + ex.Message);
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
        /// Boton que ejecuta la función factorial y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void mostrarFactorial(object sender, EventArgs e)
        {

            mostrarFactorial();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tNumero.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }
    }
}