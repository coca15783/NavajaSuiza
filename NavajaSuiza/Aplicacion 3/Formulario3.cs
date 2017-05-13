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

//Namespace aplicación 3

namespace NavajaSuiza.Aplicación_3
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
            tPotencia Potencia = new tPotencia();

            Potencia.Base = int.Parse(textBox1.Text);
            Potencia.Exponente = int.Parse(textBox2.Text);

            MessageBox.Show(Potencia.mostrarDatos());
        }

        /// <summary>
        /// Boton que ejecuta la función potencia y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {

            mostrarPotencia();
        }

    }
}
