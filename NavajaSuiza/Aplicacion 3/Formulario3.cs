using NavajaSuiza.Aplicacion_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_3  //Namespace aplicación 3
{
    /// <summary>
    /// Clase principal del formulario la aplicación 3.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Formulario3 : Form
    {
        /// <summary>
        /// Constructor de la clase Formulario3.
        /// </summary>

        public Formulario3()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Funcion que muestra la potencia de un número.
        ///</summary>
        private void mostrarPotencia()
        {
            int basE;
            int exponente;
            int potencia;
            string mensaje;

            bool resultado1 = Int32.TryParse(tBase.Text, out basE);
            bool resultado2 = Int32.TryParse(tPotencia.Text, out exponente);

            potencia = tPotenciaLogica.potencia(basE, exponente);
            mensaje = "";

            try
            {
                if (String.IsNullOrWhiteSpace((tBase.Text)) || String.IsNullOrWhiteSpace((tPotencia.Text)))
                {
                    mensaje = "Introduce un número.";
                }
                else
                {
                    if (resultado1 && resultado2)
                    {
                        mensaje = potencia.ToString();
                    }

                    if(resultado1 == false && resultado2 == false)
                    {
                        mensaje = "Has introducido un carácter";
                    }

                    if (resultado1 == true && resultado2 == false)
                    {
                        mensaje = "Has introducido un carácter";
                    }

                    if (resultado1 == false && resultado2 == true)
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
        /// Boton que ejecuta la función potencia y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void mostrarPotencia(object sender, EventArgs e)
        {

            mostrarPotencia();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tBase.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tBase.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }
    }
}