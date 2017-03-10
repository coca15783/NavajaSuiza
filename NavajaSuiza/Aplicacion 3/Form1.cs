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
        ///<param name="Num">
        ///Ruta del número a leer.
        ///</param>
        ///<param name="Exp">
        ///Ruta del exponente a leer.
        ///</param>
        
        int potencia (int Num, int Exp)
        {
            int Pot;
            int I;

            Pot = 0;

            if (Exp >= 0)
            {
                for (I = 1; I <= Exp; I++)
                {

                    Pot = Pot + Num;
                }
            }
            else
            {
                for (I = -1; I >= Exp; I--)
                {
                    Pot = Pot - Num;
                }
            }

            return Pot;
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
    }
}
