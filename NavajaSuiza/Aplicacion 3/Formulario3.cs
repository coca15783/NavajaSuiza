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
    /// Clase principal de la aplicación 3.
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
        
        int potencia (int num, int exp)
        {
            int pot;
            int i;

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
            int Num;
            int Exp; 
            int Resultado;
            
            Num = int.Parse(textBox1.Text);
            Exp = int.Parse(textBox2.Text);

            Resultado = potencia(Num, Exp);

            
            MessageBox.Show(Resultado.ToString());

        }

       

        private void Formulario3_Load(object sender, EventArgs e)
        {

        }

        

        private void Formulario3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
