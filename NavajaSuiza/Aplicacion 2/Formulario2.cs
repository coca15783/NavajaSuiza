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

        ///<summary>
        ///Funcion que muestra el factorial de un número.
        ///</summary>

        private void mostrarFactorial()
        {
            tFactorialLogica Factorial = new tFactorialLogica();

            int numero;

            numero = Factorial.Numero;
            textBox1.MaxLength = 50;    //He limitado la longitud del textBox a 50 carácteres.

            //Prueba Caja Blanca

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un número");
            }
            else
            {
                try
                {

                    Factorial.Numero = int.Parse(textBox1.Text);

                    if (numero >= 0)
                    {
                        MessageBox.Show(Factorial.mostrarDatos());
                    }
                    else
                    {
                        MessageBox.Show("Introduce un número positivo");
                    }
                }
                catch
                {
                    MessageBox.Show("Has instroducido un carácter");
                }
            }
        }
        /// <summary>
        /// Boton que ejecuta la función factorial y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {

            mostrarFactorial();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;    //He limitado la longitud del textBox a 20 carácteres.
        }
    }
}