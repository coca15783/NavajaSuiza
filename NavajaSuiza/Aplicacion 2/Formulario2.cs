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

//Namespace aplicación 2

namespace NavajaSuiza.Aplicación_2
{
    /// <summary>
    /// Clase principal de la aplicación 2.
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
            tFactorial Factorial = new tFactorial();

            int numero;

            numero = Factorial.Numero;
            

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

       
    }
}
