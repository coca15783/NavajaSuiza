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

//Namespace aplicación 4

namespace NavajaSuiza.Aplicación_4
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

        ///<summary>
        ///Funcion que muestra la tabla de multiplicar de un número.
        ///</summary>
        private void mostrarTabla()
        {
            tTabla Tabla = new tTabla();


            Tabla.Numero = int.Parse(textBox1.Text);


            if (Tabla.Numero > 0 && Tabla.Numero <= 100)
            {

                MessageBox.Show(Tabla.mostrarDatos());
            }
            else
            {
                MessageBox.Show("El número no es valido");

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

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarTabla();
        }

    }
}
