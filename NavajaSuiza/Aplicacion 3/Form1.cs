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
        ///Funcion que calcula la potencia de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>
        ///<param name="num">
        ///Ruta del número a leer.
        ///</param>
        ///<param name="exp">
        ///Ruta del exponente a leer.
        ///</param>
        
        int potencia(int num,int exp)
        {
            int pot,i;

            pot = 0;

            if (exp >= 0)
            {
                for (i = 1; i <= exp; i++)
                {

                    pot = pot + num;
                }
            }
            else
            {
                for (i = -1; i >= exp; i--)
                {
                    pot = pot - num;
                }
            }

            return pot;
        }

        /// <summary>
        /// Boton que ejecuta la función potencia y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void button1_Click(object sender, EventArgs e)
        {
            int num,exp,resultado;
            
            num = int.Parse(textBox1.Text);
            exp = int.Parse(textBox2.Text);

            resultado = potencia(num, exp);

            
            MessageBox.Show(resultado.ToString());

        }
    }
}
