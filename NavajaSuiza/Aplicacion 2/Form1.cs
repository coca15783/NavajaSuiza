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
    /// Clase principal de la aplicación.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor de la clase Form1.
        /// </summary>
        
        public Form1()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Funcion que calcula el factorial de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>
        ///<param name="num">
        ///Ruta del número a leer.
        ///</param>

        int factorial(int num)
        {
            int fac = 1;
           
            for (int i = num; i > 0; i--)
            {
               fac = fac * i;
            }

            return fac;
        }
        /// <summary>
        /// Boton que ejecuta la función factorial y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {

            int num;
            int fact;

            //Prueba Caja Blanca

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un número");
            }
            else
            {
                try
                {
                    
                    num = int.Parse(textBox1.Text);
                    fact = factorial(num);
                    if (num > 0)
                    {
                        MessageBox.Show(fact.ToString());
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
    }
}
